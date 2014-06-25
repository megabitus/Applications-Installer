Public Class Form1
    Dim win, intr
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim p As New Process
        If My.Computer.FileSystem.DirectoryExists("C:\Program Files (x86)") Then
            win = True
        Else
            win = False
        End If
        'Browsers
        If CheckBox1.Checked Then
            p.StartInfo.WorkingDirectory = "Programs\Browsers\"
            If intr = True Then
                p.StartInfo.FileName = "ChromeOnline.exe"
            Else
                p.StartInfo.FileName = "Chrome.exe"
            End If
            p.Start()
            p.WaitForExit()
        End If
        If CheckBox2.Checked Then
            p.StartInfo.WorkingDirectory = "Programs\Browsers\"
            If intr = True Then
                p.StartInfo.FileName = "FirefoxOnline.exe"
            Else
                p.StartInfo.FileName = "Firefox.exe"
            End If
            p.Start()
            p.WaitForExit()
        End If
        If CheckBox3.Checked Then
            p.StartInfo.WorkingDirectory = "Programs\Browsers\"
            p.StartInfo.FileName = "Opera.exe"
            p.Start()
            p.WaitForExit()
        End If
        'Compression
        If CheckBox4.Checked Then
            p.StartInfo.WorkingDirectory = "Programs\Compression\"
            If win = True Then
                p.StartInfo.FileName = "winrar64.exe"
            Else
                p.StartInfo.FileName = "winrar.exe"
            End If
            p.Start()
            p.WaitForExit()
        End If
        If CheckBox5.Checked Then
            p.StartInfo.WorkingDirectory = "Programs\Compression\"
            If win = True Then
                p.StartInfo.FileName = "7z64.msi"
            Else
                p.StartInfo.FileName = "7z.exe"
            End If
            p.Start()
            p.WaitForExit()
        End If
        'Documents
        If CheckBox6.Checked Then
            p.StartInfo.WorkingDirectory = "Programs\Documents\Microsoft Office 2013\"
            p.StartInfo.FileName = "setup.exe"
            p.Start()
        End If
        If CheckBox7.Checked Then
            p.StartInfo.WorkingDirectory = "Programs\Documents\Office 2007\"
            p.StartInfo.FileName = "SETUP.EXE"
            p.Start()
            p.WaitForExit()
        End If
        If CheckBox8.Checked Then
            p.StartInfo.WorkingDirectory = "Programs\Documents\"
            If intr = True Then
                p.StartInfo.FileName = "Adobe Reader XI Online.exe"
            Else
                p.StartInfo.FileName = "Adobe Reader XI.exe"
            End If
            p.Start()
            p.WaitForExit()
        End If
        If CheckBox9.Checked Then
            p.StartInfo.WorkingDirectory = "Programs\Documents\"
            p.StartInfo.FileName = "Apache OpenOffice.exe"
            p.Start()
            p.WaitForExit()
        End If
        'Media
        If CheckBox10.Checked Then
            p.StartInfo.WorkingDirectory = "Programs\Media\"
            p.StartInfo.FileName = "foobar2000.exe"
            p.Start()
            p.WaitForExit()
        End If
        If CheckBox11.Checked Then
            p.StartInfo.WorkingDirectory = "Programs\Media\"
            p.StartInfo.FileName = "KMPlayer.exe"
            p.Start()
            p.WaitForExit()
        End If
        If CheckBox12.Checked Then
            p.StartInfo.WorkingDirectory = "Programs\Media\"
            p.StartInfo.FileName = "vlc.exe"
            p.Start()
            p.WaitForExit()
        End If
        If CheckBox13.Checked Then
            p.StartInfo.WorkingDirectory = "Programs\Media\"
            p.StartInfo.FileName = "winamp.exe"
            p.Start()
            p.WaitForExit()
        End If
        If CheckBox14.Checked Then
            p.StartInfo.WorkingDirectory = "Programs\Media\"
            If win = True Then
                p.StartInfo.FileName = "PotPlayer64.EXE"
            Else
                p.StartInfo.FileName = "PotPlayer.EXE"
            End If
            p.Start()
            p.WaitForExit()
        End If
        'Runtimes
        If CheckBox15.Checked Then
            p.StartInfo.WorkingDirectory = "Programs\Runtimes\"
            If intr = True Then
                p.StartInfo.FileName = "directxOnline.exe"
            Else
                p.StartInfo.FileName = "directx.exe"
            End If
            p.Start()
            p.WaitForExit()
        End If
        If CheckBox16.Checked Then
            p.StartInfo.WorkingDirectory = "Programs\Runtimes\"
            If intr = True Then
                p.StartInfo.FileName = "dotNetFxOnline.exe"
            Else
                p.StartInfo.FileName = "dotNetFx.exe"
            End If
            p.Start()
            p.WaitForExit()
        End If
        If CheckBox17.Checked Then
            p.StartInfo.WorkingDirectory = "Programs\Runtimes\"
            If win = True Then
                p.StartInfo.FileName = "jre764.exe"
            ElseIf intr = True Then
                p.StartInfo.FileName = "jre7Online.exe"
            Else
                p.StartInfo.FileName = "jre7.exe"
            End If
            p.Start()
            p.WaitForExit()
        End If
        If CheckBox18.Checked Then
            p.StartInfo.WorkingDirectory = "Programs\Runtimes\"
            If win = True Then
                p.StartInfo.FileName = "jre864.exe"
            ElseIf intr = True Then
                p.StartInfo.FileName = "jre8Online.exe"
            Else
                p.StartInfo.FileName = "jre8.exe"
            End If
            p.Start()
            p.WaitForExit()
        End If
        'Security
        If CheckBox19.Checked Then
            p.StartInfo.WorkingDirectory = "Programs\Security\"
            p.StartInfo.FileName = "avast.exe"
            p.Start()
            p.WaitForExit()
        End If
        'Utilites
        If CheckBox20.Checked Then
            p.StartInfo.WorkingDirectory = "Programs\Utilities\"
            p.StartInfo.FileName = "ccsetup.exe"
            p.Start()
            p.WaitForExit()
        End If
        If CheckBox21.Checked Then
            p.StartInfo.WorkingDirectory = "Programs\Utilities\"
            p.StartInfo.FileName = "cdbxp.exe"
            p.Start()
            p.WaitForExit()
        End If
        If CheckBox22.Checked Then
            p.StartInfo.WorkingDirectory = "Programs\Utilities\"
            p.StartInfo.FileName = "dfsetup.exe"
            p.Start()
            p.WaitForExit()
        End If
        If CheckBox23.Checked Then
            p.StartInfo.WorkingDirectory = "Programs\Utilities\"
            p.StartInfo.FileName = "spsetup.exe"
            p.Start()
            p.WaitForExit()
        End If
        If CheckBox24.Checked Then
            p.StartInfo.WorkingDirectory = "Programs\Utilities\"
            p.StartInfo.FileName = "TeamViewer.exe"
            p.Start()
            p.WaitForExit()
        End If
        MsgBox("Installation Succesfull")
        Me.Close()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Computer.FileSystem.DirectoryExists("C:\Program Files (x86)") Then
            win = True
        Else
            win = False
        End If
        intr = My.Computer.Network.IsAvailable
        Label8.Text = My.Computer.Name
        If win = True Then
            Label10.Text = My.Computer.Info.OSFullName + "x64"
        Else
            Label10.Text = My.Computer.Info.OSFullName + "x32"
        End If
        Label12.Text = intr
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class

