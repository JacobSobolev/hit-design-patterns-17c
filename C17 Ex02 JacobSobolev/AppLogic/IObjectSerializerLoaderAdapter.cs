using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppLogic
{
    public interface IObjectSerializerLoaderAdapter
    {
        object Load(string i_Path);
    }
}
