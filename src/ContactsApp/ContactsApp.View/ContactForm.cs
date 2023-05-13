using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactsApp.View
{
	public partial class ContactForm : Form
	{
		public ContactForm()
		{
			InitializeComponent();
		}

		private void OkButton_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;
		}

		private void CancelButton_Click(object sender, EventArgs e)
		{
			DialogResult=DialogResult.Cancel;
		}

		private void AddPhotoButton_MouseEnter(object sender, EventArgs e)
		{
			AddPhotoButton.Image = Properties.Resources.add_photo_32x32;
		}

		private void AddPhotoButton_MouseLeave(object sender, EventArgs e)
		{
			AddPhotoButton.Image = Properties.Resources.add_photo_32x32_gray;
		}
	}
}
