﻿using ManagementSystem.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystem.Application.Repositories
{
    public interface IWriteRepository<T> : IRepository<T> where T : class
    {
        Task<bool> AddAsync(T values);
        Task<bool> AddRangeAsync(List<T> values);
        bool DeleteRange(List<T> values);
         bool Update(T values);
        Task<int> SaveAsync();
    }
}
