using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDWinFormsMVP.Models
{
   public interface IClientRepository
    {
        void Add(ClientModel clientModel);
        void Edit(ClientModel clientModel);
        void Delete(ClientModel clientModel);
        IEnumerable<ClientModel> GetByValue(string value);
        IEnumerable<ClientModel> GetAll();

    }
}
