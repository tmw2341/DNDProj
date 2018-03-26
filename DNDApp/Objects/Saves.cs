using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDApp.Objects
{
    class Saves
    {
        Save saves;
        int[] saveValues;

        public int GetSave(Save s)
        {
            return saveValues[(int)s];
        }

        public void SetSave(Save s, int x)
        {
            saveValues[(int)s] = x;
        }
    }
}
