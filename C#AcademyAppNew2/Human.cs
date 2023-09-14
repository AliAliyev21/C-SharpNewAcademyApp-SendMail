using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_AcademyAppNew
{
    public abstract class Human
    {
        public string? Name { get; set; } = default;
        public string? Surname { get; set; } = default;
        public int Age { get; set; } = default;

        public Human() { }

        public Human(string? name, string? surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Surname : {Surname}");
            Console.WriteLine($"Age : {Age}");
        }
    }
}
