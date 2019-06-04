namespace WindowsFormsApplication7
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
            this.lbEn = new System.Windows.Forms.ListBox();
            this.lbRus = new System.Windows.Forms.ListBox();
            this.cbEn = new System.Windows.Forms.ComboBox();
            this.cbRus = new System.Windows.Forms.ComboBox();
            this.tbEn = new System.Windows.Forms.TextBox();
            this.tbRus = new System.Windows.Forms.TextBox();
            this.bAdd = new System.Windows.Forms.Button();
            this.lEn = new System.Windows.Forms.Label();
            this.lRuss = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbEn
            // 
            this.lbEn.FormattingEnabled = true;
            this.lbEn.Location = new System.Drawing.Point(36, 90);
            this.lbEn.Name = "lbEn";
            this.lbEn.Size = new System.Drawing.Size(132, 160);
            this.lbEn.TabIndex = 0;
            // 
            // lbRus
            // 
            this.lbRus.FormattingEnabled = true;
            this.lbRus.Location = new System.Drawing.Point(228, 90);
            this.lbRus.Name = "lbRus";
            this.lbRus.Size = new System.Drawing.Size(132, 160);
            this.lbRus.TabIndex = 1;
            // 
            // cbEn
            // 
            this.cbEn.FormattingEnabled = true;
            this.cbEn.Location = new System.Drawing.Point(37, 63);
            this.cbEn.Name = "cbEn";
            this.cbEn.Size = new System.Drawing.Size(132, 21);
            this.cbEn.TabIndex = 2;
            this.cbEn.SelectedIndexChanged += new System.EventHandler(this.cbEn_SelectedIndexChanged);
            // 
            // cbRus
            // 
            this.cbRus.FormattingEnabled = true;
            this.cbRus.Location = new System.Drawing.Point(228, 63);
            this.cbRus.Name = "cbRus";
            this.cbRus.Size = new System.Drawing.Size(132, 21);
            this.cbRus.TabIndex = 3;
            // 
            // tbEn
            // 
            this.tbEn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbEn.Location = new System.Drawing.Point(37, 35);
            this.tbEn.Name = "tbEn";
            this.tbEn.Size = new System.Drawing.Size(131, 22);
            this.tbEn.TabIndex = 4;
            // 
            // tbRus
            // 
            this.tbRus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbRus.Location = new System.Drawing.Point(228, 35);
            this.tbRus.Name = "tbRus";
            this.tbRus.Size = new System.Drawing.Size(131, 22);
            this.tbRus.TabIndex = 5;
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(174, 35);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(48, 21);
            this.bAdd.TabIndex = 6;
            this.bAdd.Text = "add";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // lEn
            // 
            this.lEn.AutoSize = true;
            this.lEn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lEn.Location = new System.Drawing.Point(63, 9);
            this.lEn.Name = "lEn";
            this.lEn.Size = new System.Drawing.Size(52, 16);
            this.lEn.TabIndex = 7;
            this.lEn.Text = "English";
            // 
            // lRuss
            // 
            this.lRuss.AutoSize = true;
            this.lRuss.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lRuss.Location = new System.Drawing.Point(260, 9);
            this.lRuss.Name = "lRuss";
            this.lRuss.Size = new System.Drawing.Size(57, 16);
            this.lRuss.TabIndex = 8;
            this.lRuss.Text = "Russian";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(10, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "en";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(198, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "rus";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(7, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "rus";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(198, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "en";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 262);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lRuss);
            this.Controls.Add(this.lEn);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.tbRus);
            this.Controls.Add(this.tbEn);
            this.Controls.Add(this.cbRus);
            this.Controls.Add(this.cbEn);
            this.Controls.Add(this.lbRus);
            this.Controls.Add(this.lbEn);
            this.Name = "Form1";
            this.Text = " Translator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbEn;
        private System.Windows.Forms.ListBox lbRus;
        private System.Windows.Forms.ComboBox cbEn;
        private System.Windows.Forms.ComboBox cbRus;
        private System.Windows.Forms.TextBox tbEn;
        private System.Windows.Forms.TextBox tbRus;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Label lEn;
        private System.Windows.Forms.Label lRuss;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

