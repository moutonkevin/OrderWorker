using System.Collections.Generic;

namespace OrderWorkerMenulog.Models
{
    public class OrderContentModel
    {
        public IEnumerable<OrderMenuItemModel> Items { get; set; }
    }
}
