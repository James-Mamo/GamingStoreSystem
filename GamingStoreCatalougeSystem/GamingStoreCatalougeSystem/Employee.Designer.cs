namespace GamingStoreCatalougeSystem
{
    partial class Employee
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnUpdatePerip = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(259, 240);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(109, 45);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Update Games";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(437, 240);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(101, 45);
            this.btnView.TabIndex = 1;
            this.btnView.Text = "View Games";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(437, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "View Peripherlas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUpdatePerip
            // 
            this.btnUpdatePerip.Location = new System.Drawing.Point(259, 317);
            this.btnUpdatePerip.Name = "btnUpdatePerip";
            this.btnUpdatePerip.Size = new System.Drawing.Size(109, 45);
            this.btnUpdatePerip.TabIndex = 3;
            this.btnUpdatePerip.Text = "Update Peripherlas";
            this.btnUpdatePerip.UseVisualStyleBackColor = true;
            this.btnUpdatePerip.Click += new System.EventHandler(this.btnUpdatePerip_Click);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpdatePerip);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnUpdate);
            this.Name = "Employee";
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Employee_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnUpdatePerip;
    }
}