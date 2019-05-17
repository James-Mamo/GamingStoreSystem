namespace GamingStoreCatalougeSystem
{
    partial class ViewPeripherals
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PeriphName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtNameP = new System.Windows.Forms.TextBox();
            this.txtPriceP = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.PeriphName,
            this.Price});
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(67, 25);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(650, 94);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // PeriphName
            // 
            this.PeriphName.Text = "Name";
            // 
            // Price
            // 
            this.Price.Text = "Price";
            // 
            // txtNameP
            // 
            this.txtNameP.Location = new System.Drawing.Point(208, 214);
            this.txtNameP.Name = "txtNameP";
            this.txtNameP.Size = new System.Drawing.Size(100, 20);
            this.txtNameP.TabIndex = 2;
            // 
            // txtPriceP
            // 
            this.txtPriceP.Location = new System.Drawing.Point(208, 296);
            this.txtPriceP.Name = "txtPriceP";
            this.txtPriceP.Size = new System.Drawing.Size(100, 20);
            this.txtPriceP.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(432, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 58);
            this.button1.TabIndex = 7;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBack.Location = new System.Drawing.Point(712, 399);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 33);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ViewPeripherals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPriceP);
            this.Controls.Add(this.txtNameP);
            this.Controls.Add(this.listView1);
            this.Name = "ViewPeripherals";
            this.Text = "ViewPeripherals";
            this.Load += new System.EventHandler(this.ViewPeripherals_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader PeriphName;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.TextBox txtNameP;
        private System.Windows.Forms.TextBox txtPriceP;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBack;
    }
}