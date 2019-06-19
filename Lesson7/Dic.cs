using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    class Dic
    {
       public enum Overcast
        {
            NotDetermined,
            Clear,
            PartlyCloudy,
            Cloudy,
            Thunderclouds
        }
        public enum Precipitations
        {
            NotDetermined,
            Rain,
            Snow,
            RainAndSnow,
            Hail,
            SnowPellets,
            Dew,
            Hoarfrost,
            Frost,
            Ice,
            IceNeedles
        }
        public enum Wind
        {
            NotDetermined,
            North,
            Northeast,
            East,
            Southeast,
            South,
            Southwest,
            West,
            Northwest
        }
        public enum Moon
        {
            Undefined,
            NewMoon,
            Growing,
            FullMoon,
            Falling
        }
    }
}
