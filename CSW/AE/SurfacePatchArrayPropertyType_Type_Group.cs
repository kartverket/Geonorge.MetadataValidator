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
	/// 	This class represents the Element SurfacePatchArrayPropertyType_Type_Group
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Choice,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement,
													"SurfacePatchArrayPropertyType_Type_Group", "http://www.opengis.net/gml", false, false,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class SurfacePatchArrayPropertyType_Type_Group : CSW.XmlCommonBase
	{
		#region Constructors
		/// <summary>
		///		Constructor for SurfacePatchArrayPropertyType_Type_Group
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public SurfacePatchArrayPropertyType_Type_Group()
		{
			_elementName = "SurfacePatchArrayPropertyType_Type_Group";
			Init();
		}
		public SurfacePatchArrayPropertyType_Type_Group(String elementName)
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
			m__SurfacePatch = null;
			m__ParametricCurveSurface = null;
			m_SubGrp_ParametricCurveSurface = null;
			m_PolygonPatch = null;
			m_Triangle = null;
			m_Rectangle = null;



			_validElement = "";
// ##HAND_CODED_BLOCK_START ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional initialization code here...

// ##HAND_CODED_BLOCK_END ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
		}
		protected void ClearChoice(string selectedElement)
		{
			m__SurfacePatch = null;
			m__ParametricCurveSurface = null;
			m_SubGrp_ParametricCurveSurface = null;
			m_PolygonPatch = null;
			m_Triangle = null;
			m_Rectangle = null;
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
			AE.SurfacePatchArrayPropertyType_Type_Group newObject = new AE.SurfacePatchArrayPropertyType_Type_Group(_elementName);
			newObject.m__SurfacePatch = null;
			if (m__SurfacePatch != null)
				newObject.m__SurfacePatch = (AE.IAbstractSurfacePatchType)m__SurfacePatch.Clone();
			newObject.m__ParametricCurveSurface = null;
			if (m__ParametricCurveSurface != null)
				newObject.m__ParametricCurveSurface = (AE.IAbstractParametricCurveSurfaceType)m__ParametricCurveSurface.Clone();
			newObject.m_SubGrp_ParametricCurveSurface = null;
			if (m_SubGrp_ParametricCurveSurface != null)
				newObject.m_SubGrp_ParametricCurveSurface = (AE.SubGrp_ParametricCurveSurface)m_SubGrp_ParametricCurveSurface.Clone();
			newObject.m_PolygonPatch = null;
			if (m_PolygonPatch != null)
				newObject.m_PolygonPatch = (AE.PolygonPatch)m_PolygonPatch.Clone();
			newObject.m_Triangle = null;
			if (m_Triangle != null)
				newObject.m_Triangle = (AE.Triangle)m_Triangle.Clone();
			newObject.m_Rectangle = null;
			if (m_Rectangle != null)
				newObject.m_Rectangle = (AE.Rectangle)m_Rectangle.Clone();

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

		#region Attribute - _SurfacePatch
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
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("_SurfacePatch", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.ClassFactory), "IAbstractSurfacePatchTypeCreateObject")]
		public AE.IAbstractSurfacePatchType _SurfacePatch
		{
			get 
			{ 
				return m__SurfacePatch;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"_SurfacePatch"); // remove selection
				if (value == null)
					m__SurfacePatch = null;
				else
				{
					m__SurfacePatch = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "_SurfacePatch");
				}
			}
		}
		protected AE.IAbstractSurfacePatchType m__SurfacePatch;

		#endregion

		#region Attribute - _ParametricCurveSurface
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _SurfacePatch
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("_ParametricCurveSurface", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.ClassFactory), "IAbstractParametricCurveSurfaceTypeCreateObject")]
		public AE.IAbstractParametricCurveSurfaceType _ParametricCurveSurface
		{
			get 
			{ 
				return m__ParametricCurveSurface;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"_ParametricCurveSurface"); // remove selection
				if (value == null)
					m__ParametricCurveSurface = null;
				else
				{
					m__ParametricCurveSurface = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "_ParametricCurveSurface");
				}
			}
		}
		protected AE.IAbstractParametricCurveSurfaceType m__ParametricCurveSurface;

		#endregion

		#region Attribute - SubGrp_ParametricCurveSurface
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _SurfacePatch
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("SubGrp_ParametricCurveSurface", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement, typeof(AE.SubGrp_ParametricCurveSurface))]
		public AE.SubGrp_ParametricCurveSurface SubGrp_ParametricCurveSurface
		{
			get 
			{ 
				return m_SubGrp_ParametricCurveSurface;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"SubGrp_ParametricCurveSurface"); // remove selection
				if (value == null)
					m_SubGrp_ParametricCurveSurface = null;
				else
				{
					m_SubGrp_ParametricCurveSurface = value; 
				}
			}
		}
		protected AE.SubGrp_ParametricCurveSurface m_SubGrp_ParametricCurveSurface;
		
		#endregion

		#region Attribute - PolygonPatch
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _SurfacePatch
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("PolygonPatch", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.PolygonPatch))]
		public AE.PolygonPatch PolygonPatch
		{
			get 
			{ 
				return m_PolygonPatch;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"PolygonPatch"); // remove selection
				if (value == null)
					m_PolygonPatch = null;
				else
				{
					m_PolygonPatch = value; 
				}
			}
		}
		protected AE.PolygonPatch m_PolygonPatch;
		
		#endregion

		#region Attribute - Triangle
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _SurfacePatch
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("Triangle", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.Triangle))]
		public AE.Triangle Triangle
		{
			get 
			{ 
				return m_Triangle;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"Triangle"); // remove selection
				if (value == null)
					m_Triangle = null;
				else
				{
					m_Triangle = value; 
				}
			}
		}
		protected AE.Triangle m_Triangle;
		
		#endregion

		#region Attribute - Rectangle
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _SurfacePatch
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("Rectangle", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.Rectangle))]
		public AE.Rectangle Rectangle
		{
			get 
			{ 
				return m_Rectangle;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"Rectangle"); // remove selection
				if (value == null)
					m_Rectangle = null;
				else
				{
					m_Rectangle = value; 
				}
			}
		}
		protected AE.Rectangle m_Rectangle;
		
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


