Imports System.Data.OleDb
Imports System.Data
Imports Sistema_Matrix.clsConexaoBanco
Public Class frmGerenciamentoClientes
    'Declaração de variáveis públicas
    Public tabela As DataTable
    Public leitor As OleDbDataReader
    Public strsql As String
    Public valorCodCliente As Integer
    Public objBanco As New clsConexaoBanco
    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Carrega as mascaras nas caixas de texto
        mtxCelular.Mask = "(00)00000-0000"
        mtxCEP.Mask = "00000-000"
        mtxCNPJ.Mask = "00.000.000/0000-00"
        mtxCPF.Mask = "000.000.000-00"
        mtxIE.Mask = "000.000.000.000"
        mtxRG.Mask = "00.000.000-0"
        mtxTelefone.Mask = "(00)0000-0000"

        'Atribui o valor retornado pela função atribuiCodigo a textbox do Código
        valorCodCliente = atribuiCodigo("cliCodigo", "cliente")
        txtCodigoCliente.Text = valorCodCliente

    End Sub
    Private Sub botCadastrar_click(sender As Object, e As EventArgs) Handles botCadastrar.Click

        'Variáveis para armazenar os campos de texto
        Dim varCPF As String
        Dim varRG As String
        Dim varCNPJ As String
        Dim varIE As String
        Dim varTelefone As String
        Dim varCelular As String
        Dim varCEP As String
        Dim varTipo As String
        Dim valRetornado As Integer

        'Função que verifica se os campos obrigatórios estão vazios
        valRetornado = modFuncoes.verificaVazio(Me)

        'Testa se o valor retornado pela função para dar continuidade aos comandos
        If valRetornado = 0 Then
            'Retira a máscara das caixas de texto
            varCPF = Replace(mtxCPF.Text, ",", "")
            varCPF = Replace(varCPF, "-", "")

            varRG = Replace(mtxRG.Text, ",", "")
            varRG = Replace(varRG, "-", "")

            varCNPJ = Replace(mtxCNPJ.Text, ",", "")
            varCNPJ = Replace(varCNPJ, "/", "")
            varCNPJ = Replace(varCNPJ, "-", "")

            varIE = Replace(mtxIE.Text, ",", "")

            varCelular = Replace(mtxCelular.Text, "(", "")
            varCelular = Replace(varCelular, ")", "")
            varCelular = Replace(varCelular, "-", "")

            varTelefone = Replace(mtxTelefone.Text, "(", "")
            varTelefone = Replace(varTelefone, ")", "")
            varTelefone = Replace(varTelefone, "-", "")

            varCEP = Replace(mtxCEP.Text, "-", "")
            If rdbFisica.Checked = True Then
                varTipo = "F"
            Else
                varTipo = "J"
            End If
            Try
                'Comando para inclusão dos dados
                strsql = "INSERT INTO cliente(cliCodigo , cliNome, cliEndereco, cliBairro, cliCEP, cliCidade, cliUF, cliTelefone, " & _
                "cliCelular, cliEmail, cliDataCadastro, cliNumEndereco, cliObservacao, cliComplemento, cliWebSite, cliTipo) VALUES (" & _
                    valorCodCliente & ", '" & _
                    txtNome.Text & "','" & _
                    txtEndereco.Text & "','" & _
                    txtBairro.Text & "','" & _
                    varCEP & "','" & _
                    txtCidade.Text & "','" & _
                    cboUF.Text & "','" & _
                    varTelefone & "','" & _
                    varCelular & "','" & _
                    txtEmail.Text & "','" & _
                    DateTime.Today & "','" & _
                    txtNumEndereco.Text & "','" & _
                    txtObservacao.Text & "','" & _
                    txtComplemento.Text & "' , '" & _
                    txtWebsite.Text & "' , '" & _
                    varTipo & "')"
                'Executa a instrução
                objBanco.ExecutaQuery(strsql)

                'Testa qual dos botões estão selecionados para gravar na especialização de cliente (pessoa jurídica ou pessoa física)
                If (rdbFisica.Checked = True) Then
                    strsql = "INSERT INTO cliPessoaFisica(cliRG, cliCPF, cliCodigo) VALUES ('" & varRG & "', '" & varCPF & "','" & valorCodCliente & "')"

                    'Executa a instrução
                    objBanco.ExecutaQuery(strsql)
                ElseIf (rdbJuridica.Checked = True) Then
                    strsql = "INSERT INTO cliPessoaJuridica(cliCNPJ, cliIM, cliIE, cliRazaoSocial, cliCodigo) VALUES ('" & varCNPJ & "', '" & txtIM.Text & "' , '" & varIE & "', '" & txtRazaoSocial.Text & "' ,'" & valorCodCliente & "')"

                    'Executa a instrução
                    objBanco.ExecutaQuery(strsql)
                Else
                    MsgBox("Ocorreu um erro no programa" & vbCrLf & Err.Description & " Contate o administrador", vbCritical, "Erro")
                End If
                MsgBox("Dados gravados com sucesso", vbInformation, "Aviso")
                Limpar(Me)
                valorCodCliente = atribuiCodigo("cliCodigo", "cliente")
                txtCodigoCliente.Text = valorCodCliente
                'Tratamento dos erros
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
                    leitor.Close()
                    leitor = Nothing
                End If
            End Try
        End If
    End Sub

    Private Sub rdbFisica_CheckedChanged(sender As Object, e As EventArgs) Handles rdbFisica.CheckedChanged
        'Exibe os atributos da pessoa física
        mtxRG.Visible = True
        mtxCPF.Visible = True
        lblCPF.Visible = True
        lblRG.Visible = True
        mtxRG.Tag = ""
        mtxCPF.Tag = ""

        'Oculta os atributos da pessoa jurídica
        mtxCNPJ.Tag = "Não"
        txtRazaoSocial.Tag = "Não"
        mtxIE.Tag = "Não"
        txtIM.Tag = "Não"
        mtxCNPJ.Visible = False
        mtxIE.Visible = False
        txtIM.Visible = False
        txtRazaoSocial.Visible = False
        lblIM.Visible = False
        lblRazaoSocial.Visible = False
        lblIE.Visible = False
        lblCNPJ.Visible = False
        mtxCNPJ.Text = ""
        mtxIE.Text = ""
        txtIM.Text = ""
        txtRazaoSocial.Text = ""



    End Sub

    Private Sub rdbJuridica_CheckedChanged(sender As Object, e As EventArgs) Handles rdbJuridica.CheckedChanged

        'Oculta os atributos da pessoa física
        mtxRG.Visible = False
        mtxCPF.Visible = False
        lblRG.Visible = False
        lblCPF.Visible = False
        mtxRG.Tag = "Não"
        mtxCPF.Tag = "Não"
        mtxCPF.Text = ""
        mtxRG.Text = ""

        'Exibe os atributos da pessoa jurídica
        mtxCNPJ.Tag = ""
        txtRazaoSocial.Tag = ""
        mtxIE.Tag = ""
        txtIM.Tag = ""
        mtxCNPJ.Visible = True
        mtxIE.Visible = True
        txtIM.Visible = True
        txtRazaoSocial.Visible = True
        lblRazaoSocial.Visible = True
        lblIE.Visible = True
        lblCNPJ.Visible = True
        lblIM.Visible = True

    End Sub

    Private Sub botLimpar_Click(sender As Object, e As EventArgs) Handles botLimpar.Click
        'Chama a função para limpar as textbox
        modFuncoes.Limpar(Me)
        valorCodCliente = atribuiCodigo("cliCodigo", "cliente")
        txtCodigoCliente.Text = valorCodCliente
    End Sub

    Private Sub rdbConFisica_CheckedChanged(sender As Object, e As EventArgs) Handles rdbConFisica.CheckedChanged
        'Oculta as textbox de pessoa fisica e mostra as de pessoa jurídica
        lblConCNPJ.Visible = False
        txtConCNPJ.Visible = False

        lblConCPF.Visible = True
        txtConCpf.Visible = True
        'Limpa as textbox
        modFuncoes.Limpar(Me)

        Try
            objBanco.carregaDataGrid(dtgConsultaClientes, "SELECT cliente.cliCodigo as Código, cliente.cliNome as Nome, cliPessoaFisica.cliCPF as CPF FROM cliente INNER JOIN cliPessoaFisica ON cliente.cliCodigo = cliPessoaFisica.cliCodigo ORDER BY cliente.cliCodigo")
            'Tratamento dos erros
        Catch exc As SqlClient.SqlException
            MsgBox("Erro com banco de dados" & vbCrLf & Err.Description, vbCritical, "Erro com Banco de dados")
        Catch exc As Exception
            MsgBox("Erro" & vbCrLf & Err.Number & vbCrLf & Err.Description, vbCritical, "Erro")
        Finally
            objBanco.DesconectarBanco()
            'Testa se a variável leitor foi alterada, se sim a conexão com banco de dados será fechada
        End Try
    End Sub

    Private Sub rdbConJuridica_CheckedChanged(sender As Object, e As EventArgs) Handles rdbConJuridica.CheckedChanged
        'Oculta as textbox de pessoa fisica e mostra as de pessoa jurídica
        lblConCNPJ.Visible = True
        txtConCNPJ.Visible = True

        lblConCPF.Visible = False
        txtConCpf.Visible = False
        modFuncoes.Limpar(Me)
        Try
            objBanco.carregaDataGrid(dtgConsultaClientes, "SELECT cliente.cliCodigo as Código, cliente.cliNome as Nome, cliPessoaJuridica.cliCNPJ as CNPJ FROM cliente INNER JOIN cliPessoaJuridica ON cliente.cliCodigo = cliPessoaJuridica.cliCodigo ORDER BY cliente.cliCodigo")
            'Tratamento dos erros
        Catch exc As SqlClient.SqlException
            MsgBox("Erro com banco de dados" & vbCrLf & Err.Description, vbCritical, "Erro com Banco de dados")
        Catch exc As Exception
            MsgBox("Erro" & vbCrLf & Err.Number & vbCrLf & Err.Description, vbCritical, "Erro")
        Finally
            objBanco.DesconectarBanco()
        End Try
    End Sub
    Private Sub txtConCodigo_TextChanged(sender As Object, e As EventArgs) Handles txtConCodigo.TextChanged
        If rdbConFisica.Checked = True Then
            strsql = "SELECT cliente.cliCodigo, cliente.cliNome, cliPessoaFisica.cliCPF FROM cliente INNER JOIN cliPessoaFisica ON cliente.cliCodigo = cliPessoaFisica.cliCodigo WHERE cliente.cliCodigo LIKE '" & txtConCodigo.Text & "%' ORDER BY cliente.cliCodigo"
            filtra(txtConCodigo, strsql, dtgConsultaClientes, "cliCodigo", "cliNome", "cliCPF", "cliente")
        Else
            strsql = "SELECT cliente.cliCodigo, cliente.cliNome, cliPessoaJuridica.cliCNPJ FROM cliente INNER JOIN cliPessoaJuridica ON cliente.cliCodigo = cliPessoaJuridica.cliCodigo WHERE cliente.cliCodigo LIKE '" & txtConCodigo.Text & "%' ORDER BY cliente.cliCodigo"
            filtra(txtConCodigo, strsql, dtgConsultaClientes, "cliCodigo", "cliNome", "cliCNPJ", "cliente")
        End If
    End Sub
    Private Sub txtConNome_TextChanged(sender As Object, e As EventArgs) Handles txtConNome.TextChanged
        If rdbConFisica.Checked = True Then
            strsql = "SELECT cliente.cliCodigo, cliente.cliNome, cliPessoaFisica.cliCPF FROM cliente INNER JOIN cliPessoaFisica ON cliente.cliCodigo = cliPessoaFisica.cliCodigo WHERE cliente.cliNome LIKE '" & txtConNome.Text & "%' ORDER BY cliente.cliCodigo"
            filtra(txtConNome, strsql, dtgConsultaClientes, "cliCodigo", "cliNome", "cliCPF", "cliente")
        Else
            strsql = "SELECT cliente.cliCodigo, cliente.cliNome, cliPessoaJuridica.cliCNPJ FROM cliente INNER JOIN cliPessoaJuridica ON cliente.cliCodigo = cliPessoaJuridica.cliCodigo WHERE cliente.cliNome LIKE '" & txtConNome.Text & "%' ORDER BY cliente.cliCodigo"
            filtra(txtConNome, strsql, dtgConsultaClientes, "cliCodigo", "cliNome", "cliCNPJ", "cliente")
        End If
    End Sub
    Private Sub txtConCpf_TextChanged(sender As Object, e As EventArgs) Handles txtConCpf.TextChanged
        strsql = "SELECT cliente.cliCodigo, cliente.cliNome, cliPessoaFisica.cliCPF FROM cliente INNER JOIN cliPessoaFisica ON cliente.cliCodigo = cliPessoaFisica.cliCodigo WHERE clientePessoaFisica.cliCPF LIKE '" & txtConCpf.Text & "%' ORDER BY cliente.cliCodigo"
        filtra(txtConCpf, strsql, dtgConsultaClientes, "cliCodigo", "cliNome", "cliCPF", "cliente")
    End Sub
    Private Sub txtConCNPJ_TextChanged(sender As Object, e As EventArgs) Handles txtConCNPJ.TextChanged
        ' filtraTextbox(dtgConsultaClientes, txtConCNPJ, rdbConFisica, "cliPessoaJuridica.cliCNPJ")

        strsql = "SELECT cliente.cliCodigo, cliente.cliNome, cliPessoaJuridica.cliCNPJ FROM cliente INNER JOIN cliPessoaJuridica ON cliente.cliCodigo = cliPessoaJuridica.cliCodigo WHERE cliPessoaJuridica.cliCNPJ LIKE '" & txtConCNPJ.Text & "%' ORDER BY cliente.cliCodigo"
        filtra(txtConCNPJ, strsql, dtgConsultaClientes, "cliCodigo", "cliNome", "cliCNPJ", "cliente")
    End Sub
    Private Sub dtgConsultaClientes_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgConsultaClientes.CellDoubleClick
        Try
            'Armazena na variável o código da linha que será utilizada na clausula where do select
            valorCodCliente = dtgConsultaClientes.CurrentRow.Cells(0).Value

            'Seleciona a primeira aba do tab
            tabClientes.SelectTab(0)

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

            'Verifica qual dos radio buttons estão marcados e carrega os valores do select nas textbox
            If rdbConFisica.Checked = True Then
                strsql = "SELECT cliente.*, cliPessoaFisica.* FROM cliente INNER JOIN cliPessoaFisica ON cliente.cliCodigo = cliPessoaFisica.cliCodigo WHERE cliente.cliCodigo = " & valorCodCliente

                leitor = objBanco.ExecutaDataRead(strsql)
                leitor.Read()

                rdbFisica.Checked = True
                rdbFisica.Enabled = True
                rdbJuridica.Enabled = False
                txtNome.Text = leitor.Item(1).ToString
                txtEndereco.Text = leitor.Item(2).ToString
                txtBairro.Text = leitor.Item(3).ToString
                mtxCEP.Text = leitor.Item(4).ToString
                txtCidade.Text = leitor.Item(5).ToString
                cboUF.Text = leitor.Item(6).ToString
                mtxTelefone.Text = leitor.Item(7).ToString
                mtxCelular.Text = leitor.Item(8).ToString
                txtEmail.Text = leitor.Item(9).ToString
                txtNumEndereco.Text = leitor.Item(11).ToString
                txtObservacao.Text = leitor.Item(12).ToString
                txtComplemento.Text = leitor.Item(13).ToString
                txtWebsite.Text = leitor.Item(14).ToString
                mtxRG.Text = leitor.Item(16).ToString
                mtxCPF.Text = leitor.Item(17).ToString
            ElseIf (rdbConJuridica.Checked = True) Then
                strsql = "SELECT cliente.*, cliPessoaJuridica.* FROM cliente INNER JOIN cliPessoaJuridica ON cliente.cliCodigo = cliPessoaJuridica.cliCodigo WHERE cliente.cliCodigo = " & valorCodCliente

                leitor = objBanco.ExecutaDataRead(strsql)
                leitor.Read()

                rdbJuridica.Checked = True
                rdbJuridica.Enabled = True
                rdbFisica.Enabled = False
                txtNome.Text = leitor.Item(1).ToString
                txtEndereco.Text = leitor.Item(2).ToString
                txtBairro.Text = leitor.Item(3).ToString
                mtxCEP.Text = leitor.Item(4).ToString
                txtCidade.Text = leitor.Item(5).ToString
                cboUF.Text = leitor.Item(6).ToString
                mtxTelefone.Text = leitor.Item(7).ToString
                mtxCelular.Text = leitor.Item(8).ToString
                txtEmail.Text = leitor.Item(9).ToString
                txtNumEndereco.Text = leitor.Item(11).ToString
                txtObservacao.Text = leitor.Item(12).ToString
                txtComplemento.Text = leitor.Item(13).ToString
                txtWebsite.Text = leitor.Item(14).ToString
                mtxCNPJ.Text = leitor.Item(16).ToString
                txtIM.Text = leitor.Item(17).ToString
                mtxIE.Text = leitor.Item(18).ToString
                txtRazaoSocial.Text = leitor.Item(19).ToString
            Else
                MsgBox("Erro grava", vbCritical, "Erro")
            End If
        Catch exc As SqlClient.SqlException
            MsgBox("Erro com banco de dados" & vbCrLf & Err.Description, vbCritical, "Erro com Banco de dados")
        Catch exc As Exception
            MsgBox("Erro" & vbCrLf & Err.Number & vbCrLf & Err.Description, vbCritical, "Erro")
        Finally
            objBanco.DesconectarBanco()
            'Testa se a variável leitor foi alterada, se sim a conexão com banco de dados será fechada
            If leitor IsNot Nothing Then
                leitor.Close()
                leitor = Nothing
            End If
        End Try
    End Sub

    Private Sub botModoNovo_Click(sender As Object, e As EventArgs) Handles botModoNovo.Click
        modoInserir()
        valorCodCliente = atribuiCodigo("cliCodigo", "cliente")
        txtCodigoCliente.Text = valorCodCliente
    End Sub

    Private Sub tabConsultaClientes_Enter(sender As Object, e As EventArgs) Handles tabConsultaClientes.Enter
        rdbConFisica.Checked = True
        objBanco.carregaDataGrid(dtgConsultaClientes, "SELECT cliente.cliCodigo as Código, cliente.cliNome as Nome, cliPessoaFisica.cliCPF as CPF FROM cliente INNER JOIN cliPessoaFisica ON cliente.cliCodigo = cliPessoaFisica.cliCodigo ORDER BY cliente.cliCodigo")
    End Sub

    Private Sub botExcluir_Click(sender As Object, e As EventArgs) Handles botExcluir.Click
        If MsgBox("Deseja excluir realmente o registro", vbQuestion + vbYesNo, "Confirme") = vbYes Then
            Try
                'Variável que armazena o comando SQL
                strsql = "DELETE FROM cliente WHERE cliente.cliCodigo = " & valorCodCliente

                'Executa a instrução
                objBanco.ExecutaQuery(strsql)

                MsgBox("Registro Excluído com sucesso", vbInformation, "Sucesso")

                'Limpa as caixas de texto e coloca o formulário apenas para inserir registros
                modoInserir()
                valorCodCliente = atribuiCodigo("cliCodigo", "cliente")
                txtCodigoCliente.Text = valorCodCliente
            Catch exc As SqlClient.SqlException
                MsgBox("Erro com banco de dados" & vbCrLf & Err.Description, vbCritical, "Erro com Banco de dados")
            Catch exc As Exception
                MsgBox("Erro" & vbCrLf & Err.Number & vbCrLf & Err.Description, vbCritical, "Erro")
            Finally
                objBanco.DesconectarBanco()
            End Try
        End If
    End Sub

    Private Sub botAlterar_Click(sender As Object, e As EventArgs) Handles botAlterar.Click

        'Variáveis para armazenar os campos de texto
        Dim strsql As String
        Dim varCPF As String
        Dim varRG As String
        Dim varCNPJ As String
        Dim varIE As String
        Dim varTelefone As String
        Dim varCelular As String
        Dim varCEP As String

        Try
            'Retira a máscara das caixas de texto
            varCPF = Replace(mtxCPF.Text, ",", "")
            varCPF = Replace(varCPF, "-", "")

            varRG = Replace(mtxRG.Text, ",", "")
            varRG = Replace(varRG, "-", "")

            varCNPJ = Replace(mtxCNPJ.Text, ",", "")
            varCNPJ = Replace(varCNPJ, "/", "")
            varCNPJ = Replace(varCNPJ, "-", "")

            varIE = Replace(mtxIE.Text, ",", "")

            varCelular = Replace(mtxCelular.Text, "(", "")
            varCelular = Replace(varCelular, ")", "")
            varCelular = Replace(varCelular, "-", "")

            varTelefone = Replace(mtxTelefone.Text, "(", "")
            varTelefone = Replace(varTelefone, ")", "")
            varTelefone = Replace(varTelefone, "-", "")

            varCEP = Replace(mtxCEP.Text, "-", "")

            'Declaração de variáveis
            Dim valRetornado As Integer

            'Função que verifica se os campos obrigatórios estão vazios
            valRetornado = modFuncoes.verificaVazio(Me)

            'Testa se o valor retornado pela função para dar continuidade aos comandos
            If valRetornado = 0 Then
                If rdbFisica.Checked = True Then
                    strsql = "UPDATE cliente INNER JOIN cliPessoaFisica ON cliente.cliCodigo = cliPessoaFisica.cliCodigo SET cliente.cliNome = '" & txtNome.Text & "', cliente.cliEndereco = '" & txtEndereco.Text & "', cliente.cliBairro = '" & txtBairro.Text & "' , cliente.cliCEP = '" & varCEP & "' , cliente.cliCidade = '" & txtCidade.Text & "', cliente.cliUF = '" & cboUF.Text & "' ,cliente.cliTelefone = '" & varTelefone & "' , cliente.cliCelular = '" & varCelular & "', cliente.cliEmail = '" & txtEmail.Text & "', cliente.cliNumEndereco = '" & txtNumEndereco.Text & "', cliente.cliObservacao = '" & txtObservacao.Text & "', cliente.cliComplemento = '" & txtComplemento.Text & "', cliente.cliWebSite = '" & txtWebsite.Text & "', cliPessoaFisica.cliRG = '" & varRG & "', cliPessoaFisica.cliCPF = '" & varCPF & "' WHERE cliente.cliCodigo = " & valorCodCliente

                    'Executa a instrução
                    objBanco.ExecutaQuery(strsql)

                ElseIf rdbJuridica.Checked = True Then
                    strsql = "UPDATE cliente INNER JOIN cliPessoaJuridica ON cliente.cliCodigo = cliPessoaJuridica.cliCodigo SET cliente.cliNome = '" & txtNome.Text & "', cliente.cliEndereco = '" & txtEndereco.Text & "', cliente.cliBairro = '" & txtBairro.Text & "' , cliente.cliCEP = '" & varCEP & "' , cliente.cliCidade = '" & txtCidade.Text & "', cliente.cliUF = '" & cboUF.Text & "' ,cliente.cliTelefone = '" & varTelefone & "' , cliente.cliCelular = '" & varCelular & "', cliente.cliEmail = '" & txtEmail.Text & "', cliente.cliNumEndereco = '" & txtNumEndereco.Text & "', cliente.cliObservacao = '" & txtObservacao.Text & "', cliente.cliComplemento = '" & txtComplemento.Text & "', cliente.cliWebSite = '" & txtWebsite.Text & "', cliPessoaJuridica.cliCNPJ = '" & varCNPJ & "', cliPessoaJuridica.cliIM = '" & txtIM.Text & "', cliPessoaJuridica.cliIE = '" & varIE & "', cliPessoaJuridica.cliRazaoSocial = '" & txtRazaoSocial.Text & "' WHERE cliente.cliCodigo = " & valorCodCliente

                    'Executa a instrução
                    objBanco.ExecutaQuery(strsql)
                End If

                MsgBox("Dados alterados com sucesso", vbInformation, "Sucesso")

                'Limpa as caixas de texto e coloca o formulário apenas para inserir registros
                modoInserir()
                valorCodCliente = atribuiCodigo("cliCodigo", "cliente")
                txtCodigoCliente.Text = valorCodCliente
            End If
        Catch exc As SqlClient.SqlException
            MsgBox("Erro com banco de dados" & vbCrLf & Err.Description, vbCritical, "Erro com Banco de dados")
        Catch exc As Exception
            MsgBox("Erro" & vbCrLf & Err.Number & vbCrLf & Err.Description, vbCritical, "Erro")
        Finally
            objBanco.DesconectarBanco()
        End Try
    End Sub

    Sub modoInserir()
        'Esta função exibe os botões que cuidam da inserção de registros do formulário clientes
        botCadastrar.Visible = True
        lblCadastrar.Visible = True
        botLimpar.Visible = True
        lblLimpar.Visible = True
        botAlterar.Visible = False
        lblAlterar.Visible = False
        botExcluir.Visible = False
        lblExcluir.Visible = False
        botModoNovo.Visible = False
        lblInserir.Visible = False
        rdbFisica.Checked = True
        rdbFisica.Enabled = True
        rdbJuridica.Enabled = True
        Limpar(Me)
    End Sub

    Private Sub txtConCodigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtConCodigo.KeyPress
        modFuncoes.apenasNumeros(e)
    End Sub

    Private Sub txtConCNPJ_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtConCNPJ.KeyPress
        modFuncoes.apenasNumeros(e)
    End Sub

    Private Sub txtConCpf_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtConCpf.KeyPress
        modFuncoes.apenasNumeros(e)
    End Sub

    Private Sub txtIM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIM.KeyPress
        modFuncoes.apenasNumeros(e)
    End Sub

    Private Sub Clientes_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        modFuncoes.HabilitaBotaoLogOff()
    End Sub

    Private Sub mtxTelefone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mtxTelefone.KeyPress
        modFuncoes.apenasNumeros(e)
    End Sub

    Private Sub mtxCelular_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mtxCelular.KeyPress
        modFuncoes.apenasNumeros(e)
    End Sub

    Private Sub mtxCEP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mtxCEP.KeyPress
        modFuncoes.apenasNumeros(e)
    End Sub
End Class
