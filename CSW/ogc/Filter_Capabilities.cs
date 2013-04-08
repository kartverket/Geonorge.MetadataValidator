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

namespace ogc
{
	/// <summary>
	/// 	This class represents the Element Filter_Capabilities
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Sequence,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element,
													"Filter_Capabilities", "http://www.opengis.net/ogc", true, false,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class Filter_Capabilities : CSW.XmlCommonBase
	{
		#region Constructors
		/// <summary>
		///		Constructor for Filter_Capabilities
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public Filter_Capabilities()
		{
			_elementName = "Filter_Capabilities";
			Init();
		}
		public Filter_Capabilities(String elementName)
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
			m_Spatial_Capabilities = new ogc.Spatial_CapabilitiesType("Spatial_Capabilities");
			m_Scalar_Capabilities = new ogc.Scalar_CapabilitiesType("Scalar_Capabilities");
			m_Id_Capabilities = new ogc.Id_CapabilitiesType("Id_Capabilities");



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
			ogc.Filter_Capabilities newObject = new ogc.Filter_Capabilities(_elementName);
			newObject.m_Spatial_Capabilities = null;
			if (m_Spatial_Capabilities != null)
				newObject.m_Spatial_Capabilities = (ogc.Spatial_CapabilitiesType)m_Spatial_Capabilities.Clone();
			newObject.m_Scalar_Capabilities = null;
			if (m_Scalar_Capabilities != null)
				newObject.m_Scalar_Capabilities = (ogc.Scalar_CapabilitiesType)m_Scalar_Capabilities.Clone();
			newObject.m_Id_Capabilities = null;
			if (m_Id_Capabilities != null)
				newObject.m_Id_Capabilities = (ogc.Id_CapabilitiesType)m_Id_Capabilities.Clone();


// ##HAND_CODED_BLOCK_START ID="Additional clone"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional clone code here...

// ##HAND_CODED_BLOCK_END ID="Additional clone"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

			return newObject;
		}
		#endregion

		#region Member variables

		protected override String TargetNamespace
		{
			get { return "http://www.opengis.net/ogc"; }
		}

		#region Attribute - Spatial_Capabilities
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
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsMnd("Spatial_Capabilities", "http://www.opengis.net/ogc", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(ogc.Spatial_CapabilitiesType), true)]
		public ogc.Spatial_CapabilitiesType Spatial_Capabilities
		{
			get 
			{ 
				return m_Spatial_Capabilities;  
			}
			set 
			{ 
				Throw_IfPropertyIsNull(value, "Spatial_Capabilities");
				if (value != null)
					SetElementName(value, "Spatial_Capabilities");
				m_Spatial_Capabilities = value;
			}
		}
		protected ogc.Spatial_CapabilitiesType m_Spatial_Capabilities;
		
		#endregion

		#region Attribute - Scalar_Capabilities
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
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsMnd("Scalar_Capabilities", "http://www.opengis.net/ogc", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(ogc.Scalar_CapabilitiesType), false)]
		public ogc.Scalar_CapabilitiesType Scalar_Capabilities
		{
			get 
			{ 
				return m_Scalar_Capabilities;  
			}
			set 
			{ 
				Throw_IfPropertyIsNull(value, "Scalar_Capabilities");
				if (value != null)
					SetElementName(value, "Scalar_Capabilities");
				m_Scalar_Capabilities = value;
			}
		}
		protected ogc.Scalar_CapabilitiesType m_Scalar_Capabilities;
		
		#endregion

		#region Attribute - Id_Capabilities
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
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsMnd("Id_Capabilities", "http://www.opengis.net/ogc", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(ogc.Id_CapabilitiesType), true)]
		public ogc.Id_CapabilitiesType Id_Capabilities
		{
			get 
			{ 
				return m_Id_Capabilities;  
			}
			set 
			{ 
				Throw_IfPropertyIsNull(value, "Id_Capabilities");
				if (value != null)
					SetElementName(value, "Id_Capabilities");
				m_Id_Capabilities = value;
			}
		}
		protected ogc.Id_CapabilitiesType m_Id_Capabilities;
		
		#endregion

		#region Attribute - Namespace
		public override String Namespace
		{
			get { return "http://www.opengis.net/ogc"; }
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


