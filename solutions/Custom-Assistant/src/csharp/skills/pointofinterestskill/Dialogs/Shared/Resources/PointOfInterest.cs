// <auto-generated>
// Code generated by LUISGen C:\Users\lamil\source\repos\CAISolutions\IPABot\Skills\PointOfInterestSkill\CognitiveModels\LUISModel.json -cs Luis.PointOfInterest -o C:\Users\lamil\source\repos\CAISolutions\IPABot\Skills\PointOfInterestSkill\Dialogs\Shared\Resources
// Tool github: https://github.com/microsoft/botbuilder-tools
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>
using System.Collections.Generic;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Builder.AI.Luis;
using Newtonsoft.Json;
namespace Luis
{
    public class PointOfInterest: IRecognizerConvert
    {
        public string Text;
        public string AlteredText;
        public enum Intent {
            NAVIGATION_CANCEL_ROUTE, 
            NAVIGATION_FIND_POINTOFINTEREST, 
            NAVIGATION_ROUTE_FROM_X_TO_Y, 
            None
        };
        public Dictionary<Intent, IntentScore> Intents;

        public class _Entities
        {
            // Simple entities
            public string[] ADDRESS;
            public string[] DESCRIPTOR;
            public string[] KEYWORD;

            // Instance
            public class _Instance
            {
                public InstanceData[] ADDRESS;
                public InstanceData[] DESCRIPTOR;
                public InstanceData[] KEYWORD;
            }
            [JsonProperty("$instance")]
            public _Instance _instance;
        }
        public _Entities Entities;

        [JsonExtensionData(ReadData = true, WriteData = true)]
        public IDictionary<string, object> Properties {get; set; }

        public void Convert(dynamic result)
        {
            var app = JsonConvert.DeserializeObject<PointOfInterest>(JsonConvert.SerializeObject(result));
            Text = app.Text;
            AlteredText = app.AlteredText;
            Intents = app.Intents;
            Entities = app.Entities;
            Properties = app.Properties;
        }

        public (Intent intent, double score) TopIntent()
        {
            Intent maxIntent = Intent.None;
            var max = 0.0;
            foreach (var entry in Intents)
            {
                if (entry.Value.Score > max)
                {
                    maxIntent = entry.Key;
                    max = entry.Value.Score.Value;
                }
            }
            return (maxIntent, max);
        }
    }
}
