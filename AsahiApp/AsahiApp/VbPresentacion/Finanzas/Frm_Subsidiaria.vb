Public Class Frm_Subsidiaria
    Private subsiSelect_ As String
    Public Property SubsiSelect() As String
        Get
            Return subsiSelect_
        End Get
        Set(ByVal value As String)
            subsiSelect_ = value
        End Set
    End Property
    Private Sub Btn_Mx_Click(sender As Object, e As EventArgs) Handles Btn_Mx.Click
        Me.SubsiSelect = "MEX"
        DialogResult = DialogResult.OK
        Me.Dispose()
    End Sub
    Private Sub Btn_Serv_Click(sender As Object, e As EventArgs) Handles Btn_Serv.Click
        Me.SubsiSelect = "SERV"
        DialogResult = DialogResult.OK
        Me.Dispose()
    End Sub
End Class