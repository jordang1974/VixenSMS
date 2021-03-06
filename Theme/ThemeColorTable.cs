﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vixen_Messaging.Theme
{
	class ThemeColorTable : ProfessionalColorTable
	{
		//Form
		private static Color _backgroundColor = Color.FromArgb(68, 68, 68);

		//Buttons
		private static Color _buttonBorderColor = Color.FromArgb(40, 40, 40);
		private static Color _buttonBackColor = Color.FromArgb(20, 20, 20);
		private static Color _buttonBackColorHover = Color.FromArgb(40, 40, 40);
		private static Color _buttonTextColor;

		//Text
		private static Color _foreColorDisabled = Color.FromArgb(119, 119, 119);
		private static Color _foreColor = Color.FromArgb(221, 221, 221);

		//TextBoxes
		private static Color _textBoxBackColor = Color.FromArgb(90, 90, 90);

		//ComboBoxes
		private static Color _comboBoxBackColor = Color.FromArgb(90, 90, 90);
		private static Color _comboBoxHighlightColor = Color.FromArgb(68, 68, 68);

		//GroupBox
		private static Color _borderColor = Color.FromArgb(136, 136, 136);

		//ListBoxes
		private static Color _listBoxBackColor = Color.FromArgb(90, 90, 90);

		//NumericBoxes
		private static Color _numericBackColor = Color.FromArgb(90, 90, 90);

		//MenuStrips
		private static Color _menuMenuSelectedHighlightBackColor = Color.FromArgb(68, 68, 68);
		private static Color _highlightColor = Color.FromArgb(90, 90, 90);

		private static Color _selectionHighlightColor = _foreColor;

		private static Color _buttonSelectionGradientBegin = _highlightColor;
		private static Color _buttonSelectionGradientEnd = _highlightColor;

		private static Color _buttonPressedGradientBegin = _foreColor;
		private static Color _buttonPressedGradientEnd = _backgroundColor;


		//Sequence TimeLine
		private static Color _timeLinePanel1BackColor = Color.FromArgb(40, 40, 40);
		private static Color _timeLineGridColor = Color.FromArgb(0, 0, 0);
		private static Color _timeLineEffectsBackColor = Color.FromArgb(68, 68, 68);
		private static Color _timeLineForeColor = Color.FromArgb(221, 221, 221);
		private static Color _timeLineLabelBackColor = Color.FromArgb(68, 68, 68);

		//Forms
		public static Color BackgroundColor
		{
			get { return _backgroundColor; }
		}

		//General borders
		public static Color BorderColor
		{
			get
			{
				return _borderColor;
			}
		}

		//Buttons
		public static Color ButtonBorderColor
		{
			get { return _buttonBorderColor; }
		}

		public static Color ButtonBackColor
		{
			get { return _buttonBackColor; }
		}

		public static Color ButtonBackColorHover
		{
			get { return _buttonBackColorHover; }
		}

		public static Color ButtonTextColor
		{
			get { return _buttonTextColor; }
		}

		//Text
		public static Color ForeColorDisabled
		{
			get { return _foreColorDisabled; }
		}

		public static Color ForeColor
		{
			get { return _foreColor; }
		}

		//TextBoxes
		public static Color TextBoxBackgroundColor
		{
			get { return _textBoxBackColor; }
		}

		//ComboBoxes
		public static Color ComboBoxBackColor
		{
			get { return _comboBoxBackColor; }
		}

		public static Color ComboBoxHighlightColor
		{
			get { return _comboBoxHighlightColor; }
		}

		public static Color ComboBoxborderColor
		{
			get { return _borderColor; }
		}

		//GroupBoxes
		public static Color GroupBoxBorderColor
		{
			get { return _borderColor; }
		}


		//ListBoxes
		public static Color ListBoxBackColor
		{
			get { return _listBoxBackColor; }
		}

		//NumericBoxes
		public static Color NumericBackColor
		{
			get { return _numericBackColor; }
		}

		//Timeline Element Panel1 Background
		public static Color TimeLinePanel1BackColor
		{
			get { return _timeLinePanel1BackColor; }
		}

		public static Color TimeLineGridColor
		{
			get { return _timeLineGridColor; }
		}

		public static Color TimeLineEffectsBackColor
		{
			get { return _timeLineEffectsBackColor; }
		}

		public static Color TimeLineForeColor
		{
			get { return _timeLineForeColor; }
		}

		public static Color TimeLineLabelBackColor
		{
			get { return _timeLineLabelBackColor; }
		}

		//MenuStrips

		public override Color MenuItemSelected
		{
			get { return _backgroundColor; }
		}
		public override Color MenuItemSelectedGradientBegin
		{
			get { return _highlightColor; }
		}
		public override Color MenuItemSelectedGradientEnd
		{
			get { return _backgroundColor; }
		}
		public override Color MenuItemBorder
		{
			get { return _borderColor; }
		}

		public override Color MenuStripGradientBegin
		{
			get { return _backgroundColor; }
		}

		public override Color MenuStripGradientEnd
		{
			get { return _backgroundColor; }
		}

		//MenuItemPressed is active on hover
		public override Color MenuItemPressedGradientBegin
		{
			get { return _highlightColor; }
		}

		public override Color MenuItemPressedGradientMiddle
		{
			get { return _highlightColor; }
		}

		public override Color MenuItemPressedGradientEnd
		{
			get { return _highlightColor; }
		}

		public override Color ToolStripGradientBegin
		{
			get { return _backgroundColor; }
		}

		public override Color ToolStripGradientEnd
		{
			get { return _backgroundColor; }
		}

		public override Color ToolStripPanelGradientBegin
		{
			get { return _backgroundColor; }
		}

		public override Color ToolStripPanelGradientEnd
		{
			get { return _backgroundColor; }
		}

		public override Color ToolStripContentPanelGradientBegin
		{
			get { return _backgroundColor; }
		}

		public override Color ToolStripContentPanelGradientEnd
		{
			get { return _backgroundColor; }
		}

		public override Color SeparatorDark
		{
			get { return _backgroundColor; }
		}

		public override Color SeparatorLight
		{
			get { return _borderColor; }
		}

		public override Color StatusStripGradientBegin
		{
			get { return _backgroundColor; }
		}

		public override Color StatusStripGradientEnd
		{
			get { return _backgroundColor; }
		}

		public override Color ToolStripBorder
		{
			get { return _borderColor; }
		}

		public override Color ImageMarginGradientBegin
		{
			get { return _highlightColor; }
		}

		public override Color ImageMarginGradientEnd
		{
			get { return _highlightColor; }
		}

		public override Color ImageMarginGradientMiddle
		{
			get { return _highlightColor; }
		}

		public override Color ToolStripDropDownBackground
		{
			get { return _highlightColor; }
		}

		public override Color CheckBackground
		{
			get { return _highlightColor; }
		}

		public override Color CheckSelectedBackground
		{
			get { return _backgroundColor; }
		}


		public override Color CheckPressedBackground
		{
			get { return _backgroundColor; }
		}

		//Button pressed is for hover highlight
		/// <summary>
		/// Hover highlight solid color
		/// </summary>
		public override Color ButtonPressedHighlight
		{
			get { return _buttonPressedGradientBegin; }
		}

		/// <summary>
		/// Hover highlight gradient colors
		/// </summary>
		public override Color ButtonPressedGradientBegin
		{
			get { return _buttonPressedGradientBegin; }
		}

		/// <summary>
		/// Hover highlight gradient colors
		/// </summary>
		public override Color ButtonPressedGradientEnd
		{
			get { return _buttonPressedGradientEnd; }
		}

		public override Color ButtonPressedBorder
		{
			get { return _backgroundColor; }
		}

		public override Color ButtonCheckedHighlight
		{

			get { return _selectionHighlightColor; }
		}

		public override Color ButtonSelectedBorder
		{
			get { return _menuMenuSelectedHighlightBackColor; }
		}

		public override Color ButtonSelectedHighlight
		{
			get { return _buttonSelectionGradientBegin; }
		}

		public override Color ButtonSelectedGradientBegin
		{
			get { return _buttonSelectionGradientBegin; }
		}

		public override Color ButtonSelectedGradientEnd
		{
			get { return _buttonSelectionGradientEnd; }
		}

		public override Color GripLight
		{
			get { return _borderColor; }
		}

		public override Color GripDark
		{
			get { return _backgroundColor; }
		}

		public static Color MenuSelectedHighlightColor
		{
			get { return _menuMenuSelectedHighlightBackColor; }
		}

		public static Color HighlightColor
		{
			get { return _selectionHighlightColor; }
		}

		public static Color ListBoxHighLightColor
		{
			get
			{
				return _highlightColor;
			}
		}
	}
}
