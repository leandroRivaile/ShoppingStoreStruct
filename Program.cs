using System;
using System.Collections.Generic;

namespace ShoppingStore
{
    class Program
    {
        static void Main(string[] args)
        {
            LoopShopping();
        }
        static void LoopShopping()
        {
            Store npcStore = new Store();
            Player player1 = new Player("Leandro", 5);
            npcStore.AddItemsInNpcStore();
            do
            {
                int number = AnwserPlayerInputCanonized(npcStore.ItemsShop);
                npcStore.CanYouBuyThisItem(player1, number);
                Console.Clear();
            }
            while(player1.Coins >= npcStore.LowestPriceItemStore());
            ShowBagItems(player1);
            Console.ReadKey();
        }
        static void ShowBagItems(Player playerPara)
        {
            Console.WriteLine("You buyed all of these items: ");
            Console.WriteLine("===============================================");
            for(int c = 0; c < playerPara.bagPlayer.Count; c++)
            {
                Console.WriteLine($"[{c+1}] -> " + playerPara.bagPlayer[c].name);   
            }
            Console.WriteLine("===============================================");
            Console.WriteLine("Press any key to exit. ");
        }
        static int ReadNumber(string message)
        {
            Console.WriteLine(message);
            string inputUser = Console.ReadLine();
            int number;
            if(int.TryParse(inputUser, out number))
            {
                return number;
            }
            return -1;
        }
        static int AnwserPlayerInputCanonized(List<Items> itemsShopToBuy)
        {
            int playerAlternative = 0;
            PrintItemsList(itemsShopToBuy);
            do
            {
                playerAlternative = ReadNumber("Alternative: ");
            }
            while(playerAlternative <= 0 || playerAlternative > itemsShopToBuy.Count);
            return --playerAlternative;
        }
        static void PrintItemsList(List<Items> listItems)
        {
            for(int i = 0; i < listItems.Count ; i++)
            {
                Console.WriteLine($"Name Item -> {listItems[i].name}");
                Console.WriteLine($"Price Item -> {listItems[i].price}");
                Console.WriteLine($"Index to buy this item: {i+1}");
                Console.WriteLine("==================================================");
            }
        }

    }
}
