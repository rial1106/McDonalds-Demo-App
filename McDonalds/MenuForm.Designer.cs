
namespace McDonalds
{
    partial class MenuForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_view_previous = new System.Windows.Forms.Button();
            this.btn_make_order = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::McDonalds.Properties.Resources.mcdonalds_logo;
            this.pictureBox1.Location = new System.Drawing.Point(-151, -14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(978, 194);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btn_view_previous
            // 
            this.btn_view_previous.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_view_previous.Location = new System.Drawing.Point(505, 275);
            this.btn_view_previous.Name = "btn_view_previous";
            this.btn_view_previous.Size = new System.Drawing.Size(162, 70);
            this.btn_view_previous.TabIndex = 14;
            this.btn_view_previous.Text = "View Previous Orders";
            this.btn_view_previous.UseVisualStyleBackColor = true;
            this.btn_view_previous.Click += new System.EventHandler(this.btn_view_previous_Click);
            // 
            // btn_make_order
            // 
            this.btn_make_order.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_make_order.Location = new System.Drawing.Point(133, 275);
            this.btn_make_order.Name = "btn_make_order";
            this.btn_make_order.Size = new System.Drawing.Size(162, 70);
            this.btn_make_order.TabIndex = 15;
            this.btn_make_order.Text = "Make An Order";
            this.btn_make_order.UseVisualStyleBackColor = true;
            this.btn_make_order.Click += new System.EventHandler(this.btn_make_order_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_make_order);
            this.Controls.Add(this.btn_view_previous);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MenuForm";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_view_previous;
        private System.Windows.Forms.Button btn_make_order;
    }
}