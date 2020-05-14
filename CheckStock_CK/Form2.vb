Imports MySql.Data.MySqlClient

Public Class Form2
    Dim MysqlConn As MySqlConnection
    Dim Cs As String = "Database=test_db;Server=localhost;User id=test1;Password=test1234"
    Dim Ds As DataSet = New DataSet
    Dim Da As MySqlDataAdapter = New MySqlDataAdapter()
    Private bs As New BindingSource()

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MysqlConn = New MySqlConnection(Cs)
        MysqlConn.Open()
        ' ------------------------------ Section AutoComplete -----------------------------------
        Dim stm As String = "select Name1 from item"
        Dim cmd As MySqlCommand = New MySqlCommand(stm, MysqlConn)
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        Dim autocomp As New AutoCompleteStringCollection()
        While reader.Read()
            autocomp.Add(reader(0))
        End While
        reader.Close()
        tb_Itemdesc.AutoCompleteMode = AutoCompleteMode.Suggest
        tb_Itemdesc.AutoCompleteSource = AutoCompleteSource.CustomSource
        tb_Itemdesc.AutoCompleteCustomSource = autocomp
        '-------------------------------- Section DropDown List ----------------------------------
        'MessageBox.Show("Connection to Database has been opened.")
        Dim stm1 As String = "select VenderNo,VenderDesc from vender"
        Dim cmd1 As MySqlCommand = New MySqlCommand(stm1, MysqlConn)
        Dim reader1 As MySqlDataReader = cmd1.ExecuteReader()
        Dim dt1 As DataTable = New DataTable
        dt1.Load(reader1)
        cb_vender.ValueMember = "VenderNo"
        cb_vender.DisplayMember = "VenderDesc"
        cb_vender.DataSource = dt1
        cb_vender.SelectedValue = Form1.ComboBox1.SelectedValue
        reader1.Close()
        'MysqlConn.Close()

    End Sub

    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        MysqlConn.Close()
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
        'MysqlConn.Dispose()
        Form1.Button1.PerformClick()
        'MessageBox.Show("Insert Completed !!")
    End Sub

    Private Sub Fill_item()
        MysqlConn = New MySqlConnection(Cs)
        MysqlConn.Open()
        'MessageBox.Show(tb_Itemdesc.Text)
        Dim stm2 As String = "select Code,Name1 from item where Name1 = @ItemDesc"
        Dim cmd2 As MySqlCommand = New MySqlCommand(stm2, MysqlConn)
        cmd2.Parameters.Add("@ItemDesc", MySqlDbType.VarChar, 100).Value = tb_Itemdesc.Text
        Da.SelectCommand = cmd2
        Ds.Clear()
        Da.Fill(Ds, "Items")
        bs = New BindingSource()
        bs.DataSource = Ds.Tables("Items")
        tb_Itemdesc.DataBindings.Clear()
        tb_ItemNo.DataBindings.Clear()
        tb_Itemdesc.DataBindings.Add("text", bs, "Name1")
        tb_ItemNo.DataBindings.Add("text", bs, "Code")
        'MessageBox.Show(tb_ItemNo.Text & " : " & tb_Itemdesc.Text & " : " & cb_vender.SelectedValue & " : " & tb_Qty.Text)
        MysqlConn.Close()
    End Sub

    Private Sub Bt_in_part_F2_Click(sender As Object, e As EventArgs) Handles bt_in_part_F2.Click
        Fill_item()
        If tb_ItemNo.Text <> "" And tb_Itemdesc.Text <> "" And cb_vender.SelectedValue <> "" And tb_Qty.Text <> "" Then
            Insert_Item(tb_ItemNo.Text, tb_Itemdesc.Text, cb_vender.SelectedValue, tb_Qty.Text)
        Else
            MessageBox.Show("Same Data is Missing !!")
        End If
    End Sub

    Private Sub Tb_Itemdesc_ModifiedChanged(sender As Object, e As EventArgs) Handles tb_Itemdesc.ModifiedChanged
        Fill_item()
    End Sub

    Private Sub Tb_Qty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_Qty.KeyPress
        Form1.CheckNumber(sender, e)
    End Sub

    Private Sub Tb_Qty_KeyDown(sender As Object, e As KeyEventArgs) Handles tb_Qty.KeyDown
        If e.KeyData = Keys.F12 Then
            'MessageBox.Show("F10")
            Bt_in_part_F2_Click(sender, e)
        End If
    End Sub

    Private Sub Tb_Itemdesc_KeyDown(sender As Object, e As KeyEventArgs) Handles tb_Itemdesc.KeyDown
        If e.KeyCode = Keys.Enter Then
            'MessageBox.Show("Enter")
            Fill_item()
        ElseIf e.KeyData = Keys.F12 Then
            'MessageBox.Show("F10")
            Bt_in_part_F2_Click(sender, e)
        End If
    End Sub

End Class