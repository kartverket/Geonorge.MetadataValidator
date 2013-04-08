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
	/// 	This class represents the ComplexType Spatial_CapabilitiesType
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Sequence,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element,
													"Spatial_CapabilitiesType", "http://www.opengis.net/ogc", true, false,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class Spatial_CapabilitiesType : CSW.XmlCommonBase
	{
		#region Constructors
		/// <summary>
		///		Constructor for Spatial_CapabilitiesType
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public Spatial_CapabilitiesType()
		{
			_elementName = "Spatial_CapabilitiesType";
			Init();
		}
		public Spatial_CapabilitiesType(String elementName)
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
			m_GeometryOperands = new ogc.GeometryOperandsType("GeometryOperands");
			m_SpatialOperators = new ogc.SpatialOperatorsType("SpatialOperators");



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
			ogc.Spatial_CapabilitiesType newObject = new ogc.Spatial_CapabilitiesType(_elementName);
			newObject.m_GeometryOperands = null;
			if (m_GeometryOperands != null)
				newObject.m_GeometryOperands = (ogc.GeometryOperandsType)m_GeometryOperands.Clone();
			newObject.m_SpatialOperators = null;
			if (m_SpatialOperators != null)
				newObject.m_SpatialOperators = (ogc.SpatialOperatorsType)m_SpatialOperators.Clone();


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

		#region Attribute - GeometryOperands
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
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsMnd("GeometryOperands", "http://www.opengis.net/ogc", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(ogc.GeometryOperandsType), true)]
		public ogc.GeometryOperandsType GeometryOperands
		{
			get 
			{ 
				return m_GeometryOperands;  
			}
			set 
			{ 
				Throw_IfPropertyIsNull(value, "GeometryOperands");
				if (value != null)
					SetElementName(value, "GeometryOperands");
				m_GeometryOperands = value;
			}
		}
		protected ogc.GeometryOperandsType m_GeometryOperands;
		
		#endregion

		#region Attribute - SpatialOperators
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
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsMnd("SpatialOperators", "http://www.opengis.net/ogc", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(ogc.SpatialOperatorsType), true)]
		public ogc.SpatialOperatorsType SpatialOperators
		{
			get 
			{ 
				return m_SpatialOperators;  
			}
			set 
			{ 
				Throw_IfPropertyIsNull(value, "SpatialOperators");
				if (value != null)
					SetElementName(value, "SpatialOperators");
				m_SpatialOperators = value;
			}
		}
		protected ogc.SpatialOperatorsType m_SpatialOperators;
		
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


