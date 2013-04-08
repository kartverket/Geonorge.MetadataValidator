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

namespace AF
{
	/// <summary>
	/// 	This class represents the ComplexType setPrototype
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Sequence,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element,
													"setPrototype", "http://www.w3.org/2001/SMIL20/", true, true,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class SetPrototype : CSW.XmlCommonBase
					, AF.IsetPrototype
	{
		#region Constructors
		/// <summary>
		///		Constructor for SetPrototype
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public SetPrototype()
		{
			_elementName = "setPrototype";
			Init();
		}
		public SetPrototype(String elementName)
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
			m_AttributeName = "";
			m_AttributeType = CSW.Enumerations.IsetPrototype_AttributeType.Auto;
			m_IsValidAttributeType = true;
			m_To = "";
			m_IsValidTo = false;



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
			AF.SetPrototype newObject = new AF.SetPrototype(_elementName);
			newObject.m_AttributeName = m_AttributeName;
			newObject.m_AttributeType = m_AttributeType;
			newObject.m_IsValidAttributeType = m_IsValidAttributeType;
			newObject.m_To = m_To;
			newObject.m_IsValidTo = m_IsValidTo;


// ##HAND_CODED_BLOCK_START ID="Additional clone"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional clone code here...

// ##HAND_CODED_BLOCK_END ID="Additional clone"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

			return newObject;
		}
		#endregion

		#region Member variables

		protected override String TargetNamespace
		{
			get { return "http://www.w3.org/2001/SMIL20/"; }
		}

		#region Attribute - attributeName
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
        [LiquidTechnologies.Runtime.Net45.AttributeInfoPrimitive("attributeName", "", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, null, "", -1, -1, "", "", "", "", -1)]
		public String AttributeName
		{
			get 
			{ 
				return m_AttributeName;  
			}
			set 
			{ 
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				m_AttributeName = value;
			}
		}
		protected String m_AttributeName;

		#endregion

		#region Attribute - attributeType
		/// <summary>
		///		Represents an optional Attribute in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Attribute in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoEnum("attributeType", "", "IsValidAttributeType", typeof(CSW.Enumerations), "IsetPrototype_AttributeTypeFromString", "IsetPrototype_AttributeTypeToString", "auto")]
		public CSW.Enumerations.IsetPrototype_AttributeType AttributeType
		{
			get 
			{ 
				if (m_IsValidAttributeType == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property attributeType is not valid. Set attributeTypeValid = true");
				return m_AttributeType;  
			}
			set 
			{ 
				m_AttributeType = value;
				m_IsValidAttributeType = true;
			}
		}
		/// <summary>
		/// 	Indicates if attributeType contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for attributeType is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value (CSW.Enumerations.IsetPrototype_AttributeType.Auto).</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get attributeType
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidAttributeType
		{
			get { return m_IsValidAttributeType;  }
			set 
			{ 
				if (value != m_IsValidAttributeType)
				{
					AttributeType = CSW.Enumerations.IsetPrototype_AttributeType.Auto;
					m_IsValidAttributeType = value;
				}
			}
		}
		protected CSW.Enumerations.IsetPrototype_AttributeType m_AttributeType;
		protected Boolean m_IsValidAttributeType;

		#endregion

		#region Attribute - to
		/// <summary>
		///		Represents an optional Attribute in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Attribute in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoPrimitive("to", "", "IsValidTo", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, null, "", -1, -1, "", "", "", "", -1)]
		public String to_
		{
			get 
			{ 
				if (m_IsValidTo == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property to_ is not valid. Set to_Valid = true");
				return m_To;  
			}
			set 
			{ 
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				m_IsValidTo = true;
				m_To = value;
			}
		}
		/// <summary>
		/// 	Indicates if to_ contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for to_ is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value ("").</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get to_
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidTo
		{
			get
			{
				return m_IsValidTo;
			}
			set 
			{ 
				if (value != m_IsValidTo)
				{
					to_ = "";
					m_IsValidTo = value;
				}
			}
		}
		protected Boolean m_IsValidTo;
		protected String m_To;
		#endregion

		#region Attribute - Namespace
		public override String Namespace
		{
			get { return "http://www.w3.org/2001/SMIL20/"; }
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


