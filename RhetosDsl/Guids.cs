// Guids.cs
// MUST match guids.h
using System;

namespace Omega.RhetosDsl
{
    static class GuidList
    {
        public const string guidRhetosDslPkgString = "5d5211c5-177e-410f-947f-feb27e086e18";
        public const string guidRhetosDslCmdSetString = "e3619acd-6e5e-45e1-aa3d-629032bad3be";
        public const string guidRhetosDslEditorFactoryString = "1c5c2d80-a63d-4f88-b673-4f59c44db80f";

        public static readonly Guid guidRhetosDslCmdSet = new Guid(guidRhetosDslCmdSetString);
        public static readonly Guid guidRhetosDslEditorFactory = new Guid(guidRhetosDslEditorFactoryString);
    };
}