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

        }
    }

    class initalise
    {
        static public void amazonInit()
        {
            Amazon amazon = new Amazon();
        }
    }

    interface IOnlineShop
    {
        void BuyItem();

        void SaveItem();

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
        public void MonthlySub()
        {
            Console.WriteLine("You have subscribed to prime");
        }

        public void BuyItem()
        {
            Console.WriteLine("");
        }

        public void SaveItem()
        {

        }

        public void AddToBasket()
        {

        }
    }
}
