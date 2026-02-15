# Aplikasi Nilai Mahasiswa (VB.NET)

Program Windows Forms untuk input nilai mahasiswa secara manual dan dari file .txt, menghitung rata-rata, menentukan grade, dan menampilkan data di DataGridView.

## Fitur
- Input manual: Nama, Tugas, UTS, UAS
- Baca file .txt
- Hitung rata-rata dan grade
- Tampil tabel (DataGridView)
- Tombol keluar dengan konfirmasi

## Format File .txt
Setiap baris:
Nama,Tugas,UTS,UAS

Contoh:
Andi,80,70,90
Budi,60,65,70

## Kriteria Tugas Terpenuhi
- Membaca file: OpenFileDialog + File.ReadAllLines()
- Percabangan: If/ElseIf (validasi input, penentuan grade)
- Perulangan: For Each (membaca baris file)
- Procedure: Sub ProsesFileNilai(path As String)
