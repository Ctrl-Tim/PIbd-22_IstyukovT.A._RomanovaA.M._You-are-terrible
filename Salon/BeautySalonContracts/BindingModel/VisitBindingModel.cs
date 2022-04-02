using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalonContracts.BindingModel
{
    public class VisitBindingModel
    {
		public int? Id { get; set; }
		public int? ClientId { get; set; }
		public DateTime Data { get; set; }
		public Dictionary<int, (string, decimal)> VisitProcedures { get; set; }
	}
}
