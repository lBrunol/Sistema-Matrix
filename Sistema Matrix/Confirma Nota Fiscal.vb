Imports System.Data
Imports System.Data.OleDb
Imports Sistema_Matrix.ConexaoAccess
Imports System.Math

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
    'Armazena o código da nota
    Private valorCodigo As Integer
    'Armazena a quantidade de parcelas dos boletos
    Private quantidadeParcelasBoleto As Integer
    'Armazena a quantidade de parcelas dos cartões
    Private quantidadeParcelasCartao As Integer

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
        botFaturarNotaFiscal.Select()
        'Armazena o código do cliente
        Dim codCliente As Integer

        'Verifica o código do cliente que abriu a ordem
        strSQL = "SELECT cliCodigo FROM ordemServico WHERE ordCodigo = " & codOrdemAtual
        leitor = objBanco.ExecutaDataRead(strSQL)
        leitor.Read()
        codCliente = CInt(leitor.Item(0))

        'Executa a tribuição das tags
        atribuiTag(Me)
        'Retira a tag da textbox que não necessita estar desabilitada
        txtOutrasInformacoes.Tag = ""
        txtNomeTitular.Tag = ""
        txtSSN.Tag = ""
        txtNumCartao.Tag = ""
        'Desabilita os campos de preenchimento automático
        habilitaDesabilitaControles(Me, True)

        Try
            'Carrega os dados do presatador
            strSQL = "SELECT demCodigo, demRazaoSocial, demInscricaoMunicipal, demEndereco FROM dadosEmitente"
            leitor = objBanco.ExecutaDataRead(strSQL)
            leitor.Read()

            'Atribui os valores retornados na consulta as text box
            txtCnpjCpfTomador.Text = leitor.Item(0).ToString
            txtRazaoSocialNomeTomador.Text = leitor.Item(1).ToString
            txtInscricaoMunicipalTomador.Text = leitor.Item(2).ToString
            txtEnderecoTomador.Text = leitor.Item(3).ToString
            txtMunicipioTomador.Text = "São Paulo"
            txtUFTomador.Text = "SP"

            'Carrega os dados do tomador
            strSQL = "SELECT cliTipo FROM cliente WHERE cliCodigo = " & codCliente
            leitor = objBanco.ExecutaDataRead(strSQL)
            leitor.Read()

            'Verifica se o cliente é pessoa física ou jurídica
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
            ElseIf leitor.Item(0).ToString = "J" Then
                strSQL = "SELECT cliPessoaJuridica.cliCNPJ, cliPessoaJuridica.cliRazaoSocial, cliPessoaJuridica.cliIM, cliente.cliEndereco, cliente.cliCidade, cliente.cliUF, cliente.cliEmail FROM cliente INNER JOIN cliPessoaJuridica ON cliente.cliCodigo = cliPessoaJuridica.cliCodigo WHERE cliente.cliCodigo = " & codCliente
                leitor = objBanco.ExecutaDataRead(strSQL)
                leitor.Read()
                txtCnpjCpfPrestador.Text = leitor.Item(0).ToString
                txtRazaoSocialNomePrestador.Text = leitor.Item(1).ToString
                txtInscricaoMunicipalPrestador.Text = leitor.Item(2).ToString
                txtEnderecoPrestador.Text = leitor.Item(3).ToString
                txtMunicipioPrestador.Text = leitor.Item(4).ToString
                txtUFPrestador.Text = leitor.Item(5).ToString
                txtEmailPrestador.Text = leitor.Item(6).ToString
            Else
                MsgBox("Ocorreu um erro na gravação do registro do cliente atual, por favor, reveja o cadastro deste cliente", vbExclamation, "Erro")
                Me.Close()
            End If

            'Carrega a lista com serviços
            strSQL = "SELECT servicos_os.seoQuantidade, servicos.svcNome, servicos.svcCodigoServico, servicos.svcNome, servicos.svcAliquota, servicos.svcValorHora FROM ordemServico INNER JOIN (servicos INNER JOIN servicos_os ON servicos.svcCodigo = servicos_os.svcCodigo) ON ordemServico.ordCodigo = servicos_os.ordCodigo WHERE ordemServico.ordCodigo = " & codOrdemAtual
            'Recebe a consulta
            leitor = objBanco.ExecutaDataRead(strSQL)

            'Armazena o serviço retornado
            Dim armazenaServico As String
            'Vetor que armazena o valor do serviço sem aliquota
            Dim valorServico(50) As Integer
            'Vetor que armazena o valor do serviço + aliquota
            Dim valorServicoAliquota(50) As Integer
            'Vetor que armazena o valor total da nota + aliquota
            Dim valorTotalAliquota As Integer
            'Contador do while
            Dim i As Integer = 0
            'Enquanto houver leitura...
            While leitor.Read()
                'Le os dados de quantidade e serviço e armazena na variável
                armazenaServico = leitor.Item(0).ToString & vbTab & leitor.Item(1)
                'Guarda o valor de cada serviço * quantidade + aliquota
                valorServicoAliquota(i) = (((CInt(leitor.Item(0)) * CInt(leitor.Item(5))) / 100) * 5) + (CInt(leitor.Item(0)) * CInt(leitor.Item(5)))
                'Guarda o valor de cada serviço * quantidade
                valorServico(i) = CInt(leitor.Item(0)) * CInt(leitor.Item(5))
                'Incrementa
                i = i + 1
                'Adiciona os itens na lista
                lstServicos.Items.Add(armazenaServico)
            End While
            'Loop que soma os vetores
            For k As Integer = 0 To i - 1
                valorTotalAliquota = valorTotalAliquota + valorServicoAliquota(k)
            Next
            'Seta o valor total na textbox
            txtValorTotal.Text = FormatCurrency(valorTotalAliquota)
            'Recebe novamente os dados
            leitor = objBanco.ExecutaDataRead(strSQL)
            'Lê novamente
            leitor.Read()
            'Seta o código e nome do serviço
            txtCodigoServico.Text = leitor.Item(2).ToString & " - " & leitor.Item(1).ToString
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

    Private Sub rdbAvista_CheckedChanged(sender As Object, e As EventArgs) Handles rdbAvista.CheckedChanged
        cdbBoleto.Visible = False
        lblSelecioneDias.Visible = False

        lblSSN.Visible = False
        lblNomeTitular.Visible = False
        lblParcelas.Visible = False
        lblBandeira.Visible = False
        lblNumCartao.Visible = False
        txtNomeTitular.Visible = False
        txtNumCartao.Visible = False
        cdbParcelas.Visible = False
        txtSSN.Visible = False
        cdbCartao.Visible = False
    End Sub

    Private Sub rdbBoleto_CheckedChanged(sender As Object, e As EventArgs) Handles rdbBoleto.CheckedChanged
        cdbBoleto.Visible = True
        lblSelecioneDias.Visible = True

        lblSSN.Visible = False
        lblNomeTitular.Visible = False
        lblParcelas.Visible = False
        lblBandeira.Visible = False
        lblNumCartao.Visible = False
        txtNomeTitular.Visible = False
        txtNumCartao.Visible = False
        cdbParcelas.Visible = False
        txtSSN.Visible = False
        cdbCartao.Visible = False
    End Sub

    Private Sub rdbCartaoCredito_CheckedChanged(sender As Object, e As EventArgs) Handles rdbCartaoCredito.CheckedChanged
        cdbBoleto.Visible = False
        lblSelecioneDias.Visible = False

        lblSSN.Visible = True
        lblNomeTitular.Visible = True
        lblParcelas.Visible = True
        lblBandeira.Visible = True
        lblNumCartao.Visible = True
        txtNomeTitular.Visible = True
        txtNumCartao.Visible = True
        cdbParcelas.Visible = True
        txtSSN.Visible = True
        cdbCartao.Visible = True
    End Sub

    Private Sub botFaturarNotaFiscal_Click(sender As Object, e As EventArgs) Handles botFaturarNotaFiscal.Click

        'Armazena o valor total da nf em uma variável
        Dim valorTotal As Double
        'Atribui
        valorTotal = CDbl(txtValorTotal.Text)
        'Código do contas a receber
        Dim valorCodigoContasReceber As Integer
        'String com valor total
        Dim strValorTotal As String
        'Transforma o valor em string e substitui a , por .
        strValorTotal = Replace(valorTotal, ",", ".")

        If rdbAvista.Checked = False And rdbBoleto.Checked = False And rdbCartaoCredito.Checked = False Then
            MsgBox("Preencha as informações de pagamento", vbExclamation, "Atenção")
        ElseIf rdbAvista.Checked = True Then
            'Grava Nota no banco
            geraCodigo()
            strSQL = "INSERT INTO notaFiscal (notCodigo, notHora, notValor, notData, notCodVer, notOutrasInformacoes, ordCodigo, demCodigo) VALUES (" & valorCodigo & ", '" & DateTime.Today & "', '" & txtValorTotal.Text & "' , '" & DateTime.Today & "', 909066336, '" & txtOutrasInformacoes.Text & "', " & codOrdemAtual & ", " & CInt(txtCnpjCpfTomador.Text) & ")"
            'Executa a instrução de inserção no banco através do objeto da classe ConexaoAccess
            objBanco.ExecutaQuery(strSQL)
            'Verifica o ultimo código na tabela referenciada e atribui a variável
            valorCodigoContasReceber = Funcoes.atribuiCodigo("ctrCodigo", "contasReceber")
            strSQL = "INSERT INTO contasReceber(ctrCodigo, ctrDataEmissao, ctrDataVencimento, ctrValorEmitido, ctrDataPagamento, ctrDesc, ctrJuros, ctrValorPago, notCodigo, tpaCodigo) VALUES(" & valorCodigoContasReceber & ",'" & DateTime.Today & "', '" & DateTime.Today & "', " & strValorTotal & " , '" & DateTime.Today & "',0, 0," & strValorTotal & "," & valorCodigo & ", 3)"
            objBanco.ExecutaQuery(strSQL)
            MsgBox("Nota faturada", vbInformation, "Aviso")
            'Sub que fecha as conexões com banco e zera as variáveis usadas
            zeraVariaveisBanco()
        ElseIf rdbBoleto.Checked = True Then
            If cdbBoleto.Text = "" Then
                MsgBox("Preencha a quantidade de dias para geração dos boletos", vbExclamation, "Aviso")
                cdbBoleto.Focus()
            Else
                'Vetor que armazena o valor das parcelas
                Dim valorParcelasBoleto(11) As Double
                'Vetor que armazena o valor das parcelas convetidos para string
                Dim strParcelasBoleto(11) As String
                'Armazena os dias as datas de vencimento
                Dim varDias As Integer = 30

                'Grava nota fiscal no banco
                geraCodigo()
                strSQL = "INSERT INTO notaFiscal (notCodigo, notHora, notValor, notData, notCodVer, notOutrasInformacoes, ordCodigo, demCodigo) VALUES (" & valorCodigo & ", '" & DateTime.Today & "', '" & txtValorTotal.Text & "' , '" & DateTime.Today & "', 909066336, '" & txtOutrasInformacoes.Text & "', " & codOrdemAtual & ", " & CInt(txtCnpjCpfTomador.Text) & ")"
                'Executa a instrução de inserção no banco através do objeto da classe ConexaoAccess
                objBanco.ExecutaQuery(strSQL)

                'Loop que atribui a divisão das parcelas conforme o número escolhido a variável parcelas
                For i As Integer = 0 To quantidadeParcelasBoleto - 1
                    valorParcelasBoleto(i) = Round(valorTotal / quantidadeParcelasBoleto, 2, MidpointRounding.AwayFromZero)
                Next
                'Caso a divisão não seja exata, ele coloca 0,01 centavos para exatificar a conta
                If valorTotal Mod quantidadeParcelasBoleto <> 0 Then
                    valorParcelasBoleto(quantidadeParcelasBoleto - 1) = Round(((valorTotal / 3) - 0.01), 2, MidpointRounding.AwayFromZero)
                End If
                'Loop que transforma o valor em string e substitui a , por .
                For k As Integer = 0 To quantidadeParcelasBoleto - 1
                    strParcelasBoleto(k) = Replace(valorParcelasBoleto(k), ",", ".")
                Next
                'Verifica o ultimo código na tabela referenciada e atribui a variável
                valorCodigoContasReceber = Funcoes.atribuiCodigo("ctrCodigo", "contasReceber")
                'Loop para gravar na tabela contas a receber
                For l As Integer = 0 To quantidadeParcelasBoleto - 1
                    strSQL = "INSERT INTO contasReceber(ctrCodigo, ctrDataEmissao, ctrDataVencimento, ctrValorEmitido, ctrDataPagamento, ctrDesc, ctrJuros, ctrValorPago, notCodigo, tpaCodigo) VALUES(" & valorCodigoContasReceber & ",'" & DateTime.Today & "', '" & DateTime.Today.AddDays(varDias) & "', " & strParcelasBoleto(l) & " , '" & vbNullString & "',0, 0, 0," & valorCodigo & ", 1)"
                    objBanco.ExecutaQuery(strSQL)
                    valorCodigoContasReceber = valorCodigoContasReceber + 1
                    varDias = varDias + 30
                Next
                MsgBox("Nota faturada", vbInformation, "Aviso")
                'Sub que fecha as conexões com banco e zera as variáveis usadas
                zeraVariaveisBanco()
            End If
        ElseIf rdbCartaoCredito.Checked = True Then
            If txtNomeTitular.Text = "" Or txtNomeTitular.Text = "" Or txtSSN.Text = "" Or cdbCartao.Text = "" Or cdbParcelas.Text = "" Then
                MsgBox("Existem campos de preenchimento obrigatório vazios", vbExclamation, "Aviso")
            Else
                'Vetor que armazena o valor das parcelas
                Dim valorParcelasCartao(11) As Double
                'Vetor que armazena o valor das parcelas convetidos para string
                Dim strParcelasCartao(11) As String
                'Armazena os dias as datas de vencimento
                Dim varDias As Integer = 30

                'Grava nota fiscal no banco
                geraCodigo()
                strSQL = "INSERT INTO notaFiscal (notCodigo, notHora, notValor, notData, notCodVer, notOutrasInformacoes, ordCodigo, demCodigo) VALUES (" & valorCodigo & ", '" & DateTime.Today & "', '" & txtValorTotal.Text & "' , '" & DateTime.Today & "', 909066336, '" & txtOutrasInformacoes.Text & "', " & codOrdemAtual & ", " & CInt(txtCnpjCpfTomador.Text) & ")"
                'Executa a instrução de inserção no banco através do objeto da classe ConexaoAccess
                objBanco.ExecutaQuery(strSQL)

                'Loop que atribui a divisão das parcelas conforme o número escolhido a variável parcelas
                For i As Integer = 0 To quantidadeParcelasCartao - 1
                    valorParcelasCartao(i) = Round(valorTotal / quantidadeParcelasCartao, 2, MidpointRounding.AwayFromZero)
                Next
                'Caso a divisão não seja exata, ele coloca 0,01 centavos para exatificar a conta
                If valorTotal Mod quantidadeParcelasCartao <> 0 Then
                    valorParcelasCartao(quantidadeParcelasCartao - 1) = Round(((valorTotal / quantidadeParcelasCartao) - 0.01), 2, MidpointRounding.AwayFromZero)
                End If
                'Loop que transforma o valor em string e substitui a , por .
                For k As Integer = 0 To quantidadeParcelasCartao - 1
                    strParcelasCartao(k) = Replace(valorParcelasCartao(k), ",", ".")
                Next
                'Verifica o ultimo código na tabela referenciada e atribui a variável
                valorCodigoContasReceber = Funcoes.atribuiCodigo("ctrCodigo", "contasReceber")
                'Loop para gravar na tabela contas a receber
                For l As Integer = 0 To quantidadeParcelasCartao - 1
                    strSQL = "INSERT INTO contasReceber(ctrCodigo, ctrDataEmissao, ctrDataVencimento, ctrValorEmitido, ctrDataPagamento, ctrDesc, ctrJuros, ctrValorPago, notCodigo, tpaCodigo) VALUES(" & valorCodigoContasReceber & ",'" & DateTime.Today & "', '" & DateTime.Today.AddDays(varDias) & "', " & strParcelasCartao(l) & " , '" & vbNullString & "',0, 0, 0," & valorCodigo & ", 4)"
                    objBanco.ExecutaQuery(strSQL)
                    valorCodigoContasReceber = valorCodigoContasReceber + 1
                    varDias = varDias + 30
                Next
                MsgBox("Nota faturada", vbInformation, "Aviso")
                'Sub que fecha as conexões com banco e zera as variáveis usadas
                zeraVariaveisBanco()
            End If
        End If
    End Sub

    Private Sub geraCodigo()
        'Atribui o valor retornado pela função atribuiCodigo a textbox do Código
        valorCodigo = atribuiCodigo("notCodigo", "notaFiscal")
    End Sub

    Private Sub gravaNota()
        
    End Sub

    Private Sub cdbBoleto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cdbBoleto.SelectedIndexChanged
        Select cdbBoleto.SelectedIndex
            Case 0
                quantidadeParcelasBoleto = 1
            Case 1
                quantidadeParcelasBoleto = 2
            Case 2
                quantidadeParcelasBoleto = 3
            Case Else
                MsgBox("Ocorreu um erro, por favor, contate o administrador do sistema", vbCritical, "Erro")
        End Select
    End Sub

    Private Sub cdbParcelas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cdbParcelas.SelectedIndexChanged
        Select Case cdbParcelas.SelectedIndex
            Case 0
                quantidadeParcelasCartao = 1
            Case 1
                quantidadeParcelasCartao = 2
            Case 2
                quantidadeParcelasCartao = 3
            Case 3
                quantidadeParcelasCartao = 6
            Case Else
                MsgBox("Ocorreu um erro, por favor, contate o administrador do sistema", vbCritical, "Erro")
        End Select
    End Sub
End Class