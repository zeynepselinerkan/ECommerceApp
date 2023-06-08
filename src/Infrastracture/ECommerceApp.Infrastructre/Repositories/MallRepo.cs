﻿using ECommerceApp.Domain.Entities;
using ECommerceApp.Domain.Repositories;
using ECommerceApp.Infrastructre.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApp.Infrastructre.Repositories
{
    public class MallRepo : BaseRepo<Mall>, IMallRepo
    {
        public MallRepo(ECommerceAppDbContext eCommerceAppDbContext) : base(eCommerceAppDbContext)
        {
        }
    }
}
