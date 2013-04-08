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
	/// 	This class represents the Element GetRecordsResponse
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Sequence,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element,
													"GetRecordsResponse", "http://www.opengis.net/cat/csw/2.0.2", true, false,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class GetRecordsResponse : CSW.XmlCommonBase
	{
		#region Constructors
		/// <summary>
		///		Constructor for GetRecordsResponse
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public GetRecordsResponse()
		{
			_elementName = "GetRecordsResponse";
			Init();
		}
		public GetRecordsResponse(String elementName)
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
			m_Version = "";
			m_IsValidVersion = false;
			m_RequestId = "";
			m_IsValidRequestId = false; 
			m_SearchStatus = new csw.RequestStatusType("SearchStatus");
			m_SearchResults = new csw.SearchResultsType("SearchResults");



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
			csw.GetRecordsResponse newObject = new csw.GetRecordsResponse(_elementName);
			newObject.m_Version = m_Version;
			newObject.m_IsValidVersion = m_IsValidVersion;
			newObject.m_RequestId = m_RequestId;
			newObject.m_IsValidRequestId = m_IsValidRequestId;
			newObject.m_SearchStatus = null;
			if (m_SearchStatus != null)
				newObject.m_SearchStatus = (csw.RequestStatusType)m_SearchStatus.Clone();
			newObject.m_SearchResults = null;
			if (m_SearchResults != null)
				newObject.m_SearchResults = (csw.SearchResultsType)m_SearchResults.Clone();


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

		#region Attribute - version
		/// <summary>
		///		Represents an optional Attribute in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Attribute in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoPrimitive("version", "", "IsValidVersion", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, null, "", -1, -1, "", "", "", "", -1)]
		public String Version
		{
			get 
			{ 
				if (m_IsValidVersion == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property version is not valid. Set versionValid = true");
				return m_Version;  
			}
			set 
			{ 
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				m_IsValidVersion = true;
				m_Version = value;
			}
		}
		/// <summary>
		/// 	Indicates if version contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for version is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value ("").</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get version
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidVersion
		{
			get
			{
				return m_IsValidVersion;
			}
			set 
			{ 
				if (value != m_IsValidVersion)
				{
					Version = "";
					m_IsValidVersion = value;
				}
			}
		}
		protected Boolean m_IsValidVersion;
		protected String m_Version;
		#endregion

		#region Attribute - RequestId
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimOpt("RequestId", "http://www.opengis.net/cat/csw/2.0.2", "IsValidRequestId", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", -1, -1, "", "", "", "", -1)]
		public String RequestId
		{
			get 
			{ 
				if (m_IsValidRequestId == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property RequestId is not valid. Set RequestIdValid = true");
				return m_RequestId;  
			}
			set 
			{ 
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Collapse(value); 
				m_IsValidRequestId = true;
				m_RequestId = value;
			}
		}
		/// <summary>
		/// 	Indicates if RequestId contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for RequestId is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value ("").</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get RequestId
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidRequestId
		{
			get
			{
				return m_IsValidRequestId;
			}
			set 
			{ 
				if (value != m_IsValidRequestId)
				{
					RequestId = "";
					m_IsValidRequestId = value;
				}
			}
		}
		protected Boolean m_IsValidRequestId;
		protected String m_RequestId;
		#endregion

		#region Attribute - SearchStatus
		/// <summary>
		///		Represents a mandatory Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is mandatory and therefore must be populated within the XML.</BR>
		///		<BR>If this property is set, then the object will be COPIED. If the property is set to null an exception is raised.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsMnd("SearchStatus", "http://www.opengis.net/cat/csw/2.0.2", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(csw.RequestStatusType), false)]
		public csw.RequestStatusType SearchStatus
		{
			get 
			{ 
				return m_SearchStatus;  
			}
			set 
			{ 
				Throw_IfPropertyIsNull(value, "SearchStatus");
				if (value != null)
					SetElementName(value, "SearchStatus");
				m_SearchStatus = value;
			}
		}
		protected csw.RequestStatusType m_SearchStatus;
		
		#endregion

		#region Attribute - SearchResults
		/// <summary>
		///		Represents a mandatory Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is mandatory and therefore must be populated within the XML.</BR>
		///		<BR>If this property is set, then the object will be COPIED. If the property is set to null an exception is raised.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsMnd("SearchResults", "http://www.opengis.net/cat/csw/2.0.2", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(csw.SearchResultsType), false)]
		public csw.SearchResultsType SearchResults
		{
			get 
			{ 
				return m_SearchResults;  
			}
			set 
			{ 
				Throw_IfPropertyIsNull(value, "SearchResults");
				if (value != null)
					SetElementName(value, "SearchResults");
				m_SearchResults = value;
			}
		}
		protected csw.SearchResultsType m_SearchResults;
		
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


