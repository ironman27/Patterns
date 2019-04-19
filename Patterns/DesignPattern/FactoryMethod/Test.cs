using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.DesignPattern.FactoryMethod
{
    public static class FactoryMethod
    {
        public static void FactoryMethodPattern()
        {
            ConcreteCreator1 creator1 = new ConcreteCreator1();
            Product product1 = creator1.Create();

            ConcreteCreator2 creator2 = new ConcreteCreator2();
            Product product2 = creator2.Create();
        }
    }
}
