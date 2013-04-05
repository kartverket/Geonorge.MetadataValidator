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
	/// 	This class represents the Element SubGrpdomainSet
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Choice,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement,
													"SubGrpdomainSet", "http://www.opengis.net/gml", false, false,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class SubGrpdomainSet : CSW.XmlCommonBase
	{
		#region Constructors
		/// <summary>
		///		Constructor for SubGrpdomainSet
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public SubGrpdomainSet()
		{
			_elementName = "SubGrpdomainSet";
			Init();
		}
		public SubGrpdomainSet(String elementName)
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
			m_DomainSet = null;
			m_MultiSolidDomain = null;
			m_MultiPointDomain = null;
			m_GridDomain = null;
			m_MultiCurveDomain = null;
			m_RectifiedGridDomain = null;
			m_MultiSurfaceDomain = null;



			_validElement = "";
// ##HAND_CODED_BLOCK_START ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional initialization code here...

// ##HAND_CODED_BLOCK_END ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
		}
		protected void ClearChoice(string selectedElement)
		{
			m_DomainSet = null;
			m_MultiSolidDomain = null;
			m_MultiPointDomain = null;
			m_GridDomain = null;
			m_MultiCurveDomain = null;
			m_RectifiedGridDomain = null;
			m_MultiSurfaceDomain = null;
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
			AE.SubGrpdomainSet newObject = new AE.SubGrpdomainSet(_elementName);
			newObject.m_DomainSet = null;
			if (m_DomainSet != null)
				newObject.m_DomainSet = (AE.IDomainSetType)m_DomainSet.Clone();
			newObject.m_MultiSolidDomain = null;
			if (m_MultiSolidDomain != null)
				newObject.m_MultiSolidDomain = (AE.MultiSolidDomain)m_MultiSolidDomain.Clone();
			newObject.m_MultiPointDomain = null;
			if (m_MultiPointDomain != null)
				newObject.m_MultiPointDomain = (AE.MultiPointDomain)m_MultiPointDomain.Clone();
			newObject.m_GridDomain = null;
			if (m_GridDomain != null)
				newObject.m_GridDomain = (AE.GridDomain)m_GridDomain.Clone();
			newObject.m_MultiCurveDomain = null;
			if (m_MultiCurveDomain != null)
				newObject.m_MultiCurveDomain = (AE.MultiCurveDomain)m_MultiCurveDomain.Clone();
			newObject.m_RectifiedGridDomain = null;
			if (m_RectifiedGridDomain != null)
				newObject.m_RectifiedGridDomain = (AE.RectifiedGridDomain)m_RectifiedGridDomain.Clone();
			newObject.m_MultiSurfaceDomain = null;
			if (m_MultiSurfaceDomain != null)
				newObject.m_MultiSurfaceDomain = (AE.MultiSurfaceDomain)m_MultiSurfaceDomain.Clone();

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

		#region Attribute - domainSet
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
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("domainSet", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.ClassFactory), "IDomainSetTypeCreateObject")]
		public AE.IDomainSetType DomainSet
		{
			get 
			{ 
				return m_DomainSet;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"domainSet"); // remove selection
				if (value == null)
					m_DomainSet = null;
				else
				{
					m_DomainSet = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "domainSet");
				}
			}
		}
		protected AE.IDomainSetType m_DomainSet;

		#endregion

		#region Attribute - multiSolidDomain
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for domainSet
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("multiSolidDomain", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.MultiSolidDomain))]
		public AE.MultiSolidDomain MultiSolidDomain
		{
			get 
			{ 
				return m_MultiSolidDomain;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"multiSolidDomain"); // remove selection
				if (value == null)
					m_MultiSolidDomain = null;
				else
				{
					m_MultiSolidDomain = value; 
				}
			}
		}
		protected AE.MultiSolidDomain m_MultiSolidDomain;
		
		#endregion

		#region Attribute - multiPointDomain
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for domainSet
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("multiPointDomain", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.MultiPointDomain))]
		public AE.MultiPointDomain MultiPointDomain
		{
			get 
			{ 
				return m_MultiPointDomain;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"multiPointDomain"); // remove selection
				if (value == null)
					m_MultiPointDomain = null;
				else
				{
					m_MultiPointDomain = value; 
				}
			}
		}
		protected AE.MultiPointDomain m_MultiPointDomain;
		
		#endregion

		#region Attribute - gridDomain
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for domainSet
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("gridDomain", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.GridDomain))]
		public AE.GridDomain GridDomain
		{
			get 
			{ 
				return m_GridDomain;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"gridDomain"); // remove selection
				if (value == null)
					m_GridDomain = null;
				else
				{
					m_GridDomain = value; 
				}
			}
		}
		protected AE.GridDomain m_GridDomain;
		
		#endregion

		#region Attribute - multiCurveDomain
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for domainSet
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("multiCurveDomain", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.MultiCurveDomain))]
		public AE.MultiCurveDomain MultiCurveDomain
		{
			get 
			{ 
				return m_MultiCurveDomain;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"multiCurveDomain"); // remove selection
				if (value == null)
					m_MultiCurveDomain = null;
				else
				{
					m_MultiCurveDomain = value; 
				}
			}
		}
		protected AE.MultiCurveDomain m_MultiCurveDomain;
		
		#endregion

		#region Attribute - rectifiedGridDomain
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for domainSet
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("rectifiedGridDomain", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.RectifiedGridDomain))]
		public AE.RectifiedGridDomain RectifiedGridDomain
		{
			get 
			{ 
				return m_RectifiedGridDomain;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"rectifiedGridDomain"); // remove selection
				if (value == null)
					m_RectifiedGridDomain = null;
				else
				{
					m_RectifiedGridDomain = value; 
				}
			}
		}
		protected AE.RectifiedGridDomain m_RectifiedGridDomain;
		
		#endregion

		#region Attribute - multiSurfaceDomain
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for domainSet
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("multiSurfaceDomain", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.MultiSurfaceDomain))]
		public AE.MultiSurfaceDomain MultiSurfaceDomain
		{
			get 
			{ 
				return m_MultiSurfaceDomain;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"multiSurfaceDomain"); // remove selection
				if (value == null)
					m_MultiSurfaceDomain = null;
				else
				{
					m_MultiSurfaceDomain = value; 
				}
			}
		}
		protected AE.MultiSurfaceDomain m_MultiSurfaceDomain;
		
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


