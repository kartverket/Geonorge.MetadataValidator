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

namespace csw
{
	/// <summary>
	/// 	This class represents the Element GetRecordByIdResponse_Choice
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Choice,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement,
													"GetRecordByIdResponse_Choice", "http://www.opengis.net/cat/csw/2.0.2", false, false,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class GetRecordByIdResponse_Choice : CSW.XmlCommonBase
	{
		#region Constructors
		/// <summary>
		///		Constructor for GetRecordByIdResponse_Choice
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public GetRecordByIdResponse_Choice()
		{
			_elementName = "GetRecordByIdResponse_Choice";
			Init();
		}
		public GetRecordByIdResponse_Choice(String elementName)
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
			m_AbstractRecordCol = new CSW.XmlObjectCollection<csw.SubGrpAbstractRecord>("AbstractRecord", "http://www.opengis.net/cat/csw/2.0.2", 0, -1, true);
			m_AbstractRecordCol.OnCollectionChange += new CSW.XmlObjectCollection<csw.SubGrpAbstractRecord>.OnCollectionChangeEvent(this.AbstractRecordCol_OnChange);
			m_AnyElementCol = new LiquidTechnologies.Runtime.Net45.ElementCol("", "##other", "http://www.opengis.net/cat/csw/2.0.2", 0, -1);
			m_AnyElementCol.OnCollectionChange += new LiquidTechnologies.Runtime.Net45.ElementCol.OnCollectionChangeEvent(this.AnyElementCol_OnChange);



			_validElement = "";
// ##HAND_CODED_BLOCK_START ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional initialization code here...

// ##HAND_CODED_BLOCK_END ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
		}
		protected void ClearChoice(string selectedElement)
		{
			if (m_AbstractRecordCol != null)
			{
				if ("AbstractRecordCol" != selectedElement)
					m_AbstractRecordCol.Clear();
			}
			if (m_AnyElementCol != null)
			{
				if ("AnyElementCol" != selectedElement)
					m_AnyElementCol.Clear();
			}
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
			csw.GetRecordByIdResponse_Choice newObject = new csw.GetRecordByIdResponse_Choice(_elementName);
			foreach (csw.SubGrpAbstractRecord o in m_AbstractRecordCol)
				newObject.m_AbstractRecordCol.Add((csw.SubGrpAbstractRecord)o.Clone());
			foreach (LiquidTechnologies.Runtime.Net45.Element o in m_AnyElementCol)
				newObject.m_AnyElementCol.Add((LiquidTechnologies.Runtime.Net45.Element)o.Clone());

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
			get { return "http://www.opengis.net/cat/csw/2.0.2"; }
		}

		#region Attribute - AbstractRecord
		/// <summary>
		/// 	A collection of AbstractRecordCols
		///		
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>This collection may contain 0 to Many objects.</BR>
		///		<BR>Only one Element within this class may be set at a time. This collection (as a whole is counted as an element) may contain 0 or 0 to Many entries. Emptying the collection allows a different element to be the selected one. If there is already a selected element, and an item is added to this collection then an exception will be raised</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsCol("AbstractRecord", "http://www.opengis.net/cat/csw/2.0.2", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement)]
		public CSW.XmlObjectCollection<csw.SubGrpAbstractRecord> AbstractRecordCol
		{
			get { return m_AbstractRecordCol; }
		}
		// gets called when the collection changes (allows us to determine if this choice is selected or not)
		private void AbstractRecordCol_OnChange(object o, EventArgs args)
		{
			// The class represents a choice, so prevent more than one element from being selected
			if (_validElement != "AbstractRecordCol")
			{
				ClearChoice(m_AbstractRecordCol.Count == 0?"":"AbstractRecordCol"); // remove selection
			}
		}
		protected CSW.XmlObjectCollection<csw.SubGrpAbstractRecord> m_AbstractRecordCol;
		
		#endregion

		#region Attribute - AnyElement
		/// <summary>
		/// 	A collection of untyped elements
		///		
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as a collection of Elements in the XML.</BR>
		/// 	<BR>This collection may contain 0 to Many objects.</BR>
		///		<BR>Only one Element within this class may be set at a time. This collection (as a whole is counted as an element) may contain 0 or 0 to Many entries. Emptying the collection allows a different element to be the selected one. If there is already a selected element, and an item is added to this collection then an exception will be raised</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceUntpdCol("AnyElement", "")]
		public LiquidTechnologies.Runtime.Net45.ElementCol AnyElementCol
		{
			get { return m_AnyElementCol; }
		}
		// gets called when the collection changes (allows us to determine if this choice is selected or not)
		private void AnyElementCol_OnChange(object o, EventArgs args)
		{
			// The class represents a choice, so prevent more than one element from being selected
			if (_validElement != "AnyElementCol")
			{
				ClearChoice(m_AnyElementCol.Count == 0?"":"AnyElementCol"); // remove selection
			}
		}
		protected LiquidTechnologies.Runtime.Net45.ElementCol m_AnyElementCol;
		#endregion

		public String ChoiceSelectedElement
		{
			get { return _validElement;  }
		}
		protected String _validElement;
		#region Attribute - Namespace
		public override String Namespace
		{
			get { return "http://www.opengis.net/cat/csw/2.0.2"; }
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


