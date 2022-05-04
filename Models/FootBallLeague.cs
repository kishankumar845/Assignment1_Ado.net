﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FootBallLeague.Models
{
    public class FootBallLeague
    {
        public int MatchID { get; set; }
        public string TeamName1 { get; set; }
        public string TeamName2 { get; set; }
        public string MatchStatus { get; set; }
        public string WinningTeam { get; set; }
        public int? Points { get; set; }
    }
}