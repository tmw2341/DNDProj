using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDApp.Objects
{
    class Sizes
    {
        public int GetModifier(Size size)
        {
            switch (size)
            {
                case Size.Fine:
                    return 8;
                case Size.Diminuitive:
                    return 4;
                case Size.Tiny:
                    return 2;
                case Size.Small:
                    return 1;
                case Size.Medium:
                    return 0;
                case Size.Large_Tall:
                    return -1;
                case Size.Large_Long:
                    return -1;
                case Size.Huge_Tall:
                    return -2;
                case Size.Huge_Long:
                    return -2;
                case Size.Gargantuan_Tall:
                    return -4;
                case Size.Gargantuan_Long:
                    return -4;
                case Size.Colossal_Tall:
                    return -8;
                case Size.Colossal_Long:
                    return -8;
                default:
                    return 0;
            }
        }

        public int GetSpecModifier(Size size)
        {
            switch (size)
            {
                case Size.Fine:
                    return -8;
                case Size.Diminuitive:
                    return -4;
                case Size.Tiny:
                    return -2;
                case Size.Small:
                    return -1;
                case Size.Medium:
                    return 0;
                case Size.Large_Tall:
                    return 1;
                case Size.Large_Long:
                    return 1;
                case Size.Huge_Tall:
                    return 2;
                case Size.Huge_Long:
                    return 2;
                case Size.Gargantuan_Tall:
                    return 4;
                case Size.Gargantuan_Long:
                    return 4;
                case Size.Colossal_Tall:
                    return 8;
                case Size.Colossal_Long:
                    return 8;
                default:
                    return 0;
            }
        }

        public int GetFly(Size size)
        {
            switch (size)
            {
                case Size.Fine:
                    return 8;
                case Size.Diminuitive:
                    return 6;
                case Size.Tiny:
                    return 4;
                case Size.Small:
                    return 2;
                case Size.Medium:
                    return 0;
                case Size.Large_Tall:
                    return -2;
                case Size.Large_Long:
                    return -2;
                case Size.Huge_Tall:
                    return -4;
                case Size.Huge_Long:
                    return -4;
                case Size.Gargantuan_Tall:
                    return -6;
                case Size.Gargantuan_Long:
                    return -6;
                case Size.Colossal_Tall:
                    return -8;
                case Size.Colossal_Long:
                    return -8;
                default:
                    return 0;
            }
        }

        public int GetStealth(Size size)
        {
            switch (size)
            {
                case Size.Fine:
                    return 16;
                case Size.Diminuitive:
                    return 12;
                case Size.Tiny:
                    return 8;
                case Size.Small:
                    return 4;
                case Size.Medium:
                    return 0;
                case Size.Large_Tall:
                    return -4;
                case Size.Large_Long:
                    return -4;
                case Size.Huge_Tall:
                    return -8;
                case Size.Huge_Long:
                    return -8;
                case Size.Gargantuan_Tall:
                    return -12;
                case Size.Gargantuan_Long:
                    return -12;
                case Size.Colossal_Tall:
                    return -16;
                case Size.Colossal_Long:
                    return -16;
                default:
                    return 0;
            }
        }

        public double GetSpace(Size size)
        {
            switch (size)
            {
                case Size.Fine:
                    return .5;
                case Size.Diminuitive:
                    return 1;
                case Size.Tiny:
                    return 2.5;
                case Size.Small:
                    return 5;
                case Size.Medium:
                    return 5;
                case Size.Large_Tall:
                    return 10;
                case Size.Large_Long:
                    return 10;
                case Size.Huge_Tall:
                    return 15;
                case Size.Huge_Long:
                    return 15;
                case Size.Gargantuan_Tall:
                    return 20;
                case Size.Gargantuan_Long:
                    return 20;
                case Size.Colossal_Tall:
                    return 30;
                case Size.Colossal_Long:
                    return 30;
                default:
                    return 5;
            }
        }

        public int GetNatReach(Size size)
        {
            switch (size)
            {
                case Size.Fine:
                    return 0;
                case Size.Diminuitive:
                    return 0;
                case Size.Tiny:
                    return 0;
                case Size.Small:
                    return 5;
                case Size.Medium:
                    return 5;
                case Size.Large_Tall:
                    return 10;
                case Size.Large_Long:
                    return 5;
                case Size.Huge_Tall:
                    return 15;
                case Size.Huge_Long:
                    return 10;
                case Size.Gargantuan_Tall:
                    return 20;
                case Size.Gargantuan_Long:
                    return 15;
                case Size.Colossal_Tall:
                    return 30;
                case Size.Colossal_Long:
                    return 20;
                default:
                    return 5;
            }
        }
    }
}
