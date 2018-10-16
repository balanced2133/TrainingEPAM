﻿namespace Task4
{
    sealed internal class Cherry : Bonus
    {
        public Cherry(int positionX, int positionY) : 
            base(positionX, positionY)
        {

        }

        internal double GetIncreasedMoveSpeed(Player player) => player.MoveSpeed += 1;
    }
}
