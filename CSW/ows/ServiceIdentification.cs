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
	/// 	This class represents the Element ServiceIdentification
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Sequence,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element,
													"ServiceIdentification", "http://www.opengis.net/ows", true, true,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class ServiceIdentification : CSW.XmlCommonBase
					, ows.IDescriptionType
	{
		#region Constructors
		/// <summary>
		///		Constructor for ServiceIdentification
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public ServiceIdentification()
		{
			_elementName = "ServiceIdentification";
			Init();
		}
		public ServiceIdentification(String elementName)
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
			m_Title = "";
			m_IsValidTitle = false; 
			m_Abstract = "";
			m_IsValidAbstract = false; 
			m_KeywordsCol = new CSW.XmlObjectCollection<ows.Keywords>("Keywords", "http://www.opengis.net/ows", 0, -1, false);
			m_ServiceType = new ows.CodeType("ServiceType");
			m_ServiceTypeVersionCol = new CSW.XmlSimpleTypeCollection<String>("ServiceTypeVersion", "http://www.opengis.net/ows", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, 1, -1, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, new LiquidTechnologies.Runtime.Net45.PrimitiveRestrictions("", -1, -1, "", "", "", "", -1));
			m_Fees = "";
			m_IsValidFees = false; 
			m_AccessConstraintsCol = new CSW.XmlSimpleTypeCollection<String>("AccessConstraints", "http://www.opengis.net/ows", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, 0, -1, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, new LiquidTechnologies.Runtime.Net45.PrimitiveRestrictions("", -1, -1, "", "", "", "", -1));



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
			ows.ServiceIdentification newObject = new ows.ServiceIdentification(_elementName);
			newObject.m_Title = m_Title;
			newObject.m_IsValidTitle = m_IsValidTitle;
			newObject.m_Abstract = m_Abstract;
			newObject.m_IsValidAbstract = m_IsValidAbstract;
			foreach (ows.Keywords o in m_KeywordsCol)
				newObject.m_KeywordsCol.Add((ows.Keywords)o.Clone());
			newObject.m_ServiceType = null;
			if (m_ServiceType != null)
				newObject.m_ServiceType = (ows.CodeType)m_ServiceType.Clone();
			foreach (String o in m_ServiceTypeVersionCol)
				newObject.m_ServiceTypeVersionCol.Add(o);
			newObject.m_Fees = m_Fees;
			newObject.m_IsValidFees = m_IsValidFees;
			foreach (String o in m_AccessConstraintsCol)
				newObject.m_AccessConstraintsCol.Add(o);


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

		#region Attribute - Title
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimOpt("Title", "http://www.opengis.net/ows", "IsValidTitle", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", -1, -1, "", "", "", "", -1)]
		public String Title
		{
			get 
			{ 
				if (m_IsValidTitle == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property Title is not valid. Set TitleValid = true");
				return m_Title;  
			}
			set 
			{ 
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				m_IsValidTitle = true;
				m_Title = value;
			}
		}
		/// <summary>
		/// 	Indicates if Title contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for Title is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value ("").</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get Title
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidTitle
		{
			get
			{
				return m_IsValidTitle;
			}
			set 
			{ 
				if (value != m_IsValidTitle)
				{
					Title = "";
					m_IsValidTitle = value;
				}
			}
		}
		protected Boolean m_IsValidTitle;
		protected String m_Title;
		#endregion

		#region Attribute - Abstract
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimOpt("Abstract", "http://www.opengis.net/ows", "IsValidAbstract", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", -1, -1, "", "", "", "", -1)]
		public String abstract_
		{
			get 
			{ 
				if (m_IsValidAbstract == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property abstract_ is not valid. Set abstract_Valid = true");
				return m_Abstract;  
			}
			set 
			{ 
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				m_IsValidAbstract = true;
				m_Abstract = value;
			}
		}
		/// <summary>
		/// 	Indicates if abstract_ contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for abstract_ is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value ("").</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get abstract_
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidAbstract
		{
			get
			{
				return m_IsValidAbstract;
			}
			set 
			{ 
				if (value != m_IsValidAbstract)
				{
					abstract_ = "";
					m_IsValidAbstract = value;
				}
			}
		}
		protected Boolean m_IsValidAbstract;
		protected String m_Abstract;
		#endregion

		#region Attribute - Keywords
		/// <summary>
		/// 	A collection of KeywordsCols
		///		
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>This collection may contain 0 to Many objects.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsCol("Keywords", "http://www.opengis.net/ows", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element)]
		public CSW.XmlObjectCollection<ows.Keywords> KeywordsCol
		{
			get { return m_KeywordsCol; }
		}
		protected CSW.XmlObjectCollection<ows.Keywords> m_KeywordsCol;
		
		#endregion

		#region Attribute - ServiceType
		/// <summary>
		///		Represents a mandatory Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is mandatory and therefore must be populated within the XML.</BR>
		///		<BR>If this property is set, then the object will be COPIED. If the property is set to null an exception is raised.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsMnd("ServiceType", "http://www.opengis.net/ows", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(ows.CodeType), false)]
		public ows.CodeType ServiceType
		{
			get 
			{ 
				return m_ServiceType;  
			}
			set 
			{ 
				Throw_IfPropertyIsNull(value, "ServiceType");
				if (value != null)
					SetElementName(value, "ServiceType");
				m_ServiceType = value;
			}
		}
		protected ows.CodeType m_ServiceType;
		
		#endregion

		#region Attribute - ServiceTypeVersion
		/// <summary>
		///		A collection of Strings
		///		
		/// </summary>
		/// <remarks>
		///		<BR></BR>
		///		<BR>This property is represented as an Element in the XML.</BR>
		///		<BR>This collection may contain 1 to Many Strings.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimCol("ServiceTypeVersion", "http://www.opengis.net/ows")]
		public CSW.XmlSimpleTypeCollection<String> ServiceTypeVersionCol
		{
			get { return m_ServiceTypeVersionCol; }
		}
		protected CSW.XmlSimpleTypeCollection<String> m_ServiceTypeVersionCol;

		#endregion

		#region Attribute - Fees
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimOpt("Fees", "http://www.opengis.net/ows", "IsValidFees", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", -1, -1, "", "", "", "", -1)]
		public String Fees
		{
			get 
			{ 
				if (m_IsValidFees == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property Fees is not valid. Set FeesValid = true");
				return m_Fees;  
			}
			set 
			{ 
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				m_IsValidFees = true;
				m_Fees = value;
			}
		}
		/// <summary>
		/// 	Indicates if Fees contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for Fees is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value ("").</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get Fees
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidFees
		{
			get
			{
				return m_IsValidFees;
			}
			set 
			{ 
				if (value != m_IsValidFees)
				{
					Fees = "";
					m_IsValidFees = value;
				}
			}
		}
		protected Boolean m_IsValidFees;
		protected String m_Fees;
		#endregion

		#region Attribute - AccessConstraints
		/// <summary>
		///		A collection of Strings
		///		
		/// </summary>
		/// <remarks>
		///		<BR></BR>
		///		<BR>This property is represented as an Element in the XML.</BR>
		///		<BR>This collection may contain 0 to Many Strings.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimCol("AccessConstraints", "http://www.opengis.net/ows")]
		public CSW.XmlSimpleTypeCollection<String> AccessConstraintsCol
		{
			get { return m_AccessConstraintsCol; }
		}
		protected CSW.XmlSimpleTypeCollection<String> m_AccessConstraintsCol;

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


