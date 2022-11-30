Module modMain
    Declare Function SetLayeredWindowAttributes Lib "user32" (ByVal hWnd As Integer, ByVal crKey As Integer, ByVal bAlpha As Byte, ByVal dwFlags As Integer) As Integer
    Declare Function SetWindowLong Lib "user32.dll" Alias "SetWindowLongA" (ByVal hwnd As Integer, ByVal nIndex As Integer, ByVal dwNewLong As Integer) As Integer
    Declare Function GetWindowLong Lib "user32" Alias "GetWindowLongA" (ByVal hwnd As Integer, ByVal nIndex As Integer) As Integer
    Private Const GWL_EXSTYLE = -20

    Private Const WS_EX_LAYERED = &H80000
    Private Const LWA_ALPHA = &H2

    Private InitialStyle As Integer
    Public Enum GWL As Integer
        ExStyle = -20
    End Enum

    Public Enum WS_EX As Integer
        Transparent = &H20
        Layered = &H80000
    End Enum

    Public Enum LWA As Integer
        ColorKey = &H1
        Alpha = &H2
    End Enum
    Private Declare Function GetForegroundWindow Lib "user32.dll" () As Long
    Private Declare Function GetWindowTextLength Lib "user32.dll" Alias "GetWindowTextLengthA" (ByVal hwnd As Long) As Long
    Private Declare Function GetWindowText Lib "user32.dll" Alias "GetWindowTextA" (ByVal hwnd As Long, ByVal lpString As String, ByVal nMaxCount As Long) As Long

    'für "StayOnTop2"
    Declare Function SetWindowPos Lib "user32" (ByVal hwnd As Integer, ByVal hWndInsertAfter As Integer, ByVal X As Integer, ByVal Y As Integer, ByVal cx As Integer, ByVal cy As Integer, ByVal wFlags As Integer) As Integer
    Private Const SWP_NOMOVE = 2
    Private Const SWP_NOSIZE = 1
    Private Const flags = SWP_NOMOVE Or SWP_NOSIZE
    Private Const HWND_TOPMOST = -1
    Private Const HWND_NOTOPMOST = -2


    Public Sub Mache_Transparent(hwnd As Integer, Rate As Byte, ClickThru As Boolean)
        '### funktioniert nur unter Windows 2000 oder XP!!!
        '### macht das Fenster, dessen hWnd übergeben wurde, transparent
        '### Rate: 254 = normal 0 = ganz transparent (also unsichtbar)
        '### 190 ist z.B. ein guter Wert

        Dim WinInfo As Integer

        WinInfo = GetWindowLong(hwnd, GWL_EXSTYLE)

        If Rate < 255 Then
            Select Case ClickThru
                Case True
                    InitialStyle = GetWindowLong(hwnd, GWL.ExStyle)
                    SetWindowLong(hwnd, GWL.ExStyle, InitialStyle Or WS_EX.Layered Or WS_EX.Transparent)
                    SetLayeredWindowAttributes(hwnd, 0, Rate, LWA_ALPHA)
                    Call StayOnTop(getActWindow(2), True)
                Case False
                    WinInfo = WinInfo Or WS_EX_LAYERED
                    SetWindowLong(hwnd, GWL_EXSTYLE, WinInfo)
                    SetLayeredWindowAttributes(hwnd, 0, Rate, LWA_ALPHA)
            End Select
        Else
            'Wenn als Rate 255 angegeben wird,
            'so wird der Ausgangszustand wiederhergestellt
            WinInfo = WinInfo Xor WS_EX_LAYERED
            'SetWindowLong(hwnd, GWL_EXSTYLE, WinInfo)

            SetWindowLong(hwnd, GWL.ExStyle, InitialStyle Or WS_EX.Layered)
            'SetLayeredWindowAttributes(hwnd, 0, 255, LWA.Alpha)

            SetLayeredWindowAttributes(hwnd, 0, 255, LWA_ALPHA)
            Call StayOnTop(getActWindow(2), False)
        End If
    End Sub

    Public Function getActWindow(Text1Number2 As Single)

        ' Display the title bar text of the foreground window.
        Dim hforewnd As Long  ' receives handle of foreground window
        Dim slength As Long  ' length of foreground window's title bar text
        Dim wintext As String  ' buffer for foreground window's title bar text
        Dim retval As Long  ' return value

        hforewnd = GetForegroundWindow()  ' determine the foreground window
        If Text1Number2 = 2 Then getActWindow = hforewnd : Exit Function
        slength = GetWindowTextLength(hforewnd) + 1  ' length of its title bar text
        wintext = Space(slength)  ' make room in the buffer to receive the text
        retval = GetWindowText(hforewnd, wintext, slength)  ' get title bar text
        wintext = Left(wintext, slength - 1)  ' remove null character from end of string
        getActWindow = wintext

    End Function

    Public Sub StayOnTop(hwnd As Integer, YesNo As Boolean)
        Select Case YesNo
            Case True
                Call SetWindowPos(hwnd, HWND_TOPMOST, 0, 0, 0, 0, flags)      ' OnTop
            Case False
                Call SetWindowPos(hwnd, HWND_NOTOPMOST, 0, 0, 0, 0, flags)    ' OffTop
        End Select
    End Sub
End Module
