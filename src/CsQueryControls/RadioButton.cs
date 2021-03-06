﻿using System;
using CsQuery;
using CsQueryControls.HtmlAttributes;
using CsQueryControls.HtmlElements;

namespace CsQueryControls {
    public class RadioButton : InputElement {
        #region Property

        /// <summary>
        ///     Specifies the type of button.
        /// </summary>
        /// <value>
        ///     button|reset|submit
        /// </value>
        public new InputType? Type { get { return base.Type; } }
        /// <summary>
        ///     Specifies the value of an input element.
        /// </summary>
        /// <value>
        ///     boolean.
        /// </value>
        public new bool Value { get { return Convert.ToBoolean(base.Value); } set { base.Value = ToLowerString(value); } }
        /// <summary>
        ///     Specifies that an input element should be pre-selected when the page loads (for type="checkbox" or type="radio").
        /// </summary>
        /// <value>
        ///     checked
        /// </value>
        public virtual bool Checked {
            get { return HasAttr("checked"); }
            set {
                if (value) {
                    Attr("checked", "checked");
                } else {
                    RemoveAttr("checked");
                }
            }
        }

        #endregion

        public RadioButton(HtmlParsingMode parsingMode = HtmlParsingMode.Auto, HtmlParsingOptions parsingOptions = HtmlParsingOptions.Default, DocType docType = DocType.Default)
            : base(InputType.Radio, parsingMode, parsingOptions, docType) {
        }
    }
}