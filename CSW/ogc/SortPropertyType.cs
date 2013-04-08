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
	/// 	This class represents the ComplexType SortPropertyType
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Sequence,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element,
													"SortPropertyType", "http://www.opengis.net/ogc", true, false,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class SortPropertyType : CSW.XmlCommonBase
	{
		#region Constructors
		/// <summary>
		///		Constructor for SortPropertyType
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public SortPropertyType()
		{
			_elementName = "SortPropertyType";
			Init();
		}
		public SortPropertyType(String elementName)
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
			m_SortOrder = ogc.Enumerations.SortOrderType.DESC;
			m_IsValidSortOrder = false;



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
			ogc.SortPropertyType newObject = new ogc.SortPropertyType(_elementName);
			newObject.m_PropertyName = null;
			if (m_PropertyName != null)
				newObject.m_PropertyName = (ogc.PropertyName)m_PropertyName.Clone();
			newObject.m_SortOrder = m_SortOrder;
			newObject.m_IsValidSortOrder = m_IsValidSortOrder;


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

		#region Attribute - SortOrder
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqEnumOpt("SortOrder", "http://www.opengis.net/ogc", "IsValidSortOrder", null, typeof(ogc.Enumerations), "SortOrderTypeFromString", "SortOrderTypeToString")]
		public ogc.Enumerations.SortOrderType SortOrder
		{
			get 
			{ 
				if (m_IsValidSortOrder == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property SortOrder is not valid. Set SortOrderValid = true");
				return m_SortOrder;  
			}
			set 
			{ 
				m_SortOrder = value;
				m_IsValidSortOrder = true;
			}
		}
		/// <summary>
		/// 	Indicates if SortOrder contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for SortOrder is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value (ogc.Enumerations.SortOrderType.DESC).</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get SortOrder
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidSortOrder
		{
			get { return m_IsValidSortOrder;  }
			set 
			{ 
				if (value != m_IsValidSortOrder)
				{
					SortOrder = ogc.Enumerations.SortOrderType.DESC;
					m_IsValidSortOrder = value;
				}
			}
		}
		protected ogc.Enumerations.SortOrderType m_SortOrder;
		protected Boolean m_IsValidSortOrder;

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

