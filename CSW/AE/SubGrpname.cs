using System;
using System.Xml;

/**********************************************************************************************
 * Copyright (c) 2001-2013 Liquid Technologies Limited. All rights reserved.
 * See www.liquid-technologies.com for product details.
 *
 * Please see products End User License Agreement for distribution permissions.
 *
 * WARNING: THIS FILE IS GENERATED
 * Changes made outside of ##HAND_CODED_BLOCK_START blocks will be overwritten
 *
 * Generation  : by Liquid XML Data Binder 11.0.7.4537
 * Using Schema: C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd
 **********************************************************************************************/

namespace AE
{
	/// <summary>
	/// 	This class represents the Element SubGrpname
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Choice,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement,
													"SubGrpname", "http://www.opengis.net/gml", false, false,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class SubGrpname : CSW.XmlCommonBase
	{
		#region Constructors
		/// <summary>
		///		Constructor for SubGrpname
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public SubGrpname()
		{
			_elementName = "SubGrpname";
			Init();
		}
		public SubGrpname(String elementName)
		{
			_elementName = elementName;
			Init();
		}
		#endregion

		#region Initialization methods for the class
		/// <summary>
		///		Initializes the class
		/// </summary>
		/// <remarks>
		///		<BR>The Creates all the mandatory fields (populated with the default data) 
		///		All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd.</BR>
		/// </remarks>
		protected override void Init()
		{
			CSW.Registration.iRegistrationIndicator = 0; // causes registration to take place
			m_Name = null;
			m_ParameterName = null;
			m_SrsName = null;
			m_CoordinateOperationName = null;
			m_MethodName = null;
			m_EllipsoidName = null;
			m_MeridianName = null;
			m_CsName = null;
			m_GroupName = null;
			m_DatumName = null;



			_validElement = "";
// ##HAND_CODED_BLOCK_START ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional initialization code here...

// ##HAND_CODED_BLOCK_END ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
		}
		protected void ClearChoice(string selectedElement)
		{
			m_Name = null;
			m_ParameterName = null;
			m_SrsName = null;
			m_CoordinateOperationName = null;
			m_MethodName = null;
			m_EllipsoidName = null;
			m_MeridianName = null;
			m_CsName = null;
			m_GroupName = null;
			m_DatumName = null;
			_validElement = selectedElement;
		}
		#endregion

		#region ICloneable Interface
		/// <summary>
		///		Allows the class to be copied
		/// </summary>
		/// <remarks>
		///		Performs a 'deep copy' of all the data in the class (and its children)
		/// </remarks>
		public override object Clone()
		{
			AE.SubGrpname newObject = new AE.SubGrpname(_elementName);
			newObject.m_Name = null;
			if (m_Name != null)
				newObject.m_Name = (AE.ICodeType)m_Name.Clone();
			newObject.m_ParameterName = null;
			if (m_ParameterName != null)
				newObject.m_ParameterName = (AE.ICodeType)m_ParameterName.Clone();
			newObject.m_SrsName = null;
			if (m_SrsName != null)
				newObject.m_SrsName = (AE.ICodeType)m_SrsName.Clone();
			newObject.m_CoordinateOperationName = null;
			if (m_CoordinateOperationName != null)
				newObject.m_CoordinateOperationName = (AE.ICodeType)m_CoordinateOperationName.Clone();
			newObject.m_MethodName = null;
			if (m_MethodName != null)
				newObject.m_MethodName = (AE.ICodeType)m_MethodName.Clone();
			newObject.m_EllipsoidName = null;
			if (m_EllipsoidName != null)
				newObject.m_EllipsoidName = (AE.ICodeType)m_EllipsoidName.Clone();
			newObject.m_MeridianName = null;
			if (m_MeridianName != null)
				newObject.m_MeridianName = (AE.ICodeType)m_MeridianName.Clone();
			newObject.m_CsName = null;
			if (m_CsName != null)
				newObject.m_CsName = (AE.ICodeType)m_CsName.Clone();
			newObject.m_GroupName = null;
			if (m_GroupName != null)
				newObject.m_GroupName = (AE.ICodeType)m_GroupName.Clone();
			newObject.m_DatumName = null;
			if (m_DatumName != null)
				newObject.m_DatumName = (AE.ICodeType)m_DatumName.Clone();

			newObject._validElement = _validElement;

// ##HAND_CODED_BLOCK_START ID="Additional clone"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional clone code here...

// ##HAND_CODED_BLOCK_END ID="Additional clone"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

			return newObject;
		}
		#endregion

		#region Member variables

		protected override String TargetNamespace
		{
			get { return "http://www.opengis.net/gml"; }
		}

		#region Attribute - name
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("name", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.ClassFactory), "ICodeTypeCreateObject")]
		public AE.ICodeType Name
		{
			get 
			{ 
				return m_Name;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"name"); // remove selection
				if (value == null)
					m_Name = null;
				else
				{
					m_Name = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "name");
				}
			}
		}
		protected AE.ICodeType m_Name;

		#endregion

		#region Attribute - parameterName
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for name
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("parameterName", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.ClassFactory), "ICodeTypeCreateObject")]
		public AE.ICodeType ParameterName
		{
			get 
			{ 
				return m_ParameterName;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"parameterName"); // remove selection
				if (value == null)
					m_ParameterName = null;
				else
				{
					m_ParameterName = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "parameterName");
				}
			}
		}
		protected AE.ICodeType m_ParameterName;

		#endregion

		#region Attribute - srsName
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for name
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("srsName", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.ClassFactory), "ICodeTypeCreateObject")]
		public AE.ICodeType SrsName
		{
			get 
			{ 
				return m_SrsName;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"srsName"); // remove selection
				if (value == null)
					m_SrsName = null;
				else
				{
					m_SrsName = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "srsName");
				}
			}
		}
		protected AE.ICodeType m_SrsName;

		#endregion

		#region Attribute - coordinateOperationName
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for name
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("coordinateOperationName", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.ClassFactory), "ICodeTypeCreateObject")]
		public AE.ICodeType CoordinateOperationName
		{
			get 
			{ 
				return m_CoordinateOperationName;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"coordinateOperationName"); // remove selection
				if (value == null)
					m_CoordinateOperationName = null;
				else
				{
					m_CoordinateOperationName = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "coordinateOperationName");
				}
			}
		}
		protected AE.ICodeType m_CoordinateOperationName;

		#endregion

		#region Attribute - methodName
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for name
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("methodName", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.ClassFactory), "ICodeTypeCreateObject")]
		public AE.ICodeType MethodName
		{
			get 
			{ 
				return m_MethodName;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"methodName"); // remove selection
				if (value == null)
					m_MethodName = null;
				else
				{
					m_MethodName = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "methodName");
				}
			}
		}
		protected AE.ICodeType m_MethodName;

		#endregion

		#region Attribute - ellipsoidName
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for name
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("ellipsoidName", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.ClassFactory), "ICodeTypeCreateObject")]
		public AE.ICodeType EllipsoidName
		{
			get 
			{ 
				return m_EllipsoidName;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"ellipsoidName"); // remove selection
				if (value == null)
					m_EllipsoidName = null;
				else
				{
					m_EllipsoidName = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "ellipsoidName");
				}
			}
		}
		protected AE.ICodeType m_EllipsoidName;

		#endregion

		#region Attribute - meridianName
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for name
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("meridianName", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.ClassFactory), "ICodeTypeCreateObject")]
		public AE.ICodeType MeridianName
		{
			get 
			{ 
				return m_MeridianName;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"meridianName"); // remove selection
				if (value == null)
					m_MeridianName = null;
				else
				{
					m_MeridianName = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "meridianName");
				}
			}
		}
		protected AE.ICodeType m_MeridianName;

		#endregion

		#region Attribute - csName
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for name
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("csName", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.ClassFactory), "ICodeTypeCreateObject")]
		public AE.ICodeType CsName
		{
			get 
			{ 
				return m_CsName;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"csName"); // remove selection
				if (value == null)
					m_CsName = null;
				else
				{
					m_CsName = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "csName");
				}
			}
		}
		protected AE.ICodeType m_CsName;

		#endregion

		#region Attribute - groupName
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for name
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("groupName", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.ClassFactory), "ICodeTypeCreateObject")]
		public AE.ICodeType GroupName
		{
			get 
			{ 
				return m_GroupName;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"groupName"); // remove selection
				if (value == null)
					m_GroupName = null;
				else
				{
					m_GroupName = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "groupName");
				}
			}
		}
		protected AE.ICodeType m_GroupName;

		#endregion

		#region Attribute - datumName
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for name
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("datumName", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.ClassFactory), "ICodeTypeCreateObject")]
		public AE.ICodeType DatumName
		{
			get 
			{ 
				return m_DatumName;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"datumName"); // remove selection
				if (value == null)
					m_DatumName = null;
				else
				{
					m_DatumName = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "datumName");
				}
			}
		}
		protected AE.ICodeType m_DatumName;

		#endregion

		public String ChoiceSelectedElement
		{
			get { return _validElement;  }
		}
		protected String _validElement;
		#region Attribute - Namespace
		public override String Namespace
		{
			get { return "http://www.opengis.net/gml"; }
		}	
		#endregion	

		#region Attribute - GetBase
		public override LiquidTechnologies.Runtime.Net45.XmlObjectBase GetBase()
		{
			return this;
		}
		#endregion
		#endregion

// ##HAND_CODED_BLOCK_START ID="Additional Methods"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional Methods and members here...

// ##HAND_CODED_BLOCK_END ID="Additional Methods"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
	}
}


