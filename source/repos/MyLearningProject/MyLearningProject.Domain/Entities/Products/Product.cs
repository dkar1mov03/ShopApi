using MyLearningProject.Domain.Commons;

namespace MyLearningProject.Domain.Entities.Products;

public class Product : Auditable
{
    public long ProductId { get; set; }
    public string ProductName { get; set; }
    public decimal ProductPrice { get; set; }
    public int Quantity { get; set; }
}
