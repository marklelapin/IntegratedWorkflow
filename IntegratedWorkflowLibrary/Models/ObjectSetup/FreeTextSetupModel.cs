using System;
using System.Collections.Generic;
using System.Text;

namespace IntegratedWorkflowLibrary.Models
{
    public class FreeTextSetupModel
    {
        /// <summary>
        ///  Title / Question to be added before Free Text form field
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Sets a character limit for the free text field
        /// </summary>
        public int MaxLength { get; set; }

        /// <summary>
        /// Specifies wether the answer to this is optional
        /// </summary>
        public bool IsOptional { get; set; } = false;

        public FreeTextSetupModel(string title,int maxLength, bool isOptional)
        {
            Title = title;
            MaxLength = maxLength;
            IsOptional = isOptional;

        }

    }
}
