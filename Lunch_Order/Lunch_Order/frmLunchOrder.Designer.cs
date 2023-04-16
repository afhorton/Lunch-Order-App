namespace Lunch_Order
{
    partial class frmLunchOrder
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLunchOrder));
            grpbxMainCourse = new GroupBox();
            rdoSalad = new RadioButton();
            rdoPizza = new RadioButton();
            rdoHamburger = new RadioButton();
            grpbxOrderTotal = new GroupBox();
            txtOrderTotal = new TextBox();
            txtTax = new TextBox();
            txtSubtotal = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btnPlaceOrder = new Button();
            btnReset = new Button();
            btnExit = new Button();
            grpbxHamburgerAddOns = new GroupBox();
            ckbxHamburgerAddOns3 = new CheckBox();
            ckbxHamburgerAddOns2 = new CheckBox();
            ckbxHamburgerAddOns1 = new CheckBox();
            grpbxPizzaAddOns = new GroupBox();
            ckbxPizzaAddOns3 = new CheckBox();
            ckbxPizzaAddOns2 = new CheckBox();
            ckbxPizzaAddOns1 = new CheckBox();
            grpbxSaladAddOns = new GroupBox();
            ckbxSaladAddOns3 = new CheckBox();
            ckbxSaladAddOns2 = new CheckBox();
            ckbxSaladAddOns1 = new CheckBox();
            grpbxMainCourse.SuspendLayout();
            grpbxOrderTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            grpbxHamburgerAddOns.SuspendLayout();
            grpbxPizzaAddOns.SuspendLayout();
            grpbxSaladAddOns.SuspendLayout();
            SuspendLayout();
            // 
            // grpbxMainCourse
            // 
            grpbxMainCourse.Controls.Add(rdoSalad);
            grpbxMainCourse.Controls.Add(rdoPizza);
            grpbxMainCourse.Controls.Add(rdoHamburger);
            grpbxMainCourse.Location = new Point(24, 189);
            grpbxMainCourse.Name = "grpbxMainCourse";
            grpbxMainCourse.Size = new Size(218, 130);
            grpbxMainCourse.TabIndex = 0;
            grpbxMainCourse.TabStop = false;
            grpbxMainCourse.Text = "Main Course";
            // 
            // rdoSalad
            // 
            rdoSalad.AutoSize = true;
            rdoSalad.Location = new Point(18, 87);
            rdoSalad.Name = "rdoSalad";
            rdoSalad.Size = new Size(91, 19);
            rdoSalad.TabIndex = 2;
            rdoSalad.TabStop = true;
            rdoSalad.Text = "Salad - $4.95";
            rdoSalad.UseVisualStyleBackColor = true;
            rdoSalad.CheckedChanged += rdoSalad_CheckedChanged;
            // 
            // rdoPizza
            // 
            rdoPizza.AutoSize = true;
            rdoPizza.Location = new Point(18, 62);
            rdoPizza.Name = "rdoPizza";
            rdoPizza.Size = new Size(89, 19);
            rdoPizza.TabIndex = 1;
            rdoPizza.TabStop = true;
            rdoPizza.Text = "Pizza - $5.95";
            rdoPizza.UseVisualStyleBackColor = true;
            rdoPizza.CheckedChanged += rdoPizza_CheckedChanged;
            // 
            // rdoHamburger
            // 
            rdoHamburger.AutoSize = true;
            rdoHamburger.Location = new Point(18, 37);
            rdoHamburger.Name = "rdoHamburger";
            rdoHamburger.Size = new Size(124, 19);
            rdoHamburger.TabIndex = 0;
            rdoHamburger.TabStop = true;
            rdoHamburger.Text = "Hamburger - $6.95";
            rdoHamburger.UseVisualStyleBackColor = true;
            rdoHamburger.CheckedChanged += rdoHamburger_CheckedChanged;
            // 
            // grpbxOrderTotal
            // 
            grpbxOrderTotal.Controls.Add(txtOrderTotal);
            grpbxOrderTotal.Controls.Add(txtTax);
            grpbxOrderTotal.Controls.Add(txtSubtotal);
            grpbxOrderTotal.Controls.Add(label4);
            grpbxOrderTotal.Controls.Add(label3);
            grpbxOrderTotal.Controls.Add(label2);
            grpbxOrderTotal.Location = new Point(24, 340);
            grpbxOrderTotal.Name = "grpbxOrderTotal";
            grpbxOrderTotal.Size = new Size(269, 130);
            grpbxOrderTotal.TabIndex = 1;
            grpbxOrderTotal.TabStop = false;
            grpbxOrderTotal.Text = "Order Total";
            // 
            // txtOrderTotal
            // 
            txtOrderTotal.Location = new Point(99, 89);
            txtOrderTotal.Name = "txtOrderTotal";
            txtOrderTotal.ReadOnly = true;
            txtOrderTotal.Size = new Size(100, 23);
            txtOrderTotal.TabIndex = 5;
            // 
            // txtTax
            // 
            txtTax.Location = new Point(99, 55);
            txtTax.Name = "txtTax";
            txtTax.ReadOnly = true;
            txtTax.Size = new Size(100, 23);
            txtTax.TabIndex = 4;
            // 
            // txtSubtotal
            // 
            txtSubtotal.Location = new Point(99, 23);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.ReadOnly = true;
            txtSubtotal.Size = new Size(100, 23);
            txtSubtotal.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 97);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 2;
            label4.Text = "Order Total:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 63);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 1;
            label3.Text = "Tax (5%):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 31);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 0;
            label2.Text = "Subtotal:";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(24, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(145, 139);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(175, 88);
            label1.Name = "label1";
            label1.Size = new Size(318, 45);
            label1.TabIndex = 3;
            label1.Text = "Microsoft Lunch '98";
            // 
            // btnPlaceOrder
            // 
            btnPlaceOrder.Location = new Point(342, 340);
            btnPlaceOrder.Name = "btnPlaceOrder";
            btnPlaceOrder.Size = new Size(88, 32);
            btnPlaceOrder.TabIndex = 4;
            btnPlaceOrder.Text = "&Place Order";
            btnPlaceOrder.UseVisualStyleBackColor = true;
            btnPlaceOrder.Click += btnPlaceOrder_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(342, 389);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(88, 32);
            btnReset.TabIndex = 5;
            btnReset.Text = "&Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(342, 437);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(88, 32);
            btnExit.TabIndex = 6;
            btnExit.Text = "&Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // grpbxHamburgerAddOns
            // 
            grpbxHamburgerAddOns.Controls.Add(ckbxHamburgerAddOns3);
            grpbxHamburgerAddOns.Controls.Add(ckbxHamburgerAddOns2);
            grpbxHamburgerAddOns.Controls.Add(ckbxHamburgerAddOns1);
            grpbxHamburgerAddOns.Location = new Point(272, 189);
            grpbxHamburgerAddOns.Name = "grpbxHamburgerAddOns";
            grpbxHamburgerAddOns.Size = new Size(221, 130);
            grpbxHamburgerAddOns.TabIndex = 7;
            grpbxHamburgerAddOns.TabStop = false;
            grpbxHamburgerAddOns.Text = "Add-on items ($.75/each)";
            // 
            // ckbxHamburgerAddOns3
            // 
            ckbxHamburgerAddOns3.AutoSize = true;
            ckbxHamburgerAddOns3.Location = new Point(16, 87);
            ckbxHamburgerAddOns3.Name = "ckbxHamburgerAddOns3";
            ckbxHamburgerAddOns3.Size = new Size(89, 19);
            ckbxHamburgerAddOns3.TabIndex = 2;
            ckbxHamburgerAddOns3.Text = "French Fries";
            ckbxHamburgerAddOns3.UseVisualStyleBackColor = true;
            ckbxHamburgerAddOns3.CheckedChanged += ckbxHamburgerAddOns3_CheckedChanged;
            // 
            // ckbxHamburgerAddOns2
            // 
            ckbxHamburgerAddOns2.AutoSize = true;
            ckbxHamburgerAddOns2.Location = new Point(16, 63);
            ckbxHamburgerAddOns2.Name = "ckbxHamburgerAddOns2";
            ckbxHamburgerAddOns2.Size = new Size(179, 19);
            ckbxHamburgerAddOns2.TabIndex = 1;
            ckbxHamburgerAddOns2.Text = "Ketchup, mustard, and mayo";
            ckbxHamburgerAddOns2.UseVisualStyleBackColor = true;
            ckbxHamburgerAddOns2.CheckedChanged += ckbxHamburgerAddOns2_CheckedChanged;
            // 
            // ckbxHamburgerAddOns1
            // 
            ckbxHamburgerAddOns1.AutoSize = true;
            ckbxHamburgerAddOns1.Location = new Point(16, 38);
            ckbxHamburgerAddOns1.Name = "ckbxHamburgerAddOns1";
            ckbxHamburgerAddOns1.Size = new Size(175, 19);
            ckbxHamburgerAddOns1.TabIndex = 0;
            ckbxHamburgerAddOns1.Text = "Lettuce, tomato, and onions";
            ckbxHamburgerAddOns1.UseVisualStyleBackColor = true;
            ckbxHamburgerAddOns1.CheckedChanged += ckbxHamburgerAddOns1_CheckedChanged;
            // 
            // grpbxPizzaAddOns
            // 
            grpbxPizzaAddOns.Controls.Add(ckbxPizzaAddOns3);
            grpbxPizzaAddOns.Controls.Add(ckbxPizzaAddOns2);
            grpbxPizzaAddOns.Controls.Add(ckbxPizzaAddOns1);
            grpbxPizzaAddOns.Location = new Point(272, 189);
            grpbxPizzaAddOns.Name = "grpbxPizzaAddOns";
            grpbxPizzaAddOns.Size = new Size(221, 130);
            grpbxPizzaAddOns.TabIndex = 8;
            grpbxPizzaAddOns.TabStop = false;
            grpbxPizzaAddOns.Text = "Add-on items ($.50/each)";
            // 
            // ckbxPizzaAddOns3
            // 
            ckbxPizzaAddOns3.AutoSize = true;
            ckbxPizzaAddOns3.Location = new Point(16, 87);
            ckbxPizzaAddOns3.Name = "ckbxPizzaAddOns3";
            ckbxPizzaAddOns3.Size = new Size(58, 19);
            ckbxPizzaAddOns3.TabIndex = 2;
            ckbxPizzaAddOns3.Text = "Olives";
            ckbxPizzaAddOns3.UseVisualStyleBackColor = true;
            ckbxPizzaAddOns3.CheckedChanged += ckbxPizzaAddOns3_CheckedChanged;
            // 
            // ckbxPizzaAddOns2
            // 
            ckbxPizzaAddOns2.AutoSize = true;
            ckbxPizzaAddOns2.Location = new Point(16, 63);
            ckbxPizzaAddOns2.Name = "ckbxPizzaAddOns2";
            ckbxPizzaAddOns2.Size = new Size(69, 19);
            ckbxPizzaAddOns2.TabIndex = 1;
            ckbxPizzaAddOns2.Text = "Sausage";
            ckbxPizzaAddOns2.UseVisualStyleBackColor = true;
            ckbxPizzaAddOns2.CheckedChanged += ckbxPizzaAddOns2_CheckedChanged;
            // 
            // ckbxPizzaAddOns1
            // 
            ckbxPizzaAddOns1.AutoSize = true;
            ckbxPizzaAddOns1.Location = new Point(16, 38);
            ckbxPizzaAddOns1.Name = "ckbxPizzaAddOns1";
            ckbxPizzaAddOns1.Size = new Size(80, 19);
            ckbxPizzaAddOns1.TabIndex = 0;
            ckbxPizzaAddOns1.Text = "Pepperoni";
            ckbxPizzaAddOns1.UseVisualStyleBackColor = true;
            ckbxPizzaAddOns1.CheckedChanged += ckbxPizzaAddOns1_CheckedChanged;
            // 
            // grpbxSaladAddOns
            // 
            grpbxSaladAddOns.Controls.Add(ckbxSaladAddOns3);
            grpbxSaladAddOns.Controls.Add(ckbxSaladAddOns2);
            grpbxSaladAddOns.Controls.Add(ckbxSaladAddOns1);
            grpbxSaladAddOns.Location = new Point(272, 189);
            grpbxSaladAddOns.Name = "grpbxSaladAddOns";
            grpbxSaladAddOns.Size = new Size(221, 130);
            grpbxSaladAddOns.TabIndex = 9;
            grpbxSaladAddOns.TabStop = false;
            grpbxSaladAddOns.Text = "Add-on items ($.25/each)";
            // 
            // ckbxSaladAddOns3
            // 
            ckbxSaladAddOns3.AutoSize = true;
            ckbxSaladAddOns3.Location = new Point(16, 87);
            ckbxSaladAddOns3.Name = "ckbxSaladAddOns3";
            ckbxSaladAddOns3.Size = new Size(89, 19);
            ckbxSaladAddOns3.TabIndex = 2;
            ckbxSaladAddOns3.Text = "French Fries";
            ckbxSaladAddOns3.UseVisualStyleBackColor = true;
            ckbxSaladAddOns3.CheckedChanged += ckbxSaladAddOns3_CheckedChanged;
            // 
            // ckbxSaladAddOns2
            // 
            ckbxSaladAddOns2.AutoSize = true;
            ckbxSaladAddOns2.Location = new Point(16, 63);
            ckbxSaladAddOns2.Name = "ckbxSaladAddOns2";
            ckbxSaladAddOns2.Size = new Size(81, 19);
            ckbxSaladAddOns2.TabIndex = 1;
            ckbxSaladAddOns2.Text = "Bacon bits";
            ckbxSaladAddOns2.UseVisualStyleBackColor = true;
            ckbxSaladAddOns2.CheckedChanged += ckbxSaladAddOns2_CheckedChanged;
            // 
            // ckbxSaladAddOns1
            // 
            ckbxSaladAddOns1.AutoSize = true;
            ckbxSaladAddOns1.Location = new Point(16, 38);
            ckbxSaladAddOns1.Name = "ckbxSaladAddOns1";
            ckbxSaladAddOns1.Size = new Size(75, 19);
            ckbxSaladAddOns1.TabIndex = 0;
            ckbxSaladAddOns1.Text = "Croutons";
            ckbxSaladAddOns1.UseVisualStyleBackColor = true;
            ckbxSaladAddOns1.CheckedChanged += ckbxSaladAddOns1_CheckedChanged;
            // 
            // frmLunchOrder
            // 
            AcceptButton = btnPlaceOrder;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnReset;
            ClientSize = new Size(513, 501);
            Controls.Add(grpbxSaladAddOns);
            Controls.Add(grpbxPizzaAddOns);
            Controls.Add(grpbxHamburgerAddOns);
            Controls.Add(btnExit);
            Controls.Add(btnReset);
            Controls.Add(btnPlaceOrder);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(grpbxOrderTotal);
            Controls.Add(grpbxMainCourse);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmLunchOrder";
            Text = "Microsoft Lunch '98";
            grpbxMainCourse.ResumeLayout(false);
            grpbxMainCourse.PerformLayout();
            grpbxOrderTotal.ResumeLayout(false);
            grpbxOrderTotal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            grpbxHamburgerAddOns.ResumeLayout(false);
            grpbxHamburgerAddOns.PerformLayout();
            grpbxPizzaAddOns.ResumeLayout(false);
            grpbxPizzaAddOns.PerformLayout();
            grpbxSaladAddOns.ResumeLayout(false);
            grpbxSaladAddOns.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpbxMainCourse;
        private GroupBox grpbxOrderTotal;
        private PictureBox pictureBox1;
        private Label label1;
        private RadioButton rdoSalad;
        private RadioButton rdoPizza;
        private RadioButton rdoHamburger;
        private TextBox txtOrderTotal;
        private TextBox txtTax;
        private TextBox txtSubtotal;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnPlaceOrder;
        private Button btnReset;
        private Button btnExit;
        private GroupBox grpbxHamburgerAddOns;
        private CheckBox ckbxHamburgerAddOns3;
        private CheckBox ckbxHamburgerAddOns2;
        private CheckBox ckbxHamburgerAddOns1;
        private GroupBox grpbxPizzaAddOns;
        private CheckBox ckbxPizzaAddOns3;
        private CheckBox ckbxPizzaAddOns2;
        private CheckBox ckbxPizzaAddOns1;
        private GroupBox grpbxSaladAddOns;
        private CheckBox ckbxSaladAddOns3;
        private CheckBox ckbxSaladAddOns2;
        private CheckBox ckbxSaladAddOns1;
    }
}