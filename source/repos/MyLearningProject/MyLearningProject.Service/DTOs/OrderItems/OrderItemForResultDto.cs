namespace MyLearningProject.Service.DTOs.OrderItems;

public class OrderItemForResultDto
{
    public long OrderItemId { get; set; }
    public long OrderId { get; set; }
    public long ProductId { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
}
