using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiManager9000.DataAccess.Interface
{
    public interface IDatabase<T>
    {
        void Insert(T item);

        void Remove(T item);

        void Update(T item);

        List<T> GetAll();
    }
}
