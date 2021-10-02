
namespace Anti_AFK
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.key1TextBox = new System.Windows.Forms.TextBox();
            this.key2TextBox = new System.Windows.Forms.TextBox();
            this.key3TextBox = new System.Windows.Forms.TextBox();
            this.intervalTextBox = new System.Windows.Forms.TextBox();
            this.randomIntervalTextBox = new System.Windows.Forms.TextBox();
            this.processNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.key4TextBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(123, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Başlat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(212, 88);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Durdur";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // key1TextBox
            // 
            this.key1TextBox.Location = new System.Drawing.Point(54, 12);
            this.key1TextBox.Name = "key1TextBox";
            this.key1TextBox.Size = new System.Drawing.Size(42, 20);
            this.key1TextBox.TabIndex = 2;
            this.key1TextBox.Text = "17";
            // 
            // key2TextBox
            // 
            this.key2TextBox.Location = new System.Drawing.Point(54, 38);
            this.key2TextBox.Name = "key2TextBox";
            this.key2TextBox.Size = new System.Drawing.Size(42, 20);
            this.key2TextBox.TabIndex = 3;
            this.key2TextBox.Text = "31";
            // 
            // key3TextBox
            // 
            this.key3TextBox.Location = new System.Drawing.Point(54, 64);
            this.key3TextBox.Name = "key3TextBox";
            this.key3TextBox.Size = new System.Drawing.Size(42, 20);
            this.key3TextBox.TabIndex = 4;
            this.key3TextBox.Text = "30";
            // 
            // intervalTextBox
            // 
            this.intervalTextBox.Location = new System.Drawing.Point(232, 12);
            this.intervalTextBox.Name = "intervalTextBox";
            this.intervalTextBox.Size = new System.Drawing.Size(71, 20);
            this.intervalTextBox.TabIndex = 5;
            this.intervalTextBox.Text = "60";
            // 
            // randomIntervalTextBox
            // 
            this.randomIntervalTextBox.Location = new System.Drawing.Point(232, 35);
            this.randomIntervalTextBox.Name = "randomIntervalTextBox";
            this.randomIntervalTextBox.Size = new System.Drawing.Size(71, 20);
            this.randomIntervalTextBox.TabIndex = 6;
            this.randomIntervalTextBox.Text = "20";
            // 
            // processNameTextBox
            // 
            this.processNameTextBox.Location = new System.Drawing.Point(188, 61);
            this.processNameTextBox.Name = "processNameTextBox";
            this.processNameTextBox.Size = new System.Drawing.Size(115, 20);
            this.processNameTextBox.TabIndex = 7;
            this.processNameTextBox.Text = "NewWorld.exe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tuş1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tuş2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tuş3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(120, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Bekleme Süresi(sn)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(120, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "+/- Random Süre(sn)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(120, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Process adı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Tuş4";
            // 
            // key4TextBox
            // 
            this.key4TextBox.Location = new System.Drawing.Point(54, 90);
            this.key4TextBox.Name = "key4TextBox";
            this.key4TextBox.Size = new System.Drawing.Size(42, 20);
            this.key4TextBox.TabIndex = 14;
            this.key4TextBox.Text = "32";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 127);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.key4TextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.processNameTextBox);
            this.Controls.Add(this.randomIntervalTextBox);
            this.Controls.Add(this.intervalTextBox);
            this.Controls.Add(this.key3TextBox);
            this.Controls.Add(this.key2TextBox);
            this.Controls.Add(this.key1TextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "TolgaSoft AntiAFK";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox key1TextBox;
        private System.Windows.Forms.TextBox key2TextBox;
        private System.Windows.Forms.TextBox key3TextBox;
        private System.Windows.Forms.TextBox intervalTextBox;
        private System.Windows.Forms.TextBox randomIntervalTextBox;
        private System.Windows.Forms.TextBox processNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox key4TextBox;
        private System.Windows.Forms.Timer timer1;
    }
}

