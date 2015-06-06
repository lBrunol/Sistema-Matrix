Public Class frmConsultaContasReceber
    'Declaração de variáveis públicas
    Public queryFiltro As String
    Public queryAll As String = "SELECT contasReceber.ctrCodigo as Código, cliente.cliNome as Nome, cliente.cliEndereco as Endereço, contasReceber.ctrDataEmissao as [Data de Emissão], contasReceber.ctrDataVencimento as [Data de Vencimento], contasReceber.ctrValorEmitido as [Valor Emitido], contasReceber.ctrDataPagamento as [Data de Pagamento], contasReceber.ctrDesc as Desconto, contasReceber.ctrJuros as Juros, contasReceber.ctrValorPago as [Valor Pago], tiposPagamento.tpaDescricao as [Tipo de pagamento], notaFiscal.notCodigo as [Código da Nota Fiscal]FROM ((((tiposPagamento INNER JOIN contasReceber ON tiposPagamento.tpaCodigo = contasReceber.tpaCodigo) INNER JOIN notaFiscal ON contasReceber.notCodigo = notaFiscal.notCodigo) INNER JOIN ordemServico ON notaFiscal.ordCodigo = ordemServico.ordCodigo) INNER JOIN cliente ON ordemServico.cliCodigo = cliente.cliCodigo)"
    Public objBanco As New clsConexaoBanco
    Public codDocumento As Integer = 0
    Private Sub chkEntreDatas_CheckedChanged(sender As Object, e As EventArgs) Handles chkEntreDatas.CheckedChanged
        If mtxDataFinal.Enabled = False Then
            mtxDataFinal.Enabled = True
        Else
            mtxDataFinal.Enabled = False
        End If
        If chkEntreDatas.Checked = False Then
            objBanco.carregaDataGrid(dtgContasReceber, queryAll)
            mtxDataFinal.Text = ""
            mtxDataInicial.Text = ""
        End If
    End Sub

    Private Sub ContasReceber_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objBanco.carregaDataGrid(dtgContasReceber, queryAll)
        dtgContasReceber.Columns(5).DefaultCellStyle.Format = "C"
        dtgContasReceber.Columns(7).DefaultCellStyle.Format = "C"
        dtgContasReceber.Columns(8).DefaultCellStyle.Format = "C"
        dtgContasReceber.Columns(9).DefaultCellStyle.Format = "C"
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
            queryFiltro = queryAll + "WHERE contasReceber.ctrDataVencimento >= #06/04/2015# AND(contasReceber.ctrDataPagamento < '0' OR contasReceber.ctrDataPagamento Is Null) ORDER BY contasReceber.ctrDataPagamento"
            modFuncoes.filtraDataGrid(txtNomeCliente, dtgContasReceber, queryFiltro, queryAll, True)
        ElseIf cboStatus.Text = "Atrasado" Then
            queryFiltro = queryAll + "WHERE contasReceber.ctrDataVencimento < #06/04/2015# AND (contasReceber.ctrDataPagamento < '0' OR contasReceber.ctrDataPagamento Is Null) ORDER BY contasReceber.ctrDataPagamento"
            modFuncoes.filtraDataGrid(txtNomeCliente, dtgContasReceber, queryFiltro, queryAll, True)
        ElseIf cboStatus.Text = "Pago" Then
            queryFiltro = queryAll + "WHERE contasReceber.ctrDataPagamento Is Not Null AND contasReceber.ctrDataPagamento >'0' ORDER BY contasReceber.ctrDataPagamento"
            modFuncoes.filtraDataGrid(txtNomeCliente, dtgContasReceber, queryFiltro, queryAll, True)
        End If
    End Sub
    Private Sub mtxDataInicial_TextChanged(sender As Object, e As EventArgs) Handles mtxDataInicial.TextChanged
        If mtxDataInicial.MaskFull = True Then
            If chkEntreDatas.Checked = False Then
                queryFiltro = queryAll + "WHERE contasReceber.ctrDataVencimento = #" & CDate(mtxDataInicial.Text).ToString("MM/dd/yyyy") & "# ORDER BY contasReceber.ctrDataPagamento"
                modFuncoes.filtraDataGrid(mtxDataInicial, dtgContasReceber, queryFiltro, queryAll)
            End If
        Else
            objBanco.carregaDataGrid(dtgContasReceber, queryAll)
        End If
    End Sub

    Private Sub mtxDataFinal_TextChanged(sender As Object, e As EventArgs) Handles mtxDataFinal.TextChanged
        If chkEntreDatas.Checked = True Then
            If mtxDataFinal.MaskFull = True Then
                queryFiltro = queryAll + "WHERE contasReceber.ctrDataVencimento >= #" & CDate(mtxDataInicial.Text).ToString("MM/dd/yyyy") & "# AND contasReceber.ctrDataVencimento <= #" & CDate(mtxDataFinal.Text).ToString("MM/dd/yyyy") & "# ORDER BY contasReceber.ctrDataPagamento"
                modFuncoes.filtraDataGrid(mtxDataInicial, dtgContasReceber, queryFiltro, queryAll)
            Else
                objBanco.carregaDataGrid(dtgContasReceber, queryAll)
            End If
        End If
    End Sub

    Private Sub dtgContasReceber_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgContasReceber.CellDoubleClick
        If dtgContasReceber.CurrentRow.Cells(6).Value.ToString <> "" Then
            MsgBox("Este documento já tem a data de pagamento lançada", vbExclamation, "Aviso")
        Else
            codDocumento = dtgContasReceber.CurrentRow.Cells(0).Value
            frmLancaPagamento.Show()
        End If
    End Sub
    Private Sub botLancaPagamento_Click(sender As Object, e As EventArgs) Handles botLancaPagamento.Click
        If codDocumento = 0 Then
            MsgBox("Não há linha selecionada", vbExclamation, "Aviso")
        ElseIf dtgContasReceber.CurrentRow.Cells(6).Value.ToString <> "" Then
            MsgBox("Este documento já tem a data de pagamento lançada", vbExclamation, "Aviso")
        Else
            codDocumento = dtgContasReceber.CurrentRow.Cells(0).Value
            frmLancaPagamento.Show()
        End If
    End Sub

    Private Sub dtgContasReceber_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgContasReceber.CellContentClick
        codDocumento = dtgContasReceber.CurrentRow.Cells(0).Value
    End Sub

    Private Sub botFaturarNotaFiscal_Click(sender As Object, e As EventArgs) Handles botFaturarNotaFiscal.Click
        relContasReceber.Show()
    End Sub
End Class