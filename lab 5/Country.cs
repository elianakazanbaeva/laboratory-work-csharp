public class Country
{
    public int Id { get; set; }
    public string Name { get; set; }

    public Country()
    {
        Name = string.Empty;
    }

    public Country(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public override string ToString()
    {
        return "ID: " + Id + ", Название: "
               + Name;
    }
}