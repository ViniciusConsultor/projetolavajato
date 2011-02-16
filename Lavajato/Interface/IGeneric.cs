using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HenryCorporation.Lavajato.Interface
{
   public interface IGeneric<T>
    {
        T Add(T obj);
        void Delete(T obj);
        T ByID(T obj);
        T Update(T obj);
        List<T> GetAll();
        int LastInserted();
    }
}
