﻿using osu_StreamCompanion.Code.Misc;
using StreamCompanionTypes.DataTypes;
using StreamCompanionTypes.Enums;
using StreamCompanionTypes.Interfaces;
using StreamCompanionTypes.Interfaces.Services;

namespace osu_StreamCompanion.Code.Modules.MapDataFinders.NoData
{
    public class NoDataFinder : IModule, IMapDataFinder
    {
        private ILogger _logger;
        public bool Started { get; set; }
        public int Priority { get; set; } = -10;
        public NoDataFinder(ILogger logger)
        {
            Start(logger);
        }

        public void Start(ILogger logger)
        {
            Started = true;
            _logger = logger;
        }

        public IMapSearchResult FindBeatmap(IMapSearchArgs searchArgs)
        {
            MapSearchResult mapSearchResult = new MapSearchResult(searchArgs);

            return mapSearchResult;
        }

        public OsuStatus SearchModes { get; } = OsuStatus.Playing|OsuStatus.Watching|OsuStatus.FalsePlaying|OsuStatus.Listening|OsuStatus.Null;
        public string SearcherName { get; } = "~NO DATA~";
    }
}
