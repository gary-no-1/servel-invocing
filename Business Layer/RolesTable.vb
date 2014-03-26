﻿' This is a "safe" class, meaning that it is created once 
' and never overwritten. Any custom code you add to this class 
' will be preserved when you regenerate your application.
'
' Typical customizations that may be done in this class include
'  - adding custom event handlers
'  - overriding base class methods

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ServelInvocing.Business

''' <summary>
''' Provides access to the schema information and record data of a database table (or view).
''' See <see cref="BaseRolesTable"></see> for additional information.
''' </summary>
''' <remarks>
''' See <see cref="BaseRolesTable"></see> for additional information.
''' <para>
''' This class is implemented using the Singleton design pattern.
''' </para>
''' <para>
''' This is a "safe" class, meaning that it is generated once and never overwritten. 
''' Any changes you make to this class will be preserved when you regenerate your application.
''' </para>
''' </remarks>
''' <seealso cref="BaseRolesTable"></seealso>
''' <seealso cref="BaseRolesSqlTable"></seealso>
''' <seealso cref="RolesSqlTable"></seealso>
''' <seealso cref="RolesDefinition"></seealso>
''' <seealso cref="RolesRecord"></seealso>
''' <seealso cref="BaseRolesRecord"></seealso>

<Serializable()> Public Class RolesTable
    Inherits BaseRolesTable
    Implements System.Runtime.Serialization.ISerializable, ISingleton


#Region "ISerializable Members"

    ''' <summary>
    ''' Overridden to use the <see cref="RolesTable_SerializationHelper"></see> class 
    ''' for deserialization of <see cref="RolesTable"></see> data.
    ''' </summary>
    ''' <remarks>
    ''' Since the <see cref="RolesTable"></see> class is implemented using the Singleton design pattern, 
    ''' this method must be overridden to prevent additional instances from being created during deserialization.
    ''' </remarks>
    Protected Overridable Sub GetObjectData( _
        ByVal info As System.Runtime.Serialization.SerializationInfo, _
        ByVal context As System.Runtime.Serialization.StreamingContext _
    ) Implements System.Runtime.Serialization.ISerializable.GetObjectData
        info.SetType(GetType(RolesTable_SerializationHelper)) 'No other values need to be added
    End Sub

#Region "Class RolesTable_SerializationHelper"

    <Serializable()> Private Class RolesTable_SerializationHelper
        Implements System.Runtime.Serialization.IObjectReference

        'Method called after this object is deserialized
        Public Function GetRealObject(ByVal context As System.Runtime.Serialization.StreamingContext) As Object _
        Implements System.Runtime.Serialization.IObjectReference.GetRealObject
            Return RolesTable.Instance
        End Function
    End Class

#End Region

#End Region

    ''' <summary>
    ''' References the only instance of the <see cref="RolesTable"></see> class.
    ''' </summary>
    ''' <remarks>
    ''' Since the <see cref="RolesTable"></see> class is implemented using the Singleton design pattern, 
    ''' this field is the only way to access an instance of the class.
    ''' </remarks>
    Public Shared ReadOnly Instance As New RolesTable()

    Private Sub New()
        MyBase.New()
    End Sub

End Class ' RolesTable
End Namespace
