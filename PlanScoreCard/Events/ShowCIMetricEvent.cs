﻿using PlanScoreCard.Models;
using Prism.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanScoreCard.Events
{
    public class ShowCIMetricEvent : PubSubEvent<ScoreMetricModel>
    {
    }
}
