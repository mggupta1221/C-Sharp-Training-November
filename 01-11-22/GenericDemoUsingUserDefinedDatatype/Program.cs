
namespace GenericDemoUsingUserDefinedDatatype
{
    class Program
    {
        public static void Main()
        {
            CustomerRepository customerRepositoryObject = new CustomerRepository();
            customerRepositoryObject.Addcustomers();
            customerRepositoryObject.ShowCustomers();




        }
    }
}