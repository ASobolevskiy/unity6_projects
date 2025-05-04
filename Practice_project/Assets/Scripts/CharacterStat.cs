using System;
using Sirenix.OdinInspector;

namespace MvxPractice
{
    public sealed class CharacterStat
    {
        public event Action<int> OnValueChanged; 

        [ShowInInspector]
        public string Name { get; set; }

        [ShowInInspector]
        public int Value { get; set; }

        [Button]
        public void ChangeValue(int value)
        {
            Value = value;
            OnValueChanged?.Invoke(value);
        }
    }
}