
namespace kyrsDb
{
    partial class EditAddress
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
            this.cityTB = new System.Windows.Forms.TextBox();
            this.regionTB = new System.Windows.Forms.TextBox();
            this.streetTB = new System.Windows.Forms.TextBox();
            this.houseTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.accbtn = new System.Windows.Forms.Button();
            this.delbtn = new System.Windows.Forms.Button();
            this.outTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cityTB
            // 
            this.cityTB.Location = new System.Drawing.Point(79, 6);
            this.cityTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cityTB.Name = "cityTB";
            this.cityTB.Size = new System.Drawing.Size(377, 27);
            this.cityTB.TabIndex = 18;
            // 
            // regionTB
            // 
            this.regionTB.Location = new System.Drawing.Point(79, 41);
            this.regionTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.regionTB.Name = "regionTB";
            this.regionTB.Size = new System.Drawing.Size(377, 27);
            this.regionTB.TabIndex = 19;
            // 
            // streetTB
            // 
            this.streetTB.Location = new System.Drawing.Point(79, 76);
            this.streetTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.streetTB.Name = "streetTB";
            this.streetTB.Size = new System.Drawing.Size(377, 27);
            this.streetTB.TabIndex = 20;
            // 
            // houseTB
            // 
            this.houseTB.Location = new System.Drawing.Point(79, 111);
            this.houseTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.houseTB.Name = "houseTB";
            this.houseTB.Size = new System.Drawing.Size(377, 27);
            this.houseTB.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Город";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Район";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Улица";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Дом";
            // 
            // accbtn
            // 
            this.accbtn.Location = new System.Drawing.Point(12, 180);
            this.accbtn.Name = "accbtn";
            this.accbtn.Size = new System.Drawing.Size(213, 36);
            this.accbtn.TabIndex = 34;
            this.accbtn.Text = "Принять";
            this.accbtn.UseVisualStyleBackColor = true;
            this.accbtn.Click += new System.EventHandler(this.accbtn_Click);
            // 
            // delbtn
            // 
            this.delbtn.Location = new System.Drawing.Point(227, 180);
            this.delbtn.Name = "delbtn";
            this.delbtn.Size = new System.Drawing.Size(229, 36);
            this.delbtn.TabIndex = 35;
            this.delbtn.Text = "Удалить";
            this.delbtn.UseVisualStyleBackColor = true;
            this.delbtn.Click += new System.EventHandler(this.delbtn_Click);
            // 
            // outTB
            // 
            this.outTB.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.outTB.Location = new System.Drawing.Point(12, 146);
            this.outTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.outTB.Name = "outTB";
            this.outTB.ReadOnly = true;
            this.outTB.Size = new System.Drawing.Size(444, 27);
            this.outTB.TabIndex = 36;
            // 
            // EditAddress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 225);
            this.Controls.Add(this.outTB);
            this.Controls.Add(this.delbtn);
            this.Controls.Add(this.accbtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.houseTB);
            this.Controls.Add(this.streetTB);
            this.Controls.Add(this.regionTB);
            this.Controls.Add(this.cityTB);
            this.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(481, 233);
            this.Name = "EditAddress";
            this.Text = "EditAddress";
            this.Load += new System.EventHandler(this.EditAddress_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cityTB;
        private System.Windows.Forms.TextBox regionTB;
        private System.Windows.Forms.TextBox streetTB;
        private System.Windows.Forms.TextBox houseTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button accbtn;
        private System.Windows.Forms.Button delbtn;
        private System.Windows.Forms.TextBox outTB;
    }
}