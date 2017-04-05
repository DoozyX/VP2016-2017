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
    public partial class Form2 : Form {
        public Product product;

        public Form2() {
            InitializeComponent();
        }

        private void textBox1_Validating(object sender, CancelEventArgs e) {
            if (tbName.Text.Trim().Length == 0) {
                e.Cancel = true;
                errorProvider1.SetError(tbName, "Внесете име!");
            } else {
                errorProvider1.SetError(tbName, null);
            }
        }

        private void tbCategory_Validating(object sender, CancelEventArgs e) {
            if (tbCategory.Text.Trim().Length == 0) {
                e.Cancel = true;
                errorProvider1.SetError(tbCategory, "Внесете Категорија!");
            } else {
                errorProvider1.SetError(tbCategory, null);
            }
        }

        private void tbPrice_Validating(object sender, CancelEventArgs e) {
            if (tbPrice.Text.Trim().Length == 0) {
                e.Cancel = true;
                errorProvider1.SetError(tbPrice, "Внесете Цена!");
            } else {
                errorProvider1.SetError(tbPrice, null);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            int n = 0;
            int.TryParse(tbPrice.Text, out n);
            product = new Product(tbName.Text, tbCategory.Text, n);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}