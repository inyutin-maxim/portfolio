namespace Led {
	partial class DoubleLedIndicator {
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

		#region Код, автоматически созданный конструктором компонентов

		/// <summary> 
		/// Обязательный метод для поддержки конструктора - не изменяйте 
		/// содержимое данного метода при помощи редактора кода.
		/// </summary>
		private void InitializeComponent() {
			this.tensLed = new Led.LedIndicator();
			this.unitsLed = new Led.LedIndicator();
			this.SuspendLayout();
			// 
			// tensLed
			// 
			this.tensLed.AutoSize = true;
			this.tensLed.BackColor = System.Drawing.SystemColors.ControlText;
			this.tensLed.Location = new System.Drawing.Point(0, 0);
			this.tensLed.MinimumSize = new System.Drawing.Size(90, 175);
			this.tensLed.Name = "tensLed";
			this.tensLed.Size = new System.Drawing.Size(90, 175);
			this.tensLed.TabIndex = 0;
			// 
			// unitsLed
			// 
			this.unitsLed.AutoSize = true;
			this.unitsLed.BackColor = System.Drawing.SystemColors.ControlText;
			this.unitsLed.Location = new System.Drawing.Point(96, 0);
			this.unitsLed.MinimumSize = new System.Drawing.Size(90, 175);
			this.unitsLed.Name = "unitsLed";
			this.unitsLed.Size = new System.Drawing.Size(90, 175);
			this.unitsLed.TabIndex = 1;
			// 
			// DoubleLedIndicator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.SystemColors.ControlText;
			this.Controls.Add(this.unitsLed);
			this.Controls.Add(this.tensLed);
			this.Name = "DoubleLedIndicator";
			this.Size = new System.Drawing.Size(193, 179);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private LedIndicator tensLed;
		private LedIndicator unitsLed;
	}
}
