using Lab_1.Interfaces;

namespace Lab_1;

public class TouristInformation : ITouristInformation
{
    public void ShowPlace(IPlaceIterator iterator)
    {
        while (iterator.HasNext())
        {
            IPlace place = iterator.Next();
            Console.WriteLine(place);
        }
    }
}

