namespace Rome2Arab
{
    partial class Main
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			this.tbInput = new System.Windows.Forms.TextBox();
			this.rtbResult = new System.Windows.Forms.RichTextBox();
			this.cmbSystem = new System.Windows.Forms.ComboBox();
			this.btnConvert = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.RomeNumbersPanel = new System.Windows.Forms.Panel();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton10 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton11 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton12 = new System.Windows.Forms.ToolStripButton();
			this.RomeNumbersPanel.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tbInput
			// 
			this.tbInput.Location = new System.Drawing.Point(62, 39);
			this.tbInput.Name = "tbInput";
			this.tbInput.Size = new System.Drawing.Size(160, 20);
			this.tbInput.TabIndex = 0;
			// 
			// rtbResult
			// 
			this.rtbResult.Location = new System.Drawing.Point(12, 103);
			this.rtbResult.Name = "rtbResult";
			this.rtbResult.Size = new System.Drawing.Size(291, 146);
			this.rtbResult.TabIndex = 2;
			this.rtbResult.Text = "";
			// 
			// cmbSystem
			// 
			this.cmbSystem.FormattingEnabled = true;
			this.cmbSystem.Items.AddRange(new object[] {
            "Римские в Арабские",
            "Арабские в Римские "});
			this.cmbSystem.Location = new System.Drawing.Point(12, 12);
			this.cmbSystem.Name = "cmbSystem";
			this.cmbSystem.Size = new System.Drawing.Size(291, 21);
			this.cmbSystem.TabIndex = 3;
			this.cmbSystem.Text = "Римские в Арабские";
			this.cmbSystem.SelectedIndexChanged += new System.EventHandler(this.cmbSystem_SelectedIndexChanged);
			// 
			// btnConvert
			// 
			this.btnConvert.Location = new System.Drawing.Point(228, 39);
			this.btnConvert.Name = "btnConvert";
			this.btnConvert.Size = new System.Drawing.Size(75, 23);
			this.btnConvert.TabIndex = 4;
			this.btnConvert.Text = "Перевести";
			this.btnConvert.UseVisualStyleBackColor = true;
			this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 42);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Число:";
			// 
			// RomeNumbersPanel
			// 
			this.RomeNumbersPanel.Controls.Add(this.toolStrip1);
			this.RomeNumbersPanel.Location = new System.Drawing.Point(12, 68);
			this.RomeNumbersPanel.Name = "RomeNumbersPanel";
			this.RomeNumbersPanel.Size = new System.Drawing.Size(298, 29);
			this.RomeNumbersPanel.TabIndex = 6;
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripButton7,
            this.toolStripButton8,
            this.toolStripButton9,
            this.toolStripButton10,
            this.toolStripButton11,
            this.toolStripButton12});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(298, 25);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(25, 22);
			this.toolStripButton1.Tag = "";
			this.toolStripButton1.Text = "ↂ";
			this.toolStripButton1.ToolTipText = "ↂ - 10000";
			this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
			// 
			// toolStripButton2
			// 
			this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
			this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton2.Name = "toolStripButton2";
			this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton2.Tag = "";
			this.toolStripButton2.Text = "ↁ";
			this.toolStripButton2.ToolTipText = "ↁ - 5000";
			this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton1_Click);
			// 
			// toolStripButton3
			// 
			this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
			this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton3.Name = "toolStripButton3";
			this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton3.Tag = "";
			this.toolStripButton3.Text = "Ⅿ";
			this.toolStripButton3.ToolTipText = "Ⅿ - 1000";
			this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton1_Click);
			// 
			// toolStripButton4
			// 
			this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
			this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton4.Name = "toolStripButton4";
			this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton4.Tag = "";
			this.toolStripButton4.Text = "Ⅾ";
			this.toolStripButton4.ToolTipText = "Ⅾ - 500";
			this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton1_Click);
			// 
			// toolStripButton5
			// 
			this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
			this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton5.Name = "toolStripButton5";
			this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton5.Tag = "";
			this.toolStripButton5.Text = "Ⅽ";
			this.toolStripButton5.ToolTipText = "Ⅽ - 100";
			this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton1_Click);
			// 
			// toolStripButton6
			// 
			this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
			this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton6.Name = "toolStripButton6";
			this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton6.Tag = "";
			this.toolStripButton6.Text = "Ⅼ";
			this.toolStripButton6.ToolTipText = "Ⅼ - 50";
			this.toolStripButton6.Click += new System.EventHandler(this.toolStripButton1_Click);
			// 
			// toolStripButton7
			// 
			this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
			this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton7.Name = "toolStripButton7";
			this.toolStripButton7.Size = new System.Drawing.Size(24, 22);
			this.toolStripButton7.Tag = "";
			this.toolStripButton7.Text = "XL";
			this.toolStripButton7.ToolTipText = "XL - 40";
			this.toolStripButton7.Click += new System.EventHandler(this.toolStripButton1_Click);
			// 
			// toolStripButton8
			// 
			this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
			this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton8.Name = "toolStripButton8";
			this.toolStripButton8.Size = new System.Drawing.Size(24, 22);
			this.toolStripButton8.Tag = "";
			this.toolStripButton8.Text = "Ⅹ";
			this.toolStripButton8.ToolTipText = "Ⅹ - 10";
			this.toolStripButton8.Click += new System.EventHandler(this.toolStripButton1_Click);
			// 
			// toolStripButton9
			// 
			this.toolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripButton9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton9.Image")));
			this.toolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton9.Name = "toolStripButton9";
			this.toolStripButton9.Size = new System.Drawing.Size(24, 22);
			this.toolStripButton9.Tag = "";
			this.toolStripButton9.Text = "Ⅸ";
			this.toolStripButton9.ToolTipText = "Ⅸ - 9";
			this.toolStripButton9.Click += new System.EventHandler(this.toolStripButton1_Click);
			// 
			// toolStripButton10
			// 
			this.toolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripButton10.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton10.Image")));
			this.toolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton10.Name = "toolStripButton10";
			this.toolStripButton10.Size = new System.Drawing.Size(24, 22);
			this.toolStripButton10.Tag = "";
			this.toolStripButton10.Text = "Ⅴ";
			this.toolStripButton10.ToolTipText = "Ⅴ - 5";
			this.toolStripButton10.Click += new System.EventHandler(this.toolStripButton1_Click);
			// 
			// toolStripButton11
			// 
			this.toolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripButton11.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton11.Image")));
			this.toolStripButton11.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton11.Name = "toolStripButton11";
			this.toolStripButton11.Size = new System.Drawing.Size(24, 22);
			this.toolStripButton11.Tag = "";
			this.toolStripButton11.Text = "Ⅳ";
			this.toolStripButton11.ToolTipText = "Ⅳ - 4";
			this.toolStripButton11.Click += new System.EventHandler(this.toolStripButton1_Click);
			// 
			// toolStripButton12
			// 
			this.toolStripButton12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripButton12.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton12.Image")));
			this.toolStripButton12.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton12.Name = "toolStripButton12";
			this.toolStripButton12.Size = new System.Drawing.Size(24, 22);
			this.toolStripButton12.Text = "Ⅰ";
			this.toolStripButton12.ToolTipText = "Ⅰ - 1";
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(315, 261);
			this.Controls.Add(this.RomeNumbersPanel);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnConvert);
			this.Controls.Add(this.cmbSystem);
			this.Controls.Add(this.rtbResult);
			this.Controls.Add(this.tbInput);
			this.Name = "Main";
			this.Text = "Перевод чисел";
			this.RomeNumbersPanel.ResumeLayout(false);
			this.RomeNumbersPanel.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.RichTextBox rtbResult;
        private System.Windows.Forms.ComboBox cmbSystem;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel RomeNumbersPanel;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.ToolStripButton toolStripButton2;
		private System.Windows.Forms.ToolStripButton toolStripButton3;
		private System.Windows.Forms.ToolStripButton toolStripButton4;
		private System.Windows.Forms.ToolStripButton toolStripButton5;
		private System.Windows.Forms.ToolStripButton toolStripButton6;
		private System.Windows.Forms.ToolStripButton toolStripButton7;
		private System.Windows.Forms.ToolStripButton toolStripButton8;
		private System.Windows.Forms.ToolStripButton toolStripButton9;
		private System.Windows.Forms.ToolStripButton toolStripButton10;
		private System.Windows.Forms.ToolStripButton toolStripButton11;
		private System.Windows.Forms.ToolStripButton toolStripButton12;
    }
}

