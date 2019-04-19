using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.DecoratorPattern.Example
{
    class BulgerianPizza : Pizza
    {
        public BulgerianPizza()
            : base("Болгарская пицца")
        { }
        public override int GetCost()
        {
            return 8;
        }
    }
}
