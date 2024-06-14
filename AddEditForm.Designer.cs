namespace CarDealership
{
    partial class AddEditForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DtpManufacturingDate = new System.Windows.Forms.DateTimePicker();
            this.CbManufacturer = new System.Windows.Forms.ComboBox();
            this.BtnOk = new System.Windows.Forms.Button();
            this.TbPrice = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manufacturing date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Manufacturer";
            // 
            // DtpManufacturingDate
            // 
            this.DtpManufacturingDate.Location = new System.Drawing.Point(117, 28);
            this.DtpManufacturingDate.Name = "DtpManufacturingDate";
            this.DtpManufacturingDate.Size = new System.Drawing.Size(200, 20);
            this.DtpManufacturingDate.TabIndex = 3;
            this.DtpManufacturingDate.Validating += new System.ComponentModel.CancelEventHandler(this.DtpManufacturingDate_Validating);
            // 
            // CbManufacturer
            // 
            this.CbManufacturer.FormattingEnabled = true;
            this.CbManufacturer.Location = new System.Drawing.Point(116, 116);
            this.CbManufacturer.Name = "CbManufacturer";
            this.CbManufacturer.Size = new System.Drawing.Size(121, 21);
            this.CbManufacturer.TabIndex = 5;
            this.CbManufacturer.Validating += new System.ComponentModel.CancelEventHandler(this.CbManufacturer_Validating);
            // 
            // BtnOk
            // 
            this.BtnOk.Location = new System.Drawing.Point(116, 161);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(75, 23);
            this.BtnOk.TabIndex = 6;
            this.BtnOk.Text = "OK";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // TbPrice
            // 
            this.TbPrice.Location = new System.Drawing.Point(117, 78);
            this.TbPrice.Name = "TbPrice";
            this.TbPrice.Size = new System.Drawing.Size(120, 20);
            this.TbPrice.TabIndex = 7;
            this.TbPrice.Validating += new System.ComponentModel.CancelEventHandler(this.TbPrice_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 200);
            this.Controls.Add(this.TbPrice);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.CbManufacturer);
            this.Controls.Add(this.DtpManufacturingDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddEditForm";
            this.Text = "Car view";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DtpManufacturingDate;
        private System.Windows.Forms.ComboBox CbManufacturer;
        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.TextBox TbPrice;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}