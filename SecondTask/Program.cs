using System;

namespace SecondTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            
            s1.Name = "Joppa";
           
            Student s2 = new Student();

            s2.Name = s1.Name;

            s2.Name = s1.Name.ToUpper();
            Console.WriteLine(" sl - " + s1.Name +
            ", s2 - " + s2.Name);
            
            Console.WriteLine("Haжмитe <Enter> для " +
"завершения программы ... ");
            
            Console.Read();


        }

    }
    class Student
    {
     public String Name;
    }

}
