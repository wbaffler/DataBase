using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public interface IConnector
    {
        List<string> Row(int id);
        void Delete(int id);
    }
}
