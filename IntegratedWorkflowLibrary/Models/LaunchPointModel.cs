using System;
using System.Collections.Generic;
using System.Text;

namespace IntegratedWorkflowLibrary.Models
{
    public class LaunchPointModel
    {
       /// <summary>
       /// Launch Point ID
       /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// Name of Launch Point
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Boolean used to hide 'deleted' Launch Points
        /// </summary>
        public bool IsActive { get; set; }
    
        /// <summary>
        /// the data required for a Launch Point
        /// </summary>
        /// <param name="iD">0 if creating new Launch Point</param>
        /// <param name="title"></param>
        /// <param name="isActive"></param>
        public LaunchPointModel(int iD, string title, bool isActive)
        {
            ID = iD;
            Title = title;
            IsActive = isActive;
        }
    }
}
