using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GameOfLife
{
	public partial class MainFrm : Form
	{
		public MainFrm()
		{
			InitializeComponent();
		}

		private void MainFrm_Load(object sender, EventArgs e)
		{
			FieldClass.ResetField();
		}

		private void cmdStart_Click(object sender, EventArgs e)
		{
			SpawnTimer.Enabled = true;
		}

		private void cmdStop_Click(object sender, EventArgs e)
		{
			SpawnTimer.Enabled = false;
		}

		private void SpawnTimer_Tick(object sender, EventArgs e)
		{
			FieldClass.NextStep();
			txtCounter.Text = FieldClass.StepCount.ToString();
			
			int tmpX = 0;
			int tmpY = 0;
			Bitmap bmpField = new Bitmap(600, 600);
			for (int x = 0; x <= 198; x++) {
				for (int y = 0; y <= 198; y++) {
					if (FieldClass.Cell(x, y) == true) {
						tmpX = x * 3;
						tmpY = y * 3;
						bmpField.SetPixel(tmpX, tmpY, Color.Black);
						bmpField.SetPixel(tmpX, tmpY + 1, Color.Black);
						bmpField.SetPixel(tmpX, tmpY + 2, Color.Black);

						bmpField.SetPixel(tmpX + 1, tmpY, Color.Black);
						bmpField.SetPixel(tmpX + 1, tmpY + 1, Color.Black);
						bmpField.SetPixel(tmpX + 1, tmpY + 2, Color.Black);

						bmpField.SetPixel(tmpX + 2, tmpY, Color.Black);
						bmpField.SetPixel(tmpX + 2, tmpY + 1, Color.Black);
						bmpField.SetPixel(tmpX + 2, tmpY + 2, Color.Black);
						
					}
				}
			}
			pbxField.Image = bmpField;
			pbxField.Refresh();
			
		}

		private void cmdReset_Click(object sender, EventArgs e)
		{
			FieldClass.ResetField();
		}
	}
}
