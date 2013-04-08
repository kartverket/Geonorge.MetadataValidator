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
	/// 	This class represents the ComplexType FormulaType
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Sequence,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element,
													"FormulaType", "http://www.opengis.net/gml", true, false,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class FormulaType : CSW.XmlCommonBase
	{
		#region Constructors
		/// <summary>
		///		Constructor for FormulaType
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public FormulaType()
		{
			_elementName = "FormulaType";
			Init();
		}
		public FormulaType(String elementName)
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
			m_A = 0;
			m_IsValidA = false; 
			m_B = 0;
			m_C = 0;
			m_D = 0;
			m_IsValidD = false; 



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
			AE.FormulaType newObject = new AE.FormulaType(_elementName);
			newObject.m_A = m_A;
			newObject.m_IsValidA = m_IsValidA;
			newObject.m_B = m_B;
			newObject.m_C = m_C;
			newObject.m_D = m_D;
			newObject.m_IsValidD = m_IsValidD;


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

		#region Attribute - a
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimOpt("a", "http://www.opengis.net/gml", "IsValidA", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_r8, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", -1, -1, "", "", "", "", -1)]
		public Double A
		{
			get 
			{ 
				if (m_IsValidA == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property a is not valid. Set aValid = true");
				return m_A;  
			}
			set 
			{ 
				m_IsValidA = true;
				m_A = value;
			}
		}
		/// <summary>
		/// 	Indicates if a contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for a is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value (0).</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get a
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidA
		{
			get
			{
				return m_IsValidA;
			}
			set 
			{ 
				if (value != m_IsValidA)
				{
					A = 0;
					m_IsValidA = value;
				}
			}
		}
		protected Boolean m_IsValidA;
		protected Double m_A;
		#endregion

		#region Attribute - b
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
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("b", "http://www.opengis.net/gml", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_r8, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", -1, -1, "", "", "", "", -1)]
		public Double B
		{
			get 
			{ 
				return m_B;  
			}
			set 
			{ 
				m_B = value;
			}
		}
		protected Double m_B;

		#endregion

		#region Attribute - c
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
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("c", "http://www.opengis.net/gml", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_r8, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", -1, -1, "", "", "", "", -1)]
		public Double C
		{
			get 
			{ 
				return m_C;  
			}
			set 
			{ 
				m_C = value;
			}
		}
		protected Double m_C;

		#endregion

		#region Attribute - d
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimOpt("d", "http://www.opengis.net/gml", "IsValidD", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_r8, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", -1, -1, "", "", "", "", -1)]
		public Double D
		{
			get 
			{ 
				if (m_IsValidD == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property d is not valid. Set dValid = true");
				return m_D;  
			}
			set 
			{ 
				m_IsValidD = true;
				m_D = value;
			}
		}
		/// <summary>
		/// 	Indicates if d contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for d is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value (0).</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get d
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidD
		{
			get
			{
				return m_IsValidD;
			}
			set 
			{ 
				if (value != m_IsValidD)
				{
					D = 0;
					m_IsValidD = value;
				}
			}
		}
		protected Boolean m_IsValidD;
		protected Double m_D;
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


