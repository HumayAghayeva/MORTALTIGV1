﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mortaltig.Domain.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> ListAsync();
        Task<T> FindByIdAsync(int id);
        Task AddAsync(T entity);
        void Update(T entity);
        IList<T> GetAllList();
        void Delete(T entity);
    }
}
