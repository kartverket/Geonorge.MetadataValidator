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
	/// 	This class represents the ComplexType IdentificationType
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Sequence,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element,
													"IdentificationType", "http://www.opengis.net/ows", false, true,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class IdentificationType : CSW.XmlCommonBase
					, ows.IDescriptionType
	{
		#region Constructors
		/// <summary>
		///		Constructor for IdentificationType
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public IdentificationType()
		{
			_elementName = "IdentificationType";
			Init();
		}
		public IdentificationType(String elementName)
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
			m_Identifier = null;
			m_BoundingBoxCol = new CSW.XmlObjectCollection<ows.SubGrpBoundingBox>("BoundingBox", "http://www.opengis.net/ows", 0, -1, true);
			m_OutputFormatCol = new CSW.XmlSimpleTypeCollection<String>("OutputFormat", "http://www.opengis.net/ows", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, 0, -1, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, new LiquidTechnologies.Runtime.Net45.PrimitiveRestrictions("(application|audio|image|text|video|message|multipart|model)/.+(;\\s*.+=.+)*", -1, -1, "", "", "", "", -1));
			m_AvailableCRSCol = new CSW.XmlObjectCollection<ows.SubGrpAvailableCRS>("AvailableCRS", "http://www.opengis.net/ows", 0, -1, true);
			m_MetadataCol = new CSW.XmlObjectCollection<ows.Metadata>("Metadata", "http://www.opengis.net/ows", 0, -1, false);



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
			ows.IdentificationType newObject = new ows.IdentificationType(_elementName);
			newObject.m_Title = m_Title;
			newObject.m_IsValidTitle = m_IsValidTitle;
			newObject.m_Abstract = m_Abstract;
			newObject.m_IsValidAbstract = m_IsValidAbstract;
			foreach (ows.Keywords o in m_KeywordsCol)
				newObject.m_KeywordsCol.Add((ows.Keywords)o.Clone());
			newObject.m_Identifier = null;
			if (m_Identifier != null)
				newObject.m_Identifier = (ows.Identifier)m_Identifier.Clone();
			foreach (ows.SubGrpBoundingBox o in m_BoundingBoxCol)
				newObject.m_BoundingBoxCol.Add((ows.SubGrpBoundingBox)o.Clone());
			foreach (String o in m_OutputFormatCol)
				newObject.m_OutputFormatCol.Add(o);
			foreach (ows.SubGrpAvailableCRS o in m_AvailableCRSCol)
				newObject.m_AvailableCRSCol.Add((ows.SubGrpAvailableCRS)o.Clone());
			foreach (ows.Metadata o in m_MetadataCol)
				newObject.m_MetadataCol.Add((ows.Metadata)o.Clone());


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

		#region Attribute - Identifier
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsOpt("Identifier", "http://www.opengis.net/ows", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(ows.Identifier))]
		public ows.Identifier Identifier
		{
			get 
			{ 
				return m_Identifier;  
			}
			set 
			{ 
				if (value == null)
					m_Identifier = null;
				else
				{
					m_Identifier = value; 
				}
			}
		}
		protected ows.Identifier m_Identifier;
		
		#endregion

		#region Attribute - BoundingBox
		/// <summary>
		/// 	A collection of BoundingBoxCols
		///		
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>This collection may contain 0 to Many objects.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsCol("BoundingBox", "http://www.opengis.net/ows", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement)]
		public CSW.XmlObjectCollection<ows.SubGrpBoundingBox> BoundingBoxCol
		{
			get { return m_BoundingBoxCol; }
		}
		protected CSW.XmlObjectCollection<ows.SubGrpBoundingBox> m_BoundingBoxCol;
		
		#endregion

		#region Attribute - OutputFormat
		/// <summary>
		///		A collection of Strings
		///		
		/// </summary>
		/// <remarks>
		///		<BR></BR>
		///		<BR>This property is represented as an Element in the XML.</BR>
		///		<BR>This collection may contain 0 to Many Strings.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimCol("OutputFormat", "http://www.opengis.net/ows")]
		public CSW.XmlSimpleTypeCollection<String> OutputFormatCol
		{
			get { return m_OutputFormatCol; }
		}
		protected CSW.XmlSimpleTypeCollection<String> m_OutputFormatCol;

		#endregion

		#region Attribute - AvailableCRS
		/// <summary>
		/// 	A collection of AvailableCRSCols
		///		
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>This collection may contain 0 to Many objects.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsCol("AvailableCRS", "http://www.opengis.net/ows", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement)]
		public CSW.XmlObjectCollection<ows.SubGrpAvailableCRS> AvailableCRSCol
		{
			get { return m_AvailableCRSCol; }
		}
		protected CSW.XmlObjectCollection<ows.SubGrpAvailableCRS> m_AvailableCRSCol;
		
		#endregion

		#region Attribute - Metadata
		/// <summary>
		/// 	A collection of MetadataCols
		///		
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>This collection may contain 0 to Many objects.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsCol("Metadata", "http://www.opengis.net/ows", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element)]
		public CSW.XmlObjectCollection<ows.Metadata> MetadataCol
		{
			get { return m_MetadataCol; }
		}
		protected CSW.XmlObjectCollection<ows.Metadata> m_MetadataCol;
		
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


