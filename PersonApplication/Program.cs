using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // create one Student object
            Student student = new Student("Kirsi", "Kernel", "Piippukatu 2", "K2333");
            Console.WriteLine("Student = " + student.ToString());
            student.StudentMethod();
            student.PersonMethod();

            Teacher teacher = new Teacher("Teppo", "Terävä", "Kukkokuja 2", "D566");
            Console.WriteLine("Teacher = " + teacher.ToString());
            teacher.TeacherMethod();
            teacher.PersonMethod();
        }
    }
}
