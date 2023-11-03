public class OrderCost
{
    public int OrderId { get; set; }
    public decimal NoVatCost { get; set; }
    public decimal FinalCost { get { return NoVatCost * 1.24m; } }
}

public static class CostsData
{
    public static List<OrderCost> OrderCostList { get; } = new List<OrderCost>();
}
