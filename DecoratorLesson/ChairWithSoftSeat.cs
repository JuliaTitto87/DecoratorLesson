using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorLesson
{
    /// <summary>
    ///  ConcreteDecoratorB - обертывает  объект Chair для добавления новой функциональности
    /// </summary>
    class ChairWithSoftSeat : ChairDecorator
    {
        public ChairWithSoftSeat(Chair chair) : base(chair.Name+" with soft seat", chair)
        {
        }

        public override int GetCost()
        {
            return chair.GetCost()+5;
        }
    }
}
