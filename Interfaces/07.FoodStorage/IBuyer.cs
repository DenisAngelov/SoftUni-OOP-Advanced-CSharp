using System;

namespace _07.FoodStorage
{
    public interface IBuyer
    {
        int Food { get; }

        void BuyFood();
    }
}
