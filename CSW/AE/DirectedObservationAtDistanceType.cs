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
	/// 	This class represents the ComplexType DirectedObservationAtDistanceType
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Sequence,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element,
													"DirectedObservationAtDistanceType", "http://www.opengis.net/gml", false, true,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class DirectedObservationAtDistanceType : CSW.XmlCommonBase
					, AE.IDirectedObservationType
	{
		#region Constructors
		/// <summary>
		///		Constructor for DirectedObservationAtDistanceType
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public DirectedObservationAtDistanceType()
		{
			_elementName = "DirectedObservationAtDistanceType";
			Init();
		}
		public DirectedObservationAtDistanceType(String elementName)
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
			m_BoundedBy = null;
			m_Location = null;
			m_ValidTime = null;
			m_Using = null;
			m_Target = null;
			m_ResultOf = new AE.ResultOf("resultOf");
			m_Direction = new AE.Direction("direction");
			m_Distance = null;



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
			AE.DirectedObservationAtDistanceType newObject = new AE.DirectedObservationAtDistanceType(_elementName);
			newObject.m_Id = m_Id;
			newObject.m_IsValidId = m_IsValidId;
			foreach (AE.MetaDataProperty o in m_MetaDataPropertyCol)
				newObject.m_MetaDataPropertyCol.Add((AE.MetaDataProperty)o.Clone());
			newObject.m_Description = null;
			if (m_Description != null)
				newObject.m_Description = (AE.Description)m_Description.Clone();
			foreach (AE.SubGrpname o in m_NameCol)
				newObject.m_NameCol.Add((AE.SubGrpname)o.Clone());
			newObject.m_BoundedBy = null;
			if (m_BoundedBy != null)
				newObject.m_BoundedBy = (AE.BoundedBy)m_BoundedBy.Clone();
			newObject.m_Location = null;
			if (m_Location != null)
				newObject.m_Location = (AE.SubGrplocation)m_Location.Clone();
			newObject.m_ValidTime = null;
			if (m_ValidTime != null)
				newObject.m_ValidTime = (AE.ITimePrimitivePropertyType)m_ValidTime.Clone();
			newObject.m_Using = null;
			if (m_Using != null)
				newObject.m_Using = (AE.using_)m_Using.Clone();
			newObject.m_Target = null;
			if (m_Target != null)
				newObject.m_Target = (AE.SubGrptarget)m_Target.Clone();
			newObject.m_ResultOf = null;
			if (m_ResultOf != null)
				newObject.m_ResultOf = (AE.ResultOf)m_ResultOf.Clone();
			newObject.m_Direction = null;
			if (m_Direction != null)
				newObject.m_Direction = (AE.Direction)m_Direction.Clone();
			newObject.m_Distance = null;
			if (m_Distance != null)
				newObject.m_Distance = (AE.IMeasureType)m_Distance.Clone();


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

		#region Attribute - boundedBy
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsOpt("boundedBy", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.BoundedBy))]
		public AE.BoundedBy BoundedBy
		{
			get 
			{ 
				return m_BoundedBy;  
			}
			set 
			{ 
				if (value == null)
					m_BoundedBy = null;
				else
				{
					m_BoundedBy = value; 
				}
			}
		}
		protected AE.BoundedBy m_BoundedBy;
		
		#endregion

		#region Attribute - location
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsOpt("location", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement, typeof(AE.SubGrplocation))]
		public AE.SubGrplocation Location
		{
			get 
			{ 
				return m_Location;  
			}
			set 
			{ 
				if (value == null)
					m_Location = null;
				else
				{
					m_Location = value; 
				}
			}
		}
		protected AE.SubGrplocation m_Location;
		
		#endregion

		#region Attribute - validTime
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
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqAbsClsMnd("validTime", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.ClassFactory), "ITimePrimitivePropertyTypeCreateObject")]
		public AE.ITimePrimitivePropertyType ValidTime
		{
			get 
			{ 
				return m_ValidTime;  
			}
			set 
			{ 
				Throw_IfPropertyIsNull(value, "validTime");
				if (value != null)
				{
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "validTime");
				}
				m_ValidTime = value; 
			}
		}
		protected AE.ITimePrimitivePropertyType m_ValidTime;

		#endregion

		#region Attribute - using
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsOpt("using", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.using_))]
		public AE.using_ using_
		{
			get 
			{ 
				return m_Using;  
			}
			set 
			{ 
				if (value == null)
					m_Using = null;
				else
				{
					m_Using = value; 
				}
			}
		}
		protected AE.using_ m_Using;
		
		#endregion

		#region Attribute - target
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsOpt("target", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement, typeof(AE.SubGrptarget))]
		public AE.SubGrptarget Target
		{
			get 
			{ 
				return m_Target;  
			}
			set 
			{ 
				if (value == null)
					m_Target = null;
				else
				{
					m_Target = value; 
				}
			}
		}
		protected AE.SubGrptarget m_Target;
		
		#endregion

		#region Attribute - resultOf
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
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsMnd("resultOf", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.ResultOf), false)]
		public AE.ResultOf ResultOf
		{
			get 
			{ 
				return m_ResultOf;  
			}
			set 
			{ 
				Throw_IfPropertyIsNull(value, "resultOf");
				m_ResultOf = value;
			}
		}
		protected AE.ResultOf m_ResultOf;
		
		#endregion

		#region Attribute - direction
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
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsMnd("direction", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.Direction), false)]
		public AE.Direction Direction
		{
			get 
			{ 
				return m_Direction;  
			}
			set 
			{ 
				Throw_IfPropertyIsNull(value, "direction");
				m_Direction = value;
			}
		}
		protected AE.Direction m_Direction;
		
		#endregion

		#region Attribute - distance
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
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqAbsClsMnd("distance", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.ClassFactory), "IMeasureTypeCreateObject")]
		public AE.IMeasureType Distance
		{
			get 
			{ 
				return m_Distance;  
			}
			set 
			{ 
				Throw_IfPropertyIsNull(value, "distance");
				if (value != null)
				{
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "distance");
				}
				m_Distance = value; 
			}
		}
		protected AE.IMeasureType m_Distance;

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


