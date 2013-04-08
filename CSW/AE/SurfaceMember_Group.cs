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
	/// 	This class represents the Element surfaceMember_Group
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Choice,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement,
													"surfaceMember_Group", "http://www.opengis.net/gml", false, false,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class SurfaceMember_Group : CSW.XmlCommonBase
	{
		#region Constructors
		/// <summary>
		///		Constructor for SurfaceMember_Group
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public SurfaceMember_Group()
		{
			_elementName = "surfaceMember_Group";
			Init();
		}
		public SurfaceMember_Group(String elementName)
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
			m__Surface = null;
			m_CompositeSurface = null;
			m_Polygon = null;
			m_SubGrpSurface = null;
			m_OrientableSurface = null;



			_validElement = "";
// ##HAND_CODED_BLOCK_START ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional initialization code here...

// ##HAND_CODED_BLOCK_END ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
		}
		protected void ClearChoice(string selectedElement)
		{
			m__Surface = null;
			m_CompositeSurface = null;
			m_Polygon = null;
			m_SubGrpSurface = null;
			m_OrientableSurface = null;
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
			AE.SurfaceMember_Group newObject = new AE.SurfaceMember_Group(_elementName);
			newObject.m__Surface = null;
			if (m__Surface != null)
				newObject.m__Surface = (AE.IAbstractSurfaceType)m__Surface.Clone();
			newObject.m_CompositeSurface = null;
			if (m_CompositeSurface != null)
				newObject.m_CompositeSurface = (AE.CompositeSurface)m_CompositeSurface.Clone();
			newObject.m_Polygon = null;
			if (m_Polygon != null)
				newObject.m_Polygon = (AE.Polygon)m_Polygon.Clone();
			newObject.m_SubGrpSurface = null;
			if (m_SubGrpSurface != null)
				newObject.m_SubGrpSurface = (AE.SubGrpSurface)m_SubGrpSurface.Clone();
			newObject.m_OrientableSurface = null;
			if (m_OrientableSurface != null)
				newObject.m_OrientableSurface = (AE.OrientableSurface)m_OrientableSurface.Clone();

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

		#region Attribute - _Surface
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
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("_Surface", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.ClassFactory), "IAbstractSurfaceTypeCreateObject")]
		public AE.IAbstractSurfaceType _Surface
		{
			get 
			{ 
				return m__Surface;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"_Surface"); // remove selection
				if (value == null)
					m__Surface = null;
				else
				{
					m__Surface = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "_Surface");
				}
			}
		}
		protected AE.IAbstractSurfaceType m__Surface;

		#endregion

		#region Attribute - CompositeSurface
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _Surface
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("CompositeSurface", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.CompositeSurface))]
		public AE.CompositeSurface CompositeSurface
		{
			get 
			{ 
				return m_CompositeSurface;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"CompositeSurface"); // remove selection
				if (value == null)
					m_CompositeSurface = null;
				else
				{
					m_CompositeSurface = value; 
				}
			}
		}
		protected AE.CompositeSurface m_CompositeSurface;
		
		#endregion

		#region Attribute - Polygon
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _Surface
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("Polygon", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.Polygon))]
		public AE.Polygon Polygon
		{
			get 
			{ 
				return m_Polygon;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"Polygon"); // remove selection
				if (value == null)
					m_Polygon = null;
				else
				{
					m_Polygon = value; 
				}
			}
		}
		protected AE.Polygon m_Polygon;
		
		#endregion

		#region Attribute - SubGrpSurface
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _Surface
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("SubGrpSurface", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement, typeof(AE.SubGrpSurface))]
		public AE.SubGrpSurface SubGrpSurface
		{
			get 
			{ 
				return m_SubGrpSurface;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"SubGrpSurface"); // remove selection
				if (value == null)
					m_SubGrpSurface = null;
				else
				{
					m_SubGrpSurface = value; 
				}
			}
		}
		protected AE.SubGrpSurface m_SubGrpSurface;
		
		#endregion

		#region Attribute - OrientableSurface
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _Surface
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("OrientableSurface", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.OrientableSurface))]
		public AE.OrientableSurface OrientableSurface
		{
			get 
			{ 
				return m_OrientableSurface;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"OrientableSurface"); // remove selection
				if (value == null)
					m_OrientableSurface = null;
				else
				{
					m_OrientableSurface = value; 
				}
			}
		}
		protected AE.OrientableSurface m_OrientableSurface;
		
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


