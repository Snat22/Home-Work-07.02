namespace Task1;

public class Student : Person
{
    string _university;

    public void SetUniversity(string university)
    {   
        _university = university;
    }
    public void GetUniversity()
    {
        System.Console.WriteLine($"{_university}");
    }


    public void ShowAge(int age) 
    {
        System.Console.WriteLine($"{age}");
    }

    public void Study()
    {
        System.Console.WriteLine("I'm studying");
    }
}
