using BeautySalonContracts.BindingModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalonContracts.BusinessLogicsContracts
{
    public interface IReceiptLogic
    {
        List<ReceiptViewModel> Read(ReceiptBindingModel model);
        void CreateOrUpdate(ReceiptBindingModel model);
        void Delete(ReceiptBindingModel model);
    }
}
