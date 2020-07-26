Imports Exiled
Imports UnityEngine

Namespace FunnyMessages
    Public Class EventHandlers
        Private ReadOnly plugin As Plugin

        Public Sub New(ByVal plugin As Plugin)
            CSharpImpl.__Assign(Me.plugin, plugin)
        End Sub

        Public Sub OnPlayerSpawn(ByVal ev As Exiled.Events.EventArgs.SpawningEventArgs)
            ev.Player.Broadcast(5, $"You have spawn as {ev.Player.Role}")
        End Sub

        Public Sub OnPlayerDeath(ByVal ev As Exiled.Events.EventArgs.DiedEventArgs)
            ev.Killer.Broadcast(2, $"You Killed {ev.Target.Nickname}")
            ev.Target.Broadcast(5, $"You were Killed by {ev.Killer.Nickname}")
        End Sub

        Private Class CSharpImpl
            Public Shared Function __Assign(Of T)(ByRef target As T, ByVal value As T) As T
                target = value
                Return value
            End Function
        End Class
    End Class
End Namespace
