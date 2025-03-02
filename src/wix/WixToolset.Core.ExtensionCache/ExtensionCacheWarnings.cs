// Copyright (c) .NET Foundation and contributors. All rights reserved. Licensed under the Microsoft Reciprocal License. See LICENSE.TXT file in the project root for full license information.

namespace WixToolset.Core.ExtensionCache
{
    using WixToolset.Data;

    internal static class ExtensionCacheWarnings
    {
        public static Message NugetException(string extensionId, string exceptionMessage)
        {
            return Message(new SourceLineNumber(extensionId), Ids.NugetException, "{0}", exceptionMessage);
        }

        private static Message Message(SourceLineNumber sourceLineNumber, Ids id, string format, params object[] args)
        {
            return new Message(sourceLineNumber, MessageLevel.Warning, (int)id, format, args);
        }

        public enum Ids
        {
            NugetException = 6100,
        } // last available is 6499. 6500 is ExtensionCacheErrors.
    }
}
