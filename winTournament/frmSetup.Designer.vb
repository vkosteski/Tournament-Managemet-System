﻿Imports System.Windows.Forms.AxHost

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSetup
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub
    ' ======= BUTTON STYLING FUNCTION (Tesla SpaceX Glow) =======
    Private Sub StyleButton(btn As Button, text As String, x As Integer, y As Integer, Optional width As Integer = 50, Optional height As Integer = 30)
        btn.Text = text
        btn.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        btn.BackColor = Color.FromArgb(45, 45, 45) ' Dark gray buttons
        btn.ForeColor = Color.White
        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 130, 180) ' Hover effect
        btn.Size = New Size(width, height)
        btn.TextAlign = ContentAlignment.MiddleCenter
        btn.Location = New Point(x, y)
    End Sub
    Private Sub StyleButton2(btn As Button, text As String, x As Integer, y As Integer, Optional width As Integer = 80, Optional height As Integer = 30)
        btn.Text = text
        btn.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        btn.BackColor = Color.FromArgb(45, 45, 45) ' Dark gray buttons
        btn.ForeColor = Color.White
        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 130, 180) ' Hover effect
        btn.Size = New Size(width, height)
        btn.TextAlign = ContentAlignment.MiddleCenter
        btn.Location = New Point(x, y)
    End Sub
    Private Sub StyleButton3(btn As Button, text As String, x As Integer, y As Integer, Optional width As Integer = 80, Optional height As Integer = 30)
        btn.Text = text
        btn.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        btn.BackColor = Color.FromArgb(45, 45, 45) ' Dark gray buttons
        btn.ForeColor = Color.White
        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 130, 180) ' Hover effect
        btn.Size = New Size(width, height)
        btn.TextAlign = ContentAlignment.MiddleCenter
        btn.Location = New Point(x, y)
    End Sub
    Private Sub StyleCheckbox(chk As CheckBox, text As String, x As Integer, y As Integer)
        chk.Text = text
        chk.Font = New Font("Segoe UI", 10, FontStyle.Regular)
        chk.ForeColor = Color.White
        chk.BackColor = Color.Transparent
        chk.FlatStyle = FlatStyle.Flat
        chk.FlatAppearance.CheckedBackColor = Color.FromArgb(70, 130, 180) ' Highlight when checked
        chk.Location = New Point(x, y)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSetup))
        Me.listDisplayEvent = New System.Windows.Forms.ListBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnFinish = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblIndEvents = New System.Windows.Forms.Label()
        Me.lblTeamEvents = New System.Windows.Forms.Label()
        Me.lblIndSoFar = New System.Windows.Forms.Label()
        Me.lblTeamSoFar = New System.Windows.Forms.Label()
        Me.rdoTeam = New System.Windows.Forms.RadioButton()
        Me.rdoInd = New System.Windows.Forms.RadioButton()
        Me.lblIndEventsNum = New System.Windows.Forms.Label()
        Me.lblTeamEventsNum = New System.Windows.Forms.Label()
        Me.lblIndSoFarNum = New System.Windows.Forms.Label()
        Me.lblTeamSoFarNum = New System.Windows.Forms.Label()
        Me.tab1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.lblSelectiveEvents = New System.Windows.Forms.Label()
        Me.eventscombo = New System.Windows.Forms.ComboBox()
        Me.customcheckbox = New System.Windows.Forms.CheckBox()
        Me.selectedcheckbox = New System.Windows.Forms.CheckBox()
        Me.tab2 = New System.Windows.Forms.TabPage()
        Me.txtTeamMem5 = New System.Windows.Forms.TextBox()
        Me.txtTeamMem4 = New System.Windows.Forms.TextBox()
        Me.txtTeamMem3 = New System.Windows.Forms.TextBox()
        Me.txtTeamMem2 = New System.Windows.Forms.TextBox()
        Me.txtTeamMem1 = New System.Windows.Forms.TextBox()
        Me.lblTeamMembers = New System.Windows.Forms.Label()
        Me.ListDisplayPar = New System.Windows.Forms.ListBox()
        Me.rdoIndPar = New System.Windows.Forms.RadioButton()
        Me.rdoTeamPar = New System.Windows.Forms.RadioButton()
        Me.btnAddPar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtParName = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.tab1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.tab2.SuspendLayout()
        Me.SuspendLayout()

        Try
            Me.BackgroundImage = My.Resources.background3 ' Use the name you gave in Resources
            Me.BackgroundImageLayout = ImageLayout.Stretch ' Stretch to fit window
        Catch ex As Exception
            MessageBox.Show("Error loading background image: " & ex.Message, "Image Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


        '
        'listDisplayEvent
        '
        Me.listDisplayEvent.FormattingEnabled = True
        Me.listDisplayEvent.ItemHeight = 15
        Me.listDisplayEvent.Location = New System.Drawing.Point(335, 6)
        Me.listDisplayEvent.Name = "listDisplayEvent"
        Me.listDisplayEvent.Size = New System.Drawing.Size(190, 124)
        Me.listDisplayEvent.TabIndex = 7
        '
        'btnAdd
        '

        StyleButton(Me.btnAdd, "Add", 223, 93)


        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.Location = New System.Drawing.Point(20, 69)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(75, 16)
        Me.lblDescription.TabIndex = 3
        Me.lblDescription.Text = "Description"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(45, 41)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(44, 16)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "Name"
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(96, 67)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(127, 21)
        Me.txtDescription.TabIndex = 1
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(96, 41)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(127, 21)
        Me.txtName.TabIndex = 0
        '
        'btnFinish
        '
        StyleButton2(Me.btnFinish, "Finish", 632, 415)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White ' White text for dark theme
        Me.Label3.BackColor = System.Drawing.Color.Transparent ' Ensure it blends with dark background
        Me.Label3.Location = New System.Drawing.Point(69, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(160, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Tournament Setup"

        '
        'lblIndEvents
        '
        ' lblIndEvents
        Me.lblIndEvents.AutoSize = True
        Me.lblIndEvents.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIndEvents.ForeColor = System.Drawing.Color.White
        Me.lblIndEvents.BackColor = System.Drawing.Color.Transparent
        Me.lblIndEvents.Location = New System.Drawing.Point(495, 53)
        Me.lblIndEvents.Name = "lblIndEvents"
        Me.lblIndEvents.Size = New System.Drawing.Size(183, 19)
        Me.lblIndEvents.TabIndex = 11
        Me.lblIndEvents.Text = "Individual Events Happened"

        ' lblTeamEvents
        Me.lblTeamEvents.AutoSize = True
        Me.lblTeamEvents.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeamEvents.ForeColor = System.Drawing.Color.White
        Me.lblTeamEvents.BackColor = System.Drawing.Color.Transparent
        Me.lblTeamEvents.Location = New System.Drawing.Point(518, 76)
        Me.lblTeamEvents.Name = "lblTeamEvents"
        Me.lblTeamEvents.Size = New System.Drawing.Size(155, 19)
        Me.lblTeamEvents.TabIndex = 12
        Me.lblTeamEvents.Text = "Team Events Happened"

        ' lblIndSoFar
        Me.lblIndSoFar.AutoSize = True
        Me.lblIndSoFar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIndSoFar.ForeColor = System.Drawing.Color.White
        Me.lblIndSoFar.BackColor = System.Drawing.Color.Transparent
        Me.lblIndSoFar.Location = New System.Drawing.Point(555, 99)
        Me.lblIndSoFar.Name = "lblIndSoFar"
        Me.lblIndSoFar.Size = New System.Drawing.Size(107, 19)
        Me.lblIndSoFar.TabIndex = 13
        Me.lblIndSoFar.Text = "Individuals so far"

        ' lblTeamSoFar
        Me.lblTeamSoFar.AutoSize = True
        Me.lblTeamSoFar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeamSoFar.ForeColor = System.Drawing.Color.White
        Me.lblTeamSoFar.BackColor = System.Drawing.Color.Transparent
        Me.lblTeamSoFar.Location = New System.Drawing.Point(573, 122)
        Me.lblTeamSoFar.Name = "lblTeamSoFar"
        Me.lblTeamSoFar.Size = New System.Drawing.Size(86, 19)
        Me.lblTeamSoFar.TabIndex = 14
        Me.lblTeamSoFar.Text = "Teams so far"

        ' rdoTeam
        Me.rdoTeam.AutoSize = True
        Me.rdoTeam.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoTeam.ForeColor = System.Drawing.Color.White
        Me.rdoTeam.BackColor = System.Drawing.Color.Transparent
        Me.rdoTeam.Location = New System.Drawing.Point(33, 119)
        Me.rdoTeam.Name = "rdoTeam"
        Me.rdoTeam.Size = New System.Drawing.Size(63, 23)
        Me.rdoTeam.TabIndex = 16
        Me.rdoTeam.Text = "Team"
        Me.rdoTeam.UseVisualStyleBackColor = False

        ' rdoInd
        Me.rdoInd.AutoSize = True
        Me.rdoInd.Checked = True
        Me.rdoInd.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoInd.ForeColor = System.Drawing.Color.White
        Me.rdoInd.BackColor = System.Drawing.Color.Transparent
        Me.rdoInd.Location = New System.Drawing.Point(33, 142)
        Me.rdoInd.Name = "rdoInd"
        Me.rdoInd.Size = New System.Drawing.Size(91, 23)
        Me.rdoInd.TabIndex = 17
        Me.rdoInd.TabStop = True
        Me.rdoInd.Text = "Individual"
        Me.rdoInd.UseVisualStyleBackColor = False

        ' lblIndEventsNum
        Me.lblIndEventsNum.AutoSize = True
        Me.lblIndEventsNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIndEventsNum.ForeColor = System.Drawing.Color.White ' Set font color to white
        Me.lblIndEventsNum.BackColor = System.Drawing.Color.Transparent ' Make background transparent
        Me.lblIndEventsNum.Location = New System.Drawing.Point(685, 53)
        Me.lblIndEventsNum.Name = "lblIndEventsNum"
        Me.lblIndEventsNum.Size = New System.Drawing.Size(0, 16)
        Me.lblIndEventsNum.TabIndex = 18

        ' lblTeamEventsNum
        Me.lblTeamEventsNum.AutoSize = True
        Me.lblTeamEventsNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeamEventsNum.ForeColor = System.Drawing.Color.White ' Set font color to white
        Me.lblTeamEventsNum.BackColor = System.Drawing.Color.Transparent ' Make background transparent
        Me.lblTeamEventsNum.Location = New System.Drawing.Point(685, 76)
        Me.lblTeamEventsNum.Name = "lblTeamEventsNum"
        Me.lblTeamEventsNum.Size = New System.Drawing.Size(0, 16)
        Me.lblTeamEventsNum.TabIndex = 19

        ' lblIndSoFarNum
        Me.lblIndSoFarNum.AutoSize = True
        Me.lblIndSoFarNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIndSoFarNum.ForeColor = System.Drawing.Color.White ' Set font color to white
        Me.lblIndSoFarNum.BackColor = System.Drawing.Color.Transparent ' Make background transparent
        Me.lblIndSoFarNum.Location = New System.Drawing.Point(685, 101)
        Me.lblIndSoFarNum.Name = "lblIndSoFarNum"
        Me.lblIndSoFarNum.Size = New System.Drawing.Size(0, 16)
        Me.lblIndSoFarNum.TabIndex = 20

        ' lblTeamSoFarNum
        Me.lblTeamSoFarNum.AutoSize = True
        Me.lblTeamSoFarNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeamSoFarNum.ForeColor = System.Drawing.Color.White ' Set font color to white
        Me.lblTeamSoFarNum.BackColor = System.Drawing.Color.Transparent ' Make background transparent
        Me.lblTeamSoFarNum.Location = New System.Drawing.Point(685, 125)
        Me.lblTeamSoFarNum.Name = "lblTeamSoFarNum"
        Me.lblTeamSoFarNum.Size = New System.Drawing.Size(0, 16)
        Me.lblTeamSoFarNum.TabIndex = 21

        '
        'tab1
        '
        Me.tab1.Controls.Add(Me.TabPage2)
        Me.tab1.Controls.Add(Me.tab2)
        Me.tab1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab1.Location = New System.Drawing.Point(45, 230)
        Me.tab1.Name = "tab1"
        Me.tab1.SelectedIndex = 0
        Me.tab1.Size = New System.Drawing.Size(567, 208)
        Me.tab1.TabIndex = 22
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(30, 30, 30) ' Dark background
        Me.TabPage2.ForeColor = System.Drawing.Color.White ' White text        Me.TabPage2.Controls.Add(Me.lblSelectiveEvents)
        Me.TabPage2.Controls.Add(Me.eventscombo)
        Me.TabPage2.Controls.Add(Me.customcheckbox)
        Me.TabPage2.Controls.Add(Me.selectedcheckbox)
        Me.TabPage2.Controls.Add(Me.rdoInd)
        Me.TabPage2.Controls.Add(Me.listDisplayEvent)
        Me.TabPage2.Controls.Add(Me.txtName)
        Me.TabPage2.Controls.Add(Me.rdoTeam)
        Me.TabPage2.Controls.Add(Me.txtDescription)
        Me.TabPage2.Controls.Add(Me.lblName)
        Me.TabPage2.Controls.Add(Me.lblDescription)
        Me.TabPage2.Controls.Add(Me.btnAdd)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(559, 180)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Event Details"
        '
        'lblSelectiveEvents
        '
        Me.lblSelectiveEvents.AutoSize = True
        Me.lblSelectiveEvents.Location = New System.Drawing.Point(107, 9)
        Me.lblSelectiveEvents.Name = "lblSelectiveEvents"
        Me.lblSelectiveEvents.Size = New System.Drawing.Size(95, 15)
        Me.lblSelectiveEvents.TabIndex = 23
        Me.lblSelectiveEvents.Text = "Selective Events"
        '
        'eventscombo
        '
        Me.eventscombo.FormattingEnabled = True
        Me.eventscombo.Items.AddRange(New Object() {"Dancing", "Acrobatics", "Bridge", "Scrabble", "Volleyball", "Solo Dancing", "Solo Acrobatics", "Space invaders", "Spelling"})
        Me.eventscombo.Location = New System.Drawing.Point(208, 6)
        Me.eventscombo.Name = "eventscombo"
        Me.eventscombo.Size = New System.Drawing.Size(121, 23)
        Me.eventscombo.TabIndex = 22

        ' customcheckbox
        Me.customcheckbox.AutoSize = True
        Me.customcheckbox.Checked = True
        Me.customcheckbox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.customcheckbox.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.customcheckbox.ForeColor = System.Drawing.Color.White
        Me.customcheckbox.BackColor = System.Drawing.Color.Transparent
        Me.customcheckbox.Location = New System.Drawing.Point(223, 155)
        Me.customcheckbox.Name = "customcheckbox"
        Me.customcheckbox.Size = New System.Drawing.Size(80, 23)
        Me.customcheckbox.TabIndex = 21
        Me.customcheckbox.Text = "Custom"
        Me.customcheckbox.UseVisualStyleBackColor = False

        ' selectedcheckbox
        Me.selectedcheckbox.AutoSize = True
        Me.selectedcheckbox.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.selectedcheckbox.ForeColor = System.Drawing.Color.White
        Me.selectedcheckbox.BackColor = System.Drawing.Color.Transparent
        Me.selectedcheckbox.Location = New System.Drawing.Point(223, 131)
        Me.selectedcheckbox.Name = "selectedcheckbox"
        Me.selectedcheckbox.Size = New System.Drawing.Size(86, 23)
        Me.selectedcheckbox.TabIndex = 20
        Me.selectedcheckbox.Text = "Selected"
        Me.selectedcheckbox.UseVisualStyleBackColor = False

        'tab2
        '
        Me.tab2.AllowDrop = True
        Me.tab2.BackColor = System.Drawing.Color.FromArgb(30, 30, 30) ' Dark background
        Me.tab2.ForeColor = System.Drawing.Color.White ' White text      
        Me.tab2.Controls.Add(Me.txtTeamMem5)
        Me.tab2.Controls.Add(Me.txtTeamMem4)
        Me.tab2.Controls.Add(Me.txtTeamMem3)
        Me.tab2.Controls.Add(Me.txtTeamMem2)
        Me.tab2.Controls.Add(Me.txtTeamMem1)
        Me.tab2.Controls.Add(Me.lblTeamMembers)
        Me.tab2.Controls.Add(Me.ListDisplayPar)
        Me.tab2.Controls.Add(Me.rdoIndPar)
        Me.tab2.Controls.Add(Me.rdoTeamPar)
        Me.tab2.Controls.Add(Me.btnAddPar)
        Me.tab2.Controls.Add(Me.Label2)
        Me.tab2.Controls.Add(Me.txtParName)
        Me.tab2.Location = New System.Drawing.Point(4, 24)
        Me.tab2.Name = "tab2"
        Me.tab2.Padding = New System.Windows.Forms.Padding(3)
        Me.tab2.Size = New System.Drawing.Size(559, 180)
        Me.tab2.TabIndex = 0
        Me.tab2.Text = "Participant Details"
        '
        'txtTeamMem5
        '
        Me.txtTeamMem5.Location = New System.Drawing.Point(174, 140)
        Me.txtTeamMem5.Name = "txtTeamMem5"
        Me.txtTeamMem5.Size = New System.Drawing.Size(100, 21)
        Me.txtTeamMem5.TabIndex = 25
        '
        'txtTeamMem4
        '
        Me.txtTeamMem4.Location = New System.Drawing.Point(174, 113)
        Me.txtTeamMem4.Name = "txtTeamMem4"
        Me.txtTeamMem4.Size = New System.Drawing.Size(100, 21)
        Me.txtTeamMem4.TabIndex = 24
        '
        'txtTeamMem3
        '
        Me.txtTeamMem3.Location = New System.Drawing.Point(174, 86)
        Me.txtTeamMem3.Name = "txtTeamMem3"
        Me.txtTeamMem3.Size = New System.Drawing.Size(100, 21)
        Me.txtTeamMem3.TabIndex = 23
        '
        'txtTeamMem2
        '
        Me.txtTeamMem2.Location = New System.Drawing.Point(174, 59)
        Me.txtTeamMem2.Name = "txtTeamMem2"
        Me.txtTeamMem2.Size = New System.Drawing.Size(100, 21)
        Me.txtTeamMem2.TabIndex = 22
        '
        'txtTeamMem1
        '
        Me.txtTeamMem1.Location = New System.Drawing.Point(173, 31)
        Me.txtTeamMem1.Name = "txtTeamMem1"
        Me.txtTeamMem1.Size = New System.Drawing.Size(100, 21)
        Me.txtTeamMem1.TabIndex = 21
        '
        'lblTeamMembers
        '
        Me.lblTeamMembers.AutoSize = True
        Me.lblTeamMembers.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeamMembers.Location = New System.Drawing.Point(171, 12)
        Me.lblTeamMembers.Name = "lblTeamMembers"
        Me.lblTeamMembers.Size = New System.Drawing.Size(103, 16)
        Me.lblTeamMembers.TabIndex = 20
        Me.lblTeamMembers.Text = "Team Members"
        '
        'ListDisplayPar
        '
        Me.ListDisplayPar.FormattingEnabled = True
        Me.ListDisplayPar.ItemHeight = 15
        Me.ListDisplayPar.Location = New System.Drawing.Point(322, 12)
        Me.ListDisplayPar.Name = "ListDisplayPar"
        Me.ListDisplayPar.Size = New System.Drawing.Size(190, 124)
        Me.ListDisplayPar.TabIndex = 19
        '
        'rdoIndPar
        '
        Me.rdoIndPar.AutoSize = True
        Me.rdoIndPar.Checked = True
        Me.rdoIndPar.Location = New System.Drawing.Point(23, 145)
        Me.rdoIndPar.Name = "rdoIndPar"
        Me.rdoIndPar.Size = New System.Drawing.Size(77, 19)
        Me.rdoIndPar.TabIndex = 18
        Me.rdoIndPar.TabStop = True
        Me.rdoIndPar.Text = "Individual"
        Me.rdoInd.ForeColor = System.Drawing.Color.White
        Me.rdoTeam.ForeColor = System.Drawing.Color.White
        Me.rdoIndPar.UseVisualStyleBackColor = True
        '
        'rdoTeamPar
        '
        Me.rdoTeamPar.AutoSize = True
        Me.rdoTeamPar.Location = New System.Drawing.Point(23, 122)
        Me.rdoTeamPar.Name = "rdoTeamPar"
        Me.rdoTeamPar.Size = New System.Drawing.Size(57, 19)
        Me.rdoTeamPar.TabIndex = 17
        Me.rdoTeamPar.Text = "Team"
        Me.rdoTeamPar.UseVisualStyleBackColor = True
        '
        'btnAddPar
        '
        StyleButton(Me.btnAddPar, "Add", 9, 53)

        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Name"
        '
        'txtParName
        '
        Me.txtParName.Location = New System.Drawing.Point(9, 31)
        Me.txtParName.Name = "txtParName"
        Me.txtParName.Size = New System.Drawing.Size(100, 21)
        Me.txtParName.TabIndex = 0
        '

        'btnExit
        StyleButton3(Me.btnExit, "Exit", 713, 415)
        '

        '
        'frmSetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.tab1)
        Me.Controls.Add(Me.lblTeamSoFarNum)
        Me.Controls.Add(Me.lblIndSoFarNum)
        Me.Controls.Add(Me.lblTeamEventsNum)
        Me.Controls.Add(Me.lblIndEventsNum)
        Me.Controls.Add(Me.lblTeamSoFar)
        Me.Controls.Add(Me.lblIndSoFar)
        Me.Controls.Add(Me.lblTeamEvents)
        Me.Controls.Add(Me.lblIndEvents)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnFinish)
        Me.Icon = New Icon("C:\Users\jacka\Downloads\icon.ico")
        Me.Name = "frmSetup"
        Me.Text = "Start New Tournament"
        Me.tab1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.tab2.ResumeLayout(False)
        Me.tab2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents listDisplayEvent As ListBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents lblDescription As Label
    Friend WithEvents lblName As Label
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnFinish As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lblIndEvents As Label
    Friend WithEvents lblTeamEvents As Label
    Friend WithEvents lblIndSoFar As Label
    Friend WithEvents lblTeamSoFar As Label
    Friend WithEvents rdoInd As RadioButton
    Friend WithEvents rdoTeam As RadioButton
    Friend WithEvents lblIndEventsNum As Label
    Friend WithEvents lblTeamEventsNum As Label
    Friend WithEvents lblIndSoFarNum As Label
    Friend WithEvents lblTeamSoFarNum As Label
    Friend WithEvents tab1 As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents tab2 As TabPage
    Friend WithEvents Label2 As Label
    Friend WithEvents txtParName As TextBox
    Friend WithEvents ListDisplayPar As ListBox
    Friend WithEvents rdoIndPar As RadioButton
    Friend WithEvents rdoTeamPar As RadioButton
    Friend WithEvents btnAddPar As Button
    Friend WithEvents txtTeamMem5 As TextBox
    Friend WithEvents txtTeamMem4 As TextBox
    Friend WithEvents txtTeamMem3 As TextBox
    Friend WithEvents txtTeamMem2 As TextBox
    Friend WithEvents txtTeamMem1 As TextBox
    Friend WithEvents lblTeamMembers As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents eventscombo As ComboBox
    Friend WithEvents customcheckbox As CheckBox
    Friend WithEvents selectedcheckbox As CheckBox
    Friend WithEvents lblSelectiveEvents As Label
End Class
