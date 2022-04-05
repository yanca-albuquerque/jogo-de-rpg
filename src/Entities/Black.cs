namespace jogo_de_rpg.src.Entities
{
    public class Black : Hero
    {
        public Black(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        
        public override string Attack(){
            return this.Name + " Lançou magia negra!";
            }

        public string Attack(int Bonus){
            if (Bonus > 6){
                 return this.Name + " Lançou flechas envenenadas com ataque de " + Bonus;
            }else{
                return this.Name + " Lançou magia com sapo com ataque de " + Bonus;
            }
        }
    }
}
