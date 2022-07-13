// Copyright (c) Six Labors.
// Licensed under the Apache License, Version 2.0.

namespace SixLabors.ImageSharp.Formats.Tga
{
    /// <summary>
    /// Indicates if compression is used.
    /// </summary>
    public enum TgaCompression
    {
        /// <summary>
        /// No compression is used.
        /// </summary>
        None,

        /// <summary>
        /// Run length encoding is used.
        /// </summary>
        RunLength,

        /// <summary>
        /// Run length encoding but not cross multiple scan lines is used.
        /// </summary>
        RunLengthWithoutCrossScanLine,

    }
}
