using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> Student = new Dictionary<int, string>();

            Student.Add(1, "Mehmet");
            Student.Add(2, "Faruk");
            Student.Add(3, "Musa");
            Student.Add(4, "Burak");

            foreach (KeyValuePair<int, string> student in Student)
            {
                Console.WriteLine("ID: "+student.Key+"  "+"Adı: "+student.Value);
            }
        }
    }
}
