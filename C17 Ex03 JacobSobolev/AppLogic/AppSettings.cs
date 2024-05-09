using System;
using System.Xml.Serialization;

namespace AppLogic
{
    [Serializable]
    public class AppSettings
    {
        private const string k_FilePath = "settings.xml";

        public bool RemmberMe { get; set; }

        public string LastAccessToken { get; set; }

        private AppSettings()
        {
        }

        public static AppSettings LoadOrCreate()
        {
            IObjectSerializerLoaderAdapter loader = new XmlObjectSerializerLoaderAdapter() { XmlSerializerAdoptee = new XmlSerializer(typeof(AppSettings)) };
            AppSettings loaderObject = (AppSettings)loader.Load(k_FilePath);
            return loaderObject == null ? new AppSettings() : loaderObject;
        }

        public void Save()
        {
            IObjectSerializerSaverAdapter saver = new XmlObjectSerializerSaverAdapter() { XmlSerializerAdoptee = new XmlSerializer(typeof(AppSettings)) };
            saver.Save(this, k_FilePath);
        }
    }
}
