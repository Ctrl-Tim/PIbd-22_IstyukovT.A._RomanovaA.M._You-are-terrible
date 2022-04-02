using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalonBusinessLogic.OfficePackage.HelperModels
{
    public class ExcelInfoClient
    {
        public string FileName { get; set; }
        public string Title { get; set; }
        public List<ReportDistributionProcedureViewModel> Distributions { get; set; }
    }
}
