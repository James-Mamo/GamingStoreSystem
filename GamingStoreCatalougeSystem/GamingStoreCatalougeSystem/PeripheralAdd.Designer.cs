namespace GamingStoreCatalougeSystem
{
    partial class PeripheralAdd
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
            this.txtPeriphName = new System.Windows.Forms.TextBox();
            this.txtPeriphPrice = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPeriphName
            // 
            this.txtPeriphName.Location = new System.Drawing.Point(241, 158);
            this.txtPeriphName.Name = "txtPeriphName";
            this.txtPeriphName.Size = new System.Drawing.Size(119, 20);
            this.txtPeriphName.TabIndex = 0;
            // 
            // txtPeriphPrice
            // 
            this.txtPeriphPrice.Location = new System.Drawing.Point(241, 217);
            this.txtPeriphPrice.Name = "txtPeriphPrice";
            this.txtPeriphPrice.Size = new System.Drawing.Size(119, 20);
            this.txtPeriphPrice.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(472, 177);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(155, 60);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add Peripheral";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBack.Location = new System.Drawing.Point(697, 396);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 33);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // PeripheralAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtPeriphPrice);
            this.Controls.Add(this.txtPeriphName);
            this.Name = "PeripheralAdd";
            this.Text = "PeripheralAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPeriphName;
        private System.Windows.Forms.TextBox txtPeriphPrice;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnBack;
    }
}