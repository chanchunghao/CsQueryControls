﻿using CsQuery;
using CsQueryControls.HtmlAttributes;
using CsQueryControls.HtmlElements;

namespace CsQueryControls {
    public class TextBox : InputElement {
        #region Property

        /// <summary>
        ///     Specifies the type input element to display.
        /// </summary>
        /// <value>
        ///     button|checkbox|color|date|datetime|datetime-local|email|file|hidden|image|month|number|password|radio|range|reset|search|submit|tel|text|time|url|week
        /// </value>
        public new InputType? Type { get { return base.Type; } }

        #endregion

        public TextBox(HtmlParsingMode parsingMode = HtmlParsingMode.Auto, HtmlParsingOptions parsingOptions = HtmlParsingOptions.Default, DocType docType = DocType.Default)
            : base(InputType.Text, parsingMode, parsingOptions, docType) {
        }
    }
}