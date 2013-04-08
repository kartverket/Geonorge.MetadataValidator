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
	/// 	This class represents the Element TimePrimitivePropertyType_Type_Group
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Choice,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement,
													"TimePrimitivePropertyType_Type_Group", "http://www.opengis.net/gml", false, false,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class TimePrimitivePropertyType_Type_Group : CSW.XmlCommonBase
	{
		#region Constructors
		/// <summary>
		///		Constructor for TimePrimitivePropertyType_Type_Group
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public TimePrimitivePropertyType_Type_Group()
		{
			_elementName = "TimePrimitivePropertyType_Type_Group";
			Init();
		}
		public TimePrimitivePropertyType_Type_Group(String elementName)
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
			m__TimePrimitive = null;
			m__TimeTopologyPrimitive = null;
			m_SubGrp_TimeTopologyPrimitive = null;
			m__TimeGeometricPrimitive = null;
			m_SubGrp_TimeGeometricPrimitive = null;



			_validElement = "";
// ##HAND_CODED_BLOCK_START ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional initialization code here...

// ##HAND_CODED_BLOCK_END ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
		}
		protected void ClearChoice(string selectedElement)
		{
			m__TimePrimitive = null;
			m__TimeTopologyPrimitive = null;
			m_SubGrp_TimeTopologyPrimitive = null;
			m__TimeGeometricPrimitive = null;
			m_SubGrp_TimeGeometricPrimitive = null;
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
			AE.TimePrimitivePropertyType_Type_Group newObject = new AE.TimePrimitivePropertyType_Type_Group(_elementName);
			newObject.m__TimePrimitive = null;
			if (m__TimePrimitive != null)
				newObject.m__TimePrimitive = (AE.IAbstractTimePrimitiveType)m__TimePrimitive.Clone();
			newObject.m__TimeTopologyPrimitive = null;
			if (m__TimeTopologyPrimitive != null)
				newObject.m__TimeTopologyPrimitive = (AE.IAbstractTimeTopologyPrimitiveType)m__TimeTopologyPrimitive.Clone();
			newObject.m_SubGrp_TimeTopologyPrimitive = null;
			if (m_SubGrp_TimeTopologyPrimitive != null)
				newObject.m_SubGrp_TimeTopologyPrimitive = (AE.SubGrp_TimeTopologyPrimitive)m_SubGrp_TimeTopologyPrimitive.Clone();
			newObject.m__TimeGeometricPrimitive = null;
			if (m__TimeGeometricPrimitive != null)
				newObject.m__TimeGeometricPrimitive = (AE.IAbstractTimeGeometricPrimitiveType)m__TimeGeometricPrimitive.Clone();
			newObject.m_SubGrp_TimeGeometricPrimitive = null;
			if (m_SubGrp_TimeGeometricPrimitive != null)
				newObject.m_SubGrp_TimeGeometricPrimitive = (AE.SubGrp_TimeGeometricPrimitive)m_SubGrp_TimeGeometricPrimitive.Clone();

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

		#region Attribute - _TimePrimitive
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
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("_TimePrimitive", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.ClassFactory), "IAbstractTimePrimitiveTypeCreateObject")]
		public AE.IAbstractTimePrimitiveType _TimePrimitive
		{
			get 
			{ 
				return m__TimePrimitive;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"_TimePrimitive"); // remove selection
				if (value == null)
					m__TimePrimitive = null;
				else
				{
					m__TimePrimitive = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "_TimePrimitive");
				}
			}
		}
		protected AE.IAbstractTimePrimitiveType m__TimePrimitive;

		#endregion

		#region Attribute - _TimeTopologyPrimitive
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _TimePrimitive
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("_TimeTopologyPrimitive", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.ClassFactory), "IAbstractTimeTopologyPrimitiveTypeCreateObject")]
		public AE.IAbstractTimeTopologyPrimitiveType _TimeTopologyPrimitive
		{
			get 
			{ 
				return m__TimeTopologyPrimitive;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"_TimeTopologyPrimitive"); // remove selection
				if (value == null)
					m__TimeTopologyPrimitive = null;
				else
				{
					m__TimeTopologyPrimitive = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "_TimeTopologyPrimitive");
				}
			}
		}
		protected AE.IAbstractTimeTopologyPrimitiveType m__TimeTopologyPrimitive;

		#endregion

		#region Attribute - SubGrp_TimeTopologyPrimitive
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _TimePrimitive
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("SubGrp_TimeTopologyPrimitive", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement, typeof(AE.SubGrp_TimeTopologyPrimitive))]
		public AE.SubGrp_TimeTopologyPrimitive SubGrp_TimeTopologyPrimitive
		{
			get 
			{ 
				return m_SubGrp_TimeTopologyPrimitive;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"SubGrp_TimeTopologyPrimitive"); // remove selection
				if (value == null)
					m_SubGrp_TimeTopologyPrimitive = null;
				else
				{
					m_SubGrp_TimeTopologyPrimitive = value; 
				}
			}
		}
		protected AE.SubGrp_TimeTopologyPrimitive m_SubGrp_TimeTopologyPrimitive;
		
		#endregion

		#region Attribute - _TimeGeometricPrimitive
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _TimePrimitive
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("_TimeGeometricPrimitive", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.ClassFactory), "IAbstractTimeGeometricPrimitiveTypeCreateObject")]
		public AE.IAbstractTimeGeometricPrimitiveType _TimeGeometricPrimitive
		{
			get 
			{ 
				return m__TimeGeometricPrimitive;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"_TimeGeometricPrimitive"); // remove selection
				if (value == null)
					m__TimeGeometricPrimitive = null;
				else
				{
					m__TimeGeometricPrimitive = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "_TimeGeometricPrimitive");
				}
			}
		}
		protected AE.IAbstractTimeGeometricPrimitiveType m__TimeGeometricPrimitive;

		#endregion

		#region Attribute - SubGrp_TimeGeometricPrimitive
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _TimePrimitive
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("SubGrp_TimeGeometricPrimitive", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement, typeof(AE.SubGrp_TimeGeometricPrimitive))]
		public AE.SubGrp_TimeGeometricPrimitive SubGrp_TimeGeometricPrimitive
		{
			get 
			{ 
				return m_SubGrp_TimeGeometricPrimitive;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"SubGrp_TimeGeometricPrimitive"); // remove selection
				if (value == null)
					m_SubGrp_TimeGeometricPrimitive = null;
				else
				{
					m_SubGrp_TimeGeometricPrimitive = value; 
				}
			}
		}
		protected AE.SubGrp_TimeGeometricPrimitive m_SubGrp_TimeGeometricPrimitive;
		
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


