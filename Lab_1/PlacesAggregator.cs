using Lab_1.Interfaces;
using Lab_1.Iterators;

namespace Lab_1;

public class PlacesAggregator : IPlacesAggregator
{
    private List<IPlace> _places;

    public PlacesAggregator(List<IPlace> places)
    {
        _places = places;
    }


    public IPlaceIterator NavigatorRecommendation()
    {
        // recommendation by distance
        _places = _places.OrderBy(x => x.Distance).ToList();
        return new NavigatorIterator(this);
    }

    public IPlaceIterator TourGuideRecommendation()
    {
        // recommendation by rating
        _places = _places.OrderBy(x => x.Rating).ToList();
        return new TourGuideIterator(this);
    }

    public IPlaceIterator ByUserOpinion()
    {
        // recommendation by name
        _places = _places.OrderBy(x => x.Name).ToList();
        return new UserOpinionIterator(this);
    }

    public int Count => _places.Count;

    public IPlace this[int index] => _places[index];
}
