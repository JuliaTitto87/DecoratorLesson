using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorLesson
{
    /// <summary>
    /// Класс Chair вытупает как Component - абстрактный класс, который
    /// определяет интерфейс для наследуемых объектов
    /// </summary>
    abstract class Chair
        {
            public Chair(string n)
            {
                this.Name = n;
            }
            public string Name { get; protected set; }
            public abstract int GetCost();
        }
}

