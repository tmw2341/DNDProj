using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDApp.Objects
{
    class Dice
    {
        int sides;
        int number;
        int mod;
        //Random Rand;

        public Dice(int sides, int number)
        {
            this.sides = sides;
            this.number = number;
        }

        public int GetSides()
        {
            return this.sides;
        }

        public void SetSides(int newS)
        {
            this.sides = newS;
        }

        public int GetNumber()
        {
            return this.number;
        }
        
        public void SetNumber(int newN)
        {
            this.number = newN;
        }

        public int RollDice(){
            Random rand = new Random(DateTime.Now.Millisecond + DateTime.Now.Second);
             // This should implement a random seed - ie System.Time.GetMilis();
            int sum = 0;
            for (int i = 0; i< this.number; i++){
                sum += rand.Next(1, sides);
            }
            sum += this.mod;
            return sum;
        }
    }
}
