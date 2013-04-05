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
	/// 	This class represents the ComplexType TrianglePatchArrayPropertyType
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Sequence,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element,
													"TrianglePatchArrayPropertyType", "http://www.opengis.net/gml", false, true,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class TrianglePatchArrayPropertyType : CSW.XmlCommonBase
					, AE.ISurfacePatchArrayPropertyType
	{
		#region Constructors
		/// <summary>
		///		Constructor for TrianglePatchArrayPropertyType
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public TrianglePatchArrayPropertyType()
		{
			_elementName = "TrianglePatchArrayPropertyType";
			Init();
		}
		public TrianglePatchArrayPropertyType(String elementName)
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
			m_SurfacePatchArrayPropertyTypeDataCol = new CSW.XmlObjectCollection<AE.SurfacePatchArrayPropertyType_Type>("SurfacePatchArrayPropertyTypeData", "http://www.opengis.net/gml", 0, -1, true);
			m_TrianglePatchArrayPropertyTypeDataCol = new CSW.XmlObjectCollection<AE.TrianglePatchArrayPropertyType_Type>("TrianglePatchArrayPropertyTypeData", "http://www.opengis.net/gml", 0, -1, true);



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
			AE.TrianglePatchArrayPropertyType newObject = new AE.TrianglePatchArrayPropertyType(_elementName);
			foreach (AE.SurfacePatchArrayPropertyType_Type o in m_SurfacePatchArrayPropertyTypeDataCol)
				newObject.m_SurfacePatchArrayPropertyTypeDataCol.Add((AE.SurfacePatchArrayPropertyType_Type)o.Clone());
			foreach (AE.TrianglePatchArrayPropertyType_Type o in m_TrianglePatchArrayPropertyTypeDataCol)
				newObject.m_TrianglePatchArrayPropertyTypeDataCol.Add((AE.TrianglePatchArrayPropertyType_Type)o.Clone());


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

		#region Attribute - SurfacePatchArrayPropertyTypeData
		/// <summary>
		/// 	A collection of SurfacePatchArrayPropertyTypeDataCols
		///		Holds all the information contained within the element
		/// </summary>
		/// <remarks>
		/// 	<BR>Because this is a base type, all the objects in it must be contained within a second class. This means all classes supporting this interface can expose use the same interface regardless of how they are extended.</BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>This collection may contain 0 to Many objects.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsCol("SurfacePatchArrayPropertyTypeData", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement)]
		public CSW.XmlObjectCollection<AE.SurfacePatchArrayPropertyType_Type> SurfacePatchArrayPropertyTypeDataCol
		{
			get { return m_SurfacePatchArrayPropertyTypeDataCol; }
		}
		protected CSW.XmlObjectCollection<AE.SurfacePatchArrayPropertyType_Type> m_SurfacePatchArrayPropertyTypeDataCol;
		
		#endregion

		#region Attribute - TrianglePatchArrayPropertyTypeData
		/// <summary>
		/// 	A collection of TrianglePatchArrayPropertyTypeDataCols
		///		Holds all the information contained within the element
		/// </summary>
		/// <remarks>
		/// 	<BR>Because this is a base type, all the objects in it must be contained within a second class. This means all classes supporting this interface can expose use the same interface regardless of how they are extended.</BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>This collection may contain 0 to Many objects.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsCol("TrianglePatchArrayPropertyTypeData", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement)]
		public CSW.XmlObjectCollection<AE.TrianglePatchArrayPropertyType_Type> TrianglePatchArrayPropertyTypeDataCol
		{
			get { return m_TrianglePatchArrayPropertyTypeDataCol; }
		}
		protected CSW.XmlObjectCollection<AE.TrianglePatchArrayPropertyType_Type> m_TrianglePatchArrayPropertyTypeDataCol;
		
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


