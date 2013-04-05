using System;
using System.Collections;
using System.Xml;
using System.Diagnostics;
using System.Collections.Specialized;

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

namespace CSW 
{
	public class Enumerations
	{
		// All the enumerations used within the Schema

		#region Enumeration 'AnimModeAttrs_calcMode'
		#region Enumeration Declaration
		public enum AnimModeAttrs_calcMode
		{
        	Discrete,
        	Linear,
        	Paced
		}
		#endregion


		#region Conversion functions
		/// <summary>
		/// 	Converts a string to a AnimModeAttrs_calcMode enumeration
		/// </summary>
		public static String AnimModeAttrs_calcModeToString(CSW.Enumerations.AnimModeAttrs_calcMode enumValue)
		{
		    switch(enumValue)
		    {
		    case CSW.Enumerations.AnimModeAttrs_calcMode.Discrete:
	    		return "discrete";
		    case CSW.Enumerations.AnimModeAttrs_calcMode.Linear:
	    		return "linear";
		    case CSW.Enumerations.AnimModeAttrs_calcMode.Paced:
	    		return "paced";
			default:
	    		throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for CSW.Enumerations.AnimModeAttrs_calcMode [" + enumValue.ToString() + "]");
			}
		}
	
		/// <summary>
		/// 	Converts a AnimModeAttrs_calcMode enumeration to a string (suitable for the XML document)
		/// </summary>
		public static CSW.Enumerations.AnimModeAttrs_calcMode AnimModeAttrs_calcModeFromString(String enumValue)
		{
		    switch(LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Collapse(enumValue))
		    {
			case "discrete":
	    		return CSW.Enumerations.AnimModeAttrs_calcMode.Discrete;
			case "linear":
	    		return CSW.Enumerations.AnimModeAttrs_calcMode.Linear;
			case "paced":
	    		return CSW.Enumerations.AnimModeAttrs_calcMode.Paced;
			default:
				// ##HAND_CODED_BLOCK_START ID="Default Enum CSW.Enumerations.AnimModeAttrs_calcMode"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
				throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for CSW.Enumerations.AnimModeAttrs_calcMode [" + enumValue + "]");
				// ##HAND_CODED_BLOCK_END ID="Default Enum CSW.Enumerations.AnimModeAttrs_calcMode"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
			}
		}
		
		public static StringCollection AnimModeAttrs_calcModeNames()
		{
			StringCollection ret = new StringCollection();
			System.Type t = typeof(AnimModeAttrs_calcMode);
			foreach (AnimModeAttrs_calcMode e in Enum.GetValues(t))
				ret.Add(AnimModeAttrs_calcModeToString(e));
			return ret;
		}
		
		#endregion
		#endregion

		#region Enumeration 'AnimAddAccumAttrs_additive'
		#region Enumeration Declaration
		public enum AnimAddAccumAttrs_additive
		{
        	Replace,
        	Sum
		}
		#endregion


		#region Conversion functions
		/// <summary>
		/// 	Converts a string to a AnimAddAccumAttrs_additive enumeration
		/// </summary>
		public static String AnimAddAccumAttrs_additiveToString(CSW.Enumerations.AnimAddAccumAttrs_additive enumValue)
		{
		    switch(enumValue)
		    {
		    case CSW.Enumerations.AnimAddAccumAttrs_additive.Replace:
	    		return "replace";
		    case CSW.Enumerations.AnimAddAccumAttrs_additive.Sum:
	    		return "sum";
			default:
	    		throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for CSW.Enumerations.AnimAddAccumAttrs_additive [" + enumValue.ToString() + "]");
			}
		}
	
		/// <summary>
		/// 	Converts a AnimAddAccumAttrs_additive enumeration to a string (suitable for the XML document)
		/// </summary>
		public static CSW.Enumerations.AnimAddAccumAttrs_additive AnimAddAccumAttrs_additiveFromString(String enumValue)
		{
		    switch(LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Collapse(enumValue))
		    {
			case "replace":
	    		return CSW.Enumerations.AnimAddAccumAttrs_additive.Replace;
			case "sum":
	    		return CSW.Enumerations.AnimAddAccumAttrs_additive.Sum;
			default:
				// ##HAND_CODED_BLOCK_START ID="Default Enum CSW.Enumerations.AnimAddAccumAttrs_additive"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
				throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for CSW.Enumerations.AnimAddAccumAttrs_additive [" + enumValue + "]");
				// ##HAND_CODED_BLOCK_END ID="Default Enum CSW.Enumerations.AnimAddAccumAttrs_additive"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
			}
		}
		
		public static StringCollection AnimAddAccumAttrs_additiveNames()
		{
			StringCollection ret = new StringCollection();
			System.Type t = typeof(AnimAddAccumAttrs_additive);
			foreach (AnimAddAccumAttrs_additive e in Enum.GetValues(t))
				ret.Add(AnimAddAccumAttrs_additiveToString(e));
			return ret;
		}
		
		#endregion
		#endregion

		#region Enumeration 'AnimAddAccumAttrs_accumulate'
		#region Enumeration Declaration
		public enum AnimAddAccumAttrs_accumulate
		{
        	None,
        	Sum
		}
		#endregion


		#region Conversion functions
		/// <summary>
		/// 	Converts a string to a AnimAddAccumAttrs_accumulate enumeration
		/// </summary>
		public static String AnimAddAccumAttrs_accumulateToString(CSW.Enumerations.AnimAddAccumAttrs_accumulate enumValue)
		{
		    switch(enumValue)
		    {
		    case CSW.Enumerations.AnimAddAccumAttrs_accumulate.None:
	    		return "none";
		    case CSW.Enumerations.AnimAddAccumAttrs_accumulate.Sum:
	    		return "sum";
			default:
	    		throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for CSW.Enumerations.AnimAddAccumAttrs_accumulate [" + enumValue.ToString() + "]");
			}
		}
	
		/// <summary>
		/// 	Converts a AnimAddAccumAttrs_accumulate enumeration to a string (suitable for the XML document)
		/// </summary>
		public static CSW.Enumerations.AnimAddAccumAttrs_accumulate AnimAddAccumAttrs_accumulateFromString(String enumValue)
		{
		    switch(LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Collapse(enumValue))
		    {
			case "none":
	    		return CSW.Enumerations.AnimAddAccumAttrs_accumulate.None;
			case "sum":
	    		return CSW.Enumerations.AnimAddAccumAttrs_accumulate.Sum;
			default:
				// ##HAND_CODED_BLOCK_START ID="Default Enum CSW.Enumerations.AnimAddAccumAttrs_accumulate"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
				throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for CSW.Enumerations.AnimAddAccumAttrs_accumulate [" + enumValue + "]");
				// ##HAND_CODED_BLOCK_END ID="Default Enum CSW.Enumerations.AnimAddAccumAttrs_accumulate"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
			}
		}
		
		public static StringCollection AnimAddAccumAttrs_accumulateNames()
		{
			StringCollection ret = new StringCollection();
			System.Type t = typeof(AnimAddAccumAttrs_accumulate);
			foreach (AnimAddAccumAttrs_accumulate e in Enum.GetValues(t))
				ret.Add(AnimAddAccumAttrs_accumulateToString(e));
			return ret;
		}
		
		#endregion
		#endregion

		#region Enumeration 'AnimNamedTargetAttrs_attributeType'
		#region Enumeration Declaration
		public enum AnimNamedTargetAttrs_attributeType
		{
        	XML,
        	CSS,
        	Auto
		}
		#endregion


		#region Conversion functions
		/// <summary>
		/// 	Converts a string to a AnimNamedTargetAttrs_attributeType enumeration
		/// </summary>
		public static String AnimNamedTargetAttrs_attributeTypeToString(CSW.Enumerations.AnimNamedTargetAttrs_attributeType enumValue)
		{
		    switch(enumValue)
		    {
		    case CSW.Enumerations.AnimNamedTargetAttrs_attributeType.XML:
	    		return "XML";
		    case CSW.Enumerations.AnimNamedTargetAttrs_attributeType.CSS:
	    		return "CSS";
		    case CSW.Enumerations.AnimNamedTargetAttrs_attributeType.Auto:
	    		return "auto";
			default:
	    		throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for CSW.Enumerations.AnimNamedTargetAttrs_attributeType [" + enumValue.ToString() + "]");
			}
		}
	
		/// <summary>
		/// 	Converts a AnimNamedTargetAttrs_attributeType enumeration to a string (suitable for the XML document)
		/// </summary>
		public static CSW.Enumerations.AnimNamedTargetAttrs_attributeType AnimNamedTargetAttrs_attributeTypeFromString(String enumValue)
		{
		    switch(LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Collapse(enumValue))
		    {
			case "XML":
	    		return CSW.Enumerations.AnimNamedTargetAttrs_attributeType.XML;
			case "CSS":
	    		return CSW.Enumerations.AnimNamedTargetAttrs_attributeType.CSS;
			case "auto":
	    		return CSW.Enumerations.AnimNamedTargetAttrs_attributeType.Auto;
			default:
				// ##HAND_CODED_BLOCK_START ID="Default Enum CSW.Enumerations.AnimNamedTargetAttrs_attributeType"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
				throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for CSW.Enumerations.AnimNamedTargetAttrs_attributeType [" + enumValue + "]");
				// ##HAND_CODED_BLOCK_END ID="Default Enum CSW.Enumerations.AnimNamedTargetAttrs_attributeType"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
			}
		}
		
		public static StringCollection AnimNamedTargetAttrs_attributeTypeNames()
		{
			StringCollection ret = new StringCollection();
			System.Type t = typeof(AnimNamedTargetAttrs_attributeType);
			foreach (AnimNamedTargetAttrs_attributeType e in Enum.GetValues(t))
				ret.Add(AnimNamedTargetAttrs_attributeTypeToString(e));
			return ret;
		}
		
		#endregion
		#endregion

		#region Enumeration 'AnimateColorType_Type_CalcMode'
		#region Enumeration Declaration
		public enum AnimateColorType_Type_CalcMode
		{
        	Discrete,
        	Linear,
        	Paced
		}
		#endregion


		#region Conversion functions
		/// <summary>
		/// 	Converts a string to a AnimateColorType_Type_CalcMode enumeration
		/// </summary>
		public static String AnimateColorType_Type_CalcModeToString(CSW.Enumerations.AnimateColorType_Type_CalcMode enumValue)
		{
		    switch(enumValue)
		    {
		    case CSW.Enumerations.AnimateColorType_Type_CalcMode.Discrete:
	    		return "discrete";
		    case CSW.Enumerations.AnimateColorType_Type_CalcMode.Linear:
	    		return "linear";
		    case CSW.Enumerations.AnimateColorType_Type_CalcMode.Paced:
	    		return "paced";
			default:
	    		throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for CSW.Enumerations.AnimateColorType_Type_CalcMode [" + enumValue.ToString() + "]");
			}
		}
	
		/// <summary>
		/// 	Converts a AnimateColorType_Type_CalcMode enumeration to a string (suitable for the XML document)
		/// </summary>
		public static CSW.Enumerations.AnimateColorType_Type_CalcMode AnimateColorType_Type_CalcModeFromString(String enumValue)
		{
		    switch(LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Collapse(enumValue))
		    {
			case "discrete":
	    		return CSW.Enumerations.AnimateColorType_Type_CalcMode.Discrete;
			case "linear":
	    		return CSW.Enumerations.AnimateColorType_Type_CalcMode.Linear;
			case "paced":
	    		return CSW.Enumerations.AnimateColorType_Type_CalcMode.Paced;
			default:
				// ##HAND_CODED_BLOCK_START ID="Default Enum CSW.Enumerations.AnimateColorType_Type_CalcMode"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
				throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for CSW.Enumerations.AnimateColorType_Type_CalcMode [" + enumValue + "]");
				// ##HAND_CODED_BLOCK_END ID="Default Enum CSW.Enumerations.AnimateColorType_Type_CalcMode"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
			}
		}
		
		public static StringCollection AnimateColorType_Type_CalcModeNames()
		{
			StringCollection ret = new StringCollection();
			System.Type t = typeof(AnimateColorType_Type_CalcMode);
			foreach (AnimateColorType_Type_CalcMode e in Enum.GetValues(t))
				ret.Add(AnimateColorType_Type_CalcModeToString(e));
			return ret;
		}
		
		#endregion
		#endregion

		#region Enumeration 'AnimateMotionType_Type_CalcMode'
		#region Enumeration Declaration
		public enum AnimateMotionType_Type_CalcMode
		{
        	Discrete,
        	Linear,
        	Paced
		}
		#endregion


		#region Conversion functions
		/// <summary>
		/// 	Converts a string to a AnimateMotionType_Type_CalcMode enumeration
		/// </summary>
		public static String AnimateMotionType_Type_CalcModeToString(CSW.Enumerations.AnimateMotionType_Type_CalcMode enumValue)
		{
		    switch(enumValue)
		    {
		    case CSW.Enumerations.AnimateMotionType_Type_CalcMode.Discrete:
	    		return "discrete";
		    case CSW.Enumerations.AnimateMotionType_Type_CalcMode.Linear:
	    		return "linear";
		    case CSW.Enumerations.AnimateMotionType_Type_CalcMode.Paced:
	    		return "paced";
			default:
	    		throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for CSW.Enumerations.AnimateMotionType_Type_CalcMode [" + enumValue.ToString() + "]");
			}
		}
	
		/// <summary>
		/// 	Converts a AnimateMotionType_Type_CalcMode enumeration to a string (suitable for the XML document)
		/// </summary>
		public static CSW.Enumerations.AnimateMotionType_Type_CalcMode AnimateMotionType_Type_CalcModeFromString(String enumValue)
		{
		    switch(LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Collapse(enumValue))
		    {
			case "discrete":
	    		return CSW.Enumerations.AnimateMotionType_Type_CalcMode.Discrete;
			case "linear":
	    		return CSW.Enumerations.AnimateMotionType_Type_CalcMode.Linear;
			case "paced":
	    		return CSW.Enumerations.AnimateMotionType_Type_CalcMode.Paced;
			default:
				// ##HAND_CODED_BLOCK_START ID="Default Enum CSW.Enumerations.AnimateMotionType_Type_CalcMode"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
				throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for CSW.Enumerations.AnimateMotionType_Type_CalcMode [" + enumValue + "]");
				// ##HAND_CODED_BLOCK_END ID="Default Enum CSW.Enumerations.AnimateMotionType_Type_CalcMode"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
			}
		}
		
		public static StringCollection AnimateMotionType_Type_CalcModeNames()
		{
			StringCollection ret = new StringCollection();
			System.Type t = typeof(AnimateMotionType_Type_CalcMode);
			foreach (AnimateMotionType_Type_CalcMode e in Enum.GetValues(t))
				ret.Add(AnimateMotionType_Type_CalcModeToString(e));
			return ret;
		}
		
		#endregion
		#endregion

		#region Enumeration 'AnimateType_Type_CalcMode'
		#region Enumeration Declaration
		public enum AnimateType_Type_CalcMode
		{
        	Discrete,
        	Linear,
        	Paced
		}
		#endregion


		#region Conversion functions
		/// <summary>
		/// 	Converts a string to a AnimateType_Type_CalcMode enumeration
		/// </summary>
		public static String AnimateType_Type_CalcModeToString(CSW.Enumerations.AnimateType_Type_CalcMode enumValue)
		{
		    switch(enumValue)
		    {
		    case CSW.Enumerations.AnimateType_Type_CalcMode.Discrete:
	    		return "discrete";
		    case CSW.Enumerations.AnimateType_Type_CalcMode.Linear:
	    		return "linear";
		    case CSW.Enumerations.AnimateType_Type_CalcMode.Paced:
	    		return "paced";
			default:
	    		throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for CSW.Enumerations.AnimateType_Type_CalcMode [" + enumValue.ToString() + "]");
			}
		}
	
		/// <summary>
		/// 	Converts a AnimateType_Type_CalcMode enumeration to a string (suitable for the XML document)
		/// </summary>
		public static CSW.Enumerations.AnimateType_Type_CalcMode AnimateType_Type_CalcModeFromString(String enumValue)
		{
		    switch(LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Collapse(enumValue))
		    {
			case "discrete":
	    		return CSW.Enumerations.AnimateType_Type_CalcMode.Discrete;
			case "linear":
	    		return CSW.Enumerations.AnimateType_Type_CalcMode.Linear;
			case "paced":
	    		return CSW.Enumerations.AnimateType_Type_CalcMode.Paced;
			default:
				// ##HAND_CODED_BLOCK_START ID="Default Enum CSW.Enumerations.AnimateType_Type_CalcMode"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
				throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for CSW.Enumerations.AnimateType_Type_CalcMode [" + enumValue + "]");
				// ##HAND_CODED_BLOCK_END ID="Default Enum CSW.Enumerations.AnimateType_Type_CalcMode"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
			}
		}
		
		public static StringCollection AnimateType_Type_CalcModeNames()
		{
			StringCollection ret = new StringCollection();
			System.Type t = typeof(AnimateType_Type_CalcMode);
			foreach (AnimateType_Type_CalcMode e in Enum.GetValues(t))
				ret.Add(AnimateType_Type_CalcModeToString(e));
			return ret;
		}
		
		#endregion
		#endregion

		#region Enumeration 'IanimateColorPrototype_AttributeType'
		#region Enumeration Declaration
		public enum IanimateColorPrototype_AttributeType
		{
        	XML,
        	CSS,
        	Auto
		}
		#endregion


		#region Conversion functions
		/// <summary>
		/// 	Converts a string to a IanimateColorPrototype_AttributeType enumeration
		/// </summary>
		public static String IanimateColorPrototype_AttributeTypeToString(CSW.Enumerations.IanimateColorPrototype_AttributeType enumValue)
		{
		    switch(enumValue)
		    {
		    case CSW.Enumerations.IanimateColorPrototype_AttributeType.XML:
	    		return "XML";
		    case CSW.Enumerations.IanimateColorPrototype_AttributeType.CSS:
	    		return "CSS";
		    case CSW.Enumerations.IanimateColorPrototype_AttributeType.Auto:
	    		return "auto";
			default:
	    		throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for CSW.Enumerations.IanimateColorPrototype_AttributeType [" + enumValue.ToString() + "]");
			}
		}
	
		/// <summary>
		/// 	Converts a IanimateColorPrototype_AttributeType enumeration to a string (suitable for the XML document)
		/// </summary>
		public static CSW.Enumerations.IanimateColorPrototype_AttributeType IanimateColorPrototype_AttributeTypeFromString(String enumValue)
		{
		    switch(LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Collapse(enumValue))
		    {
			case "XML":
	    		return CSW.Enumerations.IanimateColorPrototype_AttributeType.XML;
			case "CSS":
	    		return CSW.Enumerations.IanimateColorPrototype_AttributeType.CSS;
			case "auto":
	    		return CSW.Enumerations.IanimateColorPrototype_AttributeType.Auto;
			default:
				// ##HAND_CODED_BLOCK_START ID="Default Enum CSW.Enumerations.IanimateColorPrototype_AttributeType"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
				throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for CSW.Enumerations.IanimateColorPrototype_AttributeType [" + enumValue + "]");
				// ##HAND_CODED_BLOCK_END ID="Default Enum CSW.Enumerations.IanimateColorPrototype_AttributeType"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
			}
		}
		
		public static StringCollection IanimateColorPrototype_AttributeTypeNames()
		{
			StringCollection ret = new StringCollection();
			System.Type t = typeof(IanimateColorPrototype_AttributeType);
			foreach (IanimateColorPrototype_AttributeType e in Enum.GetValues(t))
				ret.Add(IanimateColorPrototype_AttributeTypeToString(e));
			return ret;
		}
		
		#endregion
		#endregion

		#region Enumeration 'IanimateColorPrototype_Additive'
		#region Enumeration Declaration
		public enum IanimateColorPrototype_Additive
		{
        	Replace,
        	Sum
		}
		#endregion


		#region Conversion functions
		/// <summary>
		/// 	Converts a string to a IanimateColorPrototype_Additive enumeration
		/// </summary>
		public static String IanimateColorPrototype_AdditiveToString(CSW.Enumerations.IanimateColorPrototype_Additive enumValue)
		{
		    switch(enumValue)
		    {
		    case CSW.Enumerations.IanimateColorPrototype_Additive.Replace:
	    		return "replace";
		    case CSW.Enumerations.IanimateColorPrototype_Additive.Sum:
	    		return "sum";
			default:
	    		throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for CSW.Enumerations.IanimateColorPrototype_Additive [" + enumValue.ToString() + "]");
			}
		}
	
		/// <summary>
		/// 	Converts a IanimateColorPrototype_Additive enumeration to a string (suitable for the XML document)
		/// </summary>
		public static CSW.Enumerations.IanimateColorPrototype_Additive IanimateColorPrototype_AdditiveFromString(String enumValue)
		{
		    switch(LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Collapse(enumValue))
		    {
			case "replace":
	    		return CSW.Enumerations.IanimateColorPrototype_Additive.Replace;
			case "sum":
	    		return CSW.Enumerations.IanimateColorPrototype_Additive.Sum;
			default:
				// ##HAND_CODED_BLOCK_START ID="Default Enum CSW.Enumerations.IanimateColorPrototype_Additive"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
				throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for CSW.Enumerations.IanimateColorPrototype_Additive [" + enumValue + "]");
				// ##HAND_CODED_BLOCK_END ID="Default Enum CSW.Enumerations.IanimateColorPrototype_Additive"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
			}
		}
		
		public static StringCollection IanimateColorPrototype_AdditiveNames()
		{
			StringCollection ret = new StringCollection();
			System.Type t = typeof(IanimateColorPrototype_Additive);
			foreach (IanimateColorPrototype_Additive e in Enum.GetValues(t))
				ret.Add(IanimateColorPrototype_AdditiveToString(e));
			return ret;
		}
		
		#endregion
		#endregion

		#region Enumeration 'IanimateColorPrototype_Accumulate'
		#region Enumeration Declaration
		public enum IanimateColorPrototype_Accumulate
		{
        	None,
        	Sum
		}
		#endregion


		#region Conversion functions
		/// <summary>
		/// 	Converts a string to a IanimateColorPrototype_Accumulate enumeration
		/// </summary>
		public static String IanimateColorPrototype_AccumulateToString(CSW.Enumerations.IanimateColorPrototype_Accumulate enumValue)
		{
		    switch(enumValue)
		    {
		    case CSW.Enumerations.IanimateColorPrototype_Accumulate.None:
	    		return "none";
		    case CSW.Enumerations.IanimateColorPrototype_Accumulate.Sum:
	    		return "sum";
			default:
	    		throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for CSW.Enumerations.IanimateColorPrototype_Accumulate [" + enumValue.ToString() + "]");
			}
		}
	
		/// <summary>
		/// 	Converts a IanimateColorPrototype_Accumulate enumeration to a string (suitable for the XML document)
		/// </summary>
		public static CSW.Enumerations.IanimateColorPrototype_Accumulate IanimateColorPrototype_AccumulateFromString(String enumValue)
		{
		    switch(LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Collapse(enumValue))
		    {
			case "none":
	    		return CSW.Enumerations.IanimateColorPrototype_Accumulate.None;
			case "sum":
	    		return CSW.Enumerations.IanimateColorPrototype_Accumulate.Sum;
			default:
				// ##HAND_CODED_BLOCK_START ID="Default Enum CSW.Enumerations.IanimateColorPrototype_Accumulate"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
				throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for CSW.Enumerations.IanimateColorPrototype_Accumulate [" + enumValue + "]");
				// ##HAND_CODED_BLOCK_END ID="Default Enum CSW.Enumerations.IanimateColorPrototype_Accumulate"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
			}
		}
		
		public static StringCollection IanimateColorPrototype_AccumulateNames()
		{
			StringCollection ret = new StringCollection();
			System.Type t = typeof(IanimateColorPrototype_Accumulate);
			foreach (IanimateColorPrototype_Accumulate e in Enum.GetValues(t))
				ret.Add(IanimateColorPrototype_AccumulateToString(e));
			return ret;
		}
		
		#endregion
		#endregion

		#region Enumeration 'IanimateMotionPrototype_Additive'
		#region Enumeration Declaration
		public enum IanimateMotionPrototype_Additive
		{
        	Replace,
        	Sum
		}
		#endregion


		#region Conversion functions
		/// <summary>
		/// 	Converts a string to a IanimateMotionPrototype_Additive enumeration
		/// </summary>
		public static String IanimateMotionPrototype_AdditiveToString(CSW.Enumerations.IanimateMotionPrototype_Additive enumValue)
		{
		    switch(enumValue)
		    {
		    case CSW.Enumerations.IanimateMotionPrototype_Additive.Replace:
	    		return "replace";
		    case CSW.Enumerations.IanimateMotionPrototype_Additive.Sum:
	    		return "sum";
			default:
	    		throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for CSW.Enumerations.IanimateMotionPrototype_Additive [" + enumValue.ToString() + "]");
			}
		}
	
		/// <summary>
		/// 	Converts a IanimateMotionPrototype_Additive enumeration to a string (suitable for the XML document)
		/// </summary>
		public static CSW.Enumerations.IanimateMotionPrototype_Additive IanimateMotionPrototype_AdditiveFromString(String enumValue)
		{
		    switch(LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Collapse(enumValue))
		    {
			case "replace":
	    		return CSW.Enumerations.IanimateMotionPrototype_Additive.Replace;
			case "sum":
	    		return CSW.Enumerations.IanimateMotionPrototype_Additive.Sum;
			default:
				// ##HAND_CODED_BLOCK_START ID="Default Enum CSW.Enumerations.IanimateMotionPrototype_Additive"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
				throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for CSW.Enumerations.IanimateMotionPrototype_Additive [" + enumValue + "]");
				// ##HAND_CODED_BLOCK_END ID="Default Enum CSW.Enumerations.IanimateMotionPrototype_Additive"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
			}
		}
		
		public static StringCollection IanimateMotionPrototype_AdditiveNames()
		{
			StringCollection ret = new StringCollection();
			System.Type t = typeof(IanimateMotionPrototype_Additive);
			foreach (IanimateMotionPrototype_Additive e in Enum.GetValues(t))
				ret.Add(IanimateMotionPrototype_AdditiveToString(e));
			return ret;
		}
		
		#endregion
		#endregion

		#region Enumeration 'IanimateMotionPrototype_Accumulate'
		#region Enumeration Declaration
		public enum IanimateMotionPrototype_Accumulate
		{
        	None,
        	Sum
		}
		#endregion


		#region Conversion functions
		/// <summary>
		/// 	Converts a string to a IanimateMotionPrototype_Accumulate enumeration
		/// </summary>
		public static String IanimateMotionPrototype_AccumulateToString(CSW.Enumerations.IanimateMotionPrototype_Accumulate enumValue)
		{
		    switch(enumValue)
		    {
		    case CSW.Enumerations.IanimateMotionPrototype_Accumulate.None:
	    		return "none";
		    case CSW.Enumerations.IanimateMotionPrototype_Accumulate.Sum:
	    		return "sum";
			default:
	    		throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for CSW.Enumerations.IanimateMotionPrototype_Accumulate [" + enumValue.ToString() + "]");
			}
		}
	
		/// <summary>
		/// 	Converts a IanimateMotionPrototype_Accumulate enumeration to a string (suitable for the XML document)
		/// </summary>
		public static CSW.Enumerations.IanimateMotionPrototype_Accumulate IanimateMotionPrototype_AccumulateFromString(String enumValue)
		{
		    switch(LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Collapse(enumValue))
		    {
			case "none":
	    		return CSW.Enumerations.IanimateMotionPrototype_Accumulate.None;
			case "sum":
	    		return CSW.Enumerations.IanimateMotionPrototype_Accumulate.Sum;
			default:
				// ##HAND_CODED_BLOCK_START ID="Default Enum CSW.Enumerations.IanimateMotionPrototype_Accumulate"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
				throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for CSW.Enumerations.IanimateMotionPrototype_Accumulate [" + enumValue + "]");
				// ##HAND_CODED_BLOCK_END ID="Default Enum CSW.Enumerations.IanimateMotionPrototype_Accumulate"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
			}
		}
		
		public static StringCollection IanimateMotionPrototype_AccumulateNames()
		{
			StringCollection ret = new StringCollection();
			System.Type t = typeof(IanimateMotionPrototype_Accumulate);
			foreach (IanimateMotionPrototype_Accumulate e in Enum.GetValues(t))
				ret.Add(IanimateMotionPrototype_AccumulateToString(e));
			return ret;
		}
		
		#endregion
		#endregion

		#region Enumeration 'IanimatePrototype_AttributeType'
		#region Enumeration Declaration
		public enum IanimatePrototype_AttributeType
		{
        	XML,
        	CSS,
        	Auto
		}
		#endregion


		#region Conversion functions
		/// <summary>
		/// 	Converts a string to a IanimatePrototype_AttributeType enumeration
		/// </summary>
		public static String IanimatePrototype_AttributeTypeToString(CSW.Enumerations.IanimatePrototype_AttributeType enumValue)
		{
		    switch(enumValue)
		    {
		    case CSW.Enumerations.IanimatePrototype_AttributeType.XML:
	    		return "XML";
		    case CSW.Enumerations.IanimatePrototype_AttributeType.CSS:
	    		return "CSS";
		    case CSW.Enumerations.IanimatePrototype_AttributeType.Auto:
	    		return "auto";
			default:
	    		throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for CSW.Enumerations.IanimatePrototype_AttributeType [" + enumValue.ToString() + "]");
			}
		}
	
		/// <summary>
		/// 	Converts a IanimatePrototype_AttributeType enumeration to a string (suitable for the XML document)
		/// </summary>
		public static CSW.Enumerations.IanimatePrototype_AttributeType IanimatePrototype_AttributeTypeFromString(String enumValue)
		{
		    switch(LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Collapse(enumValue))
		    {
			case "XML":
	    		return CSW.Enumerations.IanimatePrototype_AttributeType.XML;
			case "CSS":
	    		return CSW.Enumerations.IanimatePrototype_AttributeType.CSS;
			case "auto":
	    		return CSW.Enumerations.IanimatePrototype_AttributeType.Auto;
			default:
				// ##HAND_CODED_BLOCK_START ID="Default Enum CSW.Enumerations.IanimatePrototype_AttributeType"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
				throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for CSW.Enumerations.IanimatePrototype_AttributeType [" + enumValue + "]");
				// ##HAND_CODED_BLOCK_END ID="Default Enum CSW.Enumerations.IanimatePrototype_AttributeType"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
			}
		}
		
		public static StringCollection IanimatePrototype_AttributeTypeNames()
		{
			StringCollection ret = new StringCollection();
			System.Type t = typeof(IanimatePrototype_AttributeType);
			foreach (IanimatePrototype_AttributeType e in Enum.GetValues(t))
				ret.Add(IanimatePrototype_AttributeTypeToString(e));
			return ret;
		}
		
		#endregion
		#endregion

		#region Enumeration 'IanimatePrototype_Additive'
		#region Enumeration Declaration
		public enum IanimatePrototype_Additive
		{
        	Replace,
        	Sum
		}
		#endregion


		#region Conversion functions
		/// <summary>
		/// 	Converts a string to a IanimatePrototype_Additive enumeration
		/// </summary>
		public static String IanimatePrototype_AdditiveToString(CSW.Enumerations.IanimatePrototype_Additive enumValue)
		{
		    switch(enumValue)
		    {
		    case CSW.Enumerations.IanimatePrototype_Additive.Replace:
	    		return "replace";
		    case CSW.Enumerations.IanimatePrototype_Additive.Sum:
	    		return "sum";
			default:
	    		throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for CSW.Enumerations.IanimatePrototype_Additive [" + enumValue.ToString() + "]");
			}
		}
	
		/// <summary>
		/// 	Converts a IanimatePrototype_Additive enumeration to a string (suitable for the XML document)
		/// </summary>
		public static CSW.Enumerations.IanimatePrototype_Additive IanimatePrototype_AdditiveFromString(String enumValue)
		{
		    switch(LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Collapse(enumValue))
		    {
			case "replace":
	    		return CSW.Enumerations.IanimatePrototype_Additive.Replace;
			case "sum":
	    		return CSW.Enumerations.IanimatePrototype_Additive.Sum;
			default:
				// ##HAND_CODED_BLOCK_START ID="Default Enum CSW.Enumerations.IanimatePrototype_Additive"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
				throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for CSW.Enumerations.IanimatePrototype_Additive [" + enumValue + "]");
				// ##HAND_CODED_BLOCK_END ID="Default Enum CSW.Enumerations.IanimatePrototype_Additive"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
			}
		}
		
		public static StringCollection IanimatePrototype_AdditiveNames()
		{
			StringCollection ret = new StringCollection();
			System.Type t = typeof(IanimatePrototype_Additive);
			foreach (IanimatePrototype_Additive e in Enum.GetValues(t))
				ret.Add(IanimatePrototype_AdditiveToString(e));
			return ret;
		}
		
		#endregion
		#endregion

		#region Enumeration 'IanimatePrototype_Accumulate'
		#region Enumeration Declaration
		public enum IanimatePrototype_Accumulate
		{
        	None,
        	Sum
		}
		#endregion


		#region Conversion functions
		/// <summary>
		/// 	Converts a string to a IanimatePrototype_Accumulate enumeration
		/// </summary>
		public static String IanimatePrototype_AccumulateToString(CSW.Enumerations.IanimatePrototype_Accumulate enumValue)
		{
		    switch(enumValue)
		    {
		    case CSW.Enumerations.IanimatePrototype_Accumulate.None:
	    		return "none";
		    case CSW.Enumerations.IanimatePrototype_Accumulate.Sum:
	    		return "sum";
			default:
	    		throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for CSW.Enumerations.IanimatePrototype_Accumulate [" + enumValue.ToString() + "]");
			}
		}
	
		/// <summary>
		/// 	Converts a IanimatePrototype_Accumulate enumeration to a string (suitable for the XML document)
		/// </summary>
		public static CSW.Enumerations.IanimatePrototype_Accumulate IanimatePrototype_AccumulateFromString(String enumValue)
		{
		    switch(LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Collapse(enumValue))
		    {
			case "none":
	    		return CSW.Enumerations.IanimatePrototype_Accumulate.None;
			case "sum":
	    		return CSW.Enumerations.IanimatePrototype_Accumulate.Sum;
			default:
				// ##HAND_CODED_BLOCK_START ID="Default Enum CSW.Enumerations.IanimatePrototype_Accumulate"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
				throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for CSW.Enumerations.IanimatePrototype_Accumulate [" + enumValue + "]");
				// ##HAND_CODED_BLOCK_END ID="Default Enum CSW.Enumerations.IanimatePrototype_Accumulate"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
			}
		}
		
		public static StringCollection IanimatePrototype_AccumulateNames()
		{
			StringCollection ret = new StringCollection();
			System.Type t = typeof(IanimatePrototype_Accumulate);
			foreach (IanimatePrototype_Accumulate e in Enum.GetValues(t))
				ret.Add(IanimatePrototype_AccumulateToString(e));
			return ret;
		}
		
		#endregion
		#endregion

		#region Enumeration 'IsetPrototype_AttributeType'
		#region Enumeration Declaration
		public enum IsetPrototype_AttributeType
		{
        	XML,
        	CSS,
        	Auto
		}
		#endregion


		#region Conversion functions
		/// <summary>
		/// 	Converts a string to a IsetPrototype_AttributeType enumeration
		/// </summary>
		public static String IsetPrototype_AttributeTypeToString(CSW.Enumerations.IsetPrototype_AttributeType enumValue)
		{
		    switch(enumValue)
		    {
		    case CSW.Enumerations.IsetPrototype_AttributeType.XML:
	    		return "XML";
		    case CSW.Enumerations.IsetPrototype_AttributeType.CSS:
	    		return "CSS";
		    case CSW.Enumerations.IsetPrototype_AttributeType.Auto:
	    		return "auto";
			default:
	    		throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for CSW.Enumerations.IsetPrototype_AttributeType [" + enumValue.ToString() + "]");
			}
		}
	
		/// <summary>
		/// 	Converts a IsetPrototype_AttributeType enumeration to a string (suitable for the XML document)
		/// </summary>
		public static CSW.Enumerations.IsetPrototype_AttributeType IsetPrototype_AttributeTypeFromString(String enumValue)
		{
		    switch(LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Collapse(enumValue))
		    {
			case "XML":
	    		return CSW.Enumerations.IsetPrototype_AttributeType.XML;
			case "CSS":
	    		return CSW.Enumerations.IsetPrototype_AttributeType.CSS;
			case "auto":
	    		return CSW.Enumerations.IsetPrototype_AttributeType.Auto;
			default:
				// ##HAND_CODED_BLOCK_START ID="Default Enum CSW.Enumerations.IsetPrototype_AttributeType"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
				throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for CSW.Enumerations.IsetPrototype_AttributeType [" + enumValue + "]");
				// ##HAND_CODED_BLOCK_END ID="Default Enum CSW.Enumerations.IsetPrototype_AttributeType"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
			}
		}
		
		public static StringCollection IsetPrototype_AttributeTypeNames()
		{
			StringCollection ret = new StringCollection();
			System.Type t = typeof(IsetPrototype_AttributeType);
			foreach (IsetPrototype_AttributeType e in Enum.GetValues(t))
				ret.Add(IsetPrototype_AttributeTypeToString(e));
			return ret;
		}
		
		#endregion
		#endregion

		#region Enumeration 'RelatedTimeType_Type_RelativePosition'
		#region Enumeration Declaration
		public enum RelatedTimeType_Type_RelativePosition
		{
        	Before,
        	After,
        	Begins,
        	Ends,
        	During,
        	Equals,
        	Contains,
        	Overlaps,
        	Meets,
        	OverlappedBy,
        	MetBy,
        	BegunBy,
        	EndedBy
		}
		#endregion


		#region Conversion functions
		/// <summary>
		/// 	Converts a string to a RelatedTimeType_Type_RelativePosition enumeration
		/// </summary>
		public static String RelatedTimeType_Type_RelativePositionToString(CSW.Enumerations.RelatedTimeType_Type_RelativePosition enumValue)
		{
		    switch(enumValue)
		    {
		    case CSW.Enumerations.RelatedTimeType_Type_RelativePosition.Before:
	    		return "Before";
		    case CSW.Enumerations.RelatedTimeType_Type_RelativePosition.After:
	    		return "After";
		    case CSW.Enumerations.RelatedTimeType_Type_RelativePosition.Begins:
	    		return "Begins";
		    case CSW.Enumerations.RelatedTimeType_Type_RelativePosition.Ends:
	    		return "Ends";
		    case CSW.Enumerations.RelatedTimeType_Type_RelativePosition.During:
	    		return "During";
		    case CSW.Enumerations.RelatedTimeType_Type_RelativePosition.Equals:
	    		return "Equals";
		    case CSW.Enumerations.RelatedTimeType_Type_RelativePosition.Contains:
	    		return "Contains";
		    case CSW.Enumerations.RelatedTimeType_Type_RelativePosition.Overlaps:
	    		return "Overlaps";
		    case CSW.Enumerations.RelatedTimeType_Type_RelativePosition.Meets:
	    		return "Meets";
		    case CSW.Enumerations.RelatedTimeType_Type_RelativePosition.OverlappedBy:
	    		return "OverlappedBy";
		    case CSW.Enumerations.RelatedTimeType_Type_RelativePosition.MetBy:
	    		return "MetBy";
		    case CSW.Enumerations.RelatedTimeType_Type_RelativePosition.BegunBy:
	    		return "BegunBy";
		    case CSW.Enumerations.RelatedTimeType_Type_RelativePosition.EndedBy:
	    		return "EndedBy";
			default:
	    		throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for CSW.Enumerations.RelatedTimeType_Type_RelativePosition [" + enumValue.ToString() + "]");
			}
		}
	
		/// <summary>
		/// 	Converts a RelatedTimeType_Type_RelativePosition enumeration to a string (suitable for the XML document)
		/// </summary>
		public static CSW.Enumerations.RelatedTimeType_Type_RelativePosition RelatedTimeType_Type_RelativePositionFromString(String enumValue)
		{
		    switch(LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Collapse(enumValue))
		    {
			case "Before":
	    		return CSW.Enumerations.RelatedTimeType_Type_RelativePosition.Before;
			case "After":
	    		return CSW.Enumerations.RelatedTimeType_Type_RelativePosition.After;
			case "Begins":
	    		return CSW.Enumerations.RelatedTimeType_Type_RelativePosition.Begins;
			case "Ends":
	    		return CSW.Enumerations.RelatedTimeType_Type_RelativePosition.Ends;
			case "During":
	    		return CSW.Enumerations.RelatedTimeType_Type_RelativePosition.During;
			case "Equals":
	    		return CSW.Enumerations.RelatedTimeType_Type_RelativePosition.Equals;
			case "Contains":
	    		return CSW.Enumerations.RelatedTimeType_Type_RelativePosition.Contains;
			case "Overlaps":
	    		return CSW.Enumerations.RelatedTimeType_Type_RelativePosition.Overlaps;
			case "Meets":
	    		return CSW.Enumerations.RelatedTimeType_Type_RelativePosition.Meets;
			case "OverlappedBy":
	    		return CSW.Enumerations.RelatedTimeType_Type_RelativePosition.OverlappedBy;
			case "MetBy":
	    		return CSW.Enumerations.RelatedTimeType_Type_RelativePosition.MetBy;
			case "BegunBy":
	    		return CSW.Enumerations.RelatedTimeType_Type_RelativePosition.BegunBy;
			case "EndedBy":
	    		return CSW.Enumerations.RelatedTimeType_Type_RelativePosition.EndedBy;
			default:
				// ##HAND_CODED_BLOCK_START ID="Default Enum CSW.Enumerations.RelatedTimeType_Type_RelativePosition"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
				throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for CSW.Enumerations.RelatedTimeType_Type_RelativePosition [" + enumValue + "]");
				// ##HAND_CODED_BLOCK_END ID="Default Enum CSW.Enumerations.RelatedTimeType_Type_RelativePosition"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
			}
		}
		
		public static StringCollection RelatedTimeType_Type_RelativePositionNames()
		{
			StringCollection ret = new StringCollection();
			System.Type t = typeof(RelatedTimeType_Type_RelativePosition);
			foreach (RelatedTimeType_Type_RelativePosition e in Enum.GetValues(t))
				ret.Add(RelatedTimeType_Type_RelativePositionToString(e));
			return ret;
		}
		
		#endregion
		#endregion

// ##HAND_CODED_BLOCK_START ID="Additional Methods"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional Methods and members here...

// ##HAND_CODED_BLOCK_END ID="Additional Methods"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
	}
}
namespace csw 
{
	public class Enumerations
	{
		// All the enumerations used within the Schema

		#region Enumeration 'ResultType'
		#region Enumeration Declaration
		public enum ResultType
		{
        	Results,
        	Hits,
        	Validate
		}
		#endregion


		#region Conversion functions
		/// <summary>
		/// 	Converts a string to a ResultType enumeration
		/// </summary>
		public static String ResultTypeToString(csw.Enumerations.ResultType enumValue)
		{
		    switch(enumValue)
		    {
		    case csw.Enumerations.ResultType.Results:
	    		return "results";
		    case csw.Enumerations.ResultType.Hits:
	    		return "hits";
		    case csw.Enumerations.ResultType.Validate:
	    		return "validate";
			default:
	    		throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for csw.Enumerations.ResultType [" + enumValue.ToString() + "]");
			}
		}
	
		/// <summary>
		/// 	Converts a ResultType enumeration to a string (suitable for the XML document)
		/// </summary>
		public static csw.Enumerations.ResultType ResultTypeFromString(String enumValue)
		{
		    switch(LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Collapse(enumValue))
		    {
			case "results":
	    		return csw.Enumerations.ResultType.Results;
			case "hits":
	    		return csw.Enumerations.ResultType.Hits;
			case "validate":
	    		return csw.Enumerations.ResultType.Validate;
			default:
				// ##HAND_CODED_BLOCK_START ID="Default Enum csw.Enumerations.ResultType"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
				throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for csw.Enumerations.ResultType [" + enumValue + "]");
				// ##HAND_CODED_BLOCK_END ID="Default Enum csw.Enumerations.ResultType"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
			}
		}
		
		public static StringCollection ResultTypeNames()
		{
			StringCollection ret = new StringCollection();
			System.Type t = typeof(ResultType);
			foreach (ResultType e in Enum.GetValues(t))
				ret.Add(ResultTypeToString(e));
			return ret;
		}
		
		#endregion
		#endregion

		#region Enumeration 'ElementSetType'
		#region Enumeration Declaration
		public enum ElementSetType
		{
        	Brief,
        	Summary,
        	Full
		}
		#endregion


		#region Conversion functions
		/// <summary>
		/// 	Converts a string to a ElementSetType enumeration
		/// </summary>
		public static String ElementSetTypeToString(csw.Enumerations.ElementSetType enumValue)
		{
		    switch(enumValue)
		    {
		    case csw.Enumerations.ElementSetType.Brief:
	    		return "brief";
		    case csw.Enumerations.ElementSetType.Summary:
	    		return "summary";
		    case csw.Enumerations.ElementSetType.Full:
	    		return "full";
			default:
	    		throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for csw.Enumerations.ElementSetType [" + enumValue.ToString() + "]");
			}
		}
	
		/// <summary>
		/// 	Converts a ElementSetType enumeration to a string (suitable for the XML document)
		/// </summary>
		public static csw.Enumerations.ElementSetType ElementSetTypeFromString(String enumValue)
		{
		    switch(LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Collapse(enumValue))
		    {
			case "brief":
	    		return csw.Enumerations.ElementSetType.Brief;
			case "summary":
	    		return csw.Enumerations.ElementSetType.Summary;
			case "full":
	    		return csw.Enumerations.ElementSetType.Full;
			default:
				// ##HAND_CODED_BLOCK_START ID="Default Enum csw.Enumerations.ElementSetType"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
				throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for csw.Enumerations.ElementSetType [" + enumValue + "]");
				// ##HAND_CODED_BLOCK_END ID="Default Enum csw.Enumerations.ElementSetType"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
			}
		}
		
		public static StringCollection ElementSetTypeNames()
		{
			StringCollection ret = new StringCollection();
			System.Type t = typeof(ElementSetType);
			foreach (ElementSetType e in Enum.GetValues(t))
				ret.Add(ElementSetTypeToString(e));
			return ret;
		}
		
		#endregion
		#endregion

		#region Enumeration 'ElementSetNameType'
		#region Enumeration Declaration
		public enum ElementSetNameType
		{
        	Brief,
        	Summary,
        	Full
		}
		#endregion


		#region Conversion functions
		/// <summary>
		/// 	Converts a string to a ElementSetNameType enumeration
		/// </summary>
		public static String ElementSetNameTypeToString(csw.Enumerations.ElementSetNameType enumValue)
		{
		    switch(enumValue)
		    {
		    case csw.Enumerations.ElementSetNameType.Brief:
	    		return "brief";
		    case csw.Enumerations.ElementSetNameType.Summary:
	    		return "summary";
		    case csw.Enumerations.ElementSetNameType.Full:
	    		return "full";
			default:
	    		throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for csw.Enumerations.ElementSetNameType [" + enumValue.ToString() + "]");
			}
		}
	
		/// <summary>
		/// 	Converts a ElementSetNameType enumeration to a string (suitable for the XML document)
		/// </summary>
		public static csw.Enumerations.ElementSetNameType ElementSetNameTypeFromString(String enumValue)
		{
		    switch(LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Collapse(enumValue))
		    {
			case "brief":
	    		return csw.Enumerations.ElementSetNameType.Brief;
			case "summary":
	    		return csw.Enumerations.ElementSetNameType.Summary;
			case "full":
	    		return csw.Enumerations.ElementSetNameType.Full;
			default:
				// ##HAND_CODED_BLOCK_START ID="Default Enum csw.Enumerations.ElementSetNameType"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
				throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for csw.Enumerations.ElementSetNameType [" + enumValue + "]");
				// ##HAND_CODED_BLOCK_END ID="Default Enum csw.Enumerations.ElementSetNameType"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
			}
		}
		
		public static StringCollection ElementSetNameTypeNames()
		{
			StringCollection ret = new StringCollection();
			System.Type t = typeof(ElementSetNameType);
			foreach (ElementSetNameType e in Enum.GetValues(t))
				ret.Add(ElementSetNameTypeToString(e));
			return ret;
		}
		
		#endregion
		#endregion

// ##HAND_CODED_BLOCK_START ID="Additional Methods"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional Methods and members here...

// ##HAND_CODED_BLOCK_END ID="Additional Methods"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
	}
}
namespace ogc 
{
	public class Enumerations
	{
		// All the enumerations used within the Schema

		#region Enumeration 'ComparisonOperatorType'
		#region Enumeration Declaration
		public enum ComparisonOperatorType
		{
        	LessThan,
        	GreaterThan,
        	LessThanEqualTo,
        	GreaterThanEqualTo,
        	EqualTo,
        	NotEqualTo,
        	Like,
        	Between,
        	NullCheck
		}
		#endregion


		#region Conversion functions
		/// <summary>
		/// 	Converts a string to a ComparisonOperatorType enumeration
		/// </summary>
		public static String ComparisonOperatorTypeToString(ogc.Enumerations.ComparisonOperatorType enumValue)
		{
		    switch(enumValue)
		    {
		    case ogc.Enumerations.ComparisonOperatorType.LessThan:
	    		return "LessThan";
		    case ogc.Enumerations.ComparisonOperatorType.GreaterThan:
	    		return "GreaterThan";
		    case ogc.Enumerations.ComparisonOperatorType.LessThanEqualTo:
	    		return "LessThanEqualTo";
		    case ogc.Enumerations.ComparisonOperatorType.GreaterThanEqualTo:
	    		return "GreaterThanEqualTo";
		    case ogc.Enumerations.ComparisonOperatorType.EqualTo:
	    		return "EqualTo";
		    case ogc.Enumerations.ComparisonOperatorType.NotEqualTo:
	    		return "NotEqualTo";
		    case ogc.Enumerations.ComparisonOperatorType.Like:
	    		return "Like";
		    case ogc.Enumerations.ComparisonOperatorType.Between:
	    		return "Between";
		    case ogc.Enumerations.ComparisonOperatorType.NullCheck:
	    		return "NullCheck";
			default:
	    		throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for ogc.Enumerations.ComparisonOperatorType [" + enumValue.ToString() + "]");
			}
		}
	
		/// <summary>
		/// 	Converts a ComparisonOperatorType enumeration to a string (suitable for the XML document)
		/// </summary>
		public static ogc.Enumerations.ComparisonOperatorType ComparisonOperatorTypeFromString(String enumValue)
		{
		    switch(LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Collapse(enumValue))
		    {
			case "LessThan":
	    		return ogc.Enumerations.ComparisonOperatorType.LessThan;
			case "GreaterThan":
	    		return ogc.Enumerations.ComparisonOperatorType.GreaterThan;
			case "LessThanEqualTo":
	    		return ogc.Enumerations.ComparisonOperatorType.LessThanEqualTo;
			case "GreaterThanEqualTo":
	    		return ogc.Enumerations.ComparisonOperatorType.GreaterThanEqualTo;
			case "EqualTo":
	    		return ogc.Enumerations.ComparisonOperatorType.EqualTo;
			case "NotEqualTo":
	    		return ogc.Enumerations.ComparisonOperatorType.NotEqualTo;
			case "Like":
	    		return ogc.Enumerations.ComparisonOperatorType.Like;
			case "Between":
	    		return ogc.Enumerations.ComparisonOperatorType.Between;
			case "NullCheck":
	    		return ogc.Enumerations.ComparisonOperatorType.NullCheck;
			default:
				// ##HAND_CODED_BLOCK_START ID="Default Enum ogc.Enumerations.ComparisonOperatorType"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
				throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for ogc.Enumerations.ComparisonOperatorType [" + enumValue + "]");
				// ##HAND_CODED_BLOCK_END ID="Default Enum ogc.Enumerations.ComparisonOperatorType"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
			}
		}
		
		public static StringCollection ComparisonOperatorTypeNames()
		{
			StringCollection ret = new StringCollection();
			System.Type t = typeof(ComparisonOperatorType);
			foreach (ComparisonOperatorType e in Enum.GetValues(t))
				ret.Add(ComparisonOperatorTypeToString(e));
			return ret;
		}
		
		#endregion
		#endregion

		#region Enumeration 'SortOrderType'
		#region Enumeration Declaration
		public enum SortOrderType
		{
        	DESC,
        	ASC
		}
		#endregion


		#region Conversion functions
		/// <summary>
		/// 	Converts a string to a SortOrderType enumeration
		/// </summary>
		public static String SortOrderTypeToString(ogc.Enumerations.SortOrderType enumValue)
		{
		    switch(enumValue)
		    {
		    case ogc.Enumerations.SortOrderType.DESC:
	    		return "DESC";
		    case ogc.Enumerations.SortOrderType.ASC:
	    		return "ASC";
			default:
	    		throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for ogc.Enumerations.SortOrderType [" + enumValue.ToString() + "]");
			}
		}
	
		/// <summary>
		/// 	Converts a SortOrderType enumeration to a string (suitable for the XML document)
		/// </summary>
		public static ogc.Enumerations.SortOrderType SortOrderTypeFromString(String enumValue)
		{
		    switch(LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Collapse(enumValue))
		    {
			case "DESC":
	    		return ogc.Enumerations.SortOrderType.DESC;
			case "ASC":
	    		return ogc.Enumerations.SortOrderType.ASC;
			default:
				// ##HAND_CODED_BLOCK_START ID="Default Enum ogc.Enumerations.SortOrderType"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
				throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for ogc.Enumerations.SortOrderType [" + enumValue + "]");
				// ##HAND_CODED_BLOCK_END ID="Default Enum ogc.Enumerations.SortOrderType"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
			}
		}
		
		public static StringCollection SortOrderTypeNames()
		{
			StringCollection ret = new StringCollection();
			System.Type t = typeof(SortOrderType);
			foreach (SortOrderType e in Enum.GetValues(t))
				ret.Add(SortOrderTypeToString(e));
			return ret;
		}
		
		#endregion
		#endregion

		#region Enumeration 'GeometryOperandType'
		#region Enumeration Declaration
		public enum GeometryOperandType
		{
        	LBracehttpColonSlashSlashwwwFullStopopengisFullStopnetSlashgmlRBraceEnvelope,
        	LBracehttpColonSlashSlashwwwFullStopopengisFullStopnetSlashgmlRBracePoint,
        	LBracehttpColonSlashSlashwwwFullStopopengisFullStopnetSlashgmlRBraceLineString,
        	LBracehttpColonSlashSlashwwwFullStopopengisFullStopnetSlashgmlRBracePolygon,
        	LBracehttpColonSlashSlashwwwFullStopopengisFullStopnetSlashgmlRBraceArcByCenterPoint,
        	LBracehttpColonSlashSlashwwwFullStopopengisFullStopnetSlashgmlRBraceCircleByCenterPoint,
        	LBracehttpColonSlashSlashwwwFullStopopengisFullStopnetSlashgmlRBraceArc,
        	LBracehttpColonSlashSlashwwwFullStopopengisFullStopnetSlashgmlRBraceCircle,
        	LBracehttpColonSlashSlashwwwFullStopopengisFullStopnetSlashgmlRBraceArcByBulge,
        	LBracehttpColonSlashSlashwwwFullStopopengisFullStopnetSlashgmlRBraceBezier,
        	LBracehttpColonSlashSlashwwwFullStopopengisFullStopnetSlashgmlRBraceClothoid,
        	LBracehttpColonSlashSlashwwwFullStopopengisFullStopnetSlashgmlRBraceCubicSpline,
        	LBracehttpColonSlashSlashwwwFullStopopengisFullStopnetSlashgmlRBraceGeodesic,
        	LBracehttpColonSlashSlashwwwFullStopopengisFullStopnetSlashgmlRBraceOffsetCurve,
        	LBracehttpColonSlashSlashwwwFullStopopengisFullStopnetSlashgmlRBraceTriangle,
        	LBracehttpColonSlashSlashwwwFullStopopengisFullStopnetSlashgmlRBracePolyhedralSurface,
        	LBracehttpColonSlashSlashwwwFullStopopengisFullStopnetSlashgmlRBraceTriangulatedSurface,
        	LBracehttpColonSlashSlashwwwFullStopopengisFullStopnetSlashgmlRBraceTin,
        	LBracehttpColonSlashSlashwwwFullStopopengisFullStopnetSlashgmlRBraceSolid
		}
		#endregion


		#region Conversion functions
		/// <summary>
		/// 	Converts a string to a GeometryOperandType enumeration
		/// </summary>
		public static String GeometryOperandTypeToString(ogc.Enumerations.GeometryOperandType enumValue)
		{
		    switch(enumValue)
		    {
		    case ogc.Enumerations.GeometryOperandType.LBracehttpColonSlashSlashwwwFullStopopengisFullStopnetSlashgmlRBraceEnvelope:
	    		return "{http://www.opengis.net/gml}Envelope";
		    case ogc.Enumerations.GeometryOperandType.LBracehttpColonSlashSlashwwwFullStopopengisFullStopnetSlashgmlRBracePoint:
	    		return "{http://www.opengis.net/gml}Point";
		    case ogc.Enumerations.GeometryOperandType.LBracehttpColonSlashSlashwwwFullStopopengisFullStopnetSlashgmlRBraceLineString:
	    		return "{http://www.opengis.net/gml}LineString";
		    case ogc.Enumerations.GeometryOperandType.LBracehttpColonSlashSlashwwwFullStopopengisFullStopnetSlashgmlRBracePolygon:
	    		return "{http://www.opengis.net/gml}Polygon";
		    case ogc.Enumerations.GeometryOperandType.LBracehttpColonSlashSlashwwwFullStopopengisFullStopnetSlashgmlRBraceArcByCenterPoint:
	    		return "{http://www.opengis.net/gml}ArcByCenterPoint";
		    case ogc.Enumerations.GeometryOperandType.LBracehttpColonSlashSlashwwwFullStopopengisFullStopnetSlashgmlRBraceCircleByCenterPoint:
	    		return "{http://www.opengis.net/gml}CircleByCenterPoint";
		    case ogc.Enumerations.GeometryOperandType.LBracehttpColonSlashSlashwwwFullStopopengisFullStopnetSlashgmlRBraceArc:
	    		return "{http://www.opengis.net/gml}Arc";
		    case ogc.Enumerations.GeometryOperandType.LBracehttpColonSlashSlashwwwFullStopopengisFullStopnetSlashgmlRBraceCircle:
	    		return "{http://www.opengis.net/gml}Circle";
		    case ogc.Enumerations.GeometryOperandType.LBracehttpColonSlashSlashwwwFullStopopengisFullStopnetSlashgmlRBraceArcByBulge:
	    		return "{http://www.opengis.net/gml}ArcByBulge";
		    case ogc.Enumerations.GeometryOperandType.LBracehttpColonSlashSlashwwwFullStopopengisFullStopnetSlashgmlRBraceBezier:
	    		return "{http://www.opengis.net/gml}Bezier";
		    case ogc.Enumerations.GeometryOperandType.LBracehttpColonSlashSlashwwwFullStopopengisFullStopnetSlashgmlRBraceClothoid:
	    		return "{http://www.opengis.net/gml}Clothoid";
		    case ogc.Enumerations.GeometryOperandType.LBracehttpColonSlashSlashwwwFullStopopengisFullStopnetSlashgmlRBraceCubicSpline:
	    		return "{http://www.opengis.net/gml}CubicSpline";
		    case ogc.Enumerations.GeometryOperandType.LBracehttpColonSlashSlashwwwFullStopopengisFullStopnetSlashgmlRBraceGeodesic:
	    		return "{http://www.opengis.net/gml}Geodesic";
		    case ogc.Enumerations.GeometryOperandType.LBracehttpColonSlashSlashwwwFullStopopengisFullStopnetSlashgmlRBraceOffsetCurve:
	    		return "{http://www.opengis.net/gml}OffsetCurve";
		    case ogc.Enumerations.GeometryOperandType.LBracehttpColonSlashSlashwwwFullStopopengisFullStopnetSlashgmlRBraceTriangle:
	    		return "{http://www.opengis.net/gml}Triangle";
		    case ogc.Enumerations.GeometryOperandType.LBracehttpColonSlashSlashwwwFullStopopengisFullStopnetSlashgmlRBracePolyhedralSurface:
	    		return "{http://www.opengis.net/gml}PolyhedralSurface";
		    case ogc.Enumerations.GeometryOperandType.LBracehttpColonSlashSlashwwwFullStopopengisFullStopnetSlashgmlRBraceTriangulatedSurface:
	    		return "{http://www.opengis.net/gml}TriangulatedSurface";
		    case ogc.Enumerations.GeometryOperandType.LBracehttpColonSlashSlashwwwFullStopopengisFullStopnetSlashgmlRBraceTin:
	    		return "{http://www.opengis.net/gml}Tin";
		    case ogc.Enumerations.GeometryOperandType.LBracehttpColonSlashSlashwwwFullStopopengisFullStopnetSlashgmlRBraceSolid:
	    		return "{http://www.opengis.net/gml}Solid";
			default:
	    		throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for ogc.Enumerations.GeometryOperandType [" + enumValue.ToString() + "]");
			}
		}
	
		/// <summary>
		/// 	Converts a GeometryOperandType enumeration to a string (suitable for the XML document)
		/// </summary>
		public static ogc.Enumerations.GeometryOperandType GeometryOperandTypeFromString(String enumValue)
		{
		    switch(LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Collapse(enumValue))
		    {
			case "{http://www.opengis.net/gml}Envelope":
	    		return ogc.Enumerations.GeometryOperandType.LBracehttpColonSlashSlashwwwFullStopopengisFullStopnetSlashgmlRBraceEnvelope;
			case "{http://www.opengis.net/gml}Point":
	    		return ogc.Enumerations.GeometryOperandType.LBracehttpColonSlashSlashwwwFullStopopengisFullStopnetSlashgmlRBracePoint;
			case "{http://www.opengis.net/gml}LineString":
	    		return ogc.Enumerations.GeometryOperandType.LBracehttpColonSlashSlashwwwFullStopopengisFullStopnetSlashgmlRBraceLineString;
			case "{http://www.opengis.net/gml}Polygon":
	    		return ogc.Enumerations.GeometryOperandType.LBracehttpColonSlashSlashwwwFullStopopengisFullStopnetSlashgmlRBracePolygon;
			case "{http://www.opengis.net/gml}ArcByCenterPoint":
	    		return ogc.Enumerations.GeometryOperandType.LBracehttpColonSlashSlashwwwFullStopopengisFullStopnetSlashgmlRBraceArcByCenterPoint;
			case "{http://www.opengis.net/gml}CircleByCenterPoint":
	    		return ogc.Enumerations.GeometryOperandType.LBracehttpColonSlashSlashwwwFullStopopengisFullStopnetSlashgmlRBraceCircleByCenterPoint;
			case "{http://www.opengis.net/gml}Arc":
	    		return ogc.Enumerations.GeometryOperandType.LBracehttpColonSlashSlashwwwFullStopopengisFullStopnetSlashgmlRBraceArc;
			case "{http://www.opengis.net/gml}Circle":
	    		return ogc.Enumerations.GeometryOperandType.LBracehttpColonSlashSlashwwwFullStopopengisFullStopnetSlashgmlRBraceCircle;
			case "{http://www.opengis.net/gml}ArcByBulge":
	    		return ogc.Enumerations.GeometryOperandType.LBracehttpColonSlashSlashwwwFullStopopengisFullStopnetSlashgmlRBraceArcByBulge;
			case "{http://www.opengis.net/gml}Bezier":
	    		return ogc.Enumerations.GeometryOperandType.LBracehttpColonSlashSlashwwwFullStopopengisFullStopnetSlashgmlRBraceBezier;
			case "{http://www.opengis.net/gml}Clothoid":
	    		return ogc.Enumerations.GeometryOperandType.LBracehttpColonSlashSlashwwwFullStopopengisFullStopnetSlashgmlRBraceClothoid;
			case "{http://www.opengis.net/gml}CubicSpline":
	    		return ogc.Enumerations.GeometryOperandType.LBracehttpColonSlashSlashwwwFullStopopengisFullStopnetSlashgmlRBraceCubicSpline;
			case "{http://www.opengis.net/gml}Geodesic":
	    		return ogc.Enumerations.GeometryOperandType.LBracehttpColonSlashSlashwwwFullStopopengisFullStopnetSlashgmlRBraceGeodesic;
			case "{http://www.opengis.net/gml}OffsetCurve":
	    		return ogc.Enumerations.GeometryOperandType.LBracehttpColonSlashSlashwwwFullStopopengisFullStopnetSlashgmlRBraceOffsetCurve;
			case "{http://www.opengis.net/gml}Triangle":
	    		return ogc.Enumerations.GeometryOperandType.LBracehttpColonSlashSlashwwwFullStopopengisFullStopnetSlashgmlRBraceTriangle;
			case "{http://www.opengis.net/gml}PolyhedralSurface":
	    		return ogc.Enumerations.GeometryOperandType.LBracehttpColonSlashSlashwwwFullStopopengisFullStopnetSlashgmlRBracePolyhedralSurface;
			case "{http://www.opengis.net/gml}TriangulatedSurface":
	    		return ogc.Enumerations.GeometryOperandType.LBracehttpColonSlashSlashwwwFullStopopengisFullStopnetSlashgmlRBraceTriangulatedSurface;
			case "{http://www.opengis.net/gml}Tin":
	    		return ogc.Enumerations.GeometryOperandType.LBracehttpColonSlashSlashwwwFullStopopengisFullStopnetSlashgmlRBraceTin;
			case "{http://www.opengis.net/gml}Solid":
	    		return ogc.Enumerations.GeometryOperandType.LBracehttpColonSlashSlashwwwFullStopopengisFullStopnetSlashgmlRBraceSolid;
			default:
				// ##HAND_CODED_BLOCK_START ID="Default Enum ogc.Enumerations.GeometryOperandType"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
				throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for ogc.Enumerations.GeometryOperandType [" + enumValue + "]");
				// ##HAND_CODED_BLOCK_END ID="Default Enum ogc.Enumerations.GeometryOperandType"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
			}
		}
		
		public static StringCollection GeometryOperandTypeNames()
		{
			StringCollection ret = new StringCollection();
			System.Type t = typeof(GeometryOperandType);
			foreach (GeometryOperandType e in Enum.GetValues(t))
				ret.Add(GeometryOperandTypeToString(e));
			return ret;
		}
		
		#endregion
		#endregion

		#region Enumeration 'SpatialOperatorNameType'
		#region Enumeration Declaration
		public enum SpatialOperatorNameType
		{
        	BBOX,
        	Equals,
        	Disjoint,
        	Intersects,
        	Touches,
        	Crosses,
        	Within,
        	Contains,
        	Overlaps,
        	Beyond,
        	DWithin
		}
		#endregion


		#region Conversion functions
		/// <summary>
		/// 	Converts a string to a SpatialOperatorNameType enumeration
		/// </summary>
		public static String SpatialOperatorNameTypeToString(ogc.Enumerations.SpatialOperatorNameType enumValue)
		{
		    switch(enumValue)
		    {
		    case ogc.Enumerations.SpatialOperatorNameType.BBOX:
	    		return "BBOX";
		    case ogc.Enumerations.SpatialOperatorNameType.Equals:
	    		return "Equals";
		    case ogc.Enumerations.SpatialOperatorNameType.Disjoint:
	    		return "Disjoint";
		    case ogc.Enumerations.SpatialOperatorNameType.Intersects:
	    		return "Intersects";
		    case ogc.Enumerations.SpatialOperatorNameType.Touches:
	    		return "Touches";
		    case ogc.Enumerations.SpatialOperatorNameType.Crosses:
	    		return "Crosses";
		    case ogc.Enumerations.SpatialOperatorNameType.Within:
	    		return "Within";
		    case ogc.Enumerations.SpatialOperatorNameType.Contains:
	    		return "Contains";
		    case ogc.Enumerations.SpatialOperatorNameType.Overlaps:
	    		return "Overlaps";
		    case ogc.Enumerations.SpatialOperatorNameType.Beyond:
	    		return "Beyond";
		    case ogc.Enumerations.SpatialOperatorNameType.DWithin:
	    		return "DWithin";
			default:
	    		throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for ogc.Enumerations.SpatialOperatorNameType [" + enumValue.ToString() + "]");
			}
		}
	
		/// <summary>
		/// 	Converts a SpatialOperatorNameType enumeration to a string (suitable for the XML document)
		/// </summary>
		public static ogc.Enumerations.SpatialOperatorNameType SpatialOperatorNameTypeFromString(String enumValue)
		{
		    switch(LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Collapse(enumValue))
		    {
			case "BBOX":
	    		return ogc.Enumerations.SpatialOperatorNameType.BBOX;
			case "Equals":
	    		return ogc.Enumerations.SpatialOperatorNameType.Equals;
			case "Disjoint":
	    		return ogc.Enumerations.SpatialOperatorNameType.Disjoint;
			case "Intersects":
	    		return ogc.Enumerations.SpatialOperatorNameType.Intersects;
			case "Touches":
	    		return ogc.Enumerations.SpatialOperatorNameType.Touches;
			case "Crosses":
	    		return ogc.Enumerations.SpatialOperatorNameType.Crosses;
			case "Within":
	    		return ogc.Enumerations.SpatialOperatorNameType.Within;
			case "Contains":
	    		return ogc.Enumerations.SpatialOperatorNameType.Contains;
			case "Overlaps":
	    		return ogc.Enumerations.SpatialOperatorNameType.Overlaps;
			case "Beyond":
	    		return ogc.Enumerations.SpatialOperatorNameType.Beyond;
			case "DWithin":
	    		return ogc.Enumerations.SpatialOperatorNameType.DWithin;
			default:
				// ##HAND_CODED_BLOCK_START ID="Default Enum ogc.Enumerations.SpatialOperatorNameType"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
				throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for ogc.Enumerations.SpatialOperatorNameType [" + enumValue + "]");
				// ##HAND_CODED_BLOCK_END ID="Default Enum ogc.Enumerations.SpatialOperatorNameType"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
			}
		}
		
		public static StringCollection SpatialOperatorNameTypeNames()
		{
			StringCollection ret = new StringCollection();
			System.Type t = typeof(SpatialOperatorNameType);
			foreach (SpatialOperatorNameType e in Enum.GetValues(t))
				ret.Add(SpatialOperatorNameTypeToString(e));
			return ret;
		}
		
		#endregion
		#endregion

// ##HAND_CODED_BLOCK_START ID="Additional Methods"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional Methods and members here...

// ##HAND_CODED_BLOCK_END ID="Additional Methods"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
	}
}
namespace ows 
{
	public class Enumerations
	{
		// All the enumerations used within the Schema

// ##HAND_CODED_BLOCK_START ID="Additional Methods"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional Methods and members here...

// ##HAND_CODED_BLOCK_END ID="Additional Methods"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
	}
}
namespace AA 
{
	public class Enumerations
	{
		// All the enumerations used within the Schema

// ##HAND_CODED_BLOCK_START ID="Additional Methods"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional Methods and members here...

// ##HAND_CODED_BLOCK_END ID="Additional Methods"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
	}
}
namespace AB 
{
	public class Enumerations
	{
		// All the enumerations used within the Schema

// ##HAND_CODED_BLOCK_START ID="Additional Methods"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional Methods and members here...

// ##HAND_CODED_BLOCK_END ID="Additional Methods"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
	}
}
namespace AC 
{
	public class Enumerations
	{
		// All the enumerations used within the Schema

		#region Enumeration 'TypeType'
		#region Enumeration Declaration
		public enum TypeType
		{
        	Simple,
        	Extended,
        	Title,
        	Resource,
        	Locator,
        	Arc
		}
		#endregion


		#region Conversion functions
		/// <summary>
		/// 	Converts a string to a TypeType enumeration
		/// </summary>
		public static String TypeTypeToString(AC.Enumerations.TypeType enumValue)
		{
		    switch(enumValue)
		    {
		    case AC.Enumerations.TypeType.Simple:
	    		return "simple";
		    case AC.Enumerations.TypeType.Extended:
	    		return "extended";
		    case AC.Enumerations.TypeType.Title:
	    		return "title";
		    case AC.Enumerations.TypeType.Resource:
	    		return "resource";
		    case AC.Enumerations.TypeType.Locator:
	    		return "locator";
		    case AC.Enumerations.TypeType.Arc:
	    		return "arc";
			default:
	    		throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for AC.Enumerations.TypeType [" + enumValue.ToString() + "]");
			}
		}
	
		/// <summary>
		/// 	Converts a TypeType enumeration to a string (suitable for the XML document)
		/// </summary>
		public static AC.Enumerations.TypeType TypeTypeFromString(String enumValue)
		{
		    switch(LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Collapse(enumValue))
		    {
			case "simple":
	    		return AC.Enumerations.TypeType.Simple;
			case "extended":
	    		return AC.Enumerations.TypeType.Extended;
			case "title":
	    		return AC.Enumerations.TypeType.Title;
			case "resource":
	    		return AC.Enumerations.TypeType.Resource;
			case "locator":
	    		return AC.Enumerations.TypeType.Locator;
			case "arc":
	    		return AC.Enumerations.TypeType.Arc;
			default:
				// ##HAND_CODED_BLOCK_START ID="Default Enum AC.Enumerations.TypeType"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
				throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for AC.Enumerations.TypeType [" + enumValue + "]");
				// ##HAND_CODED_BLOCK_END ID="Default Enum AC.Enumerations.TypeType"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
			}
		}
		
		public static StringCollection TypeTypeNames()
		{
			StringCollection ret = new StringCollection();
			System.Type t = typeof(TypeType);
			foreach (TypeType e in Enum.GetValues(t))
				ret.Add(TypeTypeToString(e));
			return ret;
		}
		
		#endregion
		#endregion

		#region Enumeration 'ShowType'
		#region Enumeration Declaration
		public enum ShowType
		{
        	new_,
        	Replace,
        	Embed,
        	Other,
        	None
		}
		#endregion


		#region Conversion functions
		/// <summary>
		/// 	Converts a string to a ShowType enumeration
		/// </summary>
		public static String ShowTypeToString(AC.Enumerations.ShowType enumValue)
		{
		    switch(enumValue)
		    {
		    case AC.Enumerations.ShowType.new_:
	    		return "new";
		    case AC.Enumerations.ShowType.Replace:
	    		return "replace";
		    case AC.Enumerations.ShowType.Embed:
	    		return "embed";
		    case AC.Enumerations.ShowType.Other:
	    		return "other";
		    case AC.Enumerations.ShowType.None:
	    		return "none";
			default:
	    		throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for AC.Enumerations.ShowType [" + enumValue.ToString() + "]");
			}
		}
	
		/// <summary>
		/// 	Converts a ShowType enumeration to a string (suitable for the XML document)
		/// </summary>
		public static AC.Enumerations.ShowType ShowTypeFromString(String enumValue)
		{
		    switch(LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Collapse(enumValue))
		    {
			case "new":
	    		return AC.Enumerations.ShowType.new_;
			case "replace":
	    		return AC.Enumerations.ShowType.Replace;
			case "embed":
	    		return AC.Enumerations.ShowType.Embed;
			case "other":
	    		return AC.Enumerations.ShowType.Other;
			case "none":
	    		return AC.Enumerations.ShowType.None;
			default:
				// ##HAND_CODED_BLOCK_START ID="Default Enum AC.Enumerations.ShowType"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
				throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for AC.Enumerations.ShowType [" + enumValue + "]");
				// ##HAND_CODED_BLOCK_END ID="Default Enum AC.Enumerations.ShowType"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
			}
		}
		
		public static StringCollection ShowTypeNames()
		{
			StringCollection ret = new StringCollection();
			System.Type t = typeof(ShowType);
			foreach (ShowType e in Enum.GetValues(t))
				ret.Add(ShowTypeToString(e));
			return ret;
		}
		
		#endregion
		#endregion

		#region Enumeration 'ActuateType'
		#region Enumeration Declaration
		public enum ActuateType
		{
        	OnLoad,
        	OnRequest,
        	Other,
        	None
		}
		#endregion


		#region Conversion functions
		/// <summary>
		/// 	Converts a string to a ActuateType enumeration
		/// </summary>
		public static String ActuateTypeToString(AC.Enumerations.ActuateType enumValue)
		{
		    switch(enumValue)
		    {
		    case AC.Enumerations.ActuateType.OnLoad:
	    		return "onLoad";
		    case AC.Enumerations.ActuateType.OnRequest:
	    		return "onRequest";
		    case AC.Enumerations.ActuateType.Other:
	    		return "other";
		    case AC.Enumerations.ActuateType.None:
	    		return "none";
			default:
	    		throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for AC.Enumerations.ActuateType [" + enumValue.ToString() + "]");
			}
		}
	
		/// <summary>
		/// 	Converts a ActuateType enumeration to a string (suitable for the XML document)
		/// </summary>
		public static AC.Enumerations.ActuateType ActuateTypeFromString(String enumValue)
		{
		    switch(LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Collapse(enumValue))
		    {
			case "onLoad":
	    		return AC.Enumerations.ActuateType.OnLoad;
			case "onRequest":
	    		return AC.Enumerations.ActuateType.OnRequest;
			case "other":
	    		return AC.Enumerations.ActuateType.Other;
			case "none":
	    		return AC.Enumerations.ActuateType.None;
			default:
				// ##HAND_CODED_BLOCK_START ID="Default Enum AC.Enumerations.ActuateType"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
				throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for AC.Enumerations.ActuateType [" + enumValue + "]");
				// ##HAND_CODED_BLOCK_END ID="Default Enum AC.Enumerations.ActuateType"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
			}
		}
		
		public static StringCollection ActuateTypeNames()
		{
			StringCollection ret = new StringCollection();
			System.Type t = typeof(ActuateType);
			foreach (ActuateType e in Enum.GetValues(t))
				ret.Add(ActuateTypeToString(e));
			return ret;
		}
		
		#endregion
		#endregion

// ##HAND_CODED_BLOCK_START ID="Additional Methods"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional Methods and members here...

// ##HAND_CODED_BLOCK_END ID="Additional Methods"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
	}
}
namespace AD 
{
	public class Enumerations
	{
		// All the enumerations used within the Schema

		#region Enumeration 'Space'
		#region Enumeration Declaration
		public enum Space
		{
        	default_,
        	Preserve
		}
		#endregion


		#region Conversion functions
		/// <summary>
		/// 	Converts a string to a Space enumeration
		/// </summary>
		public static String SpaceToString(AD.Enumerations.Space enumValue)
		{
		    switch(enumValue)
		    {
		    case AD.Enumerations.Space.default_:
	    		return "default";
		    case AD.Enumerations.Space.Preserve:
	    		return "preserve";
			default:
	    		throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for AD.Enumerations.Space [" + enumValue.ToString() + "]");
			}
		}
	
		/// <summary>
		/// 	Converts a Space enumeration to a string (suitable for the XML document)
		/// </summary>
		public static AD.Enumerations.Space SpaceFromString(String enumValue)
		{
		    switch(LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Collapse(enumValue))
		    {
			case "default":
	    		return AD.Enumerations.Space.default_;
			case "preserve":
	    		return AD.Enumerations.Space.Preserve;
			default:
				// ##HAND_CODED_BLOCK_START ID="Default Enum AD.Enumerations.Space"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
				throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for AD.Enumerations.Space [" + enumValue + "]");
				// ##HAND_CODED_BLOCK_END ID="Default Enum AD.Enumerations.Space"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
			}
		}
		
		public static StringCollection SpaceNames()
		{
			StringCollection ret = new StringCollection();
			System.Type t = typeof(Space);
			foreach (Space e in Enum.GetValues(t))
				ret.Add(SpaceToString(e));
			return ret;
		}
		
		#endregion
		#endregion

		#region Enumeration 'SpecialAttrs_space'
		#region Enumeration Declaration
		public enum SpecialAttrs_space
		{
        	default_,
        	Preserve
		}
		#endregion


		#region Conversion functions
		/// <summary>
		/// 	Converts a string to a SpecialAttrs_space enumeration
		/// </summary>
		public static String SpecialAttrs_spaceToString(AD.Enumerations.SpecialAttrs_space enumValue)
		{
		    switch(enumValue)
		    {
		    case AD.Enumerations.SpecialAttrs_space.default_:
	    		return "default";
		    case AD.Enumerations.SpecialAttrs_space.Preserve:
	    		return "preserve";
			default:
	    		throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for AD.Enumerations.SpecialAttrs_space [" + enumValue.ToString() + "]");
			}
		}
	
		/// <summary>
		/// 	Converts a SpecialAttrs_space enumeration to a string (suitable for the XML document)
		/// </summary>
		public static AD.Enumerations.SpecialAttrs_space SpecialAttrs_spaceFromString(String enumValue)
		{
		    switch(LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Collapse(enumValue))
		    {
			case "default":
	    		return AD.Enumerations.SpecialAttrs_space.default_;
			case "preserve":
	    		return AD.Enumerations.SpecialAttrs_space.Preserve;
			default:
				// ##HAND_CODED_BLOCK_START ID="Default Enum AD.Enumerations.SpecialAttrs_space"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
				throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for AD.Enumerations.SpecialAttrs_space [" + enumValue + "]");
				// ##HAND_CODED_BLOCK_END ID="Default Enum AD.Enumerations.SpecialAttrs_space"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
			}
		}
		
		public static StringCollection SpecialAttrs_spaceNames()
		{
			StringCollection ret = new StringCollection();
			System.Type t = typeof(SpecialAttrs_space);
			foreach (SpecialAttrs_space e in Enum.GetValues(t))
				ret.Add(SpecialAttrs_spaceToString(e));
			return ret;
		}
		
		#endregion
		#endregion

// ##HAND_CODED_BLOCK_START ID="Additional Methods"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional Methods and members here...

// ##HAND_CODED_BLOCK_END ID="Additional Methods"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
	}
}
namespace AE 
{
	public class Enumerations
	{
		// All the enumerations used within the Schema

		#region Enumeration 'FileValueModelType'
		#region Enumeration Declaration
		public enum FileValueModelType
		{
        	RecordSpaceInterleaved
		}
		#endregion


		#region Conversion functions
		/// <summary>
		/// 	Converts a string to a FileValueModelType enumeration
		/// </summary>
		public static String FileValueModelTypeToString(AE.Enumerations.FileValueModelType enumValue)
		{
		    switch(enumValue)
		    {
		    case AE.Enumerations.FileValueModelType.RecordSpaceInterleaved:
	    		return "Record Interleaved";
			default:
	    		throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for AE.Enumerations.FileValueModelType [" + enumValue.ToString() + "]");
			}
		}
	
		/// <summary>
		/// 	Converts a FileValueModelType enumeration to a string (suitable for the XML document)
		/// </summary>
		public static AE.Enumerations.FileValueModelType FileValueModelTypeFromString(String enumValue)
		{
		    switch(LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Collapse(enumValue))
		    {
			case "Record Interleaved":
	    		return AE.Enumerations.FileValueModelType.RecordSpaceInterleaved;
			default:
				// ##HAND_CODED_BLOCK_START ID="Default Enum AE.Enumerations.FileValueModelType"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
				throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for AE.Enumerations.FileValueModelType [" + enumValue + "]");
				// ##HAND_CODED_BLOCK_END ID="Default Enum AE.Enumerations.FileValueModelType"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
			}
		}
		
		public static StringCollection FileValueModelTypeNames()
		{
			StringCollection ret = new StringCollection();
			System.Type t = typeof(FileValueModelType);
			foreach (FileValueModelType e in Enum.GetValues(t))
				ret.Add(FileValueModelTypeToString(e));
			return ret;
		}
		
		#endregion
		#endregion

		#region Enumeration 'QueryGrammarEnumeration'
		#region Enumeration Declaration
		public enum QueryGrammarEnumeration
		{
        	Xpath,
        	Xquery,
        	Other
		}
		#endregion


		#region Conversion functions
		/// <summary>
		/// 	Converts a string to a QueryGrammarEnumeration enumeration
		/// </summary>
		public static String QueryGrammarEnumerationToString(AE.Enumerations.QueryGrammarEnumeration enumValue)
		{
		    switch(enumValue)
		    {
		    case AE.Enumerations.QueryGrammarEnumeration.Xpath:
	    		return "xpath";
		    case AE.Enumerations.QueryGrammarEnumeration.Xquery:
	    		return "xquery";
		    case AE.Enumerations.QueryGrammarEnumeration.Other:
	    		return "other";
			default:
	    		throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for AE.Enumerations.QueryGrammarEnumeration [" + enumValue.ToString() + "]");
			}
		}
	
		/// <summary>
		/// 	Converts a QueryGrammarEnumeration enumeration to a string (suitable for the XML document)
		/// </summary>
		public static AE.Enumerations.QueryGrammarEnumeration QueryGrammarEnumerationFromString(String enumValue)
		{
		    switch(LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Collapse(enumValue))
		    {
			case "xpath":
	    		return AE.Enumerations.QueryGrammarEnumeration.Xpath;
			case "xquery":
	    		return AE.Enumerations.QueryGrammarEnumeration.Xquery;
			case "other":
	    		return AE.Enumerations.QueryGrammarEnumeration.Other;
			default:
				// ##HAND_CODED_BLOCK_START ID="Default Enum AE.Enumerations.QueryGrammarEnumeration"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
				throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for AE.Enumerations.QueryGrammarEnumeration [" + enumValue + "]");
				// ##HAND_CODED_BLOCK_END ID="Default Enum AE.Enumerations.QueryGrammarEnumeration"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
			}
		}
		
		public static StringCollection QueryGrammarEnumerationNames()
		{
			StringCollection ret = new StringCollection();
			System.Type t = typeof(QueryGrammarEnumeration);
			foreach (QueryGrammarEnumeration e in Enum.GetValues(t))
				ret.Add(QueryGrammarEnumerationToString(e));
			return ret;
		}
		
		#endregion
		#endregion

		#region Enumeration 'SymbolTypeEnumeration'
		#region Enumeration Declaration
		public enum SymbolTypeEnumeration
		{
        	Svg,
        	Xpath,
        	Other
		}
		#endregion


		#region Conversion functions
		/// <summary>
		/// 	Converts a string to a SymbolTypeEnumeration enumeration
		/// </summary>
		public static String SymbolTypeEnumerationToString(AE.Enumerations.SymbolTypeEnumeration enumValue)
		{
		    switch(enumValue)
		    {
		    case AE.Enumerations.SymbolTypeEnumeration.Svg:
	    		return "svg";
		    case AE.Enumerations.SymbolTypeEnumeration.Xpath:
	    		return "xpath";
		    case AE.Enumerations.SymbolTypeEnumeration.Other:
	    		return "other";
			default:
	    		throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for AE.Enumerations.SymbolTypeEnumeration [" + enumValue.ToString() + "]");
			}
		}
	
		/// <summary>
		/// 	Converts a SymbolTypeEnumeration enumeration to a string (suitable for the XML document)
		/// </summary>
		public static AE.Enumerations.SymbolTypeEnumeration SymbolTypeEnumerationFromString(String enumValue)
		{
		    switch(LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Collapse(enumValue))
		    {
			case "svg":
	    		return AE.Enumerations.SymbolTypeEnumeration.Svg;
			case "xpath":
	    		return AE.Enumerations.SymbolTypeEnumeration.Xpath;
			case "other":
	    		return AE.Enumerations.SymbolTypeEnumeration.Other;
			default:
				// ##HAND_CODED_BLOCK_START ID="Default Enum AE.Enumerations.SymbolTypeEnumeration"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
				throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for AE.Enumerations.SymbolTypeEnumeration [" + enumValue + "]");
				// ##HAND_CODED_BLOCK_END ID="Default Enum AE.Enumerations.SymbolTypeEnumeration"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
			}
		}
		
		public static StringCollection SymbolTypeEnumerationNames()
		{
			StringCollection ret = new StringCollection();
			System.Type t = typeof(SymbolTypeEnumeration);
			foreach (SymbolTypeEnumeration e in Enum.GetValues(t))
				ret.Add(SymbolTypeEnumerationToString(e));
			return ret;
		}
		
		#endregion
		#endregion

		#region Enumeration 'TimeIndeterminateValueType'
		#region Enumeration Declaration
		public enum TimeIndeterminateValueType
		{
        	After,
        	Before,
        	Now,
        	Unknown
		}
		#endregion


		#region Conversion functions
		/// <summary>
		/// 	Converts a string to a TimeIndeterminateValueType enumeration
		/// </summary>
		public static String TimeIndeterminateValueTypeToString(AE.Enumerations.TimeIndeterminateValueType enumValue)
		{
		    switch(enumValue)
		    {
		    case AE.Enumerations.TimeIndeterminateValueType.After:
	    		return "after";
		    case AE.Enumerations.TimeIndeterminateValueType.Before:
	    		return "before";
		    case AE.Enumerations.TimeIndeterminateValueType.Now:
	    		return "now";
		    case AE.Enumerations.TimeIndeterminateValueType.Unknown:
	    		return "unknown";
			default:
	    		throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for AE.Enumerations.TimeIndeterminateValueType [" + enumValue.ToString() + "]");
			}
		}
	
		/// <summary>
		/// 	Converts a TimeIndeterminateValueType enumeration to a string (suitable for the XML document)
		/// </summary>
		public static AE.Enumerations.TimeIndeterminateValueType TimeIndeterminateValueTypeFromString(String enumValue)
		{
		    switch(LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Collapse(enumValue))
		    {
			case "after":
	    		return AE.Enumerations.TimeIndeterminateValueType.After;
			case "before":
	    		return AE.Enumerations.TimeIndeterminateValueType.Before;
			case "now":
	    		return AE.Enumerations.TimeIndeterminateValueType.Now;
			case "unknown":
	    		return AE.Enumerations.TimeIndeterminateValueType.Unknown;
			default:
				// ##HAND_CODED_BLOCK_START ID="Default Enum AE.Enumerations.TimeIndeterminateValueType"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
				throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for AE.Enumerations.TimeIndeterminateValueType [" + enumValue + "]");
				// ##HAND_CODED_BLOCK_END ID="Default Enum AE.Enumerations.TimeIndeterminateValueType"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
			}
		}
		
		public static StringCollection TimeIndeterminateValueTypeNames()
		{
			StringCollection ret = new StringCollection();
			System.Type t = typeof(TimeIndeterminateValueType);
			foreach (TimeIndeterminateValueType e in Enum.GetValues(t))
				ret.Add(TimeIndeterminateValueTypeToString(e));
			return ret;
		}
		
		#endregion
		#endregion

		#region Enumeration 'GraphTypeType'
		#region Enumeration Declaration
		public enum GraphTypeType
		{
        	TREE,
        	BICONNECTED
		}
		#endregion


		#region Conversion functions
		/// <summary>
		/// 	Converts a string to a GraphTypeType enumeration
		/// </summary>
		public static String GraphTypeTypeToString(AE.Enumerations.GraphTypeType enumValue)
		{
		    switch(enumValue)
		    {
		    case AE.Enumerations.GraphTypeType.TREE:
	    		return "TREE";
		    case AE.Enumerations.GraphTypeType.BICONNECTED:
	    		return "BICONNECTED";
			default:
	    		throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for AE.Enumerations.GraphTypeType [" + enumValue.ToString() + "]");
			}
		}
	
		/// <summary>
		/// 	Converts a GraphTypeType enumeration to a string (suitable for the XML document)
		/// </summary>
		public static AE.Enumerations.GraphTypeType GraphTypeTypeFromString(String enumValue)
		{
		    switch(LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Collapse(enumValue))
		    {
			case "TREE":
	    		return AE.Enumerations.GraphTypeType.TREE;
			case "BICONNECTED":
	    		return AE.Enumerations.GraphTypeType.BICONNECTED;
			default:
				// ##HAND_CODED_BLOCK_START ID="Default Enum AE.Enumerations.GraphTypeType"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
				throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for AE.Enumerations.GraphTypeType [" + enumValue + "]");
				// ##HAND_CODED_BLOCK_END ID="Default Enum AE.Enumerations.GraphTypeType"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
			}
		}
		
		public static StringCollection GraphTypeTypeNames()
		{
			StringCollection ret = new StringCollection();
			System.Type t = typeof(GraphTypeType);
			foreach (GraphTypeType e in Enum.GetValues(t))
				ret.Add(GraphTypeTypeToString(e));
			return ret;
		}
		
		#endregion
		#endregion

		#region Enumeration 'SurfaceInterpolationType'
		#region Enumeration Declaration
		public enum SurfaceInterpolationType
		{
        	None,
        	Planar,
        	Spherical,
        	Elliptical,
        	Conic,
        	Tin,
        	ParametricCurve,
        	PolynomialSpline,
        	RationalSpline,
        	TriangulatedSpline
		}
		#endregion


		#region Conversion functions
		/// <summary>
		/// 	Converts a string to a SurfaceInterpolationType enumeration
		/// </summary>
		public static String SurfaceInterpolationTypeToString(AE.Enumerations.SurfaceInterpolationType enumValue)
		{
		    switch(enumValue)
		    {
		    case AE.Enumerations.SurfaceInterpolationType.None:
	    		return "none";
		    case AE.Enumerations.SurfaceInterpolationType.Planar:
	    		return "planar";
		    case AE.Enumerations.SurfaceInterpolationType.Spherical:
	    		return "spherical";
		    case AE.Enumerations.SurfaceInterpolationType.Elliptical:
	    		return "elliptical";
		    case AE.Enumerations.SurfaceInterpolationType.Conic:
	    		return "conic";
		    case AE.Enumerations.SurfaceInterpolationType.Tin:
	    		return "tin";
		    case AE.Enumerations.SurfaceInterpolationType.ParametricCurve:
	    		return "parametricCurve";
		    case AE.Enumerations.SurfaceInterpolationType.PolynomialSpline:
	    		return "polynomialSpline";
		    case AE.Enumerations.SurfaceInterpolationType.RationalSpline:
	    		return "rationalSpline";
		    case AE.Enumerations.SurfaceInterpolationType.TriangulatedSpline:
	    		return "triangulatedSpline";
			default:
	    		throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for AE.Enumerations.SurfaceInterpolationType [" + enumValue.ToString() + "]");
			}
		}
	
		/// <summary>
		/// 	Converts a SurfaceInterpolationType enumeration to a string (suitable for the XML document)
		/// </summary>
		public static AE.Enumerations.SurfaceInterpolationType SurfaceInterpolationTypeFromString(String enumValue)
		{
		    switch(LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Collapse(enumValue))
		    {
			case "none":
	    		return AE.Enumerations.SurfaceInterpolationType.None;
			case "planar":
	    		return AE.Enumerations.SurfaceInterpolationType.Planar;
			case "spherical":
	    		return AE.Enumerations.SurfaceInterpolationType.Spherical;
			case "elliptical":
	    		return AE.Enumerations.SurfaceInterpolationType.Elliptical;
			case "conic":
	    		return AE.Enumerations.SurfaceInterpolationType.Conic;
			case "tin":
	    		return AE.Enumerations.SurfaceInterpolationType.Tin;
			case "parametricCurve":
	    		return AE.Enumerations.SurfaceInterpolationType.ParametricCurve;
			case "polynomialSpline":
	    		return AE.Enumerations.SurfaceInterpolationType.PolynomialSpline;
			case "rationalSpline":
	    		return AE.Enumerations.SurfaceInterpolationType.RationalSpline;
			case "triangulatedSpline":
	    		return AE.Enumerations.SurfaceInterpolationType.TriangulatedSpline;
			default:
				// ##HAND_CODED_BLOCK_START ID="Default Enum AE.Enumerations.SurfaceInterpolationType"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
				throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for AE.Enumerations.SurfaceInterpolationType [" + enumValue + "]");
				// ##HAND_CODED_BLOCK_END ID="Default Enum AE.Enumerations.SurfaceInterpolationType"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
			}
		}
		
		public static StringCollection SurfaceInterpolationTypeNames()
		{
			StringCollection ret = new StringCollection();
			System.Type t = typeof(SurfaceInterpolationType);
			foreach (SurfaceInterpolationType e in Enum.GetValues(t))
				ret.Add(SurfaceInterpolationTypeToString(e));
			return ret;
		}
		
		#endregion
		#endregion

		#region Enumeration 'AesheticCriteriaType'
		#region Enumeration Declaration
		public enum AesheticCriteriaType
		{
        	MIN_CROSSINGS,
        	MIN_AREA,
        	MIN_BENDS,
        	MAX_BENDS,
        	UNIFORM_BENDS,
        	MIN_SLOPES,
        	MIN_EDGE_LENGTH,
        	MAX_EDGE_LENGTH,
        	UNIFORM_EDGE_LENGTH,
        	MAX_ANGULAR_RESOLUTION,
        	MIN_ASPECT_RATIO,
        	MAX_SYMMETRIES
		}
		#endregion


		#region Conversion functions
		/// <summary>
		/// 	Converts a string to a AesheticCriteriaType enumeration
		/// </summary>
		public static String AesheticCriteriaTypeToString(AE.Enumerations.AesheticCriteriaType enumValue)
		{
		    switch(enumValue)
		    {
		    case AE.Enumerations.AesheticCriteriaType.MIN_CROSSINGS:
	    		return "MIN_CROSSINGS";
		    case AE.Enumerations.AesheticCriteriaType.MIN_AREA:
	    		return "MIN_AREA";
		    case AE.Enumerations.AesheticCriteriaType.MIN_BENDS:
	    		return "MIN_BENDS";
		    case AE.Enumerations.AesheticCriteriaType.MAX_BENDS:
	    		return "MAX_BENDS";
		    case AE.Enumerations.AesheticCriteriaType.UNIFORM_BENDS:
	    		return "UNIFORM_BENDS";
		    case AE.Enumerations.AesheticCriteriaType.MIN_SLOPES:
	    		return "MIN_SLOPES";
		    case AE.Enumerations.AesheticCriteriaType.MIN_EDGE_LENGTH:
	    		return "MIN_EDGE_LENGTH";
		    case AE.Enumerations.AesheticCriteriaType.MAX_EDGE_LENGTH:
	    		return "MAX_EDGE_LENGTH";
		    case AE.Enumerations.AesheticCriteriaType.UNIFORM_EDGE_LENGTH:
	    		return "UNIFORM_EDGE_LENGTH";
		    case AE.Enumerations.AesheticCriteriaType.MAX_ANGULAR_RESOLUTION:
	    		return "MAX_ANGULAR_RESOLUTION";
		    case AE.Enumerations.AesheticCriteriaType.MIN_ASPECT_RATIO:
	    		return "MIN_ASPECT_RATIO";
		    case AE.Enumerations.AesheticCriteriaType.MAX_SYMMETRIES:
	    		return "MAX_SYMMETRIES";
			default:
	    		throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for AE.Enumerations.AesheticCriteriaType [" + enumValue.ToString() + "]");
			}
		}
	
		/// <summary>
		/// 	Converts a AesheticCriteriaType enumeration to a string (suitable for the XML document)
		/// </summary>
		public static AE.Enumerations.AesheticCriteriaType AesheticCriteriaTypeFromString(String enumValue)
		{
		    switch(LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Collapse(enumValue))
		    {
			case "MIN_CROSSINGS":
	    		return AE.Enumerations.AesheticCriteriaType.MIN_CROSSINGS;
			case "MIN_AREA":
	    		return AE.Enumerations.AesheticCriteriaType.MIN_AREA;
			case "MIN_BENDS":
	    		return AE.Enumerations.AesheticCriteriaType.MIN_BENDS;
			case "MAX_BENDS":
	    		return AE.Enumerations.AesheticCriteriaType.MAX_BENDS;
			case "UNIFORM_BENDS":
	    		return AE.Enumerations.AesheticCriteriaType.UNIFORM_BENDS;
			case "MIN_SLOPES":
	    		return AE.Enumerations.AesheticCriteriaType.MIN_SLOPES;
			case "MIN_EDGE_LENGTH":
	    		return AE.Enumerations.AesheticCriteriaType.MIN_EDGE_LENGTH;
			case "MAX_EDGE_LENGTH":
	    		return AE.Enumerations.AesheticCriteriaType.MAX_EDGE_LENGTH;
			case "UNIFORM_EDGE_LENGTH":
	    		return AE.Enumerations.AesheticCriteriaType.UNIFORM_EDGE_LENGTH;
			case "MAX_ANGULAR_RESOLUTION":
	    		return AE.Enumerations.AesheticCriteriaType.MAX_ANGULAR_RESOLUTION;
			case "MIN_ASPECT_RATIO":
	    		return AE.Enumerations.AesheticCriteriaType.MIN_ASPECT_RATIO;
			case "MAX_SYMMETRIES":
	    		return AE.Enumerations.AesheticCriteriaType.MAX_SYMMETRIES;
			default:
				// ##HAND_CODED_BLOCK_START ID="Default Enum AE.Enumerations.AesheticCriteriaType"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
				throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for AE.Enumerations.AesheticCriteriaType [" + enumValue + "]");
				// ##HAND_CODED_BLOCK_END ID="Default Enum AE.Enumerations.AesheticCriteriaType"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
			}
		}
		
		public static StringCollection AesheticCriteriaTypeNames()
		{
			StringCollection ret = new StringCollection();
			System.Type t = typeof(AesheticCriteriaType);
			foreach (AesheticCriteriaType e in Enum.GetValues(t))
				ret.Add(AesheticCriteriaTypeToString(e));
			return ret;
		}
		
		#endregion
		#endregion

		#region Enumeration 'CurveInterpolationType'
		#region Enumeration Declaration
		public enum CurveInterpolationType
		{
        	Linear,
        	Geodesic,
        	CircularArc3Points,
        	CircularArc2PointWithBulge,
        	CircularArcCenterPointWithRadius,
        	Elliptical,
        	Clothoid,
        	Conic,
        	PolynomialSpline,
        	CubicSpline,
        	RationalSpline
		}
		#endregion


		#region Conversion functions
		/// <summary>
		/// 	Converts a string to a CurveInterpolationType enumeration
		/// </summary>
		public static String CurveInterpolationTypeToString(AE.Enumerations.CurveInterpolationType enumValue)
		{
		    switch(enumValue)
		    {
		    case AE.Enumerations.CurveInterpolationType.Linear:
	    		return "linear";
		    case AE.Enumerations.CurveInterpolationType.Geodesic:
	    		return "geodesic";
		    case AE.Enumerations.CurveInterpolationType.CircularArc3Points:
	    		return "circularArc3Points";
		    case AE.Enumerations.CurveInterpolationType.CircularArc2PointWithBulge:
	    		return "circularArc2PointWithBulge";
		    case AE.Enumerations.CurveInterpolationType.CircularArcCenterPointWithRadius:
	    		return "circularArcCenterPointWithRadius";
		    case AE.Enumerations.CurveInterpolationType.Elliptical:
	    		return "elliptical";
		    case AE.Enumerations.CurveInterpolationType.Clothoid:
	    		return "clothoid";
		    case AE.Enumerations.CurveInterpolationType.Conic:
	    		return "conic";
		    case AE.Enumerations.CurveInterpolationType.PolynomialSpline:
	    		return "polynomialSpline";
		    case AE.Enumerations.CurveInterpolationType.CubicSpline:
	    		return "cubicSpline";
		    case AE.Enumerations.CurveInterpolationType.RationalSpline:
	    		return "rationalSpline";
			default:
	    		throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for AE.Enumerations.CurveInterpolationType [" + enumValue.ToString() + "]");
			}
		}
	
		/// <summary>
		/// 	Converts a CurveInterpolationType enumeration to a string (suitable for the XML document)
		/// </summary>
		public static AE.Enumerations.CurveInterpolationType CurveInterpolationTypeFromString(String enumValue)
		{
		    switch(LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Collapse(enumValue))
		    {
			case "linear":
	    		return AE.Enumerations.CurveInterpolationType.Linear;
			case "geodesic":
	    		return AE.Enumerations.CurveInterpolationType.Geodesic;
			case "circularArc3Points":
	    		return AE.Enumerations.CurveInterpolationType.CircularArc3Points;
			case "circularArc2PointWithBulge":
	    		return AE.Enumerations.CurveInterpolationType.CircularArc2PointWithBulge;
			case "circularArcCenterPointWithRadius":
	    		return AE.Enumerations.CurveInterpolationType.CircularArcCenterPointWithRadius;
			case "elliptical":
	    		return AE.Enumerations.CurveInterpolationType.Elliptical;
			case "clothoid":
	    		return AE.Enumerations.CurveInterpolationType.Clothoid;
			case "conic":
	    		return AE.Enumerations.CurveInterpolationType.Conic;
			case "polynomialSpline":
	    		return AE.Enumerations.CurveInterpolationType.PolynomialSpline;
			case "cubicSpline":
	    		return AE.Enumerations.CurveInterpolationType.CubicSpline;
			case "rationalSpline":
	    		return AE.Enumerations.CurveInterpolationType.RationalSpline;
			default:
				// ##HAND_CODED_BLOCK_START ID="Default Enum AE.Enumerations.CurveInterpolationType"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
				throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for AE.Enumerations.CurveInterpolationType [" + enumValue + "]");
				// ##HAND_CODED_BLOCK_END ID="Default Enum AE.Enumerations.CurveInterpolationType"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
			}
		}
		
		public static StringCollection CurveInterpolationTypeNames()
		{
			StringCollection ret = new StringCollection();
			System.Type t = typeof(CurveInterpolationType);
			foreach (CurveInterpolationType e in Enum.GetValues(t))
				ret.Add(CurveInterpolationTypeToString(e));
			return ret;
		}
		
		#endregion
		#endregion

		#region Enumeration 'SequenceRuleTypeA'
		#region Enumeration Declaration
		public enum SequenceRuleTypeA
		{
        	Linear,
        	Boustrophedonic,
        	CantorMinusdiagonal,
        	Spiral,
        	Morton,
        	Hilbert
		}
		#endregion


		#region Conversion functions
		/// <summary>
		/// 	Converts a string to a SequenceRuleTypeA enumeration
		/// </summary>
		public static String SequenceRuleTypeAToString(AE.Enumerations.SequenceRuleTypeA enumValue)
		{
		    switch(enumValue)
		    {
		    case AE.Enumerations.SequenceRuleTypeA.Linear:
	    		return "Linear";
		    case AE.Enumerations.SequenceRuleTypeA.Boustrophedonic:
	    		return "Boustrophedonic";
		    case AE.Enumerations.SequenceRuleTypeA.CantorMinusdiagonal:
	    		return "Cantor-diagonal";
		    case AE.Enumerations.SequenceRuleTypeA.Spiral:
	    		return "Spiral";
		    case AE.Enumerations.SequenceRuleTypeA.Morton:
	    		return "Morton";
		    case AE.Enumerations.SequenceRuleTypeA.Hilbert:
	    		return "Hilbert";
			default:
	    		throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for AE.Enumerations.SequenceRuleTypeA [" + enumValue.ToString() + "]");
			}
		}
	
		/// <summary>
		/// 	Converts a SequenceRuleTypeA enumeration to a string (suitable for the XML document)
		/// </summary>
		public static AE.Enumerations.SequenceRuleTypeA SequenceRuleTypeAFromString(String enumValue)
		{
		    switch(LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Collapse(enumValue))
		    {
			case "Linear":
	    		return AE.Enumerations.SequenceRuleTypeA.Linear;
			case "Boustrophedonic":
	    		return AE.Enumerations.SequenceRuleTypeA.Boustrophedonic;
			case "Cantor-diagonal":
	    		return AE.Enumerations.SequenceRuleTypeA.CantorMinusdiagonal;
			case "Spiral":
	    		return AE.Enumerations.SequenceRuleTypeA.Spiral;
			case "Morton":
	    		return AE.Enumerations.SequenceRuleTypeA.Morton;
			case "Hilbert":
	    		return AE.Enumerations.SequenceRuleTypeA.Hilbert;
			default:
				// ##HAND_CODED_BLOCK_START ID="Default Enum AE.Enumerations.SequenceRuleTypeA"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
				throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for AE.Enumerations.SequenceRuleTypeA [" + enumValue + "]");
				// ##HAND_CODED_BLOCK_END ID="Default Enum AE.Enumerations.SequenceRuleTypeA"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
			}
		}
		
		public static StringCollection SequenceRuleTypeANames()
		{
			StringCollection ret = new StringCollection();
			System.Type t = typeof(SequenceRuleTypeA);
			foreach (SequenceRuleTypeA e in Enum.GetValues(t))
				ret.Add(SequenceRuleTypeAToString(e));
			return ret;
		}
		
		#endregion
		#endregion

		#region Enumeration 'LineTypeType'
		#region Enumeration Declaration
		public enum LineTypeType
		{
        	STRAIGHT,
        	BENT
		}
		#endregion


		#region Conversion functions
		/// <summary>
		/// 	Converts a string to a LineTypeType enumeration
		/// </summary>
		public static String LineTypeTypeToString(AE.Enumerations.LineTypeType enumValue)
		{
		    switch(enumValue)
		    {
		    case AE.Enumerations.LineTypeType.STRAIGHT:
	    		return "STRAIGHT";
		    case AE.Enumerations.LineTypeType.BENT:
	    		return "BENT";
			default:
	    		throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for AE.Enumerations.LineTypeType [" + enumValue.ToString() + "]");
			}
		}
	
		/// <summary>
		/// 	Converts a LineTypeType enumeration to a string (suitable for the XML document)
		/// </summary>
		public static AE.Enumerations.LineTypeType LineTypeTypeFromString(String enumValue)
		{
		    switch(LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Collapse(enumValue))
		    {
			case "STRAIGHT":
	    		return AE.Enumerations.LineTypeType.STRAIGHT;
			case "BENT":
	    		return AE.Enumerations.LineTypeType.BENT;
			default:
				// ##HAND_CODED_BLOCK_START ID="Default Enum AE.Enumerations.LineTypeType"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
				throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for AE.Enumerations.LineTypeType [" + enumValue + "]");
				// ##HAND_CODED_BLOCK_END ID="Default Enum AE.Enumerations.LineTypeType"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
			}
		}
		
		public static StringCollection LineTypeTypeNames()
		{
			StringCollection ret = new StringCollection();
			System.Type t = typeof(LineTypeType);
			foreach (LineTypeType e in Enum.GetValues(t))
				ret.Add(LineTypeTypeToString(e));
			return ret;
		}
		
		#endregion
		#endregion

		#region Enumeration 'KnotTypesType'
		#region Enumeration Declaration
		public enum KnotTypesType
		{
        	Uniform,
        	QuasiUniform,
        	PiecewiseBezier
		}
		#endregion


		#region Conversion functions
		/// <summary>
		/// 	Converts a string to a KnotTypesType enumeration
		/// </summary>
		public static String KnotTypesTypeToString(AE.Enumerations.KnotTypesType enumValue)
		{
		    switch(enumValue)
		    {
		    case AE.Enumerations.KnotTypesType.Uniform:
	    		return "uniform";
		    case AE.Enumerations.KnotTypesType.QuasiUniform:
	    		return "quasiUniform";
		    case AE.Enumerations.KnotTypesType.PiecewiseBezier:
	    		return "piecewiseBezier";
			default:
	    		throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for AE.Enumerations.KnotTypesType [" + enumValue.ToString() + "]");
			}
		}
	
		/// <summary>
		/// 	Converts a KnotTypesType enumeration to a string (suitable for the XML document)
		/// </summary>
		public static AE.Enumerations.KnotTypesType KnotTypesTypeFromString(String enumValue)
		{
		    switch(LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Collapse(enumValue))
		    {
			case "uniform":
	    		return AE.Enumerations.KnotTypesType.Uniform;
			case "quasiUniform":
	    		return AE.Enumerations.KnotTypesType.QuasiUniform;
			case "piecewiseBezier":
	    		return AE.Enumerations.KnotTypesType.PiecewiseBezier;
			default:
				// ##HAND_CODED_BLOCK_START ID="Default Enum AE.Enumerations.KnotTypesType"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
				throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for AE.Enumerations.KnotTypesType [" + enumValue + "]");
				// ##HAND_CODED_BLOCK_END ID="Default Enum AE.Enumerations.KnotTypesType"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
			}
		}
		
		public static StringCollection KnotTypesTypeNames()
		{
			StringCollection ret = new StringCollection();
			System.Type t = typeof(KnotTypesType);
			foreach (KnotTypesType e in Enum.GetValues(t))
				ret.Add(KnotTypesTypeToString(e));
			return ret;
		}
		
		#endregion
		#endregion

		#region Enumeration 'SuccessionType'
		#region Enumeration Declaration
		public enum SuccessionType
		{
        	Substitution,
        	Division,
        	Fusion,
        	Initiation
		}
		#endregion


		#region Conversion functions
		/// <summary>
		/// 	Converts a string to a SuccessionType enumeration
		/// </summary>
		public static String SuccessionTypeToString(AE.Enumerations.SuccessionType enumValue)
		{
		    switch(enumValue)
		    {
		    case AE.Enumerations.SuccessionType.Substitution:
	    		return "substitution";
		    case AE.Enumerations.SuccessionType.Division:
	    		return "division";
		    case AE.Enumerations.SuccessionType.Fusion:
	    		return "fusion";
		    case AE.Enumerations.SuccessionType.Initiation:
	    		return "initiation";
			default:
	    		throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for AE.Enumerations.SuccessionType [" + enumValue.ToString() + "]");
			}
		}
	
		/// <summary>
		/// 	Converts a SuccessionType enumeration to a string (suitable for the XML document)
		/// </summary>
		public static AE.Enumerations.SuccessionType SuccessionTypeFromString(String enumValue)
		{
		    switch(LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Collapse(enumValue))
		    {
			case "substitution":
	    		return AE.Enumerations.SuccessionType.Substitution;
			case "division":
	    		return AE.Enumerations.SuccessionType.Division;
			case "fusion":
	    		return AE.Enumerations.SuccessionType.Fusion;
			case "initiation":
	    		return AE.Enumerations.SuccessionType.Initiation;
			default:
				// ##HAND_CODED_BLOCK_START ID="Default Enum AE.Enumerations.SuccessionType"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
				throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for AE.Enumerations.SuccessionType [" + enumValue + "]");
				// ##HAND_CODED_BLOCK_END ID="Default Enum AE.Enumerations.SuccessionType"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
			}
		}
		
		public static StringCollection SuccessionTypeNames()
		{
			StringCollection ret = new StringCollection();
			System.Type t = typeof(SuccessionType);
			foreach (SuccessionType e in Enum.GetValues(t))
				ret.Add(SuccessionTypeToString(e));
			return ret;
		}
		
		#endregion
		#endregion

		#region Enumeration 'DrawingTypeType'
		#region Enumeration Declaration
		public enum DrawingTypeType
		{
        	POLYLINE,
        	ORTHOGONAL
		}
		#endregion


		#region Conversion functions
		/// <summary>
		/// 	Converts a string to a DrawingTypeType enumeration
		/// </summary>
		public static String DrawingTypeTypeToString(AE.Enumerations.DrawingTypeType enumValue)
		{
		    switch(enumValue)
		    {
		    case AE.Enumerations.DrawingTypeType.POLYLINE:
	    		return "POLYLINE";
		    case AE.Enumerations.DrawingTypeType.ORTHOGONAL:
	    		return "ORTHOGONAL";
			default:
	    		throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for AE.Enumerations.DrawingTypeType [" + enumValue.ToString() + "]");
			}
		}
	
		/// <summary>
		/// 	Converts a DrawingTypeType enumeration to a string (suitable for the XML document)
		/// </summary>
		public static AE.Enumerations.DrawingTypeType DrawingTypeTypeFromString(String enumValue)
		{
		    switch(LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Collapse(enumValue))
		    {
			case "POLYLINE":
	    		return AE.Enumerations.DrawingTypeType.POLYLINE;
			case "ORTHOGONAL":
	    		return AE.Enumerations.DrawingTypeType.ORTHOGONAL;
			default:
				// ##HAND_CODED_BLOCK_START ID="Default Enum AE.Enumerations.DrawingTypeType"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
				throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for AE.Enumerations.DrawingTypeType [" + enumValue + "]");
				// ##HAND_CODED_BLOCK_END ID="Default Enum AE.Enumerations.DrawingTypeType"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
			}
		}
		
		public static StringCollection DrawingTypeTypeNames()
		{
			StringCollection ret = new StringCollection();
			System.Type t = typeof(DrawingTypeType);
			foreach (DrawingTypeType e in Enum.GetValues(t))
				ret.Add(DrawingTypeTypeToString(e));
			return ret;
		}
		
		#endregion
		#endregion

		#region Enumeration 'IncrementOrder'
		#region Enumeration Declaration
		public enum IncrementOrder
		{
        	PlusxPlusy,
        	PlusyPlusx,
        	PlusxMinusy,
        	MinusxMinusy
		}
		#endregion


		#region Conversion functions
		/// <summary>
		/// 	Converts a string to a IncrementOrder enumeration
		/// </summary>
		public static String IncrementOrderToString(AE.Enumerations.IncrementOrder enumValue)
		{
		    switch(enumValue)
		    {
		    case AE.Enumerations.IncrementOrder.PlusxPlusy:
	    		return "+x+y";
		    case AE.Enumerations.IncrementOrder.PlusyPlusx:
	    		return "+y+x";
		    case AE.Enumerations.IncrementOrder.PlusxMinusy:
	    		return "+x-y";
		    case AE.Enumerations.IncrementOrder.MinusxMinusy:
	    		return "-x-y";
			default:
	    		throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for AE.Enumerations.IncrementOrder [" + enumValue.ToString() + "]");
			}
		}
	
		/// <summary>
		/// 	Converts a IncrementOrder enumeration to a string (suitable for the XML document)
		/// </summary>
		public static AE.Enumerations.IncrementOrder IncrementOrderFromString(String enumValue)
		{
		    switch(LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Collapse(enumValue))
		    {
			case "+x+y":
	    		return AE.Enumerations.IncrementOrder.PlusxPlusy;
			case "+y+x":
	    		return AE.Enumerations.IncrementOrder.PlusyPlusx;
			case "+x-y":
	    		return AE.Enumerations.IncrementOrder.PlusxMinusy;
			case "-x-y":
	    		return AE.Enumerations.IncrementOrder.MinusxMinusy;
			default:
				// ##HAND_CODED_BLOCK_START ID="Default Enum AE.Enumerations.IncrementOrder"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
				throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for AE.Enumerations.IncrementOrder [" + enumValue + "]");
				// ##HAND_CODED_BLOCK_END ID="Default Enum AE.Enumerations.IncrementOrder"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
			}
		}
		
		public static StringCollection IncrementOrderNames()
		{
			StringCollection ret = new StringCollection();
			System.Type t = typeof(IncrementOrder);
			foreach (IncrementOrder e in Enum.GetValues(t))
				ret.Add(IncrementOrderToString(e));
			return ret;
		}
		
		#endregion
		#endregion

		#region Enumeration 'SequenceRuleNames'
		#region Enumeration Declaration
		public enum SequenceRuleNames
		{
        	Linear,
        	Boustrophedonic,
        	CantorMinusdiagonal,
        	Spiral,
        	Morton,
        	Hilbert
		}
		#endregion


		#region Conversion functions
		/// <summary>
		/// 	Converts a string to a SequenceRuleNames enumeration
		/// </summary>
		public static String SequenceRuleNamesToString(AE.Enumerations.SequenceRuleNames enumValue)
		{
		    switch(enumValue)
		    {
		    case AE.Enumerations.SequenceRuleNames.Linear:
	    		return "Linear";
		    case AE.Enumerations.SequenceRuleNames.Boustrophedonic:
	    		return "Boustrophedonic";
		    case AE.Enumerations.SequenceRuleNames.CantorMinusdiagonal:
	    		return "Cantor-diagonal";
		    case AE.Enumerations.SequenceRuleNames.Spiral:
	    		return "Spiral";
		    case AE.Enumerations.SequenceRuleNames.Morton:
	    		return "Morton";
		    case AE.Enumerations.SequenceRuleNames.Hilbert:
	    		return "Hilbert";
			default:
	    		throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for AE.Enumerations.SequenceRuleNames [" + enumValue.ToString() + "]");
			}
		}
	
		/// <summary>
		/// 	Converts a SequenceRuleNames enumeration to a string (suitable for the XML document)
		/// </summary>
		public static AE.Enumerations.SequenceRuleNames SequenceRuleNamesFromString(String enumValue)
		{
		    switch(LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Collapse(enumValue))
		    {
			case "Linear":
	    		return AE.Enumerations.SequenceRuleNames.Linear;
			case "Boustrophedonic":
	    		return AE.Enumerations.SequenceRuleNames.Boustrophedonic;
			case "Cantor-diagonal":
	    		return AE.Enumerations.SequenceRuleNames.CantorMinusdiagonal;
			case "Spiral":
	    		return AE.Enumerations.SequenceRuleNames.Spiral;
			case "Morton":
	    		return AE.Enumerations.SequenceRuleNames.Morton;
			case "Hilbert":
	    		return AE.Enumerations.SequenceRuleNames.Hilbert;
			default:
				// ##HAND_CODED_BLOCK_START ID="Default Enum AE.Enumerations.SequenceRuleNames"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
				throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for AE.Enumerations.SequenceRuleNames [" + enumValue + "]");
				// ##HAND_CODED_BLOCK_END ID="Default Enum AE.Enumerations.SequenceRuleNames"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
			}
		}
		
		public static StringCollection SequenceRuleNamesNames()
		{
			StringCollection ret = new StringCollection();
			System.Type t = typeof(SequenceRuleNames);
			foreach (SequenceRuleNames e in Enum.GetValues(t))
				ret.Add(SequenceRuleNamesToString(e));
			return ret;
		}
		
		#endregion
		#endregion

		#region Enumeration 'CompassPointEnumeration'
		#region Enumeration Declaration
		public enum CompassPointEnumeration
		{
        	N,
        	NNE,
        	NE,
        	ENE,
        	E,
        	ESE,
        	SE,
        	SSE,
        	S,
        	SSW,
        	SW,
        	WSW,
        	W,
        	WNW,
        	NW,
        	NNW
		}
		#endregion


		#region Conversion functions
		/// <summary>
		/// 	Converts a string to a CompassPointEnumeration enumeration
		/// </summary>
		public static String CompassPointEnumerationToString(AE.Enumerations.CompassPointEnumeration enumValue)
		{
		    switch(enumValue)
		    {
		    case AE.Enumerations.CompassPointEnumeration.N:
	    		return "N";
		    case AE.Enumerations.CompassPointEnumeration.NNE:
	    		return "NNE";
		    case AE.Enumerations.CompassPointEnumeration.NE:
	    		return "NE";
		    case AE.Enumerations.CompassPointEnumeration.ENE:
	    		return "ENE";
		    case AE.Enumerations.CompassPointEnumeration.E:
	    		return "E";
		    case AE.Enumerations.CompassPointEnumeration.ESE:
	    		return "ESE";
		    case AE.Enumerations.CompassPointEnumeration.SE:
	    		return "SE";
		    case AE.Enumerations.CompassPointEnumeration.SSE:
	    		return "SSE";
		    case AE.Enumerations.CompassPointEnumeration.S:
	    		return "S";
		    case AE.Enumerations.CompassPointEnumeration.SSW:
	    		return "SSW";
		    case AE.Enumerations.CompassPointEnumeration.SW:
	    		return "SW";
		    case AE.Enumerations.CompassPointEnumeration.WSW:
	    		return "WSW";
		    case AE.Enumerations.CompassPointEnumeration.W:
	    		return "W";
		    case AE.Enumerations.CompassPointEnumeration.WNW:
	    		return "WNW";
		    case AE.Enumerations.CompassPointEnumeration.NW:
	    		return "NW";
		    case AE.Enumerations.CompassPointEnumeration.NNW:
	    		return "NNW";
			default:
	    		throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for AE.Enumerations.CompassPointEnumeration [" + enumValue.ToString() + "]");
			}
		}
	
		/// <summary>
		/// 	Converts a CompassPointEnumeration enumeration to a string (suitable for the XML document)
		/// </summary>
		public static AE.Enumerations.CompassPointEnumeration CompassPointEnumerationFromString(String enumValue)
		{
		    switch(LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Collapse(enumValue))
		    {
			case "N":
	    		return AE.Enumerations.CompassPointEnumeration.N;
			case "NNE":
	    		return AE.Enumerations.CompassPointEnumeration.NNE;
			case "NE":
	    		return AE.Enumerations.CompassPointEnumeration.NE;
			case "ENE":
	    		return AE.Enumerations.CompassPointEnumeration.ENE;
			case "E":
	    		return AE.Enumerations.CompassPointEnumeration.E;
			case "ESE":
	    		return AE.Enumerations.CompassPointEnumeration.ESE;
			case "SE":
	    		return AE.Enumerations.CompassPointEnumeration.SE;
			case "SSE":
	    		return AE.Enumerations.CompassPointEnumeration.SSE;
			case "S":
	    		return AE.Enumerations.CompassPointEnumeration.S;
			case "SSW":
	    		return AE.Enumerations.CompassPointEnumeration.SSW;
			case "SW":
	    		return AE.Enumerations.CompassPointEnumeration.SW;
			case "WSW":
	    		return AE.Enumerations.CompassPointEnumeration.WSW;
			case "W":
	    		return AE.Enumerations.CompassPointEnumeration.W;
			case "WNW":
	    		return AE.Enumerations.CompassPointEnumeration.WNW;
			case "NW":
	    		return AE.Enumerations.CompassPointEnumeration.NW;
			case "NNW":
	    		return AE.Enumerations.CompassPointEnumeration.NNW;
			default:
				// ##HAND_CODED_BLOCK_START ID="Default Enum AE.Enumerations.CompassPointEnumeration"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
				throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for AE.Enumerations.CompassPointEnumeration [" + enumValue + "]");
				// ##HAND_CODED_BLOCK_END ID="Default Enum AE.Enumerations.CompassPointEnumeration"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
			}
		}
		
		public static StringCollection CompassPointEnumerationNames()
		{
			StringCollection ret = new StringCollection();
			System.Type t = typeof(CompassPointEnumeration);
			foreach (CompassPointEnumeration e in Enum.GetValues(t))
				ret.Add(CompassPointEnumerationToString(e));
			return ret;
		}
		
		#endregion
		#endregion

		#region Enumeration 'SignType'
		#region Enumeration Declaration
		public enum SignType
		{
        	Minus,
        	Plus
		}
		#endregion


		#region Conversion functions
		/// <summary>
		/// 	Converts a string to a SignType enumeration
		/// </summary>
		public static String SignTypeToString(AE.Enumerations.SignType enumValue)
		{
		    switch(enumValue)
		    {
		    case AE.Enumerations.SignType.Minus:
	    		return "-";
		    case AE.Enumerations.SignType.Plus:
	    		return "+";
			default:
	    		throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for AE.Enumerations.SignType [" + enumValue.ToString() + "]");
			}
		}
	
		/// <summary>
		/// 	Converts a SignType enumeration to a string (suitable for the XML document)
		/// </summary>
		public static AE.Enumerations.SignType SignTypeFromString(String enumValue)
		{
		    switch(LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Collapse(enumValue))
		    {
			case "-":
	    		return AE.Enumerations.SignType.Minus;
			case "+":
	    		return AE.Enumerations.SignType.Plus;
			default:
				// ##HAND_CODED_BLOCK_START ID="Default Enum AE.Enumerations.SignType"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
				throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for AE.Enumerations.SignType [" + enumValue + "]");
				// ##HAND_CODED_BLOCK_END ID="Default Enum AE.Enumerations.SignType"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
			}
		}
		
		public static StringCollection SignTypeNames()
		{
			StringCollection ret = new StringCollection();
			System.Type t = typeof(SignType);
			foreach (SignType e in Enum.GetValues(t))
				ret.Add(SignTypeToString(e));
			return ret;
		}
		
		#endregion
		#endregion

		#region Enumeration 'IsSphereA'
		#region Enumeration Declaration
		public enum IsSphereA
		{
        	Sphere
		}
		#endregion


		#region Conversion functions
		/// <summary>
		/// 	Converts a string to a IsSphereA enumeration
		/// </summary>
		public static String IsSphereAToString(AE.Enumerations.IsSphereA enumValue)
		{
		    switch(enumValue)
		    {
		    case AE.Enumerations.IsSphereA.Sphere:
	    		return "sphere";
			default:
	    		throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for AE.Enumerations.IsSphereA [" + enumValue.ToString() + "]");
			}
		}
	
		/// <summary>
		/// 	Converts a IsSphereA enumeration to a string (suitable for the XML document)
		/// </summary>
		public static AE.Enumerations.IsSphereA IsSphereAFromString(String enumValue)
		{
		    switch(LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Collapse(enumValue))
		    {
			case "sphere":
	    		return AE.Enumerations.IsSphereA.Sphere;
			default:
				// ##HAND_CODED_BLOCK_START ID="Default Enum AE.Enumerations.IsSphereA"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
				throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for AE.Enumerations.IsSphereA [" + enumValue + "]");
				// ##HAND_CODED_BLOCK_END ID="Default Enum AE.Enumerations.IsSphereA"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
			}
		}
		
		public static StringCollection IsSphereANames()
		{
			StringCollection ret = new StringCollection();
			System.Type t = typeof(IsSphereA);
			foreach (IsSphereA e in Enum.GetValues(t))
				ret.Add(IsSphereAToString(e));
			return ret;
		}
		
		#endregion
		#endregion

// ##HAND_CODED_BLOCK_START ID="Additional Methods"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional Methods and members here...

// ##HAND_CODED_BLOCK_END ID="Additional Methods"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
	}
}
namespace AF 
{
	public class Enumerations
	{
		// All the enumerations used within the Schema

		#region Enumeration 'FillTimingAttrsType'
		#region Enumeration Declaration
		public enum FillTimingAttrsType
		{
        	Remove,
        	Freeze,
        	Hold,
        	Auto,
        	default_,
        	Transition
		}
		#endregion


		#region Conversion functions
		/// <summary>
		/// 	Converts a string to a FillTimingAttrsType enumeration
		/// </summary>
		public static String FillTimingAttrsTypeToString(AF.Enumerations.FillTimingAttrsType enumValue)
		{
		    switch(enumValue)
		    {
		    case AF.Enumerations.FillTimingAttrsType.Remove:
	    		return "remove";
		    case AF.Enumerations.FillTimingAttrsType.Freeze:
	    		return "freeze";
		    case AF.Enumerations.FillTimingAttrsType.Hold:
	    		return "hold";
		    case AF.Enumerations.FillTimingAttrsType.Auto:
	    		return "auto";
		    case AF.Enumerations.FillTimingAttrsType.default_:
	    		return "default";
		    case AF.Enumerations.FillTimingAttrsType.Transition:
	    		return "transition";
			default:
	    		throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for AF.Enumerations.FillTimingAttrsType [" + enumValue.ToString() + "]");
			}
		}
	
		/// <summary>
		/// 	Converts a FillTimingAttrsType enumeration to a string (suitable for the XML document)
		/// </summary>
		public static AF.Enumerations.FillTimingAttrsType FillTimingAttrsTypeFromString(String enumValue)
		{
		    switch(LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Collapse(enumValue))
		    {
			case "remove":
	    		return AF.Enumerations.FillTimingAttrsType.Remove;
			case "freeze":
	    		return AF.Enumerations.FillTimingAttrsType.Freeze;
			case "hold":
	    		return AF.Enumerations.FillTimingAttrsType.Hold;
			case "auto":
	    		return AF.Enumerations.FillTimingAttrsType.Auto;
			case "default":
	    		return AF.Enumerations.FillTimingAttrsType.default_;
			case "transition":
	    		return AF.Enumerations.FillTimingAttrsType.Transition;
			default:
				// ##HAND_CODED_BLOCK_START ID="Default Enum AF.Enumerations.FillTimingAttrsType"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
				throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for AF.Enumerations.FillTimingAttrsType [" + enumValue + "]");
				// ##HAND_CODED_BLOCK_END ID="Default Enum AF.Enumerations.FillTimingAttrsType"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
			}
		}
		
		public static StringCollection FillTimingAttrsTypeNames()
		{
			StringCollection ret = new StringCollection();
			System.Type t = typeof(FillTimingAttrsType);
			foreach (FillTimingAttrsType e in Enum.GetValues(t))
				ret.Add(FillTimingAttrsTypeToString(e));
			return ret;
		}
		
		#endregion
		#endregion

		#region Enumeration 'RestartDefaultType'
		#region Enumeration Declaration
		public enum RestartDefaultType
		{
        	Never,
        	Always,
        	WhenNotActive,
        	Inherit
		}
		#endregion


		#region Conversion functions
		/// <summary>
		/// 	Converts a string to a RestartDefaultType enumeration
		/// </summary>
		public static String RestartDefaultTypeToString(AF.Enumerations.RestartDefaultType enumValue)
		{
		    switch(enumValue)
		    {
		    case AF.Enumerations.RestartDefaultType.Never:
	    		return "never";
		    case AF.Enumerations.RestartDefaultType.Always:
	    		return "always";
		    case AF.Enumerations.RestartDefaultType.WhenNotActive:
	    		return "whenNotActive";
		    case AF.Enumerations.RestartDefaultType.Inherit:
	    		return "inherit";
			default:
	    		throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for AF.Enumerations.RestartDefaultType [" + enumValue.ToString() + "]");
			}
		}
	
		/// <summary>
		/// 	Converts a RestartDefaultType enumeration to a string (suitable for the XML document)
		/// </summary>
		public static AF.Enumerations.RestartDefaultType RestartDefaultTypeFromString(String enumValue)
		{
		    switch(LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Collapse(enumValue))
		    {
			case "never":
	    		return AF.Enumerations.RestartDefaultType.Never;
			case "always":
	    		return AF.Enumerations.RestartDefaultType.Always;
			case "whenNotActive":
	    		return AF.Enumerations.RestartDefaultType.WhenNotActive;
			case "inherit":
	    		return AF.Enumerations.RestartDefaultType.Inherit;
			default:
				// ##HAND_CODED_BLOCK_START ID="Default Enum AF.Enumerations.RestartDefaultType"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
				throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for AF.Enumerations.RestartDefaultType [" + enumValue + "]");
				// ##HAND_CODED_BLOCK_END ID="Default Enum AF.Enumerations.RestartDefaultType"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
			}
		}
		
		public static StringCollection RestartDefaultTypeNames()
		{
			StringCollection ret = new StringCollection();
			System.Type t = typeof(RestartDefaultType);
			foreach (RestartDefaultType e in Enum.GetValues(t))
				ret.Add(RestartDefaultTypeToString(e));
			return ret;
		}
		
		#endregion
		#endregion

		#region Enumeration 'RestartTimingType'
		#region Enumeration Declaration
		public enum RestartTimingType
		{
        	Never,
        	Always,
        	WhenNotActive,
        	default_
		}
		#endregion


		#region Conversion functions
		/// <summary>
		/// 	Converts a string to a RestartTimingType enumeration
		/// </summary>
		public static String RestartTimingTypeToString(AF.Enumerations.RestartTimingType enumValue)
		{
		    switch(enumValue)
		    {
		    case AF.Enumerations.RestartTimingType.Never:
	    		return "never";
		    case AF.Enumerations.RestartTimingType.Always:
	    		return "always";
		    case AF.Enumerations.RestartTimingType.WhenNotActive:
	    		return "whenNotActive";
		    case AF.Enumerations.RestartTimingType.default_:
	    		return "default";
			default:
	    		throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for AF.Enumerations.RestartTimingType [" + enumValue.ToString() + "]");
			}
		}
	
		/// <summary>
		/// 	Converts a RestartTimingType enumeration to a string (suitable for the XML document)
		/// </summary>
		public static AF.Enumerations.RestartTimingType RestartTimingTypeFromString(String enumValue)
		{
		    switch(LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Collapse(enumValue))
		    {
			case "never":
	    		return AF.Enumerations.RestartTimingType.Never;
			case "always":
	    		return AF.Enumerations.RestartTimingType.Always;
			case "whenNotActive":
	    		return AF.Enumerations.RestartTimingType.WhenNotActive;
			case "default":
	    		return AF.Enumerations.RestartTimingType.default_;
			default:
				// ##HAND_CODED_BLOCK_START ID="Default Enum AF.Enumerations.RestartTimingType"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
				throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for AF.Enumerations.RestartTimingType [" + enumValue + "]");
				// ##HAND_CODED_BLOCK_END ID="Default Enum AF.Enumerations.RestartTimingType"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
			}
		}
		
		public static StringCollection RestartTimingTypeNames()
		{
			StringCollection ret = new StringCollection();
			System.Type t = typeof(RestartTimingType);
			foreach (RestartTimingType e in Enum.GetValues(t))
				ret.Add(RestartTimingTypeToString(e));
			return ret;
		}
		
		#endregion
		#endregion

		#region Enumeration 'SyncBehaviorType'
		#region Enumeration Declaration
		public enum SyncBehaviorType
		{
        	CanSlip,
        	Locked,
        	Independent,
        	default_
		}
		#endregion


		#region Conversion functions
		/// <summary>
		/// 	Converts a string to a SyncBehaviorType enumeration
		/// </summary>
		public static String SyncBehaviorTypeToString(AF.Enumerations.SyncBehaviorType enumValue)
		{
		    switch(enumValue)
		    {
		    case AF.Enumerations.SyncBehaviorType.CanSlip:
	    		return "canSlip";
		    case AF.Enumerations.SyncBehaviorType.Locked:
	    		return "locked";
		    case AF.Enumerations.SyncBehaviorType.Independent:
	    		return "independent";
		    case AF.Enumerations.SyncBehaviorType.default_:
	    		return "default";
			default:
	    		throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for AF.Enumerations.SyncBehaviorType [" + enumValue.ToString() + "]");
			}
		}
	
		/// <summary>
		/// 	Converts a SyncBehaviorType enumeration to a string (suitable for the XML document)
		/// </summary>
		public static AF.Enumerations.SyncBehaviorType SyncBehaviorTypeFromString(String enumValue)
		{
		    switch(LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Collapse(enumValue))
		    {
			case "canSlip":
	    		return AF.Enumerations.SyncBehaviorType.CanSlip;
			case "locked":
	    		return AF.Enumerations.SyncBehaviorType.Locked;
			case "independent":
	    		return AF.Enumerations.SyncBehaviorType.Independent;
			case "default":
	    		return AF.Enumerations.SyncBehaviorType.default_;
			default:
				// ##HAND_CODED_BLOCK_START ID="Default Enum AF.Enumerations.SyncBehaviorType"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
				throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for AF.Enumerations.SyncBehaviorType [" + enumValue + "]");
				// ##HAND_CODED_BLOCK_END ID="Default Enum AF.Enumerations.SyncBehaviorType"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
			}
		}
		
		public static StringCollection SyncBehaviorTypeNames()
		{
			StringCollection ret = new StringCollection();
			System.Type t = typeof(SyncBehaviorType);
			foreach (SyncBehaviorType e in Enum.GetValues(t))
				ret.Add(SyncBehaviorTypeToString(e));
			return ret;
		}
		
		#endregion
		#endregion

		#region Enumeration 'FillDefaultType'
		#region Enumeration Declaration
		public enum FillDefaultType
		{
        	Remove,
        	Freeze,
        	Hold,
        	Auto,
        	Inherit,
        	Transition
		}
		#endregion


		#region Conversion functions
		/// <summary>
		/// 	Converts a string to a FillDefaultType enumeration
		/// </summary>
		public static String FillDefaultTypeToString(AF.Enumerations.FillDefaultType enumValue)
		{
		    switch(enumValue)
		    {
		    case AF.Enumerations.FillDefaultType.Remove:
	    		return "remove";
		    case AF.Enumerations.FillDefaultType.Freeze:
	    		return "freeze";
		    case AF.Enumerations.FillDefaultType.Hold:
	    		return "hold";
		    case AF.Enumerations.FillDefaultType.Auto:
	    		return "auto";
		    case AF.Enumerations.FillDefaultType.Inherit:
	    		return "inherit";
		    case AF.Enumerations.FillDefaultType.Transition:
	    		return "transition";
			default:
	    		throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for AF.Enumerations.FillDefaultType [" + enumValue.ToString() + "]");
			}
		}
	
		/// <summary>
		/// 	Converts a FillDefaultType enumeration to a string (suitable for the XML document)
		/// </summary>
		public static AF.Enumerations.FillDefaultType FillDefaultTypeFromString(String enumValue)
		{
		    switch(LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Collapse(enumValue))
		    {
			case "remove":
	    		return AF.Enumerations.FillDefaultType.Remove;
			case "freeze":
	    		return AF.Enumerations.FillDefaultType.Freeze;
			case "hold":
	    		return AF.Enumerations.FillDefaultType.Hold;
			case "auto":
	    		return AF.Enumerations.FillDefaultType.Auto;
			case "inherit":
	    		return AF.Enumerations.FillDefaultType.Inherit;
			case "transition":
	    		return AF.Enumerations.FillDefaultType.Transition;
			default:
				// ##HAND_CODED_BLOCK_START ID="Default Enum AF.Enumerations.FillDefaultType"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
				throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for AF.Enumerations.FillDefaultType [" + enumValue + "]");
				// ##HAND_CODED_BLOCK_END ID="Default Enum AF.Enumerations.FillDefaultType"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
			}
		}
		
		public static StringCollection FillDefaultTypeNames()
		{
			StringCollection ret = new StringCollection();
			System.Type t = typeof(FillDefaultType);
			foreach (FillDefaultType e in Enum.GetValues(t))
				ret.Add(FillDefaultTypeToString(e));
			return ret;
		}
		
		#endregion
		#endregion

		#region Enumeration 'SyncBehaviorDefaultType'
		#region Enumeration Declaration
		public enum SyncBehaviorDefaultType
		{
        	CanSlip,
        	Locked,
        	Independent,
        	Inherit
		}
		#endregion


		#region Conversion functions
		/// <summary>
		/// 	Converts a string to a SyncBehaviorDefaultType enumeration
		/// </summary>
		public static String SyncBehaviorDefaultTypeToString(AF.Enumerations.SyncBehaviorDefaultType enumValue)
		{
		    switch(enumValue)
		    {
		    case AF.Enumerations.SyncBehaviorDefaultType.CanSlip:
	    		return "canSlip";
		    case AF.Enumerations.SyncBehaviorDefaultType.Locked:
	    		return "locked";
		    case AF.Enumerations.SyncBehaviorDefaultType.Independent:
	    		return "independent";
		    case AF.Enumerations.SyncBehaviorDefaultType.Inherit:
	    		return "inherit";
			default:
	    		throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for AF.Enumerations.SyncBehaviorDefaultType [" + enumValue.ToString() + "]");
			}
		}
	
		/// <summary>
		/// 	Converts a SyncBehaviorDefaultType enumeration to a string (suitable for the XML document)
		/// </summary>
		public static AF.Enumerations.SyncBehaviorDefaultType SyncBehaviorDefaultTypeFromString(String enumValue)
		{
		    switch(LiquidTechnologies.Runtime.Net45.WhitespaceUtils.Collapse(enumValue))
		    {
			case "canSlip":
	    		return AF.Enumerations.SyncBehaviorDefaultType.CanSlip;
			case "locked":
	    		return AF.Enumerations.SyncBehaviorDefaultType.Locked;
			case "independent":
	    		return AF.Enumerations.SyncBehaviorDefaultType.Independent;
			case "inherit":
	    		return AF.Enumerations.SyncBehaviorDefaultType.Inherit;
			default:
				// ##HAND_CODED_BLOCK_START ID="Default Enum AF.Enumerations.SyncBehaviorDefaultType"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
				throw new LiquidTechnologies.Runtime.Net45.LtInvalidValueException("Unknown enumeration value for AF.Enumerations.SyncBehaviorDefaultType [" + enumValue + "]");
				// ##HAND_CODED_BLOCK_END ID="Default Enum AF.Enumerations.SyncBehaviorDefaultType"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
			}
		}
		
		public static StringCollection SyncBehaviorDefaultTypeNames()
		{
			StringCollection ret = new StringCollection();
			System.Type t = typeof(SyncBehaviorDefaultType);
			foreach (SyncBehaviorDefaultType e in Enum.GetValues(t))
				ret.Add(SyncBehaviorDefaultTypeToString(e));
			return ret;
		}
		
		#endregion
		#endregion

// ##HAND_CODED_BLOCK_START ID="Additional Methods"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional Methods and members here...

// ##HAND_CODED_BLOCK_END ID="Additional Methods"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
	}
}
namespace AG 
{
	public class Enumerations
	{
		// All the enumerations used within the Schema

// ##HAND_CODED_BLOCK_START ID="Additional Methods"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS

// Add Additional Methods and members here...

// ##HAND_CODED_BLOCK_END ID="Additional Methods"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
	}
}
	
namespace CSW 
{
	internal class Registration
	{
		private static int RegisterLicense()
		{
			LiquidTechnologies.Runtime.Net45.XmlObjectBase.Register("Trial 05/05/2013", "csw-discovery.xsd", "R1LPUMF8R0BCHD80000000AA");
			
// ##HAND_CODED_BLOCK_START ID="Namespace Declarations"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
// Add Additional namespace declarations here...
			LiquidTechnologies.Runtime.Net45.XmlSerializationContext.Default.SchemaType = LiquidTechnologies.Runtime.Net45.SchemaType.XSD;
//			LiquidTechnologies.Runtime.Net45.XmlSerializationContext.Default.DefaultNamespaceURI = "http://www.fpml.org/2003/FpML-4-0";
//			LiquidTechnologies.Runtime.Net45.XmlSerializationContext.Default.NamespaceAliases.Add("dsig", "http://www.w3.org/2000/09/xmldsig#");

			LiquidTechnologies.Runtime.Net45.XmlSerializationContext.Default.NamespaceAliases.Add("xs", "http://www.w3.org/2001/XMLSchema-instance");
			LiquidTechnologies.Runtime.Net45.XmlSerializationContext.Default.NamespaceAliases.Add("csw", "http://www.opengis.net/cat/csw/2.0.2");
			LiquidTechnologies.Runtime.Net45.XmlSerializationContext.Default.NamespaceAliases.Add("ogc", "http://www.opengis.net/ogc");
			LiquidTechnologies.Runtime.Net45.XmlSerializationContext.Default.NamespaceAliases.Add("ows", "http://www.opengis.net/ows");
			LiquidTechnologies.Runtime.Net45.XmlSerializationContext.Default.NamespaceAliases.Add("AA", "http://purl.org/dc/elements/1.1/");
			LiquidTechnologies.Runtime.Net45.XmlSerializationContext.Default.NamespaceAliases.Add("AB", "http://purl.org/dc/terms/");
			LiquidTechnologies.Runtime.Net45.XmlSerializationContext.Default.NamespaceAliases.Add("AC", "http://www.w3.org/1999/xlink");
			LiquidTechnologies.Runtime.Net45.XmlSerializationContext.Default.NamespaceAliases.Add("AD", "http://www.w3.org/XML/1998/namespace");
			LiquidTechnologies.Runtime.Net45.XmlSerializationContext.Default.NamespaceAliases.Add("AE", "http://www.opengis.net/gml");
			LiquidTechnologies.Runtime.Net45.XmlSerializationContext.Default.NamespaceAliases.Add("AF", "http://www.w3.org/2001/SMIL20/");
			LiquidTechnologies.Runtime.Net45.XmlSerializationContext.Default.NamespaceAliases.Add("AG", "http://www.w3.org/2001/SMIL20/Language");

// ##HAND_CODED_BLOCK_END ID="Namespace Declarations"## DO NOT MODIFY ANYTHING OUTSIDE OF THESE TAGS
			
			return 1;
		}
		static public int iRegistrationIndicator = RegisterLicense();
	}
}




