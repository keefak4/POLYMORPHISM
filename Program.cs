using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekMagazin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is you name?");
            string _Names =
                 Convert.ToString(Console.ReadLine());
            Console.WriteLine("Helloy {0}", _Names);
            
            Console.WriteLine("How much money do you have");
            int _price =
                 Convert.ToInt32(Console.ReadLine());
            User user = new User(_Names, "Xolzynova 12", _price, 250
                );
            Console.WriteLine("Whant do you want to buy?" +
                "List products:");
                
            //Prodyct
            
            Cosplay cosplay = new Cosplay(
                    "Sakyra",452,"anime","xxl"
                    );
            Console.WriteLine("Dols");
            Console.WriteLine("Name{0} price{1} manafucture {2} size {3}", cosplay.Name, cosplay.Price, cosplay.Manafucture, cosplay.Size);
           
            
            Manga manga = new Manga("Aot",450,"Akiba",123
                );
            Console.WriteLine("Manga");
            Console.WriteLine("Name{0} price{1} manafucture {2} pages {3}", manga.Name, manga.Price, manga.Manafucture, manga.Pages);

            Dols dols = new Dols("Naruti",750,"Akiba","PVX"
                );
            Console.WriteLine("Dols");
            Console.WriteLine("Name{0} price{1} manafucture {2} material {3}", dols.Name, dols.Price, dols.Manafucture, dols.Material);
            
            
            
            Product[] products = new Product[]
            {
                cosplay,
                manga,
                dols
            };

            Informator informator = new Informator();

            while(true)
            {
                Console.WriteLine($"Heloy{user.Name} your balance{user.Balamce}");
                for(int i = 0;i < products.Length;i++)
                {
                    Console.WriteLine($"Prodyct {i} {products[i].Name} to price {products[i].Price}");
                }
                Console.WriteLine("Select index product");
                string str = Console.ReadLine();
                int productNumber = Convert.ToInt32(str);
                if (productNumber >= 0 && productNumber < products.Length)
                {
                    if(products[productNumber].Price < user.Balamce)
                    {
                        informator.Buy(user, products[productNumber]);
                    }
                    else
                    {
                        Console.WriteLine("No money");
                    }
                }
                else
                {
                    Console.WriteLine("No prodyct");
                }
            }

        }
    }
}
