
namespace Temp.Monitoring
{
    partial class Temp_Monitoring
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
            this.VidFish = new System.Windows.Forms.Label();
            this.Temp = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            this.Temp_Rid = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.CreateOtchet = new System.Windows.Forms.Button();
            this.cbVidFish = new System.Windows.Forms.ComboBox();
            this.TempForMax = new System.Windows.Forms.TextBox();
            this.TempForMin = new System.Windows.Forms.TextBox();
            this.TimeForMax = new System.Windows.Forms.TextBox();
            this.TimeForMin = new System.Windows.Forms.TextBox();
            this.TempRid = new System.Windows.Forms.TextBox();
            this.dgvGrafik = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mtbDate = new System.Windows.Forms.MaskedTextBox();
            this.textOtchet = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrafik)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // VidFish
            // 
            this.VidFish.AutoSize = true;
            this.VidFish.Location = new System.Drawing.Point(60, 37);
            this.VidFish.Name = "VidFish";
            this.VidFish.Size = new System.Drawing.Size(79, 20);
            this.VidFish.TabIndex = 0;
            this.VidFish.Text = "Вид рыбы";
            // 
            // Temp
            // 
            this.Temp.AutoSize = true;
            this.Temp.Location = new System.Drawing.Point(60, 89);
            this.Temp.Name = "Temp";
            this.Temp.Size = new System.Drawing.Size(170, 20);
            this.Temp.TabIndex = 1;
            this.Temp.Text = "Температура(max, min)";
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Location = new System.Drawing.Point(60, 136);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(124, 20);
            this.Time.TabIndex = 2;
            this.Time.Text = "Время(max, min)";
            // 
            // Temp_Rid
            // 
            this.Temp_Rid.AutoSize = true;
            this.Temp_Rid.Location = new System.Drawing.Point(60, 213);
            this.Temp_Rid.Name = "Temp_Rid";
            this.Temp_Rid.Size = new System.Drawing.Size(150, 20);
            this.Temp_Rid.TabIndex = 3;
            this.Temp_Rid.Text = "Температурный ряд";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Location = new System.Drawing.Point(60, 179);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(41, 20);
            this.Date.TabIndex = 4;
            this.Date.Text = "Дата";
            // 
            // CreateOtchet
            // 
            this.CreateOtchet.Location = new System.Drawing.Point(60, 259);
            this.CreateOtchet.Name = "CreateOtchet";
            this.CreateOtchet.Size = new System.Drawing.Size(150, 29);
            this.CreateOtchet.TabIndex = 5;
            this.CreateOtchet.Text = "Создать отчет";
            this.CreateOtchet.UseVisualStyleBackColor = true;
            this.CreateOtchet.Click += new System.EventHandler(this.CreateOtchet_Click);
            // 
            // cbVidFish
            // 
            this.cbVidFish.FormattingEnabled = true;
            this.cbVidFish.Items.AddRange(new object[] {
            "Семга",
            "Замороженный минтай"});
            this.cbVidFish.Location = new System.Drawing.Point(372, 34);
            this.cbVidFish.Name = "cbVidFish";
            this.cbVidFish.Size = new System.Drawing.Size(261, 28);
            this.cbVidFish.TabIndex = 6;
            this.cbVidFish.SelectedIndexChanged += new System.EventHandler(this.cbVidFish_SelectedIndexChanged);
            // 
            // TempForMax
            // 
            this.TempForMax.Location = new System.Drawing.Point(372, 89);
            this.TempForMax.Name = "TempForMax";
            this.TempForMax.ReadOnly = true;
            this.TempForMax.Size = new System.Drawing.Size(125, 27);
            this.TempForMax.TabIndex = 7;
            // 
            // TempForMin
            // 
            this.TempForMin.Location = new System.Drawing.Point(586, 89);
            this.TempForMin.Name = "TempForMin";
            this.TempForMin.ReadOnly = true;
            this.TempForMin.Size = new System.Drawing.Size(125, 27);
            this.TempForMin.TabIndex = 8;
            // 
            // TimeForMax
            // 
            this.TimeForMax.Location = new System.Drawing.Point(372, 133);
            this.TimeForMax.Name = "TimeForMax";
            this.TimeForMax.ReadOnly = true;
            this.TimeForMax.Size = new System.Drawing.Size(125, 27);
            this.TimeForMax.TabIndex = 9;
            // 
            // TimeForMin
            // 
            this.TimeForMin.Location = new System.Drawing.Point(586, 136);
            this.TimeForMin.Name = "TimeForMin";
            this.TimeForMin.ReadOnly = true;
            this.TimeForMin.Size = new System.Drawing.Size(125, 27);
            this.TimeForMin.TabIndex = 10;
            // 
            // TempRid
            // 
            this.TempRid.Location = new System.Drawing.Point(372, 210);
            this.TempRid.Name = "TempRid";
            this.TempRid.Size = new System.Drawing.Size(581, 27);
            this.TempRid.TabIndex = 12;
            // 
            // dgvGrafik
            // 
            this.dgvGrafik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrafik.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvGrafik.Location = new System.Drawing.Point(60, 303);
            this.dgvGrafik.Name = "dgvGrafik";
            this.dgvGrafik.RowHeadersWidth = 51;
            this.dgvGrafik.RowTemplate.Height = 29;
            this.dgvGrafik.Size = new System.Drawing.Size(893, 243);
            this.dgvGrafik.TabIndex = 13;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Время";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 210;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Факт";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 210;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Норма";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 210;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Отклонение от нормы";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 210;
            // 
            // mtbDate
            // 
            this.mtbDate.Location = new System.Drawing.Point(372, 176);
            this.mtbDate.Mask = "00/00/0000 90:00";
            this.mtbDate.Name = "mtbDate";
            this.mtbDate.Size = new System.Drawing.Size(125, 27);
            this.mtbDate.TabIndex = 14;
            this.mtbDate.ValidatingType = typeof(System.DateTime);
            // 
            // textOtchet
            // 
            this.textOtchet.Location = new System.Drawing.Point(372, 259);
            this.textOtchet.Name = "textOtchet";
            this.textOtchet.ReadOnly = true;
            this.textOtchet.Size = new System.Drawing.Size(581, 27);
            this.textOtchet.TabIndex = 15;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1060, 28);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // Temp_Monitoring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 558);
            this.Controls.Add(this.textOtchet);
            this.Controls.Add(this.mtbDate);
            this.Controls.Add(this.dgvGrafik);
            this.Controls.Add(this.TempRid);
            this.Controls.Add(this.TimeForMin);
            this.Controls.Add(this.TimeForMax);
            this.Controls.Add(this.TempForMin);
            this.Controls.Add(this.TempForMax);
            this.Controls.Add(this.cbVidFish);
            this.Controls.Add(this.CreateOtchet);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.Temp_Rid);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.Temp);
            this.Controls.Add(this.VidFish);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Temp_Monitoring";
            this.Text = "Temp_Monitoring";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrafik)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label VidFish;
        private System.Windows.Forms.Label Temp;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label Temp_Rid;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Button CreateOtchet;
        private System.Windows.Forms.ComboBox cbVidFish;
        private System.Windows.Forms.TextBox TempForMax;
        private System.Windows.Forms.TextBox TempForMin;
        private System.Windows.Forms.TextBox TimeForMax;
        private System.Windows.Forms.TextBox TimeForMin;
        private System.Windows.Forms.TextBox TempRid;
        private System.Windows.Forms.DataGridView dgvGrafik;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.MaskedTextBox mtbDate;
        private System.Windows.Forms.TextBox textOtchet;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
    }
}

