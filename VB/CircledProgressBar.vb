Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraEditors
Imports System.ComponentModel

Namespace CircledProgressBarEditor
	Public Class CircledProgressBar
		Inherits ProgressBarControl
		' static constructor
		Shared Sub New()
			RepositoryItemCircledProgressBar.RegisterCircledProgressBar()
		End Sub

		' public constructor
		Public Sub New()
		End Sub

		' ovverride property
		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return RepositoryItemCircledProgressBar.CircledProgressBarEditorName
			End Get
		End Property

		' property as corresponded repositoryitem
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
		Public Shadows ReadOnly Property Properties() As RepositoryItemCircledProgressBar
			Get
				Return TryCast(MyBase.Properties, RepositoryItemCircledProgressBar)
			End Get
		End Property
	End Class
End Namespace
