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

namespace ogc
{
	/// <summary>
	/// 	This class represents the Element SubGrpexpression
	/// </summary>
	[LiquidTechnologies.Runtime.Net45.XmlObjectInfo(LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementGroupType.Choice,
													LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.PseudoElement,
													"SubGrpexpression", "http://www.opengis.net/ogc", false, false,
													LiquidTechnologies.Runtime.Net45.Conversions.ConversionType.type_none, null, false)]
	public partial class SubGrpexpression : CSW.XmlCommonBase
	{
		#region Constructors
		/// <summary>
		///		Constructor for SubGrpexpression
		/// </summary>
		/// <remarks>
		///		<BR>The class is created with all the mandatory fields populated with the
		///		default data. </BR>
		///		<BR>All Collection object are created.</BR>
		///		<BR>However any 1-n relationships (these are represented as collections) are
		///		empty. To comply with the schema these must be populated before the xml
		///		obtained from ToXml is valid against the schema C:\dev\prosjekter\Kartverket-hurtigtiltak\MetadataMonitor\xsd\csw-discovery.xsd</BR>
		/// </remarks>
		public SubGrpexpression()
		{
			_elementName = "SubGrpexpression";
			Init();
		}
		public SubGrpexpression(String elementName)
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
			m_Expression = null;
			m_Div = null;
			m_PropertyName = null;
			m_Literal = null;
			m_Mul = null;
			m_Sub = null;
			m_Function = null;
			m_Add = null;



			_validElement = "";
// ##HAND_CODED_BLOCK_START ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional initialization code here...

// ##HAND_CODED_BLOCK_END ID="Additional Inits"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
		}
		protected void ClearChoice(string selectedElement)
		{
			m_Expression = null;
			m_Div = null;
			m_PropertyName = null;
			m_Literal = null;
			m_Mul = null;
			m_Sub = null;
			m_Function = null;
			m_Add = null;
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
			ogc.SubGrpexpression newObject = new ogc.SubGrpexpression(_elementName);
			newObject.m_Expression = null;
			if (m_Expression != null)
				newObject.m_Expression = (ogc.IExpressionType)m_Expression.Clone();
			newObject.m_Div = null;
			if (m_Div != null)
				newObject.m_Div = (ogc.Div)m_Div.Clone();
			newObject.m_PropertyName = null;
			if (m_PropertyName != null)
				newObject.m_PropertyName = (ogc.PropertyName)m_PropertyName.Clone();
			newObject.m_Literal = null;
			if (m_Literal != null)
				newObject.m_Literal = (ogc.Literal)m_Literal.Clone();
			newObject.m_Mul = null;
			if (m_Mul != null)
				newObject.m_Mul = (ogc.Mul)m_Mul.Clone();
			newObject.m_Sub = null;
			if (m_Sub != null)
				newObject.m_Sub = (ogc.Sub)m_Sub.Clone();
			newObject.m_Function = null;
			if (m_Function != null)
				newObject.m_Function = (ogc.Function)m_Function.Clone();
			newObject.m_Add = null;
			if (m_Add != null)
				newObject.m_Add = (ogc.Add)m_Add.Clone();

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
			get { return "http://www.opengis.net/ogc"; }
		}

		#region Attribute - expression
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
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceAbsClsOpt("expression", "http://www.opengis.net/ogc", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(ogc.ClassFactory), "IExpressionTypeCreateObject")]
		public ogc.IExpressionType Expression
		{
			get 
			{ 
				return m_Expression;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"expression"); // remove selection
				if (value == null)
					m_Expression = null;
				else
				{
					m_Expression = value; 
					// The object being set needs to take the element name from the class (the type="" attribute will then be set in the XML)
					SetElementName(value.GetBase(), "expression");
				}
			}
		}
		protected ogc.IExpressionType m_Expression;

		#endregion

		#region Attribute - Div
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for expression
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("Div", "http://www.opengis.net/ogc", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(ogc.Div))]
		public ogc.Div Div
		{
			get 
			{ 
				return m_Div;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"Div"); // remove selection
				if (value == null)
					m_Div = null;
				else
				{
					m_Div = value; 
				}
			}
		}
		protected ogc.Div m_Div;
		
		#endregion

		#region Attribute - PropertyName
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for expression
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("PropertyName", "http://www.opengis.net/ogc", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(ogc.PropertyName))]
		public ogc.PropertyName PropertyName
		{
			get 
			{ 
				return m_PropertyName;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"PropertyName"); // remove selection
				if (value == null)
					m_PropertyName = null;
				else
				{
					m_PropertyName = value; 
				}
			}
		}
		protected ogc.PropertyName m_PropertyName;
		
		#endregion

		#region Attribute - Literal
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for expression
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("Literal", "http://www.opengis.net/ogc", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(ogc.Literal))]
		public ogc.Literal Literal
		{
			get 
			{ 
				return m_Literal;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"Literal"); // remove selection
				if (value == null)
					m_Literal = null;
				else
				{
					m_Literal = value; 
				}
			}
		}
		protected ogc.Literal m_Literal;
		
		#endregion

		#region Attribute - Mul
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for expression
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("Mul", "http://www.opengis.net/ogc", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(ogc.Mul))]
		public ogc.Mul Mul
		{
			get 
			{ 
				return m_Mul;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"Mul"); // remove selection
				if (value == null)
					m_Mul = null;
				else
				{
					m_Mul = value; 
				}
			}
		}
		protected ogc.Mul m_Mul;
		
		#endregion

		#region Attribute - Sub
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for expression
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("Sub", "http://www.opengis.net/ogc", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(ogc.Sub))]
		public ogc.Sub Sub
		{
			get 
			{ 
				return m_Sub;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"Sub"); // remove selection
				if (value == null)
					m_Sub = null;
				else
				{
					m_Sub = value; 
				}
			}
		}
		protected ogc.Sub m_Sub;
		
		#endregion

		#region Attribute - Function
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for expression
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("Function", "http://www.opengis.net/ogc", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(ogc.Function))]
		public ogc.Function Function
		{
			get 
			{ 
				return m_Function;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"Function"); // remove selection
				if (value == null)
					m_Function = null;
				else
				{
					m_Function = value; 
				}
			}
		}
		protected ogc.Function m_Function;
		
		#endregion

		#region Attribute - Add
		/// <summary>
		///		Represents an optional Element in the XML document
		/// 	One of the posible substitutions for expression
		/// </summary>
		/// <remarks>
		/// 	<BR></BR>
		/// 	<BR>This property is represented as an Element in the XML.</BR>
		/// 	<BR>It is optional, initially it is null.</BR>
		///		<BR>Only one Element within this class may be set at a time, setting this property when another element is already set will raise an exception. setting this property to null will allow another element to be selected</BR>
		/// </remarks>
        [LiquidTechnologies.Runtime.Net45.ElementInfoChoiceClsOpt("Add", "http://www.opengis.net/ogc", LiquidTechnologies.Runtime.Net45.XmlObjectBase.XmlElementType.Element, typeof(ogc.Add))]
		public ogc.Add Add
		{
			get 
			{ 
				return m_Add;  
			}
			set 
			{ 
				// The class represents a choice, so prevent more than one element from being selected
				ClearChoice((value == null)?"":"Add"); // remove selection
				if (value == null)
					m_Add = null;
				else
				{
					m_Add = value; 
				}
			}
		}
		protected ogc.Add m_Add;
		
		#endregion

		public String ChoiceSelectedElement
		{
			get { return _validElement;  }
		}
		protected String _validElement;
		#region Attribute - Namespace
		public override String Namespace
		{
			get { return "http://www.opengis.net/ogc"; }
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


