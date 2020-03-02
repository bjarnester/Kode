using System;
using System.Collections.Generic;
using static System.Console;

namespace Person

{
    public class Personen : IComparable<Personen>
    {
        public string Name;
        public DateTime DateOfBirth;
        public List<Personen> Children = new List<Personen>();

        public void WriteToConsole()
        {

            WriteLine($"{Name} was born on a {DateOfBirth:dddd}.");

        }

        public static Personen ProCreate(Personen p1, Personen p2)
        {

            var baby = new Personen
            {
                Name = $"Baby of {p1.Name} and {p2.Name}."
            };
            p1.Children.Add(baby);
            p2.Children.Add(baby);
            return baby;

        }

        public Personen ProCreateWith(Personen partner)
        {

            return ProCreate(this, partner);

        }

        public static int Factorial(int number)
        {

            if (number < 0)
            {

                throw new ArgumentException($"{nameof(number)} cannot be less than zero.");


            }

            return localFactorial(number);



            int localFactorial(int localNumber)
            {

                if (localNumber < 1)
                {
                    return 1;
                }
                return localNumber * localFactorial(localNumber - 1);

            }
        }

        public int CompareTo(Personen other)
        {
            return Name.CompareTo(other.Name);
        }
    }
}
