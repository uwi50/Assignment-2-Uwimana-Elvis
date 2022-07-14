Public Class AccInfo
    Public accountnumber As String
    Public OwnerName As String
    Public OwnerAddress As String
    Public email As String
    Public balance As Decimal

    Public Overrides Function ToString() As String
        Return " " & accountnumber & vbTab & OwnerName & vbTab & OwnerAddress & vbTab & vbTab & email & vbTab & vbTab & balance
    End Function
    Public Sub New(accountnumber As String, OwnerName As String, OwnerAddress As String, email As String, balance As Decimal)
        Me.accountnumber = accountnumber
        Me.OwnerName = OwnerName
        Me.OwnerAddress = OwnerAddress
        Me.email = email
        Me.balance = balance
    End Sub
    Public Sub New()

    End Sub

End Class
