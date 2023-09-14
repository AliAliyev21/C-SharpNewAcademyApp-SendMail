using System.Net.Mail;
using System.Net;

namespace C_AcademyAppNew
{
    public class Program
    {



        static void Main(string[] args)
        {
            Academy academy = new Academy();

            // Group 1 telebeleri
            Student student1 = new Student("Ali", "Aliyev", 23, "Ali21@gmail.com", new Exam[1] { new Exam("Linux Development", 99.9, DateTime.Now) });
            Student student2 = new Student("Anvar", "Mammadov", 21, "Anvar21@gmail.com", new Exam[1] { new Exam("C# Development", 99.8, DateTime.Now) });
            Student student3 = new Student("Vuqar", "Aslanov", 23, "Vuqar23@gmail.com", new Exam[1] { new Exam("C++ Development", 99.7, DateTime.Now) });
            Student[] students1 = new Student[] { student1, student2, student3 };

            //Group 1 Muellimi
            Teacher teacher1 = new Teacher("Elvin", "Camalzade", 23, 11000);

            //Group 1 
            Group group1 = new Group("T101", new Teacher[] { teacher1 }, students1);

            // Group 2 telebeleri
            Student student4 = new Student("Leyla", "Memmedova", 19, "Leyla19@gmail.com", new Exam[1] { new Exam("Designer", 98.8, DateTime.Now) });
            Student student5 = new Student("Lale", "Aliyeva", 18, "Lale18@gmail.com", new Exam[1] { new Exam("Front-End", 97.7, DateTime.Now) });
            Student student6 = new Student("Ayse", "Qurbanova", 17, "Ayse17@gmail.com", new Exam[1] { new Exam("Back-End", 96.6, DateTime.Now) });
            Student[] students2 = new Student[] { student4, student5, student6 };

            //Group 2 Muellimi
            Teacher teacher2 = new Teacher("Madina", "Akberova", 25, 8000);

            //Group 2 
            Group group2 = new Group("T101", new Teacher[] { teacher2 }, students2);

            academy.AddGroup(group1);
            academy.AddGroup(group2);

            while (true)
            {
                academy.ShowAcademy();
                Console.WriteLine();
                Console.WriteLine("Group  [1]");
                Console.WriteLine("Group  [2]");
                Console.WriteLine("Back   [3]");

                Console.WriteLine("Please enter a group : ");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.Clear();
                    group1.ShowGroup();
                    Console.WriteLine();
                    Console.Write("Add new Exam : [Y/N]");
                    string addExam = Console.ReadLine();

                    if (addExam.ToLower() == "y")
                    {
                        Console.Write("Select the student to add the new Exam (Enter student ID) : ");

                        if (int.TryParse(Console.ReadLine(), out int studentId))
                        {
                            Student selectedStudent = group1.Students.FirstOrDefault(student => student.Id == studentId);

                            if (selectedStudent != null)
                            {
                                Console.WriteLine($"Selected student [{selectedStudent.Name} {selectedStudent.Surname}]");

                                Console.WriteLine("Enter Exam Name : ");
                                string examName = Console.ReadLine();

                                Console.Write("Enter Exam Score : ");
                                if (double.TryParse(Console.ReadLine(), out double examScore))
                                {
                                    Console.Write("Enter Exam Date (dd/MM/yyyy) : ");
                                    if (DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime examDate))
                                    {
                                        Exam newExam = new Exam(examName, examScore, examDate);
                                        selectedStudent.AddExam(newExam);
                                        Console.WriteLine($"Exam added successfully.[{selectedStudent.Name}'s] updated exams");

                                        SendScoreByEmail(selectedStudent, examName, examScore);

                                        foreach (var exam in selectedStudent.Exams)
                                        {
                                            string examDateText = exam.ExamDate.HasValue ? exam.ExamDate.Value.ToShortDateString() : "N/A";
                                            Console.WriteLine($"Exam Name : {exam.ExamName}");
                                            Console.WriteLine($"Exam Date : {examDateText}");
                                            Console.WriteLine($"Exam Score : {exam.Score}");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid date input");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Invalid score input");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid student ID");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a valid student ID");
                        }
                    }
                }
                else if (choice == "2")
                {
                    Console.Clear();
                    group2.ShowGroup();
                    Console.WriteLine();
                    Console.Write("Add new Exam : [Y/N]");
                    string addExam = Console.ReadLine();

                    if (addExam.ToLower() == "y")
                    {
                        Console.Write("Select the student to add the new Exam (Enter student ID) : ");

                        if (int.TryParse(Console.ReadLine(), out int studentId))
                        {
                            Student selectedStudent = group1.Students.FirstOrDefault(student => student.Id == studentId);

                            if (selectedStudent != null)
                            {
                                Console.WriteLine($"Selected student [{selectedStudent.Name} {selectedStudent.Surname}]");

                                Console.WriteLine("Enter Exam Name : ");
                                string examName = Console.ReadLine();

                                Console.Write("Enter Exam Score : ");
                                if (double.TryParse(Console.ReadLine(), out double examScore))
                                {
                                    Console.Write("Enter Exam Date (dd/MM/yyyy) : ");
                                    if (DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime examDate))
                                    {
                                        Exam newExam = new Exam(examName, examScore, examDate);
                                        selectedStudent.AddExam(newExam);
                                        Console.WriteLine($"Exam added successfully.[{selectedStudent.Name}'s] updated exams");

                                        SendScoreByEmail(selectedStudent, examName, examScore);

                                        foreach (var exam in selectedStudent.Exams)
                                        {
                                            string examDateText = exam.ExamDate.HasValue ? exam.ExamDate.Value.ToShortDateString() : "N/A";
                                            Console.WriteLine($"Exam Name : {exam.ExamName}");
                                            Console.WriteLine($"Exam Date : {examDateText}");
                                            Console.WriteLine($"Exam Score : {exam.Score}");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid date input");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Invalid score input");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid student ID");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a valid student ID");
                        }
                    }
                }
                else if (choice == "3")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Exiting Programming....");
                    Console.ResetColor();
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Selection...");
                    continue;
                }
            }
        }

        static void SendScoreByEmail(Student student, string examName, double examResult)
        {
            try
            {
                string sendEmail = "Your Mail";
                string sendPassword = "Your Password";

                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential(sendEmail, sendPassword),
                    EnableSsl = true,
                };


                MailMessage ePoçt = new MailMessage(sendEmail, student.Email)
                {
                    Subject = "Imtahan netice bildirisi",
                    Body = $"Hormetli {student.Name},\n\n{examName} imtahanindan {examResult} netice aldiniz.\n\nSize ugurlar dileyirik,\nMyAcademy",
                };

                smtpClient.Send(ePoçt);

                Console.WriteLine("Result email sent successfully");
            }
            catch (Exception wrong)
            {
                Console.WriteLine("An error occurred while sending an email :" + wrong.Message);
            }
        }
    }
}