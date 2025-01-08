﻿namespace OxygenConcentration.FormsforColumns
{
    partial class ThirdStep
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThirdStep));
            this.chartct = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Titlecubetor = new System.Windows.Forms.Label();
            this.textBoxDays = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.textBoxdCkonec = new System.Windows.Forms.TextBox();
            this.labeldckonec = new System.Windows.Forms.Label();
            this.Calculatebutton = new System.Windows.Forms.Button();
            this.textBoxdCzasutki = new System.Windows.Forms.TextBox();
            this.textBoxBeginC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DeltaConcentration = new System.Windows.Forms.Label();
            this.Titlehightank = new System.Windows.Forms.Label();
            this.Vhightank = new System.Windows.Forms.Label();
            this.trackBarDaysVR = new System.Windows.Forms.TrackBar();
            this.textBoxInTime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chartvr = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxvr = new System.Windows.Forms.GroupBox();
            this.buttondrawgraph = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.buttonClearct = new System.Windows.Forms.Button();
            this.buttonCalculatect = new System.Windows.Forms.Button();
            this.buttonDrawct = new System.Windows.Forms.Button();
            this.trackBarDaysCT = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.chartct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDaysVR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartvr)).BeginInit();
            this.groupBoxvr.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDaysCT)).BeginInit();
            this.SuspendLayout();
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
            this.chartct.Location = new System.Drawing.Point(528, 488);
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
            this.chartct.Size = new System.Drawing.Size(626, 300);
            this.chartct.TabIndex = 36;
            this.chartct.Text = "chart1";
            // 
            // Titlecubetor
            // 
            this.Titlecubetor.AutoSize = true;
            this.Titlecubetor.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Titlecubetor.Location = new System.Drawing.Point(215, 462);
            this.Titlecubetor.Margin = new System.Windows.Forms.Padding(0);
            this.Titlecubetor.Name = "Titlecubetor";
            this.Titlecubetor.Size = new System.Drawing.Size(83, 23);
            this.Titlecubetor.TabIndex = 34;
            this.Titlecubetor.Text = "Куб+Тор";
            // 
            // textBoxDays
            // 
            this.textBoxDays.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDays.Location = new System.Drawing.Point(283, 55);
            this.textBoxDays.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxDays.Name = "textBoxDays";
            this.textBoxDays.Size = new System.Drawing.Size(85, 30);
            this.textBoxDays.TabIndex = 56;
            this.textBoxDays.Text = "2";
            this.textBoxDays.TextChanged += new System.EventHandler(this.textBoxDays_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(149, 58);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 23);
            this.label5.TabIndex = 55;
            this.label5.Text = "День  цикла=";
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClear.Location = new System.Drawing.Point(369, 347);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(0);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(141, 46);
            this.buttonClear.TabIndex = 53;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // textBoxdCkonec
            // 
            this.textBoxdCkonec.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxdCkonec.Location = new System.Drawing.Point(283, 143);
            this.textBoxdCkonec.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxdCkonec.Name = "textBoxdCkonec";
            this.textBoxdCkonec.Size = new System.Drawing.Size(85, 30);
            this.textBoxdCkonec.TabIndex = 52;
            this.textBoxdCkonec.Text = "3,3";
            // 
            // labeldckonec
            // 
            this.labeldckonec.AutoSize = true;
            this.labeldckonec.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labeldckonec.Location = new System.Drawing.Point(142, 143);
            this.labeldckonec.Margin = new System.Windows.Forms.Padding(0);
            this.labeldckonec.Name = "labeldckonec";
            this.labeldckonec.Size = new System.Drawing.Size(141, 23);
            this.labeldckonec.TabIndex = 51;
            this.labeldckonec.Text = "ΔC конечная=";
            // 
            // Calculatebutton
            // 
            this.Calculatebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Calculatebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Calculatebutton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Calculatebutton.Location = new System.Drawing.Point(15, 347);
            this.Calculatebutton.Margin = new System.Windows.Forms.Padding(0);
            this.Calculatebutton.Name = "Calculatebutton";
            this.Calculatebutton.Size = new System.Drawing.Size(141, 46);
            this.Calculatebutton.TabIndex = 50;
            this.Calculatebutton.Text = "Рассчитать";
            this.Calculatebutton.UseVisualStyleBackColor = false;
            this.Calculatebutton.Click += new System.EventHandler(this.Calculatebutton_Click);
            // 
            // textBoxdCzasutki
            // 
            this.textBoxdCzasutki.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxdCzasutki.Location = new System.Drawing.Point(283, 186);
            this.textBoxdCzasutki.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxdCzasutki.Name = "textBoxdCzasutki";
            this.textBoxdCzasutki.Size = new System.Drawing.Size(85, 30);
            this.textBoxdCzasutki.TabIndex = 49;
            this.textBoxdCzasutki.Text = "0,0333";
            this.textBoxdCzasutki.TextChanged += new System.EventHandler(this.textBoxdCzasutki_TextChanged);
            // 
            // textBoxBeginC
            // 
            this.textBoxBeginC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxBeginC.Location = new System.Drawing.Point(283, 98);
            this.textBoxBeginC.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxBeginC.Name = "textBoxBeginC";
            this.textBoxBeginC.Size = new System.Drawing.Size(85, 30);
            this.textBoxBeginC.TabIndex = 48;
            this.textBoxBeginC.Text = "3,5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(176, 189);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 23);
            this.label1.TabIndex = 47;
            this.label1.Text = "ΔC за сут.=";
            // 
            // DeltaConcentration
            // 
            this.DeltaConcentration.AutoSize = true;
            this.DeltaConcentration.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeltaConcentration.Location = new System.Drawing.Point(134, 101);
            this.DeltaConcentration.Margin = new System.Windows.Forms.Padding(0);
            this.DeltaConcentration.Name = "DeltaConcentration";
            this.DeltaConcentration.Size = new System.Drawing.Size(149, 23);
            this.DeltaConcentration.TabIndex = 46;
            this.DeltaConcentration.Text = "ΔC начальная=";
            // 
            // Titlehightank
            // 
            this.Titlehightank.AutoSize = true;
            this.Titlehightank.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Titlehightank.Location = new System.Drawing.Point(212, 16);
            this.Titlehightank.Margin = new System.Windows.Forms.Padding(0);
            this.Titlehightank.Name = "Titlehightank";
            this.Titlehightank.Size = new System.Drawing.Size(35, 23);
            this.Titlehightank.TabIndex = 45;
            this.Titlehightank.Text = "ВР";
            // 
            // Vhightank
            // 
            this.Vhightank.AutoSize = true;
            this.Vhightank.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Vhightank.Location = new System.Drawing.Point(15, 32);
            this.Vhightank.Margin = new System.Windows.Forms.Padding(0);
            this.Vhightank.Name = "Vhightank";
            this.Vhightank.Size = new System.Drawing.Size(66, 23);
            this.Vhightank.TabIndex = 44;
            this.Vhightank.Text = "V=80л";
            // 
            // trackBarDaysVR
            // 
            this.trackBarDaysVR.AccessibleRole = System.Windows.Forms.AccessibleRole.ProgressBar;
            this.trackBarDaysVR.BackColor = System.Drawing.Color.White;
            this.trackBarDaysVR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBarDaysVR.LargeChange = 1;
            this.trackBarDaysVR.Location = new System.Drawing.Point(528, 344);
            this.trackBarDaysVR.Margin = new System.Windows.Forms.Padding(0);
            this.trackBarDaysVR.Maximum = 6;
            this.trackBarDaysVR.Minimum = 1;
            this.trackBarDaysVR.Name = "trackBarDaysVR";
            this.trackBarDaysVR.Size = new System.Drawing.Size(626, 56);
            this.trackBarDaysVR.TabIndex = 57;
            this.trackBarDaysVR.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBarDaysVR.Value = 1;
            this.trackBarDaysVR.Scroll += new System.EventHandler(this.trackBarDaysVR_Scroll);
            // 
            // textBoxInTime
            // 
            this.textBoxInTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBoxInTime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxInTime.Location = new System.Drawing.Point(283, 225);
            this.textBoxInTime.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxInTime.Name = "textBoxInTime";
            this.textBoxInTime.Size = new System.Drawing.Size(85, 30);
            this.textBoxInTime.TabIndex = 61;
            this.textBoxInTime.TextChanged += new System.EventHandler(this.textBoxInTime_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(164, 225);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 23);
            this.label6.TabIndex = 60;
            this.label6.Text = "C текущая=";
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
            this.chartvr.Location = new System.Drawing.Point(528, 44);
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
            this.chartvr.Size = new System.Drawing.Size(626, 300);
            this.chartvr.TabIndex = 62;
            this.chartvr.Text = "chart";
            // 
            // groupBoxvr
            // 
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
            this.groupBoxvr.Location = new System.Drawing.Point(15, 42);
            this.groupBoxvr.Margin = new System.Windows.Forms.Padding(0);
            this.groupBoxvr.Name = "groupBoxvr";
            this.groupBoxvr.Size = new System.Drawing.Size(495, 302);
            this.groupBoxvr.TabIndex = 63;
            this.groupBoxvr.TabStop = false;
            this.groupBoxvr.Text = "Параметры";
            // 
            // buttondrawgraph
            // 
            this.buttondrawgraph.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttondrawgraph.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttondrawgraph.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttondrawgraph.Location = new System.Drawing.Point(153, 347);
            this.buttondrawgraph.Margin = new System.Windows.Forms.Padding(0);
            this.buttondrawgraph.Name = "buttondrawgraph";
            this.buttondrawgraph.Size = new System.Drawing.Size(230, 46);
            this.buttondrawgraph.TabIndex = 64;
            this.buttondrawgraph.Text = "Построить график";
            this.buttondrawgraph.UseVisualStyleBackColor = false;
            this.buttondrawgraph.Click += new System.EventHandler(this.buttondrawgraph_Click);
            // 
            // groupBox1
            // 
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
            this.groupBox1.Location = new System.Drawing.Point(15, 488);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(495, 302);
            this.groupBox1.TabIndex = 67;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры";
            // 
            // textBoxIntimect
            // 
            this.textBoxIntimect.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxIntimect.Location = new System.Drawing.Point(283, 225);
            this.textBoxIntimect.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxIntimect.Name = "textBoxIntimect";
            this.textBoxIntimect.Size = new System.Drawing.Size(85, 30);
            this.textBoxIntimect.TabIndex = 61;
            this.textBoxIntimect.TextChanged += new System.EventHandler(this.textBoxIntimect_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(164, 225);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 23);
            this.label2.TabIndex = 60;
            this.label2.Text = "C текущая=";
            // 
            // textBoxDayct
            // 
            this.textBoxDayct.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDayct.Location = new System.Drawing.Point(283, 55);
            this.textBoxDayct.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxDayct.Name = "textBoxDayct";
            this.textBoxDayct.Size = new System.Drawing.Size(85, 30);
            this.textBoxDayct.TabIndex = 56;
            this.textBoxDayct.Text = "2";
            this.textBoxDayct.TextChanged += new System.EventHandler(this.textBoxDayct_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(149, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 23);
            this.label3.TabIndex = 55;
            this.label3.Text = "День  цикла=";
            // 
            // textBoxKonecCct
            // 
            this.textBoxKonecCct.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxKonecCct.Location = new System.Drawing.Point(283, 143);
            this.textBoxKonecCct.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxKonecCct.Name = "textBoxKonecCct";
            this.textBoxKonecCct.Size = new System.Drawing.Size(85, 30);
            this.textBoxKonecCct.TabIndex = 52;
            this.textBoxKonecCct.Text = "8";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(142, 143);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 23);
            this.label4.TabIndex = 51;
            this.label4.Text = "ΔC конечная=";
            // 
            // textBoxCzasytkict
            // 
            this.textBoxCzasytkict.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCzasytkict.Location = new System.Drawing.Point(283, 186);
            this.textBoxCzasytkict.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxCzasytkict.Name = "textBoxCzasytkict";
            this.textBoxCzasytkict.Size = new System.Drawing.Size(85, 30);
            this.textBoxCzasytkict.TabIndex = 49;
            this.textBoxCzasytkict.Text = "-0,1667";
            this.textBoxCzasytkict.TextChanged += new System.EventHandler(this.textBoxCzasytkict_TextChanged);
            // 
            // textBoxBeginCct
            // 
            this.textBoxBeginCct.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxBeginCct.Location = new System.Drawing.Point(283, 98);
            this.textBoxBeginCct.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxBeginCct.Name = "textBoxBeginCct";
            this.textBoxBeginCct.Size = new System.Drawing.Size(85, 30);
            this.textBoxBeginCct.TabIndex = 48;
            this.textBoxBeginCct.Text = "7";
            // 
            // labelVct
            // 
            this.labelVct.AutoSize = true;
            this.labelVct.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVct.Location = new System.Drawing.Point(15, 32);
            this.labelVct.Margin = new System.Windows.Forms.Padding(0);
            this.labelVct.Name = "labelVct";
            this.labelVct.Size = new System.Drawing.Size(66, 23);
            this.labelVct.TabIndex = 44;
            this.labelVct.Text = "V=45л";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(176, 189);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 23);
            this.label8.TabIndex = 47;
            this.label8.Text = "ΔC за сут.=";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(134, 101);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 23);
            this.label9.TabIndex = 46;
            this.label9.Text = "ΔC начальная=";
            // 
            // buttonClearct
            // 
            this.buttonClearct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonClearct.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClearct.Location = new System.Drawing.Point(369, 793);
            this.buttonClearct.Margin = new System.Windows.Forms.Padding(0);
            this.buttonClearct.Name = "buttonClearct";
            this.buttonClearct.Size = new System.Drawing.Size(141, 46);
            this.buttonClearct.TabIndex = 66;
            this.buttonClearct.Text = "Очистить";
            this.buttonClearct.UseVisualStyleBackColor = false;
            this.buttonClearct.Click += new System.EventHandler(this.buttonClearct_Click);
            // 
            // buttonCalculatect
            // 
            this.buttonCalculatect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonCalculatect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCalculatect.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCalculatect.Location = new System.Drawing.Point(15, 793);
            this.buttonCalculatect.Margin = new System.Windows.Forms.Padding(0);
            this.buttonCalculatect.Name = "buttonCalculatect";
            this.buttonCalculatect.Size = new System.Drawing.Size(141, 46);
            this.buttonCalculatect.TabIndex = 65;
            this.buttonCalculatect.Text = "Рассчитать";
            this.buttonCalculatect.UseVisualStyleBackColor = false;
            this.buttonCalculatect.Click += new System.EventHandler(this.buttonCalculatect_Click);
            // 
            // buttonDrawct
            // 
            this.buttonDrawct.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonDrawct.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDrawct.Location = new System.Drawing.Point(153, 793);
            this.buttonDrawct.Margin = new System.Windows.Forms.Padding(0);
            this.buttonDrawct.Name = "buttonDrawct";
            this.buttonDrawct.Size = new System.Drawing.Size(230, 46);
            this.buttonDrawct.TabIndex = 68;
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
            this.trackBarDaysCT.Location = new System.Drawing.Point(528, 788);
            this.trackBarDaysCT.Margin = new System.Windows.Forms.Padding(0);
            this.trackBarDaysCT.Maximum = 6;
            this.trackBarDaysCT.Minimum = 1;
            this.trackBarDaysCT.Name = "trackBarDaysCT";
            this.trackBarDaysCT.Size = new System.Drawing.Size(626, 56);
            this.trackBarDaysCT.TabIndex = 69;
            this.trackBarDaysCT.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBarDaysCT.Value = 1;
            this.trackBarDaysCT.Scroll += new System.EventHandler(this.trackBarDaysCT_Scroll_1);
            // 
            // ThirdStep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1163, 953);
            this.Controls.Add(this.trackBarDaysCT);
            this.Controls.Add(this.buttonDrawct);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonClearct);
            this.Controls.Add(this.buttonCalculatect);
            this.Controls.Add(this.buttondrawgraph);
            this.Controls.Add(this.groupBoxvr);
            this.Controls.Add(this.chartvr);
            this.Controls.Add(this.trackBarDaysVR);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.Calculatebutton);
            this.Controls.Add(this.Titlehightank);
            this.Controls.Add(this.chartct);
            this.Controls.Add(this.Titlecubetor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ThirdStep";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Третья ступень";
            ((System.ComponentModel.ISupportInitialize)(this.chartct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDaysVR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartvr)).EndInit();
            this.groupBoxvr.ResumeLayout(false);
            this.groupBoxvr.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDaysCT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chartct;
        private System.Windows.Forms.Label Titlecubetor;
        private System.Windows.Forms.TextBox textBoxDays;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TextBox textBoxdCkonec;
        private System.Windows.Forms.Label labeldckonec;
        private System.Windows.Forms.Button Calculatebutton;
        private System.Windows.Forms.TextBox textBoxdCzasutki;
        private System.Windows.Forms.TextBox textBoxBeginC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DeltaConcentration;
        private System.Windows.Forms.Label Titlehightank;
        private System.Windows.Forms.Label Vhightank;
        private System.Windows.Forms.TrackBar trackBarDaysVR;
        private System.Windows.Forms.TextBox textBoxInTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartvr;
        private System.Windows.Forms.GroupBox groupBoxvr;
        private System.Windows.Forms.Button buttondrawgraph;
        private System.Windows.Forms.GroupBox groupBox1;
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
        private System.Windows.Forms.Button buttonClearct;
        private System.Windows.Forms.Button buttonCalculatect;
        private System.Windows.Forms.Button buttonDrawct;
        private System.Windows.Forms.TrackBar trackBarDaysCT;
    }
}