using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.DesignPattern.AbstractFactory
{
    public abstract class Creator
    {
        public abstract AbstractProductA CreateAbstractProductA();
        public abstract AbstractProductB CreateAbstractProductB();
    }
}
