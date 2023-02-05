using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class MyMath
    {
        public ILogger Logger { get; }
        public MyMath(ILogger logger)
        {
            Logger = logger;
        }
        public void Addition(int x, int y)
        {
            Logger.Event(x,y);
        }
    }
}
