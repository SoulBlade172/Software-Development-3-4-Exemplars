Public Class clicker
    Dim tick = 0, yeetus = 0, dmg = 1, dps = 0, interval = 60, multiplier = 1, hit = 0,
        upgrades = {"click - 0", "ham - 0", "pizza - 0"}, cost = {2, 30, 100}
    Private Sub Init(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 1
        Timer1.Start()
        btnUpgrade1.Text = cost(0)
        btnupgrade2.Text = cost(1)
        btnupgrade3.Text = cost(2)
    End Sub
    Private Sub Clickupgrade(sender As Object, e As EventArgs) Handles btnUpgrade1.Click
        Dim index = 0
        If yeetus >= cost(index) Then
            Dim lvl = CInt(upgrades(index).Split(" ")(2))
            yeetus -= cost(index)
            dmg = (dmg + 1) * multiplier
            lbldamage.Text = $"{dmg} damage"
            cost(index) += Math.Floor(lvl * 1.5) + lvl + 1
            lblYeetus.Text = $"{yeetus} yeetus"
            btnUpgrade1.Text = cost(index)
            upgrades(index) = upgrades(index).replace(lvl.ToString, (lvl + 1).ToString)
            lblupgrade1.Text = upgrades(index)
            lbldamageind.Text = $"{dmg} damage per click"
        End If
    End Sub
    Private Sub Hamupgrade(sender As Object, e As EventArgs) Handles btnupgrade2.Click
        Dim index = 1
        If yeetus >= cost(index) Then
            Dim lvl = CInt(upgrades(index).Split(" ")(2))
            yeetus -= cost(index)
            dps += Math.Floor((1 + 1 * lvl / 10) * multiplier)
            lbldps.Text = $"{dps} dps"
            cost(index) += Math.Floor(lvl * 2 + cost(index) / 3)
            lblYeetus.Text = $"{yeetus} yeetus"
            btnupgrade2.Text = cost(index)
            upgrades(index) = upgrades(index).replace(lvl.ToString, (lvl + 1).ToString)
            lblupgrade2.Text = upgrades(index)
            lbldpsind.Text = $"{dps} damage per second"
        End If
    End Sub
    Private Sub Pizzaupgrade(sender As Object, e As EventArgs) Handles btnupgrade3.Click
        Dim index = 2
        If yeetus >= cost(index) Then
            Dim lvl = CInt(upgrades(index).Split(" ")(2))
            yeetus -= cost(index)
            multiplier += 0.1
            lblmultiplier.Text = $"{100 + Math.Floor((multiplier - 1) * 100)}% multiplier"
            cost(index) += Math.Floor(lvl * 2 + cost(index) / 3)
            lblYeetus.Text = $"{yeetus} yeetus"
            btnupgrade3.Text = cost(index)
            upgrades(index) = upgrades(index).replace(lvl.ToString, (lvl + 1).ToString)
            lblupgrade3.Text = upgrades(index)
            lblbonus.Text = $"{Math.Floor((multiplier - 1) * 100)}% bonus damage"
        End If
    End Sub
    Private Sub Clickevent(sender As Object, e As EventArgs) Handles pbmain.Click
        yeetus += dmg
        lblYeetus.Text = $"{yeetus} yeetus"
        hit = tick + 3
        pbmain.Size = New Size(pbmain.Width * 1.05, pbmain.Height * 1.05)
        pbmain.Location = New Point(pbmain.Location.X * 1.05, pbmain.Location.Y * 1.05)
        'damage(0)
    End Sub
    Private Sub Timer(sender As Object, e As EventArgs) Handles Timer1.Tick
        tick += 1
        Select Case dps
            Case <= 1 : interval = 60
            Case 2 : interval = 30
            Case 4 : interval = 15
            Case >= 10 : interval = 10
        End Select
        If tick Mod interval = 0 Then
            If dps > 0 Then yeetus += Math.Floor(dps)
            lblYeetus.Text = $"{yeetus} yeetus"
        End If
        If tick = hit Then
            pbmain.Size = New Size(pbmain.Width / 1.05, pbmain.Height / 1.05)
            pbmain.Location = New Point(pbmain.Location.X / 1.05, pbmain.Location.Y / 1.05)
        End If
    End Sub
    Public Sub damage(hit)
        Dim img As Bitmap = New Bitmap(pbmain.Image)
        For x = 0 To img.Width - 1
            For y = 0 To img.Height - 1
                Dim oldimg = img.GetPixel(x, y)
                Dim newimg = Color.FromArgb(Math.Abs(255 - oldimg.R), Math.Abs(255 - oldimg.G), Math.Abs(255 - oldimg.B))
                img.SetPixel(x, y, newimg)
            Next
        Next
        pbmain.Image = img
    End Sub
End Class
