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
	/// 	This class represents the Element secondDefiningParameter
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Choice,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element,
													"secondDefiningParameter", "http://www.opengis.net/gml", true, false,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class SecondDefiningParameter : CSW.XmlCommonBase
	{
		#region Constructors
		/// <summary>
		///		Constructor for SecondDefiningParameter
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public SecondDefiningParameter()
		{
			_elementName = "secondDefiningParameter";
			Init();
		}
		public SecondDefiningParameter(String elementName)
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
			m_InverseFlattening = null;
			m_SemiMinorAxis = null;
			m_IsSphere = AE.Enumerations.IsSphereA.Sphere;
			m_IsValidIsSphere = false;



			_validElement = "";
// ##HAND_CODED_BLOCK_START ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional initialization code here...

// ##HAND_CODED_BLOCK_END ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
		}
		protected void ClearChoice(string selectedElement)
		{
			m_InverseFlattening = null;
			m_SemiMinorAxis = null;
			m_IsSphere = AE.Enumerations.IsSphereA.Sphere;
			m_IsValidIsSphere = false;
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
			AE.SecondDefiningParameter newObject = new AE.SecondDefiningParameter(_elementName);
			newObject.m_InverseFlattening = null;
			if (m_InverseFlattening != null)
				newObject.m_InverseFlattening = (AE.IMeasureType)m_InverseFlattening.Clone();
			newObject.m_SemiMinorAxis = null;
			if (m_SemiMinorAxis != null)
				newObject.m_SemiMinorAxis = (AE.IMeasureType)m_SemiMinorAxis.Clone();
			newObject.m_IsSphere = m_IsSphere;
			newObject.m_IsValidIsSphere = m_IsValidIsSphere;

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

		#region Attribute - inverseFlattening
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
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("inverseFlattening", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.ClassFactory), "IMeasureTypeCreateObject")]
		public AE.IMeasureType InverseFlattening
		{
			get 
			{ 
				return m_InverseFlattening;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"inverseFlattening"); // remove selection
				if (value == null)
					m_InverseFlattening = null;
				else
				{
					m_InverseFlattening = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "inverseFlattening");
				}
			}
		}
		protected AE.IMeasureType m_InverseFlattening;

		#endregion

		#region Attribute - semiMinorAxis
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
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("semiMinorAxis", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.ClassFactory), "IMeasureTypeCreateObject")]
		public AE.IMeasureType SemiMinorAxis
		{
			get 
			{ 
				return m_SemiMinorAxis;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"semiMinorAxis"); // remove selection
				if (value == null)
					m_SemiMinorAxis = null;
				else
				{
					m_SemiMinorAxis = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "semiMinorAxis");
				}
			}
		}
		protected AE.IMeasureType m_SemiMinorAxis;

		#endregion

		#region Attribute - isSphere
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. Set isSphereValid = false to de-select this element</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceEnumOpt("isSphere", "http://www.opengis.net/gml", "IsValidIsSphere", null, typeof(AE.Enumerations), "IsSphereAFromString", "IsSphereAToString")]
		public AE.Enumerations.IsSphereA IsSphere
		{
			get 
			{ 
				if (m_IsValidIsSphere == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property isSphere is not valid. Set isSphereValid = true");
				return m_IsSphere;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("isSphere"); // remove selection
				m_IsSphere = value;
				m_IsValidIsSphere = true;
			}
		}
		/// <summary>
		/// 	Indicates if isSphere contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for isSphere is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value (AE.Enumerations.IsSphereA.Sphere).</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get isSphere
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidIsSphere
		{
			get { return m_IsValidIsSphere;  }
			set 
			{ 
				if (value != m_IsValidIsSphere)
				{
					// Ensure only one element at a time is populated
					Choice_SetElementValid(value, "isSphere", ref _validElement);
					IsSphere = AE.Enumerations.IsSphereA.Sphere;
					m_IsValidIsSphere = value;
				}
			}
		}
		protected AE.Enumerations.IsSphereA m_IsSphere;
		protected Boolean m_IsValidIsSphere;

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


