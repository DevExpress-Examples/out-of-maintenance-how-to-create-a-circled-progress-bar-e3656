Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Registrator
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.XtraEditors.Drawing
Imports System.ComponentModel
Imports DevExpress.XtraEditors
Imports System.Drawing

Namespace CircledProgressBarEditor
	Public Enum CircleStartAngle
		Angle0 = 0
		Angle90 = 1
		Angle180 = 2
		Angle270 = 3
	End Enum

	<System.ComponentModel.TypeConverter(GetType(System.ComponentModel.ExpandableObjectConverter))> _
	Public Class CircledProgressBarBehaviourOptions
		Public Sub New()
			MinWidthHeightProportion = 5
			ShowTextEllipse = True
			TextEllipseColor = Color.White
			StartAngle = CircleStartAngle.Angle0
		End Sub

		Private privateStartAngle As CircleStartAngle
        <Description("Gets or sets a start angle on drawing a circle surface."), DefaultValue(CircleStartAngle.Angle90)> _
        Public Property StartAngle() As CircleStartAngle
            Get
                Return privateStartAngle
            End Get
            Set(ByVal value As CircleStartAngle)
                privateStartAngle = value
            End Set
        End Property
		Protected WidthHeightProportion As Integer
        <Description("Gets or sets the minimal value of the width to height proportion on drawing a circle surface."), DefaultValue(5)> _
        Public Property MinWidthHeightProportion() As Integer
            Get
                Return WidthHeightProportion
            End Get
            Set(ByVal value As Integer)
                If value > 0 Then
                    WidthHeightProportion = value
                End If
            End Set
        End Property

		Private privateShowTextEllipse As Boolean
        <Description("Gets or sets drawing ellipse mode around displayed text."), DefaultValue(True)> _
        Public Property ShowTextEllipse() As Boolean
            Get
                Return privateShowTextEllipse
            End Get
            Set(ByVal value As Boolean)
                privateShowTextEllipse = value
            End Set
        End Property
		Private privateTextEllipseColor As Color
        <Description("Gets or sets the ellipse color which will be drawn around the displayed text.")> _
        Public Property TextEllipseColor() As Color
            Get
                Return privateTextEllipseColor
            End Get
            Set(ByVal value As Color)
                privateTextEllipseColor = value
            End Set
        End Property

		Public Overrides Function ToString() As String
			Return "Behaviour"
		End Function
	End Class

	Public Class RepositoryItemCircledProgressBar
		Inherits RepositoryItemProgressBar
		' static constructor which calls static registration method
		Shared Sub New()
			RegisterCircledProgressBar()
		End Sub

		' static register method
		Public Shared Sub RegisterCircledProgressBar()
            EditorRegistrationInfo.Default.Editors.Add(New EditorClassInfo(CircledProgressBarEditorName, GetType(CircledProgressBar), GetType(RepositoryItemCircledProgressBar), GetType(CircledProgressBarViewInfo), New CircledProgressBarPainter(), True))
		End Sub

		' internal editor name
		Friend Const CircledProgressBarEditorName As String = "CircledProgressBar"

		' public constructor
		Public Sub New()
			MyBase.New()
			protBehavior = New CircledProgressBarBehaviourOptions()
		End Sub

		Protected protBehavior As CircledProgressBarBehaviourOptions
        <Description("Gets behavior options of a circled progress bar."), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), Category("CustomBehavior")> _
        Public ReadOnly Property CustomBehavior() As CircledProgressBarBehaviourOptions
            Get
                Return protBehavior
            End Get
        End Property

		' ovverride property
		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return CircledProgressBarEditorName
			End Get
		End Property

		Public Overrides Function CreatePainter() As BaseEditPainter
			Return New CircledProgressBarPainter()
		End Function

		Public Overrides Sub Assign(ByVal item As RepositoryItem)
			MyBase.Assign(item)
			Dim currentRepository As RepositoryItemCircledProgressBar = (TryCast(item, RepositoryItemCircledProgressBar))
			Me.CustomBehavior.MinWidthHeightProportion = currentRepository.CustomBehavior.MinWidthHeightProportion
			Me.CustomBehavior.ShowTextEllipse = currentRepository.CustomBehavior.ShowTextEllipse
			Me.CustomBehavior.StartAngle = currentRepository.CustomBehavior.StartAngle
			Me.CustomBehavior.TextEllipseColor = currentRepository.CustomBehavior.TextEllipseColor
		End Sub
	End Class
End Namespace
