Namespace E1887

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.treeList1 = New DevExpress.XtraTreeList.TreeList()
            Me.session1 = New DevExpress.Xpo.Session()
            Me.xpView1 = New DevExpress.Xpo.XPView()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
            CType((Me.treeList1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.session1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.xpView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' treeList1
            ' 
            Me.treeList1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.treeList1.Location = New System.Drawing.Point(0, 0)
            Me.treeList1.Name = "treeList1"
            Me.treeList1.Size = New System.Drawing.Size(400, 240)
            Me.treeList1.TabIndex = 0
            ' 
            ' xpView1
            ' 
            Me.xpView1.ObjectType = GetType(DXSample.BO.Order)
            Me.xpView1.Properties.AddRange(New DevExpress.Xpo.ViewProperty() {New DevExpress.Xpo.ViewProperty("ID", DevExpress.Xpo.SortDirection.None, "[Oid]", False, True), New DevExpress.Xpo.ViewProperty("ParentID", DevExpress.Xpo.SortDirection.None, "IsNull([Parent.Oid], -1)", False, True), New DevExpress.Xpo.ViewProperty("Name", DevExpress.Xpo.SortDirection.None, "[Name]", False, True), New DevExpress.Xpo.ViewProperty("UnitPrice", DevExpress.Xpo.SortDirection.None, "[UnitPrice]", False, True), New DevExpress.Xpo.ViewProperty("Quantity", DevExpress.Xpo.SortDirection.None, "[Quantity]", False, True)})
            Me.xpView1.Session = Me.session1
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.Controls.Add(Me.simpleButton1)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.panelControl1.Location = New System.Drawing.Point(0, 240)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(400, 33)
            Me.panelControl1.TabIndex = 1
            ' 
            ' simpleButton1
            ' 
            Me.simpleButton1.Location = New System.Drawing.Point(263, 6)
            Me.simpleButton1.Name = "simpleButton1"
            Me.simpleButton1.Size = New System.Drawing.Size(125, 23)
            Me.simpleButton1.TabIndex = 0
            Me.simpleButton1.Text = "Show Expression Editor"
            AddHandler Me.simpleButton1.Click, New System.EventHandler(AddressOf Me.OnShowExpressionEditorClick)
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(400, 273)
            Me.Controls.Add(Me.treeList1)
            Me.Controls.Add(Me.panelControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.OnFormLoad)
            CType((Me.treeList1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.session1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.xpView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private treeList1 As DevExpress.XtraTreeList.TreeList

        Private session1 As DevExpress.Xpo.Session

        Private xpView1 As DevExpress.Xpo.XPView

        Private panelControl1 As DevExpress.XtraEditors.PanelControl

        Private simpleButton1 As DevExpress.XtraEditors.SimpleButton
    End Class
End Namespace
