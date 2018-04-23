Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.Utils.Drawing
Imports DevExpress.LookAndFeel

Namespace CircledProgressBarEditor
	Friend Class CircledProgressBarViewInfo
		Inherits ProgressBarViewInfo
		' constructor
		Public Sub New(ByVal item As RepositoryItem)
			MyBase.New(item)
		End Sub

		Public Overrides ReadOnly Property ProgressPainter() As ProgressBarObjectPainter
			Get
				Return New CircledProgressBarObjectPainter(Owner)
			End Get
		End Property
	End Class
End Namespace
