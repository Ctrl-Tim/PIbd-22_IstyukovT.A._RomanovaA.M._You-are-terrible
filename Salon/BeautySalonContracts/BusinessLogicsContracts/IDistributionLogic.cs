using BeautySalonContracts.BindingModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalonContracts.BusinessLogicsContracts
{
    public interface IDistributionLogic
    {
        List<DistributionViewModel> Read(DistributionBindingModel model);
        void CreateOrUpdate(DistributionBindingModel model);
        void Delete(DistributionBindingModel model);
        public void Linking(DistributionLinkingBindingModel model);
    }
}
