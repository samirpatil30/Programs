using CommanLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interface
{
   public interface IUserLabelBussiness
    {
        Task<bool> AddLabel(LabelModel labelModel);
        Task<bool> UpdateLabel(LabelModel labelModelDetails, int id);
        IList<LabelModel> GetLabel(string userId);

        Task<bool> DeleteLabel(LabelModel labelModel, int id);
    }
}
