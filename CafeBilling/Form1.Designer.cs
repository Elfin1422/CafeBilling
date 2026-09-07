namespace CafeBilling
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
            if (disposing && (components != null))
            {
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
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem(new string[] {
            "Burger",
            "P85"}, -1);
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem(new string[] {
            "Chicken Sandwich",
            "P75"}, -1);
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem(new string[] {
            "Spaghetti",
            "P95"}, -1);
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem(new string[] {
            "Fries",
            "P50"}, -1);
            System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem(new string[] {
            "SoftDrink",
            "P35"}, -1);
            System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem(new string[] {
            "Iced Tea",
            "P40"}, -1);
            System.Windows.Forms.ListViewItem listViewItem15 = new System.Windows.Forms.ListViewItem(new string[] {
            "Coffee",
            "P45"}, -1);
            System.Windows.Forms.ListViewItem listViewItem16 = new System.Windows.Forms.ListViewItem(new string[] {
            "Bottled Water",
            "P25"}, -1);
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FoodBox = new System.Windows.Forms.TextBox();
            this.ReceiptMultiBox = new System.Windows.Forms.TextBox();
            this.DrinksBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FoodQuantiBox = new System.Windows.Forms.TextBox();
            this.DrinksQuantiBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxSenior = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxOrdertype = new System.Windows.Forms.ComboBox();
            this.SubmitOrderbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem9,
            listViewItem10,
            listViewItem11,
            listViewItem12});
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(171, 112);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Foods";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Price";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader2.Width = 58;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.listView2.HideSelection = false;
            this.listView2.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem13,
            listViewItem14,
            listViewItem15,
            listViewItem16});
            this.listView2.Location = new System.Drawing.Point(12, 130);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(171, 112);
            this.listView2.TabIndex = 1;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Drinks";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Price";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FoodBox
            // 
            this.FoodBox.Location = new System.Drawing.Point(242, 131);
            this.FoodBox.Name = "FoodBox";
            this.FoodBox.Size = new System.Drawing.Size(119, 20);
            this.FoodBox.TabIndex = 2;
            this.FoodBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FoodBox.TextChanged += new System.EventHandler(this.FoodBox_TextChanged);
            // 
            // ReceiptMultiBox
            // 
            this.ReceiptMultiBox.Location = new System.Drawing.Point(575, 12);
            this.ReceiptMultiBox.Multiline = true;
            this.ReceiptMultiBox.Name = "ReceiptMultiBox";
            this.ReceiptMultiBox.Size = new System.Drawing.Size(213, 403);
            this.ReceiptMultiBox.TabIndex = 4;
            this.ReceiptMultiBox.TextChanged += new System.EventHandler(this.ReceiptMultiBox_TextChanged);
            // 
            // DrinksBox
            // 
            this.DrinksBox.Location = new System.Drawing.Point(242, 189);
            this.DrinksBox.Name = "DrinksBox";
            this.DrinksBox.Size = new System.Drawing.Size(119, 20);
            this.DrinksBox.TabIndex = 5;
            this.DrinksBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DrinksBox.TextChanged += new System.EventHandler(this.DrinksBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(275, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Foods";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(275, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Drinks";
            // 
            // FoodQuantiBox
            // 
            this.FoodQuantiBox.Location = new System.Drawing.Point(443, 131);
            this.FoodQuantiBox.Name = "FoodQuantiBox";
            this.FoodQuantiBox.Size = new System.Drawing.Size(42, 20);
            this.FoodQuantiBox.TabIndex = 9;
            this.FoodQuantiBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FoodQuantiBox.TextChanged += new System.EventHandler(this.FoodQuantiBox_TextChanged);
            // 
            // DrinksQuantiBox
            // 
            this.DrinksQuantiBox.Location = new System.Drawing.Point(443, 189);
            this.DrinksQuantiBox.Name = "DrinksQuantiBox";
            this.DrinksQuantiBox.Size = new System.Drawing.Size(42, 20);
            this.DrinksQuantiBox.TabIndex = 10;
            this.DrinksQuantiBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DrinksQuantiBox.TextChanged += new System.EventHandler(this.DrinksQuantiBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(430, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Quantity";
            // 
            // checkBoxSenior
            // 
            this.checkBoxSenior.AutoSize = true;
            this.checkBoxSenior.Location = new System.Drawing.Point(256, 224);
            this.checkBoxSenior.Name = "checkBoxSenior";
            this.checkBoxSenior.Size = new System.Drawing.Size(94, 17);
            this.checkBoxSenior.TabIndex = 12;
            this.checkBoxSenior.Text = "Senior Citezen";
            this.checkBoxSenior.UseVisualStyleBackColor = true;
            this.checkBoxSenior.CheckedChanged += new System.EventHandler(this.checkBoxSenior_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(259, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Order Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(360, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Order";
            // 
            // comboBoxOrdertype
            // 
            this.comboBoxOrdertype.FormattingEnabled = true;
            this.comboBoxOrdertype.Items.AddRange(new object[] {
            "Take - Out",
            "Dine - In",
            "Deliery"});
            this.comboBoxOrdertype.Location = new System.Drawing.Point(400, 54);
            this.comboBoxOrdertype.Name = "comboBoxOrdertype";
            this.comboBoxOrdertype.Size = new System.Drawing.Size(121, 21);
            this.comboBoxOrdertype.TabIndex = 16;
            this.comboBoxOrdertype.SelectedIndexChanged += new System.EventHandler(this.comboBoxOrdertype_SelectedIndexChanged);
            // 
            // SubmitOrderbtn
            // 
            this.SubmitOrderbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.SubmitOrderbtn.Location = new System.Drawing.Point(340, 285);
            this.SubmitOrderbtn.Name = "SubmitOrderbtn";
            this.SubmitOrderbtn.Size = new System.Drawing.Size(120, 43);
            this.SubmitOrderbtn.TabIndex = 17;
            this.SubmitOrderbtn.Text = "Submit Order";
            this.SubmitOrderbtn.UseVisualStyleBackColor = false;
            this.SubmitOrderbtn.Click += new System.EventHandler(this.SubmitOrderbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SubmitOrderbtn);
            this.Controls.Add(this.comboBoxOrdertype);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBoxSenior);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DrinksQuantiBox);
            this.Controls.Add(this.FoodQuantiBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DrinksBox);
            this.Controls.Add(this.ReceiptMultiBox);
            this.Controls.Add(this.FoodBox);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox FoodBox;
        private System.Windows.Forms.TextBox ReceiptMultiBox;
        private System.Windows.Forms.TextBox DrinksBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FoodQuantiBox;
        private System.Windows.Forms.TextBox DrinksQuantiBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxSenior;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxOrdertype;
        private System.Windows.Forms.Button SubmitOrderbtn;
    }
}

