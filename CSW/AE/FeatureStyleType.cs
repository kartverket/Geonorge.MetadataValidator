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
	/// 	This class represents the ComplexType FeatureStyleType
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Sequence,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element,
													"FeatureStyleType", "http://www.opengis.net/gml", false, true,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class FeatureStyleType : CSW.XmlCommonBase
					, AE.IAbstractGMLType
	{
		#region Constructors
		/// <summary>
		///		Constructor for FeatureStyleType
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public FeatureStyleType()
		{
			_elementName = "FeatureStyleType";
			Init();
		}
		public FeatureStyleType(String elementName)
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
			m_FeatureType = "";
			m_IsValidFeatureType = false;
			m_BaseType = "";
			m_IsValidBaseType = false;
			m_QueryGrammar = AE.Enumerations.QueryGrammarEnumeration.Xpath;
			m_IsValidQueryGrammar = false;
			m_FeatureConstraint = "";
			m_IsValidFeatureConstraint = false; 
			m_GeometryStyleCol = new CSW.XmlObjectCollection<AE.GeometryStyle>("geometryStyle", "http://www.opengis.net/gml", 0, -1, false);
			m_TopologyStyleCol = new CSW.XmlObjectCollection<AE.TopologyStyle>("topologyStyle", "http://www.opengis.net/gml", 0, -1, false);
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
			AE.FeatureStyleType newObject = new AE.FeatureStyleType(_elementName);
			newObject.m_Id = m_Id;
			newObject.m_IsValidId = m_IsValidId;
			foreach (AE.MetaDataProperty o in m_MetaDataPropertyCol)
				newObject.m_MetaDataPropertyCol.Add((AE.MetaDataProperty)o.Clone());
			newObject.m_Description = null;
			if (m_Description != null)
				newObject.m_Description = (AE.Description)m_Description.Clone();
			foreach (AE.SubGrpname o in m_NameCol)
				newObject.m_NameCol.Add((AE.SubGrpname)o.Clone());
			newObject.m_FeatureType = m_FeatureType;
			newObject.m_IsValidFeatureType = m_IsValidFeatureType;
			newObject.m_BaseType = m_BaseType;
			newObject.m_IsValidBaseType = m_IsValidBaseType;
			newObject.m_QueryGrammar = m_QueryGrammar;
			newObject.m_IsValidQueryGrammar = m_IsValidQueryGrammar;
			newObject.m_FeatureConstraint = m_FeatureConstraint;
			newObject.m_IsValidFeatureConstraint = m_IsValidFeatureConstraint;
			foreach (AE.GeometryStyle o in m_GeometryStyleCol)
				newObject.m_GeometryStyleCol.Add((AE.GeometryStyle)o.Clone());
			foreach (AE.TopologyStyle o in m_TopologyStyleCol)
				newObject.m_TopologyStyleCol.Add((AE.TopologyStyle)o.Clone());
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

		#region Attribute - featureType
		/// <summary>
		///		Represents an optional Attribute in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Attribute in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoPrimitive("featureType", "", "IsValidFeatureType", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, null, "", -1, -1, "", "", "", "", -1)]
		public String FeatureType
		{
			get 
			{ 
				if (m_IsValidFeatureType == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property featureType is not valid. Set featureTypeValid = true");
				return m_FeatureType;  
			}
			set 
			{ 
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				m_IsValidFeatureType = true;
				m_FeatureType = value;
			}
		}
		/// <summary>
		/// 	Indicates if featureType contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for featureType is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value ("").</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get featureType
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidFeatureType
		{
			get
			{
				return m_IsValidFeatureType;
			}
			set 
			{ 
				if (value != m_IsValidFeatureType)
				{
					FeatureType = "";
					m_IsValidFeatureType = value;
				}
			}
		}
		protected Boolean m_IsValidFeatureType;
		protected String m_FeatureType;
		#endregion

		#region Attribute - baseType
		/// <summary>
		///		Represents an optional Attribute in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Attribute in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoPrimitive("baseType", "", "IsValidBaseType", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, null, "", -1, -1, "", "", "", "", -1)]
		public String BaseType
		{
			get 
			{ 
				if (m_IsValidBaseType == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property baseType is not valid. Set baseTypeValid = true");
				return m_BaseType;  
			}
			set 
			{ 
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				m_IsValidBaseType = true;
				m_BaseType = value;
			}
		}
		/// <summary>
		/// 	Indicates if baseType contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for baseType is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value ("").</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get baseType
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidBaseType
		{
			get
			{
				return m_IsValidBaseType;
			}
			set 
			{ 
				if (value != m_IsValidBaseType)
				{
					BaseType = "";
					m_IsValidBaseType = value;
				}
			}
		}
		protected Boolean m_IsValidBaseType;
		protected String m_BaseType;
		#endregion

		#region Attribute - queryGrammar
		/// <summary>
		///		Represents an optional Attribute in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Attribute in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoEnum("queryGrammar", "", "IsValidQueryGrammar", typeof(AE.Enumerations), "QueryGrammarEnumerationFromString", "QueryGrammarEnumerationToString", null)]
		public AE.Enumerations.QueryGrammarEnumeration QueryGrammar
		{
			get 
			{ 
				if (m_IsValidQueryGrammar == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property queryGrammar is not valid. Set queryGrammarValid = true");
				return m_QueryGrammar;  
			}
			set 
			{ 
				m_QueryGrammar = value;
				m_IsValidQueryGrammar = true;
			}
		}
		/// <summary>
		/// 	Indicates if queryGrammar contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for queryGrammar is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value (AE.Enumerations.QueryGrammarEnumeration.Xpath).</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get queryGrammar
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidQueryGrammar
		{
			get { return m_IsValidQueryGrammar;  }
			set 
			{ 
				if (value != m_IsValidQueryGrammar)
				{
					QueryGrammar = AE.Enumerations.QueryGrammarEnumeration.Xpath;
					m_IsValidQueryGrammar = value;
				}
			}
		}
		protected AE.Enumerations.QueryGrammarEnumeration m_QueryGrammar;
		protected Boolean m_IsValidQueryGrammar;

		#endregion

		#region Attribute - featureConstraint
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimOpt("featureConstraint", "http://www.opengis.net/gml", "IsValidFeatureConstraint", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", -1, -1, "", "", "", "", -1)]
		public String FeatureConstraint
		{
			get 
			{ 
				if (m_IsValidFeatureConstraint == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property featureConstraint is not valid. Set featureConstraintValid = true");
				return m_FeatureConstraint;  
			}
			set 
			{ 
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				m_IsValidFeatureConstraint = true;
				m_FeatureConstraint = value;
			}
		}
		/// <summary>
		/// 	Indicates if featureConstraint contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for featureConstraint is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value ("").</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get featureConstraint
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidFeatureConstraint
		{
			get
			{
				return m_IsValidFeatureConstraint;
			}
			set 
			{ 
				if (value != m_IsValidFeatureConstraint)
				{
					FeatureConstraint = "";
					m_IsValidFeatureConstraint = value;
				}
			}
		}
		protected Boolean m_IsValidFeatureConstraint;
		protected String m_FeatureConstraint;
		#endregion

		#region Attribute - geometryStyle
		/// <summary>
		/// 	A collection of geometryStyleCols
		///		
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>This collection may contain 0 to Many objects.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsCol("geometryStyle", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element)]
		public CSW.XmlObjectCollection<AE.GeometryStyle> GeometryStyleCol
		{
			get { return m_GeometryStyleCol; }
		}
		protected CSW.XmlObjectCollection<AE.GeometryStyle> m_GeometryStyleCol;
		
		#endregion

		#region Attribute - topologyStyle
		/// <summary>
		/// 	A collection of topologyStyleCols
		///		
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>This collection may contain 0 to Many objects.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsCol("topologyStyle", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element)]
		public CSW.XmlObjectCollection<AE.TopologyStyle> TopologyStyleCol
		{
			get { return m_TopologyStyleCol; }
		}
		protected CSW.XmlObjectCollection<AE.TopologyStyle> m_TopologyStyleCol;
		
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


