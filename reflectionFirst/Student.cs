using System;

namespace reflectionFirst
{
    public class Student
    {
        private string name { get; set; }
        private int age { get; set; }

        public Student(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public void ShowResult()
        {
            if (age >= 18)
                Console.WriteLine($"{name} - you are adult");
            else
                Console.WriteLine($"{name} - you are child");
        }
    }
}
