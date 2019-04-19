using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.DesignPattern.FactoryMethod
{
    public class ConcreteCreator2:Creator
    {
        public override Product Create()
        {
            return new ConcreteProduct2();
        }
    }
}
