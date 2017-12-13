// <auto-generated>
// This file was generated automatically by GenerateFromSchema.  Do NOT edit it.
// https://github.com/AnalyticalGraphicsInc/czml-writer
// </auto-generated>

using CesiumLanguageWriter.Advanced;
using System;
using JetBrains.Annotations;
using System.Drawing;
using System.Collections.Generic;

namespace CesiumLanguageWriter
{
    /// <summary>
    /// Writes a <c>PolylineGlowMaterial</c> to a <see cref="CesiumOutputStream" />.  A <c>PolylineGlowMaterial</c> is a material that fills the surface of a line with a glowing color.
    /// </summary>
    public class PolylineGlowMaterialCesiumWriter : CesiumPropertyWriter<PolylineGlowMaterialCesiumWriter>
    {
        /// <summary>
        /// The name of the <c>color</c> property.
        /// </summary>
        public const string ColorPropertyName = "color";

        /// <summary>
        /// The name of the <c>glowPower</c> property.
        /// </summary>
        public const string GlowPowerPropertyName = "glowPower";

        private readonly Lazy<ColorCesiumWriter> m_color = new Lazy<ColorCesiumWriter>(() => new ColorCesiumWriter(ColorPropertyName), false);
        private readonly Lazy<DoubleCesiumWriter> m_glowPower = new Lazy<DoubleCesiumWriter>(() => new DoubleCesiumWriter(GlowPowerPropertyName), false);

        /// <summary>
        /// Initializes a new instance.
        /// </summary>
        /// <param name="propertyName">The name of the property.</param>
        public PolylineGlowMaterialCesiumWriter([NotNull] string propertyName)
            : base(propertyName)
        {
        }

        /// <summary>
        /// Initializes a new instance as a copy of an existing instance.
        /// </summary>
        /// <param name="existingInstance">The existing instance to copy.</param>
        protected PolylineGlowMaterialCesiumWriter([NotNull] PolylineGlowMaterialCesiumWriter existingInstance)
            : base(existingInstance)
        {
        }

        /// <inheritdoc />
        public override PolylineGlowMaterialCesiumWriter Clone()
        {
            return new PolylineGlowMaterialCesiumWriter(this);
        }

        /// <summary>
        /// Gets the writer for the <c>color</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>color</c> property defines the color of the surface.
        /// </summary>
        [NotNull]
        public ColorCesiumWriter ColorWriter
        {
            get { return m_color.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>color</c> property.  The <c>color</c> property defines the color of the surface.
        /// </summary>
        [NotNull]
        public ColorCesiumWriter OpenColorProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(ColorWriter);
        }

        /// <summary>
        /// Writes a value for the <c>color</c> property as a <c>rgba</c> value.  The <c>color</c> property specifies the color of the surface.
        /// </summary>
        /// <param name="color">The color.</param>
        public void WriteColorProperty(Color color)
        {
            using (var writer = OpenColorProperty())
            {
                writer.WriteRgba(color);
            }
        }

        /// <summary>
        /// Writes a value for the <c>color</c> property as a <c>rgba</c> value.  The <c>color</c> property specifies the color of the surface.
        /// </summary>
        /// <param name="red">The red component in the range 0 to 255.</param>
        /// <param name="green">The green component in the range 0 to 255.</param>
        /// <param name="blue">The blue component in the range 0 to 255.</param>
        /// <param name="alpha">The alpha component in the range 0 to 255.</param>
        public void WriteColorProperty(int red, int green, int blue, int alpha)
        {
            using (var writer = OpenColorProperty())
            {
                writer.WriteRgba(red, green, blue, alpha);
            }
        }

        /// <summary>
        /// Writes a value for the <c>color</c> property as a <c>rgba</c> value.  The <c>color</c> property specifies the color of the surface.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        public void WriteColorProperty(IList<JulianDate> dates, IList<Color> values)
        {
            using (var writer = OpenColorProperty())
            {
                writer.WriteRgba(dates, values);
            }
        }

        /// <summary>
        /// Writes a value for the <c>color</c> property as a <c>rgba</c> value.  The <c>color</c> property specifies the color of the surface.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="colors">The color corresponding to each date.</param>
        /// <param name="startIndex">The index of the first element to write.</param>
        /// <param name="length">The number of elements to write.</param>
        public void WriteColorProperty(IList<JulianDate> dates, IList<Color> colors, int startIndex, int length)
        {
            using (var writer = OpenColorProperty())
            {
                writer.WriteRgba(dates, colors, startIndex, length);
            }
        }

        /// <summary>
        /// Writes a value for the <c>color</c> property as a <c>rgbaf</c> value.  The <c>color</c> property specifies the color of the surface.
        /// </summary>
        /// <param name="color">The color.</param>
        public void WriteColorPropertyRgbaf(Color color)
        {
            using (var writer = OpenColorProperty())
            {
                writer.WriteRgbaf(color);
            }
        }

        /// <summary>
        /// Writes a value for the <c>color</c> property as a <c>rgbaf</c> value.  The <c>color</c> property specifies the color of the surface.
        /// </summary>
        /// <param name="red">The red component in the range 0 to 1.0.</param>
        /// <param name="green">The green component in the range 0 to 1.0.</param>
        /// <param name="blue">The blue component in the range 0 to 1.0.</param>
        /// <param name="alpha">The alpha component in the range 0 to 1.0.</param>
        public void WriteColorPropertyRgbaf(float red, float green, float blue, float alpha)
        {
            using (var writer = OpenColorProperty())
            {
                writer.WriteRgbaf(red, green, blue, alpha);
            }
        }

        /// <summary>
        /// Writes a value for the <c>color</c> property as a <c>rgbaf</c> value.  The <c>color</c> property specifies the color of the surface.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        public void WriteColorPropertyRgbaf(IList<JulianDate> dates, IList<Color> values)
        {
            using (var writer = OpenColorProperty())
            {
                writer.WriteRgbaf(dates, values);
            }
        }

        /// <summary>
        /// Writes a value for the <c>color</c> property as a <c>rgbaf</c> value.  The <c>color</c> property specifies the color of the surface.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="colors">The color corresponding to each date.</param>
        /// <param name="startIndex">The index of the first element to write.</param>
        /// <param name="length">The number of elements to write.</param>
        public void WriteColorPropertyRgbaf(IList<JulianDate> dates, IList<Color> colors, int startIndex, int length)
        {
            using (var writer = OpenColorProperty())
            {
                writer.WriteRgbaf(dates, colors, startIndex, length);
            }
        }

        /// <summary>
        /// Writes a value for the <c>color</c> property as a <c>reference</c> value.  The <c>color</c> property specifies the color of the surface.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteColorPropertyReference(Reference value)
        {
            using (var writer = OpenColorProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>color</c> property as a <c>reference</c> value.  The <c>color</c> property specifies the color of the surface.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WriteColorPropertyReference(string value)
        {
            using (var writer = OpenColorProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>color</c> property as a <c>reference</c> value.  The <c>color</c> property specifies the color of the surface.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteColorPropertyReference(string identifier, string propertyName)
        {
            using (var writer = OpenColorProperty())
            {
                writer.WriteReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <c>color</c> property as a <c>reference</c> value.  The <c>color</c> property specifies the color of the surface.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteColorPropertyReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenColorProperty())
            {
                writer.WriteReference(identifier, propertyNames);
            }
        }

        /// <summary>
        /// Gets the writer for the <c>glowPower</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>glowPower</c> property defines the strength of the glow.
        /// </summary>
        [NotNull]
        public DoubleCesiumWriter GlowPowerWriter
        {
            get { return m_glowPower.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>glowPower</c> property.  The <c>glowPower</c> property defines the strength of the glow.
        /// </summary>
        [NotNull]
        public DoubleCesiumWriter OpenGlowPowerProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(GlowPowerWriter);
        }

        /// <summary>
        /// Writes a value for the <c>glowPower</c> property as a <c>number</c> value.  The <c>glowPower</c> property specifies the strength of the glow.
        /// </summary>
        /// <param name="value">The value.</param>
        public void WriteGlowPowerProperty(double value)
        {
            using (var writer = OpenGlowPowerProperty())
            {
                writer.WriteNumber(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>glowPower</c> property as a <c>number</c> value.  The <c>glowPower</c> property specifies the strength of the glow.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        public void WriteGlowPowerProperty(IList<JulianDate> dates, IList<double> values)
        {
            using (var writer = OpenGlowPowerProperty())
            {
                writer.WriteNumber(dates, values);
            }
        }

        /// <summary>
        /// Writes a value for the <c>glowPower</c> property as a <c>number</c> value.  The <c>glowPower</c> property specifies the strength of the glow.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The value corresponding to each date.</param>
        /// <param name="startIndex">The index of the first element to write.</param>
        /// <param name="length">The number of elements to write.</param>
        public void WriteGlowPowerProperty(IList<JulianDate> dates, IList<double> values, int startIndex, int length)
        {
            using (var writer = OpenGlowPowerProperty())
            {
                writer.WriteNumber(dates, values, startIndex, length);
            }
        }

        /// <summary>
        /// Writes a value for the <c>glowPower</c> property as a <c>reference</c> value.  The <c>glowPower</c> property specifies the strength of the glow.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteGlowPowerPropertyReference(Reference value)
        {
            using (var writer = OpenGlowPowerProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>glowPower</c> property as a <c>reference</c> value.  The <c>glowPower</c> property specifies the strength of the glow.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WriteGlowPowerPropertyReference(string value)
        {
            using (var writer = OpenGlowPowerProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>glowPower</c> property as a <c>reference</c> value.  The <c>glowPower</c> property specifies the strength of the glow.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteGlowPowerPropertyReference(string identifier, string propertyName)
        {
            using (var writer = OpenGlowPowerProperty())
            {
                writer.WriteReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <c>glowPower</c> property as a <c>reference</c> value.  The <c>glowPower</c> property specifies the strength of the glow.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteGlowPowerPropertyReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenGlowPowerProperty())
            {
                writer.WriteReference(identifier, propertyNames);
            }
        }

    }
}
