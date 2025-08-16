Imports Microsoft.Data.SqlClient
Public Class data
    Public conn As New SqlConnection("Data Source=MSI\MSSQLSERVER01;Initial Catalog=QuanLySach;Integrated Security=True;Trust Server Certificate=True")
    Public Function ThucHienLenh(sql As String, Optional paramList As List(Of SqlParameter) = Nothing) As Boolean
        Try
            conn.Open()
            Dim cmd As New SqlCommand(sql, conn)

            If paramList IsNot Nothing Then
                For Each p In paramList
                    cmd.Parameters.Add(p)
                Next
            End If

            cmd.ExecuteNonQuery()
            conn.Close()
            Return True
        Catch ex As Exception
            MessageBox.Show("Lỗi: " & ex.Message)
            conn.Close()
            Return False
        End Try
    End Function

    Public Overrides Function Equals(obj As Object) As Boolean
        Dim data = TryCast(obj, data)
        Return data IsNot Nothing AndAlso
               EqualityComparer(Of SqlConnection).Default.Equals(conn, data.conn)
    End Function

    Public Overrides Function GetHashCode() As Integer
        Return HashCode.Combine(conn)
    End Function
End Class
