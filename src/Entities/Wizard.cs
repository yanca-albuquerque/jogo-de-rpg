namespace jogo_de_rpg.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        
        public override string Attack(){
            return this.Name + " Lançou magia!";
            }

        public string Attack(int Bonus){
            if (Bonus > 6){
                 return this.Name + " Lançou magia com espinhos com ataque de " + Bonus;
            }else{
                return this.Name + " Lançou magia com flores com ataque de " + Bonus;
            }
        }
    }
}