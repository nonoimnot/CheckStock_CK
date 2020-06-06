<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Dgv_CheckStock = New System.Windows.Forms.DataGridView()
        Me.chk = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.cobo_vender = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.tb_search = New System.Windows.Forms.TextBox()
        Me.Lb_fillter = New System.Windows.Forms.Label()
        Me.Bt_Fillter = New System.Windows.Forms.Button()
        Me.Nd_Offset = New System.Windows.Forms.NumericUpDown()
        Me.Lb_Offset = New System.Windows.Forms.Label()
        Me.Lb_Row_CS = New System.Windows.Forms.Label()
        Me.Cb_Vender = New System.Windows.Forms.ComboBox()
        Me.Bt_to_Pre = New System.Windows.Forms.Button()
        Me.Cb_Mode = New System.Windows.Forms.ComboBox()
        Me.Lb_Mode = New System.Windows.Forms.Label()
        Me.Dgv_CheckStock1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.cb_dgv_vender1 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Lb_Row_Cs1 = New System.Windows.Forms.Label()
        Me.Bt_ChangeMode = New System.Windows.Forms.Button()
        CType(Me.Dgv_CheckStock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Nd_Offset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dgv_CheckStock1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Dgv_CheckStock
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv_CheckStock.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Dgv_CheckStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_CheckStock.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.chk, Me.cobo_vender})
        Me.Dgv_CheckStock.EnableHeadersVisualStyles = False
        Me.Dgv_CheckStock.Location = New System.Drawing.Point(15, 105)
        Me.Dgv_CheckStock.Margin = New System.Windows.Forms.Padding(4)
        Me.Dgv_CheckStock.MultiSelect = False
        Me.Dgv_CheckStock.Name = "Dgv_CheckStock"
        Me.Dgv_CheckStock.RowHeadersWidth = 51
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Dgv_CheckStock.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.Dgv_CheckStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dgv_CheckStock.Size = New System.Drawing.Size(1328, 416)
        Me.Dgv_CheckStock.TabIndex = 0
        '
        'chk
        '
        Me.chk.HeaderText = "##"
        Me.chk.MinimumWidth = 6
        Me.chk.Name = "chk"
        Me.chk.Width = 125
        '
        'cobo_vender
        '
        Me.cobo_vender.HeaderText = "Vender"
        Me.cobo_vender.MinimumWidth = 6
        Me.cobo_vender.Name = "cobo_vender"
        Me.cobo_vender.Width = 125
        '
        'tb_search
        '
        Me.tb_search.Location = New System.Drawing.Point(99, 65)
        Me.tb_search.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_search.Name = "tb_search"
        Me.tb_search.Size = New System.Drawing.Size(237, 22)
        Me.tb_search.TabIndex = 1
        Me.tb_search.Text = "%%%%"
        '
        'Lb_fillter
        '
        Me.Lb_fillter.AutoSize = True
        Me.Lb_fillter.Location = New System.Drawing.Point(30, 68)
        Me.Lb_fillter.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lb_fillter.Name = "Lb_fillter"
        Me.Lb_fillter.Size = New System.Drawing.Size(62, 17)
        Me.Lb_fillter.TabIndex = 2
        Me.Lb_fillter.Text = "Fillter >>"
        '
        'Bt_Fillter
        '
        Me.Bt_Fillter.Location = New System.Drawing.Point(346, 62)
        Me.Bt_Fillter.Margin = New System.Windows.Forms.Padding(4)
        Me.Bt_Fillter.Name = "Bt_Fillter"
        Me.Bt_Fillter.Size = New System.Drawing.Size(59, 28)
        Me.Bt_Fillter.TabIndex = 3
        Me.Bt_Fillter.Text = "Fillter"
        Me.Bt_Fillter.UseVisualStyleBackColor = True
        '
        'Nd_Offset
        '
        Me.Nd_Offset.Location = New System.Drawing.Point(1250, 62)
        Me.Nd_Offset.Margin = New System.Windows.Forms.Padding(4)
        Me.Nd_Offset.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.Nd_Offset.Name = "Nd_Offset"
        Me.Nd_Offset.Size = New System.Drawing.Size(84, 22)
        Me.Nd_Offset.TabIndex = 4
        '
        'Lb_Offset
        '
        Me.Lb_Offset.AutoSize = True
        Me.Lb_Offset.Location = New System.Drawing.Point(1175, 66)
        Me.Lb_Offset.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lb_Offset.Name = "Lb_Offset"
        Me.Lb_Offset.Size = New System.Drawing.Size(66, 17)
        Me.Lb_Offset.TabIndex = 5
        Me.Lb_Offset.Text = "Offset >>"
        '
        'Lb_Row_CS
        '
        Me.Lb_Row_CS.AutoSize = True
        Me.Lb_Row_CS.Location = New System.Drawing.Point(24, 537)
        Me.Lb_Row_CS.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lb_Row_CS.Name = "Lb_Row_CS"
        Me.Lb_Row_CS.Size = New System.Drawing.Size(54, 17)
        Me.Lb_Row_CS.TabIndex = 6
        Me.Lb_Row_CS.Text = "0 Rows"
        '
        'Cb_Vender
        '
        Me.Cb_Vender.FormattingEnabled = True
        Me.Cb_Vender.Location = New System.Drawing.Point(1039, 542)
        Me.Cb_Vender.Margin = New System.Windows.Forms.Padding(4)
        Me.Cb_Vender.Name = "Cb_Vender"
        Me.Cb_Vender.Size = New System.Drawing.Size(183, 24)
        Me.Cb_Vender.TabIndex = 7
        '
        'Bt_to_Pre
        '
        Me.Bt_to_Pre.Location = New System.Drawing.Point(1231, 540)
        Me.Bt_to_Pre.Margin = New System.Windows.Forms.Padding(4)
        Me.Bt_to_Pre.Name = "Bt_to_Pre"
        Me.Bt_to_Pre.Size = New System.Drawing.Size(100, 28)
        Me.Bt_to_Pre.TabIndex = 8
        Me.Bt_to_Pre.Text = "Pre Order"
        Me.Bt_to_Pre.UseVisualStyleBackColor = True
        '
        'Cb_Mode
        '
        Me.Cb_Mode.FormattingEnabled = True
        Me.Cb_Mode.Location = New System.Drawing.Point(1056, 63)
        Me.Cb_Mode.Margin = New System.Windows.Forms.Padding(4)
        Me.Cb_Mode.Name = "Cb_Mode"
        Me.Cb_Mode.Size = New System.Drawing.Size(83, 24)
        Me.Cb_Mode.TabIndex = 9
        '
        'Lb_Mode
        '
        Me.Lb_Mode.AutoSize = True
        Me.Lb_Mode.Location = New System.Drawing.Point(983, 68)
        Me.Lb_Mode.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lb_Mode.Name = "Lb_Mode"
        Me.Lb_Mode.Size = New System.Drawing.Size(63, 17)
        Me.Lb_Mode.TabIndex = 10
        Me.Lb_Mode.Text = "Mode >>"
        '
        'Dgv_CheckStock1
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv_CheckStock1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.Dgv_CheckStock1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_CheckStock1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewCheckBoxColumn1, Me.cb_dgv_vender1})
        Me.Dgv_CheckStock1.EnableHeadersVisualStyles = False
        Me.Dgv_CheckStock1.Location = New System.Drawing.Point(147, 105)
        Me.Dgv_CheckStock1.Margin = New System.Windows.Forms.Padding(4)
        Me.Dgv_CheckStock1.MultiSelect = False
        Me.Dgv_CheckStock1.Name = "Dgv_CheckStock1"
        Me.Dgv_CheckStock1.RowHeadersWidth = 51
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Dgv_CheckStock1.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.Dgv_CheckStock1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dgv_CheckStock1.Size = New System.Drawing.Size(1058, 416)
        Me.Dgv_CheckStock1.TabIndex = 11
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.HeaderText = "##"
        Me.DataGridViewCheckBoxColumn1.MinimumWidth = 6
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.Width = 125
        '
        'cb_dgv_vender1
        '
        Me.cb_dgv_vender1.HeaderText = "Vender"
        Me.cb_dgv_vender1.MinimumWidth = 6
        Me.cb_dgv_vender1.Name = "cb_dgv_vender1"
        Me.cb_dgv_vender1.Width = 125
        '
        'Lb_Row_Cs1
        '
        Me.Lb_Row_Cs1.AutoSize = True
        Me.Lb_Row_Cs1.Location = New System.Drawing.Point(188, 537)
        Me.Lb_Row_Cs1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lb_Row_Cs1.Name = "Lb_Row_Cs1"
        Me.Lb_Row_Cs1.Size = New System.Drawing.Size(54, 17)
        Me.Lb_Row_Cs1.TabIndex = 12
        Me.Lb_Row_Cs1.Text = "0 Rows"
        '
        'Bt_ChangeMode
        '
        Me.Bt_ChangeMode.Location = New System.Drawing.Point(33, 12)
        Me.Bt_ChangeMode.Name = "Bt_ChangeMode"
        Me.Bt_ChangeMode.Size = New System.Drawing.Size(93, 30)
        Me.Bt_ChangeMode.TabIndex = 13
        Me.Bt_ChangeMode.Text = "Filter Mode"
        Me.Bt_ChangeMode.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1360, 590)
        Me.Controls.Add(Me.Bt_ChangeMode)
        Me.Controls.Add(Me.Lb_Row_Cs1)
        Me.Controls.Add(Me.Dgv_CheckStock1)
        Me.Controls.Add(Me.Lb_Mode)
        Me.Controls.Add(Me.Cb_Mode)
        Me.Controls.Add(Me.Bt_to_Pre)
        Me.Controls.Add(Me.Cb_Vender)
        Me.Controls.Add(Me.Lb_Row_CS)
        Me.Controls.Add(Me.Lb_Offset)
        Me.Controls.Add(Me.Nd_Offset)
        Me.Controls.Add(Me.Bt_Fillter)
        Me.Controls.Add(Me.Lb_fillter)
        Me.Controls.Add(Me.tb_search)
        Me.Controls.Add(Me.Dgv_CheckStock)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Check Stock CK Shop"
        CType(Me.Dgv_CheckStock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Nd_Offset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dgv_CheckStock1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Dgv_CheckStock As DataGridView
    Friend WithEvents tb_search As TextBox
    Friend WithEvents Lb_fillter As Label
    Friend WithEvents Bt_Fillter As Button
    Friend WithEvents Nd_Offset As NumericUpDown
    Friend WithEvents Lb_Offset As Label
    Friend WithEvents Lb_Row_CS As Label
    Friend WithEvents Cb_Vender As ComboBox
    Friend WithEvents Bt_to_Pre As Button
    Friend WithEvents Cb_Mode As ComboBox
    Friend WithEvents Lb_Mode As Label
    Friend WithEvents chk As DataGridViewCheckBoxColumn
    Friend WithEvents cobo_vender As DataGridViewComboBoxColumn
    Friend WithEvents Dgv_CheckStock1 As DataGridView
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents cb_dgv_vender1 As DataGridViewComboBoxColumn
    Friend WithEvents Lb_Row_Cs1 As Label
    Friend WithEvents Bt_ChangeMode As Button
End Class
