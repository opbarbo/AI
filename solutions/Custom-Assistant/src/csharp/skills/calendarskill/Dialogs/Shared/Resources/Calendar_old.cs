// <auto-generated>
// Code generated by LUISGen C:\Users\lamil\source\repos\CAISolutions\IPABot\Skills\CalendarSkill\CognitiveModels\LUISModel.json -cs Luis.Calendar -o C:\Users\lamil\source\repos\CAISolutions\IPABot\Skills\CalendarSkill\\Dialogs\Shared\Resources
// Tool github: https://github.com/microsoft/botbuilder-tools
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>
using Microsoft.Bot.Builder;
using Microsoft.Bot.Builder.AI.Luis;
using Newtonsoft.Json;
using System.Collections.Generic;
namespace Luis
{
    public class Calendar_old: IRecognizerConvert
    {
        public string Text;
        public string AlteredText;
        public enum Intent {
            Cancel, 
            ConfirmNo, 
            ConfirmYes, 
            Create_Event, 
            Delete_Event, 
            Greeting, 
            Help, 
            Logout, 
            Next, 
            Next_Meeting, 
            NoLocation, 
            None, 
            Previous, 
            ReadAloud, 
            Summary, 
            Update_Event_Time
        };

        public Dictionary<Intent, IntentScore> Intents;

        public class _Entities
        {
            // Simple entities
            public string[] Communication_ContactName;
            public string[] Events_Name;
            public string[] Title;

            // Built-in entities
            public DateTimeSpec[] datetime;
            public double[] number;
            public double[] ordinal;

            // Instance
            public class _Instance
            {
                public InstanceData[] Communication_ContactName;
                public InstanceData[] Events_Name;
                public InstanceData[] Title;
                public InstanceData[] datetime;
                public InstanceData[] number;
                public InstanceData[] ordinal;
            }
            [JsonProperty("$instance")]
            public _Instance _instance;
        }
        public _Entities Entities;

        [JsonExtensionData(ReadData = true, WriteData = true)]
        public IDictionary<string, object> Properties {get; set; }

        public void Convert(dynamic result)
        {
            var app = JsonConvert.DeserializeObject<Calendar>(JsonConvert.SerializeObject(result));
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
