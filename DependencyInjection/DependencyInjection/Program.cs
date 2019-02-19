using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            Amazon amazon = initalise.amazonInit();
            amazon.AddToBasket();
            amazon.MonthlySub();
            amazon.SaveItem();
            double cost = amazon.Cost;
            Console.WriteLine("Your current monthly amazon cost is " + cost);
            Console.ReadKey();

            Netflix netflix = initalise.netflixInit();
            netflix.WatchContent();
        }
    }

    class initalise
    {
        static public Amazon amazonInit()
        {
            Amazon amazonNew = new Amazon();
            return amazonNew;
        }

        static public Netflix netflixInit()
        {
            Netflix netflixNew = new Netflix();
            return netflixNew;
        }
    }

    interface IOnlineShop
    {
        void BuyItem();

        List<string> SaveItem();

        void AddToBasket();
    }

    interface ISubscription
    {
        void MonthlySub();
    }

    interface IStream
    {
        void WatchContent();
    }

    class Service : ISubscription
    {
        public void MonthlySub()
        {
            Console.WriteLine("You have subscribed"); 
        }
    }

    class Amazon : Service, IOnlineShop
    {
        double _cost = 0;

        public double Cost { get => _cost; set => _cost = value; }

        List<string> products = new List<string>();


        public void MonthlySub()
        {
            _cost += 8.99;
            Console.WriteLine("You have subscribed to prime");
             
        }

        public List<string> SaveItem()
        {
            Console.WriteLine("Please enter a product");
            string newProd = Console.ReadLine();
            products.Add(newProd);
            return products;
        }

        public void BuyItem()
        {

        }

        public void AddToBasket()
        {

        }
    }

    class Netflix : IStream, ISubscription
    {
        double _cost = 0;
        public double Cost { get => _cost; set => _cost = value; }

        public void MonthlySub()
        {
            Console.WriteLine("You have subscribed to Netflix");
            _cost += 5.99;
        }

        public void WatchContent()
        {
            Console.WriteLine("Enter what you want to watch");
            string watch = Console.ReadLine();
            Console.WriteLine("You are now watching " + watch);
        }
    }

}
