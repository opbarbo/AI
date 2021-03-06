﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
// <auto-generated />
namespace EmailSkill.Dialogs.Shared.Resources
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using Microsoft.Bot.Solutions.Dialogs;
    using Newtonsoft.Json;

    /// <summary>
    /// Email bot responses class.
    /// </summary>
    public static class EmailBotResponses
    {
        private const string JsonFileName = "EmailBotResponses.*.json";

        private static Dictionary<string, Dictionary<string, BotResponse>> jsonResponses;

        // Generated code:
        // This code runs in the text json:
        public static BotResponse DidntUnderstandMessage => GetBotResponse();

        public static BotResponse DidntUnderstandMessageIgnoringInput => GetBotResponse();

        public static BotResponse CancellingMessage => GetBotResponse();

        public static BotResponse EmailWelcomeMessage => GetBotResponse();

        public static BotResponse NoAuth => GetBotResponse();

        public static BotResponse NoEmailContent => GetBotResponse();

        public static BotResponse NoMessageBody => GetBotResponse();

        public static BotResponse NoFocusMessage => GetBotResponse();

        public static BotResponse EmailErrorMessage => GetBotResponse();

        public static BotResponse NoSubject => GetBotResponse();

        public static BotResponse EmailNotFound => GetBotResponse();

        public static BotResponse ConfirmRecipient => GetBotResponse();

        public static BotResponse ConfirmRecipientNotFirstPage => GetBotResponse();

        public static BotResponse ConfirmRecipientLastPage => GetBotResponse();

        public static BotResponse RecipientConfirmed => GetBotResponse();

        public static BotResponse ConfirmSend => GetBotResponse();

        public static BotResponse ConfirmSendFailed => GetBotResponse();

        public static BotResponse ConfirmDelete => GetBotResponse();

        public static BotResponse SentSuccessfully => GetBotResponse();

        public static BotResponse DeleteSuccessfully => GetBotResponse();

        public static BotResponse PromptPersonNotFound => GetBotResponse();

        public static BotResponse ReadOutPrompt => GetBotResponse();

        public static BotResponse ReadOutMessage => GetBotResponse();

        public static BotResponse ReadOutMorePrompt => GetBotResponse();

        public static BotResponse NoRecipients => GetBotResponse();

        public static BotResponse NoForwardRecipients => GetBotResponse();

        public static BotResponse EmailHelpMessage => GetBotResponse();

        public static BotResponse ActionEnded => GetBotResponse();

        public static BotResponse PromptTooManyPeople => GetBotResponse();

        public static BotResponse GreetingMessage => GetBotResponse();

        public static BotResponse LogOut => GetBotResponse();

        public static BotResponse FindUserErrorMessage => GetBotResponse();

        public static BotResponse ShowEmailPrompt => GetBotResponse();

        public static BotResponse AuthFailed => GetBotResponse();

        private static Dictionary<string, Dictionary<string, BotResponse>> JsonResponses
        {
            get
            {
                if (jsonResponses != null)
                {
                    return jsonResponses;
                }

                jsonResponses = new Dictionary<string, Dictionary<string, BotResponse>>();
                var dir = Path.GetDirectoryName(typeof(EmailBotResponses).Assembly.Location);
                var resDir = Path.Combine(dir, "Dialogs\\Shared\\Resources");

                var jsonFiles = Directory.GetFiles(resDir, JsonFileName);
                foreach (var file in jsonFiles)
                {
                    var jsonData = File.ReadAllText(file);
                    var responses = JsonConvert.DeserializeObject<Dictionary<string, BotResponse>>(jsonData);
                    var key = new FileInfo(file).Name.Split(".")[1].ToLower();

                    jsonResponses.Add(key, responses);
                }

                return jsonResponses;
            }
        }

        private static BotResponse GetBotResponse([CallerMemberName] string propertyName = null)
        {
            var locale = CultureInfo.CurrentUICulture.Name;
            var theK = GetJsonResponseKeyForLocale(locale, propertyName);

            // fall back to parent language
            if (theK == null)
            {
                locale = CultureInfo.CurrentUICulture.Name.Split("-")[0].ToLower();
                theK = GetJsonResponseKeyForLocale(locale, propertyName);

                // fall back to en
                if (theK == null)
                {
                    locale = "en";
                    theK = GetJsonResponseKeyForLocale(locale, propertyName);
                }
            }

            var botResponse = JsonResponses[locale][theK ?? throw new ArgumentNullException(nameof(propertyName))];
            return JsonConvert.DeserializeObject<BotResponse>(JsonConvert.SerializeObject(botResponse));
        }

        private static string GetJsonResponseKeyForLocale(string locale, string propertyName)
        {
            try
            {
                if (JsonResponses.ContainsKey(locale))
                {
                    return JsonResponses[locale].ContainsKey(propertyName) ?
                        JsonResponses[locale].Keys.FirstOrDefault(k => string.Compare(k, propertyName, StringComparison.CurrentCultureIgnoreCase) == 0) :
                        null;
                }

                return null;
            }
            catch (KeyNotFoundException)
            {
                return null;
            }
        }
    }
}