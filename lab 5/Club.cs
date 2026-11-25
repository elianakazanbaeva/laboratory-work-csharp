public class Club
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int CountryId { get; set; }

    public Club()
    {
        Name = string.Empty;
    }

    public Club(int id, string name,
        int countryId)
    {
        Id = id;
        Name = name;
        CountryId = countryId;
    }

    public override string ToString()
    {
        return "ID: " + Id + ", Название: "
               + Name + ", ID страны: "
               + CountryId;
    }
}