using DataAccess.Abstract;

using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using Entities.Concrete;
using Core.DataAccess.EntityFramework;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfColor : EfEntityRepositoryBase<Color,CarDataContext>,IColorDal
    {
        
    }
}
