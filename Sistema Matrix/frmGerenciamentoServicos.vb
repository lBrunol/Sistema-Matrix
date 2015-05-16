Imports System.Data.OleDb
Imports System.Data
Imports Sistema_Matrix.clsConexaoBanco

Public Class frmGerenciamentoServicos
    'Declaração de variáveis públicas
    Public tabela As DataTable
    Public leitor As OleDbDataReader
    Public strsql As String
    Public valorCodServico As Integer
    Public objBanco As New clsConexaoBanco
    Public varNome As String
    Public varValor As String
    Public varDescricao As String
    Public valRetornado As Integer
    Public varCodigo As Integer
    Public varAliquota As Integer
    Private Sub formServicos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtNome.Focus()
        valorCodServico = atribuiCodigo("svcCodigo", "servicos")
        txtCodigoServico.Text = valorCodServico

        strsql = "SELECT svcCodigo as Código, svcNome as Nome, svcValorHora as Valor, svcDescricao as Descrição FROM servicos"
        'Procedimento da classe conexão access que carrega os dados no datagrid
        objBanco.carregaDataGrid(dtgConsultaServicos, strsql)

    End Sub
    Private Sub botCadastrar_click(sender As Object, e As EventArgs) Handles botCadastrar.Click

        'Função que verifica se os campos obrigatórios estão vazios
        valRetornado = modFuncoes.verificaVazio(Me)

        'Testa se o valor retornado pela função para dar continuidade aos comandos
        If valRetornado = 0 Then
            'Abre conexão com banco de dados
            Try
                'Variáveis para armazenar os campos de texto
                varNome = txtNome.Text
                varValor = CInt(txtValor.Text)
                varDescricao = txtDescricao.Text
                varCodigo = txtCodigo.Text
                varAliquota = txtAliquota.Text
                'Comando para inclusão dos dados
                strsql = "INSERT INTO servicos(svcCodigo, svcCodigoServico, svcAliquota, svcNome, svcValorHora, svcDescricao) VALUES (" & _
                    valorCodServico & " , " & _
                    varCodigo & ", " & _
                    varAliquota & ", '" & _
                    varNome & "', " & _
                    varValor & ", '" & _
                    varDescricao & "')"
                objBanco.ExecutaQuery(strsql)
                MsgBox("Dados cadastrados com sucesso", vbInformation, "Aviso")
                modFuncoes.Limpar(Me)
                valorCodServico = atribuiCodigo("svcCodigo", "servicos")
                txtCodigoServico.Text = valorCodServico
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
                If leitor IsNot Nothing Then leitor.Close()
            End Try
        End If
    End Sub
    Private Sub botLimpar_Click(sender As Object, e As EventArgs) Handles botLimpar.Click
        'Chama a função para limpar as textbox
        modFuncoes.Limpar(Me)
        valorCodServico = atribuiCodigo("svcCodigo", "servicos")
        txtCodigoServico.Text = valorCodServico
    End Sub
    Private Sub dtgConsultaServicos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgConsultaServicos.CellDoubleClick
        Try
            'Armazena na variável o código da linha que será utilizada na clausula where do select
            valorCodServico = dtgConsultaServicos.CurrentRow.Cells(0).Value

            'Seleciona a primeira aba do tab
            tabServico.SelectTab(0)

            'Abre a conexão

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

            strsql = "SELECT servicos.* FROM servicos WHERE svcCodigo = " & valorCodServico
            leitor = objBanco.ExecutaDataRead(strsql)
            leitor.Read()
            txtCodigo.Text = leitor.Item(4).ToString
            txtAliquota.Text = leitor.Item(5).ToString
            txtNome.Text = leitor.Item(1).ToString
            txtValor.Text = leitor.Item(2).ToString
            txtDescricao.Text = leitor.Item(3).ToString
            txtValor.Text = String.Format("{0:c}", Double.Parse(txtValor.Text))
        Catch exc As SqlClient.SqlException
            MsgBox("Erro com banco de dados" & vbCrLf & Err.Description, vbCritical, "Erro com Banco de dados")
        Catch exc As Exception
            MsgBox("Erro" & vbCrLf & Err.Number & vbCrLf & Err.Description, vbCritical, "Erro")
        Finally
            objBanco.DesconectarBanco()
            strsql = String.Empty
            'Testa se a variável leitor foi alterada, se sim a conexão com banco de dados será fechada
            If leitor IsNot Nothing Then leitor.Close()
        End Try
    End Sub

    Private Sub botModoNovo_Click(sender As Object, e As EventArgs) Handles botModoNovo.Click
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
        Limpar(Me)
        valorCodServico = atribuiCodigo("svcCodigo", "servicos")
        txtCodigoServico.Text = valorCodServico
    End Sub

    Private Sub tabConsultaClientes_Enter(sender As Object, e As EventArgs) Handles tabConsultaServicos.Enter
        'dtgConsultaServicos.Rows.Clear()

        Try

            strsql = "SELECT svcCodigo as Código, svcNome as Nome, svcValorHora as Valor, svcDescricao as Descrição FROM servicos"
            'Procedimento da classe conexão access que carrega os dados no datagrid
            objBanco.carregaDataGrid(dtgConsultaServicos, strsql)


            'Seta a largura das colunas
            dtgConsultaServicos.Columns(0).Width = "40"
            dtgConsultaServicos.Columns(1).Width = "160"
            dtgConsultaServicos.Columns(2).Width = "50"
            dtgConsultaServicos.Columns(3).Width = "170"

        Catch exc As SqlClient.SqlException
            MsgBox("Erro com banco de dados" & vbCrLf & Err.Description, vbCritical, "Erro com Banco de dados")
        Catch exc As Exception
            MsgBox("Erro" & vbCrLf & Err.Number & vbCrLf & Err.Description, vbCritical, "Erro")
        Finally
            objBanco.DesconectarBanco()
            dtgConsultaServicos.Refresh()
            'Testa se a variável leitor foi alterada, se sim a conexão com banco de dados será fechada
            If leitor IsNot Nothing Then leitor.Close()
        End Try
    End Sub

    Private Sub botExcluir_Click(sender As Object, e As EventArgs) Handles botExcluir.Click
        If MsgBox("Deseja excluir realmente o registro", vbQuestion + vbYesNo, "Confirme") = vbYes Then
            Try
                strsql = "DELETE FROM servicos WHERE servicos.svcCodigo = " & valorCodServico
                objBanco.ExecutaQuery(strsql)
                MsgBox("Registro Excluído com sucesso", vbInformation, "Sucesso")
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
                Limpar(Me)
                valorCodServico = atribuiCodigo("svcCodigo", "servicos")
                txtCodigoServico.Text = valorCodServico
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

        Try
            'Função que verifica se os campos obrigatórios estão vazios
            valRetornado = modFuncoes.verificaVazio(Me)

            'Testa se o valor retornado pela função para dar continuidade aos comandos
            If valRetornado = 0 Then

                varNome = txtNome.Text
                varDescricao = txtDescricao.Text
                varCodigo = txtCodigo.Text
                varAliquota = txtAliquota.Text
                varValor = Replace(txtValor.Text, "R$", "")
                varValor = Replace(varValor, ",", ".")

                'Comando SQL
                strsql = "UPDATE servicos SET servicos.svcCodigoServico = " & varCodigo & ", servicos.svcAliquota = " & varAliquota & ", servicos.svcNome = '" & varNome & "', servicos.svcValorHora = " & varValor & ", servicos.svcDescricao = '" & varDescricao & "' WHERE servicos.svcCodigo = " & valorCodServico
                objBanco.ExecutaQuery(strsql)
                MsgBox("Dados alterados com sucesso", vbInformation, "Sucesso")
                modFuncoes.Limpar(Me)
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
                valorCodServico = atribuiCodigo("svcCodigo", "servicos")
                txtCodigoServico.Text = valorCodServico
            End If
        Catch exc As SqlClient.SqlException
            MsgBox("Erro com banco de dados" & vbCrLf & Err.Description, vbCritical, "Erro com Banco de dados")
        Catch exc As Exception
            MsgBox("Erro" & vbCrLf & Err.Number & vbCrLf & Err.Description, vbCritical, "Erro")
        Finally
            objBanco.DesconectarBanco()
        End Try
    End Sub

    Private Sub txtValor_Leave(sender As Object, e As EventArgs) Handles txtValor.Leave
        Try
            txtValor.Text = String.Format("{0:c}", Double.Parse(txtValor.Text))
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txtValor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtValor.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))

        KeyAscii = CShort(SoNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub formConsultaUsuarios_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        modFuncoes.HabilitaBotaoLogOff()
    End Sub
End Class
