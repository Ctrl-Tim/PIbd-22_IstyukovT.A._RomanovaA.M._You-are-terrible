using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalonContracts.BindingModel
{
    public class PurchaseBindingModel
    {
		public int? Id { get; set; }
		public int? ClientId { get; set; }
		public decimal Price { get; set; }
		public DateTime Data { get; set; }
		public Dictionary<int, (string, decimal)> PurchaseProcedures { get; set; }
		public DateTime? DateFrom { get; set; }
		public DateTime? DateTo { get; set; }
	}
}
