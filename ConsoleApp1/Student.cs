using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Student
    {

        private int id;
        private string name;

        private int age;


        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Name {
            get { return name; }
            set { name = value; } }

        public int Age
        {
            get { return age; }
            set {age = value; }
        }

        public void Display()
        {
            Console.WriteLine($"ID: {id}, \nName: {name}, \nAge: {age}");
        }


    }
}
