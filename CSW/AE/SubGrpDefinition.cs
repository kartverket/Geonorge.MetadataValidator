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
	/// 	This class represents the Element SubGrpDefinition
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Choice,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement,
													"SubGrpDefinition", "http://www.opengis.net/gml", false, false,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class SubGrpDefinition : CSW.XmlCommonBase
	{
		#region Constructors
		/// <summary>
		///		Constructor for SubGrpDefinition
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public SubGrpDefinition()
		{
			_elementName = "SubGrpDefinition";
			Init();
		}
		public SubGrpDefinition(String elementName)
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
			m_Definition = null;
			m_DefinitionProxy = null;
			m_Dictionary = null;
			m_TimeCalendarEra = null;
			m__CoordinateOperation = null;
			m_SubGrp_CoordinateOperation = null;
			m__TimeReferenceSystem = null;
			m_SubGrp_TimeReferenceSystem = null;
			m__GeneralOperationParameter = null;
			m_SubGrp_GeneralOperationParameter = null;
			m_Ellipsoid = null;
			m__Datum = null;
			m_SubGrp_Datum = null;
			m_PrimeMeridian = null;
			m_DefinitionCollection = null;
			m_SubGrpUnitDefinition = null;
			m_OperationMethod = null;
			m__CoordinateSystem = null;
			m_SubGrp_CoordinateSystem = null;
			m_CoordinateSystemAxis = null;
			m__ReferenceSystem = null;
			m_SubGrp_ReferenceSystem = null;



			_validElement = "";
// ##HAND_CODED_BLOCK_START ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional initialization code here...

// ##HAND_CODED_BLOCK_END ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
		}
		protected void ClearChoice(string selectedElement)
		{
			m_Definition = null;
			m_DefinitionProxy = null;
			m_Dictionary = null;
			m_TimeCalendarEra = null;
			m__CoordinateOperation = null;
			m_SubGrp_CoordinateOperation = null;
			m__TimeReferenceSystem = null;
			m_SubGrp_TimeReferenceSystem = null;
			m__GeneralOperationParameter = null;
			m_SubGrp_GeneralOperationParameter = null;
			m_Ellipsoid = null;
			m__Datum = null;
			m_SubGrp_Datum = null;
			m_PrimeMeridian = null;
			m_DefinitionCollection = null;
			m_SubGrpUnitDefinition = null;
			m_OperationMethod = null;
			m__CoordinateSystem = null;
			m_SubGrp_CoordinateSystem = null;
			m_CoordinateSystemAxis = null;
			m__ReferenceSystem = null;
			m_SubGrp_ReferenceSystem = null;
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
			AE.SubGrpDefinition newObject = new AE.SubGrpDefinition(_elementName);
			newObject.m_Definition = null;
			if (m_Definition != null)
				newObject.m_Definition = (AE.IDefinitionType)m_Definition.Clone();
			newObject.m_DefinitionProxy = null;
			if (m_DefinitionProxy != null)
				newObject.m_DefinitionProxy = (AE.DefinitionProxy)m_DefinitionProxy.Clone();
			newObject.m_Dictionary = null;
			if (m_Dictionary != null)
				newObject.m_Dictionary = (AE.Dictionary)m_Dictionary.Clone();
			newObject.m_TimeCalendarEra = null;
			if (m_TimeCalendarEra != null)
				newObject.m_TimeCalendarEra = (AE.TimeCalendarEra)m_TimeCalendarEra.Clone();
			newObject.m__CoordinateOperation = null;
			if (m__CoordinateOperation != null)
				newObject.m__CoordinateOperation = (AE.IAbstractCoordinateOperationType)m__CoordinateOperation.Clone();
			newObject.m_SubGrp_CoordinateOperation = null;
			if (m_SubGrp_CoordinateOperation != null)
				newObject.m_SubGrp_CoordinateOperation = (AE.SubGrp_CoordinateOperation)m_SubGrp_CoordinateOperation.Clone();
			newObject.m__TimeReferenceSystem = null;
			if (m__TimeReferenceSystem != null)
				newObject.m__TimeReferenceSystem = (AE.IAbstractTimeReferenceSystemType)m__TimeReferenceSystem.Clone();
			newObject.m_SubGrp_TimeReferenceSystem = null;
			if (m_SubGrp_TimeReferenceSystem != null)
				newObject.m_SubGrp_TimeReferenceSystem = (AE.SubGrp_TimeReferenceSystem)m_SubGrp_TimeReferenceSystem.Clone();
			newObject.m__GeneralOperationParameter = null;
			if (m__GeneralOperationParameter != null)
				newObject.m__GeneralOperationParameter = (AE.IAbstractGeneralOperationParameterType)m__GeneralOperationParameter.Clone();
			newObject.m_SubGrp_GeneralOperationParameter = null;
			if (m_SubGrp_GeneralOperationParameter != null)
				newObject.m_SubGrp_GeneralOperationParameter = (AE.SubGrp_GeneralOperationParameter)m_SubGrp_GeneralOperationParameter.Clone();
			newObject.m_Ellipsoid = null;
			if (m_Ellipsoid != null)
				newObject.m_Ellipsoid = (AE.Ellipsoid)m_Ellipsoid.Clone();
			newObject.m__Datum = null;
			if (m__Datum != null)
				newObject.m__Datum = (AE.IAbstractDatumType)m__Datum.Clone();
			newObject.m_SubGrp_Datum = null;
			if (m_SubGrp_Datum != null)
				newObject.m_SubGrp_Datum = (AE.SubGrp_Datum)m_SubGrp_Datum.Clone();
			newObject.m_PrimeMeridian = null;
			if (m_PrimeMeridian != null)
				newObject.m_PrimeMeridian = (AE.PrimeMeridian)m_PrimeMeridian.Clone();
			newObject.m_DefinitionCollection = null;
			if (m_DefinitionCollection != null)
				newObject.m_DefinitionCollection = (AE.DefinitionCollection)m_DefinitionCollection.Clone();
			newObject.m_SubGrpUnitDefinition = null;
			if (m_SubGrpUnitDefinition != null)
				newObject.m_SubGrpUnitDefinition = (AE.SubGrpUnitDefinition)m_SubGrpUnitDefinition.Clone();
			newObject.m_OperationMethod = null;
			if (m_OperationMethod != null)
				newObject.m_OperationMethod = (AE.OperationMethod)m_OperationMethod.Clone();
			newObject.m__CoordinateSystem = null;
			if (m__CoordinateSystem != null)
				newObject.m__CoordinateSystem = (AE.IAbstractCoordinateSystemType)m__CoordinateSystem.Clone();
			newObject.m_SubGrp_CoordinateSystem = null;
			if (m_SubGrp_CoordinateSystem != null)
				newObject.m_SubGrp_CoordinateSystem = (AE.SubGrp_CoordinateSystem)m_SubGrp_CoordinateSystem.Clone();
			newObject.m_CoordinateSystemAxis = null;
			if (m_CoordinateSystemAxis != null)
				newObject.m_CoordinateSystemAxis = (AE.CoordinateSystemAxis)m_CoordinateSystemAxis.Clone();
			newObject.m__ReferenceSystem = null;
			if (m__ReferenceSystem != null)
				newObject.m__ReferenceSystem = (AE.IAbstractReferenceSystemType)m__ReferenceSystem.Clone();
			newObject.m_SubGrp_ReferenceSystem = null;
			if (m_SubGrp_ReferenceSystem != null)
				newObject.m_SubGrp_ReferenceSystem = (AE.SubGrp_ReferenceSystem)m_SubGrp_ReferenceSystem.Clone();

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

		#region Attribute - Definition
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
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("Definition", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.ClassFactory), "IDefinitionTypeCreateObject")]
		public AE.IDefinitionType Definition
		{
			get 
			{ 
				return m_Definition;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"Definition"); // remove selection
				if (value == null)
					m_Definition = null;
				else
				{
					m_Definition = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "Definition");
				}
			}
		}
		protected AE.IDefinitionType m_Definition;

		#endregion

		#region Attribute - DefinitionProxy
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for Definition
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("DefinitionProxy", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.DefinitionProxy))]
		public AE.DefinitionProxy DefinitionProxy
		{
			get 
			{ 
				return m_DefinitionProxy;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"DefinitionProxy"); // remove selection
				if (value == null)
					m_DefinitionProxy = null;
				else
				{
					m_DefinitionProxy = value; 
				}
			}
		}
		protected AE.DefinitionProxy m_DefinitionProxy;
		
		#endregion

		#region Attribute - Dictionary
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for Definition
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("Dictionary", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.Dictionary))]
		public AE.Dictionary Dictionary
		{
			get 
			{ 
				return m_Dictionary;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"Dictionary"); // remove selection
				if (value == null)
					m_Dictionary = null;
				else
				{
					m_Dictionary = value; 
				}
			}
		}
		protected AE.Dictionary m_Dictionary;
		
		#endregion

		#region Attribute - TimeCalendarEra
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for Definition
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("TimeCalendarEra", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.TimeCalendarEra))]
		public AE.TimeCalendarEra TimeCalendarEra
		{
			get 
			{ 
				return m_TimeCalendarEra;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"TimeCalendarEra"); // remove selection
				if (value == null)
					m_TimeCalendarEra = null;
				else
				{
					m_TimeCalendarEra = value; 
				}
			}
		}
		protected AE.TimeCalendarEra m_TimeCalendarEra;
		
		#endregion

		#region Attribute - _CoordinateOperation
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for Definition
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("_CoordinateOperation", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.ClassFactory), "IAbstractCoordinateOperationTypeCreateObject")]
		public AE.IAbstractCoordinateOperationType _CoordinateOperation
		{
			get 
			{ 
				return m__CoordinateOperation;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"_CoordinateOperation"); // remove selection
				if (value == null)
					m__CoordinateOperation = null;
				else
				{
					m__CoordinateOperation = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "_CoordinateOperation");
				}
			}
		}
		protected AE.IAbstractCoordinateOperationType m__CoordinateOperation;

		#endregion

		#region Attribute - SubGrp_CoordinateOperation
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for Definition
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("SubGrp_CoordinateOperation", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement, typeof(AE.SubGrp_CoordinateOperation))]
		public AE.SubGrp_CoordinateOperation SubGrp_CoordinateOperation
		{
			get 
			{ 
				return m_SubGrp_CoordinateOperation;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"SubGrp_CoordinateOperation"); // remove selection
				if (value == null)
					m_SubGrp_CoordinateOperation = null;
				else
				{
					m_SubGrp_CoordinateOperation = value; 
				}
			}
		}
		protected AE.SubGrp_CoordinateOperation m_SubGrp_CoordinateOperation;
		
		#endregion

		#region Attribute - _TimeReferenceSystem
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for Definition
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("_TimeReferenceSystem", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.ClassFactory), "IAbstractTimeReferenceSystemTypeCreateObject")]
		public AE.IAbstractTimeReferenceSystemType _TimeReferenceSystem
		{
			get 
			{ 
				return m__TimeReferenceSystem;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"_TimeReferenceSystem"); // remove selection
				if (value == null)
					m__TimeReferenceSystem = null;
				else
				{
					m__TimeReferenceSystem = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "_TimeReferenceSystem");
				}
			}
		}
		protected AE.IAbstractTimeReferenceSystemType m__TimeReferenceSystem;

		#endregion

		#region Attribute - SubGrp_TimeReferenceSystem
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for Definition
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("SubGrp_TimeReferenceSystem", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement, typeof(AE.SubGrp_TimeReferenceSystem))]
		public AE.SubGrp_TimeReferenceSystem SubGrp_TimeReferenceSystem
		{
			get 
			{ 
				return m_SubGrp_TimeReferenceSystem;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"SubGrp_TimeReferenceSystem"); // remove selection
				if (value == null)
					m_SubGrp_TimeReferenceSystem = null;
				else
				{
					m_SubGrp_TimeReferenceSystem = value; 
				}
			}
		}
		protected AE.SubGrp_TimeReferenceSystem m_SubGrp_TimeReferenceSystem;
		
		#endregion

		#region Attribute - _GeneralOperationParameter
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for Definition
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("_GeneralOperationParameter", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.ClassFactory), "IAbstractGeneralOperationParameterTypeCreateObject")]
		public AE.IAbstractGeneralOperationParameterType _GeneralOperationParameter
		{
			get 
			{ 
				return m__GeneralOperationParameter;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"_GeneralOperationParameter"); // remove selection
				if (value == null)
					m__GeneralOperationParameter = null;
				else
				{
					m__GeneralOperationParameter = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "_GeneralOperationParameter");
				}
			}
		}
		protected AE.IAbstractGeneralOperationParameterType m__GeneralOperationParameter;

		#endregion

		#region Attribute - SubGrp_GeneralOperationParameter
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for Definition
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("SubGrp_GeneralOperationParameter", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement, typeof(AE.SubGrp_GeneralOperationParameter))]
		public AE.SubGrp_GeneralOperationParameter SubGrp_GeneralOperationParameter
		{
			get 
			{ 
				return m_SubGrp_GeneralOperationParameter;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"SubGrp_GeneralOperationParameter"); // remove selection
				if (value == null)
					m_SubGrp_GeneralOperationParameter = null;
				else
				{
					m_SubGrp_GeneralOperationParameter = value; 
				}
			}
		}
		protected AE.SubGrp_GeneralOperationParameter m_SubGrp_GeneralOperationParameter;
		
		#endregion

		#region Attribute - Ellipsoid
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for Definition
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("Ellipsoid", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.Ellipsoid))]
		public AE.Ellipsoid Ellipsoid
		{
			get 
			{ 
				return m_Ellipsoid;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"Ellipsoid"); // remove selection
				if (value == null)
					m_Ellipsoid = null;
				else
				{
					m_Ellipsoid = value; 
				}
			}
		}
		protected AE.Ellipsoid m_Ellipsoid;
		
		#endregion

		#region Attribute - _Datum
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for Definition
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("_Datum", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.ClassFactory), "IAbstractDatumTypeCreateObject")]
		public AE.IAbstractDatumType _Datum
		{
			get 
			{ 
				return m__Datum;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"_Datum"); // remove selection
				if (value == null)
					m__Datum = null;
				else
				{
					m__Datum = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "_Datum");
				}
			}
		}
		protected AE.IAbstractDatumType m__Datum;

		#endregion

		#region Attribute - SubGrp_Datum
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for Definition
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("SubGrp_Datum", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement, typeof(AE.SubGrp_Datum))]
		public AE.SubGrp_Datum SubGrp_Datum
		{
			get 
			{ 
				return m_SubGrp_Datum;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"SubGrp_Datum"); // remove selection
				if (value == null)
					m_SubGrp_Datum = null;
				else
				{
					m_SubGrp_Datum = value; 
				}
			}
		}
		protected AE.SubGrp_Datum m_SubGrp_Datum;
		
		#endregion

		#region Attribute - PrimeMeridian
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for Definition
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("PrimeMeridian", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.PrimeMeridian))]
		public AE.PrimeMeridian PrimeMeridian
		{
			get 
			{ 
				return m_PrimeMeridian;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"PrimeMeridian"); // remove selection
				if (value == null)
					m_PrimeMeridian = null;
				else
				{
					m_PrimeMeridian = value; 
				}
			}
		}
		protected AE.PrimeMeridian m_PrimeMeridian;
		
		#endregion

		#region Attribute - DefinitionCollection
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for Definition
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("DefinitionCollection", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.DefinitionCollection))]
		public AE.DefinitionCollection DefinitionCollection
		{
			get 
			{ 
				return m_DefinitionCollection;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"DefinitionCollection"); // remove selection
				if (value == null)
					m_DefinitionCollection = null;
				else
				{
					m_DefinitionCollection = value; 
				}
			}
		}
		protected AE.DefinitionCollection m_DefinitionCollection;
		
		#endregion

		#region Attribute - SubGrpUnitDefinition
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for Definition
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("SubGrpUnitDefinition", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement, typeof(AE.SubGrpUnitDefinition))]
		public AE.SubGrpUnitDefinition SubGrpUnitDefinition
		{
			get 
			{ 
				return m_SubGrpUnitDefinition;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"SubGrpUnitDefinition"); // remove selection
				if (value == null)
					m_SubGrpUnitDefinition = null;
				else
				{
					m_SubGrpUnitDefinition = value; 
				}
			}
		}
		protected AE.SubGrpUnitDefinition m_SubGrpUnitDefinition;
		
		#endregion

		#region Attribute - OperationMethod
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for Definition
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("OperationMethod", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.OperationMethod))]
		public AE.OperationMethod OperationMethod
		{
			get 
			{ 
				return m_OperationMethod;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"OperationMethod"); // remove selection
				if (value == null)
					m_OperationMethod = null;
				else
				{
					m_OperationMethod = value; 
				}
			}
		}
		protected AE.OperationMethod m_OperationMethod;
		
		#endregion

		#region Attribute - _CoordinateSystem
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for Definition
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("_CoordinateSystem", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.ClassFactory), "IAbstractCoordinateSystemTypeCreateObject")]
		public AE.IAbstractCoordinateSystemType _CoordinateSystem
		{
			get 
			{ 
				return m__CoordinateSystem;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"_CoordinateSystem"); // remove selection
				if (value == null)
					m__CoordinateSystem = null;
				else
				{
					m__CoordinateSystem = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "_CoordinateSystem");
				}
			}
		}
		protected AE.IAbstractCoordinateSystemType m__CoordinateSystem;

		#endregion

		#region Attribute - SubGrp_CoordinateSystem
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for Definition
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("SubGrp_CoordinateSystem", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement, typeof(AE.SubGrp_CoordinateSystem))]
		public AE.SubGrp_CoordinateSystem SubGrp_CoordinateSystem
		{
			get 
			{ 
				return m_SubGrp_CoordinateSystem;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"SubGrp_CoordinateSystem"); // remove selection
				if (value == null)
					m_SubGrp_CoordinateSystem = null;
				else
				{
					m_SubGrp_CoordinateSystem = value; 
				}
			}
		}
		protected AE.SubGrp_CoordinateSystem m_SubGrp_CoordinateSystem;
		
		#endregion

		#region Attribute - CoordinateSystemAxis
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for Definition
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("CoordinateSystemAxis", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.CoordinateSystemAxis))]
		public AE.CoordinateSystemAxis CoordinateSystemAxis
		{
			get 
			{ 
				return m_CoordinateSystemAxis;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"CoordinateSystemAxis"); // remove selection
				if (value == null)
					m_CoordinateSystemAxis = null;
				else
				{
					m_CoordinateSystemAxis = value; 
				}
			}
		}
		protected AE.CoordinateSystemAxis m_CoordinateSystemAxis;
		
		#endregion

		#region Attribute - _ReferenceSystem
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for Definition
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("_ReferenceSystem", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.ClassFactory), "IAbstractReferenceSystemTypeCreateObject")]
		public AE.IAbstractReferenceSystemType _ReferenceSystem
		{
			get 
			{ 
				return m__ReferenceSystem;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"_ReferenceSystem"); // remove selection
				if (value == null)
					m__ReferenceSystem = null;
				else
				{
					m__ReferenceSystem = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "_ReferenceSystem");
				}
			}
		}
		protected AE.IAbstractReferenceSystemType m__ReferenceSystem;

		#endregion

		#region Attribute - SubGrp_ReferenceSystem
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for Definition
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("SubGrp_ReferenceSystem", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement, typeof(AE.SubGrp_ReferenceSystem))]
		public AE.SubGrp_ReferenceSystem SubGrp_ReferenceSystem
		{
			get 
			{ 
				return m_SubGrp_ReferenceSystem;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"SubGrp_ReferenceSystem"); // remove selection
				if (value == null)
					m_SubGrp_ReferenceSystem = null;
				else
				{
					m_SubGrp_ReferenceSystem = value; 
				}
			}
		}
		protected AE.SubGrp_ReferenceSystem m_SubGrp_ReferenceSystem;
		
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


