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
	/// 	This class represents the Element rangeParameters_Group
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Choice,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement,
													"rangeParameters_Group", "http://www.opengis.net/gml", false, false,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class RangeParameters_Group : CSW.XmlCommonBase
	{
		#region Constructors
		/// <summary>
		///		Constructor for RangeParameters_Group
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public RangeParameters_Group()
		{
			_elementName = "rangeParameters_Group";
			Init();
		}
		public RangeParameters_Group(String elementName)
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
			m_RangeParameters_Group_Choice_Choice = null;
			m_RangeParameters_Group_Choice_ChoiceA = null;
			m_RangeParameters_Group_Choice_ChoiceB = null;
			m_CompositeValue = null;



			_validElement = "";
// ##HAND_CODED_BLOCK_START ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional initialization code here...

// ##HAND_CODED_BLOCK_END ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
		}
		protected void ClearChoice(string selectedElement)
		{
			m_RangeParameters_Group_Choice_Choice = null;
			m_RangeParameters_Group_Choice_ChoiceA = null;
			m_RangeParameters_Group_Choice_ChoiceB = null;
			m_CompositeValue = null;
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
			AE.RangeParameters_Group newObject = new AE.RangeParameters_Group(_elementName);
			newObject.m_RangeParameters_Group_Choice_Choice = null;
			if (m_RangeParameters_Group_Choice_Choice != null)
				newObject.m_RangeParameters_Group_Choice_Choice = (AE.RangeParameters_Group_Choice_Choice)m_RangeParameters_Group_Choice_Choice.Clone();
			newObject.m_RangeParameters_Group_Choice_ChoiceA = null;
			if (m_RangeParameters_Group_Choice_ChoiceA != null)
				newObject.m_RangeParameters_Group_Choice_ChoiceA = (AE.RangeParameters_Group_Choice_ChoiceA)m_RangeParameters_Group_Choice_ChoiceA.Clone();
			newObject.m_RangeParameters_Group_Choice_ChoiceB = null;
			if (m_RangeParameters_Group_Choice_ChoiceB != null)
				newObject.m_RangeParameters_Group_Choice_ChoiceB = (AE.RangeParameters_Group_Choice_ChoiceB)m_RangeParameters_Group_Choice_ChoiceB.Clone();
			newObject.m_CompositeValue = null;
			if (m_CompositeValue != null)
				newObject.m_CompositeValue = (AE.SubGrpCompositeValue)m_CompositeValue.Clone();

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

		#region Attribute - rangeParameters_Group_Choice_Choice
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
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("rangeParameters_Group_Choice_Choice", "", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement, typeof(AE.RangeParameters_Group_Choice_Choice))]
		public AE.RangeParameters_Group_Choice_Choice RangeParameters_Group_Choice_Choice
		{
			get 
			{ 
				return m_RangeParameters_Group_Choice_Choice;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"rangeParameters_Group_Choice_Choice"); // remove selection
				if (value == null)
					m_RangeParameters_Group_Choice_Choice = null;
				else
				{
					m_RangeParameters_Group_Choice_Choice = value; 
				}
			}
		}
		protected AE.RangeParameters_Group_Choice_Choice m_RangeParameters_Group_Choice_Choice;
		
		#endregion

		#region Attribute - rangeParameters_Group_Choice_ChoiceA
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
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("rangeParameters_Group_Choice_ChoiceA", "", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement, typeof(AE.RangeParameters_Group_Choice_ChoiceA))]
		public AE.RangeParameters_Group_Choice_ChoiceA RangeParameters_Group_Choice_ChoiceA
		{
			get 
			{ 
				return m_RangeParameters_Group_Choice_ChoiceA;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"rangeParameters_Group_Choice_ChoiceA"); // remove selection
				if (value == null)
					m_RangeParameters_Group_Choice_ChoiceA = null;
				else
				{
					m_RangeParameters_Group_Choice_ChoiceA = value; 
				}
			}
		}
		protected AE.RangeParameters_Group_Choice_ChoiceA m_RangeParameters_Group_Choice_ChoiceA;
		
		#endregion

		#region Attribute - rangeParameters_Group_Choice_ChoiceB
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
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("rangeParameters_Group_Choice_ChoiceB", "", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement, typeof(AE.RangeParameters_Group_Choice_ChoiceB))]
		public AE.RangeParameters_Group_Choice_ChoiceB RangeParameters_Group_Choice_ChoiceB
		{
			get 
			{ 
				return m_RangeParameters_Group_Choice_ChoiceB;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"rangeParameters_Group_Choice_ChoiceB"); // remove selection
				if (value == null)
					m_RangeParameters_Group_Choice_ChoiceB = null;
				else
				{
					m_RangeParameters_Group_Choice_ChoiceB = value; 
				}
			}
		}
		protected AE.RangeParameters_Group_Choice_ChoiceB m_RangeParameters_Group_Choice_ChoiceB;
		
		#endregion

		#region Attribute - CompositeValue
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
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("CompositeValue", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement, typeof(AE.SubGrpCompositeValue))]
		public AE.SubGrpCompositeValue CompositeValue
		{
			get 
			{ 
				return m_CompositeValue;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"CompositeValue"); // remove selection
				if (value == null)
					m_CompositeValue = null;
				else
				{
					m_CompositeValue = value; 
				}
			}
		}
		protected AE.SubGrpCompositeValue m_CompositeValue;
		
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


