// <auto-generated>
// This file was generated automatically by GenerateFromSchema. Do NOT edit it.
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
    /// Writes a <c>Color</c> to a <see cref="CesiumOutputStream"/>. A <c>Color</c> is a color. The color can optionally vary over time.
    /// </summary>
    public class ColorCesiumWriter : CesiumInterpolatablePropertyWriter<ColorCesiumWriter>, ICesiumDeletablePropertyWriter, ICesiumRgbaValuePropertyWriter, ICesiumRgbafValuePropertyWriter, ICesiumReferenceValuePropertyWriter
    {
        /// <summary>
        /// The name of the <c>rgba</c> property.
        /// </summary>
        public const string RgbaPropertyName = "rgba";

        /// <summary>
        /// The name of the <c>rgbaf</c> property.
        /// </summary>
        public const string RgbafPropertyName = "rgbaf";

        /// <summary>
        /// The name of the <c>reference</c> property.
        /// </summary>
        public const string ReferencePropertyName = "reference";

        /// <summary>
        /// The name of the <c>delete</c> property.
        /// </summary>
        public const string DeletePropertyName = "delete";

        private readonly Lazy<CesiumRgbaValuePropertyAdaptor<ColorCesiumWriter>> m_asRgba;
        private readonly Lazy<CesiumRgbafValuePropertyAdaptor<ColorCesiumWriter>> m_asRgbaf;
        private readonly Lazy<CesiumReferenceValuePropertyAdaptor<ColorCesiumWriter>> m_asReference;

        /// <summary>
        /// Initializes a new instance.
        /// </summary>
        /// <param name="propertyName">The name of the property.</param>
        public ColorCesiumWriter([NotNull] string propertyName)
            : base(propertyName)
        {
            m_asRgba = CreateAsRgba();
            m_asRgbaf = CreateAsRgbaf();
            m_asReference = CreateAsReference();
        }

        /// <summary>
        /// Initializes a new instance as a copy of an existing instance.
        /// </summary>
        /// <param name="existingInstance">The existing instance to copy.</param>
        protected ColorCesiumWriter([NotNull] ColorCesiumWriter existingInstance)
            : base(existingInstance)
        {
            m_asRgba = CreateAsRgba();
            m_asRgbaf = CreateAsRgbaf();
            m_asReference = CreateAsReference();
        }

        /// <inheritdoc/>
        public override ColorCesiumWriter Clone()
        {
            return new ColorCesiumWriter(this);
        }

        /// <summary>
        /// Writes the value expressed as a <c>rgba</c>, which is the color specified as an array of color components <c>[Red, Green, Blue, Alpha]</c> where each component is an integer in the range 0-255.
        /// </summary>
        /// <param name="color">The color.</param>
        public void WriteRgba(Color color)
        {
            const string PropertyName = RgbaPropertyName;
            OpenIntervalIfNecessary();
            Output.WritePropertyName(PropertyName);
            CesiumWritingHelper.WriteRgba(Output, color);
        }

        /// <summary>
        /// Writes the value expressed as a <c>rgba</c>, which is the color specified as an array of color components <c>[Red, Green, Blue, Alpha]</c> where each component is an integer in the range 0-255.
        /// </summary>
        /// <param name="red">The red component in the range 0 to 255.</param>
        /// <param name="green">The green component in the range 0 to 255.</param>
        /// <param name="blue">The blue component in the range 0 to 255.</param>
        /// <param name="alpha">The alpha component in the range 0 to 255.</param>
        public void WriteRgba(int red, int green, int blue, int alpha)
        {
            const string PropertyName = RgbaPropertyName;
            OpenIntervalIfNecessary();
            Output.WritePropertyName(PropertyName);
            CesiumWritingHelper.WriteRgba(Output, red, green, blue, alpha);
        }

        /// <summary>
        /// Writes the value expressed as a <c>rgba</c>, which is the color specified as an array of color components <c>[Red, Green, Blue, Alpha]</c> where each component is an integer in the range 0-255.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        public void WriteRgba(IList<JulianDate> dates, IList<Color> values)
        {
            WriteRgba(dates, values, 0, dates.Count);
        }

        /// <summary>
        /// Writes the value expressed as a <c>rgba</c>, which is the color specified as an array of color components <c>[Red, Green, Blue, Alpha]</c> where each component is an integer in the range 0-255.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="colors">The color corresponding to each date.</param>
        /// <param name="startIndex">The index of the first element to write.</param>
        /// <param name="length">The number of elements to write.</param>
        public void WriteRgba(IList<JulianDate> dates, IList<Color> colors, int startIndex, int length)
        {
            const string PropertyName = RgbaPropertyName;
            OpenIntervalIfNecessary();
            CesiumWritingHelper.WriteRgba(Output, PropertyName, dates, colors, startIndex, length);
        }

        /// <summary>
        /// Writes the value expressed as a <c>rgbaf</c>, which is the color specified as an array of color components <c>[Red, Green, Blue, Alpha]</c> where each component is a double in the range 0.0-1.0.
        /// </summary>
        /// <param name="color">The color.</param>
        public void WriteRgbaf(Color color)
        {
            const string PropertyName = RgbafPropertyName;
            OpenIntervalIfNecessary();
            Output.WritePropertyName(PropertyName);
            CesiumWritingHelper.WriteRgbaf(Output, color);
        }

        /// <summary>
        /// Writes the value expressed as a <c>rgbaf</c>, which is the color specified as an array of color components <c>[Red, Green, Blue, Alpha]</c> where each component is a double in the range 0.0-1.0.
        /// </summary>
        /// <param name="red">The red component in the range 0 to 1.0.</param>
        /// <param name="green">The green component in the range 0 to 1.0.</param>
        /// <param name="blue">The blue component in the range 0 to 1.0.</param>
        /// <param name="alpha">The alpha component in the range 0 to 1.0.</param>
        public void WriteRgbaf(float red, float green, float blue, float alpha)
        {
            const string PropertyName = RgbafPropertyName;
            OpenIntervalIfNecessary();
            Output.WritePropertyName(PropertyName);
            CesiumWritingHelper.WriteRgbaf(Output, red, green, blue, alpha);
        }

        /// <summary>
        /// Writes the value expressed as a <c>rgbaf</c>, which is the color specified as an array of color components <c>[Red, Green, Blue, Alpha]</c> where each component is a double in the range 0.0-1.0.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        public void WriteRgbaf(IList<JulianDate> dates, IList<Color> values)
        {
            WriteRgbaf(dates, values, 0, dates.Count);
        }

        /// <summary>
        /// Writes the value expressed as a <c>rgbaf</c>, which is the color specified as an array of color components <c>[Red, Green, Blue, Alpha]</c> where each component is a double in the range 0.0-1.0.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="colors">The color corresponding to each date.</param>
        /// <param name="startIndex">The index of the first element to write.</param>
        /// <param name="length">The number of elements to write.</param>
        public void WriteRgbaf(IList<JulianDate> dates, IList<Color> colors, int startIndex, int length)
        {
            const string PropertyName = RgbafPropertyName;
            OpenIntervalIfNecessary();
            CesiumWritingHelper.WriteRgbaf(Output, PropertyName, dates, colors, startIndex, length);
        }

        /// <summary>
        /// Writes the value expressed as a <c>reference</c>, which is the color specified as a reference to another property.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteReference(Reference value)
        {
            const string PropertyName = ReferencePropertyName;
            OpenIntervalIfNecessary();
            Output.WritePropertyName(PropertyName);
            CesiumWritingHelper.WriteReference(Output, value);
        }

        /// <summary>
        /// Writes the value expressed as a <c>reference</c>, which is the color specified as a reference to another property.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteReference(string value)
        {
            const string PropertyName = ReferencePropertyName;
            OpenIntervalIfNecessary();
            Output.WritePropertyName(PropertyName);
            CesiumWritingHelper.WriteReference(Output, value);
        }

        /// <summary>
        /// Writes the value expressed as a <c>reference</c>, which is the color specified as a reference to another property.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteReference(string identifier, string propertyName)
        {
            const string PropertyName = ReferencePropertyName;
            OpenIntervalIfNecessary();
            Output.WritePropertyName(PropertyName);
            CesiumWritingHelper.WriteReference(Output, identifier, propertyName);
        }

        /// <summary>
        /// Writes the value expressed as a <c>reference</c>, which is the color specified as a reference to another property.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteReference(string identifier, string[] propertyNames)
        {
            const string PropertyName = ReferencePropertyName;
            OpenIntervalIfNecessary();
            Output.WritePropertyName(PropertyName);
            CesiumWritingHelper.WriteReference(Output, identifier, propertyNames);
        }

        /// <summary>
        /// Writes the value expressed as a <c>delete</c>, which is whether the client should delete existing samples or interval data for this property. Data will be deleted for the containing interval, or if there is no containing interval, then all data. If true, all other properties in this property will be ignored.
        /// </summary>
        /// <param name="value">The value.</param>
        public void WriteDelete(bool value)
        {
            const string PropertyName = DeletePropertyName;
            OpenIntervalIfNecessary();
            Output.WritePropertyName(PropertyName);
            Output.WriteValue(value);
        }

        /// <summary>
        /// Returns a wrapper for this instance that implements <see cref="ICesiumRgbaValuePropertyWriter"/>. Because the returned instance is a wrapper for this instance, you may call <see cref="ICesiumElementWriter.Close"/> on either this instance or the wrapper, but you must not call it on both.
        /// </summary>
        /// <returns>The wrapper.</returns>
        public CesiumRgbaValuePropertyAdaptor<ColorCesiumWriter> AsRgba()
        {
            return m_asRgba.Value;
        }

        private Lazy<CesiumRgbaValuePropertyAdaptor<ColorCesiumWriter>> CreateAsRgba()
        {
            return new Lazy<CesiumRgbaValuePropertyAdaptor<ColorCesiumWriter>>(CreateRgba, false);
        }

        private CesiumRgbaValuePropertyAdaptor<ColorCesiumWriter> CreateRgba()
        {
            return CesiumValuePropertyAdaptors.CreateRgba(this);
        }

        /// <summary>
        /// Returns a wrapper for this instance that implements <see cref="ICesiumRgbafValuePropertyWriter"/>. Because the returned instance is a wrapper for this instance, you may call <see cref="ICesiumElementWriter.Close"/> on either this instance or the wrapper, but you must not call it on both.
        /// </summary>
        /// <returns>The wrapper.</returns>
        public CesiumRgbafValuePropertyAdaptor<ColorCesiumWriter> AsRgbaf()
        {
            return m_asRgbaf.Value;
        }

        private Lazy<CesiumRgbafValuePropertyAdaptor<ColorCesiumWriter>> CreateAsRgbaf()
        {
            return new Lazy<CesiumRgbafValuePropertyAdaptor<ColorCesiumWriter>>(CreateRgbaf, false);
        }

        private CesiumRgbafValuePropertyAdaptor<ColorCesiumWriter> CreateRgbaf()
        {
            return CesiumValuePropertyAdaptors.CreateRgbaf(this);
        }

        /// <summary>
        /// Returns a wrapper for this instance that implements <see cref="ICesiumReferenceValuePropertyWriter"/>. Because the returned instance is a wrapper for this instance, you may call <see cref="ICesiumElementWriter.Close"/> on either this instance or the wrapper, but you must not call it on both.
        /// </summary>
        /// <returns>The wrapper.</returns>
        public CesiumReferenceValuePropertyAdaptor<ColorCesiumWriter> AsReference()
        {
            return m_asReference.Value;
        }

        private Lazy<CesiumReferenceValuePropertyAdaptor<ColorCesiumWriter>> CreateAsReference()
        {
            return new Lazy<CesiumReferenceValuePropertyAdaptor<ColorCesiumWriter>>(CreateReference, false);
        }

        private CesiumReferenceValuePropertyAdaptor<ColorCesiumWriter> CreateReference()
        {
            return CesiumValuePropertyAdaptors.CreateReference(this);
        }

    }
}
