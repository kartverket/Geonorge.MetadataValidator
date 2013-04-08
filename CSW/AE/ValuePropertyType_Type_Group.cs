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
	/// 	This class represents the Element ValuePropertyType_Type_Group
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Choice,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement,
													"ValuePropertyType_Type_Group", "http://www.opengis.net/gml", false, false,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class ValuePropertyType_Type_Group : CSW.XmlCommonBase
	{
		#region Constructors
		/// <summary>
		///		Constructor for ValuePropertyType_Type_Group
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public ValuePropertyType_Type_Group()
		{
			_elementName = "ValuePropertyType_Type_Group";
			Init();
		}
		public ValuePropertyType_Type_Group(String elementName)
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
			m_ValueComponents_Choice_Choice = null;
			m__Object = null;
			m_Null = "";
			m_IsValidNull = false; 



			_validElement = "";
// ##HAND_CODED_BLOCK_START ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional initialization code here...

// ##HAND_CODED_BLOCK_END ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
		}
		protected void ClearChoice(string selectedElement)
		{
			m_ValueComponents_Choice_Choice = null;
			m__Object = null;
			m_Null = "";
			m_IsValidNull = false;
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
			AE.ValuePropertyType_Type_Group newObject = new AE.ValuePropertyType_Type_Group(_elementName);
			newObject.m_ValueComponents_Choice_Choice = null;
			if (m_ValueComponents_Choice_Choice != null)
				newObject.m_ValueComponents_Choice_Choice = (AE.ValueComponents_Choice_Choice)m_ValueComponents_Choice_Choice.Clone();
			newObject.m__Object = null;
			if (m__Object != null)
				newObject.m__Object = (AE.SubGrp_Object)m__Object.Clone();
			newObject.m_Null = m_Null;
			newObject.m_IsValidNull = m_IsValidNull;

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

		#region Attribute - valueComponents_Choice_Choice
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
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("valueComponents_Choice_Choice", "", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement, typeof(AE.ValueComponents_Choice_Choice))]
		public AE.ValueComponents_Choice_Choice ValueComponents_Choice_Choice
		{
			get 
			{ 
				return m_ValueComponents_Choice_Choice;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"valueComponents_Choice_Choice"); // remove selection
				if (value == null)
					m_ValueComponents_Choice_Choice = null;
				else
				{
					m_ValueComponents_Choice_Choice = value; 
				}
			}
		}
		protected AE.ValueComponents_Choice_Choice m_ValueComponents_Choice_Choice;
		
		#endregion

		#region Attribute - _Object
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
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("_Object", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement, typeof(AE.SubGrp_Object))]
		public AE.SubGrp_Object _Object
		{
			get 
			{ 
				return m__Object;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"_Object"); // remove selection
				if (value == null)
					m__Object = null;
				else
				{
					m__Object = value; 
				}
			}
		}
		protected AE.SubGrp_Object m__Object;
		
		#endregion

		#region Attribute - Null
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR>This objects data type is a union of a , , anyURI, . It may contain any value that is valid for any of these types</BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("Null", "http://www.opengis.net/gml", "IsValidNull", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", -1, -1, "", "", "", "", -1)]
		public String null_
		{
			get 
			{ 
				if (m_IsValidNull == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property null_ is not valid. Set null_Valid = true");
				return m_Null;  
			}
			set 
			{ 
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Collapse(value); 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("null_"); // remove selection
				m_IsValidNull = true;
				m_Null = value;
			}
		}
		/// <summary>
		/// 	Indicates if null_ contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for null_ is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value ("").</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get null_
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidNull
		{
			get
			{
				return m_IsValidNull;
			}
			set 
			{ 
				if (value != m_IsValidNull)
				{
					null_ = "";
					m_IsValidNull = value;
				}
			}
		}
		protected Boolean m_IsValidNull;
		protected String m_Null;
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


