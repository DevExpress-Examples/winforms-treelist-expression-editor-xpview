using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Design;
using DevExpress.Data;
using DevExpress.XtraTreeList.Columns;

namespace E1887 {
    public partial class Form1 : XtraForm {
        public Form1() {
            InitializeComponent();
        }

        private void OnShowExpressionEditorClick(object sender, EventArgs e) {
            using (ExpressionEditorForm editor = 
                new ConditionExpressionEditorForm(new TreeListDataColumnInfo(treeList1.Columns), null)) {
                if (editor.ShowDialog() == DialogResult.OK) {
                    using (InputForm input = new InputForm()) {
                        input.ShowDialog();
                        xpView1.AddProperty(input.ColumnName, editor.Expression);
                        treeList1.PopulateColumns();
                    }
                }
            }
        }

        private void OnFormLoad(object sender, EventArgs e) {
            treeList1.DataSource = xpView1;
        }
    }

    public class TreeListDataColumnInfo :IDataColumnInfo {
        private TreeListColumnCollection columns;
        private TreeListColumn column;

        public TreeListDataColumnInfo(TreeListColumnCollection columns) {
            this.columns = columns;
        }

        private TreeListDataColumnInfo(TreeListColumn column) {
            this.column = column;
        }

        #region IDataColumnInfo Members

        public string Caption {
            get {
                if (column == null) return string.Empty;
                return string.IsNullOrEmpty(column.Caption) ? column.FieldName : column.Caption;
            }
        }

        public List<IDataColumnInfo> Columns { get { return GetColumns(); } }

        private List<IDataColumnInfo> GetColumns() {
            if (column != null) return null;
            List<IDataColumnInfo> result = new List<IDataColumnInfo>();
            foreach (TreeListColumn col in columns)
                result.Add(new TreeListDataColumnInfo(col));
            return result;
        }

        public DataControllerBase Controller { get { return null; } }

        public string FieldName { get { return column == null ? string.Empty : column.FieldName; } }

        public Type FieldType { get { return column == null ? null : column.ColumnType; } }

        public string Name { get { return Caption; } }

        public string UnboundExpression { get { return FieldName; } }

        #endregion
    }
}