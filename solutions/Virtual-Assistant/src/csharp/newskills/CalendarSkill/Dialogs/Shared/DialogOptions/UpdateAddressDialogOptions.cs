﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.

namespace CalendarSkill
{
    public class UpdateAddressDialogOptions
    {
        public UpdateAddressDialogOptions()
        {
            this.Reason = UpdateReason.NotFound;
        }

        public UpdateAddressDialogOptions(UpdateReason reason)
        {
            this.Reason = reason;
        }

        public enum UpdateReason
        {
            /// <summary>
            /// NotAnAddress.
            /// </summary>
            NotAnAddress,

            /// <summary>
            /// NotFound.
            /// </summary>
            NotFound,
        }

        public bool SkillMode { get; set; }

        public UpdateReason Reason { get; set; }
    }
}
