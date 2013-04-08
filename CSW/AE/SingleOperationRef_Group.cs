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
	/// 	This class represents the Element singleOperationRef_Group
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Choice,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement,
													"singleOperationRef_Group", "http://www.opengis.net/gml", false, false,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class SingleOperationRef_Group : CSW.XmlCommonBase
	{
		#region Constructors
		/// <summary>
		///		Constructor for SingleOperationRef_Group
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public SingleOperationRef_Group()
		{
			_elementName = "singleOperationRef_Group";
			Init();
		}
		public SingleOperationRef_Group(String elementName)
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
			m__SingleOperation = null;
			m__Operation = null;
			m_SubGrp_Operation = null;
			m_PassThroughOperation = null;



			_validElement = "";
// ##HAND_CODED_BLOCK_START ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional initialization code here...

// ##HAND_CODED_BLOCK_END ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
		}
		protected void ClearChoice(string selectedElement)
		{
			m__SingleOperation = null;
			m__Operation = null;
			m_SubGrp_Operation = null;
			m_PassThroughOperation = null;
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
			AE.SingleOperationRef_Group newObject = new AE.SingleOperationRef_Group(_elementName);
			newObject.m__SingleOperation = null;
			if (m__SingleOperation != null)
				newObject.m__SingleOperation = (AE.IAbstractCoordinateOperationType)m__SingleOperation.Clone();
			newObject.m__Operation = null;
			if (m__Operation != null)
				newObject.m__Operation = (AE.IAbstractCoordinateOperationType)m__Operation.Clone();
			newObject.m_SubGrp_Operation = null;
			if (m_SubGrp_Operation != null)
				newObject.m_SubGrp_Operation = (AE.SubGrp_Operation)m_SubGrp_Operation.Clone();
			newObject.m_PassThroughOperation = null;
			if (m_PassThroughOperation != null)
				newObject.m_PassThroughOperation = (AE.PassThroughOperation)m_PassThroughOperation.Clone();

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

		#region Attribute - _SingleOperation
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
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("_SingleOperation", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.ClassFactory), "IAbstractCoordinateOperationTypeCreateObject")]
		public AE.IAbstractCoordinateOperationType _SingleOperation
		{
			get 
			{ 
				return m__SingleOperation;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"_SingleOperation"); // remove selection
				if (value == null)
					m__SingleOperation = null;
				else
				{
					m__SingleOperation = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "_SingleOperation");
				}
			}
		}
		protected AE.IAbstractCoordinateOperationType m__SingleOperation;

		#endregion

		#region Attribute - _Operation
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _SingleOperation
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("_Operation", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.ClassFactory), "IAbstractCoordinateOperationTypeCreateObject")]
		public AE.IAbstractCoordinateOperationType _Operation
		{
			get 
			{ 
				return m__Operation;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"_Operation"); // remove selection
				if (value == null)
					m__Operation = null;
				else
				{
					m__Operation = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "_Operation");
				}
			}
		}
		protected AE.IAbstractCoordinateOperationType m__Operation;

		#endregion

		#region Attribute - SubGrp_Operation
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _SingleOperation
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("SubGrp_Operation", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement, typeof(AE.SubGrp_Operation))]
		public AE.SubGrp_Operation SubGrp_Operation
		{
			get 
			{ 
				return m_SubGrp_Operation;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"SubGrp_Operation"); // remove selection
				if (value == null)
					m_SubGrp_Operation = null;
				else
				{
					m_SubGrp_Operation = value; 
				}
			}
		}
		protected AE.SubGrp_Operation m_SubGrp_Operation;
		
		#endregion

		#region Attribute - PassThroughOperation
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for _SingleOperation
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("PassThroughOperation", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.PassThroughOperation))]
		public AE.PassThroughOperation PassThroughOperation
		{
			get 
			{ 
				return m_PassThroughOperation;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"PassThroughOperation"); // remove selection
				if (value == null)
					m_PassThroughOperation = null;
				else
				{
					m_PassThroughOperation = value; 
				}
			}
		}
		protected AE.PassThroughOperation m_PassThroughOperation;
		
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


