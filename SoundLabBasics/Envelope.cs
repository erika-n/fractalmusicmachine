using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundLabBasics
{
    public class Envelope
    {
        int _attack;
        int _decay;
        double _dx = 0;
        double _ddx = 0.0001;
        double _numSamples;
        double _amp;
        int _sample;


        public Envelope(int attack = 100, int decay = 100)
        {
            _attack = attack;
            _decay = decay;
            _ddx = 4.0 / (attack*attack);
            _sample = 0;
            _numSamples = 0;
        }

        public void Start(int numSamples)
        {
            _numSamples = numSamples;
            _sample = 0;
            _amp = 0;
            _dx = 0;
        }

        public double NextAmpFactor()
        {
            if (_sample <= _attack / 2)
            {
                _dx += _ddx;
                _amp += _dx;
            }
            else if (_sample <= _attack)
            {
                _dx -= _ddx;
                _amp += _dx;
            }
            
            else if (_numSamples - _sample <= _decay/2) 
            {
                _dx -= _ddx;
                _amp -= _dx;
            }
            else if (_numSamples - _sample <= _decay)
            {
                _dx += _ddx;
                _amp -= _dx;
            }

            _sample++;
            return _amp;
        }

    }
}
