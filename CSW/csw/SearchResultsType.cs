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
	/// 	This class represents the ComplexType SearchResultsType
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Sequence,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element,
													"SearchResultsType", "http://www.opengis.net/cat/csw/2.0.2", false, false,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class SearchResultsType : CSW.XmlCommonBase
	{
		#region Constructors
		/// <summary>
		///		Constructor for SearchResultsType
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public SearchResultsType()
		{
			_elementName = "SearchResultsType";
			Init();
		}
		public SearchResultsType(String elementName)
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
			m_ResultSetId = "";
			m_IsValidResultSetId = false;
			m_ElementSet = csw.Enumerations.ElementSetType.Brief;
			m_IsValidElementSet = false;
			m_RecordSchema = "";
			m_IsValidRecordSchema = false;
			m_NumberOfRecordsMatched = 0;
			m_NumberOfRecordsReturned = 0;
			m_NextRecord = 0;
			m_IsValidNextRecord = false;
			m_Expires = new LiquidTechnologies.Runtime.Net45.XmlDateTime(LiquidTechnologies.Runtime.Net45.XmlDateTime.DateType.dateTime);
			m_IsValidExpires = false;
			m_SearchResultsType_Choice = null;



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
			csw.SearchResultsType newObject = new csw.SearchResultsType(_elementName);
			newObject.m_ResultSetId = m_ResultSetId;
			newObject.m_IsValidResultSetId = m_IsValidResultSetId;
			newObject.m_ElementSet = m_ElementSet;
			newObject.m_IsValidElementSet = m_IsValidElementSet;
			newObject.m_RecordSchema = m_RecordSchema;
			newObject.m_IsValidRecordSchema = m_IsValidRecordSchema;
			newObject.m_NumberOfRecordsMatched = m_NumberOfRecordsMatched;
			newObject.m_NumberOfRecordsReturned = m_NumberOfRecordsReturned;
			newObject.m_NextRecord = m_NextRecord;
			newObject.m_IsValidNextRecord = m_IsValidNextRecord;
			newObject.m_Expires = (LiquidTechnologies.Runtime.Net45.XmlDateTime)m_Expires.Clone();
			newObject.m_IsValidExpires = m_IsValidExpires;
			newObject.m_SearchResultsType_Choice = null;
			if (m_SearchResultsType_Choice != null)
				newObject.m_SearchResultsType_Choice = (csw.SearchResultsType_Choice)m_SearchResultsType_Choice.Clone();


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

		#region Attribute - resultSetId
		/// <summary>
		///		Represents an optional Attribute in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Attribute in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoPrimitive("resultSetId", "", "IsValidResultSetId", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, null, "", -1, -1, "", "", "", "", -1)]
		public String ResultSetId
		{
			get 
			{ 
				if (m_IsValidResultSetId == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property resultSetId is not valid. Set resultSetIdValid = true");
				return m_ResultSetId;  
			}
			set 
			{ 
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Collapse(value); 
				m_IsValidResultSetId = true;
				m_ResultSetId = value;
			}
		}
		/// <summary>
		/// 	Indicates if resultSetId contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for resultSetId is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value ("").</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get resultSetId
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidResultSetId
		{
			get
			{
				return m_IsValidResultSetId;
			}
			set 
			{ 
				if (value != m_IsValidResultSetId)
				{
					ResultSetId = "";
					m_IsValidResultSetId = value;
				}
			}
		}
		protected Boolean m_IsValidResultSetId;
		protected String m_ResultSetId;
		#endregion

		#region Attribute - elementSet
		/// <summary>
		///		Represents an optional Attribute in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Attribute in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoEnum("elementSet", "", "IsValidElementSet", typeof(csw.Enumerations), "ElementSetTypeFromString", "ElementSetTypeToString", null)]
		public csw.Enumerations.ElementSetType ElementSet
		{
			get 
			{ 
				if (m_IsValidElementSet == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property elementSet is not valid. Set elementSetValid = true");
				return m_ElementSet;  
			}
			set 
			{ 
				m_ElementSet = value;
				m_IsValidElementSet = true;
			}
		}
		/// <summary>
		/// 	Indicates if elementSet contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for elementSet is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value (csw.Enumerations.ElementSetType.Brief).</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get elementSet
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidElementSet
		{
			get { return m_IsValidElementSet;  }
			set 
			{ 
				if (value != m_IsValidElementSet)
				{
					ElementSet = csw.Enumerations.ElementSetType.Brief;
					m_IsValidElementSet = value;
				}
			}
		}
		protected csw.Enumerations.ElementSetType m_ElementSet;
		protected Boolean m_IsValidElementSet;

		#endregion

		#region Attribute - recordSchema
		/// <summary>
		///		Represents an optional Attribute in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Attribute in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoPrimitive("recordSchema", "", "IsValidRecordSchema", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, null, "", -1, -1, "", "", "", "", -1)]
		public String RecordSchema
		{
			get 
			{ 
				if (m_IsValidRecordSchema == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property recordSchema is not valid. Set recordSchemaValid = true");
				return m_RecordSchema;  
			}
			set 
			{ 
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Collapse(value); 
				m_IsValidRecordSchema = true;
				m_RecordSchema = value;
			}
		}
		/// <summary>
		/// 	Indicates if recordSchema contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for recordSchema is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value ("").</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get recordSchema
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidRecordSchema
		{
			get
			{
				return m_IsValidRecordSchema;
			}
			set 
			{ 
				if (value != m_IsValidRecordSchema)
				{
					RecordSchema = "";
					m_IsValidRecordSchema = value;
				}
			}
		}
		protected Boolean m_IsValidRecordSchema;
		protected String m_RecordSchema;
		#endregion

		#region Attribute - numberOfRecordsMatched
		/// <summary>
		///		Represents a mandatory Attribute in the XML document
		///		
		/// </summary>
		/// <remarks>
		///		<BR></BR>
		///		<BR>This property is represented as an Attribute in the XML.</BR>
		///		<BR>It is mandatory and therefore must be populated within the XML.</BR>
		///		<BR>It is defaulted to 0.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoPrimitive("numberOfRecordsMatched", "", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_integer, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, null, "", -1, -1, "", "", "", "", -1)]
		public LiquidTechnologies.Runtime.Net45.BigInteger NumberOfRecordsMatched
		{
			get 
			{ 
				return m_NumberOfRecordsMatched;  
			}
			set 
			{ 
				m_NumberOfRecordsMatched = value;
			}
		}
		protected LiquidTechnologies.Runtime.Net45.BigInteger m_NumberOfRecordsMatched;

		#endregion

		#region Attribute - numberOfRecordsReturned
		/// <summary>
		///		Represents a mandatory Attribute in the XML document
		///		
		/// </summary>
		/// <remarks>
		///		<BR></BR>
		///		<BR>This property is represented as an Attribute in the XML.</BR>
		///		<BR>It is mandatory and therefore must be populated within the XML.</BR>
		///		<BR>It is defaulted to 0.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoPrimitive("numberOfRecordsReturned", "", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_integer, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, null, "", -1, -1, "", "", "", "", -1)]
		public LiquidTechnologies.Runtime.Net45.BigInteger NumberOfRecordsReturned
		{
			get 
			{ 
				return m_NumberOfRecordsReturned;  
			}
			set 
			{ 
				m_NumberOfRecordsReturned = value;
			}
		}
		protected LiquidTechnologies.Runtime.Net45.BigInteger m_NumberOfRecordsReturned;

		#endregion

		#region Attribute - nextRecord
		/// <summary>
		///		Represents an optional Attribute in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Attribute in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoPrimitive("nextRecord", "", "IsValidNextRecord", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_integer, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, null, "", -1, -1, "", "", "", "", -1)]
		public LiquidTechnologies.Runtime.Net45.BigInteger NextRecord
		{
			get 
			{ 
				if (m_IsValidNextRecord == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property nextRecord is not valid. Set nextRecordValid = true");
				return m_NextRecord;  
			}
			set 
			{ 
				m_IsValidNextRecord = true;
				m_NextRecord = value;
			}
		}
		/// <summary>
		/// 	Indicates if nextRecord contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for nextRecord is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value (0).</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get nextRecord
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidNextRecord
		{
			get
			{
				return m_IsValidNextRecord;
			}
			set 
			{ 
				if (value != m_IsValidNextRecord)
				{
					NextRecord = 0;
					m_IsValidNextRecord = value;
				}
			}
		}
		protected Boolean m_IsValidNextRecord;
		protected LiquidTechnologies.Runtime.Net45.BigInteger m_NextRecord;
		#endregion

		#region Attribute - expires
		/// <summary>
		///		Represents an optional Attribute in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Attribute in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoPrimitive("expires", "", "IsValidExpires", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_datetime, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, null, "", -1, -1, "", "", "", "", -1)]
		public LiquidTechnologies.Runtime.Net45.XmlDateTime Expires
		{
			get 
			{ 
				if (m_IsValidExpires == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property expires is not valid. Set expiresValid = true");
				return m_Expires;  
			}
			set 
			{ 
				m_IsValidExpires = true;
				m_Expires.SetDateTime(value, m_Expires.Type); 
			}
		}
		/// <summary>
		/// 	Indicates if expires contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for expires is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value (new LiquidTechnologies.Runtime.Net45.XmlDateTime(LiquidTechnologies.Runtime.Net45.XmlDateTime.DateType.dateTime)).</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get expires
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidExpires
		{
			get
			{
				return m_IsValidExpires;
			}
			set 
			{ 
				if (value != m_IsValidExpires)
				{
					Expires = new LiquidTechnologies.Runtime.Net45.XmlDateTime(LiquidTechnologies.Runtime.Net45.XmlDateTime.DateType.dateTime);
					m_IsValidExpires = value;
				}
			}
		}
		protected Boolean m_IsValidExpires;
		protected LiquidTechnologies.Runtime.Net45.XmlDateTime m_Expires;
		#endregion

		#region Attribute - SearchResultsType_Choice
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsOpt("SearchResultsType_Choice", "", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement, typeof(csw.SearchResultsType_Choice))]
		public csw.SearchResultsType_Choice SearchResultsType_Choice
		{
			get 
			{ 
				return m_SearchResultsType_Choice;  
			}
			set 
			{ 
				if (value == null)
					m_SearchResultsType_Choice = null;
				else
				{
					m_SearchResultsType_Choice = value; 
				}
			}
		}
		protected csw.SearchResultsType_Choice m_SearchResultsType_Choice;
		
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


