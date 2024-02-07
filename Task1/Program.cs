
using Task1;

var student1 = new Student();
student1.SetAge(21);
student1.SetName("Toobby");
student1.SetGender("Male");
student1.SetUniversity("MIT");
student1.Greets();
student1.Greets();
System.Console.WriteLine($"My age is {student1.GetAge()} years old ");
student1.Study();
student1.Greets();

var teacher = new Teacher();
teacher.Explaing();