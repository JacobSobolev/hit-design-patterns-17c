using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace AppLogic
{
    public class XmlObjectSerializerLoaderAdapter : IObjectSerializerLoaderAdapter
    {
        public XmlSerializer XmlSerializerAdoptee { get; set; }

        public object Load(string i_Path)
        {
            object returnValue = null;
            if (File.Exists(i_Path))
            {
                using (FileStream stream = new FileStream(i_Path, FileMode.Open))
                {
                    returnValue = XmlSerializerAdoptee.Deserialize(stream);
                }
            }

            return returnValue;
        }
    }
}
