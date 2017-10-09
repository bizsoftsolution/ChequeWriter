<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChequeWithVoucher
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChequeWithVoucher))
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.ckbPayeename = New System.Windows.Forms.CheckBox()
        Me.ckbdate = New System.Windows.Forms.CheckBox()
        Me.txtParticulars = New System.Windows.Forms.TextBox()
        Me.txtVoucherNoNew = New System.Windows.Forms.TextBox()
        Me.ckbIsRotate90Degree = New System.Windows.Forms.CheckBox()
        Me.pnDate = New System.Windows.Forms.Panel()
        Me.txtChqD1 = New DenariuChequeWriterSoft.TransparentRichTextBox()
        Me.txtChqY2 = New DenariuChequeWriterSoft.TransparentRichTextBox()
        Me.txtChqD2 = New DenariuChequeWriterSoft.TransparentRichTextBox()
        Me.txtChqM1 = New DenariuChequeWriterSoft.TransparentRichTextBox()
        Me.txtChqM2 = New DenariuChequeWriterSoft.TransparentRichTextBox()
        Me.txtChqY1 = New DenariuChequeWriterSoft.TransparentRichTextBox()
        Me.ckbamount = New System.Windows.Forms.CheckBox()
        Me.lbChqAmountInWord1 = New System.Windows.Forms.Label()
        Me.pnlImage = New System.Windows.Forms.Panel()
        Me.txtCompanyName = New System.Windows.Forms.TextBox()
        Me.txtPayeeName = New System.Windows.Forms.TextBox()
        Me.txtBankName = New System.Windows.Forms.TextBox()
        Me.lblIssuedDate = New System.Windows.Forms.Label()
        Me.lblChequeIssueDetails = New System.Windows.Forms.Label()
        Me.cmbChequeStatus = New System.Windows.Forms.ComboBox()
        Me.imgChequePreview = New System.Windows.Forms.PictureBox()
        Me.pnlForm = New System.Windows.Forms.Panel()
        Me.pnlFooter = New System.Windows.Forms.Panel()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.pnlContent = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblPayFor = New System.Windows.Forms.Label()
        Me.lblVoucherNo = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.pnlParent = New System.Windows.Forms.Panel()
        Me.txtChqName = New DenariuChequeWriterSoft.TransparentRichTextBox()
        Me.txtChqAmount = New DenariuChequeWriterSoft.TransparentRichTextBox()
        Me.lbChqAmountInWord2 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ppnlVoucher = New System.Windows.Forms.Panel()
        Me.llblReceivedBy = New System.Windows.Forms.Label()
        Me.llblAuthorisedBy = New System.Windows.Forms.Label()
        Me.llblApprovedBy = New System.Windows.Forms.Label()
        Me.llblAmountRM = New System.Windows.Forms.Label()
        Me.imgAmount = New System.Windows.Forms.PictureBox()
        Me.llblAmount2 = New System.Windows.Forms.Label()
        Me.llblPayFor2 = New System.Windows.Forms.Label()
        Me.llblPayTo2 = New System.Windows.Forms.Label()
        Me.llblBankName2 = New System.Windows.Forms.Label()
        Me.imgLine2 = New System.Windows.Forms.PictureBox()
        Me.llblChequeStatus2 = New System.Windows.Forms.Label()
        Me.llblChequeStatus1 = New System.Windows.Forms.Label()
        Me.llblChequeNo2 = New System.Windows.Forms.Label()
        Me.llblChequeNo1 = New System.Windows.Forms.Label()
        Me.llblChequeDate2 = New System.Windows.Forms.Label()
        Me.llblChequeDate1 = New System.Windows.Forms.Label()
        Me.llblBankName1 = New System.Windows.Forms.Label()
        Me.llblAmount1 = New System.Windows.Forms.Label()
        Me.llblPayFor1 = New System.Windows.Forms.Label()
        Me.llblPayTo1 = New System.Windows.Forms.Label()
        Me.llblNo2 = New System.Windows.Forms.Label()
        Me.llblDate2 = New System.Windows.Forms.Label()
        Me.llblDate1 = New System.Windows.Forms.Label()
        Me.llblNo = New System.Windows.Forms.Label()
        Me.llblVoucherCompanyName = New System.Windows.Forms.Label()
        Me.llblVoucherTitle = New System.Windows.Forms.Label()
        Me.imgLine1 = New System.Windows.Forms.PictureBox()
        Me.llblCompanyAddress = New System.Windows.Forms.Label()
        Me.imgLogo = New System.Windows.Forms.PictureBox()
        Me.dgvChequeIssue = New System.Windows.Forms.DataGridView()
        Me.btnVoucher = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.PayeeName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CHEQUEDATE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Particulars = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BankName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IssueDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChequeStatus = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.VoucherNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblChequeStatus = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtChequeNo = New System.Windows.Forms.TextBox()
        Me.brnPrint = New System.Windows.Forms.Button()
        Me.dtpIssueDate = New System.Windows.Forms.DateTimePicker()
        Me.lblWelcomeMsg = New System.Windows.Forms.Label()
        Me.lblChequeNo = New System.Windows.Forms.Label()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.txtVoucherNo = New System.Windows.Forms.TextBox()
        Me.txtInputWords = New System.Windows.Forms.TextBox()
        Me.txtBayerName = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.lblPayeeName = New System.Windows.Forms.Label()
        Me.lblBankName = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.pnDate.SuspendLayout()
        Me.pnlImage.SuspendLayout()
        CType(Me.imgChequePreview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMain.SuspendLayout()
        Me.pnlContent.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.pnlParent.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.ppnlVoucher.SuspendLayout()
        CType(Me.imgAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgLine2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgLine1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvChequeIssue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PrintDocument1
        '
        '
        'ckbPayeename
        '
        Me.ckbPayeename.AutoSize = True
        Me.ckbPayeename.Checked = True
        Me.ckbPayeename.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckbPayeename.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckbPayeename.Location = New System.Drawing.Point(24, 49)
        Me.ckbPayeename.Name = "ckbPayeename"
        Me.ckbPayeename.Size = New System.Drawing.Size(57, 19)
        Me.ckbPayeename.TabIndex = 1
        Me.ckbPayeename.Text = "Name"
        Me.ckbPayeename.UseVisualStyleBackColor = True
        '
        'ckbdate
        '
        Me.ckbdate.AutoSize = True
        Me.ckbdate.Checked = True
        Me.ckbdate.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckbdate.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckbdate.Location = New System.Drawing.Point(24, 22)
        Me.ckbdate.Name = "ckbdate"
        Me.ckbdate.Size = New System.Drawing.Size(51, 19)
        Me.ckbdate.TabIndex = 0
        Me.ckbdate.Text = "Date"
        Me.ckbdate.UseVisualStyleBackColor = True
        '
        'txtParticulars
        '
        Me.txtParticulars.Location = New System.Drawing.Point(739, 194)
        Me.txtParticulars.Name = "txtParticulars"
        Me.txtParticulars.Size = New System.Drawing.Size(454, 20)
        Me.txtParticulars.TabIndex = 91
        '
        'txtVoucherNoNew
        '
        Me.txtVoucherNoNew.Location = New System.Drawing.Point(490, 197)
        Me.txtVoucherNoNew.Name = "txtVoucherNoNew"
        Me.txtVoucherNoNew.Size = New System.Drawing.Size(142, 20)
        Me.txtVoucherNoNew.TabIndex = 90
        '
        'ckbIsRotate90Degree
        '
        Me.ckbIsRotate90Degree.AutoSize = True
        Me.ckbIsRotate90Degree.BackColor = System.Drawing.Color.Transparent
        Me.ckbIsRotate90Degree.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ckbIsRotate90Degree.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckbIsRotate90Degree.Location = New System.Drawing.Point(1035, 3)
        Me.ckbIsRotate90Degree.Name = "ckbIsRotate90Degree"
        Me.ckbIsRotate90Degree.Size = New System.Drawing.Size(147, 20)
        Me.ckbIsRotate90Degree.TabIndex = 73
        Me.ckbIsRotate90Degree.Tag = ""
        Me.ckbIsRotate90Degree.Text = "Is Rotate 90 Degree"
        Me.ckbIsRotate90Degree.UseVisualStyleBackColor = False
        '
        'pnDate
        '
        Me.pnDate.BackColor = System.Drawing.Color.Transparent
        Me.pnDate.Controls.Add(Me.txtChqD1)
        Me.pnDate.Controls.Add(Me.txtChqY2)
        Me.pnDate.Controls.Add(Me.txtChqD2)
        Me.pnDate.Controls.Add(Me.txtChqM1)
        Me.pnDate.Controls.Add(Me.txtChqM2)
        Me.pnDate.Controls.Add(Me.txtChqY1)
        Me.pnDate.Location = New System.Drawing.Point(620, 50)
        Me.pnDate.Name = "pnDate"
        Me.pnDate.Size = New System.Drawing.Size(180, 25)
        Me.pnDate.TabIndex = 52
        '
        'txtChqD1
        '
        Me.txtChqD1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtChqD1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChqD1.ForeColor = System.Drawing.Color.Black
        Me.txtChqD1.Location = New System.Drawing.Point(0, 0)
        Me.txtChqD1.Name = "txtChqD1"
        Me.txtChqD1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.txtChqD1.Size = New System.Drawing.Size(25, 25)
        Me.txtChqD1.TabIndex = 43
        Me.txtChqD1.Text = ""
        '
        'txtChqY2
        '
        Me.txtChqY2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtChqY2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChqY2.ForeColor = System.Drawing.Color.Black
        Me.txtChqY2.Location = New System.Drawing.Point(150, 0)
        Me.txtChqY2.Name = "txtChqY2"
        Me.txtChqY2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.txtChqY2.Size = New System.Drawing.Size(25, 25)
        Me.txtChqY2.TabIndex = 42
        Me.txtChqY2.Text = ""
        '
        'txtChqD2
        '
        Me.txtChqD2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtChqD2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChqD2.ForeColor = System.Drawing.Color.Black
        Me.txtChqD2.Location = New System.Drawing.Point(30, 0)
        Me.txtChqD2.Name = "txtChqD2"
        Me.txtChqD2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.txtChqD2.Size = New System.Drawing.Size(25, 25)
        Me.txtChqD2.TabIndex = 44
        Me.txtChqD2.Text = ""
        '
        'txtChqM1
        '
        Me.txtChqM1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtChqM1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChqM1.ForeColor = System.Drawing.Color.Black
        Me.txtChqM1.Location = New System.Drawing.Point(60, 0)
        Me.txtChqM1.Name = "txtChqM1"
        Me.txtChqM1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.txtChqM1.Size = New System.Drawing.Size(25, 25)
        Me.txtChqM1.TabIndex = 45
        Me.txtChqM1.Text = ""
        '
        'txtChqM2
        '
        Me.txtChqM2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtChqM2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChqM2.ForeColor = System.Drawing.Color.Black
        Me.txtChqM2.Location = New System.Drawing.Point(88, 0)
        Me.txtChqM2.Name = "txtChqM2"
        Me.txtChqM2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.txtChqM2.Size = New System.Drawing.Size(25, 25)
        Me.txtChqM2.TabIndex = 46
        Me.txtChqM2.Text = ""
        '
        'txtChqY1
        '
        Me.txtChqY1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtChqY1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChqY1.ForeColor = System.Drawing.Color.Black
        Me.txtChqY1.Location = New System.Drawing.Point(118, 0)
        Me.txtChqY1.Name = "txtChqY1"
        Me.txtChqY1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.txtChqY1.Size = New System.Drawing.Size(25, 25)
        Me.txtChqY1.TabIndex = 47
        Me.txtChqY1.Text = ""
        '
        'ckbamount
        '
        Me.ckbamount.AutoSize = True
        Me.ckbamount.Checked = True
        Me.ckbamount.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckbamount.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckbamount.Location = New System.Drawing.Point(24, 76)
        Me.ckbamount.Name = "ckbamount"
        Me.ckbamount.Size = New System.Drawing.Size(69, 19)
        Me.ckbamount.TabIndex = 2
        Me.ckbamount.Text = "Amount"
        Me.ckbamount.UseVisualStyleBackColor = True
        '
        'lbChqAmountInWord1
        '
        Me.lbChqAmountInWord1.BackColor = System.Drawing.Color.Transparent
        Me.lbChqAmountInWord1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbChqAmountInWord1.ForeColor = System.Drawing.Color.Black
        Me.lbChqAmountInWord1.Location = New System.Drawing.Point(65, 158)
        Me.lbChqAmountInWord1.Name = "lbChqAmountInWord1"
        Me.lbChqAmountInWord1.Size = New System.Drawing.Size(547, 30)
        Me.lbChqAmountInWord1.TabIndex = 48
        '
        'pnlImage
        '
        Me.pnlImage.BackColor = System.Drawing.Color.Transparent
        Me.pnlImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlImage.Controls.Add(Me.txtCompanyName)
        Me.pnlImage.Location = New System.Drawing.Point(1078, 167)
        Me.pnlImage.Name = "pnlImage"
        Me.pnlImage.Size = New System.Drawing.Size(669, 220)
        Me.pnlImage.TabIndex = 55
        Me.pnlImage.Visible = False
        '
        'txtCompanyName
        '
        Me.txtCompanyName.Location = New System.Drawing.Point(20, 77)
        Me.txtCompanyName.Name = "txtCompanyName"
        Me.txtCompanyName.Size = New System.Drawing.Size(87, 20)
        Me.txtCompanyName.TabIndex = 71
        Me.txtCompanyName.Visible = False
        '
        'txtPayeeName
        '
        Me.txtPayeeName.Location = New System.Drawing.Point(120, 48)
        Me.txtPayeeName.Name = "txtPayeeName"
        Me.txtPayeeName.Size = New System.Drawing.Size(282, 20)
        Me.txtPayeeName.TabIndex = 96
        '
        'txtBankName
        '
        Me.txtBankName.Location = New System.Drawing.Point(120, 13)
        Me.txtBankName.Name = "txtBankName"
        Me.txtBankName.Size = New System.Drawing.Size(282, 20)
        Me.txtBankName.TabIndex = 95
        '
        'lblIssuedDate
        '
        Me.lblIssuedDate.AutoSize = True
        Me.lblIssuedDate.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIssuedDate.Location = New System.Drawing.Point(926, 222)
        Me.lblIssuedDate.Name = "lblIssuedDate"
        Me.lblIssuedDate.Size = New System.Drawing.Size(87, 17)
        Me.lblIssuedDate.TabIndex = 94
        Me.lblIssuedDate.Text = "Issued Date"
        '
        'lblChequeIssueDetails
        '
        Me.lblChequeIssueDetails.AutoSize = True
        Me.lblChequeIssueDetails.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChequeIssueDetails.Location = New System.Drawing.Point(408, 10)
        Me.lblChequeIssueDetails.Name = "lblChequeIssueDetails"
        Me.lblChequeIssueDetails.Size = New System.Drawing.Size(149, 17)
        Me.lblChequeIssueDetails.TabIndex = 58
        Me.lblChequeIssueDetails.Text = "Cheque Issue Details"
        '
        'cmbChequeStatus
        '
        Me.cmbChequeStatus.FormattingEnabled = True
        Me.cmbChequeStatus.Items.AddRange(New Object() {"Draft Cheque", "Issued Cheque", "Cancel Cheque"})
        Me.cmbChequeStatus.Location = New System.Drawing.Point(739, 222)
        Me.cmbChequeStatus.Name = "cmbChequeStatus"
        Me.cmbChequeStatus.Size = New System.Drawing.Size(183, 21)
        Me.cmbChequeStatus.TabIndex = 93
        '
        'imgChequePreview
        '
        Me.imgChequePreview.BackColor = System.Drawing.Color.Gainsboro
        Me.imgChequePreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.imgChequePreview.Location = New System.Drawing.Point(0, 0)
        Me.imgChequePreview.Name = "imgChequePreview"
        Me.imgChequePreview.Size = New System.Drawing.Size(1035, 320)
        Me.imgChequePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.imgChequePreview.TabIndex = 89
        Me.imgChequePreview.TabStop = False
        '
        'pnlForm
        '
        Me.pnlForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlForm.Location = New System.Drawing.Point(0, 0)
        Me.pnlForm.Name = "pnlForm"
        Me.pnlForm.Size = New System.Drawing.Size(1214, 640)
        Me.pnlForm.TabIndex = 3
        '
        'pnlFooter
        '
        Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlFooter.Location = New System.Drawing.Point(0, 683)
        Me.pnlFooter.Name = "pnlFooter"
        Me.pnlFooter.Size = New System.Drawing.Size(1214, 10)
        Me.pnlFooter.TabIndex = 1
        '
        'pnlMain
        '
        Me.pnlMain.Controls.Add(Me.pnlContent)
        Me.pnlMain.Controls.Add(Me.pnlFooter)
        Me.pnlMain.Controls.Add(Me.pnlHeader)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(0, 0)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(1214, 693)
        Me.pnlMain.TabIndex = 10
        '
        'pnlContent
        '
        Me.pnlContent.AutoScroll = True
        Me.pnlContent.Controls.Add(Me.Panel1)
        Me.pnlContent.Controls.Add(Me.pnlForm)
        Me.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContent.Location = New System.Drawing.Point(0, 43)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Size = New System.Drawing.Size(1214, 640)
        Me.pnlContent.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.txtVoucherNoNew)
        Me.Panel1.Controls.Add(Me.txtParticulars)
        Me.Panel1.Controls.Add(Me.lblPayFor)
        Me.Panel1.Controls.Add(Me.lblVoucherNo)
        Me.Panel1.Controls.Add(Me.TabControl1)
        Me.Panel1.Controls.Add(Me.txtPayeeName)
        Me.Panel1.Controls.Add(Me.txtBankName)
        Me.Panel1.Controls.Add(Me.lblIssuedDate)
        Me.Panel1.Controls.Add(Me.lblChequeIssueDetails)
        Me.Panel1.Controls.Add(Me.cmbChequeStatus)
        Me.Panel1.Controls.Add(Me.dgvChequeIssue)
        Me.Panel1.Controls.Add(Me.lblChequeStatus)
        Me.Panel1.Controls.Add(Me.btnExit)
        Me.Panel1.Controls.Add(Me.txtChequeNo)
        Me.Panel1.Controls.Add(Me.brnPrint)
        Me.Panel1.Controls.Add(Me.dtpIssueDate)
        Me.Panel1.Controls.Add(Me.lblWelcomeMsg)
        Me.Panel1.Controls.Add(Me.lblChequeNo)
        Me.Panel1.Controls.Add(Me.dtpDate)
        Me.Panel1.Controls.Add(Me.txtVoucherNo)
        Me.Panel1.Controls.Add(Me.txtInputWords)
        Me.Panel1.Controls.Add(Me.txtBayerName)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.MonthCalendar1)
        Me.Panel1.Controls.Add(Me.lblPayeeName)
        Me.Panel1.Controls.Add(Me.lblBankName)
        Me.Panel1.Controls.Add(Me.txtAmount)
        Me.Panel1.Location = New System.Drawing.Point(12, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1202, 637)
        Me.Panel1.TabIndex = 58
        '
        'lblPayFor
        '
        Me.lblPayFor.AutoSize = True
        Me.lblPayFor.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayFor.Location = New System.Drawing.Point(635, 197)
        Me.lblPayFor.Name = "lblPayFor"
        Me.lblPayFor.Size = New System.Drawing.Size(58, 17)
        Me.lblPayFor.TabIndex = 100
        Me.lblPayFor.Text = "Pay For"
        '
        'lblVoucherNo
        '
        Me.lblVoucherNo.AutoSize = True
        Me.lblVoucherNo.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVoucherNo.Location = New System.Drawing.Point(405, 197)
        Me.lblVoucherNo.Name = "lblVoucherNo"
        Me.lblVoucherNo.Size = New System.Drawing.Size(85, 17)
        Me.lblVoucherNo.TabIndex = 98
        Me.lblVoucherNo.Text = "Voucher No"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(7, 259)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1186, 377)
        Me.TabControl1.TabIndex = 97
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.pnlParent)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1178, 351)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "CHEQUE"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'pnlParent
        '
        Me.pnlParent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlParent.Controls.Add(Me.ckbIsRotate90Degree)
        Me.pnlParent.Controls.Add(Me.pnDate)
        Me.pnlParent.Controls.Add(Me.txtChqName)
        Me.pnlParent.Controls.Add(Me.txtChqAmount)
        Me.pnlParent.Controls.Add(Me.lbChqAmountInWord1)
        Me.pnlParent.Controls.Add(Me.lbChqAmountInWord2)
        Me.pnlParent.Controls.Add(Me.pnlImage)
        Me.pnlParent.Controls.Add(Me.imgChequePreview)
        Me.pnlParent.Location = New System.Drawing.Point(0, 2)
        Me.pnlParent.Name = "pnlParent"
        Me.pnlParent.Size = New System.Drawing.Size(1180, 368)
        Me.pnlParent.TabIndex = 56
        '
        'txtChqName
        '
        Me.txtChqName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtChqName.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChqName.ForeColor = System.Drawing.Color.Black
        Me.txtChqName.Location = New System.Drawing.Point(100, 75)
        Me.txtChqName.Multiline = False
        Me.txtChqName.Name = "txtChqName"
        Me.txtChqName.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.txtChqName.Size = New System.Drawing.Size(340, 23)
        Me.txtChqName.TabIndex = 49
        Me.txtChqName.Text = ""
        '
        'txtChqAmount
        '
        Me.txtChqAmount.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtChqAmount.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChqAmount.ForeColor = System.Drawing.Color.Black
        Me.txtChqAmount.Location = New System.Drawing.Point(652, 120)
        Me.txtChqAmount.Name = "txtChqAmount"
        Me.txtChqAmount.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.txtChqAmount.Size = New System.Drawing.Size(164, 23)
        Me.txtChqAmount.TabIndex = 48
        Me.txtChqAmount.Text = ""
        '
        'lbChqAmountInWord2
        '
        Me.lbChqAmountInWord2.BackColor = System.Drawing.Color.Transparent
        Me.lbChqAmountInWord2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbChqAmountInWord2.ForeColor = System.Drawing.Color.Black
        Me.lbChqAmountInWord2.Location = New System.Drawing.Point(44, 210)
        Me.lbChqAmountInWord2.Name = "lbChqAmountInWord2"
        Me.lbChqAmountInWord2.Size = New System.Drawing.Size(547, 30)
        Me.lbChqAmountInWord2.TabIndex = 53
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.Add(Me.ppnlVoucher)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1178, 351)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "VOUCHER"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ppnlVoucher
        '
        Me.ppnlVoucher.Controls.Add(Me.llblReceivedBy)
        Me.ppnlVoucher.Controls.Add(Me.llblAuthorisedBy)
        Me.ppnlVoucher.Controls.Add(Me.llblApprovedBy)
        Me.ppnlVoucher.Controls.Add(Me.llblAmountRM)
        Me.ppnlVoucher.Controls.Add(Me.imgAmount)
        Me.ppnlVoucher.Controls.Add(Me.llblAmount2)
        Me.ppnlVoucher.Controls.Add(Me.llblPayFor2)
        Me.ppnlVoucher.Controls.Add(Me.llblPayTo2)
        Me.ppnlVoucher.Controls.Add(Me.llblBankName2)
        Me.ppnlVoucher.Controls.Add(Me.imgLine2)
        Me.ppnlVoucher.Controls.Add(Me.llblChequeStatus2)
        Me.ppnlVoucher.Controls.Add(Me.llblChequeStatus1)
        Me.ppnlVoucher.Controls.Add(Me.llblChequeNo2)
        Me.ppnlVoucher.Controls.Add(Me.llblChequeNo1)
        Me.ppnlVoucher.Controls.Add(Me.llblChequeDate2)
        Me.ppnlVoucher.Controls.Add(Me.llblChequeDate1)
        Me.ppnlVoucher.Controls.Add(Me.llblBankName1)
        Me.ppnlVoucher.Controls.Add(Me.llblAmount1)
        Me.ppnlVoucher.Controls.Add(Me.llblPayFor1)
        Me.ppnlVoucher.Controls.Add(Me.llblPayTo1)
        Me.ppnlVoucher.Controls.Add(Me.llblNo2)
        Me.ppnlVoucher.Controls.Add(Me.llblDate2)
        Me.ppnlVoucher.Controls.Add(Me.llblDate1)
        Me.ppnlVoucher.Controls.Add(Me.llblNo)
        Me.ppnlVoucher.Controls.Add(Me.llblVoucherCompanyName)
        Me.ppnlVoucher.Controls.Add(Me.llblVoucherTitle)
        Me.ppnlVoucher.Controls.Add(Me.imgLine1)
        Me.ppnlVoucher.Controls.Add(Me.llblCompanyAddress)
        Me.ppnlVoucher.Controls.Add(Me.imgLogo)
        Me.ppnlVoucher.ForeColor = System.Drawing.Color.Black
        Me.ppnlVoucher.Location = New System.Drawing.Point(1, 1)
        Me.ppnlVoucher.Name = "ppnlVoucher"
        Me.ppnlVoucher.Size = New System.Drawing.Size(928, 552)
        Me.ppnlVoucher.TabIndex = 0
        '
        'llblReceivedBy
        '
        Me.llblReceivedBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llblReceivedBy.Location = New System.Drawing.Point(622, 499)
        Me.llblReceivedBy.Name = "llblReceivedBy"
        Me.llblReceivedBy.Size = New System.Drawing.Size(107, 23)
        Me.llblReceivedBy.TabIndex = 28
        Me.llblReceivedBy.Text = "Received By"
        '
        'llblAuthorisedBy
        '
        Me.llblAuthorisedBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llblAuthorisedBy.Location = New System.Drawing.Point(422, 499)
        Me.llblAuthorisedBy.Name = "llblAuthorisedBy"
        Me.llblAuthorisedBy.Size = New System.Drawing.Size(107, 23)
        Me.llblAuthorisedBy.TabIndex = 27
        Me.llblAuthorisedBy.Text = "Authorised By"
        '
        'llblApprovedBy
        '
        Me.llblApprovedBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llblApprovedBy.Location = New System.Drawing.Point(236, 499)
        Me.llblApprovedBy.Name = "llblApprovedBy"
        Me.llblApprovedBy.Size = New System.Drawing.Size(107, 23)
        Me.llblApprovedBy.TabIndex = 26
        Me.llblApprovedBy.Text = "Approved By"
        '
        'llblAmountRM
        '
        Me.llblAmountRM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llblAmountRM.Location = New System.Drawing.Point(73, 492)
        Me.llblAmountRM.Name = "llblAmountRM"
        Me.llblAmountRM.Size = New System.Drawing.Size(107, 23)
        Me.llblAmountRM.TabIndex = 24
        '
        'imgAmount
        '
        Me.imgAmount.BackgroundImage = Global.DenariuChequeWriterSoft.My.Resources.Resources.AmountRM
        Me.imgAmount.Location = New System.Drawing.Point(29, 472)
        Me.imgAmount.Name = "imgAmount"
        Me.imgAmount.Size = New System.Drawing.Size(175, 50)
        Me.imgAmount.TabIndex = 25
        Me.imgAmount.TabStop = False
        '
        'llblAmount2
        '
        Me.llblAmount2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llblAmount2.Location = New System.Drawing.Point(136, 312)
        Me.llblAmount2.Name = "llblAmount2"
        Me.llblAmount2.Size = New System.Drawing.Size(593, 50)
        Me.llblAmount2.TabIndex = 23
        '
        'llblPayFor2
        '
        Me.llblPayFor2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llblPayFor2.Location = New System.Drawing.Point(136, 254)
        Me.llblPayFor2.Name = "llblPayFor2"
        Me.llblPayFor2.Size = New System.Drawing.Size(593, 50)
        Me.llblPayFor2.TabIndex = 22
        '
        'llblPayTo2
        '
        Me.llblPayTo2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llblPayTo2.Location = New System.Drawing.Point(136, 223)
        Me.llblPayTo2.Name = "llblPayTo2"
        Me.llblPayTo2.Size = New System.Drawing.Size(593, 16)
        Me.llblPayTo2.TabIndex = 21
        '
        'llblBankName2
        '
        Me.llblBankName2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llblBankName2.Location = New System.Drawing.Point(136, 381)
        Me.llblBankName2.Name = "llblBankName2"
        Me.llblBankName2.Size = New System.Drawing.Size(593, 16)
        Me.llblBankName2.TabIndex = 20
        '
        'imgLine2
        '
        Me.imgLine2.BackColor = System.Drawing.Color.Silver
        Me.imgLine2.Location = New System.Drawing.Point(29, 443)
        Me.imgLine2.Name = "imgLine2"
        Me.imgLine2.Size = New System.Drawing.Size(700, 2)
        Me.imgLine2.TabIndex = 19
        Me.imgLine2.TabStop = False
        '
        'llblChequeStatus2
        '
        Me.llblChequeStatus2.AutoSize = True
        Me.llblChequeStatus2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llblChequeStatus2.Location = New System.Drawing.Point(603, 412)
        Me.llblChequeStatus2.Name = "llblChequeStatus2"
        Me.llblChequeStatus2.Size = New System.Drawing.Size(0, 16)
        Me.llblChequeStatus2.TabIndex = 18
        '
        'llblChequeStatus1
        '
        Me.llblChequeStatus1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llblChequeStatus1.Location = New System.Drawing.Point(478, 412)
        Me.llblChequeStatus1.Name = "llblChequeStatus1"
        Me.llblChequeStatus1.Size = New System.Drawing.Size(125, 23)
        Me.llblChequeStatus1.TabIndex = 17
        Me.llblChequeStatus1.Text = "Cheque Status : "
        '
        'llblChequeNo2
        '
        Me.llblChequeNo2.AutoSize = True
        Me.llblChequeNo2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llblChequeNo2.Location = New System.Drawing.Point(358, 412)
        Me.llblChequeNo2.Name = "llblChequeNo2"
        Me.llblChequeNo2.Size = New System.Drawing.Size(0, 16)
        Me.llblChequeNo2.TabIndex = 16
        '
        'llblChequeNo1
        '
        Me.llblChequeNo1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llblChequeNo1.Location = New System.Drawing.Point(261, 412)
        Me.llblChequeNo1.Name = "llblChequeNo1"
        Me.llblChequeNo1.Size = New System.Drawing.Size(97, 23)
        Me.llblChequeNo1.TabIndex = 15
        Me.llblChequeNo1.Text = "Cheque No : "
        '
        'llblChequeDate2
        '
        Me.llblChequeDate2.AutoSize = True
        Me.llblChequeDate2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llblChequeDate2.Location = New System.Drawing.Point(136, 412)
        Me.llblChequeDate2.Name = "llblChequeDate2"
        Me.llblChequeDate2.Size = New System.Drawing.Size(0, 16)
        Me.llblChequeDate2.TabIndex = 14
        '
        'llblChequeDate1
        '
        Me.llblChequeDate1.AutoSize = True
        Me.llblChequeDate1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llblChequeDate1.Location = New System.Drawing.Point(29, 412)
        Me.llblChequeDate1.Name = "llblChequeDate1"
        Me.llblChequeDate1.Size = New System.Drawing.Size(110, 16)
        Me.llblChequeDate1.TabIndex = 13
        Me.llblChequeDate1.Text = "Cheque Date : "
        '
        'llblBankName1
        '
        Me.llblBankName1.AutoSize = True
        Me.llblBankName1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llblBankName1.Location = New System.Drawing.Point(29, 381)
        Me.llblBankName1.Name = "llblBankName1"
        Me.llblBankName1.Size = New System.Drawing.Size(88, 16)
        Me.llblBankName1.TabIndex = 12
        Me.llblBankName1.Text = "Bank Name"
        '
        'llblAmount1
        '
        Me.llblAmount1.AutoSize = True
        Me.llblAmount1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llblAmount1.Location = New System.Drawing.Point(29, 312)
        Me.llblAmount1.Name = "llblAmount1"
        Me.llblAmount1.Size = New System.Drawing.Size(59, 16)
        Me.llblAmount1.TabIndex = 11
        Me.llblAmount1.Text = "Amount"
        '
        'llblPayFor1
        '
        Me.llblPayFor1.AutoSize = True
        Me.llblPayFor1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llblPayFor1.Location = New System.Drawing.Point(29, 254)
        Me.llblPayFor1.Name = "llblPayFor1"
        Me.llblPayFor1.Size = New System.Drawing.Size(62, 16)
        Me.llblPayFor1.TabIndex = 10
        Me.llblPayFor1.Text = "Pay For"
        '
        'llblPayTo1
        '
        Me.llblPayTo1.AutoSize = True
        Me.llblPayTo1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llblPayTo1.Location = New System.Drawing.Point(29, 223)
        Me.llblPayTo1.Name = "llblPayTo1"
        Me.llblPayTo1.Size = New System.Drawing.Size(58, 16)
        Me.llblPayTo1.TabIndex = 9
        Me.llblPayTo1.Text = "Pay To"
        '
        'llblNo2
        '
        Me.llblNo2.AutoSize = True
        Me.llblNo2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llblNo2.Location = New System.Drawing.Point(73, 192)
        Me.llblNo2.Name = "llblNo2"
        Me.llblNo2.Size = New System.Drawing.Size(0, 16)
        Me.llblNo2.TabIndex = 8
        Me.llblNo2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'llblDate2
        '
        Me.llblDate2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llblDate2.Location = New System.Drawing.Point(612, 192)
        Me.llblDate2.Name = "llblDate2"
        Me.llblDate2.Size = New System.Drawing.Size(117, 23)
        Me.llblDate2.TabIndex = 7
        Me.llblDate2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'llblDate1
        '
        Me.llblDate1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llblDate1.Location = New System.Drawing.Point(553, 192)
        Me.llblDate1.Name = "llblDate1"
        Me.llblDate1.Size = New System.Drawing.Size(53, 23)
        Me.llblDate1.TabIndex = 6
        Me.llblDate1.Text = "Date : "
        Me.llblDate1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'llblNo
        '
        Me.llblNo.AutoSize = True
        Me.llblNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llblNo.Location = New System.Drawing.Point(29, 192)
        Me.llblNo.Name = "llblNo"
        Me.llblNo.Size = New System.Drawing.Size(36, 16)
        Me.llblNo.TabIndex = 5
        Me.llblNo.Text = "No :"
        '
        'llblVoucherCompanyName
        '
        Me.llblVoucherCompanyName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llblVoucherCompanyName.Location = New System.Drawing.Point(251, 21)
        Me.llblVoucherCompanyName.Name = "llblVoucherCompanyName"
        Me.llblVoucherCompanyName.Size = New System.Drawing.Size(478, 24)
        Me.llblVoucherCompanyName.TabIndex = 4
        Me.llblVoucherCompanyName.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'llblVoucherTitle
        '
        Me.llblVoucherTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llblVoucherTitle.Location = New System.Drawing.Point(29, 151)
        Me.llblVoucherTitle.Name = "llblVoucherTitle"
        Me.llblVoucherTitle.Size = New System.Drawing.Size(700, 24)
        Me.llblVoucherTitle.TabIndex = 3
        Me.llblVoucherTitle.Text = "Payment Voucher"
        Me.llblVoucherTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'imgLine1
        '
        Me.imgLine1.BackColor = System.Drawing.Color.Silver
        Me.imgLine1.Location = New System.Drawing.Point(29, 136)
        Me.imgLine1.Name = "imgLine1"
        Me.imgLine1.Size = New System.Drawing.Size(700, 2)
        Me.imgLine1.TabIndex = 2
        Me.imgLine1.TabStop = False
        '
        'llblCompanyAddress
        '
        Me.llblCompanyAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llblCompanyAddress.Location = New System.Drawing.Point(251, 45)
        Me.llblCompanyAddress.Name = "llblCompanyAddress"
        Me.llblCompanyAddress.Size = New System.Drawing.Size(478, 85)
        Me.llblCompanyAddress.TabIndex = 1
        Me.llblCompanyAddress.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'imgLogo
        '
        Me.imgLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.imgLogo.Location = New System.Drawing.Point(29, 17)
        Me.imgLogo.Name = "imgLogo"
        Me.imgLogo.Size = New System.Drawing.Size(134, 113)
        Me.imgLogo.TabIndex = 0
        Me.imgLogo.TabStop = False
        '
        'dgvChequeIssue
        '
        Me.dgvChequeIssue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvChequeIssue.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.btnVoucher, Me.PayeeName, Me.Amount, Me.CHEQUEDATE, Me.Particulars, Me.BankName, Me.IssueDate, Me.ChequeStatus, Me.VoucherNo})
        Me.dgvChequeIssue.Location = New System.Drawing.Point(411, 30)
        Me.dgvChequeIssue.Name = "dgvChequeIssue"
        Me.dgvChequeIssue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvChequeIssue.Size = New System.Drawing.Size(785, 161)
        Me.dgvChequeIssue.TabIndex = 0
        '
        'btnVoucher
        '
        Me.btnVoucher.HeaderText = "VOUCHER"
        Me.btnVoucher.Name = "btnVoucher"
        Me.btnVoucher.Width = 90
        '
        'PayeeName
        '
        Me.PayeeName.HeaderText = "PAYEE NAME"
        Me.PayeeName.Name = "PayeeName"
        Me.PayeeName.ReadOnly = True
        Me.PayeeName.Width = 140
        '
        'Amount
        '
        Me.Amount.HeaderText = "AMOUNT"
        Me.Amount.Name = "Amount"
        Me.Amount.ReadOnly = True
        '
        'CHEQUEDATE
        '
        Me.CHEQUEDATE.HeaderText = "CHQ DATE"
        Me.CHEQUEDATE.Name = "CHEQUEDATE"
        Me.CHEQUEDATE.ReadOnly = True
        Me.CHEQUEDATE.Width = 95
        '
        'Particulars
        '
        Me.Particulars.HeaderText = "PAY FOR"
        Me.Particulars.Name = "Particulars"
        Me.Particulars.Width = 300
        '
        'BankName
        '
        Me.BankName.HeaderText = "BANK NAME"
        Me.BankName.Name = "BankName"
        Me.BankName.ReadOnly = True
        Me.BankName.Width = 150
        '
        'IssueDate
        '
        Me.IssueDate.HeaderText = "ISSUE DATE"
        Me.IssueDate.Name = "IssueDate"
        Me.IssueDate.ReadOnly = True
        Me.IssueDate.Width = 98
        '
        'ChequeStatus
        '
        Me.ChequeStatus.DisplayStyleForCurrentCellOnly = True
        Me.ChequeStatus.HeaderText = "STATUS"
        Me.ChequeStatus.Items.AddRange(New Object() {"Draft Cheque", "Issued Cheque", "Cancel Cheque"})
        Me.ChequeStatus.Name = "ChequeStatus"
        Me.ChequeStatus.Width = 105
        '
        'VoucherNo
        '
        Me.VoucherNo.HeaderText = "VoucherNo"
        Me.VoucherNo.Name = "VoucherNo"
        Me.VoucherNo.ReadOnly = True
        Me.VoucherNo.Visible = False
        '
        'lblChequeStatus
        '
        Me.lblChequeStatus.AutoSize = True
        Me.lblChequeStatus.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChequeStatus.Location = New System.Drawing.Point(633, 223)
        Me.lblChequeStatus.Name = "lblChequeStatus"
        Me.lblChequeStatus.Size = New System.Drawing.Size(103, 17)
        Me.lblChequeStatus.TabIndex = 92
        Me.lblChequeStatus.Text = "Cheque Status"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.White
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Image = Global.DenariuChequeWriterSoft.My.Resources.Resources.exit_32
        Me.btnExit.Location = New System.Drawing.Point(91, 192)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(84, 49)
        Me.btnExit.TabIndex = 72
        Me.btnExit.Text = " E&XIT"
        Me.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'txtChequeNo
        '
        Me.txtChequeNo.Location = New System.Drawing.Point(490, 223)
        Me.txtChequeNo.MaxLength = 10
        Me.txtChequeNo.Name = "txtChequeNo"
        Me.txtChequeNo.Size = New System.Drawing.Size(142, 20)
        Me.txtChequeNo.TabIndex = 91
        '
        'brnPrint
        '
        Me.brnPrint.BackColor = System.Drawing.Color.White
        Me.brnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.brnPrint.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.brnPrint.Image = Global.DenariuChequeWriterSoft.My.Resources.Resources.print_cheque_32
        Me.brnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.brnPrint.Location = New System.Drawing.Point(7, 192)
        Me.brnPrint.Name = "brnPrint"
        Me.brnPrint.Size = New System.Drawing.Size(83, 48)
        Me.brnPrint.TabIndex = 60
        Me.brnPrint.Text = "&PRINT"
        Me.brnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.brnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.brnPrint.UseVisualStyleBackColor = False
        '
        'dtpIssueDate
        '
        Me.dtpIssueDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpIssueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpIssueDate.Location = New System.Drawing.Point(1016, 222)
        Me.dtpIssueDate.Name = "dtpIssueDate"
        Me.dtpIssueDate.Size = New System.Drawing.Size(177, 20)
        Me.dtpIssueDate.TabIndex = 70
        '
        'lblWelcomeMsg
        '
        Me.lblWelcomeMsg.AutoSize = True
        Me.lblWelcomeMsg.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcomeMsg.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblWelcomeMsg.Location = New System.Drawing.Point(907, 527)
        Me.lblWelcomeMsg.Name = "lblWelcomeMsg"
        Me.lblWelcomeMsg.Size = New System.Drawing.Size(0, 22)
        Me.lblWelcomeMsg.TabIndex = 59
        '
        'lblChequeNo
        '
        Me.lblChequeNo.AutoSize = True
        Me.lblChequeNo.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChequeNo.Location = New System.Drawing.Point(405, 223)
        Me.lblChequeNo.Name = "lblChequeNo"
        Me.lblChequeNo.Size = New System.Drawing.Size(82, 17)
        Me.lblChequeNo.TabIndex = 90
        Me.lblChequeNo.Text = "Cheque No"
        '
        'dtpDate
        '
        Me.dtpDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDate.Location = New System.Drawing.Point(414, 163)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(73, 20)
        Me.dtpDate.TabIndex = 69
        Me.dtpDate.Visible = False
        '
        'txtVoucherNo
        '
        Me.txtVoucherNo.Location = New System.Drawing.Point(415, 249)
        Me.txtVoucherNo.Name = "txtVoucherNo"
        Me.txtVoucherNo.Size = New System.Drawing.Size(142, 20)
        Me.txtVoucherNo.TabIndex = 68
        Me.txtVoucherNo.Visible = False
        '
        'txtInputWords
        '
        Me.txtInputWords.Location = New System.Drawing.Point(680, 166)
        Me.txtInputWords.Name = "txtInputWords"
        Me.txtInputWords.Size = New System.Drawing.Size(87, 20)
        Me.txtInputWords.TabIndex = 67
        Me.txtInputWords.Visible = False
        '
        'txtBayerName
        '
        Me.txtBayerName.Location = New System.Drawing.Point(801, 149)
        Me.txtBayerName.Name = "txtBayerName"
        Me.txtBayerName.Size = New System.Drawing.Size(87, 20)
        Me.txtBayerName.TabIndex = 66
        Me.txtBayerName.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ckbamount)
        Me.GroupBox1.Controls.Add(Me.ckbPayeename)
        Me.GroupBox1.Controls.Add(Me.ckbdate)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(19, 85)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(147, 101)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Display"
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(175, 85)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 0
        '
        'lblPayeeName
        '
        Me.lblPayeeName.AutoSize = True
        Me.lblPayeeName.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayeeName.Location = New System.Drawing.Point(19, 51)
        Me.lblPayeeName.Name = "lblPayeeName"
        Me.lblPayeeName.Size = New System.Drawing.Size(89, 17)
        Me.lblPayeeName.TabIndex = 2
        Me.lblPayeeName.Text = "Payee Name"
        '
        'lblBankName
        '
        Me.lblBankName.AutoSize = True
        Me.lblBankName.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBankName.Location = New System.Drawing.Point(19, 13)
        Me.lblBankName.Name = "lblBankName"
        Me.lblBankName.Size = New System.Drawing.Size(85, 17)
        Me.lblBankName.TabIndex = 0
        Me.lblBankName.Text = "Bank Name"
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(0, 0)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(87, 20)
        Me.txtAmount.TabIndex = 65
        Me.txtAmount.Visible = False
        '
        'pnlHeader
        '
        Me.pnlHeader.AutoScroll = True
        Me.pnlHeader.Controls.Add(Me.TextBox3)
        Me.pnlHeader.Controls.Add(Me.TextBox2)
        Me.pnlHeader.Controls.Add(Me.TextBox1)
        Me.pnlHeader.Controls.Add(Me.lblHeading)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1214, 43)
        Me.pnlHeader.TabIndex = 0
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(345, 15)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 3
        Me.TextBox3.Text = "-580"
        Me.TextBox3.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(239, 15)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 2
        Me.TextBox2.Text = "-10"
        Me.TextBox2.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(125, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = "90"
        Me.TextBox1.Visible = False
        '
        'lblHeading
        '
        Me.lblHeading.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblHeading.Location = New System.Drawing.Point(0, 0)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(1214, 43)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "PRINT CHEQUE WITH VOUCHER"
        Me.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 200
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'frmChequeWithVoucher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1214, 693)
        Me.Controls.Add(Me.pnlMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmChequeWithVoucher"
        Me.pnDate.ResumeLayout(False)
        Me.pnlImage.ResumeLayout(False)
        Me.pnlImage.PerformLayout()
        CType(Me.imgChequePreview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMain.ResumeLayout(False)
        Me.pnlContent.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.pnlParent.ResumeLayout(False)
        Me.pnlParent.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.ppnlVoucher.ResumeLayout(False)
        Me.ppnlVoucher.PerformLayout()
        CType(Me.imgAmount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgLine2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgLine1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvChequeIssue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents ckbPayeename As CheckBox
    Friend WithEvents ckbdate As CheckBox
    Friend WithEvents txtParticulars As TextBox
    Friend WithEvents txtVoucherNoNew As TextBox
    Friend WithEvents ckbIsRotate90Degree As CheckBox
    Friend WithEvents pnDate As Panel
    Friend WithEvents txtChqD1 As TransparentRichTextBox
    Friend WithEvents txtChqY2 As TransparentRichTextBox
    Friend WithEvents txtChqD2 As TransparentRichTextBox
    Friend WithEvents txtChqM1 As TransparentRichTextBox
    Friend WithEvents txtChqM2 As TransparentRichTextBox
    Friend WithEvents txtChqY1 As TransparentRichTextBox
    Friend WithEvents txtChqName As TransparentRichTextBox
    Friend WithEvents txtChqAmount As TransparentRichTextBox
    Friend WithEvents ckbamount As CheckBox
    Friend WithEvents lbChqAmountInWord1 As Label
    Friend WithEvents pnlImage As Panel
    Friend WithEvents txtCompanyName As TextBox
    Friend WithEvents txtPayeeName As TextBox
    Friend WithEvents txtBankName As TextBox
    Friend WithEvents lblIssuedDate As Label
    Friend WithEvents lblChequeIssueDetails As Label
    Friend WithEvents cmbChequeStatus As ComboBox
    Friend WithEvents imgChequePreview As PictureBox
    Friend WithEvents pnlForm As Panel
    Friend WithEvents pnlFooter As Panel
    Friend WithEvents pnlMain As Panel
    Friend WithEvents pnlContent As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgvChequeIssue As DataGridView
    Friend WithEvents btnVoucher As DataGridViewButtonColumn
    Friend WithEvents PayeeName As DataGridViewTextBoxColumn
    Friend WithEvents Amount As DataGridViewTextBoxColumn
    Friend WithEvents CHEQUEDATE As DataGridViewTextBoxColumn
    Friend WithEvents Particulars As DataGridViewTextBoxColumn
    Friend WithEvents BankName As DataGridViewTextBoxColumn
    Friend WithEvents IssueDate As DataGridViewTextBoxColumn
    Friend WithEvents ChequeStatus As DataGridViewComboBoxColumn
    Friend WithEvents VoucherNo As DataGridViewTextBoxColumn
    Friend WithEvents lblChequeStatus As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents txtChequeNo As TextBox
    Friend WithEvents brnPrint As Button
    Friend WithEvents dtpIssueDate As DateTimePicker
    Friend WithEvents lblWelcomeMsg As Label
    Friend WithEvents lblChequeNo As Label
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents txtVoucherNo As TextBox
    Friend WithEvents txtInputWords As TextBox
    Friend WithEvents txtBayerName As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents lblPayeeName As Label
    Friend WithEvents lblBankName As Label
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents pnlParent As Panel
    Friend WithEvents lbChqAmountInWord2 As Label
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblHeading As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents ppnlVoucher As Panel
    Friend WithEvents imgLine1 As PictureBox
    Friend WithEvents llblCompanyAddress As Label
    Friend WithEvents imgLogo As PictureBox
    Friend WithEvents llblVoucherTitle As Label
    Friend WithEvents llblVoucherCompanyName As Label
    Friend WithEvents llblNo As Label
    Friend WithEvents llblDate2 As Label
    Friend WithEvents llblDate1 As Label
    Friend WithEvents llblNo2 As Label
    Friend WithEvents llblChequeDate1 As Label
    Friend WithEvents llblBankName1 As Label
    Friend WithEvents llblAmount1 As Label
    Friend WithEvents llblPayFor1 As Label
    Friend WithEvents llblPayTo1 As Label
    Friend WithEvents llblChequeStatus2 As Label
    Friend WithEvents llblChequeStatus1 As Label
    Friend WithEvents llblChequeNo2 As Label
    Friend WithEvents llblChequeNo1 As Label
    Friend WithEvents llblChequeDate2 As Label
    Friend WithEvents imgLine2 As PictureBox
    Friend WithEvents llblAmount2 As Label
    Friend WithEvents llblPayFor2 As Label
    Friend WithEvents llblPayTo2 As Label
    Friend WithEvents llblBankName2 As Label
    Friend WithEvents llblAmountRM As Label
    Friend WithEvents imgAmount As PictureBox
    Friend WithEvents llblReceivedBy As Label
    Friend WithEvents llblAuthorisedBy As Label
    Friend WithEvents llblApprovedBy As Label
    Friend WithEvents lblPayFor As Label
    Friend WithEvents lblVoucherNo As Label
End Class
