Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.Utils.Drawing
Imports System.Drawing

Namespace CircledProgressBarEditor
	Friend Class CircledProgressBarPainter
		Inherits ProgressBarPainter
		Protected Friend Shared Function CalcProportionalBorderRectangle(ByVal initRect As Rectangle, ByVal Proportion As Integer) As Rectangle
			Dim returnedRectangle As Rectangle = Rectangle.Empty
			initRect.Height -= 1
			If (initRect.Width \ initRect.Height) > Proportion Then
				Dim newWidth As Integer = initRect.Height * Proportion
				Dim newX As Integer = initRect.X + initRect.Width \ 2 - newWidth \ 2
				returnedRectangle = New Rectangle(newX, initRect.Y, newWidth, initRect.Height)
			Else
				returnedRectangle = initRect
			End If

			Return returnedRectangle
		End Function


		Protected Sub DrawEllipseAroundTheText(ByVal info As ControlGraphicsInfoArgs)
			Dim vi As CircledProgressBarViewInfo = TryCast(info.ViewInfo, CircledProgressBarViewInfo)
			Dim item As RepositoryItemCircledProgressBar = CType(vi.Item, RepositoryItemCircledProgressBar)
			If item.CustomBehavior.ShowTextEllipse Then
				Dim currentTextSize As SizeF = info.Graphics.MeasureString(vi.DisplayText, vi.Appearance.Font)
				If (vi.ContentRect.Height - currentTextSize.Height) > 20 Then
					Dim iRectForCaptionHeight As Integer = CInt(Fix(currentTextSize.Height)) + 15
					Dim iRectForCaptionWidth As Integer = vi.ContentRect.Width / (vi.ContentRect.Height \ iRectForCaptionHeight)
					Dim iRectForCaptionX As Integer = vi.ContentRect.X + vi.ContentRect.Width \ 2 - iRectForCaptionHeight \ 2
					Dim iRectForCaptionY As Integer = vi.ContentRect.Y + vi.ContentRect.Height \ 2 - iRectForCaptionHeight \ 2
					info.Graphics.FillEllipse(New SolidBrush(item.CustomBehavior.TextEllipseColor), New Rectangle(iRectForCaptionX, iRectForCaptionY, iRectForCaptionHeight, iRectForCaptionHeight))
				End If
			End If
		End Sub

		Protected Sub DrawCircledProgressBarString(ByVal info As ControlGraphicsInfoArgs)
			Dim vi As ProgressBarBaseViewInfo = TryCast(info.ViewInfo, ProgressBarBaseViewInfo)
			Dim emptyBrush As Brush = vi.ProgressAppearance.GetForeBrush(info.Cache)
			Dim fillBrush As Brush = vi.ProgressAppearance.GetFore2Brush(info.Cache)
			Dim clip As GraphicsClipState = info.Cache.ClipInfo.SaveAndSetClip(info.Bounds)
			Try
				If vi.ProgressInfo.ProgressBounds.Width = 0 Then
					info.Cache.DrawString(vi.DisplayText, vi.PaintAppearance.Font, emptyBrush, vi.ContentRect, vi.StrFormat)
					Return
				End If
				info.Cache.ClipInfo.ExcludeClip(vi.ProgressInfo.ProgressBounds)
				DrawEllipseAroundTheText(info)
				info.Cache.DrawString(vi.DisplayText, vi.PaintAppearance.Font, emptyBrush, vi.ContentRect, vi.StrFormat)
				info.Cache.ClipInfo.SetClip(vi.ProgressInfo.ProgressBounds)
				DrawEllipseAroundTheText(info)
				info.Cache.DrawString(vi.DisplayText, vi.PaintAppearance.Font, emptyBrush, vi.ContentRect, vi.StrFormat)

			Finally
				info.Cache.ClipInfo.RestoreClipRelease(clip)
			End Try
		End Sub

		Protected Overrides Sub DrawContent(ByVal info As ControlGraphicsInfoArgs)
			Dim vi As ProgressBarBaseViewInfo = TryCast(info.ViewInfo, ProgressBarBaseViewInfo)
			Dim item As RepositoryItemCircledProgressBar = CType(vi.Item, RepositoryItemCircledProgressBar)
			ObjectPainter.DrawObject(info.Cache, vi.ProgressPainter, vi.ProgressInfo)
			info.Graphics.DrawEllipse(New Pen(item.Appearance.BackColor), CalcProportionalBorderRectangle(info.Bounds, item.CustomBehavior.MinWidthHeightProportion))
			DrawCircledProgressBarString(info)
		End Sub

		Protected Overrides Sub DrawBorder(ByVal info As ControlGraphicsInfoArgs)
			Dim vi As ProgressBarBaseViewInfo = TryCast(info.ViewInfo, ProgressBarBaseViewInfo)
			Dim item As RepositoryItemCircledProgressBar = CType(vi.Item, RepositoryItemCircledProgressBar)
			If item.OwnerEdit IsNot Nothing AndAlso item.OwnerEdit.InplaceType = DevExpress.XtraEditors.Controls.InplaceType.Standalone Then
				info.Graphics.FillRectangle(New SolidBrush(item.OwnerEdit.Parent.BackColor), info.Bounds)
			End If
		End Sub

		Protected Overrides Function IsDrawBorderLast(ByVal info As ControlGraphicsInfoArgs) As Boolean
			Dim vi As ProgressBarBaseViewInfo = TryCast(info.ViewInfo, ProgressBarBaseViewInfo)
			If TypeOf vi.BorderPainter Is WindowsXPProgressBarBorderPainter Then
				Return False
			End If
			If TypeOf vi.ProgressPainter Is CircledProgressBarObjectPainter Then
				Return False
			End If
			Return True
		End Function
	End Class
End Namespace
