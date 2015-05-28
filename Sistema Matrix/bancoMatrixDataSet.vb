Partial Class bancoMatrixDataSet
    Partial Class relNotaFiscalDataTable

        Private Sub relNotaFiscalDataTable_relNotaFiscalRowChanging(sender As System.Object, e As relNotaFiscalRowChangeEvent) Handles Me.relNotaFiscalRowChanging

        End Sub

        Private Sub relNotaFiscalDataTable_ColumnChanging(sender As System.Object, e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.DataColumn1Column.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Class notaFiscalDataTable

        Private Sub notaFiscalDataTable_ColumnChanging(sender As System.Object, e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.notCodVerColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

End Class

Namespace bancoMatrixDataSetTableAdapters

    Partial Class relNFTableAdapter

    End Class

    Partial Public Class relOrdensTableAdapter
    End Class
End Namespace
