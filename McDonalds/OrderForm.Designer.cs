
using System.Drawing;

namespace McDonalds
{
    partial class OrderForm
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
            this.order_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownChips = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownBurgers = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownNuggets = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDrinks = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.label_cost = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownChips)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBurgers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNuggets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDrinks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_back)).BeginInit();
            this.SuspendLayout();
            // 
            // order_btn
            // 
            this.order_btn.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.order_btn.Location = new System.Drawing.Point(278, 386);
            this.order_btn.Name = "order_btn";
            this.order_btn.Size = new System.Drawing.Size(88, 31);
            this.order_btn.TabIndex = 0;
            this.order_btn.Text = "Order!";
            this.order_btn.UseVisualStyleBackColor = true;
            this.order_btn.Click += new System.EventHandler(this.btn_order_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(174, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number of Burgers";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(174, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Number of Chips";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(174, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Number of Nuggets";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(174, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "Number of Drinks";
            // 
            // numericUpDownChips
            // 
            this.numericUpDownChips.Location = new System.Drawing.Point(507, 260);
            this.numericUpDownChips.Name = "numericUpDownChips";
            this.numericUpDownChips.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownChips.TabIndex = 6;
            this.numericUpDownChips.ValueChanged += new System.EventHandler(this.numericUpDownChips_ValueChanged);
            // 
            // numericUpDownBurgers
            // 
            this.numericUpDownBurgers.Location = new System.Drawing.Point(507, 221);
            this.numericUpDownBurgers.Name = "numericUpDownBurgers";
            this.numericUpDownBurgers.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownBurgers.TabIndex = 7;
            this.numericUpDownBurgers.ValueChanged += new System.EventHandler(this.numericUpDownBurgers_ValueChanged);
            // 
            // numericUpDownNuggets
            // 
            this.numericUpDownNuggets.Location = new System.Drawing.Point(507, 299);
            this.numericUpDownNuggets.Name = "numericUpDownNuggets";
            this.numericUpDownNuggets.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownNuggets.TabIndex = 8;
            this.numericUpDownNuggets.ValueChanged += new System.EventHandler(this.numericUpDownNuggets_ValueChanged);
            // 
            // numericUpDownDrinks
            // 
            this.numericUpDownDrinks.Location = new System.Drawing.Point(507, 338);
            this.numericUpDownDrinks.Name = "numericUpDownDrinks";
            this.numericUpDownDrinks.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownDrinks.TabIndex = 9;
            this.numericUpDownDrinks.ValueChanged += new System.EventHandler(this.numericUpDownDrinks_ValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::McDonalds.Properties.Resources.mcdonalds_logo;
            this.pictureBox1.Location = new System.Drawing.Point(-151, -14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(978, 193);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_clear.Location = new System.Drawing.Point(174, 386);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(88, 31);
            this.btn_clear.TabIndex = 11;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // label_cost
            // 
            this.label_cost.AutoSize = true;
            this.label_cost.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_cost.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label_cost.Location = new System.Drawing.Point(507, 388);
            this.label_cost.Name = "label_cost";
            this.label_cost.Size = new System.Drawing.Size(95, 25);
            this.label_cost.TabIndex = 12;
            this.label_cost.Text = "Total: R 0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(457, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "R35 X";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(459, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "R15 X";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(459, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "R25 X";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Location = new System.Drawing.Point(459, 338);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 19);
            this.label8.TabIndex = 16;
            this.label8.Text = "R20 X";
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Transparent;
            this.btn_back.BackgroundImage = global::McDonalds.Properties.Resources.mcdonalds_logo;
            this.btn_back.Image = global::McDonalds.Properties.Resources.back_button_image;
            this.btn_back.Location = new System.Drawing.Point(26, 26);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(50, 50);
            this.btn_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_back.TabIndex = 17;
            this.btn_back.TabStop = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 532);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_cost);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.numericUpDownDrinks);
            this.Controls.Add(this.numericUpDownNuggets);
            this.Controls.Add(this.numericUpDownBurgers);
            this.Controls.Add(this.numericUpDownChips);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.order_btn);
            this.Name = "OrderForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownChips)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBurgers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNuggets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDrinks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button order_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownChips;
        private System.Windows.Forms.NumericUpDown numericUpDownBurgers;
        private System.Windows.Forms.NumericUpDown numericUpDownNuggets;
        private System.Windows.Forms.NumericUpDown numericUpDownDrinks;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label label_cost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox btn_back;
    }
}

