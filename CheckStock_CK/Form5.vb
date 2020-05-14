Imports MySql.Data.MySqlClient

Public Class Form5
    Dim MysqlConn As MySqlConnection
    Dim Cs As String = "Database=test_db;Server=localhost;User id=test1;Password=test1234"
    Dim Ds As DataSet = New DataSet
    Dim Da As MySqlDataAdapter = New MySqlDataAdapter()

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MysqlConn = New MySqlConnection(Cs)
        MysqlConn.Open()
        'MessageBox.Show("Connection to Database has been opened.")
        '--------------------- Section Show DataGridView PreOrder Spare Parts ----------------------------
        Dim stm As String = "Select Code,name1,qty from Item where name1 like @ItemDesc and Code <> @ItemCode"

        Dim cmd As MySqlCommand = New MySqlCommand(stm, MysqlConn)

        cmd.Parameters.Add("@ItemDesc", MySqlDbType.VarChar, 250).Value = Tb_Add_Group.Text
        cmd.Parameters.Add("@ItemCode", MySqlDbType.VarChar, 20).Value = Form4.Tb_ItemCode.Text
        Da.SelectCommand = cmd
        Ds.Clear()
        Da.Fill(Ds, "Add_GpID")
        Dgv_AddGroup.DataSource = Ds.Tables("Add_GpID")
        MysqlConn.Close()
        Prepare_DataGrid_AddGroupID()
    End Sub

    Private Sub Select_Data()
        MysqlConn = New MySqlConnection(Cs)
        MysqlConn.Open()
        'MessageBox.Show("Connection to Database has been opened.")
        '--------------------- Section Show DataGridView PreOrder Spare Parts ----------------------------
        Dim stm As String = "Select Code,name1,qty from Item where name1 like @ItemDesc and Code <> @ItemCode"

        Dim cmd As MySqlCommand = New MySqlCommand(stm, MysqlConn)

        cmd.Parameters.Add("@ItemDesc", MySqlDbType.VarChar, 250).Value = Tb_Add_Group.Text
        cmd.Parameters.Add("@ItemCode", MySqlDbType.VarChar, 20).Value = Form4.Tb_ItemCode.Text
        Da.SelectCommand = cmd
        Ds.Clear()
        Da.Fill(Ds, "Add_GpID")
        Dgv_AddGroup.DataSource = Ds.Tables("Add_GpID")
        MysqlConn.Close()
    End Sub

    Private Sub Prepare_DataGrid_AddGroupID()
        With Dgv_AddGroup
            .Columns.Item(0).ReadOnly = False
            .Columns.Item(1).ReadOnly = True
            .Columns.Item(2).ReadOnly = True
            .Columns.Item(3).ReadOnly = True
            .Columns(0).HeaderText = "##"
            .Columns(1).HeaderText = "หมายเลข"
            .Columns(2).HeaderText = "รายการสินค้า"
            .Columns(3).HeaderText = "คงเหลือ"
            .Columns(0).Width = 30
            .Columns(1).Width = 80
            .Columns(2).Width = 300
            .Columns(3).Width = 80
            .RowsDefaultCellStyle.BackColor = Color.White
            .AlternatingRowsDefaultCellStyle.BackColor = Color.PowderBlue
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
            .ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray
            .RowHeadersDefaultCellStyle.BackColor = Color.LightGray
        End With
    End Sub

    Private Sub Tb_Add_Group_TextChanged(sender As Object, e As EventArgs) Handles Tb_Add_Group.TextChanged
        Select_Data()
    End Sub

    Private Sub Bt_Add_GpID_Click(sender As Object, e As EventArgs) Handles Bt_Add_GpID.Click
        Dim chk As Boolean
        For i = Dgv_AddGroup.Rows.Count - 2 To 0 Step -1
            chk = Dgv_AddGroup(0, i).Value
            'MessageBox.Show(chk.ToString)

            If chk = True Then
                Form4.Insert_Item(Dgv_AddGroup(1, i).Value, Dgv_AddGroup(2, i).Value, Form4.Max_id)
                MessageBox.Show(Dgv_AddGroup(1, i).Value & " : " & Dgv_AddGroup(2, i).Value & " : " & Form4.Max_id.ToString)
            End If
        Next
        Form4.Data_fill(Form3.Item_no)
        Me.Close()
    End Sub

End Class