namespace p1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbBig = new System.Windows.Forms.TextBox();
            this.tbMedium = new System.Windows.Forms.TextBox();
            this.tbSmall = new System.Windows.Forms.TextBox();
            this.rbBig = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbAdd3 = new System.Windows.Forms.TextBox();
            this.tbAdd2 = new System.Windows.Forms.TextBox();
            this.tbAdd1 = new System.Windows.Forms.TextBox();
            this.cbAdd3 = new System.Windows.Forms.CheckBox();
            this.cbAdd2 = new System.Windows.Forms.CheckBox();
            this.cbAdd1 = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbDrink3Total = new System.Windows.Forms.TextBox();
            this.tbDrink2Total = new System.Windows.Forms.TextBox();
            this.tbDrink1Total = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDrink3Price = new System.Windows.Forms.TextBox();
            this.tbDrink2Price = new System.Windows.Forms.TextBox();
            this.tbDrink1Price = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDrink3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDrink2 = new System.Windows.Forms.TextBox();
            this.tbDrink1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.tbDessertPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbDessert = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tbReturn = new System.Windows.Forms.TextBox();
            this.tbPaid = new System.Windows.Forms.TextBox();
            this.tbToPay = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbBig);
            this.groupBox1.Controls.Add(this.tbMedium);
            this.groupBox1.Controls.Add(this.tbSmall);
            this.groupBox1.Controls.Add(this.rbBig);
            this.groupBox1.Controls.Add(this.rbMedium);
            this.groupBox1.Controls.Add(this.rbSmall);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Големина";
            // 
            // tbBig
            // 
            this.tbBig.Location = new System.Drawing.Point(135, 71);
            this.tbBig.Name = "tbBig";
            this.tbBig.Size = new System.Drawing.Size(59, 20);
            this.tbBig.TabIndex = 5;
            this.tbBig.Text = "500";
            this.tbBig.TextChanged += new System.EventHandler(this.tbBig_TextChanged);
            // 
            // tbMedium
            // 
            this.tbMedium.Location = new System.Drawing.Point(135, 45);
            this.tbMedium.Name = "tbMedium";
            this.tbMedium.Size = new System.Drawing.Size(59, 20);
            this.tbMedium.TabIndex = 4;
            this.tbMedium.Text = "300";
            this.tbMedium.TextChanged += new System.EventHandler(this.tbMedium_TextChanged);
            // 
            // tbSmall
            // 
            this.tbSmall.Location = new System.Drawing.Point(135, 19);
            this.tbSmall.Name = "tbSmall";
            this.tbSmall.Size = new System.Drawing.Size(59, 20);
            this.tbSmall.TabIndex = 3;
            this.tbSmall.Text = "200";
            this.tbSmall.TextChanged += new System.EventHandler(this.tbSmall_TextChanged);
            // 
            // rbBig
            // 
            this.rbBig.AutoSize = true;
            this.rbBig.Location = new System.Drawing.Point(7, 72);
            this.rbBig.Name = "rbBig";
            this.rbBig.Size = new System.Drawing.Size(63, 17);
            this.rbBig.TabIndex = 2;
            this.rbBig.TabStop = true;
            this.rbBig.Text = "Голема";
            this.rbBig.UseVisualStyleBackColor = true;
            this.rbBig.CheckedChanged += new System.EventHandler(this.rbBig_CheckedChanged);
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Location = new System.Drawing.Point(7, 46);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(62, 17);
            this.rbMedium.TabIndex = 1;
            this.rbMedium.TabStop = true;
            this.rbMedium.Text = "Средна";
            this.rbMedium.UseVisualStyleBackColor = true;
            this.rbMedium.CheckedChanged += new System.EventHandler(this.rbMedium_CheckedChanged);
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Location = new System.Drawing.Point(7, 20);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(52, 17);
            this.rbSmall.TabIndex = 0;
            this.rbSmall.TabStop = true;
            this.rbSmall.Text = "Мала";
            this.rbSmall.UseVisualStyleBackColor = true;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbAdd3);
            this.groupBox2.Controls.Add(this.tbAdd2);
            this.groupBox2.Controls.Add(this.tbAdd1);
            this.groupBox2.Controls.Add(this.cbAdd3);
            this.groupBox2.Controls.Add(this.cbAdd2);
            this.groupBox2.Controls.Add(this.cbAdd1);
            this.groupBox2.Location = new System.Drawing.Point(218, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Додатоци";
            // 
            // tbAdd3
            // 
            this.tbAdd3.Location = new System.Drawing.Point(135, 68);
            this.tbAdd3.Name = "tbAdd3";
            this.tbAdd3.Size = new System.Drawing.Size(59, 20);
            this.tbAdd3.TabIndex = 8;
            this.tbAdd3.Text = "20";
            this.tbAdd3.TextChanged += new System.EventHandler(this.tbAdd3_TextChanged);
            // 
            // tbAdd2
            // 
            this.tbAdd2.Location = new System.Drawing.Point(135, 42);
            this.tbAdd2.Name = "tbAdd2";
            this.tbAdd2.Size = new System.Drawing.Size(59, 20);
            this.tbAdd2.TabIndex = 7;
            this.tbAdd2.Text = "30";
            this.tbAdd2.TextChanged += new System.EventHandler(this.tbAdd2_TextChanged);
            // 
            // tbAdd1
            // 
            this.tbAdd1.Location = new System.Drawing.Point(135, 16);
            this.tbAdd1.Name = "tbAdd1";
            this.tbAdd1.Size = new System.Drawing.Size(59, 20);
            this.tbAdd1.TabIndex = 6;
            this.tbAdd1.Text = "40";
            this.tbAdd1.TextChanged += new System.EventHandler(this.tbAdd1_TextChanged);
            // 
            // cbAdd3
            // 
            this.cbAdd3.AutoSize = true;
            this.cbAdd3.Location = new System.Drawing.Point(6, 70);
            this.cbAdd3.Name = "cbAdd3";
            this.cbAdd3.Size = new System.Drawing.Size(56, 17);
            this.cbAdd3.TabIndex = 2;
            this.cbAdd3.Text = "Кечап";
            this.cbAdd3.UseVisualStyleBackColor = true;
            this.cbAdd3.CheckedChanged += new System.EventHandler(this.cbAdd3_CheckedChanged);
            // 
            // cbAdd2
            // 
            this.cbAdd2.AutoSize = true;
            this.cbAdd2.Location = new System.Drawing.Point(6, 44);
            this.cbAdd2.Name = "cbAdd2";
            this.cbAdd2.Size = new System.Drawing.Size(105, 17);
            this.cbAdd2.TabIndex = 1;
            this.cbAdd2.Text = "Екстра сирење";
            this.cbAdd2.UseVisualStyleBackColor = true;
            this.cbAdd2.CheckedChanged += new System.EventHandler(this.cbAdd2_CheckedChanged);
            // 
            // cbAdd1
            // 
            this.cbAdd1.AutoSize = true;
            this.cbAdd1.Location = new System.Drawing.Point(6, 18);
            this.cbAdd1.Name = "cbAdd1";
            this.cbAdd1.Size = new System.Drawing.Size(87, 17);
            this.cbAdd1.TabIndex = 0;
            this.cbAdd1.Text = "Фиферонки";
            this.cbAdd1.UseVisualStyleBackColor = true;
            this.cbAdd1.CheckedChanged += new System.EventHandler(this.cbAdd1_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.tbDrink3Total);
            this.groupBox3.Controls.Add(this.tbDrink2Total);
            this.groupBox3.Controls.Add(this.tbDrink1Total);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.tbDrink3Price);
            this.groupBox3.Controls.Add(this.tbDrink2Price);
            this.groupBox3.Controls.Add(this.tbDrink1Price);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.tbDrink3);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.tbDrink2);
            this.groupBox3.Controls.Add(this.tbDrink1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(12, 118);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(406, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Пијалок";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(322, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Вкупно";
            // 
            // tbDrink3Total
            // 
            this.tbDrink3Total.Location = new System.Drawing.Point(325, 76);
            this.tbDrink3Total.Name = "tbDrink3Total";
            this.tbDrink3Total.ReadOnly = true;
            this.tbDrink3Total.Size = new System.Drawing.Size(59, 20);
            this.tbDrink3Total.TabIndex = 16;
            this.tbDrink3Total.Text = "0";
            this.tbDrink3Total.TextChanged += new System.EventHandler(this.tbDrink3Total_TextChanged);
            // 
            // tbDrink2Total
            // 
            this.tbDrink2Total.Location = new System.Drawing.Point(325, 50);
            this.tbDrink2Total.Name = "tbDrink2Total";
            this.tbDrink2Total.ReadOnly = true;
            this.tbDrink2Total.Size = new System.Drawing.Size(59, 20);
            this.tbDrink2Total.TabIndex = 15;
            this.tbDrink2Total.Text = "0";
            this.tbDrink2Total.TextChanged += new System.EventHandler(this.tbDrink2Total_TextChanged);
            // 
            // tbDrink1Total
            // 
            this.tbDrink1Total.Location = new System.Drawing.Point(325, 24);
            this.tbDrink1Total.Name = "tbDrink1Total";
            this.tbDrink1Total.ReadOnly = true;
            this.tbDrink1Total.Size = new System.Drawing.Size(59, 20);
            this.tbDrink1Total.TabIndex = 14;
            this.tbDrink1Total.Text = "0";
            this.tbDrink1Total.TextChanged += new System.EventHandler(this.tbDrink1Total_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(237, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Цена";
            // 
            // tbDrink3Price
            // 
            this.tbDrink3Price.Location = new System.Drawing.Point(240, 76);
            this.tbDrink3Price.Name = "tbDrink3Price";
            this.tbDrink3Price.Size = new System.Drawing.Size(59, 20);
            this.tbDrink3Price.TabIndex = 12;
            this.tbDrink3Price.Text = "80";
            this.tbDrink3Price.TextChanged += new System.EventHandler(this.tbDrink3Price_TextChanged);
            // 
            // tbDrink2Price
            // 
            this.tbDrink2Price.Location = new System.Drawing.Point(240, 50);
            this.tbDrink2Price.Name = "tbDrink2Price";
            this.tbDrink2Price.Size = new System.Drawing.Size(59, 20);
            this.tbDrink2Price.TabIndex = 11;
            this.tbDrink2Price.Text = "70";
            this.tbDrink2Price.TextChanged += new System.EventHandler(this.tbDrink2Price_TextChanged);
            // 
            // tbDrink1Price
            // 
            this.tbDrink1Price.Location = new System.Drawing.Point(240, 24);
            this.tbDrink1Price.Name = "tbDrink1Price";
            this.tbDrink1Price.Size = new System.Drawing.Size(59, 20);
            this.tbDrink1Price.TabIndex = 10;
            this.tbDrink1Price.Text = "60";
            this.tbDrink1Price.TextChanged += new System.EventHandler(this.tbDrink1Price_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(153, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Количина";
            // 
            // tbDrink3
            // 
            this.tbDrink3.Location = new System.Drawing.Point(156, 76);
            this.tbDrink3.Name = "tbDrink3";
            this.tbDrink3.Size = new System.Drawing.Size(59, 20);
            this.tbDrink3.TabIndex = 8;
            this.tbDrink3.Text = "0";
            this.tbDrink3.TextChanged += new System.EventHandler(this.tbDrink3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Пиво";
            // 
            // tbDrink2
            // 
            this.tbDrink2.Location = new System.Drawing.Point(156, 50);
            this.tbDrink2.Name = "tbDrink2";
            this.tbDrink2.Size = new System.Drawing.Size(59, 20);
            this.tbDrink2.TabIndex = 7;
            this.tbDrink2.Text = "0";
            this.tbDrink2.TextChanged += new System.EventHandler(this.tbDrink2_TextChanged);
            // 
            // tbDrink1
            // 
            this.tbDrink1.Location = new System.Drawing.Point(156, 24);
            this.tbDrink1.Name = "tbDrink1";
            this.tbDrink1.Size = new System.Drawing.Size(59, 20);
            this.tbDrink1.TabIndex = 6;
            this.tbDrink1.Text = "0";
            this.tbDrink1.TextChanged += new System.EventHandler(this.tbDrink1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Сок од јаболко / портокал";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Кока кола / Фанта / Спрајт";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnCancel);
            this.groupBox4.Controls.Add(this.btnOrder);
            this.groupBox4.Controls.Add(this.tbDessertPrice);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.lbDessert);
            this.groupBox4.Location = new System.Drawing.Point(12, 224);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 123);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Десерт";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(110, 93);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Откажи";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(110, 64);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(84, 23);
            this.btnOrder.TabIndex = 3;
            this.btnOrder.Text = "Нарачај";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // tbDessertPrice
            // 
            this.tbDessertPrice.Location = new System.Drawing.Point(110, 37);
            this.tbDessertPrice.Name = "tbDessertPrice";
            this.tbDessertPrice.Size = new System.Drawing.Size(84, 20);
            this.tbDessertPrice.TabIndex = 2;
            this.tbDessertPrice.TextChanged += new System.EventHandler(this.tbDessertPrice_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(107, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Цена на десерт";
            // 
            // lbDessert
            // 
            this.lbDessert.FormattingEnabled = true;
            this.lbDessert.Items.AddRange(new object[] {
            "Овошна пита",
            "Сладолед",
            "Торта"});
            this.lbDessert.Location = new System.Drawing.Point(8, 20);
            this.lbDessert.Name = "lbDessert";
            this.lbDessert.Size = new System.Drawing.Size(92, 95);
            this.lbDessert.TabIndex = 0;
            this.lbDessert.SelectedIndexChanged += new System.EventHandler(this.lbDessert_SelectedIndexChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tbReturn);
            this.groupBox5.Controls.Add(this.tbPaid);
            this.groupBox5.Controls.Add(this.tbToPay);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Location = new System.Drawing.Point(218, 224);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 123);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Наплата";
            // 
            // tbReturn
            // 
            this.tbReturn.Location = new System.Drawing.Point(124, 91);
            this.tbReturn.Name = "tbReturn";
            this.tbReturn.ReadOnly = true;
            this.tbReturn.Size = new System.Drawing.Size(70, 20);
            this.tbReturn.TabIndex = 5;
            this.tbReturn.Text = "0";
            // 
            // tbPaid
            // 
            this.tbPaid.Location = new System.Drawing.Point(124, 56);
            this.tbPaid.Name = "tbPaid";
            this.tbPaid.Size = new System.Drawing.Size(70, 20);
            this.tbPaid.TabIndex = 4;
            this.tbPaid.Text = "0";
            this.tbPaid.TextChanged += new System.EventHandler(this.tbPaid_TextChanged);
            // 
            // tbToPay
            // 
            this.tbToPay.Location = new System.Drawing.Point(124, 12);
            this.tbToPay.Name = "tbToPay";
            this.tbToPay.ReadOnly = true;
            this.tbToPay.Size = new System.Drawing.Size(70, 20);
            this.tbToPay.TabIndex = 3;
            this.tbToPay.Text = "200";
            this.tbToPay.TextChanged += new System.EventHandler(this.tbToPay_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "За враќање:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Наплатено:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Вкупно за плаќање:";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnOrder;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(431, 372);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Нарака на пица";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rbBig;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.TextBox tbBig;
        private System.Windows.Forms.TextBox tbMedium;
        private System.Windows.Forms.TextBox tbSmall;
        private System.Windows.Forms.CheckBox cbAdd3;
        private System.Windows.Forms.CheckBox cbAdd2;
        private System.Windows.Forms.CheckBox cbAdd1;
        private System.Windows.Forms.TextBox tbAdd3;
        private System.Windows.Forms.TextBox tbAdd2;
        private System.Windows.Forms.TextBox tbAdd1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbDrink3Total;
        private System.Windows.Forms.TextBox tbDrink2Total;
        private System.Windows.Forms.TextBox tbDrink1Total;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbDrink3Price;
        private System.Windows.Forms.TextBox tbDrink2Price;
        private System.Windows.Forms.TextBox tbDrink1Price;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbDrink3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDrink2;
        private System.Windows.Forms.TextBox tbDrink1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.TextBox tbDessertPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lbDessert;
        private System.Windows.Forms.TextBox tbReturn;
        private System.Windows.Forms.TextBox tbPaid;
        private System.Windows.Forms.TextBox tbToPay;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}

