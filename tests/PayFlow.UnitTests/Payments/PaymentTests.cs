using PayFlow.Domain.Payments;

namespace PayFlow.UnitTests.Payments;

public sealed class PaymentTests
{
    [Fact]
    public void Create_WithValidAmount_StartsPending()
    {
        var payment = new Payment(Guid.NewGuid(), 100_000m, "idr", "Test payment");
        Assert.Equal(PaymentStatus.Pending, payment.Status);
        Assert.Equal("IDR", payment.Currency);
        Assert.StartsWith("PAY-", payment.Reference);
    }

    [Fact]
    public void Create_WithNonPositiveAmount_Throws() =>
        Assert.Throws<ArgumentOutOfRangeException>(() => new Payment(Guid.NewGuid(), 0, "IDR", "Invalid"));
}
