Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports FSUIPC
Imports System.Runtime.InteropServices

Partial Public Class Form1
    Inherits Form
    ' =====================================
    ' DECLARE OFFSETS YOU WANT TO USE HERE
    ' =====================================
    Public Const WM_HOTKEY As Integer = &H312
    Public Const K_ALT As Integer = &H1
    Public Const K_CONTROL As Integer = &H2
    Public Const K_SHIFT As Integer = &H4

    <DllImport("User32.dll")> Public Shared Function RegisterHotKey(ByVal hwnd As IntPtr, ByVal id As Integer, ByVal fsModifiers As Integer, ByVal vk As Integer) As Integer
    End Function

    <DllImport("User32.dll")> Public Shared Function UnregisterHotKey(ByVal hwnd As IntPtr, ByVal id As Integer) As Integer
    End Function

    Public Sub New()
        InitializeComponent()
        configureForm()
        ' Start the connection timer to look for a flight sim
        Me.timerConnection.Start()
    End Sub

    ' This method is called every 1 second by the connection timer.
    Private Sub timerConnection_Tick(sender As Object, e As EventArgs) Handles timerConnection.Tick
        ' Try to open the connection
        Try
            FSUIPCConnection.Open()
            ' If there was no problem, stop this timer and start the main timer
            Me.timerConnection.[Stop]()
            Me.timerMain.Start()
            ' Update the connection status
            configureForm()
            ' No connection found. Don't need to do anything, just keep trying
        Catch
        End Try
    End Sub

    ' This method runs 20 times per second (every 50ms). This is set on the timerMain properties.
    Private Sub timerMain_Tick(sender As Object, e As EventArgs) Handles timerMain.Tick
        ' Call process() to read/write data to/from FSUIPC
        ' We do this in a Try/Catch block incase something goes wrong
        Try
            FSUIPCConnection.Process()

            ' Update the information on the form
            ' (See the Examples Application for more information on using Offsets).

        Catch ex As Exception
            ' An error occured. Tell the user and stop this timer.
            Me.timerMain.[Stop]()
            ' Update the connection status
            configureForm()
            ' start the connection timer
            Me.timerConnection.Start()
        End Try
    End Sub
    ' Configures the status label depending on if we're connected or not 
    Private Sub configureForm()
        If FSUIPCConnection.IsOpen Then
            Me.lblConnectionStatus.Text = "Connected to " & FSUIPCConnection.FlightSimVersionConnected.ToString()
            Me.lblConnectionStatus.ForeColor = Color.Green
        Else
            Me.lblConnectionStatus.Text = "Disconnected. Looking for Flight Simulator..."
            Me.lblConnectionStatus.ForeColor = Color.Red
        End If
    End Sub

    ' Form is closing so stop all the timers and close the connection
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.timerConnection.Stop()
        Me.timerMain.Stop()
        FSUIPCConnection.Close()
        UnregisterHotKey(MyBase.Handle, 100)
        UnregisterHotKey(MyBase.Handle, 101)
        UnregisterHotKey(MyBase.Handle, 102)
        UnregisterHotKey(MyBase.Handle, 103)
        UnregisterHotKey(MyBase.Handle, 104)
        UnregisterHotKey(MyBase.Handle, 105)
        UnregisterHotKey(MyBase.Handle, 106)
        'UnregisterHotKey(MyBase.Handle, 107) 'CDI Not Implemented Yet
        UnregisterHotKey(MyBase.Handle, 108)
        UnregisterHotKey(MyBase.Handle, 109)
        UnregisterHotKey(MyBase.Handle, 110)
        UnregisterHotKey(MyBase.Handle, 111)
        UnregisterHotKey(MyBase.Handle, 112)
        UnregisterHotKey(MyBase.Handle, 113)
        UnregisterHotKey(MyBase.Handle, 114)
        UnregisterHotKey(MyBase.Handle, 115)
        UnregisterHotKey(MyBase.Handle, 116)
        UnregisterHotKey(MyBase.Handle, 117)
        UnregisterHotKey(MyBase.Handle, 118)
        UnregisterHotKey(MyBase.Handle, 119)
        UnregisterHotKey(MyBase.Handle, 120)
        UnregisterHotKey(MyBase.Handle, 121)
        UnregisterHotKey(MyBase.Handle, 122)
        UnregisterHotKey(MyBase.Handle, 123)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RegisterHotKey(MyBase.Handle, 100, K_SHIFT Or K_CONTROL, Keys.A) 'COM
        RegisterHotKey(MyBase.Handle, 101, K_SHIFT Or K_CONTROL, Keys.R) 'VOR
        RegisterHotKey(MyBase.Handle, 102, K_SHIFT Or K_CONTROL, Keys.F5) 'LeftLargeKnob Left
        RegisterHotKey(MyBase.Handle, 103, K_SHIFT Or K_CONTROL, Keys.F1) 'LeftLargeKnob Right
        RegisterHotKey(MyBase.Handle, 104, K_SHIFT Or K_CONTROL, Keys.F6) 'LeftSmallKnob Left
        RegisterHotKey(MyBase.Handle, 105, K_SHIFT Or K_CONTROL, Keys.F2) 'LeftSmallKnob Right
        RegisterHotKey(MyBase.Handle, 106, K_SHIFT Or K_CONTROL, Keys.H) 'LeftSmallKnob Push
        'RegisterHotKey(MyBase.Handle, 107, K_SHIFT Or K_CONTROL, Keys.C) 'CDI Not Implemented Yet
        RegisterHotKey(MyBase.Handle, 108, K_SHIFT Or K_CONTROL, Keys.E) 'OBS
        RegisterHotKey(MyBase.Handle, 109, K_SHIFT Or K_CONTROL, Keys.F) 'MSG
        RegisterHotKey(MyBase.Handle, 110, K_SHIFT Or K_CONTROL, Keys.G) 'FPL
        RegisterHotKey(MyBase.Handle, 111, K_SHIFT Or K_CONTROL, Keys.I) 'VNAV
        RegisterHotKey(MyBase.Handle, 112, K_SHIFT Or K_CONTROL, Keys.J) 'PROC
        RegisterHotKey(MyBase.Handle, 113, K_SHIFT Or K_CONTROL, Keys.F7) 'RightLargeKnob Left
        RegisterHotKey(MyBase.Handle, 114, K_SHIFT Or K_CONTROL, Keys.F3) 'RightLargeKnob Right
        RegisterHotKey(MyBase.Handle, 115, K_SHIFT Or K_CONTROL, Keys.F8) 'RightSmallKnob Left
        RegisterHotKey(MyBase.Handle, 116, K_SHIFT Or K_CONTROL, Keys.F9) 'RightSmallKnob Right
        RegisterHotKey(MyBase.Handle, 117, K_SHIFT Or K_CONTROL, Keys.D) 'RightSmallKnob Push
        RegisterHotKey(MyBase.Handle, 118, K_SHIFT Or K_CONTROL, Keys.K) 'ENT
        RegisterHotKey(MyBase.Handle, 119, K_SHIFT Or K_CONTROL, Keys.L) 'CLR
        RegisterHotKey(MyBase.Handle, 120, K_SHIFT Or K_CONTROL, Keys.M) 'MENU
        RegisterHotKey(MyBase.Handle, 121, K_SHIFT Or K_CONTROL, Keys.N) 'DirectTo Push
        RegisterHotKey(MyBase.Handle, 122, K_SHIFT Or K_CONTROL, Keys.S) 'RNG Zoom
        RegisterHotKey(MyBase.Handle, 123, K_SHIFT Or K_CONTROL, Keys.Q) 'RNG Dezoom
    End Sub
    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        If m.Msg = WM_HOTKEY Then
            Dim k_id As IntPtr = m.WParam
            Select Case (k_id.ToString)
                Case "100"
                    Me.KeyLabel.Text = "Button Pressed: COM"
                    FSUIPCConnection.SendControlToFS(66372, 0)
                Case "101"
                    Me.KeyLabel.Text = "Button Pressed: VOR"
                    FSUIPCConnection.SendControlToFS(32780, 0)
                Case "102"
                    Me.KeyLabel.Text = "Button Pressed: LeftLargeKnob Left"
                    FSUIPCConnection.SendControlToFS(32786, 0)
                Case "103"
                    Me.KeyLabel.Text = "Button Pressed: LeftLargeKnob Right"
                    FSUIPCConnection.SendControlToFS(32785, 0)
                Case "104"
                    Me.KeyLabel.Text = "Button Pressed: LeftSmallKnob Left"
                    FSUIPCConnection.SendControlToFS(32791, 0)
                Case "105"
                    Me.KeyLabel.Text = "Button Pressed: LeftSmallKnob Right"
                    FSUIPCConnection.SendControlToFS(32790, 0)
                Case "106"
                    Me.KeyLabel.Text = "Button Pressed: LeftSmallKnob Push"
                    FSUIPCConnection.SendControlToFS(32792, 0)
                Case "108"
                    Me.KeyLabel.Text = "Button Pressed: OBS"
                    FSUIPCConnection.SendControlToFS(32776, 0)
                Case "109"
                    Me.KeyLabel.Text = "Button Pressed: MSG"
                    FSUIPCConnection.SendControlToFS(32775, 0)
                Case "110"
                    Me.KeyLabel.Text = "Button Pressed: FPL"
                    FSUIPCConnection.SendControlToFS(32771, 0)
                Case "111"
                    Me.KeyLabel.Text = "Button Pressed: VNAV"
                    FSUIPCConnection.SendControlToFS(32777, 0)
                Case "112"
                    Me.KeyLabel.Text = "Button Pressed: PROC"
                    FSUIPCConnection.SendControlToFS(32778, 0)
                Case "113"
                    Me.KeyLabel.Text = "Button Pressed: RightLargeKnob Left"
                    FSUIPCConnection.SendControlToFS(32784, 0)
                Case "114"
                    Me.KeyLabel.Text = "Button Pressed: RightLargeKnob Right"
                    FSUIPCConnection.SendControlToFS(32783, 0)
                Case "115"
                    Me.KeyLabel.Text = "Button Pressed: RightSmallKnob Left"
                    FSUIPCConnection.SendControlToFS(32788, 0)
                Case "116"
                    Me.KeyLabel.Text = "Button Pressed: RightSmallKnob Right"
                    FSUIPCConnection.SendControlToFS(32787, 0)
                Case "117"
                    Me.KeyLabel.Text = "Button Pressed: RightSmallKnob Push"
                    FSUIPCConnection.SendControlToFS(32789, 0)
                Case "118"
                    Me.KeyLabel.Text = "Button Pressed: ENT"
                    FSUIPCConnection.SendControlToFS(32769, 0)
                Case "119"
                    Me.KeyLabel.Text = "Button Pressed: CLR"
                    FSUIPCConnection.SendControlToFS(32774, 0)
                Case "120"
                    Me.KeyLabel.Text = "Button Pressed: MENU"
                    FSUIPCConnection.SendControlToFS(32770, 0)
                Case "121"
                    Me.KeyLabel.Text = "Button Pressed: DirectTo Push"
                    FSUIPCConnection.SendControlToFS(32772, 0)
                Case "122"
                    Me.KeyLabel.Text = "Button Pressed: RNG Zoom"
                    FSUIPCConnection.SendControlToFS(32782, 0)
                Case "123"
                    Me.KeyLabel.Text = "Button Pressed: RNG Dezoom"
                    FSUIPCConnection.SendControlToFS(32781, 0)
            End Select
        End If
        MyBase.WndProc(m)
    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles KeyLabel.Click

    End Sub
End Class
