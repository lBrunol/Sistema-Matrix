Imports System.Data.OleDb
Imports System.Data
Imports Sistema_Matrix.clsConexaoBanco

Public Class frmCadastroEmitente

    'Declaração de variáveis públicas
    Public tabela As DataTable
    Public leitor As OleDbDataReader
    Public strsql As String
    Public valorCodCliente As Integer
    Public objBanco As New clsConexaoBanco

    Private Sub DadosEmitente_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Carrega as mascaras nas caixas de texto
        mtxCep.Mask = "00000-000"
        mtxTelefone.Mask = "(00)0000-0000"


    End Sub

    Private Sub botCadastrar_Click(sender As System.Object, e As System.EventArgs) Handles botCadastrar.Click

        'Variáveis para armazenar os campos de texto
        Dim varCodigo As Integer
        Dim varNomeFantasia As String
        Dim varRazaoSocial As String
        Dim varIM As String
        Dim varIE As String
        Dim varEndereco As String
        Dim varCep As String
        Dim varTelefone As String

        'Declaração de variáveis
        Dim valRetornado As Integer

        'Definição das variáveis
        varNomeFantasia = txtNomeFantasia.Text
        varRazaoSocial = txtRazaoSocial.Text
        varIM = txtIM.Text
        varIE = txtIE.Text
        varEndereco = txtEndereco.Text
        varCep = mtxCep.Text
        varTelefone = mtxTelefone.Text

        'Atribui o valor retornado pela função atribuiCodigo a variável do Código
        valorCodCliente = atribuiCodigo("demCodigo", "dadosEmitente")
        varCodigo = valorCodCliente

        'Função que verifica se os campos obrigatórios estão vazios
        valRetornado = modFuncoes.verificaVazio(Me)

        'Testa se o valor retornado pela função para dar continuidade aos comandos
        If valRetornado = 0 Then

            'Retira a máscara das caixas de texto
            varCep = Replace(mtxCep.Text, "-", "")

            varTelefone = Replace(mtxTelefone.Text, "(", "")
            varTelefone = Replace(varTelefone, ")", "")
            varTelefone = Replace(varTelefone, "-", "")

            Try
                'Comando para inclusão dos dados
                strsql = "INSERT INTO dadosEmitente(demCodigo, demNomeFantasia, demRazaoSocial, demInscricaoEstadual, demInscricaoMunicipal, demCEP, demTelefone, demEndereco, demMunicipio, demUF) VALUES (" & _
                    varCodigo & ", '" & _
                    varNomeFantasia & "','" & _
                    varRazaoSocial & "','" & _
                    varIM & "','" & _
                    varIE & "','" & _
                    varEndereco & "','" & _
                    varCep & "','" & _
                    varTelefone & "','" & _
                    Txtmunicipio.Text & "','" & _
                    Txtuf.Text & "')"

                'Executa a instrução
                objBanco.ExecutaQuery(strsql)

                MsgBox("Dados gravados com sucesso", vbInformation, "Aviso")
                Limpar(Me)

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

    Private Sub botLimpar_Click(sender As System.Object, e As System.EventArgs) Handles botLimpar.Click
        'Chama a função para limpar as textbox
        modFuncoes.Limpar(Me)
    End Sub

    Private Sub botAlterar_Click(sender As System.Object, e As System.EventArgs) Handles botAlterar.Click

        'Variáveis para armazenar os campos de texto
        Dim varCodigo As Integer
        Dim varNomeFantasia As String
        Dim varRazaoSocial As String
        Dim varIM As String
        Dim varIE As String
        Dim varEndereco As String
        Dim varCep As String
        Dim varTelefone As String

        'Declaração de variáveis
        Dim valRetornado As Integer

        'Definição das variáveis
        varNomeFantasia = txtNomeFantasia.Text
        varRazaoSocial = txtRazaoSocial.Text
        varIM = txtIM.Text
        varIE = txtIE.Text
        varEndereco = txtEndereco.Text
        varCep = mtxCep.Text
        varTelefone = mtxTelefone.Text

        Try
            'Retira a máscara das caixas de texto
            varCep = Replace(mtxCep.Text, "-", "")

            varTelefone = Replace(mtxTelefone.Text, "(", "")
            varTelefone = Replace(varTelefone, ")", "")
            varTelefone = Replace(varTelefone, "-", "")

            'Função que verifica se os campos obrigatórios estão vazios
            valRetornado = modFuncoes.verificaVazio(Me)

            If valRetornado = 0 Then
                strsql = "update dadosEmitente set demNomeFantasia='" & varNomeFantasia & "', demRazaoSocial='" & varRazaoSocial & "', demInscricaoEstadual='" & varIE & "', demInscricaoMunicipal='" & varIM & "', demCEP='" & varCep & "', demTelefone='" & varTelefone & "', demEndereco='" & varEndereco & "' where demCodigo=" & varCodigo & ""
                'Executa a instrução
                objBanco.ExecutaQuery(strsql)
                MsgBox("Dados alterados com sucesso", vbInformation, "Sucesso")
            End If

        Catch exc As SqlClient.SqlException
            MsgBox("Erro com banco de dados" & vbCrLf & Err.Description, vbCritical, "Erro com Banco de dados")
        Catch exc As Exception
            MsgBox("Erro" & vbCrLf & Err.Number & vbCrLf & Err.Description, vbCritical, "Erro")
        Finally
            objBanco.DesconectarBanco()
        End Try
    End Sub

    Private Sub botExcluir_Click(sender As System.Object, e As System.EventArgs) Handles botExcluir.Click
        If MsgBox("Deseja excluir realmente o registro", vbQuestion + vbYesNo, "Confirme") = vbYes Then

            Dim varCodigo As Integer

            Try
                'Variável que armazena o comando SQL
                strsql = "DELETE FROM dadosEmitente WHERE demCodigo=" & varCodigo & ""

                'Executa a instrução
                objBanco.ExecutaQuery(strsql)

                MsgBox("Registro Excluído com sucesso", vbInformation, "Sucesso")

            Catch exc As SqlClient.SqlException
                MsgBox("Erro com banco de dados" & vbCrLf & Err.Description, vbCritical, "Erro com Banco de dados")
            Catch exc As Exception
                MsgBox("Erro" & vbCrLf & Err.Number & vbCrLf & Err.Description, vbCritical, "Erro")
            Finally
                objBanco.DesconectarBanco()
            End Try
        End If
    End Sub

    Private Sub frmCadastroEmitente_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        modFuncoes.HabilitaBotaoLogOff()
    End Sub

    Private Sub MaskeTextBox1_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs)

    End Sub
End Class