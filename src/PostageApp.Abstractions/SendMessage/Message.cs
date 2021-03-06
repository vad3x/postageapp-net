﻿using System.Collections.Generic;

namespace PostageApp.Abstractions
{
    public class Message
    {
        public string From { get; set; }

        public string Subject { get; set; }

        public string ReplyTo { get; set; }

        public string Template { get; set; }

        public List<MessageRecipient> Recipients { get; set; } = new List<MessageRecipient>();

        public Dictionary<string, string> Variables { get; set; } = new Dictionary<string, string>();

        public Dictionary<string, string> Content { get; set; } = new Dictionary<string, string>();

        public Dictionary<string, string> Headers { get; set; } = new Dictionary<string, string>();

        /// <summary>
        /// When developing an application it is often useful to override the list of recipients with your own email.
        /// This way you’ll avoid sending emails to real people when you’re developing your app.
        /// You can define a single email address.
        /// </summary>
        public string RecipientOverride { get; set; }

        public Dictionary<string, MessageAttachment> Attachments { get; set; } = new Dictionary<string, MessageAttachment>();
    }
}
