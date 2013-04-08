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
	/// 	This class represents the Element Clothoid
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Sequence,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element,
													"Clothoid", "http://www.opengis.net/gml", true, true,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class Clothoid : CSW.XmlCommonBase
					, AE.IAbstractCurveSegmentType
	{
		#region Constructors
		/// <summary>
		///		Constructor for Clothoid
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public Clothoid()
		{
			_elementName = "Clothoid";
			Init();
		}
		public Clothoid(String elementName)
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
			m_RefLocation = new AE.RefLocation("refLocation");
			m_ScaleFactor = 0;
			m_StartParameter = 0;
			m_EndParameter = 0;



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
			AE.Clothoid newObject = new AE.Clothoid(_elementName);
			newObject.m_NumDerivativesAtStart = m_NumDerivativesAtStart;
			newObject.m_IsValidNumDerivativesAtStart = m_IsValidNumDerivativesAtStart;
			newObject.m_NumDerivativesAtEnd = m_NumDerivativesAtEnd;
			newObject.m_IsValidNumDerivativesAtEnd = m_IsValidNumDerivativesAtEnd;
			newObject.m_NumDerivativeInterior = m_NumDerivativeInterior;
			newObject.m_IsValidNumDerivativeInterior = m_IsValidNumDerivativeInterior;
			newObject.m_RefLocation = null;
			if (m_RefLocation != null)
				newObject.m_RefLocation = (AE.RefLocation)m_RefLocation.Clone();
			newObject.m_ScaleFactor = m_ScaleFactor;
			newObject.m_StartParameter = m_StartParameter;
			newObject.m_EndParameter = m_EndParameter;


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

		#region Attribute - refLocation
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
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsMnd("refLocation", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.RefLocation), true)]
		public AE.RefLocation RefLocation
		{
			get 
			{ 
				return m_RefLocation;  
			}
			set 
			{ 
				Throw_IfPropertyIsNull(value, "refLocation");
				if (value != null)
					SetElementName(value, "refLocation");
				m_RefLocation = value;
			}
		}
		protected AE.RefLocation m_RefLocation;
		
		#endregion

		#region Attribute - scaleFactor
		/// <summary>
		///		Represents a mandatory Element in the XML document
		///		
		/// </summary>
		/// <remarks>
		///		<BR></BR>
		///		<BR>This property is represented as an Element in the XML.</BR>
		///		<BR>It is mandatory and therefore must be populated within the XML.</BR>
		///		<BR>It is defaulted to 0.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("scaleFactor", "http://www.opengis.net/gml", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_decimal, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", -1, -1, "", "", "", "", -1)]
		public Decimal ScaleFactor
		{
			get 
			{ 
				return m_ScaleFactor;  
			}
			set 
			{ 
				m_ScaleFactor = value;
			}
		}
		protected Decimal m_ScaleFactor;

		#endregion

		#region Attribute - startParameter
		/// <summary>
		///		Represents a mandatory Element in the XML document
		///		
		/// </summary>
		/// <remarks>
		///		<BR></BR>
		///		<BR>This property is represented as an Element in the XML.</BR>
		///		<BR>It is mandatory and therefore must be populated within the XML.</BR>
		///		<BR>It is defaulted to 0.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("startParameter", "http://www.opengis.net/gml", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_r8, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", -1, -1, "", "", "", "", -1)]
		public Double StartParameter
		{
			get 
			{ 
				return m_StartParameter;  
			}
			set 
			{ 
				m_StartParameter = value;
			}
		}
		protected Double m_StartParameter;

		#endregion

		#region Attribute - endParameter
		/// <summary>
		///		Represents a mandatory Element in the XML document
		///		
		/// </summary>
		/// <remarks>
		///		<BR></BR>
		///		<BR>This property is represented as an Element in the XML.</BR>
		///		<BR>It is mandatory and therefore must be populated within the XML.</BR>
		///		<BR>It is defaulted to 0.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("endParameter", "http://www.opengis.net/gml", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_r8, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", -1, -1, "", "", "", "", -1)]
		public Double EndParameter
		{
			get 
			{ 
				return m_EndParameter;  
			}
			set 
			{ 
				m_EndParameter = value;
			}
		}
		protected Double m_EndParameter;

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


