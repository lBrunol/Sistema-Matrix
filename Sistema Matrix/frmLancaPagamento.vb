Imports System.Data.OleDb

Public Class frmLancaPagamento
    'Recebe o código da ordem do formulário de ordens de serviço
    Public codDocumentoAtual As Integer = frmConsultaContasReceber.codDocumento
    'Instância da classe de conexão ao banco
    Private objBanco As New clsConexaoBanco
    'Variável que le os dados da tabela
    Private tabela As DataTable
    'Variável usada para os comandos select
    Private leitor As OleDbDataReader
    'String que armazena os comandos SQL
    Private strSQL As String

    Private Sub frmLancaPagamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        strSQL = "SELECT ctrCodigo, ctrDataVencimento FROM contasReceber WHERE ctrCodigo =" & codDocumentoAtual
        leitor = objBanco.ExecutaDataRead(strSQL)
        leitor.Read()
        txtNumeroDocumento.Text = leitor.Item(0).ToString
        mtxDataVencimento.Text = leitor.Item(1).ToString
    End Sub

    Private Sub botSalvar_Click(sender As Object, e As EventArgs) Handles botSalvar.Click
        Try
            If mtxDataPagamento.MaskFull = False Or txtValorPago.Text = "" Then
                MsgBox("Por favor, preencha os campos obrigatórios", vbExclamation, "Aviso")
            Else
                strSQL = "UPDATE contasReceber SET ctrDataPagamento ='" & mtxDataPagamento.Text & "', ctrValorPago = '" & txtValorPago.Text & "' WHERE ctrCodigo =" & codDocumentoAtual
                objBanco.ExecutaQuery(strSQL)
                MsgBox("Lançado com Sucesso", vbInformation, "Sucesso")
                objBanco.carregaDataGrid(frmConsultaContasReceber.dtgContasReceber, frmConsultaContasReceber.queryAll)
                Me.Close()
            End If
        Catch exc As SqlClient.SqlException
            MsgBox("Erro com banco de dados" & vbCrLf & Err.Description, vbCritical, "Erro com Banco de dados")
        Catch exc As Exception
            MsgBox("Erro" & vbCrLf & Err.Number & vbCrLf & Err.Description, vbCritical, "Erro")
        End Try
    End Sub

    Private Sub botCancelar_Click(sender As Object, e As EventArgs) Handles botCancelar.Click
        Me.Close()
    End Sub

    Private Sub txtValorPago_Leave(sender As Object, e As EventArgs) Handles txtValorPago.Leave
        modFuncoes.formataValor(txtValorPago)
    End Sub
End Class