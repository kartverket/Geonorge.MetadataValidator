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
	/// 	This class represents the Element SubGrp_DiscreteCoverage
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Choice,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement,
													"SubGrp_DiscreteCoverage", "http://www.opengis.net/gml", false, false,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class SubGrp_DiscreteCoverage : CSW.XmlCommonBase
	{
		#region Constructors
		/// <summary>
		///		Constructor for SubGrp_DiscreteCoverage
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public SubGrp_DiscreteCoverage()
		{
			_elementName = "SubGrp_DiscreteCoverage";
			Init();
		}
		public SubGrp_DiscreteCoverage(String elementName)
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
			m__DiscreteCoverage = null;
			m_MultiSurfaceCoverage = null;
			m_GridCoverage = null;
			m_MultiPointCoverage = null;
			m_MultiSolidCoverage = null;
			m_RectifiedGridCoverage = null;
			m_MultiCurveCoverage = null;



			_validElement = "";
// ##HAND_CODED_BLOCK_START ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional initialization code here...

// ##HAND_CODED_BLOCK_END ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
		}
		protected void ClearChoice(string selectedElement)
		{
			m__DiscreteCoverage = null;
			m_MultiSurfaceCoverage = null;
			m_GridCoverage = null;
			m_MultiPointCoverage = null;
			m_MultiSolidCoverage = null;
			m_RectifiedGridCoverage = null;
			m_MultiCurveCoverage = null;
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
			AE.SubGrp_DiscreteCoverage newObject = new AE.SubGrp_DiscreteCoverage(_elementName);
			newObject.m__DiscreteCoverage = null;
			if (m__DiscreteCoverage != null)
				newObject.m__DiscreteCoverage = (AE.IAbstractDiscreteCoverageType)m__DiscreteCoverage.Clone();
			newObject.m_MultiSurfaceCoverage = null;
			if (m_MultiSurfaceCoverage != null)
				newObject.m_MultiSurfaceCoverage = (AE.MultiSurfaceCoverage)m_MultiSurfaceCoverage.Clone();
			newObject.m_GridCoverage = null;
			if (m_GridCoverage != null)
				newObject.m_GridCoverage = (AE.GridCoverage)m_GridCoverage.Clone();
			newObject.m_MultiPointCoverage = null;
			if (m_MultiPointCoverage != null)
				newObject.m_MultiPointCoverage = (AE.MultiPointCoverage)m_MultiPointCoverage.Clone();
			newObject.m_MultiSolidCoverage = null;
			if (m_MultiSolidCoverage != null)
				newObject.m_MultiSolidCoverage = (AE.MultiSolidCoverage)m_MultiSolidCoverage.Clone();
			newObject.m_RectifiedGridCoverage = null;
			if (m_RectifiedGridCoverage != null)
				newObject.m_RectifiedGridCoverage = (AE.RectifiedGridCoverage)m_RectifiedGridCoverage.Clone();
			newObject.m_MultiCurveCoverage = null;
			if (m_MultiCurveCoverage != null)
				newObject.m_MultiCurveCoverage = (AE.MultiCurveCoverage)m_MultiCurveCoverage.Clone();

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

		#region Attribute - _DiscreteCoverage
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
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("_DiscreteCoverage", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.ClassFactory), "IAbstractDiscreteCoverageTypeCreateObject")]
		public AE.IAbstractDiscreteCoverageType _DiscreteCoverage
		{
			get 
			{ 
				return m__DiscreteCoverage;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"_DiscreteCoverage"); // remove selection
				if (value == null)
					m__DiscreteCoverage = null;
				else
				{
					m__DiscreteCoverage = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "_DiscreteCoverage");
				}
			}
		}
		protected AE.IAbstractDiscreteCoverageType m__DiscreteCoverage;

		#endregion

		#region Attribute - MultiSurfaceCoverage
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _DiscreteCoverage
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("MultiSurfaceCoverage", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.MultiSurfaceCoverage))]
		public AE.MultiSurfaceCoverage MultiSurfaceCoverage
		{
			get 
			{ 
				return m_MultiSurfaceCoverage;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"MultiSurfaceCoverage"); // remove selection
				if (value == null)
					m_MultiSurfaceCoverage = null;
				else
				{
					m_MultiSurfaceCoverage = value; 
				}
			}
		}
		protected AE.MultiSurfaceCoverage m_MultiSurfaceCoverage;
		
		#endregion

		#region Attribute - GridCoverage
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _DiscreteCoverage
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("GridCoverage", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.GridCoverage))]
		public AE.GridCoverage GridCoverage
		{
			get 
			{ 
				return m_GridCoverage;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"GridCoverage"); // remove selection
				if (value == null)
					m_GridCoverage = null;
				else
				{
					m_GridCoverage = value; 
				}
			}
		}
		protected AE.GridCoverage m_GridCoverage;
		
		#endregion

		#region Attribute - MultiPointCoverage
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _DiscreteCoverage
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("MultiPointCoverage", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.MultiPointCoverage))]
		public AE.MultiPointCoverage MultiPointCoverage
		{
			get 
			{ 
				return m_MultiPointCoverage;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"MultiPointCoverage"); // remove selection
				if (value == null)
					m_MultiPointCoverage = null;
				else
				{
					m_MultiPointCoverage = value; 
				}
			}
		}
		protected AE.MultiPointCoverage m_MultiPointCoverage;
		
		#endregion

		#region Attribute - MultiSolidCoverage
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _DiscreteCoverage
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("MultiSolidCoverage", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.MultiSolidCoverage))]
		public AE.MultiSolidCoverage MultiSolidCoverage
		{
			get 
			{ 
				return m_MultiSolidCoverage;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"MultiSolidCoverage"); // remove selection
				if (value == null)
					m_MultiSolidCoverage = null;
				else
				{
					m_MultiSolidCoverage = value; 
				}
			}
		}
		protected AE.MultiSolidCoverage m_MultiSolidCoverage;
		
		#endregion

		#region Attribute - RectifiedGridCoverage
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _DiscreteCoverage
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("RectifiedGridCoverage", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.RectifiedGridCoverage))]
		public AE.RectifiedGridCoverage RectifiedGridCoverage
		{
			get 
			{ 
				return m_RectifiedGridCoverage;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"RectifiedGridCoverage"); // remove selection
				if (value == null)
					m_RectifiedGridCoverage = null;
				else
				{
					m_RectifiedGridCoverage = value; 
				}
			}
		}
		protected AE.RectifiedGridCoverage m_RectifiedGridCoverage;
		
		#endregion

		#region Attribute - MultiCurveCoverage
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _DiscreteCoverage
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("MultiCurveCoverage", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.MultiCurveCoverage))]
		public AE.MultiCurveCoverage MultiCurveCoverage
		{
			get 
			{ 
				return m_MultiCurveCoverage;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"MultiCurveCoverage"); // remove selection
				if (value == null)
					m_MultiCurveCoverage = null;
				else
				{
					m_MultiCurveCoverage = value; 
				}
			}
		}
		protected AE.MultiCurveCoverage m_MultiCurveCoverage;
		
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


