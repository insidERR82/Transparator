<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbValue = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbTransparenz = New System.Windows.Forms.TrackBar()
        Me.tmrAction = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.niIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.lbInfoLink = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.tbTransparenz, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbValue)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.tbTransparenz)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(312, 50)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Transparenz"
        '
        'lbValue
        '
        Me.lbValue.AutoSize = True
        Me.lbValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbValue.Location = New System.Drawing.Point(95, 0)
        Me.lbValue.Name = "lbValue"
        Me.lbValue.Size = New System.Drawing.Size(34, 16)
        Me.lbValue.TabIndex = 3
        Me.lbValue.Text = "50%"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(280, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "1%"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "100%"
        '
        'tbTransparenz
        '
        Me.tbTransparenz.AutoSize = False
        Me.tbTransparenz.Location = New System.Drawing.Point(40, 19)
        Me.tbTransparenz.Maximum = 100
        Me.tbTransparenz.Minimum = 1
        Me.tbTransparenz.Name = "tbTransparenz"
        Me.tbTransparenz.Size = New System.Drawing.Size(245, 27)
        Me.tbTransparenz.TabIndex = 1
        Me.tbTransparenz.TickStyle = System.Windows.Forms.TickStyle.None
        Me.tbTransparenz.Value = 50
        '
        'tmrAction
        '
        Me.tmrAction.Enabled = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 16)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Transparenz"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(17, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(261, 16)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "EIN: {AltGr} + {Entf}  ;  AUS: {AltGr} + {Einfg}"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(17, 137)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(306, 16)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "EIN: {AltGr} + {Bild AUF}  ;  AUS: {AltGr} + {Bild AB}"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(17, 115)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 16)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "OnTop"
        '
        'niIcon
        '
        Me.niIcon.Icon = CType(resources.GetObject("niIcon.Icon"), System.Drawing.Icon)
        Me.niIcon.Text = "Transparator"
        Me.niIcon.Visible = True
        '
        'lbInfoLink
        '
        Me.lbInfoLink.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbInfoLink.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbInfoLink.ForeColor = System.Drawing.Color.Gray
        Me.lbInfoLink.Location = New System.Drawing.Point(200, 161)
        Me.lbInfoLink.Name = "lbInfoLink"
        Me.lbInfoLink.Size = New System.Drawing.Size(128, 13)
        Me.lbInfoLink.TabIndex = 30
        Me.lbInfoLink.Tag = "by Philipp B. (Jan. 2021)"
        Me.lbInfoLink.Text = "by Philipp B. (Jan. 2021)"
        Me.lbInfoLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.lbInfoLink, "Email senden")
        '
        'Label7
        '
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Gray
        Me.Label7.Location = New System.Drawing.Point(17, 161)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(128, 13)
        Me.Label7.TabIndex = 31
        Me.Label7.Tag = ""
        Me.Label7.Text = "(Freeware)"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(341, 183)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lbInfoLink)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transparator 1.0"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.tbTransparenz, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbValue As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tbTransparenz As TrackBar
    Friend WithEvents tmrAction As Timer
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents niIcon As NotifyIcon
    Friend WithEvents lbInfoLink As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Label7 As Label
End Class
