<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RegisterBuyer
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
        Dim Full_NameLabel As System.Windows.Forms.Label
        Dim AgeLabel As System.Windows.Forms.Label
        Dim Contact_NumberLabel As System.Windows.Forms.Label
        Dim BudgetLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim Current_LocationLabel As System.Windows.Forms.Label
        Dim Preferred_House_TypeLabel As System.Windows.Forms.Label
        Dim IC_NumberLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegisterBuyer))
        Me.BuyersBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BuyersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NestFinderManagementDataSet = New Nest_Finder.NestFinderManagementDataSet()
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
        Me.BuyersBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Full_NameTextBox = New System.Windows.Forms.TextBox()
        Me.AgeTextBox = New System.Windows.Forms.TextBox()
        Me.Contact_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.BudgetTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GenderTextBox = New System.Windows.Forms.TextBox()
        Me.Current_LocationTextBox = New System.Windows.Forms.TextBox()
        Me.Preferred_House_TypeTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BuyersTableAdapter = New Nest_Finder.NestFinderManagementDataSetTableAdapters.BuyersTableAdapter()
        Me.TableAdapterManager = New Nest_Finder.NestFinderManagementDataSetTableAdapters.TableAdapterManager()
        Me.IC_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Full_NameLabel = New System.Windows.Forms.Label()
        AgeLabel = New System.Windows.Forms.Label()
        Contact_NumberLabel = New System.Windows.Forms.Label()
        BudgetLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        Current_LocationLabel = New System.Windows.Forms.Label()
        Preferred_House_TypeLabel = New System.Windows.Forms.Label()
        IC_NumberLabel = New System.Windows.Forms.Label()
        CType(Me.BuyersBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BuyersBindingNavigator.SuspendLayout()
        CType(Me.BuyersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NestFinderManagementDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Full_NameLabel
        '
        Full_NameLabel.AutoSize = True
        Full_NameLabel.BackColor = System.Drawing.Color.Transparent
        Full_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Full_NameLabel.Location = New System.Drawing.Point(148, 127)
        Full_NameLabel.Name = "Full_NameLabel"
        Full_NameLabel.Size = New System.Drawing.Size(96, 22)
        Full_NameLabel.TabIndex = 23
        Full_NameLabel.Text = "Full Name:"
        '
        'AgeLabel
        '
        AgeLabel.AutoSize = True
        AgeLabel.BackColor = System.Drawing.Color.Transparent
        AgeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AgeLabel.Location = New System.Drawing.Point(197, 229)
        AgeLabel.Name = "AgeLabel"
        AgeLabel.Size = New System.Drawing.Size(47, 22)
        AgeLabel.TabIndex = 25
        AgeLabel.Text = "Age:"
        '
        'Contact_NumberLabel
        '
        Contact_NumberLabel.AutoSize = True
        Contact_NumberLabel.BackColor = System.Drawing.Color.Transparent
        Contact_NumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Contact_NumberLabel.Location = New System.Drawing.Point(99, 263)
        Contact_NumberLabel.Name = "Contact_NumberLabel"
        Contact_NumberLabel.Size = New System.Drawing.Size(145, 22)
        Contact_NumberLabel.TabIndex = 26
        Contact_NumberLabel.Text = "Contact Number:"
        '
        'BudgetLabel
        '
        BudgetLabel.AutoSize = True
        BudgetLabel.BackColor = System.Drawing.Color.Transparent
        BudgetLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BudgetLabel.Location = New System.Drawing.Point(172, 365)
        BudgetLabel.Name = "BudgetLabel"
        BudgetLabel.Size = New System.Drawing.Size(72, 22)
        BudgetLabel.TabIndex = 29
        BudgetLabel.Text = "Budget:"
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.BackColor = System.Drawing.Color.Transparent
        GenderLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GenderLabel.Location = New System.Drawing.Point(169, 195)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(75, 22)
        GenderLabel.TabIndex = 35
        GenderLabel.Text = "Gender:"
        '
        'Current_LocationLabel
        '
        Current_LocationLabel.AutoSize = True
        Current_LocationLabel.BackColor = System.Drawing.Color.Transparent
        Current_LocationLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Current_LocationLabel.Location = New System.Drawing.Point(96, 297)
        Current_LocationLabel.Name = "Current_LocationLabel"
        Current_LocationLabel.Size = New System.Drawing.Size(148, 22)
        Current_LocationLabel.TabIndex = 36
        Current_LocationLabel.Text = "Current Location:"
        '
        'Preferred_House_TypeLabel
        '
        Preferred_House_TypeLabel.AutoSize = True
        Preferred_House_TypeLabel.BackColor = System.Drawing.Color.Transparent
        Preferred_House_TypeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Preferred_House_TypeLabel.Location = New System.Drawing.Point(51, 331)
        Preferred_House_TypeLabel.Name = "Preferred_House_TypeLabel"
        Preferred_House_TypeLabel.Size = New System.Drawing.Size(193, 22)
        Preferred_House_TypeLabel.TabIndex = 37
        Preferred_House_TypeLabel.Text = "Preferred House Type:"
        '
        'IC_NumberLabel
        '
        IC_NumberLabel.AutoSize = True
        IC_NumberLabel.BackColor = System.Drawing.Color.Transparent
        IC_NumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IC_NumberLabel.Location = New System.Drawing.Point(144, 161)
        IC_NumberLabel.Name = "IC_NumberLabel"
        IC_NumberLabel.Size = New System.Drawing.Size(100, 22)
        IC_NumberLabel.TabIndex = 39
        IC_NumberLabel.Text = "IC Number:"
        '
        'BuyersBindingNavigator
        '
        Me.BuyersBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BuyersBindingNavigator.BindingSource = Me.BuyersBindingSource
        Me.BuyersBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.BuyersBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BuyersBindingNavigator.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.BuyersBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.BuyersBindingNavigatorSaveItem})
        Me.BuyersBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.BuyersBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BuyersBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BuyersBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BuyersBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BuyersBindingNavigator.Name = "BuyersBindingNavigator"
        Me.BuyersBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.BuyersBindingNavigator.Size = New System.Drawing.Size(800, 33)
        Me.BuyersBindingNavigator.TabIndex = 23
        Me.BuyersBindingNavigator.Text = "BindingNavigator1"
        Me.BuyersBindingNavigator.Visible = False
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
        'BuyersBindingSource
        '
        Me.BuyersBindingSource.DataMember = "Buyers"
        Me.BuyersBindingSource.DataSource = Me.NestFinderManagementDataSet
        '
        'NestFinderManagementDataSet
        '
        Me.NestFinderManagementDataSet.DataSetName = "NestFinderManagementDataSet"
        Me.NestFinderManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'BuyersBindingNavigatorSaveItem
        '
        Me.BuyersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BuyersBindingNavigatorSaveItem.Image = CType(resources.GetObject("BuyersBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.BuyersBindingNavigatorSaveItem.Name = "BuyersBindingNavigatorSaveItem"
        Me.BuyersBindingNavigatorSaveItem.Size = New System.Drawing.Size(34, 28)
        Me.BuyersBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Full_NameTextBox
        '
        Me.Full_NameTextBox.BackColor = System.Drawing.Color.White
        Me.Full_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuyersBindingSource, "Full Name", True))
        Me.Full_NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Full_NameTextBox.Location = New System.Drawing.Point(266, 124)
        Me.Full_NameTextBox.Name = "Full_NameTextBox"
        Me.Full_NameTextBox.Size = New System.Drawing.Size(342, 28)
        Me.Full_NameTextBox.TabIndex = 24
        '
        'AgeTextBox
        '
        Me.AgeTextBox.BackColor = System.Drawing.SystemColors.ControlLight
        Me.AgeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuyersBindingSource, "Age", True))
        Me.AgeTextBox.Enabled = False
        Me.AgeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgeTextBox.Location = New System.Drawing.Point(266, 226)
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(100, 28)
        Me.AgeTextBox.TabIndex = 26
        '
        'Contact_NumberTextBox
        '
        Me.Contact_NumberTextBox.BackColor = System.Drawing.Color.White
        Me.Contact_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuyersBindingSource, "Contact Number", True))
        Me.Contact_NumberTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Contact_NumberTextBox.Location = New System.Drawing.Point(266, 260)
        Me.Contact_NumberTextBox.Name = "Contact_NumberTextBox"
        Me.Contact_NumberTextBox.Size = New System.Drawing.Size(190, 28)
        Me.Contact_NumberTextBox.TabIndex = 27
        '
        'BudgetTextBox
        '
        Me.BudgetTextBox.BackColor = System.Drawing.Color.White
        Me.BudgetTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuyersBindingSource, "Budget", True))
        Me.BudgetTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BudgetTextBox.Location = New System.Drawing.Point(266, 362)
        Me.BudgetTextBox.Name = "BudgetTextBox"
        Me.BudgetTextBox.Size = New System.Drawing.Size(100, 28)
        Me.BudgetTextBox.TabIndex = 30
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(538, 333)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 57)
        Me.Button1.TabIndex = 34
        Me.Button1.Text = "ADD"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(664, 333)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(107, 57)
        Me.Button2.TabIndex = 35
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'GenderTextBox
        '
        Me.GenderTextBox.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GenderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuyersBindingSource, "Gender", True))
        Me.GenderTextBox.Enabled = False
        Me.GenderTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenderTextBox.Location = New System.Drawing.Point(266, 192)
        Me.GenderTextBox.Name = "GenderTextBox"
        Me.GenderTextBox.Size = New System.Drawing.Size(100, 28)
        Me.GenderTextBox.TabIndex = 36
        '
        'Current_LocationTextBox
        '
        Me.Current_LocationTextBox.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Current_LocationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuyersBindingSource, "Current Location", True))
        Me.Current_LocationTextBox.Enabled = False
        Me.Current_LocationTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Current_LocationTextBox.Location = New System.Drawing.Point(266, 294)
        Me.Current_LocationTextBox.Name = "Current_LocationTextBox"
        Me.Current_LocationTextBox.Size = New System.Drawing.Size(190, 28)
        Me.Current_LocationTextBox.TabIndex = 37
        '
        'Preferred_House_TypeTextBox
        '
        Me.Preferred_House_TypeTextBox.BackColor = System.Drawing.Color.White
        Me.Preferred_House_TypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuyersBindingSource, "Preferred House Type", True))
        Me.Preferred_House_TypeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Preferred_House_TypeTextBox.Location = New System.Drawing.Point(266, 328)
        Me.Preferred_House_TypeTextBox.Name = "Preferred_House_TypeTextBox"
        Me.Preferred_House_TypeTextBox.Size = New System.Drawing.Size(190, 28)
        Me.Preferred_House_TypeTextBox.TabIndex = 38
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label1.Font = New System.Drawing.Font("Malgun Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(147, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(470, 28)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Click ADD to fill in your details, then click SAVE."
        '
        'BuyersTableAdapter
        '
        Me.BuyersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AdminDetailsTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BuyersTableAdapter = Me.BuyersTableAdapter
        Me.TableAdapterManager.PropertiesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Nest_Finder.NestFinderManagementDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'IC_NumberTextBox
        '
        Me.IC_NumberTextBox.BackColor = System.Drawing.Color.White
        Me.IC_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BuyersBindingSource, "IC Number", True))
        Me.IC_NumberTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IC_NumberTextBox.Location = New System.Drawing.Point(266, 158)
        Me.IC_NumberTextBox.Name = "IC_NumberTextBox"
        Me.IC_NumberTextBox.Size = New System.Drawing.Size(190, 28)
        Me.IC_NumberTextBox.TabIndex = 40
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(538, 260)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(107, 57)
        Me.Button3.TabIndex = 41
        Me.Button3.Text = "Check IC"
        Me.Button3.UseVisualStyleBackColor = False
        Me.Button3.Visible = False
        '
        'RegisterBuyer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(819, 438)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(IC_NumberLabel)
        Me.Controls.Add(Me.IC_NumberTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Preferred_House_TypeLabel)
        Me.Controls.Add(Me.Preferred_House_TypeTextBox)
        Me.Controls.Add(Current_LocationLabel)
        Me.Controls.Add(Me.Current_LocationTextBox)
        Me.Controls.Add(GenderLabel)
        Me.Controls.Add(Me.GenderTextBox)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(BudgetLabel)
        Me.Controls.Add(Me.BudgetTextBox)
        Me.Controls.Add(Contact_NumberLabel)
        Me.Controls.Add(Me.Contact_NumberTextBox)
        Me.Controls.Add(AgeLabel)
        Me.Controls.Add(Me.AgeTextBox)
        Me.Controls.Add(Full_NameLabel)
        Me.Controls.Add(Me.Full_NameTextBox)
        Me.Controls.Add(Me.BuyersBindingNavigator)
        Me.Name = "RegisterBuyer"
        Me.Text = "Register"
        CType(Me.BuyersBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BuyersBindingNavigator.ResumeLayout(False)
        Me.BuyersBindingNavigator.PerformLayout()
        CType(Me.BuyersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NestFinderManagementDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NestFinderManagementDataSet As NestFinderManagementDataSet
    Friend WithEvents BuyersBindingSource As BindingSource
    Friend WithEvents BuyersTableAdapter As NestFinderManagementDataSetTableAdapters.BuyersTableAdapter
    Friend WithEvents TableAdapterManager As NestFinderManagementDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BuyersBindingNavigator As BindingNavigator
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
    Friend WithEvents BuyersBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Full_NameTextBox As TextBox
    Friend WithEvents AgeTextBox As TextBox
    Friend WithEvents Contact_NumberTextBox As TextBox
    Friend WithEvents BudgetTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents GenderTextBox As TextBox
    Friend WithEvents Current_LocationTextBox As TextBox
    Friend WithEvents Preferred_House_TypeTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents IC_NumberTextBox As TextBox
    Friend WithEvents Button3 As Button
End Class
