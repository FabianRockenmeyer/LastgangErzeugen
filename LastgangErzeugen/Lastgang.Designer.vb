<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Lastgang
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
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.CheckBoxMoFr = New System.Windows.Forms.CheckBox()
        Me.CheckBoxSa = New System.Windows.Forms.CheckBox()
        Me.CheckBoxSo = New System.Windows.Forms.CheckBox()
        Me.TextBoxLeistung = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxZeitBis = New System.Windows.Forms.TextBox()
        Me.TextBoxZeitVon = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxJahr = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(25, 379)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(157, 23)
        Me.ProgressBar1.TabIndex = 0
        '
        'CheckBoxMoFr
        '
        Me.CheckBoxMoFr.AutoSize = True
        Me.CheckBoxMoFr.Location = New System.Drawing.Point(112, 173)
        Me.CheckBoxMoFr.Name = "CheckBoxMoFr"
        Me.CheckBoxMoFr.Size = New System.Drawing.Size(75, 21)
        Me.CheckBoxMoFr.TabIndex = 5
        Me.CheckBoxMoFr.Text = "Mo - Fr"
        Me.CheckBoxMoFr.UseVisualStyleBackColor = True
        '
        'CheckBoxSa
        '
        Me.CheckBoxSa.AutoSize = True
        Me.CheckBoxSa.Location = New System.Drawing.Point(112, 200)
        Me.CheckBoxSa.Name = "CheckBoxSa"
        Me.CheckBoxSa.Size = New System.Drawing.Size(47, 21)
        Me.CheckBoxSa.TabIndex = 6
        Me.CheckBoxSa.Text = "Sa"
        Me.CheckBoxSa.UseVisualStyleBackColor = True
        '
        'CheckBoxSo
        '
        Me.CheckBoxSo.AutoSize = True
        Me.CheckBoxSo.Location = New System.Drawing.Point(112, 227)
        Me.CheckBoxSo.Name = "CheckBoxSo"
        Me.CheckBoxSo.Size = New System.Drawing.Size(47, 21)
        Me.CheckBoxSo.TabIndex = 7
        Me.CheckBoxSo.Text = "So"
        Me.CheckBoxSo.UseVisualStyleBackColor = True
        '
        'TextBoxLeistung
        '
        Me.TextBoxLeistung.Location = New System.Drawing.Point(112, 145)
        Me.TextBoxLeistung.Name = "TextBoxLeistung"
        Me.TextBoxLeistung.Size = New System.Drawing.Size(70, 22)
        Me.TextBoxLeistung.TabIndex = 4
        Me.TextBoxLeistung.Text = "1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Uhrzeit von:"
        '
        'TextBoxZeitBis
        '
        Me.TextBoxZeitBis.Location = New System.Drawing.Point(112, 117)
        Me.TextBoxZeitBis.Name = "TextBoxZeitBis"
        Me.TextBoxZeitBis.Size = New System.Drawing.Size(70, 22)
        Me.TextBoxZeitBis.TabIndex = 3
        Me.TextBoxZeitBis.Text = "14"
        '
        'TextBoxZeitVon
        '
        Me.TextBoxZeitVon.Location = New System.Drawing.Point(112, 89)
        Me.TextBoxZeitVon.Name = "TextBoxZeitVon"
        Me.TextBoxZeitVon.Size = New System.Drawing.Size(70, 22)
        Me.TextBoxZeitVon.TabIndex = 2
        Me.TextBoxZeitVon.Text = "8"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Uhrzeit bis:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Leistung:"
        '
        'TextBoxJahr
        '
        Me.TextBoxJahr.Location = New System.Drawing.Point(112, 61)
        Me.TextBoxJahr.Name = "TextBoxJahr"
        Me.TextBoxJahr.Size = New System.Drawing.Size(70, 22)
        Me.TextBoxJahr.TabIndex = 1
        Me.TextBoxJahr.Text = "2021"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 17)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Jahr:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(112, 254)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 27)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Eingabe"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(355, 12)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(316, 390)
        Me.RichTextBox1.TabIndex = 11
        Me.RichTextBox1.Text = ""
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(112, 287)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(105, 27)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "GibDatumAus"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(112, 320)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(105, 27)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "GibTagAus"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Lastgang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(683, 414)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBoxJahr)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxZeitVon)
        Me.Controls.Add(Me.TextBoxZeitBis)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxLeistung)
        Me.Controls.Add(Me.CheckBoxSo)
        Me.Controls.Add(Me.CheckBoxSa)
        Me.Controls.Add(Me.CheckBoxMoFr)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Name = "Lastgang"
        Me.Text = "Form6"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents CheckBoxMoFr As CheckBox
    Friend WithEvents CheckBoxSa As CheckBox
    Friend WithEvents CheckBoxSo As CheckBox
    Friend WithEvents TextBoxLeistung As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxZeitBis As TextBox
    Friend WithEvents TextBoxZeitVon As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxJahr As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
