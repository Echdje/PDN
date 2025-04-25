namespace Zadanie_04;

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }

    public Person(string firstName, string lastName, string address, string phoneNumber)
    {
        FirstName = firstName;
        LastName = lastName;
        Address = address;
        PhoneNumber = phoneNumber;
    }

    public override string ToString()
    {
        return $"{FirstName} {LastName}, Adres: {Address}, Phone number: {PhoneNumber}";
    }
}