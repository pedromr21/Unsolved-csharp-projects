using System;

namespace WeaponShopV10
{
    /// <summary>
    /// This class represents a Wand. A Wand is 
    /// considered to be a weapon.
    /// </summary>
    public class Wand : Weapon
    {
        private bool _isEnchanted = false;
        public const int InitialWandMinDamage = 10;
        public const int InitialWandMaxDamage = 30;

        #region Constructor
        public Wand(string description) 
            : base(description, InitialWandMinDamage, InitialWandMaxDamage)
        {
        }
        #endregion

        #region Properties
        public bool IsEnchanted
        {
            get { return _isEnchanted; }
            set { _isEnchanted = value; }
        }
        #endregion

        #region Methods
         public int DamageFromWand()
         {
             if (IsEnchanted)
             {
                 return CalculateDamage() * 2;
             }
             else
             {
                 return CalculateDamage();
             }
         }
        #endregion
    }
}