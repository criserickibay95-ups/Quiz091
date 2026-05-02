namespace Quiz091
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
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.btnCompute = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.txtAcctNumber = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnFullName = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAccount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtRadius
            // 
            this.txtRadius.Location = new System.Drawing.Point(40, 40);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(100, 20);
            this.txtRadius.TabIndex = 0;
            // 
            // btnCompute
            // 
            this.btnCompute.Location = new System.Drawing.Point(40, 66);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(75, 23);
            this.btnCompute.TabIndex = 1;
            this.btnCompute.Text = "Compute";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(36, 92);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(78, 20);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "Diameter:";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(40, 180);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(100, 20);
            this.txtCode.TabIndex = 3;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(40, 258);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(75, 23);
            this.btnAddProduct.TabIndex = 4;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // txtAcctNumber
            // 
            this.txtAcctNumber.Location = new System.Drawing.Point(266, 154);
            this.txtAcctNumber.Name = "txtAcctNumber";
            this.txtAcctNumber.Size = new System.Drawing.Size(100, 20);
            this.txtAcctNumber.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(266, 40);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 6;
            this.txtName.Text = "Cris Ibay";
            // 
            // btnAccount
            // 
            this.btnAccount.Location = new System.Drawing.Point(266, 180);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(75, 23);
            this.btnAccount.TabIndex = 7;
            this.btnAccount.Text = "Submit";
            this.btnAccount.UseVisualStyleBackColor = true;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // btnFullName
            // 
            this.btnFullName.Location = new System.Drawing.Point(266, 66);
            this.btnFullName.Name = "btnFullName";
            this.btnFullName.Size = new System.Drawing.Size(75, 23);
            this.btnFullName.TabIndex = 8;
            this.btnFullName.Text = "Click!";
            this.btnFullName.UseVisualStyleBackColor = true;
            this.btnFullName.Click += new System.EventHandler(this.btnFullName_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(40, 206);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(100, 20);
            this.txtDescription.TabIndex = 9;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(40, 232);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 10;
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.Location = new System.Drawing.Point(36, 284);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(68, 20);
            this.lblProduct.TabIndex = 11;
            this.lblProduct.Text = "Product:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(262, 92);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(84, 20);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "Full Name:";
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccount.Location = new System.Drawing.Point(262, 206);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(132, 20);
            this.lblAccount.TabIndex = 13;
            this.lblAccount.Text = "Account Number:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(543, 413);
            this.Controls.Add(this.lblAccount);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.btnFullName);
            this.Controls.Add(this.btnAccount);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtAcctNumber);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.txtRadius);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.TextBox txtAcctNumber;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Button btnFullName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAccount;
    }
}

