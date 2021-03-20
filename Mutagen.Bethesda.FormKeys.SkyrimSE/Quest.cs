﻿using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class RaceCompatibility
    {
        public static class Quest
        {
            private static FormLink<IQuestGetter> Construct(uint id) => new(ModKey.MakeFormKey(id));
            public static FormLink<IQuestGetter> RaceDispatcher => Construct(0x9f27);
        }
    }
}
