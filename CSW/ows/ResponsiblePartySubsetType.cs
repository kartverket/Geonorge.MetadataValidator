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
	/// 	This class represents the ComplexType ResponsiblePartySubsetType
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Sequence,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element,
													"ResponsiblePartySubsetType", "http://www.opengis.net/ows", true, false,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class ResponsiblePartySubsetType : CSW.XmlCommonBase
	{
		#region Constructors
		/// <summary>
		///		Constructor for ResponsiblePartySubsetType
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public ResponsiblePartySubsetType()
		{
			_elementName = "ResponsiblePartySubsetType";
			Init();
		}
		public ResponsiblePartySubsetType(String elementName)
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
			m_IndividualName = "";
			m_IsValidIndividualName = false; 
			m_PositionName = "";
			m_IsValidPositionName = false; 
			m_ContactInfo = null;
			m_Role = null;



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
			ows.ResponsiblePartySubsetType newObject = new ows.ResponsiblePartySubsetType(_elementName);
			newObject.m_IndividualName = m_IndividualName;
			newObject.m_IsValidIndividualName = m_IsValidIndividualName;
			newObject.m_PositionName = m_PositionName;
			newObject.m_IsValidPositionName = m_IsValidPositionName;
			newObject.m_ContactInfo = null;
			if (m_ContactInfo != null)
				newObject.m_ContactInfo = (ows.ContactInfo)m_ContactInfo.Clone();
			newObject.m_Role = null;
			if (m_Role != null)
				newObject.m_Role = (ows.Role)m_Role.Clone();


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

		#region Attribute - IndividualName
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimOpt("IndividualName", "http://www.opengis.net/ows", "IsValidIndividualName", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", -1, -1, "", "", "", "", -1)]
		public String IndividualName
		{
			get 
			{ 
				if (m_IsValidIndividualName == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property IndividualName is not valid. Set IndividualNameValid = true");
				return m_IndividualName;  
			}
			set 
			{ 
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				m_IsValidIndividualName = true;
				m_IndividualName = value;
			}
		}
		/// <summary>
		/// 	Indicates if IndividualName contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for IndividualName is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value ("").</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get IndividualName
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidIndividualName
		{
			get
			{
				return m_IsValidIndividualName;
			}
			set 
			{ 
				if (value != m_IsValidIndividualName)
				{
					IndividualName = "";
					m_IsValidIndividualName = value;
				}
			}
		}
		protected Boolean m_IsValidIndividualName;
		protected String m_IndividualName;
		#endregion

		#region Attribute - PositionName
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimOpt("PositionName", "http://www.opengis.net/ows", "IsValidPositionName", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", -1, -1, "", "", "", "", -1)]
		public String PositionName
		{
			get 
			{ 
				if (m_IsValidPositionName == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property PositionName is not valid. Set PositionNameValid = true");
				return m_PositionName;  
			}
			set 
			{ 
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				m_IsValidPositionName = true;
				m_PositionName = value;
			}
		}
		/// <summary>
		/// 	Indicates if PositionName contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for PositionName is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value ("").</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get PositionName
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidPositionName
		{
			get
			{
				return m_IsValidPositionName;
			}
			set 
			{ 
				if (value != m_IsValidPositionName)
				{
					PositionName = "";
					m_IsValidPositionName = value;
				}
			}
		}
		protected Boolean m_IsValidPositionName;
		protected String m_PositionName;
		#endregion

		#region Attribute - ContactInfo
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsOpt("ContactInfo", "http://www.opengis.net/ows", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(ows.ContactInfo))]
		public ows.ContactInfo ContactInfo
		{
			get 
			{ 
				return m_ContactInfo;  
			}
			set 
			{ 
				if (value == null)
					m_ContactInfo = null;
				else
				{
					m_ContactInfo = value; 
				}
			}
		}
		protected ows.ContactInfo m_ContactInfo;
		
		#endregion

		#region Attribute - Role
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsOpt("Role", "http://www.opengis.net/ows", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(ows.Role))]
		public ows.Role Role
		{
			get 
			{ 
				return m_Role;  
			}
			set 
			{ 
				if (value == null)
					m_Role = null;
				else
				{
					m_Role = value; 
				}
			}
		}
		protected ows.Role m_Role;
		
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


