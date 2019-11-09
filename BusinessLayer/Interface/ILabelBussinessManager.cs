using CommanLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interface
{
   public interface ILabelBussinessManager
    {
        Task<bool> AddLabel(LabelModel labelModel);
        Task<bool> UpdateLabel(LabelModel labelModelDetails, string labelName);
        IList<LabelModel> GetLabel(string userId);

        Task<bool> DeleteLabel(LabelModel labelModel, int id);
    }
}
