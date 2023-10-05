
namespace WinFormsApp1
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.managerLable = new System.Windows.Forms.Label();
            this.btn_administrator = new System.Windows.Forms.Button();
            this.btn_Shop = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // managerLable
            // 
            this.managerLable.AutoSize = true;
            this.managerLable.BackColor = System.Drawing.SystemColors.ControlDark;
            this.managerLable.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.managerLable.Location = new System.Drawing.Point(261, 9);
            this.managerLable.Name = "managerLable";
            this.managerLable.Size = new System.Drawing.Size(158, 45);
            this.managerLable.TabIndex = 1;
            this.managerLable.Text = "Car Store";
            // 
            // btn_administrator
            // 
            this.btn_administrator.BackColor = System.Drawing.Color.White;
            this.btn_administrator.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_administrator.Location = new System.Drawing.Point(355, 71);
            this.btn_administrator.Name = "btn_administrator";
            this.btn_administrator.Size = new System.Drawing.Size(275, 66);
            this.btn_administrator.TabIndex = 0;
            this.btn_administrator.Text = "Administrator";
            this.btn_administrator.UseVisualStyleBackColor = false;
            this.btn_administrator.Click += new System.EventHandler(this.btn_administrator_Click);
            // 
            // btn_Shop
            // 
            this.btn_Shop.BackColor = System.Drawing.Color.White;
            this.btn_Shop.Location = new System.Drawing.Point(58, 71);
            this.btn_Shop.Name = "btn_Shop";
            this.btn_Shop.Size = new System.Drawing.Size(275, 66);
            this.btn_Shop.TabIndex = 2;
            this.btn_Shop.Text = "Shop";
            this.btn_Shop.UseVisualStyleBackColor = false;
            this.btn_Shop.Click += new System.EventHandler(this.btn_Shop_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.White;
            this.btn_exit.Location = new System.Drawing.Point(547, 444);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(131, 48);
            this.btn_exit.TabIndex = 3;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(690, 504);
            this.ControlBox = false;
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_Shop);
            this.Controls.Add(this.managerLable);
            this.Controls.Add(this.btn_administrator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Menu";
            this.Text = "FormLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label managerLable;
        private System.Windows.Forms.Button btn_administrator;
        private System.Windows.Forms.Button btn_Shop;
        private System.Windows.Forms.Button btn_exit;
    }
}

