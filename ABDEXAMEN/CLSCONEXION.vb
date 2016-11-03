Public Class CLSCONEXION
    Public Function conexion() As String
        Dim cn As String = "Data Source=CASTLE;Initial Catalog=DBEXAMEN;Integrated Security=True"
        Return cn

    End Function
End Class
