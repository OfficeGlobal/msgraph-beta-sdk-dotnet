// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface ICallRequestBuilder.
    /// </summary>
    public partial interface ICallRequestBuilder : IEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new ICallRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new ICallRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for Participants.
        /// </summary>
        /// <returns>The <see cref="ICallParticipantsCollectionRequestBuilder"/>.</returns>
        ICallParticipantsCollectionRequestBuilder Participants { get; }

        /// <summary>
        /// Gets the request builder for AudioRoutingGroups.
        /// </summary>
        /// <returns>The <see cref="ICallAudioRoutingGroupsCollectionRequestBuilder"/>.</returns>
        ICallAudioRoutingGroupsCollectionRequestBuilder AudioRoutingGroups { get; }

        /// <summary>
        /// Gets the request builder for Operations.
        /// </summary>
        /// <returns>The <see cref="ICallOperationsCollectionRequestBuilder"/>.</returns>
        ICallOperationsCollectionRequestBuilder Operations { get; }
    
        /// <summary>
        /// Gets the request builder for CallAnswer.
        /// </summary>
        /// <returns>The <see cref="ICallAnswerRequestBuilder"/>.</returns>
        ICallAnswerRequestBuilder Answer(
            string callbackUri,
            MediaConfig mediaConfig,
            IEnumerable<Modality> acceptedModalities = null);

        /// <summary>
        /// Gets the request builder for CallCancelMediaProcessing.
        /// </summary>
        /// <returns>The <see cref="ICallCancelMediaProcessingRequestBuilder"/>.</returns>
        ICallCancelMediaProcessingRequestBuilder CancelMediaProcessing(
            bool? all = null,
            string clientContext = null);

        /// <summary>
        /// Gets the request builder for CallChangeScreenSharingRole.
        /// </summary>
        /// <returns>The <see cref="ICallChangeScreenSharingRoleRequestBuilder"/>.</returns>
        ICallChangeScreenSharingRoleRequestBuilder ChangeScreenSharingRole(
            ScreenSharingRole role);

        /// <summary>
        /// Gets the request builder for CallMute.
        /// </summary>
        /// <returns>The <see cref="ICallMuteRequestBuilder"/>.</returns>
        ICallMuteRequestBuilder Mute(
            string clientContext = null);

        /// <summary>
        /// Gets the request builder for CallPlayPrompt.
        /// </summary>
        /// <returns>The <see cref="ICallPlayPromptRequestBuilder"/>.</returns>
        ICallPlayPromptRequestBuilder PlayPrompt(
            IEnumerable<Prompt> prompts,
            string clientContext = null);

        /// <summary>
        /// Gets the request builder for CallRecognize.
        /// </summary>
        /// <returns>The <see cref="ICallRecognizeRequestBuilder"/>.</returns>
        ICallRecognizeRequestBuilder Recognize(
            IEnumerable<Prompt> prompts = null,
            bool? bargeInAllowed = null,
            string culture = null,
            Int32? initialSilenceTimeoutInSeconds = null,
            Int32? interDigitTimeoutInSeconds = null,
            IEnumerable<RecognitionOption> choices = null,
            CollectDigits collectDigits = null,
            string clientContext = null);

        /// <summary>
        /// Gets the request builder for CallRecord.
        /// </summary>
        /// <returns>The <see cref="ICallRecordRequestBuilder"/>.</returns>
        ICallRecordRequestBuilder Record(
            IEnumerable<Prompt> prompts = null,
            bool? bargeInAllowed = null,
            Int32? initialSilenceTimeoutInSeconds = null,
            Int32? maxSilenceTimeoutInSeconds = null,
            Int32? maxRecordDurationInSeconds = null,
            bool? playBeep = null,
            bool? streamWhileRecording = null,
            IEnumerable<string> stopTones = null,
            string clientContext = null);

        /// <summary>
        /// Gets the request builder for CallRedirect.
        /// </summary>
        /// <returns>The <see cref="ICallRedirectRequestBuilder"/>.</returns>
        ICallRedirectRequestBuilder Redirect(
            IEnumerable<InvitationParticipantInfo> targets,
            CallDisposition? targetDisposition = null,
            Int32? timeout = null,
            bool? maskCallee = null,
            bool? maskCaller = null);

        /// <summary>
        /// Gets the request builder for CallReject.
        /// </summary>
        /// <returns>The <see cref="ICallRejectRequestBuilder"/>.</returns>
        ICallRejectRequestBuilder Reject(
            RejectReason? reason = null);

        /// <summary>
        /// Gets the request builder for CallSubscribeToTone.
        /// </summary>
        /// <returns>The <see cref="ICallSubscribeToToneRequestBuilder"/>.</returns>
        ICallSubscribeToToneRequestBuilder SubscribeToTone(
            string clientContext = null);

        /// <summary>
        /// Gets the request builder for CallTransfer.
        /// </summary>
        /// <returns>The <see cref="ICallTransferRequestBuilder"/>.</returns>
        ICallTransferRequestBuilder Transfer(
            InvitationParticipantInfo transferTarget = null,
            IdentitySet target = null,
            string replacesCallId = null);

        /// <summary>
        /// Gets the request builder for CallUnmute.
        /// </summary>
        /// <returns>The <see cref="ICallUnmuteRequestBuilder"/>.</returns>
        ICallUnmuteRequestBuilder Unmute(
            string clientContext = null);

        /// <summary>
        /// Gets the request builder for CallUpdateMetadata.
        /// </summary>
        /// <returns>The <see cref="ICallUpdateMetadataRequestBuilder"/>.</returns>
        ICallUpdateMetadataRequestBuilder UpdateMetadata(
            string metadata = null,
            string clientContext = null);
    
    }
}
