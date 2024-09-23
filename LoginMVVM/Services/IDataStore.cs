using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginMVVM.Services
{
    public interface IDataStore<T>
    {
        //Definindo metodos minimos para persistencia de dados
        Task<bool> AddAsync(T value);
        Task<bool> UpdateAsync(T value);
        Task<bool> DeleteAsync(T value);
        Task<T> GetByIdAsync(int value);
        Task<List<T>> GetAllAsync();
    }
}
