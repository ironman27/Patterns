using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.DesignPattern.AbstractFactory
{
    public static class AbstractFactory
    {
        public static void Execute()
        {
            Creator creator1 = new Creator1();
            Client client1 = new Client(creator1);
            
            Console.WriteLine(client1.AbstractProductA.GetType());
            Console.WriteLine(client1.AbstractProductB.GetType());

            Creator creator2 = new Creator2();
            Client client2 = new Client(creator2);

            Console.WriteLine(client2.AbstractProductA.GetType());
            Console.WriteLine(client2.AbstractProductB.GetType());
        }
    }
}
