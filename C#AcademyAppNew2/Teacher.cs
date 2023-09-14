using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_AcademyAppNew
{
    public class Teacher : Human
    {
        public int Id { get; set; }
        public static int TeacherId { get; set; }
        public double Salary { get; set; } = default;
        public Exam[]? Exams { get; set; }

        public Teacher() { }

        public Teacher(string? name, string? surname, int age, double salary)
            : base(name, surname, age)
        {
            Id = ++TeacherId;
            Salary = salary;
        }

        public void ShowTeacher()
        {
            base.ShowInfo();
            Console.WriteLine($"Salary : {Salary}");
        }
    }
}


