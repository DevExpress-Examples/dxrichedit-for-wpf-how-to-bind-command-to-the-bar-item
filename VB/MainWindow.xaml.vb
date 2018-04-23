﻿Imports Microsoft.VisualBasic
Imports System.Windows
Imports System.Windows.Input
Imports DevExpress.Xpf.Core
Imports DevExpress.Xpf.RichEdit

Namespace RichEditToolbarCustomCommandWpf
	Partial Public Class MainWindow
		Inherits Window
		Public Sub New()
			InitializeComponent()
		End Sub
	End Class

	Public Class CustomRichEditUICommand
		Implements ICommand
		Private Shared ReadOnly customCommand_Renamed As New CustomRichEditUICommand("CustomCommand")
		Public Shared ReadOnly Property CustomCommand() As CustomRichEditUICommand
			Get
				Return customCommand_Renamed
			End Get
		End Property
		Private ReadOnly commandName As String

		Public Sub New()
		End Sub

		Protected Friend Sub New(ByVal commandName As String)
			Me.commandName = commandName
		End Sub

		#Region "ICommand Members"

		Public Custom Event CanExecuteChanged As System.EventHandler Implements ICommand.CanExecuteChanged
			AddHandler(ByVal value As System.EventHandler)
			End AddHandler
			RemoveHandler(ByVal value As System.EventHandler)
			End RemoveHandler
			RaiseEvent(ByVal sender As System.Object, ByVal e As System.EventArgs)
			End RaiseEvent
		End Event

		Public Function CanExecute(ByVal parameter As Object) As Boolean Implements ICommand.CanExecute
			Return True
		End Function

		Public Sub Execute(ByVal parameter As Object) Implements ICommand.Execute
			If commandName <> "CustomCommand" Then
				Throw New System.ApplicationException("Unknown command")
			End If

			Dim richEditControl As RichEditControl = CType(parameter, RichEditControl)
			DXMessageBox.Show("Number of words in the document: " & richEditControl.WordsCount.ToString())
		End Sub

		#End Region
	End Class
End Namespace
