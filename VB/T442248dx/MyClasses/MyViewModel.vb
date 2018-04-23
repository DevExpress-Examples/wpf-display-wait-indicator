Imports System
Imports System.ComponentModel

Namespace dxSampleGrid
    Partial Public Class MyViewModel
        Implements INotifyPropertyChanged

        Public Sub New()
            WaitIndicatorText = "Loading..."
        End Sub

        Private _isWaitIndicatorVisible As Boolean
        Private _waitIndicatorText As String

        Public Property IsWaitIndicatorVisible() As Boolean
            Get
                Return _isWaitIndicatorVisible
            End Get

            Set(ByVal value As Boolean)
                _isWaitIndicatorVisible = value
                RaisePropertyChanged("IsWaitIndicatorVisible")
            End Set
        End Property

        Public Property WaitIndicatorText() As String
            Get
                Return _waitIndicatorText
            End Get

            Set(ByVal value As String)
                _waitIndicatorText = value
                RaisePropertyChanged("WaitIndicatorText")
            End Set
        End Property

        Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
        Private Sub RaisePropertyChanged(ByVal propertyName As String)
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
        End Sub
    End Class
End Namespace
