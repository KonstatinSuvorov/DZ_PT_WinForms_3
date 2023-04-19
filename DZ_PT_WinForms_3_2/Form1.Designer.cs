namespace DZ_PT_WinForms_3_2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
       

        #endregion
        private void InitializeComponent()
        {
            this.ProductList = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.priceProduct = new System.Windows.Forms.TextBox();
            this.productStock = new System.Windows.Forms.ComboBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAddList = new System.Windows.Forms.Button();
            this.allPriceProduct = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxProduct = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.allPriceProductLabel = new System.Windows.Forms.Label();
            this.allPriceProductLabel2 = new System.Windows.Forms.Label();
            this.labelAllPriceProduct = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBoxProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProductList
            // 
            this.ProductList.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ProductList.ColumnWidth = 290;
            this.ProductList.FormattingEnabled = true;
            this.ProductList.IntegralHeight = false;
            this.ProductList.Location = new System.Drawing.Point(0, 0);
            this.ProductList.Name = "ProductList";
            this.ProductList.Size = new System.Drawing.Size(317, 290);
            this.ProductList.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(21, 28);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(144, 21);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Добавить товар";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // priceProduct
            // 
            this.priceProduct.Enabled = false;
            this.priceProduct.Location = new System.Drawing.Point(21, 56);
            this.priceProduct.Name = "priceProduct";
            this.priceProduct.ReadOnly = true;
            this.priceProduct.Size = new System.Drawing.Size(114, 20);
            this.priceProduct.TabIndex = 3;
            this.priceProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // productStock
            // 
            this.productStock.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.productStock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productStock.FormattingEnabled = true;
            this.productStock.Location = new System.Drawing.Point(21, 29);
            this.productStock.Name = "productStock";
            this.productStock.Size = new System.Drawing.Size(144, 21);
            this.productStock.TabIndex = 4;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(21, 55);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(144, 21);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Редактировать товар";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAddList
            // 
            this.btnAddList.Location = new System.Drawing.Point(21, 82);
            this.btnAddList.Name = "btnAddList";
            this.btnAddList.Size = new System.Drawing.Size(144, 21);
            this.btnAddList.TabIndex = 6;
            this.btnAddList.Text = "Добавить в список";
            this.btnAddList.UseVisualStyleBackColor = true;
            // 
            // allPriceProduct
            // 
            this.allPriceProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.allPriceProduct.Location = new System.Drawing.Point(344, 28);
            this.allPriceProduct.Name = "allPriceProduct";
            this.allPriceProduct.ReadOnly = true;
            this.allPriceProduct.Size = new System.Drawing.Size(114, 13);
            this.allPriceProduct.TabIndex = 8;
            this.allPriceProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.allPriceProduct.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Location = new System.Drawing.Point(323, 192);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 98);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Действия";
            // 
            // groupBoxProduct
            // 
            this.groupBoxProduct.Controls.Add(this.label1);
            this.groupBoxProduct.Controls.Add(this.productStock);
            this.groupBoxProduct.Controls.Add(this.priceProduct);
            this.groupBoxProduct.Controls.Add(this.btnAddList);
            this.groupBoxProduct.Location = new System.Drawing.Point(323, 54);
            this.groupBoxProduct.Name = "groupBoxProduct";
            this.groupBoxProduct.Size = new System.Drawing.Size(184, 118);
            this.groupBoxProduct.TabIndex = 10;
            this.groupBoxProduct.TabStop = false;
            this.groupBoxProduct.Text = "Товары";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "₽";
            // 
            // allPriceProductLabel
            // 
            this.allPriceProductLabel.AutoSize = true;
            this.allPriceProductLabel.Location = new System.Drawing.Point(354, 9);
            this.allPriceProductLabel.Name = "allPriceProductLabel";
            this.allPriceProductLabel.Size = new System.Drawing.Size(125, 13);
            this.allPriceProductLabel.TabIndex = 11;
            this.allPriceProductLabel.Text = "Цена товаров в списке";
            this.allPriceProductLabel.Visible = false;
            // 
            // allPriceProductLabel2
            // 
            this.allPriceProductLabel2.AutoSize = true;
            this.allPriceProductLabel2.Location = new System.Drawing.Point(354, 22);
            this.allPriceProductLabel2.Name = "allPriceProductLabel2";
            this.allPriceProductLabel2.Size = new System.Drawing.Size(118, 13);
            this.allPriceProductLabel2.TabIndex = 12;
            this.allPriceProductLabel2.Text = "Товаров в списке нет";
            // 
            // labelAllPriceProduct
            // 
            this.labelAllPriceProduct.AutoSize = true;
            this.labelAllPriceProduct.Location = new System.Drawing.Point(464, 31);
            this.labelAllPriceProduct.Name = "labelAllPriceProduct";
            this.labelAllPriceProduct.Size = new System.Drawing.Size(27, 13);
            this.labelAllPriceProduct.TabIndex = 14;
            this.labelAllPriceProduct.Text = "₽";
            this.labelAllPriceProduct.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 290);
            this.Controls.Add(this.labelAllPriceProduct);
            this.Controls.Add(this.allPriceProductLabel2);
            this.Controls.Add(this.allPriceProductLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxProduct);
            this.Controls.Add(this.allPriceProduct);
            this.Controls.Add(this.ProductList);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учет продаж";
            this.groupBox1.ResumeLayout(false);
            this.groupBoxProduct.ResumeLayout(false);
            this.groupBoxProduct.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        private System.Windows.Forms.ListBox ProductList;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox priceProduct;
        private System.Windows.Forms.ComboBox productStock;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAddList;
        private System.Windows.Forms.TextBox allPriceProduct;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxProduct;
        private System.Windows.Forms.Label allPriceProductLabel;
        private System.Windows.Forms.Label allPriceProductLabel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelAllPriceProduct;
    }
}

