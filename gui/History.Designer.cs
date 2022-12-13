using System.ComponentModel;

namespace M7PJ1.gui
{
    partial class History
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
            this.content = new System.Windows.Forms.Panel();
            this.dataHistory = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.student = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.content.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // content
            // 
            this.content.BackColor = System.Drawing.Color.Transparent;
            this.content.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.content.Controls.Add(this.dataHistory);
            this.content.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.content.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.content.Location = new System.Drawing.Point(0, 61);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(800, 389);
            this.content.TabIndex = 3;
            // 
            // dataHistory
            // 
            this.dataHistory.AllowUserToAddRows = false;
            this.dataHistory.AllowUserToDeleteRows = false;
            this.dataHistory.AllowUserToResizeColumns = false;
            this.dataHistory.AllowUserToResizeRows = false;
            this.dataHistory.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.id, this.student, this.order, this.price, this.date });
            this.dataHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataHistory.Location = new System.Drawing.Point(0, 0);
            this.dataHistory.MultiSelect = false;
            this.dataHistory.Name = "dataHistory";
            this.dataHistory.ReadOnly = true;
            this.dataHistory.RowHeadersVisible = false;
            this.dataHistory.Size = new System.Drawing.Size(800, 389);
            this.dataHistory.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // student
            // 
            this.student.HeaderText = "Aluno";
            this.student.Name = "student";
            this.student.ReadOnly = true;
            // 
            // order
            // 
            this.order.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.order.HeaderText = "Pedido";
            this.order.Name = "order";
            this.order.ReadOnly = true;
            // 
            // price
            // 
            this.price.HeaderText = "Preço";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // date
            // 
            this.date.HeaderText = "Data";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::M7PJ1.Properties.Resources.selectionbg;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.content);
            this.Name = "History";
            this.Text = "History";
            this.content.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataHistory)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridViewTextBoxColumn id;

        private System.Windows.Forms.DataGridViewTextBoxColumn price;

        private System.Windows.Forms.DataGridViewTextBoxColumn student;
        private System.Windows.Forms.DataGridViewTextBoxColumn order;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;

        private System.Windows.Forms.Panel content;
        private System.Windows.Forms.DataGridView dataHistory;

        #endregion
    }
}