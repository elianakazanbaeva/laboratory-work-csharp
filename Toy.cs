using System;

//5
[Serializable]
public struct Toy
{
    private string name;
    private int price;
    private int minAge;
    private int maxAge;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Price
    {
        get { return price; }
        set { price = value; }
    }

    public int MinAge
    {
        get { return minAge; }
        set { minAge = value; }
    }

    public int MaxAge
    {
        get { return maxAge; }
        set { maxAge = value; }
    }
}