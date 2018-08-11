namespace BookStore
{
    partial class Promo
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
            this.txtPromoCustomerId = new System.Windows.Forms.TextBox();
            this.lblPromoResult = new System.Windows.Forms.Label();
            this.btnCheckPromotion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter customer Id:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtPromoCustomerId
            // 
            this.txtPromoCustomerId.Location = new System.Drawing.Point(174, 71);
            this.txtPromoCustomerId.Name = "txtPromoCustomerId";
            this.txtPromoCustomerId.Size = new System.Drawing.Size(81, 20);
            this.txtPromoCustomerId.TabIndex = 1;
            // 
            // lblPromoResult
            // 
            this.lblPromoResult.AutoSize = true;
            this.lblPromoResult.Location = new System.Drawing.Point(174, 173);
            this.lblPromoResult.Name = "lblPromoResult";
            this.lblPromoResult.Size = new System.Drawing.Size(0, 13);
            this.lblPromoResult.TabIndex = 2;
            this.lblPromoResult.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnCheckPromotion
            // 
            this.btnCheckPromotion.Location = new System.Drawing.Point(174, 222);
            this.btnCheckPromotion.Name = "btnCheckPromotion";
            this.btnCheckPromotion.Size = new System.Drawing.Size(78, 23);
            this.btnCheckPromotion.TabIndex = 3;
            this.btnCheckPromotion.Text = "Check Promotion";
            this.btnCheckPromotion.UseVisualStyleBackColor = true;
            this.btnCheckPromotion.Click += new System.EventHandler(this.btnCheckPromotion_Click);
            // 
            // Promo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCheckPromotion);
            this.Controls.Add(this.lblPromoResult);
            this.Controls.Add(this.txtPromoCustomerId);
            this.Controls.Add(this.label1);
            this.Name = "Promo";
            this.Text = "promo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPromoCustomerId;
        private System.Windows.Forms.Label lblPromoResult;
        private System.Windows.Forms.Button btnCheckPromotion;
    }
}