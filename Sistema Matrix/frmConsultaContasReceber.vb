Public Class frmConsultaContasReceber
    'Declaração de variáveis públicas
    Public queryFiltro As String
    Public queryAll As String = "SELECT contasReceber.ctrCodigo as Código, cliente.cliNome as Nome, cliente.cliEndereco as Endereço, contasReceber.ctrDataEmissao as [Data de Emissão], contasReceber.ctrDataVencimento as [Data de Vencimento], contasReceber.ctrValorEmitido as [Valor Emitido], contasReceber.ctrDataPagamento as [Data de Pagamento], contasReceber.ctrDesc as Desconto, contasReceber.ctrJuros as Juros, contasReceber.ctrValorPago as [Valor Pago], tiposPagamento.tpaDescricao as [Tipo de pagamento], notaFiscal.notCodigo as [Código da Nota Fiscal]FROM ((((tiposPagamento INNER JOIN contasReceber ON tiposPagamento.tpaCodigo = contasReceber.tpaCodigo) INNER JOIN notaFiscal ON contasReceber.notCodigo = notaFiscal.notCodigo) INNER JOIN ordemServico ON notaFiscal.ordCodigo = ordemServico.ordCodigo) INNER JOIN cliente ON ordemServico.cliCodigo = cliente.cliCodigo)"
    Public objBanco As New clsConexaoBanco
    Private Sub chkEntreDatas_CheckedChanged(sender As Object, e As EventArgs) Handles chkEntreDatas.CheckedChanged
        If txtDataFinal.Enabled = False Then
            txtDataFinal.Enabled = True
        Else
            txtDataFinal.Enabled = False
        End If
    End Sub

    Private Sub ContasReceber_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objBanco.carregaDataGrid(dtgContasReceber, queryAll)
    End Sub

    Private Sub ContasReceber_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        modFuncoes.HabilitaBotaoLogOff()
    End Sub

    Private Sub txtNomeCliente_TextChanged(sender As Object, e As EventArgs) Handles txtNomeCliente.TextChanged
        queryFiltro = queryAll + "WHERE cliente.cliNome LIKE '%" & txtNomeCliente.Text & "%' ORDER BY cliNome"
        modFuncoes.filtraDataGrid(txtNomeCliente, dtgContasReceber, queryFiltro, queryAll)
    End Sub

    Private Sub cboStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboStatus.SelectedIndexChanged
        If cboStatus.Text = "Pendente" Then
            queryFiltro = queryAll + "WHERE contasReceber.ctrDataVencimento >= #06/04/2015# AND contasReceber.ctrDataPagamento < '0' ORDER BY contasReceber.ctrDataPagamento"
            modFuncoes.filtraDataGrid(txtNomeCliente, dtgContasReceber, queryFiltro, queryAll, True)
        ElseIf cboStatus.Text = "Atrasado" Then
            queryFiltro = queryAll + "WHERE contasReceber.ctrDataVencimento < #06/04/2015# AND contasReceber.ctrDataPagamento < '0' ORDER BY contasReceber.ctrDataPagamento"
            modFuncoes.filtraDataGrid(txtNomeCliente, dtgContasReceber, queryFiltro, queryAll, True)
        ElseIf cboStatus.Text = "Pago" Then
            queryFiltro = queryAll + "WHERE contasReceber.ctrDataPagamento Not is Null ORDER BY contasReceber.ctrDataPagamento"
            modFuncoes.filtraDataGrid(txtNomeCliente, dtgContasReceber, queryFiltro, queryAll, True)
        End If
    End Sub
End Class