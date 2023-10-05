
namespace WinFormsApp1
{
    partial class Administrator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrator));
            this.btn_return = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.comboBoxCables = new System.Windows.Forms.ComboBox();
            this.labelCables = new System.Windows.Forms.Label();
            this.comboBoxMaxSpeed = new System.Windows.Forms.ComboBox();
            this.labelMaxSpeed = new System.Windows.Forms.Label();
            this.lb_id = new System.Windows.Forms.Label();
            this.tb_return_id = new System.Windows.Forms.TextBox();
            this.comboBoxDoors = new System.Windows.Forms.ComboBox();
            this.labelDoor = new System.Windows.Forms.Label();
            this.comboBoxYear = new System.Windows.Forms.ComboBox();
            this.comboBoxWeight = new System.Windows.Forms.ComboBox();
            this.labelWeight = new System.Windows.Forms.Label();
            this.comboBoxColors = new System.Windows.Forms.ComboBox();
            this.lb_price = new System.Windows.Forms.Label();
            this.tb_return_price = new System.Windows.Forms.TextBox();
            this.labelYear = new System.Windows.Forms.Label();
            this.labelColor = new System.Windows.Forms.Label();
            this.comboBoxItems = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxData = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_return
            // 
            this.btn_return.BackColor = System.Drawing.Color.White;
            this.btn_return.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_return.Location = new System.Drawing.Point(12, 441);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(190, 57);
            this.btn_return.TabIndex = 4;
            this.btn_return.Text = "Exit";
            this.btn_return.UseVisualStyleBackColor = false;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.BackColor = System.Drawing.Color.White;
            this.btn_remove.Location = new System.Drawing.Point(526, 441);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(294, 57);
            this.btn_remove.TabIndex = 2;
            this.btn_remove.Text = "Remove";
            this.btn_remove.UseVisualStyleBackColor = false;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.White;
            this.btn_add.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_add.Location = new System.Drawing.Point(216, 441);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(304, 57);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "Add to Stock";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // comboBoxCables
            // 
            this.comboBoxCables.DisplayMember = "2 3 4 5 6 7 8";
            this.comboBoxCables.FormattingEnabled = true;
            this.comboBoxCables.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.comboBoxCables.Location = new System.Drawing.Point(127, 113);
            this.comboBoxCables.Name = "comboBoxCables";
            this.comboBoxCables.Size = new System.Drawing.Size(83, 28);
            this.comboBoxCables.Sorted = true;
            this.comboBoxCables.TabIndex = 36;
            this.comboBoxCables.Text = "select ";
            // 
            // labelCables
            // 
            this.labelCables.AutoSize = true;
            this.labelCables.Location = new System.Drawing.Point(12, 116);
            this.labelCables.Name = "labelCables";
            this.labelCables.Size = new System.Drawing.Size(53, 20);
            this.labelCables.TabIndex = 35;
            this.labelCables.Text = "Cables";
            // 
            // comboBoxMaxSpeed
            // 
            this.comboBoxMaxSpeed.FormattingEnabled = true;
            this.comboBoxMaxSpeed.Items.AddRange(new object[] {
            "200",
            "300"});
            this.comboBoxMaxSpeed.Location = new System.Drawing.Point(127, 249);
            this.comboBoxMaxSpeed.Name = "comboBoxMaxSpeed";
            this.comboBoxMaxSpeed.Size = new System.Drawing.Size(83, 28);
            this.comboBoxMaxSpeed.Sorted = true;
            this.comboBoxMaxSpeed.TabIndex = 34;
            this.comboBoxMaxSpeed.Text = "select";
            // 
            // labelMaxSpeed
            // 
            this.labelMaxSpeed.AutoSize = true;
            this.labelMaxSpeed.Location = new System.Drawing.Point(12, 252);
            this.labelMaxSpeed.Name = "labelMaxSpeed";
            this.labelMaxSpeed.Size = new System.Drawing.Size(81, 20);
            this.labelMaxSpeed.TabIndex = 33;
            this.labelMaxSpeed.Text = "Max speed";
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Location = new System.Drawing.Point(12, 338);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(71, 20);
            this.lb_id.TabIndex = 32;
            this.lb_id.Text = "Deal\'s ID:";
            // 
            // tb_return_id
            // 
            this.tb_return_id.Location = new System.Drawing.Point(127, 338);
            this.tb_return_id.Name = "tb_return_id";
            this.tb_return_id.ReadOnly = true;
            this.tb_return_id.Size = new System.Drawing.Size(83, 27);
            this.tb_return_id.TabIndex = 31;
            this.tb_return_id.TextChanged += new System.EventHandler(this.tb_return_id_TextChanged);
            // 
            // comboBoxDoors
            // 
            this.comboBoxDoors.FormattingEnabled = true;
            this.comboBoxDoors.Items.AddRange(new object[] {
            "2",
            "4"});
            this.comboBoxDoors.Location = new System.Drawing.Point(127, 215);
            this.comboBoxDoors.Name = "comboBoxDoors";
            this.comboBoxDoors.Size = new System.Drawing.Size(83, 28);
            this.comboBoxDoors.Sorted = true;
            this.comboBoxDoors.TabIndex = 30;
            this.comboBoxDoors.Text = "select";
            // 
            // labelDoor
            // 
            this.labelDoor.AutoSize = true;
            this.labelDoor.Location = new System.Drawing.Point(12, 218);
            this.labelDoor.Name = "labelDoor";
            this.labelDoor.Size = new System.Drawing.Size(110, 20);
            this.labelDoor.TabIndex = 29;
            this.labelDoor.Text = "Door\'s number:";
            // 
            // comboBoxYear
            // 
            this.comboBoxYear.FormattingEnabled = true;
            this.comboBoxYear.Items.AddRange(new object[] {
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022"});
            this.comboBoxYear.Location = new System.Drawing.Point(127, 147);
            this.comboBoxYear.Name = "comboBoxYear";
            this.comboBoxYear.Size = new System.Drawing.Size(83, 28);
            this.comboBoxYear.Sorted = true;
            this.comboBoxYear.TabIndex = 28;
            this.comboBoxYear.Text = "select";
            // 
            // comboBoxWeight
            // 
            this.comboBoxWeight.FormattingEnabled = true;
            this.comboBoxWeight.Location = new System.Drawing.Point(127, 181);
            this.comboBoxWeight.Name = "comboBoxWeight";
            this.comboBoxWeight.Size = new System.Drawing.Size(83, 28);
            this.comboBoxWeight.Sorted = true;
            this.comboBoxWeight.TabIndex = 27;
            this.comboBoxWeight.Text = "select";
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(12, 184);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(56, 20);
            this.labelWeight.TabIndex = 26;
            this.labelWeight.Text = "Weight";
            // 
            // comboBoxColors
            // 
            this.comboBoxColors.AccessibleName = "";
            this.comboBoxColors.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboBoxColors.FormattingEnabled = true;
            this.comboBoxColors.Items.AddRange(new object[] {
            "Black",
            "Grey",
            "White"});
            this.comboBoxColors.Location = new System.Drawing.Point(127, 79);
            this.comboBoxColors.Name = "comboBoxColors";
            this.comboBoxColors.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxColors.Size = new System.Drawing.Size(83, 28);
            this.comboBoxColors.Sorted = true;
            this.comboBoxColors.TabIndex = 25;
            this.comboBoxColors.Text = "select";
            // 
            // lb_price
            // 
            this.lb_price.AutoSize = true;
            this.lb_price.Location = new System.Drawing.Point(12, 305);
            this.lb_price.Name = "lb_price";
            this.lb_price.Size = new System.Drawing.Size(80, 20);
            this.lb_price.TabIndex = 24;
            this.lb_price.Text = "Car\'s price:";
            // 
            // tb_return_price
            // 
            this.tb_return_price.Location = new System.Drawing.Point(127, 305);
            this.tb_return_price.Name = "tb_return_price";
            this.tb_return_price.ReadOnly = true;
            this.tb_return_price.Size = new System.Drawing.Size(83, 27);
            this.tb_return_price.TabIndex = 23;
            this.tb_return_price.TextChanged += new System.EventHandler(this.tb_return_price_TextChanged);
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(12, 150);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(94, 20);
            this.labelYear.TabIndex = 22;
            this.labelYear.Text = "Year of issue:";
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Location = new System.Drawing.Point(12, 82);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(99, 20);
            this.labelColor.TabIndex = 21;
            this.labelColor.Text = "Type of color:";
            // 
            // comboBoxItems
            // 
            this.comboBoxItems.ForeColor = System.Drawing.Color.Black;
            this.comboBoxItems.FormattingEnabled = true;
            this.comboBoxItems.Items.AddRange(new object[] {
            "Charger",
            "Mercedes",
            "Tesla",
            "Volvo"});
            this.comboBoxItems.Location = new System.Drawing.Point(127, 45);
            this.comboBoxItems.Name = "comboBoxItems";
            this.comboBoxItems.Size = new System.Drawing.Size(83, 28);
            this.comboBoxItems.Sorted = true;
            this.comboBoxItems.TabIndex = 20;
            this.comboBoxItems.Text = "select ";
            this.comboBoxItems.SelectedIndexChanged += new System.EventHandler(this.cmb_items_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "Type of car:";
            // 
            // textBoxData
            // 
            this.textBoxData.Location = new System.Drawing.Point(216, 45);
            this.textBoxData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxData.Multiline = true;
            this.textBoxData.Name = "textBoxData";
            this.textBoxData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxData.Size = new System.Drawing.Size(604, 389);
            this.textBoxData.TabIndex = 41;
            // 
            // Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(831, 537);
            this.ControlBox = false;
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.textBoxData);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxCables);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.labelCables);
            this.Controls.Add(this.comboBoxMaxSpeed);
            this.Controls.Add(this.labelMaxSpeed);
            this.Controls.Add(this.lb_id);
            this.Controls.Add(this.tb_return_id);
            this.Controls.Add(this.comboBoxDoors);
            this.Controls.Add(this.labelDoor);
            this.Controls.Add(this.comboBoxYear);
            this.Controls.Add(this.comboBoxWeight);
            this.Controls.Add(this.labelWeight);
            this.Controls.Add(this.comboBoxColors);
            this.Controls.Add(this.lb_price);
            this.Controls.Add(this.tb_return_price);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.labelColor);
            this.Controls.Add(this.comboBoxItems);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Administrator";
            this.Text = "formMangger";
            this.Load += new System.EventHandler(this.FormManager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.ComboBox comboBoxCables;
        private System.Windows.Forms.Label labelCables;
        private System.Windows.Forms.ComboBox comboBoxMaxSpeed;
        private System.Windows.Forms.Label labelMaxSpeed;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.TextBox tb_return_id;
        private System.Windows.Forms.ComboBox comboBoxDoors;
        private System.Windows.Forms.Label labelDoor;
        private System.Windows.Forms.ComboBox comboBoxYear;
        private System.Windows.Forms.ComboBox comboBoxWeight;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.ComboBox comboBoxColors;
        private System.Windows.Forms.Label lb_price;
        private System.Windows.Forms.TextBox tb_return_price;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.ComboBox comboBoxItems;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxData;
    }
}