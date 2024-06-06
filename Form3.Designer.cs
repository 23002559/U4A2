namespace U4A2
{
    partial class Form3
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
            this.lblPoints = new System.Windows.Forms.Label();
            this.txtPoints3 = new System.Windows.Forms.TextBox();
            this.btnWrapping = new System.Windows.Forms.Button();
            this.btnDiscount = new System.Windows.Forms.Button();
            this.btnRefill = new System.Windows.Forms.Button();
            this.btnEngraving = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(264, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "Redeem Points Page";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Location = new System.Drawing.Point(384, 91);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(36, 13);
            this.lblPoints.TabIndex = 12;
            this.lblPoints.Text = "Points";
            // 
            // txtPoints3
            // 
            this.txtPoints3.Location = new System.Drawing.Point(344, 118);
            this.txtPoints3.Name = "txtPoints3";
            this.txtPoints3.Size = new System.Drawing.Size(116, 20);
            this.txtPoints3.TabIndex = 13;
           
            // 
            // btnWrapping
            // 
            this.btnWrapping.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWrapping.Location = new System.Drawing.Point(270, 144);
            this.btnWrapping.Name = "btnWrapping";
            this.btnWrapping.Size = new System.Drawing.Size(119, 29);
            this.btnWrapping.TabIndex = 15;
            this.btnWrapping.Text = "Free Wrapping (40)";
            this.btnWrapping.UseVisualStyleBackColor = true;
            this.btnWrapping.Click += new System.EventHandler(this.btnWrapping_Click);
            // 
            // btnDiscount
            // 
            this.btnDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiscount.Location = new System.Drawing.Point(414, 144);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(119, 29);
            this.btnDiscount.TabIndex = 16;
            this.btnDiscount.Text = "10% Discount (500)";
            this.btnDiscount.UseVisualStyleBackColor = true;
            // 
            // btnRefill
            // 
            this.btnRefill.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefill.Location = new System.Drawing.Point(270, 179);
            this.btnRefill.Name = "btnRefill";
            this.btnRefill.Size = new System.Drawing.Size(119, 29);
            this.btnRefill.TabIndex = 17;
            this.btnRefill.Text = "Free Refill (1000)";
            this.btnRefill.UseVisualStyleBackColor = true;
            // 
            // btnEngraving
            // 
            this.btnEngraving.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEngraving.Location = new System.Drawing.Point(414, 179);
            this.btnEngraving.Name = "btnEngraving";
            this.btnEngraving.Size = new System.Drawing.Size(119, 29);
            this.btnEngraving.TabIndex = 18;
            this.btnEngraving.Text = "Free Engraving (2000)";
            this.btnEngraving.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEngraving);
            this.Controls.Add(this.btnRefill);
            this.Controls.Add(this.btnDiscount);
            this.Controls.Add(this.btnWrapping);
            this.Controls.Add(this.txtPoints3);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.TextBox txtPoints3;
        private System.Windows.Forms.Button btnWrapping;
        private System.Windows.Forms.Button btnDiscount;
        private System.Windows.Forms.Button btnRefill;
        private System.Windows.Forms.Button btnEngraving;
    }
}