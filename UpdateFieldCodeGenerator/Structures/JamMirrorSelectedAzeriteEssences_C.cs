﻿namespace UpdateFieldCodeGenerator.Structures
{
    public class JamMirrorSelectedAzeriteEssences_C
    {
        public static readonly UpdateField m_azeriteEssenceID = new UpdateField(typeof(uint[]), UpdateFieldFlag.None, 3);
        public static readonly UpdateField field_0 = new UpdateField(typeof(uint), UpdateFieldFlag.None);
        public static readonly UpdateField m_enabled = new UpdateField(typeof(Bits), UpdateFieldFlag.None, bitSize: 1);
    }
}