﻿Public Class Person
    Private _name As String

    Public Property Name() As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            _name = value
        End Set
    End Property

    Private _mobile As Long

    Public Property Mobile() As Long

        Get
            Return _mobile
        End Get
        Set(ByVal value As Long)
            _mobile = value
        End Set
    End Property
End Class
