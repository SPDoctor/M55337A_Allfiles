Person aStudent = new Person();

aStudent._height = 5.5F;
aStudent._gender = "male";
aStudent.Walk();
aStudent.Speak();

Person newStudent = new Person(6.2F, 195.0F, "female");
Console.WriteLine(newStudent.ToString());

public class Person
{
    public float _height;
    public float _weight;
    public string _gender;

    public Person()
    {
        _height = 5.7F;
        _weight = 198.6F;
        _gender = "male";
    }

    public Person(float height, float weight, string gender)
    {
        _height = height;
        _weight = weight;
        _gender = gender;
    }

    public void Walk()
    {

    }

    public void Run()
    {

    }

    public void Eat()
    {

    }

    public void Sit()
    {

    }

    public void Speak()
    {

    }

}