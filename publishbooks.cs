using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogIn_Sys
{
	public partial class publishbooks : Form
	{
		public publishbooks()
		{
			InitializeComponent();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			MessageBox.Show("This action will delete any unsaved data. Are you sure you want to exit?");
			this.Hide();
			form4 form4 = new form4();
			form4.ShowDialog();
			this.Close();
		}
	}
}
