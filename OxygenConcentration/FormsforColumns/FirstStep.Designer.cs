namespace OxygenConcentration.FormsforColumns
{
    partial class FirstStep
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstStep));
            this.Titlecubetor = new System.Windows.Forms.Label();
            this.chartct = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonCalculatect = new System.Windows.Forms.Button();
            this.buttonClearct = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxIntimect = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDayct = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxKonecCct = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCzasytkict = new System.Windows.Forms.TextBox();
            this.textBoxBeginCct = new System.Windows.Forms.TextBox();
            this.labelVct = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonDrawct = new System.Windows.Forms.Button();
            this.trackBarDaysCT = new System.Windows.Forms.TrackBar();
            this.buttonScreenshot = new System.Windows.Forms.Button();
            this.Titlehightank = new System.Windows.Forms.Label();
            this.Calculatebutton = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.trackBarDaysVR = new System.Windows.Forms.TrackBar();
            this.chartvr = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxvr = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelEdC = new System.Windows.Forms.Label();
            this.textBoxInTime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxDays = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxdCkonec = new System.Windows.Forms.TextBox();
            this.labeldckonec = new System.Windows.Forms.Label();
            this.textBoxdCzasutki = new System.Windows.Forms.TextBox();
            this.textBoxBeginC = new System.Windows.Forms.TextBox();
            this.Vhightank = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DeltaConcentration = new System.Windows.Forms.Label();
            this.buttondrawgraph = new System.Windows.Forms.Button();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.chartct)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDaysCT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDaysVR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartvr)).BeginInit();
            this.groupBoxvr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // Titlecubetor
            // 
            this.Titlecubetor.AutoSize = true;
            this.Titlecubetor.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Titlecubetor.Location = new System.Drawing.Point(189, 18);
            this.Titlecubetor.Margin = new System.Windows.Forms.Padding(0);
            this.Titlecubetor.Name = "Titlecubetor";
            this.Titlecubetor.Size = new System.Drawing.Size(68, 19);
            this.Titlecubetor.TabIndex = 70;
            this.Titlecubetor.Text = "Куб+Тор";
            // 
            // chartct
            // 
            chartArea1.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea1.AxisX.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Days;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.Title = "День цикла";
            chartArea1.AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.AxisY.Title = "Концентрация";
            chartArea1.Name = "ChartArea1";
            this.chartct.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartct.Legends.Add(legend1);
            this.chartct.Location = new System.Drawing.Point(424, 39);
            this.chartct.Margin = new System.Windows.Forms.Padding(0);
            this.chartct.Name = "chartct";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Blue;
            series1.IsValueShownAsLabel = true;
            series1.LabelBackColor = System.Drawing.Color.White;
            series1.LabelBorderColor = System.Drawing.Color.Black;
            series1.LabelFormat = "F3";
            series1.LabelToolTip = "#VALX{D}";
            series1.Legend = "Legend1";
            series1.MarkerColor = System.Drawing.Color.Red;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "ΔC";
            this.chartct.Series.Add(series1);
            this.chartct.Size = new System.Drawing.Size(436, 253);
            this.chartct.TabIndex = 71;
            this.chartct.Text = "chart1";
            // 
            // buttonCalculatect
            // 
            this.buttonCalculatect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonCalculatect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCalculatect.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCalculatect.Location = new System.Drawing.Point(39, 287);
            this.buttonCalculatect.Margin = new System.Windows.Forms.Padding(0);
            this.buttonCalculatect.Name = "buttonCalculatect";
            this.buttonCalculatect.Size = new System.Drawing.Size(106, 37);
            this.buttonCalculatect.TabIndex = 72;
            this.buttonCalculatect.Text = "Рассчитать";
            this.buttonCalculatect.UseVisualStyleBackColor = false;
            this.buttonCalculatect.Click += new System.EventHandler(this.buttonCalculatect_Click);
            // 
            // buttonClearct
            // 
            this.buttonClearct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonClearct.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClearct.Location = new System.Drawing.Point(304, 287);
            this.buttonClearct.Margin = new System.Windows.Forms.Padding(0);
            this.buttonClearct.Name = "buttonClearct";
            this.buttonClearct.Size = new System.Drawing.Size(106, 37);
            this.buttonClearct.TabIndex = 73;
            this.buttonClearct.Text = "Очистить";
            this.buttonClearct.UseVisualStyleBackColor = false;
            this.buttonClearct.Click += new System.EventHandler(this.buttonClearct_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.textBoxIntimect);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxDayct);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxKonecCct);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxCzasytkict);
            this.groupBox1.Controls.Add(this.textBoxBeginCct);
            this.groupBox1.Controls.Add(this.labelVct);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(39, 39);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(371, 245);
            this.groupBox1.TabIndex = 74;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(290, 185);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 19);
            this.label12.TabIndex = 69;
            this.label12.Text = "ат. %";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(290, 154);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 19);
            this.label13.TabIndex = 68;
            this.label13.Text = "ат. %";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(290, 116);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 19);
            this.label14.TabIndex = 67;
            this.label14.Text = "ат. %";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(290, 82);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 19);
            this.label15.TabIndex = 66;
            this.label15.Text = "ат. %";
            // 
            // textBoxIntimect
            // 
            this.textBoxIntimect.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxIntimect.Location = new System.Drawing.Point(224, 183);
            this.textBoxIntimect.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxIntimect.Name = "textBoxIntimect";
            this.textBoxIntimect.Size = new System.Drawing.Size(65, 26);
            this.textBoxIntimect.TabIndex = 61;
            this.textBoxIntimect.TextChanged += new System.EventHandler(this.textBoxIntimect_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(123, 183);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 19);
            this.label2.TabIndex = 60;
            this.label2.Text = "C текущая=";
            // 
            // textBoxDayct
            // 
            this.textBoxDayct.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDayct.Location = new System.Drawing.Point(224, 45);
            this.textBoxDayct.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxDayct.Name = "textBoxDayct";
            this.textBoxDayct.Size = new System.Drawing.Size(65, 26);
            this.textBoxDayct.TabIndex = 56;
            this.textBoxDayct.Text = "2";
            this.textBoxDayct.TextChanged += new System.EventHandler(this.textBoxDayct_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(112, 47);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 19);
            this.label3.TabIndex = 55;
            this.label3.Text = "День  цикла=";
            // 
            // textBoxKonecCct
            // 
            this.textBoxKonecCct.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxKonecCct.Location = new System.Drawing.Point(224, 116);
            this.textBoxKonecCct.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxKonecCct.Name = "textBoxKonecCct";
            this.textBoxKonecCct.Size = new System.Drawing.Size(65, 26);
            this.textBoxKonecCct.TabIndex = 52;
            this.textBoxKonecCct.Text = "0,8";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(106, 116);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 19);
            this.label4.TabIndex = 51;
            this.label4.Text = "ΔC конечная=";
            // 
            // textBoxCzasytkict
            // 
            this.textBoxCzasytkict.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCzasytkict.Location = new System.Drawing.Point(224, 151);
            this.textBoxCzasytkict.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxCzasytkict.Name = "textBoxCzasytkict";
            this.textBoxCzasytkict.Size = new System.Drawing.Size(65, 26);
            this.textBoxCzasytkict.TabIndex = 49;
            this.textBoxCzasytkict.Text = "-0,1667";
            this.textBoxCzasytkict.TextChanged += new System.EventHandler(this.textBoxCzasytkict_TextChanged);
            // 
            // textBoxBeginCct
            // 
            this.textBoxBeginCct.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxBeginCct.Location = new System.Drawing.Point(224, 80);
            this.textBoxBeginCct.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxBeginCct.Name = "textBoxBeginCct";
            this.textBoxBeginCct.Size = new System.Drawing.Size(65, 26);
            this.textBoxBeginCct.TabIndex = 48;
            this.textBoxBeginCct.Text = "0,7";
            // 
            // labelVct
            // 
            this.labelVct.AutoSize = true;
            this.labelVct.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVct.Location = new System.Drawing.Point(11, 26);
            this.labelVct.Margin = new System.Windows.Forms.Padding(0);
            this.labelVct.Name = "labelVct";
            this.labelVct.Size = new System.Drawing.Size(54, 19);
            this.labelVct.TabIndex = 44;
            this.labelVct.Text = "V=30л";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(132, 154);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 19);
            this.label8.TabIndex = 47;
            this.label8.Text = "ΔC за сут.=";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(100, 82);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 19);
            this.label9.TabIndex = 46;
            this.label9.Text = "ΔC начальная=";
            // 
            // buttonDrawct
            // 
            this.buttonDrawct.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonDrawct.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDrawct.Location = new System.Drawing.Point(142, 287);
            this.buttonDrawct.Margin = new System.Windows.Forms.Padding(0);
            this.buttonDrawct.Name = "buttonDrawct";
            this.buttonDrawct.Size = new System.Drawing.Size(172, 37);
            this.buttonDrawct.TabIndex = 75;
            this.buttonDrawct.Text = "Построить график";
            this.buttonDrawct.UseVisualStyleBackColor = false;
            this.buttonDrawct.Click += new System.EventHandler(this.buttonDrawct_Click);
            // 
            // trackBarDaysCT
            // 
            this.trackBarDaysCT.AccessibleRole = System.Windows.Forms.AccessibleRole.ProgressBar;
            this.trackBarDaysCT.BackColor = System.Drawing.Color.White;
            this.trackBarDaysCT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBarDaysCT.LargeChange = 1;
            this.trackBarDaysCT.Location = new System.Drawing.Point(424, 292);
            this.trackBarDaysCT.Margin = new System.Windows.Forms.Padding(0);
            this.trackBarDaysCT.Maximum = 6;
            this.trackBarDaysCT.Minimum = 1;
            this.trackBarDaysCT.Name = "trackBarDaysCT";
            this.trackBarDaysCT.Size = new System.Drawing.Size(436, 45);
            this.trackBarDaysCT.TabIndex = 76;
            this.trackBarDaysCT.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBarDaysCT.Value = 1;
            this.trackBarDaysCT.Scroll += new System.EventHandler(this.trackBarDaysCT_Scroll);
            // 
            // buttonScreenshot
            // 
            this.buttonScreenshot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonScreenshot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonScreenshot.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonScreenshot.Location = new System.Drawing.Point(266, 345);
            this.buttonScreenshot.Margin = new System.Windows.Forms.Padding(0);
            this.buttonScreenshot.Name = "buttonScreenshot";
            this.buttonScreenshot.Size = new System.Drawing.Size(292, 41);
            this.buttonScreenshot.TabIndex = 127;
            this.buttonScreenshot.Text = "Сделать скриншот";
            this.buttonScreenshot.UseVisualStyleBackColor = false;
            this.buttonScreenshot.Click += new System.EventHandler(this.buttonScreenshot_Click);
            // 
            // Titlehightank
            // 
            this.Titlehightank.AutoSize = true;
            this.Titlehightank.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Titlehightank.Location = new System.Drawing.Point(187, 19);
            this.Titlehightank.Margin = new System.Windows.Forms.Padding(0);
            this.Titlehightank.Name = "Titlehightank";
            this.Titlehightank.Size = new System.Drawing.Size(30, 19);
            this.Titlehightank.TabIndex = 65;
            this.Titlehightank.Text = "ВР";
            // 
            // Calculatebutton
            // 
            this.Calculatebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Calculatebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Calculatebutton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Calculatebutton.Location = new System.Drawing.Point(39, 288);
            this.Calculatebutton.Margin = new System.Windows.Forms.Padding(0);
            this.Calculatebutton.Name = "Calculatebutton";
            this.Calculatebutton.Size = new System.Drawing.Size(106, 37);
            this.Calculatebutton.TabIndex = 66;
            this.Calculatebutton.Text = "Рассчитать";
            this.Calculatebutton.UseVisualStyleBackColor = false;
            this.Calculatebutton.Click += new System.EventHandler(this.Calculatebutton_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClear.Location = new System.Drawing.Point(304, 288);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(0);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(106, 37);
            this.buttonClear.TabIndex = 67;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // trackBarDaysVR
            // 
            this.trackBarDaysVR.AccessibleRole = System.Windows.Forms.AccessibleRole.ProgressBar;
            this.trackBarDaysVR.BackColor = System.Drawing.Color.White;
            this.trackBarDaysVR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBarDaysVR.LargeChange = 1;
            this.trackBarDaysVR.Location = new System.Drawing.Point(424, 288);
            this.trackBarDaysVR.Margin = new System.Windows.Forms.Padding(0);
            this.trackBarDaysVR.Maximum = 6;
            this.trackBarDaysVR.Minimum = 1;
            this.trackBarDaysVR.Name = "trackBarDaysVR";
            this.trackBarDaysVR.Size = new System.Drawing.Size(436, 45);
            this.trackBarDaysVR.TabIndex = 68;
            this.trackBarDaysVR.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBarDaysVR.Value = 1;
            this.trackBarDaysVR.Scroll += new System.EventHandler(this.trackBarDaysVR_Scroll);
            // 
            // chartvr
            // 
            chartArea2.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea2.AxisX.IsLabelAutoFit = false;
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisX.Title = "День цикла";
            chartArea2.AxisX2.LabelStyle.Format = "F3";
            chartArea2.AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea2.AxisY.MajorGrid.Enabled = false;
            chartArea2.AxisY.Title = "Концентрация";
            chartArea2.BackColor = System.Drawing.Color.White;
            chartArea2.Name = "ChartArea1";
            this.chartvr.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartvr.Legends.Add(legend2);
            this.chartvr.Location = new System.Drawing.Point(424, 40);
            this.chartvr.Margin = new System.Windows.Forms.Padding(0);
            this.chartvr.Name = "chartvr";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.Blue;
            series2.CustomProperties = "IsXAxisQuantitative=True";
            series2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series2.IsValueShownAsLabel = true;
            series2.LabelBackColor = System.Drawing.Color.White;
            series2.LabelBorderColor = System.Drawing.Color.Black;
            series2.LabelFormat = "F3";
            series2.LabelToolTip = "#VALX{D}";
            series2.Legend = "Legend1";
            series2.MarkerColor = System.Drawing.Color.Red;
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series2.Name = "ΔCвр";
            series2.SmartLabelStyle.CalloutLineAnchorCapStyle = System.Windows.Forms.DataVisualization.Charting.LineAnchorCapStyle.None;
            series2.SmartLabelStyle.IsOverlappedHidden = false;
            series2.SmartLabelStyle.MaxMovingDistance = 10D;
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.chartvr.Series.Add(series2);
            this.chartvr.Size = new System.Drawing.Size(436, 248);
            this.chartvr.TabIndex = 69;
            this.chartvr.Text = "chart";
            // 
            // groupBoxvr
            // 
            this.groupBoxvr.Controls.Add(this.label11);
            this.groupBoxvr.Controls.Add(this.label10);
            this.groupBoxvr.Controls.Add(this.label7);
            this.groupBoxvr.Controls.Add(this.labelEdC);
            this.groupBoxvr.Controls.Add(this.textBoxInTime);
            this.groupBoxvr.Controls.Add(this.label6);
            this.groupBoxvr.Controls.Add(this.textBoxDays);
            this.groupBoxvr.Controls.Add(this.label5);
            this.groupBoxvr.Controls.Add(this.textBoxdCkonec);
            this.groupBoxvr.Controls.Add(this.labeldckonec);
            this.groupBoxvr.Controls.Add(this.textBoxdCzasutki);
            this.groupBoxvr.Controls.Add(this.textBoxBeginC);
            this.groupBoxvr.Controls.Add(this.Vhightank);
            this.groupBoxvr.Controls.Add(this.label1);
            this.groupBoxvr.Controls.Add(this.DeltaConcentration);
            this.groupBoxvr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxvr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxvr.Location = new System.Drawing.Point(39, 40);
            this.groupBoxvr.Margin = new System.Windows.Forms.Padding(0);
            this.groupBoxvr.Name = "groupBoxvr";
            this.groupBoxvr.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxvr.Size = new System.Drawing.Size(371, 245);
            this.groupBoxvr.TabIndex = 70;
            this.groupBoxvr.TabStop = false;
            this.groupBoxvr.Text = "Параметры";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(288, 186);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 19);
            this.label11.TabIndex = 65;
            this.label11.Text = "ат. %";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(288, 154);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 19);
            this.label10.TabIndex = 64;
            this.label10.Text = "ат. %";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(288, 117);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 19);
            this.label7.TabIndex = 63;
            this.label7.Text = "ат. %";
            // 
            // labelEdC
            // 
            this.labelEdC.AutoSize = true;
            this.labelEdC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEdC.Location = new System.Drawing.Point(288, 83);
            this.labelEdC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEdC.Name = "labelEdC";
            this.labelEdC.Size = new System.Drawing.Size(43, 19);
            this.labelEdC.TabIndex = 62;
            this.labelEdC.Text = "ат. %";
            // 
            // textBoxInTime
            // 
            this.textBoxInTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBoxInTime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxInTime.Location = new System.Drawing.Point(222, 183);
            this.textBoxInTime.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxInTime.Name = "textBoxInTime";
            this.textBoxInTime.Size = new System.Drawing.Size(65, 26);
            this.textBoxInTime.TabIndex = 61;
            this.textBoxInTime.Text = "0,0467";
            this.textBoxInTime.TextChanged += new System.EventHandler(this.textBoxInTime_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(123, 183);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 19);
            this.label6.TabIndex = 60;
            this.label6.Text = "C текущая=";
            // 
            // textBoxDays
            // 
            this.textBoxDays.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDays.Location = new System.Drawing.Point(222, 45);
            this.textBoxDays.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxDays.Name = "textBoxDays";
            this.textBoxDays.Size = new System.Drawing.Size(65, 26);
            this.textBoxDays.TabIndex = 56;
            this.textBoxDays.Text = "2";
            this.textBoxDays.TextChanged += new System.EventHandler(this.textBoxDays_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(112, 47);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 19);
            this.label5.TabIndex = 55;
            this.label5.Text = "День  цикла=";
            // 
            // textBoxdCkonec
            // 
            this.textBoxdCkonec.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxdCkonec.Location = new System.Drawing.Point(222, 116);
            this.textBoxdCkonec.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxdCkonec.Name = "textBoxdCkonec";
            this.textBoxdCkonec.Size = new System.Drawing.Size(65, 26);
            this.textBoxdCkonec.TabIndex = 52;
            this.textBoxdCkonec.Text = "0,18";
            // 
            // labeldckonec
            // 
            this.labeldckonec.AutoSize = true;
            this.labeldckonec.BackColor = System.Drawing.Color.Transparent;
            this.labeldckonec.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labeldckonec.Location = new System.Drawing.Point(106, 116);
            this.labeldckonec.Margin = new System.Windows.Forms.Padding(0);
            this.labeldckonec.Name = "labeldckonec";
            this.labeldckonec.Size = new System.Drawing.Size(112, 19);
            this.labeldckonec.TabIndex = 51;
            this.labeldckonec.Text = "ΔC конечная=";
            // 
            // textBoxdCzasutki
            // 
            this.textBoxdCzasutki.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxdCzasutki.Location = new System.Drawing.Point(222, 151);
            this.textBoxdCzasutki.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxdCzasutki.Name = "textBoxdCzasutki";
            this.textBoxdCzasutki.Size = new System.Drawing.Size(65, 26);
            this.textBoxdCzasutki.TabIndex = 49;
            this.textBoxdCzasutki.Text = "-0,0267";
            this.textBoxdCzasutki.TextChanged += new System.EventHandler(this.textBoxdCzasutki_TextChanged);
            // 
            // textBoxBeginC
            // 
            this.textBoxBeginC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxBeginC.Location = new System.Drawing.Point(222, 80);
            this.textBoxBeginC.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxBeginC.Name = "textBoxBeginC";
            this.textBoxBeginC.Size = new System.Drawing.Size(65, 26);
            this.textBoxBeginC.TabIndex = 48;
            this.textBoxBeginC.Text = "0,02";
            // 
            // Vhightank
            // 
            this.Vhightank.AutoSize = true;
            this.Vhightank.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Vhightank.Location = new System.Drawing.Point(11, 26);
            this.Vhightank.Margin = new System.Windows.Forms.Padding(0);
            this.Vhightank.Name = "Vhightank";
            this.Vhightank.Size = new System.Drawing.Size(62, 19);
            this.Vhightank.TabIndex = 44;
            this.Vhightank.Text = "V=150л";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(132, 154);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 19);
            this.label1.TabIndex = 47;
            this.label1.Text = "ΔC за сут.=";
            // 
            // DeltaConcentration
            // 
            this.DeltaConcentration.AutoSize = true;
            this.DeltaConcentration.BackColor = System.Drawing.Color.Transparent;
            this.DeltaConcentration.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeltaConcentration.Location = new System.Drawing.Point(100, 82);
            this.DeltaConcentration.Margin = new System.Windows.Forms.Padding(0);
            this.DeltaConcentration.Name = "DeltaConcentration";
            this.DeltaConcentration.Size = new System.Drawing.Size(119, 19);
            this.DeltaConcentration.TabIndex = 46;
            this.DeltaConcentration.Text = "ΔC начальная=";
            // 
            // buttondrawgraph
            // 
            this.buttondrawgraph.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttondrawgraph.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttondrawgraph.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttondrawgraph.Location = new System.Drawing.Point(142, 288);
            this.buttondrawgraph.Margin = new System.Windows.Forms.Padding(0);
            this.buttondrawgraph.Name = "buttondrawgraph";
            this.buttondrawgraph.Size = new System.Drawing.Size(172, 37);
            this.buttondrawgraph.TabIndex = 71;
            this.buttondrawgraph.Text = "Построить график";
            this.buttondrawgraph.UseVisualStyleBackColor = false;
            this.buttondrawgraph.Click += new System.EventHandler(this.buttondrawgraph_Click);
            // 
            // splitContainer
            // 
            this.splitContainer.BackColor = System.Drawing.Color.White;
            this.splitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer.MinimumSize = new System.Drawing.Size(825, 812);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.splitContainer.Panel1.Controls.Add(this.buttondrawgraph);
            this.splitContainer.Panel1.Controls.Add(this.groupBoxvr);
            this.splitContainer.Panel1.Controls.Add(this.chartvr);
            this.splitContainer.Panel1.Controls.Add(this.trackBarDaysVR);
            this.splitContainer.Panel1.Controls.Add(this.buttonClear);
            this.splitContainer.Panel1.Controls.Add(this.Calculatebutton);
            this.splitContainer.Panel1.Controls.Add(this.Titlehightank);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.splitContainer.Panel2.Controls.Add(this.buttonScreenshot);
            this.splitContainer.Panel2.Controls.Add(this.trackBarDaysCT);
            this.splitContainer.Panel2.Controls.Add(this.buttonDrawct);
            this.splitContainer.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer.Panel2.Controls.Add(this.buttonClearct);
            this.splitContainer.Panel2.Controls.Add(this.buttonCalculatect);
            this.splitContainer.Panel2.Controls.Add(this.chartct);
            this.splitContainer.Panel2.Controls.Add(this.Titlecubetor);
            this.splitContainer.Size = new System.Drawing.Size(880, 812);
            this.splitContainer.SplitterDistance = 368;
            this.splitContainer.SplitterWidth = 3;
            this.splitContainer.TabIndex = 0;
            // 
            // FirstStep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(880, 719);
            this.Controls.Add(this.splitContainer);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(896, 675);
            this.Name = "FirstStep";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Первая ступень";
            ((System.ComponentModel.ISupportInitialize)(this.chartct)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDaysCT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDaysVR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartvr)).EndInit();
            this.groupBoxvr.ResumeLayout(false);
            this.groupBoxvr.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Titlecubetor;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartct;
        private System.Windows.Forms.Button buttonCalculatect;
        private System.Windows.Forms.Button buttonClearct;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxIntimect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDayct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxKonecCct;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCzasytkict;
        private System.Windows.Forms.TextBox textBoxBeginCct;
        private System.Windows.Forms.Label labelVct;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonDrawct;
        private System.Windows.Forms.TrackBar trackBarDaysCT;
        private System.Windows.Forms.Button buttonScreenshot;
        private System.Windows.Forms.Label Titlehightank;
        private System.Windows.Forms.Button Calculatebutton;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TrackBar trackBarDaysVR;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartvr;
        private System.Windows.Forms.GroupBox groupBoxvr;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelEdC;
        private System.Windows.Forms.TextBox textBoxInTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxDays;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxdCkonec;
        private System.Windows.Forms.Label labeldckonec;
        private System.Windows.Forms.TextBox textBoxdCzasutki;
        private System.Windows.Forms.TextBox textBoxBeginC;
        private System.Windows.Forms.Label Vhightank;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DeltaConcentration;
        private System.Windows.Forms.Button buttondrawgraph;
        private System.Windows.Forms.SplitContainer splitContainer;
    }
}