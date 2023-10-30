// See https://aka.ms/new-console-template for more information
using task_3;


static void Main(string[] args)
{
    Person person = new Person("John", "Doe");
    person.FirstName = "Test";
    person.LastName = "Test2";
    Person studentAsPerson = new Student("jack", "ma", 1);

    Student student = new Student("Gomora", "Jason", 2);

    Person[] persons = new Person[] { person, studentAsPerson, student};

    foreach ( var p in persons)
    {
        Console.WriteLine(p.ToString());
    }
}