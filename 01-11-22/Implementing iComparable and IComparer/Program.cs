namespace Implementing_iComparable_and_IComparer
{
    class Program
    {
        public static void Main()
        {
            StudentRepository studentRepositoryobj = new StudentRepository();
            Console.WriteLine("Enter \n1.sorting based on id\n2.Sorting based on grade");
            int choice=int.Parse(Console.ReadLine());
            studentRepositoryobj.AddStudents(choice);
            studentRepositoryobj.ShowStudents();
        }
    }
}