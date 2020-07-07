<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GSMTimed
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.ComboGas0 = New System.Windows.Forms.ComboBox()
        Me.ComboGas1 = New System.Windows.Forms.ComboBox()
        Me.ComboGas2 = New System.Windows.Forms.ComboBox()
        Me.MSComm1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.progTimer = New System.Windows.Forms.Timer(Me.components)
        Me.tbxFlow1Mix1 = New System.Windows.Forms.TextBox()
        Me.tbxFlow2Mix1 = New System.Windows.Forms.TextBox()
        Me.tbxFlow3Mix1 = New System.Windows.Forms.TextBox()
        Me.btnStore1 = New System.Windows.Forms.Button()
        Me.btnRun1 = New System.Windows.Forms.Button()
        Me.ledRunning1 = New System.Windows.Forms.Button()
        Me.tbxMaxFlow1 = New System.Windows.Forms.TextBox()
        Me.tbxMaxFlow2 = New System.Windows.Forms.TextBox()
        Me.tbxMaxFlow3 = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnRunSequence = New System.Windows.Forms.Button()
        Me.btnHaltSequence = New System.Windows.Forms.Button()
        Me.btnStopAll = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnFillGas0 = New System.Windows.Forms.RadioButton()
        Me.btnFillGas1 = New System.Windows.Forms.RadioButton()
        Me.btnFillGas2 = New System.Windows.Forms.RadioButton()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.tbxTotPct1 = New System.Windows.Forms.TextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ProgBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblConfigStrip = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblSequencerStrip = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tbxTotPct2 = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.ledRunning2 = New System.Windows.Forms.Button()
        Me.btnRun2 = New System.Windows.Forms.Button()
        Me.btnStore2 = New System.Windows.Forms.Button()
        Me.tbxFlow3Mix2 = New System.Windows.Forms.TextBox()
        Me.tbxFlow2Mix2 = New System.Windows.Forms.TextBox()
        Me.tbxFlow1Mix2 = New System.Windows.Forms.TextBox()
        Me.tbxTotPct3 = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.ledRunning3 = New System.Windows.Forms.Button()
        Me.btnRun3 = New System.Windows.Forms.Button()
        Me.btnStore3 = New System.Windows.Forms.Button()
        Me.tbxFlow3Mix3 = New System.Windows.Forms.TextBox()
        Me.tbxFlow2Mix3 = New System.Windows.Forms.TextBox()
        Me.tbxFlow1Mix3 = New System.Windows.Forms.TextBox()
        Me.tbxTotPct4 = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.ledRunning4 = New System.Windows.Forms.Button()
        Me.btnRun4 = New System.Windows.Forms.Button()
        Me.btnStore4 = New System.Windows.Forms.Button()
        Me.tbxFlow3Mix4 = New System.Windows.Forms.TextBox()
        Me.tbxFlow2Mix4 = New System.Windows.Forms.TextBox()
        Me.tbxFlow1Mix4 = New System.Windows.Forms.TextBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.tbxErrMsg = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ConfigurationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveConfigurationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadConfigurationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExperimentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveTimedSequenceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadTimedSequenceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tbxStep1 = New System.Windows.Forms.TextBox()
        Me.ledStep1 = New System.Windows.Forms.Button()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.ledStep2 = New System.Windows.Forms.Button()
        Me.tbxStep2 = New System.Windows.Forms.TextBox()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.ledStep3 = New System.Windows.Forms.Button()
        Me.tbxStep3 = New System.Windows.Forms.TextBox()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.ledStep4 = New System.Windows.Forms.Button()
        Me.tbxStep4 = New System.Windows.Forms.TextBox()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.ledStep5 = New System.Windows.Forms.Button()
        Me.tbxStep5 = New System.Windows.Forms.TextBox()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.ledStep6 = New System.Windows.Forms.Button()
        Me.tbxStep6 = New System.Windows.Forms.TextBox()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.ledStep7 = New System.Windows.Forms.Button()
        Me.tbxStep7 = New System.Windows.Forms.TextBox()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.ledStep8 = New System.Windows.Forms.Button()
        Me.tbxStep8 = New System.Windows.Forms.TextBox()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.ledStep9 = New System.Windows.Forms.Button()
        Me.tbxStep9 = New System.Windows.Forms.TextBox()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.ledStep10 = New System.Windows.Forms.Button()
        Me.tbxStep10 = New System.Windows.Forms.TextBox()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.ledStep11 = New System.Windows.Forms.Button()
        Me.tbxStep11 = New System.Windows.Forms.TextBox()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.ledStep12 = New System.Windows.Forms.Button()
        Me.tbxStep12 = New System.Windows.Forms.TextBox()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.ledStep13 = New System.Windows.Forms.Button()
        Me.tbxStep13 = New System.Windows.Forms.TextBox()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.ledStep14 = New System.Windows.Forms.Button()
        Me.tbxStep14 = New System.Windows.Forms.TextBox()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.ledStep15 = New System.Windows.Forms.Button()
        Me.tbxStep15 = New System.Windows.Forms.TextBox()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.ComboBox6 = New System.Windows.Forms.ComboBox()
        Me.ComboBox7 = New System.Windows.Forms.ComboBox()
        Me.ComboBox8 = New System.Windows.Forms.ComboBox()
        Me.ComboBox9 = New System.Windows.Forms.ComboBox()
        Me.ComboBox10 = New System.Windows.Forms.ComboBox()
        Me.ComboBox11 = New System.Windows.Forms.ComboBox()
        Me.ComboBox12 = New System.Windows.Forms.ComboBox()
        Me.ComboBox13 = New System.Windows.Forms.ComboBox()
        Me.ComboBox14 = New System.Windows.Forms.ComboBox()
        Me.ComboBox15 = New System.Windows.Forms.ComboBox()
        Me.comboPort = New System.Windows.Forms.ComboBox()
        Me.DirectoryEntry1 = New System.DirectoryServices.DirectoryEntry()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.sFile = New System.Windows.Forms.SaveFileDialog()
        Me.Chart2 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.tbxFlow4Mix4 = New System.Windows.Forms.TextBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.tbxFlow4Mix3 = New System.Windows.Forms.TextBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.tbxFlow4Mix2 = New System.Windows.Forms.TextBox()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.btnFillGas3 = New System.Windows.Forms.RadioButton()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.tbxFlow4Mix1 = New System.Windows.Forms.TextBox()
        Me.ComboGas3 = New System.Windows.Forms.ComboBox()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.tbxMaxFlow4 = New System.Windows.Forms.TextBox()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.stepTimer = New System.Windows.Forms.Timer(Me.components)
        Me.nUpDnPctA1 = New System.Windows.Forms.NumericUpDown()
        Me.nUpDnPctB1 = New System.Windows.Forms.NumericUpDown()
        Me.nUpDnPctC1 = New System.Windows.Forms.NumericUpDown()
        Me.nUpDnPctD1 = New System.Windows.Forms.NumericUpDown()
        Me.nUpDnPctD2 = New System.Windows.Forms.NumericUpDown()
        Me.nUpDnPctC2 = New System.Windows.Forms.NumericUpDown()
        Me.nUpDnPctB2 = New System.Windows.Forms.NumericUpDown()
        Me.nUpDnPctA2 = New System.Windows.Forms.NumericUpDown()
        Me.nUpDnPctD3 = New System.Windows.Forms.NumericUpDown()
        Me.nUpDnPctC3 = New System.Windows.Forms.NumericUpDown()
        Me.nUpDnPctB3 = New System.Windows.Forms.NumericUpDown()
        Me.nUpDnPctA3 = New System.Windows.Forms.NumericUpDown()
        Me.nUpDnPctD4 = New System.Windows.Forms.NumericUpDown()
        Me.nUpDnPctC4 = New System.Windows.Forms.NumericUpDown()
        Me.nUpDnPctB4 = New System.Windows.Forms.NumericUpDown()
        Me.nUpDnPctA4 = New System.Windows.Forms.NumericUpDown()
        Me.nUpDnTFlow1 = New System.Windows.Forms.NumericUpDown()
        Me.nUpDnTFlow2 = New System.Windows.Forms.NumericUpDown()
        Me.nUpDnTFlow3 = New System.Windows.Forms.NumericUpDown()
        Me.nUpDnTFlow4 = New System.Windows.Forms.NumericUpDown()
        Me.repeatTimer = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nUpDnPctA1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nUpDnPctB1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nUpDnPctC1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nUpDnPctD1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nUpDnPctD2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nUpDnPctC2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nUpDnPctB2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nUpDnPctA2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nUpDnPctD3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nUpDnPctC3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nUpDnPctB3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nUpDnPctA3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nUpDnPctD4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nUpDnPctC4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nUpDnPctB4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nUpDnPctA4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nUpDnTFlow1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nUpDnTFlow2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nUpDnTFlow3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nUpDnTFlow4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboGas0
        '
        Me.ComboGas0.FormattingEnabled = True
        Me.ComboGas0.Items.AddRange(New Object() {"Air", "Nitrogen", "Oxygen", "Carbon dioxide", "Helium", "Argon", "Carbon monoxide", "Neon", "Nitric oxide", "Nitrous oxide", "Sulfur hexafluoride", "Xenon", "Methane"})
        Me.ComboGas0.Location = New System.Drawing.Point(41, 79)
        Me.ComboGas0.Name = "ComboGas0"
        Me.ComboGas0.Size = New System.Drawing.Size(129, 21)
        Me.ComboGas0.TabIndex = 0
        Me.ComboGas0.Text = "Air"
        '
        'ComboGas1
        '
        Me.ComboGas1.FormattingEnabled = True
        Me.ComboGas1.Items.AddRange(New Object() {"Air", "Nitrogen", "Oxygen", "Carbon dioxide", "Helium", "Argon", "Carbon monoxide", "Neon", "Nitric oxide", "Nitrous oxide", "Sulfur hexafluoride", "Xenon", "Methane"})
        Me.ComboGas1.Location = New System.Drawing.Point(41, 118)
        Me.ComboGas1.Name = "ComboGas1"
        Me.ComboGas1.Size = New System.Drawing.Size(129, 21)
        Me.ComboGas1.TabIndex = 1
        Me.ComboGas1.Text = "Air"
        '
        'ComboGas2
        '
        Me.ComboGas2.FormattingEnabled = True
        Me.ComboGas2.Items.AddRange(New Object() {"Air", "Nitrogen", "Oxygen", "Carbon dioxide", "Helium", "Argon", "Carbon monoxide", "Neon", "Nitric oxide", "Nitrous oxide", "Sulfur hexafluoride", "Xenon", "Methane"})
        Me.ComboGas2.Location = New System.Drawing.Point(41, 157)
        Me.ComboGas2.Name = "ComboGas2"
        Me.ComboGas2.Size = New System.Drawing.Size(129, 21)
        Me.ComboGas2.TabIndex = 2
        Me.ComboGas2.Text = "Air"
        '
        'MSComm1
        '
        Me.MSComm1.BaudRate = 19200
        '
        'Timer
        '
        Me.Timer.Enabled = True
        '
        'progTimer
        '
        Me.progTimer.Interval = 1000
        '
        'tbxFlow1Mix1
        '
        Me.tbxFlow1Mix1.Location = New System.Drawing.Point(375, 80)
        Me.tbxFlow1Mix1.Name = "tbxFlow1Mix1"
        Me.tbxFlow1Mix1.Size = New System.Drawing.Size(54, 20)
        Me.tbxFlow1Mix1.TabIndex = 6
        '
        'tbxFlow2Mix1
        '
        Me.tbxFlow2Mix1.Location = New System.Drawing.Point(375, 119)
        Me.tbxFlow2Mix1.Name = "tbxFlow2Mix1"
        Me.tbxFlow2Mix1.Size = New System.Drawing.Size(54, 20)
        Me.tbxFlow2Mix1.TabIndex = 9
        '
        'tbxFlow3Mix1
        '
        Me.tbxFlow3Mix1.Location = New System.Drawing.Point(375, 158)
        Me.tbxFlow3Mix1.Name = "tbxFlow3Mix1"
        Me.tbxFlow3Mix1.Size = New System.Drawing.Size(54, 20)
        Me.tbxFlow3Mix1.TabIndex = 12
        '
        'btnStore1
        '
        Me.btnStore1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnStore1.Location = New System.Drawing.Point(287, 302)
        Me.btnStore1.Name = "btnStore1"
        Me.btnStore1.Size = New System.Drawing.Size(99, 35)
        Me.btnStore1.TabIndex = 13
        Me.btnStore1.Text = "STORE/RUN 1"
        Me.btnStore1.UseVisualStyleBackColor = False
        '
        'btnRun1
        '
        Me.btnRun1.BackColor = System.Drawing.Color.ForestGreen
        Me.btnRun1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnRun1.Location = New System.Drawing.Point(320, 348)
        Me.btnRun1.Name = "btnRun1"
        Me.btnRun1.Size = New System.Drawing.Size(66, 35)
        Me.btnRun1.TabIndex = 14
        Me.btnRun1.Text = "RUN 1"
        Me.btnRun1.UseVisualStyleBackColor = False
        '
        'ledRunning1
        '
        Me.ledRunning1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ledRunning1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ledRunning1.Location = New System.Drawing.Point(287, 355)
        Me.ledRunning1.Name = "ledRunning1"
        Me.ledRunning1.Size = New System.Drawing.Size(20, 20)
        Me.ledRunning1.TabIndex = 17
        Me.ledRunning1.UseVisualStyleBackColor = False
        '
        'tbxMaxFlow1
        '
        Me.tbxMaxFlow1.Location = New System.Drawing.Point(877, 528)
        Me.tbxMaxFlow1.Name = "tbxMaxFlow1"
        Me.tbxMaxFlow1.Size = New System.Drawing.Size(69, 20)
        Me.tbxMaxFlow1.TabIndex = 18
        Me.tbxMaxFlow1.Text = "5000"
        '
        'tbxMaxFlow2
        '
        Me.tbxMaxFlow2.Location = New System.Drawing.Point(877, 554)
        Me.tbxMaxFlow2.Name = "tbxMaxFlow2"
        Me.tbxMaxFlow2.Size = New System.Drawing.Size(69, 20)
        Me.tbxMaxFlow2.TabIndex = 19
        Me.tbxMaxFlow2.Text = "5000"
        '
        'tbxMaxFlow3
        '
        Me.tbxMaxFlow3.Location = New System.Drawing.Point(877, 580)
        Me.tbxMaxFlow3.Name = "tbxMaxFlow3"
        Me.tbxMaxFlow3.Size = New System.Drawing.Size(69, 20)
        Me.tbxMaxFlow3.TabIndex = 20
        Me.tbxMaxFlow3.Text = "750"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnExit.Location = New System.Drawing.Point(994, 631)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(78, 35)
        Me.btnExit.TabIndex = 21
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnRunSequence
        '
        Me.btnRunSequence.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.btnRunSequence.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.267326!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRunSequence.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnRunSequence.Location = New System.Drawing.Point(256, 396)
        Me.btnRunSequence.Name = "btnRunSequence"
        Me.btnRunSequence.Size = New System.Drawing.Size(130, 53)
        Me.btnRunSequence.TabIndex = 22
        Me.btnRunSequence.Text = "RUN SEQUENCE"
        Me.btnRunSequence.UseVisualStyleBackColor = False
        '
        'btnHaltSequence
        '
        Me.btnHaltSequence.BackColor = System.Drawing.Color.IndianRed
        Me.btnHaltSequence.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.267326!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHaltSequence.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnHaltSequence.Location = New System.Drawing.Point(256, 446)
        Me.btnHaltSequence.Name = "btnHaltSequence"
        Me.btnHaltSequence.Size = New System.Drawing.Size(130, 54)
        Me.btnHaltSequence.TabIndex = 23
        Me.btnHaltSequence.Text = "HALT SEQUENCE"
        Me.btnHaltSequence.UseVisualStyleBackColor = False
        '
        'btnStopAll
        '
        Me.btnStopAll.BackColor = System.Drawing.Color.Red
        Me.btnStopAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.980198!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStopAll.Location = New System.Drawing.Point(479, 396)
        Me.btnStopAll.Name = "btnStopAll"
        Me.btnStopAll.Size = New System.Drawing.Size(122, 53)
        Me.btnStopAll.TabIndex = 24
        Me.btnStopAll.Text = "STOP ALL"
        Me.btnStopAll.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.980198!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(826, 533)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 17)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "CH 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.980198!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(826, 557)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 17)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "CH 2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.980198!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(826, 583)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 17)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "CH 3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.980198!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(952, 531)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 17)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "sccm"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.980198!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(952, 557)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 17)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "sccm"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.980198!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(952, 583)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 17)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "sccm"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.69307!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(753, 505)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(278, 18)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "INSTALLED FLOW CONTROLLERS"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25743!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(11, 79)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(24, 25)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "1"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25743!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(11, 114)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(24, 25)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "2"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25743!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(11, 157)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(24, 25)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "3"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25743!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(74, 47)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 25)
        Me.Label11.TabIndex = 35
        Me.Label11.Text = "GAS"
        '
        'btnFillGas0
        '
        Me.btnFillGas0.AutoSize = True
        Me.btnFillGas0.Location = New System.Drawing.Point(183, 83)
        Me.btnFillGas0.Name = "btnFillGas0"
        Me.btnFillGas0.Size = New System.Drawing.Size(14, 13)
        Me.btnFillGas0.TabIndex = 36
        Me.btnFillGas0.TabStop = True
        Me.btnFillGas0.UseVisualStyleBackColor = True
        '
        'btnFillGas1
        '
        Me.btnFillGas1.AutoSize = True
        Me.btnFillGas1.Location = New System.Drawing.Point(183, 123)
        Me.btnFillGas1.Name = "btnFillGas1"
        Me.btnFillGas1.Size = New System.Drawing.Size(14, 13)
        Me.btnFillGas1.TabIndex = 37
        Me.btnFillGas1.TabStop = True
        Me.btnFillGas1.UseVisualStyleBackColor = True
        '
        'btnFillGas2
        '
        Me.btnFillGas2.AutoSize = True
        Me.btnFillGas2.Location = New System.Drawing.Point(183, 161)
        Me.btnFillGas2.Name = "btnFillGas2"
        Me.btnFillGas2.Size = New System.Drawing.Size(14, 13)
        Me.btnFillGas2.TabIndex = 38
        Me.btnFillGas2.TabStop = True
        Me.btnFillGas2.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.267326!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(157, 56)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 16)
        Me.Label12.TabIndex = 39
        Me.Label12.Text = "FILL GAS"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25743!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(316, 44)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(69, 25)
        Me.Label13.TabIndex = 40
        Me.Label13.Text = "MIX 1"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.980198!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(345, 83)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(28, 17)
        Me.Label14.TabIndex = 41
        Me.Label14.Text = "%="
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.980198!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(345, 123)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(28, 17)
        Me.Label15.TabIndex = 42
        Me.Label15.Text = "%="
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.980198!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(345, 161)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(28, 17)
        Me.Label16.TabIndex = 43
        Me.Label16.Text = "%="
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.11881!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(258, 266)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(62, 20)
        Me.Label17.TabIndex = 44
        Me.Label17.Text = "FLOW"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.980198!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(415, 268)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(22, 17)
        Me.Label18.TabIndex = 45
        Me.Label18.Text = "ml"
        '
        'tbxTotPct1
        '
        Me.tbxTotPct1.BackColor = System.Drawing.SystemColors.Menu
        Me.tbxTotPct1.Location = New System.Drawing.Point(277, 230)
        Me.tbxTotPct1.Name = "tbxTotPct1"
        Me.tbxTotPct1.Size = New System.Drawing.Size(49, 20)
        Me.tbxTotPct1.TabIndex = 46
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(17, 17)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ProgBar1, Me.ToolStripStatusLabel2, Me.lblConfigStrip, Me.lblSequencerStrip, Me.ToolStripStatusLabel3})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 675)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1028, 37)
        Me.StatusStrip1.TabIndex = 47
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(23, 32)
        Me.ToolStripStatusLabel1.Text = "0%"
        '
        'ProgBar1
        '
        Me.ProgBar1.AutoSize = False
        Me.ProgBar1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ProgBar1.Name = "ProgBar1"
        Me.ProgBar1.Size = New System.Drawing.Size(190, 31)
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.AutoSize = False
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(30, 32)
        Me.ToolStripStatusLabel2.Text = "---"
        '
        'lblConfigStrip
        '
        Me.lblConfigStrip.AutoSize = False
        Me.lblConfigStrip.Margin = New System.Windows.Forms.Padding(3, 3, 0, 2)
        Me.lblConfigStrip.Name = "lblConfigStrip"
        Me.lblConfigStrip.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lblConfigStrip.Size = New System.Drawing.Size(300, 32)
        Me.lblConfigStrip.Text = "Configuration file:"
        Me.lblConfigStrip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSequencerStrip
        '
        Me.lblSequencerStrip.AutoSize = False
        Me.lblSequencerStrip.Margin = New System.Windows.Forms.Padding(3, 3, 0, 2)
        Me.lblSequencerStrip.Name = "lblSequencerStrip"
        Me.lblSequencerStrip.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lblSequencerStrip.Size = New System.Drawing.Size(300, 32)
        Me.lblSequencerStrip.Text = "Sequencer file:"
        Me.lblSequencerStrip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Font = New System.Drawing.Font("Segoe UI", 9.980198!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel3.Margin = New System.Windows.Forms.Padding(3, 3, 0, 2)
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(213, 32)
        Me.ToolStripStatusLabel3.Text = "CWE, Inc.   www.cwe-inc.com"
        '
        'tbxTotPct2
        '
        Me.tbxTotPct2.BackColor = System.Drawing.SystemColors.Menu
        Me.tbxTotPct2.Location = New System.Drawing.Point(479, 230)
        Me.tbxTotPct2.Name = "tbxTotPct2"
        Me.tbxTotPct2.Size = New System.Drawing.Size(49, 20)
        Me.tbxTotPct2.TabIndex = 68
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.980198!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(617, 268)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(22, 17)
        Me.Label19.TabIndex = 67
        Me.Label19.Text = "ml"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.11881!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(460, 266)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(62, 20)
        Me.Label20.TabIndex = 66
        Me.Label20.Text = "FLOW"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.980198!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(547, 161)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(28, 17)
        Me.Label21.TabIndex = 65
        Me.Label21.Text = "%="
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.980198!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(547, 123)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(28, 17)
        Me.Label22.TabIndex = 64
        Me.Label22.Text = "%="
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.980198!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(547, 83)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(28, 17)
        Me.Label23.TabIndex = 63
        Me.Label23.Text = "%="
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25743!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(518, 44)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(69, 25)
        Me.Label24.TabIndex = 62
        Me.Label24.Text = "MIX 2"
        '
        'ledRunning2
        '
        Me.ledRunning2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ledRunning2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ledRunning2.Location = New System.Drawing.Point(489, 355)
        Me.ledRunning2.Name = "ledRunning2"
        Me.ledRunning2.Size = New System.Drawing.Size(20, 20)
        Me.ledRunning2.TabIndex = 61
        Me.ledRunning2.UseVisualStyleBackColor = False
        '
        'btnRun2
        '
        Me.btnRun2.BackColor = System.Drawing.Color.ForestGreen
        Me.btnRun2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnRun2.Location = New System.Drawing.Point(535, 348)
        Me.btnRun2.Name = "btnRun2"
        Me.btnRun2.Size = New System.Drawing.Size(66, 35)
        Me.btnRun2.TabIndex = 58
        Me.btnRun2.Text = "RUN 2"
        Me.btnRun2.UseVisualStyleBackColor = False
        '
        'btnStore2
        '
        Me.btnStore2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnStore2.Location = New System.Drawing.Point(489, 302)
        Me.btnStore2.Name = "btnStore2"
        Me.btnStore2.Size = New System.Drawing.Size(99, 35)
        Me.btnStore2.TabIndex = 57
        Me.btnStore2.Text = "STORE/RUN 2"
        Me.btnStore2.UseVisualStyleBackColor = False
        '
        'tbxFlow3Mix2
        '
        Me.tbxFlow3Mix2.Location = New System.Drawing.Point(577, 158)
        Me.tbxFlow3Mix2.Name = "tbxFlow3Mix2"
        Me.tbxFlow3Mix2.Size = New System.Drawing.Size(54, 20)
        Me.tbxFlow3Mix2.TabIndex = 56
        '
        'tbxFlow2Mix2
        '
        Me.tbxFlow2Mix2.Location = New System.Drawing.Point(577, 119)
        Me.tbxFlow2Mix2.Name = "tbxFlow2Mix2"
        Me.tbxFlow2Mix2.Size = New System.Drawing.Size(54, 20)
        Me.tbxFlow2Mix2.TabIndex = 53
        '
        'tbxFlow1Mix2
        '
        Me.tbxFlow1Mix2.Location = New System.Drawing.Point(577, 80)
        Me.tbxFlow1Mix2.Name = "tbxFlow1Mix2"
        Me.tbxFlow1Mix2.Size = New System.Drawing.Size(54, 20)
        Me.tbxFlow1Mix2.TabIndex = 50
        '
        'tbxTotPct3
        '
        Me.tbxTotPct3.BackColor = System.Drawing.SystemColors.Menu
        Me.tbxTotPct3.Location = New System.Drawing.Point(683, 230)
        Me.tbxTotPct3.Name = "tbxTotPct3"
        Me.tbxTotPct3.Size = New System.Drawing.Size(49, 20)
        Me.tbxTotPct3.TabIndex = 89
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.980198!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(821, 268)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(22, 17)
        Me.Label25.TabIndex = 88
        Me.Label25.Text = "ml"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.11881!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(664, 266)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(62, 20)
        Me.Label26.TabIndex = 87
        Me.Label26.Text = "FLOW"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.980198!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(751, 161)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(28, 17)
        Me.Label27.TabIndex = 86
        Me.Label27.Text = "%="
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.980198!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(751, 123)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(28, 17)
        Me.Label28.TabIndex = 85
        Me.Label28.Text = "%="
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.980198!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(751, 83)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(28, 17)
        Me.Label29.TabIndex = 84
        Me.Label29.Text = "%="
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25743!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(722, 44)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(69, 25)
        Me.Label30.TabIndex = 83
        Me.Label30.Text = "MIX 3"
        '
        'ledRunning3
        '
        Me.ledRunning3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ledRunning3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ledRunning3.Location = New System.Drawing.Point(693, 355)
        Me.ledRunning3.Name = "ledRunning3"
        Me.ledRunning3.Size = New System.Drawing.Size(20, 20)
        Me.ledRunning3.TabIndex = 82
        Me.ledRunning3.UseVisualStyleBackColor = False
        '
        'btnRun3
        '
        Me.btnRun3.BackColor = System.Drawing.Color.ForestGreen
        Me.btnRun3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnRun3.Location = New System.Drawing.Point(726, 348)
        Me.btnRun3.Name = "btnRun3"
        Me.btnRun3.Size = New System.Drawing.Size(66, 35)
        Me.btnRun3.TabIndex = 79
        Me.btnRun3.Text = "RUN 3"
        Me.btnRun3.UseVisualStyleBackColor = False
        '
        'btnStore3
        '
        Me.btnStore3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnStore3.Location = New System.Drawing.Point(693, 302)
        Me.btnStore3.Name = "btnStore3"
        Me.btnStore3.Size = New System.Drawing.Size(99, 35)
        Me.btnStore3.TabIndex = 78
        Me.btnStore3.Text = "STORE/RUN 3"
        Me.btnStore3.UseVisualStyleBackColor = False
        '
        'tbxFlow3Mix3
        '
        Me.tbxFlow3Mix3.Location = New System.Drawing.Point(781, 158)
        Me.tbxFlow3Mix3.Name = "tbxFlow3Mix3"
        Me.tbxFlow3Mix3.Size = New System.Drawing.Size(54, 20)
        Me.tbxFlow3Mix3.TabIndex = 77
        '
        'tbxFlow2Mix3
        '
        Me.tbxFlow2Mix3.Location = New System.Drawing.Point(781, 119)
        Me.tbxFlow2Mix3.Name = "tbxFlow2Mix3"
        Me.tbxFlow2Mix3.Size = New System.Drawing.Size(54, 20)
        Me.tbxFlow2Mix3.TabIndex = 74
        '
        'tbxFlow1Mix3
        '
        Me.tbxFlow1Mix3.Location = New System.Drawing.Point(781, 80)
        Me.tbxFlow1Mix3.Name = "tbxFlow1Mix3"
        Me.tbxFlow1Mix3.Size = New System.Drawing.Size(54, 20)
        Me.tbxFlow1Mix3.TabIndex = 71
        '
        'tbxTotPct4
        '
        Me.tbxTotPct4.BackColor = System.Drawing.SystemColors.Menu
        Me.tbxTotPct4.Location = New System.Drawing.Point(889, 230)
        Me.tbxTotPct4.Name = "tbxTotPct4"
        Me.tbxTotPct4.Size = New System.Drawing.Size(49, 20)
        Me.tbxTotPct4.TabIndex = 110
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.980198!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(1027, 268)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(22, 17)
        Me.Label31.TabIndex = 109
        Me.Label31.Text = "ml"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.11881!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(870, 266)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(62, 20)
        Me.Label32.TabIndex = 108
        Me.Label32.Text = "FLOW"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.980198!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(957, 161)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(28, 17)
        Me.Label33.TabIndex = 107
        Me.Label33.Text = "%="
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.980198!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(957, 123)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(28, 17)
        Me.Label34.TabIndex = 106
        Me.Label34.Text = "%="
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.980198!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(957, 83)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(28, 17)
        Me.Label35.TabIndex = 105
        Me.Label35.Text = "%="
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25743!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(928, 44)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(69, 25)
        Me.Label36.TabIndex = 104
        Me.Label36.Text = "MIX 4"
        '
        'ledRunning4
        '
        Me.ledRunning4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ledRunning4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ledRunning4.Location = New System.Drawing.Point(899, 355)
        Me.ledRunning4.Name = "ledRunning4"
        Me.ledRunning4.Size = New System.Drawing.Size(20, 20)
        Me.ledRunning4.TabIndex = 103
        Me.ledRunning4.UseVisualStyleBackColor = False
        '
        'btnRun4
        '
        Me.btnRun4.BackColor = System.Drawing.Color.ForestGreen
        Me.btnRun4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnRun4.Location = New System.Drawing.Point(932, 348)
        Me.btnRun4.Name = "btnRun4"
        Me.btnRun4.Size = New System.Drawing.Size(66, 35)
        Me.btnRun4.TabIndex = 100
        Me.btnRun4.Text = "RUN 4"
        Me.btnRun4.UseVisualStyleBackColor = False
        '
        'btnStore4
        '
        Me.btnStore4.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnStore4.Location = New System.Drawing.Point(899, 302)
        Me.btnStore4.Name = "btnStore4"
        Me.btnStore4.Size = New System.Drawing.Size(99, 35)
        Me.btnStore4.TabIndex = 99
        Me.btnStore4.Text = "STORE/RUN 4"
        Me.btnStore4.UseVisualStyleBackColor = False
        '
        'tbxFlow3Mix4
        '
        Me.tbxFlow3Mix4.Location = New System.Drawing.Point(987, 158)
        Me.tbxFlow3Mix4.Name = "tbxFlow3Mix4"
        Me.tbxFlow3Mix4.Size = New System.Drawing.Size(54, 20)
        Me.tbxFlow3Mix4.TabIndex = 98
        '
        'tbxFlow2Mix4
        '
        Me.tbxFlow2Mix4.Location = New System.Drawing.Point(987, 119)
        Me.tbxFlow2Mix4.Name = "tbxFlow2Mix4"
        Me.tbxFlow2Mix4.Size = New System.Drawing.Size(54, 20)
        Me.tbxFlow2Mix4.TabIndex = 95
        '
        'tbxFlow1Mix4
        '
        Me.tbxFlow1Mix4.Location = New System.Drawing.Point(987, 80)
        Me.tbxFlow1Mix4.Name = "tbxFlow1Mix4"
        Me.tbxFlow1Mix4.Size = New System.Drawing.Size(54, 20)
        Me.tbxFlow1Mix4.TabIndex = 92
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.980198!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(331, 232)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(20, 17)
        Me.Label37.TabIndex = 111
        Me.Label37.Text = "%"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.980198!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(532, 232)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(20, 17)
        Me.Label38.TabIndex = 112
        Me.Label38.Text = "%"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.980198!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(736, 233)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(20, 17)
        Me.Label39.TabIndex = 113
        Me.Label39.Text = "%"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.980198!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(942, 232)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(20, 17)
        Me.Label40.TabIndex = 114
        Me.Label40.Text = "%"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.11881!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(692, 410)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(107, 20)
        Me.Label41.TabIndex = 117
        Me.Label41.Text = "COM PORT"
        '
        'tbxErrMsg
        '
        Me.tbxErrMsg.Location = New System.Drawing.Point(860, 426)
        Me.tbxErrMsg.Multiline = True
        Me.tbxErrMsg.Name = "tbxErrMsg"
        Me.tbxErrMsg.Size = New System.Drawing.Size(212, 43)
        Me.tbxErrMsg.TabIndex = 118
        '
        'GroupBox3
        '
        Me.GroupBox3.Location = New System.Drawing.Point(654, 94)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(4, 285)
        Me.GroupBox3.TabIndex = 123
        Me.GroupBox3.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Location = New System.Drawing.Point(860, 95)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(4, 285)
        Me.GroupBox4.TabIndex = 123
        Me.GroupBox4.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(17, 17)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConfigurationToolStripMenuItem, Me.ExperimentToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1028, 24)
        Me.MenuStrip1.TabIndex = 125
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ConfigurationToolStripMenuItem
        '
        Me.ConfigurationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveConfigurationToolStripMenuItem, Me.LoadConfigurationToolStripMenuItem})
        Me.ConfigurationToolStripMenuItem.Name = "ConfigurationToolStripMenuItem"
        Me.ConfigurationToolStripMenuItem.Size = New System.Drawing.Size(93, 20)
        Me.ConfigurationToolStripMenuItem.Text = "&Configuration"
        '
        'SaveConfigurationToolStripMenuItem
        '
        Me.SaveConfigurationToolStripMenuItem.Name = "SaveConfigurationToolStripMenuItem"
        Me.SaveConfigurationToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.SaveConfigurationToolStripMenuItem.Text = "&Save configuration"
        '
        'LoadConfigurationToolStripMenuItem
        '
        Me.LoadConfigurationToolStripMenuItem.Name = "LoadConfigurationToolStripMenuItem"
        Me.LoadConfigurationToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.LoadConfigurationToolStripMenuItem.Text = "&Load configuration"
        '
        'ExperimentToolStripMenuItem
        '
        Me.ExperimentToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveTimedSequenceToolStripMenuItem, Me.LoadTimedSequenceToolStripMenuItem})
        Me.ExperimentToolStripMenuItem.Name = "ExperimentToolStripMenuItem"
        Me.ExperimentToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.ExperimentToolStripMenuItem.Text = "&Experiment"
        '
        'SaveTimedSequenceToolStripMenuItem
        '
        Me.SaveTimedSequenceToolStripMenuItem.Name = "SaveTimedSequenceToolStripMenuItem"
        Me.SaveTimedSequenceToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.SaveTimedSequenceToolStripMenuItem.Text = "&Save Timed Sequence"
        '
        'LoadTimedSequenceToolStripMenuItem
        '
        Me.LoadTimedSequenceToolStripMenuItem.Name = "LoadTimedSequenceToolStripMenuItem"
        Me.LoadTimedSequenceToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.LoadTimedSequenceToolStripMenuItem.Text = "&Load Timed Sequence"
        '
        'tbxStep1
        '
        Me.tbxStep1.Location = New System.Drawing.Point(55, 264)
        Me.tbxStep1.Name = "tbxStep1"
        Me.tbxStep1.Size = New System.Drawing.Size(77, 20)
        Me.tbxStep1.TabIndex = 128
        Me.tbxStep1.Text = "00:00:00"
        '
        'ledStep1
        '
        Me.ledStep1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ledStep1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ledStep1.Location = New System.Drawing.Point(29, 264)
        Me.ledStep1.Name = "ledStep1"
        Me.ledStep1.Size = New System.Drawing.Size(20, 20)
        Me.ledStep1.TabIndex = 130
        Me.ledStep1.UseVisualStyleBackColor = False
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.69307!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.Location = New System.Drawing.Point(12, 263)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(17, 18)
        Me.Label45.TabIndex = 132
        Me.Label45.Text = "1"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.69307!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.Location = New System.Drawing.Point(12, 289)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(17, 18)
        Me.Label46.TabIndex = 137
        Me.Label46.Text = "2"
        '
        'ledStep2
        '
        Me.ledStep2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ledStep2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ledStep2.Location = New System.Drawing.Point(29, 290)
        Me.ledStep2.Name = "ledStep2"
        Me.ledStep2.Size = New System.Drawing.Size(20, 20)
        Me.ledStep2.TabIndex = 135
        Me.ledStep2.UseVisualStyleBackColor = False
        '
        'tbxStep2
        '
        Me.tbxStep2.Location = New System.Drawing.Point(55, 290)
        Me.tbxStep2.Name = "tbxStep2"
        Me.tbxStep2.Size = New System.Drawing.Size(77, 20)
        Me.tbxStep2.TabIndex = 133
        Me.tbxStep2.Text = "00:00:00"
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.69307!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.Location = New System.Drawing.Point(12, 315)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(17, 18)
        Me.Label47.TabIndex = 142
        Me.Label47.Text = "3"
        '
        'ledStep3
        '
        Me.ledStep3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ledStep3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ledStep3.Location = New System.Drawing.Point(29, 316)
        Me.ledStep3.Name = "ledStep3"
        Me.ledStep3.Size = New System.Drawing.Size(20, 20)
        Me.ledStep3.TabIndex = 140
        Me.ledStep3.UseVisualStyleBackColor = False
        '
        'tbxStep3
        '
        Me.tbxStep3.Location = New System.Drawing.Point(55, 316)
        Me.tbxStep3.Name = "tbxStep3"
        Me.tbxStep3.Size = New System.Drawing.Size(77, 20)
        Me.tbxStep3.TabIndex = 138
        Me.tbxStep3.Text = "00:00:00"
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.69307!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.Location = New System.Drawing.Point(12, 341)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(17, 18)
        Me.Label48.TabIndex = 147
        Me.Label48.Text = "4"
        '
        'ledStep4
        '
        Me.ledStep4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ledStep4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ledStep4.Location = New System.Drawing.Point(29, 342)
        Me.ledStep4.Name = "ledStep4"
        Me.ledStep4.Size = New System.Drawing.Size(20, 20)
        Me.ledStep4.TabIndex = 145
        Me.ledStep4.UseVisualStyleBackColor = False
        '
        'tbxStep4
        '
        Me.tbxStep4.Location = New System.Drawing.Point(55, 342)
        Me.tbxStep4.Name = "tbxStep4"
        Me.tbxStep4.Size = New System.Drawing.Size(77, 20)
        Me.tbxStep4.TabIndex = 143
        Me.tbxStep4.Text = "00:00:00"
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.69307!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.Location = New System.Drawing.Point(12, 367)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(17, 18)
        Me.Label49.TabIndex = 152
        Me.Label49.Text = "5"
        '
        'ledStep5
        '
        Me.ledStep5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ledStep5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ledStep5.Location = New System.Drawing.Point(29, 368)
        Me.ledStep5.Name = "ledStep5"
        Me.ledStep5.Size = New System.Drawing.Size(20, 20)
        Me.ledStep5.TabIndex = 150
        Me.ledStep5.UseVisualStyleBackColor = False
        '
        'tbxStep5
        '
        Me.tbxStep5.Location = New System.Drawing.Point(55, 368)
        Me.tbxStep5.Name = "tbxStep5"
        Me.tbxStep5.Size = New System.Drawing.Size(77, 20)
        Me.tbxStep5.TabIndex = 148
        Me.tbxStep5.Text = "00:00:00"
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.69307!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.Location = New System.Drawing.Point(12, 393)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(17, 18)
        Me.Label50.TabIndex = 157
        Me.Label50.Text = "6"
        '
        'ledStep6
        '
        Me.ledStep6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ledStep6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ledStep6.Location = New System.Drawing.Point(29, 394)
        Me.ledStep6.Name = "ledStep6"
        Me.ledStep6.Size = New System.Drawing.Size(20, 20)
        Me.ledStep6.TabIndex = 155
        Me.ledStep6.UseVisualStyleBackColor = False
        '
        'tbxStep6
        '
        Me.tbxStep6.Location = New System.Drawing.Point(55, 394)
        Me.tbxStep6.Name = "tbxStep6"
        Me.tbxStep6.Size = New System.Drawing.Size(77, 20)
        Me.tbxStep6.TabIndex = 153
        Me.tbxStep6.Text = "00:00:00"
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.69307!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.Location = New System.Drawing.Point(12, 421)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(17, 18)
        Me.Label51.TabIndex = 162
        Me.Label51.Text = "7"
        '
        'ledStep7
        '
        Me.ledStep7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ledStep7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ledStep7.Location = New System.Drawing.Point(29, 422)
        Me.ledStep7.Name = "ledStep7"
        Me.ledStep7.Size = New System.Drawing.Size(20, 20)
        Me.ledStep7.TabIndex = 160
        Me.ledStep7.UseVisualStyleBackColor = False
        '
        'tbxStep7
        '
        Me.tbxStep7.Location = New System.Drawing.Point(55, 422)
        Me.tbxStep7.Name = "tbxStep7"
        Me.tbxStep7.Size = New System.Drawing.Size(77, 20)
        Me.tbxStep7.TabIndex = 158
        Me.tbxStep7.Text = "00:00:00"
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.69307!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.Location = New System.Drawing.Point(12, 448)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(17, 18)
        Me.Label52.TabIndex = 167
        Me.Label52.Text = "8"
        '
        'ledStep8
        '
        Me.ledStep8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ledStep8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ledStep8.Location = New System.Drawing.Point(29, 449)
        Me.ledStep8.Name = "ledStep8"
        Me.ledStep8.Size = New System.Drawing.Size(20, 20)
        Me.ledStep8.TabIndex = 165
        Me.ledStep8.UseVisualStyleBackColor = False
        '
        'tbxStep8
        '
        Me.tbxStep8.Location = New System.Drawing.Point(55, 449)
        Me.tbxStep8.Name = "tbxStep8"
        Me.tbxStep8.Size = New System.Drawing.Size(77, 20)
        Me.tbxStep8.TabIndex = 163
        Me.tbxStep8.Text = "00:00:00"
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.69307!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.Location = New System.Drawing.Point(12, 474)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(17, 18)
        Me.Label53.TabIndex = 172
        Me.Label53.Text = "9"
        '
        'ledStep9
        '
        Me.ledStep9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ledStep9.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ledStep9.Location = New System.Drawing.Point(29, 475)
        Me.ledStep9.Name = "ledStep9"
        Me.ledStep9.Size = New System.Drawing.Size(20, 20)
        Me.ledStep9.TabIndex = 170
        Me.ledStep9.UseVisualStyleBackColor = False
        '
        'tbxStep9
        '
        Me.tbxStep9.Location = New System.Drawing.Point(55, 475)
        Me.tbxStep9.Name = "tbxStep9"
        Me.tbxStep9.Size = New System.Drawing.Size(77, 20)
        Me.tbxStep9.TabIndex = 168
        Me.tbxStep9.Text = "00:00:00"
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.69307!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.Location = New System.Drawing.Point(1, 500)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(26, 18)
        Me.Label54.TabIndex = 177
        Me.Label54.Text = "10"
        '
        'ledStep10
        '
        Me.ledStep10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ledStep10.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ledStep10.Location = New System.Drawing.Point(29, 501)
        Me.ledStep10.Name = "ledStep10"
        Me.ledStep10.Size = New System.Drawing.Size(20, 20)
        Me.ledStep10.TabIndex = 175
        Me.ledStep10.UseVisualStyleBackColor = False
        '
        'tbxStep10
        '
        Me.tbxStep10.Location = New System.Drawing.Point(55, 501)
        Me.tbxStep10.Name = "tbxStep10"
        Me.tbxStep10.Size = New System.Drawing.Size(77, 20)
        Me.tbxStep10.TabIndex = 173
        Me.tbxStep10.Text = "00:00:00"
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.69307!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label55.Location = New System.Drawing.Point(2, 526)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(26, 18)
        Me.Label55.TabIndex = 182
        Me.Label55.Text = "11"
        '
        'ledStep11
        '
        Me.ledStep11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ledStep11.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ledStep11.Location = New System.Drawing.Point(29, 527)
        Me.ledStep11.Name = "ledStep11"
        Me.ledStep11.Size = New System.Drawing.Size(20, 20)
        Me.ledStep11.TabIndex = 180
        Me.ledStep11.UseVisualStyleBackColor = False
        '
        'tbxStep11
        '
        Me.tbxStep11.Location = New System.Drawing.Point(55, 527)
        Me.tbxStep11.Name = "tbxStep11"
        Me.tbxStep11.Size = New System.Drawing.Size(77, 20)
        Me.tbxStep11.TabIndex = 178
        Me.tbxStep11.Text = "00:00:00"
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.69307!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label56.Location = New System.Drawing.Point(2, 552)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(26, 18)
        Me.Label56.TabIndex = 187
        Me.Label56.Text = "12"
        '
        'ledStep12
        '
        Me.ledStep12.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ledStep12.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ledStep12.Location = New System.Drawing.Point(29, 553)
        Me.ledStep12.Name = "ledStep12"
        Me.ledStep12.Size = New System.Drawing.Size(20, 20)
        Me.ledStep12.TabIndex = 185
        Me.ledStep12.UseVisualStyleBackColor = False
        '
        'tbxStep12
        '
        Me.tbxStep12.Location = New System.Drawing.Point(55, 553)
        Me.tbxStep12.Name = "tbxStep12"
        Me.tbxStep12.Size = New System.Drawing.Size(77, 20)
        Me.tbxStep12.TabIndex = 183
        Me.tbxStep12.Text = "00:00:00"
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.69307!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label57.Location = New System.Drawing.Point(2, 578)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(26, 18)
        Me.Label57.TabIndex = 192
        Me.Label57.Text = "13"
        '
        'ledStep13
        '
        Me.ledStep13.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ledStep13.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ledStep13.Location = New System.Drawing.Point(29, 579)
        Me.ledStep13.Name = "ledStep13"
        Me.ledStep13.Size = New System.Drawing.Size(20, 20)
        Me.ledStep13.TabIndex = 190
        Me.ledStep13.UseVisualStyleBackColor = False
        '
        'tbxStep13
        '
        Me.tbxStep13.Location = New System.Drawing.Point(55, 579)
        Me.tbxStep13.Name = "tbxStep13"
        Me.tbxStep13.Size = New System.Drawing.Size(77, 20)
        Me.tbxStep13.TabIndex = 188
        Me.tbxStep13.Text = "00:00:00"
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.69307!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label58.Location = New System.Drawing.Point(2, 604)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(26, 18)
        Me.Label58.TabIndex = 197
        Me.Label58.Text = "14"
        '
        'ledStep14
        '
        Me.ledStep14.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ledStep14.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ledStep14.Location = New System.Drawing.Point(29, 605)
        Me.ledStep14.Name = "ledStep14"
        Me.ledStep14.Size = New System.Drawing.Size(20, 20)
        Me.ledStep14.TabIndex = 195
        Me.ledStep14.UseVisualStyleBackColor = False
        '
        'tbxStep14
        '
        Me.tbxStep14.Location = New System.Drawing.Point(55, 605)
        Me.tbxStep14.Name = "tbxStep14"
        Me.tbxStep14.Size = New System.Drawing.Size(77, 20)
        Me.tbxStep14.TabIndex = 193
        Me.tbxStep14.Text = "00:00:00"
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.69307!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label59.Location = New System.Drawing.Point(2, 630)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(26, 18)
        Me.Label59.TabIndex = 202
        Me.Label59.Text = "15"
        '
        'ledStep15
        '
        Me.ledStep15.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ledStep15.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ledStep15.Location = New System.Drawing.Point(29, 631)
        Me.ledStep15.Name = "ledStep15"
        Me.ledStep15.Size = New System.Drawing.Size(20, 20)
        Me.ledStep15.TabIndex = 200
        Me.ledStep15.UseVisualStyleBackColor = False
        '
        'tbxStep15
        '
        Me.tbxStep15.Location = New System.Drawing.Point(55, 631)
        Me.tbxStep15.Name = "tbxStep15"
        Me.tbxStep15.Size = New System.Drawing.Size(77, 20)
        Me.tbxStep15.TabIndex = 198
        Me.tbxStep15.Text = "00:00:00"
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.11881!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label60.Location = New System.Drawing.Point(72, 225)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(123, 20)
        Me.Label60.TabIndex = 203
        Me.Label60.Text = "SEQUENCER"
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label61.Location = New System.Drawing.Point(258, 626)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(255, 36)
        Me.Label61.TabIndex = 204
        Me.Label61.Text = "GSM-4-Comm-XS"
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.267326!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label62.Location = New System.Drawing.Point(52, 654)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(82, 16)
        Me.Label62.TabIndex = 205
        Me.Label62.Text = "HH:MM:SS"
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.267326!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label63.Location = New System.Drawing.Point(59, 245)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(44, 16)
        Me.Label63.TabIndex = 206
        Me.Label63.Text = "TIME"
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.267326!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label64.Location = New System.Drawing.Point(136, 245)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(85, 16)
        Me.Label64.TabIndex = 207
        Me.Label64.Text = "FUNCTION"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Mix 1", "Mix 2", "Mix 3", "Mix 4", "REPEAT", "REPEAT Time", "GOTO", "PAUSE", "STOP", "NONE"})
        Me.ComboBox1.Location = New System.Drawing.Point(138, 264)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(82, 21)
        Me.ComboBox1.TabIndex = 208
        Me.ComboBox1.Text = "NONE"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Mix 1", "Mix 2", "Mix 3", "Mix 4", "REPEAT", "REPEAT Time", "GOTO", "PAUSE", "STOP", "NONE"})
        Me.ComboBox2.Location = New System.Drawing.Point(138, 291)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(82, 21)
        Me.ComboBox2.TabIndex = 209
        Me.ComboBox2.Text = "NONE"
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"Mix 1", "Mix 2", "Mix 3", "Mix 4", "REPEAT", "REPEAT Time", "GOTO", "PAUSE", "STOP", "NONE"})
        Me.ComboBox3.Location = New System.Drawing.Point(138, 318)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(82, 21)
        Me.ComboBox3.TabIndex = 210
        Me.ComboBox3.Text = "NONE"
        '
        'ComboBox4
        '
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Items.AddRange(New Object() {"Mix 1", "Mix 2", "Mix 3", "Mix 4", "REPEAT", "REPEAT Time", "GOTO", "PAUSE", "STOP", "NONE"})
        Me.ComboBox4.Location = New System.Drawing.Point(138, 343)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(82, 21)
        Me.ComboBox4.TabIndex = 211
        Me.ComboBox4.Text = "NONE"
        '
        'ComboBox5
        '
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Items.AddRange(New Object() {"Mix 1", "Mix 2", "Mix 3", "Mix 4", "REPEAT", "REPEAT Time", "GOTO", "PAUSE", "STOP", "NONE"})
        Me.ComboBox5.Location = New System.Drawing.Point(138, 369)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(82, 21)
        Me.ComboBox5.TabIndex = 212
        Me.ComboBox5.Text = "NONE"
        '
        'ComboBox6
        '
        Me.ComboBox6.FormattingEnabled = True
        Me.ComboBox6.Items.AddRange(New Object() {"Mix 1", "Mix 2", "Mix 3", "Mix 4", "REPEAT", "REPEAT Time", "GOTO", "PAUSE", "STOP", "NONE"})
        Me.ComboBox6.Location = New System.Drawing.Point(138, 396)
        Me.ComboBox6.Name = "ComboBox6"
        Me.ComboBox6.Size = New System.Drawing.Size(82, 21)
        Me.ComboBox6.TabIndex = 213
        Me.ComboBox6.Text = "NONE"
        '
        'ComboBox7
        '
        Me.ComboBox7.FormattingEnabled = True
        Me.ComboBox7.Items.AddRange(New Object() {"Mix 1", "Mix 2", "Mix 3", "Mix 4", "REPEAT", "REPEAT Time", "GOTO", "PAUSE", "STOP", "NONE"})
        Me.ComboBox7.Location = New System.Drawing.Point(138, 424)
        Me.ComboBox7.Name = "ComboBox7"
        Me.ComboBox7.Size = New System.Drawing.Size(82, 21)
        Me.ComboBox7.TabIndex = 214
        Me.ComboBox7.Text = "NONE"
        '
        'ComboBox8
        '
        Me.ComboBox8.FormattingEnabled = True
        Me.ComboBox8.Items.AddRange(New Object() {"Mix 1", "Mix 2", "Mix 3", "Mix 4", "REPEAT", "REPEAT Time", "GOTO", "PAUSE", "STOP", "NONE"})
        Me.ComboBox8.Location = New System.Drawing.Point(138, 450)
        Me.ComboBox8.Name = "ComboBox8"
        Me.ComboBox8.Size = New System.Drawing.Size(82, 21)
        Me.ComboBox8.TabIndex = 215
        Me.ComboBox8.Text = "NONE"
        '
        'ComboBox9
        '
        Me.ComboBox9.FormattingEnabled = True
        Me.ComboBox9.Items.AddRange(New Object() {"Mix 1", "Mix 2", "Mix 3", "Mix 4", "REPEAT", "REPEAT Time", "GOTO", "PAUSE", "STOP", "NONE"})
        Me.ComboBox9.Location = New System.Drawing.Point(138, 477)
        Me.ComboBox9.Name = "ComboBox9"
        Me.ComboBox9.Size = New System.Drawing.Size(82, 21)
        Me.ComboBox9.TabIndex = 216
        Me.ComboBox9.Text = "NONE"
        '
        'ComboBox10
        '
        Me.ComboBox10.FormattingEnabled = True
        Me.ComboBox10.Items.AddRange(New Object() {"Mix 1", "Mix 2", "Mix 3", "Mix 4", "REPEAT", "REPEAT Time", "GOTO", "PAUSE", "STOP", "NONE"})
        Me.ComboBox10.Location = New System.Drawing.Point(138, 503)
        Me.ComboBox10.Name = "ComboBox10"
        Me.ComboBox10.Size = New System.Drawing.Size(82, 21)
        Me.ComboBox10.TabIndex = 217
        Me.ComboBox10.Text = "NONE"
        '
        'ComboBox11
        '
        Me.ComboBox11.FormattingEnabled = True
        Me.ComboBox11.Items.AddRange(New Object() {"Mix 1", "Mix 2", "Mix 3", "Mix 4", "REPEAT", "REPEAT Time", "GOTO", "PAUSE", "STOP", "NONE"})
        Me.ComboBox11.Location = New System.Drawing.Point(138, 528)
        Me.ComboBox11.Name = "ComboBox11"
        Me.ComboBox11.Size = New System.Drawing.Size(82, 21)
        Me.ComboBox11.TabIndex = 218
        Me.ComboBox11.Text = "NONE"
        '
        'ComboBox12
        '
        Me.ComboBox12.FormattingEnabled = True
        Me.ComboBox12.Items.AddRange(New Object() {"Mix 1", "Mix 2", "Mix 3", "Mix 4", "REPEAT", "REPEAT Time", "GOTO", "PAUSE", "STOP", "NONE"})
        Me.ComboBox12.Location = New System.Drawing.Point(138, 555)
        Me.ComboBox12.Name = "ComboBox12"
        Me.ComboBox12.Size = New System.Drawing.Size(82, 21)
        Me.ComboBox12.TabIndex = 219
        Me.ComboBox12.Text = "NONE"
        '
        'ComboBox13
        '
        Me.ComboBox13.FormattingEnabled = True
        Me.ComboBox13.Items.AddRange(New Object() {"Mix 1", "Mix 2", "Mix 3", "Mix 4", "REPEAT", "REPEAT Time", "GOTO", "PAUSE", "STOP", "NONE"})
        Me.ComboBox13.Location = New System.Drawing.Point(138, 580)
        Me.ComboBox13.Name = "ComboBox13"
        Me.ComboBox13.Size = New System.Drawing.Size(82, 21)
        Me.ComboBox13.TabIndex = 220
        Me.ComboBox13.Text = "NONE"
        '
        'ComboBox14
        '
        Me.ComboBox14.FormattingEnabled = True
        Me.ComboBox14.Items.AddRange(New Object() {"Mix 1", "Mix 2", "Mix 3", "Mix 4", "REPEAT", "REPEAT Time", "GOTO", "PAUSE", "STOP", "NONE"})
        Me.ComboBox14.Location = New System.Drawing.Point(138, 606)
        Me.ComboBox14.Name = "ComboBox14"
        Me.ComboBox14.Size = New System.Drawing.Size(82, 21)
        Me.ComboBox14.TabIndex = 221
        Me.ComboBox14.Text = "NONE"
        '
        'ComboBox15
        '
        Me.ComboBox15.FormattingEnabled = True
        Me.ComboBox15.Items.AddRange(New Object() {"Mix 1", "Mix 2", "Mix 3", "Mix 4", "REPEAT", "REPEAT Time", "GOTO", "PAUSE", "STOP", "NONE"})
        Me.ComboBox15.Location = New System.Drawing.Point(138, 633)
        Me.ComboBox15.Name = "ComboBox15"
        Me.ComboBox15.Size = New System.Drawing.Size(82, 21)
        Me.ComboBox15.TabIndex = 222
        Me.ComboBox15.Text = "NONE"
        '
        'comboPort
        '
        Me.comboPort.FormattingEnabled = True
        Me.comboPort.Location = New System.Drawing.Point(693, 436)
        Me.comboPort.Name = "comboPort"
        Me.comboPort.Size = New System.Drawing.Size(99, 21)
        Me.comboPort.TabIndex = 223
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'sFile
        '
        Me.sFile.AddExtension = False
        Me.sFile.CheckPathExists = False
        Me.sFile.DefaultExt = "txt"
        Me.sFile.OverwritePrompt = False
        Me.sFile.RestoreDirectory = True
        '
        'Chart2
        '
        Me.Chart2.BackColor = System.Drawing.Color.Gainsboro
        ChartArea1.AxisX.IsLabelAutoFit = False
        ChartArea1.AxisX.LabelStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.69307!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.RoyalBlue
        ChartArea1.AxisX.MajorGrid.Enabled = False
        ChartArea1.AxisY2.IsLabelAutoFit = False
        ChartArea1.AxisY2.LabelStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.267326!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea1.Name = "ChartArea1"
        Me.Chart2.ChartAreas.Add(ChartArea1)
        Legend1.Enabled = False
        Legend1.Name = "Legend1"
        Me.Chart2.Legends.Add(Legend1)
        Me.Chart2.Location = New System.Drawing.Point(412, 454)
        Me.Chart2.Name = "Chart2"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart2.Series.Add(Series1)
        Me.Chart2.Size = New System.Drawing.Size(250, 178)
        Me.Chart2.TabIndex = 228
        Me.Chart2.Text = "Chart2"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.cwe_logo_trans_2_
        Me.PictureBox1.Location = New System.Drawing.Point(269, 538)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(103, 72)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 229
        Me.PictureBox1.TabStop = False
        '
        'GroupBox7
        '
        Me.GroupBox7.Location = New System.Drawing.Point(860, 136)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(4, 285)
        Me.GroupBox7.TabIndex = 251
        Me.GroupBox7.TabStop = False
        '
        'GroupBox8
        '
        Me.GroupBox8.Location = New System.Drawing.Point(654, 135)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(4, 285)
        Me.GroupBox8.TabIndex = 250
        Me.GroupBox8.TabStop = False
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.980198!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.Location = New System.Drawing.Point(957, 202)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(28, 17)
        Me.Label42.TabIndex = 248
        Me.Label42.Text = "%="
        '
        'tbxFlow4Mix4
        '
        Me.tbxFlow4Mix4.Location = New System.Drawing.Point(987, 199)
        Me.tbxFlow4Mix4.Name = "tbxFlow4Mix4"
        Me.tbxFlow4Mix4.Size = New System.Drawing.Size(54, 20)
        Me.tbxFlow4Mix4.TabIndex = 247
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.980198!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.Location = New System.Drawing.Point(751, 202)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(28, 17)
        Me.Label43.TabIndex = 244
        Me.Label43.Text = "%="
        '
        'tbxFlow4Mix3
        '
        Me.tbxFlow4Mix3.Location = New System.Drawing.Point(781, 199)
        Me.tbxFlow4Mix3.Name = "tbxFlow4Mix3"
        Me.tbxFlow4Mix3.Size = New System.Drawing.Size(54, 20)
        Me.tbxFlow4Mix3.TabIndex = 243
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.980198!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.Location = New System.Drawing.Point(547, 202)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(28, 17)
        Me.Label44.TabIndex = 240
        Me.Label44.Text = "%="
        '
        'tbxFlow4Mix2
        '
        Me.tbxFlow4Mix2.Location = New System.Drawing.Point(577, 199)
        Me.tbxFlow4Mix2.Name = "tbxFlow4Mix2"
        Me.tbxFlow4Mix2.Size = New System.Drawing.Size(54, 20)
        Me.tbxFlow4Mix2.TabIndex = 239
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.980198!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label65.Location = New System.Drawing.Point(345, 202)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(28, 17)
        Me.Label65.TabIndex = 236
        Me.Label65.Text = "%="
        '
        'btnFillGas3
        '
        Me.btnFillGas3.AutoSize = True
        Me.btnFillGas3.Location = New System.Drawing.Point(183, 202)
        Me.btnFillGas3.Name = "btnFillGas3"
        Me.btnFillGas3.Size = New System.Drawing.Size(14, 13)
        Me.btnFillGas3.TabIndex = 235
        Me.btnFillGas3.TabStop = True
        Me.btnFillGas3.UseVisualStyleBackColor = True
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25743!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label66.Location = New System.Drawing.Point(11, 198)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(24, 25)
        Me.Label66.TabIndex = 234
        Me.Label66.Text = "4"
        '
        'tbxFlow4Mix1
        '
        Me.tbxFlow4Mix1.Location = New System.Drawing.Point(375, 199)
        Me.tbxFlow4Mix1.Name = "tbxFlow4Mix1"
        Me.tbxFlow4Mix1.Size = New System.Drawing.Size(54, 20)
        Me.tbxFlow4Mix1.TabIndex = 233
        '
        'ComboGas3
        '
        Me.ComboGas3.FormattingEnabled = True
        Me.ComboGas3.Items.AddRange(New Object() {"Air", "Nitrogen", "Oxygen", "Carbon dioxide", "Helium", "Argon", "Carbon monoxide", "Neon", "Nitric oxide", "Nitrous oxide", "Sulfur hexafluoride", "Xenon", "Methane"})
        Me.ComboGas3.Location = New System.Drawing.Point(41, 198)
        Me.ComboGas3.Name = "ComboGas3"
        Me.ComboGas3.Size = New System.Drawing.Size(129, 21)
        Me.ComboGas3.TabIndex = 230
        Me.ComboGas3.Text = "Air"
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.980198!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label67.Location = New System.Drawing.Point(952, 610)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(40, 17)
        Me.Label67.TabIndex = 255
        Me.Label67.Text = "sccm"
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.980198!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label68.Location = New System.Drawing.Point(826, 610)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(43, 17)
        Me.Label68.TabIndex = 254
        Me.Label68.Text = "CH 4"
        '
        'tbxMaxFlow4
        '
        Me.tbxMaxFlow4.Location = New System.Drawing.Point(877, 607)
        Me.tbxMaxFlow4.Name = "tbxMaxFlow4"
        Me.tbxMaxFlow4.Size = New System.Drawing.Size(69, 20)
        Me.tbxMaxFlow4.TabIndex = 253
        Me.tbxMaxFlow4.Text = "4000"
        '
        'stepTimer
        '
        Me.stepTimer.Enabled = True
        Me.stepTimer.Interval = 1000
        '
        'nUpDnPctA1
        '
        Me.nUpDnPctA1.DecimalPlaces = 1
        Me.nUpDnPctA1.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nUpDnPctA1.Location = New System.Drawing.Point(277, 79)
        Me.nUpDnPctA1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.nUpDnPctA1.Name = "nUpDnPctA1"
        Me.nUpDnPctA1.Size = New System.Drawing.Size(58, 20)
        Me.nUpDnPctA1.TabIndex = 257
        '
        'nUpDnPctB1
        '
        Me.nUpDnPctB1.DecimalPlaces = 1
        Me.nUpDnPctB1.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nUpDnPctB1.Location = New System.Drawing.Point(277, 118)
        Me.nUpDnPctB1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.nUpDnPctB1.Name = "nUpDnPctB1"
        Me.nUpDnPctB1.Size = New System.Drawing.Size(58, 20)
        Me.nUpDnPctB1.TabIndex = 258
        '
        'nUpDnPctC1
        '
        Me.nUpDnPctC1.DecimalPlaces = 1
        Me.nUpDnPctC1.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nUpDnPctC1.Location = New System.Drawing.Point(277, 157)
        Me.nUpDnPctC1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.nUpDnPctC1.Name = "nUpDnPctC1"
        Me.nUpDnPctC1.Size = New System.Drawing.Size(58, 20)
        Me.nUpDnPctC1.TabIndex = 259
        '
        'nUpDnPctD1
        '
        Me.nUpDnPctD1.DecimalPlaces = 1
        Me.nUpDnPctD1.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nUpDnPctD1.Location = New System.Drawing.Point(277, 198)
        Me.nUpDnPctD1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.nUpDnPctD1.Name = "nUpDnPctD1"
        Me.nUpDnPctD1.Size = New System.Drawing.Size(58, 20)
        Me.nUpDnPctD1.TabIndex = 260
        '
        'nUpDnPctD2
        '
        Me.nUpDnPctD2.DecimalPlaces = 1
        Me.nUpDnPctD2.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nUpDnPctD2.Location = New System.Drawing.Point(479, 198)
        Me.nUpDnPctD2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.nUpDnPctD2.Name = "nUpDnPctD2"
        Me.nUpDnPctD2.Size = New System.Drawing.Size(58, 20)
        Me.nUpDnPctD2.TabIndex = 264
        '
        'nUpDnPctC2
        '
        Me.nUpDnPctC2.DecimalPlaces = 1
        Me.nUpDnPctC2.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nUpDnPctC2.Location = New System.Drawing.Point(479, 157)
        Me.nUpDnPctC2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.nUpDnPctC2.Name = "nUpDnPctC2"
        Me.nUpDnPctC2.Size = New System.Drawing.Size(58, 20)
        Me.nUpDnPctC2.TabIndex = 263
        '
        'nUpDnPctB2
        '
        Me.nUpDnPctB2.DecimalPlaces = 1
        Me.nUpDnPctB2.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nUpDnPctB2.Location = New System.Drawing.Point(479, 118)
        Me.nUpDnPctB2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.nUpDnPctB2.Name = "nUpDnPctB2"
        Me.nUpDnPctB2.Size = New System.Drawing.Size(58, 20)
        Me.nUpDnPctB2.TabIndex = 262
        '
        'nUpDnPctA2
        '
        Me.nUpDnPctA2.DecimalPlaces = 1
        Me.nUpDnPctA2.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nUpDnPctA2.Location = New System.Drawing.Point(479, 79)
        Me.nUpDnPctA2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.nUpDnPctA2.Name = "nUpDnPctA2"
        Me.nUpDnPctA2.Size = New System.Drawing.Size(58, 20)
        Me.nUpDnPctA2.TabIndex = 261
        '
        'nUpDnPctD3
        '
        Me.nUpDnPctD3.DecimalPlaces = 1
        Me.nUpDnPctD3.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nUpDnPctD3.Location = New System.Drawing.Point(683, 198)
        Me.nUpDnPctD3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.nUpDnPctD3.Name = "nUpDnPctD3"
        Me.nUpDnPctD3.Size = New System.Drawing.Size(58, 20)
        Me.nUpDnPctD3.TabIndex = 268
        '
        'nUpDnPctC3
        '
        Me.nUpDnPctC3.DecimalPlaces = 1
        Me.nUpDnPctC3.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nUpDnPctC3.Location = New System.Drawing.Point(683, 157)
        Me.nUpDnPctC3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.nUpDnPctC3.Name = "nUpDnPctC3"
        Me.nUpDnPctC3.Size = New System.Drawing.Size(58, 20)
        Me.nUpDnPctC3.TabIndex = 267
        '
        'nUpDnPctB3
        '
        Me.nUpDnPctB3.DecimalPlaces = 1
        Me.nUpDnPctB3.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nUpDnPctB3.Location = New System.Drawing.Point(683, 118)
        Me.nUpDnPctB3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.nUpDnPctB3.Name = "nUpDnPctB3"
        Me.nUpDnPctB3.Size = New System.Drawing.Size(58, 20)
        Me.nUpDnPctB3.TabIndex = 266
        '
        'nUpDnPctA3
        '
        Me.nUpDnPctA3.DecimalPlaces = 1
        Me.nUpDnPctA3.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nUpDnPctA3.Location = New System.Drawing.Point(683, 79)
        Me.nUpDnPctA3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.nUpDnPctA3.Name = "nUpDnPctA3"
        Me.nUpDnPctA3.Size = New System.Drawing.Size(58, 20)
        Me.nUpDnPctA3.TabIndex = 265
        '
        'nUpDnPctD4
        '
        Me.nUpDnPctD4.DecimalPlaces = 1
        Me.nUpDnPctD4.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nUpDnPctD4.Location = New System.Drawing.Point(888, 198)
        Me.nUpDnPctD4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.nUpDnPctD4.Name = "nUpDnPctD4"
        Me.nUpDnPctD4.Size = New System.Drawing.Size(58, 20)
        Me.nUpDnPctD4.TabIndex = 272
        '
        'nUpDnPctC4
        '
        Me.nUpDnPctC4.DecimalPlaces = 1
        Me.nUpDnPctC4.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nUpDnPctC4.Location = New System.Drawing.Point(888, 157)
        Me.nUpDnPctC4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.nUpDnPctC4.Name = "nUpDnPctC4"
        Me.nUpDnPctC4.Size = New System.Drawing.Size(58, 20)
        Me.nUpDnPctC4.TabIndex = 271
        '
        'nUpDnPctB4
        '
        Me.nUpDnPctB4.DecimalPlaces = 1
        Me.nUpDnPctB4.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nUpDnPctB4.Location = New System.Drawing.Point(888, 118)
        Me.nUpDnPctB4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.nUpDnPctB4.Name = "nUpDnPctB4"
        Me.nUpDnPctB4.Size = New System.Drawing.Size(58, 20)
        Me.nUpDnPctB4.TabIndex = 270
        '
        'nUpDnPctA4
        '
        Me.nUpDnPctA4.DecimalPlaces = 1
        Me.nUpDnPctA4.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nUpDnPctA4.Location = New System.Drawing.Point(888, 79)
        Me.nUpDnPctA4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.nUpDnPctA4.Name = "nUpDnPctA4"
        Me.nUpDnPctA4.Size = New System.Drawing.Size(58, 20)
        Me.nUpDnPctA4.TabIndex = 269
        '
        'nUpDnTFlow1
        '
        Me.nUpDnTFlow1.Location = New System.Drawing.Point(338, 267)
        Me.nUpDnTFlow1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.nUpDnTFlow1.Maximum = New Decimal(New Integer() {125000, 0, 0, 0})
        Me.nUpDnTFlow1.Name = "nUpDnTFlow1"
        Me.nUpDnTFlow1.Size = New System.Drawing.Size(68, 20)
        Me.nUpDnTFlow1.TabIndex = 273
        '
        'nUpDnTFlow2
        '
        Me.nUpDnTFlow2.Location = New System.Drawing.Point(540, 267)
        Me.nUpDnTFlow2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.nUpDnTFlow2.Maximum = New Decimal(New Integer() {125000, 0, 0, 0})
        Me.nUpDnTFlow2.Name = "nUpDnTFlow2"
        Me.nUpDnTFlow2.Size = New System.Drawing.Size(68, 20)
        Me.nUpDnTFlow2.TabIndex = 274
        '
        'nUpDnTFlow3
        '
        Me.nUpDnTFlow3.Location = New System.Drawing.Point(744, 267)
        Me.nUpDnTFlow3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.nUpDnTFlow3.Maximum = New Decimal(New Integer() {125000, 0, 0, 0})
        Me.nUpDnTFlow3.Name = "nUpDnTFlow3"
        Me.nUpDnTFlow3.Size = New System.Drawing.Size(68, 20)
        Me.nUpDnTFlow3.TabIndex = 275
        '
        'nUpDnTFlow4
        '
        Me.nUpDnTFlow4.Location = New System.Drawing.Point(950, 267)
        Me.nUpDnTFlow4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.nUpDnTFlow4.Maximum = New Decimal(New Integer() {125000, 0, 0, 0})
        Me.nUpDnTFlow4.Name = "nUpDnTFlow4"
        Me.nUpDnTFlow4.Size = New System.Drawing.Size(68, 20)
        Me.nUpDnTFlow4.TabIndex = 276
        '
        'repeatTimer
        '
        Me.repeatTimer.Interval = 1000
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.PapayaWhip
        Me.PictureBox2.Location = New System.Drawing.Point(4, 192)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1048, 33)
        Me.PictureBox2.TabIndex = 277
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.LightSteelBlue
        Me.PictureBox3.Location = New System.Drawing.Point(4, 41)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(1046, 145)
        Me.PictureBox3.TabIndex = 278
        Me.PictureBox3.TabStop = False
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1028, 712)
        Me.ShapeContainer1.TabIndex = 279
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.SystemColors.Highlight
        Me.LineShape2.BorderWidth = 5
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 325
        Me.LineShape2.X2 = 325
        Me.LineShape2.Y1 = 296
        Me.LineShape2.Y2 = 457
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.SystemColors.Highlight
        Me.LineShape1.BorderWidth = 5
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 608
        Me.LineShape1.X2 = 608
        Me.LineShape1.Y1 = 301
        Me.LineShape1.Y2 = 462
        '
        'GSMTimed
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1028, 712)
        Me.Controls.Add(Me.nUpDnTFlow4)
        Me.Controls.Add(Me.nUpDnTFlow3)
        Me.Controls.Add(Me.nUpDnTFlow2)
        Me.Controls.Add(Me.nUpDnTFlow1)
        Me.Controls.Add(Me.nUpDnPctD4)
        Me.Controls.Add(Me.nUpDnPctC4)
        Me.Controls.Add(Me.nUpDnPctB4)
        Me.Controls.Add(Me.nUpDnPctA4)
        Me.Controls.Add(Me.nUpDnPctD3)
        Me.Controls.Add(Me.nUpDnPctC3)
        Me.Controls.Add(Me.nUpDnPctB3)
        Me.Controls.Add(Me.nUpDnPctA3)
        Me.Controls.Add(Me.nUpDnPctD2)
        Me.Controls.Add(Me.nUpDnPctC2)
        Me.Controls.Add(Me.nUpDnPctB2)
        Me.Controls.Add(Me.nUpDnPctA2)
        Me.Controls.Add(Me.nUpDnPctD1)
        Me.Controls.Add(Me.nUpDnPctC1)
        Me.Controls.Add(Me.nUpDnPctB1)
        Me.Controls.Add(Me.nUpDnPctA1)
        Me.Controls.Add(Me.Label67)
        Me.Controls.Add(Me.Label68)
        Me.Controls.Add(Me.tbxMaxFlow4)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.Label42)
        Me.Controls.Add(Me.tbxFlow4Mix4)
        Me.Controls.Add(Me.Label43)
        Me.Controls.Add(Me.tbxFlow4Mix3)
        Me.Controls.Add(Me.Label44)
        Me.Controls.Add(Me.tbxFlow4Mix2)
        Me.Controls.Add(Me.Label65)
        Me.Controls.Add(Me.btnFillGas3)
        Me.Controls.Add(Me.Label66)
        Me.Controls.Add(Me.tbxFlow4Mix1)
        Me.Controls.Add(Me.ComboGas3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Chart2)
        Me.Controls.Add(Me.comboPort)
        Me.Controls.Add(Me.ComboBox15)
        Me.Controls.Add(Me.ComboBox14)
        Me.Controls.Add(Me.ComboBox13)
        Me.Controls.Add(Me.ComboBox12)
        Me.Controls.Add(Me.ComboBox11)
        Me.Controls.Add(Me.ComboBox10)
        Me.Controls.Add(Me.ComboBox9)
        Me.Controls.Add(Me.ComboBox8)
        Me.Controls.Add(Me.ComboBox7)
        Me.Controls.Add(Me.ComboBox6)
        Me.Controls.Add(Me.ComboBox5)
        Me.Controls.Add(Me.ComboBox4)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label64)
        Me.Controls.Add(Me.Label63)
        Me.Controls.Add(Me.Label62)
        Me.Controls.Add(Me.Label61)
        Me.Controls.Add(Me.Label60)
        Me.Controls.Add(Me.Label59)
        Me.Controls.Add(Me.ledStep15)
        Me.Controls.Add(Me.tbxStep15)
        Me.Controls.Add(Me.Label58)
        Me.Controls.Add(Me.ledStep14)
        Me.Controls.Add(Me.tbxStep14)
        Me.Controls.Add(Me.Label57)
        Me.Controls.Add(Me.ledStep13)
        Me.Controls.Add(Me.tbxStep13)
        Me.Controls.Add(Me.Label56)
        Me.Controls.Add(Me.ledStep12)
        Me.Controls.Add(Me.tbxStep12)
        Me.Controls.Add(Me.Label55)
        Me.Controls.Add(Me.ledStep11)
        Me.Controls.Add(Me.tbxStep11)
        Me.Controls.Add(Me.Label54)
        Me.Controls.Add(Me.ledStep10)
        Me.Controls.Add(Me.tbxStep10)
        Me.Controls.Add(Me.Label53)
        Me.Controls.Add(Me.ledStep9)
        Me.Controls.Add(Me.tbxStep9)
        Me.Controls.Add(Me.Label52)
        Me.Controls.Add(Me.ledStep8)
        Me.Controls.Add(Me.tbxStep8)
        Me.Controls.Add(Me.Label51)
        Me.Controls.Add(Me.ledStep7)
        Me.Controls.Add(Me.tbxStep7)
        Me.Controls.Add(Me.Label50)
        Me.Controls.Add(Me.ledStep6)
        Me.Controls.Add(Me.tbxStep6)
        Me.Controls.Add(Me.Label49)
        Me.Controls.Add(Me.ledStep5)
        Me.Controls.Add(Me.tbxStep5)
        Me.Controls.Add(Me.Label48)
        Me.Controls.Add(Me.ledStep4)
        Me.Controls.Add(Me.tbxStep4)
        Me.Controls.Add(Me.Label47)
        Me.Controls.Add(Me.ledStep3)
        Me.Controls.Add(Me.tbxStep3)
        Me.Controls.Add(Me.Label46)
        Me.Controls.Add(Me.ledStep2)
        Me.Controls.Add(Me.tbxStep2)
        Me.Controls.Add(Me.Label45)
        Me.Controls.Add(Me.ledStep1)
        Me.Controls.Add(Me.tbxStep1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.tbxErrMsg)
        Me.Controls.Add(Me.Label41)
        Me.Controls.Add(Me.Label40)
        Me.Controls.Add(Me.Label39)
        Me.Controls.Add(Me.Label38)
        Me.Controls.Add(Me.Label37)
        Me.Controls.Add(Me.tbxTotPct4)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.ledRunning4)
        Me.Controls.Add(Me.btnRun4)
        Me.Controls.Add(Me.btnStore4)
        Me.Controls.Add(Me.tbxFlow3Mix4)
        Me.Controls.Add(Me.tbxFlow2Mix4)
        Me.Controls.Add(Me.tbxFlow1Mix4)
        Me.Controls.Add(Me.tbxTotPct3)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.ledRunning3)
        Me.Controls.Add(Me.btnRun3)
        Me.Controls.Add(Me.btnStore3)
        Me.Controls.Add(Me.tbxFlow3Mix3)
        Me.Controls.Add(Me.tbxFlow2Mix3)
        Me.Controls.Add(Me.tbxFlow1Mix3)
        Me.Controls.Add(Me.tbxTotPct2)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.ledRunning2)
        Me.Controls.Add(Me.btnRun2)
        Me.Controls.Add(Me.btnStore2)
        Me.Controls.Add(Me.tbxFlow3Mix2)
        Me.Controls.Add(Me.tbxFlow2Mix2)
        Me.Controls.Add(Me.tbxFlow1Mix2)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.tbxTotPct1)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.btnFillGas2)
        Me.Controls.Add(Me.btnFillGas1)
        Me.Controls.Add(Me.btnFillGas0)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnStopAll)
        Me.Controls.Add(Me.btnHaltSequence)
        Me.Controls.Add(Me.btnRunSequence)
        Me.Controls.Add(Me.tbxMaxFlow3)
        Me.Controls.Add(Me.tbxMaxFlow2)
        Me.Controls.Add(Me.tbxMaxFlow1)
        Me.Controls.Add(Me.ledRunning1)
        Me.Controls.Add(Me.btnRun1)
        Me.Controls.Add(Me.btnStore1)
        Me.Controls.Add(Me.tbxFlow3Mix1)
        Me.Controls.Add(Me.tbxFlow2Mix1)
        Me.Controls.Add(Me.tbxFlow1Mix1)
        Me.Controls.Add(Me.ComboGas2)
        Me.Controls.Add(Me.ComboGas1)
        Me.Controls.Add(Me.ComboGas0)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "GSMTimed"
        Me.Text = "GSM-4-CommXS v1.21"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nUpDnPctA1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nUpDnPctB1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nUpDnPctC1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nUpDnPctD1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nUpDnPctD2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nUpDnPctC2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nUpDnPctB2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nUpDnPctA2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nUpDnPctD3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nUpDnPctC3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nUpDnPctB3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nUpDnPctA3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nUpDnPctD4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nUpDnPctC4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nUpDnPctB4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nUpDnPctA4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nUpDnTFlow1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nUpDnTFlow2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nUpDnTFlow3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nUpDnTFlow4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboGas0 As ComboBox
    Friend WithEvents ComboGas1 As ComboBox
    Friend WithEvents ComboGas2 As ComboBox
    Friend WithEvents MSComm1 As IO.Ports.SerialPort
    Friend WithEvents Timer As Timer
    Friend WithEvents tbxFlow1Mix1 As TextBox
    Friend WithEvents tbxFlow2Mix1 As TextBox
    Friend WithEvents tbxFlow3Mix1 As TextBox
    Friend WithEvents btnStore1 As Button
    Friend WithEvents btnRun1 As Button
    Friend WithEvents ledRunning1 As Button
    Friend WithEvents tbxMaxFlow1 As TextBox
    Friend WithEvents tbxMaxFlow2 As TextBox
    Friend WithEvents tbxMaxFlow3 As TextBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnRunSequence As Button
    Friend WithEvents btnHaltSequence As Button
    Friend WithEvents btnStopAll As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents btnFillGas0 As RadioButton
    Friend WithEvents btnFillGas1 As RadioButton
    Friend WithEvents btnFillGas2 As RadioButton
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents tbxTotPct1 As TextBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents tbxTotPct2 As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents ledRunning2 As Button
    Friend WithEvents btnRun2 As Button
    Friend WithEvents btnStore2 As Button
    Friend WithEvents tbxFlow3Mix2 As TextBox
    Friend WithEvents tbxFlow2Mix2 As TextBox
    Friend WithEvents tbxFlow1Mix2 As TextBox
    Friend WithEvents tbxTotPct3 As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents ledRunning3 As Button
    Friend WithEvents btnRun3 As Button
    Friend WithEvents btnStore3 As Button
    Friend WithEvents tbxFlow3Mix3 As TextBox
    Friend WithEvents tbxFlow2Mix3 As TextBox
    Friend WithEvents tbxFlow1Mix3 As TextBox
    Friend WithEvents tbxTotPct4 As TextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents ledRunning4 As Button
    Friend WithEvents btnRun4 As Button
    Friend WithEvents btnStore4 As Button
    Friend WithEvents tbxFlow3Mix4 As TextBox
    Friend WithEvents tbxFlow2Mix4 As TextBox
    Friend WithEvents tbxFlow1Mix4 As TextBox
    Friend WithEvents Label37 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents tbxErrMsg As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ConfigurationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveConfigurationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoadConfigurationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExperimentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveTimedSequenceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoadTimedSequenceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tbxStep1 As TextBox
    Friend WithEvents ledStep1 As Button
    Friend WithEvents Label45 As Label
    Friend WithEvents Label46 As Label
    Friend WithEvents ledStep2 As Button
    Friend WithEvents tbxStep2 As TextBox
    Friend WithEvents Label47 As Label
    Friend WithEvents ledStep3 As Button
    Friend WithEvents tbxStep3 As TextBox
    Friend WithEvents Label48 As Label
    Friend WithEvents ledStep4 As Button
    Friend WithEvents tbxStep4 As TextBox
    Friend WithEvents Label49 As Label
    Friend WithEvents ledStep5 As Button
    Friend WithEvents tbxStep5 As TextBox
    Friend WithEvents Label50 As Label
    Friend WithEvents ledStep6 As Button
    Friend WithEvents tbxStep6 As TextBox
    Friend WithEvents Label51 As Label
    Friend WithEvents ledStep7 As Button
    Friend WithEvents tbxStep7 As TextBox
    Friend WithEvents Label52 As Label
    Friend WithEvents ledStep8 As Button
    Friend WithEvents tbxStep8 As TextBox
    Friend WithEvents Label53 As Label
    Friend WithEvents ledStep9 As Button
    Friend WithEvents tbxStep9 As TextBox
    Friend WithEvents Label54 As Label
    Friend WithEvents ledStep10 As Button
    Friend WithEvents tbxStep10 As TextBox
    Friend WithEvents Label55 As Label
    Friend WithEvents ledStep11 As Button
    Friend WithEvents tbxStep11 As TextBox
    Friend WithEvents Label56 As Label
    Friend WithEvents ledStep12 As Button
    Friend WithEvents tbxStep12 As TextBox
    Friend WithEvents Label57 As Label
    Friend WithEvents ledStep13 As Button
    Friend WithEvents tbxStep13 As TextBox
    Friend WithEvents Label58 As Label
    Friend WithEvents ledStep14 As Button
    Friend WithEvents tbxStep14 As TextBox
    Friend WithEvents Label59 As Label
    Friend WithEvents ledStep15 As Button
    Friend WithEvents tbxStep15 As TextBox
    Friend WithEvents Label60 As Label
    Friend WithEvents Label61 As Label
    Friend WithEvents Label62 As Label
    Friend WithEvents Label63 As Label
    Friend WithEvents Label64 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents ComboBox6 As ComboBox
    Friend WithEvents ComboBox7 As ComboBox
    Friend WithEvents ComboBox8 As ComboBox
    Friend WithEvents ComboBox9 As ComboBox
    Friend WithEvents ComboBox10 As ComboBox
    Friend WithEvents ComboBox11 As ComboBox
    Friend WithEvents ComboBox12 As ComboBox
    Friend WithEvents ComboBox13 As ComboBox
    Friend WithEvents ComboBox14 As ComboBox
    Friend WithEvents ComboBox15 As ComboBox
    Friend WithEvents lblConfigStrip As ToolStripStatusLabel
    Friend WithEvents comboPort As ComboBox
    Friend WithEvents DirectoryEntry1 As DirectoryServices.DirectoryEntry
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents sFile As SaveFileDialog
    Friend WithEvents ProgBar1 As ToolStripProgressBar
    Friend WithEvents lblSequencerStrip As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Public WithEvents progTimer As Timer
    Friend WithEvents Chart2 As DataVisualization.Charting.Chart
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents Label42 As Label
    Friend WithEvents tbxFlow4Mix4 As TextBox
    Friend WithEvents Label43 As Label
    Friend WithEvents tbxFlow4Mix3 As TextBox
    Friend WithEvents Label44 As Label
    Friend WithEvents tbxFlow4Mix2 As TextBox
    Friend WithEvents Label65 As Label
    Friend WithEvents btnFillGas3 As RadioButton
    Friend WithEvents Label66 As Label
    Friend WithEvents tbxFlow4Mix1 As TextBox
    Friend WithEvents ComboGas3 As ComboBox
    Friend WithEvents Label67 As Label
    Friend WithEvents Label68 As Label
    Friend WithEvents tbxMaxFlow4 As TextBox
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Public WithEvents stepTimer As Timer
    Friend WithEvents nUpDnPctA1 As NumericUpDown
    Friend WithEvents nUpDnPctB1 As NumericUpDown
    Friend WithEvents nUpDnPctC1 As NumericUpDown
    Friend WithEvents nUpDnPctD1 As NumericUpDown
    Friend WithEvents nUpDnPctD2 As NumericUpDown
    Friend WithEvents nUpDnPctC2 As NumericUpDown
    Friend WithEvents nUpDnPctB2 As NumericUpDown
    Friend WithEvents nUpDnPctA2 As NumericUpDown
    Friend WithEvents nUpDnPctD3 As NumericUpDown
    Friend WithEvents nUpDnPctC3 As NumericUpDown
    Friend WithEvents nUpDnPctB3 As NumericUpDown
    Friend WithEvents nUpDnPctA3 As NumericUpDown
    Friend WithEvents nUpDnPctD4 As NumericUpDown
    Friend WithEvents nUpDnPctC4 As NumericUpDown
    Friend WithEvents nUpDnPctB4 As NumericUpDown
    Friend WithEvents nUpDnPctA4 As NumericUpDown
    Friend WithEvents nUpDnTFlow1 As NumericUpDown
    Friend WithEvents nUpDnTFlow2 As NumericUpDown
    Friend WithEvents nUpDnTFlow3 As NumericUpDown
    Friend WithEvents nUpDnTFlow4 As NumericUpDown
    Public WithEvents repeatTimer As Timer
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As PowerPacks.LineShape
    Friend WithEvents LineShape2 As PowerPacks.LineShape
End Class
