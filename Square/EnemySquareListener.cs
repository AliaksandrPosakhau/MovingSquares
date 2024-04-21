using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovingSquares
{
    public class EnemySquareListener
    {
        private static int eventCounter = 0;
        private static int amountOfBlackShapes = 0;

        private static void setEventCounter(int value)
        {
            eventCounter = value;
        }
        private static int getEventCounter() { return eventCounter; }
        private static int getAmountOfBlackShapes() { return amountOfBlackShapes; }
        private static void increaseEventCounter()
        {
            Console.WriteLine("Event happened. Red square increased.");

            eventCounter++;
        }
        public static void increaseAmountOfBlackShapes()
        {
            amountOfBlackShapes++;
        }
        public static Boolean trackEventCounter()
        {

            if (getEventCounter() > 4) { 
                setEventCounter(0);
                return true; }

            return false;
        }

        public static Boolean trackBlackShapesSuperiority()
        {
            if (getAmountOfBlackShapes()%3==0)
            {
                return true;
            }
            return false;
        }
        public static void tick()
        {
            increaseEventCounter();
        }

    }
}