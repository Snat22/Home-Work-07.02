namespace Task1;

public class Person
{
    string _name ;
    int _age;
    string _gender {get;set;}

    public void Greets()
    {
     System.Console.WriteLine("Hello!");   
    }

    public void SetAge(int age)
    {
        if(_age < 0 || _age > 100)
        {
            System.Console.WriteLine("Write correct Age:");
        }else{
        _age = age;
        }

    }

    public int GetAge()
    {
        return _age;
    }

    public void SetName( string name)
    {
        _name = name;
    }
    public virtual string GetName()
    {
        return $"{_name}";
    }


       public void SetGender( string gender)
    {
        _gender = gender;
    }
    public virtual string GetGender()
    {
        return $"{_gender}";
    }
}
