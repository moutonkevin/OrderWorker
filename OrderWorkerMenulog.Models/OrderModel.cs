namespace OrderWorkerMenulog.Models
{
    public class OrderModel
    {
        public string OrderId { get; set; }
        public OrderCustomerModel Customer { get; set; }
        public OrderContentModel Content { get; set; }
    }
}
