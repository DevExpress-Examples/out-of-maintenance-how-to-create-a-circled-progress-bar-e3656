namespace CircledProgressBar
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.timerForProgressBar = new System.Windows.Forms.Timer(this.components);
            this.Start = new DevExpress.XtraEditors.SimpleButton();
            this.radioGroupSartAngle = new DevExpress.XtraEditors.RadioGroup();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.spinEditProportion = new DevExpress.XtraEditors.SpinEdit();
            this.simpleButtonStop = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.checkEditShowTextEllipse = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.colorEditFirstColor = new DevExpress.XtraEditors.ColorEdit();
            this.colorEditSecondColor = new DevExpress.XtraEditors.ColorEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.colorEditEllipseText = new DevExpress.XtraEditors.ColorEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.circledProgressBarForTest = new CircledProgressBarEditor.CircledProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupSartAngle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditProportion.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowTextEllipse.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorEditFirstColor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorEditSecondColor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorEditEllipseText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circledProgressBarForTest.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // timerForProgressBar
            // 
            this.timerForProgressBar.Tick += new System.EventHandler(this.timerForProgressBar_Tick);
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(35, 170);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(101, 23);
            this.Start.TabIndex = 1;
            this.Start.Text = "Start";
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // radioGroupSartAngle
            // 
            this.radioGroupSartAngle.Location = new System.Drawing.Point(17, 123);
            this.radioGroupSartAngle.Name = "radioGroupSartAngle";
            this.radioGroupSartAngle.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Deg 0"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Deg 90"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Deg 180"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(3, "Deg 270")});
            this.radioGroupSartAngle.Size = new System.Drawing.Size(271, 26);
            this.radioGroupSartAngle.TabIndex = 4;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(324, 158);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(121, 13);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Width / height proportion";
            // 
            // spinEditProportion
            // 
            this.spinEditProportion.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinEditProportion.Location = new System.Drawing.Point(451, 155);
            this.spinEditProportion.Name = "spinEditProportion";
            this.spinEditProportion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinEditProportion.Properties.IsFloatValue = false;
            this.spinEditProportion.Properties.Mask.EditMask = "N00";
            this.spinEditProportion.Properties.MaxValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.spinEditProportion.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinEditProportion.Size = new System.Drawing.Size(73, 20);
            this.spinEditProportion.TabIndex = 6;
            // 
            // simpleButtonStop
            // 
            this.simpleButtonStop.Location = new System.Drawing.Point(161, 170);
            this.simpleButtonStop.LookAndFeel.UseWindowsXPTheme = true;
            this.simpleButtonStop.Name = "simpleButtonStop";
            this.simpleButtonStop.Size = new System.Drawing.Size(101, 23);
            this.simpleButtonStop.TabIndex = 7;
            this.simpleButtonStop.Text = "Stop";
            this.simpleButtonStop.Click += new System.EventHandler(this.simpleButtonStop_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(19, 102);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(117, 13);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "Start progress bar angle";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.colorEditEllipseText);
            this.panel1.Controls.Add(this.labelControl7);
            this.panel1.Controls.Add(this.colorEditSecondColor);
            this.panel1.Controls.Add(this.labelControl5);
            this.panel1.Controls.Add(this.colorEditFirstColor);
            this.panel1.Controls.Add(this.labelControl4);
            this.panel1.Location = new System.Drawing.Point(326, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 88);
            this.panel1.TabIndex = 11;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(329, 8);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(77, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Color properties";
            // 
            // checkEditShowTextEllipse
            // 
            this.checkEditShowTextEllipse.Location = new System.Drawing.Point(324, 130);
            this.checkEditShowTextEllipse.Name = "checkEditShowTextEllipse";
            this.checkEditShowTextEllipse.Properties.Caption = "Show ellipse arround percents";
            this.checkEditShowTextEllipse.Size = new System.Drawing.Size(268, 19);
            this.checkEditShowTextEllipse.TabIndex = 12;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(25, 8);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(123, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "First color for gradient fill ";
            // 
            // colorEditFirstColor
            // 
            this.colorEditFirstColor.EditValue = System.Drawing.Color.Empty;
            this.colorEditFirstColor.Location = new System.Drawing.Point(161, 5);
            this.colorEditFirstColor.Name = "colorEditFirstColor";
            this.colorEditFirstColor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.colorEditFirstColor.Size = new System.Drawing.Size(73, 20);
            this.colorEditFirstColor.TabIndex = 1;
            // 
            // colorEditSecondColor
            // 
            this.colorEditSecondColor.EditValue = System.Drawing.Color.Empty;
            this.colorEditSecondColor.Location = new System.Drawing.Point(161, 30);
            this.colorEditSecondColor.Name = "colorEditSecondColor";
            this.colorEditSecondColor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.colorEditSecondColor.Size = new System.Drawing.Size(73, 20);
            this.colorEditSecondColor.TabIndex = 3;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(11, 34);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(137, 13);
            this.labelControl5.TabIndex = 2;
            this.labelControl5.Text = "Second color for gradient fill ";
            // 
            // colorEditEllipseText
            // 
            this.colorEditEllipseText.EditValue = System.Drawing.Color.Empty;
            this.colorEditEllipseText.Location = new System.Drawing.Point(161, 58);
            this.colorEditEllipseText.Name = "colorEditEllipseText";
            this.colorEditEllipseText.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.colorEditEllipseText.Size = new System.Drawing.Size(73, 20);
            this.colorEditEllipseText.TabIndex = 7;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(8, 62);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(140, 13);
            this.labelControl7.TabIndex = 6;
            this.labelControl7.Text = "Ellipse color (around percent)";
            // 
            // circledProgressBarForTest
            // 
            this.circledProgressBarForTest.Location = new System.Drawing.Point(17, 12);
            this.circledProgressBarForTest.Name = "circledProgressBarForTest";
            this.circledProgressBarForTest.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circledProgressBarForTest.Properties.CustomBehavior.StartAngle = CircledProgressBarEditor.CircleStartAngle.Angle0;
            this.circledProgressBarForTest.Properties.CustomBehavior.TextEllipseColor = System.Drawing.Color.LightGray;
            this.circledProgressBarForTest.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            this.circledProgressBarForTest.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.circledProgressBarForTest.Properties.ShowTitle = true;
            this.circledProgressBarForTest.Properties.StartColor = System.Drawing.SystemColors.ControlLightLight;
            this.circledProgressBarForTest.Properties.UseParentBackground = true;
            this.circledProgressBarForTest.Size = new System.Drawing.Size(303, 85);
            this.circledProgressBarForTest.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 211);
            this.Controls.Add(this.checkEditShowTextEllipse);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.circledProgressBarForTest);
            this.Controls.Add(this.simpleButtonStop);
            this.Controls.Add(this.spinEditProportion);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.radioGroupSartAngle);
            this.Controls.Add(this.Start);
            this.Name = "MainForm";
            this.Text = "Application main form";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupSartAngle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditProportion.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowTextEllipse.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorEditFirstColor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorEditSecondColor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorEditEllipseText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circledProgressBarForTest.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerForProgressBar;
        private DevExpress.XtraEditors.SimpleButton Start;
        private DevExpress.XtraEditors.RadioGroup radioGroupSartAngle;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SpinEdit spinEditProportion;
        private DevExpress.XtraEditors.SimpleButton simpleButtonStop;
        private CircledProgressBarEditor.CircledProgressBar circledProgressBarForTest;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.CheckEdit checkEditShowTextEllipse;
        private DevExpress.XtraEditors.ColorEdit colorEditEllipseText;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.ColorEdit colorEditSecondColor;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.ColorEdit colorEditFirstColor;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}

