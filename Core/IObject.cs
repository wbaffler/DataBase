using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public interface IObject
    {
        List<string> Data { get; }
        void Create();
        void Change();
        void Delete();
    }
}
