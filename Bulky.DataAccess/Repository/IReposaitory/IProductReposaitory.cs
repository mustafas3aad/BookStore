﻿using Bulky.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.DataAccess.Repository.IReposaitory
{
    public interface IProductReposaitory:IReposaitory<Product>
    {
        void update(Product obj);
    }
}
