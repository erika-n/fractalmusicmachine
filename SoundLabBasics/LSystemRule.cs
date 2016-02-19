using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundLabBasics
{
    public class LSystemRule
    {
        public char match;
        public string sub;
        public LSystemRule(char match, string sub)
        {
            this.match = match;
            this.sub = sub;
        }
    }
}
