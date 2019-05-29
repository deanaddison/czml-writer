﻿using System.Collections.Generic;

namespace CesiumLanguageWriter.Advanced
{
    /// <summary>
    /// A writer that can write a value as a Cartographic rectangle <c>[WestLongitude, SouthLatitude, EastLongitude, NorthLatitude]</c>, with values in radians.
    /// </summary>
    public interface ICesiumCartographicRectangleRadiansValuePropertyWriter : ICesiumInterpolatablePropertyWriter
    {
        /// <summary>
        /// Writes the value expressed as a Cartographic rectangle <c>[WestLongitude, SouthLatitude, EastLongitude, NorthLatitude]</c>, with values in radians.
        /// </summary>
        /// <param name="value">The value.</param>
        void WriteWsen(CartographicExtent value);

        /// <summary>
        /// Writes the value expressed as a Cartographic rectangle <c>[WestLongitude, SouthLatitude, EastLongitude, NorthLatitude]</c>, with values in radians.
        /// </summary>
        /// <param name="west">The westernmost longitude.</param>
        /// <param name="south">The southernmost latitude.</param>
        /// <param name="east">The easternmost longitude.</param>
        /// <param name="north">The northernmost latitude.</param>
        void WriteWsen(double west, double south, double east, double north);

        /// <summary>
        /// Writes the value expressed as a Cartographic rectangle <c>[WestLongitude, SouthLatitude, EastLongitude, NorthLatitude]</c>, with values in radians.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        void WriteWsen(IList<JulianDate> dates, IList<CartographicExtent> values);

        /// <summary>
        /// Writes the value expressed as a Cartographic rectangle <c>[WestLongitude, SouthLatitude, EastLongitude, NorthLatitude]</c>, with values in radians.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        /// <param name="startIndex">The index of the first element to write.</param>
        /// <param name="length">The number of elements to write.</param>
        void WriteWsen(IList<JulianDate> dates, IList<CartographicExtent> values, int startIndex, int length);
    }
}