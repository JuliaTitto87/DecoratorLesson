using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorLesson
{
    class SquareChair : Chair
    {
        public SquareChair() : base("Square сhair")
        { }

        public override int GetCost()
        {
            return 20;
        }
    }
}
