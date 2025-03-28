<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateRecordPage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        GroupDeworm = New GroupBox()
        RbtnNoDeworm = New RadioButton()
        RbtnYesDeworm = New RadioButton()
        GroupVaccines = New GroupBox()
        RbtnNoVac = New RadioButton()
        RbtnYesVac = New RadioButton()
        GroupSurgery = New GroupBox()
        RbtnNo = New RadioButton()
        RbtnYes = New RadioButton()
        GroupType = New GroupBox()
        RbtnCat = New RadioButton()
        RbtnDog = New RadioButton()
        GroupSex = New GroupBox()
        RbtnMale = New RadioButton()
        RbtnFemale = New RadioButton()
        TxtColor = New TextBox()
        TxtBreed = New TextBox()
        CheckedSurgery = New CheckedListBox()
        CheckedDeworming = New CheckedListBox()
        CheckedVaccine = New CheckedListBox()
        Label11 = New Label()
        Label10 = New Label()
        TxtPetIDNo = New TextBox()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        DpBirthday = New DateTimePicker()
        TxtName = New TextBox()
        Btnback = New Button()
        BtnSubmit = New Button()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        BtnUploadPet = New Button()
        PicBoxPet = New PictureBox()
        GroupDeworm.SuspendLayout()
        GroupVaccines.SuspendLayout()
        GroupSurgery.SuspendLayout()
        GroupType.SuspendLayout()
        GroupSex.SuspendLayout()
        CType(PicBoxPet, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupDeworm
        ' 
        GroupDeworm.Controls.Add(RbtnNoDeworm)
        GroupDeworm.Controls.Add(RbtnYesDeworm)
        GroupDeworm.Location = New Point(922, 670)
        GroupDeworm.Name = "GroupDeworm"
        GroupDeworm.Size = New Size(250, 125)
        GroupDeworm.TabIndex = 67
        GroupDeworm.TabStop = False
        ' 
        ' RbtnNoDeworm
        ' 
        RbtnNoDeworm.AutoSize = True
        RbtnNoDeworm.Location = New Point(18, 57)
        RbtnNoDeworm.Name = "RbtnNoDeworm"
        RbtnNoDeworm.Size = New Size(50, 24)
        RbtnNoDeworm.TabIndex = 41
        RbtnNoDeworm.TabStop = True
        RbtnNoDeworm.Text = "No"
        RbtnNoDeworm.UseVisualStyleBackColor = True
        ' 
        ' RbtnYesDeworm
        ' 
        RbtnYesDeworm.AutoSize = True
        RbtnYesDeworm.Location = New Point(14, 26)
        RbtnYesDeworm.Name = "RbtnYesDeworm"
        RbtnYesDeworm.Size = New Size(51, 24)
        RbtnYesDeworm.TabIndex = 0
        RbtnYesDeworm.TabStop = True
        RbtnYesDeworm.Text = "Yes"
        RbtnYesDeworm.UseVisualStyleBackColor = True
        ' 
        ' GroupVaccines
        ' 
        GroupVaccines.Controls.Add(RbtnNoVac)
        GroupVaccines.Controls.Add(RbtnYesVac)
        GroupVaccines.Location = New Point(922, 510)
        GroupVaccines.Name = "GroupVaccines"
        GroupVaccines.Size = New Size(250, 125)
        GroupVaccines.TabIndex = 66
        GroupVaccines.TabStop = False
        ' 
        ' RbtnNoVac
        ' 
        RbtnNoVac.AutoSize = True
        RbtnNoVac.Location = New Point(18, 69)
        RbtnNoVac.Name = "RbtnNoVac"
        RbtnNoVac.Size = New Size(50, 24)
        RbtnNoVac.TabIndex = 1
        RbtnNoVac.TabStop = True
        RbtnNoVac.Text = "No"
        RbtnNoVac.UseVisualStyleBackColor = True
        ' 
        ' RbtnYesVac
        ' 
        RbtnYesVac.AutoSize = True
        RbtnYesVac.Location = New Point(18, 28)
        RbtnYesVac.Name = "RbtnYesVac"
        RbtnYesVac.Size = New Size(51, 24)
        RbtnYesVac.TabIndex = 0
        RbtnYesVac.TabStop = True
        RbtnYesVac.Text = "Yes"
        RbtnYesVac.UseVisualStyleBackColor = True
        ' 
        ' GroupSurgery
        ' 
        GroupSurgery.Controls.Add(RbtnNo)
        GroupSurgery.Controls.Add(RbtnYes)
        GroupSurgery.Location = New Point(922, 293)
        GroupSurgery.Name = "GroupSurgery"
        GroupSurgery.Size = New Size(250, 125)
        GroupSurgery.TabIndex = 65
        GroupSurgery.TabStop = False
        ' 
        ' RbtnNo
        ' 
        RbtnNo.AutoSize = True
        RbtnNo.Location = New Point(11, 68)
        RbtnNo.Name = "RbtnNo"
        RbtnNo.Size = New Size(50, 24)
        RbtnNo.TabIndex = 1
        RbtnNo.TabStop = True
        RbtnNo.Text = "No"
        RbtnNo.UseVisualStyleBackColor = True
        ' 
        ' RbtnYes
        ' 
        RbtnYes.AutoSize = True
        RbtnYes.Location = New Point(14, 26)
        RbtnYes.Name = "RbtnYes"
        RbtnYes.Size = New Size(51, 24)
        RbtnYes.TabIndex = 0
        RbtnYes.TabStop = True
        RbtnYes.Text = "Yes"
        RbtnYes.UseVisualStyleBackColor = True
        ' 
        ' GroupType
        ' 
        GroupType.BackColor = Color.Transparent
        GroupType.Controls.Add(RbtnCat)
        GroupType.Controls.Add(RbtnDog)
        GroupType.Location = New Point(334, 494)
        GroupType.Name = "GroupType"
        GroupType.Size = New Size(250, 125)
        GroupType.TabIndex = 42
        GroupType.TabStop = False
        ' 
        ' RbtnCat
        ' 
        RbtnCat.AutoSize = True
        RbtnCat.Font = New Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RbtnCat.Location = New Point(17, 70)
        RbtnCat.Name = "RbtnCat"
        RbtnCat.Size = New Size(98, 48)
        RbtnCat.TabIndex = 1
        RbtnCat.TabStop = True
        RbtnCat.Text = "Cat"
        RbtnCat.UseVisualStyleBackColor = True
        ' 
        ' RbtnDog
        ' 
        RbtnDog.AutoSize = True
        RbtnDog.Font = New Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RbtnDog.Location = New Point(17, 16)
        RbtnDog.Name = "RbtnDog"
        RbtnDog.Size = New Size(109, 48)
        RbtnDog.TabIndex = 0
        RbtnDog.TabStop = True
        RbtnDog.Text = "Dog"
        RbtnDog.UseVisualStyleBackColor = True
        ' 
        ' GroupSex
        ' 
        GroupSex.BackColor = Color.Transparent
        GroupSex.Controls.Add(RbtnMale)
        GroupSex.Controls.Add(RbtnFemale)
        GroupSex.FlatStyle = FlatStyle.Popup
        GroupSex.Location = New Point(334, 322)
        GroupSex.Name = "GroupSex"
        GroupSex.Size = New Size(180, 122)
        GroupSex.TabIndex = 64
        GroupSex.TabStop = False
        ' 
        ' RbtnMale
        ' 
        RbtnMale.AutoSize = True
        RbtnMale.Font = New Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RbtnMale.Location = New Point(17, 68)
        RbtnMale.Name = "RbtnMale"
        RbtnMale.Size = New Size(121, 48)
        RbtnMale.TabIndex = 1
        RbtnMale.TabStop = True
        RbtnMale.Text = "Male"
        RbtnMale.UseVisualStyleBackColor = True
        ' 
        ' RbtnFemale
        ' 
        RbtnFemale.AutoSize = True
        RbtnFemale.Font = New Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RbtnFemale.Location = New Point(17, 15)
        RbtnFemale.Name = "RbtnFemale"
        RbtnFemale.Size = New Size(165, 48)
        RbtnFemale.TabIndex = 0
        RbtnFemale.TabStop = True
        RbtnFemale.Text = "Female"
        RbtnFemale.UseVisualStyleBackColor = True
        ' 
        ' TxtColor
        ' 
        TxtColor.BackColor = Color.YellowGreen
        TxtColor.BorderStyle = BorderStyle.FixedSingle
        TxtColor.Font = New Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TxtColor.Location = New Point(329, 714)
        TxtColor.Name = "TxtColor"
        TxtColor.Size = New Size(383, 54)
        TxtColor.TabIndex = 63
        ' 
        ' TxtBreed
        ' 
        TxtBreed.BackColor = Color.YellowGreen
        TxtBreed.BorderStyle = BorderStyle.FixedSingle
        TxtBreed.Font = New Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TxtBreed.Location = New Point(329, 629)
        TxtBreed.Name = "TxtBreed"
        TxtBreed.Size = New Size(383, 54)
        TxtBreed.TabIndex = 62
        ' 
        ' CheckedSurgery
        ' 
        CheckedSurgery.FormattingEnabled = True
        CheckedSurgery.Location = New Point(1178, 304)
        CheckedSurgery.Name = "CheckedSurgery"
        CheckedSurgery.Size = New Size(150, 114)
        CheckedSurgery.TabIndex = 61
        ' 
        ' CheckedDeworming
        ' 
        CheckedDeworming.FormattingEnabled = True
        CheckedDeworming.Location = New Point(1178, 681)
        CheckedDeworming.Name = "CheckedDeworming"
        CheckedDeworming.Size = New Size(150, 114)
        CheckedDeworming.TabIndex = 60
        ' 
        ' CheckedVaccine
        ' 
        CheckedVaccine.FormattingEnabled = True
        CheckedVaccine.Location = New Point(1178, 515)
        CheckedVaccine.Name = "CheckedVaccine"
        CheckedVaccine.Size = New Size(150, 114)
        CheckedVaccine.TabIndex = 59
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(802, 681)
        Label11.Name = "Label11"
        Label11.Size = New Size(90, 20)
        Label11.TabIndex = 58
        Label11.Text = "Deworming:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(817, 536)
        Label10.Name = "Label10"
        Label10.Size = New Size(68, 20)
        Label10.TabIndex = 57
        Label10.Text = "Vaccines:"
        ' 
        ' TxtPetIDNo
        ' 
        TxtPetIDNo.Location = New Point(932, 249)
        TxtPetIDNo.Name = "TxtPetIDNo"
        TxtPetIDNo.Size = New Size(125, 27)
        TxtPetIDNo.TabIndex = 56
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(773, 307)
        Label9.Name = "Label9"
        Label9.Size = New Size(119, 20)
        Label9.TabIndex = 55
        Label9.Text = "Medical Surgery:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(817, 256)
        Label8.Name = "Label8"
        Label8.Size = New Size(75, 20)
        Label8.TabIndex = 54
        Label8.Text = "Pet ID No:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Britannic Bold", 22.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        Label7.Location = New Point(114, 515)
        Label7.Name = "Label7"
        Label7.Size = New Size(209, 41)
        Label7.TabIndex = 53
        Label7.Text = "Type of Pet:"
        ' 
        ' DpBirthday
        ' 
        DpBirthday.CalendarFont = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DpBirthday.CalendarMonthBackground = Color.White
        DpBirthday.CalendarTitleBackColor = Color.White
        DpBirthday.Font = New Font("Arial Narrow", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DpBirthday.Location = New Point(334, 450)
        DpBirthday.Name = "DpBirthday"
        DpBirthday.Size = New Size(378, 38)
        DpBirthday.TabIndex = 52
        ' 
        ' TxtName
        ' 
        TxtName.BackColor = Color.YellowGreen
        TxtName.BorderStyle = BorderStyle.FixedSingle
        TxtName.Font = New Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TxtName.Location = New Point(334, 256)
        TxtName.Name = "TxtName"
        TxtName.Size = New Size(378, 54)
        TxtName.TabIndex = 51
        ' 
        ' Btnback
        ' 
        Btnback.Location = New Point(1606, 793)
        Btnback.Name = "Btnback"
        Btnback.Size = New Size(94, 29)
        Btnback.TabIndex = 50
        Btnback.Text = "Back"
        Btnback.UseVisualStyleBackColor = True
        ' 
        ' BtnSubmit
        ' 
        BtnSubmit.Location = New Point(1473, 793)
        BtnSubmit.Name = "BtnSubmit"
        BtnSubmit.Size = New Size(94, 29)
        BtnSubmit.TabIndex = 49
        BtnSubmit.Text = "Submit"
        BtnSubmit.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Britannic Bold", 22.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        Label6.Location = New Point(206, 727)
        Label6.Name = "Label6"
        Label6.Size = New Size(117, 41)
        Label6.TabIndex = 48
        Label6.Text = "Color:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Britannic Bold", 22.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        Label5.Location = New Point(199, 636)
        Label5.Name = "Label5"
        Label5.Size = New Size(124, 41)
        Label5.TabIndex = 47
        Label5.Text = "Breed:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Britannic Bold", 22.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        Label4.Location = New Point(155, 447)
        Label4.Name = "Label4"
        Label4.Size = New Size(168, 41)
        Label4.TabIndex = 46
        Label4.Text = "Birthday:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Britannic Bold", 22.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        Label3.Location = New Point(239, 333)
        Label3.Name = "Label3"
        Label3.Size = New Size(84, 41)
        Label3.TabIndex = 45
        Label3.Text = "Sex:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Britannic Bold", 22.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        Label2.Location = New Point(209, 263)
        Label2.Name = "Label2"
        Label2.Size = New Size(119, 41)
        Label2.TabIndex = 44
        Label2.Text = "Name:"
        ' 
        ' BtnUploadPet
        ' 
        BtnUploadPet.Location = New Point(1535, 550)
        BtnUploadPet.Name = "BtnUploadPet"
        BtnUploadPet.Size = New Size(189, 29)
        BtnUploadPet.TabIndex = 43
        BtnUploadPet.Text = "Upload Pet's Photo"
        BtnUploadPet.UseVisualStyleBackColor = True
        ' 
        ' PicBoxPet
        ' 
        PicBoxPet.Location = New Point(1453, 210)
        PicBoxPet.Name = "PicBoxPet"
        PicBoxPet.Size = New Size(335, 302)
        PicBoxPet.SizeMode = PictureBoxSizeMode.AutoSize
        PicBoxPet.TabIndex = 41
        PicBoxPet.TabStop = False
        ' 
        ' UpdateRecordPage
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1902, 1033)
        Controls.Add(GroupDeworm)
        Controls.Add(GroupVaccines)
        Controls.Add(GroupSurgery)
        Controls.Add(GroupType)
        Controls.Add(GroupSex)
        Controls.Add(TxtColor)
        Controls.Add(TxtBreed)
        Controls.Add(CheckedSurgery)
        Controls.Add(CheckedDeworming)
        Controls.Add(CheckedVaccine)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(TxtPetIDNo)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(DpBirthday)
        Controls.Add(TxtName)
        Controls.Add(Btnback)
        Controls.Add(BtnSubmit)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(BtnUploadPet)
        Controls.Add(PicBoxPet)
        Name = "UpdateRecordPage"
        Text = "UpdateRecordPage"
        GroupDeworm.ResumeLayout(False)
        GroupDeworm.PerformLayout()
        GroupVaccines.ResumeLayout(False)
        GroupVaccines.PerformLayout()
        GroupSurgery.ResumeLayout(False)
        GroupSurgery.PerformLayout()
        GroupType.ResumeLayout(False)
        GroupType.PerformLayout()
        GroupSex.ResumeLayout(False)
        GroupSex.PerformLayout()
        CType(PicBoxPet, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupDeworm As GroupBox
    Friend WithEvents RbtnNoDeworm As RadioButton
    Friend WithEvents RbtnYesDeworm As RadioButton
    Friend WithEvents GroupVaccines As GroupBox
    Friend WithEvents RbtnNoVac As RadioButton
    Friend WithEvents RbtnYesVac As RadioButton
    Friend WithEvents GroupSurgery As GroupBox
    Friend WithEvents RbtnNo As RadioButton
    Friend WithEvents RbtnYes As RadioButton
    Friend WithEvents GroupType As GroupBox
    Friend WithEvents RbtnCat As RadioButton
    Friend WithEvents RbtnDog As RadioButton
    Friend WithEvents GroupSex As GroupBox
    Friend WithEvents RbtnMale As RadioButton
    Friend WithEvents RbtnFemale As RadioButton
    Friend WithEvents TxtColor As TextBox
    Friend WithEvents TxtBreed As TextBox
    Friend WithEvents CheckedSurgery As CheckedListBox
    Friend WithEvents CheckedDeworming As CheckedListBox
    Friend WithEvents CheckedVaccine As CheckedListBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtPetIDNo As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents DpBirthday As DateTimePicker
    Friend WithEvents TxtName As TextBox
    Friend WithEvents Btnback As Button
    Friend WithEvents BtnSubmit As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnUploadPet As Button
    Friend WithEvents PicBoxPet As PictureBox
End Class
