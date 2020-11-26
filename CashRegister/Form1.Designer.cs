namespace CashRegister
{
    partial class burgerKindom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(burgerKindom));
            this.burgerLabel = new System.Windows.Forms.Label();
            this.headerLabel = new System.Windows.Forms.Label();
            this.drinkLabel = new System.Windows.Forms.Label();
            this.poutineLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.burgerTextbox = new System.Windows.Forms.TextBox();
            this.drinkTextbox = new System.Windows.Forms.TextBox();
            this.poutineTexbox = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.totalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.subLabel = new System.Windows.Forms.Label();
            this.changeLabel = new System.Windows.Forms.Label();
            this.tenderedLabel = new System.Windows.Forms.Label();
            this.changeButton = new System.Windows.Forms.Button();
            this.receiptButton = new System.Windows.Forms.Button();
            this.tenderedTextbox = new System.Windows.Forms.TextBox();
            this.subOutputLabel = new System.Windows.Forms.Label();
            this.totalOutputLabel = new System.Windows.Forms.Label();
            this.taxOutputLabel = new System.Windows.Forms.Label();
            this.newOrderButton = new System.Windows.Forms.Button();
            this.changeOutputLabel = new System.Windows.Forms.Label();
            this.warningLabel = new System.Windows.Forms.Label();
            this.couponLabel = new System.Windows.Forms.Label();
            this.codeTextbox = new System.Windows.Forms.TextBox();
            this.codeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // burgerLabel
            // 
            this.burgerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.burgerLabel.Location = new System.Drawing.Point(3, 55);
            this.burgerLabel.Name = "burgerLabel";
            this.burgerLabel.Size = new System.Drawing.Size(150, 23);
            this.burgerLabel.TabIndex = 0;
            this.burgerLabel.Text = "Burger Orders:";
            this.burgerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // headerLabel
            // 
            this.headerLabel.BackColor = System.Drawing.Color.Salmon;
            this.headerLabel.Font = new System.Drawing.Font("Pioneer BT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(0, -1);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(521, 37);
            this.headerLabel.TabIndex = 1;
            this.headerLabel.Text = "Burger Kingdom";
            this.headerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.headerLabel.Click += new System.EventHandler(this.HeaderLabel_Click);
            // 
            // drinkLabel
            // 
            this.drinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinkLabel.Location = new System.Drawing.Point(3, 101);
            this.drinkLabel.Name = "drinkLabel";
            this.drinkLabel.Size = new System.Drawing.Size(150, 23);
            this.drinkLabel.TabIndex = 2;
            this.drinkLabel.Text = "Drink Orders:";
            this.drinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // poutineLabel
            // 
            this.poutineLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poutineLabel.Location = new System.Drawing.Point(3, 78);
            this.poutineLabel.Name = "poutineLabel";
            this.poutineLabel.Size = new System.Drawing.Size(150, 23);
            this.poutineLabel.TabIndex = 3;
            this.poutineLabel.Text = "Poutine Orders:";
            this.poutineLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.Color.White;
            this.outputLabel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(236, 55);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(260, 272);
            this.outputLabel.TabIndex = 4;
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // burgerTextbox
            // 
            this.burgerTextbox.Location = new System.Drawing.Point(108, 57);
            this.burgerTextbox.Name = "burgerTextbox";
            this.burgerTextbox.Size = new System.Drawing.Size(100, 20);
            this.burgerTextbox.TabIndex = 5;
            // 
            // drinkTextbox
            // 
            this.drinkTextbox.Location = new System.Drawing.Point(108, 103);
            this.drinkTextbox.Name = "drinkTextbox";
            this.drinkTextbox.Size = new System.Drawing.Size(100, 20);
            this.drinkTextbox.TabIndex = 6;
            // 
            // poutineTexbox
            // 
            this.poutineTexbox.Location = new System.Drawing.Point(108, 78);
            this.poutineTexbox.Name = "poutineTexbox";
            this.poutineTexbox.Size = new System.Drawing.Size(100, 20);
            this.poutineTexbox.TabIndex = 7;
            // 
            // CalculateButton
            // 
            this.CalculateButton.BackColor = System.Drawing.Color.Silver;
            this.CalculateButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CalculateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.CalculateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.CalculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CalculateButton.Location = new System.Drawing.Point(108, 129);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(100, 23);
            this.CalculateButton.TabIndex = 8;
            this.CalculateButton.Text = "Calculate Totals";
            this.CalculateButton.UseVisualStyleBackColor = false;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // totalLabel
            // 
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(3, 216);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(78, 23);
            this.totalLabel.TabIndex = 9;
            this.totalLabel.Text = "Total:";
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // taxLabel
            // 
            this.taxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxLabel.Location = new System.Drawing.Point(3, 193);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(78, 23);
            this.taxLabel.TabIndex = 10;
            this.taxLabel.Text = "Tax:";
            this.taxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // subLabel
            // 
            this.subLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subLabel.Location = new System.Drawing.Point(3, 170);
            this.subLabel.Name = "subLabel";
            this.subLabel.Size = new System.Drawing.Size(78, 23);
            this.subLabel.TabIndex = 11;
            this.subLabel.Text = "Sub Total:";
            this.subLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // changeLabel
            // 
            this.changeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLabel.Location = new System.Drawing.Point(3, 316);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(150, 23);
            this.changeLabel.TabIndex = 12;
            this.changeLabel.Text = "Change:";
            this.changeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tenderedLabel
            // 
            this.tenderedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedLabel.Location = new System.Drawing.Point(3, 256);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(150, 23);
            this.tenderedLabel.TabIndex = 13;
            this.tenderedLabel.Text = "Tendered:";
            this.tenderedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // changeButton
            // 
            this.changeButton.BackColor = System.Drawing.Color.Silver;
            this.changeButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.changeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.changeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.changeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeButton.Location = new System.Drawing.Point(108, 282);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(100, 23);
            this.changeButton.TabIndex = 14;
            this.changeButton.Text = "Calculate Change";
            this.changeButton.UseVisualStyleBackColor = false;
            this.changeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // receiptButton
            // 
            this.receiptButton.BackColor = System.Drawing.Color.Silver;
            this.receiptButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.receiptButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.receiptButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.receiptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.receiptButton.Location = new System.Drawing.Point(108, 342);
            this.receiptButton.Name = "receiptButton";
            this.receiptButton.Size = new System.Drawing.Size(100, 23);
            this.receiptButton.TabIndex = 15;
            this.receiptButton.Text = "Print Receipt";
            this.receiptButton.UseVisualStyleBackColor = false;
            this.receiptButton.Click += new System.EventHandler(this.ReceiptButton_Click);
            // 
            // tenderedTextbox
            // 
            this.tenderedTextbox.Location = new System.Drawing.Point(108, 256);
            this.tenderedTextbox.Name = "tenderedTextbox";
            this.tenderedTextbox.Size = new System.Drawing.Size(100, 20);
            this.tenderedTextbox.TabIndex = 16;
            // 
            // subOutputLabel
            // 
            this.subOutputLabel.AutoSize = true;
            this.subOutputLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.subOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subOutputLabel.Location = new System.Drawing.Point(105, 173);
            this.subOutputLabel.Name = "subOutputLabel";
            this.subOutputLabel.Size = new System.Drawing.Size(39, 16);
            this.subOutputLabel.TabIndex = 17;
            this.subOutputLabel.Text = "$0.00";
            // 
            // totalOutputLabel
            // 
            this.totalOutputLabel.AutoSize = true;
            this.totalOutputLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.totalOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalOutputLabel.Location = new System.Drawing.Point(105, 219);
            this.totalOutputLabel.Name = "totalOutputLabel";
            this.totalOutputLabel.Size = new System.Drawing.Size(39, 16);
            this.totalOutputLabel.TabIndex = 18;
            this.totalOutputLabel.Text = "$0.00";
            // 
            // taxOutputLabel
            // 
            this.taxOutputLabel.AutoSize = true;
            this.taxOutputLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.taxOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxOutputLabel.Location = new System.Drawing.Point(105, 196);
            this.taxOutputLabel.Name = "taxOutputLabel";
            this.taxOutputLabel.Size = new System.Drawing.Size(39, 16);
            this.taxOutputLabel.TabIndex = 19;
            this.taxOutputLabel.Text = "$0.00";
            // 
            // newOrderButton
            // 
            this.newOrderButton.BackColor = System.Drawing.Color.Silver;
            this.newOrderButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.newOrderButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.newOrderButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.newOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newOrderButton.Location = new System.Drawing.Point(239, 331);
            this.newOrderButton.Name = "newOrderButton";
            this.newOrderButton.Size = new System.Drawing.Size(100, 23);
            this.newOrderButton.TabIndex = 20;
            this.newOrderButton.Text = "New Order";
            this.newOrderButton.UseVisualStyleBackColor = false;
            this.newOrderButton.Click += new System.EventHandler(this.NewOrderButton_Click);
            // 
            // changeOutputLabel
            // 
            this.changeOutputLabel.AutoSize = true;
            this.changeOutputLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.changeOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeOutputLabel.Location = new System.Drawing.Point(105, 319);
            this.changeOutputLabel.Name = "changeOutputLabel";
            this.changeOutputLabel.Size = new System.Drawing.Size(39, 16);
            this.changeOutputLabel.TabIndex = 21;
            this.changeOutputLabel.Text = "$0.00";
            // 
            // warningLabel
            // 
            this.warningLabel.BackColor = System.Drawing.Color.Transparent;
            this.warningLabel.Location = new System.Drawing.Point(345, 331);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(151, 34);
            this.warningLabel.TabIndex = 22;
            // 
            // couponLabel
            // 
            this.couponLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.couponLabel.Location = new System.Drawing.Point(3, 282);
            this.couponLabel.Name = "couponLabel";
            this.couponLabel.Size = new System.Drawing.Size(105, 23);
            this.couponLabel.TabIndex = 23;
            this.couponLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // codeTextbox
            // 
            this.codeTextbox.Location = new System.Drawing.Point(108, 371);
            this.codeTextbox.Name = "codeTextbox";
            this.codeTextbox.Size = new System.Drawing.Size(100, 20);
            this.codeTextbox.TabIndex = 24;
            this.codeTextbox.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // codeLabel
            // 
            this.codeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeLabel.Location = new System.Drawing.Point(3, 368);
            this.codeLabel.Name = "codeLabel";
            this.codeLabel.Size = new System.Drawing.Size(105, 23);
            this.codeLabel.TabIndex = 25;
            this.codeLabel.Text = "Code:";
            this.codeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // burgerKindom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(519, 395);
            this.Controls.Add(this.codeLabel);
            this.Controls.Add(this.codeTextbox);
            this.Controls.Add(this.couponLabel);
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.changeOutputLabel);
            this.Controls.Add(this.newOrderButton);
            this.Controls.Add(this.taxOutputLabel);
            this.Controls.Add(this.totalOutputLabel);
            this.Controls.Add(this.subOutputLabel);
            this.Controls.Add(this.tenderedTextbox);
            this.Controls.Add(this.receiptButton);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.tenderedLabel);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.subLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.poutineTexbox);
            this.Controls.Add(this.drinkTextbox);
            this.Controls.Add(this.burgerTextbox);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.poutineLabel);
            this.Controls.Add(this.drinkLabel);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.burgerLabel);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "burgerKindom";
            this.Text = "Burger Kingdom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label burgerLabel;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label drinkLabel;
        private System.Windows.Forms.Label poutineLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.TextBox burgerTextbox;
        private System.Windows.Forms.TextBox drinkTextbox;
        private System.Windows.Forms.TextBox poutineTexbox;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label subLabel;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Label tenderedLabel;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button receiptButton;
        private System.Windows.Forms.TextBox tenderedTextbox;
        private System.Windows.Forms.Label subOutputLabel;
        private System.Windows.Forms.Label totalOutputLabel;
        private System.Windows.Forms.Label taxOutputLabel;
        private System.Windows.Forms.Button newOrderButton;
        private System.Windows.Forms.Label changeOutputLabel;
        private System.Windows.Forms.Label warningLabel;
        private System.Windows.Forms.Label couponLabel;
        private System.Windows.Forms.TextBox codeTextbox;
        private System.Windows.Forms.Label codeLabel;
    }
}

