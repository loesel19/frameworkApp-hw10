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
        Me.UserControl11 = New WindowsControlLibrary1.UserControl1()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.btnGradient = New System.Windows.Forms.Button()
        Me.txtMsg = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'UserControl11
        '
        Me.UserControl11.EndColor = System.Drawing.Color.White
        Me.UserControl11.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.UserControl11.Location = New System.Drawing.Point(1, 1)
        Me.UserControl11.Name = "UserControl11"
        Me.UserControl11.Size = New System.Drawing.Size(800, 450)
        Me.UserControl11.StartColor = System.Drawing.Color.Red
        Me.UserControl11.TabIndex = 0
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(45, 325)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(109, 48)
        Me.btnStart.TabIndex = 1
        Me.btnStart.Text = "Start Color"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnEnd
        '
        Me.btnEnd.Location = New System.Drawing.Point(327, 426)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(109, 48)
        Me.btnEnd.TabIndex = 2
        Me.btnEnd.Text = "End Color"
        Me.btnEnd.UseVisualStyleBackColor = True
        '
        'btnGradient
        '
        Me.btnGradient.Location = New System.Drawing.Point(622, 513)
        Me.btnGradient.Name = "btnGradient"
        Me.btnGradient.Size = New System.Drawing.Size(109, 48)
        Me.btnGradient.TabIndex = 3
        Me.btnGradient.Text = "Gradient"
        Me.btnGradient.UseVisualStyleBackColor = True
        '
        'txtMsg
        '
        Me.txtMsg.Location = New System.Drawing.Point(12, 49)
        Me.txtMsg.Name = "txtMsg"
        Me.txtMsg.Size = New System.Drawing.Size(779, 20)
        Me.txtMsg.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(803, 582)
        Me.Controls.Add(Me.txtMsg)
        Me.Controls.Add(Me.btnGradient)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.UserControl11)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UserControl11 As WindowsControlLibrary1.UserControl1
    Friend WithEvents btnStart As Button
    Friend WithEvents btnEnd As Button
    Friend WithEvents btnGradient As Button
    Friend WithEvents txtMsg As TextBox
End Class
