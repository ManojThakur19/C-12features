namespace PrimaryConstructor
{
    public class FullTimeEmployee(string firstName, string lastName, decimal salary) : Employee(firstName, lastName)
    {
        public decimal Salary { get; init; } = salary;
        
    }
}
