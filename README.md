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

## Cara Menjalankan
1. Download/clone repository
2. Buka Visual Studio
3. File → Open → Project/Solution
4. Buka `uas.slnx` atau langsung `uas.vbproj`
5. Klik Start (Run)

## Kriteria Tugas Terpenuhi
- Membaca file: OpenFileDialog + File.ReadAllLines()
- Percabangan: If/ElseIf (validasi input, penentuan grade)
- Perulangan: For Each (membaca baris file)
- Procedure: Sub ProsesFileNilai(path As String)
