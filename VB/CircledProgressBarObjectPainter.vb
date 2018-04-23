Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.Utils.Drawing
Imports System.Drawing
Imports DevExpress.Skins
Imports DevExpress.XtraEditors

Namespace CircledProgressBarEditor
	Friend Class CircledProgressBarObjectPainter
		Inherits ProgressBarObjectPainter
		Private currentAngle As CircleStartAngle
		Private currentWidthHeightProportion As Integer

		' constructor
		Public Sub New(ByVal paramObject As Object)
			Dim CurrentRepository As RepositoryItemCircledProgressBar = TryCast(paramObject, RepositoryItemCircledProgressBar)
			currentAngle = If(CurrentRepository IsNot Nothing, CurrentRepository.CustomBehavior.StartAngle, CircleStartAngle.Angle90)
			currentWidthHeightProportion = If(CurrentRepository IsNot Nothing, CurrentRepository.CustomBehavior.MinWidthHeightProportion, 5)
		End Sub

		Protected Sub DrawCircledBar(ByVal e As ProgressBarObjectInfoArgs)
			DrawCircledBar(e, CalcProgressBounds(e))
		End Sub

		Protected Sub DrawCircledBar(ByVal e As ProgressBarObjectInfoArgs, ByVal pb As Rectangle)
			Dim rectForPie As Rectangle = CircledProgressBarPainter.CalcProportionalBorderRectangle(e.Bounds, currentWidthHeightProportion)
			Dim brush As Brush = e.Cache.GetGradientBrush(e.Bounds, e.StartColor, e.EndColor, System.Drawing.Drawing2D.LinearGradientMode.Vertical)
			Dim beginAngle As Single = -90 + 90 * CInt(Fix(currentAngle))
			Dim endAngle As Single = 360 * e.Percent
			If rectForPie.Width > 0 Then
				e.Cache.Graphics.FillPie(brush, rectForPie, beginAngle, endAngle)
			End If
		End Sub

		Protected Overrides Sub DrawBar(ByVal e As ProgressBarObjectInfoArgs)
			DrawCircledBar(e)
		End Sub

		Public Overrides Overloads Sub DrawObject(ByVal e As ObjectInfoArgs)
			Dim color As Color = DevExpress.LookAndFeel.LookAndFeelHelper.GetSystemColor(DevExpress.LookAndFeel.UserLookAndFeel.Default.ActiveLookAndFeel, SystemColors.Control)
			Dim ee As ProgressBarObjectInfoArgs = TryCast(e, ProgressBarObjectInfoArgs)
			If ee.FillBackground Then
				e.Cache.Paint.FillRectangle(e.Graphics, New SolidBrush(color), e.Bounds)
			End If
			DrawBar(ee)
		End Sub
	End Class
End Namespace
