' *****************************************************************************************************
' GSM-4-CommXS 
' (c) 2020 CWE, Inc.
' 2020-07-07 v1.21
' created with Visual Studio 2019   vb.net
' Conutrol program for independent 4th channel CWE GSM-4 Gas Mixer
' *****************************************************************************************************
Option Explicit On

Public Class GSMTimed
    Dim Instring As String
    Dim OutputString As String
    Dim gas1, gas2, gas3, gas4, pct1HB, pct1LB, pct2HB, pct2LB, pct3HB, pct3LB, pct4HB, pct4LB, tflowHB, tflowLB As Byte
    Dim command, mix_running As Byte
    Dim counter As Long
    Dim totalpct1, totalpct2, totalpct3, totalpct4
    Dim tflow, pct1, pct2, pct3, pct4 As Integer
    Dim Temp As String
    Dim dataFileName
    Dim hLogFile, MixNo As Integer
    Dim pct1a, pct1b, pct1c, pct1d, pct2a, pct2b, pct2c, pct2d, pct3a, pct3b, pct3c, pct3d, pct4a, pct4b, pct4c, pct4d As Double
    Dim TotFlow1, TotFlow2, TotFlow3, TotFlow4
    Dim flgFlowError1, flgFlowError2, flgFlowError3, flgFlowError4, flgFlowError5
    Dim flgFlowError6, flgFlowError7, flgFlowError8, flgFlowError9, flgFlowError10
    Dim flgFlowError11, flgFlowError12, flgFlowError13, flgFlowError14, flgFlowError15, flgFlowError16
    Dim flgPctError1, flgPctError2, flgPctError3, flgPctError4
    Dim sHour, sMin, sSec As Integer        ' sequencer time variables
    Dim xb, yb, zb, flgStop As Boolean
    Dim seqRunning As Boolean = False       ' flag to prevent user from clicking any RUN buttons while sequencer is running
    Dim repRunning As Boolean = False
    Dim duration, start, finish, repeat_time ' sequencer time variables
    Dim version As Integer = 261            ' keep version updated!
    Dim pctGas1, pctGas2, pctGas3, pctGas4
    Dim run_time(100) As Integer
    Dim later, right_now
    Dim maxflow1, maxflow2, maxflow3, maxflow4         ' ranges of installed flow controllers
    Dim maxTotalFlow, FillGas
    Dim leds() As Button                     ' this is really a control array; elements defined in form load below
    Dim stepboxes() As TextBox               '  control array of sequencer text boxes containing run times
    Dim stepcombos() As ComboBox             '  control array of combobox for step actions
    Dim seconds_counter As Long              '  sequencer step timer
    Dim repeat_counter As Long                 '  seconds counter for repeat timing



    '=========================================================================================================================================
    '                                           STARTUP ROUTINES
    '=========================================================================================================================================
    ' Load main form
    Private Sub GSMTimed_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim x As Integer
        On Error Resume Next
        GetSerialPortNames()                    ' show available serial port names in combobox
        Call LoadConfigurationToolStripMenuItem_Click(sender, e)

        btnFillGas0.Checked = True              ' select fill gas to be gas 1 (usually Nitrogen)
        btnFillGas1.Checked = False             ' de-select others
        btnFillGas2.Checked = False
        btnFillGas3.Checked = False

        '*************************************************************************************************************************************
        ' create control arrays for the SEQUENCER; addressed by: leds(index), stepboxes(index), stepcombos(index), index is 0-14 (for steps 1-15)
        leds = New Button() {ledStep1, ledStep2, ledStep3, ledStep4, ledStep5, ledStep6, ledStep7, ledStep8, ledStep9, ledStep10,
           ledStep11, ledStep12, ledStep13, ledStep14, ledStep15}

        stepboxes = New TextBox() {tbxStep1, tbxStep2, tbxStep3, tbxStep4, tbxStep5, tbxStep6, tbxStep7, tbxStep8,
            tbxStep9, tbxStep10, tbxStep11, tbxStep12, tbxStep13, tbxStep14, tbxStep15}

        stepcombos = New ComboBox() {ComboBox1, ComboBox2, ComboBox3, ComboBox4, ComboBox5, ComboBox6, ComboBox7, ComboBox8, ComboBox9,
            ComboBox10, ComboBox11, ComboBox12, ComboBox13, ComboBox14, ComboBox15}
        '*************************************************************************************************************************************

        ' initialize colors of LEDs
        For x = 0 To 14
            leds(x).BackColor = Color.RosyBrown
        Next

        CreateChart()


    End Sub

    Private Sub stepTimer_Tick(sender As Object, e As EventArgs) Handles stepTimer.Tick
        seconds_counter = seconds_counter + 1
    End Sub

    ' increment seconds counter for REPEAT Time function
    Private Sub repeatTimer_Tick(sender As Object, e As EventArgs) Handles repeatTimer.Tick
        repeat_counter = repeat_counter + 1
    End Sub

    ' load and update mixture BAR CHART
    ' this is called whenever the running gas mixture is changed
    Private Sub CreateChart()
        Me.Chart2.DataSource = GetData()
        Me.Chart2.Series.Clear()
        Chart2.ChartAreas.Clear()
        Chart2.ChartAreas.Add("Area0")
        Me.Chart2.Series.Add("GAS1")    ' Math

        Chart2.Series(0).XValueMember = "Name"
        Chart2.Series(0).YValueMembers = "Percent"
        Chart2.Series(0).IsValueShownAsLabel = True
        Chart2.ChartAreas(0).AxisX.LabelStyle.Angle = 0 '-90

        Chart2.ChartAreas(0).AxisX.MajorGrid.Enabled = False
        Chart2.ChartAreas(0).AxisY.MajorGrid.Enabled = True
        Chart2.ChartAreas(0).AxisY.MajorGrid.LineColor = Color.LightGray

    End Sub


    ' This function gets the data to put into the BAR CHART above
    Public Function GetData() As DataTable
        Dim dt = New DataTable()
        dt.Columns.Add("Name", GetType(String))
        dt.Columns.Add("Percent", GetType(Integer))

        Select Case mix_running
            Case 0
                pctGas1 = 25.0
                pctGas2 = 25.0
                pctGas3 = 25.0
                pctGas4 = 25.0
            Case 1
                pctGas1 = nUpDnPctA1.Value
                pctGas2 = nUpDnPctB1.Value
                pctGas3 = nUpDnPctC1.Value
                pctGas4 = nUpDnPctD1.Value
            Case 2
                pctGas1 = nUpDnPctA2.Value
                pctGas2 = nUpDnPctB2.Value
                pctGas3 = nUpDnPctC2.Value
                pctGas4 = nUpDnPctD2.Value

            Case 3
                pctGas1 = nUpDnPctA3.Value
                pctGas2 = nUpDnPctB3.Value
                pctGas3 = nUpDnPctC3.Value
                pctGas4 = nUpDnPctD3.Value
            Case 4
                pctGas1 = nUpDnPctA4.Value
                pctGas2 = nUpDnPctB4.Value
                pctGas3 = nUpDnPctC4.Value
                pctGas4 = nUpDnPctD4.Value
        End Select

        dt.Rows.Add("GAS1", pctGas1)   ' alex
        dt.Rows.Add("GAS2", pctGas2)  'richard
        dt.Rows.Add("GAS3", pctGas3)    ' alice
        dt.Rows.Add("GAS4", pctGas4)    ' alice 
        Return dt
    End Function


    ' this finds all the available SERIAL PORTS and puts them into the combo control
    Sub GetSerialPortNames()
        For Each sp As String In My.Computer.Ports.SerialPortNames ' Show all available COM ports.
            comboPort.Items.Add(sp)
            comboPort.SelectedIndex = 0     ' point to first valid port on the list
            comboPort.GetItemText(0)        ' pre-load this into the selection textbox
        Next
    End Sub



    ' this is the ProgBar1 progress bar timer
    ' tick increment is set programatically to allow 100 ticks full scale
    Private Sub progTimer_Tick(sender As Object, e As EventArgs) Handles progTimer.Tick
        If ProgBar1.Value < ProgBar1.Maximum Then
            ProgBar1.Value += 1     ' increment progress bar at bottom of screen
        End If
    End Sub



    '=========================================================================================================================================
    '                             USER HAS UPDATED FLOW CONTROLLER CONFIGURATION
    '=========================================================================================================================================
    Private Sub tbxMaxFlow2_TextChanged(sender As Object, e As EventArgs) Handles tbxMaxFlow2.TextChanged
        maxflow2 = Val(tbxMaxFlow2.Text)
    End Sub

    Private Sub tbxMaxFlow3_TextChanged(sender As Object, e As EventArgs) Handles tbxMaxFlow3.TextChanged
        maxflow3 = Val(tbxMaxFlow3.Text)
    End Sub

    Private Sub tbxMaxFlow1_TextChanged(sender As Object, e As EventArgs) Handles tbxMaxFlow1.TextChanged
        maxflow1 = Val(tbxMaxFlow1.Text)
    End Sub
    Private Sub tbxMaxFlow4_TextChanged(sender As Object, e As EventArgs) Handles tbxMaxFlow4.TextChanged
        maxflow4 = Val(tbxMaxFlow4.Text)
    End Sub



    '=========================================================================================================================================
    '                                           RUN SEQUENCER
    '=========================================================================================================================================
    Private Sub btnRunSequence_Click(sender As Object, e As EventArgs) Handles btnRunSequence.Click
        Dim x As Integer
        flgStop = False                                 ' flag is set by clicking HALT SEQUENCE
        If seqRunning = True Then Return
        seqRunning = True                               ' flag to prevent user from clicking other RUN buttons while sequencer is running
        On Error Resume Next
restart:                                                ' cycle back here to repeat sequence
        ' check user time boxes for proper format "HH:MM:SS",  highlight with red text if invalid
        For x = 0 To 14
            If Len(stepboxes(x).Text) <> 8 Then
                stepboxes(x).ForeColor = Color.Red ' check for proper string format
                stepboxes(x).Refresh()
            Else
                stepboxes(x).ForeColor = Color.Black
                stepboxes(x).Refresh()
            End If
        Next

        '---------------------------------------------------------------------------------------------------------------------------------------------
        For x = 0 To 14
            If stepcombos(x).Text = "NONE" Then GoTo skip_this_step ' NONE, so skip this step
            If stepcombos(x).Text = "REPEAT" Then GoTo restart      ' REPEAT, so go back to top and repeat sequence
            If stepcombos(x).Text = "STOP" Then Exit For            ' STOP, so clean up and get out

            If stepcombos(x).Text = "GOTO" Then                     ' GOTO nn, nn read from seconds position of time panel
                If Val((stepboxes(x).Text).Substring(6, 2)) <> 0 Then
                    x = Val((stepboxes(x).Text).Substring(6, 2) - 1)         ' extract seconds from string
                End If
            End If

            '-------------------------------------------------------------------------------------------------------------------------------------
            If stepcombos(x).Text = "REPEAT Time" Then              ' repeat from top to here until time is elapsed
                If repRunning = False Then                              ' first time, so start timer and set flag
                    repRunning = True                                  ' set flag that repeat is in progress
                    ' extract time from string
                    sSec = Val((stepboxes(x).Text).Substring(6, 2))         ' extract seconds from string
                    If sSec > 59 Then sSec = 59
                    sMin = Val((stepboxes(x).Text).Substring(3, 2))         ' extract minutes
                    If sMin > 59 Then sMin = 59
                    sHour = Val((stepboxes(x).Text).Substring(0, 2))        ' extract hours
                    repeat_time = sSec + (60 * sMin) + (3600 * sHour)       ' convert all to seconds
                    If repeat_time = 0 Then GoTo skip_this_step             ' prevent zero time values
                    repeatTimer.Start()               ' 
                    repeat_counter = 0
                    GoTo restart                                            ' first pass, go back to top (repeat)
                Else
                    If repeat_counter < repeat_time Then
                        GoTo restart
                    Else
                        repRunning = False
                        repeatTimer.Stop()
                        progTimer.Stop()
                        progTimer.Enabled = False
                        If flgStop = True Then GoTo cleanup_and_exit
                        GoTo skip_this_step
                    End If
                End If

                If flgStop = 1 Then Exit For 'GoTo cleanup_and_exit
            End If
            '-------------------------------------------------------------------------------------------------------------------------------------

            ' else, this must be a timed run
            ' check for proper format HH:MM:SS
            If Len(stepboxes(x).Text) <> 8 Then
                stepboxes(x).ForeColor = Color.Red                  ' check for proper string format
            Else
                stepboxes(x).ForeColor = Color.Black
            End If
            ' extract time from string
            sSec = Val((stepboxes(x).Text).Substring(6, 2))         ' extract seconds from string
            If sSec > 59 Then sSec = 59
            sMin = Val((stepboxes(x).Text).Substring(3, 2))         ' extract minutes
            If sMin > 59 Then sMin = 59
            sHour = Val((stepboxes(x).Text).Substring(0, 2))        ' extract hours
            duration = sSec + (60 * sMin) + (3600 * sHour)          ' convert all to seconds
            If duration = 0 Then GoTo skip_this_step                ' prevent zero time values

            '------------------------------------------------------------------------------------------------------------------------------------------
            Select Case stepcombos(x).Text
                Case "PAUSE"                        ' run MIX 1
                    progTimer.Interval = Int(duration * 1000 / 100) ' set interval to give 100 ticks of progress bar
                    ProgBar1.Value = 0              ' reset progress bar to zero
                    progTimer.Enabled = True
                    progTimer.Start()
                    leds(x).BackColor = Color.Red
                    leds(x).Refresh()

                    btnHaltSequence.Focus()         ' this makes sure the halt sequence button gets read all the time

                    stepTimer.Start()               ' 
                    seconds_counter = 0
                    Do While (duration > seconds_counter)
                        My.Application.DoEvents()       ' be sure background ui events are looked at
                        If flgStop = 1 Then Exit For 'GoTo cleanup_and_exit
                    Loop

                    leds(x).BackColor = Color.RosyBrown
                    leds(x).Refresh()
                    ProgBar1.Value = 0

                    progTimer.Stop()

                    progTimer.Enabled = False
                    If flgStop = True Then GoTo cleanup_and_exit

                Case "Mix 1"                        ' run MIX 1
                    progTimer.Interval = Int(duration * 1000 / 100) ' set interval to give 100 ticks of progress bar
                    ProgBar1.Value = 0              ' reset progress bar to zero
                    progTimer.Enabled = True
                    progTimer.Start()
                    mix_running = 1
                    ledRunning1.BackColor = Color.Red
                    ledRunning1.Refresh()
                    Call btnRun1_Click(sender, e)   ' fire this button to run selected mix
                    leds(x).BackColor = Color.Red
                    leds(x).Refresh()

                    btnHaltSequence.Focus()         ' this makes sure the halt sequence button gets read all the time

                    stepTimer.Start()               ' 
                    seconds_counter = 0
                    Do While (duration > seconds_counter)
                        My.Application.DoEvents()       ' be sure background ui events are looked at
                        If flgStop = 1 Then Exit For 'GoTo cleanup_and_exit
                    Loop

                    leds(x).BackColor = Color.RosyBrown
                    leds(x).Refresh()
                    ProgBar1.Value = 0

                    progTimer.Stop()

                    progTimer.Enabled = False
                    If flgStop = True Then GoTo cleanup_and_exit

                Case "Mix 2"                                    ' run MIX 2
                    progTimer.Interval = Int(duration * 1000 / 100) ' set interval to give 100 ticks of progress bar
                    ProgBar1.Value = 0              ' reset progress bar to zero
                    progTimer.Enabled = True
                    progTimer.Start()
                    mix_running = 2
                    ledRunning2.BackColor = Color.Red
                    ledRunning2.Refresh()
                    Call btnRun2_Click(sender, e)   ' fire this button to run selected mix
                    leds(x).BackColor = Color.Red
                    leds(x).Refresh()

                    btnHaltSequence.Focus()         ' this makes sure the halt sequence button gets read all the time

                    stepTimer.Start()               ' 
                    seconds_counter = 0
                    Do While (duration > seconds_counter)
                        My.Application.DoEvents()       ' be sure background ui events are looked at
                        If flgStop = 1 Then Exit For 'GoTo cleanup_and_exit
                    Loop

                    leds(x).BackColor = Color.RosyBrown
                    leds(x).Refresh()
                    ProgBar1.Value = 0
                    progTimer.Enabled = False
                    If flgStop = True Then GoTo cleanup_and_exit

                Case "Mix 3"                                    ' run MIX 3
                    progTimer.Interval = Int(duration * 1000 / 100) ' set interval to give 100 ticks of progress bar
                    ProgBar1.Value = 0              ' reset progress bar to zero
                    progTimer.Enabled = True
                    progTimer.Start()
                    mix_running = 3
                    ledRunning3.BackColor = Color.Red
                    ledRunning3.Refresh()
                    Call btnRun3_Click(sender, e)   ' fire this button to run selected mix
                    leds(x).BackColor = Color.Red
                    leds(x).Refresh()

                    btnHaltSequence.Focus()         ' this makes sure the halt sequence button gets read all the time

                    stepTimer.Start()               ' 
                    seconds_counter = 0
                    Do While (duration > seconds_counter)
                        My.Application.DoEvents()       ' be sure background ui events are looked at
                        If flgStop = 1 Then Exit For 'GoTo cleanup_and_exit
                    Loop

                    leds(x).BackColor = Color.RosyBrown
                    leds(x).Refresh()
                    ProgBar1.Value = 0
                    progTimer.Enabled = False
                    If flgStop = True Then GoTo cleanup_and_exit

                Case "Mix 4"                                    ' run MIX 4
                    progTimer.Interval = Int(duration * 1000 / 100) ' set interval to give 100 ticks of progress bar
                    ProgBar1.Value = 0              ' reset progress bar to zero
                    progTimer.Enabled = True
                    progTimer.Start()
                    mix_running = 4
                    ledRunning4.BackColor = Color.Red
                    ledRunning4.Refresh()
                    Call btnRun4_Click(sender, e)   ' fire this button to run selected mix
                    leds(x).BackColor = Color.Red
                    leds(x).Refresh()

                    btnHaltSequence.Focus()         ' this makes sure the halt sequence button gets read all the time

                    stepTimer.Start()               ' 
                    seconds_counter = 0
                    Do While (duration > seconds_counter)
                        My.Application.DoEvents()       ' be sure background ui events are looked at
                        If flgStop = 1 Then Exit For 'GoTo cleanup_and_exit
                    Loop

                    leds(x).BackColor = Color.RosyBrown
                    leds(x).Refresh()
                    ProgBar1.Value = 0
                    progTimer.Enabled = False
                    If flgStop = True Then GoTo cleanup_and_exit
            End Select
skip_this_step:
        Next

cleanup_and_exit:       ' close down sequencer operations
        For x = 0 To 14
            leds(x).BackColor = Color.RosyBrown
        Next
        Call btnStopAll_Click(sender, e)
        seqRunning = False
    End Sub



    '=========================================================================================================================================
    '                                           RUN MIXTURE PUSHBUTTON ROUTINES
    '=========================================================================================================================================
    ' following subs handle user pressing a RUN MIXTURE button for the 4 mixtures
    Private Sub btnRun1_Click(sender As Object, e As EventArgs) Handles btnRun1.Click

        If seqRunning = True Then           ' this locks out user from clicking RUN when sequencer is running
            btnRun1.Enabled = False
        Else btnRun1.enabled = True
        End If

        MSComm1.PortName = comboPort.Text
        MSComm1.Open()              ' Open the port.
        OutputString = "1"
        MSComm1.Write(OutputString)       ' send the command string
        MSComm1.Close()           ' Close the port.
        mix_running = 1
        CreateChart()                   ' update bar chart with gas percentages
    End Sub

    Private Sub btnRun2_Click(sender As Object, e As EventArgs) Handles btnRun2.Click
        If seqRunning = True Then           ' this locks out user from clicking RUN when sequencer is running
            btnRun2.Enabled = False
        Else btnRun2.Enabled = True
        End If

        MSComm1.PortName = comboPort.Text
        'MSComm1.Settings = "19200,N,8,1"
        MSComm1.Open()              ' Open the port.
        OutputString = "2"
        MSComm1.Write(OutputString)       ' send the command string
        MSComm1.Close()           ' Close the port.
        mix_running = 2
        CreateChart()                   ' update bar chart with gas percentages
    End Sub

    Private Sub btnRun3_Click(sender As Object, e As EventArgs) Handles btnRun3.Click
        If seqRunning = True Then           ' this locks out user from clicking RUN when sequencer is running
            btnRun3.Enabled = False
        Else btnRun3.Enabled = True
        End If

        MSComm1.PortName = comboPort.Text
        'MSComm1.Settings = "19200,N,8,1"
        MSComm1.Open()              ' Open the port.
        OutputString = "3"
        MSComm1.Write(OutputString)       ' send the command string
        MSComm1.Close()           ' Close the port.
        mix_running = 3
        CreateChart()                   ' update bar chart with gas percentages
    End Sub

    Private Sub btnRun4_Click(sender As Object, e As EventArgs) Handles btnRun4.Click
        If seqRunning = True Then           ' this locks out user from clicking RUN when sequencer is running
            btnRun4.Enabled = False
        Else btnRun4.Enabled = True
        End If

        MSComm1.PortName = comboPort.Text
        'MSComm1.Settings = "19200,N,8,1"
        MSComm1.Open()              ' Open the port.
        OutputString = "4"
        MSComm1.Write(OutputString)       ' send the command string
        MSComm1.Close()           ' Close the port.
        mix_running = 4
        CreateChart()                   ' update bar chart with gas percentages
    End Sub
    '-----------------------------------------------------------------------------------------------------------------------------------------
    Private Sub btnStopAll_Click(sender As Object, e As EventArgs) Handles btnStopAll.Click
        MSComm1.PortName = comboPort.Text
        MSComm1.Open()              ' Open the port.
        OutputString = "9"          ' command to stop all channels
        MSComm1.Write(OutputString) ' send the command string
        MSComm1.Close()             ' Close the port.
        mix_running = 0
        CreateChart()                   ' update bar chart with gas percentages
        Call btnHaltSequence_Click(sender, e)
    End Sub



    '=========================================================================================================================================
    '                                     STORE/RUN BUTTON ROUTINES
    '=========================================================================================================================================
    Private Sub btnStore1_Click(sender As Object, e As EventArgs) Handles btnStore1.Click
        ' construct output program string (12 bytes):
        ' 3-CHAN VERSION: MixNo,Gas1,Pct1.hb,Pct1.lb,Gas2,Pct2.hb,Pct2.lb,Gas3,Pct3.hb,Pct3.lb,TotFlow.hb,Totflow.lb
        ' 4-CHAN VERSION: MixNo,Gas1,Pct1.hb,Pct1.lb,Gas2,Pct2.hb,Pct2.lb,Gas3,Pct3.hb,Pct3.lb,Pct4.hb,Pct4.lb,TotFlow.hb,Totflow.lb

        If seqRunning = True Then Return          ' this locks out user from clicking RUN when sequencer is running

        gas1 = ComboGas0.SelectedIndex + 1
        If gas1 = 0 Then gas1 = 1   ' if not set, make it AIR
        pct1 = nUpDnPctA1.Value * 10
        pct1HB = Int(pct1 / 256)
        pct1LB = Int(pct1 - (Int(pct1HB) * 256))

        gas2 = ComboGas1.SelectedIndex + 1
        If gas2 = 0 Then gas2 = 1   ' if not set, make it AIR
        pct2 = nUpDnPctB1.Value * 10
        pct2HB = Int(pct2 / 256)
        pct2LB = Int(pct2 - (Int(pct2HB) * 256))

        gas3 = ComboGas2.SelectedIndex + 1
        If gas3 = 0 Then gas3 = 1   ' if not set, make it AIR
        pct3 = nUpDnPctC1.Value * 10
        pct3HB = Int(pct3 / 256)
        pct3LB = Int(pct3 - (Int(pct3HB) * 256))

        gas4 = ComboGas3.SelectedIndex + 1
        If gas4 = 0 Then gas4 = 1   ' if not set, make it AIR
        pct4 = nUpDnPctD1.Value * 10
        pct4HB = Int(pct4 / 256)
        pct4LB = Int(pct4 - (Int(pct4HB) * 256))

        tflow = nUpDnTFlow1.Value
        tflowHB = Int(tflow / 256)
        tflowLB = Int(tflow - (tflowHB * 256))

        ' send output as array of bytes
        Dim bytes() As Byte = {1, gas1, pct1HB, pct1LB, gas2, pct2HB, pct2LB, gas3, pct3HB, pct3LB, gas4, pct4HB, pct4LB, tflowHB, tflowLB}
        MSComm1.PortName = comboPort.Text
        MSComm1.Open()                  ' Open the port.
        MSComm1.Write(bytes, 0, bytes.Length)
        MSComm1.Close()                 ' Close the port.
        mix_running = 1
        CreateChart()

        'Debug.Print(1, gas1, pct1HB, pct1LB, gas2, pct2HB, pct2LB, gas3, pct3HB, pct3LB, gas4, pct4HB, pct4LB, tflowHB, tflowLB)
    End Sub

    Private Sub btnStore2_Click(sender As Object, e As EventArgs) Handles btnStore2.Click
        ' construct output program string (12 bytes):
        ' MixNo,Gas1,Pct1.hb,Pct1.lb,Gas2,Pct2.hb,Pct2.lb,Gas3,Pct3.hb,Pct3.lb,TotFlow.hb,Totflow.lb

        If seqRunning = True Then Return    ' this locks out user from clicking RUN when sequencer is running

        gas1 = ComboGas0.SelectedIndex + 1
        If gas1 = 0 Then gas1 = 1   ' if not set, make it AIR
        pct1 = nUpDnPctA2.Value * 10
        pct1HB = Int(pct1 / 256)
        pct1LB = Int(pct1 - (Int(pct1HB) * 256))

        gas2 = ComboGas1.SelectedIndex + 1
        If gas2 = 0 Then gas2 = 1   ' if not set, make it AIR
        pct2 = nUpDnPctB2.Value * 10
        pct2HB = Int(pct2 / 256)
        pct2LB = Int(pct2 - (Int(pct2HB) * 256))

        gas3 = ComboGas2.SelectedIndex + 1
        If gas3 = 0 Then gas3 = 1   ' if not set, make it AIR
        pct3 = nUpDnPctC2.Value * 10
        pct3HB = Int(pct3 / 256)
        pct3LB = Int(pct3 - (Int(pct3HB) * 256))

        gas4 = ComboGas3.SelectedIndex + 1
        If gas4 = 0 Then gas4 = 1   ' if not set, make it AIR
        pct4 = nUpDnPctD2.Value * 10
        pct4HB = Int(pct4 / 256)
        pct4LB = Int(pct4 - (Int(pct4HB) * 256))

        tflow = nUpDnTFlow2.Value
        tflowHB = Int(tflow / 256)
        tflowLB = Int(tflow - (tflowHB * 256))

        ' send output as array of bytes
        Dim bytes() As Byte = {2, gas1, pct1HB, pct1LB, gas2, pct2HB, pct2LB, gas3, pct3HB, pct3LB, gas4, pct4HB, pct4LB, tflowHB, tflowLB}
        MSComm1.PortName = comboPort.Text
        MSComm1.Open()                  ' Open the port.
        MSComm1.Write(bytes, 0, bytes.Length)
        MSComm1.Close()                 ' Close the port.
        mix_running = 2
        CreateChart()
    End Sub

    Private Sub btnStore3_Click(sender As Object, e As EventArgs) Handles btnStore3.Click
        ' construct output program string (12 bytes):
        ' MixNo,Gas1,Pct1.hb,Pct1.lb,Gas2,Pct2.hb,Pct2.lb,Gas3,Pct3.hb,Pct3.lb,TotFlow.hb,Totflow.lb

        If seqRunning = True Then Return          ' this locks out user from clicking RUN when sequencer is running

        gas1 = ComboGas0.SelectedIndex + 1
        If gas1 = 0 Then gas1 = 1   ' if not set, make it AIR
        pct1 = nUpDnPctA3.Value * 10
        pct1HB = Int(pct1 / 256)
        pct1LB = Int(pct1 - (Int(pct1HB) * 256))

        gas2 = ComboGas1.SelectedIndex + 1
        If gas2 = 0 Then gas2 = 1   ' if not set, make it AIR
        pct2 = nUpDnPctB3.Value * 10
        pct2HB = Int(pct2 / 256)
        pct2LB = Int(pct2 - (Int(pct2HB) * 256))

        gas3 = ComboGas2.SelectedIndex + 1
        If gas3 = 0 Then gas3 = 1   ' if not set, make it AIR
        pct3 = nUpDnPctC3.Value * 10
        pct3HB = Int(pct3 / 256)
        pct3LB = Int(pct3 - (Int(pct3HB) * 256))

        gas4 = ComboGas3.SelectedIndex + 1
        If gas4 = 0 Then gas4 = 1   ' if not set, make it AIR
        pct4 = nUpDnPctC4.Value * 10
        pct4HB = Int(pct4 / 256)
        pct4LB = Int(pct4 - (Int(pct3HB) * 256))

        tflow = nUpDnTFlow3.Value
        tflowHB = Int(tflow / 256)
        tflowLB = Int(tflow - (tflowHB * 256))

        ' send output as array of bytes
        Dim bytes() As Byte = {3, gas1, pct1HB, pct1LB, gas2, pct2HB, pct2LB, gas3, pct3HB, pct3LB, gas4, pct4HB, pct4LB, tflowHB, tflowLB}
        MSComm1.PortName = comboPort.Text
        MSComm1.Open()                  ' Open the port.
        MSComm1.Write(bytes, 0, bytes.Length)
        MSComm1.Close()
        mix_running = 3
        CreateChart()
    End Sub

    Private Sub btnStore4_Click(sender As Object, e As EventArgs) Handles btnStore4.Click
        ' construct output program string (12 bytes):
        ' MixNo,Gas1,Pct1.hb,Pct1.lb,Gas2,Pct2.hb,Pct2.lb,Gas3,Pct3.hb,Pct3.lb,TotFlow.hb,Totflow.lb

        If seqRunning = True Then Return          ' this locks out user from clicking RUN when sequencer is running

        gas1 = ComboGas0.SelectedIndex + 1
        If gas1 = 0 Then gas1 = 1   ' if not set, make it AIR
        pct1 = nUpDnPctA4.Value * 10
        pct1HB = Int(pct1 / 256)
        pct1LB = Int(pct1 - (Int(pct1HB) * 256))

        gas2 = ComboGas1.SelectedIndex + 1
        If gas2 = 0 Then gas2 = 1   ' if not set, make it AIR
        pct2 = nUpDnPctB4.Value * 10
        pct2HB = Int(pct2 / 256)
        pct2LB = Int(pct2 - (Int(pct2HB) * 256))

        gas3 = ComboGas2.SelectedIndex + 1
        If gas3 = 0 Then gas3 = 1   ' if not set, make it AIR
        pct3 = nUpDnPctC4.Value * 10
        pct3HB = Int(pct3 / 256)
        pct3LB = Int(pct3 - (Int(pct3HB) * 256))

        gas4 = ComboGas3.SelectedIndex + 1
        If gas4 = 0 Then gas4 = 1   ' if not set, make it AIR
        pct4 = nUpDnPctD4.Value * 10
        pct4HB = Int(pct4 / 256)
        pct4LB = Int(pct4 - (Int(pct3HB) * 256))

        tflow = nUpDnTFlow4.Value
        tflowHB = Int(tflow / 256)
        tflowLB = Int(tflow - (tflowHB * 256))

        ' send output as array of bytes
        Dim bytes() As Byte = {4, gas1, pct1HB, pct1LB, gas2, pct2HB, pct2LB, gas3, pct3HB, pct3LB, gas4, pct4HB, pct4LB, tflowHB, tflowLB}
        MSComm1.PortName = comboPort.Text
        MSComm1.Open()                  ' Open the port.
        MSComm1.Write(bytes, 0, bytes.Length)
        MSComm1.Close()
        mix_running = 4
        CreateChart()
    End Sub



    '=========================================================================================================================================
    '                                   EXIT BUTTON AND MENU HANDLING ROUTINES
    '=========================================================================================================================================
    ' EXIT button pressed
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        MSComm1.Close()             ' close the port
        flgStop = True
        progTimer.Enabled = False
        Call SaveConfigurationToolStripMenuItem_Click(sender, e)     ' prompt user to save configuration file
        Me.Close()                  ' close window and application
    End Sub



    '=========================================================================================================================================
    '                                    MENU LOAD CONFIGURATION FILE is selected
    '=========================================================================================================================================
    Private Sub LoadConfigurationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadConfigurationToolStripMenuItem.Click
        Dim replace
        Dim InputString As String
        Dim fnConfig As String
        On Error Resume Next

        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        openFileDialog1.Title = "Load Configuration File"

        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            fnConfig = openFileDialog1.FileName ' selected file

            FileOpen(1, fnConfig, OpenMode.Input)
            Input(1, gas1)
            Input(1, gas2)
            Input(1, gas3)
            Input(1, gas4)
            Input(1, pct1a)
            Input(1, pct1b)
            Input(1, pct1c)
            Input(1, pct1d)
            Input(1, TotFlow1)

            Input(1, pct2a)
            Input(1, pct2b)
            Input(1, pct2c)
            Input(1, pct2d)
            Input(1, TotFlow2)

            Input(1, pct3a)
            Input(1, pct3b)
            Input(1, pct3c)
            Input(1, pct3d)
            Input(1, TotFlow3)

            Input(1, pct4a)
            Input(1, pct4b)
            Input(1, pct4c)
            Input(1, pct4d)
            Input(1, TotFlow4)

            Input(1, maxflow1)
            Input(1, maxflow2)
            Input(1, maxflow3)
            Input(1, maxflow4)
            Input(1, FillGas)
            FileClose(1)

            Debug.Print(maxflow1, maxflow2, maxflow3, maxflow4, FillGas)
            Debug.Print(maxflow2) '
            Debug.Print(maxflow3)
            Debug.Print(maxflow4)

            If FillGas = 0 Then
                btnFillGas0.Checked = True
                btnFillGas1.Checked = False
                btnFillGas2.Checked = False
                btnFillGas3.Checked = False
            End If

            If FillGas = 1 Then
                btnFillGas0.Checked = False
                btnFillGas1.Checked = True
                btnFillGas2.Checked = False
                btnFillGas3.Checked = False
            End If

            If FillGas = 2 Then
                btnFillGas0.Checked = False
                btnFillGas1.Checked = False
                btnFillGas2.Checked = True
                btnFillGas3.Checked = False
            End If

            If FillGas = 3 Then
                btnFillGas0.Checked = False
                btnFillGas1.Checked = False
                btnFillGas2.Checked = False
                btnFillGas3.Checked = True
            End If

            tbxMaxFlow1.Text = maxflow1     ' installed flow controllers
            tbxMaxFlow2.Text = maxflow2
            tbxMaxFlow3.Text = maxflow3
            tbxMaxFlow4.Text = maxflow4

            ComboGas0.Text = ComboGas0.Items(gas1)    ' gasses
            ComboGas1.Text = ComboGas1.Items(gas2)
            ComboGas2.Text = ComboGas2.Items(gas3)
            ComboGas3.Text = ComboGas3.Items(gas4)

            nUpDnPctA1.Value = pct1a / 10       ' Mix 1, gas A
            nUpDnPctB1.Value = pct1b / 10       ' Mix 1, gas B
            nUpDnPctC1.Value = pct1c / 10       ' Mix 1, gas C
            nUpDnPctD1.Value = pct1d / 10       ' Mix 1, gas D
            nUpDnTFlow1.Value = TotFlow1        ' Mix 1, total flow

            nUpDnPctA2.Value = pct2a / 10       ' Mix 2, gas A
            nUpDnPctB2.Value = pct2b / 10       ' Mix 2, gas B
            nUpDnPctC2.Value = pct2c / 10       ' Mix 2, gas C
            nUpDnPctD2.Value = pct2d / 10       ' Mix 2, gas D
            nUpDnTFlow2.Value = TotFlow2        ' Mix 2, total flow

            nUpDnPctA3.Value = pct3a / 10       ' Mix 3, gas A
            nUpDnPctB3.Value = pct3b / 10       ' Mix 3, gas B
            nUpDnPctC3.Value = pct3c / 10       ' Mix 3, gas C
            nUpDnPctD3.Value = pct3d / 10       ' Mix 3, gas D
            nUpDnTFlow3.Value = TotFlow3        ' Mix 3, total flow

            nUpDnPctA4.Value = pct4a / 10       ' Mix 4, gas A
            nUpDnPctB4.Value = pct4b / 10       ' Mix 4, gas B
            nUpDnPctC4.Value = pct4c / 10       ' Mix 4, gas C
            nUpDnPctD4.Value = pct4d / 10       ' Mix 4, gas D
            nUpDnTFlow4.Value = TotFlow4        ' Mix 4, total flow

            Dim result As String                            ' get filename and show in status strip at bottom of window
            result = System.IO.Path.GetFileName(fnConfig)   ' get plain filename without full path
            lblConfigStrip.Text = "Configuration file:  " & result
        End If
    End Sub



    '=========================================================================================================================================
    '                                    MENU SAVE CONFIGURATION FILE is selected
    '=========================================================================================================================================
    Private Sub SaveConfigurationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveConfigurationToolStripMenuItem.Click
        On Error Resume Next

        ' collect all the values to be saved to the configuration file
        If btnFillGas0.Checked = True Then FillGas = 0
        If btnFillGas1.Checked = True Then FillGas = 1
        If btnFillGas2.Checked = True Then FillGas = 2
        If btnFillGas3.Checked = True Then FillGas = 3

        gas1 = ComboGas0.SelectedIndex
        gas2 = ComboGas1.SelectedIndex
        gas3 = ComboGas2.SelectedIndex
        gas4 = ComboGas3.SelectedIndex

        pct1a = nUpDnPctA1.Value * 10       ' Mix 1, gas A
        pct1b = nUpDnPctB1.Value * 10       ' Mix 1, gas B
        pct1c = nUpDnPctC1.Value * 10       ' Mix 1, gas C
        pct1d = nUpDnPctD1.Value * 10       ' Mix 1, gas D
        TotFlow1 = nUpDnTFlow1.Value        ' Mix 1, total flow

        pct2a = nUpDnPctA2.Value * 10       ' Mix 2, gas A
        pct2b = nUpDnPctB2.Value * 10       ' Mix 2, gas B
        pct2c = nUpDnPctC2.Value * 10       ' Mix 2, gas C
        pct2d = nUpDnPctD2.Value * 10       ' Mix 2, gas D
        TotFlow2 = nUpDnTFlow2.Value        ' Mix 2, total flow

        pct3a = nUpDnPctA3.Value * 10       ' Mix 3, gas A
        pct3b = nUpDnPctB3.Value * 10       ' Mix 3, gas B
        pct3c = nUpDnPctC3.Value * 10       ' Mix 3, gas C
        pct3d = nUpDnPctD3.Value * 10       ' Mix 3, gas D
        TotFlow3 = nUpDnTFlow3.Value        ' Mix 3, total flow

        pct4a = nUpDnPctA4.Value * 10       ' Mix 4, gas A
        pct4b = nUpDnPctB4.Value * 10       ' Mix 4, gas B
        pct4c = nUpDnPctC4.Value * 10       ' Mix 4, gas C
        pct4d = nUpDnPctD4.Value * 10       ' Mix 4, gas D
        TotFlow4 = nUpDnTFlow4.Value        ' Mix 4, total flow

        maxflow1 = Val(tbxMaxFlow1.Text)
        maxflow2 = Val(tbxMaxFlow2.Text)
        maxflow3 = Val(tbxMaxFlow3.Text)
        maxflow4 = Val(tbxMaxFlow4.Text)

        ' set up SaveFileDialogBox and Streamwriter
        sFile.FileName = "Save as..."
        sFile.Filter = "(*txt) | *.txt"
        sFile.OverwritePrompt = True
        sFile.CreatePrompt = True
        'sFile.CheckFileExists = True                ' this prevents creation of new file! Don't use it!
        sFile.ShowDialog()
        Dim W As New IO.StreamWriter(sFile.FileName)

        ' write the individual values 
        W.Write(gas1 & ",")
        W.Write(gas2 & ",")
        W.Write(gas3 & ",")
        W.Write(gas4 & ",")
        W.Write(pct1a & ",")
        W.Write(pct1b & ",")
        W.Write(pct1c & ",")
        W.Write(pct1d & ",")
        W.Write(TotFlow1 & ",")
        W.Write(pct2a & ",")
        W.Write(pct2b & ",")
        W.Write(pct2c & ",")
        W.Write(pct2d & ",")
        W.Write(TotFlow2 & ",")
        W.Write(pct3a & ",")
        W.Write(pct3b & ",")
        W.Write(pct3c & ",")
        W.Write(pct3d & ",")
        W.Write(TotFlow3 & ",")
        W.Write(pct4a & ",")
        W.Write(pct4b & ",")
        W.Write(pct4c & ",")
        W.Write(pct4d & ",")
        W.Write(TotFlow4 & ",")
        W.Write(maxflow1 & ",")
        W.Write(maxflow2 & ",")
        W.Write(maxflow3 & ",")
        W.Write(maxflow4 & ",")
        W.Write(FillGas)
        W.Close()

        Dim result As String                                    ' get filename and put on status bar at bottom of window
        result = System.IO.Path.GetFileName(sFile.FileName)     ' get plain filename without full path
        lblConfigStrip.Text = "Configuration file:  " & result
    End Sub



    '=========================================================================================================================================
    '                                    MENU LOAD SEQUENCER (EXPERIMENT) FILE is selected
    '=========================================================================================================================================
    Private Sub LoadTimedSequenceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadTimedSequenceToolStripMenuItem.Click
        Dim fnConfig As String
        On Error Resume Next

        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.Filter = "Exp Files (*.exp)|*.exp"
        openFileDialog1.Title = "Load Sequencer File"

        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            fnConfig = openFileDialog1.FileName             ' selected file
            Dim reader As New IO.StreamReader(fnConfig, IO.FileMode.Open)

            'loop until end of file
            While reader.Peek <> -1                         ' checks for end-of-file
                Dim sFile As String = reader.ReadLine       ' reads all text as a single line

                Dim str() As String = sFile.Split(",")      ' splits text file using "," delimiter

                'get data from csv file into individual strings
                stepcombos(0).Text = str(0)
                stepboxes(0).Text = str(1)
                stepcombos(1).Text = str(2)
                stepboxes(1).Text = str(3)
                stepcombos(2).Text = str(4)
                stepboxes(2).Text = str(5)
                stepcombos(3).Text = str(6)
                stepboxes(3).Text = str(7)
                stepcombos(4).Text = str(8)
                stepboxes(4).Text = str(9)
                stepcombos(5).Text = str(10)
                stepboxes(5).Text = str(11)
                stepcombos(6).Text = str(12)
                stepboxes(6).Text = str(13)
                stepcombos(7).Text = str(14)
                stepboxes(7).Text = str(15)
                stepcombos(8).Text = str(16)
                stepboxes(8).Text = str(17)
                stepcombos(9).Text = str(18)
                stepboxes(9).Text = str(19)
                stepcombos(10).Text = str(20)
                stepboxes(10).Text = str(21)
                stepcombos(11).Text = str(22)
                stepboxes(11).Text = str(23)
                stepcombos(12).Text = str(24)
                stepboxes(12).Text = str(25)
                stepcombos(13).Text = str(26)
                stepboxes(13).Text = str(27)
                stepcombos(14).Text = str(28)
                stepboxes(14).Text = str(29)
            End While
            reader.Close()
            Dim result As String                            ' get filename and put on status strip at bottom of window
            result = System.IO.Path.GetFileName(fnConfig)   ' get plain filename without full path
            lblSequencerStrip.Text = "Sequencer file:  " & result
        End If
    End Sub



    '=========================================================================================================================================
    '                                    MENU SAVE SEQUENCER (EXPERIMENT) FILE is selected
    '=========================================================================================================================================
    Private Sub SaveTimedSequenceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveTimedSequenceToolStripMenuItem.Click
        On Error Resume Next
        ' set up SaveFileDialogBox and Streamwriter
        sFile.FileName = "Save as..."
        sFile.Filter = "(*exp) | *.exp"
        sFile.CreatePrompt = True
        'sFile.CheckFileExists = True   ' this prevents creation of new file! Don't use it!
        sFile.OverwritePrompt = True
        sFile.ShowDialog()
        Dim W As New IO.StreamWriter(sFile.FileName)

        W.Write(stepcombos(0).Text & ",")
        W.Write(stepboxes(0).Text & ",")
        W.Write(stepcombos(1).Text & ",")
        W.Write(stepboxes(1).Text & ",")
        W.Write(stepcombos(2).Text & ",")
        W.Write(stepboxes(2).Text & ",")
        W.Write(stepcombos(3).Text & ",")
        W.Write(stepboxes(3).Text & ",")
        W.Write(stepcombos(4).Text & ",")
        W.Write(stepboxes(4).Text & ",")
        W.Write(stepcombos(5).Text & ",")
        W.Write(stepboxes(5).Text & ",")
        W.Write(stepcombos(6).Text & ",")
        W.Write(stepboxes(6).Text & ",")
        W.Write(stepcombos(7).Text & ",")
        W.Write(stepboxes(7).Text & ",")
        W.Write(stepcombos(8).Text & ",")
        W.Write(stepboxes(8).Text & ",")
        W.Write(stepcombos(9).Text & ",")
        W.Write(stepboxes(9).Text & ",")
        W.Write(stepcombos(10).Text & ",")
        W.Write(stepboxes(10).Text & ",")
        W.Write(stepcombos(11).Text & ",")
        W.Write(stepboxes(11).Text & ",")
        W.Write(stepcombos(12).Text & ",")
        W.Write(stepboxes(12).Text & ",")
        W.Write(stepcombos(13).Text & ",")
        W.Write(stepboxes(13).Text & ",")
        W.Write(stepcombos(14).Text & ",")
        W.Write(stepboxes(14).Text)
        W.Close()

        Dim result As String
        result = System.IO.Path.GetFileName(sFile.FileName)   ' get plain filename without full path
        lblSequencerStrip.Text = "Sequencer file:  " & result
    End Sub




    '=========================================================================================================================================
    '                                               SEQUENCER ROUTINES
    '=========================================================================================================================================
    Private Sub btnHaltSequence_Click(sender As Object, e As EventArgs) Handles btnHaltSequence.Click
        duration = 0
        flgStop = True
        stepTimer.Stop()
        stepTimer.Enabled = False
        progTimer.Enabled = False
        ProgBar1.Value = 0

        For x = 0 To 14
            leds(x).BackColor = Color.RosyBrown
        Next
        seqRunning = False
    End Sub


    '========================================================================================================================================
    '                                            HANDLE UPDNPCT VALUE CHANGES
    '========================================================================================================================================
    Private Sub nUpDnPctA1_ValueChanged(sender As Object, e As EventArgs) Handles nUpDnPctA1.ValueChanged
        FormatUpDns()
    End Sub

    Private Sub nUpDnPctB1_ValueChanged(sender As Object, e As EventArgs) Handles nUpDnPctB1.ValueChanged
        FormatUpDns()
    End Sub

    Private Sub nUpDnPctC1_ValueChanged(sender As Object, e As EventArgs) Handles nUpDnPctC1.ValueChanged
        FormatUpDns()
    End Sub

    Private Sub nUpDnPctD1_ValueChanged(sender As Object, e As EventArgs) Handles nUpDnPctD1.ValueChanged
        FormatUpDns()
    End Sub
    Private Sub nUpDnPctA2_ValueChanged(sender As Object, e As EventArgs) Handles nUpDnPctA2.ValueChanged
        FormatUpDns()
    End Sub

    Private Sub nUpDnPctB2_ValueChanged(sender As Object, e As EventArgs) Handles nUpDnPctB2.ValueChanged
        FormatUpDns()
    End Sub

    Private Sub nUpDnPctC2_ValueChanged(sender As Object, e As EventArgs) Handles nUpDnPctC2.ValueChanged
        FormatUpDns()
    End Sub
    Private Sub nUpDnPctD2_ValueChanged(sender As Object, e As EventArgs) Handles nUpDnPctD2.ValueChanged
        FormatUpDns()
    End Sub

    Private Sub nUpDnPctA3_ValueChanged(sender As Object, e As EventArgs) Handles nUpDnPctA3.ValueChanged
        FormatUpDns()
    End Sub

    Private Sub nUpDnPctB3_ValueChanged(sender As Object, e As EventArgs) Handles nUpDnPctB3.ValueChanged
        FormatUpDns()
    End Sub

    Private Sub nUpDnPctC3_ValueChanged(sender As Object, e As EventArgs) Handles nUpDnPctC3.ValueChanged
        FormatUpDns()
    End Sub
    Private Sub nUpDnPctD3_ValueChanged(sender As Object, e As EventArgs) Handles nUpDnPctD3.ValueChanged
        FormatUpDns()
    End Sub

    Private Sub nUpDnPctA4_ValueChanged(sender As Object, e As EventArgs) Handles nUpDnPctA4.ValueChanged
        FormatUpDns()
    End Sub

    Private Sub nUpDnPctB4_ValueChanged(sender As Object, e As EventArgs) Handles nUpDnPctB4.ValueChanged
        FormatUpDns()
    End Sub

    Private Sub nUpDnPctC4_ValueChanged(sender As Object, e As EventArgs) Handles nUpDnPctC4.ValueChanged
        FormatUpDns()
    End Sub
    Private Sub nUpDnPctD4_ValueChanged(sender As Object, e As EventArgs) Handles nUpDnPctD4.ValueChanged
        FormatUpDns()
    End Sub
    '------------------------------------------------------------------------------------------------------------------------------------------
    Private Sub btnFillGas0_CheckedChanged(sender As Object, e As EventArgs) Handles btnFillGas0.CheckedChanged
        FormatUpDns()
    End Sub

    Private Sub btnFillGas1_CheckedChanged(sender As Object, e As EventArgs) Handles btnFillGas1.CheckedChanged
        FormatUpDns()
    End Sub

    Private Sub btnFillGas2_CheckedChanged(sender As Object, e As EventArgs) Handles btnFillGas2.CheckedChanged
        FormatUpDns()
    End Sub
    Private Sub btnFillGas3_CheckedChanged(sender As Object, e As EventArgs) Handles btnFillGas3.CheckedChanged
        FormatUpDns()
    End Sub

    '-----------------------------------------------------------------------------------------------------------------------------------------
    '                                       HANDLES TOTAL FLOW UPDNS VALUE CHANGE
    '-----------------------------------------------------------------------------------------------------------------------------------------
    Private Sub nUpDnTFlow1_ValueChanged(sender As Object, e As EventArgs) Handles nUpDnTFlow1.ValueChanged
        FormatUpDns()
    End Sub
    Private Sub nUpDnTFlow2_ValueChanged(sender As Object, e As EventArgs) Handles nUpDnTFlow2.ValueChanged
        FormatUpDns()
    End Sub

    Private Sub nUpDnTFlow3_ValueChanged(sender As Object, e As EventArgs) Handles nUpDnTFlow3.ValueChanged
        FormatUpDns()
    End Sub

    Private Sub nUpDnTFlow4_ValueChanged(sender As Object, e As EventArgs) Handles nUpDnTFlow4.ValueChanged
        FormatUpDns()
    End Sub




    '==========================================================================================================================================
    '                                            FORMAT UPDN TEXTS
    '==========================================================================================================================================
    ' Gets called on following events:  formload
    '                                   reading in new configuration file
    '                                   btnFillGas0, 1, or 2 is clicked by user
    '                                   nUpDnPctA1.ValueChanged... B1, C1,... C4
    Private Sub FormatUpDns()
        '-----------------------------------------------------------------------------------------------------------------
        '                                       Autofill gas values
        '-----------------------------------------------------------------------------------------------------------------
        ' If fill button is selected, use that gas as fill, otherwise user enters value directly
        ' Selected: textbox background color = blue, updn control is invisible
        ' Not selected: textbox background color = white, updn control is disabled

        ' Gas 1
        If btnFillGas0.Checked = True Then      ' gas 1 selected as fill gas  (NOT B, C, D)  **
            ' Mix A1
            nUpDnPctA1.Enabled = False           ' make updn control invisible
            nUpDnPctA1.BackColor = Color.Aqua     ' change "fill" text box to blue
            If (nUpDnPctB1.Value + nUpDnPctC1.Value + nUpDnPctD1.Value) <= 100 Then    ' make sure total doesn't exceed 100%
                nUpDnPctA1.Value = 100 - (nUpDnPctB1.Value + nUpDnPctC1.Value + nUpDnPctD1.Value) ' compute fill gas value
            Else
                nUpDnPctA1.Value = 0                                            ' other values too big, so make fill gas 0%
            End If

            ' Mix A2                                ' (NOT B, C, D)  **
            nUpDnPctA2.Enabled = False           ' make updn control invisible
            nUpDnPctA2.BackColor = Color.Aqua     ' change "fill" text box to blue
            If (nUpDnPctB2.Value + nUpDnPctC2.Value + nUpDnPctD2.Value) <= 100 Then    ' make sure total doesn't exceed 100%
                nUpDnPctA2.Value = Format(100 - (nUpDnPctB2.Value + nUpDnPctC2.Value + nUpDnPctD2.Value), "##0.0") ' compute fill gas value
            Else
                nUpDnPctA2.Value = 0                                            ' other values too big, so make fill gas 0%
            End If

            ' Mix A3                                '(NOT B, C, D)   **
            nUpDnPctA3.Enabled = False           ' make updn control invisible
            nUpDnPctA3.BackColor = Color.Aqua     ' change "fill" text box to blue
            If (nUpDnPctB3.Value + nUpDnPctC3.Value + nUpDnPctD3.Value) <= 100 Then    ' make sure total doesn't exceed 100%
                nUpDnPctA3.Value = Format(100 - (nUpDnPctB3.Value + nUpDnPctC3.Value + nUpDnPctD3.Value), "##0.0") ' compute fill gas value
            Else
                nUpDnPctA3.Value = 0                                            ' other values too big, so make fill gas 0%
            End If

            ' Mix A4                                (NOT B, C, D) **
            nUpDnPctA4.Enabled = False           ' make updn control invisible
            nUpDnPctA4.BackColor = Color.Aqua       ' change "fill" text box to blue
            If (nUpDnPctB4.Value + nUpDnPctC4.Value + nUpDnPctD4.Value) <= 100 Then    ' make sure total doesn't exceed 100%
                nUpDnPctA4.Value = Format(100 - (nUpDnPctB4.Value + nUpDnPctC4.Value + nUpDnPctD4.Value), "##0.0") ' compute fill gas value
            Else
                nUpDnPctA4.Value = 0                 ' other values too big, so make fill gas 0%
            End If
        Else
            ' Mix A1
            nUpDnPctA1.Enabled = True
            nUpDnPctA1.BackColor = Color.White       ' make "fill" text box white

            ' Mix A2
            nUpDnPctA2.Enabled = True            ' make control visible
            nUpDnPctA2.BackColor = Color.White       ' make "fill" text box white

            ' Mix A3
            nUpDnPctA3.Enabled = True            ' make control visible
            nUpDnPctA3.BackColor = Color.White       ' make "fill" text box white

            ' Mix A4
            nUpDnPctA4.Enabled = True            ' make control visible
            nUpDnPctA4.BackColor = Color.White       ' make "fill" text box white
        End If

        '-----------------------------------------------------------------------------------------------------------------
        ' Gas 2                                     (NOT A, C, D)
        If btnFillGas1.Checked = True Then      ' gas 2 selected as fill gas   
            ' Mix B1                                **
            nUpDnPctB1.Enabled = False           ' make updn control invisible
            nUpDnPctB1.BackColor = Color.Aqua       ' change "fill" text box to blue
            If (nUpDnPctA1.Value + nUpDnPctC1.Value + nUpDnPctD1.Value) <= 100 Then    ' make sure total doesn't exceed 100%
                nUpDnPctB1.Value = Format(100 - (nUpDnPctA1.Value + nUpDnPctC1.Value + nUpDnPctD1.Value), "##0.0") ' compute fill gas value
            Else
                nUpDnPctB1.Value = 0                    ' other values too big, so make fill gas 0%
            End If

            ' Mix B2                                (NOT A, C, D)       **
            nUpDnPctB2.Enabled = False           ' make updn control invisible
            nUpDnPctB2.BackColor = Color.Aqua       ' change "fill" text box to blue
            If (nUpDnPctA2.Value + nUpDnPctC2.Value + nUpDnPctD2.Value) <= 100 Then    ' make sure total doesn't exceed 100%
                nUpDnPctB2.Value = Format(100 - (nUpDnPctA2.Value + nUpDnPctC2.Value + nUpDnPctD2.Value), "##0.0") ' compute fill gas value
            Else
                nUpDnPctB2.Value = 0                    ' other values too big, so make fill gas 0%
            End If

            ' Mix B3                                (NOT A, C, D)       **
            nUpDnPctB3.Enabled = False           ' make updn control invisible
            nUpDnPctB3.BackColor = Color.Aqua       ' change "fill" text box to blue
            If (nUpDnPctA3.Value + nUpDnPctC3.Value + nUpDnPctD3.Value) <= 100 Then    ' make sure total doesn't exceed 100%
                nUpDnPctB3.Value = Format(100 - (nUpDnPctA3.Value + nUpDnPctC3.Value + nUpDnPctD3.Value), "##0.0") ' compute fill gas value
            Else
                nUpDnPctB3.Value = 0                     ' other values too big, so make fill gas 0%
            End If

            ' Mix B4                            (NOT A, C, D)       **
            nUpDnPctB4.Enabled = False           ' make updn control invisible
            nUpDnPctB4.BackColor = Color.Aqua       ' change "fill" text box to blue
            If (nUpDnPctA4.Value + nUpDnPctC4.Value + nUpDnPctD4.Value) <= 100 Then    ' make sure total doesn't exceed 100%
                nUpDnPctB4.Value = Format(100 - (nUpDnPctA4.Value + nUpDnPctC4.Value + nUpDnPctD4.Value), "##0.0") ' compute fill gas value
            Else
                nUpDnPctB4.Value = 0                    ' other values too big, so make fill gas 0%
            End If
        Else
            ' Mix B1
            nUpDnPctB1.Enabled = True
            nUpDnPctB1.BackColor = Color.White       ' make "fill" text box white

            ' Mix B2
            nUpDnPctB2.Enabled = True            ' make control visible
            nUpDnPctB2.BackColor = Color.White       ' make "fill" text box white

            ' Mix B3
            nUpDnPctB3.Enabled = True            ' make control visible
            nUpDnPctB3.BackColor = Color.White       ' make "fill" text box white

            ' Mix B4
            nUpDnPctB4.Enabled = True            ' make control visible
            nUpDnPctB4.BackColor = Color.White       ' make "fill" text box white
        End If

        '-----------------------------------------------------------------------------------------------------------------
        ' Gas 3
        If btnFillGas2.Checked = True Then      ' gas 3 selected as fill gas   (NOT A, B, D)
            ' Mix C1                                **
            nUpDnPctC1.Enabled = False           ' make updn control invisible
            nUpDnPctC1.BackColor = Color.Aqua       ' change "fill" text box to blue
            If (nUpDnPctA1.Value + nUpDnPctB1.Value + nUpDnPctD1.Value) <= 100 Then    ' make sure total doesn't exceed 100%
                nUpDnPctC1.Value = 100 - (nUpDnPctA1.Value + nUpDnPctB1.Value + nUpDnPctD1.Value) ' compute fill gas value
            Else
                nUpDnPctC1.Value = 0                    ' other values too big, so make fill gas 0%
            End If

            ' Mix C2                            (NOT A, B, D)   **
            nUpDnPctC2.Enabled = False           ' make updn control invisible
            nUpDnPctC2.BackColor = Color.Aqua       ' change "fill" text box to blue
            If (nUpDnPctA2.Value + nUpDnPctB2.Value + nUpDnPctD2.Value) <= 100 Then    ' make sure total doesn't exceed 100%
                nUpDnPctC2.Value = Format(100 - (nUpDnPctA2.Value + nUpDnPctB2.Value + nUpDnPctD2.Value), "##0.0") ' compute fill gas value
            Else
                nUpDnPctC2.Value = 0                    ' other values too big, so make fill gas 0%
            End If

            ' Mix C3                            (NOT A, B, D)   **
            nUpDnPctC3.Enabled = False           ' make updn control invisible
            nUpDnPctC3.BackColor = Color.Aqua       ' change "fill" text box to blue
            If (nUpDnPctA3.Value + nUpDnPctB3.Value + nUpDnPctD3.Value) <= 100 Then    ' make sure total doesn't exceed 100%
                nUpDnPctC3.Value = Format(100 - (nUpDnPctA3.Value + nUpDnPctB3.Value + nUpDnPctD3.Value), "##0.0") ' compute fill gas value
            Else
                nUpDnPctC3.Value = 0                    ' other values too big, so make fill gas 0%
            End If

            ' Mix C4                            (NOT A, B, D)   **
            nUpDnPctC4.Enabled = False           ' make updn control invisible
            nUpDnPctC4.BackColor = Color.Aqua       ' change "fill" text box to blue
            If (nUpDnPctA4.Value + nUpDnPctB4.Value + nUpDnPctD4.Value) <= 100 Then    ' make sure total doesn't exceed 100%
                nUpDnPctC4.Value = Format(100 - (nUpDnPctA4.Value + nUpDnPctB4.Value + nUpDnPctD4.Value), "##0.0") ' compute fill gas value
            Else
                nUpDnPctC4.Value = 0                    ' other values too big, so make fill gas 0%
            End If
        Else
            ' Mix C1
            nUpDnPctC1.Enabled = True            ' make control visible
            nUpDnPctC1.BackColor = Color.White       ' make "fill" text box white

            ' Mix C2
            nUpDnPctC2.Enabled = True            ' make control visible
            nUpDnPctC2.BackColor = Color.White       ' make "fill" text box white

            ' Mix C3
            nUpDnPctC3.Enabled = True            ' make control visible
            nUpDnPctC3.BackColor = Color.White       ' make "fill" text box white

            ' Mix C4
            nUpDnPctC4.Enabled = True            ' make control visible
            nUpDnPctC4.BackColor = Color.White       ' make "fill" text box white
        End If

        '-----------------------------------------------------------------------------------------------------------------
        ' Gas 4
        If btnFillGas3.Checked = True Then      ' gas 4 selected as fill gas   (NOT A, B, C)
            ' Mix D1                            **
            nUpDnPctD1.Enabled = False           ' make updn control invisible
            nUpDnPctD1.BackColor = Color.Aqua       ' change "fill" text box to blue
            If (nUpDnPctA1.Value + nUpDnPctB1.Value + nUpDnPctC1.Value) <= 100 Then    ' make sure total doesn't exceed 100%
                nUpDnPctD1.Value = 100 - (nUpDnPctA1.Value + nUpDnPctB1.Value + nUpDnPctC1.Value) ' compute fill gas value
            Else
                nUpDnPctD1.Value = 0                    ' other values too big, so make fill gas 0%
            End If

            ' Mix D2                                (NOT A, B, C)   **
            nUpDnPctD2.Enabled = False           ' make updn control invisible
            nUpDnPctD2.BackColor = Color.Aqua       ' change "fill" text box to blue
            If (nUpDnPctA2.Value + nUpDnPctB2.Value + nUpDnPctC2.Value) <= 100 Then    ' make sure total doesn't exceed 100%
                nUpDnPctD2.Value = Format(100 - (nUpDnPctA2.Value + nUpDnPctB2.Value + nUpDnPctC2.Value), "##0.0") ' compute fill gas value
            Else
                nUpDnPctD2.Value = 0                    ' other values too big, so make fill gas 0%
            End If

            ' Mix D3                                (NOT A, B, C)   **
            nUpDnPctD3.Enabled = False           ' make updn control invisible
            nUpDnPctD3.BackColor = Color.Aqua       ' change "fill" text box to blue
            If (nUpDnPctA3.Value + nUpDnPctB3.Value + nUpDnPctC3.Value) <= 100 Then    ' make sure total doesn't exceed 100%
                nUpDnPctD3.Value = Format(100 - (nUpDnPctA3.Value + nUpDnPctB3.Value + nUpDnPctC3.Value), "##0.0") ' compute fill gas value
            Else
                nUpDnPctD3.Value = 0                    ' other values too big, so make fill gas 0%
            End If

            ' Mix D4                                (NOT A, B, C)   **
            nUpDnPctD4.Enabled = False           ' make updn control invisible
            nUpDnPctD4.BackColor = Color.Aqua       ' change "fill" text box to blue
            If (nUpDnPctA4.Value + nUpDnPctB4.Value + nUpDnPctC4.Value) <= 100 Then    ' make sure total doesn't exceed 100%
                nUpDnPctD4.Value = Format(100 - (nUpDnPctA4.Value + nUpDnPctB4.Value + nUpDnPctC4.Value), "##0.0") ' compute fill gas value
            Else
                nUpDnPctD4.Value = 0                    ' other values too big, so make fill gas 0%
            End If
        Else
            ' Mix D1
            nUpDnPctD1.Enabled = True            ' make control visible
            nUpDnPctD1.BackColor = Color.White       ' make "fill" text box white

            ' Mix D2
            nUpDnPctD2.Enabled = True            ' make control visible
            nUpDnPctD2.BackColor = Color.White       ' make "fill" text box white

            ' Mix D3
            nUpDnPctD3.Enabled = True            ' make control visible
            nUpDnPctD3.BackColor = Color.White       ' make "fill" text box white

            ' Mix D4
            nUpDnPctD4.Enabled = True            ' make control visible
            nUpDnPctD4.BackColor = Color.White       ' make "fill" text box white
        End If


        '=========================================================================================================================================
        '                            UPDATE TOTAL PERCENT BOXES AND FLAG ERRORS
        '=========================================================================================================================================
        'Update total percent boxes by adding up individual gas percentages; should equal 100%!
        totalpct1 = nUpDnPctA1.Value + nUpDnPctB1.Value + nUpDnPctC1.Value + nUpDnPctD1.Value
        tbxTotPct1.Text = totalpct1 & "%"
        If (totalpct1 > 100) Then
            tbxTotPct1.ForeColor = Color.Red
            flgPctError1 = 1
        Else
            tbxTotPct1.ForeColor = Color.Black
            flgPctError1 = 0
        End If

        totalpct2 = nUpDnPctA2.Value + nUpDnPctB2.Value + nUpDnPctC2.Value + nUpDnPctD2.Value
        tbxTotPct2.Text = totalpct2 & "%"
        If (totalpct2 > 100) Then
            tbxTotPct2.ForeColor = Color.Red
            flgPctError2 = 1
        Else
            tbxTotPct2.ForeColor = Color.Black
            flgPctError2 = 0
        End If

        totalpct3 = nUpDnPctA3.Value + nUpDnPctB3.Value + nUpDnPctC3.Value + nUpDnPctD3.Value
        tbxTotPct3.Text = totalpct3 & "%"
        If (totalpct3 > 100) Then
            tbxTotPct3.ForeColor = Color.Red
            flgPctError3 = 1
        Else
            tbxTotPct3.ForeColor = Color.Black
            flgPctError3 = 0
        End If

        totalpct4 = nUpDnPctA4.Value + nUpDnPctB4.Value + nUpDnPctC4.Value + nUpDnPctD4.Value
        tbxTotPct4.Text = totalpct4 & "%"
        If (totalpct4 > 100) Then
            tbxTotPct4.ForeColor = Color.Red
            flgPctError4 = 1
        Else
            tbxTotPct4.ForeColor = Color.Black
            flgPctError4 = 0
        End If

        '=========================================================================================================================================
        '                            CALCULATE FLOWS AND FORMAT INDIVIDUAL FLOW TEXT BOXES
        '=========================================================================================================================================
        ' update individual flow displays for all 4 mixes
        ' color text red and set error flags if outside range for that channel's flow controller
        ' MIX 1
        tbxFlow1Mix1.Text = Int((nUpDnPctA1.Value * nUpDnTFlow1.Value) / 100) & " ml"
        If Val(tbxFlow1Mix1.Text) > 0 And (Val(tbxFlow1Mix1.Text) < (maxflow1 / 100) Or Val(tbxFlow1Mix1.Text) > maxflow1) Then ' display 0ml is ok
            tbxFlow1Mix1.ForeColor = Color.Red  ' red bold text to indicate error
            flgFlowError1 = 1
        Else
            tbxFlow1Mix1.ForeColor = Color.Black   ' normal black text
            flgFlowError1 = 0
        End If

        tbxFlow2Mix1.Text = Int((nUpDnPctB1.Value * nUpDnTFlow1.Value) / 100) & " ml"
        If Val(tbxFlow2Mix1.Text) > 0 And (Val(tbxFlow2Mix1.Text) < (maxflow2 / 100) Or Val(tbxFlow2Mix1.Text) > maxflow2) Then
            tbxFlow2Mix1.ForeColor = Color.Red
            flgFlowError2 = 1
        Else
            tbxFlow2Mix1.ForeColor = Color.Black
            flgFlowError2 = 0
        End If

        tbxFlow3Mix1.Text = Int((nUpDnPctC1.Value * nUpDnTFlow1.Value) / 100) & " ml"
        If Val(tbxFlow3Mix1.Text) > 0 And (Val(tbxFlow3Mix1.Text) < (maxflow3 / 100) Or Val(tbxFlow3Mix1.Text) > maxflow3) Then
            tbxFlow3Mix1.ForeColor = Color.Red
            flgFlowError3 = 1
        Else
            tbxFlow3Mix1.ForeColor = Color.Black
            flgFlowError3 = 0
        End If

        tbxFlow4Mix1.Text = Int((nUpDnPctD1.Value * nUpDnTFlow1.Value) / 100) & " ml"
        If Val(tbxFlow4Mix1.Text) > 0 And (Val(tbxFlow4Mix1.Text) < (maxflow4 / 100) Or Val(tbxFlow4Mix1.Text) > maxflow4) Then
            tbxFlow4Mix1.ForeColor = Color.Red
            flgFlowError4 = 1
        Else
            tbxFlow4Mix1.ForeColor = Color.Black
            flgFlowError4 = 0
        End If
        '-----------------------------------------------------------------------------------------------------------------
        ' MIX 2
        tbxFlow1Mix2.Text = Int((nUpDnPctA2.Value * nUpDnTFlow2.Value) / 100) & " ml"
        If Val(tbxFlow1Mix2.Text) > 0 And (Val(tbxFlow1Mix2.Text) < (maxflow1 / 100) Or Val(tbxFlow1Mix2.Text) > maxflow1) Then
            tbxFlow1Mix2.ForeColor = Color.Red
            flgFlowError5 = 1
        Else
            tbxFlow1Mix2.ForeColor = Color.Black
            flgFlowError5 = 0
        End If

        tbxFlow2Mix2.Text = Int((nUpDnPctB2.Value * nUpDnTFlow2.Value) / 100) & " ml"
        If Val(tbxFlow2Mix2.Text) > 0 And (Val(tbxFlow2Mix2.Text) < (maxflow2 / 100) Or Val(tbxFlow2Mix2.Text) > maxflow2) Then
            tbxFlow2Mix2.ForeColor = Color.Red
            flgFlowError6 = 1
        Else
            tbxFlow2Mix2.ForeColor = Color.Black
            flgFlowError6 = 0
        End If

        tbxFlow3Mix2.Text = Int((nUpDnPctC2.Value * nUpDnTFlow2.Value) / 100) & " ml"
        If Val(tbxFlow3Mix2.Text) > 0 And (Val(tbxFlow3Mix2.Text) < (maxflow3 / 100) Or Val(tbxFlow3Mix2.Text) > maxflow3) Then
            tbxFlow3Mix2.ForeColor = Color.Red
            flgFlowError7 = 1
        Else
            tbxFlow3Mix2.ForeColor = Color.Black
            flgFlowError7 = 0
        End If

        tbxFlow4Mix2.Text = Int((nUpDnPctD2.Value * nUpDnTFlow2.Value) / 100) & " ml"
        If Val(tbxFlow4Mix2.Text) > 0 And (Val(tbxFlow4Mix2.Text) < (maxflow4 / 100) Or Val(tbxFlow4Mix2.Text) > maxflow4) Then
            tbxFlow4Mix2.ForeColor = Color.Red
            flgFlowError8 = 1
        Else
            tbxFlow4Mix2.ForeColor = Color.Black
            flgFlowError8 = 0
        End If
        '-----------------------------------------------------------------------------------------------------------------
        ' MIX 3
        tbxFlow1Mix3.Text = Int((nUpDnPctA3.Value * nUpDnTFlow3.Value) / 100) & " ml"
        If Val(tbxFlow1Mix3.Text) > 0 And (Val(tbxFlow1Mix3.Text) < (maxflow1 / 100) Or Val(tbxFlow1Mix3.Text) > maxflow1) Then
            tbxFlow1Mix3.ForeColor = Color.Red
            flgFlowError9 = 1
        Else
            tbxFlow1Mix3.ForeColor = Color.Black
            flgFlowError9 = 0
        End If

        tbxFlow2Mix3.Text = Int((nUpDnPctB3.Value * nUpDnTFlow3.Value) / 100) & " ml"
        If Val(tbxFlow2Mix3.Text) > 0 And (Val(tbxFlow2Mix3.Text) < (maxflow2 / 100) Or Val(tbxFlow2Mix3.Text) > maxflow2) Then
            tbxFlow2Mix3.ForeColor = Color.Red
            flgFlowError10 = 1
        Else
            tbxFlow2Mix3.ForeColor = Color.Black
            flgFlowError10 = 0
        End If

        tbxFlow3Mix3.Text = Int((nUpDnPctC3.Value * nUpDnTFlow3.Value) / 100) & " ml"
        If Val(tbxFlow3Mix3.Text) > 0 And (Val(tbxFlow3Mix3.Text) < (maxflow3 / 100) Or Val(tbxFlow3Mix3.Text) > maxflow3) Then
            tbxFlow3Mix3.ForeColor = Color.Red
            flgFlowError11 = 1
        Else
            tbxFlow3Mix3.ForeColor = Color.Black
            flgFlowError11 = 0
        End If

        tbxFlow4Mix3.Text = Int((nUpDnPctD3.Value * nUpDnTFlow4.Value) / 100) & " ml"
        If Val(tbxFlow4Mix3.Text) > 0 And (Val(tbxFlow4Mix3.Text) < (maxflow4 / 100) Or Val(tbxFlow4Mix3.Text) > maxflow3) Then
            tbxFlow4Mix3.ForeColor = Color.Red
            flgFlowError12 = 1
        Else
            tbxFlow4Mix3.ForeColor = Color.Black
            flgFlowError12 = 0
        End If
        '-----------------------------------------------------------------------------------------------------------------
        ' MIX 4
        tbxFlow1Mix4.Text = Int((nUpDnPctA4.Value * nUpDnTFlow4.Value) / 100) & " ml"
        If Val(tbxFlow1Mix4.Text) > 0 And (Val(tbxFlow1Mix4.Text) < (maxflow1 / 100) Or Val(tbxFlow1Mix4.Text) > maxflow1) Then
            tbxFlow1Mix4.ForeColor = Color.Red
            flgFlowError13 = 1
        Else
            tbxFlow1Mix4.ForeColor = Color.Black
            flgFlowError13 = 0
        End If

        tbxFlow2Mix4.Text = Int((nUpDnPctB4.Value * nUpDnTFlow4.Value) / 100) & " ml"
        If Val(tbxFlow2Mix4.Text) > 0 And (Val(tbxFlow2Mix4.Text) < (maxflow2 / 100) Or Val(tbxFlow2Mix4.Text) > maxflow2) Then
            tbxFlow2Mix4.ForeColor = Color.Red
            flgFlowError14 = 1
        Else
            tbxFlow2Mix4.ForeColor = Color.Black
            flgFlowError14 = 0
        End If

        tbxFlow3Mix4.Text = Int((nUpDnPctC4.Value * nUpDnTFlow4.Value) / 100) & " ml"
        If Val(tbxFlow3Mix4.Text) > 0 And (Val(tbxFlow3Mix4.Text) < (maxflow3 / 100) Or Val(tbxFlow3Mix4.Text) > maxflow3) Then
            tbxFlow3Mix4.ForeColor = Color.Red
            flgFlowError15 = 1
        Else
            tbxFlow3Mix4.ForeColor = Color.Black
            flgFlowError15 = 0
        End If

        tbxFlow4Mix4.Text = Int((nUpDnPctD4.Value * nUpDnTFlow4.Value) / 100) & " ml"
        If Val(tbxFlow4Mix4.Text) > 0 And (Val(tbxFlow4Mix4.Text) < (maxflow4 / 100) Or Val(tbxFlow4Mix4.Text) > maxflow4) Then
            tbxFlow4Mix4.ForeColor = Color.Red
            flgFlowError16 = 1
        Else
            tbxFlow4Mix4.ForeColor = Color.Black
            flgFlowError16 = 0
        End If

        CheckForError()
    End Sub


    '=========================================================================================================================================
    '                                           UPDATE ERROR MESSAGES IN MESSAGE BOX
    '=========================================================================================================================================
    Private Sub CheckForError()
        If flgFlowError1 = 1 Or flgFlowError2 = 1 Or flgFlowError3 = 1 Or flgFlowError4 = 1 Or
            flgFlowError5 = 1 Or flgFlowError6 = 1 Or flgFlowError7 = 1 Or flgFlowError8 = 1 Or
            flgFlowError9 = 1 Or flgFlowError10 = 1 Or flgFlowError11 = 1 Or flgFlowError12 = 1 Or
            flgFlowError13 = 1 Or flgFlowError14 = 1 Or flgFlowError15 = 1 Or flgFlowError16 = 1 Then
            tbxErrMsg.Text = "Flow out of range!" & vbCrLf & "Adjust gas percent or TOTAL FLOW."
        ElseIf flgPctError1 = 1 Or flgPctError2 = 1 Or flgPctError3 = 1 Or flgPctError4 = 1 Then
            tbxErrMsg.Text = "ERROR! TOTAL PERCENT must be 100%" & vbCrLf & "Adjust non-fill gas percents"
        Else
            tbxErrMsg.Text = "STATUS: OK"
        End If
    End Sub


    '=========================================================================================================================================
    '                                               TIMER 1 ROUTINES, EXECUTED EVERY 100mS
    '=========================================================================================================================================
    Public Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        On Error GoTo jumparound    ' exit if error on value entry

        '-----------------------------------------------------------------------------------------------------------------
        '           Make mix indicator red on running mixture, gray on ones not running
        '-----------------------------------------------------------------------------------------------------------------
        If mix_running = 1 Then
            ledRunning1.BackColor = Color.Red
        Else
            ledRunning1.BackColor = Color.RosyBrown    ' gray
        End If

        If mix_running = 2 Then
            ledRunning2.BackColor = Color.Red
        Else
            ledRunning2.BackColor = Color.RosyBrown    ' gray
        End If

        If mix_running = 3 Then
            ledRunning3.BackColor = Color.Red
        Else
            ledRunning3.BackColor = Color.RosyBrown    ' gray
        End If

        If mix_running = 4 Then
            ledRunning4.BackColor = Color.Red
        Else
            ledRunning4.BackColor = Color.RosyBrown    ' gray
        End If

jumparound:     ' vector here on error during value entry
    End Sub
End Class

