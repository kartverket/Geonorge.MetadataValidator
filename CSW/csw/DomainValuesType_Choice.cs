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

namespace csw
{
	/// <summary>
	/// 	This class represents the Element DomainValuesType_Choice
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Choice,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement,
													"DomainValuesType_Choice", "http://www.opengis.net/cat/csw/2.0.2", false, false,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class DomainValuesType_Choice : CSW.XmlCommonBase
	{
		#region Constructors
		/// <summary>
		///		Constructor for DomainValuesType_Choice
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public DomainValuesType_Choice()
		{
			_elementName = "DomainValuesType_Choice";
			Init();
		}
		public DomainValuesType_Choice(String elementName)
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
			m_PropertyName = "";
			m_IsValidPropertyName = false; 
			m_ParameterName = "";
			m_IsValidParameterName = false; 



			_validElement = "";
// ##HAND_CODED_BLOCK_START ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional initialization code here...

// ##HAND_CODED_BLOCK_END ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
		}
		protected void ClearChoice(string selectedElement)
		{
			m_PropertyName = "";
			m_IsValidPropertyName = false;
			m_ParameterName = "";
			m_IsValidParameterName = false;
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
			csw.DomainValuesType_Choice newObject = new csw.DomainValuesType_Choice(_elementName);
			newObject.m_PropertyName = m_PropertyName;
			newObject.m_IsValidPropertyName = m_IsValidPropertyName;
			newObject.m_ParameterName = m_ParameterName;
			newObject.m_IsValidParameterName = m_IsValidParameterName;

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
			get { return "http://www.opengis.net/cat/csw/2.0.2"; }
		}

		#region Attribute - PropertyName
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("PropertyName", "http://www.opengis.net/cat/csw/2.0.2", "IsValidPropertyName", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", -1, -1, "", "", "", "", -1)]
		public String PropertyName
		{
			get 
			{ 
				if (m_IsValidPropertyName == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property PropertyName is not valid. Set PropertyNameValid = true");
				return m_PropertyName;  
			}
			set 
			{ 
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Collapse(value); 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("PropertyName"); // remove selection
				m_IsValidPropertyName = true;
				m_PropertyName = value;
			}
		}
		/// <summary>
		/// 	Indicates if PropertyName contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for PropertyName is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value ("").</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get PropertyName
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidPropertyName
		{
			get
			{
				return m_IsValidPropertyName;
			}
			set 
			{ 
				if (value != m_IsValidPropertyName)
				{
					PropertyName = "";
					m_IsValidPropertyName = value;
				}
			}
		}
		protected Boolean m_IsValidPropertyName;
		protected String m_PropertyName;
		#endregion

		#region Attribute - ParameterName
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("ParameterName", "http://www.opengis.net/cat/csw/2.0.2", "IsValidParameterName", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", -1, -1, "", "", "", "", -1)]
		public String ParameterName
		{
			get 
			{ 
				if (m_IsValidParameterName == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property ParameterName is not valid. Set ParameterNameValid = true");
				return m_ParameterName;  
			}
			set 
			{ 
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Collapse(value); 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("ParameterName"); // remove selection
				m_IsValidParameterName = true;
				m_ParameterName = value;
			}
		}
		/// <summary>
		/// 	Indicates if ParameterName contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for ParameterName is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value ("").</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get ParameterName
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidParameterName
		{
			get
			{
				return m_IsValidParameterName;
			}
			set 
			{ 
				if (value != m_IsValidParameterName)
				{
					ParameterName = "";
					m_IsValidParameterName = value;
				}
			}
		}
		protected Boolean m_IsValidParameterName;
		protected String m_ParameterName;
		#endregion

		public String ChoiceSelectedElement
		{
			get { return _validElement;  }
		}
		protected String _validElement;
		#region Attribute - Namespace
		public override String Namespace
		{
			get { return "http://www.opengis.net/cat/csw/2.0.2"; }
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


