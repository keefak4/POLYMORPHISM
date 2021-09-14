using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekMagazin
{
    class Manga:Product
    {
        public int Pages { get; private set; }
        public Manga(string name,int price,string manafucture,int pages)
        {
            Name = name;
            Price = price;
            Manafucture = manafucture;
            Pages = pages;
        }
    }
}
