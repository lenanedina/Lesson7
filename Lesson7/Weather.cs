using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    class Weather
    {/*

Облачность, осадки, направление ветра, фаза луны должны быть представлены как битовое перечисление:*/

        DateTime date;//дата
        sbyte tMin; //температура минимальная
        sbyte tMax; //температура максимальная
        Dic.Overcast overcast;//облачность
        Dic.Precipitations precipitations;//осадки
        byte humidity;//влажность
        int windForce;//сила ветра
        Dic.Wind windDirection;//направление ветра
        Dic.Moon phaseMoon;//фаза луны

        public DateTime Date { get => date; set => date = value; }
        public sbyte TMin { get => tMin; set => tMin = value; }
        public sbyte TMax { get => tMax; set => tMax = value; }
        internal Dic.Overcast Overcast { get => overcast; set => overcast = value; }
        internal Dic.Precipitations Precipitations { get => precipitations; set => precipitations = value; }
        public byte Humidity { get => humidity; set => humidity = value; }
        public int WindForce { get => windForce; set => windForce = value; }
        internal Dic.Wind WindDirection { get => windDirection; set => windDirection = value; }
        internal Dic.Moon PhaseMoon { get => phaseMoon; set => phaseMoon = value; }

        public Weather(DateTime date, sbyte min, sbyte max, Dic.Overcast overcast, Dic.Precipitations precipitations, byte humidity, int windForce, Dic.Wind windDirection, Dic.Moon phaseMoon)
        {
            Date = date;
            TMin = min;
            TMax = max;
            Overcast = overcast;
            Precipitations = precipitations;
            Humidity = humidity;
            WindForce = windForce;
            WindDirection = windDirection;
            PhaseMoon = phaseMoon;
        }
        public override string ToString()
        {
            string result = 
                $"Дата:                      {Date.ToShortDateString()}\n" +
                $"температура минимальная:   {TMin}\n" +
                $"температура максимальная:  {TMax}\n" +
                $"облачность:                {Overcast}\n" +
                $"осадки:                    {Precipitations}\n" +
                $"влажность:                 {Humidity}\n" +
                $"сила ветра:                {WindForce}\n" +
                $"направление ветра:         {WindDirection}\n" +
                $"фаза луны:                 {PhaseMoon}\n";


            return result;

        }
    }
}
