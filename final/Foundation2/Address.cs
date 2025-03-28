public class Address
{
    public string Street { get; private set; }
    public string City { get; private set; }
    public string StateOrProvince { get; private set; }
    public string Country { get; private set; }

    public bool IsUSA()
    {
        if (Country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public Address(string street, string city, string stateOrProvince, string country)
    {
        Street = street;
        City = city;
        StateOrProvince = stateOrProvince;
        Country = country;
    }

    public string ReturnAddress()
    {
        return $"{Street}\n{City}, {StateOrProvince} {Country}";
    }



}