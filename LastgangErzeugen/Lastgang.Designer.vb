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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ButtonNeu = New System.Windows.Forms.Button()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'ButtonNeu
        '
        Me.ButtonNeu.Location = New System.Drawing.Point(112, 353)
        Me.ButtonNeu.Name = "ButtonNeu"
        Me.ButtonNeu.Size = New System.Drawing.Size(75, 23)
        Me.ButtonNeu.TabIndex = 12
        Me.ButtonNeu.Text = "Neu"
        Me.ButtonNeu.UseVisualStyleBackColor = True
        '
        'Chart1
        '
        Me.Chart1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ChartArea1.CursorX.IsUserSelectionEnabled = True
        ChartArea1.CursorY.IsUserSelectionEnabled = True
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Me.Chart1.Location = New System.Drawing.Point(223, 12)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(448, 390)
        Me.Chart1.TabIndex = 13
        Me.Chart1.Text = "Chart1"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"G0 - Gewerbe allgemein", "G1 - Gewerbe werktags 8 - 18", "G2 - Gewerbe Abendstunden", "G3 - Gewerbe Durchlaufend", "G4 - Laden/Friseur", "G5 - Bäckerei mit Backstube", "G6 - Wochenendbetrieb", "L0 - Landwirtschaft allgemein", "L1 - Landwirtschaft Milch", "L2 - Landwirtschaft sonstige"})
        Me.ComboBox1.Location = New System.Drawing.Point(25, 31)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(192, 24)
        Me.ComboBox1.TabIndex = 15
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(87, 382)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(30, 385)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 17)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Summe"
        '
        'Lastgang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(683, 414)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.ButtonNeu)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
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
        Me.Name = "Lastgang"
        Me.Text = "Form6"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents ButtonNeu As Button
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
End Class
