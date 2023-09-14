using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace C_AcademyAppNew
{
    public class Academy
    {
        public string? Name { get; set; }
        public Group[]? Groups { get; set; } = new Group[0];

        public Academy() { }

        public Academy(string? name)
        {
            Name = name;
        }


        public void AddGroup(Group newGroup)
        {
            if (Groups == null)
            {
                Groups = new Group[0];
            }

            var temp = new Group[Groups.Length + 1];
            Groups.CopyTo(temp, 0);

            temp[Groups.Length] = newGroup;
            Groups = temp;
        }

        public void ShowAcademy()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"\t\t= > = > = >Step IT Academy< = < = < = {Name}");
            Console.ResetColor();
            if (Groups != null && Groups.Length > 0)
            {
                foreach (var group in Groups)
                {
                    group.ShowGroup();
                }
            }
        }
    }
}


