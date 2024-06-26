﻿using SRTPluginProviderRE2C.Structs;
using SRTPluginProviderRE2C.Structs.GameStructs;
using System;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;

namespace SRTPluginProviderRE2C
{
    public struct GameMemoryRE2C : IGameMemoryRE2C
    {
        private const string IGT_TIMESPAN_STRING_FORMAT = @"hh\:mm\:ss";

        public string GameName => "RE2";
        public string VersionInfo => FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion;

        public int IGT { get => _igt; }
        internal int _igt;

        public GamePlayer Player { get => _player; set => _player = value; }
        internal GamePlayer _player;

        public string PlayerName => Player.ID == 0 ? "Leon: " : "Claire: ";

        public byte AvailableSlots { get => _availableSlots; }
        internal byte _availableSlots;

        public byte BodyCount { get => _bodyCount; }
        internal byte _bodyCount;

        public byte FASCount { get => _fasCount; }
        internal byte _fasCount;

        public byte SaveCount { get => _saveCount; }
        internal byte _saveCount;

        public byte EquippedItemId { get => _equippedItemId; }
        internal byte _equippedItemId;

        public GameItemEntry[] PlayerInventory { get => _playerInventory; }
        internal GameItemEntry[] _playerInventory;

        public NPCInfo[] EnemyHealth { get => _enemyHealth; }
        internal NPCInfo[] _enemyHealth;

        public DifficultyEntry CurrentDifficulty { get => _currentdifficulty; }
        internal DifficultyEntry _currentdifficulty;

        // Public Properties - Calculated
        public TimeSpan IGTTimeSpan => TimeSpan.FromSeconds(IGT);

        public string IGTFormattedString => IGTTimeSpan.ToString(IGT_TIMESPAN_STRING_FORMAT, CultureInfo.InvariantCulture);


    }
}
