using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundLabBasics
{
    public class Point
    {
        int _x, _y;
        public int X { get { return _x; } set { _x = value;  } }
        public int Y { get { return _y; } set { _y = value;  } }

        public Point(int x, int y)
        {
            _x = x;
            _y = y;
        }
    }
}
