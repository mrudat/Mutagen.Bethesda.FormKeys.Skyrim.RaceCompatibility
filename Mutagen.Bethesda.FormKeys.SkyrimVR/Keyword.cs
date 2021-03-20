﻿using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class RaceCompatibility
    {
        public static class Keyword
        {
            private static FormLink<IKeywordGetter> Construct(uint id) => new(ModKey.MakeFormKey(id));

            public static FormLink<IKeywordGetter> ActorProxyBreton => Construct(0x1d8a);
            public static FormLink<IKeywordGetter> ActorProxyArgonian => Construct(0x1d8b);
            public static FormLink<IKeywordGetter> ActorProxyKhajiit => Construct(0x1d8c);
            public static FormLink<IKeywordGetter> ActorProxyOrc => Construct(0x1d8d);
            public static FormLink<IKeywordGetter> ActorProxyHighElf => Construct(0x1d8e);
            public static FormLink<IKeywordGetter> ActorProxyDarkElf => Construct(0x1d8f);
            public static FormLink<IKeywordGetter> ActorProxyImperial => Construct(0x1d90);
            public static FormLink<IKeywordGetter> ActorProxyRedguard => Construct(0x1d91);
            public static FormLink<IKeywordGetter> ActorProxyWoodElf => Construct(0x1d92);
            public static FormLink<IKeywordGetter> ActorProxyNord => Construct(0x1d93);
        }
    }
}
