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
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}
		SqlConnection bağlantı2 = Form1.bağlantı;
		public void btnSigin_Click(object sender, EventArgs e)//eklem kısmı
		{
			string Username2 = txtBoxSiginUser.Text;
			string pass = txtBoxSiginPass1.Text;
			if (txtBoxSiginPass1.Text==txtBoxSiginPass2.Text)
			{
				bağlantı2.Open();
				SqlCommand komut2 = new SqlCommand("Insert into database22(username,pass)values('" + Username2 + "','" + pass + "')", bağlantı2);
				komut2.ExecuteNonQuery();
				bağlantı2.Close();

				MessageBox.Show("yeni kişi eklendi");

				Form3 form3 = new Form3();
				this.Hide();
				form3.ShowDialog();
				
			}
			else
			{
				MessageBox.Show("şifreler aynı olmalı");
			}
			
		}

		private void btnGoLogin_Click(object sender, EventArgs e)
		{
			Form1 form1 = new Form1();
			this.Hide();
			form1.ShowDialog();
		}



		
		#region border işlemleri
		private void btn_Çizgi_Click_1(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void btn_Çarpı_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		#endregion
		#region mause Move
		bool Move2;
		int Mause_x;
		int Mause_y;
		private void MauseDown(object sender, MouseEventArgs e)
		{
			Move2 = true;
			Mause_x = e.X;
			Mause_y = e.Y;
		}

		private void MauseMove(object sender, MouseEventArgs e)
		{
			label2.Visible = false;
			if (Move2 == true)
			{
				this.SetDesktopLocation(MousePosition.X - Mause_x, MousePosition.Y - Mause_y);
			}
		}

		private void MauseUp(object sender, MouseEventArgs e)
		{
			Move2 = false;
		}
		#endregion
		#region textbox işlemleri
		private void BtnSigin_User_Enter(object sender, EventArgs e)
		{
			txtBoxSiginUser.Text = "";
		}

		private void BtnSigin_User_Leave(object sender, EventArgs e)
		{
			if (txtBoxSiginUser.Text == "")
			{
				txtBoxSiginUser.Text = "Username";
			}
		}

		private void BtnSigin_Pass_Enter(object sender, EventArgs e)
		{
			txtBoxSiginPass1.Text = "";
		}

		private void BtnSigin_Pass_Leave(object sender, EventArgs e)
		{
			if (txtBoxSiginPass1.Text == "")
			{
				txtBoxSiginPass1.Text = "Username";
			}
		}

		private void BtnSigin_passAgain_Enter(object sender, EventArgs e)
		{
			txtBoxSiginPass2.Text = "";
		}

		private void BtnSigin_passAgain_Leave(object sender, EventArgs e)
		{
			if (txtBoxSiginPass2.Text == "")
			{
				txtBoxSiginPass2.Text = "Username";
			}
		}
		#endregion

		private void Form2Closed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}
		private void Form2Closing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}
	}
}
