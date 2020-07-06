﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreSystem.Model;

namespace StoreSystem.IDAL
{
    public interface IGoodsClassMaster:IDisposable
    {
        IQueryable<GoodsClassMaster> GetAllGoodsClassMaster();
        
    }
}
