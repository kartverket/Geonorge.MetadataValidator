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
	/// 	This class represents the Element usesImageDatum
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Sequence,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element,
													"usesImageDatum", "http://www.opengis.net/gml", false, false,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class UsesImageDatum : CSW.XmlCommonBase
	{
		#region Constructors
		/// <summary>
		///		Constructor for UsesImageDatum
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public UsesImageDatum()
		{
			_elementName = "usesImageDatum";
			Init();
		}
		public UsesImageDatum(String elementName)
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
			m_Type = AC.Enumerations.TypeType.Simple;
			m_IsValidType = false;
			m_Href = "";
			m_IsValidHref = false;
			m_Role = "";
			m_IsValidRole = false;
			m_Arcrole = "";
			m_IsValidArcrole = false;
			m_Title = "";
			m_IsValidTitle = false;
			m_Show = AC.Enumerations.ShowType.new_;
			m_IsValidShow = false;
			m_Actuate = AC.Enumerations.ActuateType.OnLoad;
			m_IsValidActuate = false;
			m_RemoteSchema = "";
			m_IsValidRemoteSchema = false;
			m_UsesImageDatum_Group = null;



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
			AE.UsesImageDatum newObject = new AE.UsesImageDatum(_elementName);
			newObject.m_Type = m_Type;
			newObject.m_IsValidType = m_IsValidType;
			newObject.m_Href = m_Href;
			newObject.m_IsValidHref = m_IsValidHref;
			newObject.m_Role = m_Role;
			newObject.m_IsValidRole = m_IsValidRole;
			newObject.m_Arcrole = m_Arcrole;
			newObject.m_IsValidArcrole = m_IsValidArcrole;
			newObject.m_Title = m_Title;
			newObject.m_IsValidTitle = m_IsValidTitle;
			newObject.m_Show = m_Show;
			newObject.m_IsValidShow = m_IsValidShow;
			newObject.m_Actuate = m_Actuate;
			newObject.m_IsValidActuate = m_IsValidActuate;
			newObject.m_RemoteSchema = m_RemoteSchema;
			newObject.m_IsValidRemoteSchema = m_IsValidRemoteSchema;
			newObject.m_UsesImageDatum_Group = null;
			if (m_UsesImageDatum_Group != null)
				newObject.m_UsesImageDatum_Group = (AE.UsesImageDatum_Group)m_UsesImageDatum_Group.Clone();


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

		#region Attribute - type
		/// <summary>
		///		Represents an optional Attribute in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Attribute in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoEnum("type", "http://www.w3.org/1999/xlink", "IsValidType", typeof(AC.Enumerations), "TypeTypeFromString", "TypeTypeToString", null)]
		public AC.Enumerations.TypeType Type
		{
			get 
			{ 
				if (m_IsValidType == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property type is not valid. Set typeValid = true");
				return m_Type;  
			}
			set 
			{ 
				m_Type = value;
				m_IsValidType = true;
			}
		}
		/// <summary>
		/// 	Indicates if type contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for type is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value (AC.Enumerations.TypeType.Simple).</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get type
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidType
		{
			get { return m_IsValidType;  }
			set 
			{ 
				if (value != m_IsValidType)
				{
					Type = AC.Enumerations.TypeType.Simple;
					m_IsValidType = value;
				}
			}
		}
		protected AC.Enumerations.TypeType m_Type;
		protected Boolean m_IsValidType;

		#endregion

		#region Attribute - href
		/// <summary>
		///		Represents an optional Attribute in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Attribute in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoPrimitive("href", "http://www.w3.org/1999/xlink", "IsValidHref", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, null, "", -1, -1, "", "", "", "", -1)]
		public String Href
		{
			get 
			{ 
				if (m_IsValidHref == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property href is not valid. Set hrefValid = true");
				return m_Href;  
			}
			set 
			{ 
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Collapse(value); 
				m_IsValidHref = true;
				m_Href = value;
			}
		}
		/// <summary>
		/// 	Indicates if href contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for href is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value ("").</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get href
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidHref
		{
			get
			{
				return m_IsValidHref;
			}
			set 
			{ 
				if (value != m_IsValidHref)
				{
					Href = "";
					m_IsValidHref = value;
				}
			}
		}
		protected Boolean m_IsValidHref;
		protected String m_Href;
		#endregion

		#region Attribute - role
		/// <summary>
		///		Represents an optional Attribute in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Attribute in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoPrimitive("role", "http://www.w3.org/1999/xlink", "IsValidRole", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, null, "", 1, -1, "", "", "", "", -1)]
		public String Role
		{
			get 
			{ 
				if (m_IsValidRole == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property role is not valid. Set roleValid = true");
				return m_Role;  
			}
			set 
			{ 
				CheckAttributeRestriction(2, value);
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Collapse(value); 
				m_IsValidRole = true;
				m_Role = value;
			}
		}
		/// <summary>
		/// 	Indicates if role contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for role is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value ("").</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get role
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidRole
		{
			get
			{
				return m_IsValidRole;
			}
			set 
			{ 
				if (value != m_IsValidRole)
				{
					Role = "";
					m_IsValidRole = value;
				}
			}
		}
		protected Boolean m_IsValidRole;
		protected String m_Role;
		#endregion

		#region Attribute - arcrole
		/// <summary>
		///		Represents an optional Attribute in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Attribute in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoPrimitive("arcrole", "http://www.w3.org/1999/xlink", "IsValidArcrole", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, null, "", 1, -1, "", "", "", "", -1)]
		public String Arcrole
		{
			get 
			{ 
				if (m_IsValidArcrole == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property arcrole is not valid. Set arcroleValid = true");
				return m_Arcrole;  
			}
			set 
			{ 
				CheckAttributeRestriction(3, value);
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Collapse(value); 
				m_IsValidArcrole = true;
				m_Arcrole = value;
			}
		}
		/// <summary>
		/// 	Indicates if arcrole contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for arcrole is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value ("").</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get arcrole
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidArcrole
		{
			get
			{
				return m_IsValidArcrole;
			}
			set 
			{ 
				if (value != m_IsValidArcrole)
				{
					Arcrole = "";
					m_IsValidArcrole = value;
				}
			}
		}
		protected Boolean m_IsValidArcrole;
		protected String m_Arcrole;
		#endregion

		#region Attribute - title
		/// <summary>
		///		Represents an optional Attribute in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Attribute in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoPrimitive("title", "http://www.w3.org/1999/xlink", "IsValidTitle", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, null, "", -1, -1, "", "", "", "", -1)]
		public String Title
		{
			get 
			{ 
				if (m_IsValidTitle == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property title is not valid. Set titleValid = true");
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
		/// 	Indicates if title contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for title is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value ("").</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get title
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

		#region Attribute - show
		/// <summary>
		///		Represents an optional Attribute in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Attribute in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoEnum("show", "http://www.w3.org/1999/xlink", "IsValidShow", typeof(AC.Enumerations), "ShowTypeFromString", "ShowTypeToString", null)]
		public AC.Enumerations.ShowType Show
		{
			get 
			{ 
				if (m_IsValidShow == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property show is not valid. Set showValid = true");
				return m_Show;  
			}
			set 
			{ 
				m_Show = value;
				m_IsValidShow = true;
			}
		}
		/// <summary>
		/// 	Indicates if show contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for show is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value (AC.Enumerations.ShowType.new_).</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get show
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidShow
		{
			get { return m_IsValidShow;  }
			set 
			{ 
				if (value != m_IsValidShow)
				{
					Show = AC.Enumerations.ShowType.new_;
					m_IsValidShow = value;
				}
			}
		}
		protected AC.Enumerations.ShowType m_Show;
		protected Boolean m_IsValidShow;

		#endregion

		#region Attribute - actuate
		/// <summary>
		///		Represents an optional Attribute in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Attribute in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoEnum("actuate", "http://www.w3.org/1999/xlink", "IsValidActuate", typeof(AC.Enumerations), "ActuateTypeFromString", "ActuateTypeToString", null)]
		public AC.Enumerations.ActuateType Actuate
		{
			get 
			{ 
				if (m_IsValidActuate == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property actuate is not valid. Set actuateValid = true");
				return m_Actuate;  
			}
			set 
			{ 
				m_Actuate = value;
				m_IsValidActuate = true;
			}
		}
		/// <summary>
		/// 	Indicates if actuate contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for actuate is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value (AC.Enumerations.ActuateType.OnLoad).</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get actuate
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidActuate
		{
			get { return m_IsValidActuate;  }
			set 
			{ 
				if (value != m_IsValidActuate)
				{
					Actuate = AC.Enumerations.ActuateType.OnLoad;
					m_IsValidActuate = value;
				}
			}
		}
		protected AC.Enumerations.ActuateType m_Actuate;
		protected Boolean m_IsValidActuate;

		#endregion

		#region Attribute - remoteSchema
		/// <summary>
		///		Represents an optional Attribute in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Attribute in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoPrimitive("remoteSchema", "http://www.opengis.net/gml", "IsValidRemoteSchema", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, null, "", -1, -1, "", "", "", "", -1)]
		public String RemoteSchema
		{
			get 
			{ 
				if (m_IsValidRemoteSchema == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property remoteSchema is not valid. Set remoteSchemaValid = true");
				return m_RemoteSchema;  
			}
			set 
			{ 
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Collapse(value); 
				m_IsValidRemoteSchema = true;
				m_RemoteSchema = value;
			}
		}
		/// <summary>
		/// 	Indicates if remoteSchema contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for remoteSchema is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value ("").</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get remoteSchema
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidRemoteSchema
		{
			get
			{
				return m_IsValidRemoteSchema;
			}
			set 
			{ 
				if (value != m_IsValidRemoteSchema)
				{
					RemoteSchema = "";
					m_IsValidRemoteSchema = value;
				}
			}
		}
		protected Boolean m_IsValidRemoteSchema;
		protected String m_RemoteSchema;
		#endregion

		#region Attribute - usesImageDatum_Group
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsOpt("usesImageDatum_Group", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement, typeof(AE.UsesImageDatum_Group))]
		public AE.UsesImageDatum_Group UsesImageDatum_Group
		{
			get 
			{ 
				return m_UsesImageDatum_Group;  
			}
			set 
			{ 
				if (value == null)
					m_UsesImageDatum_Group = null;
				else
				{
					m_UsesImageDatum_Group = value; 
				}
			}
		}
		protected AE.UsesImageDatum_Group m_UsesImageDatum_Group;
		
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


