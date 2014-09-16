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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnSetTestData = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnAddSeans = new System.Windows.Forms.Button();
			this.tbNewSeans = new System.Windows.Forms.TextBox();
			this.contextMenuStrip1.SuspendLayout();
			this.groupBox2.SuspendLayout();
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
            this.добавитьСеансToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(277, 104);
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
			// groupBox1
			// 
			this.groupBox1.Location = new System.Drawing.Point(131, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(370, 238);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Зал";
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
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(520, 303);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.btnSetTestData);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lbSeansList);
			this.Name = "Form1";
			this.Text = "Кинотеатр.";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.Load += new System.EventHandler(this.Main_Load);
			this.contextMenuStrip1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbSeansList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
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
    }
}

