using System;
using System.Collections;

class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Mark { get; set; }
}
class Program
{
    static void Main()
    {
        Stack stack1 = new Stack();
        Stack stack2 = new Stack();
        for (int i = 0; i < 5; i++)
        {
            Student student = new Student();
            student.FirstName = "Anton" + (i + 1);
            student.LastName = "Churka" + (i + 1);
            stack1.Push(student);
        }
        for (int i = 0; i < 5; i++)
        {
            Student student = (Student)stack1.Pop();
            Console.WriteLine("Введите оценку " + student.FirstName + student.LastName);
            int mark = Convert.ToInt32(Console.ReadLine());
            student.Mark = mark;
            stack2.Push(student);
        }
    }
}