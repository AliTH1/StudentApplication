using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Student student1 = new Student(202, "Rauf", "Mirəliyev", 50, 150, "Hazırlıq məktəbi - 403");

            Console.WriteLine("Şağirdlə bağlı hansı əməliyyatı yerinə yetirmək istəyirsiz?");
            Console.WriteLine("1 - Şağird haqqında məlumat" + "\n2 - Şağirdin ortalama qiyməti"
                + "\n3 - Şağirdin oxuduqu məktəb" + "\n4 - Əməliyyatı dayandır");

            Console.Write("\nSeçim: ");
            int userInput = Convert.ToInt32(Console.ReadLine());


            switch (userInput)
            {
                case 1: student1.showStudentInformation(); break;
                case 2: student1.averageStudent(); break;
                case 3: student1.getSchoolName(); break;
                case 4: Console.Clear(); break;
                default: Console.WriteLine( "Girişin düzgünlüyünü yoxlayın"); break;
            }

            Console.ReadLine();
        }
    }
}
