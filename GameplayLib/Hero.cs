using System.Collections.Generic;

namespace GameplayLib
{
    /// <summary>
    ///  ####### Герой, которого мы заслуживаем ########
    /// </summary>
    public class Hero
    {
        //-------------------------------Различные свойства
        /// <summary>
        /// У героя есть имя.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Герой принадлежит какому-то типу.
        /// </summary>
        public int Type { get; set; }
        /// <summary>
        /// Характеристика персонажа.
        /// </summary>
        public double BaseStr { get; set; }
        public double BaseAgi { get; set; }
        public double BaseInt { get; set; }
        public double MoveSpeed { get; set; }
        public double BaseArmor { get; set; }
        public double MinDmg { get; set; }
        public double Regeneration { get; set; }

        private double health;
        public double Health
        {
            get => health;
            set => health = value > maxHealth ? maxHealth : value;
        }
        public readonly double maxHealth;

        /// <summary>
        /// Герой, которого мы заслуживаем.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="baseStr"></param>
        /// <param name="baseAgi"></param>
        /// <param name="baseInt"></param>
        /// <param name="moveSpeed"></param>
        /// <param name="baseArmor"></param>
        /// <param name="minDmg"></param>
        /// <param name="regeneration"></param>
        public Hero(string name,
            int type,
            double baseStr,
            double baseAgi,
            double baseInt,
            double moveSpeed,
            double baseArmor,
            double minDmg,
            double regeneration)
        {
            Name = name;
            Type = type;
            BaseStr = baseStr;
            BaseAgi = baseAgi;
            BaseInt = baseInt;
            MoveSpeed = moveSpeed;
            BaseArmor = baseArmor;
            MinDmg = minDmg;
            Regeneration = regeneration;
            maxHealth = baseStr * 29;
            health = maxHealth;
        }
    }
}
