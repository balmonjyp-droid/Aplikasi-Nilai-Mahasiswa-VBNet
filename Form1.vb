Imports System.IO 'Wajib ada di paling atas untuk fitur Buka File

Public Class Form1

    '--- 1. TOMBOL "BUTTON1" (UNTUK INPUT MANUAL & HITUNG) ---
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        'Cek apakah kotak isian masih kosong
        If txtNama.Text = "" Or txtTugas.Text = "" Or txtUTS.Text = "" Or txtUAS.Text = "" Then
            MessageBox.Show("Mohon isi semua kolom (Nama, Tugas, UTS, UAS)!", "Data Belum Lengkap", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            'Mengambil data dari TextBox
            Dim nama As String = txtNama.Text
            Dim tugas As Double = Convert.ToDouble(txtTugas.Text)
            Dim uts As Double = Convert.ToDouble(txtUTS.Text)
            Dim uas As Double = Convert.ToDouble(txtUAS.Text)

            'Rumus Rata-rata
            Dim rataRata As Double = (tugas + uts + uas) / 3

            'Cari Grade (Panggil Fungsi di bawah)
            Dim grade As String = HitungGrade(rataRata)

            'Masukkan ke Tabel (DataGridView)
            'Math.Round(rataRata, 2) artinya membulatkan 2 angka di belakang koma
            dgvData.Rows.Add(nama, tugas, uts, uas, Math.Round(rataRata, 2), grade)

            'Bersihkan TextBox setelah data masuk
            txtNama.Clear()
            txtTugas.Clear()
            txtUTS.Clear()
            txtUAS.Clear()
            txtNama.Focus() 'Kembalikan kursor ke nama

        Catch ex As Exception
            'Pesan error jika user memasukkan huruf di kolom angka
            MessageBox.Show("Pastikan Nilai Tugas/UTS/UAS hanya diisi ANGKA!", "Salah Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    '--- 2. TOMBOL "BUKA FILE" ---
    Private Sub btnBukaFile_Click(sender As Object, e As EventArgs) Handles btnBukaFile.Click
        OpenFileDialog1.Filter = "Text Files (*.txt)|*.txt"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            'Panggil prosedur baca file
            ProsesFileNilai(OpenFileDialog1.FileName)
        End If
    End Sub

    '--- 3. PROSEDUR MEMBACA FILE (LOGIKA) ---
    Private Sub ProsesFileNilai(path As String)
        Try
            Dim lines() As String = File.ReadAllLines(path)

            For Each line As String In lines
                'Memisahkan data berdasarkan koma
                Dim parts() As String = line.Split(","c)

                'Pastikan format baris file benar (ada 4 data)
                If parts.Length = 4 Then
                    Dim nama As String = parts(0)
                    Dim tugas As Double = Convert.ToDouble(parts(1))
                    Dim uts As Double = Convert.ToDouble(parts(2))
                    Dim uas As Double = Convert.ToDouble(parts(3))

                    Dim rataRata As Double = (tugas + uts + uas) / 3
                    Dim grade As String = HitungGrade(rataRata)

                    dgvData.Rows.Add(nama, tugas, uts, uas, Math.Round(rataRata, 2), grade)
                End If
            Next
            MessageBox.Show("Data dari file berhasil dimasukkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Gagal membaca file: " & ex.Message)
        End Try
    End Sub

    '--- 4. FUNGSI UNTUK MENENTUKAN GRADE (PERCABANGAN) ---
    Private Function HitungGrade(nilai As Double) As String
        If nilai >= 85 Then
            Return "A"
        ElseIf nilai >= 75 Then
            Return "B"
        ElseIf nilai >= 60 Then
            Return "C"
        ElseIf nilai >= 50 Then
            Return "D"
        Else
            Return "E"
        End If
    End Function

    '--- 5. TOMBOL "KELUAR" ---
    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Dim tanya As DialogResult = MessageBox.Show("Yakin ingin keluar?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If tanya = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub
End Class