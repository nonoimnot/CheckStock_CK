Imports MySql.Data.MySqlClient

Public Class Form4
    Dim MysqlConn As MySqlConnection
    Dim Cs As String = "Database=test_db;Server=localhost;User id=test1;Password=test1234"
    Dim Ds As DataSet = New DataSet
    Dim Da As MySqlDataAdapter = New MySqlDataAdapter()
    Private bs As New BindingSource()
    Public Max_id As Integer

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub Data_fill(ItemNo As String)
        MysqlConn = New MySqlConnection(Cs)
        MysqlConn.Open()
        'MessageBox.Show("Connection to Database has been opened.")
        Dim stm As String = "Select Code,name1,item_group.GroupID from item left join item_group " &
                            "on item.code = item_group.ItemCode where Code = @ItemNo"
        Dim cmd As MySqlCommand = New MySqlCommand(stm, MysqlConn)
        cmd.Parameters.Add("@ItemNo", MySqlDbType.VarChar, 20).Value = ItemNo
        Da.SelectCommand = cmd
        Ds.Clear()
        Da.Fill(Ds, "Items")
        bs = New BindingSource()
        bs.DataSource = Ds.Tables("Items")
        Tb_ItemCode.DataBindings.Clear()
        Tb_ItemDesc.DataBindings.Clear()
        Tb_GroupID.DataBindings.Clear()
        Tb_ItemCode.DataBindings.Add("text", bs, "code")
        Tb_ItemDesc.DataBindings.Add("text", bs, "name1")
        Tb_GroupID.DataBindings.Add("text", bs, "GroupID")

        If Tb_GroupID.Text <> "" Then
            Dim stm1 As String = "select ItemCode,ItemDesc,GroupID,Item.Qty from Item_group inner join item " &
                                "on Item_group.ItemCode = item.Code where groupId = @GroupID and ItemCode <> @ItemCode"
            Dim cmd1 As MySqlCommand = New MySqlCommand(stm1, MysqlConn)
            cmd1.Parameters.Add("@GroupID", MySqlDbType.Int16).Value = Tb_GroupID.Text
            cmd1.Parameters.Add("@ItemCode", MySqlDbType.VarChar, 20).Value = Tb_ItemCode.Text
            Da.SelectCommand = cmd1
            Da.Fill(Ds, "ItemsGroup")
            Dgv_ItemGroup.DataSource = Ds.Tables("ItemsGroup")
            Prepare_DataGrid_ItemGroup()
            Max_id = CInt(Tb_GroupID.Text)
            'MessageBox.Show(Max_id.ToString)
        Else
            Max_id = Max_GroupID()
            'MessageBox.Show(Max_id.ToString)
        End If

        MysqlConn.Close()
        If Tb_GroupID.Text = "" Then
            MessageBox.Show("สินค้าไม่มีกลุ่ม ต้องจัดกลุ่มก่อน นะครับ")
            'Data_add()
        End If
    End Sub

    Private Sub Prepare_DataGrid_ItemGroup()
        With Dgv_ItemGroup
            .Columns.Item(0).ReadOnly = False
            .Columns.Item(1).ReadOnly = True
            .Columns.Item(2).ReadOnly = True
            .Columns.Item(3).ReadOnly = True
            .Columns.Item(3).ReadOnly = True
            .Columns(3).Visible = False
            .Columns(0).HeaderText = "##"
            .Columns(1).HeaderText = "หมายเลข"
            .Columns(2).HeaderText = "รายการสินค้า"
            .Columns(3).HeaderText = "เลขกลุ่ม"
            .Columns(4).HeaderText = "คงเหลือ"
            .Columns(0).Width = 30
            .Columns(1).Width = 80
            .Columns(2).Width = 320
            .Columns(3).Width = 80
            .Columns(4).Width = 80
            .RowsDefaultCellStyle.BackColor = Color.White
            .AlternatingRowsDefaultCellStyle.BackColor = Color.PowderBlue
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
            .ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray
            .RowHeadersDefaultCellStyle.BackColor = Color.LightGray
        End With
    End Sub

    Public Function Max_GroupID() As Integer
        MysqlConn = New MySqlConnection(Cs)
        MysqlConn.Open()
        'MessageBox.Show("Connection to Database has been opened.")
        Dim stm As String = "Select max(GroupId) from Item_group"
        Dim cmd As MySqlCommand = New MySqlCommand(stm, MysqlConn)
        Dim Max_GpId As Integer = cmd.ExecuteScalar()
        'MessageBox.Show(Max_GroupId.ToString)
        Return Max_GpId + 1
        MysqlConn.Close()
    End Function

    Private Sub Bt_Add_Group_Click(sender As Object, e As EventArgs) Handles Bt_Add_Group.Click
        If Tb_GroupID.Text = "" Then
            Insert_Item(Tb_ItemCode.Text, Tb_ItemDesc.Text, Max_id)
        End If
        Form5.Show()
    End Sub

    Public Sub Insert_Item(ItemNo As String, ItemDesc As String, Group As Int16)
        MysqlConn = New MySqlConnection(Cs)
        MysqlConn.Open()
        'MessageBox.Show("Connection to Database has been opened.")
        Dim stm As String = "insert into Item_Group(ItemCode, ItemDesc, GroupID) " &
                            "values(@ItemNo,@ItemDesc,@Group)"
        Dim cmd As MySqlCommand = New MySqlCommand(stm, MysqlConn)
        cmd.Parameters.Add("@ItemNo", MySqlDbType.VarChar, 20).Value = ItemNo
        cmd.Parameters.Add("@ItemDesc", MySqlDbType.VarChar, 250).Value = ItemDesc
        cmd.Parameters.Add("@Group", MySqlDbType.Int16).Value = Group

        cmd.ExecuteNonQuery()
        MysqlConn.Close()
    End Sub

    Private Sub Bt_Del_Group_Click(sender As Object, e As EventArgs) Handles Bt_Del_Group.Click
        Dim chk As Boolean
        For i = Dgv_ItemGroup.Rows.Count - 2 To 0 Step -1
            chk = Dgv_ItemGroup(0, i).Value
            'MessageBox.Show(chk.ToString)
            If chk = True Then
                'Form4.Insert_Item(Dgv_AddGroup(1, i).Value, Dgv_AddGroup(2, i).Value, Form4.Max_id)
                Delete_Item(Dgv_ItemGroup(1, i).Value, Max_id)
                MessageBox.Show(Dgv_ItemGroup(1, i).Value & " : " & Max_id.ToString)
            End If
        Next
        Data_fill(Tb_ItemCode.Text)
    End Sub

    Public Sub Delete_Item(ItemNo As String, Group As Int16)
        MysqlConn = New MySqlConnection(Cs)
        MysqlConn.Open()
        'MessageBox.Show("Connection to Database has been opened.")
        Dim stm As String = "Delete from Item_Group where ItemCode = @ItemCode and GroupID = @Group"
        Dim cmd As MySqlCommand = New MySqlCommand(stm, MysqlConn)
        cmd.Parameters.Add("@ItemCode", MySqlDbType.VarChar, 20).Value = ItemNo
        cmd.Parameters.Add("@Group", MySqlDbType.Int16).Value = Group

        cmd.ExecuteNonQuery()
        MysqlConn.Close()
    End Sub

End Class