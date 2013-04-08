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
	/// 	This class represents the ComplexType ConversionType
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Sequence,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element,
													"ConversionType", "http://www.opengis.net/gml", false, true,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class ConversionType : CSW.XmlCommonBase
					, AE.IAbstractGeneralConversionType
	{
		#region Constructors
		/// <summary>
		///		Constructor for ConversionType
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public ConversionType()
		{
			_elementName = "ConversionType";
			Init();
		}
		public ConversionType(String elementName)
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
			m_CoordinateOperationIDCol = new CSW.XmlObjectCollection<AE.CoordinateOperationID>("coordinateOperationID", "http://www.opengis.net/gml", 0, -1, false);
			m_Remarks = null;
			m_OperationVersion = "";
			m_IsValidOperationVersion = false; 
			m_ValidArea = null;
			m_Scope = "";
			m_IsValidScope = false; 
			m__positionalAccuracyCol = new CSW.XmlObjectCollection<AE.SubGrp_positionalAccuracy>("_positionalAccuracy", "http://www.opengis.net/gml", 0, -1, true);
			m_SourceCRS = null;
			m_TargetCRS = null;
			m_UsesMethod = new AE.UsesMethod("usesMethod");
			m_UsesValueCol = new CSW.XmlObjectCollection<AE.UsesValue>("usesValue", "http://www.opengis.net/gml", 0, -1, false);



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
			AE.ConversionType newObject = new AE.ConversionType(_elementName);
			newObject.m_Id = m_Id;
			newObject.m_IsValidId = m_IsValidId;
			foreach (AE.MetaDataProperty o in m_MetaDataPropertyCol)
				newObject.m_MetaDataPropertyCol.Add((AE.MetaDataProperty)o.Clone());
			newObject.m_Description = null;
			if (m_Description != null)
				newObject.m_Description = (AE.Description)m_Description.Clone();
			foreach (AE.SubGrpname o in m_NameCol)
				newObject.m_NameCol.Add((AE.SubGrpname)o.Clone());
			foreach (AE.CoordinateOperationID o in m_CoordinateOperationIDCol)
				newObject.m_CoordinateOperationIDCol.Add((AE.CoordinateOperationID)o.Clone());
			newObject.m_Remarks = null;
			if (m_Remarks != null)
				newObject.m_Remarks = (AE.Remarks)m_Remarks.Clone();
			newObject.m_OperationVersion = m_OperationVersion;
			newObject.m_IsValidOperationVersion = m_IsValidOperationVersion;
			newObject.m_ValidArea = null;
			if (m_ValidArea != null)
				newObject.m_ValidArea = (AE.ValidArea)m_ValidArea.Clone();
			newObject.m_Scope = m_Scope;
			newObject.m_IsValidScope = m_IsValidScope;
			foreach (AE.SubGrp_positionalAccuracy o in m__positionalAccuracyCol)
				newObject.m__positionalAccuracyCol.Add((AE.SubGrp_positionalAccuracy)o.Clone());
			newObject.m_SourceCRS = null;
			if (m_SourceCRS != null)
				newObject.m_SourceCRS = (AE.SourceCRS)m_SourceCRS.Clone();
			newObject.m_TargetCRS = null;
			if (m_TargetCRS != null)
				newObject.m_TargetCRS = (AE.TargetCRS)m_TargetCRS.Clone();
			newObject.m_UsesMethod = null;
			if (m_UsesMethod != null)
				newObject.m_UsesMethod = (AE.UsesMethod)m_UsesMethod.Clone();
			foreach (AE.UsesValue o in m_UsesValueCol)
				newObject.m_UsesValueCol.Add((AE.UsesValue)o.Clone());


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

		#region Attribute - coordinateOperationID
		/// <summary>
		/// 	A collection of coordinateOperationIDCols
		///		
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>This collection may contain 0 to Many objects.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsCol("coordinateOperationID", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element)]
		public CSW.XmlObjectCollection<AE.CoordinateOperationID> CoordinateOperationIDCol
		{
			get { return m_CoordinateOperationIDCol; }
		}
		protected CSW.XmlObjectCollection<AE.CoordinateOperationID> m_CoordinateOperationIDCol;
		
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

		#region Attribute - operationVersion
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimOpt("operationVersion", "http://www.opengis.net/gml", "IsValidOperationVersion", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", -1, -1, "", "", "", "", -1)]
		public String OperationVersion
		{
			get 
			{ 
				if (m_IsValidOperationVersion == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property operationVersion is not valid. Set operationVersionValid = true");
				return m_OperationVersion;  
			}
			set 
			{ 
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				m_IsValidOperationVersion = true;
				m_OperationVersion = value;
			}
		}
		/// <summary>
		/// 	Indicates if operationVersion contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for operationVersion is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value ("").</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get operationVersion
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidOperationVersion
		{
			get
			{
				return m_IsValidOperationVersion;
			}
			set 
			{ 
				if (value != m_IsValidOperationVersion)
				{
					OperationVersion = "";
					m_IsValidOperationVersion = value;
				}
			}
		}
		protected Boolean m_IsValidOperationVersion;
		protected String m_OperationVersion;
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

		#region Attribute - _positionalAccuracy
		/// <summary>
		/// 	A collection of _positionalAccuracyCols
		///		
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>This collection may contain 0 to Many objects.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsCol("_positionalAccuracy", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement)]
		public CSW.XmlObjectCollection<AE.SubGrp_positionalAccuracy> _positionalAccuracyCol
		{
			get { return m__positionalAccuracyCol; }
		}
		protected CSW.XmlObjectCollection<AE.SubGrp_positionalAccuracy> m__positionalAccuracyCol;
		
		#endregion

		#region Attribute - sourceCRS
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsOpt("sourceCRS", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.SourceCRS))]
		public AE.SourceCRS SourceCRS
		{
			get 
			{ 
				return m_SourceCRS;  
			}
			set 
			{ 
				if (value == null)
					m_SourceCRS = null;
				else
				{
					m_SourceCRS = value; 
				}
			}
		}
		protected AE.SourceCRS m_SourceCRS;
		
		#endregion

		#region Attribute - targetCRS
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsOpt("targetCRS", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.TargetCRS))]
		public AE.TargetCRS TargetCRS
		{
			get 
			{ 
				return m_TargetCRS;  
			}
			set 
			{ 
				if (value == null)
					m_TargetCRS = null;
				else
				{
					m_TargetCRS = value; 
				}
			}
		}
		protected AE.TargetCRS m_TargetCRS;
		
		#endregion

		#region Attribute - usesMethod
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
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsMnd("usesMethod", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.UsesMethod), false)]
		public AE.UsesMethod UsesMethod
		{
			get 
			{ 
				return m_UsesMethod;  
			}
			set 
			{ 
				Throw_IfPropertyIsNull(value, "usesMethod");
				m_UsesMethod = value;
			}
		}
		protected AE.UsesMethod m_UsesMethod;
		
		#endregion

		#region Attribute - usesValue
		/// <summary>
		/// 	A collection of usesValueCols
		///		
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>This collection may contain 0 to Many objects.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsCol("usesValue", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element)]
		public CSW.XmlObjectCollection<AE.UsesValue> UsesValueCol
		{
			get { return m_UsesValueCol; }
		}
		protected CSW.XmlObjectCollection<AE.UsesValue> m_UsesValueCol;
		
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


