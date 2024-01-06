using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorLesson
{
    internal class RoundChair : Chair
    {
        public RoundChair() : base("Round сhair")
        { }

        public override int GetCost()
        {
            return 30;
        }
    }
}
