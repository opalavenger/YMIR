﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSoft.MVC.Interfaces.Model
{
    public interface IQueryString
    {
        
        string SelectString { get;  }
        string WhereString { get;  }
        string OrderString { get;  }

        System.Type QueryOutputModelObjectType { get;  }
    }
}
