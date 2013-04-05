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
	/// 	This class represents the Element SubGrp_CoordinateReferenceSystem
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Choice,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement,
													"SubGrp_CoordinateReferenceSystem", "http://www.opengis.net/gml", false, false,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class SubGrp_CoordinateReferenceSystem : CSW.XmlCommonBase
	{
		#region Constructors
		/// <summary>
		///		Constructor for SubGrp_CoordinateReferenceSystem
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public SubGrp_CoordinateReferenceSystem()
		{
			_elementName = "SubGrp_CoordinateReferenceSystem";
			Init();
		}
		public SubGrp_CoordinateReferenceSystem(String elementName)
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
			m__CoordinateReferenceSystem = null;
			m_EngineeringCRS = null;
			m_GeographicCRS = null;
			m_TemporalCRS = null;
			m_ImageCRS = null;
			m_GeocentricCRS = null;
			m__GeneralDerivedCRS = null;
			m_SubGrp_GeneralDerivedCRS = null;
			m_VerticalCRS = null;



			_validElement = "";
// ##HAND_CODED_BLOCK_START ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional initialization code here...

// ##HAND_CODED_BLOCK_END ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
		}
		protected void ClearChoice(string selectedElement)
		{
			m__CoordinateReferenceSystem = null;
			m_EngineeringCRS = null;
			m_GeographicCRS = null;
			m_TemporalCRS = null;
			m_ImageCRS = null;
			m_GeocentricCRS = null;
			m__GeneralDerivedCRS = null;
			m_SubGrp_GeneralDerivedCRS = null;
			m_VerticalCRS = null;
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
			AE.SubGrp_CoordinateReferenceSystem newObject = new AE.SubGrp_CoordinateReferenceSystem(_elementName);
			newObject.m__CoordinateReferenceSystem = null;
			if (m__CoordinateReferenceSystem != null)
				newObject.m__CoordinateReferenceSystem = (AE.IAbstractReferenceSystemType)m__CoordinateReferenceSystem.Clone();
			newObject.m_EngineeringCRS = null;
			if (m_EngineeringCRS != null)
				newObject.m_EngineeringCRS = (AE.EngineeringCRS)m_EngineeringCRS.Clone();
			newObject.m_GeographicCRS = null;
			if (m_GeographicCRS != null)
				newObject.m_GeographicCRS = (AE.GeographicCRS)m_GeographicCRS.Clone();
			newObject.m_TemporalCRS = null;
			if (m_TemporalCRS != null)
				newObject.m_TemporalCRS = (AE.TemporalCRS)m_TemporalCRS.Clone();
			newObject.m_ImageCRS = null;
			if (m_ImageCRS != null)
				newObject.m_ImageCRS = (AE.ImageCRS)m_ImageCRS.Clone();
			newObject.m_GeocentricCRS = null;
			if (m_GeocentricCRS != null)
				newObject.m_GeocentricCRS = (AE.GeocentricCRS)m_GeocentricCRS.Clone();
			newObject.m__GeneralDerivedCRS = null;
			if (m__GeneralDerivedCRS != null)
				newObject.m__GeneralDerivedCRS = (AE.IAbstractGeneralDerivedCRSType)m__GeneralDerivedCRS.Clone();
			newObject.m_SubGrp_GeneralDerivedCRS = null;
			if (m_SubGrp_GeneralDerivedCRS != null)
				newObject.m_SubGrp_GeneralDerivedCRS = (AE.SubGrp_GeneralDerivedCRS)m_SubGrp_GeneralDerivedCRS.Clone();
			newObject.m_VerticalCRS = null;
			if (m_VerticalCRS != null)
				newObject.m_VerticalCRS = (AE.VerticalCRS)m_VerticalCRS.Clone();

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

		#region Attribute - _CoordinateReferenceSystem
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

		#region Attribute - EngineeringCRS
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _CoordinateReferenceSystem
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("EngineeringCRS", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.EngineeringCRS))]
		public AE.EngineeringCRS EngineeringCRS
		{
			get 
			{ 
				return m_EngineeringCRS;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"EngineeringCRS"); // remove selection
				if (value == null)
					m_EngineeringCRS = null;
				else
				{
					m_EngineeringCRS = value; 
				}
			}
		}
		protected AE.EngineeringCRS m_EngineeringCRS;
		
		#endregion

		#region Attribute - GeographicCRS
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _CoordinateReferenceSystem
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("GeographicCRS", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.GeographicCRS))]
		public AE.GeographicCRS GeographicCRS
		{
			get 
			{ 
				return m_GeographicCRS;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"GeographicCRS"); // remove selection
				if (value == null)
					m_GeographicCRS = null;
				else
				{
					m_GeographicCRS = value; 
				}
			}
		}
		protected AE.GeographicCRS m_GeographicCRS;
		
		#endregion

		#region Attribute - TemporalCRS
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _CoordinateReferenceSystem
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("TemporalCRS", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.TemporalCRS))]
		public AE.TemporalCRS TemporalCRS
		{
			get 
			{ 
				return m_TemporalCRS;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"TemporalCRS"); // remove selection
				if (value == null)
					m_TemporalCRS = null;
				else
				{
					m_TemporalCRS = value; 
				}
			}
		}
		protected AE.TemporalCRS m_TemporalCRS;
		
		#endregion

		#region Attribute - ImageCRS
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _CoordinateReferenceSystem
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("ImageCRS", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.ImageCRS))]
		public AE.ImageCRS ImageCRS
		{
			get 
			{ 
				return m_ImageCRS;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"ImageCRS"); // remove selection
				if (value == null)
					m_ImageCRS = null;
				else
				{
					m_ImageCRS = value; 
				}
			}
		}
		protected AE.ImageCRS m_ImageCRS;
		
		#endregion

		#region Attribute - GeocentricCRS
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _CoordinateReferenceSystem
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("GeocentricCRS", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.GeocentricCRS))]
		public AE.GeocentricCRS GeocentricCRS
		{
			get 
			{ 
				return m_GeocentricCRS;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"GeocentricCRS"); // remove selection
				if (value == null)
					m_GeocentricCRS = null;
				else
				{
					m_GeocentricCRS = value; 
				}
			}
		}
		protected AE.GeocentricCRS m_GeocentricCRS;
		
		#endregion

		#region Attribute - _GeneralDerivedCRS
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _CoordinateReferenceSystem
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("_GeneralDerivedCRS", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.ClassFactory), "IAbstractGeneralDerivedCRSTypeCreateObject")]
		public AE.IAbstractGeneralDerivedCRSType _GeneralDerivedCRS
		{
			get 
			{ 
				return m__GeneralDerivedCRS;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"_GeneralDerivedCRS"); // remove selection
				if (value == null)
					m__GeneralDerivedCRS = null;
				else
				{
					m__GeneralDerivedCRS = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "_GeneralDerivedCRS");
				}
			}
		}
		protected AE.IAbstractGeneralDerivedCRSType m__GeneralDerivedCRS;

		#endregion

		#region Attribute - SubGrp_GeneralDerivedCRS
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _CoordinateReferenceSystem
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("SubGrp_GeneralDerivedCRS", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement, typeof(AE.SubGrp_GeneralDerivedCRS))]
		public AE.SubGrp_GeneralDerivedCRS SubGrp_GeneralDerivedCRS
		{
			get 
			{ 
				return m_SubGrp_GeneralDerivedCRS;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"SubGrp_GeneralDerivedCRS"); // remove selection
				if (value == null)
					m_SubGrp_GeneralDerivedCRS = null;
				else
				{
					m_SubGrp_GeneralDerivedCRS = value; 
				}
			}
		}
		protected AE.SubGrp_GeneralDerivedCRS m_SubGrp_GeneralDerivedCRS;
		
		#endregion

		#region Attribute - VerticalCRS
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _CoordinateReferenceSystem
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("VerticalCRS", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.VerticalCRS))]
		public AE.VerticalCRS VerticalCRS
		{
			get 
			{ 
				return m_VerticalCRS;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"VerticalCRS"); // remove selection
				if (value == null)
					m_VerticalCRS = null;
				else
				{
					m_VerticalCRS = value; 
				}
			}
		}
		protected AE.VerticalCRS m_VerticalCRS;
		
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


