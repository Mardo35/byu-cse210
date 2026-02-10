public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        _streetAddress = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool IsInUSA()
    {
        // Case-insensitive to check for USA or United States
        string countryLower = _country.ToLower();
        return countryLower == "usa" || countryLower == "united states";
    }

    public string GetFullAddress()
    {
        return $"{_streetAddress}\n{_city}, {_state}\n{_country}";
    }
}