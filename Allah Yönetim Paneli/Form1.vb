Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Giriş Yapılıyor, Lütfen Bekleyin...", vbInformation, "Dünya Yönetim Paneli V2.0")
        MsgBox("Başarılı, Hoşgeldiniz!", vbInformation, "Dünya Yönetim Paneli V2.0")
        Me.Hide()
        Form2.Show()
    End Sub
End Class
