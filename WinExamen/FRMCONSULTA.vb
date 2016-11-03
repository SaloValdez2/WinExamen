Public Class FRMCONSULTA
    Dim objcliente As New ABDEXAMEN.CLSCLIENTE

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Call listar(Me.TextBox1.Text)
    End Sub
    Sub listar(ByVal buscar As String)
        Dim dt As New DataTable
        dt = objcliente.listar(buscar).Tables(0)
        If dt.Rows.Count > 0 Then
            DG.DataSource = dt
        End If
    End Sub

    Private Sub FRMCONSULTA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call listar("")
    End Sub
End Class
