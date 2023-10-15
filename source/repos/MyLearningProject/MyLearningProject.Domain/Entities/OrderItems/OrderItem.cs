using MyLearningProject.Domain.Commons;

namespace MyLearningProject.Domain.Entities.OrderItems;

public class OrderItem : Auditable
{
    public long OrderItemId { get; set; }
    public long OrderId { get; set; }
    public long ProductId { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
}
