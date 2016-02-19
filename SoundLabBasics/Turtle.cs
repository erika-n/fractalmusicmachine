using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundLabBasics
{
    public class Turtle
    {
        Point _currentLoc;
        int _currentX;
        int _currentY;

        public Turtle() : this(new Point(0, 0)) { }

        public Turtle(Point p)
        {
            _currentLoc = p;
            _currentX = 1;
            _currentY = 0;
        }

        /// <summary>
        /// F: move forward one hop in the current direction
        /// +: turn right 90 degrees
        /// -: turn left 90 degrees
        /// 
        /// </summary>
        /// <param name="command"></param>
        public void ExecuteCommand(char command)
        {
            if (command == 'F')
            {
                _currentLoc.X += _currentX;
                _currentLoc.Y += _currentY;
            }
            if (command == '+')
            {
                if (IsHorizontal())
                {
                    _currentY = -1 * _currentX;
                    _currentX = 0;
                }
                else
                {
                    _currentX = _currentY;
                    _currentY = 0;
                }
            }
            if (command == '-')
            {
                if (IsHorizontal())
                {
                    _currentY = _currentX;
                    _currentX = 0;
                    
                }
                else
                {
                    _currentX = -_currentY;
                    _currentY = 0;
                }
            }

        }

        public void ExecuteCommand(string command)
        {
            foreach (char c in command.ToCharArray())
            {
                ExecuteCommand(c);
            }
        }

        public Boolean IsHorizontal() 
        { 
            return _currentY == 0; 
        }

        public Point CurrentLocation()
        {
            return _currentLoc;
        }

    }
}
