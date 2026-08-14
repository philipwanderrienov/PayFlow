namespace PayFlow.Domain.Payments;

public enum PaymentStatus { Pending, Processing, Succeeded, Failed }

public sealed class Payment
{
    private Payment() { }
    public Payment(Guid merchantId, decimal amount, string currency, string description)
    {
        if (amount <= 0) throw new ArgumentOutOfRangeException(nameof(amount));
        Id = Guid.NewGuid(); MerchantId = merchantId; Amount = amount;
        Currency = currency.ToUpperInvariant(); Description = description;
        Reference = $"PAY-{DateTimeOffset.UtcNow:yyyyMMdd}-{Guid.NewGuid().ToString("N")[..8].ToUpperInvariant()}";
        Status = PaymentStatus.Pending; CreatedAt = DateTimeOffset.UtcNow;
    }
    public Guid Id { get; private set; }
    public Guid MerchantId { get; private set; }
    public string Reference { get; private set; } = string.Empty;
    public decimal Amount { get; private set; }
    public string Currency { get; private set; } = "IDR";
    public string Description { get; private set; } = string.Empty;
    public PaymentStatus Status { get; private set; }
    public DateTimeOffset CreatedAt { get; private set; }
    public DateTimeOffset? UpdatedAt { get; private set; }
    public void MarkProcessing() => ChangeStatus(PaymentStatus.Processing);
    public void MarkSucceeded() => ChangeStatus(PaymentStatus.Succeeded);
    public void MarkFailed() => ChangeStatus(PaymentStatus.Failed);
    private void ChangeStatus(PaymentStatus status) { Status = status; UpdatedAt = DateTimeOffset.UtcNow; }
}
