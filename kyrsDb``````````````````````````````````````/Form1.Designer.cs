
namespace kyrsDb
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
            this.LoginGb = new System.Windows.Forms.GroupBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.passLB = new System.Windows.Forms.Label();
            this.loginLB = new System.Windows.Forms.Label();
            this.passTB = new System.Windows.Forms.TextBox();
            this.loginTB = new System.Windows.Forms.TextBox();
            this.entCredLB = new System.Windows.Forms.Label();
            this.mainGB = new System.Windows.Forms.GroupBox();
            this.NumCamPerOwnerBtn = new System.Windows.Forms.Button();
            this.CamNumPerRegionBtn = new System.Windows.Forms.Button();
            this.GetLongMaintanceBtn = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.filtHouseTB = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.filtStreetTB = new System.Windows.Forms.TextBox();
            this.filtRegionTB = new System.Windows.Forms.TextBox();
            this.filtCityTB = new System.Windows.Forms.TextBox();
            this.filtIpTB = new System.Windows.Forms.TextBox();
            this.filtDatePlacedTB = new System.Windows.Forms.TextBox();
            this.filtMacTB = new System.Windows.Forms.TextBox();
            this.filtOwnerTB = new System.Windows.Forms.TextBox();
            this.filtManufactorerTB = new System.Windows.Forms.TextBox();
            this.filtModelTB = new System.Windows.Forms.TextBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.applyFilterBtn = new System.Windows.Forms.Button();
            this.outInfoTb = new System.Windows.Forms.TextBox();
            this.openEditFormsBtn = new System.Windows.Forms.Button();
            this.nextPagebtn = new System.Windows.Forms.Button();
            this.prevPagebtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableSelectCB = new System.Windows.Forms.ComboBox();
            this.paginCB = new System.Windows.Forms.ComboBox();
            this.tableOutDgv = new System.Windows.Forms.DataGridView();
            this.LoginGb.SuspendLayout();
            this.mainGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableOutDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginGb
            // 
            this.LoginGb.Controls.Add(this.loginBtn);
            this.LoginGb.Controls.Add(this.passLB);
            this.LoginGb.Controls.Add(this.loginLB);
            this.LoginGb.Controls.Add(this.passTB);
            this.LoginGb.Controls.Add(this.loginTB);
            this.LoginGb.Controls.Add(this.entCredLB);
            this.LoginGb.Location = new System.Drawing.Point(376, 206);
            this.LoginGb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LoginGb.Name = "LoginGb";
            this.LoginGb.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LoginGb.Size = new System.Drawing.Size(332, 183);
            this.LoginGb.TabIndex = 0;
            this.LoginGb.TabStop = false;
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(9, 138);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(311, 38);
            this.loginBtn.TabIndex = 5;
            this.loginBtn.Text = "Войти в систему";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // passLB
            // 
            this.passLB.AutoSize = true;
            this.passLB.Location = new System.Drawing.Point(9, 108);
            this.passLB.Name = "passLB";
            this.passLB.Size = new System.Drawing.Size(60, 20);
            this.passLB.TabIndex = 4;
            this.passLB.Text = "пароль";
            // 
            // loginLB
            // 
            this.loginLB.AutoSize = true;
            this.loginLB.Location = new System.Drawing.Point(9, 62);
            this.loginLB.Name = "loginLB";
            this.loginLB.Size = new System.Drawing.Size(50, 20);
            this.loginLB.TabIndex = 3;
            this.loginLB.Text = "логин";
            // 
            // passTB
            // 
            this.passTB.Location = new System.Drawing.Point(75, 105);
            this.passTB.Name = "passTB";
            this.passTB.Size = new System.Drawing.Size(232, 27);
            this.passTB.TabIndex = 2;
            // 
            // loginTB
            // 
            this.loginTB.Location = new System.Drawing.Point(75, 59);
            this.loginTB.Name = "loginTB";
            this.loginTB.Size = new System.Drawing.Size(232, 27);
            this.loginTB.TabIndex = 1;
            // 
            // entCredLB
            // 
            this.entCredLB.AutoSize = true;
            this.entCredLB.Location = new System.Drawing.Point(97, 25);
            this.entCredLB.Name = "entCredLB";
            this.entCredLB.Size = new System.Drawing.Size(178, 20);
            this.entCredLB.TabIndex = 0;
            this.entCredLB.Text = "Введите логин и пароль";
            // 
            // mainGB
            // 
            this.mainGB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainGB.Controls.Add(this.NumCamPerOwnerBtn);
            this.mainGB.Controls.Add(this.CamNumPerRegionBtn);
            this.mainGB.Controls.Add(this.GetLongMaintanceBtn);
            this.mainGB.Controls.Add(this.label12);
            this.mainGB.Controls.Add(this.filtHouseTB);
            this.mainGB.Controls.Add(this.label11);
            this.mainGB.Controls.Add(this.label10);
            this.mainGB.Controls.Add(this.label9);
            this.mainGB.Controls.Add(this.label8);
            this.mainGB.Controls.Add(this.label7);
            this.mainGB.Controls.Add(this.label6);
            this.mainGB.Controls.Add(this.label5);
            this.mainGB.Controls.Add(this.label4);
            this.mainGB.Controls.Add(this.label3);
            this.mainGB.Controls.Add(this.filtStreetTB);
            this.mainGB.Controls.Add(this.filtRegionTB);
            this.mainGB.Controls.Add(this.filtCityTB);
            this.mainGB.Controls.Add(this.filtIpTB);
            this.mainGB.Controls.Add(this.filtDatePlacedTB);
            this.mainGB.Controls.Add(this.filtMacTB);
            this.mainGB.Controls.Add(this.filtOwnerTB);
            this.mainGB.Controls.Add(this.filtManufactorerTB);
            this.mainGB.Controls.Add(this.filtModelTB);
            this.mainGB.Controls.Add(this.deleteBtn);
            this.mainGB.Controls.Add(this.applyFilterBtn);
            this.mainGB.Controls.Add(this.outInfoTb);
            this.mainGB.Controls.Add(this.openEditFormsBtn);
            this.mainGB.Controls.Add(this.LoginGb);
            this.mainGB.Controls.Add(this.nextPagebtn);
            this.mainGB.Controls.Add(this.prevPagebtn);
            this.mainGB.Controls.Add(this.label2);
            this.mainGB.Controls.Add(this.label1);
            this.mainGB.Controls.Add(this.tableSelectCB);
            this.mainGB.Controls.Add(this.paginCB);
            this.mainGB.Controls.Add(this.tableOutDgv);
            this.mainGB.Location = new System.Drawing.Point(12, -3);
            this.mainGB.Name = "mainGB";
            this.mainGB.Size = new System.Drawing.Size(1140, 591);
            this.mainGB.TabIndex = 2;
            this.mainGB.TabStop = false;
            this.mainGB.Visible = false;
            // 
            // NumCamPerOwnerBtn
            // 
            this.NumCamPerOwnerBtn.Location = new System.Drawing.Point(802, 550);
            this.NumCamPerOwnerBtn.Name = "NumCamPerOwnerBtn";
            this.NumCamPerOwnerBtn.Size = new System.Drawing.Size(329, 35);
            this.NumCamPerOwnerBtn.TabIndex = 53;
            this.NumCamPerOwnerBtn.Text = "Количество камер по владельцам";
            this.NumCamPerOwnerBtn.UseVisualStyleBackColor = true;
            this.NumCamPerOwnerBtn.Click += new System.EventHandler(this.NumCamPerOwnerBtn_Click);
            // 
            // CamNumPerRegionBtn
            // 
            this.CamNumPerRegionBtn.Location = new System.Drawing.Point(802, 509);
            this.CamNumPerRegionBtn.Name = "CamNumPerRegionBtn";
            this.CamNumPerRegionBtn.Size = new System.Drawing.Size(329, 35);
            this.CamNumPerRegionBtn.TabIndex = 52;
            this.CamNumPerRegionBtn.Text = "Количество камер по районам";
            this.CamNumPerRegionBtn.UseVisualStyleBackColor = true;
            this.CamNumPerRegionBtn.Click += new System.EventHandler(this.CamNumPerRegionBtn_Click);
            // 
            // GetLongMaintanceBtn
            // 
            this.GetLongMaintanceBtn.Location = new System.Drawing.Point(802, 471);
            this.GetLongMaintanceBtn.Name = "GetLongMaintanceBtn";
            this.GetLongMaintanceBtn.Size = new System.Drawing.Size(329, 35);
            this.GetLongMaintanceBtn.TabIndex = 51;
            this.GetLongMaintanceBtn.Text = "Давно не проводилось техобслуживние";
            this.GetLongMaintanceBtn.UseVisualStyleBackColor = true;
            this.GetLongMaintanceBtn.Click += new System.EventHandler(this.GetLongMaintanceBtn_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(802, 441);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 20);
            this.label12.TabIndex = 50;
            this.label12.Text = "Дом";
            // 
            // filtHouseTB
            // 
            this.filtHouseTB.Location = new System.Drawing.Point(881, 438);
            this.filtHouseTB.Name = "filtHouseTB";
            this.filtHouseTB.Size = new System.Drawing.Size(250, 27);
            this.filtHouseTB.TabIndex = 49;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(802, 407);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 20);
            this.label11.TabIndex = 48;
            this.label11.Text = "Улица";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(802, 374);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 20);
            this.label10.TabIndex = 47;
            this.label10.Text = "Район";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(802, 341);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 20);
            this.label9.TabIndex = 46;
            this.label9.Text = "Город";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(802, 308);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 20);
            this.label8.TabIndex = 45;
            this.label8.Text = "IP адрес";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(799, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 20);
            this.label7.TabIndex = 44;
            this.label7.Text = "Дата установки";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(799, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 20);
            this.label6.TabIndex = 43;
            this.label6.Text = "MAC Адрес";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(799, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 42;
            this.label5.Text = "Владелец";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(799, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 20);
            this.label4.TabIndex = 41;
            this.label4.Text = "Производитель";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(802, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 40;
            this.label3.Text = "Модель";
            // 
            // filtStreetTB
            // 
            this.filtStreetTB.Location = new System.Drawing.Point(881, 404);
            this.filtStreetTB.Name = "filtStreetTB";
            this.filtStreetTB.Size = new System.Drawing.Size(250, 27);
            this.filtStreetTB.TabIndex = 39;
            // 
            // filtRegionTB
            // 
            this.filtRegionTB.Location = new System.Drawing.Point(881, 371);
            this.filtRegionTB.Name = "filtRegionTB";
            this.filtRegionTB.Size = new System.Drawing.Size(250, 27);
            this.filtRegionTB.TabIndex = 38;
            // 
            // filtCityTB
            // 
            this.filtCityTB.Location = new System.Drawing.Point(881, 338);
            this.filtCityTB.Name = "filtCityTB";
            this.filtCityTB.Size = new System.Drawing.Size(250, 27);
            this.filtCityTB.TabIndex = 37;
            // 
            // filtIpTB
            // 
            this.filtIpTB.Location = new System.Drawing.Point(881, 305);
            this.filtIpTB.Name = "filtIpTB";
            this.filtIpTB.Size = new System.Drawing.Size(250, 27);
            this.filtIpTB.TabIndex = 36;
            // 
            // filtDatePlacedTB
            // 
            this.filtDatePlacedTB.Location = new System.Drawing.Point(923, 239);
            this.filtDatePlacedTB.Name = "filtDatePlacedTB";
            this.filtDatePlacedTB.Size = new System.Drawing.Size(208, 27);
            this.filtDatePlacedTB.TabIndex = 35;
            // 
            // filtMacTB
            // 
            this.filtMacTB.Location = new System.Drawing.Point(923, 272);
            this.filtMacTB.Name = "filtMacTB";
            this.filtMacTB.Size = new System.Drawing.Size(208, 27);
            this.filtMacTB.TabIndex = 34;
            // 
            // filtOwnerTB
            // 
            this.filtOwnerTB.Location = new System.Drawing.Point(923, 206);
            this.filtOwnerTB.Name = "filtOwnerTB";
            this.filtOwnerTB.Size = new System.Drawing.Size(208, 27);
            this.filtOwnerTB.TabIndex = 33;
            // 
            // filtManufactorerTB
            // 
            this.filtManufactorerTB.Location = new System.Drawing.Point(923, 171);
            this.filtManufactorerTB.Name = "filtManufactorerTB";
            this.filtManufactorerTB.Size = new System.Drawing.Size(208, 27);
            this.filtManufactorerTB.TabIndex = 32;
            // 
            // filtModelTB
            // 
            this.filtModelTB.Location = new System.Drawing.Point(923, 138);
            this.filtModelTB.Name = "filtModelTB";
            this.filtModelTB.Size = new System.Drawing.Size(208, 27);
            this.filtModelTB.TabIndex = 31;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(1047, 97);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(84, 35);
            this.deleteBtn.TabIndex = 30;
            this.deleteBtn.Text = "Удалить";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // applyFilterBtn
            // 
            this.applyFilterBtn.Location = new System.Drawing.Point(799, 97);
            this.applyFilterBtn.Name = "applyFilterBtn";
            this.applyFilterBtn.Size = new System.Drawing.Size(242, 35);
            this.applyFilterBtn.TabIndex = 29;
            this.applyFilterBtn.Text = "Применить фильтры";
            this.applyFilterBtn.UseVisualStyleBackColor = true;
            this.applyFilterBtn.Click += new System.EventHandler(this.applyFilterBtn_Click);
            // 
            // outInfoTb
            // 
            this.outInfoTb.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.outInfoTb.Location = new System.Drawing.Point(799, 64);
            this.outInfoTb.Name = "outInfoTb";
            this.outInfoTb.ReadOnly = true;
            this.outInfoTb.Size = new System.Drawing.Size(332, 27);
            this.outInfoTb.TabIndex = 28;
            // 
            // openEditFormsBtn
            // 
            this.openEditFormsBtn.Location = new System.Drawing.Point(799, 14);
            this.openEditFormsBtn.Name = "openEditFormsBtn";
            this.openEditFormsBtn.Size = new System.Drawing.Size(332, 43);
            this.openEditFormsBtn.TabIndex = 27;
            this.openEditFormsBtn.Text = "Открыть редактор";
            this.openEditFormsBtn.UseVisualStyleBackColor = true;
            this.openEditFormsBtn.Click += new System.EventHandler(this.openEditFormsBtn_Click);
            // 
            // nextPagebtn
            // 
            this.nextPagebtn.Location = new System.Drawing.Point(759, 14);
            this.nextPagebtn.Name = "nextPagebtn";
            this.nextPagebtn.Size = new System.Drawing.Size(34, 28);
            this.nextPagebtn.TabIndex = 9;
            this.nextPagebtn.Text = ">";
            this.nextPagebtn.UseVisualStyleBackColor = true;
            this.nextPagebtn.Click += new System.EventHandler(this.nextPagebtn_Click);
            // 
            // prevPagebtn
            // 
            this.prevPagebtn.Location = new System.Drawing.Point(728, 14);
            this.prevPagebtn.Name = "prevPagebtn";
            this.prevPagebtn.Size = new System.Drawing.Size(34, 28);
            this.prevPagebtn.TabIndex = 8;
            this.prevPagebtn.Text = "<";
            this.prevPagebtn.UseVisualStyleBackColor = true;
            this.prevPagebtn.Click += new System.EventHandler(this.prevPagebtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(385, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Количество записей на странице:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Таблица для работы:";
            // 
            // tableSelectCB
            // 
            this.tableSelectCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tableSelectCB.FormattingEnabled = true;
            this.tableSelectCB.Items.AddRange(new object[] {
            "Камеры",
            "Владельцы",
            "Адреса",
            "Модели",
            "Пользователи"});
            this.tableSelectCB.Location = new System.Drawing.Point(167, 15);
            this.tableSelectCB.Name = "tableSelectCB";
            this.tableSelectCB.Size = new System.Drawing.Size(212, 28);
            this.tableSelectCB.TabIndex = 5;
            this.tableSelectCB.SelectedIndexChanged += new System.EventHandler(this.tableSelectCB_SelectedIndexChanged);
            // 
            // paginCB
            // 
            this.paginCB.BackColor = System.Drawing.SystemColors.Window;
            this.paginCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.paginCB.FormattingEnabled = true;
            this.paginCB.Items.AddRange(new object[] {
            "все",
            "10",
            "30",
            "50"});
            this.paginCB.Location = new System.Drawing.Point(632, 15);
            this.paginCB.Name = "paginCB";
            this.paginCB.Size = new System.Drawing.Size(92, 28);
            this.paginCB.TabIndex = 4;
            this.paginCB.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tableOutDgv
            // 
            this.tableOutDgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableOutDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableOutDgv.Location = new System.Drawing.Point(6, 44);
            this.tableOutDgv.Name = "tableOutDgv";
            this.tableOutDgv.RowTemplate.Height = 25;
            this.tableOutDgv.Size = new System.Drawing.Size(787, 541);
            this.tableOutDgv.TabIndex = 3;
            this.tableOutDgv.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 586);
            this.Controls.Add(this.mainGB);
            this.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1110, 625);
            this.Name = "Form1";
            this.Text = "Реестр видеокамер";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.LoginGb.ResumeLayout(false);
            this.LoginGb.PerformLayout();
            this.mainGB.ResumeLayout(false);
            this.mainGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableOutDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox LoginGb;
        private System.Windows.Forms.Label passLB;
        private System.Windows.Forms.Label loginLB;
        private System.Windows.Forms.TextBox passTB;
        private System.Windows.Forms.TextBox loginTB;
        private System.Windows.Forms.Label entCredLB;
        private System.Windows.Forms.GroupBox mainGB;
        private System.Windows.Forms.DataGridView tableOutDgv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox tableSelectCB;
        private System.Windows.Forms.ComboBox paginCB;
        private System.Windows.Forms.Button nextPagebtn;
        private System.Windows.Forms.Button prevPagebtn;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button NumCamPerOwnerBtn;
        private System.Windows.Forms.Button CamNumPerRegionBtn;
        private System.Windows.Forms.Button GetLongMaintanceBtn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox filtHouseTB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox filtStreetTB;
        private System.Windows.Forms.TextBox filtRegionTB;
        private System.Windows.Forms.TextBox filtCityTB;
        private System.Windows.Forms.TextBox filtIpTB;
        private System.Windows.Forms.TextBox filtDatePlacedTB;
        private System.Windows.Forms.TextBox filtMacTB;
        private System.Windows.Forms.TextBox filtOwnerTB;
        private System.Windows.Forms.TextBox filtManufactorerTB;
        private System.Windows.Forms.TextBox filtModelTB;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button applyFilterBtn;
        private System.Windows.Forms.TextBox outInfoTb;
        private System.Windows.Forms.Button openEditFormsBtn;
    }
}

