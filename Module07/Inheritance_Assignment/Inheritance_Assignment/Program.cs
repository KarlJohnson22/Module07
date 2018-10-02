using System;

namespace Inheritance_Assignment
{

    class Teacher
    {
        private string className;
        private string instructor;
        public Teacher() { }
        public void setClassName(string c) { className = c; }
        public void setInstructor(string i) { instructor = i; }
        public string getClassName()
        {
            return className;
        }
        public string getInstructor()
        {
            return instructor;
        }
    }
    class CSharp : Teacher
    {
        public void setCandI(string c, string i)
        {
            setClassName(c); setInstructor(i);
        }
        public void teaches()
        {
            Console.WriteLine("{1} teaches {0}.", getClassName(), getInstructor());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Teacher t1 = new Teacher();
            CSharp c1 = new CSharp();
            t1.setClassName("Photoshop");
            t1.setInstructor("Darryl Runyan");
            Console.WriteLine("Class = {0}, Instructor = {1}", t1.getClassName(), t1.getInstructor());
            c1.setCandI("C#", "Bob Ray");
            c1.teaches();
            Console.ReadLine();
        }
    }
}


