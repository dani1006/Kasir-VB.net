<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pilihan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pilihan))
        Me.pay = New System.Windows.Forms.Button()
        Me.tmbh = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.metu = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pay
        '
        Me.pay.Font = New System.Drawing.Font("Amaranth", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pay.Image = CType(resources.GetObject("pay.Image"), System.Drawing.Image)
        Me.pay.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.pay.Location = New System.Drawing.Point(64, 333)
        Me.pay.Name = "pay"
        Me.pay.Size = New System.Drawing.Size(76, 38)
        Me.pay.TabIndex = 0
        Me.pay.Text = "Kasir"
        Me.pay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.pay.UseVisualStyleBackColor = True
        '
        'tmbh
        '
        Me.tmbh.Font = New System.Drawing.Font("Amaranth", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tmbh.Image = CType(resources.GetObject("tmbh.Image"), System.Drawing.Image)
        Me.tmbh.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tmbh.Location = New System.Drawing.Point(146, 333)
        Me.tmbh.Name = "tmbh"
        Me.tmbh.Size = New System.Drawing.Size(113, 38)
        Me.tmbh.TabIndex = 1
        Me.tmbh.Text = "Tambah Data"
        Me.tmbh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tmbh.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Font = New System.Drawing.Font("Javanese Text", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(63, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(296, 43)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Selamat Datang  di TOSERBA"
        '
        'metu
        '
        Me.metu.Font = New System.Drawing.Font("Amaranth", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.metu.Image = CType(resources.GetObject("metu.Image"), System.Drawing.Image)
        Me.metu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.metu.Location = New System.Drawing.Point(265, 333)
        Me.metu.Name = "metu"
        Me.metu.Size = New System.Drawing.Size(82, 38)
        Me.metu.TabIndex = 3
        Me.metu.Text = "Log Out"
        Me.metu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.metu.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(114, 112)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(195, 175)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label2.Font = New System.Drawing.Font("Javanese Text", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(138, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(162, 43)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = """BULAK SARI"""
        '
        'pilihan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(412, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.metu)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tmbh)
        Me.Controls.Add(Me.pay)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "pilihan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pay As Button
    Friend WithEvents tmbh As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents metu As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
End Class
