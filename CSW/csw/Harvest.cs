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
	/// 	This class represents the Element Harvest
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Sequence,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element,
													"Harvest", "http://www.opengis.net/cat/csw/2.0.2", true, true,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class Harvest : CSW.XmlCommonBase
					, csw.IRequestBaseType
	{
		#region Constructors
		/// <summary>
		///		Constructor for Harvest
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public Harvest()
		{
			_elementName = "Harvest";
			Init();
		}
		public Harvest(String elementName)
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
			m_Service = LiquidTechnologies.Runtime.Net45.Conversions.stringFromString("CSW", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse);
			m_Version = LiquidTechnologies.Runtime.Net45.Conversions.stringFromString("2.0.2", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse);
			m_Source = "";
			m_ResourceType = "";
			m_ResourceFormat = LiquidTechnologies.Runtime.Net45.Conversions.stringFromString("application/xml", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse);
			m_IsValidResourceFormat = false; 
			m_HarvestInterval = new LiquidTechnologies.Runtime.Net45.XmlDateTimeSpan();
			m_IsValidHarvestInterval = false; 
			m_ResponseHandlerCol = new CSW.XmlSimpleTypeCollection<String>("ResponseHandler", "http://www.opengis.net/cat/csw/2.0.2", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, 0, -1, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, new LiquidTechnologies.Runtime.Net45.PrimitiveRestrictions("", -1, -1, "", "", "", "", -1));



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
			csw.Harvest newObject = new csw.Harvest(_elementName);
			newObject.m_Service = m_Service;
			newObject.m_Version = m_Version;
			newObject.m_Source = m_Source;
			newObject.m_ResourceType = m_ResourceType;
			newObject.m_ResourceFormat = m_ResourceFormat;
			newObject.m_IsValidResourceFormat = m_IsValidResourceFormat;
			newObject.m_HarvestInterval = (LiquidTechnologies.Runtime.Net45.XmlDateTimeSpan)m_HarvestInterval.Clone();
			newObject.m_IsValidHarvestInterval = m_IsValidHarvestInterval;
			foreach (String o in m_ResponseHandlerCol)
				newObject.m_ResponseHandlerCol.Add(o);


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

		#region Attribute - service
		/// <summary>
		///		Represents a mandatory Attribute in the XML document
		///		
		/// </summary>
		/// <remarks>
		///		<BR></BR>
		///		<BR>This property is represented as an Attribute in the XML.</BR>
		///		<BR>It is mandatory and therefore must be populated within the XML.</BR>
		///		<BR>It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.stringFromString("CSW", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoPrimitive("service", "", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, null, "", -1, -1, "", "", "", "", -1)]
		public String Service
		{
			get 
			{ 
				return m_Service;  
			}
			set 
			{ 
				if (m_Service != value)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property service is marked as read only and may only have the value '" + m_Service.ToString() + "'");
			}
		}
		protected String m_Service;

		#endregion

		#region Attribute - version
		/// <summary>
		///		Represents a mandatory Attribute in the XML document
		///		
		/// </summary>
		/// <remarks>
		///		<BR></BR>
		///		<BR>This property is represented as an Attribute in the XML.</BR>
		///		<BR>It is mandatory and therefore must be populated within the XML.</BR>
		///		<BR>It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.stringFromString("2.0.2", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoPrimitive("version", "", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, null, "", -1, -1, "", "", "", "", -1)]
		public String Version
		{
			get 
			{ 
				return m_Version;  
			}
			set 
			{ 
				if (m_Version != value)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property version is marked as read only and may only have the value '" + m_Version.ToString() + "'");
			}
		}
		protected String m_Version;

		#endregion

		#region Attribute - Source
		/// <summary>
		///		Represents a mandatory Element in the XML document
		///		
		/// </summary>
		/// <remarks>
		///		<BR></BR>
		///		<BR>This property is represented as an Element in the XML.</BR>
		///		<BR>It is mandatory and therefore must be populated within the XML.</BR>
		///		<BR>It is defaulted to "".</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("Source", "http://www.opengis.net/cat/csw/2.0.2", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", -1, -1, "", "", "", "", -1)]
		public String Source
		{
			get 
			{ 
				return m_Source;  
			}
			set 
			{ 
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Collapse(value); 
				m_Source = value;
			}
		}
		protected String m_Source;

		#endregion

		#region Attribute - ResourceType
		/// <summary>
		///		Represents a mandatory Element in the XML document
		///		
		/// </summary>
		/// <remarks>
		///		<BR></BR>
		///		<BR>This property is represented as an Element in the XML.</BR>
		///		<BR>It is mandatory and therefore must be populated within the XML.</BR>
		///		<BR>It is defaulted to "".</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("ResourceType", "http://www.opengis.net/cat/csw/2.0.2", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", -1, -1, "", "", "", "", -1)]
		public String ResourceType
		{
			get 
			{ 
				return m_ResourceType;  
			}
			set 
			{ 
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				m_ResourceType = value;
			}
		}
		protected String m_ResourceType;

		#endregion

		#region Attribute - ResourceFormat
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimOpt("ResourceFormat", "http://www.opengis.net/cat/csw/2.0.2", "IsValidResourceFormat", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", -1, -1, "", "", "", "", -1)]
		public String ResourceFormat
		{
			get 
			{ 
				if (m_IsValidResourceFormat == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property ResourceFormat is not valid. Set ResourceFormatValid = true");
				return m_ResourceFormat;  
			}
			set 
			{ 
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				m_IsValidResourceFormat = true;
				m_ResourceFormat = value;
			}
		}
		/// <summary>
		/// 	Indicates if ResourceFormat contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for ResourceFormat is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value (LiquidTechnologies.Runtime.Net45.Conversions.stringFromString("application/xml", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)).</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get ResourceFormat
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidResourceFormat
		{
			get
			{
				return m_IsValidResourceFormat;
			}
			set 
			{ 
				if (value != m_IsValidResourceFormat)
				{
					ResourceFormat = LiquidTechnologies.Runtime.Net45.Conversions.stringFromString("application/xml", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse);
					m_IsValidResourceFormat = value;
				}
			}
		}
		protected Boolean m_IsValidResourceFormat;
		protected String m_ResourceFormat;
		#endregion

		#region Attribute - HarvestInterval
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimOpt("HarvestInterval", "http://www.opengis.net/cat/csw/2.0.2", "IsValidHarvestInterval", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_duration, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", -1, -1, "", "", "", "", -1)]
		public LiquidTechnologies.Runtime.Net45.XmlDateTimeSpan HarvestInterval
		{
			get 
			{ 
				if (m_IsValidHarvestInterval == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property HarvestInterval is not valid. Set HarvestIntervalValid = true");
				return m_HarvestInterval;  
			}
			set 
			{ 
				m_IsValidHarvestInterval = true;
				m_HarvestInterval = value;
			}
		}
		/// <summary>
		/// 	Indicates if HarvestInterval contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for HarvestInterval is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value (new LiquidTechnologies.Runtime.Net45.XmlDateTimeSpan()).</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get HarvestInterval
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidHarvestInterval
		{
			get
			{
				return m_IsValidHarvestInterval;
			}
			set 
			{ 
				if (value != m_IsValidHarvestInterval)
				{
					HarvestInterval = new LiquidTechnologies.Runtime.Net45.XmlDateTimeSpan();
					m_IsValidHarvestInterval = value;
				}
			}
		}
		protected Boolean m_IsValidHarvestInterval;
		protected LiquidTechnologies.Runtime.Net45.XmlDateTimeSpan m_HarvestInterval;
		#endregion

		#region Attribute - ResponseHandler
		/// <summary>
		///		A collection of Strings
		///		
		/// </summary>
		/// <remarks>
		///		<BR></BR>
		///		<BR>This property is represented as an Element in the XML.</BR>
		///		<BR>This collection may contain 0 to Many Strings.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimCol("ResponseHandler", "http://www.opengis.net/cat/csw/2.0.2")]
		public CSW.XmlSimpleTypeCollection<String> ResponseHandlerCol
		{
			get { return m_ResponseHandlerCol; }
		}
		protected CSW.XmlSimpleTypeCollection<String> m_ResponseHandlerCol;

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


