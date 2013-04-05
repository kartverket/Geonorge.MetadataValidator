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
	/// 	This class represents the ComplexType SpatialOperatorType
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Sequence,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element,
													"SpatialOperatorType", "http://www.opengis.net/ogc", true, false,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class SpatialOperatorType : CSW.XmlCommonBase
	{
		#region Constructors
		/// <summary>
		///		Constructor for SpatialOperatorType
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public SpatialOperatorType()
		{
			_elementName = "SpatialOperatorType";
			Init();
		}
		public SpatialOperatorType(String elementName)
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
			m_Name = ogc.Enumerations.SpatialOperatorNameType.BBOX;
			m_IsValidName = false;
			m_GeometryOperands = null;



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
			ogc.SpatialOperatorType newObject = new ogc.SpatialOperatorType(_elementName);
			newObject.m_Name = m_Name;
			newObject.m_IsValidName = m_IsValidName;
			newObject.m_GeometryOperands = null;
			if (m_GeometryOperands != null)
				newObject.m_GeometryOperands = (ogc.GeometryOperandsType)m_GeometryOperands.Clone();


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

		#region Attribute - name
		/// <summary>
		///		Represents an optional Attribute in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Attribute in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoEnum("name", "", "IsValidName", typeof(ogc.Enumerations), "SpatialOperatorNameTypeFromString", "SpatialOperatorNameTypeToString", null)]
		public ogc.Enumerations.SpatialOperatorNameType Name
		{
			get 
			{ 
				if (m_IsValidName == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property name is not valid. Set nameValid = true");
				return m_Name;  
			}
			set 
			{ 
				m_Name = value;
				m_IsValidName = true;
			}
		}
		/// <summary>
		/// 	Indicates if name contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for name is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value (ogc.Enumerations.SpatialOperatorNameType.BBOX).</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get name
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidName
		{
			get { return m_IsValidName;  }
			set 
			{ 
				if (value != m_IsValidName)
				{
					Name = ogc.Enumerations.SpatialOperatorNameType.BBOX;
					m_IsValidName = value;
				}
			}
		}
		protected ogc.Enumerations.SpatialOperatorNameType m_Name;
		protected Boolean m_IsValidName;

		#endregion

		#region Attribute - GeometryOperands
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsOpt("GeometryOperands", "http://www.opengis.net/ogc", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(ogc.GeometryOperandsType))]
		public ogc.GeometryOperandsType GeometryOperands
		{
			get 
			{ 
				return m_GeometryOperands;  
			}
			set 
			{ 
				if (value == null)
					m_GeometryOperands = null;
				else
				{
					SetElementName(value, "GeometryOperands");
					m_GeometryOperands = value; 
				}
			}
		}
		protected ogc.GeometryOperandsType m_GeometryOperands;
		
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


