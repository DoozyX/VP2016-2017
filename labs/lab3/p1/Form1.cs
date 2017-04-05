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

        private void calculateTotal() {
            // ... vasiot kod ovde ...
            float total = 0;
            if (rbSmall.Checked) {
                float f = 0;
                float.TryParse(tbSmall.Text, out f);
                total += f;
            }
            if (rbMedium.Checked) {
                float f = 0;
                float.TryParse(tbMedium.Text, out f);
                total += f;
            }
            if (rbBig.Checked) {
                float f = 0;
                float.TryParse(tbBig.Text, out f);
                total += f;
            }

            if (cbAdd1.Checked) {
                float f = 0;
                float.TryParse(tbAdd1.Text, out f);
                total += f;
            }
            if (cbAdd2.Checked) {
                float f = 0;
                float.TryParse(tbAdd2.Text, out f);
                total += f;
            }
            if (cbAdd3.Checked) {
                float f = 0;
                float.TryParse(tbAdd3.Text, out f);
                total += f;
            }
            float n = 0;
            float.TryParse(tbDrink1Total.Text, out n);
            total += n;
            n = 0;
            float.TryParse(tbDrink2Total.Text, out n);
            total += n;
            n = 0;
            float.TryParse(tbDrink3Total.Text, out n);
            total += n;
            n = 0;
            float.TryParse(tbDessertPrice.Text, out n);
            total += n;
            tbToPay.Text = total.ToString();
        }

        private void Form1_Load(object sender, EventArgs e) {}

        private void tbSmall_TextChanged(object sender, EventArgs e) {
            calculateTotal();
        }

        private void tbMedium_TextChanged(object sender, EventArgs e) {
            calculateTotal();
        }

        private void tbBig_TextChanged(object sender, EventArgs e) {
            calculateTotal();
        }

        private void cbAdd1_CheckedChanged(object sender, EventArgs e) {
            calculateTotal();
        }

        private void cbAdd2_CheckedChanged(object sender, EventArgs e) {
            calculateTotal();
        }

        private void cbAdd3_CheckedChanged(object sender, EventArgs e) {
            calculateTotal();
        }

        private void tbDrink1Total_TextChanged(object sender, EventArgs e) {
            calculateTotal();
        }

        private void tbDrink2Total_TextChanged(object sender, EventArgs e) {
            calculateTotal();
        }

        private void tbDrink3Total_TextChanged(object sender, EventArgs e) {
            calculateTotal();
        }

        private void tbDessertPrice_TextChanged(object sender, EventArgs e) {
            calculateTotal();
        }

        private void rbSmall_CheckedChanged(object sender, EventArgs e) {
            calculateTotal();
        }

        private void rbMedium_CheckedChanged(object sender, EventArgs e) {
            calculateTotal();
        }

        private void rbBig_CheckedChanged(object sender, EventArgs e) {
            calculateTotal();
        }

        private void tbAdd1_TextChanged(object sender, EventArgs e) {
            calculateTotal();
        }

        private void tbAdd2_TextChanged(object sender, EventArgs e) {
            calculateTotal();
        }

        private void tbAdd3_TextChanged(object sender, EventArgs e) {
            calculateTotal();
        }

        private void calculateDrink1() {
            float total = 0;
            float n = 0;
            float.TryParse(tbDrink1.Text, out n);
            float p = 0;
            float.TryParse(tbDrink1Price.Text, out p);
            total = n * p;
            tbDrink1Total.Text = total.ToString();
        }

        private void tbDrink1_TextChanged(object sender, EventArgs e) {
            calculateDrink1();
        }

        private void tbDrink1Price_TextChanged(object sender, EventArgs e) {
            calculateDrink1();
        }

        private void calculateDrink2() {
            float total = 0;
            float n = 0;
            float.TryParse(tbDrink2.Text, out n);
            float p = 0;
            float.TryParse(tbDrink2Price.Text, out p);
            total = n * p;
            tbDrink2Total.Text = total.ToString();
        }

        private void tbDrink2_TextChanged(object sender, EventArgs e) {
            calculateDrink2();
        }

        private void tbDrink2Price_TextChanged(object sender, EventArgs e) {
            calculateDrink2();
        }

        private void calculateDrink3() {
            float total = 0;
            float n = 0;
            float.TryParse(tbDrink3.Text, out n);
            float p = 0;
            float.TryParse(tbDrink3Price.Text, out p);
            total = n * p;
            tbDrink3Total.Text = total.ToString();
        }

        private void tbDrink3_TextChanged(object sender, EventArgs e) {
            calculateDrink3();
        }

        private void tbDrink3Price_TextChanged(object sender, EventArgs e) {
            calculateDrink3();
        }

        private void lbDessert_SelectedIndexChanged(object sender, EventArgs e) {
            if (lbDessert.SelectedIndex == 0) {
                tbDessertPrice.Text = "80";
            }
            if (lbDessert.SelectedIndex == 1) {
                tbDessertPrice.Text = "120";
            }
            if (lbDessert.SelectedIndex == 2) {
                tbDessertPrice.Text = "160";
            }
        }

        private void calculateReturn() {
            float total = 0;
            float n = 0;
            float.TryParse(tbToPay.Text, out n);
            float p = 0;
            float.TryParse(tbPaid.Text, out p);
            total = p - n;
            tbReturn.Text = total.ToString();
        }

        private void tbToPay_TextChanged(object sender, EventArgs e) {
            calculateReturn();
        }


        private void tbPaid_TextChanged(object sender, EventArgs e) {
            calculateReturn();
        }

        private void btnOrder_Click(object sender, EventArgs e) {
            StringBuilder total = new StringBuilder();
            StringBuilder drinks = new StringBuilder();

            if (rbSmall.Checked) {
                total.Append("Мала пица\n");
            }
            if (rbMedium.Checked) {
                total.Append("Средна пица\n");
            }
            if (rbBig.Checked) {
                total.Append("Голема пица\n");
            }
            if (cbAdd1.Checked || cbAdd2.Checked || cbAdd3.Checked) {
                total.Append("\nДодатоци:\n");
            }
            if (cbAdd1.Checked) {
                total.Append("Феферонки\n");
            }
            if (cbAdd2.Checked) {
                total.Append("Екстра сирење\n");
            }
            if (cbAdd3.Checked) {
                total.Append("Кечап\n");
            }

            int n = 0;
            int.TryParse(tbDrink1.Text, out n);
            if (n != 0) {
                drinks.Append(n+ " кока кола / фанта / спрајт\n");
            }
            n = 0;
            int.TryParse(tbDrink2.Text, out n);
            if (n != 0) {
                drinks.Append(string.Format(n + " сок од портокал / јаболко\n"));
            }
            n = 0;
            int.TryParse(tbDrink3.Text, out n);
            if (n != 0) {
                drinks.Append(string.Format(n + " пиво\n"));
            }
            if (drinks.Length > 0) {
                total.Append("\nПијалок:\n");
                total.Append(drinks);
            }
            if (lbDessert.SelectedIndex != -1) {
                total.Append("\nДесерт:\n");
                total.Append(lbDessert.SelectedItem);
            }
            MessageBox.Show(total.ToString(), "Вашата нарачка");
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show("Дали сакате да ја откажете нарачката?", "Откажи нарачка?",
               MessageBoxButtons.YesNo, // vid na dijalogot 
               MessageBoxIcon.Question); // ikona na dijalogot
            if (result == DialogResult.Yes) {
                Application.Exit();
            }
        }
    }
}