using BeautySalonBusinessLogic.OfficePackage.HelperEnums;
using BeautySalonBusinessLogic.OfficePackage.HelperModels;

namespace BeautySalonBusinessLogic.OfficePackage
{
    public abstract class AbstractSaveToExcel
    {
        public abstract void CreateReport(ExcelInfoClient info);
        // Создание excel-файла
        protected abstract void CreateExcel(ExcelInfoClient info);
        /// Добавляем новую ячейку в лист
        protected abstract void InsertCellInWorksheet(ExcelCellParameters excelParams);
        /// Объединение ячеек
        protected abstract void MergeCells(ExcelMergeParameters excelParams);
        /// Сохранение файла
        protected abstract void SaveExcel(ExcelInfoClient info);

    }
}
