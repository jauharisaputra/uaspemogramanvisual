Imports System.IO

Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        ' Ambil nilai dari input
        Dim nama As String = txtNama.Text
        Dim absensi As Double = CDbl(txtAbsensi.Text)
        Dim tugas As Double = CDbl(txtTugas.Text)
        Dim uts As Double = CDbl(txtUTS.Text)
        Dim uas As Double = CDbl(txtUAS.Text)

        ' Hitung nilai akhir
        Dim nilaiAkhir As Double = (absensi * 0.3) + (tugas * 0.1) + (uts * 0.3) + (uas * 0.3)

        ' Hitung Grade dan Status
        Dim grade As String
        Dim status As String

        If nilaiAkhir >= 80 Then
            grade = "A"
            status = "Lulus"
        ElseIf nilaiAkhir >= 70 Then
            grade = "B"
            status = "Lulus"
        ElseIf nilaiAkhir >= 60 Then
            grade = "C"
            status = "Lulus"
        ElseIf nilaiAkhir >= 50 Then
            grade = "D"
            status = "Tidak Lulus"
        Else
            grade = "E"
            status = "Tidak Lulus"
        End If

        ' Tampilkan di DataGridView
        dgvData.Rows.Add(nama, absensi, tugas, uts, uas, nilaiAkhir, grade, status)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Dim filePath As String = "data_nilai.txt"
        Using writer As New StreamWriter(filePath, False)
            For Each row As DataGridViewRow In dgvData.Rows
                If Not row.IsNewRow Then
                    Dim line As String = $"{row.Cells(0).Value};{row.Cells(1).Value};{row.Cells(2).Value};" &
                                     $"{row.Cells(3).Value};{row.Cells(4).Value};{row.Cells(5).Value};" &
                                     $"{row.Cells(6).Value};{row.Cells(7).Value}"
                    writer.WriteLine(line)
                End If
            Next
        End Using
        MessageBox.Show("Data berhasil disimpan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnMuatData.Click
        Dim filePath As String = "data_nilai.txt"
        If Not File.Exists(filePath) Then
            MessageBox.Show("File data tidak ditemukan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        dgvData.Rows.Clear()
        Using reader As New StreamReader(filePath)
            While Not reader.EndOfStream
                Dim line As String = reader.ReadLine()
                Dim data() As String = line.Split(";"c)

                If data.Length = 8 Then
                    dgvData.Rows.Add(data(0), data(1), data(2), data(3), data(4), data(5), data(6), data(7))
                End If
            End While
        End Using
        MessageBox.Show("Data berhasil dimuat!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtNama.Clear()
        txtAbsensi.Clear()
        txtTugas.Clear()
        txtUTS.Clear()
        txtUAS.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
