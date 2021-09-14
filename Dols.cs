using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekMagazin
{
    class Dols:Product
    {
        public string Material { get; private set; }
        public Dols (string name,int price,string manafucture,string material)
        {
            Name = name;
            Price = price;
            Manafucture = manafucture;
            Material = material;
        }

    }
}
