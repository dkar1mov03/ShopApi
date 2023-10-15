using System.Reflection.Metadata.Ecma335;

namespace MyLearningProject.Service.DTOs.OrderItems;

public class OrderItemForCreationDto
{
    public long OrderId { get; set; }
    public long Productid { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
}
