Imports System.IO
Imports System.Text.RegularExpressions
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        On Error Resume Next
        System.IO.Directory.CreateDirectory(My.Computer.FileSystem.SpecialDirectories.Temp & "/HostsBypassWebIndonesia")
        Dim Hostspatched, Hostunpatched, Hostpatching As String

        File.WriteAllBytes(My.Computer.FileSystem.SpecialDirectories.Temp & "/HostsBypassWebIndonesia/hosts-unblock", My.Resources.hosts)

        'Membaca hosts
        Hostspatched = My.Computer.FileSystem.ReadAllText(My.Computer.FileSystem.SpecialDirectories.Temp & "/HostsBypassWebIndonesia/hosts-unblock")
        Hostunpatched = My.Computer.FileSystem.ReadAllText("C:\Windows\System32\drivers\etc\hosts")

        'Menulis hosts
        My.Computer.FileSystem.WriteAllText("C:\Windows\System32\drivers\etc\hosts", Environment.NewLine + Environment.NewLine + Hostspatched, True)

        MsgBox("Patch berkasil!
Patchnya sekali saja ya!")

        'Menghapus temp folder 
        System.IO.Directory.Delete(My.Computer.FileSystem.SpecialDirectories.Temp & "/HostsBypassWebIndonesia", True)
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://github.com/AyraHikari/HostsBypassWebIndonesia")
    End Sub
End Class
