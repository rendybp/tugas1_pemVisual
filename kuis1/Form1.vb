Public Class Form1

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub btnHasil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHasil.Click
        namaOutput.Text = namaInput.Text
        telpOutput.Text = telpInput.Text
        alamatOutput.Text = alamatInput.Text
        namaMobilOutput.Text = namaMobilInput.Text
        hargaOutput.Text = hargaInput.Text
        hariOutput.Text = hariInput.Text
        totalOutput.Text = totalInput.Text
    End Sub

    Private Sub btnUlangi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUlangi.Click
        namaInput.Text = " "
        telpInput.Text = " "
        alamatInput.Text = " "
        namaMobilInput.Text = " "
        hargaInput.Text = " "
        hariInput.Text = " "
        totalInput.Text = " "

        namaOutput.Text = " "
        telpOutput.Text = " "
        alamatOutput.Text = " "
        namaMobilOutput.Text = " "
        hargaOutput.Text = " "
        hariOutput.Text = " "
        totalOutput.Text = " "

        namaInput.Focus()
    End Sub

    Private Sub btnHitung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHitung.Click
        Dim harga As String
        Dim hari As Integer
        Dim total As String

        harga = CInt(hargaInput.Text)
        hari = CInt(hariInput.Text)

        total = (harga * hari)
        totalInput.Text = "Rp. " & total
    End Sub

End Class
