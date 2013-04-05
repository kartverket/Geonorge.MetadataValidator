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
	/// 	This class represents the Element timeInterval
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Sequence,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element,
													"timeInterval", "http://www.opengis.net/gml", true, false,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_decimal, null, false)]
	public partial class TimeInterval : CSW.XmlCommonBase
	{
		#region Constructors
		/// <summary>
		///		Constructor for TimeInterval
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public TimeInterval()
		{
			_elementName = "timeInterval";
			Init();
		}
		public TimeInterval(String elementName)
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
			m_Unit = "";
			m_Radix = 0;
			m_IsValidRadix = false;
			m_Factor = 0;
			m_IsValidFactor = false;


			_primitiveValue = 0;

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
			AE.TimeInterval newObject = new AE.TimeInterval(_elementName);
			newObject.m_Unit = m_Unit;
			newObject.m_Radix = m_Radix;
			newObject.m_IsValidRadix = m_IsValidRadix;
			newObject.m_Factor = m_Factor;
			newObject.m_IsValidFactor = m_IsValidFactor;


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

		#region Attribute - unit
		/// <summary>
		///		Represents a mandatory Attribute in the XML document
		///		
		/// </summary>
		/// <remarks>
		///		<BR></BR>
		///		<BR>This property is represented as an Attribute in the XML.</BR>
		///		<BR>It is mandatory and therefore must be populated within the XML.</BR>
		///		<BR>It is defaulted to "".</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoPrimitive("unit", "", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, null, "", -1, -1, "", "", "", "", -1)]
		public String Unit
		{
			get 
			{ 
				return m_Unit;  
			}
			set 
			{ 
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Collapse(value); 
				m_Unit = value;
			}
		}
		protected String m_Unit;

		#endregion

		#region Attribute - radix
		/// <summary>
		///		Represents an optional Attribute in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Attribute in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoPrimitive("radix", "", "IsValidRadix", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_integer, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, null, "", -1, -1, "", "", "", "", -1)]
		public LiquidTechnologies.Runtime.Net45.BigInteger Radix
		{
			get 
			{ 
				if (m_IsValidRadix == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property radix is not valid. Set radixValid = true");
				return m_Radix;  
			}
			set 
			{ 
				m_IsValidRadix = true;
				m_Radix = value;
			}
		}
		/// <summary>
		/// 	Indicates if radix contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for radix is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value (0).</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get radix
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidRadix
		{
			get
			{
				return m_IsValidRadix;
			}
			set 
			{ 
				if (value != m_IsValidRadix)
				{
					Radix = 0;
					m_IsValidRadix = value;
				}
			}
		}
		protected Boolean m_IsValidRadix;
		protected LiquidTechnologies.Runtime.Net45.BigInteger m_Radix;
		#endregion

		#region Attribute - factor
		/// <summary>
		///		Represents an optional Attribute in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Attribute in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoPrimitive("factor", "", "IsValidFactor", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_integer, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, null, "", -1, -1, "", "", "", "", -1)]
		public LiquidTechnologies.Runtime.Net45.BigInteger Factor
		{
			get 
			{ 
				if (m_IsValidFactor == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property factor is not valid. Set factorValid = true");
				return m_Factor;  
			}
			set 
			{ 
				m_IsValidFactor = true;
				m_Factor = value;
			}
		}
		/// <summary>
		/// 	Indicates if factor contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for factor is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value (0).</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get factor
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidFactor
		{
			get
			{
				return m_IsValidFactor;
			}
			set 
			{ 
				if (value != m_IsValidFactor)
				{
					Factor = 0;
					m_IsValidFactor = value;
				}
			}
		}
		protected Boolean m_IsValidFactor;
		protected LiquidTechnologies.Runtime.Net45.BigInteger m_Factor;
		#endregion

		#region Attribute - PrimitiveValue

		/// <summary>
		/// 	The InnerText for this element
		/// </summary>
		/// <remarks>
		/// 	This class represents the element TimeInterval, this
		/// 	element is open, and as such we can place data into it.
		/// 	<BR>ie &lt;TimeInterval&gt;Some Data&lt;/TimeInterval&gt;</BR>
		/// </remarks>
		public Decimal PrimitiveValue
		{
			get
			{
				return _primitiveValue;
			}
			set
			{
				_primitiveValue = value;
			}
		}
		protected Decimal _primitiveValue;
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


