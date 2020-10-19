using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoppingcart
{
    class Program
    {
        static void Main(string[] args)
        {
            static double cost (List<string> shoppingCart)
            {
                double Cost = 0;
                foreach (string s in shoppingCart)
                {
                    if(s.ToUpper()=="ORANGE")
                    {
                        Cost = Cost + 0.25;
                    }
                    if(s.ToUpper()=="APPLE")
                    {
                        Cost = Cost + 0.60;
                    }
                }
                return Cost;
            }



            List<string> liste = new List<string>();
            liste.Add("orange");
            liste.Add("orange");
            liste.Add("apple");
            liste.Add("apple");
            Console.WriteLine("the shopping cart cost " + cost(liste));
            Console.ReadLine();

        }
    }
}
