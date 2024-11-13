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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.textbox_kode_brg = New System.Windows.Forms.TextBox()
        Me.textbox_nama_brg = New System.Windows.Forms.TextBox()
        Me.textbox_harga = New System.Windows.Forms.TextBox()
        Me.textbox_expired = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.textbox_tujuan = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.radio_buah = New System.Windows.Forms.RadioButton()
        Me.radio_sayur = New System.Windows.Forms.RadioButton()
        Me.btn_bersihkan = New System.Windows.Forms.Button()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.btn_hapus = New System.Windows.Forms.Button()
        Me.btn_keluar = New System.Windows.Forms.Button()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.cmb_jumlah_brg = New System.Windows.Forms.ComboBox()
        Me.kode_barang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama_barang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jumlah_barang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.harga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.expired = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jenis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tujuan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(418, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(228, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "STARTING ARGENTINA 2018"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(59, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nomor Punggung"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(59, 157)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama      :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(59, 199)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Posisi   :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(59, 242)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Umur"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(59, 285)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(128, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Kelas Permainan"
        '
        'textbox_kode_brg
        '
        Me.textbox_kode_brg.Location = New System.Drawing.Point(198, 115)
        Me.textbox_kode_brg.Name = "textbox_kode_brg"
        Me.textbox_kode_brg.Size = New System.Drawing.Size(254, 26)
        Me.textbox_kode_brg.TabIndex = 6
        '
        'textbox_nama_brg
        '
        Me.textbox_nama_brg.Location = New System.Drawing.Point(198, 154)
        Me.textbox_nama_brg.Name = "textbox_nama_brg"
        Me.textbox_nama_brg.Size = New System.Drawing.Size(254, 26)
        Me.textbox_nama_brg.TabIndex = 7
        '
        'textbox_harga
        '
        Me.textbox_harga.Location = New System.Drawing.Point(198, 242)
        Me.textbox_harga.Name = "textbox_harga"
        Me.textbox_harga.Size = New System.Drawing.Size(254, 26)
        Me.textbox_harga.TabIndex = 9
        '
        'textbox_expired
        '
        Me.textbox_expired.Location = New System.Drawing.Point(198, 282)
        Me.textbox_expired.Name = "textbox_expired"
        Me.textbox_expired.Size = New System.Drawing.Size(254, 26)
        Me.textbox_expired.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(60, 387)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 20)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Pola Permainan"
        '
        'textbox_tujuan
        '
        Me.textbox_tujuan.Location = New System.Drawing.Point(198, 387)
        Me.textbox_tujuan.Multiline = True
        Me.textbox_tujuan.Name = "textbox_tujuan"
        Me.textbox_tujuan.Size = New System.Drawing.Size(254, 87)
        Me.textbox_tujuan.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(59, 330)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(136, 20)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Status                   :"
        '
        'radio_buah
        '
        Me.radio_buah.AutoSize = True
        Me.radio_buah.Location = New System.Drawing.Point(202, 330)
        Me.radio_buah.Name = "radio_buah"
        Me.radio_buah.Size = New System.Drawing.Size(94, 24)
        Me.radio_buah.TabIndex = 14
        Me.radio_buah.TabStop = True
        Me.radio_buah.Text = "Menikah"
        Me.radio_buah.UseVisualStyleBackColor = True
        '
        'radio_sayur
        '
        Me.radio_sayur.AutoSize = True
        Me.radio_sayur.Location = New System.Drawing.Point(325, 330)
        Me.radio_sayur.Name = "radio_sayur"
        Me.radio_sayur.Size = New System.Drawing.Size(143, 24)
        Me.radio_sayur.TabIndex = 15
        Me.radio_sayur.TabStop = True
        Me.radio_sayur.Text = "Belum Menikah"
        Me.radio_sayur.UseVisualStyleBackColor = True
        '
        'btn_bersihkan
        '
        Me.btn_bersihkan.Location = New System.Drawing.Point(66, 508)
        Me.btn_bersihkan.Name = "btn_bersihkan"
        Me.btn_bersihkan.Size = New System.Drawing.Size(107, 36)
        Me.btn_bersihkan.TabIndex = 16
        Me.btn_bersihkan.Text = "Bersihkan"
        Me.btn_bersihkan.UseVisualStyleBackColor = True
        '
        'btn_simpan
        '
        Me.btn_simpan.Location = New System.Drawing.Point(214, 508)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(107, 36)
        Me.btn_simpan.TabIndex = 17
        Me.btn_simpan.Text = "Simpan"
        Me.btn_simpan.UseVisualStyleBackColor = True
        '
        'btn_hapus
        '
        Me.btn_hapus.Location = New System.Drawing.Point(361, 508)
        Me.btn_hapus.Name = "btn_hapus"
        Me.btn_hapus.Size = New System.Drawing.Size(107, 36)
        Me.btn_hapus.TabIndex = 18
        Me.btn_hapus.Text = "Hapus"
        Me.btn_hapus.UseVisualStyleBackColor = True
        '
        'btn_keluar
        '
        Me.btn_keluar.Location = New System.Drawing.Point(507, 508)
        Me.btn_keluar.Name = "btn_keluar"
        Me.btn_keluar.Size = New System.Drawing.Size(107, 36)
        Me.btn_keluar.TabIndex = 19
        Me.btn_keluar.Text = "Keluar"
        Me.btn_keluar.UseVisualStyleBackColor = True
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.kode_barang, Me.nama_barang, Me.jumlah_barang, Me.harga, Me.expired, Me.jenis, Me.tujuan})
        Me.DGV.Location = New System.Drawing.Point(2, 581)
        Me.DGV.Name = "DGV"
        Me.DGV.RowHeadersWidth = 62
        Me.DGV.RowTemplate.Height = 28
        Me.DGV.Size = New System.Drawing.Size(941, 242)
        Me.DGV.TabIndex = 20
        '
        'cmb_jumlah_brg
        '
        Me.cmb_jumlah_brg.FormattingEnabled = True
        Me.cmb_jumlah_brg.Items.AddRange(New Object() {"Striker", "Center", "Defender", "Goalkeeper"})
        Me.cmb_jumlah_brg.Location = New System.Drawing.Point(199, 197)
        Me.cmb_jumlah_brg.Name = "cmb_jumlah_brg"
        Me.cmb_jumlah_brg.Size = New System.Drawing.Size(251, 28)
        Me.cmb_jumlah_brg.TabIndex = 21
        '
        'kode_barang
        '
        Me.kode_barang.HeaderText = "Nomor Panggung"
        Me.kode_barang.MinimumWidth = 8
        Me.kode_barang.Name = "kode_barang"
        Me.kode_barang.Width = 150
        '
        'nama_barang
        '
        Me.nama_barang.HeaderText = "Nama"
        Me.nama_barang.MinimumWidth = 8
        Me.nama_barang.Name = "nama_barang"
        Me.nama_barang.Width = 120
        '
        'jumlah_barang
        '
        Me.jumlah_barang.HeaderText = "Posisi"
        Me.jumlah_barang.MinimumWidth = 8
        Me.jumlah_barang.Name = "jumlah_barang"
        Me.jumlah_barang.Width = 150
        '
        'harga
        '
        Me.harga.HeaderText = "Umur"
        Me.harga.MinimumWidth = 8
        Me.harga.Name = "harga"
        Me.harga.Width = 150
        '
        'expired
        '
        Me.expired.HeaderText = "Kelas Permainan"
        Me.expired.MinimumWidth = 8
        Me.expired.Name = "expired"
        Me.expired.Width = 150
        '
        'jenis
        '
        Me.jenis.HeaderText = "Status"
        Me.jenis.MinimumWidth = 8
        Me.jenis.Name = "jenis"
        Me.jenis.Width = 150
        '
        'tujuan
        '
        Me.tujuan.HeaderText = "Pola Permainan"
        Me.tujuan.MinimumWidth = 8
        Me.tujuan.Name = "tujuan"
        Me.tujuan.Width = 250
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1119, 905)
        Me.Controls.Add(Me.cmb_jumlah_brg)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.btn_keluar)
        Me.Controls.Add(Me.btn_hapus)
        Me.Controls.Add(Me.btn_simpan)
        Me.Controls.Add(Me.btn_bersihkan)
        Me.Controls.Add(Me.radio_sayur)
        Me.Controls.Add(Me.radio_buah)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.textbox_tujuan)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.textbox_expired)
        Me.Controls.Add(Me.textbox_harga)
        Me.Controls.Add(Me.textbox_nama_brg)
        Me.Controls.Add(Me.textbox_kode_brg)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents textbox_kode_brg As TextBox
    Friend WithEvents textbox_nama_brg As TextBox
    Friend WithEvents textbox_harga As TextBox
    Friend WithEvents textbox_expired As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents textbox_tujuan As TextBox
    Private WithEvents Label8 As Label
    Friend WithEvents radio_buah As RadioButton
    Friend WithEvents radio_sayur As RadioButton
    Friend WithEvents btn_bersihkan As Button
    Friend WithEvents btn_simpan As Button
    Friend WithEvents btn_hapus As Button
    Friend WithEvents btn_keluar As Button
    Friend WithEvents DGV As DataGridView
    Friend WithEvents cmb_jumlah_brg As ComboBox
    Friend WithEvents kode_barang As DataGridViewTextBoxColumn
    Friend WithEvents nama_barang As DataGridViewTextBoxColumn
    Friend WithEvents jumlah_barang As DataGridViewTextBoxColumn
    Friend WithEvents harga As DataGridViewTextBoxColumn
    Friend WithEvents expired As DataGridViewTextBoxColumn
    Friend WithEvents jenis As DataGridViewTextBoxColumn
    Friend WithEvents tujuan As DataGridViewTextBoxColumn
End Class
