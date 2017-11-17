using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.DB
{
    public interface IDbCRUD<T>
    {
        void Insert(T obj);
        T Get(int id);
        void Update(int id);
        void Delete(int id);
    }
}
