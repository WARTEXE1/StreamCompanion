﻿using System;
using System.Collections.Generic;
using osu_StreamCompanion.Code.Modules.ModsHandler;

namespace osu_StreamCompanion.Code.Core.DataTypes
{
    public class MapSearchResult
    {
        public List<Beatmap> BeatmapsFound { get { return _beatmapsFound;} set { } }
        readonly List<Beatmap> _beatmapsFound = new List<Beatmap>();
        public Dictionary<string,string> FormatedStrings = new Dictionary<string, string>(); 
        public bool FoundBeatmaps => _beatmapsFound.Count > 0;
        public string MapSearchString;
        public Tuple<EMods,string> Mods = null;
        public OsuStatus Action=OsuStatus.Null;
        
        public MapSearchResult(List<Beatmap> beatmaps)
        {
            _beatmapsFound = beatmaps;
        }

        public MapSearchResult(Beatmap beatmap)
        {
            _beatmapsFound.Add(beatmap);
        }

        public MapSearchResult()
        {
            
        }
    }
}
