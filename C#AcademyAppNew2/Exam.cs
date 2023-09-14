using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_AcademyAppNew
{
    public class Exam
    {
        public string? ExamName { get; set; } = default;
        public double Score { get; set; } = default;
        public DateTime? ExamDate { get; set; } = DateTime.Now;

        public Exam() { }

        public Exam(string? examName, double score, DateTime examDate)
        {
            ExamName = examName;
            Score = score;
            ExamDate = examDate;
        }

        public void ShowExamInformation()
        {
            Console.WriteLine($"Lesson Name : {ExamName}");
            Console.WriteLine($"Score : {Score}");
            Console.WriteLine($"Exam Date : {ExamDate}");
        }
    }
}

