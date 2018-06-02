using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingClass
{
    public class clothing
    {
        /// <summary>
        /// Дата заполнения
        /// </summary>
        public DateTime Filled { get; set; }
        /// <summary>
        /// ФИО заказчика
        /// </summary>
        public string FullName { get; set; }
        /// <summary>
        /// Адресс доставки
        /// </summary>
        public string WayPoints { get; set; }
        /// <summary>
        /// Стоимость
        /// </summary>
        public decimal Price { get; set; }
        public Currency Currency { get; set; }
        /// <summary>
        /// Заказанная одежда
        /// </summary>
        public List<GoodsType> Goods { get; set; }
        /// <summary>
        /// Номер телефона заказчика
        /// </summary>
        public int PhoneNumber { get; set; }
    }
    public enum Currency
    {
        Rubles
    }

    public class GoodsType
    {
        public GoodsCatalog Catalog { get; set; }

        public override string ToString()
        {
            return string.Format("{0}", Catalog);
        }

        public GoodsType Clone()
        {
            return new GoodsType { Catalog = Catalog };
        }
    }
    public enum GoodsCatalog
    {
        Jeans,
        Shirts,
        Jerseys,
        Shotters,
        Jackets,
        Costumers,
    }
}
