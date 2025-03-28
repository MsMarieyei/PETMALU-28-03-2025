<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PetRegistrationPage
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PetRegistrationPage))
        Label1 = New Label()
        PicBoxPet = New PictureBox()
        BtnUploadPet = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        Label6 = New Label()
        BtnSubmit = New Button()
        Btnback = New Button()
        TxtName = New TextBox()
        DpBirthday = New DateTimePicker()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        TxtPetIDNo = New TextBox()
        Label10 = New Label()
        Label11 = New Label()
        CheckBox1 = New CheckBox()
        CheckedVaccine = New CheckedListBox()
        CheckedDeworming = New CheckedListBox()
        CheckedSurgery = New CheckedListBox()
        Label12 = New Label()
        TxtBreed = New TextBox()
        TxtColor = New TextBox()
        GroupSex = New GroupBox()
        RbtnMale = New RadioButton()
        RbtnFemale = New RadioButton()
        GroupType = New GroupBox()
        RbtnCat = New RadioButton()
        RbtnDog = New RadioButton()
        GroupSurgery = New GroupBox()
        RbtnNo = New RadioButton()
        RbtnYes = New RadioButton()
        GroupVaccines = New GroupBox()
        RbtnNoVac = New RadioButton()
        RbtnYesVac = New RadioButton()
        GroupDeworm = New GroupBox()
        RbtnNoDeworm = New RadioButton()
        RbtnYesDeworm = New RadioButton()
        CType(PicBoxPet, ComponentModel.ISupportInitialize).BeginInit()
        GroupSex.SuspendLayout()
        GroupType.SuspendLayout()
        GroupSurgery.SuspendLayout()
        GroupVaccines.SuspendLayout()
        GroupDeworm.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Showcard Gothic", 64.8F, FontStyle.Regular, GraphicsUnit.Point, 0)
        Label1.ForeColor = Color.FromArgb(0, 64, 0)
        Label1.Location = New Point(445, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(1457, 135)
        Label1.TabIndex = 0
        Label1.Text = "Client/Pet Registration"
        ' 
        ' PicBoxPet
        ' 
        PicBoxPet.Location = New Point(1399, 316)
        PicBoxPet.Name = "PicBoxPet"
        PicBoxPet.Size = New Size(335, 302)
        PicBoxPet.SizeMode = PictureBoxSizeMode.AutoSize
        PicBoxPet.TabIndex = 1
        PicBoxPet.TabStop = False
        ' 
        ' BtnUploadPet
        ' 
        BtnUploadPet.Location = New Point(1481, 656)
        BtnUploadPet.Name = "BtnUploadPet"
        BtnUploadPet.Size = New Size(189, 29)
        BtnUploadPet.TabIndex = 2
        BtnUploadPet.Text = "Upload Pet's Photo"
        BtnUploadPet.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Britannic Bold", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0)
        Label2.ForeColor = Color.FromArgb(0, 64, 0)
        Label2.Location = New Point(155, 369)
        Label2.Name = "Label2"
        Label2.Size = New Size(119, 41)
        Label2.TabIndex = 3
        Label2.Text = "Name:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Britannic Bold", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0)
        Label3.ForeColor = Color.FromArgb(0, 64, 0)
        Label3.Location = New Point(185, 439)
        Label3.Name = "Label3"
        Label3.Size = New Size(84, 41)
        Label3.TabIndex = 4
        Label3.Text = "Sex:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Britannic Bold", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0)
        Label4.ForeColor = Color.FromArgb(0, 64, 0)
        Label4.Location = New Point(101, 553)
        Label4.Name = "Label4"
        Label4.Size = New Size(168, 41)
        Label4.TabIndex = 5
        Label4.Text = "Birthday:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Britannic Bold", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0)
        Label5.ForeColor = Color.FromArgb(0, 64, 0)
        Label5.Location = New Point(145, 742)
        Label5.Name = "Label5"
        Label5.Size = New Size(124, 41)
        Label5.TabIndex = 6
        Label5.Text = "Breed:"
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.ImageScalingSize = New Size(20, 20)
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(61, 4)
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Britannic Bold", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0)
        Label6.ForeColor = Color.FromArgb(0, 64, 0)
        Label6.Location = New Point(152, 833)
        Label6.Name = "Label6"
        Label6.Size = New Size(117, 41)
        Label6.TabIndex = 8
        Label6.Text = "Color:"
        ' 
        ' BtnSubmit
        ' 
        BtnSubmit.Location = New Point(1419, 899)
        BtnSubmit.Name = "BtnSubmit"
        BtnSubmit.Size = New Size(94, 29)
        BtnSubmit.TabIndex = 9
        BtnSubmit.Text = "Submit"
        BtnSubmit.UseVisualStyleBackColor = True
        ' 
        ' Btnback
        ' 
        Btnback.Location = New Point(1552, 899)
        Btnback.Name = "Btnback"
        Btnback.Size = New Size(94, 29)
        Btnback.TabIndex = 10
        Btnback.Text = "Back"
        Btnback.UseVisualStyleBackColor = True
        ' 
        ' TxtName
        ' 
        TxtName.BackColor = Color.YellowGreen
        TxtName.BorderStyle = BorderStyle.FixedSingle
        TxtName.Font = New Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0)
        TxtName.Location = New Point(280, 362)
        TxtName.Name = "TxtName"
        TxtName.Size = New Size(378, 54)
        TxtName.TabIndex = 11
        ' 
        ' DpBirthday
        ' 
        DpBirthday.CalendarFont = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0)
        DpBirthday.CalendarMonthBackground = Color.White
        DpBirthday.CalendarTitleBackColor = Color.White
        DpBirthday.Font = New Font("Arial Narrow", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0)
        DpBirthday.Location = New Point(280, 556)
        DpBirthday.Name = "DpBirthday"
        DpBirthday.Size = New Size(378, 38)
        DpBirthday.TabIndex = 14
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Britannic Bold", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0)
        Label7.ForeColor = Color.FromArgb(0, 64, 0)
        Label7.Location = New Point(60, 621)
        Label7.Name = "Label7"
        Label7.Size = New Size(209, 41)
        Label7.TabIndex = 15
        Label7.Text = "Type of Pet:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(763, 362)
        Label8.Name = "Label8"
        Label8.Size = New Size(75, 20)
        Label8.TabIndex = 19
        Label8.Text = "Pet ID No:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(719, 413)
        Label9.Name = "Label9"
        Label9.Size = New Size(119, 20)
        Label9.TabIndex = 20
        Label9.Text = "Medical Surgery:"
        ' 
        ' TxtPetIDNo
        ' 
        TxtPetIDNo.Location = New Point(878, 355)
        TxtPetIDNo.Name = "TxtPetIDNo"
        TxtPetIDNo.Size = New Size(125, 27)
        TxtPetIDNo.TabIndex = 21
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(763, 642)
        Label10.Name = "Label10"
        Label10.Size = New Size(68, 20)
        Label10.TabIndex = 24
        Label10.Text = "Vaccines:"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(748, 787)
        Label11.Name = "Label11"
        Label11.Size = New Size(90, 20)
        Label11.TabIndex = 25
        Label11.Text = "Deworming:"
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(0, 0)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(103, 24)
        CheckBox1.TabIndex = 26
        CheckBox1.Text = "CheckBox1"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' CheckedVaccine
        ' 
        CheckedVaccine.FormattingEnabled = True
        CheckedVaccine.Location = New Point(1124, 621)
        CheckedVaccine.Name = "CheckedVaccine"
        CheckedVaccine.Size = New Size(150, 114)
        CheckedVaccine.TabIndex = 27
        ' 
        ' CheckedDeworming
        ' 
        CheckedDeworming.FormattingEnabled = True
        CheckedDeworming.Location = New Point(1124, 787)
        CheckedDeworming.Name = "CheckedDeworming"
        CheckedDeworming.Size = New Size(150, 114)
        CheckedDeworming.TabIndex = 28
        ' 
        ' CheckedSurgery
        ' 
        CheckedSurgery.FormattingEnabled = True
        CheckedSurgery.Location = New Point(1124, 410)
        CheckedSurgery.Name = "CheckedSurgery"
        CheckedSurgery.Size = New Size(150, 114)
        CheckedSurgery.TabIndex = 29
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = Color.Transparent
        Label12.Font = New Font("Broadway", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0)
        Label12.Location = New Point(1030, 220)
        Label12.Name = "Label12"
        Label12.Size = New Size(227, 53)
        Label12.TabIndex = 30
        Label12.Text = "Pet Info"
        ' 
        ' TxtBreed
        ' 
        TxtBreed.BackColor = Color.YellowGreen
        TxtBreed.BorderStyle = BorderStyle.FixedSingle
        TxtBreed.Font = New Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0)
        TxtBreed.Location = New Point(275, 735)
        TxtBreed.Name = "TxtBreed"
        TxtBreed.Size = New Size(383, 54)
        TxtBreed.TabIndex = 31
        ' 
        ' TxtColor
        ' 
        TxtColor.BackColor = Color.YellowGreen
        TxtColor.BorderStyle = BorderStyle.FixedSingle
        TxtColor.Font = New Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0)
        TxtColor.Location = New Point(275, 820)
        TxtColor.Name = "TxtColor"
        TxtColor.Size = New Size(383, 54)
        TxtColor.TabIndex = 32
        ' 
        ' GroupSex
        ' 
        GroupSex.BackColor = Color.Transparent
        GroupSex.Controls.Add(RbtnMale)
        GroupSex.Controls.Add(RbtnFemale)
        GroupSex.FlatStyle = FlatStyle.Popup
        GroupSex.Location = New Point(280, 428)
        GroupSex.Name = "GroupSex"
        GroupSex.Size = New Size(180, 122)
        GroupSex.TabIndex = 37
        GroupSex.TabStop = False
        ' 
        ' RbtnMale
        ' 
        RbtnMale.AutoSize = True
        RbtnMale.Font = New Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0)
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
        RbtnFemale.Font = New Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0)
        RbtnFemale.Location = New Point(17, 15)
        RbtnFemale.Name = "RbtnFemale"
        RbtnFemale.Size = New Size(165, 48)
        RbtnFemale.TabIndex = 0
        RbtnFemale.TabStop = True
        RbtnFemale.Text = "Female"
        RbtnFemale.UseVisualStyleBackColor = True
        ' 
        ' GroupType
        ' 
        GroupType.BackColor = Color.Transparent
        GroupType.Controls.Add(RbtnCat)
        GroupType.Controls.Add(RbtnDog)
        GroupType.Location = New Point(280, 600)
        GroupType.Name = "GroupType"
        GroupType.Size = New Size(250, 125)
        GroupType.TabIndex = 2
        GroupType.TabStop = False
        ' 
        ' RbtnCat
        ' 
        RbtnCat.AutoSize = True
        RbtnCat.Font = New Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0)
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
        RbtnDog.Font = New Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0)
        RbtnDog.Location = New Point(17, 16)
        RbtnDog.Name = "RbtnDog"
        RbtnDog.Size = New Size(109, 48)
        RbtnDog.TabIndex = 0
        RbtnDog.TabStop = True
        RbtnDog.Text = "Dog"
        RbtnDog.UseVisualStyleBackColor = True
        ' 
        ' GroupSurgery
        ' 
        GroupSurgery.Controls.Add(RbtnNo)
        GroupSurgery.Controls.Add(RbtnYes)
        GroupSurgery.Location = New Point(868, 399)
        GroupSurgery.Name = "GroupSurgery"
        GroupSurgery.Size = New Size(250, 125)
        GroupSurgery.TabIndex = 38
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
        ' GroupVaccines
        ' 
        GroupVaccines.Controls.Add(RbtnNoVac)
        GroupVaccines.Controls.Add(RbtnYesVac)
        GroupVaccines.Location = New Point(868, 616)
        GroupVaccines.Name = "GroupVaccines"
        GroupVaccines.Size = New Size(250, 125)
        GroupVaccines.TabIndex = 39
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
        ' GroupDeworm
        ' 
        GroupDeworm.Controls.Add(RbtnNoDeworm)
        GroupDeworm.Controls.Add(RbtnYesDeworm)
        GroupDeworm.Location = New Point(868, 776)
        GroupDeworm.Name = "GroupDeworm"
        GroupDeworm.Size = New Size(250, 125)
        GroupDeworm.TabIndex = 40
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
        ' PetRegistrationPage
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1902, 1033)
        Controls.Add(GroupDeworm)
        Controls.Add(GroupVaccines)
        Controls.Add(GroupSurgery)
        Controls.Add(GroupType)
        Controls.Add(GroupSex)
        Controls.Add(TxtColor)
        Controls.Add(TxtBreed)
        Controls.Add(Label12)
        Controls.Add(CheckedSurgery)
        Controls.Add(CheckedDeworming)
        Controls.Add(CheckedVaccine)
        Controls.Add(CheckBox1)
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
        Controls.Add(Label1)
        Name = "PetRegistrationPage"
        CType(PicBoxPet, ComponentModel.ISupportInitialize).EndInit()
        GroupSex.ResumeLayout(False)
        GroupSex.PerformLayout()
        GroupType.ResumeLayout(False)
        GroupType.PerformLayout()
        GroupSurgery.ResumeLayout(False)
        GroupSurgery.PerformLayout()
        GroupVaccines.ResumeLayout(False)
        GroupVaccines.PerformLayout()
        GroupDeworm.ResumeLayout(False)
        GroupDeworm.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PicBoxPet As PictureBox
    Friend WithEvents BtnUploadPet As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Label6 As Label
    Friend WithEvents BtnSubmit As Button
    Friend WithEvents Btnback As Button
    Friend WithEvents TxtName As TextBox
    Friend WithEvents DpBirthday As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtPetIDNo As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckedVaccine As CheckedListBox
    Friend WithEvents CheckedDeworming As CheckedListBox
    Friend WithEvents CheckedSurgery As CheckedListBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TxtBreed As TextBox
    Friend WithEvents TxtColor As TextBox
    Friend WithEvents GroupSex As GroupBox
    Friend WithEvents RbtnMale As RadioButton
    Friend WithEvents RbtnFemale As RadioButton
    Friend WithEvents GroupType As GroupBox
    Friend WithEvents RbtnDog As RadioButton
    Friend WithEvents RbtnCat As RadioButton
    Friend WithEvents GroupSurgery As GroupBox
    Friend WithEvents RbtnNo As RadioButton
    Friend WithEvents RbtnYes As RadioButton
    Friend WithEvents GroupVaccines As GroupBox
    Friend WithEvents GroupDeworm As GroupBox
    Friend WithEvents RbtnNoVac As RadioButton
    Friend WithEvents RbtnYesVac As RadioButton
    Friend WithEvents RbtnNoDeworm As RadioButton
    Friend WithEvents RbtnYesDeworm As RadioButton
End Class
