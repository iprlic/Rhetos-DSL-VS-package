﻿using System.ComponentModel.Composition;
using System.Windows;
using System.Windows.Shapes;
using System.Windows.Media;
using System.Windows.Controls;
using Microsoft.VisualStudio.Text;
using Microsoft.VisualStudio.Text.Editor;
using Microsoft.VisualStudio.Text.Formatting;
using Microsoft.VisualStudio.Text.Tagging;
using Microsoft.VisualStudio.Utilities;

namespace RhetosDsl.Outlining
{
    [Export(typeof(IGlyphFactoryProvider))]
    [Name("TodoGlyph")]
    [Order(After = "VsTextMarker")]
    [ContentType("RhetosDsl")]
    [TagType(typeof(TodoTag))]
    internal sealed class TodoGlyphFactoryProvider : IGlyphFactoryProvider
    {
        public IGlyphFactory GetGlyphFactory(IWpfTextView view, IWpfTextViewMargin margin)
        {
            return new TodoGlyphFactory();
        }
    }


    internal class TodoGlyphFactory : IGlyphFactory
    {
        const double m_glyphSize = 16.0;

        public UIElement GenerateGlyph(IWpfTextViewLine line, IGlyphTag tag)
        {
            // Ensure we can draw a glyph for this marker. 
            if (tag == null || !(tag is TodoTag))
            {
                return null;
            }

            System.Windows.Shapes.Ellipse ellipse = new Ellipse();
            ellipse.Fill = Brushes.LightBlue;
            ellipse.StrokeThickness = 2;
            ellipse.Stroke = Brushes.LightBlue;
            ellipse.Height = m_glyphSize;
            ellipse.Width = m_glyphSize;
            ellipse.ToolTip = new TextBlock()
                                  {
                                      Text = "TODO",
                                  };

            return ellipse;
        }
    }

}
