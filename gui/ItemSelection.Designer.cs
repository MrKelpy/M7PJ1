using System.ComponentModel;

namespace M7PJ1.gui
{
    partial class ItemSelection
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
            this.dialsLayout = new System.Windows.Forms.Panel();
            this.lblErrorStudent = new System.Windows.Forms.Label();
            this.productLayout = new System.Windows.Forms.Panel();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblSelected = new System.Windows.Forms.Label();
            this.btnDecrement = new System.Windows.Forms.Button();
            this.btnIncrement = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.txtStudent = new System.Windows.Forms.TextBox();
            this.btnX = new System.Windows.Forms.Button();
            this.btnR = new System.Windows.Forms.Button();
            this.btnL = new System.Windows.Forms.Button();
            this.btnF = new System.Windows.Forms.Button();
            this.btnW = new System.Windows.Forms.Button();
            this.btnQ = new System.Windows.Forms.Button();
            this.btnK = new System.Windows.Forms.Button();
            this.btnE = new System.Windows.Forms.Button();
            this.btnV = new System.Windows.Forms.Button();
            this.btnP = new System.Windows.Forms.Button();
            this.btnJ = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.btnU = new System.Windows.Forms.Button();
            this.btnO = new System.Windows.Forms.Button();
            this.btnI = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnT = new System.Windows.Forms.Button();
            this.btnN = new System.Windows.Forms.Button();
            this.btnH = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnS = new System.Windows.Forms.Button();
            this.btnM = new System.Windows.Forms.Button();
            this.btnG = new System.Windows.Forms.Button();
            this.btnA = new System.Windows.Forms.Button();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.content.SuspendLayout();
            this.dialsLayout.SuspendLayout();
            this.productLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // content
            // 
            this.content.BackColor = System.Drawing.Color.Transparent;
            this.content.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.content.Controls.Add(this.dialsLayout);
            this.content.Controls.Add(this.btnX);
            this.content.Controls.Add(this.btnR);
            this.content.Controls.Add(this.btnL);
            this.content.Controls.Add(this.btnF);
            this.content.Controls.Add(this.btnW);
            this.content.Controls.Add(this.btnQ);
            this.content.Controls.Add(this.btnK);
            this.content.Controls.Add(this.btnE);
            this.content.Controls.Add(this.btnV);
            this.content.Controls.Add(this.btnP);
            this.content.Controls.Add(this.btnJ);
            this.content.Controls.Add(this.btnD);
            this.content.Controls.Add(this.btnU);
            this.content.Controls.Add(this.btnO);
            this.content.Controls.Add(this.btnI);
            this.content.Controls.Add(this.btnC);
            this.content.Controls.Add(this.btnT);
            this.content.Controls.Add(this.btnN);
            this.content.Controls.Add(this.btnH);
            this.content.Controls.Add(this.btnB);
            this.content.Controls.Add(this.btnS);
            this.content.Controls.Add(this.btnM);
            this.content.Controls.Add(this.btnG);
            this.content.Controls.Add(this.btnA);
            this.content.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.content.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.content.Location = new System.Drawing.Point(0, 60);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(800, 390);
            this.content.TabIndex = 2;
            // 
            // dialsLayout
            // 
            this.dialsLayout.Controls.Add(this.label2);
            this.dialsLayout.Controls.Add(this.textSearch);
            this.dialsLayout.Controls.Add(this.lblErrorStudent);
            this.dialsLayout.Controls.Add(this.productLayout);
            this.dialsLayout.Controls.Add(this.btnCheckout);
            this.dialsLayout.Controls.Add(this.label1);
            this.dialsLayout.Controls.Add(this.btnNext);
            this.dialsLayout.Controls.Add(this.btnPrevious);
            this.dialsLayout.Controls.Add(this.txtStudent);
            this.dialsLayout.Dock = System.Windows.Forms.DockStyle.Right;
            this.dialsLayout.Location = new System.Drawing.Point(588, 0);
            this.dialsLayout.Name = "dialsLayout";
            this.dialsLayout.Size = new System.Drawing.Size(212, 390);
            this.dialsLayout.TabIndex = 38;
            // 
            // lblErrorStudent
            // 
            this.lblErrorStudent.ForeColor = System.Drawing.Color.Red;
            this.lblErrorStudent.Location = new System.Drawing.Point(21, 102);
            this.lblErrorStudent.Name = "lblErrorStudent";
            this.lblErrorStudent.Size = new System.Drawing.Size(171, 19);
            this.lblErrorStudent.TabIndex = 39;
            this.lblErrorStudent.Text = "*Por favor insira um aluno.";
            this.lblErrorStudent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblErrorStudent.Visible = false;
            // 
            // productLayout
            // 
            this.productLayout.Controls.Add(this.lblPrice);
            this.productLayout.Controls.Add(this.lblSelected);
            this.productLayout.Controls.Add(this.btnDecrement);
            this.productLayout.Controls.Add(this.btnIncrement);
            this.productLayout.Controls.Add(this.btn6);
            this.productLayout.Controls.Add(this.btn5);
            this.productLayout.Controls.Add(this.btn3);
            this.productLayout.Controls.Add(this.btn2);
            this.productLayout.Controls.Add(this.lblQuantity);
            this.productLayout.Location = new System.Drawing.Point(21, 116);
            this.productLayout.Name = "productLayout";
            this.productLayout.Size = new System.Drawing.Size(171, 184);
            this.productLayout.TabIndex = 39;
            // 
            // lblPrice
            // 
            this.lblPrice.Location = new System.Drawing.Point(7, 58);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(154, 19);
            this.lblPrice.TabIndex = 39;
            this.lblPrice.Text = "Preço:";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSelected
            // 
            this.lblSelected.Location = new System.Drawing.Point(7, 14);
            this.lblSelected.Name = "lblSelected";
            this.lblSelected.Size = new System.Drawing.Size(154, 44);
            this.lblSelected.TabIndex = 38;
            this.lblSelected.Text = "Selecionado:";
            this.lblSelected.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnDecrement
            // 
            this.btnDecrement.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDecrement.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnDecrement.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnDecrement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnDecrement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecrement.Location = new System.Drawing.Point(88, 144);
            this.btnDecrement.Name = "btnDecrement";
            this.btnDecrement.Size = new System.Drawing.Size(34, 34);
            this.btnDecrement.TabIndex = 36;
            this.btnDecrement.Text = "-1";
            this.btnDecrement.UseVisualStyleBackColor = false;
            this.btnDecrement.Click += new System.EventHandler(this.OnQuantityChangeButtonClick);
            // 
            // btnIncrement
            // 
            this.btnIncrement.BackColor = System.Drawing.Color.Gainsboro;
            this.btnIncrement.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnIncrement.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnIncrement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnIncrement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncrement.Location = new System.Drawing.Point(48, 144);
            this.btnIncrement.Name = "btnIncrement";
            this.btnIncrement.Size = new System.Drawing.Size(34, 34);
            this.btnIncrement.TabIndex = 35;
            this.btnIncrement.Text = "+1";
            this.btnIncrement.UseVisualStyleBackColor = false;
            this.btnIncrement.Click += new System.EventHandler(this.OnQuantityChangeButtonClick);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.Gainsboro;
            this.btn6.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Location = new System.Drawing.Point(128, 104);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(34, 34);
            this.btn6.TabIndex = 34;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.OnQuantityChangeButtonClick);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.Gainsboro;
            this.btn5.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Location = new System.Drawing.Point(88, 104);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(34, 34);
            this.btn5.TabIndex = 33;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.OnQuantityChangeButtonClick);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.Gainsboro;
            this.btn3.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Location = new System.Drawing.Point(48, 104);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(34, 34);
            this.btn3.TabIndex = 32;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.OnQuantityChangeButtonClick);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Gainsboro;
            this.btn2.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Location = new System.Drawing.Point(8, 104);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(34, 34);
            this.btn2.TabIndex = 31;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.OnQuantityChangeButtonClick);
            // 
            // lblQuantity
            // 
            this.lblQuantity.Location = new System.Drawing.Point(8, 77);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(154, 19);
            this.lblQuantity.TabIndex = 30;
            this.lblQuantity.Text = "Quantidade:";
            this.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCheckout
            // 
            this.btnCheckout.Enabled = false;
            this.btnCheckout.Location = new System.Drawing.Point(28, 306);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(154, 34);
            this.btnCheckout.TabIndex = 28;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(28, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 19);
            this.label1.TabIndex = 27;
            this.label1.Text = "Aluno";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(109, 354);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(74, 24);
            this.btnNext.TabIndex = 26;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(28, 354);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(74, 24);
            this.btnPrevious.TabIndex = 25;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // txtStudent
            // 
            this.txtStudent.Location = new System.Drawing.Point(21, 80);
            this.txtStudent.Name = "txtStudent";
            this.txtStudent.Size = new System.Drawing.Size(171, 21);
            this.txtStudent.TabIndex = 24;
            // 
            // btnX
            // 
            this.btnX.BackColor = System.Drawing.Color.Gainsboro;
            this.btnX.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnX.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnX.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnX.Location = new System.Drawing.Point(482, 290);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(100, 100);
            this.btnX.TabIndex = 23;
            this.btnX.UseVisualStyleBackColor = false;
            // 
            // btnR
            // 
            this.btnR.BackColor = System.Drawing.Color.Gainsboro;
            this.btnR.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnR.Location = new System.Drawing.Point(482, 195);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(100, 100);
            this.btnR.TabIndex = 22;
            this.btnR.UseVisualStyleBackColor = false;
            // 
            // btnL
            // 
            this.btnL.BackColor = System.Drawing.Color.Gainsboro;
            this.btnL.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnL.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnL.Location = new System.Drawing.Point(482, 97);
            this.btnL.Name = "btnL";
            this.btnL.Size = new System.Drawing.Size(100, 100);
            this.btnL.TabIndex = 21;
            this.btnL.UseVisualStyleBackColor = false;
            // 
            // btnF
            // 
            this.btnF.BackColor = System.Drawing.Color.Gainsboro;
            this.btnF.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnF.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnF.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnF.Location = new System.Drawing.Point(482, 1);
            this.btnF.Name = "btnF";
            this.btnF.Size = new System.Drawing.Size(100, 100);
            this.btnF.TabIndex = 20;
            this.btnF.UseVisualStyleBackColor = false;
            // 
            // btnW
            // 
            this.btnW.BackColor = System.Drawing.Color.Gainsboro;
            this.btnW.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnW.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnW.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnW.Location = new System.Drawing.Point(385, 290);
            this.btnW.Name = "btnW";
            this.btnW.Size = new System.Drawing.Size(100, 100);
            this.btnW.TabIndex = 19;
            this.btnW.UseVisualStyleBackColor = false;
            // 
            // btnQ
            // 
            this.btnQ.BackColor = System.Drawing.Color.Gainsboro;
            this.btnQ.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnQ.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnQ.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQ.Location = new System.Drawing.Point(385, 195);
            this.btnQ.Name = "btnQ";
            this.btnQ.Size = new System.Drawing.Size(100, 100);
            this.btnQ.TabIndex = 18;
            this.btnQ.UseVisualStyleBackColor = false;
            // 
            // btnK
            // 
            this.btnK.BackColor = System.Drawing.Color.Gainsboro;
            this.btnK.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnK.Location = new System.Drawing.Point(385, 97);
            this.btnK.Name = "btnK";
            this.btnK.Size = new System.Drawing.Size(100, 100);
            this.btnK.TabIndex = 17;
            this.btnK.UseVisualStyleBackColor = false;
            // 
            // btnE
            // 
            this.btnE.BackColor = System.Drawing.Color.Gainsboro;
            this.btnE.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnE.Location = new System.Drawing.Point(385, 1);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(100, 100);
            this.btnE.TabIndex = 16;
            this.btnE.UseVisualStyleBackColor = false;
            // 
            // btnV
            // 
            this.btnV.BackColor = System.Drawing.Color.Gainsboro;
            this.btnV.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnV.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnV.Location = new System.Drawing.Point(288, 290);
            this.btnV.Name = "btnV";
            this.btnV.Size = new System.Drawing.Size(100, 100);
            this.btnV.TabIndex = 15;
            this.btnV.UseVisualStyleBackColor = false;
            // 
            // btnP
            // 
            this.btnP.BackColor = System.Drawing.Color.Gainsboro;
            this.btnP.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnP.Location = new System.Drawing.Point(288, 195);
            this.btnP.Name = "btnP";
            this.btnP.Size = new System.Drawing.Size(100, 100);
            this.btnP.TabIndex = 14;
            this.btnP.UseVisualStyleBackColor = false;
            // 
            // btnJ
            // 
            this.btnJ.BackColor = System.Drawing.Color.Gainsboro;
            this.btnJ.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnJ.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnJ.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnJ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJ.Location = new System.Drawing.Point(288, 97);
            this.btnJ.Name = "btnJ";
            this.btnJ.Size = new System.Drawing.Size(100, 100);
            this.btnJ.TabIndex = 13;
            this.btnJ.UseVisualStyleBackColor = false;
            // 
            // btnD
            // 
            this.btnD.BackColor = System.Drawing.Color.Gainsboro;
            this.btnD.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnD.Location = new System.Drawing.Point(288, 1);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(100, 100);
            this.btnD.TabIndex = 12;
            this.btnD.UseVisualStyleBackColor = false;
            // 
            // btnU
            // 
            this.btnU.BackColor = System.Drawing.Color.Gainsboro;
            this.btnU.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnU.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnU.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnU.Location = new System.Drawing.Point(192, 290);
            this.btnU.Name = "btnU";
            this.btnU.Size = new System.Drawing.Size(100, 100);
            this.btnU.TabIndex = 11;
            this.btnU.UseVisualStyleBackColor = false;
            // 
            // btnO
            // 
            this.btnO.BackColor = System.Drawing.Color.Gainsboro;
            this.btnO.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnO.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnO.Location = new System.Drawing.Point(192, 195);
            this.btnO.Name = "btnO";
            this.btnO.Size = new System.Drawing.Size(100, 100);
            this.btnO.TabIndex = 10;
            this.btnO.UseVisualStyleBackColor = false;
            // 
            // btnI
            // 
            this.btnI.BackColor = System.Drawing.Color.Gainsboro;
            this.btnI.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnI.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnI.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnI.Location = new System.Drawing.Point(192, 97);
            this.btnI.Name = "btnI";
            this.btnI.Size = new System.Drawing.Size(100, 100);
            this.btnI.TabIndex = 9;
            this.btnI.UseVisualStyleBackColor = false;
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.Color.Gainsboro;
            this.btnC.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnC.Location = new System.Drawing.Point(192, 1);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(100, 100);
            this.btnC.TabIndex = 8;
            this.btnC.UseVisualStyleBackColor = false;
            // 
            // btnT
            // 
            this.btnT.BackColor = System.Drawing.Color.Gainsboro;
            this.btnT.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnT.Location = new System.Drawing.Point(96, 290);
            this.btnT.Name = "btnT";
            this.btnT.Size = new System.Drawing.Size(100, 100);
            this.btnT.TabIndex = 7;
            this.btnT.UseVisualStyleBackColor = false;
            // 
            // btnN
            // 
            this.btnN.BackColor = System.Drawing.Color.Gainsboro;
            this.btnN.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnN.Location = new System.Drawing.Point(96, 195);
            this.btnN.Name = "btnN";
            this.btnN.Size = new System.Drawing.Size(100, 100);
            this.btnN.TabIndex = 6;
            this.btnN.UseVisualStyleBackColor = false;
            // 
            // btnH
            // 
            this.btnH.BackColor = System.Drawing.Color.Gainsboro;
            this.btnH.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnH.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnH.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnH.Location = new System.Drawing.Point(96, 97);
            this.btnH.Name = "btnH";
            this.btnH.Size = new System.Drawing.Size(100, 100);
            this.btnH.TabIndex = 5;
            this.btnH.UseVisualStyleBackColor = false;
            // 
            // btnB
            // 
            this.btnB.BackColor = System.Drawing.Color.Gainsboro;
            this.btnB.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnB.Location = new System.Drawing.Point(96, 1);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(100, 100);
            this.btnB.TabIndex = 4;
            this.btnB.UseVisualStyleBackColor = false;
            // 
            // btnS
            // 
            this.btnS.BackColor = System.Drawing.Color.Gainsboro;
            this.btnS.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnS.Location = new System.Drawing.Point(0, 290);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(100, 100);
            this.btnS.TabIndex = 3;
            this.btnS.UseVisualStyleBackColor = false;
            // 
            // btnM
            // 
            this.btnM.BackColor = System.Drawing.Color.Gainsboro;
            this.btnM.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnM.Location = new System.Drawing.Point(0, 195);
            this.btnM.Name = "btnM";
            this.btnM.Size = new System.Drawing.Size(100, 100);
            this.btnM.TabIndex = 2;
            this.btnM.UseVisualStyleBackColor = false;
            // 
            // btnG
            // 
            this.btnG.BackColor = System.Drawing.Color.Gainsboro;
            this.btnG.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnG.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnG.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnG.Location = new System.Drawing.Point(0, 97);
            this.btnG.Name = "btnG";
            this.btnG.Size = new System.Drawing.Size(100, 100);
            this.btnG.TabIndex = 1;
            this.btnG.UseVisualStyleBackColor = false;
            // 
            // btnA
            // 
            this.btnA.BackColor = System.Drawing.Color.Gainsboro;
            this.btnA.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnA.Location = new System.Drawing.Point(0, 1);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(100, 100);
            this.btnA.TabIndex = 0;
            this.btnA.UseVisualStyleBackColor = false;
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(63, 16);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(137, 21);
            this.textSearch.TabIndex = 40;
            this.textSearch.TextChanged += new System.EventHandler(this.textSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 19);
            this.label2.TabIndex = 41;
            this.label2.Text = "Procurar";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ItemSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::M7PJ1.Properties.Resources.selectionbg;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.content);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "ItemSelection";
            this.content.ResumeLayout(false);
            this.dialsLayout.ResumeLayout(false);
            this.dialsLayout.PerformLayout();
            this.productLayout.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label lblPrice;

        private System.Windows.Forms.Label lblErrorStudent;

        private System.Windows.Forms.Panel productLayout;

        private System.Windows.Forms.Label lblSelected;

        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;

        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Button btnV;
        private System.Windows.Forms.Button btnU;
        private System.Windows.Forms.Button btnT;
        private System.Windows.Forms.Button btnS;

        private System.Windows.Forms.Button btnW;

        private System.Windows.Forms.Panel dialsLayout;

        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblQuantity;

        private System.Windows.Forms.Button btnG;
        private System.Windows.Forms.Button btnM;
        private System.Windows.Forms.Button btnN;
        private System.Windows.Forms.Button btnH;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnO;
        private System.Windows.Forms.Button btnI;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnP;
        private System.Windows.Forms.Button btnJ;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button btnQ;
        private System.Windows.Forms.Button btnK;
        private System.Windows.Forms.Button btnE;
        private System.Windows.Forms.Button btnR;
        private System.Windows.Forms.Button btnL;
        private System.Windows.Forms.Button btnF;
        private System.Windows.Forms.TextBox txtStudent;
        private System.Windows.Forms.Button btnIncrement;
        private System.Windows.Forms.Button btnDecrement;
        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Panel content;
        private System.Windows.Forms.Button btnA;

        #endregion
    }
}