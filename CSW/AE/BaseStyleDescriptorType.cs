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
	/// 	This class represents the ComplexType BaseStyleDescriptorType
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Sequence,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element,
													"BaseStyleDescriptorType", "http://www.opengis.net/gml", false, true,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class BaseStyleDescriptorType : CSW.XmlCommonBase
					, AE.IBaseStyleDescriptorType
					, AE.IAbstractGMLType
	{
		#region Constructors
		/// <summary>
		///		Constructor for BaseStyleDescriptorType
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public BaseStyleDescriptorType()
		{
			_elementName = "BaseStyleDescriptorType";
			Init();
		}
		public BaseStyleDescriptorType(String elementName)
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
			AE.BaseStyleDescriptorType newObject = new AE.BaseStyleDescriptorType(_elementName);
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


