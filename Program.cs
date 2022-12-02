using System;
using static System.Console;

namespace Module03
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Write("Enter your name: ");
            string name = ReadLine();
            Write("Enter your age: ");
            byte age = checked((byte)int.Parse(ReadLine()));
            Write("Enter date of birth: ");
            bool corDateOfBirth = DateTime.TryParse(ReadLine(), out DateTime date);

            if (corDateOfBirth == true) 
            {
                WriteLine(format:"You data: \n\tName: {0} \n\tAge: {1} \n\tDate of birth: {2 : dd.mm.yyyy}",
                arg0: name,
                arg1: age,
                arg2: date);
            }
            else
            {
                WriteLine("Не корректная дата.");
            }

        }
    }
}
