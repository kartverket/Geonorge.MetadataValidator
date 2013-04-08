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
	/// 	This class represents the Element SubGrp_GeometricAggregate
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Choice,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement,
													"SubGrp_GeometricAggregate", "http://www.opengis.net/gml", false, false,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class SubGrp_GeometricAggregate : CSW.XmlCommonBase
	{
		#region Constructors
		/// <summary>
		///		Constructor for SubGrp_GeometricAggregate
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public SubGrp_GeometricAggregate()
		{
			_elementName = "SubGrp_GeometricAggregate";
			Init();
		}
		public SubGrp_GeometricAggregate(String elementName)
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
			m__GeometricAggregate = null;
			m_MultiSolid = null;
			m_MultiLineString = null;
			m_MultiPolygon = null;
			m_MultiCurve = null;
			m_MultiGeometry = null;
			m_MultiPoint = null;
			m_MultiSurface = null;



			_validElement = "";
// ##HAND_CODED_BLOCK_START ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional initialization code here...

// ##HAND_CODED_BLOCK_END ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
		}
		protected void ClearChoice(string selectedElement)
		{
			m__GeometricAggregate = null;
			m_MultiSolid = null;
			m_MultiLineString = null;
			m_MultiPolygon = null;
			m_MultiCurve = null;
			m_MultiGeometry = null;
			m_MultiPoint = null;
			m_MultiSurface = null;
			_validElement = selectedElement;
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
			AE.SubGrp_GeometricAggregate newObject = new AE.SubGrp_GeometricAggregate(_elementName);
			newObject.m__GeometricAggregate = null;
			if (m__GeometricAggregate != null)
				newObject.m__GeometricAggregate = (AE.IAbstractGeometricAggregateType)m__GeometricAggregate.Clone();
			newObject.m_MultiSolid = null;
			if (m_MultiSolid != null)
				newObject.m_MultiSolid = (AE.MultiSolid)m_MultiSolid.Clone();
			newObject.m_MultiLineString = null;
			if (m_MultiLineString != null)
				newObject.m_MultiLineString = (AE.MultiLineString)m_MultiLineString.Clone();
			newObject.m_MultiPolygon = null;
			if (m_MultiPolygon != null)
				newObject.m_MultiPolygon = (AE.MultiPolygon)m_MultiPolygon.Clone();
			newObject.m_MultiCurve = null;
			if (m_MultiCurve != null)
				newObject.m_MultiCurve = (AE.MultiCurve)m_MultiCurve.Clone();
			newObject.m_MultiGeometry = null;
			if (m_MultiGeometry != null)
				newObject.m_MultiGeometry = (AE.MultiGeometry)m_MultiGeometry.Clone();
			newObject.m_MultiPoint = null;
			if (m_MultiPoint != null)
				newObject.m_MultiPoint = (AE.MultiPoint)m_MultiPoint.Clone();
			newObject.m_MultiSurface = null;
			if (m_MultiSurface != null)
				newObject.m_MultiSurface = (AE.MultiSurface)m_MultiSurface.Clone();

			newObject._validElement = _validElement;

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

		#region Attribute - _GeometricAggregate
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("_GeometricAggregate", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.ClassFactory), "IAbstractGeometricAggregateTypeCreateObject")]
		public AE.IAbstractGeometricAggregateType _GeometricAggregate
		{
			get 
			{ 
				return m__GeometricAggregate;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"_GeometricAggregate"); // remove selection
				if (value == null)
					m__GeometricAggregate = null;
				else
				{
					m__GeometricAggregate = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "_GeometricAggregate");
				}
			}
		}
		protected AE.IAbstractGeometricAggregateType m__GeometricAggregate;

		#endregion

		#region Attribute - MultiSolid
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _GeometricAggregate
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("MultiSolid", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.MultiSolid))]
		public AE.MultiSolid MultiSolid
		{
			get 
			{ 
				return m_MultiSolid;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"MultiSolid"); // remove selection
				if (value == null)
					m_MultiSolid = null;
				else
				{
					m_MultiSolid = value; 
				}
			}
		}
		protected AE.MultiSolid m_MultiSolid;
		
		#endregion

		#region Attribute - MultiLineString
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _GeometricAggregate
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("MultiLineString", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.MultiLineString))]
		public AE.MultiLineString MultiLineString
		{
			get 
			{ 
				return m_MultiLineString;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"MultiLineString"); // remove selection
				if (value == null)
					m_MultiLineString = null;
				else
				{
					m_MultiLineString = value; 
				}
			}
		}
		protected AE.MultiLineString m_MultiLineString;
		
		#endregion

		#region Attribute - MultiPolygon
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _GeometricAggregate
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("MultiPolygon", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.MultiPolygon))]
		public AE.MultiPolygon MultiPolygon
		{
			get 
			{ 
				return m_MultiPolygon;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"MultiPolygon"); // remove selection
				if (value == null)
					m_MultiPolygon = null;
				else
				{
					m_MultiPolygon = value; 
				}
			}
		}
		protected AE.MultiPolygon m_MultiPolygon;
		
		#endregion

		#region Attribute - MultiCurve
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _GeometricAggregate
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("MultiCurve", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.MultiCurve))]
		public AE.MultiCurve MultiCurve
		{
			get 
			{ 
				return m_MultiCurve;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"MultiCurve"); // remove selection
				if (value == null)
					m_MultiCurve = null;
				else
				{
					m_MultiCurve = value; 
				}
			}
		}
		protected AE.MultiCurve m_MultiCurve;
		
		#endregion

		#region Attribute - MultiGeometry
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _GeometricAggregate
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("MultiGeometry", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.MultiGeometry))]
		public AE.MultiGeometry MultiGeometry
		{
			get 
			{ 
				return m_MultiGeometry;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"MultiGeometry"); // remove selection
				if (value == null)
					m_MultiGeometry = null;
				else
				{
					m_MultiGeometry = value; 
				}
			}
		}
		protected AE.MultiGeometry m_MultiGeometry;
		
		#endregion

		#region Attribute - MultiPoint
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _GeometricAggregate
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("MultiPoint", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.MultiPoint))]
		public AE.MultiPoint MultiPoint
		{
			get 
			{ 
				return m_MultiPoint;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"MultiPoint"); // remove selection
				if (value == null)
					m_MultiPoint = null;
				else
				{
					m_MultiPoint = value; 
				}
			}
		}
		protected AE.MultiPoint m_MultiPoint;
		
		#endregion

		#region Attribute - MultiSurface
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _GeometricAggregate
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("MultiSurface", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.MultiSurface))]
		public AE.MultiSurface MultiSurface
		{
			get 
			{ 
				return m_MultiSurface;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"MultiSurface"); // remove selection
				if (value == null)
					m_MultiSurface = null;
				else
				{
					m_MultiSurface = value; 
				}
			}
		}
		protected AE.MultiSurface m_MultiSurface;
		
		#endregion

		public String ChoiceSelectedElement
		{
			get { return _validElement;  }
		}
		protected String _validElement;
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


