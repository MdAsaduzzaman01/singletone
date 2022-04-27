using System;
using System.Threading.Tasks;

namespace SingletonDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(FromTeacher,FromStudent);
            Console.ReadLine();
        }
        private static void FromTeacher()
        {
            Singleton fromTeacher = Singleton.GetInstance;
            fromTeacher.PrintDetails("From Teacher");

        }
        private static void FromStudent()
        {

            Singleton fromStudent = Singleton.GetInstance;
            fromStudent.PrintDetails("From Student");
        }
    }
}
