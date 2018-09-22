// <auto-generated>
// Code generated by LUISGen .\Desktop\calendar_0_5_1.json -cs Luis.Calendar -o .\Desktop
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
    public class Calendar: IRecognizerConvert
    {
        public string Text;
        public string AlteredText;
        public enum Intent {
            ChangeCalendarEntry, 
            CheckAvailability, 
            Confirm, 
            ConnectToMeeting, 
            ContactMeetingAttendees, 
            CreateCalendarEntry, 
            DeleteCalendarEntry, 
            FindCalendarDetail, 
            FindCalendarEntry, 
            FindCalendarWhen, 
            FindCalendarWhere, 
            FindCalendarWho, 
            FindDuration, 
            FindMeetingRoom, 
            GoBack, 
            None, 
            Reject, 
            ShowNext, 
            ShowPrevious, 
            TimeRemaining, 
            Cancel, 
            ConfirmNo, 
            Greeting, 
            Help, 
            NextMeeting, 
            NoLocation, 
            ReadAloud, 
            Summary, 
            Logout
        };
        public Dictionary<Intent, IntentScore> Intents;

        public class _Entities
        {
            // Simple entities
            public string[] ContactName;
            public string[] a;
            public string[] DestinationCalendar;
            public string[] Duration;
            public string[] EndDate;
            public string[] EndTime;
            public string[] Location;
            public string[] MeetingRoom;
            public string[] MoveEarlierTimeSpan;
            public string[] MoveLaterTimeSpan;
            public string[] OrderReference;
            public string[] OriginalEndDate;
            public string[] OriginalEndTime;
            public string[] OriginalStartDate;
            public string[] OriginalStartTime;
            public string[] PositionReference;
            public string[] RelationshipName;
            public string[] SlotAttribute;
            public string[] StartDate;
            public string[] StartTime;
            public string[] Subject;

            // Built-in entities
            public DateTimeSpec[] datetime;
            public double[] number;
            public double[] ordinal;

            // Instance
            public class _Instance
            {
                public InstanceData[] ContactName;
                public InstanceData[] a;
                public InstanceData[] DestinationCalendar;
                public InstanceData[] Duration;
                public InstanceData[] EndDate;
                public InstanceData[] EndTime;
                public InstanceData[] Location;
                public InstanceData[] MeetingRoom;
                public InstanceData[] MoveEarlierTimeSpan;
                public InstanceData[] MoveLaterTimeSpan;
                public InstanceData[] OrderReference;
                public InstanceData[] OriginalEndDate;
                public InstanceData[] OriginalEndTime;
                public InstanceData[] OriginalStartDate;
                public InstanceData[] OriginalStartTime;
                public InstanceData[] PositionReference;
                public InstanceData[] RelationshipName;
                public InstanceData[] SlotAttribute;
                public InstanceData[] StartDate;
                public InstanceData[] StartTime;
                public InstanceData[] Subject;
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
