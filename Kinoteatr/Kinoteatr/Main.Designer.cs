using System.Collections.Generic;

namespace Kinoteatr
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
			this.components = new System.ComponentModel.Container();
			this.lbSeansList = new System.Windows.Forms.ListBox();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.ToolStripMenuItemSeans = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemFreePlaces = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.ToolStripMenuItemDay = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.добавитьСеансToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label1 = new System.Windows.Forms.Label();
			this.btnSetTestData = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnAddSeans = new System.Windows.Forms.Button();
			this.tbNewSeans = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.label6 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
			this.показатьФормуПользователяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.btnShowClientForm = new System.Windows.Forms.Button();
			this.contextMenuStrip1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// lbSeansList
			// 
			this.lbSeansList.ContextMenuStrip = this.contextMenuStrip1;
			this.lbSeansList.FormattingEnabled = true;
			this.lbSeansList.Location = new System.Drawing.Point(15, 25);
			this.lbSeansList.Name = "lbSeansList";
			this.lbSeansList.Size = new System.Drawing.Size(110, 225);
			this.lbSeansList.TabIndex = 0;
			this.lbSeansList.SelectedIndexChanged += new System.EventHandler(this.lbSeansList_SelectedIndexChanged);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemSeans,
            this.toolStripMenuItemFreePlaces,
            this.ToolStripMenuItem1,
            this.ToolStripMenuItemDay,
            this.toolStripMenuItem2,
            this.добавитьСеансToolStripMenuItem,
            this.toolStripMenuItem3,
            this.показатьФормуПользователяToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(277, 132);
			// 
			// ToolStripMenuItemSeans
			// 
			this.ToolStripMenuItemSeans.Name = "ToolStripMenuItemSeans";
			this.ToolStripMenuItemSeans.Size = new System.Drawing.Size(276, 22);
			this.ToolStripMenuItemSeans.Text = "Прибыль за сеанс";
			this.ToolStripMenuItemSeans.Click += new System.EventHandler(this.ToolStripMenuItemSeans_Click);
			// 
			// toolStripMenuItemFreePlaces
			// 
			this.toolStripMenuItemFreePlaces.Name = "toolStripMenuItemFreePlaces";
			this.toolStripMenuItemFreePlaces.Size = new System.Drawing.Size(276, 22);
			this.toolStripMenuItemFreePlaces.Text = "Проверить наличие свободных мест";
			this.toolStripMenuItemFreePlaces.Click += new System.EventHandler(this.toolStripMenuItemFreePlaces_Click);
			// 
			// ToolStripMenuItem1
			// 
			this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
			this.ToolStripMenuItem1.Size = new System.Drawing.Size(273, 6);
			// 
			// ToolStripMenuItemDay
			// 
			this.ToolStripMenuItemDay.Name = "ToolStripMenuItemDay";
			this.ToolStripMenuItemDay.Size = new System.Drawing.Size(276, 22);
			this.ToolStripMenuItemDay.Text = "Прибыль за день";
			this.ToolStripMenuItemDay.Click += new System.EventHandler(this.ToolStripMenuItemDay_Click);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(273, 6);
			// 
			// добавитьСеансToolStripMenuItem
			// 
			this.добавитьСеансToolStripMenuItem.Name = "добавитьСеансToolStripMenuItem";
			this.добавитьСеансToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
			this.добавитьСеансToolStripMenuItem.Text = "Добавить сеанс";
			this.добавитьСеансToolStripMenuItem.Click += new System.EventHandler(this.добавитьСеансToolStripMenuItem_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(89, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Список сеансов";
			// 
			// btnSetTestData
			// 
			this.btnSetTestData.Location = new System.Drawing.Point(364, 256);
			this.btnSetTestData.Name = "btnSetTestData";
			this.btnSetTestData.Size = new System.Drawing.Size(144, 23);
			this.btnSetTestData.TabIndex = 3;
			this.btnSetTestData.Text = "Установить тестовые данные";
			this.btnSetTestData.UseVisualStyleBackColor = true;
			this.btnSetTestData.Click += new System.EventHandler(this.btnSetTestData_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnAddSeans);
			this.groupBox2.Controls.Add(this.tbNewSeans);
			this.groupBox2.Location = new System.Drawing.Point(15, 256);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(346, 42);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Новый сеанс";
			this.groupBox2.Visible = false;
			// 
			// btnAddSeans
			// 
			this.btnAddSeans.Location = new System.Drawing.Point(238, 14);
			this.btnAddSeans.Name = "btnAddSeans";
			this.btnAddSeans.Size = new System.Drawing.Size(102, 23);
			this.btnAddSeans.TabIndex = 1;
			this.btnAddSeans.Text = "Добавить сеанс";
			this.btnAddSeans.UseVisualStyleBackColor = true;
			this.btnAddSeans.Click += new System.EventHandler(this.btnAddSeans_Click);
			// 
			// tbNewSeans
			// 
			this.tbNewSeans.Location = new System.Drawing.Point(3, 16);
			this.tbNewSeans.Name = "tbNewSeans";
			this.tbNewSeans.Size = new System.Drawing.Size(229, 20);
			this.tbNewSeans.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Location = new System.Drawing.Point(131, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(370, 238);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Зал";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Green;
			this.pictureBox1.Location = new System.Drawing.Point(6, 19);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(28, 20);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.Red;
			this.pictureBox2.Location = new System.Drawing.Point(6, 45);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(28, 20);
			this.pictureBox2.TabIndex = 1;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.BackColor = System.Drawing.Color.Blue;
			this.pictureBox3.Location = new System.Drawing.Point(6, 71);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(28, 20);
			this.pictureBox3.TabIndex = 2;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox4
			// 
			this.pictureBox4.BackColor = System.Drawing.Color.Brown;
			this.pictureBox4.Location = new System.Drawing.Point(6, 97);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(28, 20);
			this.pictureBox4.TabIndex = 3;
			this.pictureBox4.TabStop = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(40, 26);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "- 100 р";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(40, 52);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(40, 13);
			this.label3.TabIndex = 5;
			this.label3.Tag = "";
			this.label3.Text = "- 200 р";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(40, 78);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(40, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "- 300 р";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(40, 104);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(40, 13);
			this.label5.TabIndex = 7;
			this.label5.Text = "- 400 р";
			// 
			// pictureBox5
			// 
			this.pictureBox5.BackColor = System.Drawing.Color.LightGray;
			this.pictureBox5.Location = new System.Drawing.Point(6, 123);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(28, 20);
			this.pictureBox5.TabIndex = 8;
			this.pictureBox5.TabStop = false;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(40, 130);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(49, 13);
			this.label6.TabIndex = 9;
			this.label6.Text = "- Занято";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.label6);
			this.groupBox3.Controls.Add(this.pictureBox5);
			this.groupBox3.Controls.Add(this.label5);
			this.groupBox3.Controls.Add(this.label4);
			this.groupBox3.Controls.Add(this.label3);
			this.groupBox3.Controls.Add(this.label2);
			this.groupBox3.Controls.Add(this.pictureBox4);
			this.groupBox3.Controls.Add(this.pictureBox3);
			this.groupBox3.Controls.Add(this.pictureBox2);
			this.groupBox3.Controls.Add(this.pictureBox1);
			this.groupBox3.Location = new System.Drawing.Point(507, 12);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(95, 238);
			this.groupBox3.TabIndex = 5;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Легенда";
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(273, 6);
			// 
			// btnShowClientForm
			// 
			this.btnShowClientForm.Location = new System.Drawing.Point(462, 270);
			this.btnShowClientForm.Name = "btnShowClientForm";
			this.btnShowClientForm.Size = new System.Drawing.Size(140, 23);
			this.btnShowClientForm.TabIndex = 6;
			this.btnShowClientForm.Text = "Форма пользователя";
			this.btnShowClientForm.UseVisualStyleBackColor = true;
			this.btnShowClientForm.Click += new System.EventHandler(this.btnShowClientForm_Click);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(614, 303);
			this.Controls.Add(this.btnShowClientForm);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.btnSetTestData);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lbSeansList);
			this.Name = "Main";
			this.Text = "Кинотеатр.";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.Load += new System.EventHandler(this.Main_Load);
			this.contextMenuStrip1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbSeansList;
		private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSeans;
        private System.Windows.Forms.ToolStripSeparator ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemDay;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFreePlaces;
        private System.Windows.Forms.Button btnSetTestData;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddSeans;
        private System.Windows.Forms.TextBox tbNewSeans;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem добавитьСеансToolStripMenuItem;

	    /// <summary>
	    /// Список мест
	    /// </summary>
		public List<Place> placeList = new List<Place>();
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem показатьФормуПользователяToolStripMenuItem;
		private System.Windows.Forms.Button btnShowClientForm;
    }
}

