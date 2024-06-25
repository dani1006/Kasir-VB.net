<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class kasir
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(kasir))
        Me.bnyk = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ttlbyr = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dibyr = New System.Windows.Forms.TextBox()
        Me.sisa = New System.Windows.Forms.TextBox()
        Me.baru = New System.Windows.Forms.Button()
        Me.mbalek = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hrg = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.totalsemua = New System.Windows.Forms.Label()
        Me.produk = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bnyk
        '
        Me.bnyk.Location = New System.Drawing.Point(132, 86)
        Me.bnyk.Name = "bnyk"
        Me.bnyk.Size = New System.Drawing.Size(62, 20)
        Me.bnyk.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Barang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(131, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Banyak"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bodoni Bd BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label3.Location = New System.Drawing.Point(71, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(303, 22)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "KASIR TOSERBA ""BULAK SARI"""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(270, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Total"
        '
        'ttlbyr
        '
        Me.ttlbyr.Enabled = False
        Me.ttlbyr.Location = New System.Drawing.Point(262, 86)
        Me.ttlbyr.Name = "ttlbyr"
        Me.ttlbyr.ReadOnly = True
        Me.ttlbyr.Size = New System.Drawing.Size(112, 20)
        Me.ttlbyr.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 329)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Di Bayar"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 359)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Kembali"
        '
        'dibyr
        '
        Me.dibyr.Location = New System.Drawing.Point(82, 326)
        Me.dibyr.Name = "dibyr"
        Me.dibyr.Size = New System.Drawing.Size(112, 20)
        Me.dibyr.TabIndex = 10
        '
        'sisa
        '
        Me.sisa.Enabled = False
        Me.sisa.Location = New System.Drawing.Point(82, 356)
        Me.sisa.Name = "sisa"
        Me.sisa.ReadOnly = True
        Me.sisa.Size = New System.Drawing.Size(112, 20)
        Me.sisa.TabIndex = 11
        '
        'baru
        '
        Me.baru.BackColor = System.Drawing.Color.Azure
        Me.baru.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.baru.Image = CType(resources.GetObject("baru.Image"), System.Drawing.Image)
        Me.baru.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.baru.Location = New System.Drawing.Point(327, 398)
        Me.baru.Name = "baru"
        Me.baru.Size = New System.Drawing.Size(61, 33)
        Me.baru.TabIndex = 13
        Me.baru.Text = "Baru"
        Me.baru.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.baru.UseVisualStyleBackColor = False
        '
        'mbalek
        '
        Me.mbalek.BackColor = System.Drawing.Color.Azure
        Me.mbalek.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.mbalek.Image = CType(resources.GetObject("mbalek.Image"), System.Drawing.Image)
        Me.mbalek.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mbalek.Location = New System.Drawing.Point(27, 397)
        Me.mbalek.Name = "mbalek"
        Me.mbalek.Size = New System.Drawing.Size(67, 34)
        Me.mbalek.TabIndex = 14
        Me.mbalek.Text = "Back"
        Me.mbalek.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.mbalek.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.DataGridView1.Location = New System.Drawing.Point(9, 123)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(394, 181)
        Me.DataGridView1.TabIndex = 18
        '
        'Column1
        '
        Me.Column1.HeaderText = "Barang"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Harga"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Banyak"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 50
        '
        'Column4
        '
        Me.Column4.HeaderText = "Total"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'hrg
        '
        Me.hrg.Enabled = False
        Me.hrg.Location = New System.Drawing.Point(193, 86)
        Me.hrg.Name = "hrg"
        Me.hrg.ReadOnly = True
        Me.hrg.Size = New System.Drawing.Size(73, 20)
        Me.hrg.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(200, 70)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 13)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Harga"
        '
        'totalsemua
        '
        Me.totalsemua.AutoSize = True
        Me.totalsemua.Font = New System.Drawing.Font("Courier New", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalsemua.Location = New System.Drawing.Point(241, 333)
        Me.totalsemua.Name = "totalsemua"
        Me.totalsemua.Size = New System.Drawing.Size(34, 36)
        Me.totalsemua.TabIndex = 21
        Me.totalsemua.Text = "0"
        '
        'produk
        '
        Me.produk.Location = New System.Drawing.Point(11, 86)
        Me.produk.Name = "produk"
        Me.produk.Size = New System.Drawing.Size(122, 20)
        Me.produk.TabIndex = 22
        '
        'kasir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(412, 450)
        Me.Controls.Add(Me.produk)
        Me.Controls.Add(Me.totalsemua)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.hrg)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.mbalek)
        Me.Controls.Add(Me.baru)
        Me.Controls.Add(Me.sisa)
        Me.Controls.Add(Me.dibyr)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ttlbyr)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bnyk)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "kasir"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kasir"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bnyk As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ttlbyr As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents dibyr As TextBox
    Friend WithEvents sisa As TextBox
    Friend WithEvents baru As Button
    Friend WithEvents mbalek As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents hrg As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents totalsemua As Label
    Friend WithEvents produk As TextBox
End Class
