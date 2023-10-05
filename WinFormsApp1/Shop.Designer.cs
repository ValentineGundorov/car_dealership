
namespace WinFormsApp1
{
    partial class Shop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Shop));
            this.btn_exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Charger = new System.Windows.Forms.Button();
            this.btn_Mercedes = new System.Windows.Forms.Button();
            this.label_ElctricCars = new System.Windows.Forms.Label();
            this.btn_Tesla = new System.Windows.Forms.Button();
            this.btn_Volvo = new System.Windows.Forms.Button();
            this.textBoxItems = new System.Windows.Forms.TextBox();
            this.comboBoxItems = new System.Windows.Forms.ComboBox();
            this.buttonAddItemToCart = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.comboBoxCart = new System.Windows.Forms.ComboBox();
            this.labeCost = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.buttonBuy = new System.Windows.Forms.Button();
            this.labelItems = new System.Windows.Forms.Label();
            this.labelAmount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.White;
            this.btn_exit.Location = new System.Drawing.Point(901, 507);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(158, 55);
            this.btn_exit.TabIndex = 3;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(58, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Addition";
            // 
            // btn_Charger
            // 
            this.btn_Charger.Location = new System.Drawing.Point(35, 357);
            this.btn_Charger.Name = "btn_Charger";
            this.btn_Charger.Size = new System.Drawing.Size(155, 47);
            this.btn_Charger.TabIndex = 4;
            this.btn_Charger.Text = "Charger";
            this.btn_Charger.UseVisualStyleBackColor = true;
            this.btn_Charger.Click += new System.EventHandler(this.btn_Charger_Click);
            // 
            // btn_Mercedes
            // 
            this.btn_Mercedes.Location = new System.Drawing.Point(31, 230);
            this.btn_Mercedes.Name = "btn_Mercedes";
            this.btn_Mercedes.Size = new System.Drawing.Size(159, 50);
            this.btn_Mercedes.TabIndex = 3;
            this.btn_Mercedes.Text = "Mercedes";
            this.btn_Mercedes.UseVisualStyleBackColor = true;
            this.btn_Mercedes.Click += new System.EventHandler(this.btn_Mercedes_Click);
            // 
            // label_ElctricCars
            // 
            this.label_ElctricCars.AutoSize = true;
            this.label_ElctricCars.BackColor = System.Drawing.Color.DarkGray;
            this.label_ElctricCars.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_ElctricCars.Location = new System.Drawing.Point(58, 35);
            this.label_ElctricCars.Name = "label_ElctricCars";
            this.label_ElctricCars.Size = new System.Drawing.Size(89, 62);
            this.label_ElctricCars.TabIndex = 2;
            this.label_ElctricCars.Text = "Electric\n  Cars\r\n";
            // 
            // btn_Tesla
            // 
            this.btn_Tesla.Location = new System.Drawing.Point(31, 115);
            this.btn_Tesla.Name = "btn_Tesla";
            this.btn_Tesla.Size = new System.Drawing.Size(159, 52);
            this.btn_Tesla.TabIndex = 1;
            this.btn_Tesla.Text = "Tesla";
            this.btn_Tesla.UseVisualStyleBackColor = true;
            this.btn_Tesla.Click += new System.EventHandler(this.btn_Tesla_Click);
            // 
            // btn_Volvo
            // 
            this.btn_Volvo.Location = new System.Drawing.Point(31, 173);
            this.btn_Volvo.Name = "btn_Volvo";
            this.btn_Volvo.Size = new System.Drawing.Size(159, 51);
            this.btn_Volvo.TabIndex = 0;
            this.btn_Volvo.Text = "Volvo";
            this.btn_Volvo.UseVisualStyleBackColor = true;
            this.btn_Volvo.Click += new System.EventHandler(this.btn_Volvo_Click);
            // 
            // textBoxItems
            // 
            this.textBoxItems.Location = new System.Drawing.Point(196, 78);
            this.textBoxItems.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxItems.Multiline = true;
            this.textBoxItems.Name = "textBoxItems";
            this.textBoxItems.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxItems.Size = new System.Drawing.Size(863, 279);
            this.textBoxItems.TabIndex = 6;
            // 
            // comboBoxItems
            // 
            this.comboBoxItems.FormattingEnabled = true;
            this.comboBoxItems.Location = new System.Drawing.Point(324, 41);
            this.comboBoxItems.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxItems.Name = "comboBoxItems";
            this.comboBoxItems.Size = new System.Drawing.Size(735, 28);
            this.comboBoxItems.TabIndex = 7;
            this.comboBoxItems.Visible = false;
            // 
            // buttonAddItemToCart
            // 
            this.buttonAddItemToCart.Location = new System.Drawing.Point(192, 39);
            this.buttonAddItemToCart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAddItemToCart.Name = "buttonAddItemToCart";
            this.buttonAddItemToCart.Size = new System.Drawing.Size(126, 31);
            this.buttonAddItemToCart.TabIndex = 8;
            this.buttonAddItemToCart.Text = "Add";
            this.buttonAddItemToCart.UseVisualStyleBackColor = true;
            this.buttonAddItemToCart.Click += new System.EventHandler(this.buttonAddItemToCart_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(196, 365);
            this.buttonRemove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(126, 31);
            this.buttonRemove.TabIndex = 10;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // comboBoxCart
            // 
            this.comboBoxCart.FormattingEnabled = true;
            this.comboBoxCart.Location = new System.Drawing.Point(328, 368);
            this.comboBoxCart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxCart.Name = "comboBoxCart";
            this.comboBoxCart.Size = new System.Drawing.Size(731, 28);
            this.comboBoxCart.TabIndex = 9;
            // 
            // labeCost
            // 
            this.labeCost.AutoSize = true;
            this.labeCost.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labeCost.Location = new System.Drawing.Point(328, 404);
            this.labeCost.Name = "labeCost";
            this.labeCost.Size = new System.Drawing.Size(114, 31);
            this.labeCost.TabIndex = 11;
            this.labeCost.Text = "Total cost";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPrice.Location = new System.Drawing.Point(497, 404);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(27, 31);
            this.labelPrice.TabIndex = 12;
            this.labelPrice.Text = "0";
            // 
            // buttonBuy
            // 
            this.buttonBuy.Location = new System.Drawing.Point(192, 404);
            this.buttonBuy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(126, 62);
            this.buttonBuy.TabIndex = 13;
            this.buttonBuy.Text = "Buy";
            this.buttonBuy.UseVisualStyleBackColor = true;
            this.buttonBuy.Click += new System.EventHandler(this.buttonBuy_Click);
            // 
            // labelItems
            // 
            this.labelItems.AutoSize = true;
            this.labelItems.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelItems.Location = new System.Drawing.Point(497, 437);
            this.labelItems.Name = "labelItems";
            this.labelItems.Size = new System.Drawing.Size(27, 31);
            this.labelItems.TabIndex = 15;
            this.labelItems.Text = "0";
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAmount.Location = new System.Drawing.Point(328, 437);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(151, 31);
            this.labelAmount.TabIndex = 14;
            this.labelAmount.Text = "Total amount";
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1071, 574);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.label_ElctricCars);
            this.Controls.Add(this.btn_Charger);
            this.Controls.Add(this.labelItems);
            this.Controls.Add(this.btn_Mercedes);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.buttonBuy);
            this.Controls.Add(this.btn_Tesla);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.btn_Volvo);
            this.Controls.Add(this.labeCost);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.comboBoxCart);
            this.Controls.Add(this.buttonAddItemToCart);
            this.Controls.Add(this.comboBoxItems);
            this.Controls.Add(this.textBoxItems);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Shop";
            this.Text = "FormCustomer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label label_ElctricCars;
        private System.Windows.Forms.Button btn_Tesla;
        private System.Windows.Forms.Button btn_Volvo;
        private System.Windows.Forms.Button btn_Charger;
        private System.Windows.Forms.Button btn_Mercedes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxItems;
        private System.Windows.Forms.ComboBox comboBoxItems;
        private System.Windows.Forms.Button buttonAddItemToCart;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.ComboBox comboBoxCart;
        private System.Windows.Forms.Label labeCost;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Button buttonBuy;
        private System.Windows.Forms.Label labelItems;
        private System.Windows.Forms.Label labelAmount;
    }
}