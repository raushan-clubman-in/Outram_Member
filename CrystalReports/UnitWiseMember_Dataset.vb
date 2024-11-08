﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated by a tool.
'     Runtime Version: 1.1.4322.2032
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
Public Class UnitWiseMember_Dataset
    Inherits DataSet
    
    Private tableVW_UNITWISE_MEMBER As VW_UNITWISE_MEMBERDataTable
    
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
            If (Not (ds.Tables("VW_UNITWISE_MEMBER")) Is Nothing) Then
                Me.Tables.Add(New VW_UNITWISE_MEMBERDataTable(ds.Tables("VW_UNITWISE_MEMBER")))
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
    Public ReadOnly Property VW_UNITWISE_MEMBER As VW_UNITWISE_MEMBERDataTable
        Get
            Return Me.tableVW_UNITWISE_MEMBER
        End Get
    End Property
    
    Public Overrides Function Clone() As DataSet
        Dim cln As UnitWiseMember_Dataset = CType(MyBase.Clone,UnitWiseMember_Dataset)
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
        If (Not (ds.Tables("VW_UNITWISE_MEMBER")) Is Nothing) Then
            Me.Tables.Add(New VW_UNITWISE_MEMBERDataTable(ds.Tables("VW_UNITWISE_MEMBER")))
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
        Me.tableVW_UNITWISE_MEMBER = CType(Me.Tables("VW_UNITWISE_MEMBER"),VW_UNITWISE_MEMBERDataTable)
        If (Not (Me.tableVW_UNITWISE_MEMBER) Is Nothing) Then
            Me.tableVW_UNITWISE_MEMBER.InitVars
        End If
    End Sub
    
    Private Sub InitClass()
        Me.DataSetName = "UnitWiseMember_Dataset"
        Me.Prefix = ""
        Me.Namespace = "http://tempuri.org/UnitWiseMember_Dataset.xsd"
        Me.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CaseSensitive = false
        Me.EnforceConstraints = true
        Me.tableVW_UNITWISE_MEMBER = New VW_UNITWISE_MEMBERDataTable
        Me.Tables.Add(Me.tableVW_UNITWISE_MEMBER)
    End Sub
    
    Private Function ShouldSerializeVW_UNITWISE_MEMBER() As Boolean
        Return false
    End Function
    
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    Public Delegate Sub VW_UNITWISE_MEMBERRowChangeEventHandler(ByVal sender As Object, ByVal e As VW_UNITWISE_MEMBERRowChangeEvent)
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class VW_UNITWISE_MEMBERDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnmcode As DataColumn
        
        Private columnmname As DataColumn
        
        Private columndoj As DataColumn
        
        Private columnadd1 As DataColumn
        
        Private columnadd2 As DataColumn
        
        Private columnadd3 As DataColumn
        
        Private columncity As DataColumn
        
        Private columnstate As DataColumn
        
        Private columncountry As DataColumn
        
        Private columnpincode As DataColumn
        
        Private columnphone1 As DataColumn
        
        Private columnprefix As DataColumn
        
        Private columncontcell As DataColumn
        
        Private columnTypeDesc As DataColumn
        
        Private columncurentstatus As DataColumn
        
        Private columnunitno As DataColumn
        
        Private columnUNITNAME As DataColumn
        
        Private columnUNITDescription As DataColumn
        
        Friend Sub New()
            MyBase.New("VW_UNITWISE_MEMBER")
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
        
        Friend ReadOnly Property mcodeColumn As DataColumn
            Get
                Return Me.columnmcode
            End Get
        End Property
        
        Friend ReadOnly Property mnameColumn As DataColumn
            Get
                Return Me.columnmname
            End Get
        End Property
        
        Friend ReadOnly Property dojColumn As DataColumn
            Get
                Return Me.columndoj
            End Get
        End Property
        
        Friend ReadOnly Property add1Column As DataColumn
            Get
                Return Me.columnadd1
            End Get
        End Property
        
        Friend ReadOnly Property add2Column As DataColumn
            Get
                Return Me.columnadd2
            End Get
        End Property
        
        Friend ReadOnly Property add3Column As DataColumn
            Get
                Return Me.columnadd3
            End Get
        End Property
        
        Friend ReadOnly Property cityColumn As DataColumn
            Get
                Return Me.columncity
            End Get
        End Property
        
        Friend ReadOnly Property stateColumn As DataColumn
            Get
                Return Me.columnstate
            End Get
        End Property
        
        Friend ReadOnly Property countryColumn As DataColumn
            Get
                Return Me.columncountry
            End Get
        End Property
        
        Friend ReadOnly Property pincodeColumn As DataColumn
            Get
                Return Me.columnpincode
            End Get
        End Property
        
        Friend ReadOnly Property phone1Column As DataColumn
            Get
                Return Me.columnphone1
            End Get
        End Property
        
        Friend ReadOnly Property prefixColumn As DataColumn
            Get
                Return Me.columnprefix
            End Get
        End Property
        
        Friend ReadOnly Property contcellColumn As DataColumn
            Get
                Return Me.columncontcell
            End Get
        End Property
        
        Friend ReadOnly Property TypeDescColumn As DataColumn
            Get
                Return Me.columnTypeDesc
            End Get
        End Property
        
        Friend ReadOnly Property curentstatusColumn As DataColumn
            Get
                Return Me.columncurentstatus
            End Get
        End Property
        
        Friend ReadOnly Property unitnoColumn As DataColumn
            Get
                Return Me.columnunitno
            End Get
        End Property
        
        Friend ReadOnly Property UNITNAMEColumn As DataColumn
            Get
                Return Me.columnUNITNAME
            End Get
        End Property
        
        Friend ReadOnly Property UNITDescriptionColumn As DataColumn
            Get
                Return Me.columnUNITDescription
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As VW_UNITWISE_MEMBERRow
            Get
                Return CType(Me.Rows(index),VW_UNITWISE_MEMBERRow)
            End Get
        End Property
        
        Public Event VW_UNITWISE_MEMBERRowChanged As VW_UNITWISE_MEMBERRowChangeEventHandler
        
        Public Event VW_UNITWISE_MEMBERRowChanging As VW_UNITWISE_MEMBERRowChangeEventHandler
        
        Public Event VW_UNITWISE_MEMBERRowDeleted As VW_UNITWISE_MEMBERRowChangeEventHandler
        
        Public Event VW_UNITWISE_MEMBERRowDeleting As VW_UNITWISE_MEMBERRowChangeEventHandler
        
        Public Overloads Sub AddVW_UNITWISE_MEMBERRow(ByVal row As VW_UNITWISE_MEMBERRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddVW_UNITWISE_MEMBERRow( _
                    ByVal mcode As String,  _
                    ByVal mname As String,  _
                    ByVal doj As Date,  _
                    ByVal add1 As String,  _
                    ByVal add2 As String,  _
                    ByVal add3 As String,  _
                    ByVal city As String,  _
                    ByVal state As String,  _
                    ByVal country As String,  _
                    ByVal pincode As String,  _
                    ByVal phone1 As String,  _
                    ByVal prefix As String,  _
                    ByVal contcell As String,  _
                    ByVal TypeDesc As String,  _
                    ByVal curentstatus As String,  _
                    ByVal unitno As String,  _
                    ByVal UNITNAME As String,  _
                    ByVal UNITDescription As String) As VW_UNITWISE_MEMBERRow
            Dim rowVW_UNITWISE_MEMBERRow As VW_UNITWISE_MEMBERRow = CType(Me.NewRow,VW_UNITWISE_MEMBERRow)
            rowVW_UNITWISE_MEMBERRow.ItemArray = New Object() {mcode, mname, doj, add1, add2, add3, city, state, country, pincode, phone1, prefix, contcell, TypeDesc, curentstatus, unitno, UNITNAME, UNITDescription}
            Me.Rows.Add(rowVW_UNITWISE_MEMBERRow)
            Return rowVW_UNITWISE_MEMBERRow
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As VW_UNITWISE_MEMBERDataTable = CType(MyBase.Clone,VW_UNITWISE_MEMBERDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New VW_UNITWISE_MEMBERDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnmcode = Me.Columns("mcode")
            Me.columnmname = Me.Columns("mname")
            Me.columndoj = Me.Columns("doj")
            Me.columnadd1 = Me.Columns("add1")
            Me.columnadd2 = Me.Columns("add2")
            Me.columnadd3 = Me.Columns("add3")
            Me.columncity = Me.Columns("city")
            Me.columnstate = Me.Columns("state")
            Me.columncountry = Me.Columns("country")
            Me.columnpincode = Me.Columns("pincode")
            Me.columnphone1 = Me.Columns("phone1")
            Me.columnprefix = Me.Columns("prefix")
            Me.columncontcell = Me.Columns("contcell")
            Me.columnTypeDesc = Me.Columns("TypeDesc")
            Me.columncurentstatus = Me.Columns("curentstatus")
            Me.columnunitno = Me.Columns("unitno")
            Me.columnUNITNAME = Me.Columns("UNITNAME")
            Me.columnUNITDescription = Me.Columns("UNITDescription")
        End Sub
        
        Private Sub InitClass()
            Me.columnmcode = New DataColumn("mcode", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnmcode)
            Me.columnmname = New DataColumn("mname", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnmname)
            Me.columndoj = New DataColumn("doj", GetType(System.DateTime), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columndoj)
            Me.columnadd1 = New DataColumn("add1", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnadd1)
            Me.columnadd2 = New DataColumn("add2", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnadd2)
            Me.columnadd3 = New DataColumn("add3", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnadd3)
            Me.columncity = New DataColumn("city", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columncity)
            Me.columnstate = New DataColumn("state", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnstate)
            Me.columncountry = New DataColumn("country", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columncountry)
            Me.columnpincode = New DataColumn("pincode", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnpincode)
            Me.columnphone1 = New DataColumn("phone1", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnphone1)
            Me.columnprefix = New DataColumn("prefix", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnprefix)
            Me.columncontcell = New DataColumn("contcell", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columncontcell)
            Me.columnTypeDesc = New DataColumn("TypeDesc", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnTypeDesc)
            Me.columncurentstatus = New DataColumn("curentstatus", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columncurentstatus)
            Me.columnunitno = New DataColumn("unitno", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnunitno)
            Me.columnUNITNAME = New DataColumn("UNITNAME", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnUNITNAME)
            Me.columnUNITDescription = New DataColumn("UNITDescription", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnUNITDescription)
            Me.columnmcode.ReadOnly = true
            Me.columnmname.ReadOnly = true
            Me.columndoj.ReadOnly = true
            Me.columnadd1.ReadOnly = true
            Me.columnadd2.ReadOnly = true
            Me.columnadd3.ReadOnly = true
            Me.columncity.ReadOnly = true
            Me.columnstate.ReadOnly = true
            Me.columncountry.ReadOnly = true
            Me.columnpincode.ReadOnly = true
            Me.columnphone1.ReadOnly = true
            Me.columnprefix.ReadOnly = true
            Me.columncontcell.ReadOnly = true
            Me.columnTypeDesc.ReadOnly = true
            Me.columncurentstatus.ReadOnly = true
            Me.columnunitno.ReadOnly = true
            Me.columnUNITNAME.ReadOnly = true
            Me.columnUNITDescription.ReadOnly = true
        End Sub
        
        Public Function NewVW_UNITWISE_MEMBERRow() As VW_UNITWISE_MEMBERRow
            Return CType(Me.NewRow,VW_UNITWISE_MEMBERRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New VW_UNITWISE_MEMBERRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(VW_UNITWISE_MEMBERRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.VW_UNITWISE_MEMBERRowChangedEvent) Is Nothing) Then
                RaiseEvent VW_UNITWISE_MEMBERRowChanged(Me, New VW_UNITWISE_MEMBERRowChangeEvent(CType(e.Row,VW_UNITWISE_MEMBERRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.VW_UNITWISE_MEMBERRowChangingEvent) Is Nothing) Then
                RaiseEvent VW_UNITWISE_MEMBERRowChanging(Me, New VW_UNITWISE_MEMBERRowChangeEvent(CType(e.Row,VW_UNITWISE_MEMBERRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.VW_UNITWISE_MEMBERRowDeletedEvent) Is Nothing) Then
                RaiseEvent VW_UNITWISE_MEMBERRowDeleted(Me, New VW_UNITWISE_MEMBERRowChangeEvent(CType(e.Row,VW_UNITWISE_MEMBERRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.VW_UNITWISE_MEMBERRowDeletingEvent) Is Nothing) Then
                RaiseEvent VW_UNITWISE_MEMBERRowDeleting(Me, New VW_UNITWISE_MEMBERRowChangeEvent(CType(e.Row,VW_UNITWISE_MEMBERRow), e.Action))
            End If
        End Sub
        
        Public Sub RemoveVW_UNITWISE_MEMBERRow(ByVal row As VW_UNITWISE_MEMBERRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class VW_UNITWISE_MEMBERRow
        Inherits DataRow
        
        Private tableVW_UNITWISE_MEMBER As VW_UNITWISE_MEMBERDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tableVW_UNITWISE_MEMBER = CType(Me.Table,VW_UNITWISE_MEMBERDataTable)
        End Sub
        
        Public Property mcode As String
            Get
                Try 
                    Return CType(Me(Me.tableVW_UNITWISE_MEMBER.mcodeColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableVW_UNITWISE_MEMBER.mcodeColumn) = value
            End Set
        End Property
        
        Public Property mname As String
            Get
                Try 
                    Return CType(Me(Me.tableVW_UNITWISE_MEMBER.mnameColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableVW_UNITWISE_MEMBER.mnameColumn) = value
            End Set
        End Property
        
        Public Property doj As Date
            Get
                Try 
                    Return CType(Me(Me.tableVW_UNITWISE_MEMBER.dojColumn),Date)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableVW_UNITWISE_MEMBER.dojColumn) = value
            End Set
        End Property
        
        Public Property add1 As String
            Get
                Try 
                    Return CType(Me(Me.tableVW_UNITWISE_MEMBER.add1Column),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableVW_UNITWISE_MEMBER.add1Column) = value
            End Set
        End Property
        
        Public Property add2 As String
            Get
                Try 
                    Return CType(Me(Me.tableVW_UNITWISE_MEMBER.add2Column),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableVW_UNITWISE_MEMBER.add2Column) = value
            End Set
        End Property
        
        Public Property add3 As String
            Get
                Try 
                    Return CType(Me(Me.tableVW_UNITWISE_MEMBER.add3Column),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableVW_UNITWISE_MEMBER.add3Column) = value
            End Set
        End Property
        
        Public Property city As String
            Get
                Try 
                    Return CType(Me(Me.tableVW_UNITWISE_MEMBER.cityColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableVW_UNITWISE_MEMBER.cityColumn) = value
            End Set
        End Property
        
        Public Property state As String
            Get
                Try 
                    Return CType(Me(Me.tableVW_UNITWISE_MEMBER.stateColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableVW_UNITWISE_MEMBER.stateColumn) = value
            End Set
        End Property
        
        Public Property country As String
            Get
                Try 
                    Return CType(Me(Me.tableVW_UNITWISE_MEMBER.countryColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableVW_UNITWISE_MEMBER.countryColumn) = value
            End Set
        End Property
        
        Public Property pincode As String
            Get
                Try 
                    Return CType(Me(Me.tableVW_UNITWISE_MEMBER.pincodeColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableVW_UNITWISE_MEMBER.pincodeColumn) = value
            End Set
        End Property
        
        Public Property phone1 As String
            Get
                Try 
                    Return CType(Me(Me.tableVW_UNITWISE_MEMBER.phone1Column),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableVW_UNITWISE_MEMBER.phone1Column) = value
            End Set
        End Property
        
        Public Property prefix As String
            Get
                Try 
                    Return CType(Me(Me.tableVW_UNITWISE_MEMBER.prefixColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableVW_UNITWISE_MEMBER.prefixColumn) = value
            End Set
        End Property
        
        Public Property contcell As String
            Get
                Try 
                    Return CType(Me(Me.tableVW_UNITWISE_MEMBER.contcellColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableVW_UNITWISE_MEMBER.contcellColumn) = value
            End Set
        End Property
        
        Public Property TypeDesc As String
            Get
                Try 
                    Return CType(Me(Me.tableVW_UNITWISE_MEMBER.TypeDescColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableVW_UNITWISE_MEMBER.TypeDescColumn) = value
            End Set
        End Property
        
        Public Property curentstatus As String
            Get
                Try 
                    Return CType(Me(Me.tableVW_UNITWISE_MEMBER.curentstatusColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableVW_UNITWISE_MEMBER.curentstatusColumn) = value
            End Set
        End Property
        
        Public Property unitno As String
            Get
                Try 
                    Return CType(Me(Me.tableVW_UNITWISE_MEMBER.unitnoColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableVW_UNITWISE_MEMBER.unitnoColumn) = value
            End Set
        End Property
        
        Public Property UNITNAME As String
            Get
                Try 
                    Return CType(Me(Me.tableVW_UNITWISE_MEMBER.UNITNAMEColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableVW_UNITWISE_MEMBER.UNITNAMEColumn) = value
            End Set
        End Property
        
        Public Property UNITDescription As String
            Get
                Try 
                    Return CType(Me(Me.tableVW_UNITWISE_MEMBER.UNITDescriptionColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableVW_UNITWISE_MEMBER.UNITDescriptionColumn) = value
            End Set
        End Property
        
        Public Function IsmcodeNull() As Boolean
            Return Me.IsNull(Me.tableVW_UNITWISE_MEMBER.mcodeColumn)
        End Function
        
        Public Sub SetmcodeNull()
            Me(Me.tableVW_UNITWISE_MEMBER.mcodeColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsmnameNull() As Boolean
            Return Me.IsNull(Me.tableVW_UNITWISE_MEMBER.mnameColumn)
        End Function
        
        Public Sub SetmnameNull()
            Me(Me.tableVW_UNITWISE_MEMBER.mnameColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsdojNull() As Boolean
            Return Me.IsNull(Me.tableVW_UNITWISE_MEMBER.dojColumn)
        End Function
        
        Public Sub SetdojNull()
            Me(Me.tableVW_UNITWISE_MEMBER.dojColumn) = System.Convert.DBNull
        End Sub
        
        Public Function Isadd1Null() As Boolean
            Return Me.IsNull(Me.tableVW_UNITWISE_MEMBER.add1Column)
        End Function
        
        Public Sub Setadd1Null()
            Me(Me.tableVW_UNITWISE_MEMBER.add1Column) = System.Convert.DBNull
        End Sub
        
        Public Function Isadd2Null() As Boolean
            Return Me.IsNull(Me.tableVW_UNITWISE_MEMBER.add2Column)
        End Function
        
        Public Sub Setadd2Null()
            Me(Me.tableVW_UNITWISE_MEMBER.add2Column) = System.Convert.DBNull
        End Sub
        
        Public Function Isadd3Null() As Boolean
            Return Me.IsNull(Me.tableVW_UNITWISE_MEMBER.add3Column)
        End Function
        
        Public Sub Setadd3Null()
            Me(Me.tableVW_UNITWISE_MEMBER.add3Column) = System.Convert.DBNull
        End Sub
        
        Public Function IscityNull() As Boolean
            Return Me.IsNull(Me.tableVW_UNITWISE_MEMBER.cityColumn)
        End Function
        
        Public Sub SetcityNull()
            Me(Me.tableVW_UNITWISE_MEMBER.cityColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsstateNull() As Boolean
            Return Me.IsNull(Me.tableVW_UNITWISE_MEMBER.stateColumn)
        End Function
        
        Public Sub SetstateNull()
            Me(Me.tableVW_UNITWISE_MEMBER.stateColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IscountryNull() As Boolean
            Return Me.IsNull(Me.tableVW_UNITWISE_MEMBER.countryColumn)
        End Function
        
        Public Sub SetcountryNull()
            Me(Me.tableVW_UNITWISE_MEMBER.countryColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IspincodeNull() As Boolean
            Return Me.IsNull(Me.tableVW_UNITWISE_MEMBER.pincodeColumn)
        End Function
        
        Public Sub SetpincodeNull()
            Me(Me.tableVW_UNITWISE_MEMBER.pincodeColumn) = System.Convert.DBNull
        End Sub
        
        Public Function Isphone1Null() As Boolean
            Return Me.IsNull(Me.tableVW_UNITWISE_MEMBER.phone1Column)
        End Function
        
        Public Sub Setphone1Null()
            Me(Me.tableVW_UNITWISE_MEMBER.phone1Column) = System.Convert.DBNull
        End Sub
        
        Public Function IsprefixNull() As Boolean
            Return Me.IsNull(Me.tableVW_UNITWISE_MEMBER.prefixColumn)
        End Function
        
        Public Sub SetprefixNull()
            Me(Me.tableVW_UNITWISE_MEMBER.prefixColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IscontcellNull() As Boolean
            Return Me.IsNull(Me.tableVW_UNITWISE_MEMBER.contcellColumn)
        End Function
        
        Public Sub SetcontcellNull()
            Me(Me.tableVW_UNITWISE_MEMBER.contcellColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsTypeDescNull() As Boolean
            Return Me.IsNull(Me.tableVW_UNITWISE_MEMBER.TypeDescColumn)
        End Function
        
        Public Sub SetTypeDescNull()
            Me(Me.tableVW_UNITWISE_MEMBER.TypeDescColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IscurentstatusNull() As Boolean
            Return Me.IsNull(Me.tableVW_UNITWISE_MEMBER.curentstatusColumn)
        End Function
        
        Public Sub SetcurentstatusNull()
            Me(Me.tableVW_UNITWISE_MEMBER.curentstatusColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsunitnoNull() As Boolean
            Return Me.IsNull(Me.tableVW_UNITWISE_MEMBER.unitnoColumn)
        End Function
        
        Public Sub SetunitnoNull()
            Me(Me.tableVW_UNITWISE_MEMBER.unitnoColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsUNITNAMENull() As Boolean
            Return Me.IsNull(Me.tableVW_UNITWISE_MEMBER.UNITNAMEColumn)
        End Function
        
        Public Sub SetUNITNAMENull()
            Me(Me.tableVW_UNITWISE_MEMBER.UNITNAMEColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsUNITDescriptionNull() As Boolean
            Return Me.IsNull(Me.tableVW_UNITWISE_MEMBER.UNITDescriptionColumn)
        End Function
        
        Public Sub SetUNITDescriptionNull()
            Me(Me.tableVW_UNITWISE_MEMBER.UNITDescriptionColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class VW_UNITWISE_MEMBERRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As VW_UNITWISE_MEMBERRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As VW_UNITWISE_MEMBERRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As VW_UNITWISE_MEMBERRow
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
