using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppLogic
{
    public interface IObjectSerializerSaverAdapter
    {
        void Save(object i_Object, string i_Path);
    }
}
