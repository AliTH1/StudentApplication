using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApplication
{
    public class Student
    {
        private int studentNo;
        private string studentName, studentSurname;
        private int exam1, exam2, final;
        private string schoolName;

        public Student(int _studentNo, string _studentName, string _studentSurname,
            int _exam1, int _exam2, string _schoolName)
        {
            studentNo = _studentNo;
            studentName = _studentName;
            studentSurname = _studentSurname;
            exam1 = _exam1;
            exam2 = _exam2;
            final = _exam1 + _exam2;
            schoolName = _schoolName;
        }

        public void showStudentInformation()
        {
            Console.Clear();
            Console.WriteLine("\nŞagirdin nömrəsi: " + studentNo);
            Console.WriteLine("Adı: " + studentName + " " + "\nSoyadı: " + studentSurname);
            Console.WriteLine("\n\nBirinci imtahan balı: " + exam1 + " " + "\nİkinci imtahan balı: " + exam2
                + "\nÜmumi bal: " + final);
        }

        public void averageStudent()
        {
            Console.Clear();
            double ortalama = exam1 * 0.2 + exam2 * 0.2 + final * 0.6;
            Console.WriteLine("Ortalama qiymət: " + ortalama);
        }

        public void getSchoolName()
        {
            Console.Clear();
            Console.WriteLine("Məktəbin adı: " + schoolName);
        }
    }
}
