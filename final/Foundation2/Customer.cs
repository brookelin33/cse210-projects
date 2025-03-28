public class Customer 
{

    public Address Address { get; private set;}
    
    public string Name { get; private set;} 

    public Customer (string name, Address address)
    {
        Name = name;
        Address = address;
    }
}