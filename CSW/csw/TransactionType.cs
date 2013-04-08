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
	/// 	This class represents the ComplexType TransactionType
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Sequence,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element,
													"TransactionType", "http://www.opengis.net/cat/csw/2.0.2", false, true,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class TransactionType : CSW.XmlCommonBase
					, csw.IRequestBaseType
	{
		#region Constructors
		/// <summary>
		///		Constructor for TransactionType
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public TransactionType()
		{
			_elementName = "TransactionType";
			Init();
		}
		public TransactionType(String elementName)
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
			m_VerboseResponse = LiquidTechnologies.Runtime.Net45.Conversions.booleanFromString("false", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse);
			m_IsValidVerboseResponse = true;
			m_RequestId = "";
			m_IsValidRequestId = false;
			m_TransactionType_Type_ChoiceCol = new CSW.XmlObjectCollection<csw.TransactionType_Type_Choice>("TransactionType_Type_Choice", "", 1, -1, true);



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
			csw.TransactionType newObject = new csw.TransactionType(_elementName);
			newObject.m_Service = m_Service;
			newObject.m_Version = m_Version;
			newObject.m_VerboseResponse = m_VerboseResponse;
			newObject.m_IsValidVerboseResponse = m_IsValidVerboseResponse;
			newObject.m_RequestId = m_RequestId;
			newObject.m_IsValidRequestId = m_IsValidRequestId;
			foreach (csw.TransactionType_Type_Choice o in m_TransactionType_Type_ChoiceCol)
				newObject.m_TransactionType_Type_ChoiceCol.Add((csw.TransactionType_Type_Choice)o.Clone());


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

		#region Attribute - verboseResponse
		/// <summary>
		///		Represents an optional Attribute in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Attribute in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoPrimitive("verboseResponse", "", "IsValidVerboseResponse", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_boolean, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "false", "", -1, -1, "", "", "", "", -1)]
		public Boolean VerboseResponse
		{
			get 
			{ 
				if (m_IsValidVerboseResponse == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property verboseResponse is not valid. Set verboseResponseValid = true");
				return m_VerboseResponse;  
			}
			set 
			{ 
				m_IsValidVerboseResponse = true;
				m_VerboseResponse = value;
			}
		}
		/// <summary>
		/// 	Indicates if verboseResponse contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for verboseResponse is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value (LiquidTechnologies.Runtime.Net45.Conversions.booleanFromString("false", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)).</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get verboseResponse
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidVerboseResponse
		{
			get
			{
				return m_IsValidVerboseResponse;
			}
			set 
			{ 
				// Attributes with Default can not be removed.
				if (!value)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property verboseResponse has a a default value, and is an attribute, because of this it can not be removed from the schema");
			}
		}
		protected Boolean m_IsValidVerboseResponse;
		protected Boolean m_VerboseResponse;
		#endregion

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

		#region Attribute - TransactionType_Type_Choice
		/// <summary>
		/// 	A collection of TransactionType_Type_ChoiceCols
		///		
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>This collection may contain 1 to Many objects.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsCol("TransactionType_Type_Choice", "", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement)]
		public CSW.XmlObjectCollection<csw.TransactionType_Type_Choice> TransactionType_Type_ChoiceCol
		{
			get { return m_TransactionType_Type_ChoiceCol; }
		}
		protected CSW.XmlObjectCollection<csw.TransactionType_Type_Choice> m_TransactionType_Type_ChoiceCol;
		
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


