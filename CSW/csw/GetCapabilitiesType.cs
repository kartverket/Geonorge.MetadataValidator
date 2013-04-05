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
	/// 	This class represents the ComplexType GetCapabilitiesType
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Sequence,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element,
													"GetCapabilitiesType", "http://www.opengis.net/cat/csw/2.0.2", true, true,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class GetCapabilitiesType : CSW.XmlCommonBase
					, ows.IGetCapabilitiesType
	{
		#region Constructors
		/// <summary>
		///		Constructor for GetCapabilitiesType
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public GetCapabilitiesType()
		{
			_elementName = "GetCapabilitiesType";
			Init();
		}
		public GetCapabilitiesType(String elementName)
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
			m_UpdateSequence = "";
			m_IsValidUpdateSequence = false;
			m_AcceptVersions = null;
			m_Sections = null;
			m_AcceptFormats = null;
			m_Service = LiquidTechnologies.Runtime.Net45.Conversions.stringFromString("http://www.opengis.net/cat/csw", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse);
			m_IsValidService = true;



// ##HAND_CODED_BLOCK_START ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional initialization code here...

// ##HAND_CODED_BLOCK_END ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
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
			csw.GetCapabilitiesType newObject = new csw.GetCapabilitiesType(_elementName);
			newObject.m_UpdateSequence = m_UpdateSequence;
			newObject.m_IsValidUpdateSequence = m_IsValidUpdateSequence;
			newObject.m_AcceptVersions = null;
			if (m_AcceptVersions != null)
				newObject.m_AcceptVersions = (ows.AcceptVersionsType)m_AcceptVersions.Clone();
			newObject.m_Sections = null;
			if (m_Sections != null)
				newObject.m_Sections = (ows.SectionsType)m_Sections.Clone();
			newObject.m_AcceptFormats = null;
			if (m_AcceptFormats != null)
				newObject.m_AcceptFormats = (ows.AcceptFormatsType)m_AcceptFormats.Clone();
			newObject.m_Service = m_Service;
			newObject.m_IsValidService = m_IsValidService;


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

		#region Attribute - updateSequence
		/// <summary>
		///		Represents an optional Attribute in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Attribute in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoPrimitive("updateSequence", "", "IsValidUpdateSequence", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, null, "", -1, -1, "", "", "", "", -1)]
		public String UpdateSequence
		{
			get 
			{ 
				if (m_IsValidUpdateSequence == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property updateSequence is not valid. Set updateSequenceValid = true");
				return m_UpdateSequence;  
			}
			set 
			{ 
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				m_IsValidUpdateSequence = true;
				m_UpdateSequence = value;
			}
		}
		/// <summary>
		/// 	Indicates if updateSequence contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for updateSequence is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value ("").</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get updateSequence
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidUpdateSequence
		{
			get
			{
				return m_IsValidUpdateSequence;
			}
			set 
			{ 
				if (value != m_IsValidUpdateSequence)
				{
					UpdateSequence = "";
					m_IsValidUpdateSequence = value;
				}
			}
		}
		protected Boolean m_IsValidUpdateSequence;
		protected String m_UpdateSequence;
		#endregion

		#region Attribute - AcceptVersions
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsOpt("AcceptVersions", "http://www.opengis.net/ows", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(ows.AcceptVersionsType))]
		public ows.AcceptVersionsType AcceptVersions
		{
			get 
			{ 
				return m_AcceptVersions;  
			}
			set 
			{ 
				if (value == null)
					m_AcceptVersions = null;
				else
				{
					SetElementName(value, "AcceptVersions");
					m_AcceptVersions = value; 
				}
			}
		}
		protected ows.AcceptVersionsType m_AcceptVersions;
		
		#endregion

		#region Attribute - Sections
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsOpt("Sections", "http://www.opengis.net/ows", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(ows.SectionsType))]
		public ows.SectionsType Sections
		{
			get 
			{ 
				return m_Sections;  
			}
			set 
			{ 
				if (value == null)
					m_Sections = null;
				else
				{
					SetElementName(value, "Sections");
					m_Sections = value; 
				}
			}
		}
		protected ows.SectionsType m_Sections;
		
		#endregion

		#region Attribute - AcceptFormats
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsOpt("AcceptFormats", "http://www.opengis.net/ows", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(ows.AcceptFormatsType))]
		public ows.AcceptFormatsType AcceptFormats
		{
			get 
			{ 
				return m_AcceptFormats;  
			}
			set 
			{ 
				if (value == null)
					m_AcceptFormats = null;
				else
				{
					SetElementName(value, "AcceptFormats");
					m_AcceptFormats = value; 
				}
			}
		}
		protected ows.AcceptFormatsType m_AcceptFormats;
		
		#endregion

		#region Attribute - service
		/// <summary>
		///		Represents an optional Attribute in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Attribute in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoPrimitive("service", "", "IsValidService", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "http://www.opengis.net/cat/csw", "", -1, -1, "", "", "", "", -1)]
		public String Service
		{
			get 
			{ 
				if (m_IsValidService == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property service is not valid. Set serviceValid = true");
				return m_Service;  
			}
			set 
			{ 
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				m_IsValidService = true;
				m_Service = value;
			}
		}
		/// <summary>
		/// 	Indicates if service contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for service is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value (LiquidTechnologies.Runtime.Net45.Conversions.stringFromString("http://www.opengis.net/cat/csw", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)).</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get service
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidService
		{
			get
			{
				return m_IsValidService;
			}
			set 
			{ 
				// Attributes with Default can not be removed.
				if (!value)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property service has a a default value, and is an attribute, because of this it can not be removed from the schema");
			}
		}
		protected Boolean m_IsValidService;
		protected String m_Service;
		#endregion

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


