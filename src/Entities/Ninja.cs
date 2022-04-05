namespace jogo_de_rpg.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        
        public override string Attack(){
            return this.Name + " Deu um golpe!";
            }

        public string Attack(int Bonus){
            if (Bonus > 6){
                 return this.Name + " Socou e chutou com ataque de " + Bonus;
            }else{
                return this.Name + " Deu um soco com ataque de " + Bonus;
            }
        }
    }
}