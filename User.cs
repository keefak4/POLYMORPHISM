using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekMagazin
{
    class User
    {
        public string Name { get; private set; }
        public string Adress { get; private set; }
        public double Balamce { get; private set; }
        public double Spent { get; private set; }
        public User(string name,string adress,int balance,int spent)
        {
            Name = name;
            Adress = adress;
            Balamce = balance;
            Spent = spent;
        }
        public void ReduceBalance(double price)
        {
            Balamce -= price;
            Spent += price;
        }
    }
}
