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

namespace ows
{
	/// <summary>
	/// 	This class represents the Element ContactInfo
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Sequence,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element,
													"ContactInfo", "http://www.opengis.net/ows", true, false,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class ContactInfo : CSW.XmlCommonBase
	{
		#region Constructors
		/// <summary>
		///		Constructor for ContactInfo
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public ContactInfo()
		{
			_elementName = "ContactInfo";
			Init();
		}
		public ContactInfo(String elementName)
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
			m_Phone = null;
			m_Address = null;
			m_OnlineResource = null;
			m_HoursOfService = "";
			m_IsValidHoursOfService = false; 
			m_ContactInstructions = "";
			m_IsValidContactInstructions = false; 



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
			ows.ContactInfo newObject = new ows.ContactInfo(_elementName);
			newObject.m_Phone = null;
			if (m_Phone != null)
				newObject.m_Phone = (ows.TelephoneType)m_Phone.Clone();
			newObject.m_Address = null;
			if (m_Address != null)
				newObject.m_Address = (ows.AddressType)m_Address.Clone();
			newObject.m_OnlineResource = null;
			if (m_OnlineResource != null)
				newObject.m_OnlineResource = (ows.IOnlineResourceType)m_OnlineResource.Clone();
			newObject.m_HoursOfService = m_HoursOfService;
			newObject.m_IsValidHoursOfService = m_IsValidHoursOfService;
			newObject.m_ContactInstructions = m_ContactInstructions;
			newObject.m_IsValidContactInstructions = m_IsValidContactInstructions;


// ##HAND_CODED_BLOCK_START ID="Additional clone"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional clone code here...

// ##HAND_CODED_BLOCK_END ID="Additional clone"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

			return newObject;
		}
		#endregion

		#region Member variables

		protected override String TargetNamespace
		{
			get { return "http://www.opengis.net/ows"; }
		}

		#region Attribute - Phone
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsOpt("Phone", "http://www.opengis.net/ows", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(ows.TelephoneType))]
		public ows.TelephoneType Phone
		{
			get 
			{ 
				return m_Phone;  
			}
			set 
			{ 
				if (value == null)
					m_Phone = null;
				else
				{
					SetElementName(value, "Phone");
					m_Phone = value; 
				}
			}
		}
		protected ows.TelephoneType m_Phone;
		
		#endregion

		#region Attribute - Address
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsOpt("Address", "http://www.opengis.net/ows", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(ows.AddressType))]
		public ows.AddressType Address
		{
			get 
			{ 
				return m_Address;  
			}
			set 
			{ 
				if (value == null)
					m_Address = null;
				else
				{
					SetElementName(value, "Address");
					m_Address = value; 
				}
			}
		}
		protected ows.AddressType m_Address;
		
		#endregion

		#region Attribute - OnlineResource
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqAbsClsOpt("OnlineResource", "http://www.opengis.net/ows", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(ows.ClassFactory), "IOnlineResourceTypeCreateObject")]
		public ows.IOnlineResourceType OnlineResource
		{
			get 
			{ 
				return m_OnlineResource;  
			}
			set 
			{ 
				if (value == null)
					m_OnlineResource = null;
				else
				{
					m_OnlineResource = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "OnlineResource");
				}
			}
		}
		protected ows.IOnlineResourceType m_OnlineResource;

		#endregion

		#region Attribute - HoursOfService
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimOpt("HoursOfService", "http://www.opengis.net/ows", "IsValidHoursOfService", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", -1, -1, "", "", "", "", -1)]
		public String HoursOfService
		{
			get 
			{ 
				if (m_IsValidHoursOfService == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property HoursOfService is not valid. Set HoursOfServiceValid = true");
				return m_HoursOfService;  
			}
			set 
			{ 
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				m_IsValidHoursOfService = true;
				m_HoursOfService = value;
			}
		}
		/// <summary>
		/// 	Indicates if HoursOfService contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for HoursOfService is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value ("").</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get HoursOfService
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidHoursOfService
		{
			get
			{
				return m_IsValidHoursOfService;
			}
			set 
			{ 
				if (value != m_IsValidHoursOfService)
				{
					HoursOfService = "";
					m_IsValidHoursOfService = value;
				}
			}
		}
		protected Boolean m_IsValidHoursOfService;
		protected String m_HoursOfService;
		#endregion

		#region Attribute - ContactInstructions
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimOpt("ContactInstructions", "http://www.opengis.net/ows", "IsValidContactInstructions", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", -1, -1, "", "", "", "", -1)]
		public String ContactInstructions
		{
			get 
			{ 
				if (m_IsValidContactInstructions == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property ContactInstructions is not valid. Set ContactInstructionsValid = true");
				return m_ContactInstructions;  
			}
			set 
			{ 
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				m_IsValidContactInstructions = true;
				m_ContactInstructions = value;
			}
		}
		/// <summary>
		/// 	Indicates if ContactInstructions contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for ContactInstructions is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value ("").</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get ContactInstructions
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidContactInstructions
		{
			get
			{
				return m_IsValidContactInstructions;
			}
			set 
			{ 
				if (value != m_IsValidContactInstructions)
				{
					ContactInstructions = "";
					m_IsValidContactInstructions = value;
				}
			}
		}
		protected Boolean m_IsValidContactInstructions;
		protected String m_ContactInstructions;
		#endregion

		#region Attribute - Namespace
		public override String Namespace
		{
			get { return "http://www.opengis.net/ows"; }
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


