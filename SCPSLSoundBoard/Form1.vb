Public Class Form1
    'My.Computer.Audio.Play(My.Resources. , AudioPlayMode.Background)

    'Ambient Sounds
    Private Sub PlayAmbientSoundBtn_Click(sender As Object, e As EventArgs) Handles PlayAmbientSoundBtn.Click
        Try
            Select Case ComboBox1.SelectedItem.ToString
                Case "Ambient 1 #20732"
                    My.Computer.Audio.Play(My.Resources.Ambient1a, AudioPlayMode.Background)
                Case "Ambient 1 "
                    My.Computer.Audio.Play(My.Resources.Ambient1, AudioPlayMode.Background)
                Case "Ambient 2 #20754"
                    My.Computer.Audio.Play(My.Resources.Ambient2a, AudioPlayMode.Background)
                Case "Ambient 2"
                    My.Computer.Audio.Play(My.Resources.Ambient2, AudioPlayMode.Background)
                Case "Ambient 3 #20755"
                    My.Computer.Audio.Play(My.Resources.Ambient3a, AudioPlayMode.Background)
                Case "Ambient 3"
                    My.Computer.Audio.Play(My.Resources.Ambient3, AudioPlayMode.Background)
                Case "Ambient 4 #20663"
                    My.Computer.Audio.Play(My.Resources.Ambient4a, AudioPlayMode.Background)
                Case "Ambient 4"
                    My.Computer.Audio.Play(My.Resources.Ambient4, AudioPlayMode.Background)
                Case "Ambient 5 $20741"
                    My.Computer.Audio.Play(My.Resources.Ambient5a, AudioPlayMode.Background)
                Case "Ambient 5"
                    My.Computer.Audio.Play(My.Resources.Ambient5, AudioPlayMode.Background)
                Case "Ambient 6 #20684"
                    My.Computer.Audio.Play(My.Resources.Ambient6a, AudioPlayMode.Background)
                Case "Ambient 6"
                    My.Computer.Audio.Play(My.Resources.Ambient6, AudioPlayMode.Background)
                Case "Ambient 7 #20761"
                    My.Computer.Audio.Play(My.Resources.Ambient7a, AudioPlayMode.Background)
                Case "Ambient 7"
                    My.Computer.Audio.Play(My.Resources.Ambient7, AudioPlayMode.Background)
                Case "Ambient 8 #20722"
                    My.Computer.Audio.Play(My.Resources.Ambient8a, AudioPlayMode.Background)
                Case "Ambient 8"
                    My.Computer.Audio.Play(My.Resources.Ambient8, AudioPlayMode.Background)
                Case "Ambient 9"
                    My.Computer.Audio.Play(My.Resources.Ambient9, AudioPlayMode.Background)
                Case "Ambient 10"
                    My.Computer.Audio.Play(My.Resources.Ambient10, AudioPlayMode.Background)
                Case "Ambient 11"
                    My.Computer.Audio.Play(My.Resources.Ambient11, AudioPlayMode.Background)
                Case "Ambient 12"
                    My.Computer.Audio.Play(My.Resources.Ambient12, AudioPlayMode.Background)
                Case "Ambient 13"
                    My.Computer.Audio.Play(My.Resources.Ambient13, AudioPlayMode.Background)
                Case "Ambient 14"
                    My.Computer.Audio.Play(My.Resources.Ambient14, AudioPlayMode.Background)
                Case "Ambient 15"
                    My.Computer.Audio.Play(My.Resources.Ambient15, AudioPlayMode.Background)
                Case "Ambient 17"
                    My.Computer.Audio.Play(My.Resources.Ambient17, AudioPlayMode.Background)
                Case "Ambient 18"
                    My.Computer.Audio.Play(My.Resources.Ambient18, AudioPlayMode.Background)
                Case "Ambient 19"
                    My.Computer.Audio.Play(My.Resources.Ambient19, AudioPlayMode.Background)
                Case "Ambient 20"
                    My.Computer.Audio.Play(My.Resources.Ambient20, AudioPlayMode.Background)
                Case "Ambient 21"
                    My.Computer.Audio.Play(My.Resources.Ambient21, AudioPlayMode.Background)
                Case "Ambient 22"
                    My.Computer.Audio.Play(My.Resources.Ambient22, AudioPlayMode.Background)
                Case "Ambient 23"
                    My.Computer.Audio.Play(My.Resources.Ambient22, AudioPlayMode.Background)
            End Select
        Catch ex As Exception
        End Try
    End Sub

    'SCP Sounds
    Private Sub SCPSoundsBtn_Click(sender As Object, e As EventArgs) Handles SCPSoundsBtn.Click
        Try
            Select Case ComboBox2.SelectedItem.ToString
                Case "SCP 106 Contained"
                    My.Computer.Audio.Play(My.Resources.SCP106Contained, AudioPlayMode.Background)
                Case "SCP 106 Femur Breaker"
                    My.Computer.Audio.Play(My.Resources.SCP106FemurBreaker, AudioPlayMode.Background)
                Case "SCP 106 Footsteps 01"
                    My.Computer.Audio.Play(My.Resources.SCP106Footstep01, AudioPlayMode.Background)
                Case "SCP 106 Footsteps 02"
                    My.Computer.Audio.Play(My.Resources.SCP106Footstep02, AudioPlayMode.Background)
                Case "SCP 106 Footsteps 03"
                    My.Computer.Audio.Play(My.Resources.SCP106Footstep03, AudioPlayMode.Background)
                Case "SCP 173 Neck Snap 01"
                    My.Computer.Audio.Play(My.Resources.SCP173Snap01, AudioPlayMode.Background)
                Case "SCP 173 Neck Snap 02"
                    My.Computer.Audio.Play(My.Resources.SCP173Snap02, AudioPlayMode.Background)
                Case "SCP 173 Neck Snap 03"
                    My.Computer.Audio.Play(My.Resources.SCP173Snap03, AudioPlayMode.Background)
                Case "SCP 173 Footsteps 01"
                    My.Computer.Audio.Play(My.Resources.SCP173Footstep01, AudioPlayMode.Background)
                Case "SCP 173 Footsteps 02"
                    My.Computer.Audio.Play(My.Resources.SCP173Footstep02, AudioPlayMode.Background)
                Case "SCP 173 Footsteps 03"
                    My.Computer.Audio.Play(My.Resources.SCP173Footstep03, AudioPlayMode.Background)
                Case "SCP 096 Idle Sound"
                    My.Computer.Audio.Play(My.Resources.SCP096IdleSound, AudioPlayMode.Background)
                Case "SCP 096 Trigger Sound"
                    My.Computer.Audio.Play(My.Resources.SCP096Triggered, AudioPlayMode.Background)
                Case "SCP 096 Panic Sound"
                    My.Computer.Audio.Play(My.Resources.SCP096Scream, AudioPlayMode.Background)
            End Select
        Catch ex As Exception
        End Try
    End Sub

    'Scare Sounds
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Select Case ComboBox3.SelectedItem.ToString
                Case "Scare 0"
                    My.Computer.Audio.Play(My.Resources.Scare_0, AudioPlayMode.Background)
                Case "Scare 1"
                    My.Computer.Audio.Play(My.Resources.Scare_1, AudioPlayMode.Background)
                Case "Scare 2"
                    My.Computer.Audio.Play(My.Resources.Scare_2, AudioPlayMode.Background)
                Case "Scare 3"
                    My.Computer.Audio.Play(My.Resources.Scare_3, AudioPlayMode.Background)
                Case "Scare 4"
                    My.Computer.Audio.Play(My.Resources.Scare_4, AudioPlayMode.Background)
                Case "Scare 5"
                    My.Computer.Audio.Play(My.Resources.Scare_5, AudioPlayMode.Background)
                Case "Scare 6"
                    My.Computer.Audio.Play(My.Resources.Scare_6, AudioPlayMode.Background)
            End Select
        Catch ex As Exception
        End Try
    End Sub

    'Weapon Sounds
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Select Case ComboBox4.SelectedItem.ToString
                Case "ShotM249"
                    My.Computer.Audio.Play(My.Resources.ShotmM249, AudioPlayMode.Background)
                Case "ShotMicroUzi"
                    My.Computer.Audio.Play(My.Resources.ShotMicroUzi, AudioPlayMode.Background)
                Case "ShotE11Rifle"
                    My.Computer.Audio.Play(My.Resources.ShotE11Rifle, AudioPlayMode.Background)
                Case "ShotPistol"
                    My.Computer.Audio.Play(My.Resources.ShotPistol, AudioPlayMode.Background)
                Case "ReloadM249"
                    My.Computer.Audio.Play(My.Resources.ReloadM249, AudioPlayMode.Background)
                Case "ReloadMicroUzi"
                    My.Computer.Audio.Play(My.Resources.ReloadMicroUzi, AudioPlayMode.Background)
                Case "ReloadPistol"
                    My.Computer.Audio.Play(My.Resources.ReloadPistol, AudioPlayMode.Background)
                Case "ReloadE11Rifle01"
                    My.Computer.Audio.Play(My.Resources.ReloadE11Rifle01, AudioPlayMode.Background)
                Case "ReloadE11Rifle02"
                    My.Computer.Audio.Play(My.Resources.ReloadE11Rifle02, AudioPlayMode.Background)
                Case "EMPGrenade"
                    My.Computer.Audio.Play(My.Resources.EMPGrenade, AudioPlayMode.Background)
                Case "SmokeGrenade"
                    My.Computer.Audio.Play(My.Resources.SmokeGrenade, AudioPlayMode.Background)
                Case "OutOfAmmo"
                    My.Computer.Audio.Play(My.Resources.OutOfAmmo, AudioPlayMode.Background)
                Case "M-HID"
                    My.Computer.Audio.Play(My.Resources.HIDTurret, AudioPlayMode.Background)
            End Select
        Catch ex As Exception
        End Try
    End Sub

    'Nuke Sounds
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Select Case ComboBox5.SelectedItem.ToString
                Case "Detonation Canceled"
                    My.Computer.Audio.Play(My.Resources.Canceled, AudioPlayMode.Background)
                Case "Main 80"
                    My.Computer.Audio.Play(My.Resources.Main80, AudioPlayMode.Background)
                Case "Main 90"
                    My.Computer.Audio.Play(My.Resources.Main90, AudioPlayMode.Background)
                Case "Main 100"
                    My.Computer.Audio.Play(My.Resources.Main100, AudioPlayMode.Background)
                Case "Main 110"
                    My.Computer.Audio.Play(My.Resources.Main110, AudioPlayMode.Background)
                Case "Main 120"
                    My.Computer.Audio.Play(My.Resources.Main120, AudioPlayMode.Background)
                Case "Resume 30"
                    My.Computer.Audio.Play(My.Resources.Resume30, AudioPlayMode.Background)
                Case "Resume 40"
                    My.Computer.Audio.Play(My.Resources.Resume40, AudioPlayMode.Background)
                Case "Resume 50"
                    My.Computer.Audio.Play(My.Resources.Resume50, AudioPlayMode.Background)
                Case "Resume 60"
                    My.Computer.Audio.Play(My.Resources.Resume60, AudioPlayMode.Background)
                Case "Resume 70"
                    My.Computer.Audio.Play(My.Resources.Resume70, AudioPlayMode.Background)
                Case "Resume 80"
                    My.Computer.Audio.Play(My.Resources.Resume80, AudioPlayMode.Background)
                Case "Resume 90"
                    My.Computer.Audio.Play(My.Resources.Resume90, AudioPlayMode.Background)
                Case "Resume 100"
                    My.Computer.Audio.Play(My.Resources.Resume100, AudioPlayMode.Background)
            End Select
        Catch ex As Exception
        End Try
    End Sub

    'Other Sounds
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Select Case ComboBox6.SelectedItem.ToString
                Case "Noise 02"
                    My.Computer.Audio.Play(My.Resources.Broadcast2, AudioPlayMode.Background)
                Case "Noise 07"
                    My.Computer.Audio.Play(My.Resources.Broadcast7, AudioPlayMode.Background)
                Case "Chaos Insurgency Spawn"
                    My.Computer.Audio.Play(My.Resources.The_Chaos_Insurgency_Announce, AudioPlayMode.Background)
                Case "Intercom Start"
                    My.Computer.Audio.Play(My.Resources.ic_start, AudioPlayMode.Background)
                Case "Intercom Stop"
                    My.Computer.Audio.Play(My.Resources.ic_stop, AudioPlayMode.Background)
                Case "Spawn Bell"
                    My.Computer.Audio.Play(My.Resources.Bell1, AudioPlayMode.Background)
                Case "Die Bell"
                    My.Computer.Audio.Play(My.Resources.Bell2, AudioPlayMode.Background)
                Case "Fall Damage"
                    My.Computer.Audio.Play(My.Resources.falldamage, AudioPlayMode.Background)
                Case "Helicopter"
                    My.Computer.Audio.Play(My.Resources.Helicopter, AudioPlayMode.Background)
            End Select
        Catch ex As Exception
        End Try
    End Sub
End Class
