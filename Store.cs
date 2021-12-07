using System;
using System.Collections.Generic;
namespace ShoppingStore
{
    public class Store
    {
        public List<Items> ItemsShop = new List<Items>();
        public void AddItemsInNpcStore()
        {
            Items abacaxi = new Items("Abacaxi", 2);
            Items morango = new Items("Morango", 1);
            Items paoDeQueijo = new Items("Pão de Queijo", 3);
            this.ItemsShop.Add(abacaxi);
            this.ItemsShop.Add(morango);
            this.ItemsShop.Add(paoDeQueijo);
        }

        public int LowestPriceItemStore()
        {
            int lowestPrice = 0;
            for(int i =0; i < ItemsShop.Count; i++)
            {
                if(i == 0)
                {
                    lowestPrice = ItemsShop[0].price;
                }
                else if(ItemsShop[i].price < lowestPrice)
                {
                    lowestPrice = ItemsShop[i].price;
                }
            }
            return lowestPrice;
        }
        public void CanYouBuyThisItem(Player player, int indexItem)
        {
            if(indexItem > ItemsShop.Count)
            {
                Console.WriteLine("Item not found!");
                Console.ReadKey();
                return;
            }
            if(player.Coins < ItemsShop[indexItem].price)
            {
                Console.WriteLine("you dont have sufficient money for this");
                Console.ReadKey();
                return;
            }

            player.bagPlayer.Add(ItemsShop[indexItem]);
            player.Coins -= ItemsShop[indexItem].price;

            Console.WriteLine($"You buy {ItemsShop[indexItem].name} for the price U$: {ItemsShop[indexItem].price}");
            Console.WriteLine($"You have total of money U$: {player.Coins}");
            Console.ReadKey();
        }
    }

}