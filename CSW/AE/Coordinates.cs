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
	/// 	This class represents the Element coordinates
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Sequence,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element,
													"coordinates", "http://www.opengis.net/gml", true, false,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, false)]
	public partial class Coordinates : CSW.XmlCommonBase
	{
		#region Constructors
		/// <summary>
		///		Constructor for Coordinates
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public Coordinates()
		{
			_elementName = "coordinates";
			Init();
		}
		public Coordinates(String elementName)
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
			m_Decimal = LiquidTechnologies.Runtime.Net45.Conversions.stringFromString(".", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse);
			m_IsValidDecimal = true;
			m_Cs = LiquidTechnologies.Runtime.Net45.Conversions.stringFromString(",", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse);
			m_IsValidCs = true;
			m_Ts = LiquidTechnologies.Runtime.Net45.Conversions.stringFromString(" ", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse);
			m_IsValidTs = true;


			_primitiveValue = "";

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
			AE.Coordinates newObject = new AE.Coordinates(_elementName);
			newObject.m_Decimal = m_Decimal;
			newObject.m_IsValidDecimal = m_IsValidDecimal;
			newObject.m_Cs = m_Cs;
			newObject.m_IsValidCs = m_IsValidCs;
			newObject.m_Ts = m_Ts;
			newObject.m_IsValidTs = m_IsValidTs;


			newObject._primitiveValue = _primitiveValue;
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

		#region Attribute - decimal
		/// <summary>
		///		Represents an optional Attribute in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Attribute in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoPrimitive("decimal", "", "IsValidDecimal", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, ".", "", -1, -1, "", "", "", "", -1)]
		public String decimal_
		{
			get 
			{ 
				if (m_IsValidDecimal == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property decimal_ is not valid. Set decimal_Valid = true");
				return m_Decimal;  
			}
			set 
			{ 
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				m_IsValidDecimal = true;
				m_Decimal = value;
			}
		}
		/// <summary>
		/// 	Indicates if decimal_ contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for decimal_ is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value (LiquidTechnologies.Runtime.Net45.Conversions.stringFromString(".", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)).</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get decimal_
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidDecimal
		{
			get
			{
				return m_IsValidDecimal;
			}
			set 
			{ 
				// Attributes with Default can not be removed.
				if (!value)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property decimal_ has a a default value, and is an attribute, because of this it can not be removed from the schema");
			}
		}
		protected Boolean m_IsValidDecimal;
		protected String m_Decimal;
		#endregion

		#region Attribute - cs
		/// <summary>
		///		Represents an optional Attribute in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Attribute in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoPrimitive("cs", "", "IsValidCs", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, ",", "", -1, -1, "", "", "", "", -1)]
		public String Cs
		{
			get 
			{ 
				if (m_IsValidCs == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property cs is not valid. Set csValid = true");
				return m_Cs;  
			}
			set 
			{ 
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				m_IsValidCs = true;
				m_Cs = value;
			}
		}
		/// <summary>
		/// 	Indicates if cs contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for cs is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value (LiquidTechnologies.Runtime.Net45.Conversions.stringFromString(",", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)).</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get cs
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidCs
		{
			get
			{
				return m_IsValidCs;
			}
			set 
			{ 
				// Attributes with Default can not be removed.
				if (!value)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property cs has a a default value, and is an attribute, because of this it can not be removed from the schema");
			}
		}
		protected Boolean m_IsValidCs;
		protected String m_Cs;
		#endregion

		#region Attribute - ts
		/// <summary>
		///		Represents an optional Attribute in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Attribute in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoPrimitive("ts", "", "IsValidTs", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, " ", "", -1, -1, "", "", "", "", -1)]
		public String Ts
		{
			get 
			{ 
				if (m_IsValidTs == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property ts is not valid. Set tsValid = true");
				return m_Ts;  
			}
			set 
			{ 
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				m_IsValidTs = true;
				m_Ts = value;
			}
		}
		/// <summary>
		/// 	Indicates if ts contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for ts is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value (LiquidTechnologies.Runtime.Net45.Conversions.stringFromString(" ", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)).</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get ts
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidTs
		{
			get
			{
				return m_IsValidTs;
			}
			set 
			{ 
				// Attributes with Default can not be removed.
				if (!value)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property ts has a a default value, and is an attribute, because of this it can not be removed from the schema");
			}
		}
		protected Boolean m_IsValidTs;
		protected String m_Ts;
		#endregion

		#region Attribute - PrimitiveValue

		/// <summary>
		/// 	The InnerText for this element
		/// </summary>
		/// <remarks>
		/// 	This class represents the element Coordinates, this
		/// 	element is open, and as such we can place data into it.
		/// 	<BR>ie &lt;Coordinates&gt;Some Data&lt;/Coordinates&gt;</BR>
		/// </remarks>
		public String PrimitiveValue
		{
			get
			{
				return _primitiveValue;
			}
			set
			{
				_primitiveValue = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value);
			}
		}
		protected String _primitiveValue;
		#endregion
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


