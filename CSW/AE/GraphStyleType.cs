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
	/// 	This class represents the ComplexType GraphStyleType
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Sequence,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element,
													"GraphStyleType", "http://www.opengis.net/gml", false, true,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class GraphStyleType : CSW.XmlCommonBase
					, AE.IBaseStyleDescriptorType
	{
		#region Constructors
		/// <summary>
		///		Constructor for GraphStyleType
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public GraphStyleType()
		{
			_elementName = "GraphStyleType";
			Init();
		}
		public GraphStyleType(String elementName)
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
			m_SpatialResolution = null;
			m_StyleVariationCol = new CSW.XmlObjectCollection<AE.StyleVariationType>("styleVariation", "http://www.opengis.net/gml", 0, -1, false);
			m_AnimateCol = new CSW.XmlObjectCollection<AF.Animate>("animate", "http://www.w3.org/2001/SMIL20/", 0, -1, false);
			m_AnimateMotionCol = new CSW.XmlObjectCollection<AF.AnimateMotion>("animateMotion", "http://www.w3.org/2001/SMIL20/", 0, -1, false);
			m_AnimateColorCol = new CSW.XmlObjectCollection<AF.AnimateColor>("animateColor", "http://www.w3.org/2001/SMIL20/", 0, -1, false);
			m_SetCol = new CSW.XmlObjectCollection<AF.Set>("set", "http://www.w3.org/2001/SMIL20/", 0, -1, false);
			m_Planar = false;
			m_IsValidPlanar = false; 
			m_Directed = false;
			m_IsValidDirected = false; 
			m_Grid = false;
			m_IsValidGrid = false; 
			m_MinDistance = 0;
			m_IsValidMinDistance = false; 
			m_MinAngle = 0;
			m_IsValidMinAngle = false; 
			m_GraphType = AE.Enumerations.GraphTypeType.TREE;
			m_IsValidGraphType = false;
			m_DrawingType = AE.Enumerations.DrawingTypeType.POLYLINE;
			m_IsValidDrawingType = false;
			m_LineType = AE.Enumerations.LineTypeType.STRAIGHT;
			m_IsValidLineType = false;
			m_AestheticCriteriaCol = new CSW.XmlEnumTypeCollection<AE.Enumerations.AesheticCriteriaType>("aestheticCriteria", "http://www.opengis.net/gml", 0, -1, typeof(AE.Enumerations), "AesheticCriteriaTypeFromString", "AesheticCriteriaTypeToString");



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
			AE.GraphStyleType newObject = new AE.GraphStyleType(_elementName);
			newObject.m_Id = m_Id;
			newObject.m_IsValidId = m_IsValidId;
			foreach (AE.MetaDataProperty o in m_MetaDataPropertyCol)
				newObject.m_MetaDataPropertyCol.Add((AE.MetaDataProperty)o.Clone());
			newObject.m_Description = null;
			if (m_Description != null)
				newObject.m_Description = (AE.Description)m_Description.Clone();
			foreach (AE.SubGrpname o in m_NameCol)
				newObject.m_NameCol.Add((AE.SubGrpname)o.Clone());
			newObject.m_SpatialResolution = null;
			if (m_SpatialResolution != null)
				newObject.m_SpatialResolution = (AE.ScaleType)m_SpatialResolution.Clone();
			foreach (AE.StyleVariationType o in m_StyleVariationCol)
				newObject.m_StyleVariationCol.Add((AE.StyleVariationType)o.Clone());
			foreach (AF.Animate o in m_AnimateCol)
				newObject.m_AnimateCol.Add((AF.Animate)o.Clone());
			foreach (AF.AnimateMotion o in m_AnimateMotionCol)
				newObject.m_AnimateMotionCol.Add((AF.AnimateMotion)o.Clone());
			foreach (AF.AnimateColor o in m_AnimateColorCol)
				newObject.m_AnimateColorCol.Add((AF.AnimateColor)o.Clone());
			foreach (AF.Set o in m_SetCol)
				newObject.m_SetCol.Add((AF.Set)o.Clone());
			newObject.m_Planar = m_Planar;
			newObject.m_IsValidPlanar = m_IsValidPlanar;
			newObject.m_Directed = m_Directed;
			newObject.m_IsValidDirected = m_IsValidDirected;
			newObject.m_Grid = m_Grid;
			newObject.m_IsValidGrid = m_IsValidGrid;
			newObject.m_MinDistance = m_MinDistance;
			newObject.m_IsValidMinDistance = m_IsValidMinDistance;
			newObject.m_MinAngle = m_MinAngle;
			newObject.m_IsValidMinAngle = m_IsValidMinAngle;
			newObject.m_GraphType = m_GraphType;
			newObject.m_IsValidGraphType = m_IsValidGraphType;
			newObject.m_DrawingType = m_DrawingType;
			newObject.m_IsValidDrawingType = m_IsValidDrawingType;
			newObject.m_LineType = m_LineType;
			newObject.m_IsValidLineType = m_IsValidLineType;
			foreach (AE.Enumerations.AesheticCriteriaType o in m_AestheticCriteriaCol)
				newObject.m_AestheticCriteriaCol.Add(o);


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

		#region Attribute - spatialResolution
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsOpt("spatialResolution", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.ScaleType))]
		public AE.ScaleType SpatialResolution
		{
			get 
			{ 
				return m_SpatialResolution;  
			}
			set 
			{ 
				if (value == null)
					m_SpatialResolution = null;
				else
				{
					SetElementName(value, "spatialResolution");
					m_SpatialResolution = value; 
				}
			}
		}
		protected AE.ScaleType m_SpatialResolution;
		
		#endregion

		#region Attribute - styleVariation
		/// <summary>
		/// 	A collection of styleVariationCols
		///		
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>This collection may contain 0 to Many objects.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsCol("styleVariation", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element)]
		public CSW.XmlObjectCollection<AE.StyleVariationType> StyleVariationCol
		{
			get { return m_StyleVariationCol; }
		}
		protected CSW.XmlObjectCollection<AE.StyleVariationType> m_StyleVariationCol;
		
		#endregion

		#region Attribute - animate
		/// <summary>
		/// 	A collection of animateCols
		///		
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>This collection may contain 0 to Many objects.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsCol("animate", "http://www.w3.org/2001/SMIL20/", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element)]
		public CSW.XmlObjectCollection<AF.Animate> AnimateCol
		{
			get { return m_AnimateCol; }
		}
		protected CSW.XmlObjectCollection<AF.Animate> m_AnimateCol;
		
		#endregion

		#region Attribute - animateMotion
		/// <summary>
		/// 	A collection of animateMotionCols
		///		
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>This collection may contain 0 to Many objects.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsCol("animateMotion", "http://www.w3.org/2001/SMIL20/", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element)]
		public CSW.XmlObjectCollection<AF.AnimateMotion> AnimateMotionCol
		{
			get { return m_AnimateMotionCol; }
		}
		protected CSW.XmlObjectCollection<AF.AnimateMotion> m_AnimateMotionCol;
		
		#endregion

		#region Attribute - animateColor
		/// <summary>
		/// 	A collection of animateColorCols
		///		
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>This collection may contain 0 to Many objects.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsCol("animateColor", "http://www.w3.org/2001/SMIL20/", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element)]
		public CSW.XmlObjectCollection<AF.AnimateColor> AnimateColorCol
		{
			get { return m_AnimateColorCol; }
		}
		protected CSW.XmlObjectCollection<AF.AnimateColor> m_AnimateColorCol;
		
		#endregion

		#region Attribute - set
		/// <summary>
		/// 	A collection of setCols
		///		
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>This collection may contain 0 to Many objects.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsCol("set", "http://www.w3.org/2001/SMIL20/", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element)]
		public CSW.XmlObjectCollection<AF.Set> SetCol
		{
			get { return m_SetCol; }
		}
		protected CSW.XmlObjectCollection<AF.Set> m_SetCol;
		
		#endregion

		#region Attribute - planar
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimOpt("planar", "http://www.opengis.net/gml", "IsValidPlanar", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_boolean, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", -1, -1, "", "", "", "", -1)]
		public Boolean Planar
		{
			get 
			{ 
				if (m_IsValidPlanar == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property planar is not valid. Set planarValid = true");
				return m_Planar;  
			}
			set 
			{ 
				m_IsValidPlanar = true;
				m_Planar = value;
			}
		}
		/// <summary>
		/// 	Indicates if planar contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for planar is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value (false).</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get planar
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidPlanar
		{
			get
			{
				return m_IsValidPlanar;
			}
			set 
			{ 
				if (value != m_IsValidPlanar)
				{
					Planar = false;
					m_IsValidPlanar = value;
				}
			}
		}
		protected Boolean m_IsValidPlanar;
		protected Boolean m_Planar;
		#endregion

		#region Attribute - directed
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimOpt("directed", "http://www.opengis.net/gml", "IsValidDirected", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_boolean, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", -1, -1, "", "", "", "", -1)]
		public Boolean Directed
		{
			get 
			{ 
				if (m_IsValidDirected == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property directed is not valid. Set directedValid = true");
				return m_Directed;  
			}
			set 
			{ 
				m_IsValidDirected = true;
				m_Directed = value;
			}
		}
		/// <summary>
		/// 	Indicates if directed contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for directed is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value (false).</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get directed
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidDirected
		{
			get
			{
				return m_IsValidDirected;
			}
			set 
			{ 
				if (value != m_IsValidDirected)
				{
					Directed = false;
					m_IsValidDirected = value;
				}
			}
		}
		protected Boolean m_IsValidDirected;
		protected Boolean m_Directed;
		#endregion

		#region Attribute - grid
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimOpt("grid", "http://www.opengis.net/gml", "IsValidGrid", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_boolean, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", -1, -1, "", "", "", "", -1)]
		public Boolean Grid
		{
			get 
			{ 
				if (m_IsValidGrid == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property grid is not valid. Set gridValid = true");
				return m_Grid;  
			}
			set 
			{ 
				m_IsValidGrid = true;
				m_Grid = value;
			}
		}
		/// <summary>
		/// 	Indicates if grid contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for grid is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value (false).</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get grid
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidGrid
		{
			get
			{
				return m_IsValidGrid;
			}
			set 
			{ 
				if (value != m_IsValidGrid)
				{
					Grid = false;
					m_IsValidGrid = value;
				}
			}
		}
		protected Boolean m_IsValidGrid;
		protected Boolean m_Grid;
		#endregion

		#region Attribute - minDistance
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimOpt("minDistance", "http://www.opengis.net/gml", "IsValidMinDistance", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_r8, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", -1, -1, "", "", "", "", -1)]
		public Double MinDistance
		{
			get 
			{ 
				if (m_IsValidMinDistance == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property minDistance is not valid. Set minDistanceValid = true");
				return m_MinDistance;  
			}
			set 
			{ 
				m_IsValidMinDistance = true;
				m_MinDistance = value;
			}
		}
		/// <summary>
		/// 	Indicates if minDistance contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for minDistance is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value (0).</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get minDistance
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidMinDistance
		{
			get
			{
				return m_IsValidMinDistance;
			}
			set 
			{ 
				if (value != m_IsValidMinDistance)
				{
					MinDistance = 0;
					m_IsValidMinDistance = value;
				}
			}
		}
		protected Boolean m_IsValidMinDistance;
		protected Double m_MinDistance;
		#endregion

		#region Attribute - minAngle
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimOpt("minAngle", "http://www.opengis.net/gml", "IsValidMinAngle", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_r8, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", -1, -1, "", "", "", "", -1)]
		public Double MinAngle
		{
			get 
			{ 
				if (m_IsValidMinAngle == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property minAngle is not valid. Set minAngleValid = true");
				return m_MinAngle;  
			}
			set 
			{ 
				m_IsValidMinAngle = true;
				m_MinAngle = value;
			}
		}
		/// <summary>
		/// 	Indicates if minAngle contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for minAngle is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value (0).</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get minAngle
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidMinAngle
		{
			get
			{
				return m_IsValidMinAngle;
			}
			set 
			{ 
				if (value != m_IsValidMinAngle)
				{
					MinAngle = 0;
					m_IsValidMinAngle = value;
				}
			}
		}
		protected Boolean m_IsValidMinAngle;
		protected Double m_MinAngle;
		#endregion

		#region Attribute - graphType
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqEnumOpt("graphType", "http://www.opengis.net/gml", "IsValidGraphType", null, typeof(AE.Enumerations), "GraphTypeTypeFromString", "GraphTypeTypeToString")]
		public AE.Enumerations.GraphTypeType GraphType
		{
			get 
			{ 
				if (m_IsValidGraphType == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property graphType is not valid. Set graphTypeValid = true");
				return m_GraphType;  
			}
			set 
			{ 
				m_GraphType = value;
				m_IsValidGraphType = true;
			}
		}
		/// <summary>
		/// 	Indicates if graphType contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for graphType is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value (AE.Enumerations.GraphTypeType.TREE).</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get graphType
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidGraphType
		{
			get { return m_IsValidGraphType;  }
			set 
			{ 
				if (value != m_IsValidGraphType)
				{
					GraphType = AE.Enumerations.GraphTypeType.TREE;
					m_IsValidGraphType = value;
				}
			}
		}
		protected AE.Enumerations.GraphTypeType m_GraphType;
		protected Boolean m_IsValidGraphType;

		#endregion

		#region Attribute - drawingType
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqEnumOpt("drawingType", "http://www.opengis.net/gml", "IsValidDrawingType", null, typeof(AE.Enumerations), "DrawingTypeTypeFromString", "DrawingTypeTypeToString")]
		public AE.Enumerations.DrawingTypeType DrawingType
		{
			get 
			{ 
				if (m_IsValidDrawingType == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property drawingType is not valid. Set drawingTypeValid = true");
				return m_DrawingType;  
			}
			set 
			{ 
				m_DrawingType = value;
				m_IsValidDrawingType = true;
			}
		}
		/// <summary>
		/// 	Indicates if drawingType contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for drawingType is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value (AE.Enumerations.DrawingTypeType.POLYLINE).</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get drawingType
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidDrawingType
		{
			get { return m_IsValidDrawingType;  }
			set 
			{ 
				if (value != m_IsValidDrawingType)
				{
					DrawingType = AE.Enumerations.DrawingTypeType.POLYLINE;
					m_IsValidDrawingType = value;
				}
			}
		}
		protected AE.Enumerations.DrawingTypeType m_DrawingType;
		protected Boolean m_IsValidDrawingType;

		#endregion

		#region Attribute - lineType
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqEnumOpt("lineType", "http://www.opengis.net/gml", "IsValidLineType", null, typeof(AE.Enumerations), "LineTypeTypeFromString", "LineTypeTypeToString")]
		public AE.Enumerations.LineTypeType LineType
		{
			get 
			{ 
				if (m_IsValidLineType == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property lineType is not valid. Set lineTypeValid = true");
				return m_LineType;  
			}
			set 
			{ 
				m_LineType = value;
				m_IsValidLineType = true;
			}
		}
		/// <summary>
		/// 	Indicates if lineType contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for lineType is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value (AE.Enumerations.LineTypeType.STRAIGHT).</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get lineType
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidLineType
		{
			get { return m_IsValidLineType;  }
			set 
			{ 
				if (value != m_IsValidLineType)
				{
					LineType = AE.Enumerations.LineTypeType.STRAIGHT;
					m_IsValidLineType = value;
				}
			}
		}
		protected AE.Enumerations.LineTypeType m_LineType;
		protected Boolean m_IsValidLineType;

		#endregion

		#region Attribute - aestheticCriteria
		/// <summary>
		/// 	A collection of AesheticCriteriaType Enumerated values
		///		
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>This collection may contain 0 to Many values.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqEnumCol("aestheticCriteria", "http://www.opengis.net/gml")]
		public CSW.XmlEnumTypeCollection<AE.Enumerations.AesheticCriteriaType> AestheticCriteriaCol
		{
			get { return m_AestheticCriteriaCol;  }
		}
		protected CSW.XmlEnumTypeCollection<AE.Enumerations.AesheticCriteriaType> m_AestheticCriteriaCol;

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


