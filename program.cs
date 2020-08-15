/*
This program is purely deidcated for the purpose of using the following concepts of C# here on online compiler 
a). data types
b). Array -single dimension/ multi dimesnsion
c). for loop
d). concept of namespace or class
namespace: classes of classes
*/
using System;//namespace for library the function that we are going to use below this line -mapping 
namespace smartdata_entreprises//classes of classs
{
    struct employee
    {
        public int emp_ID;
        public string emp_name;
        public string emp_address;
        public int basic_salary;
    };  
    class employee_record
    {
        static void Main(string[] args)//main function
        {
            employee[] emp = new employee[3];
            int i;
            Console.WriteLine("SmartData Enterprises Limited ");
            Console.WriteLine("Enter the records of Employee: ");
            for (i = 0; i <= 2; i++)
            {
                Console.WriteLine("Enter Employee Id: ");
                emp[i].emp_ID = int.Parse(Console.ReadLine());//Parsing conversion from string to int and finally keeping inside array
                Console.WriteLine("Enter Employee name: ");
                emp[i].emp_name = Console.ReadLine();
                Console.WriteLine("Enter Employee Address : ");
                emp[i].emp_address = Console.ReadLine();
                Console.WriteLine("Enter Basic Salary : ");
                emp[i].basic_salary = int.Parse(Console.ReadLine());
            }
            for (i = 0; i <= 2; i++)
            {
                Console.WriteLine("\nThe Employee id : " + emp[i].emp_ID);
                Console.WriteLine("The Employee Names: " + emp[i].emp_name);
                Console.WriteLine("The Employee address: " + emp[i].emp_address);
                Console.WriteLine("The Employee basic salary: " + emp[i].basic_salary);
            }
        }
    }
}
