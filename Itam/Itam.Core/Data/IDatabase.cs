using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Itam.Core.Data
{
    public interface IDatabase
    {
        IDbConnection GetOpenConnection(bool mars = false);

        IDbConnection GetClosedConnection();
    }
}
