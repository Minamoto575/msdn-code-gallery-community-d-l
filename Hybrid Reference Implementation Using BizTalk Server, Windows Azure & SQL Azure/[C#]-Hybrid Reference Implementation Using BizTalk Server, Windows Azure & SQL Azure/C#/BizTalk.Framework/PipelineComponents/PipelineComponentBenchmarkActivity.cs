﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 2.0.50727.42
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------
namespace Contoso.Cloud.Integration.BizTalk.Core.PipelineComponents
{
    #region Using Statements
    using System;
    using System.Runtime.CompilerServices;

    using Contoso.Cloud.Integration.Framework.ActivityTracking;
    #endregion

    /// <summary>
    /// Provides a strongly type class for BAM activity PipelineComponentBenchmarkActivity.
    /// </summary>
    [Serializable]
    [CompilerGenerated]
    public partial class PipelineComponentBenchmarkActivity : ActivityBase
    {
        /// <summary>
        /// Defines the name of the BAM activity.
        /// </summary>
        private const string activityName = "PipelineComponentBenchmarkActivity";

        #region Activity item names

        /// <summary>
        /// The activity item name
        /// </summary>
        public const string ComponentNameFieldName = "ComponentName";

        /// <summary>
        /// The activity item name
        /// </summary>
        public const string PipelineIDFieldName = "PipelineID";

        /// <summary>
        /// The activity item name
        /// </summary>
        public const string StageIDFieldName = "StageID";

        /// <summary>
        /// The activity item name
        /// </summary>
        public const string MachineNameFieldName = "MachineName";

        /// <summary>
        /// The activity item name
        /// </summary>
        public const string WindowsIdentityNameFieldName = "WindowsIdentityName";

        /// <summary>
        /// The activity item name
        /// </summary>
        public const string ExecuteStartedFieldName = "ExecuteStarted";

        /// <summary>
        /// The activity item name
        /// </summary>
        public const string ExecuteCompletedFieldName = "ExecuteCompleted";

        /// <summary>
        /// The activity item name
        /// </summary>
        public const string DisassembleStartedFieldName = "DisassembleStarted";

        /// <summary>
        /// The activity item name
        /// </summary>
        public const string DisassembleCompletedFieldName = "DisassembleCompleted";

        /// <summary>
        /// The activity item name
        /// </summary>
        public const string GetNextStartedFieldName = "GetNextStarted";

        /// <summary>
        /// The activity item name
        /// </summary>
        public const string GetNextCompletedFieldName = "GetNextCompleted";

        /// <summary>
        /// The activity item name
        /// </summary>
        public const string AssembleStartedFieldName = "AssembleStarted";

        /// <summary>
        /// The activity item name
        /// </summary>
        public const string AssembleCompletedFieldName = "AssembleCompleted";

        /// <summary>
        /// The activity item name
        /// </summary>
        public const string ProbeStartedFieldName = "ProbeStarted";

        /// <summary>
        /// The activity item name
        /// </summary>
        public const string ProbeCompletedFieldName = "ProbeCompleted";

        /// <summary>
        /// The activity item name
        /// </summary>
        public const string AddDocumentStartedFieldName = "AddDocumentStarted";

        /// <summary>
        /// The activity item name
        /// </summary>
        public const string AddDocumentCompletedFieldName = "AddDocumentCompleted";

        /// <summary>
        /// The activity item name
        /// </summary>
        public const string AssembleDurationMsFieldName = "AssembleDurationMs";

        /// <summary>
        /// The activity item name
        /// </summary>
        public const string DisassembleDurationMsFieldName = "DisassembleDurationMs";

        /// <summary>
        /// The activity item name
        /// </summary>
        public const string ExecuteDurationMsFieldName = "ExecuteDurationMs";

        /// <summary>
        /// The activity item name
        /// </summary>
        public const string GetNextDurationMsFieldName = "GetNextDurationMs";

        /// <summary>
        /// The activity item name
        /// </summary>
        public const string ProbeDurationMsFieldName = "ProbeDurationMs";

        /// <summary>
        /// The activity item name
        /// </summary>
        public const string AddDocumentDurationMsFieldName = "AddDocumentDurationMs";

        #endregion


        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineComponentBenchmarkActivity" /> using the specified BAM activity ID.
        /// </summary>
        /// <param name="activityID">The ID of the BAM activity.</param>
        public PipelineComponentBenchmarkActivity(string activityID)
        {
            this.ActivityID = activityID;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineComponentBenchmarkActivity" /> using the specified BAM activity ID and continuation token.
        /// </summary>
        /// <param name="activityID">The ID of the BAM activity.</param>
        /// <param name="continuationToken">A continuation token that is used to correlate heterogeneous information within the BAM infrastructure.</param>
        public PipelineComponentBenchmarkActivity(string activityID, string continuationToken)
        {
            this.ActivityID = activityID;
            this.ContinuationToken = continuationToken;
        }

        #endregion

        #region Public properties
        /// <summary>
        /// The activity name as defined in the BAM Excel spreadsheet.
        /// </summary>
        public override string ActivityName
        {
            get
            {
                return activityName;
            }
        }


        /// <summary>
        /// Business milestone or business data.
        /// </summary>
        public string ComponentName
        {
            get
            {
                string value = (string)this.ActivityData[ComponentNameFieldName];

                return value;
            }
            set
            {
                this.ActivityData[ComponentNameFieldName] = value;
            }
        }

        /// <summary>
        /// Business milestone or business data.
        /// </summary>
        public string PipelineID
        {
            get
            {
                string value = (string)this.ActivityData[PipelineIDFieldName];

                return value;
            }
            set
            {
                this.ActivityData[PipelineIDFieldName] = value;
            }
        }

        /// <summary>
        /// Business milestone or business data.
        /// </summary>
        public string StageID
        {
            get
            {
                string value = (string)this.ActivityData[StageIDFieldName];

                return value;
            }
            set
            {
                this.ActivityData[StageIDFieldName] = value;
            }
        }

        /// <summary>
        /// Business milestone or business data.
        /// </summary>
        public string MachineName
        {
            get
            {
                string value = (string)this.ActivityData[MachineNameFieldName];

                return value;
            }
            set
            {
                this.ActivityData[MachineNameFieldName] = value;
            }
        }

        /// <summary>
        /// Business milestone or business data.
        /// </summary>
        public string WindowsIdentityName
        {
            get
            {
                string value = (string)this.ActivityData[WindowsIdentityNameFieldName];

                return value;
            }
            set
            {
                this.ActivityData[WindowsIdentityNameFieldName] = value;
            }
        }

        /// <summary>
        /// Business milestone or business data.
        /// </summary>
        public DateTime ExecuteStarted
        {
            get
            {
                DateTime value = (DateTime)this.ActivityData[ExecuteStartedFieldName];

                return value;
            }
            set
            {
                this.ActivityData[ExecuteStartedFieldName] = value;
            }
        }

        /// <summary>
        /// Business milestone or business data.
        /// </summary>
        public DateTime ExecuteCompleted
        {
            get
            {
                DateTime value = (DateTime)this.ActivityData[ExecuteCompletedFieldName];

                return value;
            }
            set
            {
                this.ActivityData[ExecuteCompletedFieldName] = value;
            }
        }

        /// <summary>
        /// Business milestone or business data.
        /// </summary>
        public DateTime DisassembleStarted
        {
            get
            {
                DateTime value = (DateTime)this.ActivityData[DisassembleStartedFieldName];

                return value;
            }
            set
            {
                this.ActivityData[DisassembleStartedFieldName] = value;
            }
        }

        /// <summary>
        /// Business milestone or business data.
        /// </summary>
        public DateTime DisassembleCompleted
        {
            get
            {
                DateTime value = (DateTime)this.ActivityData[DisassembleCompletedFieldName];

                return value;
            }
            set
            {
                this.ActivityData[DisassembleCompletedFieldName] = value;
            }
        }

        /// <summary>
        /// Business milestone or business data.
        /// </summary>
        public DateTime GetNextStarted
        {
            get
            {
                DateTime value = (DateTime)this.ActivityData[GetNextStartedFieldName];

                return value;
            }
            set
            {
                this.ActivityData[GetNextStartedFieldName] = value;
            }
        }

        /// <summary>
        /// Business milestone or business data.
        /// </summary>
        public DateTime GetNextCompleted
        {
            get
            {
                DateTime value = (DateTime)this.ActivityData[GetNextCompletedFieldName];

                return value;
            }
            set
            {
                this.ActivityData[GetNextCompletedFieldName] = value;
            }
        }

        /// <summary>
        /// Business milestone or business data.
        /// </summary>
        public DateTime AssembleStarted
        {
            get
            {
                DateTime value = (DateTime)this.ActivityData[AssembleStartedFieldName];

                return value;
            }
            set
            {
                this.ActivityData[AssembleStartedFieldName] = value;
            }
        }

        /// <summary>
        /// Business milestone or business data.
        /// </summary>
        public DateTime AssembleCompleted
        {
            get
            {
                DateTime value = (DateTime)this.ActivityData[AssembleCompletedFieldName];

                return value;
            }
            set
            {
                this.ActivityData[AssembleCompletedFieldName] = value;
            }
        }

        /// <summary>
        /// Business milestone or business data.
        /// </summary>
        public DateTime ProbeStarted
        {
            get
            {
                DateTime value = (DateTime)this.ActivityData[ProbeStartedFieldName];

                return value;
            }
            set
            {
                this.ActivityData[ProbeStartedFieldName] = value;
            }
        }

        /// <summary>
        /// Business milestone or business data.
        /// </summary>
        public DateTime ProbeCompleted
        {
            get
            {
                DateTime value = (DateTime)this.ActivityData[ProbeCompletedFieldName];

                return value;
            }
            set
            {
                this.ActivityData[ProbeCompletedFieldName] = value;
            }
        }

        /// <summary>
        /// Business milestone or business data.
        /// </summary>
        public DateTime AddDocumentStarted
        {
            get
            {
                DateTime value = (DateTime)this.ActivityData[AddDocumentStartedFieldName];

                return value;
            }
            set
            {
                this.ActivityData[AddDocumentStartedFieldName] = value;
            }
        }

        /// <summary>
        /// Business milestone or business data.
        /// </summary>
        public DateTime AddDocumentCompleted
        {
            get
            {
                DateTime value = (DateTime)this.ActivityData[AddDocumentCompletedFieldName];

                return value;
            }
            set
            {
                this.ActivityData[AddDocumentCompletedFieldName] = value;
            }
        }

        /// <summary>
        /// Business milestone or business data.
        /// </summary>
        public double AssembleDurationMs
        {
            get
            {
                double value = (double)this.ActivityData[AssembleDurationMsFieldName];

                return value;
            }
            set
            {
                this.ActivityData[AssembleDurationMsFieldName] = value;
            }
        }

        /// <summary>
        /// Business milestone or business data.
        /// </summary>
        public double DisassembleDurationMs
        {
            get
            {
                double value = (double)this.ActivityData[DisassembleDurationMsFieldName];

                return value;
            }
            set
            {
                this.ActivityData[DisassembleDurationMsFieldName] = value;
            }
        }

        /// <summary>
        /// Business milestone or business data.
        /// </summary>
        public double ExecuteDurationMs
        {
            get
            {
                double value = (double)this.ActivityData[ExecuteDurationMsFieldName];

                return value;
            }
            set
            {
                this.ActivityData[ExecuteDurationMsFieldName] = value;
            }
        }

        /// <summary>
        /// Business milestone or business data.
        /// </summary>
        public double GetNextDurationMs
        {
            get
            {
                double value = (double)this.ActivityData[GetNextDurationMsFieldName];

                return value;
            }
            set
            {
                this.ActivityData[GetNextDurationMsFieldName] = value;
            }
        }

        /// <summary>
        /// Business milestone or business data.
        /// </summary>
        public double ProbeDurationMs
        {
            get
            {
                double value = (double)this.ActivityData[ProbeDurationMsFieldName];

                return value;
            }
            set
            {
                this.ActivityData[ProbeDurationMsFieldName] = value;
            }
        }

        /// <summary>
        /// Business milestone or business data.
        /// </summary>
        public double AddDocumentDurationMs
        {
            get
            {
                double value = (double)this.ActivityData[AddDocumentDurationMsFieldName];

                return value;
            }
            set
            {
                this.ActivityData[AddDocumentDurationMsFieldName] = value;
            }
        }

        #endregion
    }

}
