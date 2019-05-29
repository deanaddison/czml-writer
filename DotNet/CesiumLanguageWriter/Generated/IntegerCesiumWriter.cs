// <auto-generated>
// This file was generated automatically by GenerateFromSchema. Do NOT edit it.
// https://github.com/AnalyticalGraphicsInc/czml-writer
// </auto-generated>

using CesiumLanguageWriter.Advanced;
using System;
using JetBrains.Annotations;
using System.Collections.Generic;

namespace CesiumLanguageWriter
{
    /// <summary>
    /// Writes a <c>Integer</c> to a <see cref="CesiumOutputStream"/>. A <c>Integer</c> is an integer number.
    /// </summary>
    public class IntegerCesiumWriter : CesiumInterpolatablePropertyWriter<IntegerCesiumWriter>, ICesiumDeletablePropertyWriter, ICesiumIntegerValuePropertyWriter, ICesiumReferenceValuePropertyWriter
    {
        /// <summary>
        /// The name of the <c>number</c> property.
        /// </summary>
        public const string NumberPropertyName = "number";

        /// <summary>
        /// The name of the <c>reference</c> property.
        /// </summary>
        public const string ReferencePropertyName = "reference";

        /// <summary>
        /// The name of the <c>delete</c> property.
        /// </summary>
        public const string DeletePropertyName = "delete";

        private readonly Lazy<CesiumIntegerValuePropertyAdaptor<IntegerCesiumWriter>> m_asNumber;
        private readonly Lazy<CesiumReferenceValuePropertyAdaptor<IntegerCesiumWriter>> m_asReference;

        /// <summary>
        /// Initializes a new instance.
        /// </summary>
        /// <param name="propertyName">The name of the property.</param>
        public IntegerCesiumWriter([NotNull] string propertyName)
            : base(propertyName)
        {
            m_asNumber = CreateAsNumber();
            m_asReference = CreateAsReference();
        }

        /// <summary>
        /// Initializes a new instance as a copy of an existing instance.
        /// </summary>
        /// <param name="existingInstance">The existing instance to copy.</param>
        protected IntegerCesiumWriter([NotNull] IntegerCesiumWriter existingInstance)
            : base(existingInstance)
        {
            m_asNumber = CreateAsNumber();
            m_asReference = CreateAsReference();
        }

        /// <inheritdoc/>
        public override IntegerCesiumWriter Clone()
        {
            return new IntegerCesiumWriter(this);
        }

        /// <summary>
        /// Writes the value expressed as a <c>number</c>, which is the integer.
        /// </summary>
        /// <param name="value">The value.</param>
        public void WriteNumber(int value)
        {
            const string PropertyName = NumberPropertyName;
            if (ForceInterval)
            {
                OpenIntervalIfNecessary();
            }
            if (IsInterval)
            {
                Output.WritePropertyName(PropertyName);
            }
            Output.WriteValue(value);
        }

        /// <summary>
        /// Writes the value expressed as a <c>number</c>, which is the integer.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        public void WriteNumber(IList<JulianDate> dates, IList<int> values)
        {
            WriteNumber(dates, values, 0, dates.Count);
        }

        /// <summary>
        /// Writes the value expressed as a <c>number</c>, which is the integer.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The value corresponding to each date.</param>
        /// <param name="startIndex">The index of the first element to write.</param>
        /// <param name="length">The number of elements to write.</param>
        public void WriteNumber(IList<JulianDate> dates, IList<int> values, int startIndex, int length)
        {
            const string PropertyName = NumberPropertyName;
            OpenIntervalIfNecessary();
            CesiumWritingHelper.WriteInteger(Output, PropertyName, dates, values, startIndex, length);
        }

        /// <summary>
        /// Writes the value expressed as a <c>reference</c>, which is the integer specified as a reference to another property.
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
        /// Writes the value expressed as a <c>reference</c>, which is the integer specified as a reference to another property.
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
        /// Writes the value expressed as a <c>reference</c>, which is the integer specified as a reference to another property.
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
        /// Writes the value expressed as a <c>reference</c>, which is the integer specified as a reference to another property.
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
        /// Returns a wrapper for this instance that implements <see cref="ICesiumIntegerValuePropertyWriter"/>. Because the returned instance is a wrapper for this instance, you may call <see cref="ICesiumElementWriter.Close"/> on either this instance or the wrapper, but you must not call it on both.
        /// </summary>
        /// <returns>The wrapper.</returns>
        public CesiumIntegerValuePropertyAdaptor<IntegerCesiumWriter> AsNumber()
        {
            return m_asNumber.Value;
        }

        private Lazy<CesiumIntegerValuePropertyAdaptor<IntegerCesiumWriter>> CreateAsNumber()
        {
            return new Lazy<CesiumIntegerValuePropertyAdaptor<IntegerCesiumWriter>>(CreateInteger, false);
        }

        private CesiumIntegerValuePropertyAdaptor<IntegerCesiumWriter> CreateInteger()
        {
            return CesiumValuePropertyAdaptors.CreateInteger(this);
        }

        /// <summary>
        /// Returns a wrapper for this instance that implements <see cref="ICesiumReferenceValuePropertyWriter"/>. Because the returned instance is a wrapper for this instance, you may call <see cref="ICesiumElementWriter.Close"/> on either this instance or the wrapper, but you must not call it on both.
        /// </summary>
        /// <returns>The wrapper.</returns>
        public CesiumReferenceValuePropertyAdaptor<IntegerCesiumWriter> AsReference()
        {
            return m_asReference.Value;
        }

        private Lazy<CesiumReferenceValuePropertyAdaptor<IntegerCesiumWriter>> CreateAsReference()
        {
            return new Lazy<CesiumReferenceValuePropertyAdaptor<IntegerCesiumWriter>>(CreateReference, false);
        }

        private CesiumReferenceValuePropertyAdaptor<IntegerCesiumWriter> CreateReference()
        {
            return CesiumValuePropertyAdaptors.CreateReference(this);
        }

    }
}
