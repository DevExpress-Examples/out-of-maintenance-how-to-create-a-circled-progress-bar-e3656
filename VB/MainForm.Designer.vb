Imports Microsoft.VisualBasic
Imports System
Namespace CircledProgressBar
	Partial Public Class MainForm
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.timerForProgressBar = New System.Windows.Forms.Timer(Me.components)
			Me.Start = New DevExpress.XtraEditors.SimpleButton()
			Me.radioGroupSartAngle = New DevExpress.XtraEditors.RadioGroup()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			Me.spinEditProportion = New DevExpress.XtraEditors.SpinEdit()
			Me.simpleButtonStop = New DevExpress.XtraEditors.SimpleButton()
			Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
			Me.panel1 = New System.Windows.Forms.Panel()
			Me.labelControl3 = New DevExpress.XtraEditors.LabelControl()
			Me.checkEditShowTextEllipse = New DevExpress.XtraEditors.CheckEdit()
			Me.labelControl4 = New DevExpress.XtraEditors.LabelControl()
			Me.colorEditFirstColor = New DevExpress.XtraEditors.ColorEdit()
			Me.colorEditSecondColor = New DevExpress.XtraEditors.ColorEdit()
			Me.labelControl5 = New DevExpress.XtraEditors.LabelControl()
			Me.colorEditEllipseText = New DevExpress.XtraEditors.ColorEdit()
			Me.labelControl7 = New DevExpress.XtraEditors.LabelControl()
			Me.circledProgressBarForTest = New CircledProgressBarEditor.CircledProgressBar()
			CType(Me.radioGroupSartAngle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.spinEditProportion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel1.SuspendLayout()
			CType(Me.checkEditShowTextEllipse.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.colorEditFirstColor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.colorEditSecondColor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.colorEditEllipseText.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.circledProgressBarForTest.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' timerForProgressBar
			' 
'			Me.timerForProgressBar.Tick += New System.EventHandler(Me.timerForProgressBar_Tick);
			' 
			' Start
			' 
			Me.Start.Location = New System.Drawing.Point(35, 170)
			Me.Start.Name = "Start"
			Me.Start.Size = New System.Drawing.Size(101, 23)
			Me.Start.TabIndex = 1
			Me.Start.Text = "Start"
'			Me.Start.Click += New System.EventHandler(Me.Start_Click);
			' 
			' radioGroupSartAngle
			' 
			Me.radioGroupSartAngle.Location = New System.Drawing.Point(17, 123)
			Me.radioGroupSartAngle.Name = "radioGroupSartAngle"
			Me.radioGroupSartAngle.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() { New DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Deg 0"), New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Deg 90"), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Deg 180"), New DevExpress.XtraEditors.Controls.RadioGroupItem(3, "Deg 270")})
			Me.radioGroupSartAngle.Size = New System.Drawing.Size(271, 26)
			Me.radioGroupSartAngle.TabIndex = 4
			' 
			' labelControl1
			' 
			Me.labelControl1.Location = New System.Drawing.Point(324, 158)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New System.Drawing.Size(121, 13)
			Me.labelControl1.TabIndex = 5
			Me.labelControl1.Text = "Width / height proportion"
			' 
			' spinEditProportion
			' 
			Me.spinEditProportion.EditValue = New Decimal(New Integer() { 1, 0, 0, 0})
			Me.spinEditProportion.Location = New System.Drawing.Point(451, 155)
			Me.spinEditProportion.Name = "spinEditProportion"
			Me.spinEditProportion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.spinEditProportion.Properties.IsFloatValue = False
			Me.spinEditProportion.Properties.Mask.EditMask = "N00"
			Me.spinEditProportion.Properties.MaxValue = New Decimal(New Integer() { 10, 0, 0, 0})
			Me.spinEditProportion.Properties.MinValue = New Decimal(New Integer() { 1, 0, 0, 0})
			Me.spinEditProportion.Size = New System.Drawing.Size(73, 20)
			Me.spinEditProportion.TabIndex = 6
			' 
			' simpleButtonStop
			' 
			Me.simpleButtonStop.Location = New System.Drawing.Point(161, 170)
			Me.simpleButtonStop.LookAndFeel.UseWindowsXPTheme = True
			Me.simpleButtonStop.Name = "simpleButtonStop"
			Me.simpleButtonStop.Size = New System.Drawing.Size(101, 23)
			Me.simpleButtonStop.TabIndex = 7
			Me.simpleButtonStop.Text = "Stop"
'			Me.simpleButtonStop.Click += New System.EventHandler(Me.simpleButtonStop_Click);
			' 
			' labelControl2
			' 
			Me.labelControl2.Location = New System.Drawing.Point(19, 102)
			Me.labelControl2.Name = "labelControl2"
			Me.labelControl2.Size = New System.Drawing.Size(117, 13)
			Me.labelControl2.TabIndex = 10
			Me.labelControl2.Text = "Start progress bar angle"
			' 
			' panel1
			' 
			Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
			Me.panel1.Controls.Add(Me.colorEditEllipseText)
			Me.panel1.Controls.Add(Me.labelControl7)
			Me.panel1.Controls.Add(Me.colorEditSecondColor)
			Me.panel1.Controls.Add(Me.labelControl5)
			Me.panel1.Controls.Add(Me.colorEditFirstColor)
			Me.panel1.Controls.Add(Me.labelControl4)
			Me.panel1.Location = New System.Drawing.Point(326, 27)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(243, 88)
			Me.panel1.TabIndex = 11
			' 
			' labelControl3
			' 
			Me.labelControl3.Location = New System.Drawing.Point(329, 8)
			Me.labelControl3.Name = "labelControl3"
			Me.labelControl3.Size = New System.Drawing.Size(77, 13)
			Me.labelControl3.TabIndex = 0
			Me.labelControl3.Text = "Color properties"
			' 
			' checkEditShowTextEllipse
			' 
			Me.checkEditShowTextEllipse.Location = New System.Drawing.Point(324, 130)
			Me.checkEditShowTextEllipse.Name = "checkEditShowTextEllipse"
			Me.checkEditShowTextEllipse.Properties.Caption = "Show ellipse arround percents"
			Me.checkEditShowTextEllipse.Size = New System.Drawing.Size(268, 19)
			Me.checkEditShowTextEllipse.TabIndex = 12
			' 
			' labelControl4
			' 
			Me.labelControl4.Location = New System.Drawing.Point(25, 8)
			Me.labelControl4.Name = "labelControl4"
			Me.labelControl4.Size = New System.Drawing.Size(123, 13)
			Me.labelControl4.TabIndex = 0
			Me.labelControl4.Text = "First color for gradient fill "
			' 
			' colorEditFirstColor
			' 
			Me.colorEditFirstColor.EditValue = System.Drawing.Color.Empty
			Me.colorEditFirstColor.Location = New System.Drawing.Point(161, 5)
			Me.colorEditFirstColor.Name = "colorEditFirstColor"
			Me.colorEditFirstColor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.colorEditFirstColor.Size = New System.Drawing.Size(73, 20)
			Me.colorEditFirstColor.TabIndex = 1
			' 
			' colorEditSecondColor
			' 
			Me.colorEditSecondColor.EditValue = System.Drawing.Color.Empty
			Me.colorEditSecondColor.Location = New System.Drawing.Point(161, 30)
			Me.colorEditSecondColor.Name = "colorEditSecondColor"
			Me.colorEditSecondColor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.colorEditSecondColor.Size = New System.Drawing.Size(73, 20)
			Me.colorEditSecondColor.TabIndex = 3
			' 
			' labelControl5
			' 
			Me.labelControl5.Location = New System.Drawing.Point(11, 34)
			Me.labelControl5.Name = "labelControl5"
			Me.labelControl5.Size = New System.Drawing.Size(137, 13)
			Me.labelControl5.TabIndex = 2
			Me.labelControl5.Text = "Second color for gradient fill "
			' 
			' colorEditEllipseText
			' 
			Me.colorEditEllipseText.EditValue = System.Drawing.Color.Empty
			Me.colorEditEllipseText.Location = New System.Drawing.Point(161, 58)
			Me.colorEditEllipseText.Name = "colorEditEllipseText"
			Me.colorEditEllipseText.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.colorEditEllipseText.Size = New System.Drawing.Size(73, 20)
			Me.colorEditEllipseText.TabIndex = 7
			' 
			' labelControl7
			' 
			Me.labelControl7.Location = New System.Drawing.Point(8, 62)
			Me.labelControl7.Name = "labelControl7"
			Me.labelControl7.Size = New System.Drawing.Size(140, 13)
			Me.labelControl7.TabIndex = 6
			Me.labelControl7.Text = "Ellipse color (around percent)"
			' 
			' circledProgressBarForTest
			' 
			Me.circledProgressBarForTest.Location = New System.Drawing.Point(17, 12)
			Me.circledProgressBarForTest.Name = "circledProgressBarForTest"
			Me.circledProgressBarForTest.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(64))))), (CInt(Fix((CByte(64))))), (CInt(Fix((CByte(64))))))
			Me.circledProgressBarForTest.Properties.CustomBehavior.StartAngle = CircledProgressBarEditor.CircleStartAngle.Angle0
			Me.circledProgressBarForTest.Properties.CustomBehavior.TextEllipseColor = System.Drawing.Color.LightGray
			Me.circledProgressBarForTest.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003
			Me.circledProgressBarForTest.Properties.LookAndFeel.UseDefaultLookAndFeel = False
			Me.circledProgressBarForTest.Properties.ShowTitle = True
			Me.circledProgressBarForTest.Properties.StartColor = System.Drawing.SystemColors.ControlLightLight
			Me.circledProgressBarForTest.Properties.UseParentBackground = True
			Me.circledProgressBarForTest.Size = New System.Drawing.Size(303, 85)
			Me.circledProgressBarForTest.TabIndex = 9
			' 
			' MainForm
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(581, 211)
			Me.Controls.Add(Me.checkEditShowTextEllipse)
			Me.Controls.Add(Me.labelControl3)
			Me.Controls.Add(Me.panel1)
			Me.Controls.Add(Me.labelControl2)
			Me.Controls.Add(Me.circledProgressBarForTest)
			Me.Controls.Add(Me.simpleButtonStop)
			Me.Controls.Add(Me.spinEditProportion)
			Me.Controls.Add(Me.labelControl1)
			Me.Controls.Add(Me.radioGroupSartAngle)
			Me.Controls.Add(Me.Start)
			Me.Name = "MainForm"
			Me.Text = "Application main form"
'			Me.Load += New System.EventHandler(Me.MainForm_Load);
			CType(Me.radioGroupSartAngle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.spinEditProportion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel1.ResumeLayout(False)
			Me.panel1.PerformLayout()
			CType(Me.checkEditShowTextEllipse.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.colorEditFirstColor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.colorEditSecondColor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.colorEditEllipseText.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.circledProgressBarForTest.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private WithEvents timerForProgressBar As System.Windows.Forms.Timer
		Private WithEvents Start As DevExpress.XtraEditors.SimpleButton
		Private radioGroupSartAngle As DevExpress.XtraEditors.RadioGroup
		Private labelControl1 As DevExpress.XtraEditors.LabelControl
		Private spinEditProportion As DevExpress.XtraEditors.SpinEdit
		Private WithEvents simpleButtonStop As DevExpress.XtraEditors.SimpleButton
		Private circledProgressBarForTest As CircledProgressBarEditor.CircledProgressBar
		Private labelControl2 As DevExpress.XtraEditors.LabelControl
		Private panel1 As System.Windows.Forms.Panel
		Private labelControl3 As DevExpress.XtraEditors.LabelControl
		Private checkEditShowTextEllipse As DevExpress.XtraEditors.CheckEdit
		Private colorEditEllipseText As DevExpress.XtraEditors.ColorEdit
		Private labelControl7 As DevExpress.XtraEditors.LabelControl
		Private colorEditSecondColor As DevExpress.XtraEditors.ColorEdit
		Private labelControl5 As DevExpress.XtraEditors.LabelControl
		Private colorEditFirstColor As DevExpress.XtraEditors.ColorEdit
		Private labelControl4 As DevExpress.XtraEditors.LabelControl
	End Class
End Namespace

