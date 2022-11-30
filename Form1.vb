
Public Class frmMain
    <Runtime.InteropServices.DllImport("User32")>
    Private Shared Function SetForegroundWindow(hwnd As IntPtr) As Integer
    End Function
    Public Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Integer) As Short

    Private Sub tbTransparenz_Scroll(sender As Object, e As EventArgs) Handles tbTransparenz.Scroll
        lbValue.Text = tbTransparenz.Value * -1 + 100 & "%"
        Me.Opacity = 0.1 + tbTransparenz.Value / 100
    End Sub

    Private Sub tbTransparenz_MouseUp(sender As Object, e As MouseEventArgs) Handles tbTransparenz.MouseUp
        Me.Opacity = 100
    End Sub


    Private Sub tbTransparenz_MouseDown(sender As Object, e As MouseEventArgs) Handles tbTransparenz.MouseDown
        Me.Opacity = 0.1 + tbTransparenz.Value / 100
    End Sub

    Private Sub tmrAction_Tick(sender As Object, e As EventArgs) Handles tmrAction.Tick
        '{AltGr} + {Einfg} => Transparenz = 100%
        If GetAsyncKeyState(165) <> 0 And GetAsyncKeyState(Keys.Insert) <> 0 Then _
            Call Mache_Transparent(getActWindow(2), 255, False) : Debug.Print("{Transparenz = 100%}")

        '{AltGr} + {Entf} => Transparenz = 1-100%
        If GetAsyncKeyState(165) <> 0 And GetAsyncKeyState(Keys.Delete) <> 0 Then _
        Call Mache_Transparent(getActWindow(2), tbTransparenz.Value * 2.4, False) : Debug.Print("{Transparenz = 2-100%}")


        '{AltGr} + {Bild auf} => allways on top = true
        If GetAsyncKeyState(165) <> 0 And GetAsyncKeyState(Keys.PageUp) <> 0 Then _
             Call StayOnTop(getActWindow(2), True) : Debug.Print("{allways on top = true}")

        '{AltGr} + {Bild ab} => allways on top = true
        If GetAsyncKeyState(165) <> 0 And GetAsyncKeyState(Keys.PageDown) <> 0 Then _
             Call StayOnTop(getActWindow(2), False) : Debug.Print("{allways on top = false}")
    End Sub

    Private Sub niIcon_MouseClick(sender As Object, e As MouseEventArgs) Handles niIcon.MouseClick
        If Me.Visible = False Then Me.Show() : Exit Sub
        If Me.Visible = True Then Me.Hide()
    End Sub

    Private Sub lbInfoLink_MouseHover(sender As Object, e As EventArgs) Handles lbInfoLink.MouseHover
        lbInfoLink.ForeColor = Color.Blue
        lbInfoLink.Text = "insidERR@gmx.net"
    End Sub
    Private Sub lbInfoLink_MouseLeave(sender As Object, e As EventArgs) Handles lbInfoLink.MouseLeave
        lbInfoLink.ForeColor = Color.Gray
        lbInfoLink.Text = lbInfoLink.Tag
    End Sub

    Private Sub lbInfoLink_Click(sender As Object, e As EventArgs) Handles lbInfoLink.Click
        Process.Start("mailto:insidERR@gmx.net?subject=Transparator 1.0&body=Ich liebe dieses Tool :-)")
    End Sub

End Class
