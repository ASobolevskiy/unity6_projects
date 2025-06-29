using System;
using Atomic.Elements;
using Atomic.Entities;
using Game.Core.Behaviours;
using UnityEngine;

namespace Game.Core.Installers
{
    [Serializable]
    public sealed class RotationInstaller : IEntityInstaller
    {
        [SerializeField]
        private Quaternion _rotation;
        
        public void Install(IEntity entity)
        {
            entity.SetRotation(_rotation);
            entity.SetCanRotate(new AndExpression());

            entity.AddBehaviour(new RotationBehaviour());
        }
    }
}