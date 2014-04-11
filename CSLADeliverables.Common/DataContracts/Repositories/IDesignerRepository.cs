using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLADeliverables.Common.DataContracts.Repositories
{
    public interface IDesignerRepository : IRepository
    {
        IDesignerData GetDesigner(int id);
    }
}
