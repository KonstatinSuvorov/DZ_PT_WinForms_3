namespace DZ_PT_WinForms_3_3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxReadFile = new System.Windows.Forms.TextBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxReadFile
            // 
            this.textBoxReadFile.Location = new System.Drawing.Point(0, -1);
            this.textBoxReadFile.Multiline = true;
            this.textBoxReadFile.Name = "textBoxReadFile";
            this.textBoxReadFile.ReadOnly = true;
            this.textBoxReadFile.Size = new System.Drawing.Size(550, 250);
            this.textBoxReadFile.TabIndex = 0;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(0, 257);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(266, 42);
            this.btnUpload.TabIndex = 1;
            this.btnUpload.Text = "Загрузить файл";
            this.btnUpload.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(284, 257);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(266, 42);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Редактировать файл";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 311);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.textBoxReadFile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Текстовый редактор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxReadFile;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnEdit;
    }
}