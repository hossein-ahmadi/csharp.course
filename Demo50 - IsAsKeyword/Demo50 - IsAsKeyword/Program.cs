// Demo50 - IsAsKeywords

using Demo50___IsAsKeyword.Models;

Student st = new Student("Hossein", "Ahmadi");
st.EducationalField = "Programming";

Teacher teacher = new Teacher("Mohammad","Nasiri", "2");

Person st2 = new Student("Mehdi", "Adeli");

Person teacher2 = new Teacher("Ali","Shokrollahi", "3");

object teacher3 = new Teacher("Ali","Shokrollahi", "3");

DisplayInformation(st);
DisplayInformation(teacher2);

void DisplayInformation(Person person)
{
    if (person is Student st)
    {
        Console.WriteLine(st.EducationalField);
    }

    if (person is Teacher { EducationalLevel: "3" } t)
    {
        Console.WriteLine("Good, Person is teacher and educational level is greater than 2");
    }

    if (person is Student st1 && (st1.EducationalField == "Programming" || st1.EducationalField == "Development"))
    {

    }

    var teacher = person as Teacher;
}