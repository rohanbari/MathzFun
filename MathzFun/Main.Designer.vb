<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
		Me.components = New System.ComponentModel.Container()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Clock = New System.Windows.Forms.Timer(Me.components)
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.Button3 = New System.Windows.Forms.Button()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(222, 72)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(100, 25)
		Me.Button1.TabIndex = 0
		Me.Button1.Text = "Start Test"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'Label1
		'
		Me.Label1.Location = New System.Drawing.Point(12, 9)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(310, 60)
		Me.Label1.TabIndex = 1
		Me.Label1.Text = "Welcome to the MathzFun app! Here you need to give answers either a given number " &
	"is odd or even each time you are asked."
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(12, 77)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(153, 14)
		Me.Label2.TabIndex = 2
		Me.Label2.Text = "Click ""Start"" to get started"
		'
		'Clock
		'
		Me.Clock.Interval = 1000
		'
		'Label3
		'
		Me.Label3.Location = New System.Drawing.Point(15, 100)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(307, 40)
		Me.Label3.TabIndex = 3
		Me.Label3.Text = "A number will appear here"
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Button2
		'
		Me.Button2.Enabled = False
		Me.Button2.Location = New System.Drawing.Point(18, 143)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(146, 25)
		Me.Button2.TabIndex = 4
		Me.Button2.Text = "Even"
		Me.Button2.UseVisualStyleBackColor = True
		'
		'Button3
		'
		Me.Button3.Enabled = False
		Me.Button3.Location = New System.Drawing.Point(170, 143)
		Me.Button3.Name = "Button3"
		Me.Button3.Size = New System.Drawing.Size(152, 25)
		Me.Button3.TabIndex = 5
		Me.Button3.Text = "Odd"
		Me.Button3.UseVisualStyleBackColor = True
		'
		'Label4
		'
		Me.Label4.Location = New System.Drawing.Point(15, 171)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(307, 31)
		Me.Label4.TabIndex = 6
		Me.Label4.Text = "PERSONAL BEST"
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Main
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(334, 211)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Button3)
		Me.Controls.Add(Me.Button2)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.Button1)
		Me.Font = New System.Drawing.Font("Tahoma", 9.0!)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.MaximizeBox = False
		Me.Name = "Main"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "MathzFun"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Button1 As Button
	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Clock As Timer
	Friend WithEvents Label3 As Label
	Friend WithEvents Button2 As Button
	Friend WithEvents Button3 As Button
	Friend WithEvents Label4 As Label
End Class
