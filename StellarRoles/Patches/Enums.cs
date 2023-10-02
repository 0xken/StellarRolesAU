﻿
namespace StellarRoles
{
    public enum MurderAttemptResult
    {
        PerformKill,
        SuppressKill,
    }
    public enum SabatageTypes
    {
        Comms,
        O2,
        Reactor,
        OxyMask,
        Lights,
        Charles,
        Seismic,
        None
    }
    public enum Map
    {
        Skeld,
        Mira,
        Polus,
        Dleks,
        Airship,
        Submerged
    }
    public enum Faction
    {
        Crewmate,
        Impostor,
        Neutral,
        NK,
        Other,
        Modifier
    }
    public enum RoleId
    {
        Spectator,
        // Impostor Roles
        Janitor,
        Warlock,
        Shade,
        Morphling,
        Hacker,
        Miner,
        Camouflager,
        Vampire,
        Undertaker,
        Cultist,
        Changeling,
        Follower,
        Wraith,
        BountyHunter,
        Assassin,
        NKAssassin,
        Bomber,

        // Crewmate Roles
        Administrator,
        Detective,
        Engineer,
        Guardian,
        Investigator,
        Jailor,
        Mayor,
        Medic,
        ParityCop,
        Psychic,
        Refugee,
        Sheriff,
        Spy,
        Tracker,
        Trapper,
        Vigilante,
        Watcher,

        // Neutral Roles
        Arsonist,
        Scavenger,
        Jester,
        Executioner,
        Romantic,
        VengefulRomantic,
        Beloved,

        // Neutral Killing Roles
        HeadHunter,
        RuthlessRomantic,
        JanitorNK,
        WarlockNK,
        ShadeNK,
        MorphlingNK,
        MinerNK,
        CamouflagerNK,
        VampireNK,
        UndertakerNK,
        WraithNK,
        BountyHunterNK,
        BomberNK,
        Nightmare,
        Pyromaniac,
        // Default Roles
        Crewmate,
        Impostor,
        RogueImpostor,

        // Modifier ---
        Sleepwalker,
        Mini,
        Giant,
        Spiteful,
        Clutch,
        Gopher,
        Sniper,
        Ascended
    }
    public enum CustomRPC
    {
        // Main Controls

        ResetVaribles = 60,
        ShareOptions,
        ForceEnd,
        LoverPairDead,
        SetRole,
        SetModifier,
        VersionHandshake,
        UncheckedMurderPlayer,
        AddGameInfo,
        DynamicMapOption,
        SetGameStarting,
        ExitAllVents,
        ShareRandomSeed,

        // Role functionality

        EngineerFixLights = 101,
        EngineerFixSubmergedOxygen,
        CleanBody,
        DragBody,
        DropBody,
        GuardianSetShielded,
        GuardianResetShielded,
        JailorJail,
        ParalyzePlayer,
        PyromaniacDouse,
        MorphlingMorph,
        CamouflagerCamouflage,
        TrackerMarkPlayer,
        TrackerTrackWarning,
        ParityCopCompareAddition,
        ArsonistDouse,
        ScavengerEat,
        VampireSetBitten,
        VampireResetBitten,
        PlaceShadeTrace,
        PlaceMinerVent,
        PlaceLantern,
        TripSensor,
        SealVent,
        SetTrap,
        TriggerVentTrap,
        JailBreak,
        ArsonistWin,
        GuesserShoot,
        ScavengerWin,
        SetFirstKill,
        SetFirstKillPlayers,
        SetInvisible,
        ExecutionerSetTarget,
        ExecutionerChangeRole,
        WraithPhase,
        WraithReturn,
        WraithLanternBreak,
        CultistCreateImposter,
        CreateImpostor,
        TurnToCrewmate,
        SetMeetingChatOverlay,
        RefugeeShield,
        RuthlessRomanticShield,
        RomanticShield,
        FallInLove,
        BecomeVengefulLover,
        BecomeLoversRole,
        MedicSetHearMonitor,
        ChangelingChange,
        ScavengerTurnToRefugee,
        RomanticTurnToRefugee,
        VengefulRomanticToRefugee,
        ExilePlayer,
        ShadeGlobalBlind,
        ShadeNearBlind,
        HackerJamToggle,
        NightMareBlind,
        NightMareClear,
        SetJesterWinner,
        PlayerKilledByAbility,
        SetExecutionerWin,
        GiveBomb,
        PassBomb,
        ReadButtons,
        FakeCompare,
        ResetSensors,
        AddPet,
        SpitefulVote,
        ShadeClearBlind,
        AddSpectator,
        RemoveSpectator,
        AvengedLover,
        Duel,
        ClearDuel,
        SendResultOfDuel,
        MayorRetire,
        PsychicAddCount,
    }
}
