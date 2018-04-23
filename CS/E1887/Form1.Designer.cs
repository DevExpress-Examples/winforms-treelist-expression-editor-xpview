namespace E1887 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.session1 = new DevExpress.Xpo.Session();
            this.xpView1 = new DevExpress.Xpo.XPView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.session1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeList1
            // 
            this.treeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList1.Location = new System.Drawing.Point(0, 0);
            this.treeList1.Name = "treeList1";
            this.treeList1.Size = new System.Drawing.Size(400, 240);
            this.treeList1.TabIndex = 0;
            // 
            // xpView1
            // 
            this.xpView1.ObjectType = typeof(DXSample.BO.Order);
            this.xpView1.Properties.AddRange(new DevExpress.Xpo.ViewProperty[] {
            new DevExpress.Xpo.ViewProperty("ID", DevExpress.Xpo.SortDirection.None, "[Oid]", false, true),
            new DevExpress.Xpo.ViewProperty("ParentID", DevExpress.Xpo.SortDirection.None, "IsNull([Parent.Oid], -1)", false, true),
            new DevExpress.Xpo.ViewProperty("Name", DevExpress.Xpo.SortDirection.None, "[Name]", false, true),
            new DevExpress.Xpo.ViewProperty("UnitPrice", DevExpress.Xpo.SortDirection.None, "[UnitPrice]", false, true),
            new DevExpress.Xpo.ViewProperty("Quantity", DevExpress.Xpo.SortDirection.None, "[Quantity]", false, true)});
            this.xpView1.Session = this.session1;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 240);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(400, 33);
            this.panelControl1.TabIndex = 1;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(263, 6);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(125, 23);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Show Expression Editor";
            this.simpleButton1.Click += new System.EventHandler(this.OnShowExpressionEditorClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 273);
            this.Controls.Add(this.treeList1);
            this.Controls.Add(this.panelControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.OnFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.session1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.Xpo.Session session1;
        private DevExpress.Xpo.XPView xpView1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;

    }
}

