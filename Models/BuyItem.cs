using Moj.Web.Shop.Models;
using System.Text.Json.Serialization;

namespace Moj.Web.Shop.Models
{
    public class BuyItem
    {
        public int Id { get; set; }

        public int ProductId { get; set; }

        public string OrderedByName { get; set; } = null!;

        public string OrderedByEmail { get; set; } = null!;

        public string OrderId { get; set; } = null!;
        public int NumberOfItems { get; set; }

        public float PricePerProduct { get; set; }
        public int ProductDiscount { get; set; }
        public float TotalAmount { get; set; }
        public bool IsPayed { get; set; }
        public bool IsDelivered { get; set; }

        [JsonIgnore]
        public virtual Product Product { get; set; } = null!;
    }
}