Public Class Form1
    Dim A, B, C, D, E As Boolean

    Private time As Byte

    Private Sub pb12_Click(sender As Object, e As EventArgs) Handles pb12.Click

    End Sub

    Private binary As Byte


    Private Sub Form1_Load(sender As Object, ev As EventArgs) Handles MyBase.Load
        Timer1.Interval = TimeSpan.FromSeconds(1).TotalMilliseconds
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, ev As EventArgs) Handles Timer1.Tick
        binary = time

        A = CBool(binary >= 8)
        If A Then
            binary -= 8
        End If

        B = CBool(binary >= 4)
        If B Then
            binary -= 4
        End If

        C = CBool(binary >= 2)
        If C Then
            binary -= 2
        End If

        D = CBool(binary >= 1)
        If D Then
            binary -= 1
        End If

        IsOn(CBool((C And (Not B Or D)) Or (B And Not C)), pb1)

        IsOn(CBool(C Or A Or Not (B Xor D)), pb2)

        IsOn(CBool(Not B Or D Or C), pb3)

        IsOn(CBool(C Or A Or Not (B Xor D)), pb4)

        IsOn(B, pb5)

        IsOn(CBool(A Or (Not C And Not D) Or (B And (Not C Or Not D))), pb6)

        IsOn(CBool(Not A And Not B And Not C And D), pb7)

        IsOn(CBool(Not A And Not B And Not C And D), pb8)

        IsOn(CBool(Not A And Not B And Not C And Not D), pb9)

        IsOn(CBool(A Or (Not B And Not D) Or Not (C Xor D)), pb10)

        IsOn(CBool((Not A And Not B And Not C And Not D) Or (B And (C Xor D))), pb11)

        IsOn(CBool(A Or (C And Not D) Or (B And Not C)), pb12)

        IsOn(CBool(Not B Or Not C Or Not D), pb13)

        IsOn(CBool(A Or B Or C), pb14)

        IsOn(CBool((Not A And Not C And Not D) Or (A And D)), pb15)

        IsOn(CBool(Not D And (Not B Or C)), pb16)

        IsOn(CBool(Not A And Not B And Not C And Not D), pb17)

        IsOn(CBool(Not A And Not B And Not C And D), pb18)

        IsOn(CBool(D And B And C), pb19)

        IsOn(CBool(A Or (Not C And Not D) Or (Not B And C And D) Or (B And (Not C Or Not D))), pb20)

        IsOn(CBool((Not B And C) Or (B And Not C And D)), pb21)

        IsOn(CBool((Not D And (Not B Or C)) Or (Not A And (Not B Or (Not C And D)))), pb22)

        IsOn(CBool(Not B Or (C Xor D)), pb23)

        IsOn(CBool(Not B Or C Or D), pb24)

        IsOn(CBool(Not D And (B Xor C)), pb25)


        If time = 9 Then
            time = 0
        Else
            time += 1
        End If
    End Sub

    Private Sub IsOn(x As Boolean, pb As PictureBox)
        Console.WriteLine(x)
        Console.WriteLine(pb)

        If x Then
            pb.Image = My.Resources.red_circle
        Else
            pb.Image = My.Resources.grey_circle
        End If
    End Sub

End Class
