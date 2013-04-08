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
	/// 	This class represents the Element SubGrp_Coverage
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Choice,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement,
													"SubGrp_Coverage", "http://www.opengis.net/gml", false, false,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class SubGrp_Coverage : CSW.XmlCommonBase
	{
		#region Constructors
		/// <summary>
		///		Constructor for SubGrp_Coverage
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public SubGrp_Coverage()
		{
			_elementName = "SubGrp_Coverage";
			Init();
		}
		public SubGrp_Coverage(String elementName)
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
			m__Coverage = null;
			m__ContinuousCoverage = null;
			m__ContinuousCoverageA = null;
			m__DiscreteCoverage = null;
			m_SubGrp_DiscreteCoverage = null;



			_validElement = "";
// ##HAND_CODED_BLOCK_START ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional initialization code here...

// ##HAND_CODED_BLOCK_END ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
		}
		protected void ClearChoice(string selectedElement)
		{
			m__Coverage = null;
			m__ContinuousCoverage = null;
			m__ContinuousCoverageA = null;
			m__DiscreteCoverage = null;
			m_SubGrp_DiscreteCoverage = null;
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
			AE.SubGrp_Coverage newObject = new AE.SubGrp_Coverage(_elementName);
			newObject.m__Coverage = null;
			if (m__Coverage != null)
				newObject.m__Coverage = (AE.IAbstractCoverageType)m__Coverage.Clone();
			newObject.m__ContinuousCoverage = null;
			if (m__ContinuousCoverage != null)
				newObject.m__ContinuousCoverage = (AE.IAbstractContinuousCoverageType)m__ContinuousCoverage.Clone();
			newObject.m__ContinuousCoverageA = null;
			if (m__ContinuousCoverageA != null)
				newObject.m__ContinuousCoverageA = (AE.IAbstractContinuousCoverageType)m__ContinuousCoverageA.Clone();
			newObject.m__DiscreteCoverage = null;
			if (m__DiscreteCoverage != null)
				newObject.m__DiscreteCoverage = (AE.IAbstractDiscreteCoverageType)m__DiscreteCoverage.Clone();
			newObject.m_SubGrp_DiscreteCoverage = null;
			if (m_SubGrp_DiscreteCoverage != null)
				newObject.m_SubGrp_DiscreteCoverage = (AE.SubGrp_DiscreteCoverage)m_SubGrp_DiscreteCoverage.Clone();

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

		#region Attribute - _Coverage
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
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("_Coverage", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.ClassFactory), "IAbstractCoverageTypeCreateObject")]
		public AE.IAbstractCoverageType _Coverage
		{
			get 
			{ 
				return m__Coverage;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"_Coverage"); // remove selection
				if (value == null)
					m__Coverage = null;
				else
				{
					m__Coverage = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "_Coverage");
				}
			}
		}
		protected AE.IAbstractCoverageType m__Coverage;

		#endregion

		#region Attribute - _ContinuousCoverage
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _Coverage
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("_ContinuousCoverage", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.ClassFactory), "IAbstractContinuousCoverageTypeCreateObject")]
		public AE.IAbstractContinuousCoverageType _ContinuousCoverage
		{
			get 
			{ 
				return m__ContinuousCoverage;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"_ContinuousCoverage"); // remove selection
				if (value == null)
					m__ContinuousCoverage = null;
				else
				{
					m__ContinuousCoverage = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "_ContinuousCoverage");
				}
			}
		}
		protected AE.IAbstractContinuousCoverageType m__ContinuousCoverage;

		#endregion

		#region Attribute - _ContinuousCoverage
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _Coverage
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("_ContinuousCoverage", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.ClassFactory), "IAbstractContinuousCoverageTypeCreateObject")]
		public AE.IAbstractContinuousCoverageType _ContinuousCoverageA
		{
			get 
			{ 
				return m__ContinuousCoverageA;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"_ContinuousCoverageA"); // remove selection
				if (value == null)
					m__ContinuousCoverageA = null;
				else
				{
					m__ContinuousCoverageA = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "_ContinuousCoverage");
				}
			}
		}
		protected AE.IAbstractContinuousCoverageType m__ContinuousCoverageA;

		#endregion

		#region Attribute - _DiscreteCoverage
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _Coverage
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

		#region Attribute - SubGrp_DiscreteCoverage
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _Coverage
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("SubGrp_DiscreteCoverage", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement, typeof(AE.SubGrp_DiscreteCoverage))]
		public AE.SubGrp_DiscreteCoverage SubGrp_DiscreteCoverage
		{
			get 
			{ 
				return m_SubGrp_DiscreteCoverage;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"SubGrp_DiscreteCoverage"); // remove selection
				if (value == null)
					m_SubGrp_DiscreteCoverage = null;
				else
				{
					m_SubGrp_DiscreteCoverage = value; 
				}
			}
		}
		protected AE.SubGrp_DiscreteCoverage m_SubGrp_DiscreteCoverage;
		
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


