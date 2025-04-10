using static System.Console;
public class Program
{
    public static void Main(string[] args)
    {
        Person person = new Person();
        person.AgeGroup = AgeGroupEnumeration.Adult;
        WriteLine(person.AgeGroup);
    }
}