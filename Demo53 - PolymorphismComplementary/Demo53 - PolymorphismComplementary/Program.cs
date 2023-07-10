// Demo53
// Polymorphism complementary

using Demo53___PolymorphismComplementary.Models;

var st = new Student()
{
    Firstname = "Hossein",
    Lastname = "Ahmadi",
    Age = 37,
    EducationalField = "Programming"
};

Console.WriteLine(st.GetDisplayString());

Person p = new Student()
{
    Firstname = "Mohammad",
    Lastname = "Nasiri"
};

Console.WriteLine(p.GetDisplayString());

var cloned = st.Clone();

