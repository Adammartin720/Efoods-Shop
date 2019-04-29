namespace Assignment_Programme
{
    partial class frmmenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.btncustomer = new System.Windows.Forms.Button();
            this.btnproduct = new System.Windows.Forms.Button();
            this.btnsalesrep = new System.Windows.Forms.Button();
            this.btnorder = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "eFood Main Menu";
            // 
            // btncustomer
            // 
            this.btncustomer.Location = new System.Drawing.Point(102, 72);
            this.btncustomer.Name = "btncustomer";
            this.btncustomer.Size = new System.Drawing.Size(89, 29);
            this.btncustomer.TabIndex = 1;
            this.btncustomer.Text = "Customer";
            this.btncustomer.UseVisualStyleBackColor = true;
            this.btncustomer.Click += new System.EventHandler(this.btncustomer_Click);
            // 
            // btnproduct
            // 
            this.btnproduct.Location = new System.Drawing.Point(102, 107);
            this.btnproduct.Name = "btnproduct";
            this.btnproduct.Size = new System.Drawing.Size(89, 29);
            this.btnproduct.TabIndex = 2;
            this.btnproduct.Text = "Product";
            this.btnproduct.UseVisualStyleBackColor = true;
            this.btnproduct.Click += new System.EventHandler(this.btnproduct_Click);
            // 
            // btnsalesrep
            // 
            this.btnsalesrep.Location = new System.Drawing.Point(102, 142);
            this.btnsalesrep.Name = "btnsalesrep";
            this.btnsalesrep.Size = new System.Drawing.Size(89, 29);
            this.btnsalesrep.TabIndex = 3;
            this.btnsalesrep.Text = "Sales Rep";
            this.btnsalesrep.UseVisualStyleBackColor = true;
            // 
            // btnorder
            // 
            this.btnorder.Location = new System.Drawing.Point(102, 177);
            this.btnorder.Name = "btnorder";
            this.btnorder.Size = new System.Drawing.Size(89, 29);
            this.btnorder.TabIndex = 4;
            this.btnorder.Text = "Order";
            this.btnorder.UseVisualStyleBackColor = true;
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(228, 204);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(52, 35);
            this.btnexit.TabIndex = 5;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            // 
            // frmmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 241);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnorder);
            this.Controls.Add(this.btnsalesrep);
            this.Controls.Add(this.btnproduct);
            this.Controls.Add(this.btncustomer);
            this.Controls.Add(this.label1);
            this.Name = "frmmenu";
            this.Text = "Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncustomer;
        private System.Windows.Forms.Button btnproduct;
        private System.Windows.Forms.Button btnsalesrep;
        private System.Windows.Forms.Button btnorder;
        private System.Windows.Forms.Button btnexit;
    }
}

