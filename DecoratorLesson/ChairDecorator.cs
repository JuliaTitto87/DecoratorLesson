using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorLesson
{
    /// <summary>
    /// Decorator декорирует объект Chair
    /// </summary>
    abstract class ChairDecorator:Chair
    {
            protected Chair chair;
            public ChairDecorator(string n, Chair chair) : base(n)
            {
            this.chair = chair;
            }
        }
    }

