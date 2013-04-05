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
	/// 	This class represents the ComplexType GeometryStyleType
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Sequence,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element,
													"GeometryStyleType", "http://www.opengis.net/gml", false, true,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class GeometryStyleType : CSW.XmlCommonBase
					, AE.IBaseStyleDescriptorType
	{
		#region Constructors
		/// <summary>
		///		Constructor for GeometryStyleType
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public GeometryStyleType()
		{
			_elementName = "GeometryStyleType";
			Init();
		}
		public GeometryStyleType(String elementName)
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
			m_GeometryProperty = "";
			m_IsValidGeometryProperty = false;
			m_GeometryType = "";
			m_IsValidGeometryType = false;
			m_GeometryStyleType_Type_Seq_Choice = new AE.GeometryStyleType_Type_Seq_Choice("GeometryStyleType_Type_Seq_Choice");
			m_LabelStyle = null;



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
			AE.GeometryStyleType newObject = new AE.GeometryStyleType(_elementName);
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
			newObject.m_GeometryProperty = m_GeometryProperty;
			newObject.m_IsValidGeometryProperty = m_IsValidGeometryProperty;
			newObject.m_GeometryType = m_GeometryType;
			newObject.m_IsValidGeometryType = m_IsValidGeometryType;
			newObject.m_GeometryStyleType_Type_Seq_Choice = null;
			if (m_GeometryStyleType_Type_Seq_Choice != null)
				newObject.m_GeometryStyleType_Type_Seq_Choice = (AE.GeometryStyleType_Type_Seq_Choice)m_GeometryStyleType_Type_Seq_Choice.Clone();
			newObject.m_LabelStyle = null;
			if (m_LabelStyle != null)
				newObject.m_LabelStyle = (AE.LabelStyle)m_LabelStyle.Clone();


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

		#region Attribute - geometryProperty
		/// <summary>
		///		Represents an optional Attribute in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Attribute in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoPrimitive("geometryProperty", "", "IsValidGeometryProperty", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, null, "", -1, -1, "", "", "", "", -1)]
		public String GeometryProperty
		{
			get 
			{ 
				if (m_IsValidGeometryProperty == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property geometryProperty is not valid. Set geometryPropertyValid = true");
				return m_GeometryProperty;  
			}
			set 
			{ 
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				m_IsValidGeometryProperty = true;
				m_GeometryProperty = value;
			}
		}
		/// <summary>
		/// 	Indicates if geometryProperty contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for geometryProperty is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value ("").</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get geometryProperty
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidGeometryProperty
		{
			get
			{
				return m_IsValidGeometryProperty;
			}
			set 
			{ 
				if (value != m_IsValidGeometryProperty)
				{
					GeometryProperty = "";
					m_IsValidGeometryProperty = value;
				}
			}
		}
		protected Boolean m_IsValidGeometryProperty;
		protected String m_GeometryProperty;
		#endregion

		#region Attribute - geometryType
		/// <summary>
		///		Represents an optional Attribute in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Attribute in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoPrimitive("geometryType", "", "IsValidGeometryType", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, null, "", -1, -1, "", "", "", "", -1)]
		public String GeometryType
		{
			get 
			{ 
				if (m_IsValidGeometryType == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property geometryType is not valid. Set geometryTypeValid = true");
				return m_GeometryType;  
			}
			set 
			{ 
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				m_IsValidGeometryType = true;
				m_GeometryType = value;
			}
		}
		/// <summary>
		/// 	Indicates if geometryType contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for geometryType is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value ("").</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get geometryType
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidGeometryType
		{
			get
			{
				return m_IsValidGeometryType;
			}
			set 
			{ 
				if (value != m_IsValidGeometryType)
				{
					GeometryType = "";
					m_IsValidGeometryType = value;
				}
			}
		}
		protected Boolean m_IsValidGeometryType;
		protected String m_GeometryType;
		#endregion

		#region Attribute - GeometryStyleType_Type_Seq_Choice
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
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsMnd("GeometryStyleType_Type_Seq_Choice", "", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement, typeof(AE.GeometryStyleType_Type_Seq_Choice), false)]
		public AE.GeometryStyleType_Type_Seq_Choice GeometryStyleType_Type_Seq_Choice
		{
			get 
			{ 
				return m_GeometryStyleType_Type_Seq_Choice;  
			}
			set 
			{ 
				Throw_IfPropertyIsNull(value, "GeometryStyleType_Type_Seq_Choice");
				m_GeometryStyleType_Type_Seq_Choice = value;
			}
		}
		protected AE.GeometryStyleType_Type_Seq_Choice m_GeometryStyleType_Type_Seq_Choice;
		
		#endregion

		#region Attribute - labelStyle
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsOpt("labelStyle", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.LabelStyle))]
		public AE.LabelStyle LabelStyle
		{
			get 
			{ 
				return m_LabelStyle;  
			}
			set 
			{ 
				if (value == null)
					m_LabelStyle = null;
				else
				{
					m_LabelStyle = value; 
				}
			}
		}
		protected AE.LabelStyle m_LabelStyle;
		
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


