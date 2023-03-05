using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Hanoi_Solver
{
    public class Block
    {
        public int size;

        public Block(int size)
        {
            this.size = size;
        }

        public static bool operator >(Block a, Block b)
        {
            return a.size > b.size;
        }

        public static bool operator <(Block a, Block b)
        {
            return a.size < b.size;
        }
    }
}
