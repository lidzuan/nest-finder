<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Details
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
        Dim DescriptionLabel As System.Windows.Forms.Label
        Dim Date_of_EstablishmentLabel As System.Windows.Forms.Label
        Dim Total_SalesLabel As System.Windows.Forms.Label
        Dim Total_Houses_OwnedLabel As System.Windows.Forms.Label
        Dim Houses_SoldLabel As System.Windows.Forms.Label
        Dim Houses_AvailableLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Details))
        Me.Button2 = New System.Windows.Forms.Button()
        Me.NestFinderManagementDataSet = New Nest_Finder.NestFinderManagementDataSet()
        Me.AdminDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AdminDetailsTableAdapter = New Nest_Finder.NestFinderManagementDataSetTableAdapters.AdminDetailsTableAdapter()
        Me.TableAdapterManager = New Nest_Finder.NestFinderManagementDataSetTableAdapters.TableAdapterManager()
        Me.AdminDetailsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.AdminDetailsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.Date_of_EstablishmentLabel1 = New System.Windows.Forms.Label()
        Me.Total_SalesLabel1 = New System.Windows.Forms.Label()
        Me.Total_Houses_OwnedLabel1 = New System.Windows.Forms.Label()
        Me.Houses_SoldLabel1 = New System.Windows.Forms.Label()
        Me.Houses_AvailableLabel1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        DescriptionLabel = New System.Windows.Forms.Label()
        Date_of_EstablishmentLabel = New System.Windows.Forms.Label()
        Total_SalesLabel = New System.Windows.Forms.Label()
        Total_Houses_OwnedLabel = New System.Windows.Forms.Label()
        Houses_SoldLabel = New System.Windows.Forms.Label()
        Houses_AvailableLabel = New System.Windows.Forms.Label()
        CType(Me.NestFinderManagementDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdminDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdminDetailsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AdminDetailsBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'DescriptionLabel
        '
        DescriptionLabel.AutoSize = True
        DescriptionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DescriptionLabel.Location = New System.Drawing.Point(534, 67)
        DescriptionLabel.Name = "DescriptionLabel"
        DescriptionLabel.Size = New System.Drawing.Size(127, 25)
        DescriptionLabel.TabIndex = 22
        DescriptionLabel.Text = "Description:"
        '
        'Date_of_EstablishmentLabel
        '
        Date_of_EstablishmentLabel.AutoSize = True
        Date_of_EstablishmentLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Date_of_EstablishmentLabel.Location = New System.Drawing.Point(432, 239)
        Date_of_EstablishmentLabel.Name = "Date_of_EstablishmentLabel"
        Date_of_EstablishmentLabel.Size = New System.Drawing.Size(229, 25)
        Date_of_EstablishmentLabel.TabIndex = 23
        Date_of_EstablishmentLabel.Text = "Date of Establishment:"
        '
        'Total_SalesLabel
        '
        Total_SalesLabel.AutoSize = True
        Total_SalesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Total_SalesLabel.Location = New System.Drawing.Point(532, 280)
        Total_SalesLabel.Name = "Total_SalesLabel"
        Total_SalesLabel.Size = New System.Drawing.Size(129, 25)
        Total_SalesLabel.TabIndex = 24
        Total_SalesLabel.Text = "Total Sales:"
        '
        'Total_Houses_OwnedLabel
        '
        Total_Houses_OwnedLabel.AutoSize = True
        Total_Houses_OwnedLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Total_Houses_OwnedLabel.Location = New System.Drawing.Point(440, 322)
        Total_Houses_OwnedLabel.Name = "Total_Houses_OwnedLabel"
        Total_Houses_OwnedLabel.Size = New System.Drawing.Size(221, 25)
        Total_Houses_OwnedLabel.TabIndex = 25
        Total_Houses_OwnedLabel.Text = "Total Houses Owned:"
        '
        'Houses_SoldLabel
        '
        Houses_SoldLabel.AutoSize = True
        Houses_SoldLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Houses_SoldLabel.Location = New System.Drawing.Point(495, 363)
        Houses_SoldLabel.Name = "Houses_SoldLabel"
        Houses_SoldLabel.Size = New System.Drawing.Size(166, 25)
        Houses_SoldLabel.TabIndex = 26
        Houses_SoldLabel.Text = "Houses Rented:"
        '
        'Houses_AvailableLabel
        '
        Houses_AvailableLabel.AutoSize = True
        Houses_AvailableLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Houses_AvailableLabel.Location = New System.Drawing.Point(474, 406)
        Houses_AvailableLabel.Name = "Houses_AvailableLabel"
        Houses_AvailableLabel.Size = New System.Drawing.Size(187, 25)
        Houses_AvailableLabel.TabIndex = 27
        Houses_AvailableLabel.Text = "Houses Available:"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(981, 391)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(83, 76)
        Me.Button2.TabIndex = 21
        Me.Button2.UseVisualStyleBackColor = False
        '
        'NestFinderManagementDataSet
        '
        Me.NestFinderManagementDataSet.DataSetName = "NestFinderManagementDataSet"
        Me.NestFinderManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AdminDetailsBindingSource
        '
        Me.AdminDetailsBindingSource.DataMember = "AdminDetails"
        Me.AdminDetailsBindingSource.DataSource = Me.NestFinderManagementDataSet
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
        'AdminDetailsBindingNavigator
        '
        Me.AdminDetailsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.AdminDetailsBindingNavigator.BindingSource = Me.AdminDetailsBindingSource
        Me.AdminDetailsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.AdminDetailsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.AdminDetailsBindingNavigator.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.AdminDetailsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.AdminDetailsBindingNavigatorSaveItem})
        Me.AdminDetailsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.AdminDetailsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.AdminDetailsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.AdminDetailsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.AdminDetailsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.AdminDetailsBindingNavigator.Name = "AdminDetailsBindingNavigator"
        Me.AdminDetailsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.AdminDetailsBindingNavigator.Size = New System.Drawing.Size(933, 33)
        Me.AdminDetailsBindingNavigator.TabIndex = 22
        Me.AdminDetailsBindingNavigator.Text = "BindingNavigator1"
        Me.AdminDetailsBindingNavigator.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(54, 28)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 33)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 31)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 33)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 33)
        '
        'AdminDetailsBindingNavigatorSaveItem
        '
        Me.AdminDetailsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AdminDetailsBindingNavigatorSaveItem.Image = CType(resources.GetObject("AdminDetailsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.AdminDetailsBindingNavigatorSaveItem.Name = "AdminDetailsBindingNavigatorSaveItem"
        Me.AdminDetailsBindingNavigatorSaveItem.Size = New System.Drawing.Size(34, 28)
        Me.AdminDetailsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdminDetailsBindingSource, "Description", True))
        Me.DescriptionTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescriptionTextBox.Location = New System.Drawing.Point(687, 64)
        Me.DescriptionTextBox.Multiline = True
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.ReadOnly = True
        Me.DescriptionTextBox.Size = New System.Drawing.Size(377, 153)
        Me.DescriptionTextBox.TabIndex = 23
        '
        'Date_of_EstablishmentLabel1
        '
        Me.Date_of_EstablishmentLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdminDetailsBindingSource, "Date of Establishment", True))
        Me.Date_of_EstablishmentLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date_of_EstablishmentLabel1.Location = New System.Drawing.Point(691, 239)
        Me.Date_of_EstablishmentLabel1.Name = "Date_of_EstablishmentLabel1"
        Me.Date_of_EstablishmentLabel1.Size = New System.Drawing.Size(193, 25)
        Me.Date_of_EstablishmentLabel1.TabIndex = 24
        Me.Date_of_EstablishmentLabel1.Text = "Label2"
        '
        'Total_SalesLabel1
        '
        Me.Total_SalesLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdminDetailsBindingSource, "Total Sales", True))
        Me.Total_SalesLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Total_SalesLabel1.Location = New System.Drawing.Point(691, 280)
        Me.Total_SalesLabel1.Name = "Total_SalesLabel1"
        Me.Total_SalesLabel1.Size = New System.Drawing.Size(193, 25)
        Me.Total_SalesLabel1.TabIndex = 25
        Me.Total_SalesLabel1.Text = "Label2"
        '
        'Total_Houses_OwnedLabel1
        '
        Me.Total_Houses_OwnedLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdminDetailsBindingSource, "Total Houses Owned", True))
        Me.Total_Houses_OwnedLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Total_Houses_OwnedLabel1.Location = New System.Drawing.Point(691, 322)
        Me.Total_Houses_OwnedLabel1.Name = "Total_Houses_OwnedLabel1"
        Me.Total_Houses_OwnedLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Total_Houses_OwnedLabel1.TabIndex = 26
        Me.Total_Houses_OwnedLabel1.Text = "Label2"
        '
        'Houses_SoldLabel1
        '
        Me.Houses_SoldLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdminDetailsBindingSource, "Houses Rented", True))
        Me.Houses_SoldLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Houses_SoldLabel1.Location = New System.Drawing.Point(691, 363)
        Me.Houses_SoldLabel1.Name = "Houses_SoldLabel1"
        Me.Houses_SoldLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Houses_SoldLabel1.TabIndex = 27
        Me.Houses_SoldLabel1.Text = "Label2"
        '
        'Houses_AvailableLabel1
        '
        Me.Houses_AvailableLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdminDetailsBindingSource, "Houses Available", True))
        Me.Houses_AvailableLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Houses_AvailableLabel1.Location = New System.Drawing.Point(691, 406)
        Me.Houses_AvailableLabel1.Name = "Houses_AvailableLabel1"
        Me.Houses_AvailableLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Houses_AvailableLabel1.TabIndex = 28
        Me.Houses_AvailableLabel1.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(109, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(256, 32)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Management System"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Ravie", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(413, 63)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Nest Finder"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Location = New System.Drawing.Point(74, 179)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(323, 288)
        Me.Panel1.TabIndex = 29
        '
        'Details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1110, 523)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Houses_AvailableLabel)
        Me.Controls.Add(Me.Houses_AvailableLabel1)
        Me.Controls.Add(Houses_SoldLabel)
        Me.Controls.Add(Me.Houses_SoldLabel1)
        Me.Controls.Add(Total_Houses_OwnedLabel)
        Me.Controls.Add(Me.Total_Houses_OwnedLabel1)
        Me.Controls.Add(Total_SalesLabel)
        Me.Controls.Add(Me.Total_SalesLabel1)
        Me.Controls.Add(Date_of_EstablishmentLabel)
        Me.Controls.Add(Me.Date_of_EstablishmentLabel1)
        Me.Controls.Add(DescriptionLabel)
        Me.Controls.Add(Me.DescriptionTextBox)
        Me.Controls.Add(Me.AdminDetailsBindingNavigator)
        Me.Controls.Add(Me.Button2)
        Me.Name = "Details"
        Me.Text = "About Nest Finder"
        CType(Me.NestFinderManagementDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdminDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdminDetailsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AdminDetailsBindingNavigator.ResumeLayout(False)
        Me.AdminDetailsBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As Button
    Friend WithEvents NestFinderManagementDataSet As NestFinderManagementDataSet
    Friend WithEvents AdminDetailsBindingSource As BindingSource
    Friend WithEvents AdminDetailsTableAdapter As NestFinderManagementDataSetTableAdapters.AdminDetailsTableAdapter
    Friend WithEvents TableAdapterManager As NestFinderManagementDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AdminDetailsBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents AdminDetailsBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents DescriptionTextBox As TextBox
    Friend WithEvents Date_of_EstablishmentLabel1 As Label
    Friend WithEvents Total_SalesLabel1 As Label
    Friend WithEvents Total_Houses_OwnedLabel1 As Label
    Friend WithEvents Houses_SoldLabel1 As Label
    Friend WithEvents Houses_AvailableLabel1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
End Class
