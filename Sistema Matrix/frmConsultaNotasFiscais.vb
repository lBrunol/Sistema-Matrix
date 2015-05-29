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

    End Sub

    Private Sub NotasFiscais_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        modFuncoes.HabilitaBotaoLogOff()
    End Sub

    Private Sub NotasFiscais_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtCnpjCpfTomador_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtCnpjCpfTomador.TextChanged
        strsql = "SELECT notaFiscal.notCodigo, notaFiscal.notHora, notaFiscal.notValor, notaFiscal.notData, notaFiscal.notCodVer, notaFiscal.notOutrasInformacoes, ordemServico.ordCodigo, notaFiscal.demCodigo, cliente.cliCodigo, cliente.cliNome FROM cliente INNER JOIN (ordemServico INNER JOIN notaFiscal ON ordemServico.ordCodigo = notaFiscal.ordCodigo) ON cliente.cliCodigo = ordemServico.cliCodigo WHERE cliente.cliNome like '%" & txtCnpjCpfTomador.Text & "%' ORDER BY notaFiscal.notData, cliente.cliNome"
        strsql2 = "SELECT notaFiscal.notCodigo, notaFiscal.notHora, notaFiscal.notValor, notaFiscal.notData, notaFiscal.notCodVer, notaFiscal.notOutrasInformacoes, ordemServico.ordCodigo, notaFiscal.demCodigo, cliente.cliCodigo, cliente.cliNome FROM cliente INNER JOIN (ordemServico INNER JOIN notaFiscal ON ordemServico.ordCodigo = notaFiscal.ordCodigo) ON cliente.cliCodigo = ordemServico.cliCodigo ORDER BY notaFiscal.notData, cliente.cliNome"
        filtraNF(txtCnpjCpfTomador, strsql, dtgNotaFiscal, "notCodigo", "notHora", "notValor", "notData", "notCodVer", "notOutrasInformacoes", "ordCodigo", "demCodigo", "cliCodigo", "cliNome", strsql2)


    End Sub


    Private Sub botFaturarNotaFiscal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botFaturarNotaFiscal.Click

    End Sub



    Private Sub dtpDataInicial_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDataInicial.ValueChanged
        If chkEntreDatas.Checked = True Then

            strsql = "SELECT notaFiscal.notCodigo, notaFiscal.notHora, notaFiscal.notValor, notaFiscal.notData, notaFiscal.notCodVer, notaFiscal.notOutrasInformacoes, ordemServico.ordCodigo, notaFiscal.demCodigo, cliente.cliCodigo, cliente.cliNome FROM cliente INNER JOIN (ordemServico INNER JOIN notaFiscal ON ordemServico.ordCodigo = notaFiscal.ordCodigo) ON cliente.cliCodigo = ordemServico.cliCodigo WHERE notaFiscal.notData BETWEEN #" & dtpDataInicial.Value.ToString & "# AND #" & dtpDataFinal.Value.ToString & "#  ORDER BY notaFiscal.notData, cliente.cliNome"
            strsql2 = "SELECT notaFiscal.notCodigo, notaFiscal.notHora, notaFiscal.notValor, notaFiscal.notData, notaFiscal.notCodVer, notaFiscal.notOutrasInformacoes, ordemServico.ordCodigo, notaFiscal.demCodigo, cliente.cliCodigo, cliente.cliNome FROM cliente INNER JOIN (ordemServico INNER JOIN notaFiscal ON ordemServico.ordCodigo = notaFiscal.ordCodigo) ON cliente.cliCodigo = ordemServico.cliCodigo ORDER BY notaFiscal.notData, cliente.cliNome"
            filtraNFDTP(dtpDataInicial, strsql, dtgNotaFiscal, "notCodigo", "notHora", "notValor", "notData", "notCodVer", "notOutrasInformacoes", "ordCodigo", "demCodigo", "cliCodigo", "cliNome", strsql2)
            txtCnpjCpfTomador.Text = ""
        Else

            strsql = "SELECT notaFiscal.notCodigo, notaFiscal.notHora, notaFiscal.notValor, notaFiscal.notData, notaFiscal.notCodVer, notaFiscal.notOutrasInformacoes, ordemServico.ordCodigo, notaFiscal.demCodigo, cliente.cliCodigo, cliente.cliNome FROM cliente INNER JOIN (ordemServico INNER JOIN notaFiscal ON ordemServico.ordCodigo = notaFiscal.ordCodigo) ON cliente.cliCodigo = ordemServico.cliCodigo WHERE notaFiscal.notData>=#" & dtpDataInicial.Value.ToString & "# ORDER BY notaFiscal.notData, cliente.cliNome"
            strsql2 = "SELECT notaFiscal.notCodigo, notaFiscal.notHora, notaFiscal.notValor, notaFiscal.notData, notaFiscal.notCodVer, notaFiscal.notOutrasInformacoes, ordemServico.ordCodigo, notaFiscal.demCodigo, cliente.cliCodigo, cliente.cliNome FROM cliente INNER JOIN (ordemServico INNER JOIN notaFiscal ON ordemServico.ordCodigo = notaFiscal.ordCodigo) ON cliente.cliCodigo = ordemServico.cliCodigo ORDER BY notaFiscal.notData, cliente.cliNome"
            filtraNFDTP(dtpDataInicial, strsql, dtgNotaFiscal, "notCodigo", "notHora", "notValor", "notData", "notCodVer", "notOutrasInformacoes", "ordCodigo", "demCodigo", "cliCodigo", "cliNome", strsql2)
            txtCnpjCpfTomador.Text = ""
        End If

    End Sub

    Private Sub dtpDataFinal_ValueChanged(sender As System.Object, e As System.EventArgs) Handles dtpDataFinal.ValueChanged
        If chkEntreDatas.Checked = True Then

            strsql = "SELECT notaFiscal.notCodigo, notaFiscal.notHora, notaFiscal.notValor, notaFiscal.notData, notaFiscal.notCodVer, notaFiscal.notOutrasInformacoes, ordemServico.ordCodigo, notaFiscal.demCodigo, cliente.cliCodigo, cliente.cliNome FROM cliente INNER JOIN (ordemServico INNER JOIN notaFiscal ON ordemServico.ordCodigo = notaFiscal.ordCodigo) ON cliente.cliCodigo = ordemServico.cliCodigo WHERE notaFiscal.notData BETWEEN #" & dtpDataInicial.Value.ToString & "# AND #" & dtpDataFinal.Value.ToString & "#  ORDER BY notaFiscal.notData, cliente.cliNome"
            strsql2 = "SELECT notaFiscal.notCodigo, notaFiscal.notHora, notaFiscal.notValor, notaFiscal.notData, notaFiscal.notCodVer, notaFiscal.notOutrasInformacoes, ordemServico.ordCodigo, notaFiscal.demCodigo, cliente.cliCodigo, cliente.cliNome FROM cliente INNER JOIN (ordemServico INNER JOIN notaFiscal ON ordemServico.ordCodigo = notaFiscal.ordCodigo) ON cliente.cliCodigo = ordemServico.cliCodigo ORDER BY notaFiscal.notData, cliente.cliNome"
            filtraNFDTP(dtpDataInicial, strsql, dtgNotaFiscal, "notCodigo", "notHora", "notValor", "notData", "notCodVer", "notOutrasInformacoes", "ordCodigo", "demCodigo", "cliCodigo", "cliNome", strsql2)
            txtCnpjCpfTomador.Text = ""
        Else

            strsql = "SELECT notaFiscal.notCodigo, notaFiscal.notHora, notaFiscal.notValor, notaFiscal.notData, notaFiscal.notCodVer, notaFiscal.notOutrasInformacoes, ordemServico.ordCodigo, notaFiscal.demCodigo, cliente.cliCodigo, cliente.cliNome FROM cliente INNER JOIN (ordemServico INNER JOIN notaFiscal ON ordemServico.ordCodigo = notaFiscal.ordCodigo) ON cliente.cliCodigo = ordemServico.cliCodigo WHERE notaFiscal.notData<=#" & dtpDataFinal.Value.ToString & "# ORDER BY notaFiscal.notData, cliente.cliNome"
            strsql2 = "SELECT notaFiscal.notCodigo, notaFiscal.notHora, notaFiscal.notValor, notaFiscal.notData, notaFiscal.notCodVer, notaFiscal.notOutrasInformacoes, ordemServico.ordCodigo, notaFiscal.demCodigo, cliente.cliCodigo, cliente.cliNome FROM cliente INNER JOIN (ordemServico INNER JOIN notaFiscal ON ordemServico.ordCodigo = notaFiscal.ordCodigo) ON cliente.cliCodigo = ordemServico.cliCodigo ORDER BY notaFiscal.notData, cliente.cliNome"
            filtraNFDTP(dtpDataInicial, strsql, dtgNotaFiscal, "notCodigo", "notHora", "notValor", "notData", "notCodVer", "notOutrasInformacoes", "ordCodigo", "demCodigo", "cliCodigo", "cliNome", strsql2)
            txtCnpjCpfTomador.Text = ""
        End If
    End Sub
End Class