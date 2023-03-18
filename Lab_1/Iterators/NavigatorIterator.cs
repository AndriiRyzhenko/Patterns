using Lab_1.Interfaces;

namespace Lab_1.Iterators;

public class NavigatorIterator : IPlaceIterator
{
    private readonly IPlacesAggregator _places;
    private int _index;

    public NavigatorIterator(IPlacesAggregator places)
    {
        _places = places;
    }

    public bool HasNext() => _index < _places.Count;

    public IPlace Next() => _places[_index++];
}

