// Demo51
// Inheritance Complementary
// TOSINSO.COM C# Course

using Demo51___InheritanceComplementary.Models.Models;

var st = new Student("Hossein","Ahmadi", 37);

Person p1 = st; // up casting

Student st1 = (Student)p1; // down casting