using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mertkXmlSerializer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Product product = new Product();
            product.Id = 1;
            product.Name = "Şampuan";
            product.Tedarikci = "Elidor";
            product.Fiyat = 15;
            Product newProduct = new Product();
            newProduct.Id = 2;
            newProduct.Name = "Deterjan";
            newProduct.Tedarikci = "Omo";
            newProduct.Fiyat = 112;
            List<Product> products = new List<Product>();
            products.Add(product);
            products.Add(newProduct);
            Type types = typeof(Product);                      
            mkXmlSerializer nSerialize = new mkXmlSerializer(typeof(Product),types);
            nSerialize.Serialize(products);



        }
    }
}
