using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BicycleDash
{
    interface IObserver
    {
        void Update(int data);
        void Display();
    }
}
