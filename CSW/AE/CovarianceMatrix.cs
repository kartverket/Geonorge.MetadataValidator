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
	/// 	This class represents the Element covarianceMatrix
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Sequence,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element,
													"covarianceMatrix", "http://www.opengis.net/gml", true, true,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class CovarianceMatrix : CSW.XmlCommonBase
					, AE.IAbstractPositionalAccuracyType
	{
		#region Constructors
		/// <summary>
		///		Constructor for CovarianceMatrix
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public CovarianceMatrix()
		{
			_elementName = "covarianceMatrix";
			Init();
		}
		public CovarianceMatrix(String elementName)
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
			m_MeasureDescription = null;
			m_UnitOfMeasureCol = new CSW.XmlAbstractObjectCollection<AE.IUnitOfMeasureType>("unitOfMeasure", "http://www.opengis.net/gml", 1, -1, typeof(AE.ClassFactory), "IUnitOfMeasureTypeCreateObject");
			m_IncludesElementCol = new CSW.XmlObjectCollection<AE.IncludesElement>("includesElement", "http://www.opengis.net/gml", 1, -1, false);



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
			AE.CovarianceMatrix newObject = new AE.CovarianceMatrix(_elementName);
			newObject.m_MeasureDescription = null;
			if (m_MeasureDescription != null)
				newObject.m_MeasureDescription = (AE.ICodeType)m_MeasureDescription.Clone();
			foreach (AE.IUnitOfMeasureType o in m_UnitOfMeasureCol)
				newObject.m_UnitOfMeasureCol.Add((AE.IUnitOfMeasureType)o.Clone());
			foreach (AE.IncludesElement o in m_IncludesElementCol)
				newObject.m_IncludesElementCol.Add((AE.IncludesElement)o.Clone());


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

		#region Attribute - measureDescription
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqAbsClsOpt("measureDescription", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.ClassFactory), "ICodeTypeCreateObject")]
		public AE.ICodeType MeasureDescription
		{
			get 
			{ 
				return m_MeasureDescription;  
			}
			set 
			{ 
				if (value == null)
					m_MeasureDescription = null;
				else
				{
					m_MeasureDescription = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "measureDescription");
				}
			}
		}
		protected AE.ICodeType m_MeasureDescription;

		#endregion

		#region Attribute - unitOfMeasure
		/// <summary>
		/// 	A collection of unitOfMeasureCols
		///		
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>This collection may contain 1 to Many objects.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqAbsClsCol("unitOfMeasure", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element)]
		public CSW.XmlAbstractObjectCollection<AE.IUnitOfMeasureType> UnitOfMeasureCol
		{
			get { return m_UnitOfMeasureCol;  }
		}
		protected CSW.XmlAbstractObjectCollection<AE.IUnitOfMeasureType> m_UnitOfMeasureCol;
		
		#endregion

		#region Attribute - includesElement
		/// <summary>
		/// 	A collection of includesElementCols
		///		
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>This collection may contain 1 to Many objects.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsCol("includesElement", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element)]
		public CSW.XmlObjectCollection<AE.IncludesElement> IncludesElementCol
		{
			get { return m_IncludesElementCol; }
		}
		protected CSW.XmlObjectCollection<AE.IncludesElement> m_IncludesElementCol;
		
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


