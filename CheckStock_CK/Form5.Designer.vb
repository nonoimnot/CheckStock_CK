<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form5
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Tb_Add_Group = New System.Windows.Forms.TextBox()
        Me.Bt_Add_GpID = New System.Windows.Forms.Button()
        Me.Dgv_AddGroup = New System.Windows.Forms.DataGridView()
        Me.chk = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.Dgv_AddGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Tb_Add_Group
        '
        Me.Tb_Add_Group.Location = New System.Drawing.Point(12, 24)
        Me.Tb_Add_Group.Name = "Tb_Add_Group"
        Me.Tb_Add_Group.Size = New System.Drawing.Size(370, 22)
        Me.Tb_Add_Group.TabIndex = 0
        Me.Tb_Add_Group.Text = "%"
        '
        'Bt_Add_GpID
        '
        Me.Bt_Add_GpID.Location = New System.Drawing.Point(648, 18)
        Me.Bt_Add_GpID.Name = "Bt_Add_GpID"
        Me.Bt_Add_GpID.Size = New System.Drawing.Size(102, 34)
        Me.Bt_Add_GpID.TabIndex = 1
        Me.Bt_Add_GpID.Text = "Add Group"
        Me.Bt_Add_GpID.UseVisualStyleBackColor = True
        '
        'Dgv_AddGroup
        '
        Me.Dgv_AddGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_AddGroup.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.chk})
        Me.Dgv_AddGroup.EnableHeadersVisualStyles = False
        Me.Dgv_AddGroup.Location = New System.Drawing.Point(13, 69)
        Me.Dgv_AddGroup.Margin = New System.Windows.Forms.Padding(4)
        Me.Dgv_AddGroup.Name = "Dgv_AddGroup"
        Me.Dgv_AddGroup.Size = New System.Drawing.Size(737, 130)
        Me.Dgv_AddGroup.TabIndex = 4
        '
        'chk
        '
        Me.chk.HeaderText = "##"
        Me.chk.Name = "chk"
        Me.chk.Width = 30
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(762, 212)
        Me.Controls.Add(Me.Dgv_AddGroup)
        Me.Controls.Add(Me.Bt_Add_GpID)
        Me.Controls.Add(Me.Tb_Add_Group)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form5"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Item Group"
        CType(Me.Dgv_AddGroup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Tb_Add_Group As TextBox
    Friend WithEvents Bt_Add_GpID As Button
    Friend WithEvents Dgv_AddGroup As DataGridView
    Friend WithEvents chk As DataGridViewCheckBoxColumn
End Class
