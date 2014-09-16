

using UnityEngine;


//
// Autogenerated by gaxb ( https://github.com/SmallPlanet/gaxb )
//

using System;
using System.Xml;
using System.Text;
using System.Reflection;
using System.Collections.Generic;
using System.Collections;


public partial class PUText : PUTextBase {
	
	public PUText()
	{
		string attr;

		attr = "12";
		if(attr != null) { fontSize = int.Parse(attr); fontSizeExists = true; } 
		attr = "0,0,0,1";
		if(attr != null) { fontColor = new Color().PUParse(attr); fontColorExists = true; } 
		attr = "middleCenter";
		if(attr != null) { alignment = (PlanetUnity2.TextAlignment)System.Enum.Parse(typeof(PlanetUnity2.TextAlignment), attr); alignmentExists = true; } 

	}
	
	
	public PUText(
			string font,
			int fontSize,
			PlanetUnity2.FontStyle fontStyle,
			Color fontColor,
			float lineSpacing,
			PlanetUnity2.TextAlignment alignment,
			string value,
			bool bestFit ) : this()
	{
		this.font = font;
		this.fontExists = true;

		this.fontSize = fontSize;
		this.fontSizeExists = true;

		this.fontStyle = fontStyle;
		this.fontStyleExists = true;

		this.fontColor = fontColor;
		this.fontColorExists = true;

		this.lineSpacing = lineSpacing;
		this.lineSpacingExists = true;

		this.alignment = alignment;
		this.alignmentExists = true;

		this.value = value;
		this.valueExists = true;

		this.bestFit = bestFit;
		this.bestFitExists = true;
	}

	
	
	public PUText(
			string font,
			int fontSize,
			PlanetUnity2.FontStyle fontStyle,
			Color fontColor,
			float lineSpacing,
			PlanetUnity2.TextAlignment alignment,
			string value,
			bool bestFit,
			Vector4 bounds,
			Vector3 position,
			Vector2 size,
			Vector3 rotation,
			Vector3 scale,
			Vector2 pivot,
			string anchor,
			bool active,
			bool mask,
			bool outline,
			float lastY,
			float lastX,
			string shader,
			string title,
			string tag,
			string tag1,
			string tag2,
			string tag3,
			string tag4,
			string tag5,
			string tag6 ) : this()
	{
		this.font = font;
		this.fontExists = true;

		this.fontSize = fontSize;
		this.fontSizeExists = true;

		this.fontStyle = fontStyle;
		this.fontStyleExists = true;

		this.fontColor = fontColor;
		this.fontColorExists = true;

		this.lineSpacing = lineSpacing;
		this.lineSpacingExists = true;

		this.alignment = alignment;
		this.alignmentExists = true;

		this.value = value;
		this.valueExists = true;

		this.bestFit = bestFit;
		this.bestFitExists = true;

		this.bounds = bounds;
		this.boundsExists = true;

		this.position = position;
		this.positionExists = true;

		this.size = size;
		this.sizeExists = true;

		this.rotation = rotation;
		this.rotationExists = true;

		this.scale = scale;
		this.scaleExists = true;

		this.pivot = pivot;
		this.pivotExists = true;

		this.anchor = anchor;
		this.anchorExists = true;

		this.active = active;
		this.activeExists = true;

		this.mask = mask;
		this.maskExists = true;

		this.outline = outline;
		this.outlineExists = true;

		this.lastY = lastY;
		this.lastYExists = true;

		this.lastX = lastX;
		this.lastXExists = true;

		this.shader = shader;
		this.shaderExists = true;

		this.title = title;
		this.titleExists = true;

		this.tag = tag;
		this.tagExists = true;

		this.tag1 = tag1;
		this.tag1Exists = true;

		this.tag2 = tag2;
		this.tag2Exists = true;

		this.tag3 = tag3;
		this.tag3Exists = true;

		this.tag4 = tag4;
		this.tag4Exists = true;

		this.tag5 = tag5;
		this.tag5Exists = true;

		this.tag6 = tag6;
		this.tag6Exists = true;
	}


}




public class PUTextBase : PUGameObject {


	private static Type planetOverride = Type.GetType("PlanetUnityOverride");
	private static MethodInfo processStringMethod = planetOverride.GetMethod("processString", BindingFlags.Public | BindingFlags.Static);




	// XML Attributes
	public string font;
	public bool fontExists;

	public int fontSize;
	public bool fontSizeExists;

	public PlanetUnity2.FontStyle fontStyle;
	public bool fontStyleExists;

	public Color fontColor;
	public bool fontColorExists;

	public float lineSpacing;
	public bool lineSpacingExists;

	public PlanetUnity2.TextAlignment alignment;
	public bool alignmentExists;

	public string value;
	public bool valueExists;

	public bool bestFit;
	public bool bestFitExists;




	
	public void SetFont(string v) { font = v; fontExists = true; } 
	public void SetFontSize(int v) { fontSize = v; fontSizeExists = true; } 
	public void SetFontStyle(PlanetUnity2.FontStyle v) { fontStyle = v; fontStyleExists = true; } 
	public void SetFontColor(Color v) { fontColor = v; fontColorExists = true; } 
	public void SetLineSpacing(float v) { lineSpacing = v; lineSpacingExists = true; } 
	public void SetAlignment(PlanetUnity2.TextAlignment v) { alignment = v; alignmentExists = true; } 
	public void SetValue(string v) { value = v; valueExists = true; } 
	public void SetBestFit(bool v) { bestFit = v; bestFitExists = true; } 


	public override void gaxb_unload()
	{
		base.gaxb_unload();

	}
	
	public void gaxb_addToParent()
	{
		if(parent != null)
		{
			FieldInfo parentField = parent.GetType().GetField("Text");
			List<object> parentChildren = null;
			
			if(parentField != null)
			{
				parentField.SetValue(parent, this);
				
				parentField = parent.GetType().GetField("TextExists");
				parentField.SetValue(parent, true);
			}
			else
			{
				parentField = parent.GetType().GetField("Texts");
				
				if(parentField != null)
				{
					parentChildren = (List<object>)(parentField.GetValue(parent));
				}
				else
				{
					parentField = parent.GetType().GetField("GameObjects");
					if(parentField != null)
					{
						parentChildren = (List<object>)(parentField.GetValue(parent));
					}
				}
				if(parentChildren == null)
				{
					FieldInfo childrenField = parent.GetType().GetField("children");
					if(childrenField != null)
					{
						parentChildren = (List<object>)childrenField.GetValue(parent);
					}
				}
				if(parentChildren != null)
				{
					parentChildren.Add(this);
				}
				
			}
		}
	}

	public override void gaxb_load(XmlReader reader, object _parent, Hashtable args)
	{
		base.gaxb_load(reader, _parent, args);

		if(reader == null && _parent == null)
			return;
		
		parent = _parent;
		
		if(this.GetType() == typeof( PUText ))
		{
			gaxb_addToParent();
		}
		
		xmlns = reader.GetAttribute("xmlns");
		

		string attr;
		attr = reader.GetAttribute("font");
		if(attr != null && planetOverride != null) { attr = processStringMethod.Invoke(null, new [] {_parent, attr}).ToString(); }
		if(attr != null) { font = attr; fontExists = true; } 
		
		attr = reader.GetAttribute("fontSize");
		if(attr != null && planetOverride != null) { attr = processStringMethod.Invoke(null, new [] {_parent, attr}).ToString(); }
		if(attr == null) { attr = "12"; }
		if(attr != null) { fontSize = int.Parse(attr); fontSizeExists = true; } 
		
		attr = reader.GetAttribute("fontStyle");
		if(attr != null && planetOverride != null) { attr = processStringMethod.Invoke(null, new [] {_parent, attr}).ToString(); }
		if(attr != null) { fontStyle = (PlanetUnity2.FontStyle)System.Enum.Parse(typeof(PlanetUnity2.FontStyle), attr); fontStyleExists = true; } 
		
		attr = reader.GetAttribute("fontColor");
		if(attr != null && planetOverride != null) { attr = processStringMethod.Invoke(null, new [] {_parent, attr}).ToString(); }
		if(attr == null) { attr = "0,0,0,1"; }
		if(attr != null) { fontColor = new Color().PUParse(attr); fontColorExists = true; } 
		
		attr = reader.GetAttribute("lineSpacing");
		if(attr != null && planetOverride != null) { attr = processStringMethod.Invoke(null, new [] {_parent, attr}).ToString(); }
		if(attr != null) { lineSpacing = float.Parse(attr); lineSpacingExists = true; } 
		
		attr = reader.GetAttribute("alignment");
		if(attr != null && planetOverride != null) { attr = processStringMethod.Invoke(null, new [] {_parent, attr}).ToString(); }
		if(attr == null) { attr = "middleCenter"; }
		if(attr != null) { alignment = (PlanetUnity2.TextAlignment)System.Enum.Parse(typeof(PlanetUnity2.TextAlignment), attr); alignmentExists = true; } 
		
		attr = reader.GetAttribute("value");
		if(attr != null && planetOverride != null) { attr = processStringMethod.Invoke(null, new [] {_parent, attr}).ToString(); }
		if(attr != null) { value = attr; valueExists = true; } 
		
		attr = reader.GetAttribute("bestFit");
		if(attr != null && planetOverride != null) { attr = processStringMethod.Invoke(null, new [] {_parent, attr}).ToString(); }
		if(attr != null) { bestFit = bool.Parse(attr); bestFitExists = true; } 
		

	}
	
	
	
	
	
	
	
	public override void gaxb_appendXMLAttributes(StringBuilder sb)
	{
		base.gaxb_appendXMLAttributes(sb);

		if(fontExists) { sb.AppendFormat (" {0}=\"{1}\"", "font", font); }
		if(fontSizeExists) { sb.AppendFormat (" {0}=\"{1}\"", "fontSize", fontSize); }
		if(fontStyleExists) { sb.AppendFormat (" {0}=\"{1}\"", "fontStyle", (int)fontStyle); }
		if(fontColorExists) { sb.AppendFormat (" {0}=\"{1}\"", "fontColor", fontColor); }
		if(lineSpacingExists) { sb.AppendFormat (" {0}=\"{1}\"", "lineSpacing", lineSpacing.ToString ("0.##")); }
		if(alignmentExists) { sb.AppendFormat (" {0}=\"{1}\"", "alignment", (int)alignment); }
		if(valueExists) { sb.AppendFormat (" {0}=\"{1}\"", "value", value); }
		if(bestFitExists) { sb.AppendFormat (" {0}=\"{1}\"", "bestFit", bestFit.ToString().ToLower()); }

	}
	
	public override void gaxb_appendXMLSequences(StringBuilder sb)
	{
		base.gaxb_appendXMLSequences(sb);


	}
	
	public override void gaxb_appendXML(StringBuilder sb)
	{
		if(sb.Length == 0)
		{
			sb.AppendFormat ("<?xml version=\"1.0\" encoding=\"UTF-8\"?>");
		}
		
		sb.AppendFormat ("<{0}", "Text");
		
		if(xmlns != null)
		{
			sb.AppendFormat (" {0}=\"{1}\"", "xmlns", xmlns);
		}
		
		gaxb_appendXMLAttributes(sb);
		
		
		StringBuilder seq = new StringBuilder();
		seq.AppendFormat(" ");
		gaxb_appendXMLSequences(seq);
		
		if(seq.Length == 1)
		{
			sb.AppendFormat (" />");
		}
		else
		{
			sb.AppendFormat (">{0}</{1}>", seq.ToString(), "Text");
		}
	}
}
