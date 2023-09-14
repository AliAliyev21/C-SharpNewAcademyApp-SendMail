using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_AcademyAppNew
{
    public class Group
    {
        public string? Name { get; set; }
        public Teacher[]? Teachers { get; set; }
        public Student[]? Students { get; set; }

        public Group() { }

        public Group(string? name, Teacher[]? teachers, Student[]? students)
        {
            Name = name;
            Teachers = teachers;
            Students = students;
        }

        public void AddStudent(Student newStudent)
        {
            if (Students == null)
            {
                Students = new Student[0];
            }

            var temp = new Student[Students.Length + 1];
            Students.CopyTo(temp, 0);

            temp[Students.Length] = newStudent;
            Students = temp;
        }

        public void AddTeacher(Teacher newTeacher)
        {
            if (Teachers == null)
            {
                Teachers = new Teacher[0];
            }

            var temp = new Teacher[Teachers.Length + 1];
            Teachers.CopyTo(temp, 0);
            temp[temp.Length] = newTeacher;
            Teachers = temp;
        }


        public void ShowGroup()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"\t= > = >Groups< = < = [{Name}]");
            Console.ResetColor();
            if (Teachers != null && Teachers.Length > 0)
            {

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("= > Teachers < =");
                Console.ResetColor();
                foreach (var teacher in Teachers)
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine($"Id->[{teacher.Id}]");
                    Console.ResetColor();
                    teacher.ShowTeacher();
                }
            }

            if (Students != null && Students.Length > 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("= > Students < =");
                Console.ResetColor();
                foreach (var student in Students)
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine($"Id->[{student.Id}]");
                    Console.ResetColor();
                    student.ShowStudent();
                }
            }
        }
    }
}


