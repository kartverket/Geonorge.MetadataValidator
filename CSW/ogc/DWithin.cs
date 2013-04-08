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
	/// 	This class represents the Element DWithin
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Sequence,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element,
													"DWithin", "http://www.opengis.net/ogc", false, true,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class DWithin : CSW.XmlCommonBase
					, ogc.ISpatialOpsType
	{
		#region Constructors
		/// <summary>
		///		Constructor for DWithin
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public DWithin()
		{
			_elementName = "DWithin";
			Init();
		}
		public DWithin(String elementName)
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
			m_PropertyName = new ogc.PropertyName("PropertyName");
			m__Geometry = new AE.SubGrp_Geometry("_Geometry");
			m_Distance = new ogc.DistanceType("Distance");



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
			ogc.DWithin newObject = new ogc.DWithin(_elementName);
			newObject.m_PropertyName = null;
			if (m_PropertyName != null)
				newObject.m_PropertyName = (ogc.PropertyName)m_PropertyName.Clone();
			newObject.m__Geometry = null;
			if (m__Geometry != null)
				newObject.m__Geometry = (AE.SubGrp_Geometry)m__Geometry.Clone();
			newObject.m_Distance = null;
			if (m_Distance != null)
				newObject.m_Distance = (ogc.DistanceType)m_Distance.Clone();


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

		#region Attribute - PropertyName
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
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsMnd("PropertyName", "http://www.opengis.net/ogc", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(ogc.PropertyName), false)]
		public ogc.PropertyName PropertyName
		{
			get 
			{ 
				return m_PropertyName;  
			}
			set 
			{ 
				Throw_IfPropertyIsNull(value, "PropertyName");
				m_PropertyName = value;
			}
		}
		protected ogc.PropertyName m_PropertyName;
		
		#endregion

		#region Attribute - _Geometry
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
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsMnd("_Geometry", "http://www.opengis.net/ogc", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement, typeof(AE.SubGrp_Geometry), false)]
		public AE.SubGrp_Geometry _Geometry
		{
			get 
			{ 
				return m__Geometry;  
			}
			set 
			{ 
				Throw_IfPropertyIsNull(value, "_Geometry");
				m__Geometry = value;
			}
		}
		protected AE.SubGrp_Geometry m__Geometry;
		
		#endregion

		#region Attribute - Distance
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
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsMnd("Distance", "http://www.opengis.net/ogc", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(ogc.DistanceType), false)]
		public ogc.DistanceType Distance
		{
			get 
			{ 
				return m_Distance;  
			}
			set 
			{ 
				Throw_IfPropertyIsNull(value, "Distance");
				if (value != null)
					SetElementName(value, "Distance");
				m_Distance = value;
			}
		}
		protected ogc.DistanceType m_Distance;
		
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


