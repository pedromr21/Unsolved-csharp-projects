using System;

namespace RolePlayV12
{
    public class Warrior
    {
        #region Instance fields
        private string _name;
        private int _hitPoints;
        private Sword _sword1;
        private Sword _sword2;
        #endregion

        #region Constructor
        public Warrior(string name, int hitPoints, Sword sword1)
        {
            _name = name;
            _hitPoints = hitPoints;
            _sword1 = sword1;
            
        }
        #endregion

        #region Properties
        public string Name
        {
            get { return _name; }
        }

        public Sword Sword1
        {
            get { return _sword1; }
        }
        public Sword Sword2
        {
            get { return _sword2; }
        }


        public int HitPoints
        {
            get { return _hitPoints; }
        }

        public bool Dead
        {
            get { return _hitPoints <= 0; }
        }
        #endregion

        #region Methods
        public void ReceiveDamage(int points)
        {
            _hitPoints = _hitPoints - points;
        }

        public int DealDamage()
        {
            return _sword1.DealDamage();
        }

        public string GetInfo()
        {
            return $"{Name} has {HitPoints} hit points ({(Dead ? "dead" : "alive")})";
        }
        #endregion
    }
}