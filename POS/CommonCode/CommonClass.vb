﻿Imports System.Data.SqlClient
Imports System.IO
Module CommonClass
    'Public Function GetConnectionStringFromFile() As String
    '    Dim filePath As String = "connectionString.txt"
    '    If File.Exists(filePath) Then
    '        Return File.ReadAllText(filePath).Trim()
    '    Else
    '        MessageBox.Show("Configuration file not found. Please create or specify the file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        Return My.Settings.pos_dbConnectionString
    '    End If
    'End Function

    Public user_login As String
    Public user_type As String
    Public connection = My.Settings.pos_dbConnectionString
    'Public connection = GetConnectionStringFromFile()
    Dim result As Integer

    'Public StoreName = "Vincent Jade Alivio Production"
    'Public StoreNameColor = Color.DodgerBlue
    'Public SloganColor = Color.DodgerBlue
    'Public PanelRightColor = Color.DodgerBlue
    'Public Slogan = "Fix before Up"
    'Public LogoPictureBoxPic = My.Resources._1

    Public storeTheme As String

    Public Sub CommonQuery(query, DataGridView)
        Try
            Dim conn As SqlConnection = New SqlConnection(connection)
            Dim cmd As SqlCommand = New SqlCommand(query, conn)
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            Dim dt As New DataTable
            da.Fill(dt)
            DataGridView.DataSource = dt
        Catch ex As Exception
            MsgBox("Something went wrong!" + ex.Message.ToString(), MsgBoxStyle.Critical)
            Return
        End Try
    End Sub
    Public Function GetLastRow(table As String, column As String) As Int32

        Dim last_row = ""
        Dim query As String = "SELECT TOP 1 " + column + " FROM " + table + " ORDER BY " + column + " DESC"
        Dim conn As SqlConnection = New SqlConnection(connection)
        Dim cmd As SqlCommand = New SqlCommand(query, conn)
        Dim da As New SqlDataAdapter
        da.SelectCommand = cmd
        Dim dt As New DataTable
        da.Fill(dt)
        Try
            If dt.Rows.Count > 0 Then
                last_row = Int32.Parse(dt.Rows(0)("" + column + "").ToString()) + 1
            Else
                last_row = 1
            End If
        Catch ex As Exception
            last_row = 1
        End Try
        Return last_row
    End Function
End Module
