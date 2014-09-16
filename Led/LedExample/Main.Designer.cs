namespace LedExample {
	partial class Main {
		/// <summary>
		/// Требуется переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Обязательный метод для поддержки конструктора - не изменяйте
		/// содержимое данного метода при помощи редактора кода.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			this.time = new System.Windows.Forms.Timer(this.components);
			this.dliSeconds = new Led.DoubleLedIndicator();
			this.dliMinutes = new Led.DoubleLedIndicator();
			this.dliHour = new Led.DoubleLedIndicator();
			this.SuspendLayout();
			// 
			// time
			// 
			this.time.Enabled = true;
			this.time.Interval = 1000;
			this.time.Tick += new System.EventHandler(this.time_Tick);
			// 
			// dliSeconds
			// 
			this.dliSeconds.AutoSize = true;
			this.dliSeconds.BackColor = System.Drawing.SystemColors.ControlText;
			this.dliSeconds.Location = new System.Drawing.Point(387, 0);
			this.dliSeconds.Name = "dliSeconds";
			this.dliSeconds.Size = new System.Drawing.Size(189, 178);
			this.dliSeconds.TabIndex = 2;
			// 
			// dliMinutes
			// 
			this.dliMinutes.AutoSize = true;
			this.dliMinutes.BackColor = System.Drawing.SystemColors.ControlText;
			this.dliMinutes.Location = new System.Drawing.Point(192, 0);
			this.dliMinutes.Name = "dliMinutes";
			this.dliMinutes.Size = new System.Drawing.Size(189, 178);
			this.dliMinutes.TabIndex = 1;
			// 
			// dliHour
			// 
			this.dliHour.AutoSize = true;
			this.dliHour.BackColor = System.Drawing.SystemColors.ControlText;
			this.dliHour.Location = new System.Drawing.Point(0, 0);
			this.dliHour.Name = "dliHour";
			this.dliHour.Size = new System.Drawing.Size(189, 178);
			this.dliHour.TabIndex = 0;
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(580, 184);
			this.Controls.Add(this.dliSeconds);
			this.Controls.Add(this.dliMinutes);
			this.Controls.Add(this.dliHour);
			this.Name = "Main";
			this.Text = "Демонстрация работы компонента DoubleLedIndicator";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Led.DoubleLedIndicator dliHour;
		private Led.DoubleLedIndicator dliMinutes;
		private Led.DoubleLedIndicator dliSeconds;
		private System.Windows.Forms.Timer time;

	}
}

