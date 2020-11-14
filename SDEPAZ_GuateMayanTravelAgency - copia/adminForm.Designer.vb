<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminForm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(adminForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.AgenciaTravelDataSet = New SDEPAZ_GuateMayanTravelAgency.AgenciaTravelDataSet()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesTableAdapter = New SDEPAZ_GuateMayanTravelAgency.AgenciaTravelDataSetTableAdapters.ClientesTableAdapter()
        Me.IdClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrimernombreClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SegundonombreClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrimerapellidoClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SegundoapellidoClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DpiClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IddestinoClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AgenciaTravelDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label1.Location = New System.Drawing.Point(53, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Cliente ID:"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "idCliente", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.ClientesBindingSource, "idCliente", True))
        Me.TextBox1.Location = New System.Drawing.Point(135, 34)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(195, 20)
        Me.TextBox1.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "primernombreCliente", True))
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.ClientesBindingSource, "primernombreCliente", True))
        Me.TextBox2.Location = New System.Drawing.Point(135, 65)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(195, 20)
        Me.TextBox2.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label2.Location = New System.Drawing.Point(11, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Segundo nombre:"
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "segundonombreCliente", True))
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.ClientesBindingSource, "segundonombreCliente", True))
        Me.TextBox3.Location = New System.Drawing.Point(135, 93)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(195, 20)
        Me.TextBox3.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label3.Location = New System.Drawing.Point(25, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Primer nombre:"
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "primerapellidoCliente", True))
        Me.TextBox4.Location = New System.Drawing.Point(135, 119)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(195, 20)
        Me.TextBox4.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label4.Location = New System.Drawing.Point(17, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Primer apellido:"
        '
        'TextBox5
        '
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "dpiCliente", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N0"))
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.ClientesBindingSource, "dpiCliente", True))
        Me.TextBox5.Location = New System.Drawing.Point(135, 207)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(195, 20)
        Me.TextBox5.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label5.Location = New System.Drawing.Point(90, 208)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 15)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "DPI:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label6.Location = New System.Drawing.Point(60, 172)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 15)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Telefono:"
        '
        'TextBox7
        '
        Me.TextBox7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "telefonoCliente", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N0"))
        Me.TextBox7.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.ClientesBindingSource, "telefonoCliente", True))
        Me.TextBox7.Location = New System.Drawing.Point(135, 172)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(195, 20)
        Me.TextBox7.TabIndex = 5
        '
        'TextBox8
        '
        Me.TextBox8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "segundoapellidoCliente", True))
        Me.TextBox8.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.ClientesBindingSource, "segundoapellidoCliente", True))
        Me.TextBox8.Location = New System.Drawing.Point(135, 146)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(195, 20)
        Me.TextBox8.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label8.Location = New System.Drawing.Point(3, 144)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(124, 15)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Segundo apellido:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label10.Location = New System.Drawing.Point(51, 244)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 15)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "ID Destino:"
        '
        'TextBox11
        '
        Me.TextBox11.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "emailCliente", True))
        Me.TextBox11.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.ClientesBindingSource, "emailCliente", True))
        Me.TextBox11.Location = New System.Drawing.Point(135, 272)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(195, 20)
        Me.TextBox11.TabIndex = 10
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label11.Location = New System.Drawing.Point(76, 277)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 15)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Email:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 352)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 36)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Agregar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(93, 352)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 36)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "Eliminar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(174, 352)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 36)
        Me.Button3.TabIndex = 22
        Me.Button3.Text = "Actualizar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(255, 352)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 36)
        Me.Button4.TabIndex = 23
        Me.Button4.Text = "Cancelar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'TextBox10
        '
        Me.TextBox10.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "iddestinoCliente", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N0"))
        Me.TextBox10.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.ClientesBindingSource, "iddestinoCliente", True))
        Me.TextBox10.Location = New System.Drawing.Point(135, 243)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(195, 20)
        Me.TextBox10.TabIndex = 7
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(645, 352)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 36)
        Me.Button5.TabIndex = 25
        Me.Button5.Text = "Cerrar"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdClienteDataGridViewTextBoxColumn, Me.PrimernombreClienteDataGridViewTextBoxColumn, Me.SegundonombreClienteDataGridViewTextBoxColumn, Me.PrimerapellidoClienteDataGridViewTextBoxColumn, Me.SegundoapellidoClienteDataGridViewTextBoxColumn, Me.TelefonoClienteDataGridViewTextBoxColumn, Me.DpiClienteDataGridViewTextBoxColumn, Me.IddestinoClienteDataGridViewTextBoxColumn, Me.EmailClienteDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ClientesBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(391, 39)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(565, 153)
        Me.DataGridView1.TabIndex = 26
        '
        'AgenciaTravelDataSet
        '
        Me.AgenciaTravelDataSet.DataSetName = "AgenciaTravelDataSet"
        Me.AgenciaTravelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.AgenciaTravelDataSet
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'IdClienteDataGridViewTextBoxColumn
        '
        Me.IdClienteDataGridViewTextBoxColumn.DataPropertyName = "idCliente"
        Me.IdClienteDataGridViewTextBoxColumn.HeaderText = "idCliente"
        Me.IdClienteDataGridViewTextBoxColumn.Name = "IdClienteDataGridViewTextBoxColumn"
        Me.IdClienteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrimernombreClienteDataGridViewTextBoxColumn
        '
        Me.PrimernombreClienteDataGridViewTextBoxColumn.DataPropertyName = "primernombreCliente"
        Me.PrimernombreClienteDataGridViewTextBoxColumn.HeaderText = "primernombreCliente"
        Me.PrimernombreClienteDataGridViewTextBoxColumn.Name = "PrimernombreClienteDataGridViewTextBoxColumn"
        '
        'SegundonombreClienteDataGridViewTextBoxColumn
        '
        Me.SegundonombreClienteDataGridViewTextBoxColumn.DataPropertyName = "segundonombreCliente"
        Me.SegundonombreClienteDataGridViewTextBoxColumn.HeaderText = "segundonombreCliente"
        Me.SegundonombreClienteDataGridViewTextBoxColumn.Name = "SegundonombreClienteDataGridViewTextBoxColumn"
        '
        'PrimerapellidoClienteDataGridViewTextBoxColumn
        '
        Me.PrimerapellidoClienteDataGridViewTextBoxColumn.DataPropertyName = "primerapellidoCliente"
        Me.PrimerapellidoClienteDataGridViewTextBoxColumn.HeaderText = "primerapellidoCliente"
        Me.PrimerapellidoClienteDataGridViewTextBoxColumn.Name = "PrimerapellidoClienteDataGridViewTextBoxColumn"
        '
        'SegundoapellidoClienteDataGridViewTextBoxColumn
        '
        Me.SegundoapellidoClienteDataGridViewTextBoxColumn.DataPropertyName = "segundoapellidoCliente"
        Me.SegundoapellidoClienteDataGridViewTextBoxColumn.HeaderText = "segundoapellidoCliente"
        Me.SegundoapellidoClienteDataGridViewTextBoxColumn.Name = "SegundoapellidoClienteDataGridViewTextBoxColumn"
        '
        'TelefonoClienteDataGridViewTextBoxColumn
        '
        Me.TelefonoClienteDataGridViewTextBoxColumn.DataPropertyName = "telefonoCliente"
        Me.TelefonoClienteDataGridViewTextBoxColumn.HeaderText = "telefonoCliente"
        Me.TelefonoClienteDataGridViewTextBoxColumn.Name = "TelefonoClienteDataGridViewTextBoxColumn"
        '
        'DpiClienteDataGridViewTextBoxColumn
        '
        Me.DpiClienteDataGridViewTextBoxColumn.DataPropertyName = "dpiCliente"
        Me.DpiClienteDataGridViewTextBoxColumn.HeaderText = "dpiCliente"
        Me.DpiClienteDataGridViewTextBoxColumn.Name = "DpiClienteDataGridViewTextBoxColumn"
        '
        'IddestinoClienteDataGridViewTextBoxColumn
        '
        Me.IddestinoClienteDataGridViewTextBoxColumn.DataPropertyName = "iddestinoCliente"
        Me.IddestinoClienteDataGridViewTextBoxColumn.HeaderText = "iddestinoCliente"
        Me.IddestinoClienteDataGridViewTextBoxColumn.Name = "IddestinoClienteDataGridViewTextBoxColumn"
        '
        'EmailClienteDataGridViewTextBoxColumn
        '
        Me.EmailClienteDataGridViewTextBoxColumn.DataPropertyName = "emailCliente"
        Me.EmailClienteDataGridViewTextBoxColumn.HeaderText = "emailCliente"
        Me.EmailClienteDataGridViewTextBoxColumn.Name = "EmailClienteDataGridViewTextBoxColumn"
        '
        'adminForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(968, 474)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox10)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TextBox11)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "adminForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AgenciaTravelDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents AgenciaTravelDataSet As SDEPAZ_GuateMayanTravelAgency.AgenciaTravelDataSet
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents ClientesTableAdapter As SDEPAZ_GuateMayanTravelAgency.AgenciaTravelDataSetTableAdapters.ClientesTableAdapter
    Friend WithEvents IdClienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrimernombreClienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SegundonombreClienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrimerapellidoClienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SegundoapellidoClienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelefonoClienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DpiClienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IddestinoClienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailClienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
