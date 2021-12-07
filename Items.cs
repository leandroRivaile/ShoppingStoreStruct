namespace ShoppingStore
{
    public class Items
    {
        public string name {get; private set;}
        public int price {get; private set;}
        public Items(string name, int price)
        {
            this.name = name;
            this.price = price;
        }
    }
}
