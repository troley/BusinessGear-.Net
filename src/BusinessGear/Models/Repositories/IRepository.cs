﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessGear.Models.Repositories
{
    public interface IRepository<T>
    {
        void Add(T item);
        IEnumerable<T> GetAll();
        T Find(int key);
        void Remove(int key);
        void Update(T item);
    }
}
