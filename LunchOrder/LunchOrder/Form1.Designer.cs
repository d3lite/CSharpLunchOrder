namespace LunchOrder
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
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.lblOrderTotal = new System.Windows.Forms.Label();
            this.lblSalesTax = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.gbxMainCourse = new System.Windows.Forms.GroupBox();
            this.rdbSalad = new System.Windows.Forms.RadioButton();
            this.rdbPizza = new System.Windows.Forms.RadioButton();
            this.rdbHamburger = new System.Windows.Forms.RadioButton();
            this.btnExit = new System.Windows.Forms.Button();
            this.gpbAddOnItems = new System.Windows.Forms.GroupBox();
            this.chkOption3 = new System.Windows.Forms.CheckBox();
            this.chkOption2 = new System.Windows.Forms.CheckBox();
            this.chkOption1 = new System.Windows.Forms.CheckBox();
            this.GroupBox1.SuspendLayout();
            this.gbxMainCourse.SuspendLayout();
            this.gpbAddOnItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPlaceOrder.Location = new System.Drawing.Point(265, 142);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(88, 23);
            this.btnPlaceOrder.TabIndex = 17;
            this.btnPlaceOrder.Text = "Place &Order";
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.lblOrderTotal);
            this.GroupBox1.Controls.Add(this.lblSalesTax);
            this.GroupBox1.Controls.Add(this.lblSubtotal);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Location = new System.Drawing.Point(17, 134);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(224, 104);
            this.GroupBox1.TabIndex = 21;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Order total";
            // 
            // lblOrderTotal
            // 
            this.lblOrderTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOrderTotal.Location = new System.Drawing.Point(104, 72);
            this.lblOrderTotal.Name = "lblOrderTotal";
            this.lblOrderTotal.Size = new System.Drawing.Size(88, 20);
            this.lblOrderTotal.TabIndex = 5;
            this.lblOrderTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSalesTax
            // 
            this.lblSalesTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSalesTax.Location = new System.Drawing.Point(104, 48);
            this.lblSalesTax.Name = "lblSalesTax";
            this.lblSalesTax.Size = new System.Drawing.Size(88, 20);
            this.lblSalesTax.TabIndex = 4;
            this.lblSalesTax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSubtotal.Location = new System.Drawing.Point(104, 24);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(88, 20);
            this.lblSubtotal.TabIndex = 3;
            this.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(16, 72);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(80, 16);
            this.Label3.TabIndex = 2;
            this.Label3.Text = "Order total:";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(16, 48);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(80, 16);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Tax (7.75%):";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(16, 24);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(80, 16);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Subtotal:";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbxMainCourse
            // 
            this.gbxMainCourse.Controls.Add(this.rdbSalad);
            this.gbxMainCourse.Controls.Add(this.rdbPizza);
            this.gbxMainCourse.Controls.Add(this.rdbHamburger);
            this.gbxMainCourse.Location = new System.Drawing.Point(17, 14);
            this.gbxMainCourse.Name = "gbxMainCourse";
            this.gbxMainCourse.Size = new System.Drawing.Size(144, 104);
            this.gbxMainCourse.TabIndex = 19;
            this.gbxMainCourse.TabStop = false;
            this.gbxMainCourse.Text = "Main course";
            // 
            // rdbSalad
            // 
            this.rdbSalad.AutoSize = true;
            this.rdbSalad.Location = new System.Drawing.Point(6, 65);
            this.rdbSalad.Name = "rdbSalad";
            this.rdbSalad.Size = new System.Drawing.Size(88, 17);
            this.rdbSalad.TabIndex = 0;
            this.rdbSalad.TabStop = true;
            this.rdbSalad.Text = "Salad - $4.95";
            this.rdbSalad.UseVisualStyleBackColor = true;
            this.rdbSalad.CheckedChanged += new System.EventHandler(this.rdbSalad_CheckedChanged);
            // 
            // rdbPizza
            // 
            this.rdbPizza.AutoSize = true;
            this.rdbPizza.Location = new System.Drawing.Point(6, 42);
            this.rdbPizza.Name = "rdbPizza";
            this.rdbPizza.Size = new System.Drawing.Size(86, 17);
            this.rdbPizza.TabIndex = 0;
            this.rdbPizza.TabStop = true;
            this.rdbPizza.Text = "Pizza - $5.95";
            this.rdbPizza.UseVisualStyleBackColor = true;
            this.rdbPizza.CheckedChanged += new System.EventHandler(this.rdbPizza_CheckedChanged);
            // 
            // rdbHamburger
            // 
            this.rdbHamburger.AutoSize = true;
            this.rdbHamburger.Location = new System.Drawing.Point(6, 19);
            this.rdbHamburger.Name = "rdbHamburger";
            this.rdbHamburger.Size = new System.Drawing.Size(118, 17);
            this.rdbHamburger.TabIndex = 0;
            this.rdbHamburger.TabStop = true;
            this.rdbHamburger.Text = "Hamburgers - $6.95";
            this.rdbHamburger.UseVisualStyleBackColor = true;
            this.rdbHamburger.CheckedChanged += new System.EventHandler(this.rdbHamburger_CheckedChanged);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(265, 214);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(88, 23);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "E&xit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gpbAddOnItems
            // 
            this.gpbAddOnItems.Controls.Add(this.chkOption3);
            this.gpbAddOnItems.Controls.Add(this.chkOption2);
            this.gpbAddOnItems.Controls.Add(this.chkOption1);
            this.gpbAddOnItems.Location = new System.Drawing.Point(167, 14);
            this.gpbAddOnItems.Name = "gpbAddOnItems";
            this.gpbAddOnItems.Size = new System.Drawing.Size(200, 104);
            this.gpbAddOnItems.TabIndex = 22;
            this.gpbAddOnItems.TabStop = false;
            this.gpbAddOnItems.Text = "Add-on items ($.75/each)";
            // 
            // chkOption3
            // 
            this.chkOption3.AutoSize = true;
            this.chkOption3.Location = new System.Drawing.Point(6, 65);
            this.chkOption3.Name = "chkOption3";
            this.chkOption3.Size = new System.Drawing.Size(84, 17);
            this.chkOption3.TabIndex = 0;
            this.chkOption3.Text = "French Fries";
            this.chkOption3.UseVisualStyleBackColor = true;
            this.chkOption3.CheckedChanged += new System.EventHandler(this.chkOption3_CheckedChanged);
            // 
            // chkOption2
            // 
            this.chkOption2.AutoSize = true;
            this.chkOption2.Location = new System.Drawing.Point(6, 42);
            this.chkOption2.Name = "chkOption2";
            this.chkOption2.Size = new System.Drawing.Size(161, 17);
            this.chkOption2.TabIndex = 0;
            this.chkOption2.Text = "Ketchup. mustard, and mayo";
            this.chkOption2.UseVisualStyleBackColor = true;
            this.chkOption2.CheckedChanged += new System.EventHandler(this.chkOption2_CheckedChanged);
            // 
            // chkOption1
            // 
            this.chkOption1.AutoSize = true;
            this.chkOption1.Location = new System.Drawing.Point(7, 20);
            this.chkOption1.Name = "chkOption1";
            this.chkOption1.Size = new System.Drawing.Size(158, 17);
            this.chkOption1.TabIndex = 0;
            this.chkOption1.Text = "Lettuce, tomato, and onions";
            this.chkOption1.UseVisualStyleBackColor = true;
            this.chkOption1.CheckedChanged += new System.EventHandler(this.chkOption1_CheckedChanged);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnPlaceOrder;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(377, 251);
            this.Controls.Add(this.gpbAddOnItems);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.gbxMainCourse);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lunch Order";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GroupBox1.ResumeLayout(false);
            this.gbxMainCourse.ResumeLayout(false);
            this.gbxMainCourse.PerformLayout();
            this.gpbAddOnItems.ResumeLayout(false);
            this.gpbAddOnItems.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btnPlaceOrder;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label lblOrderTotal;
        internal System.Windows.Forms.Label lblSalesTax;
        internal System.Windows.Forms.Label lblSubtotal;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.GroupBox gbxMainCourse;
        internal System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RadioButton rdbSalad;
        private System.Windows.Forms.RadioButton rdbPizza;
        private System.Windows.Forms.RadioButton rdbHamburger;
        private System.Windows.Forms.GroupBox gpbAddOnItems;
        private System.Windows.Forms.CheckBox chkOption3;
        private System.Windows.Forms.CheckBox chkOption2;
        private System.Windows.Forms.CheckBox chkOption1;
    }
}

