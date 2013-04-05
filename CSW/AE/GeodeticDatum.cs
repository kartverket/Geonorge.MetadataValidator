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
	/// 	This class represents the Element GeodeticDatum
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Sequence,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element,
													"GeodeticDatum", "http://www.opengis.net/gml", false, true,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class GeodeticDatum : CSW.XmlCommonBase
					, AE.IAbstractDatumType
	{
		#region Constructors
		/// <summary>
		///		Constructor for GeodeticDatum
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public GeodeticDatum()
		{
			_elementName = "GeodeticDatum";
			Init();
		}
		public GeodeticDatum(String elementName)
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
			m_DatumIDCol = new CSW.XmlObjectCollection<AE.DatumID>("datumID", "http://www.opengis.net/gml", 0, -1, false);
			m_Remarks = null;
			m_AnchorPoint = null;
			m_RealizationEpoch = new LiquidTechnologies.Runtime.Net45.XmlDateTime(LiquidTechnologies.Runtime.Net45.XmlDateTime.DateType.date);
			m_IsValidRealizationEpoch = false; 
			m_ValidArea = null;
			m_Scope = "";
			m_IsValidScope = false; 
			m_UsesPrimeMeridian = new AE.UsesPrimeMeridian("usesPrimeMeridian");
			m_UsesEllipsoid = new AE.UsesEllipsoid("usesEllipsoid");



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
			AE.GeodeticDatum newObject = new AE.GeodeticDatum(_elementName);
			newObject.m_Id = m_Id;
			newObject.m_IsValidId = m_IsValidId;
			foreach (AE.MetaDataProperty o in m_MetaDataPropertyCol)
				newObject.m_MetaDataPropertyCol.Add((AE.MetaDataProperty)o.Clone());
			newObject.m_Description = null;
			if (m_Description != null)
				newObject.m_Description = (AE.Description)m_Description.Clone();
			foreach (AE.SubGrpname o in m_NameCol)
				newObject.m_NameCol.Add((AE.SubGrpname)o.Clone());
			foreach (AE.DatumID o in m_DatumIDCol)
				newObject.m_DatumIDCol.Add((AE.DatumID)o.Clone());
			newObject.m_Remarks = null;
			if (m_Remarks != null)
				newObject.m_Remarks = (AE.Remarks)m_Remarks.Clone();
			newObject.m_AnchorPoint = null;
			if (m_AnchorPoint != null)
				newObject.m_AnchorPoint = (AE.ICodeType)m_AnchorPoint.Clone();
			newObject.m_RealizationEpoch = (LiquidTechnologies.Runtime.Net45.XmlDateTime)m_RealizationEpoch.Clone();
			newObject.m_IsValidRealizationEpoch = m_IsValidRealizationEpoch;
			newObject.m_ValidArea = null;
			if (m_ValidArea != null)
				newObject.m_ValidArea = (AE.ValidArea)m_ValidArea.Clone();
			newObject.m_Scope = m_Scope;
			newObject.m_IsValidScope = m_IsValidScope;
			newObject.m_UsesPrimeMeridian = null;
			if (m_UsesPrimeMeridian != null)
				newObject.m_UsesPrimeMeridian = (AE.UsesPrimeMeridian)m_UsesPrimeMeridian.Clone();
			newObject.m_UsesEllipsoid = null;
			if (m_UsesEllipsoid != null)
				newObject.m_UsesEllipsoid = (AE.UsesEllipsoid)m_UsesEllipsoid.Clone();


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

		#region Attribute - datumID
		/// <summary>
		/// 	A collection of datumIDCols
		///		
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>This collection may contain 0 to Many objects.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsCol("datumID", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element)]
		public CSW.XmlObjectCollection<AE.DatumID> DatumIDCol
		{
			get { return m_DatumIDCol; }
		}
		protected CSW.XmlObjectCollection<AE.DatumID> m_DatumIDCol;
		
		#endregion

		#region Attribute - remarks
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsOpt("remarks", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.Remarks))]
		public AE.Remarks Remarks
		{
			get 
			{ 
				return m_Remarks;  
			}
			set 
			{ 
				if (value == null)
					m_Remarks = null;
				else
				{
					m_Remarks = value; 
				}
			}
		}
		protected AE.Remarks m_Remarks;
		
		#endregion

		#region Attribute - anchorPoint
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqAbsClsOpt("anchorPoint", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.ClassFactory), "ICodeTypeCreateObject")]
		public AE.ICodeType AnchorPoint
		{
			get 
			{ 
				return m_AnchorPoint;  
			}
			set 
			{ 
				if (value == null)
					m_AnchorPoint = null;
				else
				{
					m_AnchorPoint = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "anchorPoint");
				}
			}
		}
		protected AE.ICodeType m_AnchorPoint;

		#endregion

		#region Attribute - realizationEpoch
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimOpt("realizationEpoch", "http://www.opengis.net/gml", "IsValidRealizationEpoch", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_date, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", -1, -1, "", "", "", "", -1)]
		public LiquidTechnologies.Runtime.Net45.XmlDateTime RealizationEpoch
		{
			get 
			{ 
				if (m_IsValidRealizationEpoch == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property realizationEpoch is not valid. Set realizationEpochValid = true");
				return m_RealizationEpoch;  
			}
			set 
			{ 
				m_IsValidRealizationEpoch = true;
				m_RealizationEpoch.SetDateTime(value, m_RealizationEpoch.Type); 
			}
		}
		/// <summary>
		/// 	Indicates if realizationEpoch contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for realizationEpoch is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value (new LiquidTechnologies.Runtime.Net45.XmlDateTime(LiquidTechnologies.Runtime.Net45.XmlDateTime.DateType.date)).</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get realizationEpoch
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidRealizationEpoch
		{
			get
			{
				return m_IsValidRealizationEpoch;
			}
			set 
			{ 
				if (value != m_IsValidRealizationEpoch)
				{
					RealizationEpoch = new LiquidTechnologies.Runtime.Net45.XmlDateTime(LiquidTechnologies.Runtime.Net45.XmlDateTime.DateType.date);
					m_IsValidRealizationEpoch = value;
				}
			}
		}
		protected Boolean m_IsValidRealizationEpoch;
		protected LiquidTechnologies.Runtime.Net45.XmlDateTime m_RealizationEpoch;
		#endregion

		#region Attribute - validArea
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsOpt("validArea", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.ValidArea))]
		public AE.ValidArea ValidArea
		{
			get 
			{ 
				return m_ValidArea;  
			}
			set 
			{ 
				if (value == null)
					m_ValidArea = null;
				else
				{
					m_ValidArea = value; 
				}
			}
		}
		protected AE.ValidArea m_ValidArea;
		
		#endregion

		#region Attribute - scope
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimOpt("scope", "http://www.opengis.net/gml", "IsValidScope", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", -1, -1, "", "", "", "", -1)]
		public String Scope
		{
			get 
			{ 
				if (m_IsValidScope == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property scope is not valid. Set scopeValid = true");
				return m_Scope;  
			}
			set 
			{ 
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				m_IsValidScope = true;
				m_Scope = value;
			}
		}
		/// <summary>
		/// 	Indicates if scope contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for scope is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value ("").</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get scope
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidScope
		{
			get
			{
				return m_IsValidScope;
			}
			set 
			{ 
				if (value != m_IsValidScope)
				{
					Scope = "";
					m_IsValidScope = value;
				}
			}
		}
		protected Boolean m_IsValidScope;
		protected String m_Scope;
		#endregion

		#region Attribute - usesPrimeMeridian
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
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsMnd("usesPrimeMeridian", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.UsesPrimeMeridian), false)]
		public AE.UsesPrimeMeridian UsesPrimeMeridian
		{
			get 
			{ 
				return m_UsesPrimeMeridian;  
			}
			set 
			{ 
				Throw_IfPropertyIsNull(value, "usesPrimeMeridian");
				m_UsesPrimeMeridian = value;
			}
		}
		protected AE.UsesPrimeMeridian m_UsesPrimeMeridian;
		
		#endregion

		#region Attribute - usesEllipsoid
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
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsMnd("usesEllipsoid", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.UsesEllipsoid), false)]
		public AE.UsesEllipsoid UsesEllipsoid
		{
			get 
			{ 
				return m_UsesEllipsoid;  
			}
			set 
			{ 
				Throw_IfPropertyIsNull(value, "usesEllipsoid");
				m_UsesEllipsoid = value;
			}
		}
		protected AE.UsesEllipsoid m_UsesEllipsoid;
		
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


