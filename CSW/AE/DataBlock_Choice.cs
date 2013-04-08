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
	/// 	This class represents the Element DataBlock_Choice
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Choice,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement,
													"DataBlock_Choice", "http://www.opengis.net/gml", false, false,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class DataBlock_Choice : CSW.XmlCommonBase
	{
		#region Constructors
		/// <summary>
		///		Constructor for DataBlock_Choice
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public DataBlock_Choice()
		{
			_elementName = "DataBlock_Choice";
			Init();
		}
		public DataBlock_Choice(String elementName)
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
			m_TupleList = null;
			m_DoubleOrNullTupleList = "";
			m_IsValidDoubleOrNullTupleList = false; 



			_validElement = "";
// ##HAND_CODED_BLOCK_START ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional initialization code here...

// ##HAND_CODED_BLOCK_END ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
		}
		protected void ClearChoice(string selectedElement)
		{
			m_TupleList = null;
			m_DoubleOrNullTupleList = "";
			m_IsValidDoubleOrNullTupleList = false;
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
			AE.DataBlock_Choice newObject = new AE.DataBlock_Choice(_elementName);
			newObject.m_TupleList = null;
			if (m_TupleList != null)
				newObject.m_TupleList = (AE.TupleList)m_TupleList.Clone();
			newObject.m_DoubleOrNullTupleList = m_DoubleOrNullTupleList;
			newObject.m_IsValidDoubleOrNullTupleList = m_IsValidDoubleOrNullTupleList;

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

		#region Attribute - tupleList
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
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("tupleList", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.TupleList))]
		public AE.TupleList TupleList
		{
			get 
			{ 
				return m_TupleList;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"tupleList"); // remove selection
				if (value == null)
					m_TupleList = null;
				else
				{
					m_TupleList = value; 
				}
			}
		}
		protected AE.TupleList m_TupleList;
		
		#endregion

		#region Attribute - doubleOrNullTupleList
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoicePrimOpt("doubleOrNullTupleList", "http://www.opengis.net/gml", "IsValidDoubleOrNullTupleList", null, LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "", -1, -1, "", "", "", "", -1)]
		public String DoubleOrNullTupleList
		{
			get 
			{ 
				if (m_IsValidDoubleOrNullTupleList == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property doubleOrNullTupleList is not valid. Set doubleOrNullTupleListValid = true");
				return m_DoubleOrNullTupleList;  
			}
			set 
			{ 
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice("doubleOrNullTupleList"); // remove selection
				m_IsValidDoubleOrNullTupleList = true;
				m_DoubleOrNullTupleList = value;
			}
		}
		/// <summary>
		/// 	Indicates if doubleOrNullTupleList contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for doubleOrNullTupleList is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value ("").</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get doubleOrNullTupleList
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidDoubleOrNullTupleList
		{
			get
			{
				return m_IsValidDoubleOrNullTupleList;
			}
			set 
			{ 
				if (value != m_IsValidDoubleOrNullTupleList)
				{
					DoubleOrNullTupleList = "";
					m_IsValidDoubleOrNullTupleList = value;
				}
			}
		}
		protected Boolean m_IsValidDoubleOrNullTupleList;
		protected String m_DoubleOrNullTupleList;
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


