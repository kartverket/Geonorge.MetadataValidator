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

namespace csw
{
	/// <summary>
	/// 	This class represents the ComplexType SummaryRecordType
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Sequence,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element,
													"SummaryRecordType", "http://www.opengis.net/cat/csw/2.0.2", false, true,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class SummaryRecordType : CSW.XmlCommonBase
					, csw.IAbstractRecordType
	{
		#region Constructors
		/// <summary>
		///		Constructor for SummaryRecordType
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public SummaryRecordType()
		{
			_elementName = "SummaryRecordType";
			Init();
		}
		public SummaryRecordType(String elementName)
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
			m_IdentifierCol = new CSW.XmlObjectCollection<AA.SubGrpidentifier>("identifier", "http://www.opengis.net/cat/csw/2.0.2", 1, -1, true);
			m_TitleCol = new CSW.XmlObjectCollection<AA.SubGrptitle>("title", "http://www.opengis.net/cat/csw/2.0.2", 1, -1, true);
			m_Type = null;
			m_SubjectCol = new CSW.XmlAbstractObjectCollection<AA.ISimpleLiteral>("subject", "http://purl.org/dc/elements/1.1/", 0, -1, typeof(AA.ClassFactory), "ISimpleLiteralCreateObject");
			m_FormatCol = new CSW.XmlObjectCollection<AA.SubGrpformat>("format", "http://www.opengis.net/cat/csw/2.0.2", 0, -1, true);
			m_RelationCol = new CSW.XmlObjectCollection<AA.SubGrprelation>("relation", "http://www.opengis.net/cat/csw/2.0.2", 0, -1, true);
			m_ModifiedCol = new CSW.XmlObjectCollection<AB.Modified>("modified", "http://purl.org/dc/terms/", 0, -1, false);
			m_AbstractCol = new CSW.XmlObjectCollection<AB.abstract_>("abstract", "http://purl.org/dc/terms/", 0, -1, false);
			m_SpatialCol = new CSW.XmlObjectCollection<AB.Spatial>("spatial", "http://purl.org/dc/terms/", 0, -1, false);
			m_BoundingBoxCol = new CSW.XmlObjectCollection<ows.SubGrpBoundingBox>("BoundingBox", "http://www.opengis.net/cat/csw/2.0.2", 0, -1, true);



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
			csw.SummaryRecordType newObject = new csw.SummaryRecordType(_elementName);
			foreach (AA.SubGrpidentifier o in m_IdentifierCol)
				newObject.m_IdentifierCol.Add((AA.SubGrpidentifier)o.Clone());
			foreach (AA.SubGrptitle o in m_TitleCol)
				newObject.m_TitleCol.Add((AA.SubGrptitle)o.Clone());
			newObject.m_Type = null;
			if (m_Type != null)
				newObject.m_Type = (AA.ISimpleLiteral)m_Type.Clone();
			foreach (AA.ISimpleLiteral o in m_SubjectCol)
				newObject.m_SubjectCol.Add((AA.ISimpleLiteral)o.Clone());
			foreach (AA.SubGrpformat o in m_FormatCol)
				newObject.m_FormatCol.Add((AA.SubGrpformat)o.Clone());
			foreach (AA.SubGrprelation o in m_RelationCol)
				newObject.m_RelationCol.Add((AA.SubGrprelation)o.Clone());
			foreach (AB.Modified o in m_ModifiedCol)
				newObject.m_ModifiedCol.Add((AB.Modified)o.Clone());
			foreach (AB.abstract_ o in m_AbstractCol)
				newObject.m_AbstractCol.Add((AB.abstract_)o.Clone());
			foreach (AB.Spatial o in m_SpatialCol)
				newObject.m_SpatialCol.Add((AB.Spatial)o.Clone());
			foreach (ows.SubGrpBoundingBox o in m_BoundingBoxCol)
				newObject.m_BoundingBoxCol.Add((ows.SubGrpBoundingBox)o.Clone());


// ##HAND_CODED_BLOCK_START ID="Additional clone"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional clone code here...

// ##HAND_CODED_BLOCK_END ID="Additional clone"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

			return newObject;
		}
		#endregion

		#region Member variables

		protected override String TargetNamespace
		{
			get { return "http://www.opengis.net/cat/csw/2.0.2"; }
		}

		#region Attribute - identifier
		/// <summary>
		/// 	A collection of identifierCols
		///		
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>This collection may contain 1 to Many objects.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsCol("identifier", "http://www.opengis.net/cat/csw/2.0.2", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement)]
		public CSW.XmlObjectCollection<AA.SubGrpidentifier> IdentifierCol
		{
			get { return m_IdentifierCol; }
		}
		protected CSW.XmlObjectCollection<AA.SubGrpidentifier> m_IdentifierCol;
		
		#endregion

		#region Attribute - title
		/// <summary>
		/// 	A collection of titleCols
		///		
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>This collection may contain 1 to Many objects.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsCol("title", "http://www.opengis.net/cat/csw/2.0.2", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement)]
		public CSW.XmlObjectCollection<AA.SubGrptitle> TitleCol
		{
			get { return m_TitleCol; }
		}
		protected CSW.XmlObjectCollection<AA.SubGrptitle> m_TitleCol;
		
		#endregion

		#region Attribute - type
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqAbsClsOpt("type", "http://purl.org/dc/elements/1.1/", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AA.ClassFactory), "ISimpleLiteralCreateObject")]
		public AA.ISimpleLiteral Type
		{
			get 
			{ 
				return m_Type;  
			}
			set 
			{ 
				if (value == null)
					m_Type = null;
				else
				{
					m_Type = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "type");
				}
			}
		}
		protected AA.ISimpleLiteral m_Type;

		#endregion

		#region Attribute - subject
		/// <summary>
		/// 	A collection of subjectCols
		///		
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>This collection may contain 0 to Many objects.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqAbsClsCol("subject", "http://purl.org/dc/elements/1.1/", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element)]
		public CSW.XmlAbstractObjectCollection<AA.ISimpleLiteral> SubjectCol
		{
			get { return m_SubjectCol;  }
		}
		protected CSW.XmlAbstractObjectCollection<AA.ISimpleLiteral> m_SubjectCol;
		
		#endregion

		#region Attribute - format
		/// <summary>
		/// 	A collection of formatCols
		///		
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>This collection may contain 0 to Many objects.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsCol("format", "http://www.opengis.net/cat/csw/2.0.2", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement)]
		public CSW.XmlObjectCollection<AA.SubGrpformat> FormatCol
		{
			get { return m_FormatCol; }
		}
		protected CSW.XmlObjectCollection<AA.SubGrpformat> m_FormatCol;
		
		#endregion

		#region Attribute - relation
		/// <summary>
		/// 	A collection of relationCols
		///		
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>This collection may contain 0 to Many objects.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsCol("relation", "http://www.opengis.net/cat/csw/2.0.2", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement)]
		public CSW.XmlObjectCollection<AA.SubGrprelation> RelationCol
		{
			get { return m_RelationCol; }
		}
		protected CSW.XmlObjectCollection<AA.SubGrprelation> m_RelationCol;
		
		#endregion

		#region Attribute - modified
		/// <summary>
		/// 	A collection of modifiedCols
		///		
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>This collection may contain 0 to Many objects.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsCol("modified", "http://purl.org/dc/terms/", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element)]
		public CSW.XmlObjectCollection<AB.Modified> ModifiedCol
		{
			get { return m_ModifiedCol; }
		}
		protected CSW.XmlObjectCollection<AB.Modified> m_ModifiedCol;
		
		#endregion

		#region Attribute - abstract
		/// <summary>
		/// 	A collection of abstractCols
		///		
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>This collection may contain 0 to Many objects.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsCol("abstract", "http://purl.org/dc/terms/", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element)]
		public CSW.XmlObjectCollection<AB.abstract_> AbstractCol
		{
			get { return m_AbstractCol; }
		}
		protected CSW.XmlObjectCollection<AB.abstract_> m_AbstractCol;
		
		#endregion

		#region Attribute - spatial
		/// <summary>
		/// 	A collection of spatialCols
		///		
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>This collection may contain 0 to Many objects.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsCol("spatial", "http://purl.org/dc/terms/", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element)]
		public CSW.XmlObjectCollection<AB.Spatial> SpatialCol
		{
			get { return m_SpatialCol; }
		}
		protected CSW.XmlObjectCollection<AB.Spatial> m_SpatialCol;
		
		#endregion

		#region Attribute - BoundingBox
		/// <summary>
		/// 	A collection of BoundingBoxCols
		///		
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>This collection may contain 0 to Many objects.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsCol("BoundingBox", "http://www.opengis.net/cat/csw/2.0.2", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement)]
		public CSW.XmlObjectCollection<ows.SubGrpBoundingBox> BoundingBoxCol
		{
			get { return m_BoundingBoxCol; }
		}
		protected CSW.XmlObjectCollection<ows.SubGrpBoundingBox> m_BoundingBoxCol;
		
		#endregion

		#region Attribute - Namespace
		public override String Namespace
		{
			get { return "http://www.opengis.net/cat/csw/2.0.2"; }
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

