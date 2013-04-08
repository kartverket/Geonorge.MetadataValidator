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
	/// 	This class represents the ComplexType TransactionSummaryType
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Sequence,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element,
													"TransactionSummaryType", "http://www.opengis.net/cat/csw/2.0.2", true, false,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class TransactionSummaryType : CSW.XmlCommonBase
	{
		#region Constructors
		/// <summary>
		///		Constructor for TransactionSummaryType
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public TransactionSummaryType()
		{
			_elementName = "TransactionSummaryType";
			Init();
		}
		public TransactionSummaryType(String elementName)
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
			m_RequestId = "";
			m_IsValidRequestId = false;
			m_TotalInserted = 0;
			m_IsValidTotalInserted = false; 
			m_TotalUpdated = 0;
			m_IsValidTotalUpdated = false; 
			m_TotalDeleted = 0;
			m_IsValidTotalDeleted = false; 



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
			csw.TransactionSummaryType newObject = new csw.TransactionSummaryType(_elementName);
			newObject.m_RequestId = m_RequestId;
			newObject.m_IsValidRequestId = m_IsValidRequestId;
			newObject.m_TotalInserted = m_TotalInserted;
			newObject.m_IsValidTotalInserted = m_IsValidTotalInserted;
			newObject.m_TotalUpdated = m_TotalUpdated;
			newObject.m_IsValidTotalUpdated = m_IsValidTotalUpdated;
			newObject.m_TotalDeleted = m_TotalDeleted;
			newObject.m_IsValidTotalDeleted = m_IsValidTotalDeleted;


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

		#region Attribute - requestId
		/// <summary>
		///		Represents an optional Attribute in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Attribute in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoPrimitive("requestId", "", "IsValidRequestId", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, null, "", -1, -1, "", "", "", "", -1)]
		public String RequestId
		{
			get 
			{ 
				if (m_IsValidRequestId == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property requestId is not valid. Set requestIdValid = true");
				return m_RequestId;  
			}
			set 
			{ 
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Collapse(value); 
				m_IsValidRequestId = true;
				m_RequestId = value;
			}
		}
		/// <summary>
		/// 	Indicates if requestId contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for requestId is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value ("").</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get requestId
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidRequestId
		{
			get
			{
				return m_IsValidRequestId;
			}
			set 
			{ 
				if (value != m_IsValidRequestId)
				{
					RequestId = "";
					m_IsValidRequestId = value;
				}
			}
		}
		protected Boolean m_IsValidRequestId;
		protected String m_RequestId;
		#endregion

		#region Attribute - totalInserted
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimOpt("totalInserted", "http://www.opengis.net/cat/csw/2.0.2", "IsValidTotalInserted", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_integer, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", -1, -1, "0", "", "", "", -1)]
		public LiquidTechnologies.Runtime.Net45.BigInteger TotalInserted
		{
			get 
			{ 
				if (m_IsValidTotalInserted == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property totalInserted is not valid. Set totalInsertedValid = true");
				return m_TotalInserted;  
			}
			set 
			{ 
				CheckElementRestriction(0, value);
				m_IsValidTotalInserted = true;
				m_TotalInserted = value;
			}
		}
		/// <summary>
		/// 	Indicates if totalInserted contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for totalInserted is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value (0).</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get totalInserted
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidTotalInserted
		{
			get
			{
				return m_IsValidTotalInserted;
			}
			set 
			{ 
				if (value != m_IsValidTotalInserted)
				{
					TotalInserted = 0;
					m_IsValidTotalInserted = value;
				}
			}
		}
		protected Boolean m_IsValidTotalInserted;
		protected LiquidTechnologies.Runtime.Net45.BigInteger m_TotalInserted;
		#endregion

		#region Attribute - totalUpdated
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimOpt("totalUpdated", "http://www.opengis.net/cat/csw/2.0.2", "IsValidTotalUpdated", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_integer, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", -1, -1, "0", "", "", "", -1)]
		public LiquidTechnologies.Runtime.Net45.BigInteger TotalUpdated
		{
			get 
			{ 
				if (m_IsValidTotalUpdated == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property totalUpdated is not valid. Set totalUpdatedValid = true");
				return m_TotalUpdated;  
			}
			set 
			{ 
				CheckElementRestriction(1, value);
				m_IsValidTotalUpdated = true;
				m_TotalUpdated = value;
			}
		}
		/// <summary>
		/// 	Indicates if totalUpdated contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for totalUpdated is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value (0).</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get totalUpdated
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidTotalUpdated
		{
			get
			{
				return m_IsValidTotalUpdated;
			}
			set 
			{ 
				if (value != m_IsValidTotalUpdated)
				{
					TotalUpdated = 0;
					m_IsValidTotalUpdated = value;
				}
			}
		}
		protected Boolean m_IsValidTotalUpdated;
		protected LiquidTechnologies.Runtime.Net45.BigInteger m_TotalUpdated;
		#endregion

		#region Attribute - totalDeleted
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimOpt("totalDeleted", "http://www.opengis.net/cat/csw/2.0.2", "IsValidTotalDeleted", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_integer, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", -1, -1, "0", "", "", "", -1)]
		public LiquidTechnologies.Runtime.Net45.BigInteger TotalDeleted
		{
			get 
			{ 
				if (m_IsValidTotalDeleted == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property totalDeleted is not valid. Set totalDeletedValid = true");
				return m_TotalDeleted;  
			}
			set 
			{ 
				CheckElementRestriction(2, value);
				m_IsValidTotalDeleted = true;
				m_TotalDeleted = value;
			}
		}
		/// <summary>
		/// 	Indicates if totalDeleted contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for totalDeleted is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value (0).</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get totalDeleted
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidTotalDeleted
		{
			get
			{
				return m_IsValidTotalDeleted;
			}
			set 
			{ 
				if (value != m_IsValidTotalDeleted)
				{
					TotalDeleted = 0;
					m_IsValidTotalDeleted = value;
				}
			}
		}
		protected Boolean m_IsValidTotalDeleted;
		protected LiquidTechnologies.Runtime.Net45.BigInteger m_TotalDeleted;
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


