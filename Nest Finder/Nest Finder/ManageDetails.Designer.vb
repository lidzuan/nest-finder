<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageDetails
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
        Me.components = New System.ComponentModel.Container()
        Dim Total_SalesLabel As System.Windows.Forms.Label
        Dim DescriptionLabel As System.Windows.Forms.Label
        Dim Date_of_EstablishmentLabel As System.Windows.Forms.Label
        Dim Total_Houses_OwnedLabel As System.Windows.Forms.Label
        Dim Houses_SoldLabel As System.Windows.Forms.Label
        Dim Houses_AvailableLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManageDetails))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.AdminDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NestFinderManagementDataSet = New Nest_Finder.NestFinderManagementDataSet()
        Me.AdminDetailsTableAdapter = New Nest_Finder.NestFinderManagementDataSetTableAdapters.AdminDetailsTableAdapter()
        Me.TableAdapterManager = New Nest_Finder.NestFinderManagementDataSetTableAdapters.TableAdapterManager()
        Me.BuyersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BuyersTableAdapter = New Nest_Finder.NestFinderManagementDataSetTableAdapters.BuyersTableAdapter()
        Me.Total_SalesTextBox1 = New System.Windows.Forms.TextBox()
        Me.DescriptionTextBox1 = New System.Windows.Forms.TextBox()
        Me.Date_of_EstablishmentTextBox1 = New System.Windows.Forms.TextBox()
        Me.Total_Houses_OwnedTextBox1 = New System.Windows.Forms.TextBox()
        Me.Houses_SoldTextBox1 = New System.Windows.Forms.TextBox()
        Me.Houses_AvailableTextBox1 = New System.Windows.Forms.TextBox()
        Total_SalesLabel = New System.Windows.Forms.Label()
        DescriptionLabel = New System.Windows.Forms.Label()
        Date_of_EstablishmentLabel = New System.Windows.Forms.Label()
        Total_Houses_OwnedLabel = New System.Windows.Forms.Label()
        Houses_SoldLabel = New System.Windows.Forms.Label()
        Houses_AvailableLabel = New System.Windows.Forms.Label()
        CType(Me.AdminDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NestFinderManagementDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuyersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Total_SalesLabel
        '
        Total_SalesLabel.AutoSize = True
        Total_SalesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Total_SalesLabel.Location = New System.Drawing.Point(522, 209)
        Total_SalesLabel.Name = "Total_SalesLabel"
        Total_SalesLabel.Size = New System.Drawing.Size(106, 22)
        Total_SalesLabel.TabIndex = 9
        Total_SalesLabel.Text = "Total Sales:"
        '
        'DescriptionLabel
        '
        DescriptionLabel.AutoSize = True
        DescriptionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DescriptionLabel.Location = New System.Drawing.Point(523, 55)
        DescriptionLabel.Name = "DescriptionLabel"
        DescriptionLabel.Size = New System.Drawing.Size(105, 22)
        DescriptionLabel.TabIndex = 10
        DescriptionLabel.Text = "Description:"
        '
        'Date_of_EstablishmentLabel
        '
        Date_of_EstablishmentLabel.AutoSize = True
        Date_of_EstablishmentLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Date_of_EstablishmentLabel.Location = New System.Drawing.Point(438, 175)
        Date_of_EstablishmentLabel.Name = "Date_of_EstablishmentLabel"
        Date_of_EstablishmentLabel.Size = New System.Drawing.Size(190, 22)
        Date_of_EstablishmentLabel.TabIndex = 11
        Date_of_EstablishmentLabel.Text = "Date of Establishment:"
        '
        'Total_Houses_OwnedLabel
        '
        Total_Houses_OwnedLabel.AutoSize = True
        Total_Houses_OwnedLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Total_Houses_OwnedLabel.Location = New System.Drawing.Point(444, 243)
        Total_Houses_OwnedLabel.Name = "Total_Houses_OwnedLabel"
        Total_Houses_OwnedLabel.Size = New System.Drawing.Size(184, 22)
        Total_Houses_OwnedLabel.TabIndex = 12
        Total_Houses_OwnedLabel.Text = "Total Houses Owned:"
        '
        'Houses_SoldLabel
        '
        Houses_SoldLabel.AutoSize = True
        Houses_SoldLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Houses_SoldLabel.Location = New System.Drawing.Point(489, 277)
        Houses_SoldLabel.Name = "Houses_SoldLabel"
        Houses_SoldLabel.Size = New System.Drawing.Size(139, 22)
        Houses_SoldLabel.TabIndex = 13
        Houses_SoldLabel.Text = "Houses Rented:"
        '
        'Houses_AvailableLabel
        '
        Houses_AvailableLabel.AutoSize = True
        Houses_AvailableLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Houses_AvailableLabel.Location = New System.Drawing.Point(474, 311)
        Houses_AvailableLabel.Name = "Houses_AvailableLabel"
        Houses_AvailableLabel.Size = New System.Drawing.Size(154, 22)
        Houses_AvailableLabel.TabIndex = 15
        Houses_AvailableLabel.Text = "Houses Available:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(112, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(256, 32)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Management System"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Ravie", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(413, 63)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Nest Finder"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Location = New System.Drawing.Point(77, 155)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(323, 288)
        Me.Panel1.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button1.Location = New System.Drawing.Point(634, 370)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(106, 59)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "EDIT"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(824, 356)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(104, 87)
        Me.Button2.TabIndex = 9
        Me.Button2.UseVisualStyleBackColor = False
        '
        'AdminDetailsBindingSource
        '
        Me.AdminDetailsBindingSource.DataMember = "AdminDetails"
        Me.AdminDetailsBindingSource.DataSource = Me.NestFinderManagementDataSet
        '
        'NestFinderManagementDataSet
        '
        Me.NestFinderManagementDataSet.DataSetName = "NestFinderManagementDataSet"
        Me.NestFinderManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AdminDetailsTableAdapter
        '
        Me.AdminDetailsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AdminDetailsTableAdapter = Me.AdminDetailsTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BuyersTableAdapter = Nothing
        Me.TableAdapterManager.PropertiesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Nest_Finder.NestFinderManagementDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BuyersBindingSource
        '
        Me.BuyersBindingSource.DataMember = "Buyers"
        Me.BuyersBindingSource.DataSource = Me.NestFinderManagementDataSet
        '
        'BuyersTableAdapter
        '
        Me.BuyersTableAdapter.ClearBeforeFill = True
        '
        'Total_SalesTextBox1
        '
        Me.Total_SalesTextBox1.BackColor = System.Drawing.SystemColors.Menu
        Me.Total_SalesTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdminDetailsBindingSource, "Total Sales", True))
        Me.Total_SalesTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Total_SalesTextBox1.Location = New System.Drawing.Point(634, 206)
        Me.Total_SalesTextBox1.Name = "Total_SalesTextBox1"
        Me.Total_SalesTextBox1.Size = New System.Drawing.Size(158, 28)
        Me.Total_SalesTextBox1.TabIndex = 10
        '
        'DescriptionTextBox1
        '
        Me.DescriptionTextBox1.BackColor = System.Drawing.SystemColors.Menu
        Me.DescriptionTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdminDetailsBindingSource, "Description", True))
        Me.DescriptionTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescriptionTextBox1.Location = New System.Drawing.Point(634, 52)
        Me.DescriptionTextBox1.Multiline = True
        Me.DescriptionTextBox1.Name = "DescriptionTextBox1"
        Me.DescriptionTextBox1.Size = New System.Drawing.Size(294, 114)
        Me.DescriptionTextBox1.TabIndex = 11
        '
        'Date_of_EstablishmentTextBox1
        '
        Me.Date_of_EstablishmentTextBox1.BackColor = System.Drawing.SystemColors.Menu
        Me.Date_of_EstablishmentTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdminDetailsBindingSource, "Date of Establishment", True))
        Me.Date_of_EstablishmentTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date_of_EstablishmentTextBox1.Location = New System.Drawing.Point(634, 172)
        Me.Date_of_EstablishmentTextBox1.Name = "Date_of_EstablishmentTextBox1"
        Me.Date_of_EstablishmentTextBox1.Size = New System.Drawing.Size(158, 28)
        Me.Date_of_EstablishmentTextBox1.TabIndex = 12
        '
        'Total_Houses_OwnedTextBox1
        '
        Me.Total_Houses_OwnedTextBox1.BackColor = System.Drawing.SystemColors.Menu
        Me.Total_Houses_OwnedTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdminDetailsBindingSource, "Total Houses Owned", True))
        Me.Total_Houses_OwnedTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Total_Houses_OwnedTextBox1.Location = New System.Drawing.Point(634, 240)
        Me.Total_Houses_OwnedTextBox1.Name = "Total_Houses_OwnedTextBox1"
        Me.Total_Houses_OwnedTextBox1.Size = New System.Drawing.Size(100, 28)
        Me.Total_Houses_OwnedTextBox1.TabIndex = 13
        '
        'Houses_SoldTextBox1
        '
        Me.Houses_SoldTextBox1.BackColor = System.Drawing.SystemColors.Menu
        Me.Houses_SoldTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdminDetailsBindingSource, "Houses Rented", True))
        Me.Houses_SoldTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Houses_SoldTextBox1.Location = New System.Drawing.Point(634, 274)
        Me.Houses_SoldTextBox1.Name = "Houses_SoldTextBox1"
        Me.Houses_SoldTextBox1.Size = New System.Drawing.Size(100, 28)
        Me.Houses_SoldTextBox1.TabIndex = 14
        '
        'Houses_AvailableTextBox1
        '
        Me.Houses_AvailableTextBox1.BackColor = System.Drawing.SystemColors.Menu
        Me.Houses_AvailableTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdminDetailsBindingSource, "Houses Available", True))
        Me.Houses_AvailableTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Houses_AvailableTextBox1.Location = New System.Drawing.Point(634, 308)
        Me.Houses_AvailableTextBox1.Name = "Houses_AvailableTextBox1"
        Me.Houses_AvailableTextBox1.Size = New System.Drawing.Size(100, 28)
        Me.Houses_AvailableTextBox1.TabIndex = 16
        '
        'ManageDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(969, 487)
        Me.Controls.Add(Houses_AvailableLabel)
        Me.Controls.Add(Me.Houses_AvailableTextBox1)
        Me.Controls.Add(Houses_SoldLabel)
        Me.Controls.Add(Me.Houses_SoldTextBox1)
        Me.Controls.Add(Total_Houses_OwnedLabel)
        Me.Controls.Add(Me.Total_Houses_OwnedTextBox1)
        Me.Controls.Add(Date_of_EstablishmentLabel)
        Me.Controls.Add(Me.Date_of_EstablishmentTextBox1)
        Me.Controls.Add(DescriptionLabel)
        Me.Controls.Add(Me.DescriptionTextBox1)
        Me.Controls.Add(Total_SalesLabel)
        Me.Controls.Add(Me.Total_SalesTextBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ManageDetails"
        Me.Text = "Manage Details"
        CType(Me.AdminDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NestFinderManagementDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuyersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents AdminDetailsBindingSource As BindingSource
    Friend WithEvents NestFinderManagementDataSet As NestFinderManagementDataSet
    Friend WithEvents AdminDetailsTableAdapter As NestFinderManagementDataSetTableAdapters.AdminDetailsTableAdapter
    Friend WithEvents TableAdapterManager As NestFinderManagementDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Houses_SoldTextBox As TextBox
    Friend WithEvents Total_Houses_OwnedTextBox As TextBox
    Friend WithEvents Houses_AvailableTextBox As TextBox
    Friend WithEvents Total_SalesTextBox As TextBox
    Friend WithEvents Date_of_EstablishmentTextBox As TextBox
    Friend WithEvents DescriptionTextBox As TextBox
    Friend WithEvents BuyersBindingSource As BindingSource
    Friend WithEvents BuyersTableAdapter As NestFinderManagementDataSetTableAdapters.BuyersTableAdapter
    Friend WithEvents Full_NameTextBox As TextBox
    Friend WithEvents Total_SalesTextBox1 As TextBox
    Friend WithEvents DescriptionTextBox1 As TextBox
    Friend WithEvents Date_of_EstablishmentTextBox1 As TextBox
    Friend WithEvents Total_Houses_OwnedTextBox1 As TextBox
    Friend WithEvents Houses_SoldTextBox1 As TextBox
    Friend WithEvents Houses_AvailableTextBox1 As TextBox
End Class
