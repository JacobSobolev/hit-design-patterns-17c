using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace C17_Ex01
{
    [Serializable]
    public sealed class AppSettings 
    {
        private const string k_FileName = "settings.xml";
        private static readonly object sr_LockObject = new object();
        private static AppSettings s_Instance = null;

        public static AppSettings Instance
        {
            get
            {
                if (s_Instance == null)
                {
                    lock (sr_LockObject)
                    {
                        if (s_Instance == null)
                        {
                            if (File.Exists(k_FileName))
                            {
                                using (FileStream stream = new FileStream(k_FileName, FileMode.Open))
                                {
                                    XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
                                    s_Instance = (AppSettings)serializer.Deserialize(stream);
                                }
                            }
                            else
                            {
                                s_Instance = new AppSettings();
                            }
                        }
                    }
                }

                return s_Instance;
            }
        }

        public bool RemmberMe { get; set; }

        public string LastAccessToken { get; set; }

        private AppSettings()
        {
        }
       
        public void Save()
        {
            using (FileStream stream = new FileStream(k_FileName, FileMode.Create))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
                serializer.Serialize(stream, this);
            }
        }
    }
}
