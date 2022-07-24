namespace login22._27._2022
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.btnGoLogin = new System.Windows.Forms.Button();
			this.btnSigin = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.txtBox_passLogin = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.txtBoxUserLogin = new System.Windows.Forms.TextBox();
			this.btn_Çizgi = new System.Windows.Forms.Button();
			this.btn_Çarpı = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnGoLogin
			// 
			this.btnGoLogin.FlatAppearance.BorderSize = 0;
			this.btnGoLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnGoLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.87629F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnGoLogin.Location = new System.Drawing.Point(63, 495);
			this.btnGoLogin.Margin = new System.Windows.Forms.Padding(4);
			this.btnGoLogin.Name = "btnGoLogin";
			this.btnGoLogin.Size = new System.Drawing.Size(353, 44);
			this.btnGoLogin.TabIndex = 60;
			this.btnGoLogin.Text = "don\'t you have an account yet?Sigin";
			this.btnGoLogin.UseVisualStyleBackColor = true;
			this.btnGoLogin.Click += new System.EventHandler(this.btn_GoSigin_Click);
			// 
			// btnSigin
			// 
			this.btnSigin.BackColor = System.Drawing.Color.White;
			this.btnSigin.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.btnSigin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSigin.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.81443F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnSigin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnSigin.Location = new System.Drawing.Point(219, 316);
			this.btnSigin.Margin = new System.Windows.Forms.Padding(4);
			this.btnSigin.Name = "btnSigin";
			this.btnSigin.Size = new System.Drawing.Size(125, 55);
			this.btnSigin.TabIndex = 59;
			this.btnSigin.Text = "Login";
			this.btnSigin.UseVisualStyleBackColor = false;
			this.btnSigin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(104, 265);
			this.textBox1.Margin = new System.Windows.Forms.Padding(4);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(239, 0);
			this.textBox1.TabIndex = 58;
			// 
			// txtBox_passLogin
			// 
			this.txtBox_passLogin.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.txtBox_passLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtBox_passLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.3299F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtBox_passLogin.ForeColor = System.Drawing.SystemColors.Window;
			this.txtBox_passLogin.Location = new System.Drawing.Point(104, 228);
			this.txtBox_passLogin.Margin = new System.Windows.Forms.Padding(4);
			this.txtBox_passLogin.Multiline = true;
			this.txtBox_passLogin.Name = "txtBox_passLogin";
			this.txtBox_passLogin.Size = new System.Drawing.Size(240, 38);
			this.txtBox_passLogin.TabIndex = 57;
			this.txtBox_passLogin.Text = "Password";
			this.txtBox_passLogin.Enter += new System.EventHandler(this.btnLogin_pass_enter);
			this.txtBox_passLogin.Leave += new System.EventHandler(this.btnLogin_pass_Leave);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.26804F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new System.Drawing.Point(154, 66);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(112, 44);
			this.label1.TabIndex = 56;
			this.label1.Text = "Login";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(104, 195);
			this.textBox2.Margin = new System.Windows.Forms.Padding(4);
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(239, 0);
			this.textBox2.TabIndex = 55;
			// 
			// txtBoxUserLogin
			// 
			this.txtBoxUserLogin.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.txtBoxUserLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtBoxUserLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.3299F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtBoxUserLogin.ForeColor = System.Drawing.SystemColors.Window;
			this.txtBoxUserLogin.Location = new System.Drawing.Point(104, 163);
			this.txtBoxUserLogin.Margin = new System.Windows.Forms.Padding(4);
			this.txtBoxUserLogin.Multiline = true;
			this.txtBoxUserLogin.Name = "txtBoxUserLogin";
			this.txtBoxUserLogin.Size = new System.Drawing.Size(240, 43);
			this.txtBoxUserLogin.TabIndex = 54;
			this.txtBoxUserLogin.Text = "Username";
			this.txtBoxUserLogin.Enter += new System.EventHandler(this.btnLogin_username_Enter);
			this.txtBoxUserLogin.Leave += new System.EventHandler(this.btnLogin_username_Leave);
			// 
			// btn_Çizgi
			// 
			this.btn_Çizgi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btn_Çizgi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_Çizgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.20619F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btn_Çizgi.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.btn_Çizgi.Image = ((System.Drawing.Image)(resources.GetObject("btn_Çizgi.Image")));
			this.btn_Çizgi.Location = new System.Drawing.Point(383, 10);
			this.btn_Çizgi.Margin = new System.Windows.Forms.Padding(4);
			this.btn_Çizgi.Name = "btn_Çizgi";
			this.btn_Çizgi.Size = new System.Drawing.Size(33, 37);
			this.btn_Çizgi.TabIndex = 53;
			this.btn_Çizgi.UseVisualStyleBackColor = true;
			this.btn_Çizgi.Click += new System.EventHandler(this.btn_Çizgi_Click);
			// 
			// btn_Çarpı
			// 
			this.btn_Çarpı.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btn_Çarpı.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_Çarpı.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.btn_Çarpı.Image = ((System.Drawing.Image)(resources.GetObject("btn_Çarpı.Image")));
			this.btn_Çarpı.Location = new System.Drawing.Point(420, 0);
			this.btn_Çarpı.Margin = new System.Windows.Forms.Padding(4);
			this.btn_Çarpı.Name = "btn_Çarpı";
			this.btn_Çarpı.Size = new System.Drawing.Size(48, 46);
			this.btn_Çarpı.TabIndex = 52;
			this.btn_Çarpı.UseVisualStyleBackColor = true;
			this.btn_Çarpı.Click += new System.EventHandler(this.btn_Exit_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.26804F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label3.Location = new System.Drawing.Point(412, 423);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(0, 44);
			this.label3.TabIndex = 64;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ClientSize = new System.Drawing.Size(469, 545);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnGoLogin);
			this.Controls.Add(this.btnSigin);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.txtBox_passLogin);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.txtBoxUserLogin);
			this.Controls.Add(this.btn_Çizgi);
			this.Controls.Add(this.btn_Çarpı);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Form1";
			this.Text = "Form1";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1Closing);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1Closed);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MauseDown);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MauseMove);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MauseUp);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		public System.Windows.Forms.Button btnGoLogin;
		public System.Windows.Forms.Button btnSigin;
		public System.Windows.Forms.TextBox textBox1;
		public System.Windows.Forms.TextBox txtBox_passLogin;
		public System.Windows.Forms.Label label1;
		public System.Windows.Forms.TextBox textBox2;
		public System.Windows.Forms.TextBox txtBoxUserLogin;
		public System.Windows.Forms.Button btn_Çizgi;
		public System.Windows.Forms.Button btn_Çarpı;
		public System.Windows.Forms.Label label3;
	}
}

