<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128636989/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1887)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# WinForms TreeList - Create calculated columns (Expression Editor and XPView)

In this example, the WinForms TreeList control is bound to a collection of [persistent objects](https://docs.devexpress.com/XPO/DevExpress.Xpo.XPView). The example demonstrates how to add/create view properties ([ViewProperty](https://docs.devexpress.com/XPO/DevExpress.Xpo.ViewProperty)) on the fly using `ConditionExpressionEditorForm` and add coresponding calculated columns:

```csharp
void OnShowExpressionEditorClick(object sender, EventArgs e) {
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
```

* Run the project.
* Click the **Show Expression Editor** button.
* Create an expression (for example, "[Quantity] * [UnitPrice]").
* Click OK.
* Specify the name of a new calculated column (for example, "Total").
* Click OK.


## Files to Review

* [Form1.cs](./CS/E1887/Form1.cs) (VB: [Form1.vb](./VB/E1887/Form1.vb))


## Documentation

* [Expression Editor](https://docs.devexpress.com/WindowsForms/6211/common-features/expressions)


## See Also

* [Bind to XPO Data](https://docs.devexpress.com/WindowsForms/401033/common-features/data-binding/bind-to-XPO-data)
