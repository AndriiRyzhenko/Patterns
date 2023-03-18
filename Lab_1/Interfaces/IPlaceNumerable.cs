namespace Lab_1.Interfaces;

public interface IPlacesAggregator
{
    IPlaceIterator NavigatorRecommendation();
    IPlaceIterator TourGuideRecommendation();
    IPlaceIterator ByUserOpinion();
    int Count { get; }
    IPlace this[int index] { get; }
}

