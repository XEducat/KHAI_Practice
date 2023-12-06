using Project_OOP.Moldels;

public class PersonCreatedEventArgs : EventArgs
{
    public Person Person { get; }

    public PersonCreatedEventArgs(Person person)
    {
        this.Person = person;
    }
}