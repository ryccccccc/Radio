using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radio
{
    internal class Radio
    {
        public float Volume { get; set; }
        public void AumentaVolume()
        {
            Volume = Volume + (0.1f * Volume);
        }
        public void DiminuisciVolume()
        {
            Volume = Volume - (0.1f * Volume);
        }
    }
}
