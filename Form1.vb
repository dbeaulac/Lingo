Public Class frmLingo

    Dim secret(4) As Char       ' Stores the answer in an easily searchable character array
    Dim prog(4) As Integer      ' Determines the progress made on each letter
    Dim dealt(4) As Integer     ' Determines if a letter has already been placed
    Dim solve(4) As Char        ' Stores the letters that have been correctly guessed
    Dim guess As Integer        ' Refers to the current round of guessing (value 1-5)
    Dim time As Integer         ' Value that controls the precise moments of letters being typed in and revealed

    Dim yes As New System.Drawing.Font("Arial", 40, FontStyle.Underline)    'Font for correctly guessed letters
    Dim maybe As New System.Drawing.Font("Arial", 40, FontStyle.Italic)     'Font for correct letters in the wrong spot
    Dim no As New System.Drawing.Font("Arial", 40, FontStyle.Regular)       'Font for incorrectly guessed letters

    Private Sub btnSubmit_Click(sender As System.Object, e As System.EventArgs) Handles btnSubmit.Click
        For i As Integer = 0 To 4 Step 1
            secret(i) = txtSecret.Text(i)   'Stores the secret word into the secret array

            'Resets the values of prog and dealt
            prog(i) = 0
            dealt(i) = 0
        Next

        guess = 1       'Sets guess to 1, beginning a new game

        'Resets the board
        For Each control In letterTable.Controls
            Dim letterLabel = TryCast(control, Label)
            letterLabel.BackColor = Color.MidnightBlue
            letterLabel.ForeColor = Color.White
            letterLabel.Font = no
            letterLabel.Text = "."
        Next

        'Places the first letter of the secret word into position 1 of guess 1,
        'blanks out the answer row, and resets the solved letters
        lbl11.Text = secret(0)
        For i As Integer = 1 To 5 Step 1
            letterTable.Controls("lbl6" & i).Text = " "
            solve(i - 1) = "."
        Next
        solve(0) = lbl11.Text

        'Remove the controls for the secret button
        btnSubmit.Visible = False
        txtSecret.Visible = False

        'Reveals the TextBox for submitting guesses, and focuses the cursor inside
        txtGuess.Visible = True
        txtGuess.Focus()

        pbInstructions.Image = lingo.My.Resources.GuessingInstructions
    End Sub

    Private Sub btnGuess_Click(sender As System.Object, e As System.EventArgs) Handles btnGuess.Click
        'Checks each letter individually, to see if the position of each letter matches.
        For i As Integer = 0 To 4 Step 1
            If txtGuess.Text(i) = secret(i) Then
                prog(i) = 2
                dealt(i) = 1
            End If
        Next

        'Checks each letter to see if the letter is in the word, but in the wrong position
        For j As Integer = 0 To 4 Step 1
            For i As Integer = 0 To 4 Step 1
                'This if statement only runs if all three conditions are true
                '1. If the current letter is in the word
                '2. If the letter hasn't already been solved
                '3. If the letter hasn't already been dealt with
                '   (example: preventing both O's in MOOSE from lighting up)
                If txtGuess.Text(j) = secret(i) And prog(j) <> 2 And dealt(i) = 0 Then
                    prog(j) = 1
                    dealt(i) = 1
                    i = 5
                End If
            Next
        Next
        'Sets the time integer 
        time = 0
        Timer1.Start()
    End Sub

    Private Sub txtSecret_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtSecret.TextChanged
        'Checks if there are five characters in the secret word TextBox.
        'If so, the submit button appears, and the button gains focus
        'If there are ever less than 5 characters, the submit button disappears or will not show
        'The TextBox has a maximum length of 5 characters, so no code is required to enforce this.
        If txtSecret.TextLength = 5 Then
            btnSubmit.Visible = True
            btnSubmit.Focus()
        Else
            btnSubmit.Visible = False
        End If
    End Sub

    Private Sub txtGuess_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtGuess.TextChanged
        'Checks if there are five characters in the guessed word TextBox.
        'If so, the guess button appears, and the button gains focus
        'If there are ever less than 5 characters, the guess button disappears or will not show
        'The TextBox has a maximum length of 5 characters, so no code is required to enforce this.
        If txtGuess.TextLength = 5 Then
            btnGuess.Visible = True
            btnGuess.Focus()
        Else
            btnGuess.Visible = False
        End If
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        'The interval of the timer is 175 ticks (milliseconds) 
        'As the timer ticks, the leters will be placed onto the board, one at a time,
        'followed by the result of the guess being revealed one letter at a time.

        If time = 1 Then        'Places the first letter of the guess into position #1
            letterTable.Controls("lbl" & guess & "1").Text = txtGuess.Text(0)
        ElseIf time = 2 Then    'Places the second letter of the guess into position #2
            letterTable.Controls("lbl" & guess & "2").Text = txtGuess.Text(1)
        ElseIf time = 3 Then    'Places the third letter of the guess into position #3
            letterTable.Controls("lbl" & guess & "3").Text = txtGuess.Text(2)
        ElseIf time = 4 Then    'Places the fourth letter of the guess into position #4
            letterTable.Controls("lbl" & guess & "4").Text = txtGuess.Text(3)
        ElseIf time = 5 Then    'Places the fifth letter of the guess into position #5
            letterTable.Controls("lbl" & guess & "5").Text = txtGuess.Text(4)
        ElseIf time > 8 And time < 14 Then    'Reveals the result of the each letter
            If prog(time - 9) = 2 Then
                'If prog is 2, then the letter is in the word and in the correct place
                letterTable.Controls("lbl" & guess & time - 8).BackColor = Color.OrangeRed
                letterTable.Controls("lbl" & guess & time - 8).Font = yes
                solve(time - 9) = letterTable.Controls("lbl" & guess & time - 8).Text
            ElseIf prog(time - 9) = 1 Then
                'If prog is 1, then the letter is in the word, but in the wrong place
                letterTable.Controls("lbl" & guess & time - 8).BackColor = Color.Gold
                letterTable.Controls("lbl" & guess & time - 8).ForeColor = Color.Black
                letterTable.Controls("lbl" & guess & time - 8).Font = maybe
            End If
        ElseIf time = 14 Then

            'Readies the game for the next guess
            guess += 1
            txtGuess.Text = ""
            txtGuess.Focus()

            'Checks if the word has been solved, or if the guess limit has been reached
            If prog(0) + prog(1) + prog(2) + prog(3) + prog(4) = 10 Or guess > 5 Then
                For i As Integer = 0 To 4 Step 1
                    letterTable.Controls("lbl6" & i + 1).Text = secret(i)
                Next
                
                txtSecret.Visible = True
                btnSubmit.Visible = True
                txtGuess.Visible = False
                btnGuess.Visible = False

                txtSecret.Text = ""
                txtSecret.Focus()
                pbInstructions.Image = lingo.My.Resources.SecretInstructions
            Else
                'Loads the currently solved letters into the next row
                For i As Integer = 0 To 4 Step 1
                    letterTable.Controls("lbl" & guess & i + 1).Text = solve(i)
                Next
            End If

            'Clears prog and dealt for the next word
            For i As Integer = 0 To 4 Step 1
                prog(i) = 0
                dealt(i) = 0
            Next
            Timer1.Stop()
        End If

        'Increments time, so the next tick will run the next block of code
        time += 1
    End Sub
End Class
