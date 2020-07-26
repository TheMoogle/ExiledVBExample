Imports System
Imports System.Collections.Generic
Imports Exiled.API.Features
Imports Handlers = Exiled.Events.Handlers

Namespace FunnyMessages
    Public Class Plugin
        Inherits Plugin(Of Config)

        Public Overrides ReadOnly Property Author As String = "TheMoogle"
        Public Overrides ReadOnly Property Name As String = "Funny Messages"
        Public Overrides ReadOnly Property Prefix As String = "MFM"
        Public Overrides ReadOnly Property Version As Version = New Version(1, 0, 0)

        Public EventHandler As EventHandlers

        Public Overrides Sub OnEnabled()
            EventHandler = New EventHandlers(Me)
            AddHandler Handlers.Player.Spawning, AddressOf EventHandler.OnPlayerSpawn
            AddHandler Handlers.Player.Died, AddressOf EventHandler.OnPlayerDeath
        End Sub

        Public Overrides Sub OnDisabled()
            RemoveHandler Handlers.Player.Died, AddressOf EventHandler.OnPlayerDeath
            RemoveHandler Handlers.Player.Spawning, AddressOf EventHandler.OnPlayerSpawn
            EventHandler = Nothing
        End Sub

        Public Overrides Sub OnReloaded()
        End Sub
    End Class
End Namespace

