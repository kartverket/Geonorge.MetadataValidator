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
	/// 	This class represents the Element RelatedTimeType_Type
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Sequence,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement,
													"RelatedTimeType_Type", "http://www.opengis.net/gml", false, false,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class RelatedTimeType_Type : CSW.XmlCommonBase
	{
		#region Constructors
		/// <summary>
		///		Constructor for RelatedTimeType_Type
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public RelatedTimeType_Type()
		{
			_elementName = "RelatedTimeType_Type";
			Init();
		}
		public RelatedTimeType_Type(String elementName)
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
			m_RelativePosition = CSW.Enumerations.RelatedTimeType_Type_RelativePosition.Before;
			m_IsValidRelativePosition = false;



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
			AE.RelatedTimeType_Type newObject = new AE.RelatedTimeType_Type(_elementName);
			newObject.m_RelativePosition = m_RelativePosition;
			newObject.m_IsValidRelativePosition = m_IsValidRelativePosition;


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

		#region Attribute - relativePosition
		/// <summary>
		///		Represents an optional Attribute in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Attribute in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoEnum("relativePosition", "", "IsValidRelativePosition", typeof(CSW.Enumerations), "RelatedTimeType_Type_RelativePositionFromString", "RelatedTimeType_Type_RelativePositionToString", null)]
		public CSW.Enumerations.RelatedTimeType_Type_RelativePosition RelativePosition
		{
			get 
			{ 
				if (m_IsValidRelativePosition == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property relativePosition is not valid. Set relativePositionValid = true");
				return m_RelativePosition;  
			}
			set 
			{ 
				m_RelativePosition = value;
				m_IsValidRelativePosition = true;
			}
		}
		/// <summary>
		/// 	Indicates if relativePosition contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for relativePosition is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value (CSW.Enumerations.RelatedTimeType_Type_RelativePosition.Before).</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get relativePosition
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidRelativePosition
		{
			get { return m_IsValidRelativePosition;  }
			set 
			{ 
				if (value != m_IsValidRelativePosition)
				{
					RelativePosition = CSW.Enumerations.RelatedTimeType_Type_RelativePosition.Before;
					m_IsValidRelativePosition = value;
				}
			}
		}
		protected CSW.Enumerations.RelatedTimeType_Type_RelativePosition m_RelativePosition;
		protected Boolean m_IsValidRelativePosition;

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


