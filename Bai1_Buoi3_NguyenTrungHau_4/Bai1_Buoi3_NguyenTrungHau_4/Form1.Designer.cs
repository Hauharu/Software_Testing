
namespace Bai1_Buoi3_NguyenTrungHau_4
{
    partial class Form1
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
            this.bt_hau_4 = new System.Windows.Forms.Button();
            this.tbox_hau_4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_hau_4
            // 
            this.bt_hau_4.Location = new System.Drawing.Point(211, 268);
            this.bt_hau_4.Name = "bt_hau_4";
            this.bt_hau_4.Size = new System.Drawing.Size(186, 44);
            this.bt_hau_4.TabIndex = 0;
            this.bt_hau_4.Text = "OPEN BROWSER";
            this.bt_hau_4.UseVisualStyleBackColor = true;
            this.bt_hau_4.Click += new System.EventHandler(this.bt_hau_4_Click);
            // 
            // tbox_hau_4
            // 
            this.tbox_hau_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_hau_4.Location = new System.Drawing.Point(211, 154);
            this.tbox_hau_4.Name = "tbox_hau_4";
            this.tbox_hau_4.Size = new System.Drawing.Size(186, 29);
            this.tbox_hau_4.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "URL";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(458, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 44);
            this.button1.TabIndex = 3;
            this.button1.Text = "CLOSE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbox_hau_4);
            this.Controls.Add(this.bt_hau_4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "url";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_hau_4;
        private System.Windows.Forms.TextBox tbox_hau_4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

