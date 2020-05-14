Imports System.IO
Imports System.Text
Imports MySql.Data.MySqlClient

Public Class Form1
    Dim MysqlConn As MySqlConnection
    Dim Cs As String = "Database=test_db;Server=localhost;User id=test1;Password=test1234"
    Dim Ds As DataSet = New DataSet
    Dim Da As MySqlDataAdapter = New MySqlDataAdapter()
    Public Itc As New ArrayList()
    Public Item_array As New ArrayList()
    'Test for GitHub'


    Public Sub CheckNumber(sender As Object, e As KeyPressEventArgs)
        Select Case Asc(e.KeyChar)
            Case 48 To 57
                e.Handled = False
            Case 8
                e.Handled = False
            Case 13
                e.Handled = False
            Case 46
                e.Handled = False
            Case Else
                e.Handled = True
                MessageBox.Show("Only Number Char Please")
        End Select

    End Sub

    Private Sub Update_Or_Parts(OrderNo As Integer, Qty As Integer, OrStNo As String)
        MysqlConn = New MySqlConnection(Cs)
        MysqlConn.Open()
        'MessageBox.Show("Connection to Database has been opened.")
        Dim stm As String = "update order_spare_parts set OrderStatusNo = @OrStNo, " &
                                "OrQty = @Qty, DocDate = now() where OrderNo = @OrderNo"
        Dim cmd As MySqlCommand = New MySqlCommand(stm, MysqlConn)
        cmd.Parameters.Add("@OrStNo", MySqlDbType.VarChar, 2).Value = OrStNo
        cmd.Parameters.Add("@Qty", MySqlDbType.Int16).Value = Qty
        cmd.Parameters.Add("@OrderNo", MySqlDbType.Int16).Value = OrderNo
        cmd.ExecuteNonQuery()
        MysqlConn.Close()
        MysqlConn.Dispose()

    End Sub

    Private Sub Del_Item(OrderNo As Integer)
        MysqlConn = New MySqlConnection(Cs)
        MysqlConn.Open()
        'MessageBox.Show("Connection to Database has been opened.")
        Dim stm As String = "delete from order_spare_parts where orderno = @OrderNo"
        Dim cmd As MySqlCommand = New MySqlCommand(stm, MysqlConn)
        cmd.Parameters.Add("@OrderNo", MySqlDbType.Int16).Value = OrderNo
        cmd.ExecuteNonQuery()
        MysqlConn.Close()
        MysqlConn.Dispose()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MysqlConn = New MySqlConnection(Cs)
        MysqlConn.Open()
        'MessageBox.Show("Connection to Database has been opened.")
        Dim stm As String = "select VenderNo,VenderDesc from vender"
        Dim cmd As MySqlCommand = New MySqlCommand(stm, MysqlConn)
        Dim reader As MySqlDataReader = cmd.ExecuteReader()
        Dim dt As DataTable = New DataTable
        'Dim listrow As Short = 0
        dt.Load(reader)
        ComboBox1.ValueMember = "VenderNo"
        ComboBox1.DisplayMember = "VenderDesc"
        ComboBox1.DataSource = dt
        reader.Close()
        MysqlConn.Close()
        MysqlConn.Dispose()
        Button1.PerformClick()

        'Try

        'Catch ex As Exception
        'MessageBox.Show("Cannot connect to database: " & ex.Message)
        'Finally
        'MysqlConn.Dispose()
        'End Try

    End Sub

    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click, ComboBox1.SelectionChangeCommitted
        Dim Vender_Select As String = ComboBox1.Text
        Dim Vender_No As String = ComboBox1.SelectedValue
        'MessageBox.Show(Vender_No & " : " & Vender_Select, "Combobox1 selected")
        MysqlConn = New MySqlConnection(Cs)
        MysqlConn.Open()
        'MessageBox.Show("Connection to Database has been opened.")
        '--------------------- Section Show DataGridView PreOrder Spare Parts ----------------------------
        Dim stm As String = "select OrderNo,ItemCode,ItemDesc,OrQty,item.qty as InStrock,DocDate from " &
                            "order_spare_parts inner join item on order_spare_parts.ItemCode = item.Code " &
                            "where VenderNO = @Venderno and OrderStatusNo = '01'"
        Dim cmd As MySqlCommand = New MySqlCommand(stm, MysqlConn)

        cmd.Parameters.Add("@venderno", MySqlDbType.VarChar, 3).Value = Vender_No
        Da.SelectCommand = cmd
        Ds.Clear()
        Da.Fill(Ds, "PreOrder")
        Dgv_Preorder.DataSource = Ds.Tables("PreOrder")
        '--------------------- Section Show DataGridView Order Spare Parts ----------------------------
        'Dim stm1 As String = "select OrderNo,ItemCode,ItemDesc,OrQty,item.qty as InStrock,DocDate from " &
        Dim stm1 As String = "select OrderNo,ItemCode,ItemDesc,item.SalePrice3 as SalePrice,item.AgvCost,item.qty as InStrock,OrQty,DocDate from " &
                             "order_spare_parts inner join item on order_spare_parts.ItemCode = item.Code " &
                             "where VenderNO = @Venderno and OrderStatusNo = '02'"
        Dim cmd1 As MySqlCommand = New MySqlCommand(stm1, MysqlConn)

        cmd1.Parameters.Add("@venderno", MySqlDbType.VarChar, 3).Value = Vender_No
        Da.SelectCommand = cmd1
        Da.Fill(Ds, "Order")
        Dgv_Order.DataSource = Ds.Tables("Order")
        '--------------------- Section Show DataGridView Received Spare Parts ----------------------------
        Dim stm2 As String = "select OrderNo,ItemCode,ItemDesc,item.SalePrice3 as SalePrice,item.AgvCost,OrQty,item.AgvCost as Prices " &
                            " from order_spare_parts " &
                            " inner join item on order_spare_parts.ItemCode = item.Code where VenderNO = @Venderno " &
                            "and OrderStatusNo = '03'"
        Dim cmd2 As MySqlCommand = New MySqlCommand(stm2, MysqlConn)

        cmd2.Parameters.Add("@venderno", MySqlDbType.VarChar, 3).Value = Vender_No
        Da.SelectCommand = cmd2
        Da.Fill(Ds, "Received")
        Dgv_Received.DataSource = Ds.Tables("Received")
        '--------------------- Section Show DataGridView Completed Spare Parts ----------------------------
        Dim stm3 As String = "select OrderNo,ItemCode,ItemDesc,OrQty,DocDate from order_spare_parts " &
                            "where VenderNO = @Venderno and OrderStatusNo = '04'"
        Dim cmd3 As MySqlCommand = New MySqlCommand(stm3, MysqlConn)

        cmd3.Parameters.Add("@venderno", MySqlDbType.VarChar, 3).Value = Vender_No
        Da.SelectCommand = cmd3
        Da.Fill(Ds, "Completed")
        Dgv_Completed.DataSource = Ds.Tables("Completed")

        MysqlConn.Close()
        MysqlConn.Dispose()

        ' --------------------------- Section SetUp Property Columns -------------------------------- '
        Dgv_Preorder.Columns.Item(1).ReadOnly = True
        Dgv_Preorder.Columns.Item(2).ReadOnly = True
        Dgv_Preorder.Columns.Item(3).ReadOnly = True
        Dgv_Preorder.Columns.Item(5).ReadOnly = True
        Dgv_Preorder.Columns.Item(6).ReadOnly = True
        Dgv_Preorder.Columns(0).HeaderText = "#"
        Dgv_Preorder.Columns(1).HeaderText = "No"
        Dgv_Preorder.Columns(2).HeaderText = "เลขสินค้า"
        Dgv_Preorder.Columns(3).HeaderText = "รายการสินค้า"
        Dgv_Preorder.Columns(4).HeaderText = "ซื้อ"
        Dgv_Preorder.Columns(5).HeaderText = "เหลือ"
        Dgv_Preorder.Columns(6).HeaderText = "วันที่"
        Dgv_Preorder.Columns(0).Width = 27
        Dgv_Preorder.Columns(1).Width = 50
        Dgv_Preorder.Columns(2).Width = 95
        Dgv_Preorder.Columns(3).Width = 345
        Dgv_Preorder.Columns(4).Width = 50
        Dgv_Preorder.Columns(5).Width = 50
        Dgv_Preorder.Columns(6).Width = 100
        Dgv_Preorder.RowsDefaultCellStyle.BackColor = Color.White
        Dgv_Preorder.AlternatingRowsDefaultCellStyle.BackColor = Color.PowderBlue
        Dgv_Preorder.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
        Dgv_Preorder.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray
        Dgv_Preorder.RowHeadersDefaultCellStyle.BackColor = Color.LightGray

        Dgv_Order.Columns.Item(1).ReadOnly = True
        Dgv_Order.Columns.Item(1).Visible = False
        Dgv_Order.Columns.Item(2).ReadOnly = True
        Dgv_Order.Columns.Item(2).Visible = True
        Dgv_Order.Columns.Item(3).ReadOnly = True
        Dgv_Order.Columns.Item(4).ReadOnly = True
        Dgv_Order.Columns.Item(5).ReadOnly = True
        Dgv_Order.Columns.Item(6).ReadOnly = True
        Dgv_Order.Columns.Item(7).ReadOnly = False
        Dgv_Order.Columns.Item(8).ReadOnly = True
        Dgv_Order.Columns(0).HeaderText = "#"
        Dgv_Order.Columns(1).HeaderText = "No"
        Dgv_Order.Columns(2).HeaderText = "เลขสินค้า"
        Dgv_Order.Columns(3).HeaderText = "รายการสินค้า"
        Dgv_Order.Columns(4).HeaderText = "ขาย"
        Dgv_Order.Columns(5).HeaderText = "ต้นทุน"
        Dgv_Order.Columns(6).HeaderText = "คงเหลือ"
        Dgv_Order.Columns(7).HeaderText = "ซื้อ"
        Dgv_Order.Columns(8).HeaderText = "วันที่"
        Dgv_Order.Columns(0).Width = 30
        Dgv_Order.Columns(2).Width = 90
        Dgv_Order.Columns(3).Width = 310
        Dgv_Order.Columns(4).Width = 70
        Dgv_Order.Columns(5).Width = 70
        Dgv_Order.Columns(6).Width = 70
        Dgv_Order.Columns(7).Width = 70
        Dgv_Order.Columns(8).Width = 100
        Dgv_Order.RowsDefaultCellStyle.BackColor = Color.White
        Dgv_Order.AlternatingRowsDefaultCellStyle.BackColor = Color.PowderBlue
        Dgv_Order.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
        Dgv_Order.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray
        Dgv_Order.RowHeadersDefaultCellStyle.BackColor = Color.LightGray

        Dgv_Received.Columns.Item(0).ReadOnly = True
        Dgv_Received.Columns.Item(0).Visible = False
        Dgv_Received.Columns.Item(1).ReadOnly = True
        Dgv_Received.Columns.Item(2).ReadOnly = True
        Dgv_Received.Columns.Item(3).ReadOnly = True
        Dgv_Received.Columns.Item(4).ReadOnly = True
        Dgv_Received.Columns.Item(5).ReadOnly = False
        Dgv_Received.Columns.Item(6).ReadOnly = False
        Dgv_Received.Columns(0).HeaderText = "#"
        Dgv_Received.Columns(1).HeaderText = "เลขสินค้า"
        Dgv_Received.Columns(2).HeaderText = "รายการสินค้า"
        Dgv_Received.Columns(3).HeaderText = "ราคาขาย"
        Dgv_Received.Columns(4).HeaderText = "ต้นทุน"
        Dgv_Received.Columns(5).HeaderText = "จำนวนซื้อ"
        Dgv_Received.Columns(6).HeaderText = "ราคาซื้อ"
        Dgv_Received.Columns(1).Width = 100
        Dgv_Received.Columns(2).Width = 310
        Dgv_Received.Columns(3).Width = 80
        Dgv_Received.Columns(4).Width = 80
        Dgv_Received.Columns(5).Width = 80
        Dgv_Received.Columns(6).Width = 70
        Dgv_Received.RowsDefaultCellStyle.BackColor = Color.White
        Dgv_Received.AlternatingRowsDefaultCellStyle.BackColor = Color.PowderBlue
        Dgv_Received.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
        Dgv_Received.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray
        Dgv_Received.RowHeadersDefaultCellStyle.BackColor = Color.LightGray

        Dgv_Completed.Columns.Item(0).ReadOnly = False
        Dgv_Completed.Columns.Item(1).ReadOnly = True
        Dgv_Completed.Columns.Item(2).ReadOnly = True
        Dgv_Completed.Columns.Item(3).ReadOnly = True
        Dgv_Completed.Columns.Item(4).ReadOnly = True
        Dgv_Completed.Columns.Item(5).ReadOnly = True
        Dgv_Completed.Columns(0).HeaderText = "##"
        Dgv_Completed.Columns(1).HeaderText = "No"
        Dgv_Completed.Columns(2).HeaderText = "เลขสินค้า"
        Dgv_Completed.Columns(3).HeaderText = "รายการสินค้า"
        Dgv_Completed.Columns(4).HeaderText = "จำนวนซื้อ"
        Dgv_Completed.Columns(5).HeaderText = "วันที่"
        Dgv_Completed.Columns(0).Width = 30
        Dgv_Completed.Columns(1).Width = 50
        Dgv_Completed.Columns(2).Width = 100
        Dgv_Completed.Columns(3).Width = 350
        Dgv_Completed.Columns(4).Width = 90
        Dgv_Completed.Columns(5).Width = 100
        Dgv_Completed.RowsDefaultCellStyle.BackColor = Color.White
        Dgv_Completed.AlternatingRowsDefaultCellStyle.BackColor = Color.PowderBlue
        Dgv_Completed.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
        Dgv_Completed.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray
        Dgv_Completed.RowHeadersDefaultCellStyle.BackColor = Color.LightGray

        ' -------------------------- Section Show Row no in All Table --------------------------------- '
        Dim rowno_pre As Short = Dgv_Preorder.Rows.Count - 1
        Lb_Preorder_row.Text = rowno_pre.ToString & " Rows"
        Dim rowno_or As Short = Dgv_Order.Rows.Count - 1
        Lb_OrderRows.Text = rowno_or.ToString & " Rows"
        Dim rowno_rec As Short = Dgv_Received.Rows.Count - 1
        Lb_RowNo_Received.Text = rowno_rec.ToString & " Rows"
        Dim rowno_com As Short = Dgv_Completed.Rows.Count - 1
        lb_RowNo_Completed.Text = rowno_com.ToString & " Rows"

    End Sub

    Private Sub Bt_update_PreOrder_Click(sender As Object, e As EventArgs) Handles Bt_update_PreOrder.Click
        Dim vQty As Integer
        'MessageBox.Show(Dgv_Preorder.SelectedRows.Count.ToString)
        For i = 0 To Dgv_Preorder.Rows.Count - 2
            'MessageBox.Show(Dgv_Preorder.SelectedRows.Item(i + 1).Cells(4).Value)
            If IsDBNull(Dgv_Preorder(4, i).Value) Then
                vQty = 0
            Else
                vQty = Dgv_Preorder(4, i).Value
            End If
            Update_Or_Parts(Dgv_Preorder(1, i).Value, vQty, "01")
        Next i
        Button1_Click(Nothing, Nothing)

    End Sub

    Private Sub Bt_MovetoOp_Click(sender As Object, e As EventArgs) Handles Bt_MovetoOp.Click
        Dim vQty As Integer
        Dim chk As Boolean
        For i = 0 To Dgv_Preorder.Rows.Count - 2
            chk = Dgv_Preorder(0, i).Value
            If IsDBNull(Dgv_Preorder(4, i).Value) Then
                vQty = 0
            Else
                vQty = Dgv_Preorder(4, i).Value
            End If

            If vQty <> 0 Then
                If chk = True Then
                    Update_Or_Parts(Dgv_Preorder(1, i).Value, vQty, "02")
                Else
                    Update_Or_Parts(Dgv_Preorder(1, i).Value, vQty, "01")
                    'MessageBox.Show("คุณไม่ได้กด Check Box นะครับ")
                End If
            Else
                If chk = True Then
                    Update_Or_Parts(Dgv_Preorder(1, i).Value, vQty, "01")
                End If
            End If
        Next i
        Button1_Click(Nothing, Nothing)

    End Sub

    Private Sub Bt_update_Order_Click(sender As Object, e As EventArgs) Handles Bt_update_Order.Click
        'Dgv_Order.SelectAll()
        Dim chk As Boolean
        Dim vQty As Integer
        For i = 0 To Dgv_Order.Rows.Count - 2
            vQty = Dgv_Order(7, i).Value
            chk = Dgv_Order(0, i).Value
            If chk = True Then
                Update_Or_Parts(Dgv_Order(1, i).Value, vQty, "03")
            End If
        Next
        Button1_Click(Nothing, Nothing)
    End Sub

    Private Sub Bt_GenCsv_Click(sender As Object, e As EventArgs) Handles Bt_GenCsv.Click
        Dim filePath As String
        Dim delimeter As String = ","
        Dim sb As New StringBuilder
        For i As Integer = 0 To Dgv_Received.Rows.Count - 2
            Dim array As String() = New String(Dgv_Received.Columns.Count - 2) {}
            array(0) = Dgv_Received(1, i).Value.ToString
            array(1) = Dgv_Received(5, i).Value.ToString
            array(2) = Dgv_Received(6, i).Value.ToString
            If Not Dgv_Received.Rows(i).IsNewRow Then
                sb.AppendLine(String.Join(delimeter, array))
            End If
        Next
        Try
            filePath = Tb_Folder_GenCsv.Text
            File.WriteAllText(filePath, sb.ToString)
            MessageBox.Show("Orderfile.csv Ready")
            'Opens the file immediately after writing
            'Process.Start(filePath)
            Update_Completed()
        Catch ex As Exception
            MessageBox.Show("Something Wrong in Write File Process !!")
            Tb_Folder_GenCsv_MouseDoubleClick(sender, e)
        End Try

    End Sub

    Private Sub Tb_Folder_GenCsv_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles Tb_Folder_GenCsv.MouseDoubleClick
        'MessageBox.Show("show Dialog")
        FolderBrowserDialog1.Description = "เลือกโพเดอร์ที่จะส่งไฟล์ออก"
        FolderBrowserDialog1.RootFolder = Environment.SpecialFolder.MyComputer
        FolderBrowserDialog1.ShowNewFolderButton = True
        FolderBrowserDialog1.ShowDialog()
        Tb_Folder_GenCsv.Text = FolderBrowserDialog1.SelectedPath() & "\Orderfile.csv"
    End Sub

    Private Sub Update_Completed()
        Dim vQty As Integer
        For i = 0 To Dgv_Received.Rows.Count - 2
            vQty = Dgv_Received(5, i).Value
            'MessageBox.Show(Dgv_Received(0, i).Value & " : " & vQty)
            Update_Or_Parts(Dgv_Received(0, i).Value, vQty, "04")
        Next
        Button1_Click(Nothing, Nothing)

    End Sub

    Private Sub Bt_Delete_pre_Click(sender As Object, e As EventArgs) Handles Bt_Del_Pre.Click
        'Dgv_Preorder.SelectAll()
        Dim chk As Boolean
        For i = 0 To Dgv_Preorder.Rows.Count - 2
            'chk = Dgv_Preorder.SelectedRows.Item(i + 1).Cells(0).Value
            chk = Dgv_Preorder(0, i).Value
            If chk = True Then
                Del_Item(Dgv_Preorder(1, i).Value)
                'MessageBox.Show(Dgv_Preorder(1, i).Value)
            End If
        Next
        Button1_Click(Nothing, Nothing)

    End Sub

    Private Sub Bt_Del_Or_Click(sender As Object, e As EventArgs) Handles Bt_Del_Or.Click
        Dim chk As Boolean
        For i = 0 To Dgv_Order.Rows.Count - 2
            'chk = Dgv_Order.SelectedRows.Item(i + 1).Cells(0).Value
            chk = Dgv_Order(0, i).Value
            If chk = True Then
                Del_Item(Dgv_Order(1, i).Value)
                'MessageBox.Show(Dgv_Order(1, i).Value)
            End If
        Next
        Button1_Click(Nothing, Nothing)

    End Sub

    Private Sub Bt_insert_parts_Click(sender As Object, e As EventArgs) Handles Bt_insert_parts.Click
        Form2.Show()
    End Sub

    Private Sub Check_Redundacy_Item()
        MysqlConn = New MySqlConnection(Cs)
        MysqlConn.Open()
        'MessageBox.Show("Connection to Database has been opened.")
        Dim stm As String = "select itemcode,itemdesc,count(itemcode) from order_spare_parts " &
                            "where orderstatusno <> '04' group by itemcode"
        Dim cmd As MySqlCommand = New MySqlCommand(stm, MysqlConn)
        Dim reader As MySqlDataReader = cmd.ExecuteReader()
        Dim dt As DataTable = New DataTable
        'Dim listrow As Short = 0
        dt.Load(reader)
        Itc.Clear()
        Item_array.Clear()
        For i = 0 To dt.Rows.Count - 1
            'MessageBox.Show(dt.Rows(i)(0) & " : " & dt.Rows(i)(1))
            If dt.Rows(i)("count(itemcode)") > 1 Then
                Itc.AddRange({dt.Rows(i)("itemcode"), dt.Rows(i)("count(itemcode)")})
                'MessageBox.Show(dt.Rows(i)("itemcode").ToString & " : " & dt.Rows(i)("itemdesc").ToString)
                Item_array.Add(dt.Rows(i)("itemcode"))
            End If
        Next
        'MessageBox.Show(" Row of itc >> " & Itc.Count.ToString)
        If Itc.Count > 0 Then
            lb_Data_Redundancy.Visible = True
        Else
            lb_Data_Redundancy.Visible = False
        End If
        reader.Close()
        MysqlConn.Close()
    End Sub

    Private Sub Timer_check_redundancy_Tick(sender As Object, e As EventArgs) Handles Timer_check_redundancy.Tick
        Check_Redundacy_Item()
    End Sub

    Private Sub Lb_Data_Redundancy_Click(sender As Object, e As EventArgs) Handles lb_Data_Redundancy.Click
        'MessageBox.Show("ข้อมูลซ้ำซ้อน")
        Form6.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Bt_CheckStock.Click
        Form3.Show()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs)
        Form5.Show()
    End Sub

    Private Sub Bt_Back_Received_Click(sender As Object, e As EventArgs) Handles Bt_Back_Received.Click
        Dim chk As Boolean
        Dim vQty As Integer
        For i = 0 To Dgv_Completed.Rows.Count - 2
            vQty = Dgv_Completed(4, i).Value
            chk = Dgv_Completed(0, i).Value
            'MessageBox.Show(Dgv_Completed(1, i).Value & " : " & vQty)
            If chk = True Then
                Update_Or_Parts(Dgv_Completed(1, i).Value, vQty, "03")
            End If
        Next
        Button1_Click(sender, e)

    End Sub

    Private Sub Bt_Del_Completed_Click(sender As Object, e As EventArgs) Handles Bt_Del_Completed.Click
        Dim chk As Boolean
        For i = 0 To Dgv_Completed.Rows.Count - 2
            chk = Dgv_Completed(0, i).Value
            'MessageBox.Show(Dgv_Completed(1, i).Value & " : " & vQty)
            If chk = True Then
                Del_Item(Dgv_Completed(1, i).Value)
            End If
        Next
        Button1_Click(sender, e)
    End Sub

    Private Sub Dgv_Preorder_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles Dgv_Preorder.RowPostPaint
        Dim dg As DataGridView = DirectCast(sender, DataGridView)
        ' Current row record
        Dim rowNumber As String = (e.RowIndex + 1).ToString()

        ' Format row based on number of records displayed by using leading zeros
        While rowNumber.Length < dg.RowCount.ToString().Length
            rowNumber = "0" & rowNumber
        End While

        ' Position text
        Dim size As SizeF = e.Graphics.MeasureString(rowNumber, Me.Font)
        If dg.RowHeadersWidth < CInt(size.Width + 20) Then
            dg.RowHeadersWidth = CInt(size.Width + 20)
        End If

        ' Use default system text brush
        Dim b As Brush = SystemBrushes.ControlText

        ' Draw row number
        e.Graphics.DrawString(rowNumber, dg.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2))
    End Sub

    Private Sub Dgv_Order_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles Dgv_Order.RowPostPaint
        Dim dg As DataGridView = DirectCast(sender, DataGridView)
        ' Current row record
        Dim rowNumber As String = (e.RowIndex + 1).ToString()

        ' Format row based on number of records displayed by using leading zeros
        While rowNumber.Length < dg.RowCount.ToString().Length
            rowNumber = "0" & rowNumber
        End While

        ' Position text
        Dim size As SizeF = e.Graphics.MeasureString(rowNumber, Me.Font)
        If dg.RowHeadersWidth < CInt(size.Width + 20) Then
            dg.RowHeadersWidth = CInt(size.Width + 20)
        End If

        ' Use default system text brush
        Dim b As Brush = SystemBrushes.ControlText

        ' Draw row number
        e.Graphics.DrawString(rowNumber, dg.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2))

    End Sub

    Private Sub Dgv_Received_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles Dgv_Received.RowPostPaint
        Dim dg As DataGridView = DirectCast(sender, DataGridView)
        ' Current row record
        Dim rowNumber As String = (e.RowIndex + 1).ToString()

        ' Format row based on number of records displayed by using leading zeros
        While rowNumber.Length < dg.RowCount.ToString().Length
            rowNumber = "0" & rowNumber
        End While

        ' Position text
        Dim size As SizeF = e.Graphics.MeasureString(rowNumber, Me.Font)
        If dg.RowHeadersWidth < CInt(size.Width + 20) Then
            dg.RowHeadersWidth = CInt(size.Width + 20)
        End If

        ' Use default system text brush
        Dim b As Brush = SystemBrushes.ControlText

        ' Draw row number
        e.Graphics.DrawString(rowNumber, dg.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2))

    End Sub

    Private Sub Dgv_Completed_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles Dgv_Completed.RowPostPaint
        Dim dg As DataGridView = DirectCast(sender, DataGridView)
        ' Current row record
        Dim rowNumber As String = (e.RowIndex + 1).ToString()

        ' Format row based on number of records displayed by using leading zeros
        While rowNumber.Length < dg.RowCount.ToString().Length
            rowNumber = "0" & rowNumber
        End While

        ' Position text
        Dim size As SizeF = e.Graphics.MeasureString(rowNumber, Me.Font)
        If dg.RowHeadersWidth < CInt(size.Width + 20) Then
            dg.RowHeadersWidth = CInt(size.Width + 20)
        End If

        ' Use default system text brush
        Dim b As Brush = SystemBrushes.ControlText

        ' Draw row number
        e.Graphics.DrawString(rowNumber, dg.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2))

    End Sub

    Private Sub Dgv_Preorder_ColumnHeaderMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles Dgv_Preorder.ColumnHeaderMouseDoubleClick

        For i = 0 To Dgv_Preorder.Rows.Count - 2
            Dgv_Preorder(0, i).Value = True
        Next
    End Sub

    Private Sub Dgv_Order_ColumnHeaderMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles Dgv_Order.ColumnHeaderMouseDoubleClick
        For i = 0 To Dgv_Order.Rows.Count - 2
            Dgv_Order(0, i).Value = True
        Next
    End Sub

End Class
