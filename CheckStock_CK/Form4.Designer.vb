<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Tb_ItemCode = New System.Windows.Forms.TextBox()
        Me.Tb_ItemDesc = New System.Windows.Forms.TextBox()
        Me.Tb_GroupID = New System.Windows.Forms.TextBox()
        Me.Dgv_ItemGroup = New System.Windows.Forms.DataGridView()
        Me.chk = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Lb_GroupID = New System.Windows.Forms.Label()
        Me.Bt_Add_Group = New System.Windows.Forms.Button()
        Me.Bt_Del_Group = New System.Windows.Forms.Button()
        CType(Me.Dgv_ItemGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Tb_ItemCode
        '
        Me.Tb_ItemCode.Location = New System.Drawing.Point(16, 15)
        Me.Tb_ItemCode.Margin = New System.Windows.Forms.Padding(4)
        Me.Tb_ItemCode.Name = "Tb_ItemCode"
        Me.Tb_ItemCode.ReadOnly = True
        Me.Tb_ItemCode.Size = New System.Drawing.Size(132, 22)
        Me.Tb_ItemCode.TabIndex = 0
        '
        'Tb_ItemDesc
        '
        Me.Tb_ItemDesc.Location = New System.Drawing.Point(16, 47)
        Me.Tb_ItemDesc.Margin = New System.Windows.Forms.Padding(4)
        Me.Tb_ItemDesc.Name = "Tb_ItemDesc"
        Me.Tb_ItemDesc.ReadOnly = True
        Me.Tb_ItemDesc.Size = New System.Drawing.Size(448, 22)
        Me.Tb_ItemDesc.TabIndex = 1
        '
        'Tb_GroupID
        '
        Me.Tb_GroupID.Location = New System.Drawing.Point(344, 15)
        Me.Tb_GroupID.Margin = New System.Windows.Forms.Padding(4)
        Me.Tb_GroupID.Name = "Tb_GroupID"
        Me.Tb_GroupID.ReadOnly = True
        Me.Tb_GroupID.Size = New System.Drawing.Size(120, 22)
        Me.Tb_GroupID.TabIndex = 2
        '
        'Dgv_ItemGroup
        '
        Me.Dgv_ItemGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_ItemGroup.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.chk})
        Me.Dgv_ItemGroup.EnableHeadersVisualStyles = False
        Me.Dgv_ItemGroup.Location = New System.Drawing.Point(16, 91)
        Me.Dgv_ItemGroup.Margin = New System.Windows.Forms.Padding(4)
        Me.Dgv_ItemGroup.Name = "Dgv_ItemGroup"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv_ItemGroup.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.Dgv_ItemGroup.Size = New System.Drawing.Size(737, 130)
        Me.Dgv_ItemGroup.TabIndex = 3
        '
        'chk
        '
        Me.chk.HeaderText = "##"
        Me.chk.Name = "chk"
        Me.chk.Width = 30
        '
        'Lb_GroupID
        '
        Me.Lb_GroupID.AutoSize = True
        Me.Lb_GroupID.Location = New System.Drawing.Point(268, 18)
        Me.Lb_GroupID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lb_GroupID.Name = "Lb_GroupID"
        Me.Lb_GroupID.Size = New System.Drawing.Size(68, 17)
        Me.Lb_GroupID.TabIndex = 4
        Me.Lb_GroupID.Text = "Group >>"
        '
        'Bt_Add_Group
        '
        Me.Bt_Add_Group.Location = New System.Drawing.Point(653, 12)
        Me.Bt_Add_Group.Margin = New System.Windows.Forms.Padding(4)
        Me.Bt_Add_Group.Name = "Bt_Add_Group"
        Me.Bt_Add_Group.Size = New System.Drawing.Size(100, 28)
        Me.Bt_Add_Group.TabIndex = 5
        Me.Bt_Add_Group.Text = "Add Group"
        Me.Bt_Add_Group.UseVisualStyleBackColor = True
        '
        'Bt_Del_Group
        '
        Me.Bt_Del_Group.Location = New System.Drawing.Point(653, 47)
        Me.Bt_Del_Group.Margin = New System.Windows.Forms.Padding(4)
        Me.Bt_Del_Group.Name = "Bt_Del_Group"
        Me.Bt_Del_Group.Size = New System.Drawing.Size(100, 28)
        Me.Bt_Del_Group.TabIndex = 6
        Me.Bt_Del_Group.Text = "Del Group"
        Me.Bt_Del_Group.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(772, 241)
        Me.Controls.Add(Me.Bt_Del_Group)
        Me.Controls.Add(Me.Bt_Add_Group)
        Me.Controls.Add(Me.Lb_GroupID)
        Me.Controls.Add(Me.Dgv_ItemGroup)
        Me.Controls.Add(Me.Tb_GroupID)
        Me.Controls.Add(Me.Tb_ItemDesc)
        Me.Controls.Add(Me.Tb_ItemCode)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Location = New System.Drawing.Point(800, 150)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Manget Item Group"
        CType(Me.Dgv_ItemGroup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Tb_ItemCode As TextBox
    Friend WithEvents Tb_ItemDesc As TextBox
    Friend WithEvents Tb_GroupID As TextBox
    Friend WithEvents Dgv_ItemGroup As DataGridView
    Friend WithEvents Lb_GroupID As Label
    Friend WithEvents Bt_Add_Group As Button
    Friend WithEvents Bt_Del_Group As Button
    Friend WithEvents chk As DataGridViewCheckBoxColumn
End Class
