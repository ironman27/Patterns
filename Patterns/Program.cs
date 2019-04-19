using Patterns.BehavioralPatterns.ObserverPattern;
using Patterns.DecoratorPattern.Example;
using Patterns.ProxyPattern;
using Patterns.ProxyPattern.RemoteProxies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns.DesignPattern.AbstractFactory;
using Patterns.DesignPattern.FactoryMethod;


namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Observer

            //Stock stock = new Stock();
            //Bank bank = new Bank("ЮнитБанк", stock);
            //Broker broker = new Broker("Иван Иваныч", stock);
            //// имитация торгов
            //stock.Market();
            //// брокер прекращает наблюдать за торгами
            //broker.StopTrade();
            //// имитация торгов
            //stock.Market();

            //Console.Read();

            #endregion Observer

            #region Proxy 

            //Subject subject = new Proxy();
            //subject.Request();

            //using (IBook book = new BookStoreProxy())
            //{
            //    // читаем первую страницу
            //    Page page1 = book.GetPage(1);
            //    Console.WriteLine(page1.Text);
            //    // читаем вторую страницу
            //    Page page2 = book.GetPage(2);
            //    Console.WriteLine(page2.Text);
            //    // возвращаемся на первую страницу    
            //    page1 = book.GetPage(1);
            //    Console.WriteLine(page1.Text);
            //}

            //Console.Read();

            #endregion Proxy

            #region Decorator

            //Pizza pizza1 = new ItalianPizza();
            //pizza1 = new TomatoPizza(pizza1); // итальянская пицца с томатами
            //Console.WriteLine("Название: {0}", pizza1.Name);
            //Console.WriteLine("Цена: {0}", pizza1.GetCost());

            //Pizza pizza2 = new ItalianPizza();
            //pizza2 = new CheesePizza(pizza2);// итальянская пиццы с сыром
            //Console.WriteLine("Название: {0}", pizza2.Name);
            //Console.WriteLine("Цена: {0}", pizza2.GetCost());

            //Pizza pizza3 = new BulgerianPizza();
            //pizza3 = new TomatoPizza(pizza3);
            //pizza3 = new CheesePizza(pizza3);// болгарская пиццы с томатами и сыром
            //Console.WriteLine("Название: {0}", pizza3.Name);
            //Console.WriteLine("Цена: {0}", pizza3.GetCost());

            #endregion Decorator

            #region FactoryMethod

            //FactoryMethod.FactoryMethodPattern();

            #endregion FactoryMethod

            #region AbstractFactory

            AbstractFactory.Execute();

            #endregion AbstractFactory

            Console.ReadLine();
        }
    }
}