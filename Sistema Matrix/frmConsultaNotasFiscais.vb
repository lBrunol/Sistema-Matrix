Imports System.Data.OleDb
Imports System.Data
Imports Sistema_Matrix.clsConexaoBanco
Public Class frmConsultaNotasFiscais
    'Declaração de variáveis públicas
    Public tabela As DataTable
    Public leitor As OleDbDataReader
    Public strsql As String
    Public strsql2 As String
    Public valorCodCliente As Integer
    Public objBanco As New clsConexaoBanco

    Private Sub chkEntreDatas_CheckedChanged(sender As Object, e As EventArgs) Handles chkEntreDatas.CheckedChanged
        If mskDataFinal.Enabled = False Then
            mskDataFinal.Enabled = True
        Else
            mskDataFinal.Enabled = False
        End If
    End Sub

    Private Sub NotasFiscais_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        modFuncoes.HabilitaBotaoLogOff()
    End Sub

    Private Sub NotasFiscais_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtCnpjCpfTomador_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtCnpjCpfTomador.TextChanged
        strsql = "SELECT notaFiscal.notCodigo, notaFiscal.notHora, notaFiscal.notValor, notaFiscal.notData, notaFiscal.notCodVer, notaFiscal.notOutrasInformacoes, notaFiscal.ordCodigo, notaFiscal.demCodigo, cliente.cliCodigo, cliente.cliNome FROM (cliente INNER JOIN ordemServico ON cliente.cliCodigo = ordemServico.cliCodigo) INNER JOIN notaFiscal ON ordemServico.ordCodigo = notaFiscal.ordCodigo WHERE cliente.cliNome Like '%" & txtCnpjCpfTomador.Text & "%' ORDER BY cliente.cliNome"
        strsql2 = "SELECT notaFiscal.notCodigo, notaFiscal.notHora, notaFiscal.notValor, notaFiscal.notData, notaFiscal.notCodVer, notaFiscal.notOutrasInformacoes, notaFiscal.ordCodigo, notaFiscal.demCodigo, ordemServiço.cliCodigo, cliente.cliNome FROM notaFiscal INNER JOIN ordemServiço ON notaFiscal.ordCodigo = ordemServiço.ordCodigo INNER JOIN cliente ON ordemServiço.cliCodigo = cliente.cliCodigo ORDER BY notaFiscal.notData, cliente.cliNome"
        filtraNF(txtCnpjCpfTomador, strsql, dtgNotaFiscal, strsql2)

    End Sub

    Private Sub mskDataInicial_TextChanged(sender As System.Object, e As System.EventArgs)
        If chkEntreDatas.Checked = True Then

            strsql = "SELECT notaFiscal.notCodigo, notaFiscal.notHora, notaFiscal.notValor, notaFiscal.notData, notaFiscal.notCodVer, notaFiscal.notOutrasInformacoes, notaFiscal.ordCodigo, notaFiscal.demCodigo, ordemServiço.cliCodigo, cliente.cliNome FROM notaFiscal INNER JOIN ordemServiço ON notaFiscal.ordCodigo = ordemServiço.ordCodigo INNER JOIN cliente ON ordemServiço.cliCodigo = cliente.cliCodigo WHERE notaFiscal.notData BETWEEN '" & mskDataInicial.Text & "*' AND '" & mskDataFinal.Text & "%'  ORDER BY notaFiscal.notData, cliente.cliNome"
            strsql2 = "SELECT notaFiscal.notCodigo, notaFiscal.notHora, notaFiscal.notValor, notaFiscal.notData, notaFiscal.notCodVer, notaFiscal.notOutrasInformacoes, notaFiscal.ordCodigo, notaFiscal.demCodigo, ordemServiço.cliCodigo, cliente.cliNome FROM notaFiscal INNER JOIN ordemServiço ON notaFiscal.ordCodigo = ordemServiço.ordCodigo INNER JOIN cliente ON ordemServiço.cliCodigo = cliente.cliCodigo ORDER BY notaFiscal.notData, cliente.cliNome"
            filtraNFMSK(mskDataInicial, strsql, dtgNotaFiscal, strsql2)

        Else

            strsql = "SELECT notaFiscal.notCodigo, notaFiscal.notHora, notaFiscal.notValor, notaFiscal.notData, notaFiscal.notCodVer, notaFiscal.notOutrasInformacoes, notaFiscal.ordCodigo, notaFiscal.demCodigo, ordemServiço.cliCodigo, cliente.cliNome FROM notaFiscal INNER JOIN ordemServiço ON notaFiscal.ordCodigo = ordemServiço.ordCodigo INNER JOIN cliente ON ordemServiço.cliCodigo = cliente.cliCodigo WHERE notaFiscal.notData>='" & mskDataInicial.Text & "%' ORDER BY notaFiscal.notData, cliente.cliNome"
            strsql2 = "SELECT notaFiscal.notCodigo, notaFiscal.notHora, notaFiscal.notValor, notaFiscal.notData, notaFiscal.notCodVer, notaFiscal.notOutrasInformacoes, notaFiscal.ordCodigo, notaFiscal.demCodigo, ordemServiço.cliCodigo, cliente.cliNome FROM notaFiscal INNER JOIN ordemServiço ON notaFiscal.ordCodigo = ordemServiço.ordCodigo INNER JOIN cliente ON ordemServiço.cliCodigo = cliente.cliCodigo ORDER BY notaFiscal.notData, cliente.cliNome"
            filtraNFMSK(mskDataInicial, strsql, dtgNotaFiscal, strsql2)

        End If
    End Sub

    Private Sub mskDataFinal_MaskInputRejected(sender As System.Object, e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles mskDataFinal.MaskInputRejected
        If chkEntreDatas.Checked = True Then

            strsql = "SELECT notaFiscal.notCodigo, notaFiscal.notHora, notaFiscal.notValor, notaFiscal.notData, notaFiscal.notCodVer, notaFiscal.notOutrasInformacoes, notaFiscal.ordCodigo, notaFiscal.demCodigo, ordemServiço.cliCodigo, cliente.cliNome FROM notaFiscal INNER JOIN ordemServiço ON notaFiscal.ordCodigo = ordemServiço.ordCodigo INNER JOIN cliente ON ordemServiço.cliCodigo = cliente.cliCodigo WHERE notaFiscal.notData BETWEEN '" & mskDataInicial.Text & "%' AND '" & mskDataFinal.Text & "%'  ORDER BY notaFiscal.notData, cliente.cliNome"
            strsql2 = "SELECT notaFiscal.notCodigo, notaFiscal.notHora, notaFiscal.notValor, notaFiscal.notData, notaFiscal.notCodVer, notaFiscal.notOutrasInformacoes, notaFiscal.ordCodigo, notaFiscal.demCodigo, ordemServiço.cliCodigo, cliente.cliNome FROM notaFiscal INNER JOIN ordemServiço ON notaFiscal.ordCodigo = ordemServiço.ordCodigo INNER JOIN cliente ON ordemServiço.cliCodigo = cliente.cliCodigo ORDER BY notaFiscal.notData, cliente.cliNome"
            filtraNFMSK(mskDataFinal, strsql, dtgNotaFiscal, strsql2)

        Else

            strsql = "SELECT notaFiscal.notCodigo, notaFiscal.notHora, notaFiscal.notValor, notaFiscal.notData, notaFiscal.notCodVer, notaFiscal.notOutrasInformacoes, notaFiscal.ordCodigo, notaFiscal.demCodigo, ordemServiço.cliCodigo, cliente.cliNome FROM notaFiscal INNER JOIN ordemServiço ON notaFiscal.ordCodigo = ordemServiço.ordCodigo INNER JOIN cliente ON ordemServiço.cliCodigo = cliente.cliCodigo WHERE notaFiscal.notData<='" & mskDataFinal.Text & "%' ORDER BY notaFiscal.notData, cliente.cliNome"
            strsql2 = "SELECT notaFiscal.notCodigo, notaFiscal.notHora, notaFiscal.notValor, notaFiscal.notData, notaFiscal.notCodVer, notaFiscal.notOutrasInformacoes, notaFiscal.ordCodigo, notaFiscal.demCodigo, ordemServiço.cliCodigo, cliente.cliNome FROM notaFiscal INNER JOIN ordemServiço ON notaFiscal.ordCodigo = ordemServiço.ordCodigo INNER JOIN cliente ON ordemServiço.cliCodigo = cliente.cliCodigo ORDER BY notaFiscal.notData, cliente.cliNome"
            filtraNFMSK(mskDataFinal, strsql, dtgNotaFiscal, strsql2)

        End If
    End Sub

    Private Sub botFaturarNotaFiscal_Click(sender As System.Object, e As System.EventArgs) Handles botFaturarNotaFiscal.Click

    End Sub
End Class