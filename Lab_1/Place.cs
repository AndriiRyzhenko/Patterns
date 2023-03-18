using Lab_1.Interfaces;

namespace Lab_1;

public class Place : IPlace
{
    public string Name { get; set; }
    public int Distance { get; set; }
    public int Rating { get; set; }

    public override string ToString()
    {
        return $"Name: {Name}, Distance: {Distance}km, Rating: {Rating}";
    }
}

