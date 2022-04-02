using BeautySalonContracts.BindingModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalonContracts.BusinessLogicsContracts
{
    public interface IReportClientLogic
    {
        // Получение списка процедур за определенный период
        public List<ReportProceduresViewModel> GetProcedures(ReportClientBindingModel model);
        // Получение списка выдач по выбранным процедурам
        public List<ReportDistributionProcedureViewModel> GetDistributionList(ReportDistributionProcedureBindingModel model);
        // Сохранение покупок в файл-Word
        public void SavePurchaseListToWordFile(ReportClientBindingModel model, string name);
        // Сохранение покупок в файл-Excel
        public void SavePurchaseListToExcelFile(ReportClientBindingModel model, string name);
        // Сохранение процедур в файл-Pdf
        public void SaveProceduresToPdfFile(ReportClientBindingModel model);
    }
}
