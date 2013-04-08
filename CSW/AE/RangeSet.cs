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
	/// 	This class represents the Element rangeSet
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Choice,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element,
													"rangeSet", "http://www.opengis.net/gml", false, false,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class RangeSet : CSW.XmlCommonBase
	{
		#region Constructors
		/// <summary>
		///		Constructor for RangeSet
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public RangeSet()
		{
			_elementName = "rangeSet";
			Init();
		}
		public RangeSet(String elementName)
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
			m_ValueArrayCol = new CSW.XmlObjectCollection<AE.ValueArray>("ValueArray", "http://www.opengis.net/gml", 1, -1, false);
			m_ValueArrayCol.OnCollectionChange += new CSW.XmlObjectCollection<AE.ValueArray>.OnCollectionChangeEvent(this.ValueArrayCol_OnChange);
			m_RangeSet_ChoiceCol = new CSW.XmlObjectCollection<AE.RangeSet_Choice>("rangeSet_Choice", "", 1, -1, true);
			m_RangeSet_ChoiceCol.OnCollectionChange += new CSW.XmlObjectCollection<AE.RangeSet_Choice>.OnCollectionChangeEvent(this.RangeSet_ChoiceCol_OnChange);
			m_DataBlock = null;
			m_File = null;



			_validElement = "";
// ##HAND_CODED_BLOCK_START ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional initialization code here...

// ##HAND_CODED_BLOCK_END ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
		}
		protected void ClearChoice(string selectedElement)
		{
			if (m_ValueArrayCol != null)
			{
				if ("ValueArrayCol" != selectedElement)
					m_ValueArrayCol.Clear();
			}
			if (m_RangeSet_ChoiceCol != null)
			{
				if ("rangeSet_ChoiceCol" != selectedElement)
					m_RangeSet_ChoiceCol.Clear();
			}
			m_DataBlock = null;
			m_File = null;
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
			AE.RangeSet newObject = new AE.RangeSet(_elementName);
			foreach (AE.ValueArray o in m_ValueArrayCol)
				newObject.m_ValueArrayCol.Add((AE.ValueArray)o.Clone());
			foreach (AE.RangeSet_Choice o in m_RangeSet_ChoiceCol)
				newObject.m_RangeSet_ChoiceCol.Add((AE.RangeSet_Choice)o.Clone());
			newObject.m_DataBlock = null;
			if (m_DataBlock != null)
				newObject.m_DataBlock = (AE.DataBlock)m_DataBlock.Clone();
			newObject.m_File = null;
			if (m_File != null)
				newObject.m_File = (AE.File)m_File.Clone();

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

		#region Attribute - ValueArray
		/// <summary>
		/// 	A collection of ValueArrayCols
		///		
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>This collection may contain 1 to Many objects.</BR>
		///		<BR>Only one Element within this class may be set at a time. This collection (as a whole is counted as an element) may contain 0 or 1 to Many entries. Emptying the collection allows a different element to be the selected one. If there is already a selected element, and an item is added to this collection then an exception will be raised</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsCol("ValueArray", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element)]
		public CSW.XmlObjectCollection<AE.ValueArray> ValueArrayCol
		{
			get { return m_ValueArrayCol; }
		}
		// gets called when the collection changes (allows us to determine if this choice is selected or not)
		private void ValueArrayCol_OnChange(object o, EventArgs args)
		{
			// The class represents a choice, so prevent more than one element from being selected
			if (_validElement != "ValueArrayCol")
			{
				ClearChoice(m_ValueArrayCol.Count == 0?"":"ValueArrayCol"); // remove selection
			}
		}
		protected CSW.XmlObjectCollection<AE.ValueArray> m_ValueArrayCol;
		
		#endregion

		#region Attribute - rangeSet_Choice
		/// <summary>
		/// 	A collection of rangeSet_ChoiceCols
		///		
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>This collection may contain 1 to Many objects.</BR>
		///		<BR>Only one Element within this class may be set at a time. This collection (as a whole is counted as an element) may contain 0 or 1 to Many entries. Emptying the collection allows a different element to be the selected one. If there is already a selected element, and an item is added to this collection then an exception will be raised</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsCol("rangeSet_Choice", "", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement)]
		public CSW.XmlObjectCollection<AE.RangeSet_Choice> RangeSet_ChoiceCol
		{
			get { return m_RangeSet_ChoiceCol; }
		}
		// gets called when the collection changes (allows us to determine if this choice is selected or not)
		private void RangeSet_ChoiceCol_OnChange(object o, EventArgs args)
		{
			// The class represents a choice, so prevent more than one element from being selected
			if (_validElement != "rangeSet_ChoiceCol")
			{
				ClearChoice(m_RangeSet_ChoiceCol.Count == 0?"":"rangeSet_ChoiceCol"); // remove selection
			}
		}
		protected CSW.XmlObjectCollection<AE.RangeSet_Choice> m_RangeSet_ChoiceCol;
		
		#endregion

		#region Attribute - DataBlock
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
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("DataBlock", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.DataBlock))]
		public AE.DataBlock DataBlock
		{
			get 
			{ 
				return m_DataBlock;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"DataBlock"); // remove selection
				if (value == null)
					m_DataBlock = null;
				else
				{
					m_DataBlock = value; 
				}
			}
		}
		protected AE.DataBlock m_DataBlock;
		
		#endregion

		#region Attribute - File
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
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("File", "http://www.opengis.net/gml", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(AE.File))]
		public AE.File File
		{
			get 
			{ 
				return m_File;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"File"); // remove selection
				if (value == null)
					m_File = null;
				else
				{
					m_File = value; 
				}
			}
		}
		protected AE.File m_File;
		
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


