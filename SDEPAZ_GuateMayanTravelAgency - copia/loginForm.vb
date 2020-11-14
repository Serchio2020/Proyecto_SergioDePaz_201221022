Public Class loginForm
    Dim Admin As Integer = 0
    Dim User As Integer = 0



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim Admin As Integer = 0
        Dim User As Integer = 0
        Dim displayNo As Integer = 0

        If txtUser.Text = ("administrador") Then
            Admin += 1
        End If

        If txtPassword.Text = ("admin") Then
            Admin += 1
        End If

        If Admin = 2 And User = 0 Then
            MsgBox("Acceso Otorgado")
            txtUser.Text = ""
            txtPassword.Text = ""
            adminForm.Show()




        End If


        If txtUser.Text = ("agente1") Then

            User += 1

        End If

        If txtPassword.Text = ("agente1") Then

            User += 1


        End If

        If User = 2 And Admin <> 2 Then

            MsgBox("Acceso Otorgado")
            txtUser.Text = ""
            txtPassword.Text = ""
            clienteForm.Show()

        End If



        If Admin <> 2 And User <> 2 And displayNo = 0 Then

            MsgBox("Acceso denegado, usuario o contraseña incorrectos")
            Admin = 0
            User = 0

        End If











    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub
End Class
