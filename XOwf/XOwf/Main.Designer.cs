namespace XOwf {
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
			this.FieldPanel = new System.Windows.Forms.Panel();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.status = new System.Windows.Forms.ToolStripStatusLabel();
			this.Mode = new System.Windows.Forms.GroupBox();
			this.rbVsPC = new System.Windows.Forms.RadioButton();
			this.rbTwoPlayer = new System.Windows.Forms.RadioButton();
			this.NewGame = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.Mode.SuspendLayout();
			this.SuspendLayout();
			// 
			// FieldPanel
			// 
			this.FieldPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.FieldPanel.Location = new System.Drawing.Point(12, 27);
			this.FieldPanel.Name = "FieldPanel";
			this.FieldPanel.Size = new System.Drawing.Size(165, 165);
			this.FieldPanel.TabIndex = 0;
			this.FieldPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			this.FieldPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(328, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// файлToolStripMenuItem
			// 
			this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.toolStripMenuItem1,
            this.ExitToolStripMenuItem});
			this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
			this.файлToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
			this.файлToolStripMenuItem.Text = "Файл";
			// 
			// newGameToolStripMenuItem
			// 
			this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
			this.newGameToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
			this.newGameToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
			this.newGameToolStripMenuItem.Text = "Новая игра";
			this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(158, 6);
			// 
			// ExitToolStripMenuItem
			// 
			this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
			this.ExitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
			this.ExitToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
			this.ExitToolStripMenuItem.Text = "Выход";
			this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status});
			this.statusStrip1.Location = new System.Drawing.Point(0, 201);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(328, 22);
			this.statusStrip1.TabIndex = 2;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// status
			// 
			this.status.Name = "status";
			this.status.Size = new System.Drawing.Size(0, 17);
			// 
			// Mode
			// 
			this.Mode.Controls.Add(this.rbVsPC);
			this.Mode.Controls.Add(this.rbTwoPlayer);
			this.Mode.Location = new System.Drawing.Point(183, 27);
			this.Mode.Name = "Mode";
			this.Mode.Size = new System.Drawing.Size(137, 76);
			this.Mode.TabIndex = 4;
			this.Mode.TabStop = false;
			this.Mode.Text = "Режим";
			// 
			// rbVsPC
			// 
			this.rbVsPC.AutoSize = true;
			this.rbVsPC.Location = new System.Drawing.Point(6, 42);
			this.rbVsPC.Name = "rbVsPC";
			this.rbVsPC.Size = new System.Drawing.Size(128, 17);
			this.rbVsPC.TabIndex = 1;
			this.rbVsPC.Text = "Против компьютера";
			this.rbVsPC.UseVisualStyleBackColor = true;
			// 
			// rbTwoPlayer
			// 
			this.rbTwoPlayer.AutoSize = true;
			this.rbTwoPlayer.Checked = true;
			this.rbTwoPlayer.Location = new System.Drawing.Point(6, 19);
			this.rbTwoPlayer.Name = "rbTwoPlayer";
			this.rbTwoPlayer.Size = new System.Drawing.Size(69, 17);
			this.rbTwoPlayer.TabIndex = 0;
			this.rbTwoPlayer.TabStop = true;
			this.rbTwoPlayer.Text = "2 игрока";
			this.rbTwoPlayer.UseVisualStyleBackColor = true;
			// 
			// NewGame
			// 
			this.NewGame.Location = new System.Drawing.Point(183, 109);
			this.NewGame.Name = "NewGame";
			this.NewGame.Size = new System.Drawing.Size(137, 23);
			this.NewGame.TabIndex = 5;
			this.NewGame.Text = "Новая игра";
			this.NewGame.UseVisualStyleBackColor = true;
			this.NewGame.Click += new System.EventHandler(this.NewGame_Click);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(328, 223);
			this.Controls.Add(this.NewGame);
			this.Controls.Add(this.Mode);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.FieldPanel);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Main";
			this.Text = "XO";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.Mode.ResumeLayout(false);
			this.Mode.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		/// <summary>
		/// Игровая панель
		/// </summary>
		private System.Windows.Forms.Panel FieldPanel;
		/// <summary>
		/// Меню
		/// </summary>
		private System.Windows.Forms.MenuStrip menuStrip1;
		/// <summary>
		/// Пункт меню "Файл"
		/// </summary>
		private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
		/// <summary>
		/// Пункт меню "Новая игра"
		/// </summary>
		private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
		/// <summary>
		/// Разделитель
		/// </summary>
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		/// <summary>
		/// Пункт меню "Выход"
		/// </summary>
		private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
		/// <summary>
		/// Панель статуса
		/// </summary>
		private System.Windows.Forms.StatusStrip statusStrip1;
		/// <summary>
		/// Статус игры
		/// </summary>
		private System.Windows.Forms.ToolStripStatusLabel status;
		/// <summary>
		/// Поле группирования "Режим"
		/// </summary>
		private System.Windows.Forms.GroupBox Mode;
		/// <summary>
		/// Режим "Против Компьютера"
		/// </summary>
		private System.Windows.Forms.RadioButton rbVsPC;
		/// <summary>
		/// Режим "Два игрока"
		/// </summary>
		private System.Windows.Forms.RadioButton rbTwoPlayer;
		/// <summary>
		/// Кнопка "Новая игра"
		/// </summary>
		private System.Windows.Forms.Button NewGame;
	}
}

