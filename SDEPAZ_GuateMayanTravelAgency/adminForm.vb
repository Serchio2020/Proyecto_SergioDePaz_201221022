Imports SDEPAZ_GuateMayanTravelAgency


Public Class adminForm

    Private db As AgenciaTravelDataSet1


    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub adminForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'AgenciaTravelDataSet1.Clientes' Puede moverla o quitarla según sea necesario.
        'Me.ClientesTableAdapter1.Fill(Me.AgenciaTravelDataSet1.Clientes)
        '<TODO: esta línea de código carga datos en la tabla 'AgenciaTravelDataSet.Clientes' Puede moverla o quitarla según sea necesario.
        'Me.ClientesTableAdapter.Fill(Me.AgenciaTravelDataSet.Clientes)

        db = New AgenciaTravelDataSet()
        db.Clientes.Load()
        ClientesBindingSource.DataSource = db.Clientes.Locale





    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()

    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ClientesBindingSource.AddNew()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If MessageBox.Show("Seguro desea eliminar los registros?", "Mensaje", MessageBoxButtons.YesNo) = DialogResult.Yes Then

            ClientesBindingSource.RemoveCurrent()
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        db.AcceptChanges()

    End Sub
End Class