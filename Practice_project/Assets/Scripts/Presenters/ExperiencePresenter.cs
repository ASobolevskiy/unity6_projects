using MvxPractice.Presenters.Interfaces;
using UniRx;

namespace MvxPractice.Presenters
{
    public sealed class ExperiencePresenter : IExperiencePresenter
    {
        public IReadOnlyReactiveProperty<int> CurrentLevelReactive => _currentLevelReactive;
        public IReadOnlyReactiveProperty<int> CurrentExperienceReactive => _currentExperienceReactive;
        public IReadOnlyReactiveProperty<int> RequiredExperienceReactive => _requiredExperienceReactive;
        public IReadOnlyReactiveProperty<bool> CanLevelUpReactive => _canLevelUp;
        public ReactiveCommand LevelUpCommand { get; private set; }

        private readonly ReactiveProperty<int> _currentLevelReactive = new();
        private readonly ReactiveProperty<int> _currentExperienceReactive = new();
        private readonly ReactiveProperty<int> _requiredExperienceReactive = new();
        private readonly ReactiveProperty<bool> _canLevelUp = new();

        private readonly PlayerLevel _playerLevelInfo;
        private CompositeDisposable _subscriptions;

        public ExperiencePresenter(PlayerLevel playerLevelInfo)
        {
            _playerLevelInfo = playerLevelInfo;
            Init();
        }

        private void Init()
        {
            _currentLevelReactive.Value = _playerLevelInfo.CurrentLevel;
            
            _currentExperienceReactive.Value = _playerLevelInfo.CurrentExperience;
            _playerLevelInfo.OnExperienceChanged += HandleExperienceChanged;

            _requiredExperienceReactive.Value = _playerLevelInfo.RequiredExperience;
            _canLevelUp.Value = _playerLevelInfo.CanLevelUp();
            
            _playerLevelInfo.OnLevelUp += HandleLevelUp;
            _subscriptions = new CompositeDisposable();
            LevelUpCommand = new ReactiveCommand(CanLevelUpReactive);
            LevelUpCommand.Subscribe(OnLevelUpCommand).AddTo(_subscriptions);
        }

        private void HandleLevelUp()
        {
            _currentLevelReactive.Value = _playerLevelInfo.CurrentLevel;
            _currentExperienceReactive.Value = _playerLevelInfo.CurrentExperience;
            _requiredExperienceReactive.Value = _playerLevelInfo.RequiredExperience;
            _canLevelUp.Value = _playerLevelInfo.CanLevelUp();
        }

        private void HandleExperienceChanged(int obj)
        {
            _currentExperienceReactive.Value = obj;
            _canLevelUp.Value = _playerLevelInfo.CanLevelUp();
        }

        private void OnLevelUpCommand(Unit _)
        {
            LevelUp();
        }

        private void LevelUp() => _playerLevelInfo.LevelUp();

        ~ExperiencePresenter()
        {
            _playerLevelInfo.OnExperienceChanged -= HandleExperienceChanged;
            _playerLevelInfo.OnLevelUp -= HandleLevelUp;
            _subscriptions.Dispose();
        }
    }
}