namespace Zadanie_04;

class Program
{
    static void Main(string[] args)
    {
        SampleDataBase db = new SampleDataBase();
        Person Adrian = new Person("Adrian", "Stanisz", "dwa", "trzy");
        
        db.addPerson(Adrian);
        
        Console.WriteLine(db.getPersonById(0));
    }
}