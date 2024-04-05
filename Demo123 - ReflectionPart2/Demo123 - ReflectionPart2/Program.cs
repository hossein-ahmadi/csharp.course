// Demo123 - Reflection Part 2
// TOSINSO C# Mega Course

using Demo123___ReflectionPart2;

var empType = typeof(Employee); // Type.GetType("Demo123___ReflectionPart2.Employee"); 

// create instances

var emp = Activator.CreateInstance<Employee>();

var defaultConstructor = empType.GetConstructors().First(c => c.GetParameters().Length == 0);

var emp2 = (Employee)defaultConstructor.Invoke(null);

var secondaryConstructor = empType.GetConstructors().First(c => c.GetParameters().Length == 3);

var emp3 = (Employee)secondaryConstructor.Invoke(new object[] { "Hossein", "Ahmadi", 15000000 });

// invoke methods

var getFullnameMethod = empType.GetMethod("GetFullname");

var fullname = getFullnameMethod.Invoke(emp3, null);

var calculateTaxMethod = empType.GetMethod("CalculateTax");

var tax = calculateTaxMethod.Invoke(emp3, new object[] { (byte)10 });

// get and set properties

var firstNameProperty = empType.GetProperty("Firstname");

firstNameProperty.SetValue(emp2, "Hossein");

var firstname = firstNameProperty.GetValue(emp2);

Console.ReadKey();
