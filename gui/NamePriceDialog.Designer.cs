using System.ComponentModel;

namespace M7PJ1.gui
{
    partial class NamePriceDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.lblListingName = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.nameLayout = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.priceLayout = new System.Windows.Forms.Panel();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblListingPrice = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.nameLayout.SuspendLayout();
            this.priceLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblListingName
            // 
            this.lblListingName.BackColor = System.Drawing.Color.Transparent;
            this.lblListingName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListingName.Location = new System.Drawing.Point(8, 10);
            this.lblListingName.Name = "lblListingName";
            this.lblListingName.Size = new System.Drawing.Size(277, 25);
            this.lblListingName.TabIndex = 0;
            this.lblListingName.Text = "Nome do Artigo (0/35)";
            this.lblListingName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(277, 42);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Titulo";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameLayout
            // 
            this.nameLayout.BackColor = System.Drawing.Color.Transparent;
            this.nameLayout.Controls.Add(this.txtName);
            this.nameLayout.Controls.Add(this.lblListingName);
            this.nameLayout.Location = new System.Drawing.Point(4, 69);
            this.nameLayout.Name = "nameLayout";
            this.nameLayout.Size = new System.Drawing.Size(295, 73);
            this.nameLayout.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.ForeColor = System.Drawing.Color.Firebrick;
            this.txtName.Location = new System.Drawing.Point(8, 38);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(277, 20);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // priceLayout
            // 
            this.priceLayout.BackColor = System.Drawing.Color.Transparent;
            this.priceLayout.Controls.Add(this.txtPrice);
            this.priceLayout.Controls.Add(this.lblListingPrice);
            this.priceLayout.Location = new System.Drawing.Point(4, 148);
            this.priceLayout.Name = "priceLayout";
            this.priceLayout.Size = new System.Drawing.Size(295, 73);
            this.priceLayout.TabIndex = 3;
            this.priceLayout.Visible = false;
            // 
            // txtPrice
            // 
            this.txtPrice.ForeColor = System.Drawing.Color.Firebrick;
            this.txtPrice.Location = new System.Drawing.Point(8, 38);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(277, 20);
            this.txtPrice.TabIndex = 1;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // lblListingPrice
            // 
            this.lblListingPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblListingPrice.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListingPrice.Location = new System.Drawing.Point(8, 10);
            this.lblListingPrice.Name = "lblListingPrice";
            this.lblListingPrice.Size = new System.Drawing.Size(277, 25);
            this.lblListingPrice.TabIndex = 0;
            this.lblListingPrice.Text = "Preço do Artigo";
            this.lblListingPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(12, 238);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(127, 44);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(162, 238);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(127, 44);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // NamePriceDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::M7PJ1.Properties.Resources.selectionbg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(301, 294);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.priceLayout);
            this.Controls.Add(this.nameLayout);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NamePriceDialog";
            this.Text = "NamePriceDialog";
            this.nameLayout.ResumeLayout(false);
            this.nameLayout.PerformLayout();
            this.priceLayout.ResumeLayout(false);
            this.priceLayout.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Panel priceLayout;
        private System.Windows.Forms.TextBox txtPrice;

        private System.Windows.Forms.Panel nameLayout;

        private System.Windows.Forms.Label lblListingName;
        private System.Windows.Forms.Label lblListingPrice;
        private System.Windows.Forms.Label lblTitle;

        #endregion
    }
}