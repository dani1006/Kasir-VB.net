<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class databarang
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(databarang))
        Me.tambah = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.harga = New System.Windows.Forms.TextBox()
        Me.produk = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.stok = New System.Windows.Forms.TextBox()
        Me.kembali = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tambah
        '
        Me.tambah.Image = CType(resources.GetObject("tambah.Image"), System.Drawing.Image)
        Me.tambah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tambah.Location = New System.Drawing.Point(313, 384)
        Me.tambah.Name = "tambah"
        Me.tambah.Size = New System.Drawing.Size(78, 33)
        Me.tambah.TabIndex = 29
        Me.tambah.Text = "Tambah"
        Me.tambah.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tambah.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bodoni Bd BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label3.Location = New System.Drawing.Point(72, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(303, 22)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "INPUT TOSERBA ""BULAK SARI"""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(179, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Harga"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Barang"
        '
        'harga
        '
        Me.harga.Location = New System.Drawing.Point(224, 85)
        Me.harga.Name = "harga"
        Me.harga.Size = New System.Drawing.Size(73, 20)
        Me.harga.TabIndex = 17
        '
        'produk
        '
        Me.produk.Location = New System.Drawing.Point(58, 85)
        Me.produk.Name = "produk"
        Me.produk.Size = New System.Drawing.Size(112, 20)
        Me.produk.TabIndex = 16
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(36, 141)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(339, 222)
        Me.DataGridView1.TabIndex = 30
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(316, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Stok"
        '
        'stok
        '
        Me.stok.Location = New System.Drawing.Point(351, 85)
        Me.stok.Name = "stok"
        Me.stok.Size = New System.Drawing.Size(40, 20)
        Me.stok.TabIndex = 32
        '
        'kembali
        '
        Me.kembali.Image = CType(resources.GetObject("kembali.Image"), System.Drawing.Image)
        Me.kembali.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.kembali.Location = New System.Drawing.Point(27, 384)
        Me.kembali.Name = "kembali"
        Me.kembali.Size = New System.Drawing.Size(67, 33)
        Me.kembali.TabIndex = 33
        Me.kembali.Text = "Back"
        Me.kembali.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.kembali.UseVisualStyleBackColor = True
        '
        'databarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(412, 450)
        Me.Controls.Add(Me.kembali)
        Me.Controls.Add(Me.stok)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.tambah)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.harga)
        Me.Controls.Add(Me.produk)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "databarang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Input Barang"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tambah As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents harga As TextBox
    Friend WithEvents produk As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents stok As TextBox
    Friend WithEvents kembali As Button
End Class
