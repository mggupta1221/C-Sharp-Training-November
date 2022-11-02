using System.Globalization;

namespace Implementing_iComparable_and_IComparer
{
    class Program
    {
        public static void Main()
        {
           StudentRepository studentRepositoryobj = new StudentRepository();
            Console.WriteLine("Enter \n1.sorting based on id using Icomparable\n2.Sorting based on grade using Icomparer\n3.using index(Start from 1) and upto(index 3) which element using IComparer\n4.Using Comparison Delegate wrt Names");
            Console.WriteLine();
            int choice=int.Parse(Console.ReadLine());
            studentRepositoryobj.AddStudents(choice);
            studentRepositoryobj.ShowStudents();
        }
    }
}
/* 
 sorting the complex(User Defined) collections can be done by 4 type

1.Using IComparable interface
    use if u have full control over the code or class 
    
    Inherit class from IComparable Interface
    CompareTo(type other) method
    current instanv=ce value compared with other values 
    return 1: current>other
    return -1: other>Current
    return 0: else

2.Using IComparer Interface: used if u dont have full control on class only dll is provided

    1.Compare(T x,T y) method
        create new class and inherit it from IComparer interface
        

            students.Sort(student2obj);

                public class Student2 : IComparer<Student>
                {
                    public int Compare(Student? x, Student? y)
                    {
                        if (x.Grade > y.Grade)
                            return 1;
                        else if(x.Grade < y.Grade)  
                            return -1;
                        return 0;
                    }
                }
    
    2.Compare(initial_index, count_of_members_the_Index, )
 
            students.Sort(1,3,student2obj);
 
            public class Student2 : IComparer<Student>
                {
                    public int Compare(Student? x, Student? y)
                    {
                        if (x.Grade > y.Grade)
                            return 1;
                        else if(x.Grade < y.Grade)  
                            return -1;
                        return 0;
                    }
                }

    3.Using Comparison Delegate
            
            //calling
            //syntax:  public delegate int Comparison<in T>(T x, T y);

         Comparison<Student> comparison = new Comparison<Student>(CompareNames); //Delegate
        students.Sort(comparison);
         students.Sort(CompareNames); //either pass delegate name or delegate method


        //method implementation
        public static int CompareNames(Student student1,Student student2) //delegate method
        {
           return student1.Name.CompareTo(student2.Name);   //this CompareTo is inbuilt method of string to sort based on alphabet
        }
 
               
The Generic List Collection Class in C# provides the following four Sort Methods.

Sort(): This method is used to sort the elements in the entire Generic List using the default comparer.
Sort(IComparer<T> comparer): This method is used to sort the elements in the entire Generic List using the specified comparer.
Sort(Comparison<T> comparison): This method is used to sort the elements in the entire Generic List using the specified System.Comparison.
Sort(int index, int count, IComparer<T> comparer): This method is used to sort the elements in a range of elements in a Generic List using the specified comparer.
 
 */