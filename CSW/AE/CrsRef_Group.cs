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
	/// 	This class represents the Element crsRef_Group
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Choice,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement,
													"crsRef_Group", "http://www.opengis.net/gml", false, false,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class CrsRef_Group : CSW.XmlCommonBase
	{
		#region Constructors
		/// <summary>
		///		Constructor for CrsRef_Group
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public CrsRef_Group()
		{
			_elementName = "crsRef_Group";
			Init();
		}
		public CrsRef_Group(String elementName)
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
			m__CRS = null;
			m_CompoundCRS = null;
			m__CoordinateReferenceSystem = null;
			m_SubGrp_CoordinateReferenceSystem = null;



			_validElement = "";
// ##HAND_CODED_BLOCK_START ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional initialization code here...

// ##HAND_CODED_BLOCK_END ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
		}
		protected void ClearChoice(string selectedElement)
		{
			m__CRS = null;
			m_CompoundCRS = null;
			m__CoordinateReferenceSystem = null;
			m_SubGrp_CoordinateReferenceSystem = null;
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
			AE.CrsRef_Group newObject = new AE.CrsRef_Group(_elementName);
			newObject.m__CRS = null;
			if (m__CRS != null)
				newObject.m__CRS = (AE.IAbstractReferenceSystemType)m__CRS.Clone();
			newObject.m_CompoundCRS = null;
			if (m_CompoundCRS != null)
				newObject.m_CompoundCRS = (AE.CompoundCRS)m_CompoundCRS.Clone();
			newObject.m__CoordinateReferenceSystem = null;
			if (m__CoordinateReferenceSystem != null)
				newObject.m__CoordinateReferenceSystem = (AE.IAbstractReferenceSystemType)m__CoordinateReferenceSystem.Clone();
			newObject.m_SubGrp_CoordinateReferenceSystem = null;
			if (m_SubGrp_CoordinateReferenceSystem != null)
				newObject.m_SubGrp_CoordinateReferenceSystem = (AE.SubGrp_CoordinateReferenceSystem)m_SubGrp_CoordinateReferenceSystem.Clone();

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

		#region Attribute - _CRS
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
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("_CRS", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.ClassFactory), "IAbstractReferenceSystemTypeCreateObject")]
		public AE.IAbstractReferenceSystemType _CRS
		{
			get 
			{ 
				return m__CRS;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"_CRS"); // remove selection
				if (value == null)
					m__CRS = null;
				else
				{
					m__CRS = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "_CRS");
				}
			}
		}
		protected AE.IAbstractReferenceSystemType m__CRS;

		#endregion

		#region Attribute - CompoundCRS
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _CRS
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("CompoundCRS", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.CompoundCRS))]
		public AE.CompoundCRS CompoundCRS
		{
			get 
			{ 
				return m_CompoundCRS;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"CompoundCRS"); // remove selection
				if (value == null)
					m_CompoundCRS = null;
				else
				{
					m_CompoundCRS = value; 
				}
			}
		}
		protected AE.CompoundCRS m_CompoundCRS;
		
		#endregion

		#region Attribute - _CoordinateReferenceSystem
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _CRS
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("_CoordinateReferenceSystem", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.ClassFactory), "IAbstractReferenceSystemTypeCreateObject")]
		public AE.IAbstractReferenceSystemType _CoordinateReferenceSystem
		{
			get 
			{ 
				return m__CoordinateReferenceSystem;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"_CoordinateReferenceSystem"); // remove selection
				if (value == null)
					m__CoordinateReferenceSystem = null;
				else
				{
					m__CoordinateReferenceSystem = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "_CoordinateReferenceSystem");
				}
			}
		}
		protected AE.IAbstractReferenceSystemType m__CoordinateReferenceSystem;

		#endregion

		#region Attribute - SubGrp_CoordinateReferenceSystem
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _CRS
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("SubGrp_CoordinateReferenceSystem", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement, typeof(AE.SubGrp_CoordinateReferenceSystem))]
		public AE.SubGrp_CoordinateReferenceSystem SubGrp_CoordinateReferenceSystem
		{
			get 
			{ 
				return m_SubGrp_CoordinateReferenceSystem;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"SubGrp_CoordinateReferenceSystem"); // remove selection
				if (value == null)
					m_SubGrp_CoordinateReferenceSystem = null;
				else
				{
					m_SubGrp_CoordinateReferenceSystem = value; 
				}
			}
		}
		protected AE.SubGrp_CoordinateReferenceSystem m_SubGrp_CoordinateReferenceSystem;
		
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


