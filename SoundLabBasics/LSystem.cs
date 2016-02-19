using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundLabBasics
{
    public class LSystem
    {

        private string _axiom;
        private LSystemRule[] _rules;

        public LSystem(string axiom, LSystemRule[] rules)
        {
            _axiom = axiom;
            _rules = rules;
        }

        public string StringAtDepth(int depth)
        {
            string returning = _axiom;
            for (int i = 0; i < depth; i++)
            {
                for (int r = 0; r < _rules.Length; r++)
                {
                    returning = Expand(returning, _rules[r].match, _rules[r].sub);
                }
            }
            return returning;
        }



        public static string Expand(string str, char match, string sub)
        {
            string returning = "";
            foreach(char c in str.ToCharArray()){
                if (c == match)
                {
                    returning += sub;
                }
                else
                {
                    returning += c;
                }
            }
            return returning;
        }

        //// Audio stuff

       



    }



}
