using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Controller
{
    public interface ICRUD<T>
    {
        void Create(T obj);
        T Get(int id);
        //List<T> GetAll(T);
        void Update(T obj);
        void Delete(int id);
       
    }
}
