Imports System
Module Program
    Sub Main(args As String())
        Console.WriteLine("� ���� ���������� ���������� � ����� � ���������. ������ ����� � �����������")
        Dim dis As Integer
        Dim sm As Integer
        Dim dm As Integer
        Dim metr As Integer
        r
        dis = Console.ReadLine
        metr = dis \ 100
        dm = (dis - metr * 100)
        sm = dis Mod 100

        Console.WriteLine("����������" & dis & " = " & metr & "metr" & sm & " sm = " & dis \ 10 & " dm " & sm Mod 10 & " sm = " & metr & " metr " & dm \ 10 & " dm " & sm Mod 10 & " sm ")
    End Sub
End Module
