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
	/// 	This class represents the ComplexType GetRecordByIdType
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Sequence,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element,
													"GetRecordByIdType", "http://www.opengis.net/cat/csw/2.0.2", true, true,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class GetRecordByIdType : CSW.XmlCommonBase
					, csw.IRequestBaseType
	{
		#region Constructors
		/// <summary>
		///		Constructor for GetRecordByIdType
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public GetRecordByIdType()
		{
			_elementName = "GetRecordByIdType";
			Init();
		}
		public GetRecordByIdType(String elementName)
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
			m_OutputFormat = LiquidTechnologies.Runtime.Net45.Conversions.stringFromString("application/xml", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse);
			m_IsValidOutputFormat = true;
			m_OutputSchema = "";
			m_IsValidOutputSchema = false;
			m_IdCol = new CSW.XmlSimpleTypeCollection<String>("Id", "http://www.opengis.net/cat/csw/2.0.2", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, 1, -1, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, new LiquidTechnologies.Runtime.Net45.PrimitiveRestrictions("", -1, -1, "", "", "", "", -1));
			m_ElementSetName = null;



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
			csw.GetRecordByIdType newObject = new csw.GetRecordByIdType(_elementName);
			newObject.m_Service = m_Service;
			newObject.m_Version = m_Version;
			newObject.m_OutputFormat = m_OutputFormat;
			newObject.m_IsValidOutputFormat = m_IsValidOutputFormat;
			newObject.m_OutputSchema = m_OutputSchema;
			newObject.m_IsValidOutputSchema = m_IsValidOutputSchema;
			foreach (String o in m_IdCol)
				newObject.m_IdCol.Add(o);
			newObject.m_ElementSetName = null;
			if (m_ElementSetName != null)
				newObject.m_ElementSetName = (csw.ElementSetName)m_ElementSetName.Clone();


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

		#region Attribute - outputFormat
		/// <summary>
		///		Represents an optional Attribute in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Attribute in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoPrimitive("outputFormat", "", "IsValidOutputFormat", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "application/xml", "", -1, -1, "", "", "", "", -1)]
		public String OutputFormat
		{
			get 
			{ 
				if (m_IsValidOutputFormat == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property outputFormat is not valid. Set outputFormatValid = true");
				return m_OutputFormat;  
			}
			set 
			{ 
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				m_IsValidOutputFormat = true;
				m_OutputFormat = value;
			}
		}
		/// <summary>
		/// 	Indicates if outputFormat contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for outputFormat is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value (LiquidTechnologies.Runtime.Net45.Conversions.stringFromString("application/xml", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)).</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get outputFormat
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidOutputFormat
		{
			get
			{
				return m_IsValidOutputFormat;
			}
			set 
			{ 
				// Attributes with Default can not be removed.
				if (!value)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property outputFormat has a a default value, and is an attribute, because of this it can not be removed from the schema");
			}
		}
		protected Boolean m_IsValidOutputFormat;
		protected String m_OutputFormat;
		#endregion

		#region Attribute - outputSchema
		/// <summary>
		///		Represents an optional Attribute in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Attribute in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoPrimitive("outputSchema", "", "IsValidOutputSchema", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, null, "", -1, -1, "", "", "", "", -1)]
		public String OutputSchema
		{
			get 
			{ 
				if (m_IsValidOutputSchema == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property outputSchema is not valid. Set outputSchemaValid = true");
				return m_OutputSchema;  
			}
			set 
			{ 
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Collapse(value); 
				m_IsValidOutputSchema = true;
				m_OutputSchema = value;
			}
		}
		/// <summary>
		/// 	Indicates if outputSchema contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for outputSchema is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value ("").</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get outputSchema
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidOutputSchema
		{
			get
			{
				return m_IsValidOutputSchema;
			}
			set 
			{ 
				if (value != m_IsValidOutputSchema)
				{
					OutputSchema = "";
					m_IsValidOutputSchema = value;
				}
			}
		}
		protected Boolean m_IsValidOutputSchema;
		protected String m_OutputSchema;
		#endregion

		#region Attribute - Id
		/// <summary>
		///		A collection of Strings
		///		
		/// </summary>
		/// <remarks>
		///		<BR></BR>
		///		<BR>This property is represented as an Element in the XML.</BR>
		///		<BR>This collection may contain 1 to Many Strings.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimCol("Id", "http://www.opengis.net/cat/csw/2.0.2")]
		public CSW.XmlSimpleTypeCollection<String> IdCol
		{
			get { return m_IdCol; }
		}
		protected CSW.XmlSimpleTypeCollection<String> m_IdCol;

		#endregion

		#region Attribute - ElementSetName
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsOpt("ElementSetName", "http://www.opengis.net/cat/csw/2.0.2", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(csw.ElementSetName))]
		public csw.ElementSetName ElementSetName
		{
			get 
			{ 
				return m_ElementSetName;  
			}
			set 
			{ 
				if (value == null)
					m_ElementSetName = null;
				else
				{
					m_ElementSetName = value; 
				}
			}
		}
		protected csw.ElementSetName m_ElementSetName;
		
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


