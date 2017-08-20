namespace Text_Rpg
{
    public class Hero
    {
        private int _Health;
        private string _Name;
        private int _Strength;
        private int _Intelligence;
        private int _Dexterity;
        private int _Cunning;
        private int _Endurance;
        private int _Mana;

        public Hero()
        {
            
        }

        public void Standardvalues()
        {
            _Health = _Endurance * 10;
            _Cunning = 10;
            _Dexterity = 10;
            _Intelligence = 10;
            _Strength = 10;
            _Endurance = 10;
            _Mana = _Intelligence * 10;
            _Name = "Hans";
        }

        public int GetStr
        {
            get { return _Strength; }
            set { _Strength = value; }
        }

        public void increaseINT()
        {
            _Intelligence = _Intelligence + 1;
        }
    }
}