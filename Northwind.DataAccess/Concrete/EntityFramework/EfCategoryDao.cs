﻿using Northwind.Core.DataAccess.EntityFramework;
using Northwind.DataAccess.Abstract;
using Northwind.DataAccess.Concrete.EntityFramework.Contexts;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDao : EfEntityRepositoryBase<Category,NorthwindContext>,ICategoryDao
    {
    }
}
