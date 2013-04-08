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
	/// 	This class represents the Element posList
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Sequence,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element,
													"posList", "http://www.opengis.net/gml", true, false,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_r8, null, false)]
	public partial class PosList : CSW.XmlCommonBase
	{
		#region Constructors
		/// <summary>
		///		Constructor for PosList
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public PosList()
		{
			_elementName = "posList";
			Init();
		}
		public PosList(String elementName)
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
			m_SrsName = "";
			m_IsValidSrsName = false;
			m_SrsDimension = 0;
			m_IsValidSrsDimension = false;
			m_AxisLabels = "";
			m_IsValidAxisLabels = false;
			m_UomLabels = "";
			m_IsValidUomLabels = false;
			m_Count = 0;
			m_IsValidCount = false;


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
			AE.PosList newObject = new AE.PosList(_elementName);
			newObject.m_SrsName = m_SrsName;
			newObject.m_IsValidSrsName = m_IsValidSrsName;
			newObject.m_SrsDimension = m_SrsDimension;
			newObject.m_IsValidSrsDimension = m_IsValidSrsDimension;
			newObject.m_AxisLabels = m_AxisLabels;
			newObject.m_IsValidAxisLabels = m_IsValidAxisLabels;
			newObject.m_UomLabels = m_UomLabels;
			newObject.m_IsValidUomLabels = m_IsValidUomLabels;
			newObject.m_Count = m_Count;
			newObject.m_IsValidCount = m_IsValidCount;


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

		#region Attribute - srsName
		/// <summary>
		///		Represents an optional Attribute in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Attribute in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoPrimitive("srsName", "", "IsValidSrsName", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, null, "", -1, -1, "", "", "", "", -1)]
		public String SrsName
		{
			get 
			{ 
				if (m_IsValidSrsName == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property srsName is not valid. Set srsNameValid = true");
				return m_SrsName;  
			}
			set 
			{ 
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Collapse(value); 
				m_IsValidSrsName = true;
				m_SrsName = value;
			}
		}
		/// <summary>
		/// 	Indicates if srsName contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for srsName is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value ("").</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get srsName
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidSrsName
		{
			get
			{
				return m_IsValidSrsName;
			}
			set 
			{ 
				if (value != m_IsValidSrsName)
				{
					SrsName = "";
					m_IsValidSrsName = value;
				}
			}
		}
		protected Boolean m_IsValidSrsName;
		protected String m_SrsName;
		#endregion

		#region Attribute - srsDimension
		/// <summary>
		///		Represents an optional Attribute in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Attribute in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoPrimitive("srsDimension", "", "IsValidSrsDimension", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_integer, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, null, "", -1, -1, "", "", "", "", -1)]
		public LiquidTechnologies.Runtime.Net45.BigInteger SrsDimension
		{
			get 
			{ 
				if (m_IsValidSrsDimension == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property srsDimension is not valid. Set srsDimensionValid = true");
				return m_SrsDimension;  
			}
			set 
			{ 
				m_IsValidSrsDimension = true;
				m_SrsDimension = value;
			}
		}
		/// <summary>
		/// 	Indicates if srsDimension contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for srsDimension is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value (0).</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get srsDimension
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidSrsDimension
		{
			get
			{
				return m_IsValidSrsDimension;
			}
			set 
			{ 
				if (value != m_IsValidSrsDimension)
				{
					SrsDimension = 0;
					m_IsValidSrsDimension = value;
				}
			}
		}
		protected Boolean m_IsValidSrsDimension;
		protected LiquidTechnologies.Runtime.Net45.BigInteger m_SrsDimension;
		#endregion

		#region Attribute - axisLabels
		/// <summary>
		///		Represents an optional Attribute in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Attribute in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoPrimitive("axisLabels", "", "IsValidAxisLabels", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, null, "", -1, -1, "", "", "", "", -1)]
		public String AxisLabels
		{
			get 
			{ 
				if (m_IsValidAxisLabels == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property axisLabels is not valid. Set axisLabelsValid = true");
				return m_AxisLabels;  
			}
			set 
			{ 
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Collapse(value); 
				m_IsValidAxisLabels = true;
				m_AxisLabels = value;
			}
		}
		/// <summary>
		/// 	Indicates if axisLabels contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for axisLabels is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value ("").</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get axisLabels
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidAxisLabels
		{
			get
			{
				return m_IsValidAxisLabels;
			}
			set 
			{ 
				if (value != m_IsValidAxisLabels)
				{
					AxisLabels = "";
					m_IsValidAxisLabels = value;
				}
			}
		}
		protected Boolean m_IsValidAxisLabels;
		protected String m_AxisLabels;
		#endregion

		#region Attribute - uomLabels
		/// <summary>
		///		Represents an optional Attribute in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Attribute in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoPrimitive("uomLabels", "", "IsValidUomLabels", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, null, "", -1, -1, "", "", "", "", -1)]
		public String UomLabels
		{
			get 
			{ 
				if (m_IsValidUomLabels == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property uomLabels is not valid. Set uomLabelsValid = true");
				return m_UomLabels;  
			}
			set 
			{ 
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Collapse(value); 
				m_IsValidUomLabels = true;
				m_UomLabels = value;
			}
		}
		/// <summary>
		/// 	Indicates if uomLabels contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for uomLabels is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value ("").</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get uomLabels
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidUomLabels
		{
			get
			{
				return m_IsValidUomLabels;
			}
			set 
			{ 
				if (value != m_IsValidUomLabels)
				{
					UomLabels = "";
					m_IsValidUomLabels = value;
				}
			}
		}
		protected Boolean m_IsValidUomLabels;
		protected String m_UomLabels;
		#endregion

		#region Attribute - count
		/// <summary>
		///		Represents an optional Attribute in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Attribute in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoPrimitive("count", "", "IsValidCount", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_integer, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, null, "", -1, -1, "", "", "", "", -1)]
		public LiquidTechnologies.Runtime.Net45.BigInteger Count
		{
			get 
			{ 
				if (m_IsValidCount == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property count is not valid. Set countValid = true");
				return m_Count;  
			}
			set 
			{ 
				m_IsValidCount = true;
				m_Count = value;
			}
		}
		/// <summary>
		/// 	Indicates if count contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for count is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value (0).</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get count
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidCount
		{
			get
			{
				return m_IsValidCount;
			}
			set 
			{ 
				if (value != m_IsValidCount)
				{
					Count = 0;
					m_IsValidCount = value;
				}
			}
		}
		protected Boolean m_IsValidCount;
		protected LiquidTechnologies.Runtime.Net45.BigInteger m_Count;
		#endregion

		#region Attribute - PrimitiveValue

		/// <summary>
		/// 	The InnerText for this element
		/// </summary>
		/// <remarks>
		/// 	This class represents the element PosList, this
		/// 	element is open, and as such we can place data into it.
		/// 	<BR>ie &lt;PosList&gt;Some Data&lt;/PosList&gt;</BR>
		/// </remarks>
		public Double PrimitiveValue
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
		protected Double _primitiveValue;
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


