Imports System.Data
Imports System.Data.OleDb
Imports Sistema_Matrix.ConexaoAccess
Public Class Form6
    'Declaração de variáveis públicas
    Public tabela As DataTable
    Public leitor As OleDbDataReader
    Public leitor2 As OleDbDataReader
    Public strsql As String
    Public valorCodOS As Integer
    Public objBanco As New ConexaoAccess
    Public valanterior As Integer = 109
    Public codServ As Integer
    Public codCli As Integer
    Public codFun As Integer
    Public tipCliente As String
    Public varOK As Boolean = True
    Public codOrdemServicoAtual As Integer
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
        Dim i As Integer = 0
        Try
            'Carrega as combo box com os dados das tabelas cliente, funcionarios e serviços
            strsql = "SELECT * FROM cliente ORDER BY cliCodigo"
            tabela = objBanco.ExecutaDataTable(strsql)

            If tabela.Rows.Count > 0 Then
                For i = 0 To tabela.Rows.Count - 1
                    cboCodCliente.Items.Add(tabela.Rows(i)("cliCodigo"))
                    cboCliente.Items.Add(tabela.Rows(i)("cliNome"))
                Next
            End If
            'Zera o contador para que ele seja reutilizado
            i = 0
            strsql = "SELECT * FROM funcionarios"
            tabela = objBanco.ExecutaDataTable(strsql)
            If tabela.Rows.Count > 0 Then
                For i = 0 To tabela.Rows.Count - 1
                    cboCodFuncionario.Items.Add(tabela.Rows(i)("funMatricula"))
                    cboFuncionario.Items.Add(tabela.Rows(i)("funNome"))
                Next
            End If

            i = 0
            strsql = "SELECT * FROM servicos"
            tabela = objBanco.ExecutaDataTable(strsql)
            If tabela.Rows.Count > 0 Then
                For i = 0 To tabela.Rows.Count - 1
                    cboCodServico.Items.Add(tabela.Rows(i)("svcCodigo"))
                    cboServico.Items.Add(tabela.Rows(i)("svcNome"))
                Next
            End If
            i = 0

            'Atribui a data de abertura a textBox
            mtxDataAbertura.Text = Today

            'Gera o código para a ordem de serviço e atribui a textbox
            valorCodOS = atribuiCodigo("ordCodigo", "ordemServico")
            txtCodigo.Text = valorCodOS

            'Desabilita os campos de preenchimento automático
            habilitaDesabilitaControles(Me, True)
        Catch exc As SqlClient.SqlException
            MsgBox("Erro com banco de dados" & vbCrLf & Err.Description, vbCritical, "Erro com Banco de dados")
        Catch exc As Exception
            MsgBox("Erro" & vbCrLf & Err.Number & vbCrLf & Err.Description, vbCritical, "Erro")
        Finally
            'Fecha a conexão
            objBanco.DesconectarBanco()
            strsql = String.Empty
            'Testa se a variável leitor foi alterada, se sim a conexão com banco de dados será fechada
        End Try
    End Sub

    Private Sub cboCliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCliente.SelectedIndexChanged
        If varOK = True And cboCliente.SelectedIndex <> -1 Then
            cboCodCliente.SelectedIndex = cboCliente.SelectedIndex
        End If
        cboFuncionario.Select()
    End Sub

    Private Sub botNovoServico_Click(sender As Object, e As EventArgs) Handles botNovoServico.Click


        Dim txtValor1(36) As TextBox
        Dim txtQtde1(36) As TextBox
        Dim txtDescricao1(36) As RichTextBox
        Dim cboServico1(36) As ComboBox


        txtValor1(i) = New System.Windows.Forms.TextBox()
        txtQtde1(i) = New System.Windows.Forms.TextBox()
        txtDescricao1(i) = New System.Windows.Forms.RichTextBox()
        cboServico1(i) = New System.Windows.Forms.ComboBox()

        Me.Size = New Size(770, Me.Height + 107)
        tabOrdemServico.Size = New Size(730, tabOrdemServico.Height + 85)
        grpServico.Size = New Size(695, grpServico.Height + 70)

        'Cria a txtValor
        txtValor1(i).Name = "txtValor" & i
        txtValor1(i).Height = 20
        txtValor1(i).Width = 95
        txtValor1(i).Location = New Point(307, valanterior)
        txtValor1(i).BringToFront()
        grpServico.Controls.Add(txtValor1(i))
        'Me.Controls.Add(txtValor1(i))

        'Cria a text box quantidade
        txtQtde1(i).Name = "txtQtde" & i
        txtQtde1(i).Height = 20
        txtQtde1(i).Width = 39
        txtQtde1(i).Location = New Point(407, valanterior)
        grpServico.Controls.Add(txtQtde1(i))

        'Cria a text box descrição
        txtDescricao1(i).Name = "txtDescricao" & i
        txtDescricao1(i).Height = 56
        txtDescricao1(i).Width = 216
        txtDescricao1(i).Location = New Point(468, valanterior)
        grpServico.Controls.Add(txtDescricao1(i))

        'Cria a combo box descrição
        cboServico1(i).Name = "txtDescricao" & i
        cboServico1(i).Height = 21
        cboServico1(i).Width = 289
        cboServico1(i).Location = New Point(6, valanterior)
        grpServico.Controls.Add(cboServico1(i))

        'Carrega as combo box
        Dim k As Integer

        strsql = "SELECT * FROM servicos"
        tabela = objBanco.ExecutaDataTable(strsql)
        If tabela.Rows.Count > 0 Then
            For k = 0 To tabela.Rows.Count - 1
                cboServico1(i).Items.Add(tabela.Rows(k)("svcNome"))
            Next
        End If

        'Reposiciona o botão para criar as novas textbox
        botNovoServico.Location = New Point(4, valanterior + 35)

        valanterior = valanterior + 70
        
        i = i + 1
    End Sub
    Private Sub cboCodCliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCodCliente.SelectedIndexChanged
        If cboCodCliente.SelectedIndex <> -1 Then
            Try
                codCli = cboCodCliente.SelectedItem
                strsql = "SELECT * FROM cliente WHERE cliCodigo = " & codCli
                leitor = objBanco.ExecutaDataRead(strsql)
                leitor.Read()

                txtEndereco.Text = leitor.Item(2).ToString
                txtBairro.Text = leitor.Item(3).ToString
                mtxCEP.Text = leitor.Item(4).ToString
                txtCidade.Text = leitor.Item(5).ToString
                txtUF.Text = leitor.Item(6).ToString
                mtxTelefone.Text = leitor.Item(7).ToString
                txtNumEndereco.Text = leitor.Item(11).ToString
                txtComplemento.Text = leitor.Item(13).ToString

                If leitor.Item("cliTipo").ToString = "F" Then
                    strsql = "SELECT * FROM cliPessoaFisica WHERE cliCodigo = " & codCli
                    leitor = objBanco.ExecutaDataRead(strsql)
                    leitor.Read()

                    mtxCPF.Visible = True
                    lblCPF.Visible = True
                    mtxRG.Visible = True
                    lblRG.Visible = True


                    mtxRG.Text = leitor.Item(0).ToString
                    mtxCPF.Text = leitor.Item(1).ToString

                    mtxCNPJ.Visible = False
                    lblCNPJ.Visible = False
                    mtxIE.Visible = False
                    lblIE.Visible = False
                    txtIM.Visible = False
                    lblIM.Visible = False
                    lblRazaoSocial.Visible = False
                    txtRazaoSocial.Visible = False


                ElseIf leitor.Item(15).ToString = "J" Then

                    strsql = "SELECT * FROM cliPessoaJuridica WHERE cliCodigo = " & codCli
                    leitor = objBanco.ExecutaDataRead(strsql)
                    leitor.Read()

                    mtxCPF.Visible = False
                    lblCPF.Visible = False
                    mtxRG.Visible = False
                    lblRG.Visible = False



                    mtxCNPJ.Visible = True
                    lblCNPJ.Visible = True
                    mtxIE.Visible = True
                    lblIE.Visible = True
                    txtIM.Visible = True
                    lblIM.Visible = True
                    lblRazaoSocial.Visible = True
                    txtRazaoSocial.Visible = True

                    mtxCNPJ.Text = leitor.Item(0).ToString
                    txtIM.Text = leitor.Item(1).ToString
                    mtxIE.Text = leitor.Item(2).ToString
                    txtRazaoSocial.Text = leitor.Item(3).ToString
                End If
                habilitaDesabilitaControles(grpCliente, True)
            Catch exc As SqlClient.SqlException
                MsgBox("Erro com banco de dados" & vbCrLf & Err.Description, vbCritical, "Erro com Banco de dados")
            Catch exc As Exception
                MsgBox("Erro" & vbCrLf & Err.Number & vbCrLf & Err.Description, vbCritical, "Erro")
            Finally
                'Fecha a conexão
                objBanco.DesconectarBanco()
                strsql = String.Empty
                'Testa se a variável leitor foi alterada, se sim a conexão com banco de dados será fechada
                If leitor IsNot Nothing Then
                    leitor = Nothing
                End If
            End Try
        End If
    End Sub

    Private Sub cboFuncionario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFuncionario.SelectedIndexChanged
        If varOK = True And cboFuncionario.SelectedIndex <> -1 Then
            cboCodFuncionario.SelectedIndex = cboFuncionario.SelectedIndex
        End If
        cboServico.Select()
    End Sub

    Private Sub cboServico_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboServico.SelectedIndexChanged
        If varOK = True And cboServico.SelectedIndex <> -1 Then
            cboCodServico.SelectedIndex = cboServico.SelectedIndex
            If txtQtde.Text <> "" Then
                txtValorTotal.Text = FormatCurrency(calculaValorTotal())
            End If
        End If
        txtQtde.Select()
    End Sub

    Private Sub cboCodServico_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCodServico.SelectedIndexChanged
        If cboCodServico.SelectedIndex <> -1 Then
            Try
                codServ = cboCodServico.SelectedItem
                strsql = "SELECT * FROM servicos WHERE svcCodigo = " & codServ
                leitor = objBanco.ExecutaDataRead(strsql)
                leitor.Read()
                txtValor.Text = FormatCurrency(leitor.Item(2).ToString)
                txtDescrição.Text = leitor.Item(3).ToString
                habilitaDesabilitaControles(grpServico, True)
                txtQtde.Text = "1"

            Catch exc As SqlClient.SqlException
                MsgBox("Erro com banco de dados" & vbCrLf & Err.Description, vbCritical, "Erro com Banco de dados")
            Catch exc As Exception
                MsgBox("Erro" & vbCrLf & Err.Number & vbCrLf & Err.Description, vbCritical, "Erro")
            Finally
                'Fecha a conexão
                objBanco.DesconectarBanco()
                strsql = String.Empty
                'Testa se a variável leitor foi alterada, se sim a conexão com banco de dados será fechada
                If leitor IsNot Nothing Then
                    leitor = Nothing
                End If
            End Try
        End If
    End Sub

    Private Sub cboCodFuncionario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCodFuncionario.SelectedIndexChanged
        If cboCodFuncionario.SelectedIndex <> -1 Then
            Try
                codFun = cboCodFuncionario.SelectedItem
                strsql = "SELECT * FROM funcionarios WHERE funMatricula = " & codFun
                leitor = objBanco.ExecutaDataRead(strsql)
                leitor.Read()
                txtCargo.Text = leitor.Item(5).ToString
                habilitaDesabilitaControles(grpFuncionario, True)
            Catch exc As SqlClient.SqlException
                MsgBox("Erro com banco de dados" & vbCrLf & Err.Description, vbCritical, "Erro com Banco de dados")
            Catch exc As Exception
                MsgBox("Erro" & vbCrLf & Err.Number & vbCrLf & Err.Description, vbCritical, "Erro")
            Finally
                'Fecha a conexão
                objBanco.DesconectarBanco()
                strsql = String.Empty
                'Testa se a variável leitor foi alterada, se sim a conexão com banco de dados será fechada
                If leitor IsNot Nothing Then
                    leitor = Nothing
                End If
            End Try
        End If
        
    End Sub

    Private Sub botCadastrar_Click(sender As Object, e As EventArgs) Handles botCadastrar.Click
        Dim dataFechamento As String

        If txtQtde.Text = "" Then
            txtQtde.Text = "1"
        End If
        txtValorTotal.Text = FormatCurrency(calculaValorTotal())
        dataFechamento = vbNullString

        ' If mtxDataFechamento.Text = "  /  /" Then
        dataFechamento = Replace(mtxDataFechamento.Text, "/", "")
        dataFechamento = Replace(dataFechamento, " ", "")
        'MsgBox(mtxDataFechamento.Text)
        MsgBox(dataFechamento)
       ' End If
        Try
            If cboCliente.Text = "" Or cboFuncionario.Text = "" Or cboServico.Text = "" Then
                MsgBox("Por favor, preencha as ComboBox para prosseguir", vbExclamation, "Aviso")
            ElseIf MsgBox("Atenção, depois de confirmar está mensagem, não será mais possível alterar ou excluir a Ordem de Serviço" & vbCrLf & "Deseja prosseguir?", vbQuestion + vbYesNo, "Aviso") = vbYes Then
                'Inseri os dados da ordem de serviço    
                strsql = "INSERT INTO ordemServico (ordCodigo , ordOcorrencia, ordDataAbertura, ordDataFechamento, cliCodigo, funMatricula) VALUES (" & valorCodOS & " ,'" & txtDescricaoOS.Text & "', '" & mtxDataAbertura.Text & "' , '" & vbNullString & "' , " & codCli & ", " & codFun & ")"
                objBanco.ExecutaQuery(strsql)

                'Adiciona os dados de serviço na tabela servicos_os
                strsql = "INSERT INTO servicos_os(seoData, seoQuantidade, ordCodigo, svcCodigo) VALUES ('" & Today & "', '" & txtQtde.Text & "' , " & valorCodOS & ", " & codServ & ")"
                objBanco.ExecutaQuery(strsql)
                MsgBox("Dados inseridos com sucesso", vbInformation, "Aviso")
                If MsgBox("Deseja faturar a Ordem de serviço agora?", vbQuestion & vbYesNo, "Confirme") = vbYes Then
                    codOrdemServicoAtual = CInt(Me.txtCodigo.Text)
                    Me.Hide()
                    confirmaNotaFiscal.Show()
                End If
                habilitaDesabilitaControles(Me, True)
                mtxDataAbertura.Enabled = False
                cboCliente.ResetText()
                cboFuncionario.ResetText()
                cboServico.ResetText()
                mtxDataAbertura.Text = Date.Today
                modoNovo()
            End If
        Catch exc As SqlClient.SqlException
            MsgBox("Erro com banco de dados" & vbCrLf & Err.Description, vbCritical, "Erro com Banco de dados")
        Catch exc As Exception
            MsgBox("Erro" & vbCrLf & Err.Number & vbCrLf & Err.Description, vbCritical, "Erro")
        Finally
            'Fecha a conexão
            objBanco.DesconectarBanco()
            strsql = String.Empty
            'Testa se a variável leitor foi alterada, se sim a conexão com banco de dados será fechada
            If leitor IsNot Nothing Then
                leitor = Nothing
            End If
        End Try
    End Sub
    Private Sub tabConsultaOrdem_Enter(sender As Object, e As EventArgs) Handles tabConsultaOrdem.Enter
        dtgOrdemServico.Rows.Clear()
        Try
            tabela = New DataTable()

            strsql = "SELECT ordemServico.ordCodigo, cliente.cliNome, cliente.cliTipo, ordemServico.ordDataFechamento FROM cliente INNER JOIN ordemServico ON cliente.cliCodigo = ordemServico.cliCodigo"

            tabela = objBanco.ExecutaDataTable(strsql)

            If tabela.Rows.Count > 0 Then
                Dim i As Integer = 0
                For i = 0 To tabela.Rows.Count - 1
                    dtgOrdemServico.Rows.Add(tabela.Rows(i)("ordCodigo"), tabela.Rows(i)("cliNome"), tabela.Rows(i)("ordDataFechamento"), tabela.Rows(i)("cliTipo"))
                Next
            End If

        Catch exc As SqlClient.SqlException
            MsgBox("Erro com banco de dados" & vbCrLf & Err.Description, vbCritical, "Erro com Banco de dados")
        Catch exc As Exception
            MsgBox("Erro" & vbCrLf & Err.Number & vbCrLf & Err.Description, vbCritical, "Erro")
        Finally
            objBanco.DesconectarBanco()
            dtgOrdemServico.Refresh()
            'Testa se a variável leitor foi alterada, se sim a conexão com banco de dados será fechada
            If leitor IsNot Nothing Then
                leitor.Close()
                leitor = Nothing
            End If
            strsql = String.Empty
            tabela.Dispose()
        End Try
    End Sub

    Private Sub dtgOrdemServico_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgOrdemServico.CellDoubleClick
        varOK = False
        Try

            'Armazena na variável o código da linha que será utilizada na clausula where do select
            valorCodOS = dtgOrdemServico.CurrentRow.Cells(0).Value
            tipCliente = dtgOrdemServico.CurrentRow.Cells(3).Value.ToString

            strsql = "SELECT ordCodigo FROM notaFiscal WHERE ordCodigo =" & valorCodOS
            leitor = objBanco.ExecutaDataRead(strsql)

            If leitor.Read() Then
                If leitor.Item(0).ToString Then
                    botVisualizarNota.Visible = True
                    lblVisualizarNota.Visible = True
                    botFaturarNotaFiscal.Visible = False
                    lblFaturarNotaFiscal.Visible = False
                End If
            Else
                botVisualizarNota.Visible = False
                lblVisualizarNota.Visible = False

                botFaturarNotaFiscal.Visible = True
                lblFaturarNotaFiscal.Visible = True
            End If


            'Seleciona a primeira aba do tab
            tabOrdemServico.SelectTab(0)

            'Exibe os botões de alteração e exclusão e oculta os de adição
            botCadastrar.Visible = False
            lblCadastrar.Visible = False
            botLimpar.Visible = False
            lblLimpar.Visible = False

            botAlterar.Visible = True
            lblAlterar.Visible = True
            botExcluir.Visible = True
            lblExcluir.Visible = True
            botModoNovo.Visible = True
            lblInserir.Visible = True


            If tipCliente = "F" Then
                'Verifica qual dos radio buttons estão marcados e carrega os valores do select nas textbox
                strsql = "SELECT ordCodigo, ordOcorrencia, ordDataAbertura, ordDataFechamento, cliente.cliNome, cliente.cliCodigo, ordemServico.cliCodigo, cliEndereco, cliBairro, cliCEP, cliCidade, cliUF, cliTelefone, cliNumEndereco, cliComplemento, cliRG, cliCPF, funNome, funCargo FROM (funcionarios INNER JOIN (cliente INNER JOIN ordemServico ON cliente.cliCodigo = ordemServico.cliCodigo) ON funcionarios.funMatricula = ordemServico.funMatricula) INNER JOIN cliPessoaFisica ON cliente.cliCodigo = cliPessoaFisica.cliCodigo WHERE ordemServico.ordCodigo = " & valorCodOS

                leitor = objBanco.ExecutaDataRead(strsql)
                leitor.Read()


                txtCodigo.Text = leitor.Item("ordCodigo").ToString
                txtDescricaoOS.Text = leitor.Item("ordOcorrencia").ToString
                mtxDataAbertura.Text = leitor.Item("ordDataAbertura").ToString
                mtxDataFechamento.Text = leitor.Item("ordDataFechamento").ToString
                cboCliente.SelectedItem = leitor.Item(4).ToString
                'cboCodCliente.SelectedItem = leitor.Item(5)
                txtCidade.Text = leitor.Item("cliCidade").ToString
                txtUF.Text = leitor.Item("cliUF").ToString
                mtxTelefone.Text = leitor.Item("cliTelefone").ToString
                txtNumEndereco.Text = leitor.Item("cliNumEndereco").ToString
                mtxRG.Text = leitor.Item("cliRG").ToString
                mtxCPF.Text = leitor.Item("cliCPF").ToString
                txtComplemento.Text = leitor.Item("cliComplemento").ToString
                txtEndereco.Text = leitor.Item("cliEndereco").ToString
                mtxCEP.Text = leitor.Item("cliCEP").ToString
                txtBairro.Text = leitor.Item("cliBairro").ToString
                cboFuncionario.SelectedItem = leitor.Item("funNome").ToString
                txtCargo.Text = leitor.Item("funCargo").ToString


                strsql = "SELECT ordemServico.ordCodigo, servicos.svcNome, servicos.svcValorHora, servicos.svcDescricao, servicos_os.seoQuantidade FROM ordemServico INNER JOIN (servicos INNER JOIN servicos_os ON servicos.svcCodigo = servicos_os.svcCodigo) ON ordemServico.ordCodigo = servicos_os.ordCodigo WHERE ordemServico.ordCodigo = " & valorCodOS

                leitor = objBanco.ExecutaDataRead(strsql)
                leitor.Read()

                cboServico.SelectedItem = leitor.Item("svcNome").ToString
                txtValor.Text = leitor.Item("svcValorHora").ToString
                txtQtde.Text = leitor.Item("seoQuantidade").ToString
                txtDescrição.Text = leitor.Item("svcDescricao").ToString

                habilitaDesabilitaControles(Me, True)
                mtxDataFechamento.Enabled = True
                cboCliente.Enabled = True
                cboFuncionario.Enabled = True
                cboServico.Enabled = True
                txtQtde.Enabled = False
                varOK = True
            Else
                strsql = "SELECT ordemServico.ordCodigo, ordemServico.ordOcorrencia, ordemServico.ordDataAbertura, ordemServico.ordDataFechamento, cliente.cliNome, cliente.cliEndereco, cliente.cliBairro, cliente.cliCEP, cliente.cliCidade, cliente.cliUF, cliente.cliTelefone, cliente.cliNumEndereco, cliente.cliComplemento, cliPessoaJuridica.cliCNPJ, cliPessoaJuridica.cliIM, cliPessoaJuridica.cliIE, cliPessoaJuridica.cliRazaoSocial, funcionarios.funNome, funcionarios.funCargo FROM (funcionarios INNER JOIN (cliente INNER JOIN ordemServico ON cliente.cliCodigo = ordemServico.cliCodigo) ON funcionarios.funMatricula = ordemServico.funMatricula) INNER JOIN cliPessoaJuridica ON cliente.cliCodigo = cliPessoaJuridica.cliCodigo WHERE ordemServico.ordCodigo = " & valorCodOS

                leitor = objBanco.ExecutaDataRead(strsql)
                leitor.Read()


                txtCodigo.Text = leitor.Item("ordCodigo").ToString
                txtDescricaoOS.Text = leitor.Item("ordOcorrencia").ToString
                mtxDataAbertura.Text = leitor.Item("ordDataAbertura").ToString
                mtxDataFechamento.Text = leitor.Item("ordDataFechamento").ToString
                cboCliente.SelectedItem = leitor.Item(4).ToString
                'cboCodCliente.SelectedItem = leitor.Item(5)
                txtCidade.Text = leitor.Item("cliCidade").ToString
                txtUF.Text = leitor.Item("cliUF").ToString
                mtxTelefone.Text = leitor.Item("cliTelefone").ToString
                txtNumEndereco.Text = leitor.Item("cliNumEndereco").ToString
                txtComplemento.Text = leitor.Item("cliComplemento").ToString
                txtEndereco.Text = leitor.Item("cliEndereco").ToString
                mtxCEP.Text = leitor.Item("cliCEP").ToString
                txtBairro.Text = leitor.Item("cliBairro").ToString
                cboFuncionario.SelectedItem = leitor.Item("funNome").ToString
                txtCargo.Text = leitor.Item("funCargo").ToString
                mtxCNPJ.Text = leitor.Item("cliCNPJ").ToString
                mtxIE.Text = leitor.Item("cliIE").ToString
                txtIM.Text = leitor.Item("cliIM").ToString
                txtRazaoSocial.Text = leitor.Item("cliRazaoSocial").ToString



                strsql = "SELECT ordemServico.ordCodigo, servicos.svcNome, servicos.svcValor, servicos.svcDescricao, servicos_os.seoQuantidade FROM ordemServico INNER JOIN (servicos INNER JOIN servicos_os ON servicos.svcCodigo = servicos_os.svcCodigo) ON ordemServico.ordCodigo = servicos_os.ordCodigo WHERE ordemServico.ordCodigo = " & valorCodOS

                leitor = objBanco.ExecutaDataRead(strsql)
                leitor.Read()

                cboServico.SelectedItem = leitor.Item("svcNome").ToString
                txtValor.Text = leitor.Item("svcValorHora").ToString
                txtQtde.Text = leitor.Item("seoQuantidade").ToString
                txtDescrição.Text = leitor.Item("svcDescricao").ToString

                habilitaDesabilitaControles(Me, True)
                cboCliente.Enabled = True
                cboFuncionario.Enabled = True
                cboServico.Enabled = True
                txtQtde.Enabled = False
                varOK = True
            End If
        Catch exc As SqlClient.SqlException
            MsgBox("Erro com banco de dados" & vbCrLf & Err.Description, vbCritical, "Erro com Banco de dados")
        Catch exc As Exception
            MsgBox("Erro" & vbCrLf & Err.Number & vbCrLf & Err.Description, vbCritical, "Erro")
        Finally
            objBanco.DesconectarBanco()
            dtgOrdemServico.Refresh()
            'Testa se a variável leitor foi alterada, se sim a conexão com banco de dados será fechada
            If leitor IsNot Nothing Then
                leitor.Close()
                leitor = Nothing
                strsql = String.Empty
            End If
        End Try
    End Sub

    Private Sub botModoNovo_Click(sender As Object, e As EventArgs) Handles botModoNovo.Click
        modoNovo()
        'If cboCliente.SelectedIndex <> -1 Or cboFuncionario.SelectedIndex <> -1 Or cboServico.SelectedIndex <> -1 Then
        cboCliente.SelectedIndex = -1
        cboServico.SelectedIndex = -1
        cboFuncionario.SelectedIndex = -1
        cboCodCliente.SelectedIndex = -1
        cboCodServico.SelectedIndex = -1
        cboCodFuncionario.SelectedIndex = -1
        'End If
    End Sub

    Private Sub botAlterar_Click(sender As Object, e As EventArgs) Handles botAlterar.Click
        Try
            Dim dataFechamento As String
            dataFechamento = mtxDataFechamento.Text

            If mtxDataFechamento.Text = "  /  /" Then
                dataFechamento = Replace(mtxDataFechamento.Text, "/", "")
                dataFechamento = Replace(dataFechamento, " ", "")
            End If

            strsql = "UPDATE ordemServico SET ordDataFechamento = '" & dataFechamento & "' WHERE ordCodigo = " & valorCodOS
            objBanco.ExecutaQuery(strsql)
            MsgBox("Dados Alterados com Sucesso", vbInformation, "Aviso")
            modoNovo()

        Catch exc As SqlClient.SqlException
            MsgBox("Erro com banco de dados" & vbCrLf & Err.Number & Err.Description, vbCritical, "Erro com Banco de dados")
        Catch exc As Exception
            MsgBox("Erro" & vbCrLf & Err.Number & vbCrLf & Err.Description, vbCritical, "Erro")
        Finally
            objBanco.DesconectarBanco()
        End Try
    End Sub

    Private Sub modoNovo()
        botCadastrar.Visible = True
        lblCadastrar.Visible = True
        botLimpar.Visible = True
        lblLimpar.Visible = True
        botAlterar.Visible = False
        lblAlterar.Visible = False
        botExcluir.Visible = False
        lblExcluir.Visible = False
        botModoNovo.Visible = False
        botVisualizarNota.Visible = False
        lblVisualizarNota.Visible = False
        botFaturarNotaFiscal.Visible = False
        lblFaturarNotaFiscal.Visible = False
        lblInserir.Visible = False
        cboCliente.Enabled = True
        cboFuncionario.Enabled = True
        cboServico.Enabled = True
        Limpar(Me)
        valorCodOS = atribuiCodigo("ordCodigo", "ordemServico")
        txtCodigo.Text = valorCodOS
    End Sub

    Private Sub Form6_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Funcoes.HabilitaBotaoLogOff()
    End Sub
    Private Sub botFaturarNotaFiscal_Click(sender As Object, e As EventArgs) Handles botFaturarNotaFiscal.Click
        If MsgBox("Deseja faturar a Ordem de serviço agora?", vbQuestion & vbYesNo, "Confirme") = vbYes Then
            codOrdemServicoAtual = CInt(Me.txtCodigo.Text)
            Me.Hide()
            confirmaNotaFiscal.Show()
        End If
    End Sub
    Private Function calculaValorTotal()
        Dim quantidadeOs As Double
        Dim valorUnitario As Double
        Dim valorTotal As Double
        quantidadeOs = txtQtde.Text
        valorUnitario = txtValor.Text
        valorTotal = valorUnitario * quantidadeOs
        valorTotal = valorTotal
        Return valorTotal

    End Function

    Private Sub txtQtde_Leave(sender As Object, e As EventArgs) Handles txtQtde.Leave
        If txtQtde.Text = "" Then
            txtQtde.Text = "1"
        End If
        txtValorTotal.Text = FormatCurrency(calculaValorTotal())
    End Sub
End Class