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
	/// 	This class represents the Element Geodesic
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Sequence,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element,
													"Geodesic", "http://www.opengis.net/gml", false, true,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class Geodesic : CSW.XmlCommonBase
					, AE.IGeodesicStringType
	{
		#region Constructors
		/// <summary>
		///		Constructor for Geodesic
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public Geodesic()
		{
			_elementName = "Geodesic";
			Init();
		}
		public Geodesic(String elementName)
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
			m_NumDerivativesAtStart = LiquidTechnologies.Runtime.Net45.Conversions.integerFromString("0", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse);
			m_IsValidNumDerivativesAtStart = true;
			m_NumDerivativesAtEnd = LiquidTechnologies.Runtime.Net45.Conversions.integerFromString("0", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse);
			m_IsValidNumDerivativesAtEnd = true;
			m_NumDerivativeInterior = LiquidTechnologies.Runtime.Net45.Conversions.integerFromString("0", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse);
			m_IsValidNumDerivativeInterior = true;
			m_GeodesicStringTypeData = new AE.GeodesicStringType_Type("GeodesicStringTypeData");



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
			AE.Geodesic newObject = new AE.Geodesic(_elementName);
			newObject.m_NumDerivativesAtStart = m_NumDerivativesAtStart;
			newObject.m_IsValidNumDerivativesAtStart = m_IsValidNumDerivativesAtStart;
			newObject.m_NumDerivativesAtEnd = m_NumDerivativesAtEnd;
			newObject.m_IsValidNumDerivativesAtEnd = m_IsValidNumDerivativesAtEnd;
			newObject.m_NumDerivativeInterior = m_NumDerivativeInterior;
			newObject.m_IsValidNumDerivativeInterior = m_IsValidNumDerivativeInterior;
			newObject.m_GeodesicStringTypeData = null;
			if (m_GeodesicStringTypeData != null)
				newObject.m_GeodesicStringTypeData = (AE.GeodesicStringType_Type)m_GeodesicStringTypeData.Clone();


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

		#region Attribute - numDerivativesAtStart
		/// <summary>
		///		Represents an optional Attribute in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Attribute in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoPrimitive("numDerivativesAtStart", "", "IsValidNumDerivativesAtStart", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_integer, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "0", "", -1, -1, "", "", "", "", -1)]
		public LiquidTechnologies.Runtime.Net45.BigInteger NumDerivativesAtStart
		{
			get 
			{ 
				if (m_IsValidNumDerivativesAtStart == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property numDerivativesAtStart is not valid. Set numDerivativesAtStartValid = true");
				return m_NumDerivativesAtStart;  
			}
			set 
			{ 
				m_IsValidNumDerivativesAtStart = true;
				m_NumDerivativesAtStart = value;
			}
		}
		/// <summary>
		/// 	Indicates if numDerivativesAtStart contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for numDerivativesAtStart is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value (LiquidTechnologies.Runtime.Net45.Conversions.integerFromString("0", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)).</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get numDerivativesAtStart
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidNumDerivativesAtStart
		{
			get
			{
				return m_IsValidNumDerivativesAtStart;
			}
			set 
			{ 
				// Attributes with Default can not be removed.
				if (!value)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property numDerivativesAtStart has a a default value, and is an attribute, because of this it can not be removed from the schema");
			}
		}
		protected Boolean m_IsValidNumDerivativesAtStart;
		protected LiquidTechnologies.Runtime.Net45.BigInteger m_NumDerivativesAtStart;
		#endregion

		#region Attribute - numDerivativesAtEnd
		/// <summary>
		///		Represents an optional Attribute in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Attribute in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoPrimitive("numDerivativesAtEnd", "", "IsValidNumDerivativesAtEnd", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_integer, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "0", "", -1, -1, "", "", "", "", -1)]
		public LiquidTechnologies.Runtime.Net45.BigInteger NumDerivativesAtEnd
		{
			get 
			{ 
				if (m_IsValidNumDerivativesAtEnd == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property numDerivativesAtEnd is not valid. Set numDerivativesAtEndValid = true");
				return m_NumDerivativesAtEnd;  
			}
			set 
			{ 
				m_IsValidNumDerivativesAtEnd = true;
				m_NumDerivativesAtEnd = value;
			}
		}
		/// <summary>
		/// 	Indicates if numDerivativesAtEnd contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for numDerivativesAtEnd is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value (LiquidTechnologies.Runtime.Net45.Conversions.integerFromString("0", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)).</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get numDerivativesAtEnd
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidNumDerivativesAtEnd
		{
			get
			{
				return m_IsValidNumDerivativesAtEnd;
			}
			set 
			{ 
				// Attributes with Default can not be removed.
				if (!value)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property numDerivativesAtEnd has a a default value, and is an attribute, because of this it can not be removed from the schema");
			}
		}
		protected Boolean m_IsValidNumDerivativesAtEnd;
		protected LiquidTechnologies.Runtime.Net45.BigInteger m_NumDerivativesAtEnd;
		#endregion

		#region Attribute - numDerivativeInterior
		/// <summary>
		///		Represents an optional Attribute in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Attribute in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoPrimitive("numDerivativeInterior", "", "IsValidNumDerivativeInterior", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_integer, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "0", "", -1, -1, "", "", "", "", -1)]
		public LiquidTechnologies.Runtime.Net45.BigInteger NumDerivativeInterior
		{
			get 
			{ 
				if (m_IsValidNumDerivativeInterior == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property numDerivativeInterior is not valid. Set numDerivativeInteriorValid = true");
				return m_NumDerivativeInterior;  
			}
			set 
			{ 
				m_IsValidNumDerivativeInterior = true;
				m_NumDerivativeInterior = value;
			}
		}
		/// <summary>
		/// 	Indicates if numDerivativeInterior contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for numDerivativeInterior is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value (LiquidTechnologies.Runtime.Net45.Conversions.integerFromString("0", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)).</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get numDerivativeInterior
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidNumDerivativeInterior
		{
			get
			{
				return m_IsValidNumDerivativeInterior;
			}
			set 
			{ 
				// Attributes with Default can not be removed.
				if (!value)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property numDerivativeInterior has a a default value, and is an attribute, because of this it can not be removed from the schema");
			}
		}
		protected Boolean m_IsValidNumDerivativeInterior;
		protected LiquidTechnologies.Runtime.Net45.BigInteger m_NumDerivativeInterior;
		#endregion

		#region Attribute - GeodesicStringTypeData
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
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsMnd("GeodesicStringTypeData", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement, typeof(AE.GeodesicStringType_Type), true)]
		public AE.GeodesicStringType_Type GeodesicStringTypeData
		{
			get 
			{ 
				return m_GeodesicStringTypeData;  
			}
			set 
			{ 
				Throw_IfPropertyIsNull(value, "GeodesicStringTypeData");
				m_GeodesicStringTypeData = value;
			}
		}
		protected AE.GeodesicStringType_Type m_GeodesicStringTypeData;
		
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

