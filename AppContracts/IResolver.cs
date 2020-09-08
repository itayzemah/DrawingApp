﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ItayDrowingApp.AppContracts
{
    public interface IResolver
    {
        IT Resolve<IT>();
        object Resolve(Type type);
        IEnumerable<object> ResolveAll(Type type);
        IEnumerable<IT> ResolveAll<IT>();

       

    }
}
