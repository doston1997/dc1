using ClothingClass;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ClassLibrary1
{
    class ClothingDeliveryHelper
    {
        private static readonly XmlSerializer food = new XmlSerializer(typeof(clothing));
        public static void WriteToFile(string fileName, clothing data)
        {
            using (var fileStream = File.Create(fileName))
            {
                food.Serialize(fileStream, data);
            }
        }

        public static clothing LoadFromFile(string fileName)
        {
            using (var fileStream = File.OpenRead(fileName))
            {
                return (clothing)food.Deserialize(fileStream);
            }
        }
    }
}
