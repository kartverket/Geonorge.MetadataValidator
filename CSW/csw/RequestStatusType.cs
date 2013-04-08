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
	/// 	This class represents the ComplexType RequestStatusType
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Sequence,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element,
													"RequestStatusType", "http://www.opengis.net/cat/csw/2.0.2", true, false,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class RequestStatusType : CSW.XmlCommonBase
	{
		#region Constructors
		/// <summary>
		///		Constructor for RequestStatusType
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public RequestStatusType()
		{
			_elementName = "RequestStatusType";
			Init();
		}
		public RequestStatusType(String elementName)
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
			m_Timestamp = new LiquidTechnologies.Runtime.Net45.XmlDateTime(LiquidTechnologies.Runtime.Net45.XmlDateTime.DateType.dateTime);
			m_IsValidTimestamp = false;



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
			csw.RequestStatusType newObject = new csw.RequestStatusType(_elementName);
			newObject.m_Timestamp = (LiquidTechnologies.Runtime.Net45.XmlDateTime)m_Timestamp.Clone();
			newObject.m_IsValidTimestamp = m_IsValidTimestamp;


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

		#region Attribute - timestamp
		/// <summary>
		///		Represents an optional Attribute in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Attribute in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoPrimitive("timestamp", "", "IsValidTimestamp", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_datetime, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, null, "", -1, -1, "", "", "", "", -1)]
		public LiquidTechnologies.Runtime.Net45.XmlDateTime Timestamp
		{
			get 
			{ 
				if (m_IsValidTimestamp == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property timestamp is not valid. Set timestampValid = true");
				return m_Timestamp;  
			}
			set 
			{ 
				m_IsValidTimestamp = true;
				m_Timestamp.SetDateTime(value, m_Timestamp.Type); 
			}
		}
		/// <summary>
		/// 	Indicates if timestamp contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for timestamp is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value (new LiquidTechnologies.Runtime.Net45.XmlDateTime(LiquidTechnologies.Runtime.Net45.XmlDateTime.DateType.dateTime)).</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get timestamp
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidTimestamp
		{
			get
			{
				return m_IsValidTimestamp;
			}
			set 
			{ 
				if (value != m_IsValidTimestamp)
				{
					Timestamp = new LiquidTechnologies.Runtime.Net45.XmlDateTime(LiquidTechnologies.Runtime.Net45.XmlDateTime.DateType.dateTime);
					m_IsValidTimestamp = value;
				}
			}
		}
		protected Boolean m_IsValidTimestamp;
		protected LiquidTechnologies.Runtime.Net45.XmlDateTime m_Timestamp;
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


