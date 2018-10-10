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
        Me.TbNama = New System.Windows.Forms.TextBox()
        Me.CBbidang = New System.Windows.Forms.ComboBox()
        Me.TBpermintaan = New System.Windows.Forms.TextBox()
        Me.RBtunai = New System.Windows.Forms.RadioButton()
        Me.RBcekbank = New System.Windows.Forms.RadioButton()
        Me.RBgiro = New System.Windows.Forms.RadioButton()
        Me.TBkeperluan = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TBID = New System.Windows.Forms.TextBox()
        Me.BTcancel = New System.Windows.Forms.Button()
        Me.BTsave = New System.Windows.Forms.Button()
        Me.LVpengajuan = New System.Windows.Forms.ListView()
        Me.BTEdit = New System.Windows.Forms.Button()
        Me.BTDelete = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TbNama
        '
        Me.TbNama.Location = New System.Drawing.Point(99, 22)
        Me.TbNama.Name = "TbNama"
        Me.TbNama.Size = New System.Drawing.Size(171, 20)
        Me.TbNama.TabIndex = 0
        '
        'CBbidang
        '
        Me.CBbidang.FormattingEnabled = True
        Me.CBbidang.Items.AddRange(New Object() {"Akademik", "Keuangan", "ICT"})
        Me.CBbidang.Location = New System.Drawing.Point(99, 49)
        Me.CBbidang.Name = "CBbidang"
        Me.CBbidang.Size = New System.Drawing.Size(121, 21)
        Me.CBbidang.TabIndex = 1
        '
        'TBpermintaan
        '
        Me.TBpermintaan.Location = New System.Drawing.Point(99, 76)
        Me.TBpermintaan.Name = "TBpermintaan"
        Me.TBpermintaan.Size = New System.Drawing.Size(171, 20)
        Me.TBpermintaan.TabIndex = 2
        '
        'RBtunai
        '
        Me.RBtunai.AutoSize = True
        Me.RBtunai.Location = New System.Drawing.Point(99, 104)
        Me.RBtunai.Name = "RBtunai"
        Me.RBtunai.Size = New System.Drawing.Size(52, 17)
        Me.RBtunai.TabIndex = 3
        Me.RBtunai.TabStop = True
        Me.RBtunai.Text = "Tunai"
        Me.RBtunai.UseVisualStyleBackColor = True
        '
        'RBcekbank
        '
        Me.RBcekbank.AutoSize = True
        Me.RBcekbank.Location = New System.Drawing.Point(99, 128)
        Me.RBcekbank.Name = "RBcekbank"
        Me.RBcekbank.Size = New System.Drawing.Size(72, 17)
        Me.RBcekbank.TabIndex = 4
        Me.RBcekbank.TabStop = True
        Me.RBcekbank.Text = "Cek Bank"
        Me.RBcekbank.UseVisualStyleBackColor = True
        '
        'RBgiro
        '
        Me.RBgiro.AutoSize = True
        Me.RBgiro.Location = New System.Drawing.Point(99, 152)
        Me.RBgiro.Name = "RBgiro"
        Me.RBgiro.Size = New System.Drawing.Size(44, 17)
        Me.RBgiro.TabIndex = 5
        Me.RBgiro.TabStop = True
        Me.RBgiro.Text = "Giro"
        Me.RBgiro.UseVisualStyleBackColor = True
        '
        'TBkeperluan
        '
        Me.TBkeperluan.Location = New System.Drawing.Point(99, 176)
        Me.TBkeperluan.Multiline = True
        Me.TBkeperluan.Name = "TBkeperluan"
        Me.TBkeperluan.Size = New System.Drawing.Size(171, 100)
        Me.TBkeperluan.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Nama Pelaksana"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Bidang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Jml Permintaan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Bentuk dana"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 176)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Keperluan"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TBID)
        Me.GroupBox1.Controls.Add(Me.BTcancel)
        Me.GroupBox1.Controls.Add(Me.BTsave)
        Me.GroupBox1.Controls.Add(Me.CBbidang)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TbNama)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TBpermintaan)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.RBtunai)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.RBcekbank)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.RBgiro)
        Me.GroupBox1.Controls.Add(Me.TBkeperluan)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(292, 312)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pengajuan"
        '
        'TBID
        '
        Me.TBID.Location = New System.Drawing.Point(8, 128)
        Me.TBID.Name = "TBID"
        Me.TBID.Size = New System.Drawing.Size(32, 20)
        Me.TBID.TabIndex = 14
        '
        'BTcancel
        '
        Me.BTcancel.Location = New System.Drawing.Point(195, 282)
        Me.BTcancel.Name = "BTcancel"
        Me.BTcancel.Size = New System.Drawing.Size(75, 23)
        Me.BTcancel.TabIndex = 13
        Me.BTcancel.Text = "cancel"
        Me.BTcancel.UseVisualStyleBackColor = True
        '
        'BTsave
        '
        Me.BTsave.Location = New System.Drawing.Point(99, 283)
        Me.BTsave.Name = "BTsave"
        Me.BTsave.Size = New System.Drawing.Size(75, 23)
        Me.BTsave.TabIndex = 12
        Me.BTsave.Text = "save"
        Me.BTsave.UseVisualStyleBackColor = True
        '
        'LVpengajuan
        '
        Me.LVpengajuan.Location = New System.Drawing.Point(311, 34)
        Me.LVpengajuan.Name = "LVpengajuan"
        Me.LVpengajuan.Size = New System.Drawing.Size(316, 255)
        Me.LVpengajuan.TabIndex = 13
        Me.LVpengajuan.UseCompatibleStateImageBehavior = False
        '
        'BTEdit
        '
        Me.BTEdit.Location = New System.Drawing.Point(311, 294)
        Me.BTEdit.Name = "BTEdit"
        Me.BTEdit.Size = New System.Drawing.Size(75, 23)
        Me.BTEdit.TabIndex = 14
        Me.BTEdit.Text = "Edit"
        Me.BTEdit.UseVisualStyleBackColor = True
        '
        'BTDelete
        '
        Me.BTDelete.Location = New System.Drawing.Point(552, 295)
        Me.BTDelete.Name = "BTDelete"
        Me.BTDelete.Size = New System.Drawing.Size(75, 23)
        Me.BTDelete.TabIndex = 15
        Me.BTDelete.Text = "Delete"
        Me.BTDelete.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(311, 13)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(316, 20)
        Me.DateTimePicker1.TabIndex = 16
        Me.DateTimePicker1.Value = New Date(2018, 10, 10, 0, 0, 0, 0)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(639, 336)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.BTDelete)
        Me.Controls.Add(Me.BTEdit)
        Me.Controls.Add(Me.LVpengajuan)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TbNama As System.Windows.Forms.TextBox
    Friend WithEvents CBbidang As System.Windows.Forms.ComboBox
    Friend WithEvents TBpermintaan As System.Windows.Forms.TextBox
    Friend WithEvents RBtunai As System.Windows.Forms.RadioButton
    Friend WithEvents RBcekbank As System.Windows.Forms.RadioButton
    Friend WithEvents RBgiro As System.Windows.Forms.RadioButton
    Friend WithEvents TBkeperluan As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BTcancel As System.Windows.Forms.Button
    Friend WithEvents BTsave As System.Windows.Forms.Button
    Friend WithEvents LVpengajuan As System.Windows.Forms.ListView
    Friend WithEvents BTEdit As System.Windows.Forms.Button
    Friend WithEvents BTDelete As System.Windows.Forms.Button
    Friend WithEvents TBID As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker

End Class
