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
	/// 	This class represents the Element OperationParameterGroup
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Sequence,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element,
													"OperationParameterGroup", "http://www.opengis.net/gml", false, true,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class OperationParameterGroup : CSW.XmlCommonBase
					, AE.IOperationParameterGroupBaseType
	{
		#region Constructors
		/// <summary>
		///		Constructor for OperationParameterGroup
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public OperationParameterGroup()
		{
			_elementName = "OperationParameterGroup";
			Init();
		}
		public OperationParameterGroup(String elementName)
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
			m_MinimumOccurs = 0;
			m_IsValidMinimumOccurs = false; 
			m_GroupIDCol = new CSW.XmlObjectCollection<AE.GroupID>("groupID", "http://www.opengis.net/gml", 0, -1, false);
			m_Remarks = null;
			m_MaximumOccurs = 0;
			m_IsValidMaximumOccurs = false; 
			m_IncludesParameterCol = new CSW.XmlObjectCollection<AE.IncludesParameter>("includesParameter", "http://www.opengis.net/gml", 2, -1, false);



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
			AE.OperationParameterGroup newObject = new AE.OperationParameterGroup(_elementName);
			newObject.m_Id = m_Id;
			newObject.m_IsValidId = m_IsValidId;
			foreach (AE.MetaDataProperty o in m_MetaDataPropertyCol)
				newObject.m_MetaDataPropertyCol.Add((AE.MetaDataProperty)o.Clone());
			newObject.m_Description = null;
			if (m_Description != null)
				newObject.m_Description = (AE.Description)m_Description.Clone();
			foreach (AE.SubGrpname o in m_NameCol)
				newObject.m_NameCol.Add((AE.SubGrpname)o.Clone());
			newObject.m_MinimumOccurs = m_MinimumOccurs;
			newObject.m_IsValidMinimumOccurs = m_IsValidMinimumOccurs;
			foreach (AE.GroupID o in m_GroupIDCol)
				newObject.m_GroupIDCol.Add((AE.GroupID)o.Clone());
			newObject.m_Remarks = null;
			if (m_Remarks != null)
				newObject.m_Remarks = (AE.Remarks)m_Remarks.Clone();
			newObject.m_MaximumOccurs = m_MaximumOccurs;
			newObject.m_IsValidMaximumOccurs = m_IsValidMaximumOccurs;
			foreach (AE.IncludesParameter o in m_IncludesParameterCol)
				newObject.m_IncludesParameterCol.Add((AE.IncludesParameter)o.Clone());


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

		#region Attribute - minimumOccurs
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimOpt("minimumOccurs", "http://www.opengis.net/gml", "IsValidMinimumOccurs", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_integer, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", -1, -1, "0", "", "", "", -1)]
		public LiquidTechnologies.Runtime.Net45.BigInteger MinimumOccurs
		{
			get 
			{ 
				if (m_IsValidMinimumOccurs == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property minimumOccurs is not valid. Set minimumOccursValid = true");
				return m_MinimumOccurs;  
			}
			set 
			{ 
				CheckElementRestriction(3, value);
				m_IsValidMinimumOccurs = true;
				m_MinimumOccurs = value;
			}
		}
		/// <summary>
		/// 	Indicates if minimumOccurs contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for minimumOccurs is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value (0).</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get minimumOccurs
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidMinimumOccurs
		{
			get
			{
				return m_IsValidMinimumOccurs;
			}
			set 
			{ 
				if (value != m_IsValidMinimumOccurs)
				{
					MinimumOccurs = 0;
					m_IsValidMinimumOccurs = value;
				}
			}
		}
		protected Boolean m_IsValidMinimumOccurs;
		protected LiquidTechnologies.Runtime.Net45.BigInteger m_MinimumOccurs;
		#endregion

		#region Attribute - groupID
		/// <summary>
		/// 	A collection of groupIDCols
		///		
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>This collection may contain 0 to Many objects.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsCol("groupID", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element)]
		public CSW.XmlObjectCollection<AE.GroupID> GroupIDCol
		{
			get { return m_GroupIDCol; }
		}
		protected CSW.XmlObjectCollection<AE.GroupID> m_GroupIDCol;
		
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

		#region Attribute - maximumOccurs
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqPrimOpt("maximumOccurs", "http://www.opengis.net/gml", "IsValidMaximumOccurs", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_integer, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "", -1, -1, "1", "", "", "", -1)]
		public LiquidTechnologies.Runtime.Net45.BigInteger MaximumOccurs
		{
			get 
			{ 
				if (m_IsValidMaximumOccurs == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property maximumOccurs is not valid. Set maximumOccursValid = true");
				return m_MaximumOccurs;  
			}
			set 
			{ 
				CheckElementRestriction(6, value);
				m_IsValidMaximumOccurs = true;
				m_MaximumOccurs = value;
			}
		}
		/// <summary>
		/// 	Indicates if maximumOccurs contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for maximumOccurs is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value (0).</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get maximumOccurs
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidMaximumOccurs
		{
			get
			{
				return m_IsValidMaximumOccurs;
			}
			set 
			{ 
				if (value != m_IsValidMaximumOccurs)
				{
					MaximumOccurs = 0;
					m_IsValidMaximumOccurs = value;
				}
			}
		}
		protected Boolean m_IsValidMaximumOccurs;
		protected LiquidTechnologies.Runtime.Net45.BigInteger m_MaximumOccurs;
		#endregion

		#region Attribute - includesParameter
		/// <summary>
		/// 	A collection of includesParameterCols
		///		
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>This collection may contain 2 to Many objects.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsCol("includesParameter", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element)]
		public CSW.XmlObjectCollection<AE.IncludesParameter> IncludesParameterCol
		{
			get { return m_IncludesParameterCol; }
		}
		protected CSW.XmlObjectCollection<AE.IncludesParameter> m_IncludesParameterCol;
		
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


