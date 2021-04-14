namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.TopsLabel = new System.Windows.Forms.Label();
            this.PreDrawTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.PenColorButton = new System.Windows.Forms.Button();
            this.PenColorPanel = new System.Windows.Forms.Panel();
            this.FillColorButton = new System.Windows.Forms.Button();
            this.FillColorPanel = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PenWidthBar = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.гавнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.undo = new System.Windows.Forms.Button();
            this.redo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PenWidthBar)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(13, 72);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(165, 24);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(109, 32);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(69, 22);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // TopsLabel
            // 
            this.TopsLabel.Location = new System.Drawing.Point(13, 32);
            this.TopsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TopsLabel.Name = "TopsLabel";
            this.TopsLabel.Size = new System.Drawing.Size(88, 17);
            this.TopsLabel.TabIndex = 5;
            this.TopsLabel.Text = "Вершины:";
            this.TopsLabel.Click += new System.EventHandler(this.TopsLabel_Click);
            // 
            // PreDrawTimer
            // 
            this.PreDrawTimer.Interval = 10;
            this.PreDrawTimer.Tick += new System.EventHandler(this.PreDrawTimer_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(2, 104);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1342, 508);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // PenColorButton
            // 
            this.PenColorButton.Location = new System.Drawing.Point(210, 74);
            this.PenColorButton.Margin = new System.Windows.Forms.Padding(4);
            this.PenColorButton.Name = "PenColorButton";
            this.PenColorButton.Size = new System.Drawing.Size(60, 24);
            this.PenColorButton.TabIndex = 8;
            this.PenColorButton.Text = "Цвет:";
            this.PenColorButton.UseVisualStyleBackColor = true;
            this.PenColorButton.Click += new System.EventHandler(this.PenColorButton_Click);
            // 
            // PenColorPanel
            // 
            this.PenColorPanel.BackColor = System.Drawing.Color.Black;
            this.PenColorPanel.Location = new System.Drawing.Point(269, 74);
            this.PenColorPanel.Margin = new System.Windows.Forms.Padding(4);
            this.PenColorPanel.Name = "PenColorPanel";
            this.PenColorPanel.Size = new System.Drawing.Size(29, 24);
            this.PenColorPanel.TabIndex = 9;
            this.PenColorPanel.Click += new System.EventHandler(this.PenColorButton_Click);
            this.PenColorPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.PenColorPanel_Paint);
            // 
            // FillColorButton
            // 
            this.FillColorButton.Location = new System.Drawing.Point(331, 74);
            this.FillColorButton.Margin = new System.Windows.Forms.Padding(4);
            this.FillColorButton.Name = "FillColorButton";
            this.FillColorButton.Size = new System.Drawing.Size(84, 24);
            this.FillColorButton.TabIndex = 10;
            this.FillColorButton.Text = "Заливка:";
            this.FillColorButton.UseVisualStyleBackColor = true;
            this.FillColorButton.Click += new System.EventHandler(this.FillColorButton_Click);
            // 
            // FillColorPanel
            // 
            this.FillColorPanel.BackColor = System.Drawing.Color.White;
            this.FillColorPanel.Location = new System.Drawing.Point(414, 74);
            this.FillColorPanel.Margin = new System.Windows.Forms.Padding(4);
            this.FillColorPanel.Name = "FillColorPanel";
            this.FillColorPanel.Size = new System.Drawing.Size(27, 24);
            this.FillColorPanel.TabIndex = 10;
            this.FillColorPanel.Click += new System.EventHandler(this.FillColorButton_Click);
            // 
            // PenWidthBar
            // 
            this.PenWidthBar.Cursor = System.Windows.Forms.Cursors.Default;
            this.PenWidthBar.Location = new System.Drawing.Point(504, 42);
            this.PenWidthBar.Margin = new System.Windows.Forms.Padding(4);
            this.PenWidthBar.Maximum = 50;
            this.PenWidthBar.Minimum = 5;
            this.PenWidthBar.Name = "PenWidthBar";
            this.PenWidthBar.Size = new System.Drawing.Size(227, 56);
            this.PenWidthBar.TabIndex = 10;
            this.PenWidthBar.TickFrequency = 5;
            this.PenWidthBar.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.PenWidthBar.Value = 6;
            this.PenWidthBar.Scroll += new System.EventHandler(this.PenWidthBar_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(514, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Толщина линий:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Фигуры:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.гавнаяToolStripMenuItem,
            this.видToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1344, 28);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новыйToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // новыйToolStripMenuItem
            // 
            this.новыйToolStripMenuItem.Name = "новыйToolStripMenuItem";
            this.новыйToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.новыйToolStripMenuItem.Text = "Новый";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.открытьToolStripMenuItem.Text = "Открыть";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как";
            // 
            // гавнаяToolStripMenuItem
            // 
            this.гавнаяToolStripMenuItem.Name = "гавнаяToolStripMenuItem";
            this.гавнаяToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.гавнаяToolStripMenuItem.Text = "Главная";
            // 
            // видToolStripMenuItem
            // 
            this.видToolStripMenuItem.Name = "видToolStripMenuItem";
            this.видToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.видToolStripMenuItem.Text = "Вид";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(210, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 27);
            this.button1.TabIndex = 15;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // undo
            // 
            this.undo.Location = new System.Drawing.Point(738, 79);
            this.undo.Name = "undo";
            this.undo.Size = new System.Drawing.Size(75, 23);
            this.undo.TabIndex = 16;
            this.undo.Text = "undo";
            this.undo.UseVisualStyleBackColor = true;
            this.undo.Click += new System.EventHandler(this.undo_Click);
            // 
            // redo
            // 
            this.redo.Location = new System.Drawing.Point(819, 79);
            this.redo.Name = "redo";
            this.redo.Size = new System.Drawing.Size(75, 23);
            this.redo.TabIndex = 17;
            this.redo.Text = "redo";
            this.redo.UseVisualStyleBackColor = true;
            this.redo.Click += new System.EventHandler(this.redo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 506);
            this.Controls.Add(this.redo);
            this.Controls.Add(this.undo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.TopsLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FillColorPanel);
            this.Controls.Add(this.FillColorButton);
            this.Controls.Add(this.PenColorPanel);
            this.Controls.Add(this.PenColorButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.PenWidthBar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PenWidthBar)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label TopsLabel;
        private System.Windows.Forms.Timer PreDrawTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button PenColorButton;
        private System.Windows.Forms.Panel PenColorPanel;
        private System.Windows.Forms.Button FillColorButton;
        private System.Windows.Forms.Panel FillColorPanel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar PenWidthBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новыйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem гавнаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button undo;
        private System.Windows.Forms.Button redo;
    }
}

