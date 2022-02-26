namespace DIO.src.entities
{
    public abstract class hero
    {
        public hero(string name, int level, string herotype)
        {
            this.name = name;
            this.level = level;
            this.herotype = herotype; 
        
        }
        public hero(){
            
        }

        
        public string name; 
        public int level;
        public string herotype;

        public override string ToString()
        {
            return this.name + " " + this.level + " " + this.herotype;
        }
        public virtual string attack()
        {
            return this.name + "atacou com sua espada";
        }

    }
}