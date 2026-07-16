using DN.OrderService;
using Moq;
using NUnit.Framework;

namespace DN.OrderService.Tests;

[TestFixture]
public class OrderProcessorTests
{
    private Mock<IInventoryRepository> _inventoryMock = null!;
    private Mock<IEmailService> _emailMock = null!;
    private OrderProcessor _sut = null!; // System Under Test

    [SetUp]
    public void SetUp()
    {
        _inventoryMock = new Mock<IInventoryRepository>();
        _emailMock = new Mock<IEmailService>();
        _sut = new OrderProcessor(_inventoryMock.Object, _emailMock.Object);
    }

    // ---------------------------------------------------------------
    // EXERCISE 1: Creating Mock Objects Using Moq + state-based testing
    // 1. Set up _inventoryMock.Setup(x => x.GetAvailableStock("Widget"))
    //    to return 10.
    // 2. Call _sut.PlaceOrder(...) with an order for 2 Widgets @ 5.00m.
    // 3. Assert the returned total equals 10.00m.
    // ---------------------------------------------------------------
    [Test]
    public void PlaceOrder_SufficientStock_ReturnsCorrectTotal()
    {
        // Arrange
        // TODO: _inventoryMock.Setup(...)
        var order = new Order(1, "Widget", 2, 5.00m);

        // Act
        // TODO: var total = _sut.PlaceOrder(order, "customer@example.com");

        // Assert
        Assert.Fail("TODO: implement this test");
    }

    // ---------------------------------------------------------------
    // EXERCISE 2: Interaction testing - verify a mock method WAS called
    // Verify that ReduceStock was called exactly once with the right
    // product name and quantity, using _inventoryMock.Verify(...).
    // ---------------------------------------------------------------
    [Test]
    public void PlaceOrder_SufficientStock_ReducesStockExactlyOnce()
    {
        // TODO: Setup GetAvailableStock, call PlaceOrder,
        // then _inventoryMock.Verify(x => x.ReduceStock("Widget", 2), Times.Once);
        Assert.Fail("TODO: implement this test");
    }

    // ---------------------------------------------------------------
    // EXERCISE 3: Interaction testing - verify a second collaborator
    // Verify that SendOrderConfirmation was called on the email mock
    // with the correct customer email.
    // ---------------------------------------------------------------
    [Test]
    public void PlaceOrder_SufficientStock_SendsConfirmationEmail()
    {
        // TODO: implement using _emailMock.Verify(...)
        Assert.Fail("TODO: implement this test");
    }

    // ---------------------------------------------------------------
    // EXERCISE 4: Testing exception paths + verifying a mock is NOT called
    // 1. Set up GetAvailableStock to return 1 (less than requested).
    // 2. Assert PlaceOrder throws InvalidOperationException.
    // 3. Verify ReduceStock and SendOrderConfirmation were NEVER called
    //    (Times.Never).
    // ---------------------------------------------------------------
    [Test]
    public void PlaceOrder_InsufficientStock_ThrowsAndDoesNotReduceStockOrEmail()
    {
        Assert.Fail("TODO: implement this test");
    }

    // ---------------------------------------------------------------
    // EXERCISE 5 (stretch): Testing private/edge behavior via null args
    // PlaceOrder(null, "a@b.com") should throw ArgumentNullException.
    // ---------------------------------------------------------------
    [Test]
    public void PlaceOrder_NullOrder_ThrowsArgumentNullException()
    {
        Assert.Fail("TODO: implement this test");
    }
}
