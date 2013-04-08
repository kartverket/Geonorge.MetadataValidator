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
	/// 	This class represents the Element MultiGeometry
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Sequence,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element,
													"MultiGeometry", "http://www.opengis.net/gml", false, true,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class MultiGeometry : CSW.XmlCommonBase
					, AE.IAbstractGeometricAggregateType
	{
		#region Constructors
		/// <summary>
		///		Constructor for MultiGeometry
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public MultiGeometry()
		{
			_elementName = "MultiGeometry";
			Init();
		}
		public MultiGeometry(String elementName)
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
			m_Id = "";
			m_IsValidId = false;
			m_MetaDataPropertyCol = new CSW.XmlObjectCollection<AE.MetaDataProperty>("metaDataProperty", "http://www.opengis.net/gml", 0, -1, false);
			m_Description = null;
			m_NameCol = new CSW.XmlObjectCollection<AE.SubGrpname>("name", "http://www.opengis.net/gml", 0, -1, true);
			m_Gid = "";
			m_IsValidGid = false;
			m_SrsName = "";
			m_IsValidSrsName = false;
			m_SrsDimension = 0;
			m_IsValidSrsDimension = false;
			m_AxisLabels = "";
			m_IsValidAxisLabels = false;
			m_UomLabels = "";
			m_IsValidUomLabels = false;
			m_GeometryMemberCol = new CSW.XmlObjectCollection<AE.GeometryMember>("geometryMember", "http://www.opengis.net/gml", 0, -1, false);
			m_GeometryMembers = null;



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
			AE.MultiGeometry newObject = new AE.MultiGeometry(_elementName);
			newObject.m_Id = m_Id;
			newObject.m_IsValidId = m_IsValidId;
			foreach (AE.MetaDataProperty o in m_MetaDataPropertyCol)
				newObject.m_MetaDataPropertyCol.Add((AE.MetaDataProperty)o.Clone());
			newObject.m_Description = null;
			if (m_Description != null)
				newObject.m_Description = (AE.Description)m_Description.Clone();
			foreach (AE.SubGrpname o in m_NameCol)
				newObject.m_NameCol.Add((AE.SubGrpname)o.Clone());
			newObject.m_Gid = m_Gid;
			newObject.m_IsValidGid = m_IsValidGid;
			newObject.m_SrsName = m_SrsName;
			newObject.m_IsValidSrsName = m_IsValidSrsName;
			newObject.m_SrsDimension = m_SrsDimension;
			newObject.m_IsValidSrsDimension = m_IsValidSrsDimension;
			newObject.m_AxisLabels = m_AxisLabels;
			newObject.m_IsValidAxisLabels = m_IsValidAxisLabels;
			newObject.m_UomLabels = m_UomLabels;
			newObject.m_IsValidUomLabels = m_IsValidUomLabels;
			foreach (AE.GeometryMember o in m_GeometryMemberCol)
				newObject.m_GeometryMemberCol.Add((AE.GeometryMember)o.Clone());
			newObject.m_GeometryMembers = null;
			if (m_GeometryMembers != null)
				newObject.m_GeometryMembers = (AE.GeometryMembers)m_GeometryMembers.Clone();


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

		#region Attribute - id
		/// <summary>
		///		Represents an optional Attribute in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Attribute in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoPrimitive("id", "http://www.opengis.net/gml", "IsValidId", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, null, "", -1, -1, "", "", "", "", -1)]
		public String Id
		{
			get 
			{ 
				if (m_IsValidId == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property id is not valid. Set idValid = true");
				return m_Id;  
			}
			set 
			{ 
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Collapse(value); 
				m_IsValidId = true;
				m_Id = value;
			}
		}
		/// <summary>
		/// 	Indicates if id contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for id is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value ("").</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get id
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidId
		{
			get
			{
				return m_IsValidId;
			}
			set 
			{ 
				if (value != m_IsValidId)
				{
					Id = "";
					m_IsValidId = value;
				}
			}
		}
		protected Boolean m_IsValidId;
		protected String m_Id;
		#endregion

		#region Attribute - metaDataProperty
		/// <summary>
		/// 	A collection of metaDataPropertyCols
		///		
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>This collection may contain 0 to Many objects.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsCol("metaDataProperty", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element)]
		public CSW.XmlObjectCollection<AE.MetaDataProperty> MetaDataPropertyCol
		{
			get { return m_MetaDataPropertyCol; }
		}
		protected CSW.XmlObjectCollection<AE.MetaDataProperty> m_MetaDataPropertyCol;
		
		#endregion

		#region Attribute - description
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsOpt("description", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.Description))]
		public AE.Description Description
		{
			get 
			{ 
				return m_Description;  
			}
			set 
			{ 
				if (value == null)
					m_Description = null;
				else
				{
					m_Description = value; 
				}
			}
		}
		protected AE.Description m_Description;
		
		#endregion

		#region Attribute - name
		/// <summary>
		/// 	A collection of nameCols
		///		
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>This collection may contain 0 to Many objects.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsCol("name", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement)]
		public CSW.XmlObjectCollection<AE.SubGrpname> NameCol
		{
			get { return m_NameCol; }
		}
		protected CSW.XmlObjectCollection<AE.SubGrpname> m_NameCol;
		
		#endregion

		#region Attribute - gid
		/// <summary>
		///		Represents an optional Attribute in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Attribute in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoPrimitive("gid", "", "IsValidGid", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, null, "", -1, -1, "", "", "", "", -1)]
		public String Gid
		{
			get 
			{ 
				if (m_IsValidGid == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property gid is not valid. Set gidValid = true");
				return m_Gid;  
			}
			set 
			{ 
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				m_IsValidGid = true;
				m_Gid = value;
			}
		}
		/// <summary>
		/// 	Indicates if gid contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for gid is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value ("").</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get gid
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidGid
		{
			get
			{
				return m_IsValidGid;
			}
			set 
			{ 
				if (value != m_IsValidGid)
				{
					Gid = "";
					m_IsValidGid = value;
				}
			}
		}
		protected Boolean m_IsValidGid;
		protected String m_Gid;
		#endregion

		#region Attribute - srsName
		/// <summary>
		///		Represents an optional Attribute in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Attribute in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoPrimitive("srsName", "", "IsValidSrsName", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, null, "", -1, -1, "", "", "", "", -1)]
		public String SrsName
		{
			get 
			{ 
				if (m_IsValidSrsName == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property srsName is not valid. Set srsNameValid = true");
				return m_SrsName;  
			}
			set 
			{ 
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Collapse(value); 
				m_IsValidSrsName = true;
				m_SrsName = value;
			}
		}
		/// <summary>
		/// 	Indicates if srsName contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for srsName is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value ("").</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get srsName
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidSrsName
		{
			get
			{
				return m_IsValidSrsName;
			}
			set 
			{ 
				if (value != m_IsValidSrsName)
				{
					SrsName = "";
					m_IsValidSrsName = value;
				}
			}
		}
		protected Boolean m_IsValidSrsName;
		protected String m_SrsName;
		#endregion

		#region Attribute - srsDimension
		/// <summary>
		///		Represents an optional Attribute in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Attribute in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoPrimitive("srsDimension", "", "IsValidSrsDimension", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_integer, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, null, "", -1, -1, "", "", "", "", -1)]
		public LiquidTechnologies.Runtime.Net45.BigInteger SrsDimension
		{
			get 
			{ 
				if (m_IsValidSrsDimension == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property srsDimension is not valid. Set srsDimensionValid = true");
				return m_SrsDimension;  
			}
			set 
			{ 
				m_IsValidSrsDimension = true;
				m_SrsDimension = value;
			}
		}
		/// <summary>
		/// 	Indicates if srsDimension contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for srsDimension is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value (0).</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get srsDimension
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidSrsDimension
		{
			get
			{
				return m_IsValidSrsDimension;
			}
			set 
			{ 
				if (value != m_IsValidSrsDimension)
				{
					SrsDimension = 0;
					m_IsValidSrsDimension = value;
				}
			}
		}
		protected Boolean m_IsValidSrsDimension;
		protected LiquidTechnologies.Runtime.Net45.BigInteger m_SrsDimension;
		#endregion

		#region Attribute - axisLabels
		/// <summary>
		///		Represents an optional Attribute in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Attribute in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoPrimitive("axisLabels", "", "IsValidAxisLabels", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, null, "", -1, -1, "", "", "", "", -1)]
		public String AxisLabels
		{
			get 
			{ 
				if (m_IsValidAxisLabels == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property axisLabels is not valid. Set axisLabelsValid = true");
				return m_AxisLabels;  
			}
			set 
			{ 
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Collapse(value); 
				m_IsValidAxisLabels = true;
				m_AxisLabels = value;
			}
		}
		/// <summary>
		/// 	Indicates if axisLabels contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for axisLabels is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value ("").</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get axisLabels
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidAxisLabels
		{
			get
			{
				return m_IsValidAxisLabels;
			}
			set 
			{ 
				if (value != m_IsValidAxisLabels)
				{
					AxisLabels = "";
					m_IsValidAxisLabels = value;
				}
			}
		}
		protected Boolean m_IsValidAxisLabels;
		protected String m_AxisLabels;
		#endregion

		#region Attribute - uomLabels
		/// <summary>
		///		Represents an optional Attribute in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Attribute in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoPrimitive("uomLabels", "", "IsValidUomLabels", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, null, "", -1, -1, "", "", "", "", -1)]
		public String UomLabels
		{
			get 
			{ 
				if (m_IsValidUomLabels == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property uomLabels is not valid. Set uomLabelsValid = true");
				return m_UomLabels;  
			}
			set 
			{ 
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Collapse(value); 
				m_IsValidUomLabels = true;
				m_UomLabels = value;
			}
		}
		/// <summary>
		/// 	Indicates if uomLabels contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for uomLabels is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value ("").</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get uomLabels
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidUomLabels
		{
			get
			{
				return m_IsValidUomLabels;
			}
			set 
			{ 
				if (value != m_IsValidUomLabels)
				{
					UomLabels = "";
					m_IsValidUomLabels = value;
				}
			}
		}
		protected Boolean m_IsValidUomLabels;
		protected String m_UomLabels;
		#endregion

		#region Attribute - geometryMember
		/// <summary>
		/// 	A collection of geometryMemberCols
		///		
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>This collection may contain 0 to Many objects.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsCol("geometryMember", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element)]
		public CSW.XmlObjectCollection<AE.GeometryMember> GeometryMemberCol
		{
			get { return m_GeometryMemberCol; }
		}
		protected CSW.XmlObjectCollection<AE.GeometryMember> m_GeometryMemberCol;
		
		#endregion

		#region Attribute - geometryMembers
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsOpt("geometryMembers", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.GeometryMembers))]
		public AE.GeometryMembers GeometryMembers
		{
			get 
			{ 
				return m_GeometryMembers;  
			}
			set 
			{ 
				if (value == null)
					m_GeometryMembers = null;
				else
				{
					m_GeometryMembers = value; 
				}
			}
		}
		protected AE.GeometryMembers m_GeometryMembers;
		
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


