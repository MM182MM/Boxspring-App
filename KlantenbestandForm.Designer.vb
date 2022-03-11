<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class KlantenbestandForm
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KlantenbestandForm))
        Me.VoornaamLabel = New System.Windows.Forms.Label()
        Me.VoornaamTB = New System.Windows.Forms.TextBox()
        Me.Table1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KlantenbestandDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KlantenbestandDataSet = New Klantenbestand_App.KlantenbestandDataSet()
        Me.AchternaamTB = New System.Windows.Forms.TextBox()
        Me.AchternaamLabel = New System.Windows.Forms.Label()
        Me.PostcodeTB = New System.Windows.Forms.TextBox()
        Me.PostcodeLabel = New System.Windows.Forms.Label()
        Me.AdresTB = New System.Windows.Forms.TextBox()
        Me.AdresLabel = New System.Windows.Forms.Label()
        Me.EmailTB = New System.Windows.Forms.TextBox()
        Me.EmailLabel = New System.Windows.Forms.Label()
        Me.TelefoonTB = New System.Windows.Forms.TextBox()
        Me.TelefoonLabel = New System.Windows.Forms.Label()
        Me.MobielTB = New System.Windows.Forms.TextBox()
        Me.MobielLabel = New System.Windows.Forms.Label()
        Me.WoonplaatsTB = New System.Windows.Forms.TextBox()
        Me.WoonplaatsLabel = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.VorigeBTN = New System.Windows.Forms.Button()
        Me.ToevoegenBTN = New System.Windows.Forms.Button()
        Me.VolgendeBTN = New System.Windows.Forms.Button()
        Me.AfsluitenBTN = New System.Windows.Forms.Button()
        Me.OpslaanBTN = New System.Windows.Forms.Button()
        Me.VerwijderenBTN = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VoornaamDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AchternaamDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdresDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PostcodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WoonplaatsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MobielDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefoonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Table1TableAdapter = New Klantenbestand_App.KlantenbestandDataSetTableAdapters.Table1TableAdapter()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Dieks_btn = New System.Windows.Forms.Button()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KlantenbestandDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KlantenbestandDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'VoornaamLabel
        '
        Me.VoornaamLabel.AutoSize = True
        Me.VoornaamLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VoornaamLabel.Location = New System.Drawing.Point(25, 23)
        Me.VoornaamLabel.Name = "VoornaamLabel"
        Me.VoornaamLabel.Size = New System.Drawing.Size(99, 20)
        Me.VoornaamLabel.TabIndex = 0
        Me.VoornaamLabel.Text = "Voornaam:"
        '
        'VoornaamTB
        '
        Me.VoornaamTB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Voornaam", True))
        Me.VoornaamTB.Location = New System.Drawing.Point(162, 23)
        Me.VoornaamTB.Name = "VoornaamTB"
        Me.VoornaamTB.Size = New System.Drawing.Size(214, 20)
        Me.VoornaamTB.TabIndex = 1
        '
        'Table1BindingSource
        '
        Me.Table1BindingSource.DataMember = "Table1"
        Me.Table1BindingSource.DataSource = Me.KlantenbestandDataSetBindingSource
        '
        'KlantenbestandDataSetBindingSource
        '
        Me.KlantenbestandDataSetBindingSource.DataSource = Me.KlantenbestandDataSet
        Me.KlantenbestandDataSetBindingSource.Position = 0
        '
        'KlantenbestandDataSet
        '
        Me.KlantenbestandDataSet.DataSetName = "KlantenbestandDataSet"
        Me.KlantenbestandDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AchternaamTB
        '
        Me.AchternaamTB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Achternaam", True))
        Me.AchternaamTB.Location = New System.Drawing.Point(162, 52)
        Me.AchternaamTB.Name = "AchternaamTB"
        Me.AchternaamTB.Size = New System.Drawing.Size(214, 20)
        Me.AchternaamTB.TabIndex = 3
        '
        'AchternaamLabel
        '
        Me.AchternaamLabel.AutoSize = True
        Me.AchternaamLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AchternaamLabel.Location = New System.Drawing.Point(25, 52)
        Me.AchternaamLabel.Name = "AchternaamLabel"
        Me.AchternaamLabel.Size = New System.Drawing.Size(115, 20)
        Me.AchternaamLabel.TabIndex = 2
        Me.AchternaamLabel.Text = "Achternaam:"
        '
        'PostcodeTB
        '
        Me.PostcodeTB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Postcode", True))
        Me.PostcodeTB.Location = New System.Drawing.Point(162, 110)
        Me.PostcodeTB.Name = "PostcodeTB"
        Me.PostcodeTB.Size = New System.Drawing.Size(214, 20)
        Me.PostcodeTB.TabIndex = 7
        '
        'PostcodeLabel
        '
        Me.PostcodeLabel.AutoSize = True
        Me.PostcodeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PostcodeLabel.Location = New System.Drawing.Point(25, 110)
        Me.PostcodeLabel.Name = "PostcodeLabel"
        Me.PostcodeLabel.Size = New System.Drawing.Size(93, 20)
        Me.PostcodeLabel.TabIndex = 6
        Me.PostcodeLabel.Text = "Postcode:"
        '
        'AdresTB
        '
        Me.AdresTB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Adres", True))
        Me.AdresTB.Location = New System.Drawing.Point(162, 81)
        Me.AdresTB.Name = "AdresTB"
        Me.AdresTB.Size = New System.Drawing.Size(214, 20)
        Me.AdresTB.TabIndex = 5
        '
        'AdresLabel
        '
        Me.AdresLabel.AutoSize = True
        Me.AdresLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdresLabel.Location = New System.Drawing.Point(25, 81)
        Me.AdresLabel.Name = "AdresLabel"
        Me.AdresLabel.Size = New System.Drawing.Size(64, 20)
        Me.AdresLabel.TabIndex = 4
        Me.AdresLabel.Text = "Adres:"
        '
        'EmailTB
        '
        Me.EmailTB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Email", True))
        Me.EmailTB.Location = New System.Drawing.Point(162, 226)
        Me.EmailTB.Name = "EmailTB"
        Me.EmailTB.Size = New System.Drawing.Size(214, 20)
        Me.EmailTB.TabIndex = 15
        '
        'EmailLabel
        '
        Me.EmailLabel.AutoSize = True
        Me.EmailLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailLabel.Location = New System.Drawing.Point(25, 226)
        Me.EmailLabel.Name = "EmailLabel"
        Me.EmailLabel.Size = New System.Drawing.Size(62, 20)
        Me.EmailLabel.TabIndex = 14
        Me.EmailLabel.Text = "Email:"
        '
        'TelefoonTB
        '
        Me.TelefoonTB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Telefoon", True))
        Me.TelefoonTB.Location = New System.Drawing.Point(162, 197)
        Me.TelefoonTB.Name = "TelefoonTB"
        Me.TelefoonTB.Size = New System.Drawing.Size(214, 20)
        Me.TelefoonTB.TabIndex = 13
        '
        'TelefoonLabel
        '
        Me.TelefoonLabel.AutoSize = True
        Me.TelefoonLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TelefoonLabel.Location = New System.Drawing.Point(25, 197)
        Me.TelefoonLabel.Name = "TelefoonLabel"
        Me.TelefoonLabel.Size = New System.Drawing.Size(87, 20)
        Me.TelefoonLabel.TabIndex = 12
        Me.TelefoonLabel.Text = "Telefoon:"
        '
        'MobielTB
        '
        Me.MobielTB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Mobiel", True))
        Me.MobielTB.Location = New System.Drawing.Point(162, 168)
        Me.MobielTB.Name = "MobielTB"
        Me.MobielTB.Size = New System.Drawing.Size(214, 20)
        Me.MobielTB.TabIndex = 11
        '
        'MobielLabel
        '
        Me.MobielLabel.AutoSize = True
        Me.MobielLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MobielLabel.Location = New System.Drawing.Point(25, 168)
        Me.MobielLabel.Name = "MobielLabel"
        Me.MobielLabel.Size = New System.Drawing.Size(64, 20)
        Me.MobielLabel.TabIndex = 10
        Me.MobielLabel.Text = "Mobiel"
        '
        'WoonplaatsTB
        '
        Me.WoonplaatsTB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Woonplaats", True))
        Me.WoonplaatsTB.Location = New System.Drawing.Point(162, 139)
        Me.WoonplaatsTB.Name = "WoonplaatsTB"
        Me.WoonplaatsTB.Size = New System.Drawing.Size(214, 20)
        Me.WoonplaatsTB.TabIndex = 9
        '
        'WoonplaatsLabel
        '
        Me.WoonplaatsLabel.AutoSize = True
        Me.WoonplaatsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WoonplaatsLabel.Location = New System.Drawing.Point(25, 139)
        Me.WoonplaatsLabel.Name = "WoonplaatsLabel"
        Me.WoonplaatsLabel.Size = New System.Drawing.Size(113, 20)
        Me.WoonplaatsLabel.TabIndex = 8
        Me.WoonplaatsLabel.Text = "Woonplaats:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(414, 111)
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'VorigeBTN
        '
        Me.VorigeBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VorigeBTN.Location = New System.Drawing.Point(62, 270)
        Me.VorigeBTN.Name = "VorigeBTN"
        Me.VorigeBTN.Size = New System.Drawing.Size(94, 23)
        Me.VorigeBTN.TabIndex = 17
        Me.VorigeBTN.Text = "Vorige"
        Me.VorigeBTN.UseVisualStyleBackColor = True
        '
        'ToevoegenBTN
        '
        Me.ToevoegenBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToevoegenBTN.Location = New System.Drawing.Point(162, 270)
        Me.ToevoegenBTN.Name = "ToevoegenBTN"
        Me.ToevoegenBTN.Size = New System.Drawing.Size(94, 23)
        Me.ToevoegenBTN.TabIndex = 18
        Me.ToevoegenBTN.Text = "Toevoegen"
        Me.ToevoegenBTN.UseVisualStyleBackColor = True
        '
        'VolgendeBTN
        '
        Me.VolgendeBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VolgendeBTN.Location = New System.Drawing.Point(262, 270)
        Me.VolgendeBTN.Name = "VolgendeBTN"
        Me.VolgendeBTN.Size = New System.Drawing.Size(94, 23)
        Me.VolgendeBTN.TabIndex = 19
        Me.VolgendeBTN.Text = "Volgende"
        Me.VolgendeBTN.UseVisualStyleBackColor = True
        '
        'AfsluitenBTN
        '
        Me.AfsluitenBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AfsluitenBTN.Location = New System.Drawing.Point(262, 299)
        Me.AfsluitenBTN.Name = "AfsluitenBTN"
        Me.AfsluitenBTN.Size = New System.Drawing.Size(94, 23)
        Me.AfsluitenBTN.TabIndex = 22
        Me.AfsluitenBTN.Text = "Afsluiten"
        Me.AfsluitenBTN.UseVisualStyleBackColor = True
        '
        'OpslaanBTN
        '
        Me.OpslaanBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpslaanBTN.Location = New System.Drawing.Point(62, 299)
        Me.OpslaanBTN.Name = "OpslaanBTN"
        Me.OpslaanBTN.Size = New System.Drawing.Size(94, 23)
        Me.OpslaanBTN.TabIndex = 21
        Me.OpslaanBTN.Text = "Opslaan"
        Me.OpslaanBTN.UseVisualStyleBackColor = True
        '
        'VerwijderenBTN
        '
        Me.VerwijderenBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VerwijderenBTN.Location = New System.Drawing.Point(162, 299)
        Me.VerwijderenBTN.Name = "VerwijderenBTN"
        Me.VerwijderenBTN.Size = New System.Drawing.Size(94, 23)
        Me.VerwijderenBTN.TabIndex = 20
        Me.VerwijderenBTN.Text = "Verwijderen"
        Me.VerwijderenBTN.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.AfsluitenBTN)
        Me.GroupBox1.Controls.Add(Me.OpslaanBTN)
        Me.GroupBox1.Controls.Add(Me.VerwijderenBTN)
        Me.GroupBox1.Controls.Add(Me.VolgendeBTN)
        Me.GroupBox1.Controls.Add(Me.ToevoegenBTN)
        Me.GroupBox1.Controls.Add(Me.VorigeBTN)
        Me.GroupBox1.Controls.Add(Me.EmailTB)
        Me.GroupBox1.Controls.Add(Me.EmailLabel)
        Me.GroupBox1.Controls.Add(Me.TelefoonTB)
        Me.GroupBox1.Controls.Add(Me.TelefoonLabel)
        Me.GroupBox1.Controls.Add(Me.MobielTB)
        Me.GroupBox1.Controls.Add(Me.MobielLabel)
        Me.GroupBox1.Controls.Add(Me.WoonplaatsTB)
        Me.GroupBox1.Controls.Add(Me.WoonplaatsLabel)
        Me.GroupBox1.Controls.Add(Me.PostcodeTB)
        Me.GroupBox1.Controls.Add(Me.PostcodeLabel)
        Me.GroupBox1.Controls.Add(Me.AdresTB)
        Me.GroupBox1.Controls.Add(Me.AdresLabel)
        Me.GroupBox1.Controls.Add(Me.AchternaamTB)
        Me.GroupBox1.Controls.Add(Me.AchternaamLabel)
        Me.GroupBox1.Controls.Add(Me.VoornaamTB)
        Me.GroupBox1.Controls.Add(Me.VoornaamLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 142)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(414, 360)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Klant Invoer"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.VoornaamDataGridViewTextBoxColumn, Me.AchternaamDataGridViewTextBoxColumn, Me.AdresDataGridViewTextBoxColumn, Me.PostcodeDataGridViewTextBoxColumn, Me.WoonplaatsDataGridViewTextBoxColumn, Me.MobielDataGridViewTextBoxColumn, Me.TelefoonDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.Table1BindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(3, 15)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(843, 469)
        Me.DataGridView1.TabIndex = 24
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.Visible = False
        '
        'VoornaamDataGridViewTextBoxColumn
        '
        Me.VoornaamDataGridViewTextBoxColumn.DataPropertyName = "Voornaam"
        Me.VoornaamDataGridViewTextBoxColumn.HeaderText = "Voornaam"
        Me.VoornaamDataGridViewTextBoxColumn.Name = "VoornaamDataGridViewTextBoxColumn"
        '
        'AchternaamDataGridViewTextBoxColumn
        '
        Me.AchternaamDataGridViewTextBoxColumn.DataPropertyName = "Achternaam"
        Me.AchternaamDataGridViewTextBoxColumn.HeaderText = "Achternaam"
        Me.AchternaamDataGridViewTextBoxColumn.Name = "AchternaamDataGridViewTextBoxColumn"
        '
        'AdresDataGridViewTextBoxColumn
        '
        Me.AdresDataGridViewTextBoxColumn.DataPropertyName = "Adres"
        Me.AdresDataGridViewTextBoxColumn.HeaderText = "Adres"
        Me.AdresDataGridViewTextBoxColumn.Name = "AdresDataGridViewTextBoxColumn"
        '
        'PostcodeDataGridViewTextBoxColumn
        '
        Me.PostcodeDataGridViewTextBoxColumn.DataPropertyName = "Postcode"
        Me.PostcodeDataGridViewTextBoxColumn.HeaderText = "Postcode"
        Me.PostcodeDataGridViewTextBoxColumn.Name = "PostcodeDataGridViewTextBoxColumn"
        '
        'WoonplaatsDataGridViewTextBoxColumn
        '
        Me.WoonplaatsDataGridViewTextBoxColumn.DataPropertyName = "Woonplaats"
        Me.WoonplaatsDataGridViewTextBoxColumn.HeaderText = "Woonplaats"
        Me.WoonplaatsDataGridViewTextBoxColumn.Name = "WoonplaatsDataGridViewTextBoxColumn"
        '
        'MobielDataGridViewTextBoxColumn
        '
        Me.MobielDataGridViewTextBoxColumn.DataPropertyName = "Mobiel"
        Me.MobielDataGridViewTextBoxColumn.HeaderText = "Mobiel"
        Me.MobielDataGridViewTextBoxColumn.Name = "MobielDataGridViewTextBoxColumn"
        '
        'TelefoonDataGridViewTextBoxColumn
        '
        Me.TelefoonDataGridViewTextBoxColumn.DataPropertyName = "Telefoon"
        Me.TelefoonDataGridViewTextBoxColumn.HeaderText = "Telefoon"
        Me.TelefoonDataGridViewTextBoxColumn.Name = "TelefoonDataGridViewTextBoxColumn"
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "Email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        '
        'Table1TableAdapter
        '
        Me.Table1TableAdapter.ClearBeforeFill = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Dieks_btn)
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Location = New System.Drawing.Point(460, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(854, 490)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Klantenbestand"
        '
        'Dieks_btn
        '
        Me.Dieks_btn.Location = New System.Drawing.Point(281, 207)
        Me.Dieks_btn.Name = "Dieks_btn"
        Me.Dieks_btn.Size = New System.Drawing.Size(160, 23)
        Me.Dieks_btn.TabIndex = 25
        Me.Dieks_btn.Text = "Dieks button!"
        Me.Dieks_btn.UseVisualStyleBackColor = True
        '
        'KlantenbestandForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1325, 513)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "KlantenbestandForm"
        Me.Text = "Klantenbestand"
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KlantenbestandDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KlantenbestandDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents VoornaamLabel As Label
    Friend WithEvents VoornaamTB As TextBox
    Friend WithEvents AchternaamTB As TextBox
    Friend WithEvents AchternaamLabel As Label
    Friend WithEvents PostcodeTB As TextBox
    Friend WithEvents PostcodeLabel As Label
    Friend WithEvents AdresTB As TextBox
    Friend WithEvents AdresLabel As Label
    Friend WithEvents EmailTB As TextBox
    Friend WithEvents EmailLabel As Label
    Friend WithEvents TelefoonTB As TextBox
    Friend WithEvents TelefoonLabel As Label
    Friend WithEvents MobielTB As TextBox
    Friend WithEvents MobielLabel As Label
    Friend WithEvents WoonplaatsTB As TextBox
    Friend WithEvents WoonplaatsLabel As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents VorigeBTN As Button
    Friend WithEvents ToevoegenBTN As Button
    Friend WithEvents VolgendeBTN As Button
    Friend WithEvents AfsluitenBTN As Button
    Friend WithEvents OpslaanBTN As Button
    Friend WithEvents VerwijderenBTN As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents KlantenbestandDataSetBindingSource As BindingSource
    Friend WithEvents KlantenbestandDataSet As KlantenbestandDataSet
    Friend WithEvents Table1BindingSource As BindingSource
    Friend WithEvents Table1TableAdapter As KlantenbestandDataSetTableAdapters.Table1TableAdapter
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VoornaamDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AchternaamDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AdresDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PostcodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WoonplaatsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MobielDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelefoonDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Dieks_btn As Button
End Class
