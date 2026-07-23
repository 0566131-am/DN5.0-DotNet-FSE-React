namespace DN.OrderService;

/// <summary>
/// Used to practice:
/// - Dependency Injection via Constructor
/// - Creating Mock Objects Using Moq
/// - State-based vs Interaction Testing
/// - Testing the interaction between two objects
/// </summary>
public class OrderProcessor
{
    private readonly IInventoryRepository _inventoryRepository;
    private readonly IEmailService _emailService;

    // Dependency Injection via Constructor
    public OrderProcessor(IInventoryRepository inventoryRepository, IEmailService emailService)
    {
        _inventoryRepository = inventoryRepository ?? throw new ArgumentNullException(nameof(inventoryRepository));
        _emailService = emailService ?? throw new ArgumentNullException(nameof(emailService));
    }

    public decimal PlaceOrder(Order order, string customerEmail)
    {
        if (order is null)
            throw new ArgumentNullException(nameof(order));

        var availableStock = _inventoryRepository.GetAvailableStock(order.ProductName);

        if (availableStock < order.Quantity)
        {
            throw new InvalidOperationException(
                $"Insufficient stock for '{order.ProductName}'. Available: {availableStock}, Requested: {order.Quantity}.");
        }

        _inventoryRepository.ReduceStock(order.ProductName, order.Quantity);

        var total = order.Quantity * order.UnitPrice;

        // Interaction with a second collaborator (email service)
        _emailService.SendOrderConfirmation(customerEmail, order);

        return total;
    }
}
