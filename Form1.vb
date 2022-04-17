Public Class Form1
    '--------------------------------------------------------------------------------
    '-                      File Name: Form1                                        -
    '-                      Part of Project: custom framework control program       -
    '--------------------------------------------------------------------------------
    '-                      Written By: Andrew A. Loesel                            -
    '-                      Written On: April 14, 2022                              -
    '--------------------------------------------------------------------------------
    '- File Purpose:                                                                -
    '-                                                                              -
    '- This file contains the form definition for the form that we put our custom   -
    '- control on.                                                                  -
    '--------------------------------------------------------------------------------
    '- Program Purpose:                                                             -
    '-                                                                              -
    '- The purpose of this program is to create a custom control for windows forms, -
    '- and implement this crontrol on a forms application.                          -
    '--------------------------------------------------------------------------------
    '- Global Variable Dictionary (alphabetically):                                 -
    '- theEndColor - the end color of our gradient.                                 -
    '- theGradientMode - the gradient mode of our control.                          -
    '- theStartColor - the start color of our gradient.                             -
    '--------------------------------------------------------------------------------
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        '------------------------------------------------------------------------------
        '-                      Subprogram Name: btnStart_Click                       -
        '------------------------------------------------------------------------------
        '-                      Written By: Andrew A. Loesel                          -
        '-                      Written On: April 14, 2022                            -
        '------------------------------------------------------------------------------
        '- Subprogram Purpose:                                                        -
        '-                                                                            -
        '- The purpose of this subprogram is to change the start color of our custom  -
        '- gradientControl, userControl1, when the user clicks the start color button.-
        '- We also say 'vb programming rocks' in our textbox.                         -
        '------------------------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):                                 -
        '- sender - identifies which control used the event.                          -
        '- e - Holds the EventArgs object sent to the routine.                        -
        '------------------------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):                                -
        '- None                                                                       -
        '------------------------------------------------------------------------------
        txtMsg.Text = "VB Programming Rocks!"
        UserControl11.StartColor = Color.SteelBlue
    End Sub

    Private Sub btnEnd_Click(sender As Object, e As EventArgs) Handles btnEnd.Click
        '------------------------------------------------------------------------------
        '-                      Subprogram Name: btnEnd_Click                         -
        '------------------------------------------------------------------------------
        '-                      Written By: Andrew A. Loesel                          -
        '-                      Written On: April 14, 2022                            -
        '------------------------------------------------------------------------------
        '- Subprogram Purpose:                                                        -
        '-                                                                            -
        '- The purpose of this subprogram is to change the end color of our gradient  -
        '- control when the user presses the end color button.                        -
        '------------------------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):                                 -
        '- sender - identifies which control used the event.                          -
        '- e - Holds the EventArgs object sent to the routine.                        -
        '------------------------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):                                -
        '- None                                                                       -
        '------------------------------------------------------------------------------
        UserControl11.EndColor = Color.DarkOliveGreen
    End Sub

    Private Sub btnGradient_Click(sender As Object, e As EventArgs) Handles btnGradient.Click
        '------------------------------------------------------------------------------
        '-                      Subprogram Name: btnStart_Click                       -
        '------------------------------------------------------------------------------
        '-                      Written By: Andrew A. Loesel                          -
        '-                      Written On: April 14, 2022                            -
        '------------------------------------------------------------------------------
        '- Subprogram Purpose:                                                        -
        '-                                                                            -
        '- The purpose of this subprogram is to change the gradient mode of our       -
        '- gradient control when the user clicks the gradient button.                 -
        '------------------------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):                                 -
        '- sender - identifies which control used the event.                          -
        '- e - Holds the EventArgs object sent to the routine.                        -
        '------------------------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):                                -
        '- None                                                                       -
        '------------------------------------------------------------------------------
        UserControl11.GradientMode = Drawing.Drawing2D.LinearGradientMode.Vertical
    End Sub
End Class
