public class Person
{
    public string PersonName { set; get; }
    public string Email { set; get; }
    public AgeGroupEnumeration AgeGroup { set; get; }

}

public enum AgeGroupEnumeration
{
    Child,
    Teenager,
    Adult,
    Senior
}