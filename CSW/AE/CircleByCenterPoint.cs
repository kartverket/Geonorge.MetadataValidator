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
	/// 	This class represents the Element CircleByCenterPoint
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Sequence,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element,
													"CircleByCenterPoint", "http://www.opengis.net/gml", false, true,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class CircleByCenterPoint : CSW.XmlCommonBase
					, AE.IArcByCenterPointType
	{
		#region Constructors
		/// <summary>
		///		Constructor for CircleByCenterPoint
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public CircleByCenterPoint()
		{
			_elementName = "CircleByCenterPoint";
			Init();
		}
		public CircleByCenterPoint(String elementName)
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
			m_Interpolation = AE.Enumerations.CurveInterpolationType.Linear;
			m_IsValidInterpolation = false;
			m_NumArc = LiquidTechnologies.Runtime.Net45.Conversions.integerFromString("1", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse);
			m_ArcByCenterPointType_Type_Choice = new AE.ArcByCenterPointType_Type_Choice("ArcByCenterPointType_Type_Choice");
			m_Radius = new AE.LengthType("radius");
			m_StartAngle = null;
			m_EndAngle = null;



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
			AE.CircleByCenterPoint newObject = new AE.CircleByCenterPoint(_elementName);
			newObject.m_NumDerivativesAtStart = m_NumDerivativesAtStart;
			newObject.m_IsValidNumDerivativesAtStart = m_IsValidNumDerivativesAtStart;
			newObject.m_NumDerivativesAtEnd = m_NumDerivativesAtEnd;
			newObject.m_IsValidNumDerivativesAtEnd = m_IsValidNumDerivativesAtEnd;
			newObject.m_NumDerivativeInterior = m_NumDerivativeInterior;
			newObject.m_IsValidNumDerivativeInterior = m_IsValidNumDerivativeInterior;
			newObject.m_Interpolation = m_Interpolation;
			newObject.m_IsValidInterpolation = m_IsValidInterpolation;
			newObject.m_NumArc = m_NumArc;
			newObject.m_ArcByCenterPointType_Type_Choice = null;
			if (m_ArcByCenterPointType_Type_Choice != null)
				newObject.m_ArcByCenterPointType_Type_Choice = (AE.ArcByCenterPointType_Type_Choice)m_ArcByCenterPointType_Type_Choice.Clone();
			newObject.m_Radius = null;
			if (m_Radius != null)
				newObject.m_Radius = (AE.LengthType)m_Radius.Clone();
			newObject.m_StartAngle = null;
			if (m_StartAngle != null)
				newObject.m_StartAngle = (AE.AngleType)m_StartAngle.Clone();
			newObject.m_EndAngle = null;
			if (m_EndAngle != null)
				newObject.m_EndAngle = (AE.AngleType)m_EndAngle.Clone();


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

		#region Attribute - interpolation
		/// <summary>
		///		Represents an optional Attribute in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Attribute in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoEnum("interpolation", "", "IsValidInterpolation", typeof(AE.Enumerations), "CurveInterpolationTypeFromString", "CurveInterpolationTypeToString", null)]
		public AE.Enumerations.CurveInterpolationType Interpolation
		{
			get 
			{ 
				if (m_IsValidInterpolation == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property interpolation is not valid. Set interpolationValid = true");
				return m_Interpolation;  
			}
			set 
			{ 
				m_Interpolation = value;
				m_IsValidInterpolation = true;
			}
		}
		/// <summary>
		/// 	Indicates if interpolation contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for interpolation is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value (AE.Enumerations.CurveInterpolationType.Linear).</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get interpolation
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidInterpolation
		{
			get { return m_IsValidInterpolation;  }
			set 
			{ 
				if (value != m_IsValidInterpolation)
				{
					Interpolation = AE.Enumerations.CurveInterpolationType.Linear;
					m_IsValidInterpolation = value;
				}
			}
		}
		protected AE.Enumerations.CurveInterpolationType m_Interpolation;
		protected Boolean m_IsValidInterpolation;

		#endregion

		#region Attribute - numArc
		/// <summary>
		///		Represents a mandatory Attribute in the XML document
		///		
		/// </summary>
		/// <remarks>
		///		<BR></BR>
		///		<BR>This property is represented as an Attribute in the XML.</BR>
		///		<BR>It is mandatory and therefore must be populated within the XML.</BR>
		///		<BR>It is defaulted to LiquidTechnologies.Runtime.Net45.Conversions.integerFromString("1", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse).</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoPrimitive("numArc", "", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_integer, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, null, "", -1, -1, "", "", "", "", -1)]
		public LiquidTechnologies.Runtime.Net45.BigInteger NumArc
		{
			get 
			{ 
				return m_NumArc;  
			}
			set 
			{ 
				if (m_NumArc != value)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property numArc is marked as read only and may only have the value '" + m_NumArc.ToString() + "'");
			}
		}
		protected LiquidTechnologies.Runtime.Net45.BigInteger m_NumArc;

		#endregion

		#region Attribute - ArcByCenterPointType_Type_Choice
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
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsMnd("ArcByCenterPointType_Type_Choice", "", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement, typeof(AE.ArcByCenterPointType_Type_Choice), false)]
		public AE.ArcByCenterPointType_Type_Choice ArcByCenterPointType_Type_Choice
		{
			get 
			{ 
				return m_ArcByCenterPointType_Type_Choice;  
			}
			set 
			{ 
				Throw_IfPropertyIsNull(value, "ArcByCenterPointType_Type_Choice");
				m_ArcByCenterPointType_Type_Choice = value;
			}
		}
		protected AE.ArcByCenterPointType_Type_Choice m_ArcByCenterPointType_Type_Choice;
		
		#endregion

		#region Attribute - radius
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
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsMnd("radius", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.LengthType), false)]
		public AE.LengthType Radius
		{
			get 
			{ 
				return m_Radius;  
			}
			set 
			{ 
				Throw_IfPropertyIsNull(value, "radius");
				if (value != null)
					SetElementName(value, "radius");
				m_Radius = value;
			}
		}
		protected AE.LengthType m_Radius;
		
		#endregion

		#region Attribute - startAngle
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsOpt("startAngle", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.AngleType))]
		public AE.AngleType StartAngle
		{
			get 
			{ 
				return m_StartAngle;  
			}
			set 
			{ 
				if (value == null)
					m_StartAngle = null;
				else
				{
					SetElementName(value, "startAngle");
					m_StartAngle = value; 
				}
			}
		}
		protected AE.AngleType m_StartAngle;
		
		#endregion

		#region Attribute - endAngle
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsOpt("endAngle", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.AngleType))]
		public AE.AngleType EndAngle
		{
			get 
			{ 
				return m_EndAngle;  
			}
			set 
			{ 
				if (value == null)
					m_EndAngle = null;
				else
				{
					SetElementName(value, "endAngle");
					m_EndAngle = value; 
				}
			}
		}
		protected AE.AngleType m_EndAngle;
		
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


