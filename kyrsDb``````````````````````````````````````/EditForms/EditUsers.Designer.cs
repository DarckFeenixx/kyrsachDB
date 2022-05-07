
namespace kyrsDb
{
    partial class EditUsers
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
            this.delbtn = new System.Windows.Forms.Button();
            this.accbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.companyTB = new System.Windows.Forms.TextBox();
            this.passTB = new System.Windows.Forms.TextBox();
            this.loginTB = new System.Windows.Forms.TextBox();
            this.outTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // delbtn
            // 
            this.delbtn.Location = new System.Drawing.Point(228, 152);
            this.delbtn.Name = "delbtn";
            this.delbtn.Size = new System.Drawing.Size(229, 36);
            this.delbtn.TabIndex = 45;
            this.delbtn.Text = "Удалить";
            this.delbtn.UseVisualStyleBackColor = true;
            this.delbtn.Click += new System.EventHandler(this.delbtn_Click);
            // 
            // accbtn
            // 
            this.accbtn.Location = new System.Drawing.Point(13, 152);
            this.accbtn.Name = "accbtn";
            this.accbtn.Size = new System.Drawing.Size(213, 36);
            this.accbtn.TabIndex = 44;
            this.accbtn.Text = "Принять";
            this.accbtn.UseVisualStyleBackColor = true;
            this.accbtn.Click += new System.EventHandler(this.accbtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 42;
            this.label3.Text = "Компания";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 41;
            this.label2.Text = "Пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 40;
            this.label1.Text = "Логин";
            // 
            // companyTB
            // 
            this.companyTB.Location = new System.Drawing.Point(99, 83);
            this.companyTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.companyTB.Name = "companyTB";
            this.companyTB.Size = new System.Drawing.Size(357, 27);
            this.companyTB.TabIndex = 38;
            // 
            // passTB
            // 
            this.passTB.Location = new System.Drawing.Point(99, 48);
            this.passTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.passTB.Name = "passTB";
            this.passTB.Size = new System.Drawing.Size(357, 27);
            this.passTB.TabIndex = 37;
            // 
            // loginTB
            // 
            this.loginTB.Location = new System.Drawing.Point(99, 13);
            this.loginTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.loginTB.Name = "loginTB";
            this.loginTB.Size = new System.Drawing.Size(357, 27);
            this.loginTB.TabIndex = 36;
            // 
            // outTB
            // 
            this.outTB.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.outTB.Location = new System.Drawing.Point(13, 118);
            this.outTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.outTB.Name = "outTB";
            this.outTB.ReadOnly = true;
            this.outTB.Size = new System.Drawing.Size(444, 27);
            this.outTB.TabIndex = 46;
            // 
            // EditUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 199);
            this.Controls.Add(this.outTB);
            this.Controls.Add(this.delbtn);
            this.Controls.Add(this.accbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.companyTB);
            this.Controls.Add(this.passTB);
            this.Controls.Add(this.loginTB);
            this.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EditUsers";
            this.Text = "EditUsers";
            this.Load += new System.EventHandler(this.EditUsers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button delbtn;
        private System.Windows.Forms.Button accbtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox companyTB;
        private System.Windows.Forms.TextBox passTB;
        private System.Windows.Forms.TextBox loginTB;
        private System.Windows.Forms.TextBox outTB;
    }
}