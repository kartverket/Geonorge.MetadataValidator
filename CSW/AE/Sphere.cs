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
	/// 	This class represents the Element Sphere
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Sequence,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element,
													"Sphere", "http://www.opengis.net/gml", true, true,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class Sphere : CSW.XmlCommonBase
					, AE.IAbstractGriddedSurfaceType
	{
		#region Constructors
		/// <summary>
		///		Constructor for Sphere
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public Sphere()
		{
			_elementName = "Sphere";
			Init();
		}
		public Sphere(String elementName)
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
			m_RowCol = new CSW.XmlObjectCollection<AE.Row>("row", "http://www.opengis.net/gml", 1, -1, false);
			m_Rows = 0;
			m_IsValidRows = false; 
			m_Columns = 0;
			m_IsValidColumns = false; 
			m_HorizontalCurveType = AE.Enumerations.CurveInterpolationType.Linear;
			m_IsValidHorizontalCurveType = false;
			m_VerticalCurveType = AE.Enumerations.CurveInterpolationType.Linear;
			m_IsValidVerticalCurveType = false;



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
			AE.Sphere newObject = new AE.Sphere(_elementName);
			foreach (AE.Row o in m_RowCol)
				newObject.m_RowCol.Add((AE.Row)o.Clone());
			newObject.m_Rows = m_Rows;
			newObject.m_IsValidRows = m_IsValidRows;
			newObject.m_Columns = m_Columns;
			newObject.m_IsValidColumns = m_IsValidColumns;
			newObject.m_HorizontalCurveType = m_HorizontalCurveType;
			newObject.m_IsValidHorizontalCurveType = m_IsValidHorizontalCurveType;
			newObject.m_VerticalCurveType = m_VerticalCurveType;
			newObject.m_IsValidVerticalCurveType = m_IsValidVerticalCurveType;


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

		#region Attribute - row
		/// <summary>
		/// 	A collection of rowCols
		///		
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>This collection may contain 1 to Many objects.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsCol("row", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element)]
		public CSW.XmlObjectCollection<AE.Row> RowCol
		{
			get { return m_RowCol; }
		}
		protected CSW.XmlObjectCollection<AE.Row> m_RowCol;
		
		#endregion

		#region Attribute - rows
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimOpt("rows", "http://www.opengis.net/gml", "IsValidRows", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_integer, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", -1, -1, "", "", "", "", -1)]
		public LiquidTechnologies.Runtime.Net45.BigInteger Rows
		{
			get 
			{ 
				if (m_IsValidRows == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property rows is not valid. Set rowsValid = true");
				return m_Rows;  
			}
			set 
			{ 
				m_IsValidRows = true;
				m_Rows = value;
			}
		}
		/// <summary>
		/// 	Indicates if rows contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for rows is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value (0).</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get rows
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidRows
		{
			get
			{
				return m_IsValidRows;
			}
			set 
			{ 
				if (value != m_IsValidRows)
				{
					Rows = 0;
					m_IsValidRows = value;
				}
			}
		}
		protected Boolean m_IsValidRows;
		protected LiquidTechnologies.Runtime.Net45.BigInteger m_Rows;
		#endregion

		#region Attribute - columns
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimOpt("columns", "http://www.opengis.net/gml", "IsValidColumns", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_integer, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", -1, -1, "", "", "", "", -1)]
		public LiquidTechnologies.Runtime.Net45.BigInteger Columns
		{
			get 
			{ 
				if (m_IsValidColumns == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property columns is not valid. Set columnsValid = true");
				return m_Columns;  
			}
			set 
			{ 
				m_IsValidColumns = true;
				m_Columns = value;
			}
		}
		/// <summary>
		/// 	Indicates if columns contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for columns is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value (0).</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get columns
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidColumns
		{
			get
			{
				return m_IsValidColumns;
			}
			set 
			{ 
				if (value != m_IsValidColumns)
				{
					Columns = 0;
					m_IsValidColumns = value;
				}
			}
		}
		protected Boolean m_IsValidColumns;
		protected LiquidTechnologies.Runtime.Net45.BigInteger m_Columns;
		#endregion

		#region Attribute - horizontalCurveType
		/// <summary>
		///		Represents an optional Attribute in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Attribute in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoEnum("horizontalCurveType", "", "IsValidHorizontalCurveType", typeof(AE.Enumerations), "CurveInterpolationTypeFromString", "CurveInterpolationTypeToString", null)]
		public AE.Enumerations.CurveInterpolationType HorizontalCurveType
		{
			get 
			{ 
				if (m_IsValidHorizontalCurveType == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property horizontalCurveType is not valid. Set horizontalCurveTypeValid = true");
				return m_HorizontalCurveType;  
			}
			set 
			{ 
				m_HorizontalCurveType = value;
				m_IsValidHorizontalCurveType = true;
			}
		}
		/// <summary>
		/// 	Indicates if horizontalCurveType contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for horizontalCurveType is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value (AE.Enumerations.CurveInterpolationType.Linear).</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get horizontalCurveType
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidHorizontalCurveType
		{
			get { return m_IsValidHorizontalCurveType;  }
			set 
			{ 
				if (value != m_IsValidHorizontalCurveType)
				{
					HorizontalCurveType = AE.Enumerations.CurveInterpolationType.Linear;
					m_IsValidHorizontalCurveType = value;
				}
			}
		}
		protected AE.Enumerations.CurveInterpolationType m_HorizontalCurveType;
		protected Boolean m_IsValidHorizontalCurveType;

		#endregion

		#region Attribute - verticalCurveType
		/// <summary>
		///		Represents an optional Attribute in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Attribute in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoEnum("verticalCurveType", "", "IsValidVerticalCurveType", typeof(AE.Enumerations), "CurveInterpolationTypeFromString", "CurveInterpolationTypeToString", null)]
		public AE.Enumerations.CurveInterpolationType VerticalCurveType
		{
			get 
			{ 
				if (m_IsValidVerticalCurveType == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property verticalCurveType is not valid. Set verticalCurveTypeValid = true");
				return m_VerticalCurveType;  
			}
			set 
			{ 
				m_VerticalCurveType = value;
				m_IsValidVerticalCurveType = true;
			}
		}
		/// <summary>
		/// 	Indicates if verticalCurveType contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for verticalCurveType is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value (AE.Enumerations.CurveInterpolationType.Linear).</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get verticalCurveType
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidVerticalCurveType
		{
			get { return m_IsValidVerticalCurveType;  }
			set 
			{ 
				if (value != m_IsValidVerticalCurveType)
				{
					VerticalCurveType = AE.Enumerations.CurveInterpolationType.Linear;
					m_IsValidVerticalCurveType = value;
				}
			}
		}
		protected AE.Enumerations.CurveInterpolationType m_VerticalCurveType;
		protected Boolean m_IsValidVerticalCurveType;

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


