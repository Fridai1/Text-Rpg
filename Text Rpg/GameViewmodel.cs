namespace Text_Rpg
{
    public class GameViewmodel
    {
        public Human DomainObject;

        public GameViewmodel(Human obj)
        {
            DomainObject = obj;
        }
        
        public int GetStr
        {
            get { return DomainObject.GetStr; }
            set { DomainObject.GetStr = value; }
        }
    }
}