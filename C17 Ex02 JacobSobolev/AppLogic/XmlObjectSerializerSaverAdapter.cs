using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace AppLogic
{
   public class XmlObjectSerializerSaverAdapter : IObjectSerializerSaverAdapter
    {
        public XmlSerializer XmlSerializerAdoptee { get; set; }

        public void Save(object i_Object, string i_Path)
        {
            using (FileStream stream = new FileStream(i_Path, FileMode.Create))
            {
                XmlSerializerAdoptee.Serialize(stream, i_Object);
            }
        }
    }
}
