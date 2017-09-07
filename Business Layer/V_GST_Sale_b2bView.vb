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
''' See <see cref="BaseV_GST_Sale_b2bView"></see> for additional information.
''' </summary>
''' <remarks>
''' See <see cref="BaseV_GST_Sale_b2bView"></see> for additional information.
''' <para>
''' This class is implemented using the Singleton design pattern.
''' </para>
''' </remarks>
''' <seealso cref="BaseV_GST_Sale_b2bView"></seealso>
''' <seealso cref="BaseV_GST_Sale_b2bSqlView"></seealso>
''' <seealso cref="V_GST_Sale_b2bSqlView"></seealso>
''' <seealso cref="V_GST_Sale_b2bDefinition"></seealso>
''' <seealso cref="V_GST_Sale_b2bRecord"></seealso>
''' <seealso cref="BaseV_GST_Sale_b2bRecord"></seealso>

<Serializable()> Public Class V_GST_Sale_b2bView
	Inherits BaseV_GST_Sale_b2bView
	Implements System.Runtime.Serialization.ISerializable, ISingleton


#Region "ISerializable Members"

	''' <summary>
	''' Overridden to use the <see cref="V_GST_Sale_b2bView_SerializationHelper"></see> class 
	''' for deserialization of <see cref="V_GST_Sale_b2bView"></see> data.
	''' </summary>
	''' <remarks>
	''' Since the <see cref="V_GST_Sale_b2bView"></see> class is implemented using the Singleton design pattern, 
	''' this method must be overridden to prevent additional instances from being created during deserialization.
	''' </remarks>
	Protected Overridable Sub GetObjectData( _
		ByVal info As System.Runtime.Serialization.SerializationInfo, _
		ByVal context As System.Runtime.Serialization.StreamingContext _
	) Implements System.Runtime.Serialization.ISerializable.GetObjectData
		info.SetType(GetType(V_GST_Sale_b2bView_SerializationHelper)) 'No other values need to be added
	End Sub

#Region "Class V_GST_Sale_b2bView_SerializationHelper"

	<Serializable()> Private Class V_GST_Sale_b2bView_SerializationHelper
		Implements System.Runtime.Serialization.IObjectReference

		'Method called after this object is deserialized
		Public Function GetRealObject(ByVal context As System.Runtime.Serialization.StreamingContext) As Object _
		Implements System.Runtime.Serialization.IObjectReference.GetRealObject
			Return V_GST_Sale_b2bView.Instance
		End Function
	End Class

#End Region

#End Region

	''' <summary>
	''' References the only instance of the <see cref="V_GST_Sale_b2bView"></see> class.
	''' </summary>
	''' <remarks>
	''' Since the <see cref="V_GST_Sale_b2bView"></see> class is implemented using the Singleton design pattern, 
	''' this field is the only way to access an instance of the class.
	''' </remarks>
	Public Shared ReadOnly Instance As New V_GST_Sale_b2bView()

	Private Sub New()
		MyBase.New()
	End Sub


End Class
End Namespace
