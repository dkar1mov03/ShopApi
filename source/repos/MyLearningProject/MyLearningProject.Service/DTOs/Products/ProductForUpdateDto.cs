namespace MyLearningProject.Service.DTOs.Products;

public class ProductForUpdateDto
{
    public long ProductId { get; set; }
    public string ProductName { get; set; }
    public decimal ProductPrice { get; set; }
    public int Quantity { get; set; }
}
