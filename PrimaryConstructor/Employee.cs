namespace PrimaryConstructor
{
    public class Employee(string firstName, string lastName, string defaultValue)
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DefaultValue { get; init; }
        private readonly string _defaultvalue = defaultValue;

        public string ChangeFirstName()
        {
            return FirstName;
        }
        public string FullName => $"{FirstName} {LastName}";
    }
}
