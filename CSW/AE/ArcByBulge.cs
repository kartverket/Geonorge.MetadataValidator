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
	/// 	This class represents the Element ArcByBulge
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Sequence,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element,
													"ArcByBulge", "http://www.opengis.net/gml", false, true,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class ArcByBulge : CSW.XmlCommonBase
					, AE.IArcStringByBulgeType
	{
		#region Constructors
		/// <summary>
		///		Constructor for ArcByBulge
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public ArcByBulge()
		{
			_elementName = "ArcByBulge";
			Init();
		}
		public ArcByBulge(String elementName)
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
			m_NumArc = 0;
			m_IsValidNumArc = false;
			m_ArcStringByBulgeType_Type_Choice = new AE.ArcStringByBulgeType_Type_Choice("ArcStringByBulgeType_Type_Choice");
			m_BulgeCol = new CSW.XmlSimpleTypeCollection<Double>("bulge", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_r8, 1, -1, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, new LiquidTechnologies.Runtime.Net45.PrimitiveRestrictions("", -1, -1, "", "", "", "", -1));
			m_NormalCol = new CSW.XmlObjectCollection<AE.VectorType>("normal", "http://www.opengis.net/gml", 1, -1, false);



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
			AE.ArcByBulge newObject = new AE.ArcByBulge(_elementName);
			newObject.m_NumDerivativesAtStart = m_NumDerivativesAtStart;
			newObject.m_IsValidNumDerivativesAtStart = m_IsValidNumDerivativesAtStart;
			newObject.m_NumDerivativesAtEnd = m_NumDerivativesAtEnd;
			newObject.m_IsValidNumDerivativesAtEnd = m_IsValidNumDerivativesAtEnd;
			newObject.m_NumDerivativeInterior = m_NumDerivativeInterior;
			newObject.m_IsValidNumDerivativeInterior = m_IsValidNumDerivativeInterior;
			newObject.m_Interpolation = m_Interpolation;
			newObject.m_IsValidInterpolation = m_IsValidInterpolation;
			newObject.m_NumArc = m_NumArc;
			newObject.m_IsValidNumArc = m_IsValidNumArc;
			newObject.m_ArcStringByBulgeType_Type_Choice = null;
			if (m_ArcStringByBulgeType_Type_Choice != null)
				newObject.m_ArcStringByBulgeType_Type_Choice = (AE.ArcStringByBulgeType_Type_Choice)m_ArcStringByBulgeType_Type_Choice.Clone();
			foreach (Double o in m_BulgeCol)
				newObject.m_BulgeCol.Add(o);
			foreach (AE.VectorType o in m_NormalCol)
				newObject.m_NormalCol.Add((AE.VectorType)o.Clone());


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
		///		Represents an optional Attribute in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Attribute in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoPrimitive("numArc", "", "IsValidNumArc", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_integer, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, null, "", -1, -1, "", "", "", "", -1)]
		public LiquidTechnologies.Runtime.Net45.BigInteger NumArc
		{
			get 
			{ 
				if (m_IsValidNumArc == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property numArc is not valid. Set numArcValid = true");
				return m_NumArc;  
			}
			set 
			{ 
				m_IsValidNumArc = true;
				m_NumArc = value;
			}
		}
		/// <summary>
		/// 	Indicates if numArc contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for numArc is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value (0).</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get numArc
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidNumArc
		{
			get
			{
				return m_IsValidNumArc;
			}
			set 
			{ 
				if (value != m_IsValidNumArc)
				{
					NumArc = 0;
					m_IsValidNumArc = value;
				}
			}
		}
		protected Boolean m_IsValidNumArc;
		protected LiquidTechnologies.Runtime.Net45.BigInteger m_NumArc;
		#endregion

		#region Attribute - ArcStringByBulgeType_Type_Choice
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
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsMnd("ArcStringByBulgeType_Type_Choice", "", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement, typeof(AE.ArcStringByBulgeType_Type_Choice), true)]
		public AE.ArcStringByBulgeType_Type_Choice ArcStringByBulgeType_Type_Choice
		{
			get 
			{ 
				return m_ArcStringByBulgeType_Type_Choice;  
			}
			set 
			{ 
				Throw_IfPropertyIsNull(value, "ArcStringByBulgeType_Type_Choice");
				m_ArcStringByBulgeType_Type_Choice = value;
			}
		}
		protected AE.ArcStringByBulgeType_Type_Choice m_ArcStringByBulgeType_Type_Choice;
		
		#endregion

		#region Attribute - bulge
		/// <summary>
		///		A collection of Doubles
		///		
		/// </summary>
		/// <remarks>
		///		<BR></BR>
		///		<BR>This property is represented as an Element in the XML.</BR>
		///		<BR>This collection may contain 1 to Many Doubles.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimCol("bulge", "http://www.opengis.net/gml")]
		public CSW.XmlSimpleTypeCollection<Double> BulgeCol
		{
			get { return m_BulgeCol; }
		}
		protected CSW.XmlSimpleTypeCollection<Double> m_BulgeCol;

		#endregion

		#region Attribute - normal
		/// <summary>
		/// 	A collection of normalCols
		///		
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>This collection may contain 1 to Many objects.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsCol("normal", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element)]
		public CSW.XmlObjectCollection<AE.VectorType> NormalCol
		{
			get { return m_NormalCol; }
		}
		protected CSW.XmlObjectCollection<AE.VectorType> m_NormalCol;
		
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


