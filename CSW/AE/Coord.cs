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
	/// 	This class represents the Element coord
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Sequence,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element,
													"coord", "http://www.opengis.net/gml", true, false,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class Coord : CSW.XmlCommonBase
	{
		#region Constructors
		/// <summary>
		///		Constructor for Coord
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public Coord()
		{
			_elementName = "coord";
			Init();
		}
		public Coord(String elementName)
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
			m_X = 0;
			m_Y = 0;
			m_IsValidY = false; 
			m_Z = 0;
			m_IsValidZ = false; 



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
			AE.Coord newObject = new AE.Coord(_elementName);
			newObject.m_X = m_X;
			newObject.m_Y = m_Y;
			newObject.m_IsValidY = m_IsValidY;
			newObject.m_Z = m_Z;
			newObject.m_IsValidZ = m_IsValidZ;


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

		#region Attribute - X
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
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimMnd("X", "http://www.opengis.net/gml", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_decimal, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", -1, -1, "", "", "", "", -1)]
		public Decimal X
		{
			get 
			{ 
				return m_X;  
			}
			set 
			{ 
				m_X = value;
			}
		}
		protected Decimal m_X;

		#endregion

		#region Attribute - Y
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimOpt("Y", "http://www.opengis.net/gml", "IsValidY", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_decimal, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", -1, -1, "", "", "", "", -1)]
		public Decimal Y
		{
			get 
			{ 
				if (m_IsValidY == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property Y is not valid. Set YValid = true");
				return m_Y;  
			}
			set 
			{ 
				m_IsValidY = true;
				m_Y = value;
			}
		}
		/// <summary>
		/// 	Indicates if Y contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for Y is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value (0).</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get Y
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidY
		{
			get
			{
				return m_IsValidY;
			}
			set 
			{ 
				if (value != m_IsValidY)
				{
					Y = 0;
					m_IsValidY = value;
				}
			}
		}
		protected Boolean m_IsValidY;
		protected Decimal m_Y;
		#endregion

		#region Attribute - Z
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimOpt("Z", "http://www.opengis.net/gml", "IsValidZ", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_decimal, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", -1, -1, "", "", "", "", -1)]
		public Decimal Z
		{
			get 
			{ 
				if (m_IsValidZ == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property Z is not valid. Set ZValid = true");
				return m_Z;  
			}
			set 
			{ 
				m_IsValidZ = true;
				m_Z = value;
			}
		}
		/// <summary>
		/// 	Indicates if Z contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for Z is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value (0).</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get Z
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidZ
		{
			get
			{
				return m_IsValidZ;
			}
			set 
			{ 
				if (value != m_IsValidZ)
				{
					Z = 0;
					m_IsValidZ = value;
				}
			}
		}
		protected Boolean m_IsValidZ;
		protected Decimal m_Z;
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


