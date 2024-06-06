namespace U4A2
{
    partial class Form4
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
            this.label2 = new System.Windows.Forms.Label();
            this.lblPaid = new System.Windows.Forms.Label();
            this.txtPricePaid = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.txtPoints = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddPoints = new System.Windows.Forms.Button();
            this.lstRewards = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEnterReward = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(285, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 31);
            this.label1.TabIndex = 12;
            this.label1.Text = "Admin Dashboard";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(120, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Add Points";
            // 
            // lblPaid
            // 
            this.lblPaid.AutoSize = true;
            this.lblPaid.Location = new System.Drawing.Point(57, 133);
            this.lblPaid.Name = "lblPaid";
            this.lblPaid.Size = new System.Drawing.Size(70, 13);
            this.lblPaid.TabIndex = 17;
            this.lblPaid.Text = "Price Paid (£)";
            // 
            // txtPricePaid
            // 
            this.txtPricePaid.Location = new System.Drawing.Point(165, 130);
            this.txtPricePaid.Name = "txtPricePaid";
            this.txtPricePaid.Size = new System.Drawing.Size(116, 20);
            this.txtPricePaid.TabIndex = 18;
            this.txtPricePaid.TextChanged += new System.EventHandler(this.txtPricePaid_TextChanged);
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(111, 162);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(116, 23);
            this.btnConvert.TabIndex = 19;
            this.btnConvert.Text = "Convert To Points";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // txtPoints
            // 
            this.txtPoints.Location = new System.Drawing.Point(111, 218);
            this.txtPoints.Name = "txtPoints";
            this.txtPoints.Size = new System.Drawing.Size(116, 20);
            this.txtPoints.TabIndex = 20;
            this.txtPoints.TextChanged += new System.EventHandler(this.txtPoints_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Points";
            // 
            // btnAddPoints
            // 
            this.btnAddPoints.Location = new System.Drawing.Point(111, 254);
            this.btnAddPoints.Name = "btnAddPoints";
            this.btnAddPoints.Size = new System.Drawing.Size(116, 24);
            this.btnAddPoints.TabIndex = 22;
            this.btnAddPoints.Text = "Add Points";
            this.btnAddPoints.UseVisualStyleBackColor = true;
            this.btnAddPoints.Click += new System.EventHandler(this.btnAddPoints_Click);
            // 
            // lstRewards
            // 
            this.lstRewards.FormattingEnabled = true;
            this.lstRewards.Location = new System.Drawing.Point(516, 162);
            this.lstRewards.Name = "lstRewards";
            this.lstRewards.Size = new System.Drawing.Size(221, 95);
            this.lstRewards.TabIndex = 23;
            this.lstRewards.SelectedIndexChanged += new System.EventHandler(this.lstRewards_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(617, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 24);
            this.label4.TabIndex = 24;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(621, 92);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(116, 20);
            this.textBox1.TabIndex = 25;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(165, 92);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(116, 20);
            this.txtEmail.TabIndex = 15;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(57, 95);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 16;
            this.lblEmail.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(513, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Enter Reward ";
            // 
            // txtEnterReward
            // 
            this.txtEnterReward.Location = new System.Drawing.Point(621, 92);
            this.txtEnterReward.Name = "txtEnterReward";
            this.txtEnterReward.Size = new System.Drawing.Size(116, 20);
            this.txtEnterReward.TabIndex = 27;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(565, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "Add To List";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(524, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 24);
            this.label5.TabIndex = 30;
            this.label5.Text = "Add and View Rewards";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEnterReward);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstRewards);
            this.Controls.Add(this.btnAddPoints);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPoints);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtPricePaid);
            this.Controls.Add(this.lblPaid);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPaid;
        private System.Windows.Forms.TextBox txtPricePaid;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.TextBox txtPoints;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddPoints;
        private System.Windows.Forms.ListBox lstRewards;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEnterReward;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
    }
}