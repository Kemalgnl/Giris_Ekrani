using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace login22._27._2022
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		public static SqlConnection bağlantı = new SqlConnection("Data Source=CASPER\\SQLEXPRESS;Initial Catalog=database22;Integrated Security=true");

		public void btnLogin_Click(object sender, EventArgs e)
		{

			string Username = txtBoxUserLogin.Text;
			string pass=txtBox_passLogin.Text;

			bağlantı.Open();
			SqlCommand komut = new SqlCommand("select *From Table1",bağlantı);
			SqlDataReader okuyucu = komut.ExecuteReader();
			while (okuyucu.Read())
			{
				if (Username==okuyucu["username"].ToString().TrimEnd()&& pass == okuyucu["pass"].ToString().TrimEnd())//okuyucu okuduğu süre boyunca
				{
						Form3 form3 = new Form3();
						this.Hide();
						form3.ShowDialog();
				}
				if (Username != okuyucu["username"].ToString().TrimEnd() && pass != okuyucu["pass"].ToString().TrimEnd())//okuyucu okuduğu süre boyunca
				{
					MessageBox.Show("böyle bir hesap bulunmuyor lütfen tekrar deneyin");
				}
			}
			okuyucu.Close();

			
		}
		private void btn_GoSigin_Click(object sender, EventArgs e)
		{
			Form2 form2 = new Form2();
			this.Hide();
			form2.ShowDialog();
		}

		#region border işlemleri
		private void btn_Çizgi_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void btn_Exit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		#endregion
		#region mause Move
		bool Move1;
		int Mause_x;
		int Mause_y;
		private void MauseDown(object sender, MouseEventArgs e)
		{
			Move1 = true;
			Mause_x = e.X;
			Mause_y = e.Y;
		}

		private void MauseMove(object sender, MouseEventArgs e)
		{
			label3.Visible = false;
			if (Move1 == true)
			{
				this.SetDesktopLocation(MousePosition.X - Mause_x, MousePosition.Y - Mause_y);
			}
		}

		private void MauseUp(object sender, MouseEventArgs e)
		{
			Move1 = false;
		}
		#endregion
		#region textbox işlemleri

		private void btnLogin_username_Enter(object sender, EventArgs e)
		{
			txtBoxUserLogin.Text = "";
		}

		private void btnLogin_username_Leave(object sender, EventArgs e)
		{
			if (txtBoxUserLogin.Text == "")
			{
				txtBoxUserLogin.Text = "Username";
			}
		}

		private void btnLogin_pass_enter(object sender, EventArgs e)
		{
			txtBox_passLogin.Text = "";
		}

		private void btnLogin_pass_Leave(object sender, EventArgs e)
		{
			if (txtBox_passLogin.Text == "")
			{
				txtBox_passLogin.Text = "Username";
			}
		}

		#endregion

		private void Form1Closed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}
		private void Form1Closing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}
	}
}
