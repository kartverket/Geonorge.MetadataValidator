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
	/// 	This class represents the Element SubGrpAbstractRecord
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Choice,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement,
													"SubGrpAbstractRecord", "http://www.opengis.net/cat/csw/2.0.2", false, false,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class SubGrpAbstractRecord : CSW.XmlCommonBase
	{
		#region Constructors
		/// <summary>
		///		Constructor for SubGrpAbstractRecord
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public SubGrpAbstractRecord()
		{
			_elementName = "SubGrpAbstractRecord";
			Init();
		}
		public SubGrpAbstractRecord(String elementName)
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
			m_AbstractRecord = null;
			m_DCMIRecord = null;
			m_Record = null;
			m_BriefRecord = null;
			m_SummaryRecord = null;



			_validElement = "";
// ##HAND_CODED_BLOCK_START ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional initialization code here...

// ##HAND_CODED_BLOCK_END ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
		}
		protected void ClearChoice(string selectedElement)
		{
			m_AbstractRecord = null;
			m_DCMIRecord = null;
			m_Record = null;
			m_BriefRecord = null;
			m_SummaryRecord = null;
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
			csw.SubGrpAbstractRecord newObject = new csw.SubGrpAbstractRecord(_elementName);
			newObject.m_AbstractRecord = null;
			if (m_AbstractRecord != null)
				newObject.m_AbstractRecord = (csw.IAbstractRecordType)m_AbstractRecord.Clone();
			newObject.m_DCMIRecord = null;
			if (m_DCMIRecord != null)
				newObject.m_DCMIRecord = (csw.IDCMIRecordType)m_DCMIRecord.Clone();
			newObject.m_Record = null;
			if (m_Record != null)
				newObject.m_Record = (csw.Record)m_Record.Clone();
			newObject.m_BriefRecord = null;
			if (m_BriefRecord != null)
				newObject.m_BriefRecord = (csw.BriefRecord)m_BriefRecord.Clone();
			newObject.m_SummaryRecord = null;
			if (m_SummaryRecord != null)
				newObject.m_SummaryRecord = (csw.SummaryRecord)m_SummaryRecord.Clone();

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
		///		Represents an optional Element in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("AbstractRecord", "http://www.opengis.net/cat/csw/2.0.2", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(csw.ClassFactory), "IAbstractRecordTypeCreateObject")]
		public csw.IAbstractRecordType AbstractRecord
		{
			get 
			{ 
				return m_AbstractRecord;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"AbstractRecord"); // remove selection
				if (value == null)
					m_AbstractRecord = null;
				else
				{
					m_AbstractRecord = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "AbstractRecord");
				}
			}
		}
		protected csw.IAbstractRecordType m_AbstractRecord;

		#endregion

		#region Attribute - DCMIRecord
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for AbstractRecord
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("DCMIRecord", "http://www.opengis.net/cat/csw/2.0.2", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(csw.ClassFactory), "IDCMIRecordTypeCreateObject")]
		public csw.IDCMIRecordType DCMIRecord
		{
			get 
			{ 
				return m_DCMIRecord;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"DCMIRecord"); // remove selection
				if (value == null)
					m_DCMIRecord = null;
				else
				{
					m_DCMIRecord = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "DCMIRecord");
				}
			}
		}
		protected csw.IDCMIRecordType m_DCMIRecord;

		#endregion

		#region Attribute - Record
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for AbstractRecord
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("Record", "http://www.opengis.net/cat/csw/2.0.2", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(csw.Record))]
		public csw.Record Record
		{
			get 
			{ 
				return m_Record;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"Record"); // remove selection
				if (value == null)
					m_Record = null;
				else
				{
					m_Record = value; 
				}
			}
		}
		protected csw.Record m_Record;
		
		#endregion

		#region Attribute - BriefRecord
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for AbstractRecord
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("BriefRecord", "http://www.opengis.net/cat/csw/2.0.2", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(csw.BriefRecord))]
		public csw.BriefRecord BriefRecord
		{
			get 
			{ 
				return m_BriefRecord;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"BriefRecord"); // remove selection
				if (value == null)
					m_BriefRecord = null;
				else
				{
					m_BriefRecord = value; 
				}
			}
		}
		protected csw.BriefRecord m_BriefRecord;
		
		#endregion

		#region Attribute - SummaryRecord
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for AbstractRecord
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("SummaryRecord", "http://www.opengis.net/cat/csw/2.0.2", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(csw.SummaryRecord))]
		public csw.SummaryRecord SummaryRecord
		{
			get 
			{ 
				return m_SummaryRecord;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"SummaryRecord"); // remove selection
				if (value == null)
					m_SummaryRecord = null;
				else
				{
					m_SummaryRecord = value; 
				}
			}
		}
		protected csw.SummaryRecord m_SummaryRecord;
		
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


