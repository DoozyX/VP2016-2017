using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnDelAllProd_Click(object sender, EventArgs e) {
            if (
                MessageBox.Show("Дали сте сигурни дека сакате да ја испразните листата со продукти?",
                    "Испразни ја листата?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                lbProducts.Items.Clear();
            }
        }

        private void btnAddNewProduct_Click(object sender, EventArgs e) {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            if (form2.DialogResult == DialogResult.OK) {
                lbProducts.Items.Add(form2.product);
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e) {
            if (lbProducts.SelectedIndex != -1) {
                lbProducts.Items.RemoveAt(lbProducts.SelectedIndex);
            }
        }

        private void lbProducts_SelectedIndexChanged(object sender, EventArgs e) {
            if (lbProducts.SelectedIndex == -1) {
                tbName.Text = "";
                tbCategory.Text = "";
                tbPrice.Text = "";
            } else {
                Product product = lbProducts.SelectedItem as Product;
                tbName.Text = product.Name;
                tbCategory.Text = product.Category;
                tbPrice.Text = product.Price.ToString();
            }
        }

        private void btnAddToCart_Click(object sender, EventArgs e) {
            if (lbProducts.SelectedIndex != -1) {
                Product product = lbProducts.SelectedItem as Product;
                ProductItem productItem = new ProductItem(product, (int)nupQuantity.Value);
                lbCart.Items.Add(productItem);
            }
        }

        private void btnDelAllCart_Click(object sender, EventArgs e) {
            if (
                MessageBox.Show("Дали сте сигурни дека сакате да ја испразните листата со продукти?",
                    "Испразни ја листата?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                lbCart.Items.Clear();
            }
        }
    }
}