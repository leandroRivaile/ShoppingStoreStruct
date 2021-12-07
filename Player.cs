using System.Collections.Generic;

namespace ShoppingStore
{
    public class Player
    {
        private string name;
        private int coins;
        public string Name {get => name; set {name = value;}}
        public int Coins {get => coins; set {coins = value;}}
        public List<Items> bagPlayer = new List<Items>();
        public Player(string name, int coins)
        {
            this.name = name;
            this.coins = coins;
        }
    }
}
