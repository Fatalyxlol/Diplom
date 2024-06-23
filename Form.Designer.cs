namespace Kangaroo
{
    partial class Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.colorDraw = new System.Windows.Forms.Panel();
            this.colorDialogDraw = new System.Windows.Forms.ColorDialog();
            this.colorGrid = new System.Windows.Forms.Panel();
            this.colorDialogGrid = new System.Windows.Forms.ColorDialog();
            this.checkBoxGrid = new System.Windows.Forms.CheckBox();
            this.textBox = new System.Windows.Forms.RichTextBox();
            this.countGrid = new System.Windows.Forms.TextBox();
            this.f1 = new System.Windows.Forms.Button();
            this.f2 = new System.Windows.Forms.Button();
            this.f3 = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.load = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.f4 = new System.Windows.Forms.Button();
            this.f5 = new System.Windows.Forms.Button();
            this.f6 = new System.Windows.Forms.Button();
            this.f7 = new System.Windows.Forms.Button();
            this.panelForProgrammer = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.f9 = new System.Windows.Forms.Button();
            this.f8 = new System.Windows.Forms.Button();
            this.checkBoxProgrammer = new System.Windows.Forms.CheckBox();
            this.step = new System.Windows.Forms.TextBox();
            this.checkBoxArrow = new System.Windows.Forms.CheckBox();
            this.buttonRun = new System.Windows.Forms.Button();
            this.buttonResult = new System.Windows.Forms.Button();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelNumber = new System.Windows.Forms.Panel();
            this.okButton = new System.Windows.Forms.Button();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.panelEdges = new System.Windows.Forms.Panel();
            this.isNotEdge = new System.Windows.Forms.Button();
            this.isEdge = new System.Windows.Forms.Button();
            this.buttonCount = new System.Windows.Forms.Button();
            this.buttonCross = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.res = new System.Windows.Forms.Button();
            this.run = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonUnity = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panelForProgrammer.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.panelNumber.SuspendLayout();
            this.panelEdges.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox.Location = new System.Drawing.Point(302, 99);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(809, 845);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxMouseClick);
            // 
            // colorDraw
            // 
            this.colorDraw.BackColor = System.Drawing.Color.White;
            this.colorDraw.Location = new System.Drawing.Point(222, 15);
            this.colorDraw.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.colorDraw.Name = "colorDraw";
            this.colorDraw.Size = new System.Drawing.Size(33, 38);
            this.colorDraw.TabIndex = 1;
            this.colorDraw.MouseClick += new System.Windows.Forms.MouseEventHandler(this.colorDraw_MouseClick);
            // 
            // colorGrid
            // 
            this.colorGrid.BackColor = System.Drawing.Color.White;
            this.colorGrid.Location = new System.Drawing.Point(262, 15);
            this.colorGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.colorGrid.Name = "colorGrid";
            this.colorGrid.Size = new System.Drawing.Size(33, 38);
            this.colorGrid.TabIndex = 2;
            this.colorGrid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.colorGrid_MouseClick);
            // 
            // checkBoxGrid
            // 
            this.checkBoxGrid.AutoSize = true;
            this.checkBoxGrid.Checked = true;
            this.checkBoxGrid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxGrid.ForeColor = System.Drawing.Color.Coral;
            this.checkBoxGrid.Location = new System.Drawing.Point(15, 45);
            this.checkBoxGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxGrid.Name = "checkBoxGrid";
            this.checkBoxGrid.Size = new System.Drawing.Size(109, 24);
            this.checkBoxGrid.TabIndex = 3;
            this.checkBoxGrid.Text = "Grid Mode";
            this.checkBoxGrid.UseVisualStyleBackColor = true;
            this.checkBoxGrid.CheckedChanged += new System.EventHandler(this.checkBoxGrid_CheckedChanged);
            // 
            // textBox
            // 
            this.textBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBox.Location = new System.Drawing.Point(3, 2);
            this.textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(279, 574);
            this.textBox.TabIndex = 5;
            this.textBox.Text = "";
            this.textBox.Visible = false;
            // 
            // countGrid
            // 
            this.countGrid.Location = new System.Drawing.Point(14, 138);
            this.countGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.countGrid.MaxLength = 10;
            this.countGrid.Name = "countGrid";
            this.countGrid.Size = new System.Drawing.Size(112, 26);
            this.countGrid.TabIndex = 6;
            this.countGrid.Text = "7";
            this.countGrid.TextChanged += new System.EventHandler(this.countGrid_TextChanged);
            // 
            // f1
            // 
            this.f1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.f1.Location = new System.Drawing.Point(0, 46);
            this.f1.Margin = new System.Windows.Forms.Padding(1);
            this.f1.Name = "f1";
            this.f1.Size = new System.Drawing.Size(84, 38);
            this.f1.TabIndex = 7;
            this.f1.Text = "Вперёд";
            this.f1.UseVisualStyleBackColor = true;
            this.f1.Click += new System.EventHandler(this.f1_Click);
            // 
            // f2
            // 
            this.f2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.f2.Location = new System.Drawing.Point(87, 46);
            this.f2.Margin = new System.Windows.Forms.Padding(1);
            this.f2.Name = "f2";
            this.f2.Size = new System.Drawing.Size(84, 38);
            this.f2.TabIndex = 8;
            this.f2.Text = "Прыжок";
            this.f2.UseVisualStyleBackColor = true;
            this.f2.Click += new System.EventHandler(this.f2_Click);
            // 
            // f3
            // 
            this.f3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.f3.Location = new System.Drawing.Point(173, 46);
            this.f3.Margin = new System.Windows.Forms.Padding(1);
            this.f3.Name = "f3";
            this.f3.Size = new System.Drawing.Size(94, 38);
            this.f3.TabIndex = 9;
            this.f3.Text = "Направо";
            this.f3.UseVisualStyleBackColor = true;
            this.f3.Click += new System.EventHandler(this.f3_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(0, 690);
            this.save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(63, 29);
            this.save.TabIndex = 10;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // load
            // 
            this.load.Location = new System.Drawing.Point(70, 690);
            this.load.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(63, 29);
            this.load.TabIndex = 11;
            this.load.Text = "Load";
            this.load.UseVisualStyleBackColor = true;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(164, 60);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(132, 29);
            this.buttonClear.TabIndex = 12;
            this.buttonClear.Text = "Очистка";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // f4
            // 
            this.f4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.f4.Location = new System.Drawing.Point(0, 46);
            this.f4.Margin = new System.Windows.Forms.Padding(1);
            this.f4.Name = "f4";
            this.f4.Size = new System.Drawing.Size(84, 38);
            this.f4.TabIndex = 13;
            this.f4.Text = "Повтори";
            this.f4.UseVisualStyleBackColor = true;
            this.f4.Click += new System.EventHandler(this.f4_Click);
            // 
            // f5
            // 
            this.f5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.f5.Location = new System.Drawing.Point(87, 46);
            this.f5.Margin = new System.Windows.Forms.Padding(1);
            this.f5.Name = "f5";
            this.f5.Size = new System.Drawing.Size(84, 38);
            this.f5.TabIndex = 14;
            this.f5.Text = "Конец";
            this.f5.UseVisualStyleBackColor = true;
            this.f5.Click += new System.EventHandler(this.f5_Click);
            // 
            // f6
            // 
            this.f6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.f6.Location = new System.Drawing.Point(173, 46);
            this.f6.Margin = new System.Windows.Forms.Padding(1);
            this.f6.Name = "f6";
            this.f6.Size = new System.Drawing.Size(84, 38);
            this.f6.TabIndex = 15;
            this.f6.Text = "Если";
            this.f6.UseVisualStyleBackColor = true;
            this.f6.Click += new System.EventHandler(this.f6_Click);
            // 
            // f7
            // 
            this.f7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.f7.Location = new System.Drawing.Point(260, 46);
            this.f7.Margin = new System.Windows.Forms.Padding(1);
            this.f7.Name = "f7";
            this.f7.Size = new System.Drawing.Size(84, 38);
            this.f7.TabIndex = 16;
            this.f7.Text = "Иначе";
            this.f7.UseVisualStyleBackColor = true;
            this.f7.Click += new System.EventHandler(this.f7_Click);
            // 
            // panelForProgrammer
            // 
            this.panelForProgrammer.Controls.Add(this.label8);
            this.panelForProgrammer.Controls.Add(this.label7);
            this.panelForProgrammer.Controls.Add(this.label6);
            this.panelForProgrammer.Controls.Add(this.label5);
            this.panelForProgrammer.Controls.Add(this.label4);
            this.panelForProgrammer.Controls.Add(this.f4);
            this.panelForProgrammer.Controls.Add(this.f5);
            this.panelForProgrammer.Controls.Add(this.f6);
            this.panelForProgrammer.Controls.Add(this.f9);
            this.panelForProgrammer.Controls.Add(this.f7);
            this.panelForProgrammer.Controls.Add(this.f8);
            this.panelForProgrammer.Location = new System.Drawing.Point(272, 0);
            this.panelForProgrammer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelForProgrammer.Name = "panelForProgrammer";
            this.panelForProgrammer.Size = new System.Drawing.Size(537, 84);
            this.panelForProgrammer.TabIndex = 17;
            this.panelForProgrammer.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(371, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 25);
            this.label8.TabIndex = 28;
            this.label8.Text = "F8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(285, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 25);
            this.label7.TabIndex = 27;
            this.label7.Text = "F7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(198, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 25);
            this.label6.TabIndex = 26;
            this.label6.Text = "F6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(114, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 25);
            this.label5.TabIndex = 25;
            this.label5.Text = "F5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(27, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 25);
            this.label4.TabIndex = 24;
            this.label4.Text = "F4";
            // 
            // f9
            // 
            this.f9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.f9.Location = new System.Drawing.Point(433, 46);
            this.f9.Margin = new System.Windows.Forms.Padding(1);
            this.f9.Name = "f9";
            this.f9.Size = new System.Drawing.Size(84, 38);
            this.f9.TabIndex = 20;
            this.f9.Text = "F9";
            this.f9.UseVisualStyleBackColor = true;
            this.f9.Visible = false;
            // 
            // f8
            // 
            this.f8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.f8.Location = new System.Drawing.Point(346, 46);
            this.f8.Margin = new System.Windows.Forms.Padding(1);
            this.f8.Name = "f8";
            this.f8.Size = new System.Drawing.Size(84, 38);
            this.f8.TabIndex = 17;
            this.f8.Text = "Пока";
            this.f8.UseVisualStyleBackColor = true;
            this.f8.Click += new System.EventHandler(this.f8_Click);
            // 
            // checkBoxProgrammer
            // 
            this.checkBoxProgrammer.AutoSize = true;
            this.checkBoxProgrammer.ForeColor = System.Drawing.Color.Coral;
            this.checkBoxProgrammer.Location = new System.Drawing.Point(14, 12);
            this.checkBoxProgrammer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxProgrammer.Name = "checkBoxProgrammer";
            this.checkBoxProgrammer.Size = new System.Drawing.Size(122, 24);
            this.checkBoxProgrammer.TabIndex = 18;
            this.checkBoxProgrammer.Text = "Programmer";
            this.checkBoxProgrammer.UseVisualStyleBackColor = true;
            this.checkBoxProgrammer.CheckedChanged += new System.EventHandler(this.checkBoxProgrammer_CheckedChanged);
            // 
            // step
            // 
            this.step.Location = new System.Drawing.Point(14, 105);
            this.step.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.step.MaxLength = 10;
            this.step.Name = "step";
            this.step.Size = new System.Drawing.Size(112, 26);
            this.step.TabIndex = 19;
            this.step.Text = "1";
            this.step.TextChanged += new System.EventHandler(this.step_TextChanged);
            // 
            // checkBoxArrow
            // 
            this.checkBoxArrow.AutoSize = true;
            this.checkBoxArrow.ForeColor = System.Drawing.Color.Coral;
            this.checkBoxArrow.Location = new System.Drawing.Point(15, 75);
            this.checkBoxArrow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxArrow.Name = "checkBoxArrow";
            this.checkBoxArrow.Size = new System.Drawing.Size(120, 24);
            this.checkBoxArrow.TabIndex = 20;
            this.checkBoxArrow.Text = "Arrow Mode";
            this.checkBoxArrow.UseVisualStyleBackColor = true;
            this.checkBoxArrow.Visible = false;
            this.checkBoxArrow.CheckedChanged += new System.EventHandler(this.checkBoxArrow_CheckedChanged);
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(150, 690);
            this.buttonRun.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(63, 29);
            this.buttonRun.TabIndex = 21;
            this.buttonRun.Text = "Run";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // buttonResult
            // 
            this.buttonResult.Location = new System.Drawing.Point(219, 690);
            this.buttonResult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(63, 29);
            this.buttonResult.TabIndex = 22;
            this.buttonResult.Text = "Res";
            this.buttonResult.UseVisualStyleBackColor = true;
            this.buttonResult.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.label3);
            this.panelButtons.Controls.Add(this.label2);
            this.panelButtons.Controls.Add(this.label1);
            this.panelButtons.Controls.Add(this.f1);
            this.panelButtons.Controls.Add(this.f2);
            this.panelButtons.Controls.Add(this.f3);
            this.panelButtons.Controls.Add(this.panelForProgrammer);
            this.panelButtons.Location = new System.Drawing.Point(312, 9);
            this.panelButtons.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(809, 84);
            this.panelButtons.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(207, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 25);
            this.label3.TabIndex = 23;
            this.label3.Text = "F3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(112, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "F2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "F1";
            // 
            // panelNumber
            // 
            this.panelNumber.Controls.Add(this.okButton);
            this.panelNumber.Controls.Add(this.textBoxNumber);
            this.panelNumber.Location = new System.Drawing.Point(312, 15);
            this.panelNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelNumber.Name = "panelNumber";
            this.panelNumber.Size = new System.Drawing.Size(258, 38);
            this.panelNumber.TabIndex = 24;
            this.panelNumber.Visible = false;
            // 
            // okButton
            // 
            this.okButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.okButton.Location = new System.Drawing.Point(156, -2);
            this.okButton.Margin = new System.Windows.Forms.Padding(1);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(84, 38);
            this.okButton.TabIndex = 21;
            this.okButton.Text = "Ок";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(14, 2);
            this.textBoxNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNumber.MaxLength = 10;
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(112, 26);
            this.textBoxNumber.TabIndex = 25;
            this.textBoxNumber.Text = "1";
            // 
            // panelEdges
            // 
            this.panelEdges.Controls.Add(this.isNotEdge);
            this.panelEdges.Controls.Add(this.isEdge);
            this.panelEdges.Location = new System.Drawing.Point(576, 15);
            this.panelEdges.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelEdges.Name = "panelEdges";
            this.panelEdges.Size = new System.Drawing.Size(354, 38);
            this.panelEdges.TabIndex = 24;
            this.panelEdges.Visible = false;
            // 
            // isNotEdge
            // 
            this.isNotEdge.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.isNotEdge.Location = new System.Drawing.Point(168, 0);
            this.isNotEdge.Margin = new System.Windows.Forms.Padding(1);
            this.isNotEdge.Name = "isNotEdge";
            this.isNotEdge.Size = new System.Drawing.Size(165, 38);
            this.isNotEdge.TabIndex = 22;
            this.isNotEdge.Text = "впереди не край";
            this.isNotEdge.UseVisualStyleBackColor = true;
            this.isNotEdge.Click += new System.EventHandler(this.isEdge_Click);
            // 
            // isEdge
            // 
            this.isEdge.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.isEdge.Location = new System.Drawing.Point(0, 0);
            this.isEdge.Margin = new System.Windows.Forms.Padding(1);
            this.isEdge.Name = "isEdge";
            this.isEdge.Size = new System.Drawing.Size(165, 38);
            this.isEdge.TabIndex = 21;
            this.isEdge.Text = "впереди край";
            this.isEdge.UseVisualStyleBackColor = true;
            this.isEdge.Click += new System.EventHandler(this.isEdge_Click);
            // 
            // buttonCount
            // 
            this.buttonCount.Location = new System.Drawing.Point(164, 131);
            this.buttonCount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCount.Name = "buttonCount";
            this.buttonCount.Size = new System.Drawing.Size(130, 29);
            this.buttonCount.TabIndex = 25;
            this.buttonCount.Text = "Подсчет";
            this.buttonCount.UseVisualStyleBackColor = true;
            this.buttonCount.Click += new System.EventHandler(this.buttonCount_Click);
            // 
            // buttonCross
            // 
            this.buttonCross.Location = new System.Drawing.Point(164, 95);
            this.buttonCross.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCross.Name = "buttonCross";
            this.buttonCross.Size = new System.Drawing.Size(130, 29);
            this.buttonCross.TabIndex = 26;
            this.buttonCross.Text = "Пересечение";
            this.buttonCross.UseVisualStyleBackColor = true;
            this.buttonCross.Click += new System.EventHandler(this.buttonCross_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.res);
            this.panel1.Controls.Add(this.run);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox);
            this.panel1.Controls.Add(this.buttonResult);
            this.panel1.Controls.Add(this.save);
            this.panel1.Controls.Add(this.load);
            this.panel1.Controls.Add(this.buttonRun);
            this.panel1.Location = new System.Drawing.Point(14, 208);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 684);
            this.panel1.TabIndex = 27;
            this.panel1.Visible = false;
            // 
            // res
            // 
            this.res.Location = new System.Drawing.Point(139, 634);
            this.res.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.res.Name = "res";
            this.res.Size = new System.Drawing.Size(110, 44);
            this.res.TabIndex = 26;
            this.res.Text = "Результат";
            this.res.UseVisualStyleBackColor = true;
            this.res.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // run
            // 
            this.run.Location = new System.Drawing.Point(23, 634);
            this.run.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(110, 44);
            this.run.TabIndex = 25;
            this.run.Text = "Пуск";
            this.run.UseVisualStyleBackColor = true;
            this.run.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(139, 582);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 44);
            this.button2.TabIndex = 24;
            this.button2.Text = "Загрузка";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.load_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 582);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 44);
            this.button1.TabIndex = 23;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.save_Click);
            // 
            // buttonUnity
            // 
            this.buttonUnity.Location = new System.Drawing.Point(164, 168);
            this.buttonUnity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonUnity.Name = "buttonUnity";
            this.buttonUnity.Size = new System.Drawing.Size(132, 29);
            this.buttonUnity.TabIndex = 28;
            this.buttonUnity.Text = "Объединение";
            this.buttonUnity.UseVisualStyleBackColor = true;
            this.buttonUnity.Click += new System.EventHandler(this.buttonUnity_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1127, 906);
            this.Controls.Add(this.buttonUnity);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonCross);
            this.Controls.Add(this.buttonCount);
            this.Controls.Add(this.panelNumber);
            this.Controls.Add(this.panelEdges);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.checkBoxArrow);
            this.Controls.Add(this.step);
            this.Controls.Add(this.checkBoxProgrammer);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.countGrid);
            this.Controls.Add(this.checkBoxGrid);
            this.Controls.Add(this.colorGrid);
            this.Controls.Add(this.colorDraw);
            this.Controls.Add(this.pictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form";
            this.Text = "Kangaroo";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panelForProgrammer.ResumeLayout(false);
            this.panelForProgrammer.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.panelButtons.PerformLayout();
            this.panelNumber.ResumeLayout(false);
            this.panelNumber.PerformLayout();
            this.panelEdges.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Panel colorDraw;
        private System.Windows.Forms.ColorDialog colorDialogDraw;
        private System.Windows.Forms.Panel colorGrid;
        private System.Windows.Forms.ColorDialog colorDialogGrid;
        private System.Windows.Forms.CheckBox checkBoxGrid;
        private System.Windows.Forms.RichTextBox textBox;
        private System.Windows.Forms.TextBox countGrid;
        private System.Windows.Forms.Button f1;
        private System.Windows.Forms.Button f2;
        private System.Windows.Forms.Button f3;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button load;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button f4;
        private System.Windows.Forms.Button f5;
        private System.Windows.Forms.Button f6;
        private System.Windows.Forms.Button f7;
        private System.Windows.Forms.Panel panelForProgrammer;
        private System.Windows.Forms.CheckBox checkBoxProgrammer;
        private System.Windows.Forms.TextBox step;
        private System.Windows.Forms.Button f8;
        private System.Windows.Forms.Button f9;
        private System.Windows.Forms.CheckBox checkBoxArrow;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.Button buttonResult;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Panel panelNumber;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Panel panelEdges;
        private System.Windows.Forms.Button isNotEdge;
        private System.Windows.Forms.Button isEdge;
        private System.Windows.Forms.Button buttonCount;
        private System.Windows.Forms.Button buttonCross;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonUnity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button res;
        private System.Windows.Forms.Button run;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

