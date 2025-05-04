using System;
using UnityEngine;

namespace MvxPractice.Data
{
    [Serializable]
    public sealed class StatDataObject
    {
        [SerializeField]
        private string statName;

        [SerializeField]
        private int statValue;

        public string StatName => statName;
        public int StatValue => statValue;
    }

    public static class StatExtentions
    {
        public static CharacterStat ToCharacterStat(this StatDataObject so)
        {
            var charStat = new CharacterStat()
            {
                Name = so.StatName,
                Value = so.StatValue
            };
            return charStat;
        }
    }
}