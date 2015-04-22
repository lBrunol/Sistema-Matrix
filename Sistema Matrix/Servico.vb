Imports System.Data.OleDb
Imports System.Data
Imports Sistema_Matrix.ConexaoAccess

Public Class formConsultaUsuarios
    'Declaração de variáveis públicas
    Public tabela As DataTable
    Public leitor As OleDbDataReader
    Public strsql As String
    Public valorCodServico As Integer
    Public objBanco As New ConexaoAccess
    Private Sub formServicos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNome.Focus()
        valorCodServico = atribuiCodigo("svcCodigo", "servicos")
        txtCodigoServico.Text = valorCodServico
    End Sub
    Private Sub botCadastrar_click(sender As Object, e As EventArgs) Handles botCadastrar.Click
        'Variáveis para armazenar os campos de texto
        Dim varNome As String
        Dim varValor As String
        Dim varDescricao As String
        Dim valRetornado As Integer

        varNome = txtNome.Text
        varValor = txtValor.Text
        varDescricao = txtDescricao.Text
        varValor = CInt(varValor)
        'Função que verifica se os campos obrigatórios estão vazios
        valRetornado = Funcoes.verificaVazio(Me)

        'Testa se o valor retornado pela função para dar continuidade aos comandos
        If valRetornado = 0 Then
            'Abre conexão com banco de dados
            Try
                'Comando para inclusão dos dados
                strsql = "INSERT INTO servicos(svcCodigo, svcNome, svcValorHora, svcDescricao, svcCodigoServico, svcAliquota) VALUES (" & _
                    valorCodServico & " , '" & _
                    varNome & "','" & _
                    varValor & "','" & _
                    varDescricao & "', " & 1 & ", " & 5 & ")"
                objBanco.ExecutaQuery(strsql)
                MsgBox("Dados cadastrados com sucesso", vbInformation, "Aviso")
                Funcoes.Limpar(Me)
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
        Funcoes.Limpar(Me)
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

            'Verifica qual dos radio buttons estão marcados e carrega os valores do select nas textbox
            strsql = "SELECT servicos.* FROM servicos WHERE svcCodigo = " & valorCodServico
            leitor = objBanco.ExecutaDataRead(strsql)
            leitor.Read()
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
    End Sub

    Private Sub tabConsultaClientes_Enter(sender As Object, e As EventArgs) Handles tabConsultaServicos.Enter
        dtgConsultaServicos.Rows.Clear()

        Try

            'Adiciona o cabeçalho das colunas
            dtgConsultaServicos.ColumnCount = 4
            dtgConsultaServicos.Columns(0).Name = "Codigo"
            dtgConsultaServicos.Columns(1).Name = "Nome"
            dtgConsultaServicos.Columns(2).Name = "Valor"
            dtgConsultaServicos.Columns(3).Name = "Descrição"

            'Seta a largura das colunas
            dtgConsultaServicos.Columns(0).Width = "40"
            dtgConsultaServicos.Columns(1).Width = "160"
            dtgConsultaServicos.Columns(2).Width = "50"
            dtgConsultaServicos.Columns(3).Width = "170"

            'Início da operação de consulta
            tabela = New DataTable()

            strsql = "SELECT servicos.* FROM servicos"
            tabela = objBanco.ExecutaDataTable(strsql)
            If tabela.Rows.Count > 0 Then
                Dim i As Integer = 0
                For i = 0 To tabela.Rows.Count - 1
                    dtgConsultaServicos.Rows.Add(tabela.Rows(i)("svcCodigo"), tabela.Rows(i)("svcNome"), tabela.Rows(i)("svcValor"), tabela.Rows(i)("svcDescricao"))
                Next
            End If

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
        'Variáveis para armazenar os campos de texto
        Dim varNome As String
        Dim varValor As String
        Dim varDescricao As String
        Dim valRetornado As Integer

        varNome = txtNome.Text
        varValor = txtValor.Text
        varDescricao = txtDescricao.Text

        varValor = Replace(txtValor.Text, "R$", "")
        varValor = Replace(varValor, ",", ".")
        Try
            'Função que verifica se os campos obrigatórios estão vazios
            valRetornado = Funcoes.verificaVazio(Me)

            'Testa se o valor retornado pela função para dar continuidade aos comandos
            If valRetornado = 0 Then
                'Comando SQL
                strsql = "UPDATE servicos SET servicos.svcNome = '" & varNome & "', servicos.svcValor = " & varValor & ", servicos.svcDescricao = '" & varDescricao & "' WHERE servicos.svcCodigo = " & valorCodServico
                objBanco.ExecutaQuery(strsql)
                MsgBox("Dados alterados com sucesso", vbInformation, "Sucesso")
                Funcoes.Limpar(Me)
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
        Funcoes.HabilitaBotaoLogOff()
    End Sub


    Private Sub tabCadastroServicos_Click(sender As Object, e As EventArgs) Handles tabCadastroServicos.Click

    End Sub
End Class
