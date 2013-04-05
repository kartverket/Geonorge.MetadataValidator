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
	/// 	This class represents the Element SubGrp_TimeObject
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Choice,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement,
													"SubGrp_TimeObject", "http://www.opengis.net/gml", false, false,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class SubGrp_TimeObject : CSW.XmlCommonBase
	{
		#region Constructors
		/// <summary>
		///		Constructor for SubGrp_TimeObject
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public SubGrp_TimeObject()
		{
			_elementName = "SubGrp_TimeObject";
			Init();
		}
		public SubGrp_TimeObject(String elementName)
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
			m__TimeObject = null;
			m__TimeComplex = null;
			m_SubGrp_TimeComplex = null;
			m__TimePrimitive = null;
			m_SubGrp_TimePrimitive = null;



			_validElement = "";
// ##HAND_CODED_BLOCK_START ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional initialization code here...

// ##HAND_CODED_BLOCK_END ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
		}
		protected void ClearChoice(string selectedElement)
		{
			m__TimeObject = null;
			m__TimeComplex = null;
			m_SubGrp_TimeComplex = null;
			m__TimePrimitive = null;
			m_SubGrp_TimePrimitive = null;
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
			AE.SubGrp_TimeObject newObject = new AE.SubGrp_TimeObject(_elementName);
			newObject.m__TimeObject = null;
			if (m__TimeObject != null)
				newObject.m__TimeObject = (AE.IAbstractTimeObjectType)m__TimeObject.Clone();
			newObject.m__TimeComplex = null;
			if (m__TimeComplex != null)
				newObject.m__TimeComplex = (AE.IAbstractTimeComplexType)m__TimeComplex.Clone();
			newObject.m_SubGrp_TimeComplex = null;
			if (m_SubGrp_TimeComplex != null)
				newObject.m_SubGrp_TimeComplex = (AE.SubGrp_TimeComplex)m_SubGrp_TimeComplex.Clone();
			newObject.m__TimePrimitive = null;
			if (m__TimePrimitive != null)
				newObject.m__TimePrimitive = (AE.IAbstractTimePrimitiveType)m__TimePrimitive.Clone();
			newObject.m_SubGrp_TimePrimitive = null;
			if (m_SubGrp_TimePrimitive != null)
				newObject.m_SubGrp_TimePrimitive = (AE.SubGrp_TimePrimitive)m_SubGrp_TimePrimitive.Clone();

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

		#region Attribute - _TimeObject
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
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("_TimeObject", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.ClassFactory), "IAbstractTimeObjectTypeCreateObject")]
		public AE.IAbstractTimeObjectType _TimeObject
		{
			get 
			{ 
				return m__TimeObject;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"_TimeObject"); // remove selection
				if (value == null)
					m__TimeObject = null;
				else
				{
					m__TimeObject = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "_TimeObject");
				}
			}
		}
		protected AE.IAbstractTimeObjectType m__TimeObject;

		#endregion

		#region Attribute - _TimeComplex
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _TimeObject
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("_TimeComplex", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.ClassFactory), "IAbstractTimeComplexTypeCreateObject")]
		public AE.IAbstractTimeComplexType _TimeComplex
		{
			get 
			{ 
				return m__TimeComplex;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"_TimeComplex"); // remove selection
				if (value == null)
					m__TimeComplex = null;
				else
				{
					m__TimeComplex = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "_TimeComplex");
				}
			}
		}
		protected AE.IAbstractTimeComplexType m__TimeComplex;

		#endregion

		#region Attribute - SubGrp_TimeComplex
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _TimeObject
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("SubGrp_TimeComplex", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement, typeof(AE.SubGrp_TimeComplex))]
		public AE.SubGrp_TimeComplex SubGrp_TimeComplex
		{
			get 
			{ 
				return m_SubGrp_TimeComplex;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"SubGrp_TimeComplex"); // remove selection
				if (value == null)
					m_SubGrp_TimeComplex = null;
				else
				{
					m_SubGrp_TimeComplex = value; 
				}
			}
		}
		protected AE.SubGrp_TimeComplex m_SubGrp_TimeComplex;
		
		#endregion

		#region Attribute - _TimePrimitive
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _TimeObject
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

		#region Attribute - SubGrp_TimePrimitive
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _TimeObject
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("SubGrp_TimePrimitive", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement, typeof(AE.SubGrp_TimePrimitive))]
		public AE.SubGrp_TimePrimitive SubGrp_TimePrimitive
		{
			get 
			{ 
				return m_SubGrp_TimePrimitive;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"SubGrp_TimePrimitive"); // remove selection
				if (value == null)
					m_SubGrp_TimePrimitive = null;
				else
				{
					m_SubGrp_TimePrimitive = value; 
				}
			}
		}
		protected AE.SubGrp_TimePrimitive m_SubGrp_TimePrimitive;
		
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


