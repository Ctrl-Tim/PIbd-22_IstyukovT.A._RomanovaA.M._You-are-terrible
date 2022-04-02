using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalonContracts.BindingModel
{
    public class DistributionBindingModel
    {
        public int? Id { get; set; }

        public int? EmployeeId { get; set; }

        public int? VisitId { get; set; }

        public DateTime IssueDate { get; set; }

        public Dictionary<int, (string, int)> DistributionCosmetics { get; set; }

        public DateTime? DateFrom { get; set; }

        public DateTime? DateTo { get; set; }
    }
}
