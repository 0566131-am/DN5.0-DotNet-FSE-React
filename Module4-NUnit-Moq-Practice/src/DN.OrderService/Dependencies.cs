namespace DN.OrderService;

public record Order(int Id, string ProductName, int Quantity, decimal UnitPrice);

/// <summary>
/// External dependency #1 - to be mocked in tests.
/// Simulates checking/updating stock in a database or external system.
/// </summary>
public interface IInventoryRepository
{
    int GetAvailableStock(string productName);
    void ReduceStock(string productName, int quantity);
}

/// <summary>
/// External dependency #2 - to be mocked in tests.
/// Simulates sending a real email (SMTP call, 3rd party API, etc.).
/// </summary>
public interface IEmailService
{
    void SendOrderConfirmation(string customerEmail, Order order);
}
