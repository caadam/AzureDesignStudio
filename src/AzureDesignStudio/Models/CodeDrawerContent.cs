﻿using AzureDesignStudio.Core.Models;

namespace AzureDesignStudio.Models
{
    public enum CodeDrawerContentType
    {
        Json = 0,
        Bicep
    }
    public class CodeDrawerContent
    {
        public CodeDrawerContentType Type { get; set; }
        public string Content { get; set; } = string.Empty;
        public IArmTemplate? ArmTemplate { get; set; } = default!;
    }
}
