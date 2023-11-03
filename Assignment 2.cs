public class OrderCostCalculatorService : IOrderCostCalculatorService
{
    public async Task SaveOrderCost(int orderId, decimal noVatCost)
    {
        var orderCost = new OrderCost
        {
            OrderId = orderId,
            NoVatCost = noVatCost
        };
        CostsData.OrderCostList.Add(orderCost);

        await Task.Delay(0);
    }

    public async Task<decimal> GetOrderFinalCost(int orderId)
    {
        var orderCost = CostsData.OrderCostList.FirstOrDefault(o => o.OrderId == orderId);

        if (orderCost != null)
        {
            return await Task.FromResult(orderCost.FinalCost);
        }

        return await Task.FromResult(0m);
    }
}
