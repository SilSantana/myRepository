﻿Public Class Form1

    ' Author: Silvana  V1.0

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If Not txtName.Text = "" Then
            lstNames.Items.Add(txtName.Text)
        End If

        txtName.Text = ""
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
