﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StatusAbsensi
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DPTanggal = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RdnAbsenMasuk = New System.Windows.Forms.RadioButton()
        Me.RdnAbsenKeluar = New System.Windows.Forms.RadioButton()
        Me.BtnAbsen = New System.Windows.Forms.Button()
        Me.CBNamaPegawai = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.DPTanggal)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.BtnAbsen)
        Me.Panel1.Controls.Add(Me.CBNamaPegawai)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(26, 62)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(402, 309)
        Me.Panel1.TabIndex = 5
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePicker1.Location = New System.Drawing.Point(235, 95)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(143, 23)
        Me.DateTimePicker1.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(281, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 15)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Waktu"
        '
        'DPTanggal
        '
        Me.DPTanggal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DPTanggal.Location = New System.Drawing.Point(25, 95)
        Me.DPTanggal.Name = "DPTanggal"
        Me.DPTanggal.Size = New System.Drawing.Size(153, 23)
        Me.DPTanggal.TabIndex = 12
        Me.DPTanggal.Value = New Date(2022, 12, 29, 0, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(73, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 15)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Tanggal"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RdnAbsenMasuk)
        Me.GroupBox1.Controls.Add(Me.RdnAbsenKeluar)
        Me.GroupBox1.Location = New System.Drawing.Point(98, 145)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 67)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Jenis Absensi"
        '
        'RdnAbsenMasuk
        '
        Me.RdnAbsenMasuk.AutoSize = True
        Me.RdnAbsenMasuk.Location = New System.Drawing.Point(57, 22)
        Me.RdnAbsenMasuk.Name = "RdnAbsenMasuk"
        Me.RdnAbsenMasuk.Size = New System.Drawing.Size(96, 19)
        Me.RdnAbsenMasuk.TabIndex = 8
        Me.RdnAbsenMasuk.TabStop = True
        Me.RdnAbsenMasuk.Text = "Absen Masuk"
        Me.RdnAbsenMasuk.UseVisualStyleBackColor = True
        '
        'RdnAbsenKeluar
        '
        Me.RdnAbsenKeluar.AutoSize = True
        Me.RdnAbsenKeluar.Location = New System.Drawing.Point(57, 42)
        Me.RdnAbsenKeluar.Name = "RdnAbsenKeluar"
        Me.RdnAbsenKeluar.Size = New System.Drawing.Size(94, 19)
        Me.RdnAbsenKeluar.TabIndex = 9
        Me.RdnAbsenKeluar.TabStop = True
        Me.RdnAbsenKeluar.Text = "Absen Keluar"
        Me.RdnAbsenKeluar.UseVisualStyleBackColor = True
        '
        'BtnAbsen
        '
        Me.BtnAbsen.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnAbsen.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnAbsen.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnAbsen.Location = New System.Drawing.Point(98, 246)
        Me.BtnAbsen.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnAbsen.Name = "BtnAbsen"
        Me.BtnAbsen.Size = New System.Drawing.Size(200, 34)
        Me.BtnAbsen.TabIndex = 7
        Me.BtnAbsen.Text = "Absen"
        Me.BtnAbsen.UseVisualStyleBackColor = False
        '
        'CBNamaPegawai
        '
        Me.CBNamaPegawai.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.CBNamaPegawai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBNamaPegawai.FormattingEnabled = True
        Me.CBNamaPegawai.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.CBNamaPegawai.Location = New System.Drawing.Point(98, 36)
        Me.CBNamaPegawai.Name = "CBNamaPegawai"
        Me.CBNamaPegawai.Size = New System.Drawing.Size(200, 23)
        Me.CBNamaPegawai.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(146, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Nama Pegawai"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Font = New System.Drawing.Font("Myanmar Text", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(26, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(402, 30)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "# Edit Absensi"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'StatusAbsensi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(456, 383)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "StatusAbsensi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StatusAbsensi"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents DPTanggal As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RdnAbsenMasuk As RadioButton
    Friend WithEvents RdnAbsenKeluar As RadioButton
    Friend WithEvents BtnAbsen As Button
    Friend WithEvents CBNamaPegawai As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label4 As Label
End Class