Imports System.IO
Imports MySql.Data.MySqlClient

Public Class Form1

    Dim imagePath As String = "C:\Users\ASUS-GK\Documents\Visual Pak Awang\PA\image\"
    Dim OFD As New OpenFileDialog()
    Dim sessionFullName, sessionAddress, sessionPhoneNumber As String
    Dim positionAdmin, positionUser As Button

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        End
    End Sub

    Private Sub btnHomeAdmin_Click(sender As Object, e As EventArgs) Handles btnHomeAdmin.Click
        clearPicture()
        clearCreate()

        positionAdmin = btnHomeAdmin

        pnlOnButtonPositionAdmin.Height = btnHomeAdmin.Height
        pnlOnButtonPositionAdmin.Top = btnHomeAdmin.Top

        pnlHomeAdmin.Visible = True
        pnlManageUserAdmin.Visible = False
        pnlManageMenuAdmin.Visible = False
        pnlFormCreateMenuAdmin.Visible = False
        pnlFormUpdateMenuAdmin.Visible = False
        pnlManageOrderAdmin.Visible = False
        pnlReportAdmin.Visible = False
        pnlManagePaymentAdmin.Visible = False
    End Sub

    Private Sub btnReadUserAdmin_Click(sender As Object, e As EventArgs) Handles btnReadUserAdmin.Click
        clearPicture()
        clearCreate()

        positionAdmin = btnReadUserAdmin

        pnlOnButtonPositionAdmin.Height = btnReadUserAdmin.Height
        pnlOnButtonPositionAdmin.Top = btnReadUserAdmin.Top

        pnlHomeAdmin.Visible = False
        pnlManageUserAdmin.Visible = True
        pnlManageMenuAdmin.Visible = False
        pnlFormCreateMenuAdmin.Visible = False
        pnlFormUpdateMenuAdmin.Visible = False
        pnlManageOrderAdmin.Visible = False
        pnlReportAdmin.Visible = False
        pnlManagePaymentAdmin.Visible = False
    End Sub

    Private Sub btnManageMenuAdmin_Click(sender As Object, e As EventArgs) Handles btnManageMenuAdmin.Click
        clearPicture()
        clearCreate()

        positionAdmin = btnManageMenuAdmin

        pnlOnButtonPositionAdmin.Height = btnManageMenuAdmin.Height
        pnlOnButtonPositionAdmin.Top = btnManageMenuAdmin.Top

        pnlHomeAdmin.Visible = False
        pnlManageUserAdmin.Visible = False
        pnlManageMenuAdmin.Visible = True
        pnlFormCreateMenuAdmin.Visible = False
        pnlFormUpdateMenuAdmin.Visible = False
        pnlManageOrderAdmin.Visible = False
        pnlReportAdmin.Visible = False
        pnlManagePaymentAdmin.Visible = False
    End Sub

    Private Sub btnManageOrderAdmin_Click(sender As Object, e As EventArgs) Handles btnManageOrderAdmin.Click
        clearPicture()
        clearCreate()

        positionAdmin = btnManageOrderAdmin

        pnlOnButtonPositionAdmin.Height = btnManageOrderAdmin.Height
        pnlOnButtonPositionAdmin.Top = btnManageOrderAdmin.Top

        pnlHomeAdmin.Visible = False
        pnlManageUserAdmin.Visible = False
        pnlManageMenuAdmin.Visible = False
        pnlFormCreateMenuAdmin.Visible = False
        pnlFormUpdateMenuAdmin.Visible = False
        pnlManageOrderAdmin.Visible = True
        pnlReportAdmin.Visible = False
        pnlManagePaymentAdmin.Visible = False
    End Sub

    Private Sub btnManagePaymentAdmin_Click(sender As Object, e As EventArgs) Handles btnManagePaymentAdmin.Click
        clearPicture()
        clearCreate()

        positionAdmin = btnManagePaymentAdmin

        pnlOnButtonPositionAdmin.Height = btnManagePaymentAdmin.Height
        pnlOnButtonPositionAdmin.Top = btnManagePaymentAdmin.Top

        pnlHomeAdmin.Visible = False
        pnlManageUserAdmin.Visible = False
        pnlManageMenuAdmin.Visible = False
        pnlFormCreateMenuAdmin.Visible = False
        pnlFormUpdateMenuAdmin.Visible = False
        pnlManageOrderAdmin.Visible = False
        pnlReportAdmin.Visible = False
        pnlManagePaymentAdmin.Visible = True
    End Sub

    Private Sub btnLogoutAdmin_Click(sender As Object, e As EventArgs) Handles btnLogoutAdmin.Click
        pnlOnButtonPositionAdmin.Height = btnLogoutAdmin.Height
        pnlOnButtonPositionAdmin.Top = btnLogoutAdmin.Top

        Dim close As String
        close = MessageBox.Show("Are you sure ?", "CONFIRM", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If close = MsgBoxResult.Yes Then
            pnlLogin.Visible = True
            pnlRegistration.Visible = False

            pnlHomeAdmin.Visible = False
            pnlManageUserAdmin.Visible = False
            pnlManageMenuAdmin.Visible = False
            pnlFormCreateMenuAdmin.Visible = False
            pnlFormUpdateMenuAdmin.Visible = False
            pnlManageOrderAdmin.Visible = False
            pnlReportAdmin.Visible = False
            pnlManagePaymentAdmin.Visible = False

            pnlOnButtonPositionAdmin.Height = btnHomeAdmin.Height
            pnlOnButtonPositionAdmin.Top = btnHomeAdmin.Top
        Else
            pnlOnButtonPositionAdmin.Height = positionAdmin.Height
            pnlOnButtonPositionAdmin.Top = positionAdmin.Top
            positionAdmin.Focus()
            Exit Sub
        End If
    End Sub

    Private Function checkDataLogin()
        If TextBox5.Text = "" Then
            MessageBox.Show("Input cannot be empty", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox5.Focus()
        ElseIf TextBox6.Text = "" Then
            MessageBox.Show("Input cannot be empty", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox6.Focus()
        Else
            Return True
        End If
        Return False
    End Function

    Private Function checkDataRegistration()
        If TextBox7.Text = "" Then
            MessageBox.Show("Input cannot be empty", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox7.Focus()
        ElseIf TextBox8.Text = "" Then
            MessageBox.Show("Input cannot be empty", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox8.Focus()
        ElseIf TextBox9.Text = "" Then
            MessageBox.Show("Input cannot be empty", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox9.Focus()
        ElseIf TextBox11.Text = "" Then
            MessageBox.Show("Input cannot be empty", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox11.Focus()
        ElseIf TextBox12.Text = "" Then
            MessageBox.Show("Input cannot be empty", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox12.Focus()
        ElseIf TextBox17.Text = "" Then
            MessageBox.Show("Input cannot be empty", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox17.Focus()
        Else
            Return True
        End If
        Return False
    End Function

    Private Function checkDataCreate()
        If TextBox1.Text = "" Then
            MessageBox.Show("Input cannot be empty", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox1.Focus()
        ElseIf TextBox2.Text = "" Then
            MessageBox.Show("Input cannot be empty", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox2.Focus()
        ElseIf TextBox3.Text = "" Then
            MessageBox.Show("Input cannot be empty", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox3.Focus()
        ElseIf TextBox4.Text = "" Then
            MessageBox.Show("Input cannot be empty", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Button4.Focus()
        Else
            Return True
        End If
        Return False
    End Function

    Private Function checkDataUpdate()
        If TextBox16.Text = "" Then
            MessageBox.Show("Input cannot be empty", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox16.Focus()
        ElseIf TextBox15.Text = "" Then
            MessageBox.Show("Input cannot be empty", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox15.Focus()
        ElseIf TextBox13.Text = "" Then
            MessageBox.Show("Input cannot be empty", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox13.Focus()
        Else
            Return True
        End If
        Return False
    End Function

    Private Function checkDataOrder()
        If TextBox23.Text = "" Then
            MessageBox.Show("Input cannot be empty", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox23.Focus()
        ElseIf TextBox22.Text = "" Then
            MessageBox.Show("Input cannot be empty", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox22.Focus()
        ElseIf TextBox25.Text = "" Then
            MessageBox.Show("Input cannot be empty", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox25.Focus()
        ElseIf TextBox24.Text = "" Then
            MessageBox.Show("Input cannot be empty", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox24.Focus()
        ElseIf TextBox21.Text = "" Then
            MessageBox.Show("Input cannot be empty", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox21.Focus()
        ElseIf TextBox20.Text = "" Then
            MessageBox.Show("Input cannot be empty", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox20.Focus()
        Else
            Return True
        End If
        Return False
    End Function

    Private Function checkDataPayment()
        If TextBox32.Text = "" Then
            MessageBox.Show("Input cannot be empty", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox32.Focus()
        ElseIf TextBox31.Text = "" Then
            MessageBox.Show("Input cannot be empty", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox31.Focus()
        Else
            Return True
        End If
        Return False
    End Function

    Sub clearLogin()
        TextBox5.Text = ""
        TextBox6.Text = ""
    End Sub

    Sub clearRegistration()
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox11.Text = ""
        TextBox12.Text = ""
        TextBox17.Text = ""
    End Sub

    Sub clearCreate()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub

    Sub clearUpdate()
        TextBox16.Text = ""
        TextBox15.Text = ""
        TextBox14.Text = ""
        TextBox13.Text = ""
        clearPicture()
    End Sub

    Sub clearOrder()
        TextBox23.Text = ""
        TextBox22.Text = ""
        TextBox25.Text = ""
        TextBox24.Text = ""
        TextBox21.Text = ""
        TextBox20.Text = ""
    End Sub

    Sub clearPayment()
        TextBox31.Text = ""
        TextBox32.Text = ""
    End Sub

    Sub clearPicture()
        DataGridView6.ClearSelection()
        DataGridView1.ClearSelection()
        DataGridView2.ClearSelection()
        DataGridView3.ClearSelection()
        DataGridView4.ClearSelection()
        DataGridView7.ClearSelection()
        PictureBox10.Image = Image.FromFile(imagePath & "Resources\blankImage.jpg")
        Label40.Text = "-"
        PictureBox21.Image = Image.FromFile(imagePath & "Resources\blankImage.jpg")
        Label35.Text = "-"
        PictureBox32.Image = Image.FromFile(imagePath & "Resources\blankImagePay.jpg")
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ErrorProvider4.SetError(TextBox2, "Input must be a number!")
            e.Handled = True
        Else
            e.Handled = False
            ErrorProvider4.Clear()
        End If
    End Sub

    Private Sub TextBox15_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox15.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ErrorProvider3.SetError(TextBox15, "Input must be a number!")
            e.Handled = True
        Else
            e.Handled = False
            ErrorProvider3.Clear()
        End If
    End Sub

    Private Sub TextBox17_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox17.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox25_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox25.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox20_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox20.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ErrorProvider1.SetError(TextBox20, "Input must be a number!")
            e.Handled = True
        Else
            e.Handled = False
            ErrorProvider1.Clear()
        End If
    End Sub

    Private Sub TextBox32_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox32.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ErrorProvider2.SetError(TextBox32, "Input must be a number!")
            e.Handled = True
        Else
            e.Handled = False
            ErrorProvider2.Clear()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection()
        displayDataUser()
        displayDataMenu()
        displayDataOrder()
        displayDataPayment()
        displayMenu()
        displayOrderHistory()
        setGrid()
    End Sub

    Sub displayDataUser()
        DA = New MySqlDataAdapter("SELECT id, username, fullName, email, address, phoneNumber from tbaccount WHERE role != 'admin'", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tbaccount")
        DataGridView6.DataSource = DS.Tables("tbaccount")
        DataGridView6.Refresh()
        DataGridView6.ClearSelection()
    End Sub

    Sub displayDataMenu()
        DA = New MySqlDataAdapter("Select id, name, price From tbmenu", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tbmenu")
        DataGridView1.DataSource = DS.Tables("tbmenu")
        DataGridView1.Refresh()
        DataGridView1.ClearSelection()
        displayMenu()
    End Sub

    Sub displayDataOrder()
        DA = New MySqlDataAdapter("Select id, customerFullName, menuName, quantity, total, customerAddress, customerPhoneNumber, status From tborder", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tborder")
        DataGridView4.DataSource = DS.Tables("tborder")
        DataGridView4.Refresh()
        DataGridView4.ClearSelection()
    End Sub

    Sub displayDataPayment()
        DA = New MySqlDataAdapter("Select id, customerFullName, total, bankAccount, status From tborder", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tborder")
        DataGridView7.DataSource = DS.Tables("tborder")
        DataGridView7.Refresh()
        DataGridView7.ClearSelection()
    End Sub

    Sub displayMenu()
        DA = New MySqlDataAdapter("Select name, price From tbmenu", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tbmenu")
        DataGridView2.DataSource = DS.Tables("tbmenu")
        DataGridView2.Refresh()
        DataGridView2.ClearSelection()
    End Sub

    Sub displayOrderHistory()
        DA = New MySqlDataAdapter("Select id, menuName, total, customerAddress, customerPhoneNumber, status From tborder WHERE customerFullName = '" & sessionFullName & "'", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tborder")
        DataGridView3.DataSource = DS.Tables("tborder")
        DataGridView3.Refresh()
        DataGridView3.ClearSelection()
    End Sub

    Sub setGrid()
        DataGridView6.Columns(0).Width = 105.499
        DataGridView6.Columns(1).Width = 105.499
        DataGridView6.Columns(2).Width = 105.499
        DataGridView6.Columns(3).Width = 105.499
        DataGridView6.Columns(4).Width = 105.499
        DataGridView6.Columns(5).Width = 105.599

        DataGridView6.RowsDefaultCellStyle.BackColor = Color.FromArgb(255, 252, 252)
        DataGridView6.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(11, 65, 42)
        DataGridView6.RowsDefaultCellStyle.ForeColor = Color.FromArgb(11, 65, 42)
        DataGridView6.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(255, 252, 252)

        DataGridView1.Columns(0).Width = 151.499
        DataGridView1.Columns(1).Width = 151.499
        DataGridView1.Columns(2).Width = 151.599

        DataGridView1.RowsDefaultCellStyle.BackColor = Color.FromArgb(255, 252, 252)
        DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(11, 65, 42)
        DataGridView1.RowsDefaultCellStyle.ForeColor = Color.FromArgb(11, 65, 42)
        DataGridView1.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(255, 252, 252)

        DataGridView4.Columns(0).Width = 78.499
        DataGridView4.Columns(1).Width = 78.599
        DataGridView4.Columns(2).Width = 78.599
        DataGridView4.Columns(3).Width = 78.599
        DataGridView4.Columns(4).Width = 78.599
        DataGridView4.Columns(5).Width = 78.599
        DataGridView4.Columns(6).Width = 78.599
        DataGridView4.Columns(7).Width = 78.599

        DataGridView4.RowsDefaultCellStyle.BackColor = Color.FromArgb(255, 252, 252)
        DataGridView4.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(11, 65, 42)
        DataGridView4.RowsDefaultCellStyle.ForeColor = Color.FromArgb(11, 65, 42)
        DataGridView4.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(255, 252, 252)

        DataGridView7.Columns(0).Width = 75.499
        DataGridView7.Columns(1).Width = 75.499
        DataGridView7.Columns(2).Width = 75.499
        DataGridView7.Columns(3).Width = 75.599
        DataGridView7.Columns(4).Width = 75.599

        DataGridView7.RowsDefaultCellStyle.BackColor = Color.FromArgb(255, 252, 252)
        DataGridView7.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(11, 65, 42)
        DataGridView7.RowsDefaultCellStyle.ForeColor = Color.FromArgb(11, 65, 42)
        DataGridView7.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(255, 252, 252)

        DataGridView2.Columns(0).Width = 227.499
        DataGridView2.Columns(1).Width = 227.499

        DataGridView2.RowsDefaultCellStyle.BackColor = Color.FromArgb(255, 252, 252)
        DataGridView2.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(11, 65, 42)
        DataGridView2.RowsDefaultCellStyle.ForeColor = Color.FromArgb(11, 65, 42)
        DataGridView2.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(255, 252, 252)

        DataGridView3.Columns(0).Width = 105.499
        DataGridView3.Columns(1).Width = 105.499
        DataGridView3.Columns(2).Width = 105.499
        DataGridView3.Columns(3).Width = 105.499
        DataGridView3.Columns(4).Width = 105.499
        DataGridView3.Columns(5).Width = 105.499

        DataGridView3.RowsDefaultCellStyle.BackColor = Color.FromArgb(255, 252, 252)
        DataGridView3.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(11, 65, 42)
        DataGridView3.RowsDefaultCellStyle.ForeColor = Color.FromArgb(11, 65, 42)
        DataGridView3.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(255, 252, 252)

        DataGridView6.Columns(0).HeaderText = "Id"
        DataGridView6.Columns(1).HeaderText = "Username"
        DataGridView6.Columns(2).HeaderText = "Full Name"
        DataGridView6.Columns(3).HeaderText = "Email"
        DataGridView6.Columns(4).HeaderText = "Adress"
        DataGridView6.Columns(5).HeaderText = "Phone Number"

        DataGridView1.Columns(0).HeaderText = "Id"
        DataGridView1.Columns(1).HeaderText = "Menu Name"
        DataGridView1.Columns(2).HeaderText = "Price (Rp)"

        DataGridView4.Columns(0).HeaderText = "Id"
        DataGridView4.Columns(1).HeaderText = "Full Name"
        DataGridView4.Columns(2).HeaderText = "Menu Name"
        DataGridView4.Columns(3).HeaderText = "Quantity"
        DataGridView4.Columns(4).HeaderText = "Total (Rp)"
        DataGridView4.Columns(5).HeaderText = "Address"
        DataGridView4.Columns(6).HeaderText = "Phone Number"
        DataGridView4.Columns(7).HeaderText = "Status"

        DataGridView7.Columns(0).HeaderText = "Id"
        DataGridView7.Columns(1).HeaderText = "Full Name"
        DataGridView7.Columns(2).HeaderText = "Total (Rp)"
        DataGridView7.Columns(3).HeaderText = "Bank Account"
        DataGridView7.Columns(4).HeaderText = "Status"

        DataGridView2.Columns(0).HeaderText = "Menu Name"
        DataGridView2.Columns(1).HeaderText = "Price (Rp)"

        DataGridView3.Columns(0).HeaderText = "Id"
        DataGridView3.Columns(1).HeaderText = "Menu Name"
        DataGridView3.Columns(2).HeaderText = "Total (Rp)"
        DataGridView3.Columns(3).HeaderText = "Address"
        DataGridView3.Columns(4).HeaderText = "Phone Number"
        DataGridView3.Columns(5).HeaderText = "Status"
    End Sub

    'Login
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If checkDataLogin() = True Then
            CMD = New MySqlCommand("Select * From tbaccount where username='" & TextBox5.Text & "' AND password='" & TextBox6.Text & "'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()
            If Not RD.HasRows Then
                RD.Close()
                MessageBox.Show("The username or password you entered is incorrect", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                If RD.GetString("role") = "admin" Then
                    'Login As Admin
                    RD.Close()

                    positionAdmin = btnHomeAdmin

                    pnlLogin.Visible = False
                    pnlRegistration.Visible = False

                    pnlLeftSideAdmin.Visible = True
                    pnlHomeAdmin.Visible = True
                    pnlManageUserAdmin.Visible = False
                    pnlManageMenuAdmin.Visible = False
                    pnlFormCreateMenuAdmin.Visible = False
                    pnlFormUpdateMenuAdmin.Visible = False
                    pnlManageOrderAdmin.Visible = False
                    pnlReportAdmin.Visible = False
                    pnlManagePaymentAdmin.Visible = False

                    pnlLeftSideUser.Visible = False
                    pnlHomeUser.Visible = False
                    pnlOrderUser.Visible = False
                    pnlFormOrderUser.Visible = False
                    pnlOrderHistoryUser.Visible = False
                    pnlFormPaymentUser.Visible = False

                    clearLogin()
                Else
                    'Login As User
                    sessionFullName = RD.GetString("fullName")
                    sessionAddress = RD.GetString("address")
                    sessionPhoneNumber = RD.GetString("phoneNumber")

                    RD.Close()

                    positionUser = btnHomeUser

                    pnlLogin.Visible = False
                    pnlRegistration.Visible = False

                    pnlLeftSideAdmin.Visible = False
                    pnlHomeAdmin.Visible = False
                    pnlManageUserAdmin.Visible = False
                    pnlManageMenuAdmin.Visible = False
                    pnlFormCreateMenuAdmin.Visible = False
                    pnlFormUpdateMenuAdmin.Visible = False
                    pnlManageOrderAdmin.Visible = False
                    pnlReportAdmin.Visible = False
                    pnlManagePaymentAdmin.Visible = False

                    pnlLeftSideUser.Visible = True
                    pnlHomeUser.Visible = True
                    pnlOrderUser.Visible = False
                    pnlFormOrderUser.Visible = False
                    pnlOrderHistoryUser.Visible = False
                    pnlFormPaymentUser.Visible = False

                    clearLogin()

                    displayOrderHistory()
                End If
            End If
        End If
    End Sub

    'Login To Register
    Private Sub loginToRegister_Click(sender As Object, e As EventArgs) Handles loginToRegister.Click
        pnlLogin.Visible = False
        pnlRegistration.Visible = True
        clearLogin()
    End Sub

    'Registration
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If checkDataRegistration() = True Then
            CMD = New MySqlCommand("Select * From tbaccount where username='" & TextBox8.Text & "'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()
            If Not RD.HasRows Then
                RD.Close()
                CMD = New MySqlCommand("insert into tbaccount (username, password, fullName, email, phoneNumber, address, role) Values ('" & TextBox7.Text & "' , '" & TextBox8.Text & "' , '" & TextBox9.Text & "' , '" & TextBox12.Text & "' , '" & TextBox17.Text & "' , '" & TextBox11.Text & "', 'user')", CONN)
                CMD.ExecuteNonQuery()
                MessageBox.Show("Data saved successfully", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information)

                'Back To Login
                pnlLogin.Visible = True
                pnlRegistration.Visible = False

                displayDataUser()
                clearRegistration()
            Else
                RD.Close()
                MessageBox.Show("The username you entered already in use", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub

    'Register To Login
    Private Sub registerToLogin_Click(sender As Object, e As EventArgs) Handles registerToLogin.Click
        pnlLogin.Visible = True
        pnlRegistration.Visible = False
        clearRegistration()
    End Sub

    'Search (Data User)
    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        CMD = New MySqlCommand("SELECT id ,username, fullName, email, phoneNumber, address From tbaccount where (role != 'admin') AND (id like '%" & TextBox19.Text & "%' OR username like '%" & TextBox19.Text & "%' OR fullName like '%" & TextBox19.Text & "%')", CONN)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            RD.Close()
            DA = New MySqlDataAdapter("SELECT id ,username, fullName, email, phoneNumber, address From tbaccount where (role != 'admin') AND (id like '%" & TextBox19.Text & "%' OR username like '%" & TextBox19.Text & "%' OR fullName like '%" & TextBox19.Text & "%')", CONN)
            DS = New DataSet
            DA.Fill(DS, "Dapat")
            DataGridView6.DataSource = DS.Tables("Dapat")
            DataGridView6.ReadOnly = True
            DataGridView6.ClearSelection()
        Else
            RD.Close()
            MessageBox.Show("Data not found", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub TextBox19_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox19.KeyPress
        If (e.KeyChar = Chr(13)) Then
            CMD = New MySqlCommand("SELECT id ,username, fullName, email, phoneNumber, address From tbaccount where (role != 'admin') AND (id like '%" & TextBox19.Text & "%' OR username like '%" & TextBox19.Text & "%' OR fullName like '%" & TextBox19.Text & "%')", CONN)
            RD = CMD.ExecuteReader
            RD.Read()
            If RD.HasRows Then
                RD.Close()
                DA = New MySqlDataAdapter("SELECT id ,username, fullName, email, phoneNumber, address From tbaccount where (role != 'admin') AND (id like '%" & TextBox19.Text & "%' OR username like '%" & TextBox19.Text & "%' OR fullName like '%" & TextBox19.Text & "%')", CONN)
                DS = New DataSet
                DA.Fill(DS, "Dapat")
                DataGridView6.DataSource = DS.Tables("Dapat")
                DataGridView6.ReadOnly = True
                DataGridView6.ClearSelection()
            Else
                RD.Close()
                MessageBox.Show("Data not found", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub

    'Delete (Data User)
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If DataGridView6.SelectedRows.Count = 0 Then
            MessageBox.Show("You have not selected data", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim selectedRow As DataGridViewRow = DataGridView6.SelectedRows(0)
            Dim value As String = selectedRow.Cells(1).Value.ToString()
            If MessageBox.Show("Are you sure to delete account with username = " & value & " ?", "CONFIRM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                CMD = New MySqlCommand("Delete From tbaccount Where username = '" & value & "'", CONN)
                CMD.ExecuteNonQuery()

                displayDataUser()

                MessageBox.Show("Data deleted successfully", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    'Browse Image File (Create Data Menu)
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            OFD.Filter = "Image Files(*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png"
            OFD.Title = "Select an image"
            OFD.FileName = ""
            If OFD.ShowDialog() = DialogResult.OK Then
                TextBox4.Text = Path.GetDirectoryName(OFD.FileName) & "\" & Path.GetFileName(OFD.FileName)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    'Show Form (Create Data Menu)
    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click
        pnlLogin.Visible = False
        pnlRegistration.Visible = False
        pnlHomeAdmin.Visible = False
        pnlManageUserAdmin.Visible = False
        pnlManageMenuAdmin.Visible = False
        pnlFormCreateMenuAdmin.Visible = True
        pnlFormUpdateMenuAdmin.Visible = False
        pnlManageOrderAdmin.Visible = False
        pnlReportAdmin.Visible = False
        pnlManagePaymentAdmin.Visible = False
    End Sub

    'Create (Data Menu)
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If checkDataCreate() = True Then
            CMD = New MySqlCommand("Select * From tbmenu where name='" & TextBox1.Text & "'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()
            If Not RD.HasRows Then
                RD.Close()
                CMD = New MySqlCommand("insert into tbmenu (name, image, price, description) Values ('" & TextBox1.Text & "' , '" & TextBox1.Text & ".jpg ' ,'" & TextBox2.Text & "' , '" & TextBox3.Text & "')", CONN)
                CMD.ExecuteNonQuery()
                My.Computer.FileSystem.CopyFile(OFD.FileName, imagePath & TextBox1.Text & ".jpg")

                pnlFormCreateMenuAdmin.Visible = False
                pnlManageMenuAdmin.Visible = True

                MessageBox.Show("Data saved successfully", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information)
                displayDataMenu()
                clearCreate()
            Else
                RD.Close()
                MessageBox.Show("The coffe name you entered already exists", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub

    'Back To Manage Menu
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        pnlFormCreateMenuAdmin.Visible = False
        pnlManageMenuAdmin.Visible = True
    End Sub

    'Search (Data Menu Admin)
    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        CMD = New MySqlCommand("Select id, name, price From tbmenu where id like '%" & TextBox10.Text & "%' OR name like '%" & TextBox10.Text & "%'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            RD.Close()
            DA = New MySqlDataAdapter("Select id, name, price From tbmenu where id like '%" & TextBox10.Text & "%' OR name like '%" & TextBox10.Text & "%'", CONN)
            DS = New DataSet
            DA.Fill(DS, "Dapat")
            DataGridView1.DataSource = DS.Tables("Dapat")
            DataGridView1.ReadOnly = True
            clearPicture()
        Else
            RD.Close()
            MessageBox.Show("Data not found", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub TextBox10_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox10.KeyPress
        If (e.KeyChar = Chr(13)) Then
            CMD = New MySqlCommand("Select id, name, price From tbmenu where id like '%" & TextBox10.Text & "%' OR name like '%" & TextBox10.Text & "%'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()
            If RD.HasRows Then
                RD.Close()
                DA = New MySqlDataAdapter("Select id, name, price From tbmenu where id like '%" & TextBox10.Text & "%' OR name like '%" & TextBox10.Text & "%'", CONN)
                DS = New DataSet
                DA.Fill(DS, "Dapat")
                DataGridView1.DataSource = DS.Tables("Dapat")
                DataGridView1.ReadOnly = True
                clearPicture()
            Else
                RD.Close()
                MessageBox.Show("Data not found", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub

    'Read (Data Menu)
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
                Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
                Dim value As String = selectedRow.Cells(0).Value.ToString()

                CMD = New MySqlCommand("SELECT image, description FROM tbmenu WHERE tbmenu.id = '" & value & "'", CONN)
                RD = CMD.ExecuteReader
                RD.Read()

                Dim imageName As String = imagePath & RD.GetString("image")
                Label40.Text = RD.GetString("description")

                Dim imageBytes() As Byte = File.ReadAllBytes(imageName)
                Dim ms As New MemoryStream(imageBytes)
                PictureBox10.Image = Image.FromStream(ms)

                RD.Close()
            End If
        Catch ex As Exception
        End Try
    End Sub

    'Show Form (Update Data Menu)
    Private Sub PictureBox17_Click(sender As Object, e As EventArgs) Handles PictureBox17.Click
        If DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("You have not selected data", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
            Dim value As String = selectedRow.Cells(0).Value.ToString()

            CMD = New MySqlCommand("SELECT description FROM tbmenu WHERE tbmenu.id = " & value & "", CONN)
            RD = CMD.ExecuteReader
            RD.Read()

            pnlLogin.Visible = False
            pnlRegistration.Visible = False
            pnlHomeAdmin.Visible = False
            pnlManageUserAdmin.Visible = False
            pnlManageMenuAdmin.Visible = False
            pnlFormCreateMenuAdmin.Visible = False
            pnlFormUpdateMenuAdmin.Visible = True
            pnlManageOrderAdmin.Visible = False
            pnlReportAdmin.Visible = False
            pnlManagePaymentAdmin.Visible = False

            TextBox16.Text = selectedRow.Cells(1).Value.ToString()
            TextBox15.Text = selectedRow.Cells(2).Value.ToString()
            TextBox13.Text = RD.GetString("description")

            RD.Close()
        End If
    End Sub

    'Browse Image File (Update Data Menu)
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            OFD.Filter = "Image Files(*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png"
            OFD.Title = "Select an image"
            OFD.FileName = ""
            If OFD.ShowDialog() = DialogResult.OK Then
                TextBox14.Text = Path.GetDirectoryName(OFD.FileName) & "\" & Path.GetFileName(OFD.FileName)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    'Update (Data Menu)
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("You have not selected data", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
            Dim value As String = selectedRow.Cells(0).Value.ToString()
            If checkDataUpdate() = True Then
                If TextBox14.Text <> "" Then
                    'If Update Image

                    'Update Image Name In Database
                    CMD = New MySqlCommand("Update tbmenu set image = '" & TextBox16.Text & ".jpg', price = '" & TextBox15.Text & "', description = '" & TextBox13.Text & "' WHERE  tbmenu.id = '" & value & "'", CONN)
                    CMD.ExecuteNonQuery()

                    'Update File In Folder
                    File.Copy(TextBox14.Text, imagePath & TextBox16.Text & ".jpg", True)

                    'Back To Manage Menu
                    pnlFormUpdateMenuAdmin.Visible = False
                    pnlManageMenuAdmin.Visible = True

                    MessageBox.Show("Data changed successfully", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    displayDataMenu()
                    clearUpdate()
                Else
                    'Otherwise Update Image
                    CMD = New MySqlCommand("Update tbmenu set image = '" & TextBox16.Text & ".jpg', price = '" & TextBox15.Text & "', description = '" & TextBox13.Text & "' WHERE  tbmenu.id = '" & value & "'", CONN)
                    CMD.ExecuteNonQuery()
                    RD.Close()

                    'Back To Manage Menu
                    pnlFormUpdateMenuAdmin.Visible = False
                    pnlManageMenuAdmin.Visible = True

                    clearPicture()

                    MessageBox.Show("Data changed successfully", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    displayDataMenu()
                    clearUpdate()
                End If
            End If
        End If
    End Sub

    'Back To Update Menu
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        pnlFormUpdateMenuAdmin.Visible = False
        pnlManageMenuAdmin.Visible = True
    End Sub

    'Delete (Data Menu)
    Private Sub PictureBox18_Click(sender As Object, e As EventArgs) Handles PictureBox18.Click
        If DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("You have not selected data", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
            Dim value As String = selectedRow.Cells(0).Value.ToString()
            Dim fileName As String = imagePath & selectedRow.Cells(1).Value.ToString() & ".jpg"
            If MessageBox.Show("Are you sure to delete menu with id = " & value & " ?", "CONFIRM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                CMD = New MySqlCommand("Delete From tbmenu Where id = '" & value & "'", CONN)
                CMD.ExecuteNonQuery()

                'Delete Image In Folder
                If File.Exists(fileName) Then
                    Try
                        File.Delete(fileName)
                    Catch ex As Exception
                    End Try
                Else
                End If

                clearPicture()
                displayDataMenu()

                MessageBox.Show("Data deleted successfully", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    'Search (Data Order)
    Private Sub PictureBox26_Click(sender As Object, e As EventArgs) Handles PictureBox26.Click
        CMD = New MySqlCommand("Select id, customerFullName, menuName, quantity, total, customerAddress, customerPhoneNumber, status From tborder WHERE id like '%" & TextBox27.Text & "%' OR customerFullName like '%" & TextBox27.Text & "%' OR menuName like '%" & TextBox27.Text & "%' OR status like '%" & TextBox27.Text & "%'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            RD.Close()
            DA = New MySqlDataAdapter("Select id, customerFullName, menuName, quantity, total, customerAddress, customerPhoneNumber, status From tborder WHERE id like '%" & TextBox27.Text & "%' OR customerFullName like '%" & TextBox27.Text & "%' OR menuName like '%" & TextBox27.Text & "%' OR status like '%" & TextBox27.Text & "%'", CONN)
            DS = New DataSet
            DA.Fill(DS, "Dapat")
            DataGridView4.DataSource = DS.Tables("Dapat")
            DataGridView4.ReadOnly = True
            DataGridView4.ClearSelection()
        Else
            RD.Close()
            MessageBox.Show("Data not found", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub TextBox27_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox27.KeyPress
        If (e.KeyChar = Chr(13)) Then
            CMD = New MySqlCommand("Select id, customerFullName, menuName, quantity, total, customerAddress, customerPhoneNumber, status From tborder WHERE id like '%" & TextBox27.Text & "%' OR customerFullName like '%" & TextBox27.Text & "%' OR menuName like '%" & TextBox27.Text & "%' OR status like '%" & TextBox27.Text & "%'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()
            If RD.HasRows Then
                RD.Close()
                DA = New MySqlDataAdapter("Select id, customerFullName, menuName, quantity, total, customerAddress, customerPhoneNumber, status From tborder WHERE id like '%" & TextBox27.Text & "%' OR customerFullName like '%" & TextBox27.Text & "%' OR menuName like '%" & TextBox27.Text & "%' OR status like '%" & TextBox27.Text & "%'", CONN)
                DS = New DataSet
                DA.Fill(DS, "Dapat")
                DataGridView4.DataSource = DS.Tables("Dapat")
                DataGridView4.ReadOnly = True
                DataGridView4.ClearSelection()
            Else
                RD.Close()
                MessageBox.Show("Data not found", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub

    'Delete (Data Order)
    Private Sub PictureBox25_Click(sender As Object, e As EventArgs) Handles PictureBox25.Click
        If DataGridView4.SelectedRows.Count = 0 Then
            MessageBox.Show("You have not selected data", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim selectedRow As DataGridViewRow = DataGridView4.SelectedRows(0)
            Dim value As String = selectedRow.Cells(0).Value.ToString()
            Dim fileName As String = imagePath & "PaymentSlip\" & "PaymentSlipIdOrder = " & value & ".jpg"

            If MessageBox.Show("Are you sure to delete data with id = " & value & " ?", "CONFIRM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                CMD = New MySqlCommand("Delete From tborder Where id = '" & value & "'", CONN)
                CMD.ExecuteNonQuery()

                'Delete Image In Folder
                If File.Exists(fileName) Then
                    Try
                        File.Delete(fileName)
                    Catch ex As Exception
                    End Try
                Else
                End If

                clearPicture()
                displayDataOrder()
                displayDataPayment()

                MessageBox.Show("Data deleted successfully", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    'Search (Data Payment)
    Private Sub PictureBox31_Click(sender As Object, e As EventArgs) Handles PictureBox31.Click
        CMD = New MySqlCommand("Select id, customerFullName, total, bankAccount, status From tborder WHERE id like '%" & TextBox28.Text & "%' OR customerFullName like '%" & TextBox28.Text & "%' OR status like '%" & TextBox28.Text & "%'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            RD.Close()
            DA = New MySqlDataAdapter("Select id, customerFullName, total, bankAccount, status From tborder WHERE id like '%" & TextBox28.Text & "%' OR customerFullName like '%" & TextBox28.Text & "%' OR status like '%" & TextBox28.Text & "%'", CONN)
            DS = New DataSet
            DA.Fill(DS, "Dapat")
            DataGridView7.DataSource = DS.Tables("Dapat")
            DataGridView7.ReadOnly = True
            DataGridView7.ClearSelection()
        Else
            RD.Close()
            MessageBox.Show("Data not found", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub TextBox28_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox28.KeyPress
        If (e.KeyChar = Chr(13)) Then
            CMD = New MySqlCommand("Select id, customerFullName, total, bankAccount, status From tborder WHERE id like '%" & TextBox28.Text & "%' OR customerFullName like '%" & TextBox28.Text & "%' OR status like '%" & TextBox28.Text & "%'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()
            If RD.HasRows Then
                RD.Close()
                DA = New MySqlDataAdapter("Select id, customerFullName, total, bankAccount, status From tborder WHERE id like '%" & TextBox28.Text & "%' OR customerFullName like '%" & TextBox28.Text & "%' OR status like '%" & TextBox28.Text & "%'", CONN)
                DS = New DataSet
                DA.Fill(DS, "Dapat")
                DataGridView7.DataSource = DS.Tables("Dapat")
                DataGridView7.ReadOnly = True
                DataGridView7.ClearSelection()
            Else
                RD.Close()
                MessageBox.Show("Data not found", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub

    'Read Data (Data Payment)
    Private Sub DataGridView7_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView7.CellClick
        Try
            If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
                Dim selectedRow As DataGridViewRow = DataGridView7.SelectedRows(0)
                Dim value As String = selectedRow.Cells(0).Value.ToString()
                Dim valueStatus As String = selectedRow.Cells(4).Value.ToString()

                CMD = New MySqlCommand("SELECT paymentSlip FROM tborder WHERE tborder.id = '" & value & "'", CONN)
                RD = CMD.ExecuteReader
                RD.Read()

                Dim imageName As String = imagePath & "\PaymentSlip\" & RD.GetString("paymentSlip")

                If valueStatus = "Unpaid" Then
                    RD.Close()
                    PictureBox32.Image = Image.FromFile(imagePath & "Resources\blankImagePay.jpg")
                Else
                    RD.Close()
                    Dim imageBytes() As Byte = File.ReadAllBytes(imageName)
                    Dim ms As New MemoryStream(imageBytes)
                    PictureBox32.Image = Image.FromStream(ms)
                    RD.Close()
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    '=====================================================================================================================================

    Private Sub btnHomeUser_Click(sender As Object, e As EventArgs) Handles btnHomeUser.Click
        clearPicture()
        clearPayment()

        pnlOnButtonPositionUser.Height = btnHomeUser.Height
        pnlOnButtonPositionUser.Top = btnHomeUser.Top

        positionUser = btnHomeUser

        pnlHomeUser.Visible = True
        pnlOrderUser.Visible = False
        pnlFormOrderUser.Visible = False
        pnlOrderHistoryUser.Visible = False
        pnlFormPaymentUser.Visible = False
    End Sub

    Private Sub btnOrderUser_Click(sender As Object, e As EventArgs) Handles btnOrderUser.Click
        clearPicture()
        clearPayment()

        pnlOnButtonPositionUser.Height = btnOrderUser.Height
        pnlOnButtonPositionUser.Top = btnOrderUser.Top

        positionUser = btnOrderUser

        pnlHomeUser.Visible = False
        pnlOrderUser.Visible = True
        pnlFormOrderUser.Visible = False
        pnlOrderHistoryUser.Visible = False
        pnlFormPaymentUser.Visible = False
    End Sub

    Private Sub btnOrderHistoryUser_Click(sender As Object, e As EventArgs) Handles btnOrderHistoryUser.Click
        clearPicture()
        clearPayment()

        pnlOnButtonPositionUser.Height = btnOrderHistoryUser.Height
        pnlOnButtonPositionUser.Top = btnOrderHistoryUser.Top

        positionUser = btnOrderHistoryUser

        pnlHomeUser.Visible = False
        pnlOrderUser.Visible = False
        pnlFormOrderUser.Visible = False
        pnlOrderHistoryUser.Visible = True
        pnlFormPaymentUser.Visible = False
    End Sub

    Private Sub btnLogoutUser_Click(sender As Object, e As EventArgs) Handles btnLogoutUser.Click
        pnlOnButtonPositionUser.Height = btnLogoutUser.Height
        pnlOnButtonPositionUser.Top = btnLogoutUser.Top

        Dim close As String
        close = MessageBox.Show("Are you sure ?", "CONFIRM", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If close = MsgBoxResult.Yes Then
            pnlLogin.Visible = True
            pnlRegistration.Visible = False

            pnlHomeUser.Visible = False
            pnlOrderUser.Visible = False
            pnlFormOrderUser.Visible = False
            pnlOrderHistoryUser.Visible = False
            pnlFormPaymentUser.Visible = False

            pnlOnButtonPositionUser.Height = btnHomeUser.Height
            pnlOnButtonPositionUser.Top = btnHomeUser.Top
        Else
            pnlOnButtonPositionUser.Height = positionUser.Height
            pnlOnButtonPositionUser.Top = positionUser.Top
            positionUser.Focus()
            Exit Sub
        End If
    End Sub

    'Read Data (Order)
    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        Try
            If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
                Dim selectedRow As DataGridViewRow = DataGridView2.SelectedRows(0)
                Dim value As String = selectedRow.Cells(0).Value.ToString()

                CMD = New MySqlCommand("SELECT image, description FROM tbmenu WHERE tbmenu.name = '" & value & "'", CONN)
                RD = CMD.ExecuteReader
                RD.Read()

                Dim imageName As String = imagePath & RD.GetString("image")
                Label35.Text = RD.GetString("description")

                Dim imageBytes() As Byte = File.ReadAllBytes(imageName)
                Dim ms As New MemoryStream(imageBytes)
                PictureBox21.Image = Image.FromStream(ms)

                RD.Close()
            End If
        Catch ex As Exception
        End Try
    End Sub

    'Search (Data Menu User)
    Private Sub PictureBox22_Click(sender As Object, e As EventArgs) Handles PictureBox22.Click
        CMD = New MySqlCommand("Select name, price From tbmenu where name like '%" & TextBox18.Text & "%'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            RD.Close()
            DA = New MySqlDataAdapter("Select name, price From tbmenu where name like '%" & TextBox18.Text & "%'", CONN)
            DS = New DataSet
            DA.Fill(DS, "Dapat")
            DataGridView2.DataSource = DS.Tables("Dapat")
            DataGridView2.ReadOnly = True
            clearPicture()
        Else
            RD.Close()
            MessageBox.Show("Data not found", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub TextBox18_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox18.KeyPress
        If (e.KeyChar = Chr(13)) Then
            CMD = New MySqlCommand("Select name, price From tbmenu where name like '%" & TextBox18.Text & "%'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()
            If RD.HasRows Then
                RD.Close()
                DA = New MySqlDataAdapter("Select name, price From tbmenu where name like '%" & TextBox18.Text & "%'", CONN)
                DS = New DataSet
                DA.Fill(DS, "Dapat")
                DataGridView2.DataSource = DS.Tables("Dapat")
                DataGridView2.ReadOnly = True
                clearPicture()
            Else
                RD.Close()
                MessageBox.Show("Data not found", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub

    'Quantity +
    Private Sub Button15_Click_1(sender As Object, e As EventArgs) Handles Button15.Click
        TextBox25.Text = Val(TextBox25.Text + 1)
    End Sub

    'Order
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If checkDataOrder() = True Then
            If MessageBox.Show("Are you sure to order " & TextBox25.Text & " " & TextBox23.Text & " for " & "Rp." & Val(TextBox22.Text * TextBox25.Text) & " ?", "CONFIRM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                CMD = New MySqlCommand("insert into tborder (menuName, menuPrice, quantity, total, customerFullName, customerAddress, customerPhoneNumber, paymentSlip, bankAccount, status) Values ('" & TextBox23.Text & "' , '" & TextBox22.Text & "' ,'" & TextBox25.Text & "' , '" & Val(TextBox22.Text * TextBox25.Text) & "' , '" & TextBox24.Text & "' , '" & TextBox21.Text & "' , '" & TextBox20.Text & "' , '-' , '-' , 'Unpaid')", CONN)
                CMD.ExecuteNonQuery()

                pnlOnButtonPositionUser.Height = btnOrderHistoryUser.Height
                pnlOnButtonPositionUser.Top = btnOrderHistoryUser.Top

                positionUser = btnOrderHistoryUser

                pnlFormOrderUser.Visible = False
                pnlOrderHistoryUser.Visible = True

                displayDataOrder()
                displayDataPayment()
                displayOrderHistory()
                clearOrder()

                MessageBox.Show("Order data added successfully", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    'Quantity -
    Private Sub Button14_Click_1(sender As Object, e As EventArgs) Handles Button14.Click
        If TextBox25.Text <= 1 Then
            MessageBox.Show("Quantity cannot be less than 1", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox25.Focus()
        Else
            TextBox25.Text = Val(TextBox25.Text - 1)
        End If
    End Sub

    'Show Form (Order)
    Private Sub PictureBox20_Click(sender As Object, e As EventArgs) Handles PictureBox20.Click
        If DataGridView2.SelectedRows.Count = 0 Then
            MessageBox.Show("You have not selected data", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim selectedRow As DataGridViewRow = DataGridView2.SelectedRows(0)
            Dim value As String = selectedRow.Cells(0).Value.ToString()

            pnlLogin.Visible = False
            pnlRegistration.Visible = False
            pnlHomeUser.Visible = False
            pnlOrderUser.Visible = False
            pnlFormOrderUser.Visible = True
            pnlOrderHistoryUser.Visible = False
            pnlFormPaymentUser.Visible = False

            TextBox23.Text = selectedRow.Cells(0).Value.ToString()
            TextBox22.Text = selectedRow.Cells(1).Value
            TextBox25.Text = 1
            TextBox24.Text = sessionFullName
            TextBox21.Text = sessionAddress
            TextBox20.Text = sessionPhoneNumber
        End If
    End Sub

    'Show Form (Payment)
    Private Sub PictureBox9_Click_1(sender As Object, e As EventArgs) Handles PictureBox9.Click
        If DataGridView3.SelectedRows.Count = 0 Then
            MessageBox.Show("You have not selected data", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            'Check the data has been paid or not
            Dim selectedRow As DataGridViewRow = DataGridView3.SelectedRows(0)
            Dim value As String = selectedRow.Cells(5).Value.ToString()
            If value = "Paid" Then
                MessageBox.Show("You have already paid for this order", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                pnlOrderUser.Visible = False
                pnlFormOrderUser.Visible = False
                pnlOrderHistoryUser.Visible = False
                pnlFormPaymentUser.Visible = True
            End If
        End If
    End Sub

    'Search (Data History Order)
    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        CMD = New MySqlCommand("SELECT id, menuName, total, customerAddress, customerPhoneNumber, status From tborder WHERE customerFullName = '" & sessionFullName & "' AND (id like '%" & TextBox26.Text & "%' OR menuName like '%" & TextBox26.Text & "%' OR status like '%" & TextBox26.Text & "%')", CONN)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            RD.Close()
            DA = New MySqlDataAdapter("SELECT id, menuName, total, customerAddress, customerPhoneNumber, status From tborder WHERE customerFullName = '" & sessionFullName & "' AND (id like '%" & TextBox26.Text & "%' OR menuName like '%" & TextBox26.Text & "%' OR status like '%" & TextBox26.Text & "%')", CONN)
            DS = New DataSet
            DA.Fill(DS, "Dapat")
            DataGridView3.DataSource = DS.Tables("Dapat")
            DataGridView3.ReadOnly = True
            DataGridView3.ClearSelection()
        Else
            RD.Close()
            MessageBox.Show("Data not found", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub TextBox26_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox26.KeyPress
        If (e.KeyChar = Chr(13)) Then
            CMD = New MySqlCommand("SELECT id, menuName, total, customerAddress, customerPhoneNumber, status From tborder WHERE customerFullName = '" & sessionFullName & "' AND (id like '%" & TextBox26.Text & "%' OR menuName like '%" & TextBox26.Text & "%' OR status like '%" & TextBox26.Text & "%')", CONN)
            RD = CMD.ExecuteReader
            RD.Read()
            If RD.HasRows Then
                RD.Close()
                DA = New MySqlDataAdapter("SELECT id, menuName, total, customerAddress, customerPhoneNumber, status From tborder WHERE customerFullName = '" & sessionFullName & "' AND (id like '%" & TextBox26.Text & "%' OR menuName like '%" & TextBox26.Text & "%' OR status like '%" & TextBox26.Text & "%')", CONN)
                DS = New DataSet
                DA.Fill(DS, "Dapat")
                DataGridView3.DataSource = DS.Tables("Dapat")
                DataGridView3.ReadOnly = True
                DataGridView3.ClearSelection()
            Else
                RD.Close()
                MessageBox.Show("Data not found", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub

    'Back To Order History
    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        pnlFormPaymentUser.Visible = False
        pnlOrderHistoryUser.Visible = True
        clearPayment()
    End Sub

    'Browse Image (Payment)
    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Try
            OFD.Filter = "Image Files(*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png"
            OFD.Title = "Select an image"
            OFD.FileName = ""
            If OFD.ShowDialog() = DialogResult.OK Then
                TextBox31.Text = Path.GetDirectoryName(OFD.FileName) & "\" & Path.GetFileName(OFD.FileName)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    'Payment
    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If checkDataPayment() = True Then
            Dim selectedRow As DataGridViewRow = DataGridView3.SelectedRows(0)
            Dim value As String = selectedRow.Cells(0).Value.ToString()

            CMD = New MySqlCommand("UPDATE tborder SET bankAccount = '" & TextBox32.Text & "', paymentSlip = 'PaymentSlipIdOrder = " & value & ".jpg" & "', status = 'Paid' WHERE tborder.id = '" & value & "'", CONN)
            CMD.ExecuteNonQuery()
            My.Computer.FileSystem.CopyFile(OFD.FileName, imagePath & "PaymentSlip\" & "PaymentSlipIdOrder = " & value & ".jpg")

            pnlFormPaymentUser.Visible = False
            pnlOrderHistoryUser.Visible = True

            displayDataOrder()
            displayDataPayment()
            displayOrderHistory()
            clearPayment()

            MessageBox.Show("Payment successfull", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    'Back To Order
    Private Sub Button10_Click_1(sender As Object, e As EventArgs) Handles Button10.Click
        pnlOrderUser.Visible = True
        pnlFormOrderUser.Visible = False
    End Sub

    'Change color label LoginToRegister
    Private Sub loginToRegister_MouseEnter(sender As Object, e As EventArgs) Handles loginToRegister.MouseEnter
        loginToRegister.ForeColor = Color.Blue
    End Sub
    Private Sub loginToRegister_MouseLeave(sender As Object, e As EventArgs) Handles loginToRegister.MouseLeave
        loginToRegister.ForeColor = Color.FromArgb(32, 36, 33)
    End Sub

    'Change color label RegisterToLogin
    Private Sub registerToLogin_MouseEnter(sender As Object, e As EventArgs) Handles registerToLogin.MouseEnter
        registerToLogin.ForeColor = Color.Blue
    End Sub
    Private Sub registerToLogin_MouseLeave(sender As Object, e As EventArgs) Handles registerToLogin.MouseLeave
        registerToLogin.ForeColor = Color.FromArgb(32, 36, 33)
    End Sub

    'Change color icon button
    '---------Admin---------'
    Private Sub PictureBox1_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox1.MouseEnter
        PictureBox1.BackColor = Color.FromArgb(11, 65, 42)
    End Sub
    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave
        PictureBox1.BackColor = Color.FromArgb(32, 36, 33)
    End Sub

    Private Sub PictureBox14_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox14.MouseEnter
        PictureBox14.BackColor = Color.FromArgb(11, 65, 42)
    End Sub
    Private Sub PictureBox14_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox14.MouseLeave
        PictureBox14.BackColor = Color.FromArgb(32, 36, 33)
    End Sub

    Private Sub PictureBox16_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox16.MouseEnter
        PictureBox16.BackColor = Color.FromArgb(11, 65, 42)
    End Sub
    Private Sub PictureBox16_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox16.MouseLeave
        PictureBox16.BackColor = Color.FromArgb(32, 36, 33)
    End Sub

    Private Sub PictureBox17_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox17.MouseEnter
        PictureBox17.BackColor = Color.FromArgb(11, 65, 42)
    End Sub
    Private Sub PictureBox17_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox17.MouseLeave
        PictureBox17.BackColor = Color.FromArgb(32, 36, 33)
    End Sub

    Private Sub PictureBox18_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox18.MouseEnter
        PictureBox18.BackColor = Color.FromArgb(11, 65, 42)
    End Sub
    Private Sub PictureBox18_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox18.MouseLeave
        PictureBox18.BackColor = Color.FromArgb(32, 36, 33)
    End Sub

    Private Sub PictureBox6_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox6.MouseEnter
        PictureBox6.BackColor = Color.FromArgb(11, 65, 42)
    End Sub
    Private Sub PictureBox6_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox6.MouseLeave
        PictureBox6.BackColor = Color.FromArgb(32, 36, 33)
    End Sub

    Private Sub PictureBox25_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox25.MouseEnter
        PictureBox25.BackColor = Color.FromArgb(11, 65, 42)
    End Sub
    Private Sub PictureBox25_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox25.MouseLeave
        PictureBox25.BackColor = Color.FromArgb(32, 36, 33)
    End Sub

    Private Sub PictureBox26_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox26.MouseEnter
        PictureBox26.BackColor = Color.FromArgb(11, 65, 42)
    End Sub
    Private Sub PictureBox26_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox26.MouseLeave
        PictureBox26.BackColor = Color.FromArgb(32, 36, 33)
    End Sub

    Private Sub PictureBox31_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox31.MouseEnter
        PictureBox31.BackColor = Color.FromArgb(11, 65, 42)
    End Sub
    Private Sub PictureBox31_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox31.MouseLeave
        PictureBox31.BackColor = Color.FromArgb(32, 36, 33)
    End Sub

    Private Sub PictureBox27_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox27.MouseEnter
        PictureBox27.BackColor = Color.FromArgb(11, 65, 42)
    End Sub
    Private Sub PictureBox27_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox27.MouseLeave
        PictureBox27.BackColor = Color.FromArgb(32, 36, 33)
    End Sub

    Private Sub PictureBox30_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox30.MouseEnter
        PictureBox30.BackColor = Color.FromArgb(11, 65, 42)
    End Sub
    Private Sub PictureBox30_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox30.MouseLeave
        PictureBox30.BackColor = Color.FromArgb(32, 36, 33)
    End Sub

    '---------User---------'
    Private Sub PictureBox20_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox20.MouseEnter
        PictureBox20.BackColor = Color.FromArgb(11, 65, 42)
    End Sub
    Private Sub PictureBox20_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox20.MouseLeave
        PictureBox20.BackColor = Color.FromArgb(32, 36, 33)
    End Sub

    Private Sub PictureBox22_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox22.MouseEnter
        PictureBox22.BackColor = Color.FromArgb(11, 65, 42)
    End Sub
    Private Sub PictureBox22_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox22.MouseLeave
        PictureBox22.BackColor = Color.FromArgb(32, 36, 33)
    End Sub

    Private Sub PictureBox9_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox9.MouseEnter
        PictureBox9.BackColor = Color.FromArgb(11, 65, 42)
    End Sub

    Private Sub PictureBox27_Click(sender As Object, e As EventArgs) Handles PictureBox27.Click
        pnlManageOrderAdmin.Visible = False
        pnlReportAdmin.Visible = True
    End Sub

    Private Sub PictureBox30_Click(sender As Object, e As EventArgs) Handles PictureBox30.Click
        pnlManageOrderAdmin.Visible = True
        pnlReportAdmin.Visible = False
    End Sub

    Private Sub PictureBox9_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox9.MouseLeave
        PictureBox9.BackColor = Color.FromArgb(32, 36, 33)
    End Sub

    Private Sub PictureBox11_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox11.MouseEnter
        PictureBox11.BackColor = Color.FromArgb(11, 65, 42)
    End Sub
    Private Sub PictureBox11_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox11.MouseLeave
        PictureBox11.BackColor = Color.FromArgb(32, 36, 33)
    End Sub
End Class
