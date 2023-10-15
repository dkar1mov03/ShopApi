using MyLearningProject.Domain.Commons;

namespace MyLearningProject.Domain.Entities.Orders;

public class Order : Auditable
{
    public long OrderId { get; set; }
    public long UserId { get; set; }
    public DateTime OrderDate { get; set; }
}
