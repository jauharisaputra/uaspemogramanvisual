<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtAbsensi = New System.Windows.Forms.TextBox()
        Me.txtTugas = New System.Windows.Forms.TextBox()
        Me.txtUTS = New System.Windows.Forms.TextBox()
        Me.txtUAS = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnHitung = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnMuatData = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.dgvData = New System.Windows.Forms.DataGridView()
        Me.colNama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAbsensi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTugas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colUTS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colUAS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNilaiAkhir = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colGrade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(183, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(471, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Aplikasi Pengolahan Data Nilai Mahasiswa UNSIA"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtUAS)
        Me.GroupBox1.Controls.Add(Me.txtUTS)
        Me.GroupBox1.Controls.Add(Me.txtTugas)
        Me.GroupBox1.Controls.Add(Me.txtAbsensi)
        Me.GroupBox1.Controls.Add(Me.txtNama)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 50)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(164, 388)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INPUT DATA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nama Mahasiswa"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Absensi"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(5, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Tugas"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(5, 235)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 16)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "UTS"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(5, 311)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 16)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "UAS"
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(6, 49)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(152, 20)
        Me.txtNama.TabIndex = 5
        '
        'txtAbsensi
        '
        Me.txtAbsensi.Location = New System.Drawing.Point(6, 110)
        Me.txtAbsensi.Name = "txtAbsensi"
        Me.txtAbsensi.Size = New System.Drawing.Size(76, 20)
        Me.txtAbsensi.TabIndex = 6
        '
        'txtTugas
        '
        Me.txtTugas.Location = New System.Drawing.Point(6, 185)
        Me.txtTugas.Name = "txtTugas"
        Me.txtTugas.Size = New System.Drawing.Size(76, 20)
        Me.txtTugas.TabIndex = 7
        '
        'txtUTS
        '
        Me.txtUTS.Location = New System.Drawing.Point(6, 265)
        Me.txtUTS.Name = "txtUTS"
        Me.txtUTS.Size = New System.Drawing.Size(76, 20)
        Me.txtUTS.TabIndex = 8
        '
        'txtUAS
        '
        Me.txtUAS.Location = New System.Drawing.Point(6, 330)
        Me.txtUAS.Name = "txtUAS"
        Me.txtUAS.Size = New System.Drawing.Size(76, 20)
        Me.txtUAS.TabIndex = 9
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvData)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(183, 50)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(595, 239)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "OUTPUT DATA"
        '
        'btnHitung
        '
        Me.btnHitung.Location = New System.Drawing.Point(225, 312)
        Me.btnHitung.Name = "btnHitung"
        Me.btnHitung.Size = New System.Drawing.Size(115, 23)
        Me.btnHitung.TabIndex = 11
        Me.btnHitung.Text = "Hitung Nilai"
        Me.btnHitung.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(225, 357)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(115, 23)
        Me.btnSimpan.TabIndex = 12
        Me.btnSimpan.Text = "Simpan ke File"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'btnMuatData
        '
        Me.btnMuatData.Location = New System.Drawing.Point(225, 401)
        Me.btnMuatData.Name = "btnMuatData"
        Me.btnMuatData.Size = New System.Drawing.Size(115, 23)
        Me.btnMuatData.TabIndex = 13
        Me.btnMuatData.Text = "Muat Data dari File"
        Me.btnMuatData.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(561, 313)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 14
        Me.btnClear.Text = "Hapus Form"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(670, 312)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "Keluar"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'dgvData
        '
        Me.dgvData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvData.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgvData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colNama, Me.colAbsensi, Me.colTugas, Me.colUTS, Me.colUAS, Me.colNilaiAkhir, Me.colGrade, Me.colStatus})
        Me.dgvData.Location = New System.Drawing.Point(6, 23)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dgvData.RowHeadersWidth = 18
        Me.dgvData.Size = New System.Drawing.Size(589, 166)
        Me.dgvData.TabIndex = 0
        '
        'colNama
        '
        Me.colNama.HeaderText = "Nama Mahasiswa"
        Me.colNama.Name = "colNama"
        Me.colNama.Width = 119
        '
        'colAbsensi
        '
        Me.colAbsensi.HeaderText = "Absensi"
        Me.colAbsensi.Name = "colAbsensi"
        Me.colAbsensi.Width = 76
        '
        'colTugas
        '
        Me.colTugas.HeaderText = "Tugas"
        Me.colTugas.Name = "colTugas"
        Me.colTugas.Width = 67
        '
        'colUTS
        '
        Me.colUTS.HeaderText = "UTS"
        Me.colUTS.Name = "colUTS"
        Me.colUTS.Width = 57
        '
        'colUAS
        '
        Me.colUAS.HeaderText = "UAS"
        Me.colUAS.Name = "colUAS"
        Me.colUAS.Width = 57
        '
        'colNilaiAkhir
        '
        Me.colNilaiAkhir.HeaderText = "Nilai Akhir"
        Me.colNilaiAkhir.Name = "colNilaiAkhir"
        Me.colNilaiAkhir.Width = 83
        '
        'colGrade
        '
        Me.colGrade.HeaderText = "Grade"
        Me.colGrade.Name = "colGrade"
        Me.colGrade.Width = 66
        '
        'colStatus
        '
        Me.colStatus.HeaderText = "Status"
        Me.colStatus.Name = "colStatus"
        Me.colStatus.Width = 68
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnMuatData)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.btnHitung)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Aplikasi Pengolahan Data Nilai Mahasiswa UNSIA"
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtUAS As TextBox
    Friend WithEvents txtUTS As TextBox
    Friend WithEvents txtTugas As TextBox
    Friend WithEvents txtAbsensi As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnHitung As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnMuatData As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents dgvData As DataGridView
    Friend WithEvents colNama As DataGridViewTextBoxColumn
    Friend WithEvents colAbsensi As DataGridViewTextBoxColumn
    Friend WithEvents colTugas As DataGridViewTextBoxColumn
    Friend WithEvents colUTS As DataGridViewTextBoxColumn
    Friend WithEvents colUAS As DataGridViewTextBoxColumn
    Friend WithEvents colNilaiAkhir As DataGridViewTextBoxColumn
    Friend WithEvents colGrade As DataGridViewTextBoxColumn
    Friend WithEvents colStatus As DataGridViewTextBoxColumn
End Class
