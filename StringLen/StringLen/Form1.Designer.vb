<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.txtString = New System.Windows.Forms.TextBox()
        Me.BtnLength = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtString
        '
        Me.txtString.Location = New System.Drawing.Point(147, 182)
        Me.txtString.Multiline = True
        Me.txtString.Name = "txtString"
        Me.txtString.Size = New System.Drawing.Size(377, 71)
        Me.txtString.TabIndex = 0
        '
        'BtnLength
        '
        Me.BtnLength.Location = New System.Drawing.Point(178, 332)
        Me.BtnLength.Name = "BtnLength"
        Me.BtnLength.Size = New System.Drawing.Size(328, 48)
        Me.BtnLength.TabIndex = 1
        Me.BtnLength.Text = "Length"
        Me.BtnLength.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(676, 452)
        Me.Controls.Add(Me.BtnLength)
        Me.Controls.Add(Me.txtString)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtString As TextBox
    Friend WithEvents BtnLength As Button
End Class
