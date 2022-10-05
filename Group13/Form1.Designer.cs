
namespace Group13
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.cbCom = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbBauDrate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLamp3 = new System.Windows.Forms.Button();
            this.btnLamp1 = new System.Windows.Forms.Button();
            this.btnLamp2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.standardControl2 = new SymbolFactoryDotNet.StandardControl();
            this.standardControl1 = new SymbolFactoryDotNet.StandardControl();
            this.button7 = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btnLamp4 = new System.Windows.Forms.Button();
            this.btnArch = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.cbCom);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbBauDrate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(41, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 154);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnConnect
            // 
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConnect.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(284, 63);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(154, 37);
            this.btnConnect.TabIndex = 14;
            this.btnConnect.Text = "CONNECT";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // cbCom
            // 
            this.cbCom.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCom.FormattingEnabled = true;
            this.cbCom.Location = new System.Drawing.Point(142, 44);
            this.cbCom.Name = "cbCom";
            this.cbCom.Size = new System.Drawing.Size(123, 30);
            this.cbCom.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "BAUDRATE";
            // 
            // cbBauDrate
            // 
            this.cbBauDrate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBauDrate.FormattingEnabled = true;
            this.cbBauDrate.Location = new System.Drawing.Point(142, 90);
            this.cbBauDrate.Name = "cbBauDrate";
            this.cbBauDrate.Size = new System.Drawing.Size(123, 30);
            this.cbBauDrate.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "COM";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Group13.Properties.Resources.den2;
            this.pictureBox1.Location = new System.Drawing.Point(598, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(30, 54);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(103, 102);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(229, 54);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(103, 102);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(422, 54);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(103, 102);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Group13.Properties.Resources.cuacuon2;
            this.pictureBox5.Location = new System.Drawing.Point(29, 54);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(103, 102);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 6;
            this.pictureBox5.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLamp4);
            this.groupBox2.Controls.Add(this.btnLamp3);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.btnLamp1);
            this.groupBox2.Controls.Add(this.btnLamp2);
            this.groupBox2.Controls.Add(this.pictureBox3);
            this.groupBox2.Controls.Add(this.pictureBox4);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Location = new System.Drawing.Point(199, 225);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(727, 277);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnLamp3
            // 
            this.btnLamp3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLamp3.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamp3.Location = new System.Drawing.Point(422, 198);
            this.btnLamp3.Name = "btnLamp3";
            this.btnLamp3.Size = new System.Drawing.Size(103, 48);
            this.btnLamp3.TabIndex = 9;
            this.btnLamp3.Text = "ON";
            this.btnLamp3.UseVisualStyleBackColor = true;
            this.btnLamp3.Click += new System.EventHandler(this.btnLamp3_Click);
            // 
            // btnLamp1
            // 
            this.btnLamp1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLamp1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamp1.Location = new System.Drawing.Point(30, 198);
            this.btnLamp1.Name = "btnLamp1";
            this.btnLamp1.Size = new System.Drawing.Size(103, 48);
            this.btnLamp1.TabIndex = 7;
            this.btnLamp1.Text = "ON";
            this.btnLamp1.UseVisualStyleBackColor = true;
            this.btnLamp1.Click += new System.EventHandler(this.btnLamp1_Click);
            // 
            // btnLamp2
            // 
            this.btnLamp2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLamp2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamp2.Location = new System.Drawing.Point(229, 198);
            this.btnLamp2.Name = "btnLamp2";
            this.btnLamp2.Size = new System.Drawing.Size(103, 48);
            this.btnLamp2.TabIndex = 8;
            this.btnLamp2.Text = "ON";
            this.btnLamp2.UseVisualStyleBackColor = true;
            this.btnLamp2.Click += new System.EventHandler(this.btnLamp2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.standardControl2);
            this.groupBox3.Controls.Add(this.standardControl1);
            this.groupBox3.Controls.Add(this.button7);
            this.groupBox3.Controls.Add(this.btn);
            this.groupBox3.Location = new System.Drawing.Point(582, 42);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(231, 154);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // standardControl2
            // 
            this.standardControl2.AnalogIntValue1 = ((short)(0));
            this.standardControl2.AnalogValue1 = 0D;
            this.standardControl2.AnimationMode = SymbolFactoryNetEngine.AnimationModeOptions.DiscreteColorFill;
            this.standardControl2.BackColor = System.Drawing.Color.Transparent;
            this.standardControl2.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl2.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl2.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(64))))), "Band2"));
            this.standardControl2.BlinkColor = System.Drawing.Color.Red;
            this.standardControl2.Category = "1Btn.cat2";
            this.standardControl2.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl2.DebugData"));
            this.standardControl2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.standardControl2.Location = new System.Drawing.Point(153, 79);
            this.standardControl2.Name = "standardControl2";
            this.standardControl2.Size = new System.Drawing.Size(53, 69);
            this.standardControl2.SymbolHandle = ((long)(703557272));
            this.standardControl2.TabIndex = 14;
            // 
            // standardControl1
            // 
            this.standardControl1.AnalogIntValue1 = ((short)(0));
            this.standardControl1.AnalogValue1 = 0D;
            this.standardControl1.AnimationMode = SymbolFactoryNetEngine.AnimationModeOptions.DiscreteColorFill;
            this.standardControl1.BackColor = System.Drawing.Color.Transparent;
            this.standardControl1.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.standardControl1.BandsCollection.Add(new SymbolFactoryNetEngine.Band(90D, 90, false, SymbolFactoryNetEngine.BandStyleOptions.Original, System.Drawing.Color.Red, "Band1"));
            this.standardControl1.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(64))))), "Band2"));
            this.standardControl1.BlinkColor = System.Drawing.Color.Red;
            this.standardControl1.Category = "1Btn.cat2";
            this.standardControl1.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("standardControl1.DebugData"));
            this.standardControl1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.standardControl1.Location = new System.Drawing.Point(153, 10);
            this.standardControl1.Name = "standardControl1";
            this.standardControl1.Size = new System.Drawing.Size(53, 69);
            this.standardControl1.SymbolHandle = ((long)(703557272));
            this.standardControl1.TabIndex = 13;
            this.standardControl1.Load += new System.EventHandler(this.standardControl1_Load);
            // 
            // button7
            // 
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(6, 88);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(103, 48);
            this.button7.TabIndex = 12;
            this.button7.Text = "MAN";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // btn
            // 
            this.btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn.Location = new System.Drawing.Point(6, 21);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(103, 48);
            this.btn.TabIndex = 11;
            this.btn.Text = "AUTO";
            this.btn.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnArch);
            this.groupBox4.Controls.Add(this.pictureBox5);
            this.groupBox4.Location = new System.Drawing.Point(12, 225);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(167, 277);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // btnLamp4
            // 
            this.btnLamp4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLamp4.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamp4.Location = new System.Drawing.Point(598, 198);
            this.btnLamp4.Name = "btnLamp4";
            this.btnLamp4.Size = new System.Drawing.Size(103, 48);
            this.btnLamp4.TabIndex = 10;
            this.btnLamp4.Text = "ON";
            this.btnLamp4.UseVisualStyleBackColor = true;
            this.btnLamp4.Click += new System.EventHandler(this.btnLamp4_Click);
            // 
            // btnArch
            // 
            this.btnArch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnArch.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArch.Location = new System.Drawing.Point(29, 198);
            this.btnArch.Name = "btnArch";
            this.btnArch.Size = new System.Drawing.Size(103, 48);
            this.btnArch.TabIndex = 11;
            this.btnArch.Text = "ON";
            this.btnArch.UseVisualStyleBackColor = true;
            this.btnArch.Click += new System.EventHandler(this.btnArch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 522);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "OPEN";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.standardControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLamp3;
        private System.Windows.Forms.Button btnLamp1;
        private System.Windows.Forms.Button btnLamp2;
        private System.Windows.Forms.GroupBox groupBox3;
        private SymbolFactoryDotNet.StandardControl standardControl1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label label1;
        private SymbolFactoryDotNet.StandardControl standardControl2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cbBauDrate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCom;
        private System.Windows.Forms.Button btnConnect;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btnLamp4;
        private System.Windows.Forms.Button btnArch;
    }
}

