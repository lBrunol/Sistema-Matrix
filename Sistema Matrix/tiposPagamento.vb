Imports System.Data.OleDb
Imports System.Data
Imports Sistema_Matrix.ConexaoAccess
Public Class tiposPagamento

    'Armazena o valor da PK
    Public valorCodigo As Integer
    'Variável que recebe o valor retornado pela função que verifica se os campos estão vazios
    Private valorRetornado As Integer
    'Instância da classe de conexão ao banco
    Private objBanco As New ConexaoAccess
    'Variável que le os dados da tabela
    Private tabela As DataTable
    'Variável usada para os comandos select
    Private leitor As OleDbDataReader
    'String que armazena os comandos SQL
    Private strSQL As String



    Private Sub botCadastrar_Click(sender As Object, e As EventArgs) Handles botCadastrar.Click
        'Armazena na variável o valor que foi retornado pela função, o argumento é o próprio form
        valorRetornado = Funcoes.verificaVazio(Me)

        'Teste se o valor retornado é 0 ou mais, para poder proceder
        If (valorRetornado = 0) Then
            'Instrução SQL
            strSQL = "INSERT INTO tiposPagamento (tpaCodigo, tpaDescricao) VALUES (" & valorCodigo & ", '" & txtDescricao.Text & "')"
            'Executa a instrução de inserção no banco através do objeto da classe ConexaoAccess
            objBanco.ExecutaQuery(strSQL)
            MsgBox("Dados gravados com sucesso", vbInformation, "Aviso")
            'Função para limpar os campos do formulário
            Funcoes.Limpar(Me)
            'Chama a função privada para atribuir código
            geraCodigo()
            'Sub que fecha as conexões com banco e zera as variáveis usadas
            zeraVariaveisBanco()
        End If

    End Sub

    Private Sub tiposPagamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Chama a função privada para atribuir código
        geraCodigo()
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

    Private Sub botLimpar_Click(sender As Object, e As EventArgs) Handles botLimpar.Click
        'Função para limpar os campos do formulário
        Funcoes.Limpar(Me)
        'Chama a função privada para atribuir código
        geraCodigo()
    End Sub

    Private Sub geraCodigo()
        'Atribui o valor retornado pela função atribuiCodigo a textbox do Código
        valorCodigo = atribuiCodigo("tpaCodigo", "tiposPagamento")
        txtCodigo.Text = valorCodigo
    End Sub
End Class