using BeautySalonContracts.BindingModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalonContracts.BusinessLogicsContracts
{
    internal interface IPurchaseLogic
    {
        List<PurchaseViewModel> Read(PurchaseBindingModel model);
        void CreateOrUpdate(PurchaseBindingModel model);
        void Delete(PurchaseBindingModel model);
        public void Linking(PurchaseBindingModel model);
    }
}
