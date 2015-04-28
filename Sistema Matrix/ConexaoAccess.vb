Imports System.Data.OleDb
Imports System.Data.ConnectionState
Imports System.Data.DataSet
Public Class ConexaoAccess
    Private varConexao As New OleDbConnection ' objeto oledb Connection
    Private varComando As New OleDbCommand ' objeto oledb Command
    Private varLeitor As OleDbDataReader ' objeto oledb Recordset
    Private varAdapter As New OleDbDataAdapter
    Private varEstadoCon As New ConnectionState
    Public Sub New()

    End Sub
    Public Sub ConectarBanco()
        'Armazena a string de conexão ao banco
        varConexao = New OleDb.OleDbConnection("provider = microsoft.ace.oledb.12.0; data source = dados/banco.accdb")
        'Verifica se a conexão já está aberta
        If Not varConexao.State = ConnectionState.Open Then
            varConexao.Open()
        End If
    End Sub
    Public Sub DesconectarBanco()
        varConexao = New OleDb.OleDbConnection("provider = microsoft.ace.oledb.12.0; data source = dados/banco.accdb")
        'Verifica se a conexão está aberta
        If varConexao.State = ConnectionState.Open Then
            varConexao.Close()
            varConexao.Dispose()
            varConexao = Nothing
        End If
    End Sub
    Public Function ExecutaDataTable(ByVal sql As String) As DataTable
        Dim mDataTable As New DataTable
        Try
            ConectarBanco()
            varComando.CommandType = CommandType.Text
            varComando.CommandText = sql
            varComando.Connection = varConexao
            varAdapter.SelectCommand = varComando
            varAdapter.Fill(mDataTable)
            varAdapter.Dispose()
            Return mDataTable
        Catch ex As SqlClient.SqlException
            MessageBox.Show(ex.Number & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            If Err.Number = 5 Then

            Else
                MessageBox.Show(Err.Number & " " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Try
        Return mDataTable
    End Function
    Public Sub carregaDataGrid(ByVal dataGrid As DataGridView, ByVal sql As String)
        Dim mDataTable As New DataTable
        Try
            ConectarBanco()
            mDataTable = ExecutaDataTable(sql)
            dataGrid.DataSource = mDataTable
            dataGrid.Refresh()
        Catch ex As SqlClient.SqlException
            MessageBox.Show(ex.Number & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            If Err.Number = 5 Then

            Else
                MessageBox.Show(Err.Number & " " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Try
    End Sub
    Public Function ExecutaDataRead(ByVal sql As String) As OleDbDataReader
        'varLeitor = Nothing
        Try
            ConectarBanco()
            varComando.CommandType = CommandType.Text
            varComando.CommandText = sql
            varComando.Connection = varConexao
            varLeitor = varComando.ExecuteReader()
            varComando.Dispose()
            Return varLeitor
        Catch ex As SqlClient.SqlException
            MessageBox.Show(ex.Number & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            'If Err.Number = 5 Then

            ' Else
            MessageBox.Show(Err.Number & " " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'End If
        End Try
        Return varLeitor
    End Function
    Public Function ExecutaQuery(ByVal sql As String) As OleDbCommand
        'Método que seleciona os dados na tabela
        'Try
        ConectarBanco()
        varComando.CommandType = CommandType.Text
        varComando.CommandText = sql
        varComando.Connection = varConexao
        varComando.ExecuteNonQuery()
        varComando.Dispose()
        Return varComando
        'Catch ex As SqlClient.SqlException
        'MessageBox.Show(ex.Number & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ' Catch ex As Exception
        ' If Err.Number = 5 Then

        ' Else
        'MessageBox.Show(Err.Number & " " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ' End If
        'End Try
        Return varComando
    End Function
End Class

