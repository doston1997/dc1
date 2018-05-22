using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClothingClass;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public GoodsType goods { get; set; }
        public Form2(GoodsType goods)
        {
            this.goods = goods;
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            switch (goods.Catalog)
            {
                case GoodsCatalog.Jeans:
                    radioButton1.Checked = true;
                    break;
                case GoodsCatalog.Shirts:
                    radioButton2.Checked = true;
                    break;
                case GoodsCatalog.Jerseys:
                    radioButton3.Checked = true;
                    break;
                case GoodsCatalog.Shotters:
                    radioButton4.Checked = true;
                    break;
                case GoodsCatalog.Jackets:
                    radioButton5.Checked = true;
                    break;
                case GoodsCatalog.Costumers:
                    radioButton6.Checked = true;
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                goods.Catalog = GoodsCatalog.Jeans;
            else if (radioButton2.Checked)
                goods.Catalog = GoodsCatalog.Shirts;
            else if (radioButton3.Checked)
                goods.Catalog = GoodsCatalog.Jerseys;
            else if (radioButton4.Checked)
                goods.Catalog = GoodsCatalog.Shotters;
            else if (radioButton5.Checked)
                goods.Catalog = GoodsCatalog.Jackets;
            else if (radioButton6.Checked)
                goods.Catalog = GoodsCatalog.Costumers;
        }

    }
}
