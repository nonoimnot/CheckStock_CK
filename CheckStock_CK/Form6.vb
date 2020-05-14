Imports MySql.Data.MySqlClient

Public Class Form6
    Dim MysqlConn As MySqlConnection
    Dim Cs As String = "Database=test_db;Server=localhost;User id=test1;Password=test1234"
    Dim Ds As DataSet = New DataSet
    Dim Da As MySqlDataAdapter = New MySqlDataAdapter()


    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MessageBox.Show("Array is >> " & Form1.Item_array.Count.ToString & " Rows")
        Dim ItmCode_Array() As Object = Form1.Item_array.ToArray()
        Dim r As String = "'" & String.Join("', '", ItmCode_Array) & "'"
        'MessageBox.Show(r)
        '--------------------------------------------------------------------------------------------------------------
        MysqlConn = New MySqlConnection(Cs)
        MysqlConn.Open()
        'MessageBox.Show("Connection to Database has been opened.")
        '--------------------- Section Show DataGridView PreOrder Spare Parts ----------------------------
        Dim stm As String = "select orderno,itemcode,itemdesc,vender.VenderDesc,OrderStatusNo,DocDate " &
                            "from order_spare_parts inner join vender on order_spare_parts.VenderNo = vender.VenderNo " &
                            "where itemcode in (" & r & ")"

        Dim cmd As MySqlCommand = New MySqlCommand(stm, MysqlConn)

        Da.SelectCommand = cmd
        Ds.Clear()
        Da.Fill(Ds, "Redundance_Item")
        Dgv_Redundance.DataSource = Ds.Tables("Redundance_Item")
        MysqlConn.Close()
        Prepare_DataGrid_ReDun()
        Show_Row_No()
    End Sub

    Private Sub Prepare_DataGrid_ReDun()
        With Dgv_Redundance
            .Columns(0).HeaderText = "##"
            .Columns(1).HeaderText = "หมายเลข"
            .Columns(2).HeaderText = "รายการสินค้า"
            .Columns(3).HeaderText = "ร้านค้า"
            .Columns(4).HeaderText = "สถานะ"
            .Columns(5).HeaderText = "วันที่"
            .Columns(0).Width = 50
            .Columns(1).Width = 80
            .Columns(2).Width = 320
            .Columns(3).Width = 80
            .Columns(4).Width = 50
            .Columns(5).Width = 100
            .RowsDefaultCellStyle.BackColor = Color.White
            .AlternatingRowsDefaultCellStyle.BackColor = Color.PowderBlue
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
            .ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray
            .RowHeadersDefaultCellStyle.BackColor = Color.LightGray
        End With
    End Sub

    Private Sub Show_Row_No()
        ' -------------------------- Section Show Row no in All Table --------------------------------- '
        Dim rowno_csck As Short = Dgv_Redundance.Rows.Count - 1
        Lb_Row_Redundance.Text = rowno_csck.ToString & " Rows"

    End Sub
End Class