using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdHomeWork
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public string Hobby { get; set; }
        public bool Gender { get; set; }

        public int GetAge()
        {
            return DateTime.Now.Year - BirthDate.Year;
        }
        static void Main(string[] args)
        {
            char gender;

            //Reading gender from user
             Console.WriteLine("Enter gender (M/m or F/f): ");
            gender = Convert.ToChar(Console.ReadLine());


            // checking vowel and consonant
            switch (gender)
                {
                case 'M':
                case 'm':
                Console.WriteLine("MALE");
                break;

                case 'F':
                case 'f':
                Console.WriteLine("FEMALE");
                break;

                default:
                Console.WriteLine("Unspecified Gender");
                break;
                }

                Console.ReadLine();

            }

        }
    }

