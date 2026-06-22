public class CustomerRepositoryImpl : CustomerRepository
{
    public string FindCustomerById(int id)
    {
        return $"Customer Found: ID = {id}, Name = John Doe";
    }
}