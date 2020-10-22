using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.DALContracts
{
    public interface IMyDBConnection
    {
        public void Connect(string strConn);

    }
}
