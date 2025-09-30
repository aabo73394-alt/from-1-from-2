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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button1.Location = New System.Drawing.Point(245, 180)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 28)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "تنفيذ العمليه"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button2.Location = New System.Drawing.Point(135, 180)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(104, 28)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "الة حاسبه متقدمه"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button3.Location = New System.Drawing.Point(198, 214)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "الخروج"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(195, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 25)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "ادخل العدد الاول"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(136, 67)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(45, 20)
        Me.TextBox1.TabIndex = 10
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(136, 106)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(45, 20)
        Me.TextBox2.TabIndex = 11
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(136, 138)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(45, 20)
        Me.TextBox3.TabIndex = 12
        '
        'RadioButton1
        '
        Me.RadioButton1.BackColor = System.Drawing.SystemColors.Highlight
        Me.RadioButton1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(6, 19)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(106, 36)
        Me.RadioButton1.TabIndex = 3
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "(+)الجمع"
        Me.RadioButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RadioButton1.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(Me.RadioButton4)
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(-1, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(131, 204)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "العمليات الحسابيه"
        '
        'RadioButton2
        '
        Me.RadioButton2.BackColor = System.Drawing.SystemColors.Highlight
        Me.RadioButton2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(6, 61)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(106, 39)
        Me.RadioButton2.TabIndex = 4
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "(-)الطرح"
        Me.RadioButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RadioButton2.UseVisualStyleBackColor = False
        '
        'RadioButton3
        '
        Me.RadioButton3.BackColor = System.Drawing.SystemColors.Highlight
        Me.RadioButton3.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton3.Location = New System.Drawing.Point(6, 106)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(106, 44)
        Me.RadioButton3.TabIndex = 5
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "(*)الضرب"
        Me.RadioButton3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RadioButton3.UseVisualStyleBackColor = False
        '
        'RadioButton4
        '
        Me.RadioButton4.BackColor = System.Drawing.SystemColors.Highlight
        Me.RadioButton4.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton4.Location = New System.Drawing.Point(6, 156)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(106, 42)
        Me.RadioButton4.TabIndex = 6
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "(\)القسمه"
        Me.RadioButton4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RadioButton4.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(195, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 25)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "ادخل العدد الثاني"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(194, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 25)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "النتيجه"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(327, 261)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
