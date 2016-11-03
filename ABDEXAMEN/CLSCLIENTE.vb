Imports System.Data.SqlClient

Public Class CLSCLIENTE
    Public Function listar(ByVal buscar As String) As DataSet
        Dim ds As New DataSet
        Dim objconexion As New CLSCONEXION
        Using cn As New SqlConnection
            Using da As New SqlDataAdapter
                Using cmd As New SqlCommand
                    cn.ConnectionString = objconexion.conexion
                    cmd.Connection = cn
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandText = "USP_LISTAR_CLIENTE"
                    cmd.Parameters.Add("@BUSCAR", SqlDbType.VarChar).Value = buscar
                    da.SelectCommand = cmd
                    cn.Open()
                    da.Fill(ds)
                    cn.Close()

                End Using
            End Using
        End Using
        Return ds
    End Function
End Class
