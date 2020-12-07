namespace BT2YM
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConvert = new System.Windows.Forms.Button();
            this.lblFrom = new System.Windows.Forms.Label();
            this.clbxFrom = new System.Windows.Forms.CheckedListBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkLightCoral = new System.Windows.Forms.CheckBox();
            this.OrangeRed = new System.Windows.Forms.CheckBox();
            this.Gray = new System.Windows.Forms.CheckBox();
            this.Aquamarine = new System.Windows.Forms.CheckBox();
            this.Blue = new System.Windows.Forms.CheckBox();
            this.Navy = new System.Windows.Forms.CheckBox();
            this.LightSalmon = new System.Windows.Forms.CheckBox();
            this.Gold = new System.Windows.Forms.CheckBox();
            this.DarkGreen = new System.Windows.Forms.CheckBox();
            this.DimGray = new System.Windows.Forms.CheckBox();
            this.CadetBlue = new System.Windows.Forms.CheckBox();
            this.Magenta = new System.Windows.Forms.CheckBox();
            this.Chocolate = new System.Windows.Forms.CheckBox();
            this.Orange = new System.Windows.Forms.CheckBox();
            this.YellowGreen = new System.Windows.Forms.CheckBox();
            this.SpringGreen = new System.Windows.Forms.CheckBox();
            this.Teal = new System.Windows.Forms.CheckBox();
            this.Purple = new System.Windows.Forms.CheckBox();
            this.Firebrick = new System.Windows.Forms.CheckBox();
            this.Khaki = new System.Windows.Forms.CheckBox();
            this.Yellow = new System.Windows.Forms.CheckBox();
            this.Olive = new System.Windows.Forms.CheckBox();
            this.DeepSkyBlue = new System.Windows.Forms.CheckBox();
            this.Indigo = new System.Windows.Forms.CheckBox();
            this.Red = new System.Windows.Forms.CheckBox();
            this.DarkRed = new System.Windows.Forms.CheckBox();
            this.Pink = new System.Windows.Forms.CheckBox();
            this.SteelBlue = new System.Windows.Forms.CheckBox();
            this.Cyan = new System.Windows.Forms.CheckBox();
            this.Lime = new System.Windows.Forms.CheckBox();
            this.btnSelectDir = new System.Windows.Forms.Button();
            this.fbdFrom = new System.Windows.Forms.FolderBrowserDialog();
            this.lblTransparency = new System.Windows.Forms.Label();
            this.lblTransPercent = new System.Windows.Forms.Label();
            this.btnTransMinus = new System.Windows.Forms.Button();
            this.btnTransPlus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConvert
            // 
            this.btnConvert.BackColor = System.Drawing.Color.MistyRose;
            this.btnConvert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConvert.Font = new System.Drawing.Font("PT Sans Caption", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnConvert.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnConvert.Location = new System.Drawing.Point(626, 243);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(104, 44);
            this.btnConvert.TabIndex = 0;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("PT Sans Caption", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFrom.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblFrom.Location = new System.Drawing.Point(8, 17);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(58, 24);
            this.lblFrom.TabIndex = 1;
            this.lblFrom.Text = "From";
            // 
            // clbxFrom
            // 
            this.clbxFrom.BackColor = System.Drawing.Color.SeaShell;
            this.clbxFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clbxFrom.FormattingEnabled = true;
            this.clbxFrom.Location = new System.Drawing.Point(12, 44);
            this.clbxFrom.Name = "clbxFrom";
            this.clbxFrom.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.clbxFrom.Size = new System.Drawing.Size(444, 130);
            this.clbxFrom.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("PT Sans Caption", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblName.Location = new System.Drawing.Point(8, 177);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(64, 24);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("PT Sans Caption", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDescription.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblDescription.Location = new System.Drawing.Point(8, 234);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(117, 24);
            this.lblDescription.TabIndex = 7;
            this.lblDescription.Text = "Description";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.SeaShell;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtName.Location = new System.Drawing.Point(12, 206);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(444, 26);
            this.txtName.TabIndex = 8;
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.SeaShell;
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDescription.Location = new System.Drawing.Point(12, 261);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(444, 26);
            this.txtDescription.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PT Sans Caption", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(568, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Colors";
            // 
            // chkLightCoral
            // 
            this.chkLightCoral.BackColor = System.Drawing.Color.LightCoral;
            this.chkLightCoral.CheckAlign = System.Drawing.ContentAlignment.BottomRight;
            this.chkLightCoral.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.chkLightCoral.FlatAppearance.BorderSize = 2;
            this.chkLightCoral.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkLightCoral.ForeColor = System.Drawing.SystemColors.WindowText;
            this.chkLightCoral.Location = new System.Drawing.Point(470, 44);
            this.chkLightCoral.Margin = new System.Windows.Forms.Padding(0);
            this.chkLightCoral.Name = "chkLightCoral";
            this.chkLightCoral.Size = new System.Drawing.Size(52, 26);
            this.chkLightCoral.TabIndex = 11;
            this.chkLightCoral.UseVisualStyleBackColor = false;
            // 
            // OrangeRed
            // 
            this.OrangeRed.BackColor = System.Drawing.Color.OrangeRed;
            this.OrangeRed.CheckAlign = System.Drawing.ContentAlignment.BottomRight;
            this.OrangeRed.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.OrangeRed.FlatAppearance.BorderSize = 2;
            this.OrangeRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrangeRed.ForeColor = System.Drawing.SystemColors.WindowText;
            this.OrangeRed.Location = new System.Drawing.Point(522, 44);
            this.OrangeRed.Margin = new System.Windows.Forms.Padding(0);
            this.OrangeRed.Name = "OrangeRed";
            this.OrangeRed.Size = new System.Drawing.Size(52, 26);
            this.OrangeRed.TabIndex = 12;
            this.OrangeRed.UseVisualStyleBackColor = false;
            // 
            // Gray
            // 
            this.Gray.BackColor = System.Drawing.Color.Gray;
            this.Gray.CheckAlign = System.Drawing.ContentAlignment.BottomRight;
            this.Gray.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Gray.FlatAppearance.BorderSize = 2;
            this.Gray.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Gray.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Gray.Location = new System.Drawing.Point(574, 44);
            this.Gray.Margin = new System.Windows.Forms.Padding(0);
            this.Gray.Name = "Gray";
            this.Gray.Size = new System.Drawing.Size(52, 26);
            this.Gray.TabIndex = 13;
            this.Gray.UseVisualStyleBackColor = false;
            // 
            // Aquamarine
            // 
            this.Aquamarine.BackColor = System.Drawing.Color.Aquamarine;
            this.Aquamarine.CheckAlign = System.Drawing.ContentAlignment.BottomRight;
            this.Aquamarine.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Aquamarine.FlatAppearance.BorderSize = 2;
            this.Aquamarine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Aquamarine.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Aquamarine.Location = new System.Drawing.Point(626, 44);
            this.Aquamarine.Margin = new System.Windows.Forms.Padding(0);
            this.Aquamarine.Name = "Aquamarine";
            this.Aquamarine.Size = new System.Drawing.Size(52, 26);
            this.Aquamarine.TabIndex = 14;
            this.Aquamarine.UseVisualStyleBackColor = false;
            // 
            // Blue
            // 
            this.Blue.BackColor = System.Drawing.Color.Blue;
            this.Blue.CheckAlign = System.Drawing.ContentAlignment.BottomRight;
            this.Blue.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Blue.FlatAppearance.BorderSize = 2;
            this.Blue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Blue.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Blue.Location = new System.Drawing.Point(678, 44);
            this.Blue.Margin = new System.Windows.Forms.Padding(0);
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(52, 26);
            this.Blue.TabIndex = 15;
            this.Blue.UseVisualStyleBackColor = false;
            // 
            // Navy
            // 
            this.Navy.BackColor = System.Drawing.Color.Navy;
            this.Navy.CheckAlign = System.Drawing.ContentAlignment.BottomRight;
            this.Navy.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Navy.FlatAppearance.BorderSize = 2;
            this.Navy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Navy.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Navy.Location = new System.Drawing.Point(470, 70);
            this.Navy.Margin = new System.Windows.Forms.Padding(0);
            this.Navy.Name = "Navy";
            this.Navy.Size = new System.Drawing.Size(52, 26);
            this.Navy.TabIndex = 16;
            this.Navy.UseVisualStyleBackColor = false;
            // 
            // LightSalmon
            // 
            this.LightSalmon.BackColor = System.Drawing.Color.LightSalmon;
            this.LightSalmon.CheckAlign = System.Drawing.ContentAlignment.BottomRight;
            this.LightSalmon.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.LightSalmon.FlatAppearance.BorderSize = 2;
            this.LightSalmon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LightSalmon.ForeColor = System.Drawing.SystemColors.WindowText;
            this.LightSalmon.Location = new System.Drawing.Point(522, 70);
            this.LightSalmon.Margin = new System.Windows.Forms.Padding(0);
            this.LightSalmon.Name = "LightSalmon";
            this.LightSalmon.Size = new System.Drawing.Size(52, 26);
            this.LightSalmon.TabIndex = 17;
            this.LightSalmon.UseVisualStyleBackColor = false;
            // 
            // Gold
            // 
            this.Gold.BackColor = System.Drawing.Color.Gold;
            this.Gold.CheckAlign = System.Drawing.ContentAlignment.BottomRight;
            this.Gold.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Gold.FlatAppearance.BorderSize = 2;
            this.Gold.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Gold.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Gold.Location = new System.Drawing.Point(574, 70);
            this.Gold.Margin = new System.Windows.Forms.Padding(0);
            this.Gold.Name = "Gold";
            this.Gold.Size = new System.Drawing.Size(52, 26);
            this.Gold.TabIndex = 18;
            this.Gold.UseVisualStyleBackColor = false;
            // 
            // DarkGreen
            // 
            this.DarkGreen.BackColor = System.Drawing.Color.DarkGreen;
            this.DarkGreen.CheckAlign = System.Drawing.ContentAlignment.BottomRight;
            this.DarkGreen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DarkGreen.FlatAppearance.BorderSize = 2;
            this.DarkGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DarkGreen.ForeColor = System.Drawing.SystemColors.WindowText;
            this.DarkGreen.Location = new System.Drawing.Point(626, 70);
            this.DarkGreen.Margin = new System.Windows.Forms.Padding(0);
            this.DarkGreen.Name = "DarkGreen";
            this.DarkGreen.Size = new System.Drawing.Size(52, 26);
            this.DarkGreen.TabIndex = 19;
            this.DarkGreen.UseVisualStyleBackColor = false;
            // 
            // DimGray
            // 
            this.DimGray.BackColor = System.Drawing.Color.DimGray;
            this.DimGray.CheckAlign = System.Drawing.ContentAlignment.BottomRight;
            this.DimGray.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DimGray.FlatAppearance.BorderSize = 2;
            this.DimGray.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DimGray.ForeColor = System.Drawing.SystemColors.WindowText;
            this.DimGray.Location = new System.Drawing.Point(678, 70);
            this.DimGray.Margin = new System.Windows.Forms.Padding(0);
            this.DimGray.Name = "DimGray";
            this.DimGray.Size = new System.Drawing.Size(52, 26);
            this.DimGray.TabIndex = 20;
            this.DimGray.UseVisualStyleBackColor = false;
            // 
            // CadetBlue
            // 
            this.CadetBlue.BackColor = System.Drawing.Color.CadetBlue;
            this.CadetBlue.CheckAlign = System.Drawing.ContentAlignment.BottomRight;
            this.CadetBlue.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.CadetBlue.FlatAppearance.BorderSize = 2;
            this.CadetBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CadetBlue.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CadetBlue.Location = new System.Drawing.Point(470, 96);
            this.CadetBlue.Margin = new System.Windows.Forms.Padding(0);
            this.CadetBlue.Name = "CadetBlue";
            this.CadetBlue.Size = new System.Drawing.Size(52, 26);
            this.CadetBlue.TabIndex = 21;
            this.CadetBlue.UseVisualStyleBackColor = false;
            // 
            // Magenta
            // 
            this.Magenta.BackColor = System.Drawing.Color.Magenta;
            this.Magenta.CheckAlign = System.Drawing.ContentAlignment.BottomRight;
            this.Magenta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Magenta.FlatAppearance.BorderSize = 2;
            this.Magenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Magenta.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Magenta.Location = new System.Drawing.Point(522, 96);
            this.Magenta.Margin = new System.Windows.Forms.Padding(0);
            this.Magenta.Name = "Magenta";
            this.Magenta.Size = new System.Drawing.Size(52, 26);
            this.Magenta.TabIndex = 22;
            this.Magenta.UseVisualStyleBackColor = false;
            // 
            // Chocolate
            // 
            this.Chocolate.BackColor = System.Drawing.Color.Chocolate;
            this.Chocolate.CheckAlign = System.Drawing.ContentAlignment.BottomRight;
            this.Chocolate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Chocolate.FlatAppearance.BorderSize = 2;
            this.Chocolate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Chocolate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Chocolate.Location = new System.Drawing.Point(574, 96);
            this.Chocolate.Margin = new System.Windows.Forms.Padding(0);
            this.Chocolate.Name = "Chocolate";
            this.Chocolate.Size = new System.Drawing.Size(52, 26);
            this.Chocolate.TabIndex = 23;
            this.Chocolate.UseVisualStyleBackColor = false;
            // 
            // Orange
            // 
            this.Orange.BackColor = System.Drawing.Color.Orange;
            this.Orange.CheckAlign = System.Drawing.ContentAlignment.BottomRight;
            this.Orange.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Orange.FlatAppearance.BorderSize = 2;
            this.Orange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Orange.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Orange.Location = new System.Drawing.Point(626, 96);
            this.Orange.Margin = new System.Windows.Forms.Padding(0);
            this.Orange.Name = "Orange";
            this.Orange.Size = new System.Drawing.Size(52, 26);
            this.Orange.TabIndex = 24;
            this.Orange.UseVisualStyleBackColor = false;
            // 
            // YellowGreen
            // 
            this.YellowGreen.BackColor = System.Drawing.Color.YellowGreen;
            this.YellowGreen.CheckAlign = System.Drawing.ContentAlignment.BottomRight;
            this.YellowGreen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.YellowGreen.FlatAppearance.BorderSize = 2;
            this.YellowGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YellowGreen.ForeColor = System.Drawing.SystemColors.WindowText;
            this.YellowGreen.Location = new System.Drawing.Point(678, 96);
            this.YellowGreen.Margin = new System.Windows.Forms.Padding(0);
            this.YellowGreen.Name = "YellowGreen";
            this.YellowGreen.Size = new System.Drawing.Size(52, 26);
            this.YellowGreen.TabIndex = 25;
            this.YellowGreen.UseVisualStyleBackColor = false;
            // 
            // SpringGreen
            // 
            this.SpringGreen.BackColor = System.Drawing.Color.SpringGreen;
            this.SpringGreen.CheckAlign = System.Drawing.ContentAlignment.BottomRight;
            this.SpringGreen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.SpringGreen.FlatAppearance.BorderSize = 2;
            this.SpringGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SpringGreen.ForeColor = System.Drawing.SystemColors.WindowText;
            this.SpringGreen.Location = new System.Drawing.Point(470, 122);
            this.SpringGreen.Margin = new System.Windows.Forms.Padding(0);
            this.SpringGreen.Name = "SpringGreen";
            this.SpringGreen.Size = new System.Drawing.Size(52, 26);
            this.SpringGreen.TabIndex = 26;
            this.SpringGreen.UseVisualStyleBackColor = false;
            // 
            // Teal
            // 
            this.Teal.BackColor = System.Drawing.Color.Teal;
            this.Teal.CheckAlign = System.Drawing.ContentAlignment.BottomRight;
            this.Teal.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Teal.FlatAppearance.BorderSize = 2;
            this.Teal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Teal.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Teal.Location = new System.Drawing.Point(522, 122);
            this.Teal.Margin = new System.Windows.Forms.Padding(0);
            this.Teal.Name = "Teal";
            this.Teal.Size = new System.Drawing.Size(52, 26);
            this.Teal.TabIndex = 27;
            this.Teal.UseVisualStyleBackColor = false;
            // 
            // Purple
            // 
            this.Purple.BackColor = System.Drawing.Color.Purple;
            this.Purple.CheckAlign = System.Drawing.ContentAlignment.BottomRight;
            this.Purple.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Purple.FlatAppearance.BorderSize = 2;
            this.Purple.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Purple.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Purple.Location = new System.Drawing.Point(574, 122);
            this.Purple.Margin = new System.Windows.Forms.Padding(0);
            this.Purple.Name = "Purple";
            this.Purple.Size = new System.Drawing.Size(52, 26);
            this.Purple.TabIndex = 28;
            this.Purple.UseVisualStyleBackColor = false;
            // 
            // Firebrick
            // 
            this.Firebrick.BackColor = System.Drawing.Color.Firebrick;
            this.Firebrick.CheckAlign = System.Drawing.ContentAlignment.BottomRight;
            this.Firebrick.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Firebrick.FlatAppearance.BorderSize = 2;
            this.Firebrick.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Firebrick.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Firebrick.Location = new System.Drawing.Point(626, 122);
            this.Firebrick.Margin = new System.Windows.Forms.Padding(0);
            this.Firebrick.Name = "Firebrick";
            this.Firebrick.Size = new System.Drawing.Size(52, 26);
            this.Firebrick.TabIndex = 29;
            this.Firebrick.UseVisualStyleBackColor = false;
            // 
            // Khaki
            // 
            this.Khaki.BackColor = System.Drawing.Color.Khaki;
            this.Khaki.CheckAlign = System.Drawing.ContentAlignment.BottomRight;
            this.Khaki.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Khaki.FlatAppearance.BorderSize = 2;
            this.Khaki.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Khaki.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Khaki.Location = new System.Drawing.Point(678, 122);
            this.Khaki.Margin = new System.Windows.Forms.Padding(0);
            this.Khaki.Name = "Khaki";
            this.Khaki.Size = new System.Drawing.Size(52, 26);
            this.Khaki.TabIndex = 30;
            this.Khaki.UseVisualStyleBackColor = false;
            // 
            // Yellow
            // 
            this.Yellow.BackColor = System.Drawing.Color.Yellow;
            this.Yellow.CheckAlign = System.Drawing.ContentAlignment.BottomRight;
            this.Yellow.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Yellow.FlatAppearance.BorderSize = 2;
            this.Yellow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Yellow.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Yellow.Location = new System.Drawing.Point(470, 148);
            this.Yellow.Margin = new System.Windows.Forms.Padding(0);
            this.Yellow.Name = "Yellow";
            this.Yellow.Size = new System.Drawing.Size(52, 26);
            this.Yellow.TabIndex = 31;
            this.Yellow.UseVisualStyleBackColor = false;
            // 
            // Olive
            // 
            this.Olive.BackColor = System.Drawing.Color.Olive;
            this.Olive.CheckAlign = System.Drawing.ContentAlignment.BottomRight;
            this.Olive.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Olive.FlatAppearance.BorderSize = 2;
            this.Olive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Olive.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Olive.Location = new System.Drawing.Point(522, 148);
            this.Olive.Margin = new System.Windows.Forms.Padding(0);
            this.Olive.Name = "Olive";
            this.Olive.Size = new System.Drawing.Size(52, 26);
            this.Olive.TabIndex = 32;
            this.Olive.UseVisualStyleBackColor = false;
            // 
            // DeepSkyBlue
            // 
            this.DeepSkyBlue.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.DeepSkyBlue.CheckAlign = System.Drawing.ContentAlignment.BottomRight;
            this.DeepSkyBlue.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DeepSkyBlue.FlatAppearance.BorderSize = 2;
            this.DeepSkyBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeepSkyBlue.ForeColor = System.Drawing.SystemColors.WindowText;
            this.DeepSkyBlue.Location = new System.Drawing.Point(574, 148);
            this.DeepSkyBlue.Margin = new System.Windows.Forms.Padding(0);
            this.DeepSkyBlue.Name = "DeepSkyBlue";
            this.DeepSkyBlue.Size = new System.Drawing.Size(52, 26);
            this.DeepSkyBlue.TabIndex = 33;
            this.DeepSkyBlue.UseVisualStyleBackColor = false;
            // 
            // Indigo
            // 
            this.Indigo.BackColor = System.Drawing.Color.Indigo;
            this.Indigo.CheckAlign = System.Drawing.ContentAlignment.BottomRight;
            this.Indigo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Indigo.FlatAppearance.BorderSize = 2;
            this.Indigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Indigo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Indigo.Location = new System.Drawing.Point(626, 148);
            this.Indigo.Margin = new System.Windows.Forms.Padding(0);
            this.Indigo.Name = "Indigo";
            this.Indigo.Size = new System.Drawing.Size(52, 26);
            this.Indigo.TabIndex = 34;
            this.Indigo.UseVisualStyleBackColor = false;
            // 
            // Red
            // 
            this.Red.BackColor = System.Drawing.Color.Red;
            this.Red.CheckAlign = System.Drawing.ContentAlignment.BottomRight;
            this.Red.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Red.FlatAppearance.BorderSize = 2;
            this.Red.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Red.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Red.Location = new System.Drawing.Point(678, 148);
            this.Red.Margin = new System.Windows.Forms.Padding(0);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(52, 26);
            this.Red.TabIndex = 35;
            this.Red.UseVisualStyleBackColor = false;
            // 
            // DarkRed
            // 
            this.DarkRed.BackColor = System.Drawing.Color.DarkRed;
            this.DarkRed.CheckAlign = System.Drawing.ContentAlignment.BottomRight;
            this.DarkRed.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DarkRed.FlatAppearance.BorderSize = 2;
            this.DarkRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DarkRed.ForeColor = System.Drawing.SystemColors.WindowText;
            this.DarkRed.Location = new System.Drawing.Point(470, 174);
            this.DarkRed.Margin = new System.Windows.Forms.Padding(0);
            this.DarkRed.Name = "DarkRed";
            this.DarkRed.Size = new System.Drawing.Size(52, 26);
            this.DarkRed.TabIndex = 36;
            this.DarkRed.UseVisualStyleBackColor = false;
            // 
            // Pink
            // 
            this.Pink.BackColor = System.Drawing.Color.Pink;
            this.Pink.CheckAlign = System.Drawing.ContentAlignment.BottomRight;
            this.Pink.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Pink.FlatAppearance.BorderSize = 2;
            this.Pink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Pink.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Pink.Location = new System.Drawing.Point(678, 174);
            this.Pink.Margin = new System.Windows.Forms.Padding(0);
            this.Pink.Name = "Pink";
            this.Pink.Size = new System.Drawing.Size(52, 26);
            this.Pink.TabIndex = 37;
            this.Pink.UseVisualStyleBackColor = false;
            // 
            // SteelBlue
            // 
            this.SteelBlue.BackColor = System.Drawing.Color.SteelBlue;
            this.SteelBlue.CheckAlign = System.Drawing.ContentAlignment.BottomRight;
            this.SteelBlue.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.SteelBlue.FlatAppearance.BorderSize = 2;
            this.SteelBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SteelBlue.ForeColor = System.Drawing.SystemColors.WindowText;
            this.SteelBlue.Location = new System.Drawing.Point(626, 174);
            this.SteelBlue.Margin = new System.Windows.Forms.Padding(0);
            this.SteelBlue.Name = "SteelBlue";
            this.SteelBlue.Size = new System.Drawing.Size(52, 26);
            this.SteelBlue.TabIndex = 38;
            this.SteelBlue.UseVisualStyleBackColor = false;
            // 
            // Cyan
            // 
            this.Cyan.BackColor = System.Drawing.Color.Cyan;
            this.Cyan.CheckAlign = System.Drawing.ContentAlignment.BottomRight;
            this.Cyan.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Cyan.FlatAppearance.BorderSize = 2;
            this.Cyan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cyan.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Cyan.Location = new System.Drawing.Point(574, 174);
            this.Cyan.Margin = new System.Windows.Forms.Padding(0);
            this.Cyan.Name = "Cyan";
            this.Cyan.Size = new System.Drawing.Size(52, 26);
            this.Cyan.TabIndex = 39;
            this.Cyan.UseVisualStyleBackColor = false;
            // 
            // Lime
            // 
            this.Lime.BackColor = System.Drawing.Color.Lime;
            this.Lime.CheckAlign = System.Drawing.ContentAlignment.BottomRight;
            this.Lime.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Lime.FlatAppearance.BorderSize = 2;
            this.Lime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lime.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Lime.Location = new System.Drawing.Point(522, 174);
            this.Lime.Margin = new System.Windows.Forms.Padding(0);
            this.Lime.Name = "Lime";
            this.Lime.Size = new System.Drawing.Size(52, 26);
            this.Lime.TabIndex = 40;
            this.Lime.UseVisualStyleBackColor = false;
            // 
            // btnSelectDir
            // 
            this.btnSelectDir.BackColor = System.Drawing.Color.MistyRose;
            this.btnSelectDir.Location = new System.Drawing.Point(72, 17);
            this.btnSelectDir.Name = "btnSelectDir";
            this.btnSelectDir.Size = new System.Drawing.Size(26, 21);
            this.btnSelectDir.TabIndex = 41;
            this.btnSelectDir.Text = "...";
            this.btnSelectDir.UseVisualStyleBackColor = false;
            this.btnSelectDir.Click += new System.EventHandler(this.btnSelectDir_Click);
            // 
            // fbdFrom
            // 
            this.fbdFrom.Description = "Select directory with files GPX";
            // 
            // lblTransparency
            // 
            this.lblTransparency.AutoSize = true;
            this.lblTransparency.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTransparency.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTransparency.Location = new System.Drawing.Point(482, 209);
            this.lblTransparency.Name = "lblTransparency";
            this.lblTransparency.Size = new System.Drawing.Size(117, 20);
            this.lblTransparency.TabIndex = 42;
            this.lblTransparency.Text = "Transparency";
            // 
            // lblTransPercent
            // 
            this.lblTransPercent.AutoSize = true;
            this.lblTransPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTransPercent.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTransPercent.Location = new System.Drawing.Point(520, 239);
            this.lblTransPercent.Name = "lblTransPercent";
            this.lblTransPercent.Size = new System.Drawing.Size(44, 20);
            this.lblTransPercent.TabIndex = 43;
            this.lblTransPercent.Text = "50%";
            // 
            // btnTransMinus
            // 
            this.btnTransMinus.BackColor = System.Drawing.Color.MistyRose;
            this.btnTransMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTransMinus.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnTransMinus.Location = new System.Drawing.Point(488, 233);
            this.btnTransMinus.Name = "btnTransMinus";
            this.btnTransMinus.Size = new System.Drawing.Size(26, 25);
            this.btnTransMinus.TabIndex = 44;
            this.btnTransMinus.Text = "-";
            this.btnTransMinus.UseVisualStyleBackColor = false;
            this.btnTransMinus.Click += new System.EventHandler(this.btnTransMinus_Click);
            // 
            // btnTransPlus
            // 
            this.btnTransPlus.BackColor = System.Drawing.Color.MistyRose;
            this.btnTransPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTransPlus.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnTransPlus.Location = new System.Drawing.Point(567, 233);
            this.btnTransPlus.Name = "btnTransPlus";
            this.btnTransPlus.Size = new System.Drawing.Size(26, 25);
            this.btnTransPlus.TabIndex = 45;
            this.btnTransPlus.Text = "+";
            this.btnTransPlus.UseVisualStyleBackColor = false;
            this.btnTransPlus.Click += new System.EventHandler(this.btnTransPlus_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(744, 305);
            this.Controls.Add(this.btnTransPlus);
            this.Controls.Add(this.btnTransMinus);
            this.Controls.Add(this.lblTransPercent);
            this.Controls.Add(this.lblTransparency);
            this.Controls.Add(this.btnSelectDir);
            this.Controls.Add(this.Lime);
            this.Controls.Add(this.Cyan);
            this.Controls.Add(this.SteelBlue);
            this.Controls.Add(this.Pink);
            this.Controls.Add(this.DarkRed);
            this.Controls.Add(this.Red);
            this.Controls.Add(this.Indigo);
            this.Controls.Add(this.DeepSkyBlue);
            this.Controls.Add(this.Olive);
            this.Controls.Add(this.Yellow);
            this.Controls.Add(this.Khaki);
            this.Controls.Add(this.Firebrick);
            this.Controls.Add(this.Purple);
            this.Controls.Add(this.Teal);
            this.Controls.Add(this.SpringGreen);
            this.Controls.Add(this.YellowGreen);
            this.Controls.Add(this.Orange);
            this.Controls.Add(this.Chocolate);
            this.Controls.Add(this.Magenta);
            this.Controls.Add(this.CadetBlue);
            this.Controls.Add(this.DimGray);
            this.Controls.Add(this.DarkGreen);
            this.Controls.Add(this.Gold);
            this.Controls.Add(this.LightSalmon);
            this.Controls.Add(this.Navy);
            this.Controls.Add(this.Blue);
            this.Controls.Add(this.Aquamarine);
            this.Controls.Add(this.Gray);
            this.Controls.Add(this.OrangeRed);
            this.Controls.Add(this.chkLightCoral);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.clbxFrom);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.btnConvert);
            this.Name = "MainForm";
            this.Text = "Convert GPX to KML (Yandex.Map)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.CheckedListBox clbxFrom;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkLightCoral;
        private System.Windows.Forms.CheckBox OrangeRed;
        private System.Windows.Forms.CheckBox Gray;
        private System.Windows.Forms.CheckBox Aquamarine;
        private System.Windows.Forms.CheckBox Blue;
        private System.Windows.Forms.CheckBox Navy;
        private System.Windows.Forms.CheckBox LightSalmon;
        private System.Windows.Forms.CheckBox Gold;
        private System.Windows.Forms.CheckBox DarkGreen;
        private System.Windows.Forms.CheckBox DimGray;
        private System.Windows.Forms.CheckBox CadetBlue;
        private System.Windows.Forms.CheckBox Magenta;
        private System.Windows.Forms.CheckBox Chocolate;
        private System.Windows.Forms.CheckBox Orange;
        private System.Windows.Forms.CheckBox YellowGreen;
        private System.Windows.Forms.CheckBox SpringGreen;
        private System.Windows.Forms.CheckBox Teal;
        private System.Windows.Forms.CheckBox Purple;
        private System.Windows.Forms.CheckBox Firebrick;
        private System.Windows.Forms.CheckBox Khaki;
        private System.Windows.Forms.CheckBox Yellow;
        private System.Windows.Forms.CheckBox Olive;
        private System.Windows.Forms.CheckBox DeepSkyBlue;
        private System.Windows.Forms.CheckBox Indigo;
        private System.Windows.Forms.CheckBox Red;
        private System.Windows.Forms.CheckBox DarkRed;
        private System.Windows.Forms.CheckBox Pink;
        private System.Windows.Forms.CheckBox SteelBlue;
        private System.Windows.Forms.CheckBox Cyan;
        private System.Windows.Forms.CheckBox Lime;
        private System.Windows.Forms.Button btnSelectDir;
        private System.Windows.Forms.FolderBrowserDialog fbdFrom;
        private System.Windows.Forms.Label lblTransparency;
        private System.Windows.Forms.Label lblTransPercent;
        private System.Windows.Forms.Button btnTransMinus;
        private System.Windows.Forms.Button btnTransPlus;
    }
}

