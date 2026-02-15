<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        txtNama = New TextBox()
        Label2 = New Label()
        txtTugas = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        txtUTS = New TextBox()
        txtUAS = New TextBox()
        btnTambah = New Button()
        dgvData = New DataGridView()
        colNama = New DataGridViewTextBoxColumn()
        colTugas = New DataGridViewTextBoxColumn()
        colUTS = New DataGridViewTextBoxColumn()
        colUAS = New DataGridViewTextBoxColumn()
        colRata = New DataGridViewTextBoxColumn()
        colGrade = New DataGridViewTextBoxColumn()
        btnBukaFile = New Button()
        btnTutup = New Button()
        OpenFileDialog1 = New OpenFileDialog()
        CType(dgvData, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(53, 59)
        Label1.Name = "Label1"
        Label1.Size = New Size(132, 48)
        Label1.TabIndex = 0
        Label1.Text = "Nama :"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(200, 56)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(300, 55)
        txtNama.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(53, 146)
        Label2.Name = "Label2"
        Label2.Size = New Size(131, 48)
        Label2.TabIndex = 2
        Label2.Text = "Tugas :"
        ' 
        ' txtTugas
        ' 
        txtTugas.Location = New Point(201, 143)
        txtTugas.Name = "txtTugas"
        txtTugas.Size = New Size(120, 55)
        txtTugas.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(374, 146)
        Label3.Name = "Label3"
        Label3.Size = New Size(110, 48)
        Label3.TabIndex = 4
        Label3.Text = "UTS : "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(669, 153)
        Label4.Name = "Label4"
        Label4.Size = New Size(104, 48)
        Label4.TabIndex = 6
        Label4.Text = "UAS :"
        ' 
        ' txtUTS
        ' 
        txtUTS.Location = New Point(477, 146)
        txtUTS.Name = "txtUTS"
        txtUTS.Size = New Size(120, 55)
        txtUTS.TabIndex = 7
        ' 
        ' txtUAS
        ' 
        txtUAS.Location = New Point(779, 150)
        txtUAS.Name = "txtUAS"
        txtUAS.Size = New Size(120, 55)
        txtUAS.TabIndex = 8
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(1064, 146)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(225, 69)
        btnTambah.TabIndex = 9
        btnTambah.Text = "Input"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' dgvData
        ' 
        dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvData.Columns.AddRange(New DataGridViewColumn() {colNama, colTugas, colUTS, colUAS, colRata, colGrade})
        dgvData.Location = New Point(53, 232)
        dgvData.Name = "dgvData"
        dgvData.RowHeadersWidth = 123
        dgvData.Size = New Size(1236, 407)
        dgvData.TabIndex = 10
        ' 
        ' colNama
        ' 
        colNama.HeaderText = "Nama Siswa"
        colNama.MinimumWidth = 15
        colNama.Name = "colNama"
        ' 
        ' colTugas
        ' 
        colTugas.HeaderText = "Tugas"
        colTugas.MinimumWidth = 15
        colTugas.Name = "colTugas"
        ' 
        ' colUTS
        ' 
        colUTS.HeaderText = "UTS"
        colUTS.MinimumWidth = 15
        colUTS.Name = "colUTS"
        ' 
        ' colUAS
        ' 
        colUAS.HeaderText = "UAS"
        colUAS.MinimumWidth = 15
        colUAS.Name = "colUAS"
        ' 
        ' colRata
        ' 
        colRata.HeaderText = "Rata-Rata"
        colRata.MinimumWidth = 15
        colRata.Name = "colRata"
        ' 
        ' colGrade
        ' 
        colGrade.HeaderText = "Grade"
        colGrade.MinimumWidth = 15
        colGrade.Name = "colGrade"
        ' 
        ' btnBukaFile
        ' 
        btnBukaFile.Location = New Point(53, 671)
        btnBukaFile.Name = "btnBukaFile"
        btnBukaFile.Size = New Size(225, 69)
        btnBukaFile.TabIndex = 11
        btnBukaFile.Text = "Buka File"
        btnBukaFile.UseVisualStyleBackColor = True
        ' 
        ' btnTutup
        ' 
        btnTutup.Location = New Point(1064, 671)
        btnTutup.Name = "btnTutup"
        btnTutup.Size = New Size(225, 69)
        btnTutup.TabIndex = 12
        btnTutup.Text = "Keluar"
        btnTutup.UseVisualStyleBackColor = True
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(20F, 48F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1339, 752)
        Controls.Add(btnTutup)
        Controls.Add(btnBukaFile)
        Controls.Add(dgvData)
        Controls.Add(btnTambah)
        Controls.Add(txtUAS)
        Controls.Add(txtUTS)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(txtTugas)
        Controls.Add(Label2)
        Controls.Add(txtNama)
        Controls.Add(Label1)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        CType(dgvData, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTugas As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtUTS As TextBox
    Friend WithEvents txtUAS As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents dgvData As DataGridView
    Friend WithEvents colNama As DataGridViewTextBoxColumn
    Friend WithEvents colTugas As DataGridViewTextBoxColumn
    Friend WithEvents colUTS As DataGridViewTextBoxColumn
    Friend WithEvents colUAS As DataGridViewTextBoxColumn
    Friend WithEvents colRata As DataGridViewTextBoxColumn
    Friend WithEvents colGrade As DataGridViewTextBoxColumn
    Friend WithEvents btnBukaFile As Button
    Friend WithEvents btnTutup As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog

End Class
