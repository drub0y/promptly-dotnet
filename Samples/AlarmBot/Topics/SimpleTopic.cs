﻿using Microsoft.Bot.Builder;
using PromptlyBot;
using System;
using System.Threading.Tasks;

namespace AlarmBot.Topics
{
    //[Serializable]
    public class SimpleTopicState
    {
        public string name;
    }

    public class SimpleTopic : Topic<SimpleTopicState>
    {
        public SimpleTopic(SimpleTopicState state = null) : base(state) { }

        public override Task OnReceiveActivity(IBotContext context)
        {
            context.Reply("SimpleTopic.OnReceiveActivity()");
            return Task.CompletedTask;
        }
    }
}
