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
	/// 	This class represents the ComplexType AddressType
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Sequence,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element,
													"AddressType", "http://www.opengis.net/ows", true, false,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class AddressType : CSW.XmlCommonBase
	{
		#region Constructors
		/// <summary>
		///		Constructor for AddressType
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public AddressType()
		{
			_elementName = "AddressType";
			Init();
		}
		public AddressType(String elementName)
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
			m_DeliveryPointCol = new CSW.XmlSimpleTypeCollection<String>("DeliveryPoint", "http://www.opengis.net/ows", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, 0, -1, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, new LiquidTechnologies.Runtime.Net45.PrimitiveRestrictions("", -1, -1, "", "", "", "", -1));
			m_City = "";
			m_IsValidCity = false; 
			m_AdministrativeArea = "";
			m_IsValidAdministrativeArea = false; 
			m_PostalCode = "";
			m_IsValidPostalCode = false; 
			m_Country = "";
			m_IsValidCountry = false; 
			m_ElectronicMailAddressCol = new CSW.XmlSimpleTypeCollection<String>("ElectronicMailAddress", "http://www.opengis.net/ows", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, 0, -1, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, new LiquidTechnologies.Runtime.Net45.PrimitiveRestrictions("", -1, -1, "", "", "", "", -1));



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
			ows.AddressType newObject = new ows.AddressType(_elementName);
			foreach (String o in m_DeliveryPointCol)
				newObject.m_DeliveryPointCol.Add(o);
			newObject.m_City = m_City;
			newObject.m_IsValidCity = m_IsValidCity;
			newObject.m_AdministrativeArea = m_AdministrativeArea;
			newObject.m_IsValidAdministrativeArea = m_IsValidAdministrativeArea;
			newObject.m_PostalCode = m_PostalCode;
			newObject.m_IsValidPostalCode = m_IsValidPostalCode;
			newObject.m_Country = m_Country;
			newObject.m_IsValidCountry = m_IsValidCountry;
			foreach (String o in m_ElectronicMailAddressCol)
				newObject.m_ElectronicMailAddressCol.Add(o);


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

		#region Attribute - DeliveryPoint
		/// <summary>
		///		A collection of Strings
		///		
		/// </summary>
		/// <remarks>
		///		<BR></BR>
		///		<BR>This property is represented as an Element in the XML.</BR>
		///		<BR>This collection may contain 0 to Many Strings.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimCol("DeliveryPoint", "http://www.opengis.net/ows")]
		public CSW.XmlSimpleTypeCollection<String> DeliveryPointCol
		{
			get { return m_DeliveryPointCol; }
		}
		protected CSW.XmlSimpleTypeCollection<String> m_DeliveryPointCol;

		#endregion

		#region Attribute - City
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimOpt("City", "http://www.opengis.net/ows", "IsValidCity", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", -1, -1, "", "", "", "", -1)]
		public String City
		{
			get 
			{ 
				if (m_IsValidCity == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property City is not valid. Set CityValid = true");
				return m_City;  
			}
			set 
			{ 
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				m_IsValidCity = true;
				m_City = value;
			}
		}
		/// <summary>
		/// 	Indicates if City contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for City is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value ("").</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get City
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidCity
		{
			get
			{
				return m_IsValidCity;
			}
			set 
			{ 
				if (value != m_IsValidCity)
				{
					City = "";
					m_IsValidCity = value;
				}
			}
		}
		protected Boolean m_IsValidCity;
		protected String m_City;
		#endregion

		#region Attribute - AdministrativeArea
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimOpt("AdministrativeArea", "http://www.opengis.net/ows", "IsValidAdministrativeArea", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", -1, -1, "", "", "", "", -1)]
		public String AdministrativeArea
		{
			get 
			{ 
				if (m_IsValidAdministrativeArea == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property AdministrativeArea is not valid. Set AdministrativeAreaValid = true");
				return m_AdministrativeArea;  
			}
			set 
			{ 
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				m_IsValidAdministrativeArea = true;
				m_AdministrativeArea = value;
			}
		}
		/// <summary>
		/// 	Indicates if AdministrativeArea contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for AdministrativeArea is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value ("").</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get AdministrativeArea
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidAdministrativeArea
		{
			get
			{
				return m_IsValidAdministrativeArea;
			}
			set 
			{ 
				if (value != m_IsValidAdministrativeArea)
				{
					AdministrativeArea = "";
					m_IsValidAdministrativeArea = value;
				}
			}
		}
		protected Boolean m_IsValidAdministrativeArea;
		protected String m_AdministrativeArea;
		#endregion

		#region Attribute - PostalCode
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimOpt("PostalCode", "http://www.opengis.net/ows", "IsValidPostalCode", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", -1, -1, "", "", "", "", -1)]
		public String PostalCode
		{
			get 
			{ 
				if (m_IsValidPostalCode == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property PostalCode is not valid. Set PostalCodeValid = true");
				return m_PostalCode;  
			}
			set 
			{ 
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				m_IsValidPostalCode = true;
				m_PostalCode = value;
			}
		}
		/// <summary>
		/// 	Indicates if PostalCode contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for PostalCode is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value ("").</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get PostalCode
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidPostalCode
		{
			get
			{
				return m_IsValidPostalCode;
			}
			set 
			{ 
				if (value != m_IsValidPostalCode)
				{
					PostalCode = "";
					m_IsValidPostalCode = value;
				}
			}
		}
		protected Boolean m_IsValidPostalCode;
		protected String m_PostalCode;
		#endregion

		#region Attribute - Country
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimOpt("Country", "http://www.opengis.net/ows", "IsValidCountry", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", -1, -1, "", "", "", "", -1)]
		public String Country
		{
			get 
			{ 
				if (m_IsValidCountry == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property Country is not valid. Set CountryValid = true");
				return m_Country;  
			}
			set 
			{ 
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				m_IsValidCountry = true;
				m_Country = value;
			}
		}
		/// <summary>
		/// 	Indicates if Country contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for Country is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value ("").</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get Country
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidCountry
		{
			get
			{
				return m_IsValidCountry;
			}
			set 
			{ 
				if (value != m_IsValidCountry)
				{
					Country = "";
					m_IsValidCountry = value;
				}
			}
		}
		protected Boolean m_IsValidCountry;
		protected String m_Country;
		#endregion

		#region Attribute - ElectronicMailAddress
		/// <summary>
		///		A collection of Strings
		///		
		/// </summary>
		/// <remarks>
		///		<BR></BR>
		///		<BR>This property is represented as an Element in the XML.</BR>
		///		<BR>This collection may contain 0 to Many Strings.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimCol("ElectronicMailAddress", "http://www.opengis.net/ows")]
		public CSW.XmlSimpleTypeCollection<String> ElectronicMailAddressCol
		{
			get { return m_ElectronicMailAddressCol; }
		}
		protected CSW.XmlSimpleTypeCollection<String> m_ElectronicMailAddressCol;

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


