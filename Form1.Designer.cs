
namespace Kalendoriausprojektas
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
            this.formDays = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMonth2 = new System.Windows.Forms.Button();
            this.btnMonth1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbdata = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // formDays
            // 
            this.formDays.Location = new System.Drawing.Point(26, 123);
            this.formDays.Name = "formDays";
            this.formDays.Size = new System.Drawing.Size(1108, 689);
            this.formDays.TabIndex = 0;
            this.formDays.Paint += new System.Windows.Forms.PaintEventHandler(this.dienos_Paint);
            // 
            // btnMonth2
            // 
            this.btnMonth2.Location = new System.Drawing.Point(1051, 12);
            this.btnMonth2.Name = "btnMonth2";
            this.btnMonth2.Size = new System.Drawing.Size(75, 50);
            this.btnMonth2.TabIndex = 1;
            this.btnMonth2.Text = ">";
            this.btnMonth2.UseVisualStyleBackColor = true;
            this.btnMonth2.Click += new System.EventHandler(this.btnMen2_Click);
            // 
            // btnMonth1
            // 
            this.btnMonth1.Location = new System.Drawing.Point(948, 12);
            this.btnMonth1.Name = "btnMonth1";
            this.btnMonth1.Size = new System.Drawing.Size(75, 50);
            this.btnMonth1.TabIndex = 2;
            this.btnMonth1.Text = "<";
            this.btnMonth1.UseVisualStyleBackColor = true;
            this.btnMonth1.Click += new System.EventHandler(this.btnMen1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sunday";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Monday";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(374, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tuesday";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(528, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Wednesday";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(687, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Thursday";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(843, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Friday";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1007, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Saturday";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // lbdata
            // 
            this.lbdata.AutoSize = true;
            this.lbdata.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdata.Location = new System.Drawing.Point(452, 23);
            this.lbdata.Name = "lbdata";
            this.lbdata.Size = new System.Drawing.Size(246, 38);
            this.lbdata.TabIndex = 4;
            this.lbdata.Text = "MONTH, YEAR";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1174, 840);
            this.Controls.Add(this.lbdata);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMonth1);
            this.Controls.Add(this.btnMonth2);
            this.Controls.Add(this.formDays);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel formDays;
        private System.Windows.Forms.Button btnMonth2;
        private System.Windows.Forms.Button btnMonth1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbdata;
    }
}

