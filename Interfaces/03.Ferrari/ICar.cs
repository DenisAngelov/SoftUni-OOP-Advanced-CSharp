using System;

namespace _03.Ferrari
{
    public interface ICar
    {
        string Driver { get; }
        string Model { get; }

        string Stop();
        string Start();
    }
}
