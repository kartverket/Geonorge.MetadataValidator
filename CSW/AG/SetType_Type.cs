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

namespace AG
{
	/// <summary>
	/// 	This class represents the Element setType_Type
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Sequence,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement,
													"setType_Type", "http://www.w3.org/2001/SMIL20/Language", false, false,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class SetType_Type : CSW.XmlCommonBase
	{
		#region Constructors
		/// <summary>
		///		Constructor for SetType_Type
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public SetType_Type()
		{
			_elementName = "setType_Type";
			Init();
		}
		public SetType_Type(String elementName)
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
			m_Id = "";
			m_IsValidId = false;
			m_Class = "";
			m_IsValidClass = false;
			m_Lang = "";
			m_IsValidLang = false;
			m_Alt = "";
			m_IsValidAlt = false;
			m_Longdesc = "";
			m_IsValidLongdesc = false;
			m_Begin = "";
			m_IsValidBegin = false;
			m_End = "";
			m_IsValidEnd = false;
			m_Dur = "";
			m_IsValidDur = false;
			m_RepeatDur = "";
			m_IsValidRepeatDur = false;
			m_RepeatCount = 0;
			m_IsValidRepeatCount = false;
			m_Repeat = 0;
			m_IsValidRepeat = false;
			m_Min = "";
			m_IsValidMin = false;
			m_Max = "";
			m_IsValidMax = false;
			m_SyncBehavior = AF.Enumerations.SyncBehaviorType.default_;
			m_IsValidSyncBehavior = true;
			m_SyncTolerance = "";
			m_IsValidSyncTolerance = false;
			m_SyncBehaviorDefault = AF.Enumerations.SyncBehaviorDefaultType.Inherit;
			m_IsValidSyncBehaviorDefault = true;
			m_SyncToleranceDefault = LiquidTechnologies.Runtime.Net45.Conversions.stringFromString("inherit", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse);
			m_IsValidSyncToleranceDefault = true;
			m_Restart = AF.Enumerations.RestartTimingType.default_;
			m_IsValidRestart = true;
			m_RestartDefault = AF.Enumerations.RestartDefaultType.Inherit;
			m_IsValidRestartDefault = true;
			m_Fill = AF.Enumerations.FillTimingAttrsType.default_;
			m_IsValidFill = true;
			m_FillDefault = AF.Enumerations.FillDefaultType.Inherit;
			m_IsValidFillDefault = true;
			m_TargetElement = "";
			m_IsValidTargetElement = false;
			m_Skip_content = LiquidTechnologies.Runtime.Net45.Conversions.booleanFromString("true", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse);
			m_IsValidSkip_content = true;
			m_SetType_Type_GroupCol = new CSW.XmlObjectCollection<AG.SetType_Type_Group>("setType_Type_Group", "http://www.w3.org/2001/SMIL20/Language", 0, -1, true);

			_anyAttributes = new LiquidTechnologies.Runtime.Net45.AttributeCol("##any", "##any", "http://www.opengis.net/cat/csw/2.0.2");


// ##HAND_CODED_BLOCK_START ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional initialization code here...

// ##HAND_CODED_BLOCK_END ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
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
			AG.SetType_Type newObject = new AG.SetType_Type(_elementName);
			newObject.m_Id = m_Id;
			newObject.m_IsValidId = m_IsValidId;
			newObject.m_Class = m_Class;
			newObject.m_IsValidClass = m_IsValidClass;
			newObject.m_Lang = m_Lang;
			newObject.m_IsValidLang = m_IsValidLang;
			newObject.m_Alt = m_Alt;
			newObject.m_IsValidAlt = m_IsValidAlt;
			newObject.m_Longdesc = m_Longdesc;
			newObject.m_IsValidLongdesc = m_IsValidLongdesc;
			newObject.m_Begin = m_Begin;
			newObject.m_IsValidBegin = m_IsValidBegin;
			newObject.m_End = m_End;
			newObject.m_IsValidEnd = m_IsValidEnd;
			newObject.m_Dur = m_Dur;
			newObject.m_IsValidDur = m_IsValidDur;
			newObject.m_RepeatDur = m_RepeatDur;
			newObject.m_IsValidRepeatDur = m_IsValidRepeatDur;
			newObject.m_RepeatCount = m_RepeatCount;
			newObject.m_IsValidRepeatCount = m_IsValidRepeatCount;
			newObject.m_Repeat = m_Repeat;
			newObject.m_IsValidRepeat = m_IsValidRepeat;
			newObject.m_Min = m_Min;
			newObject.m_IsValidMin = m_IsValidMin;
			newObject.m_Max = m_Max;
			newObject.m_IsValidMax = m_IsValidMax;
			newObject.m_SyncBehavior = m_SyncBehavior;
			newObject.m_IsValidSyncBehavior = m_IsValidSyncBehavior;
			newObject.m_SyncTolerance = m_SyncTolerance;
			newObject.m_IsValidSyncTolerance = m_IsValidSyncTolerance;
			newObject.m_SyncBehaviorDefault = m_SyncBehaviorDefault;
			newObject.m_IsValidSyncBehaviorDefault = m_IsValidSyncBehaviorDefault;
			newObject.m_SyncToleranceDefault = m_SyncToleranceDefault;
			newObject.m_IsValidSyncToleranceDefault = m_IsValidSyncToleranceDefault;
			newObject.m_Restart = m_Restart;
			newObject.m_IsValidRestart = m_IsValidRestart;
			newObject.m_RestartDefault = m_RestartDefault;
			newObject.m_IsValidRestartDefault = m_IsValidRestartDefault;
			newObject.m_Fill = m_Fill;
			newObject.m_IsValidFill = m_IsValidFill;
			newObject.m_FillDefault = m_FillDefault;
			newObject.m_IsValidFillDefault = m_IsValidFillDefault;
			newObject.m_TargetElement = m_TargetElement;
			newObject.m_IsValidTargetElement = m_IsValidTargetElement;
			newObject.m_Skip_content = m_Skip_content;
			newObject.m_IsValidSkip_content = m_IsValidSkip_content;
			foreach (AG.SetType_Type_Group o in m_SetType_Type_GroupCol)
				newObject.m_SetType_Type_GroupCol.Add((AG.SetType_Type_Group)o.Clone());

			newObject._anyAttributes = (LiquidTechnologies.Runtime.Net45.AttributeCol)_anyAttributes.Clone();

// ##HAND_CODED_BLOCK_START ID="Additional clone"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional clone code here...

// ##HAND_CODED_BLOCK_END ID="Additional clone"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

			return newObject;
		}
		#endregion

		#region Member variables

		protected override String TargetNamespace
		{
			get { return "http://www.w3.org/2001/SMIL20/Language"; }
		}

		#region Attribute - id
		/// <summary>
		///		Represents an optional Attribute in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Attribute in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoPrimitive("id", "", "IsValidId", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, null, "", -1, -1, "", "", "", "", -1)]
		public String Id
		{
			get 
			{ 
				if (m_IsValidId == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property id is not valid. Set idValid = true");
				return m_Id;  
			}
			set 
			{ 
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Collapse(value); 
				m_IsValidId = true;
				m_Id = value;
			}
		}
		/// <summary>
		/// 	Indicates if id contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for id is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value ("").</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get id
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidId
		{
			get
			{
				return m_IsValidId;
			}
			set 
			{ 
				if (value != m_IsValidId)
				{
					Id = "";
					m_IsValidId = value;
				}
			}
		}
		protected Boolean m_IsValidId;
		protected String m_Id;
		#endregion

		#region Attribute - class
		/// <summary>
		///		Represents an optional Attribute in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Attribute in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoPrimitive("class", "", "IsValidClass", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, null, "", -1, -1, "", "", "", "", -1)]
		public String class_
		{
			get 
			{ 
				if (m_IsValidClass == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property class_ is not valid. Set class_Valid = true");
				return m_Class;  
			}
			set 
			{ 
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				m_IsValidClass = true;
				m_Class = value;
			}
		}
		/// <summary>
		/// 	Indicates if class_ contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for class_ is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value ("").</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get class_
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidClass
		{
			get
			{
				return m_IsValidClass;
			}
			set 
			{ 
				if (value != m_IsValidClass)
				{
					class_ = "";
					m_IsValidClass = value;
				}
			}
		}
		protected Boolean m_IsValidClass;
		protected String m_Class;
		#endregion

		#region Attribute - lang
		/// <summary>
		///		Represents an optional Attribute in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Attribute in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoPrimitive("lang", "http://www.w3.org/XML/1998/namespace", "IsValidLang", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, null, "", -1, -1, "", "", "", "", -1)]
		public String Lang
		{
			get 
			{ 
				if (m_IsValidLang == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property lang is not valid. Set langValid = true");
				return m_Lang;  
			}
			set 
			{ 
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Collapse(value); 
				m_IsValidLang = true;
				m_Lang = value;
			}
		}
		/// <summary>
		/// 	Indicates if lang contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for lang is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value ("").</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get lang
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidLang
		{
			get
			{
				return m_IsValidLang;
			}
			set 
			{ 
				if (value != m_IsValidLang)
				{
					Lang = "";
					m_IsValidLang = value;
				}
			}
		}
		protected Boolean m_IsValidLang;
		protected String m_Lang;
		#endregion

		#region Attribute - alt
		/// <summary>
		///		Represents an optional Attribute in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Attribute in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoPrimitive("alt", "", "IsValidAlt", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, null, "", -1, -1, "", "", "", "", -1)]
		public String Alt
		{
			get 
			{ 
				if (m_IsValidAlt == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property alt is not valid. Set altValid = true");
				return m_Alt;  
			}
			set 
			{ 
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				m_IsValidAlt = true;
				m_Alt = value;
			}
		}
		/// <summary>
		/// 	Indicates if alt contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for alt is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value ("").</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get alt
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidAlt
		{
			get
			{
				return m_IsValidAlt;
			}
			set 
			{ 
				if (value != m_IsValidAlt)
				{
					Alt = "";
					m_IsValidAlt = value;
				}
			}
		}
		protected Boolean m_IsValidAlt;
		protected String m_Alt;
		#endregion

		#region Attribute - longdesc
		/// <summary>
		///		Represents an optional Attribute in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Attribute in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoPrimitive("longdesc", "", "IsValidLongdesc", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, null, "", -1, -1, "", "", "", "", -1)]
		public String Longdesc
		{
			get 
			{ 
				if (m_IsValidLongdesc == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property longdesc is not valid. Set longdescValid = true");
				return m_Longdesc;  
			}
			set 
			{ 
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Collapse(value); 
				m_IsValidLongdesc = true;
				m_Longdesc = value;
			}
		}
		/// <summary>
		/// 	Indicates if longdesc contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for longdesc is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value ("").</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get longdesc
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidLongdesc
		{
			get
			{
				return m_IsValidLongdesc;
			}
			set 
			{ 
				if (value != m_IsValidLongdesc)
				{
					Longdesc = "";
					m_IsValidLongdesc = value;
				}
			}
		}
		protected Boolean m_IsValidLongdesc;
		protected String m_Longdesc;
		#endregion

		#region Attribute - begin
		/// <summary>
		///		Represents an optional Attribute in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Attribute in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoPrimitive("begin", "", "IsValidBegin", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, null, "", -1, -1, "", "", "", "", -1)]
		public String Begin
		{
			get 
			{ 
				if (m_IsValidBegin == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property begin is not valid. Set beginValid = true");
				return m_Begin;  
			}
			set 
			{ 
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				m_IsValidBegin = true;
				m_Begin = value;
			}
		}
		/// <summary>
		/// 	Indicates if begin contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for begin is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value ("").</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get begin
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidBegin
		{
			get
			{
				return m_IsValidBegin;
			}
			set 
			{ 
				if (value != m_IsValidBegin)
				{
					Begin = "";
					m_IsValidBegin = value;
				}
			}
		}
		protected Boolean m_IsValidBegin;
		protected String m_Begin;
		#endregion

		#region Attribute - end
		/// <summary>
		///		Represents an optional Attribute in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Attribute in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoPrimitive("end", "", "IsValidEnd", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, null, "", -1, -1, "", "", "", "", -1)]
		public String End
		{
			get 
			{ 
				if (m_IsValidEnd == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property end is not valid. Set endValid = true");
				return m_End;  
			}
			set 
			{ 
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				m_IsValidEnd = true;
				m_End = value;
			}
		}
		/// <summary>
		/// 	Indicates if end contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for end is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value ("").</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get end
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidEnd
		{
			get
			{
				return m_IsValidEnd;
			}
			set 
			{ 
				if (value != m_IsValidEnd)
				{
					End = "";
					m_IsValidEnd = value;
				}
			}
		}
		protected Boolean m_IsValidEnd;
		protected String m_End;
		#endregion

		#region Attribute - dur
		/// <summary>
		///		Represents an optional Attribute in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Attribute in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoPrimitive("dur", "", "IsValidDur", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, null, "", -1, -1, "", "", "", "", -1)]
		public String Dur
		{
			get 
			{ 
				if (m_IsValidDur == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property dur is not valid. Set durValid = true");
				return m_Dur;  
			}
			set 
			{ 
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				m_IsValidDur = true;
				m_Dur = value;
			}
		}
		/// <summary>
		/// 	Indicates if dur contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for dur is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value ("").</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get dur
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidDur
		{
			get
			{
				return m_IsValidDur;
			}
			set 
			{ 
				if (value != m_IsValidDur)
				{
					Dur = "";
					m_IsValidDur = value;
				}
			}
		}
		protected Boolean m_IsValidDur;
		protected String m_Dur;
		#endregion

		#region Attribute - repeatDur
		/// <summary>
		///		Represents an optional Attribute in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Attribute in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoPrimitive("repeatDur", "", "IsValidRepeatDur", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, null, "", -1, -1, "", "", "", "", -1)]
		public String RepeatDur
		{
			get 
			{ 
				if (m_IsValidRepeatDur == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property repeatDur is not valid. Set repeatDurValid = true");
				return m_RepeatDur;  
			}
			set 
			{ 
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				m_IsValidRepeatDur = true;
				m_RepeatDur = value;
			}
		}
		/// <summary>
		/// 	Indicates if repeatDur contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for repeatDur is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value ("").</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get repeatDur
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidRepeatDur
		{
			get
			{
				return m_IsValidRepeatDur;
			}
			set 
			{ 
				if (value != m_IsValidRepeatDur)
				{
					RepeatDur = "";
					m_IsValidRepeatDur = value;
				}
			}
		}
		protected Boolean m_IsValidRepeatDur;
		protected String m_RepeatDur;
		#endregion

		#region Attribute - repeatCount
		/// <summary>
		///		Represents an optional Attribute in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Attribute in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoPrimitive("repeatCount", "", "IsValidRepeatCount", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_decimal, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, null, "", -1, -1, "0.0", "", "", "", -1)]
		public Decimal RepeatCount
		{
			get 
			{ 
				if (m_IsValidRepeatCount == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property repeatCount is not valid. Set repeatCountValid = true");
				return m_RepeatCount;  
			}
			set 
			{ 
				CheckAttributeRestriction(9, value);
				m_IsValidRepeatCount = true;
				m_RepeatCount = value;
			}
		}
		/// <summary>
		/// 	Indicates if repeatCount contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for repeatCount is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value (0).</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get repeatCount
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidRepeatCount
		{
			get
			{
				return m_IsValidRepeatCount;
			}
			set 
			{ 
				if (value != m_IsValidRepeatCount)
				{
					RepeatCount = 0;
					m_IsValidRepeatCount = value;
				}
			}
		}
		protected Boolean m_IsValidRepeatCount;
		protected Decimal m_RepeatCount;
		#endregion

		#region Attribute - repeat
		/// <summary>
		///		Represents an optional Attribute in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Attribute in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoPrimitive("repeat", "", "IsValidRepeat", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_integer, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, null, "", -1, -1, "", "", "", "", -1)]
		public LiquidTechnologies.Runtime.Net45.BigInteger Repeat
		{
			get 
			{ 
				if (m_IsValidRepeat == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property repeat is not valid. Set repeatValid = true");
				return m_Repeat;  
			}
			set 
			{ 
				m_IsValidRepeat = true;
				m_Repeat = value;
			}
		}
		/// <summary>
		/// 	Indicates if repeat contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for repeat is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value (0).</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get repeat
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidRepeat
		{
			get
			{
				return m_IsValidRepeat;
			}
			set 
			{ 
				if (value != m_IsValidRepeat)
				{
					Repeat = 0;
					m_IsValidRepeat = value;
				}
			}
		}
		protected Boolean m_IsValidRepeat;
		protected LiquidTechnologies.Runtime.Net45.BigInteger m_Repeat;
		#endregion

		#region Attribute - min
		/// <summary>
		///		Represents an optional Attribute in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Attribute in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoPrimitive("min", "", "IsValidMin", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, null, "", -1, -1, "", "", "", "", -1)]
		public String Min
		{
			get 
			{ 
				if (m_IsValidMin == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property min is not valid. Set minValid = true");
				return m_Min;  
			}
			set 
			{ 
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				m_IsValidMin = true;
				m_Min = value;
			}
		}
		/// <summary>
		/// 	Indicates if min contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for min is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value ("").</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get min
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidMin
		{
			get
			{
				return m_IsValidMin;
			}
			set 
			{ 
				if (value != m_IsValidMin)
				{
					Min = "";
					m_IsValidMin = value;
				}
			}
		}
		protected Boolean m_IsValidMin;
		protected String m_Min;
		#endregion

		#region Attribute - max
		/// <summary>
		///		Represents an optional Attribute in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Attribute in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoPrimitive("max", "", "IsValidMax", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, null, "", -1, -1, "", "", "", "", -1)]
		public String Max
		{
			get 
			{ 
				if (m_IsValidMax == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property max is not valid. Set maxValid = true");
				return m_Max;  
			}
			set 
			{ 
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				m_IsValidMax = true;
				m_Max = value;
			}
		}
		/// <summary>
		/// 	Indicates if max contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for max is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value ("").</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get max
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidMax
		{
			get
			{
				return m_IsValidMax;
			}
			set 
			{ 
				if (value != m_IsValidMax)
				{
					Max = "";
					m_IsValidMax = value;
				}
			}
		}
		protected Boolean m_IsValidMax;
		protected String m_Max;
		#endregion

		#region Attribute - syncBehavior
		/// <summary>
		///		Represents an optional Attribute in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Attribute in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoEnum("syncBehavior", "", "IsValidSyncBehavior", typeof(AF.Enumerations), "SyncBehaviorTypeFromString", "SyncBehaviorTypeToString", "default")]
		public AF.Enumerations.SyncBehaviorType SyncBehavior
		{
			get 
			{ 
				if (m_IsValidSyncBehavior == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property syncBehavior is not valid. Set syncBehaviorValid = true");
				return m_SyncBehavior;  
			}
			set 
			{ 
				m_SyncBehavior = value;
				m_IsValidSyncBehavior = true;
			}
		}
		/// <summary>
		/// 	Indicates if syncBehavior contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for syncBehavior is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value (AF.Enumerations.SyncBehaviorType.default_).</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get syncBehavior
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidSyncBehavior
		{
			get { return m_IsValidSyncBehavior;  }
			set 
			{ 
				if (value != m_IsValidSyncBehavior)
				{
					SyncBehavior = AF.Enumerations.SyncBehaviorType.default_;
					m_IsValidSyncBehavior = value;
				}
			}
		}
		protected AF.Enumerations.SyncBehaviorType m_SyncBehavior;
		protected Boolean m_IsValidSyncBehavior;

		#endregion

		#region Attribute - syncTolerance
		/// <summary>
		///		Represents an optional Attribute in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Attribute in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoPrimitive("syncTolerance", "", "IsValidSyncTolerance", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, null, "", -1, -1, "", "", "", "", -1)]
		public String SyncTolerance
		{
			get 
			{ 
				if (m_IsValidSyncTolerance == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property syncTolerance is not valid. Set syncToleranceValid = true");
				return m_SyncTolerance;  
			}
			set 
			{ 
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				m_IsValidSyncTolerance = true;
				m_SyncTolerance = value;
			}
		}
		/// <summary>
		/// 	Indicates if syncTolerance contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for syncTolerance is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value ("").</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get syncTolerance
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidSyncTolerance
		{
			get
			{
				return m_IsValidSyncTolerance;
			}
			set 
			{ 
				if (value != m_IsValidSyncTolerance)
				{
					SyncTolerance = "";
					m_IsValidSyncTolerance = value;
				}
			}
		}
		protected Boolean m_IsValidSyncTolerance;
		protected String m_SyncTolerance;
		#endregion

		#region Attribute - syncBehaviorDefault
		/// <summary>
		///		Represents an optional Attribute in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Attribute in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoEnum("syncBehaviorDefault", "", "IsValidSyncBehaviorDefault", typeof(AF.Enumerations), "SyncBehaviorDefaultTypeFromString", "SyncBehaviorDefaultTypeToString", "inherit")]
		public AF.Enumerations.SyncBehaviorDefaultType SyncBehaviorDefault
		{
			get 
			{ 
				if (m_IsValidSyncBehaviorDefault == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property syncBehaviorDefault is not valid. Set syncBehaviorDefaultValid = true");
				return m_SyncBehaviorDefault;  
			}
			set 
			{ 
				m_SyncBehaviorDefault = value;
				m_IsValidSyncBehaviorDefault = true;
			}
		}
		/// <summary>
		/// 	Indicates if syncBehaviorDefault contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for syncBehaviorDefault is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value (AF.Enumerations.SyncBehaviorDefaultType.Inherit).</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get syncBehaviorDefault
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidSyncBehaviorDefault
		{
			get { return m_IsValidSyncBehaviorDefault;  }
			set 
			{ 
				if (value != m_IsValidSyncBehaviorDefault)
				{
					SyncBehaviorDefault = AF.Enumerations.SyncBehaviorDefaultType.Inherit;
					m_IsValidSyncBehaviorDefault = value;
				}
			}
		}
		protected AF.Enumerations.SyncBehaviorDefaultType m_SyncBehaviorDefault;
		protected Boolean m_IsValidSyncBehaviorDefault;

		#endregion

		#region Attribute - syncToleranceDefault
		/// <summary>
		///		Represents an optional Attribute in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Attribute in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoPrimitive("syncToleranceDefault", "", "IsValidSyncToleranceDefault", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Preserve, "inherit", "", -1, -1, "", "", "", "", -1)]
		public String SyncToleranceDefault
		{
			get 
			{ 
				if (m_IsValidSyncToleranceDefault == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property syncToleranceDefault is not valid. Set syncToleranceDefaultValid = true");
				return m_SyncToleranceDefault;  
			}
			set 
			{ 
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Preserve(value); 
				m_IsValidSyncToleranceDefault = true;
				m_SyncToleranceDefault = value;
			}
		}
		/// <summary>
		/// 	Indicates if syncToleranceDefault contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for syncToleranceDefault is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value (LiquidTechnologies.Runtime.Net45.Conversions.stringFromString("inherit", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)).</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get syncToleranceDefault
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidSyncToleranceDefault
		{
			get
			{
				return m_IsValidSyncToleranceDefault;
			}
			set 
			{ 
				// Attributes with Default can not be removed.
				if (!value)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property syncToleranceDefault has a a default value, and is an attribute, because of this it can not be removed from the schema");
			}
		}
		protected Boolean m_IsValidSyncToleranceDefault;
		protected String m_SyncToleranceDefault;
		#endregion

		#region Attribute - restart
		/// <summary>
		///		Represents an optional Attribute in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Attribute in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoEnum("restart", "", "IsValidRestart", typeof(AF.Enumerations), "RestartTimingTypeFromString", "RestartTimingTypeToString", "default")]
		public AF.Enumerations.RestartTimingType Restart
		{
			get 
			{ 
				if (m_IsValidRestart == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property restart is not valid. Set restartValid = true");
				return m_Restart;  
			}
			set 
			{ 
				m_Restart = value;
				m_IsValidRestart = true;
			}
		}
		/// <summary>
		/// 	Indicates if restart contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for restart is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value (AF.Enumerations.RestartTimingType.default_).</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get restart
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidRestart
		{
			get { return m_IsValidRestart;  }
			set 
			{ 
				if (value != m_IsValidRestart)
				{
					Restart = AF.Enumerations.RestartTimingType.default_;
					m_IsValidRestart = value;
				}
			}
		}
		protected AF.Enumerations.RestartTimingType m_Restart;
		protected Boolean m_IsValidRestart;

		#endregion

		#region Attribute - restartDefault
		/// <summary>
		///		Represents an optional Attribute in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Attribute in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoEnum("restartDefault", "", "IsValidRestartDefault", typeof(AF.Enumerations), "RestartDefaultTypeFromString", "RestartDefaultTypeToString", "inherit")]
		public AF.Enumerations.RestartDefaultType RestartDefault
		{
			get 
			{ 
				if (m_IsValidRestartDefault == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property restartDefault is not valid. Set restartDefaultValid = true");
				return m_RestartDefault;  
			}
			set 
			{ 
				m_RestartDefault = value;
				m_IsValidRestartDefault = true;
			}
		}
		/// <summary>
		/// 	Indicates if restartDefault contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for restartDefault is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value (AF.Enumerations.RestartDefaultType.Inherit).</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get restartDefault
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidRestartDefault
		{
			get { return m_IsValidRestartDefault;  }
			set 
			{ 
				if (value != m_IsValidRestartDefault)
				{
					RestartDefault = AF.Enumerations.RestartDefaultType.Inherit;
					m_IsValidRestartDefault = value;
				}
			}
		}
		protected AF.Enumerations.RestartDefaultType m_RestartDefault;
		protected Boolean m_IsValidRestartDefault;

		#endregion

		#region Attribute - fill
		/// <summary>
		///		Represents an optional Attribute in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Attribute in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoEnum("fill", "", "IsValidFill", typeof(AF.Enumerations), "FillTimingAttrsTypeFromString", "FillTimingAttrsTypeToString", "default")]
		public AF.Enumerations.FillTimingAttrsType Fill
		{
			get 
			{ 
				if (m_IsValidFill == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property fill is not valid. Set fillValid = true");
				return m_Fill;  
			}
			set 
			{ 
				m_Fill = value;
				m_IsValidFill = true;
			}
		}
		/// <summary>
		/// 	Indicates if fill contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for fill is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value (AF.Enumerations.FillTimingAttrsType.default_).</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get fill
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidFill
		{
			get { return m_IsValidFill;  }
			set 
			{ 
				if (value != m_IsValidFill)
				{
					Fill = AF.Enumerations.FillTimingAttrsType.default_;
					m_IsValidFill = value;
				}
			}
		}
		protected AF.Enumerations.FillTimingAttrsType m_Fill;
		protected Boolean m_IsValidFill;

		#endregion

		#region Attribute - fillDefault
		/// <summary>
		///		Represents an optional Attribute in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Attribute in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoEnum("fillDefault", "", "IsValidFillDefault", typeof(AF.Enumerations), "FillDefaultTypeFromString", "FillDefaultTypeToString", "inherit")]
		public AF.Enumerations.FillDefaultType FillDefault
		{
			get 
			{ 
				if (m_IsValidFillDefault == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property fillDefault is not valid. Set fillDefaultValid = true");
				return m_FillDefault;  
			}
			set 
			{ 
				m_FillDefault = value;
				m_IsValidFillDefault = true;
			}
		}
		/// <summary>
		/// 	Indicates if fillDefault contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for fillDefault is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value (AF.Enumerations.FillDefaultType.Inherit).</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get fillDefault
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidFillDefault
		{
			get { return m_IsValidFillDefault;  }
			set 
			{ 
				if (value != m_IsValidFillDefault)
				{
					FillDefault = AF.Enumerations.FillDefaultType.Inherit;
					m_IsValidFillDefault = value;
				}
			}
		}
		protected AF.Enumerations.FillDefaultType m_FillDefault;
		protected Boolean m_IsValidFillDefault;

		#endregion

		#region Attribute - targetElement
		/// <summary>
		///		Represents an optional Attribute in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Attribute in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoPrimitive("targetElement", "", "IsValidTargetElement", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_string, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, null, "", -1, -1, "", "", "", "", -1)]
		public String TargetElement
		{
			get 
			{ 
				if (m_IsValidTargetElement == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property targetElement is not valid. Set targetElementValid = true");
				return m_TargetElement;  
			}
			set 
			{ 
				// Apply whitespace rules appropriately
				value = LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Collapse(value); 
				m_IsValidTargetElement = true;
				m_TargetElement = value;
			}
		}
		/// <summary>
		/// 	Indicates if targetElement contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for targetElement is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value ("").</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get targetElement
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidTargetElement
		{
			get
			{
				return m_IsValidTargetElement;
			}
			set 
			{ 
				if (value != m_IsValidTargetElement)
				{
					TargetElement = "";
					m_IsValidTargetElement = value;
				}
			}
		}
		protected Boolean m_IsValidTargetElement;
		protected String m_TargetElement;
		#endregion

		#region Attribute - skip-content
		/// <summary>
		///		Represents an optional Attribute in the XML document
		/// 	
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Attribute in the XML.</BR>
		/// 	<BR>It is optional, initially it is not valid.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.AttributeInfoPrimitive("skip-content", "", "IsValidSkip_content", LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_boolean, null, LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse, "true", "", -1, -1, "", "", "", "", -1)]
		public Boolean Skip_content
		{
			get 
			{ 
				if (m_IsValidSkip_content == false)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property skip_content is not valid. Set skip_contentValid = true");
				return m_Skip_content;  
			}
			set 
			{ 
				m_IsValidSkip_content = true;
				m_Skip_content = value;
			}
		}
		/// <summary>
		/// 	Indicates if skip_content contains a valid value.
		/// </summary>
		/// <remarks>
		/// 	<BR>true if the value for skip_content is valid, false if not.</BR>
		///		<BR>If this is set to true then the property is considered valid, and assigned its
		///		default value (LiquidTechnologies.Runtime.Net45.Conversions.booleanFromString("true", LiquidTechnologies.Runtime.Net45.WhitespaceUtils.WhitespaceRule.Collapse)).</BR>
		///		<BR>If its set to false then its made invalid, and subsequent calls to get skip_content
		///		will raise an exception.</BR>
		/// </remarks>
		public Boolean IsValidSkip_content
		{
			get
			{
				return m_IsValidSkip_content;
			}
			set 
			{ 
				// Attributes with Default can not be removed.
				if (!value)
					throw new LiquidTechnologies.Runtime.Net45.LtInvalidStateException("The Property skip_content has a a default value, and is an attribute, because of this it can not be removed from the schema");
			}
		}
		protected Boolean m_IsValidSkip_content;
		protected Boolean m_Skip_content;
		#endregion

		#region Attribute - setType_Type_Group
		/// <summary>
		/// 	A collection of setType_Type_GroupCols
		///		
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>This collection may contain 0 to Many objects.</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoSeqClsCol("setType_Type_Group", "http://www.w3.org/2001/SMIL20/Language", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement)]
		public CSW.XmlObjectCollection<AG.SetType_Type_Group> SetType_Type_GroupCol
		{
			get { return m_SetType_Type_GroupCol; }
		}
		protected CSW.XmlObjectCollection<AG.SetType_Type_Group> m_SetType_Type_GroupCol;
		
		#endregion

		#region Attribute - AnyAttribute
		
		/// <summary>
		/// 	Additional attributes
		/// </summary>
		/// <remarks>
		/// </remarks>
		[LiquidTechnologies.Runtime.Net45.AttributeInfoAny("Any", "http://www.w3.org/2001/SMIL20/Language", "##any", "http://www.opengis.net/cat/csw/2.0.2", null)]
		public LiquidTechnologies.Runtime.Net45.AttributeCol AnyAttributes
		{
			get { return _anyAttributes;  }
		}
		protected LiquidTechnologies.Runtime.Net45.AttributeCol _anyAttributes;
		#endregion
		#region Attribute - Namespace
		public override String Namespace
		{
			get { return "http://www.w3.org/2001/SMIL20/Language"; }
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


