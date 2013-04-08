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
	/// 	This class represents the ComplexType TimePositionType
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Sequence,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element,
													"TimePositionType", "http://www.opengis.net/gml", true, false,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_date, null, false)]
	public partial class TimePositionType : CSW.XmlCommonBase
	{
		#region Constructors
		/// <summary>
		///		Constructor for TimePositionType
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public TimePositionType()
		{
			_elementName = "TimePositionType";
			Init();
		}
		public TimePositionType(String elementName)
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
			m_Frame = LiquidTechnologies.Runtime.Net45.Conversions.stringFromString("#ISO-8601", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse);
			m_IsValidFrame = true;
			m_CalendarEraName = "";
			m_IsValidCalendarEraName = false;
			m_IndeterminatePosition = AE.Enumerations.TimeIndeterminateValueType.After;
			m_IsValidIndeterminatePosition = false;


			_primitiveValue = new LiquidTechnologies.Runtime.Net45.XmlDateTime(LiquidTechnologies.Runtime.Net45.XmlDateTime.DateType.date);

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
			AE.TimePositionType newObject = new AE.TimePositionType(_elementName);
			newObject.m_Frame = m_Frame;
			newObject.m_IsValidFrame = m_IsValidFrame;
			newObject.m_CalendarEraName = m_CalendarEraName;
			newObject.m_IsValidCalendarEraName = m_IsValidCalendarEraName;
			newObject.m_IndeterminatePosition = m_IndeterminatePosition;
			newObject.m_IsValidIndeterminatePosition = m_IsValidIndeterminatePosition;


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

		#region Attribute - frame
		/// <summary>
		///		Represents an optional Attribute in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Attribute in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoPrimitive("frame", "", "IsValidFrame", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "#ISO-8601", "", -1, -1, "", "", "", "", -1)]
		public String Frame
		{
			get 
			{ 
				if (m_IsValidFrame == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property frame is not valid. Set frameValid = true");
				return m_Frame;  
			}
			set 
			{ 
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Collapse(value); 
				m_IsValidFrame = true;
				m_Frame = value;
			}
		}
		/// <summary>
		/// 	Indicates if frame contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for frame is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value (LiquidTechnologies.Runtime.Net45.Conversions.stringFromString("#ISO-8601", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)).</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get frame
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidFrame
		{
			get
			{
				return m_IsValidFrame;
			}
			set 
			{ 
				// Attributes with Default can not be removed.
				if (!value)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property frame has a a default value, and is an attribute, because of this it can not be removed from the schema");
			}
		}
		protected Boolean m_IsValidFrame;
		protected String m_Frame;
		#endregion

		#region Attribute - calendarEraName
		/// <summary>
		///		Represents an optional Attribute in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Attribute in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoPrimitive("calendarEraName", "", "IsValidCalendarEraName", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, null, "", -1, -1, "", "", "", "", -1)]
		public String CalendarEraName
		{
			get 
			{ 
				if (m_IsValidCalendarEraName == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property calendarEraName is not valid. Set calendarEraNameValid = true");
				return m_CalendarEraName;  
			}
			set 
			{ 
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				m_IsValidCalendarEraName = true;
				m_CalendarEraName = value;
			}
		}
		/// <summary>
		/// 	Indicates if calendarEraName contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for calendarEraName is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value ("").</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get calendarEraName
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidCalendarEraName
		{
			get
			{
				return m_IsValidCalendarEraName;
			}
			set 
			{ 
				if (value != m_IsValidCalendarEraName)
				{
					CalendarEraName = "";
					m_IsValidCalendarEraName = value;
				}
			}
		}
		protected Boolean m_IsValidCalendarEraName;
		protected String m_CalendarEraName;
		#endregion

		#region Attribute - indeterminatePosition
		/// <summary>
		///		Represents an optional Attribute in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Attribute in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoEnum("indeterminatePosition", "", "IsValidIndeterminatePosition", typeof(AE.Enumerations), "TimeIndeterminateValueTypeFromString", "TimeIndeterminateValueTypeToString", null)]
		public AE.Enumerations.TimeIndeterminateValueType IndeterminatePosition
		{
			get 
			{ 
				if (m_IsValidIndeterminatePosition == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property indeterminatePosition is not valid. Set indeterminatePositionValid = true");
				return m_IndeterminatePosition;  
			}
			set 
			{ 
				m_IndeterminatePosition = value;
				m_IsValidIndeterminatePosition = true;
			}
		}
		/// <summary>
		/// 	Indicates if indeterminatePosition contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for indeterminatePosition is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value (AE.Enumerations.TimeIndeterminateValueType.After).</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get indeterminatePosition
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidIndeterminatePosition
		{
			get { return m_IsValidIndeterminatePosition;  }
			set 
			{ 
				if (value != m_IsValidIndeterminatePosition)
				{
					IndeterminatePosition = AE.Enumerations.TimeIndeterminateValueType.After;
					m_IsValidIndeterminatePosition = value;
				}
			}
		}
		protected AE.Enumerations.TimeIndeterminateValueType m_IndeterminatePosition;
		protected Boolean m_IsValidIndeterminatePosition;

		#endregion

		#region Attribute - PrimitiveValue

		/// <summary>
		/// 	The InnerText for this element
		/// </summary>
		/// <remarks>
		/// 	This class represents the element TimePositionType, this
		/// 	element is open, and as such we can place data into it.
		/// 	<BR>ie &lt;TimePositionType&gt;Some Data&lt;/TimePositionType&gt;</BR>
		/// </remarks>
		public LiquidTechnologies.Runtime.Net45.XmlDateTime PrimitiveValue
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
		protected LiquidTechnologies.Runtime.Net45.XmlDateTime _primitiveValue;
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


