﻿Public Class HapusJabatan

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        LblHapusJabatan.Text() = Jabatan.selectedTableJabatanNama

    End Sub


    Private Sub BtnHapus_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnHapus_Click_1(sender As Object, e As EventArgs) Handles BtnHapus.Click
        Jabatan.jabatan.DeleteDataJabatanByID(Jabatan.selectedTableJabatan)
        Me.Close()
    End Sub
End Class