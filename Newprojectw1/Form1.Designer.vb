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
        btnButton = New Button()
        askAge = New Button()
        anotherWay = New Button()
        SuspendLayout()
        ' 
        ' btnButton
        ' 
        btnButton.Location = New Point(334, 110)
        btnButton.Name = "btnButton"
        btnButton.Size = New Size(125, 73)
        btnButton.TabIndex = 0
        btnButton.Text = "Say Hi"
        btnButton.UseVisualStyleBackColor = True
        ' 
        ' askAge
        ' 
        askAge.Location = New Point(334, 247)
        askAge.Name = "askAge"
        askAge.Size = New Size(125, 34)
        askAge.TabIndex = 1
        askAge.Text = "Age"
        askAge.UseVisualStyleBackColor = True
        ' 
        ' anotherWay
        ' 
        anotherWay.Location = New Point(334, 312)
        anotherWay.Name = "anotherWay"
        anotherWay.Size = New Size(125, 34)
        anotherWay.TabIndex = 2
        anotherWay.Text = "Another Way"
        anotherWay.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(886, 444)
        Controls.Add(anotherWay)
        Controls.Add(askAge)
        Controls.Add(btnButton)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnButton As Button
    Friend WithEvents askAge As Button
    Friend WithEvents anotherWay As Button
End Class
