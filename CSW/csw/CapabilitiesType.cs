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
	/// 	This class represents the ComplexType CapabilitiesType
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Sequence,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element,
													"CapabilitiesType", "http://www.opengis.net/cat/csw/2.0.2", true, true,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class CapabilitiesType : CSW.XmlCommonBase
					, ows.ICapabilitiesBaseType
	{
		#region Constructors
		/// <summary>
		///		Constructor for CapabilitiesType
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public CapabilitiesType()
		{
			_elementName = "CapabilitiesType";
			Init();
		}
		public CapabilitiesType(String elementName)
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
			m_Version = "";
			m_UpdateSequence = "";
			m_IsValidUpdateSequence = false;
			m_ServiceIdentification = null;
			m_ServiceProvider = null;
			m_OperationsMetadata = null;
			m_Filter_Capabilities = new ogc.Filter_Capabilities("Filter_Capabilities");



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
			csw.CapabilitiesType newObject = new csw.CapabilitiesType(_elementName);
			newObject.m_Version = m_Version;
			newObject.m_UpdateSequence = m_UpdateSequence;
			newObject.m_IsValidUpdateSequence = m_IsValidUpdateSequence;
			newObject.m_ServiceIdentification = null;
			if (m_ServiceIdentification != null)
				newObject.m_ServiceIdentification = (ows.ServiceIdentification)m_ServiceIdentification.Clone();
			newObject.m_ServiceProvider = null;
			if (m_ServiceProvider != null)
				newObject.m_ServiceProvider = (ows.ServiceProvider)m_ServiceProvider.Clone();
			newObject.m_OperationsMetadata = null;
			if (m_OperationsMetadata != null)
				newObject.m_OperationsMetadata = (ows.OperationsMetadata)m_OperationsMetadata.Clone();
			newObject.m_Filter_Capabilities = null;
			if (m_Filter_Capabilities != null)
				newObject.m_Filter_Capabilities = (ogc.Filter_Capabilities)m_Filter_Capabilities.Clone();


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

		#region Attribute - version
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
        [LiquidTechnologies.Runtime.Net45.AttributeInfoPrimitive("version", "", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, null, "", -1, -1, "", "", "", "", -1)]
		public String Version
		{
			get 
			{ 
				return m_Version;  
			}
			set 
			{ 
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				m_Version = value;
			}
		}
		protected String m_Version;

		#endregion

		#region Attribute - updateSequence
		/// <summary>
		///		Represents an optional Attribute in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Attribute in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoPrimitive("updateSequence", "", "IsValidUpdateSequence", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, null, "", -1, -1, "", "", "", "", -1)]
		public String UpdateSequence
		{
			get 
			{ 
				if (m_IsValidUpdateSequence == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property updateSequence is not valid. Set updateSequenceValid = true");
				return m_UpdateSequence;  
			}
			set 
			{ 
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				m_IsValidUpdateSequence = true;
				m_UpdateSequence = value;
			}
		}
		/// <summary>
		/// 	Indicates if updateSequence contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for updateSequence is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value ("").</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get updateSequence
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidUpdateSequence
		{
			get
			{
				return m_IsValidUpdateSequence;
			}
			set 
			{ 
				if (value != m_IsValidUpdateSequence)
				{
					UpdateSequence = "";
					m_IsValidUpdateSequence = value;
				}
			}
		}
		protected Boolean m_IsValidUpdateSequence;
		protected String m_UpdateSequence;
		#endregion

		#region Attribute - ServiceIdentification
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsOpt("ServiceIdentification", "http://www.opengis.net/ows", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(ows.ServiceIdentification))]
		public ows.ServiceIdentification ServiceIdentification
		{
			get 
			{ 
				return m_ServiceIdentification;  
			}
			set 
			{ 
				if (value == null)
					m_ServiceIdentification = null;
				else
				{
					m_ServiceIdentification = value; 
				}
			}
		}
		protected ows.ServiceIdentification m_ServiceIdentification;
		
		#endregion

		#region Attribute - ServiceProvider
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsOpt("ServiceProvider", "http://www.opengis.net/ows", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(ows.ServiceProvider))]
		public ows.ServiceProvider ServiceProvider
		{
			get 
			{ 
				return m_ServiceProvider;  
			}
			set 
			{ 
				if (value == null)
					m_ServiceProvider = null;
				else
				{
					m_ServiceProvider = value; 
				}
			}
		}
		protected ows.ServiceProvider m_ServiceProvider;
		
		#endregion

		#region Attribute - OperationsMetadata
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsOpt("OperationsMetadata", "http://www.opengis.net/ows", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(ows.OperationsMetadata))]
		public ows.OperationsMetadata OperationsMetadata
		{
			get 
			{ 
				return m_OperationsMetadata;  
			}
			set 
			{ 
				if (value == null)
					m_OperationsMetadata = null;
				else
				{
					m_OperationsMetadata = value; 
				}
			}
		}
		protected ows.OperationsMetadata m_OperationsMetadata;
		
		#endregion

		#region Attribute - Filter_Capabilities
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
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsMnd("Filter_Capabilities", "http://www.opengis.net/ogc", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(ogc.Filter_Capabilities), true)]
		public ogc.Filter_Capabilities Filter_Capabilities
		{
			get 
			{ 
				return m_Filter_Capabilities;  
			}
			set 
			{ 
				Throw_IfPropertyIsNull(value, "Filter_Capabilities");
				m_Filter_Capabilities = value;
			}
		}
		protected ogc.Filter_Capabilities m_Filter_Capabilities;
		
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


