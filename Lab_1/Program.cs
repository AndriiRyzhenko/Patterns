using Lab_1.Interfaces;

namespace Lab_1;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Laboratory work №1. Iterator pattern");
        Console.WriteLine();

        List<IPlace> places = new List<IPlace>
        {
            new Place() {Name = "Pysanka Museum", Distance = 150, Rating = 3},
            new Place() {Name = "Golden Gate of Kyiv", Distance = 300, Rating = 5},
            new Place() {Name = "Lviv High Castle", Distance = 50, Rating = 2},
            new Place() {Name = "Odesa Opera House", Distance = 200, Rating = 4},
            new Place() {Name = "Carpathian Mountains", Distance = 75, Rating = 5}
        };

        IPlacesAggregator aggregator = new PlacesAggregator(places);
        ITouristInformation touristInformation = new TouristInformation();

        Console.WriteLine("ByUserOpinion:");
        touristInformation.ShowPlace(aggregator.ByUserOpinion());

        Console.WriteLine();
        Console.WriteLine("NavigatorRecommendation:");
        touristInformation.ShowPlace(aggregator.NavigatorRecommendation());

        Console.WriteLine();
        Console.WriteLine("TourGuideRecommendation:");
        touristInformation.ShowPlace(aggregator.TourGuideRecommendation());
    }
}
