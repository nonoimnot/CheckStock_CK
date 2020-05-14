<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Tab_Control = New System.Windows.Forms.TabControl()
        Me.Tab_PreOr = New System.Windows.Forms.TabPage()
        Me.Bt_CheckStock = New System.Windows.Forms.Button()
        Me.lb_Data_Redundancy = New System.Windows.Forms.Label()
        Me.Bt_insert_parts = New System.Windows.Forms.Button()
        Me.Bt_Del_Pre = New System.Windows.Forms.Button()
        Me.Lb_Preorder_row = New System.Windows.Forms.Label()
        Me.Bt_update_PreOrder = New System.Windows.Forms.Button()
        Me.Bt_MovetoOp = New System.Windows.Forms.Button()
        Me.Dgv_Preorder = New System.Windows.Forms.DataGridView()
        Me.chk_pre = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Tab_Order = New System.Windows.Forms.TabPage()
        Me.Bt_Del_Or = New System.Windows.Forms.Button()
        Me.Lb_OrderRows = New System.Windows.Forms.Label()
        Me.Bt_update_Order = New System.Windows.Forms.Button()
        Me.Dgv_Order = New System.Windows.Forms.DataGridView()
        Me.chk = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Tab_Receive = New System.Windows.Forms.TabPage()
        Me.Tb_Folder_GenCsv = New System.Windows.Forms.TextBox()
        Me.Bt_GenCsv = New System.Windows.Forms.Button()
        Me.Lb_RowNo_Received = New System.Windows.Forms.Label()
        Me.Dgv_Received = New System.Windows.Forms.DataGridView()
        Me.Tab_Completed = New System.Windows.Forms.TabPage()
        Me.Bt_Del_Completed = New System.Windows.Forms.Button()
        Me.Bt_Back_Received = New System.Windows.Forms.Button()
        Me.Dgv_Completed = New System.Windows.Forms.DataGridView()
        Me.chk_completed = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.lb_RowNo_Completed = New System.Windows.Forms.Label()
        Me.Timer_check_redundancy = New System.Windows.Forms.Timer(Me.components)
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Tab_Control.SuspendLayout()
        Me.Tab_PreOr.SuspendLayout()
        CType(Me.Dgv_Preorder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tab_Order.SuspendLayout()
        CType(Me.Dgv_Order, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tab_Receive.SuspendLayout()
        CType(Me.Dgv_Received, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tab_Completed.SuspendLayout()
        CType(Me.Dgv_Completed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Tab_Control
        '
        Me.Tab_Control.Controls.Add(Me.Tab_PreOr)
        Me.Tab_Control.Controls.Add(Me.Tab_Order)
        Me.Tab_Control.Controls.Add(Me.Tab_Receive)
        Me.Tab_Control.Controls.Add(Me.Tab_Completed)
        Me.Tab_Control.Location = New System.Drawing.Point(16, 15)
        Me.Tab_Control.Margin = New System.Windows.Forms.Padding(4)
        Me.Tab_Control.Name = "Tab_Control"
        Me.Tab_Control.SelectedIndex = 0
        Me.Tab_Control.Size = New System.Drawing.Size(1035, 529)
        Me.Tab_Control.TabIndex = 0
        '
        'Tab_PreOr
        '
        Me.Tab_PreOr.Controls.Add(Me.Bt_CheckStock)
        Me.Tab_PreOr.Controls.Add(Me.lb_Data_Redundancy)
        Me.Tab_PreOr.Controls.Add(Me.Bt_insert_parts)
        Me.Tab_PreOr.Controls.Add(Me.Bt_Del_Pre)
        Me.Tab_PreOr.Controls.Add(Me.Lb_Preorder_row)
        Me.Tab_PreOr.Controls.Add(Me.Bt_update_PreOrder)
        Me.Tab_PreOr.Controls.Add(Me.Bt_MovetoOp)
        Me.Tab_PreOr.Controls.Add(Me.Dgv_Preorder)
        Me.Tab_PreOr.Controls.Add(Me.Button1)
        Me.Tab_PreOr.Controls.Add(Me.ComboBox1)
        Me.Tab_PreOr.Location = New System.Drawing.Point(4, 25)
        Me.Tab_PreOr.Margin = New System.Windows.Forms.Padding(4)
        Me.Tab_PreOr.Name = "Tab_PreOr"
        Me.Tab_PreOr.Padding = New System.Windows.Forms.Padding(4)
        Me.Tab_PreOr.Size = New System.Drawing.Size(1027, 500)
        Me.Tab_PreOr.TabIndex = 0
        Me.Tab_PreOr.Text = "PreOrder Parts"
        Me.Tab_PreOr.UseVisualStyleBackColor = True
        '
        'Bt_CheckStock
        '
        Me.Bt_CheckStock.Location = New System.Drawing.Point(247, 7)
        Me.Bt_CheckStock.Margin = New System.Windows.Forms.Padding(4)
        Me.Bt_CheckStock.Name = "Bt_CheckStock"
        Me.Bt_CheckStock.Size = New System.Drawing.Size(116, 28)
        Me.Bt_CheckStock.TabIndex = 9
        Me.Bt_CheckStock.Text = "Check Stock"
        Me.Bt_CheckStock.UseVisualStyleBackColor = True
        '
        'lb_Data_Redundancy
        '
        Me.lb_Data_Redundancy.AutoSize = True
        Me.lb_Data_Redundancy.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lb_Data_Redundancy.Location = New System.Drawing.Point(471, 14)
        Me.lb_Data_Redundancy.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lb_Data_Redundancy.Name = "lb_Data_Redundancy"
        Me.lb_Data_Redundancy.Size = New System.Drawing.Size(173, 17)
        Me.lb_Data_Redundancy.TabIndex = 8
        Me.lb_Data_Redundancy.Text = "ตรวจพบการสั่งสินค้า ซ้ำซ้อน !!!"
        Me.lb_Data_Redundancy.Visible = False
        '
        'Bt_insert_parts
        '
        Me.Bt_insert_parts.Location = New System.Drawing.Point(808, 7)
        Me.Bt_insert_parts.Margin = New System.Windows.Forms.Padding(4)
        Me.Bt_insert_parts.Name = "Bt_insert_parts"
        Me.Bt_insert_parts.Size = New System.Drawing.Size(100, 28)
        Me.Bt_insert_parts.TabIndex = 7
        Me.Bt_insert_parts.Text = "Insert"
        Me.Bt_insert_parts.UseVisualStyleBackColor = True
        '
        'Bt_Del_Pre
        '
        Me.Bt_Del_Pre.Location = New System.Drawing.Point(916, 7)
        Me.Bt_Del_Pre.Margin = New System.Windows.Forms.Padding(4)
        Me.Bt_Del_Pre.Name = "Bt_Del_Pre"
        Me.Bt_Del_Pre.Size = New System.Drawing.Size(100, 28)
        Me.Bt_Del_Pre.TabIndex = 6
        Me.Bt_Del_Pre.Text = "Delete"
        Me.Bt_Del_Pre.UseVisualStyleBackColor = True
        '
        'Lb_Preorder_row
        '
        Me.Lb_Preorder_row.AutoSize = True
        Me.Lb_Preorder_row.Location = New System.Drawing.Point(21, 463)
        Me.Lb_Preorder_row.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lb_Preorder_row.Name = "Lb_Preorder_row"
        Me.Lb_Preorder_row.Size = New System.Drawing.Size(49, 17)
        Me.Lb_Preorder_row.TabIndex = 5
        Me.Lb_Preorder_row.Text = "0 rows"
        '
        'Bt_update_PreOrder
        '
        Me.Bt_update_PreOrder.Location = New System.Drawing.Point(808, 457)
        Me.Bt_update_PreOrder.Margin = New System.Windows.Forms.Padding(4)
        Me.Bt_update_PreOrder.Name = "Bt_update_PreOrder"
        Me.Bt_update_PreOrder.Size = New System.Drawing.Size(100, 28)
        Me.Bt_update_PreOrder.TabIndex = 4
        Me.Bt_update_PreOrder.Text = "Update"
        Me.Bt_update_PreOrder.UseVisualStyleBackColor = True
        '
        'Bt_MovetoOp
        '
        Me.Bt_MovetoOp.Location = New System.Drawing.Point(916, 457)
        Me.Bt_MovetoOp.Margin = New System.Windows.Forms.Padding(4)
        Me.Bt_MovetoOp.Name = "Bt_MovetoOp"
        Me.Bt_MovetoOp.Size = New System.Drawing.Size(100, 28)
        Me.Bt_MovetoOp.TabIndex = 3
        Me.Bt_MovetoOp.Text = "To Order"
        Me.Bt_MovetoOp.UseVisualStyleBackColor = True
        '
        'Dgv_Preorder
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv_Preorder.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Dgv_Preorder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_Preorder.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.chk_pre})
        Me.Dgv_Preorder.EnableHeadersVisualStyles = False
        Me.Dgv_Preorder.Location = New System.Drawing.Point(8, 43)
        Me.Dgv_Preorder.Margin = New System.Windows.Forms.Padding(4)
        Me.Dgv_Preorder.Name = "Dgv_Preorder"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv_Preorder.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Dgv_Preorder.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.Dgv_Preorder.Size = New System.Drawing.Size(1008, 406)
        Me.Dgv_Preorder.TabIndex = 2
        '
        'chk_pre
        '
        Me.chk_pre.HeaderText = "##"
        Me.chk_pre.Name = "chk_pre"
        Me.chk_pre.Width = 27
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(177, 7)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(47, 28)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Go"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(8, 7)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(160, 24)
        Me.ComboBox1.TabIndex = 0
        '
        'Tab_Order
        '
        Me.Tab_Order.Controls.Add(Me.Bt_Del_Or)
        Me.Tab_Order.Controls.Add(Me.Lb_OrderRows)
        Me.Tab_Order.Controls.Add(Me.Bt_update_Order)
        Me.Tab_Order.Controls.Add(Me.Dgv_Order)
        Me.Tab_Order.Location = New System.Drawing.Point(4, 25)
        Me.Tab_Order.Margin = New System.Windows.Forms.Padding(4)
        Me.Tab_Order.Name = "Tab_Order"
        Me.Tab_Order.Padding = New System.Windows.Forms.Padding(4)
        Me.Tab_Order.Size = New System.Drawing.Size(1027, 500)
        Me.Tab_Order.TabIndex = 1
        Me.Tab_Order.Text = "Order Parts"
        Me.Tab_Order.UseVisualStyleBackColor = True
        '
        'Bt_Del_Or
        '
        Me.Bt_Del_Or.Location = New System.Drawing.Point(916, 7)
        Me.Bt_Del_Or.Margin = New System.Windows.Forms.Padding(4)
        Me.Bt_Del_Or.Name = "Bt_Del_Or"
        Me.Bt_Del_Or.Size = New System.Drawing.Size(100, 28)
        Me.Bt_Del_Or.TabIndex = 4
        Me.Bt_Del_Or.Text = "Delete"
        Me.Bt_Del_Or.UseVisualStyleBackColor = True
        '
        'Lb_OrderRows
        '
        Me.Lb_OrderRows.AutoSize = True
        Me.Lb_OrderRows.Location = New System.Drawing.Point(32, 459)
        Me.Lb_OrderRows.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lb_OrderRows.Name = "Lb_OrderRows"
        Me.Lb_OrderRows.Size = New System.Drawing.Size(54, 17)
        Me.Lb_OrderRows.TabIndex = 3
        Me.Lb_OrderRows.Text = "0 Rows"
        '
        'Bt_update_Order
        '
        Me.Bt_update_Order.Location = New System.Drawing.Point(905, 453)
        Me.Bt_update_Order.Margin = New System.Windows.Forms.Padding(4)
        Me.Bt_update_Order.Name = "Bt_update_Order"
        Me.Bt_update_Order.Size = New System.Drawing.Size(111, 28)
        Me.Bt_update_Order.TabIndex = 2
        Me.Bt_update_Order.Text = "To Received"
        Me.Bt_update_Order.UseVisualStyleBackColor = True
        '
        'Dgv_Order
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv_Order.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.Dgv_Order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_Order.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.chk})
        Me.Dgv_Order.EnableHeadersVisualStyles = False
        Me.Dgv_Order.Location = New System.Drawing.Point(8, 39)
        Me.Dgv_Order.Margin = New System.Windows.Forms.Padding(4)
        Me.Dgv_Order.Name = "Dgv_Order"
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Dgv_Order.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.Dgv_Order.Size = New System.Drawing.Size(1008, 406)
        Me.Dgv_Order.TabIndex = 0
        '
        'chk
        '
        Me.chk.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chk.HeaderText = "##"
        Me.chk.Name = "chk"
        Me.chk.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.chk.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.chk.Width = 46
        '
        'Tab_Receive
        '
        Me.Tab_Receive.Controls.Add(Me.Tb_Folder_GenCsv)
        Me.Tab_Receive.Controls.Add(Me.Bt_GenCsv)
        Me.Tab_Receive.Controls.Add(Me.Lb_RowNo_Received)
        Me.Tab_Receive.Controls.Add(Me.Dgv_Received)
        Me.Tab_Receive.Location = New System.Drawing.Point(4, 25)
        Me.Tab_Receive.Margin = New System.Windows.Forms.Padding(4)
        Me.Tab_Receive.Name = "Tab_Receive"
        Me.Tab_Receive.Padding = New System.Windows.Forms.Padding(4)
        Me.Tab_Receive.Size = New System.Drawing.Size(1027, 500)
        Me.Tab_Receive.TabIndex = 2
        Me.Tab_Receive.Text = "Received Parts"
        Me.Tab_Receive.UseVisualStyleBackColor = True
        '
        'Tb_Folder_GenCsv
        '
        Me.Tb_Folder_GenCsv.Location = New System.Drawing.Point(561, 461)
        Me.Tb_Folder_GenCsv.Name = "Tb_Folder_GenCsv"
        Me.Tb_Folder_GenCsv.Size = New System.Drawing.Size(337, 22)
        Me.Tb_Folder_GenCsv.TabIndex = 3
        Me.Tb_Folder_GenCsv.Text = "D:\VirtualBox\Orderfile.csv"
        '
        'Bt_GenCsv
        '
        Me.Bt_GenCsv.Location = New System.Drawing.Point(905, 458)
        Me.Bt_GenCsv.Margin = New System.Windows.Forms.Padding(4)
        Me.Bt_GenCsv.Name = "Bt_GenCsv"
        Me.Bt_GenCsv.Size = New System.Drawing.Size(111, 28)
        Me.Bt_GenCsv.TabIndex = 2
        Me.Bt_GenCsv.Text = "Gen Csv"
        Me.Bt_GenCsv.UseVisualStyleBackColor = True
        '
        'Lb_RowNo_Received
        '
        Me.Lb_RowNo_Received.AutoSize = True
        Me.Lb_RowNo_Received.Location = New System.Drawing.Point(25, 464)
        Me.Lb_RowNo_Received.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lb_RowNo_Received.Name = "Lb_RowNo_Received"
        Me.Lb_RowNo_Received.Size = New System.Drawing.Size(54, 17)
        Me.Lb_RowNo_Received.TabIndex = 1
        Me.Lb_RowNo_Received.Text = "0 Rows"
        '
        'Dgv_Received
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv_Received.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.Dgv_Received.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_Received.EnableHeadersVisualStyles = False
        Me.Dgv_Received.Location = New System.Drawing.Point(8, 34)
        Me.Dgv_Received.Margin = New System.Windows.Forms.Padding(4)
        Me.Dgv_Received.MultiSelect = False
        Me.Dgv_Received.Name = "Dgv_Received"
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Dgv_Received.RowsDefaultCellStyle = DataGridViewCellStyle7
        Me.Dgv_Received.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dgv_Received.Size = New System.Drawing.Size(1008, 412)
        Me.Dgv_Received.TabIndex = 0
        '
        'Tab_Completed
        '
        Me.Tab_Completed.Controls.Add(Me.Bt_Del_Completed)
        Me.Tab_Completed.Controls.Add(Me.Bt_Back_Received)
        Me.Tab_Completed.Controls.Add(Me.Dgv_Completed)
        Me.Tab_Completed.Controls.Add(Me.lb_RowNo_Completed)
        Me.Tab_Completed.Location = New System.Drawing.Point(4, 25)
        Me.Tab_Completed.Margin = New System.Windows.Forms.Padding(4)
        Me.Tab_Completed.Name = "Tab_Completed"
        Me.Tab_Completed.Padding = New System.Windows.Forms.Padding(4)
        Me.Tab_Completed.Size = New System.Drawing.Size(1027, 500)
        Me.Tab_Completed.TabIndex = 3
        Me.Tab_Completed.Text = "Completed Parts"
        Me.Tab_Completed.UseVisualStyleBackColor = True
        '
        'Bt_Del_Completed
        '
        Me.Bt_Del_Completed.Location = New System.Drawing.Point(898, 453)
        Me.Bt_Del_Completed.Name = "Bt_Del_Completed"
        Me.Bt_Del_Completed.Size = New System.Drawing.Size(111, 28)
        Me.Bt_Del_Completed.TabIndex = 5
        Me.Bt_Del_Completed.Text = "Delete"
        Me.Bt_Del_Completed.UseVisualStyleBackColor = True
        '
        'Bt_Back_Received
        '
        Me.Bt_Back_Received.Location = New System.Drawing.Point(781, 453)
        Me.Bt_Back_Received.Name = "Bt_Back_Received"
        Me.Bt_Back_Received.Size = New System.Drawing.Size(111, 28)
        Me.Bt_Back_Received.TabIndex = 4
        Me.Bt_Back_Received.Text = "<< Back"
        Me.Bt_Back_Received.UseVisualStyleBackColor = True
        '
        'Dgv_Completed
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv_Completed.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.Dgv_Completed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_Completed.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.chk_completed})
        Me.Dgv_Completed.EnableHeadersVisualStyles = False
        Me.Dgv_Completed.Location = New System.Drawing.Point(12, 30)
        Me.Dgv_Completed.Margin = New System.Windows.Forms.Padding(4)
        Me.Dgv_Completed.MultiSelect = False
        Me.Dgv_Completed.Name = "Dgv_Completed"
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Dgv_Completed.RowsDefaultCellStyle = DataGridViewCellStyle9
        Me.Dgv_Completed.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dgv_Completed.Size = New System.Drawing.Size(1008, 409)
        Me.Dgv_Completed.TabIndex = 3
        '
        'chk_completed
        '
        Me.chk_completed.HeaderText = "##"
        Me.chk_completed.Name = "chk_completed"
        Me.chk_completed.Width = 30
        '
        'lb_RowNo_Completed
        '
        Me.lb_RowNo_Completed.AutoSize = True
        Me.lb_RowNo_Completed.Location = New System.Drawing.Point(27, 453)
        Me.lb_RowNo_Completed.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lb_RowNo_Completed.Name = "lb_RowNo_Completed"
        Me.lb_RowNo_Completed.Size = New System.Drawing.Size(54, 17)
        Me.lb_RowNo_Completed.TabIndex = 2
        Me.lb_RowNo_Completed.Text = "0 Rows"
        '
        'Timer_check_redundancy
        '
        Me.Timer_check_redundancy.Enabled = True
        Me.Timer_check_redundancy.Interval = 1000
        '
        'FolderBrowserDialog1
        '
        Me.FolderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 559)
        Me.Controls.Add(Me.Tab_Control)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CK Order Spare Parts Programe"
        Me.Tab_Control.ResumeLayout(False)
        Me.Tab_PreOr.ResumeLayout(False)
        Me.Tab_PreOr.PerformLayout()
        CType(Me.Dgv_Preorder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tab_Order.ResumeLayout(False)
        Me.Tab_Order.PerformLayout()
        CType(Me.Dgv_Order, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tab_Receive.ResumeLayout(False)
        Me.Tab_Receive.PerformLayout()
        CType(Me.Dgv_Received, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tab_Completed.ResumeLayout(False)
        Me.Tab_Completed.PerformLayout()
        CType(Me.Dgv_Completed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Tab_Control As TabControl
    Friend WithEvents Tab_PreOr As TabPage
    Friend WithEvents Tab_Order As TabPage
    Friend WithEvents Tab_Receive As TabPage
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Dgv_Preorder As DataGridView
    Friend WithEvents Bt_update_PreOrder As Button
    Friend WithEvents Bt_MovetoOp As Button
    Friend WithEvents Lb_Preorder_row As Label
    Friend WithEvents Lb_OrderRows As Label
    Friend WithEvents Bt_update_Order As Button
    Friend WithEvents Dgv_Order As DataGridView
    Friend WithEvents Lb_RowNo_Received As Label
    Friend WithEvents chk_pre As DataGridViewCheckBoxColumn
    Friend WithEvents Bt_GenCsv As Button
    Friend WithEvents Bt_Del_Pre As Button
    Friend WithEvents Bt_Del_Or As Button
    Friend WithEvents chk As DataGridViewCheckBoxColumn
    Friend WithEvents Bt_insert_parts As Button
    Friend WithEvents Tab_Completed As TabPage
    Friend WithEvents lb_RowNo_Completed As Label
    Friend WithEvents Dgv_Received As DataGridView
    Friend WithEvents Dgv_Completed As DataGridView
    Friend WithEvents lb_Data_Redundancy As Label
    Friend WithEvents Timer_check_redundancy As Timer
    Friend WithEvents Bt_CheckStock As Button
    Friend WithEvents Bt_Back_Received As Button
    Friend WithEvents chk_completed As DataGridViewCheckBoxColumn
    Friend WithEvents Bt_Del_Completed As Button
    Friend WithEvents Tb_Folder_GenCsv As TextBox
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
End Class
