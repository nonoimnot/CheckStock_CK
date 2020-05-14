<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.tb_Itemdesc = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bt_in_part_F2 = New System.Windows.Forms.Button()
        Me.tb_Qty = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tb_ItemNo = New System.Windows.Forms.TextBox()
        Me.cb_vender = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tb_Itemdesc
        '
        Me.tb_Itemdesc.Location = New System.Drawing.Point(12, 47)
        Me.tb_Itemdesc.Name = "tb_Itemdesc"
        Me.tb_Itemdesc.Size = New System.Drawing.Size(332, 20)
        Me.tb_Itemdesc.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "รายการสินค้า"
        '
        'bt_in_part_F2
        '
        Me.bt_in_part_F2.Location = New System.Drawing.Point(350, 21)
        Me.bt_in_part_F2.Name = "bt_in_part_F2"
        Me.bt_in_part_F2.Size = New System.Drawing.Size(56, 46)
        Me.bt_in_part_F2.TabIndex = 2
        Me.bt_in_part_F2.Text = "Insert"
        Me.bt_in_part_F2.UseVisualStyleBackColor = True
        '
        'tb_Qty
        '
        Me.tb_Qty.Location = New System.Drawing.Point(297, 24)
        Me.tb_Qty.Name = "tb_Qty"
        Me.tb_Qty.Size = New System.Drawing.Size(44, 20)
        Me.tb_Qty.TabIndex = 3
        Me.tb_Qty.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(303, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Qty"
        '
        'tb_ItemNo
        '
        Me.tb_ItemNo.Enabled = False
        Me.tb_ItemNo.Location = New System.Drawing.Point(12, 23)
        Me.tb_ItemNo.Name = "tb_ItemNo"
        Me.tb_ItemNo.Size = New System.Drawing.Size(100, 20)
        Me.tb_ItemNo.TabIndex = 5
        '
        'cb_vender
        '
        Me.cb_vender.FormattingEnabled = True
        Me.cb_vender.Location = New System.Drawing.Point(119, 23)
        Me.cb_vender.Name = "cb_vender"
        Me.cb_vender.Size = New System.Drawing.Size(87, 21)
        Me.cb_vender.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(358, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "[ F12 ]"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 91)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cb_vender)
        Me.Controls.Add(Me.tb_ItemNo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tb_Qty)
        Me.Controls.Add(Me.bt_in_part_F2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tb_Itemdesc)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Insert Form"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tb_Itemdesc As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents bt_in_part_F2 As Button
    Friend WithEvents tb_Qty As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tb_ItemNo As TextBox
    Friend WithEvents cb_vender As ComboBox
    Friend WithEvents Label3 As Label
End Class
