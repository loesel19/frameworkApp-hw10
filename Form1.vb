Public Class Form1
    '--------------------------------------------------------------------------------
    '-                      File Name: Form1                                        -
    '-                      Part of Project: Excel Linking Application (cis311 HW9) -
    '--------------------------------------------------------------------------------
    '-                      Written By: Andrew A. Loesel                            -
    '-                      Written On: April 14, 2022                              -
    '--------------------------------------------------------------------------------
    '- File Purpose:                                                                -
    '-                                                                              -
    '- This file contains all functionality of the program. We take care of all I/O -
    '- in this File. 
    '--------------------------------------------------------------------------------
    '- Program Purpose:                                                             -
    '-                                                                              -
    '- The purpose of this program is to load some data into a list on the front end-
    '- and then send that data to an excel sheet. We also will program formulas into-
    '- the excel sheet to take care of averages, stdevs, min and max for the student-
    '- scores that we are working with.                                             -
    '--------------------------------------------------------------------------------
    '- Global Variable Dictionary (alphabetically):                                 -
    '- myStudents - a generic list of clsStudents. Holds all the student data we    -
    '-              work with in this application.                                  -
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
