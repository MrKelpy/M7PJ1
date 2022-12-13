using System.ComponentModel;

namespace M7PJ1.gui
{
    partial class Main
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
            this.layout = new System.Windows.Forms.Panel();
            this.menuLayout = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnNewListing = new System.Windows.Forms.Button();
            this.btnDeleteListing = new System.Windows.Forms.Button();
            this.btnEditListing = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.layout.SuspendLayout();
            this.menuLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // layout
            // 
            this.layout.BackColor = System.Drawing.Color.Transparent;
            this.layout.BackgroundImage = global::M7PJ1.Properties.Resources.selectionbg;
            this.layout.Controls.Add(this.menuLayout);
            this.layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout.Location = new System.Drawing.Point(0, 0);
            this.layout.Name = "layout";
            this.layout.Size = new System.Drawing.Size(800, 450);
            this.layout.TabIndex = 0;
            // 
            // menuLayout
            // 
            this.menuLayout.Controls.Add(this.btnClear);
            this.menuLayout.Controls.Add(this.btnNewListing);
            this.menuLayout.Controls.Add(this.btnDeleteListing);
            this.menuLayout.Controls.Add(this.btnEditListing);
            this.menuLayout.Controls.Add(this.btnHistory);
            this.menuLayout.Controls.Add(this.btnOrders);
            this.menuLayout.Controls.Add(this.btnHome);
            this.menuLayout.Location = new System.Drawing.Point(2, 1);
            this.menuLayout.Name = "menuLayout";
            this.menuLayout.Size = new System.Drawing.Size(797, 59);
            this.menuLayout.TabIndex = 1;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClear.Location = new System.Drawing.Point(380, 11);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(97, 40);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Cancelar Compra";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnNewListing
            // 
            this.btnNewListing.BackColor = System.Drawing.Color.Transparent;
            this.btnNewListing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewListing.FlatAppearance.BorderSize = 0;
            this.btnNewListing.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnNewListing.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnNewListing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewListing.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNewListing.Location = new System.Drawing.Point(483, 11);
            this.btnNewListing.Name = "btnNewListing";
            this.btnNewListing.Size = new System.Drawing.Size(97, 40);
            this.btnNewListing.TabIndex = 5;
            this.btnNewListing.Text = "Novo Artigo";
            this.btnNewListing.UseVisualStyleBackColor = false;
            this.btnNewListing.Click += new System.EventHandler(this.btnNewListing_Click);
            // 
            // btnDeleteListing
            // 
            this.btnDeleteListing.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteListing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteListing.FlatAppearance.BorderSize = 0;
            this.btnDeleteListing.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDeleteListing.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDeleteListing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteListing.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDeleteListing.Location = new System.Drawing.Point(586, 11);
            this.btnDeleteListing.Name = "btnDeleteListing";
            this.btnDeleteListing.Size = new System.Drawing.Size(97, 40);
            this.btnDeleteListing.TabIndex = 4;
            this.btnDeleteListing.Text = "Apagar Artigo";
            this.btnDeleteListing.UseVisualStyleBackColor = false;
            this.btnDeleteListing.Click += new System.EventHandler(this.btnDeleteListing_Click);
            // 
            // btnEditListing
            // 
            this.btnEditListing.BackColor = System.Drawing.Color.Transparent;
            this.btnEditListing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditListing.FlatAppearance.BorderSize = 0;
            this.btnEditListing.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEditListing.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEditListing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditListing.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEditListing.Location = new System.Drawing.Point(689, 11);
            this.btnEditListing.Name = "btnEditListing";
            this.btnEditListing.Size = new System.Drawing.Size(97, 40);
            this.btnEditListing.TabIndex = 3;
            this.btnEditListing.Text = "Editar Artigo";
            this.btnEditListing.UseVisualStyleBackColor = false;
            this.btnEditListing.Click += new System.EventHandler(this.btnEditListing_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.BackColor = System.Drawing.Color.Transparent;
            this.btnHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHistory.FlatAppearance.BorderSize = 0;
            this.btnHistory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistory.ForeColor = System.Drawing.SystemColors.Control;
            this.btnHistory.Location = new System.Drawing.Point(218, 11);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(97, 40);
            this.btnHistory.TabIndex = 2;
            this.btnHistory.Text = "Histórico";
            this.btnHistory.UseVisualStyleBackColor = false;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.BackColor = System.Drawing.Color.Transparent;
            this.btnOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrders.FlatAppearance.BorderSize = 0;
            this.btnOrders.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnOrders.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrders.ForeColor = System.Drawing.SystemColors.Control;
            this.btnOrders.Location = new System.Drawing.Point(115, 11);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(97, 40);
            this.btnOrders.TabIndex = 1;
            this.btnOrders.Text = "Pedidos";
            this.btnOrders.UseVisualStyleBackColor = false;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.ForeColor = System.Drawing.SystemColors.Control;
            this.btnHome.Location = new System.Drawing.Point(12, 11);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(97, 40);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.layout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Main";
            this.Text = "AEFC Food Tray";
            this.layout.ResumeLayout(false);
            this.menuLayout.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnClear;

        private System.Windows.Forms.Button btnDeleteListing;
        private System.Windows.Forms.Button btnNewListing;

        private System.Windows.Forms.Button btnEditListing;

        private System.Windows.Forms.Button btnHistory;

        private System.Windows.Forms.Button btnOrders;

        private System.Windows.Forms.Panel menuLayout;

        private System.Windows.Forms.Button btnHome;

        private System.Windows.Forms.Panel layout;

        #endregion
    }
}