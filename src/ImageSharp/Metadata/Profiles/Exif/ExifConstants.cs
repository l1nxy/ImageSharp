// Copyright (c) Six Labors.
// Licensed under the Apache License, Version 2.0.

using System;
using System.Text;

namespace SixLabors.ImageSharp.Metadata.Profiles.Exif
{
    internal static class ExifConstants
    {
        public static ReadOnlySpan<byte> LittleEndianByteOrderMarker => new byte[]
        {
            (byte)'I',
            (byte)'I',
            0x2A,
            0x00,
        };

        public static ReadOnlySpan<byte> BigEndianByteOrderMarker => new byte[]
        {
            (byte)'M',
            (byte)'M',
            0x00,
            0x2A
        };

        // UTF-8 is better than ASCII, UTF-8 encodes the ASCII codes the same way
        public static Encoding DefaultEncoding => Encoding.UTF8;
    }
}
