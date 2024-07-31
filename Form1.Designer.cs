namespace CSharp_LaiSuat
{
    partial class Form1
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
            btnTinh = new Button();
            label1 = new Label();
            txtNbd = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtTien = new TextBox();
            txtNam = new TextBox();
            txtLS = new TextBox();
            label5 = new Label();
            TN = new ListBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // btnTinh
            // 
            btnTinh.Location = new Point(434, 99);
            btnTinh.Margin = new Padding(6, 7, 6, 7);
            btnTinh.Name = "btnTinh";
            btnTinh.Size = new Size(119, 42);
            btnTinh.TabIndex = 0;
            btnTinh.Text = "Tính";
            btnTinh.UseVisualStyleBackColor = true;
            btnTinh.Click += btnTinh_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 9);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(178, 33);
            label1.TabIndex = 1;
            label1.Text = "Năm bắt đầu:";
            // 
            // txtNbd
            // 
            txtNbd.Location = new Point(202, 6);
            txtNbd.Name = "txtNbd";
            txtNbd.Size = new Size(100, 40);
            txtNbd.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(311, 9);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(133, 33);
            label2.TabIndex = 1;
            label2.Text = "Đến năm:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 56);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(184, 33);
            label3.TabIndex = 1;
            label3.Text = "Số tiền mượn:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 102);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(106, 33);
            label4.TabIndex = 1;
            label4.Text = "Lãi suất";
            // 
            // txtTien
            // 
            txtTien.Location = new Point(202, 53);
            txtTien.Name = "txtTien";
            txtTien.Size = new Size(351, 40);
            txtTien.TabIndex = 2;
            // 
            // txtNam
            // 
            txtNam.Location = new Point(453, 6);
            txtNam.Name = "txtNam";
            txtNam.Size = new Size(100, 40);
            txtNam.TabIndex = 2;
            // 
            // txtLS
            // 
            txtLS.Location = new Point(202, 99);
            txtLS.Name = "txtLS";
            txtLS.Size = new Size(100, 40);
            txtLS.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 146);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(145, 33);
            label5.TabIndex = 1;
            label5.Text = "Số tiền nợ:";
            // 
            // TN
            // 
            TN.FormattingEnabled = true;
            TN.ItemHeight = 33;
            TN.Location = new Point(15, 182);
            TN.Name = "TN";
            TN.Size = new Size(785, 268);
            TN.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(308, 102);
            label6.Name = "label6";
            label6.Size = new Size(41, 33);
            label6.TabIndex = 4;
            label6.Text = "%";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(812, 456);
            Controls.Add(label6);
            Controls.Add(TN);
            Controls.Add(txtLS);
            Controls.Add(txtTien);
            Controls.Add(txtNam);
            Controls.Add(txtNbd);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(btnTinh);
            Font = new Font("Tahoma", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 7, 6, 7);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTinh;
        private Label label1;
        private TextBox txtNbd;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtTien;
        private TextBox txtNam;
        private TextBox txtLS;
        private Label label5;
        private ListBox TN;
        private Label label6;
    }
}
