namespace DIO.src.entities
{
    public class wizard : hero
    {

        public wizard(string name, int level, string herotype)
        {
            this.name = name;
            this.level = level;
            this.herotype = herotype; 
        }

          public override string attack()
        {
            return this.name + "lançou magia";
        }

           public string attack(int bonus)
        {
            if(bonus > 6)
            {
                return this.name + "lançou magia super efetiva com bonus de " + bonus;
            }
            else
            {
                return this.name + "lançou uma magia com força fraca cpm bonus de " + bonus; 
            }

            
        }

    }
}