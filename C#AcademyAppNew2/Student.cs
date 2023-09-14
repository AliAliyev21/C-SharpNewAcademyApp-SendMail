using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_AcademyAppNew
{
    public class Student : Human
    {
        public int Id { get; set; }
        public static int StudentId { get; set; }
        public string? Email { get; set; } = "Your Email";
        public Exam[] Exams { get; set; } = new Exam[0];
        public Student() { }

        public Student(string? name, string? surname, int age, string? email, Exam[]? exams)
            : base(name, surname, age)
        {
            Id = ++StudentId;
            Email = email;
            Exams = exams;
        }

        public void AddExam(Exam newExam)
        {
            if (Exams == null)
            {
                Exams = new Exam[0];
            }

            var temp = new Exam[Exams.Length + 1];
            Exams.CopyTo(temp, 0);

            temp[temp.Length - 1] = newExam;
            Exams = temp;
        }

        public double GetAvgScore()
        {
            if (Exams == null)
            {
                throw new InvalidOperationException("No exams available to calculate average score");
            }

            double totalScore = 0;

            foreach (var exam in Exams)
            {
                totalScore += exam.Score;
            }

            double avarageScore = totalScore / Exams.Length;
            return avarageScore;
        }

        public void ShowStudent()
        {
            base.ShowInfo();
            Console.WriteLine($"Email : {Email}");
            Console.WriteLine($"Avarage Score : {GetAvgScore()}");
        }
    }
}