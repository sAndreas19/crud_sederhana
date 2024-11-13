Imports MySql.Data.MySqlClient
Imports Mysqlx.Crud
Public Class Form1

    Sub tampilkanData()
        'Buka Koneksi Database'
        Konek()

        da = New MySqlDataAdapter("SELECT * FROM penjualan", Koneksi)
        dt = New DataTable
        da.Fill(dt)
        DGV.Rows.Clear()
        For i = 0 To dt.Rows.Count - 1
            DGV.Rows.Add(dt.Rows(i).Item(0))
            DGV.Rows(i).Cells(1).Value = dt.Rows(i).Item(1)
            DGV.Rows(i).Cells(2).Value = dt.Rows(i).Item(2)
            DGV.Rows(i).Cells(3).Value = dt.Rows(i).Item(3)
            DGV.Rows(i).Cells(4).Value = dt.Rows(i).Item(4)
            DGV.Rows(i).Cells(5).Value = dt.Rows(i).Item(5)
            DGV.Rows(i).Cells(6).Value = dt.Rows(i).Item(6)
        Next

        'Tutup Koneksi Database'
        Diskonek()

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Panggil sub tampilkanData'
        tampilkanData()
    End Sub

    Private Sub btn_keluar_Click(sender As Object, e As EventArgs) Handles btn_keluar.Click
        Me.Close()
    End Sub

    Private Sub btn_bersihkan_Click(sender As Object, e As EventArgs) Handles btn_bersihkan.Click
        textbox_kode_brg.Text = ""
        textbox_nama_brg.Text = ""
        cmb_jumlah_brg.Text = ""
        textbox_harga.Text = ""
        textbox_expired.Text = ""
        radio_buah.Checked = False
        radio_sayur.Checked = False
        textbox_tujuan.Text = ""
        textbox_kode_brg.Focus()

    End Sub

    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click

        Dim jenis As String
        If radio_buah.Checked = True Then
            jenis = "Buah"
        ElseIf radio_sayur.Checked = True Then
            jenis = "Sayur"
        End If

        'Jika ketemu edit data, kalau tidak simpan baru'
        If ketemu = True Then
            'ubah data'
            Try
                Konek()
                cmd = New MySqlCommand("UPDATE penjualan SET nama_barang = '" & textbox_nama_brg.Text & "', jumlah_barang = '" & cmb_jumlah_brg.Text & "', harga = '" & textbox_harga.Text & "', expired = '" & textbox_expired.Text & "', jenis = '" & jenis & "', tujuan = '" & textbox_tujuan.Text & "' ", Koneksi)

                cmd.ExecuteNonQuery()
                MsgBox("Ubah Data Sukses!!")
                Diskonek()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            'simpan baru'
            Try
                Konek()
                cmd = New MySqlCommand("Insert INTO penjualan (kode_barang, nama_barang, jumlah_barang, harga, expired, jenis, tujuan) VALUES ('" & textbox_kode_brg.Text & "','" & textbox_nama_brg.Text & "', '" & cmb_jumlah_brg.Text & "', '" & textbox_harga.Text & "', '" & textbox_expired.Text & "', '" & jenis & "', '" & textbox_tujuan.Text & "')", Koneksi)

                cmd.ExecuteNonQuery()
                MsgBox("Simpan Data Sukses!!")
                Diskonek()
                tampilkanData()
                btn_bersihkan_Click(sender, e)

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

        tampilkanData()
        btn_bersihkan_Click(sender, e)
    End Sub

    Private Sub textbox_kode_brg_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textbox_kode_brg.KeyPress

        If e.KeyChar = Chr(13) Then
            Konek()

            cmd = New MySqlCommand("SELECT * FROM penjualan WHERE kode_barang = '" & textbox_kode_brg.Text & "' ", Koneksi)

            Dim jenis As String
            'Dim jumlah_barang As String'

            dr = cmd.ExecuteReader
            If dr.Read Then
                textbox_kode_brg.Text = dr.Item(0)
                textbox_nama_brg.Text = dr.Item(1)
                cmb_jumlah_brg.Text = dr.Item(2)
                textbox_harga.Text = dr.Item(3)
                textbox_expired.Text = dr.Item(4)
                jenis = dr.Item(5)
                If radio_buah.Checked = True Then
                    jenis = "Buah"
                ElseIf radio_sayur.Checked = True Then
                    jenis = "Sayur"
                End If
                textbox_tujuan.Text = dr.Item(6)
                MsgBox("Data Ditemukan!")
                ketemu = True

            Else
                MsgBox("Data Tidak Ditemukan!")
                'btn_bersihkan_Click(sender, e)'
                textbox_kode_brg.Focus()
                ketemu = False
            End If


            Diskonek()
        End If
    End Sub

    Private Sub btn_hapus_Click(sender As Object, e As EventArgs) Handles btn_hapus.Click
        If ketemu = True Then
            Try
                Konek()

                If MessageBox.Show("Apakah Anda Yakin Akan Menghapus Data Ini?", "Konfirmasi", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then

                    cmd = New MySqlCommand("DELETE FROM penjualan WHERE kode_barang = '" & textbox_kode_brg.Text & "' ", Koneksi)

                    cmd.ExecuteNonQuery()
                    MsgBox("Hapus Data Sukses")
                    tampilkanData()
                    btn_bersihkan_Click(sender, e)

                End If
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class
