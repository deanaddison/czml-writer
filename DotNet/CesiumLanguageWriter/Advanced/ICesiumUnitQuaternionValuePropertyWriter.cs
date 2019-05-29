﻿using System.Collections.Generic;

namespace CesiumLanguageWriter.Advanced
{
    /// <summary>
    /// A writer that can write a value as a 4-dimensional unit magnitude quaternion, specified as <c>[X, Y, Z, W]</c>.
    /// </summary>
    public interface ICesiumUnitQuaternionValuePropertyWriter : ICesiumInterpolatablePropertyWriter
    {
        /// <summary>
        /// Writes the value expressed as a 4-dimensional unit magnitude quaternion, specified as <c>[X, Y, Z, W]</c>.
        /// </summary>
        /// <param name="value">The value.</param>
        void WriteUnitQuaternion(UnitQuaternion value);

        /// <summary>
        /// Writes the value expressed as a 4-dimensional unit magnitude quaternion, specified as <c>[X, Y, Z, W]</c>.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        void WriteUnitQuaternion(IList<JulianDate> dates, IList<UnitQuaternion> values);

        /// <summary>
        /// Writes the value expressed as a 4-dimensional unit magnitude quaternion, specified as <c>[X, Y, Z, W]</c>.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        /// <param name="startIndex">The index of the first element to write.</param>
        /// <param name="length">The number of elements to write.</param>
        void WriteUnitQuaternion(IList<JulianDate> dates, IList<UnitQuaternion> values, int startIndex, int length);
    }
}