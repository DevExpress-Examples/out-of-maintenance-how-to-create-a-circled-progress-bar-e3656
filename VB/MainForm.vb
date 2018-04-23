Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.Utils.Drawing
Imports DevExpress.XtraEditors
Imports CircledProgressBarEditor

Namespace CircledProgressBar
	Partial Public Class MainForm
		Inherits Form
		Private Customers As New DataTable()
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub SetRepositoryItemsSettings(ByVal currentRepository As RepositoryItemCircledProgressBar)
			currentRepository.CustomBehavior.MinWidthHeightProportion = Convert.ToInt32(spinEditProportion.EditValue)
			currentRepository.CustomBehavior.ShowTextEllipse = CBool(checkEditShowTextEllipse.EditValue)
			currentRepository.CustomBehavior.StartAngle = CType(radioGroupSartAngle.EditValue, CircledProgressBarEditor.CircleStartAngle)
			currentRepository.CustomBehavior.TextEllipseColor = CType(colorEditEllipseText.EditValue, Color)

			currentRepository.EndColor = CType(colorEditFirstColor.EditValue, Color)
			currentRepository.StartColor = CType(colorEditSecondColor.EditValue, Color)
		End Sub

		Private Sub MainForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			circledProgressBarForTest.Properties.Minimum = 1
			circledProgressBarForTest.Properties.Maximum = 100
			circledProgressBarForTest.EditValue = 0

			timerForProgressBar.Interval = 500
			radioGroupSartAngle.SelectedIndex = 0
			spinEditProportion.EditValue = 5
			checkEditShowTextEllipse.EditValue = True
			colorEditEllipseText.EditValue = Color.White
			colorEditFirstColor.EditValue = Color.LightBlue
			colorEditSecondColor.EditValue = Color.LightYellow
			SetRepositoryItemsSettings(circledProgressBarForTest.Properties)

			' events
			AddHandler radioGroupSartAngle.EditValueChanged, AddressOf radioGroupSartAngle_EditValueChanged
			AddHandler spinEditProportion.EditValueChanged, AddressOf spinEditProportion_EditValueChanged
			AddHandler checkEditShowTextEllipse.EditValueChanged, AddressOf checkEditShowTextEllipse_EditValueChanged
			AddHandler colorEditEllipseText.EditValueChanged, AddressOf colorEditEllipseText_EditValueChanged
			AddHandler colorEditFirstColor.EditValueChanged, AddressOf colorEditFirstColor_EditValueChanged
			AddHandler colorEditSecondColor.EditValueChanged, AddressOf colorEditSecondColor_EditValueChanged
		End Sub

		Private Sub colorEditSecondColor_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			SetRepositoryItemsSettings(circledProgressBarForTest.Properties)
		End Sub
		Private Sub colorEditFirstColor_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			SetRepositoryItemsSettings(circledProgressBarForTest.Properties)
		End Sub
		Private Sub colorEditEllipseText_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			SetRepositoryItemsSettings(circledProgressBarForTest.Properties)
		End Sub
		Private Sub checkEditShowTextEllipse_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			SetRepositoryItemsSettings(circledProgressBarForTest.Properties)
		End Sub
		Private Sub spinEditProportion_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			SetRepositoryItemsSettings(circledProgressBarForTest.Properties)
		End Sub
		Private Sub radioGroupSartAngle_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			SetRepositoryItemsSettings(circledProgressBarForTest.Properties)
		End Sub



		Private Sub Start_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Start.Click
			circledProgressBarForTest.EditValue = 0
			timerForProgressBar.Start()
		End Sub

        Private Sub timerForProgressBar_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles timerForProgressBar.Tick
            If CInt(Fix(circledProgressBarForTest.EditValue)).Equals(circledProgressBarForTest.Properties.Maximum) Then
                timerForProgressBar.Stop()
            Else
                circledProgressBarForTest.EditValue = CInt(Fix(circledProgressBarForTest.EditValue)) + 1
            End If
        End Sub

		Private Sub simpleButtonStop_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButtonStop.Click
			timerForProgressBar.Stop()
		End Sub
	End Class
End Namespace
