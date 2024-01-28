using PrimaryConstructor;

Console.WriteLine("Primary Constructor");

 
//Benefits
//Simplify initialization of properties of class
//Why constructor
   //1. to pass arguments to base constructor
   //2. to initialize readonly variables for dependency injection


var employee1 = new Employee("Manoj","Thakur");

Console.WriteLine(employee1.FullName);

