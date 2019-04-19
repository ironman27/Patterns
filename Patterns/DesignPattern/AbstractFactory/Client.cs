using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.DesignPattern.AbstractFactory
{
    public class Client
    {
        public AbstractProductA AbstractProductA;
        public AbstractProductB AbstractProductB;
        public Client(Creator creator)
        {
            AbstractProductA = creator.CreateAbstractProductA();
            AbstractProductB = creator.CreateAbstractProductB();
        }
    }
}
