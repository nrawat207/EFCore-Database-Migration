namespace EFCoreDatabase.Migration.Entities
{
    public class Employee
    {
        public long EmployeeId { get; set; }
        public string Name { get; set; }
        public Department Department { get; set; }
    }
}
