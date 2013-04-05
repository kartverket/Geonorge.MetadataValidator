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
	/// 	This class represents the Element SubGrp_CurveSegment
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Choice,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement,
													"SubGrp_CurveSegment", "http://www.opengis.net/gml", false, false,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class SubGrp_CurveSegment : CSW.XmlCommonBase
	{
		#region Constructors
		/// <summary>
		///		Constructor for SubGrp_CurveSegment
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public SubGrp_CurveSegment()
		{
			_elementName = "SubGrp_CurveSegment";
			Init();
		}
		public SubGrp_CurveSegment(String elementName)
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
			m__CurveSegment = null;
			m_OffsetCurve = null;
			m_SubGrpGeodesicString = null;
			m_SubGrpArcString = null;
			m_LineStringSegment = null;
			m_Clothoid = null;
			m_SubGrpArcStringByBulge = null;
			m_SubGrpArcByCenterPoint = null;
			m_CubicSpline = null;
			m_SubGrpBSpline = null;



			_validElement = "";
// ##HAND_CODED_BLOCK_START ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional initialization code here...

// ##HAND_CODED_BLOCK_END ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
		}
		protected void ClearChoice(string selectedElement)
		{
			m__CurveSegment = null;
			m_OffsetCurve = null;
			m_SubGrpGeodesicString = null;
			m_SubGrpArcString = null;
			m_LineStringSegment = null;
			m_Clothoid = null;
			m_SubGrpArcStringByBulge = null;
			m_SubGrpArcByCenterPoint = null;
			m_CubicSpline = null;
			m_SubGrpBSpline = null;
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
			AE.SubGrp_CurveSegment newObject = new AE.SubGrp_CurveSegment(_elementName);
			newObject.m__CurveSegment = null;
			if (m__CurveSegment != null)
				newObject.m__CurveSegment = (AE.IAbstractCurveSegmentType)m__CurveSegment.Clone();
			newObject.m_OffsetCurve = null;
			if (m_OffsetCurve != null)
				newObject.m_OffsetCurve = (AE.OffsetCurve)m_OffsetCurve.Clone();
			newObject.m_SubGrpGeodesicString = null;
			if (m_SubGrpGeodesicString != null)
				newObject.m_SubGrpGeodesicString = (AE.SubGrpGeodesicString)m_SubGrpGeodesicString.Clone();
			newObject.m_SubGrpArcString = null;
			if (m_SubGrpArcString != null)
				newObject.m_SubGrpArcString = (AE.SubGrpArcString)m_SubGrpArcString.Clone();
			newObject.m_LineStringSegment = null;
			if (m_LineStringSegment != null)
				newObject.m_LineStringSegment = (AE.LineStringSegment)m_LineStringSegment.Clone();
			newObject.m_Clothoid = null;
			if (m_Clothoid != null)
				newObject.m_Clothoid = (AE.Clothoid)m_Clothoid.Clone();
			newObject.m_SubGrpArcStringByBulge = null;
			if (m_SubGrpArcStringByBulge != null)
				newObject.m_SubGrpArcStringByBulge = (AE.SubGrpArcStringByBulge)m_SubGrpArcStringByBulge.Clone();
			newObject.m_SubGrpArcByCenterPoint = null;
			if (m_SubGrpArcByCenterPoint != null)
				newObject.m_SubGrpArcByCenterPoint = (AE.SubGrpArcByCenterPoint)m_SubGrpArcByCenterPoint.Clone();
			newObject.m_CubicSpline = null;
			if (m_CubicSpline != null)
				newObject.m_CubicSpline = (AE.CubicSpline)m_CubicSpline.Clone();
			newObject.m_SubGrpBSpline = null;
			if (m_SubGrpBSpline != null)
				newObject.m_SubGrpBSpline = (AE.SubGrpBSpline)m_SubGrpBSpline.Clone();

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

		#region Attribute - _CurveSegment
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
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("_CurveSegment", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.ClassFactory), "IAbstractCurveSegmentTypeCreateObject")]
		public AE.IAbstractCurveSegmentType _CurveSegment
		{
			get 
			{ 
				return m__CurveSegment;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"_CurveSegment"); // remove selection
				if (value == null)
					m__CurveSegment = null;
				else
				{
					m__CurveSegment = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "_CurveSegment");
				}
			}
		}
		protected AE.IAbstractCurveSegmentType m__CurveSegment;

		#endregion

		#region Attribute - OffsetCurve
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _CurveSegment
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("OffsetCurve", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.OffsetCurve))]
		public AE.OffsetCurve OffsetCurve
		{
			get 
			{ 
				return m_OffsetCurve;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"OffsetCurve"); // remove selection
				if (value == null)
					m_OffsetCurve = null;
				else
				{
					m_OffsetCurve = value; 
				}
			}
		}
		protected AE.OffsetCurve m_OffsetCurve;
		
		#endregion

		#region Attribute - SubGrpGeodesicString
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _CurveSegment
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("SubGrpGeodesicString", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement, typeof(AE.SubGrpGeodesicString))]
		public AE.SubGrpGeodesicString SubGrpGeodesicString
		{
			get 
			{ 
				return m_SubGrpGeodesicString;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"SubGrpGeodesicString"); // remove selection
				if (value == null)
					m_SubGrpGeodesicString = null;
				else
				{
					m_SubGrpGeodesicString = value; 
				}
			}
		}
		protected AE.SubGrpGeodesicString m_SubGrpGeodesicString;
		
		#endregion

		#region Attribute - SubGrpArcString
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _CurveSegment
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("SubGrpArcString", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement, typeof(AE.SubGrpArcString))]
		public AE.SubGrpArcString SubGrpArcString
		{
			get 
			{ 
				return m_SubGrpArcString;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"SubGrpArcString"); // remove selection
				if (value == null)
					m_SubGrpArcString = null;
				else
				{
					m_SubGrpArcString = value; 
				}
			}
		}
		protected AE.SubGrpArcString m_SubGrpArcString;
		
		#endregion

		#region Attribute - LineStringSegment
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _CurveSegment
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("LineStringSegment", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.LineStringSegment))]
		public AE.LineStringSegment LineStringSegment
		{
			get 
			{ 
				return m_LineStringSegment;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"LineStringSegment"); // remove selection
				if (value == null)
					m_LineStringSegment = null;
				else
				{
					m_LineStringSegment = value; 
				}
			}
		}
		protected AE.LineStringSegment m_LineStringSegment;
		
		#endregion

		#region Attribute - Clothoid
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _CurveSegment
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("Clothoid", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.Clothoid))]
		public AE.Clothoid Clothoid
		{
			get 
			{ 
				return m_Clothoid;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"Clothoid"); // remove selection
				if (value == null)
					m_Clothoid = null;
				else
				{
					m_Clothoid = value; 
				}
			}
		}
		protected AE.Clothoid m_Clothoid;
		
		#endregion

		#region Attribute - SubGrpArcStringByBulge
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _CurveSegment
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("SubGrpArcStringByBulge", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement, typeof(AE.SubGrpArcStringByBulge))]
		public AE.SubGrpArcStringByBulge SubGrpArcStringByBulge
		{
			get 
			{ 
				return m_SubGrpArcStringByBulge;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"SubGrpArcStringByBulge"); // remove selection
				if (value == null)
					m_SubGrpArcStringByBulge = null;
				else
				{
					m_SubGrpArcStringByBulge = value; 
				}
			}
		}
		protected AE.SubGrpArcStringByBulge m_SubGrpArcStringByBulge;
		
		#endregion

		#region Attribute - SubGrpArcByCenterPoint
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _CurveSegment
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("SubGrpArcByCenterPoint", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement, typeof(AE.SubGrpArcByCenterPoint))]
		public AE.SubGrpArcByCenterPoint SubGrpArcByCenterPoint
		{
			get 
			{ 
				return m_SubGrpArcByCenterPoint;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"SubGrpArcByCenterPoint"); // remove selection
				if (value == null)
					m_SubGrpArcByCenterPoint = null;
				else
				{
					m_SubGrpArcByCenterPoint = value; 
				}
			}
		}
		protected AE.SubGrpArcByCenterPoint m_SubGrpArcByCenterPoint;
		
		#endregion

		#region Attribute - CubicSpline
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _CurveSegment
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("CubicSpline", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.CubicSpline))]
		public AE.CubicSpline CubicSpline
		{
			get 
			{ 
				return m_CubicSpline;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"CubicSpline"); // remove selection
				if (value == null)
					m_CubicSpline = null;
				else
				{
					m_CubicSpline = value; 
				}
			}
		}
		protected AE.CubicSpline m_CubicSpline;
		
		#endregion

		#region Attribute - SubGrpBSpline
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _CurveSegment
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("SubGrpBSpline", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement, typeof(AE.SubGrpBSpline))]
		public AE.SubGrpBSpline SubGrpBSpline
		{
			get 
			{ 
				return m_SubGrpBSpline;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"SubGrpBSpline"); // remove selection
				if (value == null)
					m_SubGrpBSpline = null;
				else
				{
					m_SubGrpBSpline = value; 
				}
			}
		}
		protected AE.SubGrpBSpline m_SubGrpBSpline;
		
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


