namespace GameOfLife
{
	partial class MainFrm
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
			this.pbxField = new System.Windows.Forms.PictureBox();
			this.SpawnTimer = new System.Windows.Forms.Timer(this.components);
			this.cmdStart = new System.Windows.Forms.Button();
			this.cmdStop = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtCounter = new System.Windows.Forms.Label();
			this.cmdReset = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pbxField)).BeginInit();
			this.SuspendLayout();
			// 
			// pbxField
			// 
			this.pbxField.Location = new System.Drawing.Point(83, 12);
			this.pbxField.Name = "pbxField";
			this.pbxField.Size = new System.Drawing.Size(600, 600);
			this.pbxField.TabIndex = 0;
			this.pbxField.TabStop = false;
			// 
			// SpawnTimer
			// 
			this.SpawnTimer.Interval = 50;
			this.SpawnTimer.Tick += new System.EventHandler(this.SpawnTimer_Tick);
			// 
			// cmdStart
			// 
			this.cmdStart.Location = new System.Drawing.Point(12, 12);
			this.cmdStart.Name = "cmdStart";
			this.cmdStart.Size = new System.Drawing.Size(64, 23);
			this.cmdStart.TabIndex = 1;
			this.cmdStart.Text = "Start";
			this.cmdStart.UseVisualStyleBackColor = true;
			this.cmdStart.Click += new System.EventHandler(this.cmdStart_Click);
			// 
			// cmdStop
			// 
			this.cmdStop.Location = new System.Drawing.Point(13, 41);
			this.cmdStop.Name = "cmdStop";
			this.cmdStop.Size = new System.Drawing.Size(64, 23);
			this.cmdStop.TabIndex = 2;
			this.cmdStop.Text = "Stop";
			this.cmdStop.UseVisualStyleBackColor = true;
			this.cmdStop.Click += new System.EventHandler(this.cmdStop_Click);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(10, 96);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(68, 15);
			this.label1.TabIndex = 3;
			this.label1.Text = "Step:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// txtCounter
			// 
			this.txtCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCounter.Location = new System.Drawing.Point(10, 111);
			this.txtCounter.Name = "txtCounter";
			this.txtCounter.Size = new System.Drawing.Size(68, 15);
			this.txtCounter.TabIndex = 4;
			this.txtCounter.Text = "0";
			this.txtCounter.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// cmdReset
			// 
			this.cmdReset.Location = new System.Drawing.Point(12, 70);
			this.cmdReset.Name = "cmdReset";
			this.cmdReset.Size = new System.Drawing.Size(64, 23);
			this.cmdReset.TabIndex = 5;
			this.cmdReset.Text = "Reset";
			this.cmdReset.UseVisualStyleBackColor = true;
			this.cmdReset.Click += new System.EventHandler(this.cmdReset_Click);
			// 
			// MainFrm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(759, 674);
			this.Controls.Add(this.cmdReset);
			this.Controls.Add(this.txtCounter);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cmdStop);
			this.Controls.Add(this.cmdStart);
			this.Controls.Add(this.pbxField);
			this.Name = "MainFrm";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.MainFrm_Load);
			((System.ComponentModel.ISupportInitialize)(this.pbxField)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pbxField;
		private System.Windows.Forms.Timer SpawnTimer;
		private System.Windows.Forms.Button cmdStart;
		private System.Windows.Forms.Button cmdStop;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label txtCounter;
		private System.Windows.Forms.Button cmdReset;
	}
}

