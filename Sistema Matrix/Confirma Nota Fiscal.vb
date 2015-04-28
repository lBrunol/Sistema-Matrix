Imports System.Data
Imports System.Data.OleDb
Imports Sistema_Matrix.ConexaoAccess

Public Class confirmaNotaFiscal
    'Recebe o código da ordem do formulário de ordens de serviço
    Public codOrdemAtual As Integer = Form6.codOrdemServicoAtual
    'Instância da classe de conexão ao banco
    Private objBanco As New ConexaoAccess
    'Variável que le os dados da tabela
    Private tabela As DataTable
    'Variável usada para os comandos select
    Private leitor As OleDbDataReader
    'String que armazena os comandos SQL
    Private strSQL As String
    Private Sub atribuiTag(formReferenciado As Control)
        'Função que faz um loop em todos os controles do formulário para atribuir a a tag "auto" para que eles possam ser
        'desabilitados posteriormente
        Dim controleForm As Control
        For Each controleForm In formReferenciado.Controls
            controleForm.Tag = "Auto"
            If controleForm.Controls.Count > 0 Then
                atribuiTag(controleForm)
            End If
        Next
    End Sub
    Private Sub Nota_Fiscal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'codOrdemAtual = 8

        Dim codCliente As Integer

        strSQL = "SELECT cliCodigo FROM ordemServico WHERE ordCodigo = " & codOrdemAtual
        leitor = objBanco.ExecutaDataRead(strSQL)
        leitor.Read()
        codCliente = CInt(leitor.Item(0))

        'Executa a tribuição das tags
        atribuiTag(Me)
        txtOutrasInformacoes.Tag = ""
        'Desabilita os campos de preenchimento automático
        habilitaDesabilitaControles(Me, True)

        Try


            'Carrega os dados do presatador
            strSQL = "SELECT demCodigo, demRazaoSocial, demInscricaoMunicipal, demEndereco FROM dadosEmitente"
            leitor = objBanco.ExecutaDataRead(strSQL)
            leitor.Read()

            txtCnpjCpfTomador.Text = leitor.Item(0).ToString
            txtRazaoSocialNomeTomador.Text = leitor.Item(1).ToString
            txtInscricaoMunicipalTomador.Text = leitor.Item(2).ToString
            txtEnderecoTomador.Text = leitor.Item(3).ToString
            txtMunicipioTomador.Text = "São Paulo"
            txtUFTomador.Text = "SP"

            'Carrega os dados do tomador
            strSQL = "SELECT cliTipo FROM cliente"
            leitor = objBanco.ExecutaDataRead(strSQL)
            leitor.Read()

            If leitor.Item(0).ToString = "F" Then
                strSQL = "SELECT cliPessoaFisica.cliCPF, cliente.cliNome, cliente.cliEndereco, cliente.cliCidade, cliente.cliUF, cliente.cliEmail FROM cliente INNER JOIN cliPessoaFisica ON cliente.cliCodigo = cliPessoaFisica.cliCodigo WHERE cliente.cliCodigo = " & codCliente
                leitor = objBanco.ExecutaDataRead(strSQL)
                leitor.Read()

                txtCnpjCpfPrestador.Text = leitor.Item(0).ToString
                txtRazaoSocialNomePrestador.Text = leitor.Item(1).ToString
                txtEnderecoPrestador.Text = leitor.Item(2).ToString
                txtMunicipioPrestador.Text = leitor.Item(3).ToString
                txtUFPrestador.Text = leitor.Item(4).ToString
                txtEmailPrestador.Text = leitor.Item(5).ToString
                txtInscricaoMunicipalPrestador.Text = "-"
            End If

        Catch exc As SqlClient.SqlException
            MsgBox("Erro com banco de dados" & vbCrLf & Err.Description, vbCritical, "Erro com Banco de dados")
        Catch exc As Exception
            MsgBox("Erro" & vbCrLf & Err.Number & vbCrLf & Err.Description, vbCritical, "Erro")
        Finally
            'Sub que fecha as conexões com banco e zera as variáveis usadas
            zeraVariaveisBanco()
        End Try
    End Sub
    Private Sub confirmaNotaFiscal_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Funcoes.HabilitaBotaoLogOff()
    End Sub

    Private Sub botCancelar_Click(sender As Object, e As EventArgs) Handles botCancelar.Click
        If MsgBox("Deseja cancelar o faturamento da nota?", vbQuestion & vbYesNo) = vbYes Then
            Me.Close()
        End If
    End Sub
    Private Sub zeraVariaveisBanco()
        'Fecha a conexão com banco
        objBanco.DesconectarBanco()
        'Zera a variável strSQL
        strSQL = String.Empty
        'Testa se a variável leitor foi alterada, se sim a conexão com banco de dados será fechada
        If leitor IsNot Nothing Then
            leitor.Close()
            leitor = Nothing
        End If
    End Sub
End Class