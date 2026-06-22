public class CustomerService
{
    private readonly CustomerRepository repository;

    public CustomerService(CustomerRepository repository)
    {
        this.repository = repository;
    }

    public void GetCustomer(int id)
    {
        Console.WriteLine(repository.FindCustomerById(id));
    }
}