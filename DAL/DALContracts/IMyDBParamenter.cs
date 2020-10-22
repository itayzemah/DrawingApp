using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.DALContracts
{
    public interface IMyDBParamenter
    {
        string ParameterName { get; set; }
        object Value { get; set; }
    }
}
