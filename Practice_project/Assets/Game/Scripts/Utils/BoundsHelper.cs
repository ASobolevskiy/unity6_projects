using Atomic.Contexts;
using Atomic.Elements;
using Game.Context;
using UnityEngine;

namespace Game.Utils
{
    public sealed class BoundsHelper
    {
        private readonly ReactiveVariable<float> _minX;
        private readonly ReactiveVariable<float> _maxX;
        private readonly ReactiveVariable<float> _minZ;
        private readonly ReactiveVariable<float> _maxZ;

        public BoundsHelper()
        {
            _minX = GameContext.Instance.GetMinimumHorizontal();
            _maxX = GameContext.Instance.GetMaximumHorizontal();
            _minZ = GameContext.Instance.GetMinimumVertical();
            _maxZ = GameContext.Instance.GetMaximumVertical();
        }
        
        public Vector3 EnsureStayInBounds(Vector3 position)
        {
            position.x = Mathf.Clamp(position.x, _minX.Value, _maxX.Value);
            position.z = Mathf.Clamp(position.z, _minZ.Value, _maxZ.Value);
            return position;
        }

        public bool IsInBounds(Vector3 position)
        {
            var xPos = position.x;
            var zPos = position.z;
            return (xPos >= _minX.Value && xPos <= _maxX.Value) && (zPos >= _minZ.Value && zPos <= _maxZ.Value);
        }
    }
}