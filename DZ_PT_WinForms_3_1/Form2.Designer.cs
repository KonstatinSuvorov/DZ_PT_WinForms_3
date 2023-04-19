using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_PT_WinForms_3_1
{
    partial class Form2
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
            this.btnSearchF2 = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.textBoxF2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSearchF2
            // 
            this.btnSearchF2.Location = new System.Drawing.Point(197, 226);
            this.btnSearchF2.Name = "btnSearchF2";
            this.btnSearchF2.Size = new System.Drawing.Size(75, 23);
            this.btnSearchF2.TabIndex = 1;
            this.btnSearchF2.Text = "Поиск";
            this.btnSearchF2.UseMnemonic = false;
            this.btnSearchF2.UseVisualStyleBackColor = true;
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(0, 0);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(284, 199);
            this.listBox.TabIndex = 2;
            // 
            // textBoxF2
            // 
            this.textBoxF2.Location = new System.Drawing.Point(13, 228);
            this.textBoxF2.Name = "textBoxF2";
            this.textBoxF2.Size = new System.Drawing.Size(178, 20);
            this.textBoxF2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Вводите маску поиска, например «*.doc».";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxF2);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.btnSearchF2);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Окно поиска";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        private System.Windows.Forms.Button btnSearchF2;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.TextBox textBoxF2;
        private System.Windows.Forms.Label label1;
    }
}
