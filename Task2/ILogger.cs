using System;

namespace Task2
{
    public interface ILogger
    {
        void Event(int x, int y);
        void Error(Exception ex);

    }
}
