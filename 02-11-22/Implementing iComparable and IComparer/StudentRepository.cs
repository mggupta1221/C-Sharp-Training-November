
namespace Implementing_iComparable_and_IComparer
{
    class StudentRepository
    {
        List<Student> students = new List<Student>();
        Student2 student2obj=new Student2();


        public static int CompareNames(Student student1,Student student2) //delegate method
        {
           return student1.Name.CompareTo(student2.Name);   //this compareto is inbuilt method of string to sort based on alphabet
        }
        
        public void AddStudents(int choice)
        {
            students.Add(new Student(){ Id = 101,Name = "Marsh",Grade=9.5});
            students.Add(new Student() { Id = 1, Name = "Alim", Grade = 10 });
            students.Add(new Student() { Id = 55, Name = "Scott", Grade = 9.4});
            students.Add(new Student() { Id = 99, Name = "Micheal", Grade = 8.4 });
            students.Add(new Student() { Id = 43, Name = "Blake", Grade = 6 });

            if (choice == 1)
                students.Sort(); ///BASED ON iD
            else if (choice == 2)
                students.Sort(student2obj); //overloading method  //basedon grade
            else if(choice == 3)
                students.Sort(1,3,student2obj); //based on grade
            else
            {
                Comparison<Student> comparison = new Comparison<Student>(CompareNames); //Delegate
                //students.Sort(comparison);
                students.Sort(CompareNames); //either pass delegate name or delegate method

            }
        }

        public void ShowStudents()
        {
            foreach (Student student in students)
                Console.WriteLine($"{student.Id} : {student.Name} : {student.Grade} ");
        }
    }
}