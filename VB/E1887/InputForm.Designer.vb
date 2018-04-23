Imports Microsoft.VisualBasic
Imports System
Namespace E1887
	Partial Public Class InputForm
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			Me.textEdit1 = New DevExpress.XtraEditors.TextEdit()
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			CType(Me.textEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' labelControl1
			' 
			Me.labelControl1.Location = New System.Drawing.Point(12, 16)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New System.Drawing.Size(65, 13)
			Me.labelControl1.TabIndex = 0
			Me.labelControl1.Text = "Column Name"
			' 
			' textEdit1
			' 
			Me.textEdit1.Location = New System.Drawing.Point(83, 12)
			Me.textEdit1.Name = "textEdit1"
			Me.textEdit1.Size = New System.Drawing.Size(206, 22)
			Me.textEdit1.TabIndex = 1
			' 
			' simpleButton1
			' 
			Me.simpleButton1.DialogResult = System.Windows.Forms.DialogResult.OK
			Me.simpleButton1.Location = New System.Drawing.Point(205, 40)
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.Size = New System.Drawing.Size(75, 23)
			Me.simpleButton1.TabIndex = 2
			Me.simpleButton1.Text = "OK"
			' 
			' InputForm
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(292, 69)
			Me.Controls.Add(Me.simpleButton1)
			Me.Controls.Add(Me.textEdit1)
			Me.Controls.Add(Me.labelControl1)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "InputForm"
			Me.Text = "InputForm"
			CType(Me.textEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private labelControl1 As DevExpress.XtraEditors.LabelControl
		Private textEdit1 As DevExpress.XtraEditors.TextEdit
		Private simpleButton1 As DevExpress.XtraEditors.SimpleButton
	End Class
End Namespace