namespace Zadanie_04;

public class SampleDataBase
{
    private List<Person> people = new List<Person>();

    public void addPerson(Person person)
    {
        people.Add(person);
    }

    public void removePerson(Person person)
    {
        people.Remove(person);
    }

    public Person getPersonById(int id)
    {
        return people[id];
    }

    public List<Person> getAlPersons()
    {
        return people;
    }
}