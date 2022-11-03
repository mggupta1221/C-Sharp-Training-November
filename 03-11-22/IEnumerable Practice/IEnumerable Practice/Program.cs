namespace IEnumerable_Practice
{
    public class Program
    {
        public static void Main()
        {
            //Employee employee = new Employee();
            //employee.AddEmployee(new Employee() { Id = 2, Name = "Scott",Department="SALES" });
            //employee.AddEmployee(new Employee() { Id = 1, Name = "Alex", Department = "IT" });
            //employee.AddEmployee(new Employee() { Id = 5, Name = "Mike", Department = "HR" });
            //employee.AddEmployee(new Employee() { Id = 6, Name = "Mukesh", Department = "IT" });
            //employee.AddEmployee(new Employee() { Id = 3, Name = "Scott", Department = "HR" });
            //employee.GetEmployee();

            Organization organizationEmployee = new Organization();         //
            organizationEmployee.Add(new Employee() { Id = 2, Name = "Scott", Department = "SALES" });
            organizationEmployee.Add(new Employee() { Id = 1, Name = "Alex", Department = "IT" });
            organizationEmployee.Add(new Employee() { Id = 5, Name = "Mike", Department = "HR" });
            organizationEmployee.Add(new Employee() { Id = 6, Name = "Mukesh", Department = "IT" });
            organizationEmployee.Add(new Employee() { Id = 3, Name = "Scott", Department = "HR" });

            foreach(Employee EachEmployeeInOrganization in organizationEmployee) //to iterate over user made collection all collections  from iEnumerable
            {
                Console.WriteLine($"{EachEmployeeInOrganization.Id} : {EachEmployeeInOrganization.Name} : {EachEmployeeInOrganization.Department}");
            }



        }
    }
}