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
	/// 	This class represents the Element AssociationType_Type_Group
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Choice,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement,
													"AssociationType_Type_Group", "http://www.opengis.net/gml", false, false,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class AssociationType_Type_Group : CSW.XmlCommonBase
	{
		#region Constructors
		/// <summary>
		///		Constructor for AssociationType_Type_Group
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public AssociationType_Type_Group()
		{
			_elementName = "AssociationType_Type_Group";
			Init();
		}
		public AssociationType_Type_Group(String elementName)
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
			m__Object = null;
			m__MetaData = null;
			m_SubGrp_MetaData = null;
			m__GML = null;
			m_SubGrp_GML = null;



			_validElement = "";
// ##HAND_CODED_BLOCK_START ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional initialization code here...

// ##HAND_CODED_BLOCK_END ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
		}
		protected void ClearChoice(string selectedElement)
		{
			m__Object = null;
			m__MetaData = null;
			m_SubGrp_MetaData = null;
			m__GML = null;
			m_SubGrp_GML = null;
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
			AE.AssociationType_Type_Group newObject = new AE.AssociationType_Type_Group(_elementName);
			newObject.m__Object = null;
			if (m__Object != null)
				newObject.m__Object = (LiquidTechnologies.Runtime.Net45.Element)m__Object.Clone();
			newObject.m__MetaData = null;
			if (m__MetaData != null)
				newObject.m__MetaData = (AE.I_MetaData)m__MetaData.Clone();
			newObject.m_SubGrp_MetaData = null;
			if (m_SubGrp_MetaData != null)
				newObject.m_SubGrp_MetaData = (AE.SubGrp_MetaData)m_SubGrp_MetaData.Clone();
			newObject.m__GML = null;
			if (m__GML != null)
				newObject.m__GML = (AE.I_GML)m__GML.Clone();
			newObject.m_SubGrp_GML = null;
			if (m_SubGrp_GML != null)
				newObject.m_SubGrp_GML = (AE.SubGrp_GML)m_SubGrp_GML.Clone();

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

		#region Attribute - _Object
		/// <summary>
		///		Represents an optional untyped element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceUntpdOpt("_Object", "http://www.opengis.net/gml", "##any", "http://www.opengis.net/cat/csw/2.0.2")]
		public LiquidTechnologies.Runtime.Net45.Element _Object
		{
			get
			{
				return m__Object;  
			}
			set
			{
				if (value != null)
					LiquidTechnologies.Runtime.Net45.Element.TestNamespace(value.Namespace, "##any", "http://www.opengis.net/cat/csw/2.0.2");
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"_Object");
				m__Object = value; 
			}
		}
		protected LiquidTechnologies.Runtime.Net45.Element m__Object;
		#endregion

		#region Attribute - _MetaData
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _Object
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("_MetaData", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.ClassFactory), "I_MetaDataCreateObject")]
		public AE.I_MetaData _MetaData
		{
			get 
			{ 
				return m__MetaData;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"_MetaData"); // remove selection
				if (value == null)
					m__MetaData = null;
				else
				{
					m__MetaData = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "_MetaData");
				}
			}
		}
		protected AE.I_MetaData m__MetaData;

		#endregion

		#region Attribute - SubGrp_MetaData
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _Object
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("SubGrp_MetaData", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement, typeof(AE.SubGrp_MetaData))]
		public AE.SubGrp_MetaData SubGrp_MetaData
		{
			get 
			{ 
				return m_SubGrp_MetaData;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"SubGrp_MetaData"); // remove selection
				if (value == null)
					m_SubGrp_MetaData = null;
				else
				{
					m_SubGrp_MetaData = value; 
				}
			}
		}
		protected AE.SubGrp_MetaData m_SubGrp_MetaData;
		
		#endregion

		#region Attribute - _GML
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _Object
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("_GML", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.ClassFactory), "I_GMLCreateObject")]
		public AE.I_GML _GML
		{
			get 
			{ 
				return m__GML;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"_GML"); // remove selection
				if (value == null)
					m__GML = null;
				else
				{
					m__GML = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "_GML");
				}
			}
		}
		protected AE.I_GML m__GML;

		#endregion

		#region Attribute - SubGrp_GML
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _Object
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("SubGrp_GML", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement, typeof(AE.SubGrp_GML))]
		public AE.SubGrp_GML SubGrp_GML
		{
			get 
			{ 
				return m_SubGrp_GML;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"SubGrp_GML"); // remove selection
				if (value == null)
					m_SubGrp_GML = null;
				else
				{
					m_SubGrp_GML = value; 
				}
			}
		}
		protected AE.SubGrp_GML m_SubGrp_GML;
		
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


