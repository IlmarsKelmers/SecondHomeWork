using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdHomeWork
{
    public class Car
    {
        public string Brand { get; set; }
        public string NumberPlate { get; set; }
        public double Speed { get; set; }
        public void StartToDrive()
            {
                Speed = 10;
                Console.WriteLine("Mašīna māk sākt braukt");
            }
            public double GoFaster()
            {
                Speed += 10;
                Console.WriteLine("Palielina ātrumu +" + Speed);
                return Speed;
            }
            public void Beep()
            {
            Console.WriteLine("Mašīna māk arī uztaurēt Beep beep");
            }
            public double SlowDown()
            {
            Speed -= 10;
            Console.WriteLine("Smazina ātrumu - " + Speed);
            return Speed;
            }
            public void Stop()
            {
            Speed = 0;
            Console.WriteLine("Beidz braukt, apstāšanās");
            }
        }
    }

