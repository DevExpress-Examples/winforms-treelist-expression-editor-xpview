using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace E1887 {
    public partial class InputForm : DevExpress.XtraEditors.XtraForm {
        public InputForm() {
            InitializeComponent();
        }

        public string ColumnName { get { return textEdit1.Text; } }
    }
}