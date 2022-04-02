using BeautySalonContracts.BindingModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalonContracts.BusinessLogicsContracts
{
    public interface IReportLogicEmployee
    {
        // Получение списка покупок по выбранной косметике
        public List<ReportPurchaseCosmeticViewModel> GetPurchaseList(ReportEmployeeBindingModel model);
        // Получение списка косметики за определенный период
        public List<ReportCosmeticsViewModel> GetCosmetics(ReportEmployeeBindingModel model);
        // Сохранение покупок в файл-Word
        public void SavePurchaseListToWordFile(ReportEmployeeBindingModel model);
        // Сохранение покупок в файл-Excel
        public void SavePurchaseListToExcelFile(ReportEmployeeBindingModel model);
        // Сохранение косметики в файл-Pdf
        public void SaveCosmeticsToPdfFile(ReportEmployeeBindingModel model);

    }
}
