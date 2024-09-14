﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated by a tool.
'     Runtime Version: 1.1.4322.2470
'
'     Changes to this file may cause incorrect behavior and will be lost if 
'     the code is regenerated.
' </autogenerated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System
Imports System.Data
Imports System.Runtime.Serialization
Imports System.Xml


<Serializable(),  _
 System.ComponentModel.DesignerCategoryAttribute("code"),  _
 System.Diagnostics.DebuggerStepThrough(),  _
 System.ComponentModel.ToolboxItem(true)>  _
Public Class Dataset2
    Inherits DataSet
    
    Private tableVIEW_MEM_RPR As VIEW_MEM_RPRDataTable
    
    Public Sub New()
        MyBase.New
        Me.InitClass
        Dim schemaChangedHandler As System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
        AddHandler Me.Tables.CollectionChanged, schemaChangedHandler
        AddHandler Me.Relations.CollectionChanged, schemaChangedHandler
    End Sub
    
    Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
        MyBase.New
        Dim strSchema As String = CType(info.GetValue("XmlSchema", GetType(System.String)),String)
        If (Not (strSchema) Is Nothing) Then
            Dim ds As DataSet = New DataSet
            ds.ReadXmlSchema(New XmlTextReader(New System.IO.StringReader(strSchema)))
            If (Not (ds.Tables("VIEW_MEM_RPR")) Is Nothing) Then
                Me.Tables.Add(New VIEW_MEM_RPRDataTable(ds.Tables("VIEW_MEM_RPR")))
            End If
            Me.DataSetName = ds.DataSetName
            Me.Prefix = ds.Prefix
            Me.Namespace = ds.Namespace
            Me.Locale = ds.Locale
            Me.CaseSensitive = ds.CaseSensitive
            Me.EnforceConstraints = ds.EnforceConstraints
            Me.Merge(ds, false, System.Data.MissingSchemaAction.Add)
            Me.InitVars
        Else
            Me.InitClass
        End If
        Me.GetSerializationData(info, context)
        Dim schemaChangedHandler As System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
        AddHandler Me.Tables.CollectionChanged, schemaChangedHandler
        AddHandler Me.Relations.CollectionChanged, schemaChangedHandler
    End Sub
    
    <System.ComponentModel.Browsable(false),  _
     System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)>  _
    Public ReadOnly Property VIEW_MEM_RPR As VIEW_MEM_RPRDataTable
        Get
            Return Me.tableVIEW_MEM_RPR
        End Get
    End Property
    
    Public Overrides Function Clone() As DataSet
        Dim cln As Dataset2 = CType(MyBase.Clone,Dataset2)
        cln.InitVars
        Return cln
    End Function
    
    Protected Overrides Function ShouldSerializeTables() As Boolean
        Return false
    End Function
    
    Protected Overrides Function ShouldSerializeRelations() As Boolean
        Return false
    End Function
    
    Protected Overrides Sub ReadXmlSerializable(ByVal reader As XmlReader)
        Me.Reset
        Dim ds As DataSet = New DataSet
        ds.ReadXml(reader)
        If (Not (ds.Tables("VIEW_MEM_RPR")) Is Nothing) Then
            Me.Tables.Add(New VIEW_MEM_RPRDataTable(ds.Tables("VIEW_MEM_RPR")))
        End If
        Me.DataSetName = ds.DataSetName
        Me.Prefix = ds.Prefix
        Me.Namespace = ds.Namespace
        Me.Locale = ds.Locale
        Me.CaseSensitive = ds.CaseSensitive
        Me.EnforceConstraints = ds.EnforceConstraints
        Me.Merge(ds, false, System.Data.MissingSchemaAction.Add)
        Me.InitVars
    End Sub
    
    Protected Overrides Function GetSchemaSerializable() As System.Xml.Schema.XmlSchema
        Dim stream As System.IO.MemoryStream = New System.IO.MemoryStream
        Me.WriteXmlSchema(New XmlTextWriter(stream, Nothing))
        stream.Position = 0
        Return System.Xml.Schema.XmlSchema.Read(New XmlTextReader(stream), Nothing)
    End Function
    
    Friend Sub InitVars()
        Me.tableVIEW_MEM_RPR = CType(Me.Tables("VIEW_MEM_RPR"),VIEW_MEM_RPRDataTable)
        If (Not (Me.tableVIEW_MEM_RPR) Is Nothing) Then
            Me.tableVIEW_MEM_RPR.InitVars
        End If
    End Sub
    
    Private Sub InitClass()
        Me.DataSetName = "Dataset2"
        Me.Prefix = ""
        Me.Namespace = "http://tempuri.org/Dataset2.xsd"
        Me.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CaseSensitive = false
        Me.EnforceConstraints = true
        Me.tableVIEW_MEM_RPR = New VIEW_MEM_RPRDataTable
        Me.Tables.Add(Me.tableVIEW_MEM_RPR)
    End Sub
    
    Private Function ShouldSerializeVIEW_MEM_RPR() As Boolean
        Return false
    End Function
    
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    Public Delegate Sub VIEW_MEM_RPRRowChangeEventHandler(ByVal sender As Object, ByVal e As VIEW_MEM_RPRRowChangeEvent)
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class VIEW_MEM_RPRDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnMCODE As DataColumn
        
        Private columnMNAME As DataColumn
        
        Private columnDOB As DataColumn
        
        Private columnDOJ As DataColumn
        
        Private columnCurentStatus As DataColumn
        
        Private columnMEMBERTYPECODE As DataColumn
        
        Private columnmem_code As DataColumn
        
        Private columnname As DataColumn
        
        Private columnrelation As DataColumn
        
        Friend Sub New()
            MyBase.New("VIEW_MEM_RPR")
            Me.InitClass
        End Sub
        
        Friend Sub New(ByVal table As DataTable)
            MyBase.New(table.TableName)
            If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                Me.CaseSensitive = table.CaseSensitive
            End If
            If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                Me.Locale = table.Locale
            End If
            If (table.Namespace <> table.DataSet.Namespace) Then
                Me.Namespace = table.Namespace
            End If
            Me.Prefix = table.Prefix
            Me.MinimumCapacity = table.MinimumCapacity
            Me.DisplayExpression = table.DisplayExpression
        End Sub
        
        <System.ComponentModel.Browsable(false)>  _
        Public ReadOnly Property Count As Integer
            Get
                Return Me.Rows.Count
            End Get
        End Property
        
        Friend ReadOnly Property MCODEColumn As DataColumn
            Get
                Return Me.columnMCODE
            End Get
        End Property
        
        Friend ReadOnly Property MNAMEColumn As DataColumn
            Get
                Return Me.columnMNAME
            End Get
        End Property
        
        Friend ReadOnly Property DOBColumn As DataColumn
            Get
                Return Me.columnDOB
            End Get
        End Property
        
        Friend ReadOnly Property DOJColumn As DataColumn
            Get
                Return Me.columnDOJ
            End Get
        End Property
        
        Friend ReadOnly Property CurentStatusColumn As DataColumn
            Get
                Return Me.columnCurentStatus
            End Get
        End Property
        
        Friend ReadOnly Property MEMBERTYPECODEColumn As DataColumn
            Get
                Return Me.columnMEMBERTYPECODE
            End Get
        End Property
        
        Friend ReadOnly Property mem_codeColumn As DataColumn
            Get
                Return Me.columnmem_code
            End Get
        End Property
        
        Friend ReadOnly Property nameColumn As DataColumn
            Get
                Return Me.columnname
            End Get
        End Property
        
        Friend ReadOnly Property relationColumn As DataColumn
            Get
                Return Me.columnrelation
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As VIEW_MEM_RPRRow
            Get
                Return CType(Me.Rows(index),VIEW_MEM_RPRRow)
            End Get
        End Property
        
        Public Event VIEW_MEM_RPRRowChanged As VIEW_MEM_RPRRowChangeEventHandler
        
        Public Event VIEW_MEM_RPRRowChanging As VIEW_MEM_RPRRowChangeEventHandler
        
        Public Event VIEW_MEM_RPRRowDeleted As VIEW_MEM_RPRRowChangeEventHandler
        
        Public Event VIEW_MEM_RPRRowDeleting As VIEW_MEM_RPRRowChangeEventHandler
        
        Public Overloads Sub AddVIEW_MEM_RPRRow(ByVal row As VIEW_MEM_RPRRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddVIEW_MEM_RPRRow(ByVal MCODE As String, ByVal MNAME As String, ByVal DOB As Date, ByVal DOJ As Date, ByVal CurentStatus As String, ByVal MEMBERTYPECODE As String, ByVal mem_code As String, ByVal name As String, ByVal relation As String) As VIEW_MEM_RPRRow
            Dim rowVIEW_MEM_RPRRow As VIEW_MEM_RPRRow = CType(Me.NewRow,VIEW_MEM_RPRRow)
            rowVIEW_MEM_RPRRow.ItemArray = New Object() {MCODE, MNAME, DOB, DOJ, CurentStatus, MEMBERTYPECODE, mem_code, name, relation}
            Me.Rows.Add(rowVIEW_MEM_RPRRow)
            Return rowVIEW_MEM_RPRRow
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As VIEW_MEM_RPRDataTable = CType(MyBase.Clone,VIEW_MEM_RPRDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New VIEW_MEM_RPRDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnMCODE = Me.Columns("MCODE")
            Me.columnMNAME = Me.Columns("MNAME")
            Me.columnDOB = Me.Columns("DOB")
            Me.columnDOJ = Me.Columns("DOJ")
            Me.columnCurentStatus = Me.Columns("CurentStatus")
            Me.columnMEMBERTYPECODE = Me.Columns("MEMBERTYPECODE")
            Me.columnmem_code = Me.Columns("mem_code")
            Me.columnname = Me.Columns("name")
            Me.columnrelation = Me.Columns("relation")
        End Sub
        
        Private Sub InitClass()
            Me.columnMCODE = New DataColumn("MCODE", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnMCODE)
            Me.columnMNAME = New DataColumn("MNAME", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnMNAME)
            Me.columnDOB = New DataColumn("DOB", GetType(System.DateTime), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnDOB)
            Me.columnDOJ = New DataColumn("DOJ", GetType(System.DateTime), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnDOJ)
            Me.columnCurentStatus = New DataColumn("CurentStatus", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnCurentStatus)
            Me.columnMEMBERTYPECODE = New DataColumn("MEMBERTYPECODE", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnMEMBERTYPECODE)
            Me.columnmem_code = New DataColumn("mem_code", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnmem_code)
            Me.columnname = New DataColumn("name", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnname)
            Me.columnrelation = New DataColumn("relation", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnrelation)
            Me.columnMCODE.AllowDBNull = false
        End Sub
        
        Public Function NewVIEW_MEM_RPRRow() As VIEW_MEM_RPRRow
            Return CType(Me.NewRow,VIEW_MEM_RPRRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New VIEW_MEM_RPRRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(VIEW_MEM_RPRRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.VIEW_MEM_RPRRowChangedEvent) Is Nothing) Then
                RaiseEvent VIEW_MEM_RPRRowChanged(Me, New VIEW_MEM_RPRRowChangeEvent(CType(e.Row,VIEW_MEM_RPRRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.VIEW_MEM_RPRRowChangingEvent) Is Nothing) Then
                RaiseEvent VIEW_MEM_RPRRowChanging(Me, New VIEW_MEM_RPRRowChangeEvent(CType(e.Row,VIEW_MEM_RPRRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.VIEW_MEM_RPRRowDeletedEvent) Is Nothing) Then
                RaiseEvent VIEW_MEM_RPRRowDeleted(Me, New VIEW_MEM_RPRRowChangeEvent(CType(e.Row,VIEW_MEM_RPRRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.VIEW_MEM_RPRRowDeletingEvent) Is Nothing) Then
                RaiseEvent VIEW_MEM_RPRRowDeleting(Me, New VIEW_MEM_RPRRowChangeEvent(CType(e.Row,VIEW_MEM_RPRRow), e.Action))
            End If
        End Sub
        
        Public Sub RemoveVIEW_MEM_RPRRow(ByVal row As VIEW_MEM_RPRRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class VIEW_MEM_RPRRow
        Inherits DataRow
        
        Private tableVIEW_MEM_RPR As VIEW_MEM_RPRDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tableVIEW_MEM_RPR = CType(Me.Table,VIEW_MEM_RPRDataTable)
        End Sub
        
        Public Property MCODE As String
            Get
                Return CType(Me(Me.tableVIEW_MEM_RPR.MCODEColumn),String)
            End Get
            Set
                Me(Me.tableVIEW_MEM_RPR.MCODEColumn) = value
            End Set
        End Property
        
        Public Property MNAME As String
            Get
                Try 
                    Return CType(Me(Me.tableVIEW_MEM_RPR.MNAMEColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableVIEW_MEM_RPR.MNAMEColumn) = value
            End Set
        End Property
        
        Public Property DOB As Date
            Get
                Try 
                    Return CType(Me(Me.tableVIEW_MEM_RPR.DOBColumn),Date)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableVIEW_MEM_RPR.DOBColumn) = value
            End Set
        End Property
        
        Public Property DOJ As Date
            Get
                Try 
                    Return CType(Me(Me.tableVIEW_MEM_RPR.DOJColumn),Date)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableVIEW_MEM_RPR.DOJColumn) = value
            End Set
        End Property
        
        Public Property CurentStatus As String
            Get
                Try 
                    Return CType(Me(Me.tableVIEW_MEM_RPR.CurentStatusColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableVIEW_MEM_RPR.CurentStatusColumn) = value
            End Set
        End Property
        
        Public Property MEMBERTYPECODE As String
            Get
                Try 
                    Return CType(Me(Me.tableVIEW_MEM_RPR.MEMBERTYPECODEColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableVIEW_MEM_RPR.MEMBERTYPECODEColumn) = value
            End Set
        End Property
        
        Public Property mem_code As String
            Get
                Try 
                    Return CType(Me(Me.tableVIEW_MEM_RPR.mem_codeColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableVIEW_MEM_RPR.mem_codeColumn) = value
            End Set
        End Property
        
        Public Property name As String
            Get
                Try 
                    Return CType(Me(Me.tableVIEW_MEM_RPR.nameColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableVIEW_MEM_RPR.nameColumn) = value
            End Set
        End Property
        
        Public Property relation As String
            Get
                Try 
                    Return CType(Me(Me.tableVIEW_MEM_RPR.relationColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableVIEW_MEM_RPR.relationColumn) = value
            End Set
        End Property
        
        Public Function IsMNAMENull() As Boolean
            Return Me.IsNull(Me.tableVIEW_MEM_RPR.MNAMEColumn)
        End Function
        
        Public Sub SetMNAMENull()
            Me(Me.tableVIEW_MEM_RPR.MNAMEColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsDOBNull() As Boolean
            Return Me.IsNull(Me.tableVIEW_MEM_RPR.DOBColumn)
        End Function
        
        Public Sub SetDOBNull()
            Me(Me.tableVIEW_MEM_RPR.DOBColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsDOJNull() As Boolean
            Return Me.IsNull(Me.tableVIEW_MEM_RPR.DOJColumn)
        End Function
        
        Public Sub SetDOJNull()
            Me(Me.tableVIEW_MEM_RPR.DOJColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsCurentStatusNull() As Boolean
            Return Me.IsNull(Me.tableVIEW_MEM_RPR.CurentStatusColumn)
        End Function
        
        Public Sub SetCurentStatusNull()
            Me(Me.tableVIEW_MEM_RPR.CurentStatusColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsMEMBERTYPECODENull() As Boolean
            Return Me.IsNull(Me.tableVIEW_MEM_RPR.MEMBERTYPECODEColumn)
        End Function
        
        Public Sub SetMEMBERTYPECODENull()
            Me(Me.tableVIEW_MEM_RPR.MEMBERTYPECODEColumn) = System.Convert.DBNull
        End Sub
        
        Public Function Ismem_codeNull() As Boolean
            Return Me.IsNull(Me.tableVIEW_MEM_RPR.mem_codeColumn)
        End Function
        
        Public Sub Setmem_codeNull()
            Me(Me.tableVIEW_MEM_RPR.mem_codeColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsnameNull() As Boolean
            Return Me.IsNull(Me.tableVIEW_MEM_RPR.nameColumn)
        End Function
        
        Public Sub SetnameNull()
            Me(Me.tableVIEW_MEM_RPR.nameColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsrelationNull() As Boolean
            Return Me.IsNull(Me.tableVIEW_MEM_RPR.relationColumn)
        End Function
        
        Public Sub SetrelationNull()
            Me(Me.tableVIEW_MEM_RPR.relationColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class VIEW_MEM_RPRRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As VIEW_MEM_RPRRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As VIEW_MEM_RPRRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As VIEW_MEM_RPRRow
            Get
                Return Me.eventRow
            End Get
        End Property
        
        Public ReadOnly Property Action As DataRowAction
            Get
                Return Me.eventAction
            End Get
        End Property
    End Class
End Class
