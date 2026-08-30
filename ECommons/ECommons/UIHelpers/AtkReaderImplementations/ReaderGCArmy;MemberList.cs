// porting-note(api13): upstream owns this reader (ECommons e45c72d, 2025-10-04) at the
// typo'd filename above; the api12 tree had hand-gap-filled an identical copy under the
// clean name ReaderGCArmyMemberList.cs, which the a388ee2 anchor swap correctly discarded.
// Kept from that copy: the AtkValue offsets below describe the GcArmyMemberList addon layout
// and are unchanged on game 7.5, but AutoDuty's SquadronManager auto-member-select still has
// NO runtime verification on TC game 7.1 -- RUNTIME-VERIFY before trusting the selection.
using ECommons.MathHelpers;
using FFXIVClientStructs.FFXIV.Component.GUI;
using System.Collections.Generic;

namespace ECommons.UIHelpers.AtkReaderImplementations;
public unsafe class ReaderGCArmyMemberList(AtkUnitBase* UnitBase, int BeginOffset = 0) : AtkReader(UnitBase, BeginOffset)
{
    public uint EntryCount => ReadUInt(4) ?? 0;
    public List<MemberInfo> Entries => Loop<MemberInfo>(4, 15, (int)EntryCount);

    public class MemberInfo(nint UnitBasePtr, int BeginOffset = 0) : AtkReader(UnitBasePtr, BeginOffset)
    {
        public uint Unk0 => ReadUInt(0) ?? 0;
        public int SelectionMask => ReadInt(1) ?? 0; // Bitmask: 0 is always set? 1 and 4 are set when selected. Sometimes 14 is set
        public bool Selected => Bitmask.IsBitSet((short)SelectionMask, 1);
        public string Name => ReadString(2);
        public string Class => ReadString(3);
        public string PortraitPath => ReadString(4);
        public int ClassId => ReadInt(5) ?? 0; // See SquadronClassType
        public SquadronClassType ClassType => (SquadronClassType)ClassId;
        public int Level => ReadInt(6) ?? 0;
        public uint Unk3 => ReadUInt(7) ?? 0;
        public int Unk4 => ReadInt(8) ?? 0;
        public int Physical => ReadInt(9) ?? 0;
        public int Mental => ReadInt(10) ?? 0;
        public int Tactical => ReadInt(11) ?? 0;
        public string Chemistry => ReadString(12);
        public string Tactics => ReadString(14);
    }

    public enum SquadronClassType : int
    {
        Gladiator = 0,
        Pugilist = 1,
        Marauder = 2,
        Lancer = 3,
        Archer = 4,
        Conjurer = 5,
        Thaumaturge = 6,
        Arcanist = 7,
        Rogue = 8,
    }
}