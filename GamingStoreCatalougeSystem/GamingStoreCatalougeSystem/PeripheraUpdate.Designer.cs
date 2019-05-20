namespace GamingStoreCatalougeSystem
{
    partial class PeripheraUpdate
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
            this.txtNameP = new System.Windows.Forms.TextBox();
            this.txtPriceU = new System.Windows.Forms.TextBox();
            this.btnUpdateP = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNameP
            // 
            this.txtNameP.Location = new System.Drawing.Point(224, 146);
            this.txtNameP.Name = "txtNameP";
            this.txtNameP.Size = new System.Drawing.Size(100, 20);
            this.txtNameP.TabIndex = 2;
            // 
            // txtPriceU
            // 
            this.txtPriceU.Location = new System.Drawing.Point(224, 220);
            this.txtPriceU.Name = "txtPriceU";
            this.txtPriceU.Size = new System.Drawing.Size(100, 20);
            this.txtPriceU.TabIndex = 3;
            // 
            // btnUpdateP
            // 
            this.btnUpdateP.Location = new System.Drawing.Point(390, 161);
            this.btnUpdateP.Name = "btnUpdateP";
            this.btnUpdateP.Size = new System.Drawing.Size(124, 58);
            this.btnUpdateP.TabIndex = 4;
            this.btnUpdateP.Text = "Update";
            this.btnUpdateP.UseVisualStyleBackColor = true;
            this.btnUpdateP.Click += new System.EventHandler(this.btnUpdateP_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(695, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 31);
            this.button1.TabIndex = 5;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PeripheraUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnUpdateP);
            this.Controls.Add(this.txtPriceU);
            this.Controls.Add(this.txtNameP);
            this.Name = "PeripheraUpdate";
            this.Text = "PeripheraUpdate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNameP;
        private System.Windows.Forms.TextBox txtPriceU;
        private System.Windows.Forms.Button btnUpdateP;
        private System.Windows.Forms.Button button1;
    }
}