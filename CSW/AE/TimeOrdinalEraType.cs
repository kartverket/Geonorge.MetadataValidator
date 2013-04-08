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
	/// 	This class represents the ComplexType TimeOrdinalEraType
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Sequence,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element,
													"TimeOrdinalEraType", "http://www.opengis.net/gml", false, true,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class TimeOrdinalEraType : CSW.XmlCommonBase
					, AE.IDefinitionType
	{
		#region Constructors
		/// <summary>
		///		Constructor for TimeOrdinalEraType
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public TimeOrdinalEraType()
		{
			_elementName = "TimeOrdinalEraType";
			Init();
		}
		public TimeOrdinalEraType(String elementName)
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
			m_RelatedTimeCol = new CSW.XmlObjectCollection<AE.RelatedTimeType>("relatedTime", "http://www.opengis.net/gml", 0, -1, false);
			m_Start = new AE.TimeNodePropertyType("start");
			m_End = new AE.TimeNodePropertyType("end");
			m_Extent = null;
			m_MemberCol = new CSW.XmlObjectCollection<AE.TimeOrdinalEraPropertyType>("member", "http://www.opengis.net/gml", 0, -1, false);
			m_Group = null;



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
			AE.TimeOrdinalEraType newObject = new AE.TimeOrdinalEraType(_elementName);
			newObject.m_Id = m_Id;
			newObject.m_IsValidId = m_IsValidId;
			foreach (AE.MetaDataProperty o in m_MetaDataPropertyCol)
				newObject.m_MetaDataPropertyCol.Add((AE.MetaDataProperty)o.Clone());
			newObject.m_Description = null;
			if (m_Description != null)
				newObject.m_Description = (AE.Description)m_Description.Clone();
			foreach (AE.SubGrpname o in m_NameCol)
				newObject.m_NameCol.Add((AE.SubGrpname)o.Clone());
			foreach (AE.RelatedTimeType o in m_RelatedTimeCol)
				newObject.m_RelatedTimeCol.Add((AE.RelatedTimeType)o.Clone());
			newObject.m_Start = null;
			if (m_Start != null)
				newObject.m_Start = (AE.TimeNodePropertyType)m_Start.Clone();
			newObject.m_End = null;
			if (m_End != null)
				newObject.m_End = (AE.TimeNodePropertyType)m_End.Clone();
			newObject.m_Extent = null;
			if (m_Extent != null)
				newObject.m_Extent = (AE.TimePeriodPropertyType)m_Extent.Clone();
			foreach (AE.TimeOrdinalEraPropertyType o in m_MemberCol)
				newObject.m_MemberCol.Add((AE.TimeOrdinalEraPropertyType)o.Clone());
			newObject.m_Group = null;
			if (m_Group != null)
				newObject.m_Group = (AE.ReferenceType)m_Group.Clone();


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

		#region Attribute - relatedTime
		/// <summary>
		/// 	A collection of relatedTimeCols
		///		
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>This collection may contain 0 to Many objects.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsCol("relatedTime", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element)]
		public CSW.XmlObjectCollection<AE.RelatedTimeType> RelatedTimeCol
		{
			get { return m_RelatedTimeCol; }
		}
		protected CSW.XmlObjectCollection<AE.RelatedTimeType> m_RelatedTimeCol;
		
		#endregion

		#region Attribute - start
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
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsMnd("start", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.TimeNodePropertyType), false)]
		public AE.TimeNodePropertyType Start
		{
			get 
			{ 
				return m_Start;  
			}
			set 
			{ 
				Throw_IfPropertyIsNull(value, "start");
				if (value != null)
					SetElementName(value, "start");
				m_Start = value;
			}
		}
		protected AE.TimeNodePropertyType m_Start;
		
		#endregion

		#region Attribute - end
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
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsMnd("end", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.TimeNodePropertyType), false)]
		public AE.TimeNodePropertyType End
		{
			get 
			{ 
				return m_End;  
			}
			set 
			{ 
				Throw_IfPropertyIsNull(value, "end");
				if (value != null)
					SetElementName(value, "end");
				m_End = value;
			}
		}
		protected AE.TimeNodePropertyType m_End;
		
		#endregion

		#region Attribute - extent
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsOpt("extent", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.TimePeriodPropertyType))]
		public AE.TimePeriodPropertyType Extent
		{
			get 
			{ 
				return m_Extent;  
			}
			set 
			{ 
				if (value == null)
					m_Extent = null;
				else
				{
					SetElementName(value, "extent");
					m_Extent = value; 
				}
			}
		}
		protected AE.TimePeriodPropertyType m_Extent;
		
		#endregion

		#region Attribute - member
		/// <summary>
		/// 	A collection of memberCols
		///		
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>This collection may contain 0 to Many objects.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsCol("member", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element)]
		public CSW.XmlObjectCollection<AE.TimeOrdinalEraPropertyType> MemberCol
		{
			get { return m_MemberCol; }
		}
		protected CSW.XmlObjectCollection<AE.TimeOrdinalEraPropertyType> m_MemberCol;
		
		#endregion

		#region Attribute - group
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsOpt("group", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.ReferenceType))]
		public AE.ReferenceType Group
		{
			get 
			{ 
				return m_Group;  
			}
			set 
			{ 
				if (value == null)
					m_Group = null;
				else
				{
					SetElementName(value, "group");
					m_Group = value; 
				}
			}
		}
		protected AE.ReferenceType m_Group;
		
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


