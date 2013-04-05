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
	/// 	This class represents the Element SubGrp_positionalAccuracy
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Choice,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement,
													"SubGrp_positionalAccuracy", "http://www.opengis.net/gml", false, false,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class SubGrp_positionalAccuracy : CSW.XmlCommonBase
	{
		#region Constructors
		/// <summary>
		///		Constructor for SubGrp_positionalAccuracy
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public SubGrp_positionalAccuracy()
		{
			_elementName = "SubGrp_positionalAccuracy";
			Init();
		}
		public SubGrp_positionalAccuracy(String elementName)
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
			m__positionalAccuracy = null;
			m_RelativeInternalPositionalAccuracy = null;
			m_CovarianceMatrix = null;
			m_AbsoluteExternalPositionalAccuracy = null;



			_validElement = "";
// ##HAND_CODED_BLOCK_START ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional initialization code here...

// ##HAND_CODED_BLOCK_END ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
		}
		protected void ClearChoice(string selectedElement)
		{
			m__positionalAccuracy = null;
			m_RelativeInternalPositionalAccuracy = null;
			m_CovarianceMatrix = null;
			m_AbsoluteExternalPositionalAccuracy = null;
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
			AE.SubGrp_positionalAccuracy newObject = new AE.SubGrp_positionalAccuracy(_elementName);
			newObject.m__positionalAccuracy = null;
			if (m__positionalAccuracy != null)
				newObject.m__positionalAccuracy = (AE.IAbstractPositionalAccuracyType)m__positionalAccuracy.Clone();
			newObject.m_RelativeInternalPositionalAccuracy = null;
			if (m_RelativeInternalPositionalAccuracy != null)
				newObject.m_RelativeInternalPositionalAccuracy = (AE.RelativeInternalPositionalAccuracy)m_RelativeInternalPositionalAccuracy.Clone();
			newObject.m_CovarianceMatrix = null;
			if (m_CovarianceMatrix != null)
				newObject.m_CovarianceMatrix = (AE.CovarianceMatrix)m_CovarianceMatrix.Clone();
			newObject.m_AbsoluteExternalPositionalAccuracy = null;
			if (m_AbsoluteExternalPositionalAccuracy != null)
				newObject.m_AbsoluteExternalPositionalAccuracy = (AE.AbsoluteExternalPositionalAccuracy)m_AbsoluteExternalPositionalAccuracy.Clone();

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

		#region Attribute - _positionalAccuracy
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
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("_positionalAccuracy", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.ClassFactory), "IAbstractPositionalAccuracyTypeCreateObject")]
		public AE.IAbstractPositionalAccuracyType _positionalAccuracy
		{
			get 
			{ 
				return m__positionalAccuracy;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"_positionalAccuracy"); // remove selection
				if (value == null)
					m__positionalAccuracy = null;
				else
				{
					m__positionalAccuracy = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "_positionalAccuracy");
				}
			}
		}
		protected AE.IAbstractPositionalAccuracyType m__positionalAccuracy;

		#endregion

		#region Attribute - relativeInternalPositionalAccuracy
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _positionalAccuracy
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("relativeInternalPositionalAccuracy", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.RelativeInternalPositionalAccuracy))]
		public AE.RelativeInternalPositionalAccuracy RelativeInternalPositionalAccuracy
		{
			get 
			{ 
				return m_RelativeInternalPositionalAccuracy;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"relativeInternalPositionalAccuracy"); // remove selection
				if (value == null)
					m_RelativeInternalPositionalAccuracy = null;
				else
				{
					m_RelativeInternalPositionalAccuracy = value; 
				}
			}
		}
		protected AE.RelativeInternalPositionalAccuracy m_RelativeInternalPositionalAccuracy;
		
		#endregion

		#region Attribute - covarianceMatrix
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _positionalAccuracy
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("covarianceMatrix", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.CovarianceMatrix))]
		public AE.CovarianceMatrix CovarianceMatrix
		{
			get 
			{ 
				return m_CovarianceMatrix;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"covarianceMatrix"); // remove selection
				if (value == null)
					m_CovarianceMatrix = null;
				else
				{
					m_CovarianceMatrix = value; 
				}
			}
		}
		protected AE.CovarianceMatrix m_CovarianceMatrix;
		
		#endregion

		#region Attribute - absoluteExternalPositionalAccuracy
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _positionalAccuracy
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("absoluteExternalPositionalAccuracy", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.AbsoluteExternalPositionalAccuracy))]
		public AE.AbsoluteExternalPositionalAccuracy AbsoluteExternalPositionalAccuracy
		{
			get 
			{ 
				return m_AbsoluteExternalPositionalAccuracy;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"absoluteExternalPositionalAccuracy"); // remove selection
				if (value == null)
					m_AbsoluteExternalPositionalAccuracy = null;
				else
				{
					m_AbsoluteExternalPositionalAccuracy = value; 
				}
			}
		}
		protected AE.AbsoluteExternalPositionalAccuracy m_AbsoluteExternalPositionalAccuracy;
		
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


