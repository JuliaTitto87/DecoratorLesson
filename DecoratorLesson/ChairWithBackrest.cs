using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorLesson
{
    /// <summary>
    ///  ConcreteDecoratorA - обертывает  объект Chair для добавления новой функциональности
    /// </summary>
    class ChairWithBackrest :ChairDecorator
    {
        public ChairWithBackrest(Chair chair) : base(chair.Name+ " with backrest", chair)
        {
        }

        public override int GetCost()
        {
            return chair.GetCost() + 10;
        }
    }
}
