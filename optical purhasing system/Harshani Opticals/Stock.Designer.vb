<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStock
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtItemPrice = New System.Windows.Forms.TextBox()
        Me.txtItemBrand = New System.Windows.Forms.TextBox()
        Me.txtItemQuantity = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnViewAllData = New System.Windows.Forms.Button()
        Me.btnAddStock = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnUpdateDetails = New System.Windows.Forms.Button()
        Me.btnDeleteStock = New System.Windows.Forms.Button()
        Me.cboSelectItem = New System.Windows.Forms.ComboBox()
        Me.cboItemCode = New System.Windows.Forms.ComboBox()
        Me.btnClearData = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(54, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Item Code"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(54, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Item Price"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(54, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Item Brand"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(54, 170)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 17)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Select Item"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(54, 215)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 17)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Item Quantity"
        '
        'txtItemPrice
        '
        Me.txtItemPrice.Location = New System.Drawing.Point(174, 77)
        Me.txtItemPrice.Name = "txtItemPrice"
        Me.txtItemPrice.Size = New System.Drawing.Size(214, 22)
        Me.txtItemPrice.TabIndex = 1
        '
        'txtItemBrand
        '
        Me.txtItemBrand.Location = New System.Drawing.Point(174, 122)
        Me.txtItemBrand.Name = "txtItemBrand"
        Me.txtItemBrand.Size = New System.Drawing.Size(214, 22)
        Me.txtItemBrand.TabIndex = 1
        '
        'txtItemQuantity
        '
        Me.txtItemQuantity.Location = New System.Drawing.Point(174, 212)
        Me.txtItemQuantity.Name = "txtItemQuantity"
        Me.txtItemQuantity.Size = New System.Drawing.Size(214, 22)
        Me.txtItemQuantity.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(424, 35)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 45)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "View Item"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnViewAllData
        '
        Me.btnViewAllData.Location = New System.Drawing.Point(73, 307)
        Me.btnViewAllData.Name = "btnViewAllData"
        Me.btnViewAllData.Size = New System.Drawing.Size(114, 38)
        Me.btnViewAllData.TabIndex = 3
        Me.btnViewAllData.Text = "View All Stocks"
        Me.btnViewAllData.UseVisualStyleBackColor = True
        '
        'btnAddStock
        '
        Me.btnAddStock.Location = New System.Drawing.Point(227, 307)
        Me.btnAddStock.Name = "btnAddStock"
        Me.btnAddStock.Size = New System.Drawing.Size(114, 38)
        Me.btnAddStock.TabIndex = 3
        Me.btnAddStock.Text = "Add Stock"
        Me.btnAddStock.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(393, 369)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(114, 38)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnUpdateDetails
        '
        Me.btnUpdateDetails.Location = New System.Drawing.Point(389, 307)
        Me.btnUpdateDetails.Name = "btnUpdateDetails"
        Me.btnUpdateDetails.Size = New System.Drawing.Size(114, 38)
        Me.btnUpdateDetails.TabIndex = 3
        Me.btnUpdateDetails.Text = "Update Details"
        Me.btnUpdateDetails.UseVisualStyleBackColor = True
        '
        'btnDeleteStock
        '
        Me.btnDeleteStock.Location = New System.Drawing.Point(227, 369)
        Me.btnDeleteStock.Name = "btnDeleteStock"
        Me.btnDeleteStock.Size = New System.Drawing.Size(114, 38)
        Me.btnDeleteStock.TabIndex = 3
        Me.btnDeleteStock.Text = "Delete Stock"
        Me.btnDeleteStock.UseVisualStyleBackColor = True
        '
        'cboSelectItem
        '
        Me.cboSelectItem.FormattingEnabled = True
        Me.cboSelectItem.Items.AddRange(New Object() {"Frame", "Lense"})
        Me.cboSelectItem.Location = New System.Drawing.Point(174, 167)
        Me.cboSelectItem.Name = "cboSelectItem"
        Me.cboSelectItem.Size = New System.Drawing.Size(214, 24)
        Me.cboSelectItem.TabIndex = 4
        '
        'cboItemCode
        '
        Me.cboItemCode.FormattingEnabled = True
        Me.cboItemCode.Location = New System.Drawing.Point(174, 36)
        Me.cboItemCode.Name = "cboItemCode"
        Me.cboItemCode.Size = New System.Drawing.Size(214, 24)
        Me.cboItemCode.TabIndex = 5
        '
        'btnClearData
        '
        Me.btnClearData.Location = New System.Drawing.Point(73, 369)
        Me.btnClearData.Name = "btnClearData"
        Me.btnClearData.Size = New System.Drawing.Size(114, 38)
        Me.btnClearData.TabIndex = 3
        Me.btnClearData.Text = "Clear Data"
        Me.btnClearData.UseVisualStyleBackColor = True
        '
        'frmStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(577, 458)
        Me.Controls.Add(Me.cboItemCode)
        Me.Controls.Add(Me.cboSelectItem)
        Me.Controls.Add(Me.btnDeleteStock)
        Me.Controls.Add(Me.btnUpdateDetails)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnClearData)
        Me.Controls.Add(Me.btnAddStock)
        Me.Controls.Add(Me.btnViewAllData)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtItemQuantity)
        Me.Controls.Add(Me.txtItemBrand)
        Me.Controls.Add(Me.txtItemPrice)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmStock"
        Me.Text = "Stock"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtItemPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtItemBrand As System.Windows.Forms.TextBox
    Friend WithEvents txtItemQuantity As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnViewAllData As System.Windows.Forms.Button
    Friend WithEvents btnAddStock As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnUpdateDetails As System.Windows.Forms.Button
    Friend WithEvents btnDeleteStock As System.Windows.Forms.Button
    Friend WithEvents cboSelectItem As System.Windows.Forms.ComboBox
    Friend WithEvents cboItemCode As System.Windows.Forms.ComboBox
    Friend WithEvents btnClearData As System.Windows.Forms.Button
End Class
