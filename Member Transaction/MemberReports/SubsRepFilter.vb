Public Class SubsRepFilter
    Inherits System.Windows.Forms.Form
#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents btn_Print As System.Windows.Forms.Button
    Friend WithEvents Btn_cancel As System.Windows.Forms.Button
    Friend WithEvents chklst_QuaterSelect As System.Windows.Forms.CheckedListBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DTP_QUATER_YEAR As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(SubsRepFilter))
        Me.btn_Print = New System.Windows.Forms.Button
        Me.Btn_cancel = New System.Windows.Forms.Button
        Me.chklst_QuaterSelect = New System.Windows.Forms.CheckedListBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DTP_QUATER_YEAR = New System.Windows.Forms.DateTimePicker
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_Print
        '
        Me.btn_Print.BackgroundImage = CType(resources.GetObject("btn_Print.BackgroundImage"), System.Drawing.Image)
        Me.btn_Print.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Print.ForeColor = System.Drawing.Color.White
        Me.btn_Print.Location = New System.Drawing.Point(16, 216)
        Me.btn_Print.Name = "btn_Print"
        Me.btn_Print.Size = New System.Drawing.Size(104, 32)
        Me.btn_Print.TabIndex = 1
        Me.btn_Print.Text = "Print"
        '
        'Btn_cancel
        '
        Me.Btn_cancel.BackgroundImage = CType(resources.GetObject("Btn_cancel.BackgroundImage"), System.Drawing.Image)
        Me.Btn_cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_cancel.ForeColor = System.Drawing.Color.White
        Me.Btn_cancel.Location = New System.Drawing.Point(176, 216)
        Me.Btn_cancel.Name = "Btn_cancel"
        Me.Btn_cancel.Size = New System.Drawing.Size(104, 32)
        Me.Btn_cancel.TabIndex = 2
        Me.Btn_cancel.Text = "Cancel"
        '
        'chklst_QuaterSelect
        '
        Me.chklst_QuaterSelect.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(192, Byte), CType(255, Byte))
        Me.chklst_QuaterSelect.Items.AddRange(New Object() {"April (1st April to 30th June)", "July (1st July to 30th September)", "October (1st October to 31st December)", "January (1st January to 31st March)"})
        Me.chklst_QuaterSelect.Location = New System.Drawing.Point(16, 56)
        Me.chklst_QuaterSelect.Name = "chklst_QuaterSelect"
        Me.chklst_QuaterSelect.Size = New System.Drawing.Size(256, 154)
        Me.chklst_QuaterSelect.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DodgerBlue
        Me.GroupBox1.Controls.Add(Me.DTP_QUATER_YEAR)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(288, 256)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'DTP_QUATER_YEAR
        '
        Me.DTP_QUATER_YEAR.CustomFormat = "yyyy"
        Me.DTP_QUATER_YEAR.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_QUATER_YEAR.Location = New System.Drawing.Point(16, 16)
        Me.DTP_QUATER_YEAR.Name = "DTP_QUATER_YEAR"
        Me.DTP_QUATER_YEAR.Size = New System.Drawing.Size(80, 20)
        Me.DTP_QUATER_YEAR.TabIndex = 0
        '
        'SubsRepFilter
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(304, 273)
        Me.Controls.Add(Me.chklst_QuaterSelect)
        Me.Controls.Add(Me.Btn_cancel)
        Me.Controls.Add(Me.btn_Print)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "SubsRepFilter"
        Me.Text = "QUATER FILTER"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub SubsRepFilter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'SubsRepFilter.
        SetQuater = ""
    End Sub
    Private Sub btn_Print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Print.Click
        Try
            Dim ReportFilterObj As New ReportFilter
            'RepSqlStr = "Subscription Bill"
            'ReportFilterObj.MdiParent = Me
            ReportFilterObj.DLabel.Text = " Enter Member Code"
            ReportFilterObj.Text = RepSqlStr
            ReportFilterObj.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_cancel.Click
        If MsgBox("Do U Want to Close this Form........", MsgBoxStyle.OKCancel + MsgBoxStyle.DefaultButton1 + MsgBoxStyle.Question, Me.Text) = MsgBoxResult.OK Then
            Me.Close()
        Else
            DTP_QUATER_YEAR.Focus()
        End If
    End Sub
    Private Sub chklst_QuaterSelect_ItemCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) Handles chklst_QuaterSelect.ItemCheck
        SetQuater = "and (B.QUTERDATE = "
        VRDate = " CAST(CONVERT(VARCHAR(11),DUEDATE,6) AS DATETIME) <= "
        If e.Index = 0 Then
            SetQuater = SetQuater & "'1\4\" & DTP_QUATER_YEAR.Value.Year & " TO 30\6\" & DTP_QUATER_YEAR.Value.Year & "')"
            VRDate = VRDate & " '1-APR-" & DTP_QUATER_YEAR.Value.Year & "' "
        ElseIf e.Index = 1 Then
            SetQuater = SetQuater & "'1\4\" & DTP_QUATER_YEAR.Value.Year & " TO 30\9\" & DTP_QUATER_YEAR.Value.Year & "')"
            VRDate = VRDate & " '1-JUL-" & DTP_QUATER_YEAR.Value.Year & "' "
        ElseIf e.Index = 2 Then
            SetQuater = SetQuater & "'1\10\" & DTP_QUATER_YEAR.Value.Year & " TO 31\12\" & DTP_QUATER_YEAR.Value.Year & "')"
            VRDate = VRDate & " '1-NOV-" & DTP_QUATER_YEAR.Value.Year & "' "
        ElseIf e.Index = 3 Then
            SetQuater = SetQuater & "'1\1\" & DTP_QUATER_YEAR.Value.Year & " TO 31\3\" & DTP_QUATER_YEAR.Value.Year & "')"
            VRDate = VRDate & " '1-JAN-" & DTP_QUATER_YEAR.Value.Year & "' "
        End If
    End Sub
End Class
