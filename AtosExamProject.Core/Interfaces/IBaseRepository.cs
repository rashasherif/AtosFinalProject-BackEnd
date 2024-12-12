﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AtosExamProject.Core.Interfaces

{
    public interface IBaseRepository<T> where T : class
    {
        T GetById(int id);

        Task<T> GetByIdAsync(int id);

        IEnumerable<T> GetAll();

        T Find(Expression<Func<T, bool>> match, string[] includes = null);


     

    }
}
