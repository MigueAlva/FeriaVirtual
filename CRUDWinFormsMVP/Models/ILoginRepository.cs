using CRUDWinFormsMVP._Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDWinFormsMVP.Models
{
   public interface ILoginRepository
    {
        bool LoginUser(string value1, string value2);


    }
}
