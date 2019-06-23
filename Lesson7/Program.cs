using System;


namespace Lesson7
{
    class Program
    {
       

    static void Main(string[] args)
        {
            Weather weather1 = new Weather(DateTime.Parse("2019.06.18"), 23, 32, Dic.Overcast.Clear, Dic.Precipitations.NotDetermined, 45, 8, Dic.Wind.Southwest, Dic.Moon.Falling);

            Console.WriteLine(weather1); 
            Console.WriteLine();
           

        }
    }
}
