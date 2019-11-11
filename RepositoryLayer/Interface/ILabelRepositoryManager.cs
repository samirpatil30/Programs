using CommanLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Interface
{
   public interface ILabelRepositoryManager
    {
        Task<bool> AddLabel(LabelModel labelModel);

        Task<bool> UpdateLabel(LabelModel labelModel,int id);
        IList<LabelModel> GetLabel(string userId);

        Task<bool> DeleteLabel(LabelModel labelModel, int id);
    }
}
