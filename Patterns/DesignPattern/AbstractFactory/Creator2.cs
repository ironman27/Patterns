using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.DesignPattern.AbstractFactory
{
    public class Creator2:Creator
    {
        public override AbstractProductA CreateAbstractProductA()
        {
            return new ProductA2();
        }

        public override AbstractProductB CreateAbstractProductB()
        {
            return new ProductB2();
        }
    }
}
