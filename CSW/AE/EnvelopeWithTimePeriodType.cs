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
	/// 	This class represents the ComplexType EnvelopeWithTimePeriodType
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Sequence,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element,
													"EnvelopeWithTimePeriodType", "http://www.opengis.net/gml", false, true,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class EnvelopeWithTimePeriodType : CSW.XmlCommonBase
					, AE.IEnvelopeType
	{
		#region Constructors
		/// <summary>
		///		Constructor for EnvelopeWithTimePeriodType
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public EnvelopeWithTimePeriodType()
		{
			_elementName = "EnvelopeWithTimePeriodType";
			Init();
		}
		public EnvelopeWithTimePeriodType(String elementName)
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
			m_EnvelopeTypeData = new AE.EnvelopeType_Type("EnvelopeTypeData");
			m_EnvelopeWithTimePeriodTypeData = new AE.EnvelopeWithTimePeriodType_Type("EnvelopeWithTimePeriodTypeData");



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
			AE.EnvelopeWithTimePeriodType newObject = new AE.EnvelopeWithTimePeriodType(_elementName);
			newObject.m_EnvelopeTypeData = null;
			if (m_EnvelopeTypeData != null)
				newObject.m_EnvelopeTypeData = (AE.EnvelopeType_Type)m_EnvelopeTypeData.Clone();
			newObject.m_EnvelopeWithTimePeriodTypeData = null;
			if (m_EnvelopeWithTimePeriodTypeData != null)
				newObject.m_EnvelopeWithTimePeriodTypeData = (AE.EnvelopeWithTimePeriodType_Type)m_EnvelopeWithTimePeriodTypeData.Clone();


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

		#region Attribute - EnvelopeTypeData
		/// <summary>
		///		Represents a mandatory Element in the XML document
		/// 	Holds all the information contained within the element
		/// </summary>
		/// <remarks>
		/// 	<BR>Because this is a base type, all the objects in it must be contained within a second class. This means all classes supporting this interface can expose use the same interface regardless of how they are extended.</BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is mandatory and therefore must be populated within the XML.</BR>
		///		<BR>If this property is set, then the object will be COPIED. If the property is set to null an exception is raised.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsMnd("EnvelopeTypeData", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement, typeof(AE.EnvelopeType_Type), true)]
		public AE.EnvelopeType_Type EnvelopeTypeData
		{
			get 
			{ 
				return m_EnvelopeTypeData;  
			}
			set 
			{ 
				Throw_IfPropertyIsNull(value, "EnvelopeTypeData");
				m_EnvelopeTypeData = value;
			}
		}
		protected AE.EnvelopeType_Type m_EnvelopeTypeData;
		
		#endregion

		#region Attribute - EnvelopeWithTimePeriodTypeData
		/// <summary>
		///		Represents a mandatory Element in the XML document
		/// 	Holds all the information contained within the element
		/// </summary>
		/// <remarks>
		/// 	<BR>Because this is a base type, all the objects in it must be contained within a second class. This means all classes supporting this interface can expose use the same interface regardless of how they are extended.</BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is mandatory and therefore must be populated within the XML.</BR>
		///		<BR>If this property is set, then the object will be COPIED. If the property is set to null an exception is raised.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsMnd("EnvelopeWithTimePeriodTypeData", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement, typeof(AE.EnvelopeWithTimePeriodType_Type), true)]
		public AE.EnvelopeWithTimePeriodType_Type EnvelopeWithTimePeriodTypeData
		{
			get 
			{ 
				return m_EnvelopeWithTimePeriodTypeData;  
			}
			set 
			{ 
				Throw_IfPropertyIsNull(value, "EnvelopeWithTimePeriodTypeData");
				m_EnvelopeWithTimePeriodTypeData = value;
			}
		}
		protected AE.EnvelopeWithTimePeriodType_Type m_EnvelopeWithTimePeriodTypeData;
		
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


