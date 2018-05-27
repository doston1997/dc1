using System.IO;
using System.Xml.Serialization;

namespace ClothingClass
{
    public class ClothingDeliveryHelper
    {
        private static readonly XmlSerializer goods = new XmlSerializer(typeof(clothing));
        public static void WriteToFile(string fileName, clothing data)
        {
            using (var fileStream = File.Create(fileName))
            {
                goods.Serialize(fileStream, data);
            }
        }

        public static clothing LoadFromFile(string fileName)
        {
            using (var fileStream = File.OpenRead(fileName))
            {
                return (clothing)goods.Deserialize(fileStream);
            }
        }
        public static clothing LoadFromStream(Stream file)
        {
            return (clothing)goods.Deserialize(file);
        }
    }
}
