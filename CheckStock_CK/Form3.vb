Imports MySql.Data.MySqlClient

Public Class Form3
    Dim MysqlConn As MySqlConnection
    Dim Cs As String = "Database=test_db;Server=localhost;User id=test1;Password=test1234"
    Dim Ds As DataSet = New DataSet
    Dim Da As MySqlDataAdapter = New MySqlDataAdapter()
    Dim Ven_Dict As New Dictionary(Of String, String)
    Dim Ven_array As New ArrayList
    Public Item_no As String
    Public Vender_Select_Mode As Boolean = False

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cb_Mode.Items.Add("Auto 1")
        Cb_Mode.Items.Add("Auto 1-1")
        Cb_Mode.Items.Add("Auto 2")
        Cb_Mode.Items.Add("Auto 2-1")
        Cb_Mode.Items.Add("Manual")
        Cb_Mode.Items.Add("Manual-1")

        Cb_Mode.SelectedItem = "Auto 1"
        MysqlConn = New MySqlConnection(Cs)
        MysqlConn.Open()
        'MessageBox.Show("Connection to Database has been opened.")
        Dim stm As String = "select VenderNo,VenderDesc from vender"
        Dim cmd As MySqlCommand = New MySqlCommand(stm, MysqlConn)
        Dim reader As MySqlDataReader = cmd.ExecuteReader()
        Dim dt As DataTable = New DataTable
        'Dim listrow As Short = 0
        dt.Load(reader)
        Cb_Vender.ValueMember = "VenderNo"
        Cb_Vender.DisplayMember = "VenderDesc"
        Cb_Vender.DataSource = dt
        Ven_array.Add("")
        For i = 0 To dt.Rows.Count - 1
            Ven_Dict.Add(dt.Rows(i)("VenderDesc"), dt.Rows(i)("VenderNo"))
            Ven_array.Add(dt.Rows(i)("VenderDesc"))
            'MessageBox.Show(dt.Rows(i)("itemcode").ToString & " : " & dt.Rows(i)("itemdesc").ToString)
        Next
        reader.Close()

        '--------------------- Section Show DataGridView CheckStock Spare Parts ----------------------------
        Dim stm1 As String = "select ItemCode,ItemDesc,w1_qty,w2_qty,w3_qty,stockqty,'0' as Qty from cstock_1 
                    union
                    select ItemCode,ItemDesc,w1_qty,w2_qty,w3_qty,stockqty,'0' as Qty from cstock_2 
                    union
                    select ItemCode,ItemDesc,w1_qty,w2_qty,w3_qty,stockqty,'0' as Qty from cstock_3 order by itemdesc"
        Dim cmd1 As MySqlCommand = New MySqlCommand(stm1, MysqlConn)
        Da.SelectCommand = cmd1
        Ds.Clear()
        Da.Fill(Ds, "CheckStock")
        Dgv_CheckStock.DataSource = Ds.Tables("CheckStock")
        MysqlConn.Close()
        Dgv_CheckStock1.Visible = False
        Dgv_CheckStock.Visible = True
        Prepare_DataGrid1()
        Show_Row_No()
    End Sub

    Private Sub Insert_Item(ItemNo As String, ItemDesc As String, VenderNo As String, OrQty As Int16)
        MysqlConn = New MySqlConnection(Cs)
        MysqlConn.Open()
        'MessageBox.Show("Connection to Database has been opened.")
        Dim stm As String = "insert into order_spare_parts(ItemCode,ItemDesc,VenderNo,OrderStatusNo,OrQty,DocDate) " &
                            "values(@ItemNo,@ItemDesc,@VenderNo,'01',@OrQty, now())"
        Dim cmd As MySqlCommand = New MySqlCommand(stm, MysqlConn)
        cmd.Parameters.Add("@ItemNo", MySqlDbType.VarChar, 20).Value = ItemNo
        cmd.Parameters.Add("@ItemDesc", MySqlDbType.VarChar, 250).Value = ItemDesc
        cmd.Parameters.Add("@VenderNo", MySqlDbType.VarChar, 20).Value = VenderNo
        cmd.Parameters.Add("@OrQty", MySqlDbType.Int16).Value = OrQty
        cmd.ExecuteNonQuery()
        MysqlConn.Close()
    End Sub

    Private Sub Insert_OrderAI(ItemNo As String, W1_Qty As Int16, W2_Qty As Int16, W3_Qty As Int16, stockqty As Int16, VenderNo As String, OrQty As Int16)
        MysqlConn = New MySqlConnection(Cs)
        MysqlConn.Open()
        'MessageBox.Show("Connection to Database has been opened.")
        Dim stm As String = "insert into orderai(ItemCode,w1_qty,w2_qty,w3_qty,stockqty,VenderNo,OrQty) " &
                            "values(@ItemNo,@W1_Qty,@W2_Qty,@W3_Qty,@stockqty,@VenderNo,@OrQty)"
        Dim cmd As MySqlCommand = New MySqlCommand(stm, MysqlConn)
        cmd.Parameters.Add("@ItemNo", MySqlDbType.VarChar, 20).Value = ItemNo
        cmd.Parameters.Add("@W1_Qty", MySqlDbType.Int16).Value = W1_Qty
        cmd.Parameters.Add("@W2_Qty", MySqlDbType.Int16).Value = W2_Qty
        cmd.Parameters.Add("@W3_Qty", MySqlDbType.Int16).Value = W3_Qty
        cmd.Parameters.Add("@stockqty", MySqlDbType.Int16).Value = stockqty
        cmd.Parameters.Add("@VenderNo", MySqlDbType.VarChar, 20).Value = VenderNo
        cmd.Parameters.Add("@OrQty", MySqlDbType.Int16).Value = OrQty
        cmd.ExecuteNonQuery()
        MysqlConn.Close()
    End Sub


    Private Sub Prepare_DataGrid1()
        Dgv_CheckStock.Columns.Item(0).ReadOnly = False
        Dgv_CheckStock.Columns.Item(1).ReadOnly = False
        Dgv_CheckStock.Columns.Item(2).ReadOnly = True
        Dgv_CheckStock.Columns.Item(3).ReadOnly = True
        Dgv_CheckStock.Columns.Item(4).ReadOnly = True
        Dgv_CheckStock.Columns.Item(5).ReadOnly = True
        Dgv_CheckStock.Columns.Item(6).ReadOnly = True
        Dgv_CheckStock.Columns.Item(7).ReadOnly = True
        Dgv_CheckStock.Columns.Item(8).ReadOnly = False
        Dgv_CheckStock.Columns(0).HeaderText = "#"
        Dgv_CheckStock.Columns(1).HeaderText = "ร้านค้า"
        Dgv_CheckStock.Columns(2).HeaderText = "หมายเลข"
        Dgv_CheckStock.Columns(3).HeaderText = "รายการสินค้า"
        Dgv_CheckStock.Columns(4).HeaderText = "< 1 >"
        Dgv_CheckStock.Columns(5).HeaderText = "< 2 >"
        Dgv_CheckStock.Columns(6).HeaderText = "< 3 >"
        Dgv_CheckStock.Columns(7).HeaderText = "คงเหลือ"
        Dgv_CheckStock.Columns(8).HeaderText = "สั่งซื้อ"
        Dgv_CheckStock.Columns(0).Visible = True
        Dgv_CheckStock.Columns(1).Visible = False
        Dgv_CheckStock.Columns(0).Width = 45
        Dgv_CheckStock.Columns(2).Width = 100
        Dgv_CheckStock.Columns(3).Width = 410
        Dgv_CheckStock.Columns(4).Width = 75
        Dgv_CheckStock.Columns(5).Width = 75
        Dgv_CheckStock.Columns(6).Width = 75
        Dgv_CheckStock.Columns(7).Width = 75
        Dgv_CheckStock.Columns(8).Width = 80
        Dgv_CheckStock.Columns(0).DisplayIndex = 6
        Dgv_CheckStock.Columns(1).DisplayIndex = 7
        Dgv_CheckStock.Columns(2).DisplayIndex = 0
        Dgv_CheckStock.Columns(3).DisplayIndex = 1
        Dgv_CheckStock.Columns(4).DisplayIndex = 2
        Dgv_CheckStock.Columns(5).DisplayIndex = 3
        Dgv_CheckStock.Columns(6).DisplayIndex = 4
        Dgv_CheckStock.Columns(7).DisplayIndex = 5
        Dgv_CheckStock.RowsDefaultCellStyle.BackColor = Color.White
        Dgv_CheckStock.AlternatingRowsDefaultCellStyle.BackColor = Color.PowderBlue
        Dgv_CheckStock.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
        Dgv_CheckStock.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray
        Dgv_CheckStock.RowHeadersDefaultCellStyle.BackColor = Color.LightGray
    End Sub

    Private Sub Prepare_DataGrid2()
        Dgv_CheckStock.Columns.Item(0).ReadOnly = False
        Dgv_CheckStock.Columns.Item(1).ReadOnly = False
        Dgv_CheckStock.Columns.Item(2).ReadOnly = True
        Dgv_CheckStock.Columns.Item(3).ReadOnly = True
        Dgv_CheckStock.Columns.Item(4).ReadOnly = True
        Dgv_CheckStock.Columns.Item(5).ReadOnly = True
        Dgv_CheckStock.Columns.Item(6).ReadOnly = True
        Dgv_CheckStock.Columns.Item(7).ReadOnly = True
        Dgv_CheckStock.Columns.Item(8).ReadOnly = False
        Dgv_CheckStock.Columns(0).Visible = False
        Dgv_CheckStock.Columns(1).Visible = True
        Dgv_CheckStock.Columns(0).HeaderText = "#"
        Dgv_CheckStock.Columns(1).HeaderText = "ร้านค้า"
        Dgv_CheckStock.Columns(2).HeaderText = "หมายเลข"
        Dgv_CheckStock.Columns(3).HeaderText = "รายการสินค้า"
        Dgv_CheckStock.Columns(4).HeaderText = "< 1 >"
        Dgv_CheckStock.Columns(5).HeaderText = "< 2 >"
        Dgv_CheckStock.Columns(6).HeaderText = "< 3 >"
        Dgv_CheckStock.Columns(7).HeaderText = "คงเหลือ"
        Dgv_CheckStock.Columns(8).HeaderText = "สั่งซื้อ"
        Dgv_CheckStock.Columns(0).Width = 30
        Dgv_CheckStock.Columns(1).Width = 90
        Dgv_CheckStock.Columns(2).Width = 90
        Dgv_CheckStock.Columns(3).Width = 400
        Dgv_CheckStock.Columns(4).Width = 70
        Dgv_CheckStock.Columns(5).Width = 70
        Dgv_CheckStock.Columns(6).Width = 70
        Dgv_CheckStock.Columns(7).Width = 70
        Dgv_CheckStock.Columns(8).Width = 80
        Dgv_CheckStock.Columns(0).DisplayIndex = 6
        Dgv_CheckStock.Columns(1).DisplayIndex = 7
        Dgv_CheckStock.Columns(2).DisplayIndex = 0
        Dgv_CheckStock.Columns(3).DisplayIndex = 1
        Dgv_CheckStock.Columns(4).DisplayIndex = 2
        Dgv_CheckStock.Columns(5).DisplayIndex = 3
        Dgv_CheckStock.Columns(6).DisplayIndex = 4
        Dgv_CheckStock.Columns(7).DisplayIndex = 5
        Dgv_CheckStock.RowsDefaultCellStyle.BackColor = Color.White
        Dgv_CheckStock.AlternatingRowsDefaultCellStyle.BackColor = Color.PowderBlue
        Dgv_CheckStock.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
        Dgv_CheckStock.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray
        Dgv_CheckStock.RowHeadersDefaultCellStyle.BackColor = Color.LightGray
    End Sub

    Private Sub Prepare_DataGrid3()
        Dgv_CheckStock1.Columns.Item(0).ReadOnly = False
        Dgv_CheckStock1.Columns.Item(1).ReadOnly = False
        Dgv_CheckStock1.Columns.Item(2).ReadOnly = True
        Dgv_CheckStock1.Columns.Item(3).ReadOnly = True
        Dgv_CheckStock1.Columns.Item(4).ReadOnly = True
        Dgv_CheckStock1.Columns.Item(5).ReadOnly = False
        Dgv_CheckStock1.Columns(0).Visible = False
        Dgv_CheckStock1.Columns(1).Visible = True
        Dgv_CheckStock1.Columns(0).HeaderText = "#"
        Dgv_CheckStock1.Columns(1).HeaderText = "ร้านค้า"
        Dgv_CheckStock1.Columns(2).HeaderText = "หมายเลข"
        Dgv_CheckStock1.Columns(3).HeaderText = "รายการสินค้า"
        Dgv_CheckStock1.Columns(4).HeaderText = "คงเหลือ"
        Dgv_CheckStock1.Columns(5).HeaderText = "สั่งซื้อ"
        Dgv_CheckStock1.Columns(0).Width = 30
        Dgv_CheckStock1.Columns(1).Width = 90
        Dgv_CheckStock1.Columns(2).Width = 90
        Dgv_CheckStock1.Columns(3).Width = 400
        Dgv_CheckStock1.Columns(4).Width = 70
        Dgv_CheckStock1.Columns(5).Width = 70
        Dgv_CheckStock1.Columns(0).DisplayIndex = 4
        Dgv_CheckStock1.Columns(1).DisplayIndex = 5
        Dgv_CheckStock1.Columns(2).DisplayIndex = 0
        Dgv_CheckStock1.Columns(3).DisplayIndex = 1
        Dgv_CheckStock1.Columns(4).DisplayIndex = 2
        Dgv_CheckStock1.Columns(5).DisplayIndex = 3
        Dgv_CheckStock1.RowsDefaultCellStyle.BackColor = Color.White
        Dgv_CheckStock1.AlternatingRowsDefaultCellStyle.BackColor = Color.PowderBlue
        Dgv_CheckStock1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
        Dgv_CheckStock1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray
        Dgv_CheckStock1.RowHeadersDefaultCellStyle.BackColor = Color.LightGray
    End Sub

    Private Sub Show_Row_No()
        ' -------------------------- Section Show Row no in All Table --------------------------------- '
        Dim rowno_csck As Short = Dgv_CheckStock.Rows.Count - 1
        Lb_Row_CS.Text = rowno_csck.ToString & " Rows"
        Dim rowno_csck1 As Short = Dgv_CheckStock1.Rows.Count - 1
        Lb_Row_Cs1.Text = rowno_csck1.ToString("###,###") & " Rows"
    End Sub

    Private Sub Combo_Vender_Set()
        cobo_vender.Items.Clear()
        For i = 0 To Ven_array.Count - 1
            cobo_vender.Items.Add(Ven_array(i))
            'MessageBox.Show(Ven_array.Item(i))
        Next
    End Sub

    Private Sub Combo_Vender1_Set()
        cb_dgv_vender1.Items.Clear()
        For i = 0 To Ven_array.Count - 1
            cb_dgv_vender1.Items.Add(Ven_array(i))
        Next
    End Sub


    Private Sub Select_Data1()
        MysqlConn = New MySqlConnection(Cs)
        MysqlConn.Open()
        'MessageBox.Show("Connection to Database has been opened.")
        '--------------------- Section Show DataGridView PreOrder Spare Parts ----------------------------
        Dim stm As String = "select ItemCode,ItemDesc,w1_qty,w2_qty,w3_qty,stockqty,'0' as Qty from checkstock_1 " &
                            "where w1_qty + w2_qty + w3_qty >= stockqty - @offValue and itemdesc like @ItemDesc Union " &
                            "select ItemCode,ItemDesc,w1_qty,w2_qty,w3_qty,stockqty,'0' as Qty from checkstock_2 " &
                            "where w1_qty + w2_qty + w3_qty >= stockqty - @offValue and itemdesc like @ItemDesc Union " &
                            "select ItemCode,ItemDesc,w1_qty,w2_qty,w3_qty,stockqty,'0' as Qty from checkstock_3 " &
                            "where w1_qty + w2_qty + w3_qty >= stockqty - @offValue and itemdesc like @ItemDesc " &
                            "order by ItemDesc"

        Dim cmd As MySqlCommand = New MySqlCommand(stm, MysqlConn)

        cmd.Parameters.Add("@offvalue", MySqlDbType.Int16).Value = Nd_Offset.Value
        cmd.Parameters.Add("@ItemDesc", MySqlDbType.VarChar, 250).Value = tb_search.Text
        Da.SelectCommand = cmd
        Ds.Clear()
        Da.Fill(Ds, "CheckStock")
        Dgv_CheckStock.DataSource = Ds.Tables("CheckStock")
        Dgv_CheckStock1.Visible = False
        Dgv_CheckStock.Visible = True

        Lb_Row_CS.Visible = True
        Lb_Row_Cs1.Visible = False
    End Sub
    Private Sub Select_Data1_1()
        MysqlConn = New MySqlConnection(Cs)
        MysqlConn.Open()
        'MessageBox.Show("Connection to Database has been opened.")
        '--------------------- Section Show DataGridView PreOrder Spare Parts ----------------------------
        Dim sql1 As String = "select ItemCode,ItemDesc,w1_qty,w2_qty,w3_qty,stockqty,'0' as Qty from checkstock_1 " &
                            "where w1_qty + w2_qty + w3_qty >= stockqty - @offValue and itemdesc like @ItemDesc " &
                            "and Itemcode not in (select ItemCode from order_spare_parts where OrderStatusNo = '01' or OrderStatusNo = '02')"

        Dim sql2 As String = "select ItemCode,ItemDesc,w1_qty,w2_qty,w3_qty,stockqty,'0' as Qty from checkstock_2 " &
                            "where w1_qty + w2_qty + w3_qty >= stockqty - @offValue and itemdesc like @ItemDesc " &
                            "and Itemcode not in (select ItemCode from order_spare_parts where OrderStatusNo = '01' or OrderStatusNo = '02')"

        Dim sql3 As String = "select ItemCode,ItemDesc,w1_qty,w2_qty,w3_qty,stockqty,'0' as Qty from checkstock_3 " &
                            "where w1_qty + w2_qty + w3_qty >= stockqty - @offValue and itemdesc like @ItemDesc " &
                            "and Itemcode not in (select ItemCode from order_spare_parts where OrderStatusNo = '01' or OrderStatusNo = '02')"

        Dim stm As String = sql1 & " Union " & sql2 & " Union " & sql3 & " order by ItemDesc"

        Dim cmd As MySqlCommand = New MySqlCommand(stm, MysqlConn)

        cmd.Parameters.Add("@offvalue", MySqlDbType.Int16).Value = Nd_Offset.Value
        cmd.Parameters.Add("@ItemDesc", MySqlDbType.VarChar, 250).Value = tb_search.Text
        Da.SelectCommand = cmd
        Ds.Clear()
        Da.Fill(Ds, "CheckStock")
        Dgv_CheckStock.DataSource = Ds.Tables("CheckStock")
        Dgv_CheckStock1.Visible = False
        Dgv_CheckStock.Visible = True

        Lb_Row_CS.Visible = True
        Lb_Row_Cs1.Visible = False
    End Sub

    Private Sub Select_Data2()
        MysqlConn = New MySqlConnection(Cs)
        MysqlConn.Open()
        'MessageBox.Show("Connection to Database has been opened.")
        '--------------------- Section Show DataGridView PreOrder Spare Parts ----------------------------
        Dim stm As String = "Select Code,name1,qty ,'0' as Sale_Qty from Item where name1 like @ItemDesc order by name1"

        Dim cmd As MySqlCommand = New MySqlCommand(stm, MysqlConn)

        cmd.Parameters.Add("@ItemDesc", MySqlDbType.VarChar, 250).Value = tb_search.Text
        Da.SelectCommand = cmd
        Ds.Clear()
        Da.Fill(Ds, "CheckStock3")
        Dgv_CheckStock1.DataSource = Ds.Tables("CheckStock3")
        'Combo_Vender1_Set()
        Dgv_CheckStock1.Visible = True
        Dgv_CheckStock.Visible = False

        Lb_Row_CS.Visible = False
        Lb_Row_Cs1.Visible = True
    End Sub
    Private Sub Select_Data2_1()
        MysqlConn = New MySqlConnection(Cs)
        MysqlConn.Open()
        'MessageBox.Show("Connection to Database has been opened.")
        '--------------------- Section Show DataGridView PreOrder Spare Parts ----------------------------
        Dim stm As String = "Select Code,name1,qty ,'0' as Sale_Qty from Item where name1 like @ItemDesc" &
                            " and Code not in (select ItemCode from order_spare_parts where OrderStatusNo = '01' or OrderStatusNo = '02')" &
                            " order by name1"

        Dim cmd As MySqlCommand = New MySqlCommand(stm, MysqlConn)

        cmd.Parameters.Add("@ItemDesc", MySqlDbType.VarChar, 250).Value = tb_search.Text
        Da.SelectCommand = cmd
        Ds.Clear()
        Da.Fill(Ds, "CheckStock3")
        Dgv_CheckStock1.DataSource = Ds.Tables("CheckStock3")
        'Combo_Vender1_Set()
        Dgv_CheckStock1.Visible = True
        Dgv_CheckStock.Visible = False

        Lb_Row_CS.Visible = False
        Lb_Row_Cs1.Visible = True
    End Sub

    Private Sub Select_Vender_Select(VenderNo As String)
        MysqlConn = New MySqlConnection(Cs)
        MysqlConn.Open()
        'MessageBox.Show("Connection to Database has been opened.")
        '--------------------- Section Show DataGridView PreOrder Spare Parts ----------------------------
        Dim sql1 As String = "select ItemCode,ItemDesc,w1_qty,w2_qty,w3_qty,stockqty,'0' as Qty from salesum_update " &
                            "where (ItemCode in  (SELECT ItemCode FROM test_db.order_spare_parts where VenderNo = @VenderNo group by ItemCode) )" &
                            "and Itemcode not in (select ItemCode from order_spare_parts where OrderStatusNo = '01' or OrderStatusNo = '02')" &
                            "and w1_qty + w2_qty + w3_qty >= stockqty - @offValue"

        Dim sql2 As String = "select code,name1,'0','0','0',qty,'0' as Qty from item " &
                            "where (code in  (SELECT ItemCode FROM test_db.order_spare_parts where VenderNo = @VenderNo group by ItemCode) )" &
                            "and code not in (select ItemCode from order_spare_parts where OrderStatusNo = '01' or OrderStatusNo = '02')" &
                            "and qty < 1"

        Dim stm As String = sql1 & " Union " & sql2 & " order by ItemDesc"

        'MessageBox.Show(stm)

        Dim cmd As MySqlCommand = New MySqlCommand(stm, MysqlConn)

        cmd.Parameters.Add("@offvalue", MySqlDbType.Int16).Value = Nd_Offset.Value
        cmd.Parameters.Add("@VenderNo", MySqlDbType.VarChar, 250).Value = VenderNo
        Da.SelectCommand = cmd
        Ds.Clear()
        Da.Fill(Ds, "CheckStock")
        Dgv_CheckStock.DataSource = Ds.Tables("CheckStock")
        Dgv_CheckStock1.Visible = False
        Dgv_CheckStock.Visible = True

        Lb_Row_CS.Visible = True
        Lb_Row_Cs1.Visible = False
    End Sub
    Private Sub Bt_Fillter_Click(sender As Object, e As EventArgs) Handles Bt_Fillter.Click
        'MessageBox.Show(Cb_Mode.SelectedItem)
        If Cb_Mode.SelectedItem = "Auto 1" Then
            Select_Data1()
            Prepare_DataGrid1()
            Show_Row_No()
            Cb_Vender.Visible = True
        ElseIf Cb_Mode.SelectedItem = "Auto 1-1" Then
            Select_Data1_1()
            Prepare_DataGrid1()
            Show_Row_No()
            Cb_Vender.Visible = True
        ElseIf Cb_Mode.SelectedItem = "Auto 2" Then
            Select_Data1()
            Combo_Vender_Set()
            Prepare_DataGrid2()
            Show_Row_No()
            Cb_Vender.Visible = False
        ElseIf Cb_Mode.SelectedItem = "Auto 2-1" Then
            Select_Data1_1()
            Combo_Vender_Set()
            Prepare_DataGrid2()
            Show_Row_No()
            Cb_Vender.Visible = False
        ElseIf Cb_Mode.SelectedItem = "Manual" Then
            Select_Data2()
            Combo_Vender1_Set()
            Prepare_DataGrid3()
            Show_Row_No()
            Cb_Vender.Visible = False
        ElseIf Cb_Mode.SelectedItem = "Manual-1" Then
            Select_Data2_1()
            Combo_Vender1_Set()
            Prepare_DataGrid3()
            Show_Row_No()
            Cb_Vender.Visible = False
        Else
            'MessageBox.Show("Something Error About Select Mode", "Error Message")
        End If
    End Sub
    Private Sub Tb_search_TextChanged(sender As Object, e As EventArgs) Handles tb_search.TextChanged
        Bt_Fillter_Click(sender, e)
    End Sub

    Private Sub Nd_Offset_KeyDown(sender As Object, e As KeyEventArgs) Handles Nd_Offset.KeyDown
        If e.KeyCode = Keys.Enter Then
            'MessageBox.Show("Enter")
            Bt_Fillter_Click(sender, e)
        End If
    End Sub

    Private Sub Cb_Mode_SelectedValueChanged(sender As Object, e As EventArgs) Handles Cb_Mode.SelectedValueChanged
        Bt_Fillter_Click(sender, e)
    End Sub

    Private Sub Bt_to_Pre_Click(sender As Object, e As EventArgs) Handles Bt_to_Pre.Click
        Dim vQty As Integer
        If Cb_Mode.SelectedItem = "Auto 1" Then
            Dim chk As Boolean
            For i = Dgv_CheckStock.Rows.Count - 2 To 0 Step -1
                chk = Dgv_CheckStock(0, i).Value
                'MessageBox.Show(Dgv_CheckStock(8, i).Value.ToString)
                If IsDBNull(Dgv_CheckStock(8, i).Value) Then
                    vQty = 0
                ElseIf Not IsDBNull(Dgv_CheckStock(8, i).Value) Then
                    vQty = Dgv_CheckStock(8, i).Value
                End If

                If chk = True Then
                    Insert_Item(Dgv_CheckStock(2, i).Value, Dgv_CheckStock(3, i).Value, Cb_Vender.SelectedValue.ToString, vQty)
                    'MessageBox.Show(Dgv_CheckStock(2, i).Value & " : " & Dgv_CheckStock(3, i).Value & " : " & Cb_Vender.SelectedValue.ToString & " : " & vQty.ToString)
                    Insert_OrderAI(Dgv_CheckStock(2, i).Value, Dgv_CheckStock(4, i).Value, Dgv_CheckStock(5, i).Value, Dgv_CheckStock(6, i).Value,
                                   Dgv_CheckStock(7, i).Value, Cb_Vender.SelectedValue.ToString, Dgv_CheckStock(8, i).Value)
                    Dgv_CheckStock.Rows.Remove(Dgv_CheckStock.Rows(i))
                End If
            Next
        ElseIf Cb_Mode.SelectedItem = "Auto 1-1" Then
            Dim chk As Boolean
            For i = Dgv_CheckStock.Rows.Count - 2 To 0 Step -1
                chk = Dgv_CheckStock(0, i).Value
                'MessageBox.Show(Dgv_CheckStock(8, i).Value.ToString)
                If IsDBNull(Dgv_CheckStock(8, i).Value) Then
                    vQty = 0
                ElseIf Not IsDBNull(Dgv_CheckStock(8, i).Value) Then
                    vQty = Dgv_CheckStock(8, i).Value
                End If

                If chk = True Then
                    Insert_Item(Dgv_CheckStock(2, i).Value, Dgv_CheckStock(3, i).Value, Cb_Vender.SelectedValue.ToString, vQty)
                    'MessageBox.Show(Dgv_CheckStock(2, i).Value & " : " & Dgv_CheckStock(3, i).Value & " : " & Cb_Vender.SelectedValue.ToString & " : " & vQty.ToString)
                    Insert_OrderAI(Dgv_CheckStock(2, i).Value, Dgv_CheckStock(4, i).Value, Dgv_CheckStock(5, i).Value, Dgv_CheckStock(6, i).Value,
                                   Dgv_CheckStock(7, i).Value, Cb_Vender.SelectedValue.ToString, Dgv_CheckStock(8, i).Value)
                    Dgv_CheckStock.Rows.Remove(Dgv_CheckStock.Rows(i))
                End If
            Next
        ElseIf Cb_Mode.SelectedItem = "Auto 2" Then
            Dim VenDesc As String
            Dim venNo As String
            For i = Dgv_CheckStock.Rows.Count - 2 To 0 Step -1
                If IsDBNull(Dgv_CheckStock(8, i).Value) Then
                    vQty = 0
                ElseIf Not IsDBNull(Dgv_CheckStock(8, i).Value) Then
                    vQty = Dgv_CheckStock(8, i).Value
                End If
                VenDesc = Dgv_CheckStock(1, i).Value
                If VenDesc <> "" Then
                    venNo = Ven_Dict.Item(VenDesc)
                    Insert_Item(Dgv_CheckStock(2, i).Value, Dgv_CheckStock(3, i).Value, venNo, vQty)
                    'MessageBox.Show(Dgv_CheckStock(2, i).Value & " : " & Dgv_CheckStock(3, i).Value & " : " & VenDesc & " : " & vQty.ToString)
                    Insert_OrderAI(Dgv_CheckStock(2, i).Value, Dgv_CheckStock(4, i).Value, Dgv_CheckStock(5, i).Value, Dgv_CheckStock(6, i).Value,
                                   Dgv_CheckStock(7, i).Value, venNo, Dgv_CheckStock(8, i).Value)
                    Dgv_CheckStock.Rows.Remove(Dgv_CheckStock.Rows(i))
                Else
                    'MessageBox.Show(Dgv_CheckStock(2, i).Value & " : " & Dgv_CheckStock(3, i).Value & " ไม่ได้กรอก Vender นะครับ")
                End If
                'MessageBox.Show(venNo, VenDesc)
            Next
        ElseIf Cb_Mode.SelectedItem = "Auto 2-1" Then
            Dim VenDesc As String
            Dim venNo As String
            For i = Dgv_CheckStock.Rows.Count - 2 To 0 Step -1
                If IsDBNull(Dgv_CheckStock(8, i).Value) Then
                    vQty = 0
                ElseIf Not IsDBNull(Dgv_CheckStock(8, i).Value) Then
                    vQty = Dgv_CheckStock(8, i).Value
                End If
                VenDesc = Dgv_CheckStock(1, i).Value
                If VenDesc <> "" Then
                    venNo = Ven_Dict.Item(VenDesc)
                    Insert_Item(Dgv_CheckStock(2, i).Value, Dgv_CheckStock(3, i).Value, venNo, vQty)
                    'MessageBox.Show(Dgv_CheckStock(2, i).Value & " : " & Dgv_CheckStock(3, i).Value & " : " & VenDesc & " : " & vQty.ToString)
                    Insert_OrderAI(Dgv_CheckStock(2, i).Value, Dgv_CheckStock(4, i).Value, Dgv_CheckStock(5, i).Value, Dgv_CheckStock(6, i).Value,
                                   Dgv_CheckStock(7, i).Value, venNo, Dgv_CheckStock(8, i).Value)
                    Dgv_CheckStock.Rows.Remove(Dgv_CheckStock.Rows(i))
                Else
                    'MessageBox.Show(Dgv_CheckStock(2, i).Value & " : " & Dgv_CheckStock(3, i).Value & " ไม่ได้กรอก Vender นะครับ")
                End If
                'MessageBox.Show(venNo, VenDesc)
            Next
        ElseIf Cb_Mode.SelectedItem = "Manual" Then
            Dim VenDesc As String
            Dim venNo As String
            For i = Dgv_CheckStock1.Rows.Count - 2 To 0 Step -1
                If IsDBNull(Dgv_CheckStock1(5, i).Value) Then
                    vQty = 0
                ElseIf Not IsDBNull(Dgv_CheckStock1(5, i).Value) Then
                    vQty = Dgv_CheckStock1(5, i).Value
                End If
                VenDesc = Dgv_CheckStock1(1, i).Value
                If VenDesc <> "" Then
                    venNo = Ven_Dict.Item(VenDesc)
                    Insert_Item(Dgv_CheckStock1(2, i).Value, Dgv_CheckStock1(3, i).Value, venNo, vQty)
                    'MessageBox.Show(Dgv_CheckStock1(2, i).Value & " : " & Dgv_CheckStock1(3, i).Value & " : " & Dgv_CheckStock1(1, i).Value & " : " & vQty.ToString)
                    Dgv_CheckStock1.Rows.Remove(Dgv_CheckStock1.Rows(i))
                Else
                    'MessageBox.Show(Dgv_CheckStock(2, i).Value & " : " & Dgv_CheckStock(3, i).Value & " ไม่ได้กรอก Vender นะครับ")
                End If
            Next
        ElseIf Cb_Mode.SelectedItem = "Manual-1" Then
            Dim VenDesc As String
            Dim venNo As String
            For i = Dgv_CheckStock1.Rows.Count - 2 To 0 Step -1
                If IsDBNull(Dgv_CheckStock1(5, i).Value) Then
                    vQty = 0
                ElseIf Not IsDBNull(Dgv_CheckStock1(5, i).Value) Then
                    vQty = Dgv_CheckStock1(5, i).Value
                End If
                VenDesc = Dgv_CheckStock1(1, i).Value
                If VenDesc <> "" Then
                    venNo = Ven_Dict.Item(VenDesc)
                    Insert_Item(Dgv_CheckStock1(2, i).Value, Dgv_CheckStock1(3, i).Value, venNo, vQty)
                    'MessageBox.Show(Dgv_CheckStock1(2, i).Value & " : " & Dgv_CheckStock1(3, i).Value & " : " & Dgv_CheckStock1(1, i).Value & " : " & vQty.ToString)
                    Dgv_CheckStock1.Rows.Remove(Dgv_CheckStock1.Rows(i))
                Else
                    'MessageBox.Show(Dgv_CheckStock(2, i).Value & " : " & Dgv_CheckStock(3, i).Value & " ไม่ได้กรอก Vender นะครับ")
                End If
            Next
        Else
            'MessageBox.Show("Something Error About Select Mode", "Error Message")
        End If
        Form1.Button1_Click(sender, e)
    End Sub

    Private Sub Dgv_CheckStock1_RowHeaderMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles Dgv_CheckStock1.RowHeaderMouseDoubleClick
        Item_no = Dgv_CheckStock1.SelectedRows(0).Cells(2).Value.ToString
        Form4.Show()
        Form4.Data_fill(Item_no)
    End Sub

    Private Sub Dgv_CheckStock_RowHeaderMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles Dgv_CheckStock.RowHeaderMouseDoubleClick
        'MessageBox.Show(Dgv_CheckStock.SelectedRows(0).Cells(2).Value.ToString & " : " & Dgv_CheckStock.SelectedRows(0).Cells(3).Value.ToString)
        Item_no = Dgv_CheckStock.SelectedRows(0).Cells(2).Value.ToString
        Form4.Show()
        Form4.Data_fill(Item_no)
    End Sub

    Private Sub Dgv_CheckStock1_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles Dgv_CheckStock1.RowPostPaint
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

    Private Sub Dgv_CheckStock_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles Dgv_CheckStock.RowPostPaint
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

    Friend Sub Load_Combo_Vender_vdmode()
        MysqlConn = New MySqlConnection(Cs)
        MysqlConn.Open()
        'MessageBox.Show("Connection to Database has been opened.")
        Dim stm As String = "select VenderNo,VenderDesc from vender"
        Dim cmd As MySqlCommand = New MySqlCommand(stm, MysqlConn)
        Dim reader As MySqlDataReader = cmd.ExecuteReader()
        Dim dt As DataTable = New DataTable
        'Dim listrow As Short = 0
        dt.Load(reader)
        Cb_vender_vdmode.ValueMember = "VenderNo"
        Cb_vender_vdmode.DisplayMember = "VenderDesc"
        Cb_vender_vdmode.DataSource = dt
        reader.Close()

    End Sub

    Private Sub Bt_ChangeMode_Click(sender As Object, e As EventArgs) Handles Bt_ChangeMode.Click
        If Vender_Select_Mode = False Then
            'Combo_Select_Vender_Set()
            Load_Combo_Vender_vdmode()
            Cb_vender_vdmode.Visible = True
            Bt_Select_Vender.Visible = True
            Bt_ChangeMode.Text = "Vender Select Mode"
            Vender_Select_Mode = True

            Lb_fillter.Visible = False
            tb_search.Visible = False
            Bt_Fillter.Visible = False
            Lb_Mode.Visible = False
            Cb_Mode.Visible = False
        Else
            Cb_vender_vdmode.Visible = False
            Bt_Select_Vender.Visible = False
            Bt_ChangeMode.Text = "Filter Mode"
            Vender_Select_Mode = False

            Lb_fillter.Visible = True
            tb_search.Visible = True
            Bt_Fillter.Visible = True
            Lb_Mode.Visible = True
            Cb_Mode.Visible = True
        End If


    End Sub

    Private Sub Bt_Select_Vender_Click(sender As Object, e As EventArgs) Handles Bt_Select_Vender.Click
        Dim VenderNo As String = Cb_vender_vdmode.SelectedValue
        'MessageBox.Show(VenderNo)
        Select_Vender_Select(VenderNo)
        Prepare_DataGrid1()
        Show_Row_No()
        Cb_Vender.Visible = True
    End Sub
End Class