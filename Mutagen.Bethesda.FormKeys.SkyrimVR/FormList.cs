﻿using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class RaceCompatibility
    {
        public static class FormList
        {
            private static FormLink<IFormListGetter> Construct(uint id) => new(ModKey.MakeFormKey(id));
            public static FormLink<IFormListGetter> PlayableRaceList => Construct(0xd62);
            public static FormLink<IFormListGetter> PlayableVampireList => Construct(0xd63);
        }
    }
}
