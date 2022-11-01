using System.Xml.Linq;

namespace Implementing_iComparable_and_IComparer
{
    class StudentRepository
    {
        List<Student> students = new List<Student>();
        Student2 student2obj=new Student2();    
        public void AddStudents(int choice)
        {
            students.Add(new Student(){ Id = 101,Name = "Marsh",Grade=7.8});
            students.Add(new Student() { Id = 1, Name = "Lenin", Grade = 8.9 });
            students.Add(new Student() { Id = 55, Name = "Scott", Grade = 9.4});
            students.Add(new Student() { Id = 99, Name = "Micheal", Grade = 10 });
            if(choice == 1)
                students.Sort();
            else
                students.Sort(student2obj); //overloading method
        }

        public void ShowStudents()
        {
            foreach (Student student in students)
                Console.WriteLine($"{student.Id} : {student.Name} : {student.Grade} ");
        }
    }
}