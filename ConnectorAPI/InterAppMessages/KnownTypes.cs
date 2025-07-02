﻿// Ignore Spelling: Github App

namespace Skyline.DataMiner.ConnectorAPI.Github.Repositories.InterAppMessages
{
	using System;
	using System.Collections.Generic;

	using Skyline.DataMiner.ConnectorAPI.Github.Repositories.InterAppMessages.Repositories;
	using Skyline.DataMiner.ConnectorAPI.Github.Repositories.InterAppMessages.Workflows;
	using Skyline.DataMiner.Core.InterAppCalls.Common.CallSingle;

	/// <summary>
	/// Static class holding the types of the InterApp Messages.
	/// </summary>
	public static class Types
	{
		/// <summary>
		/// Gets a list of all the supported InterApp Message Types.
		/// </summary>
		public static List<Type> KnownTypes { get; } = new List<Type>
		{
			// Repositories
			typeof(GenericInterAppMessage<AddRepositoryRequest>),
			typeof(GenericInterAppMessage<AddRepositoryResponse>),
			typeof(GenericInterAppMessage<CreateRepositoryRequest>),
			typeof(GenericInterAppMessage<CreateRepositoryResponse>),
			typeof(GenericInterAppMessage<CreateRepositoryContentRequest>),
			typeof(GenericInterAppMessage<CreateRepositoryContentResponse>),
			typeof(GenericInterAppMessage<AddRepositoryCollaboratorRequest>),
			typeof(GenericInterAppMessage<AddRepositoryCollaboratorResponse>),
			typeof(GenericInterAppMessage<RemoveRepositoryRequest>),
			typeof(GenericInterAppMessage<RemoveRepositoryResponse>),
			typeof(GenericInterAppMessage<AddRepositoryTopicsRequest>),
			typeof(GenericInterAppMessage<AddRepositoryTopicsResponse>),
			typeof(GenericInterAppMessage<RemoveRepositoryTopicsRequest>),
			typeof(GenericInterAppMessage<RemoveRepositoryTopicsResponse>),

			// Workflows
			typeof(GenericInterAppMessage<AddWorkflowRequest>),
			typeof(GenericInterAppMessage<AddAutomationScriptCIWorkflowRequest>),
			typeof(GenericInterAppMessage<AddAutomationScriptCICDWorkflowRequest>),
			typeof(GenericInterAppMessage<AddConnectorCIWorkflowRequest>),
			typeof(GenericInterAppMessage<AddNugetCICDWorkflowRequest>),
			typeof(GenericInterAppMessage<AddInternalNugetCICDWorkflowRequest>),
			typeof(GenericInterAppMessage<AddCustomWorkflowRequest>),
			typeof(GenericInterAppMessage<AddWorkflowResponse>),
            typeof(GenericInterAppMessage<ExecuteWorkflowRequest>),
            typeof(GenericInterAppMessage<ExecuteWorkflowResponse>),
        };

		/// <summary>
		/// Gets a mapping between the supported InterApp Message requests and their response types.
		/// </summary>
		public static Dictionary<Type, Type> KnownTypeMapping { get; } = new Dictionary<Type, Type>
		{
			{ typeof(AddRepositoryRequest),                         typeof(AddRepositoryResponse) },
			{ typeof(CreateRepositoryRequest),                      typeof(CreateRepositoryResponse) },
			{ typeof(CreateRepositoryContentRequest),               typeof(CreateRepositoryContentResponse) },
			{ typeof(AddRepositoryCollaboratorRequest),             typeof(AddRepositoryCollaboratorResponse) },
			{ typeof(RemoveRepositoryRequest),                      typeof(RemoveRepositoryResponse) },
			{ typeof(AddRepositoryTopicsRequest),					typeof(AddRepositoryTopicsResponse) },
			{ typeof(RemoveRepositoryTopicsRequest),				typeof(RemoveRepositoryTopicsResponse) },

			{ typeof(AddWorkflowRequest),                           typeof(AddWorkflowResponse) },
			{ typeof(AddAutomationScriptCIWorkflowRequest),         typeof(AddWorkflowResponse) },
			{ typeof(AddAutomationScriptCICDWorkflowRequest),       typeof(AddWorkflowResponse) },
			{ typeof(AddConnectorCIWorkflowRequest),                typeof(AddWorkflowResponse) },
			{ typeof(AddNugetCICDWorkflowRequest),                  typeof(AddWorkflowResponse) },
			{ typeof(AddInternalNugetCICDWorkflowRequest),          typeof(AddWorkflowResponse) },
			{ typeof(AddCustomWorkflowRequest),						typeof(AddWorkflowResponse) },
            { typeof(ExecuteWorkflowRequest),						typeof(ExecuteWorkflowResponse) },
        };

		internal static Message ToMessage(IGithubMessage message)
		{
			switch (message)
			{
				case AddRepositoryRequest addRepositoryRequest:
					return new GenericInterAppMessage<AddRepositoryRequest>(addRepositoryRequest);

				case CreateRepositoryRequest createRepositoryRequest:
					return new GenericInterAppMessage<CreateRepositoryRequest>(createRepositoryRequest);

				case CreateRepositoryContentRequest createRepositoryContent:
					return new GenericInterAppMessage<CreateRepositoryContentRequest>(createRepositoryContent);

				case AddRepositoryCollaboratorRequest addRepositoryCollaboratorRequest:
					return new GenericInterAppMessage<AddRepositoryCollaboratorRequest>(addRepositoryCollaboratorRequest);

				case RemoveRepositoryRequest removeRepositoryRequest:
					return new GenericInterAppMessage<RemoveRepositoryRequest>(removeRepositoryRequest);

				case AddRepositoryTopicsRequest addRepositoryTopicsRequest:
					return new GenericInterAppMessage<AddRepositoryTopicsRequest>(addRepositoryTopicsRequest);

				case RemoveRepositoryTopicsRequest removeRepositoryTopicsRequest:
					return new GenericInterAppMessage<RemoveRepositoryTopicsRequest>(removeRepositoryTopicsRequest);

				case AddAutomationScriptCIWorkflowRequest addAutomationScriptCIWorkflowRequest:
					return new GenericInterAppMessage<AddAutomationScriptCIWorkflowRequest>(addAutomationScriptCIWorkflowRequest);

				case AddAutomationScriptCICDWorkflowRequest addAutomationScriptCICDWorkflowRequest:
					return new GenericInterAppMessage<AddAutomationScriptCICDWorkflowRequest>(addAutomationScriptCICDWorkflowRequest);

				case AddConnectorCIWorkflowRequest addConnectorCIWorkflowRequest:
					return new GenericInterAppMessage<AddConnectorCIWorkflowRequest>(addConnectorCIWorkflowRequest);

				case AddNugetCICDWorkflowRequest addNugetCICDWorkflowRequest:
					return new GenericInterAppMessage<AddNugetCICDWorkflowRequest>(addNugetCICDWorkflowRequest);

				case AddInternalNugetCICDWorkflowRequest addInternalNugetCICDWorkflowRequest:
					return new GenericInterAppMessage<AddInternalNugetCICDWorkflowRequest>(addInternalNugetCICDWorkflowRequest);

				case AddCustomWorkflowRequest addCustomWorkflowRequest:
					return new GenericInterAppMessage<AddCustomWorkflowRequest>(addCustomWorkflowRequest);

				case ExecuteWorkflowRequest executeWorkflowRequest:
                    return new GenericInterAppMessage<ExecuteWorkflowRequest>(executeWorkflowRequest);

                default:
					throw new InvalidOperationException("Unknown message type");
			}
		}
	
		internal static IGithubResponse FromMessage(Message message)
		{
			switch (message)
			{
				case GenericInterAppMessage<AddRepositoryResponse> addRepositoryResponse:
					return addRepositoryResponse.Data;

				case GenericInterAppMessage<CreateRepositoryResponse> createRepositoryResponse:
					return createRepositoryResponse.Data;

				case GenericInterAppMessage<CreateRepositoryContentResponse> createRepositoryContentResponse:
					return createRepositoryContentResponse.Data;

				case GenericInterAppMessage<AddRepositoryCollaboratorResponse> addRepositoryCollaboratorResponse:
					return addRepositoryCollaboratorResponse.Data;

				case GenericInterAppMessage<RemoveRepositoryResponse> addRepositoryResponse:
					return addRepositoryResponse.Data;

				case GenericInterAppMessage<AddRepositoryTopicsResponse> addRepositoryTopicsResponse:
					return addRepositoryTopicsResponse.Data;

				case GenericInterAppMessage<RemoveRepositoryTopicsResponse> removeRepositoryTopicsResponse:
					return removeRepositoryTopicsResponse.Data;

				case GenericInterAppMessage<AddWorkflowResponse> addRepositoryResponse:
					return addRepositoryResponse.Data;

                case GenericInterAppMessage<ExecuteWorkflowResponse> executeWorkflowResponse:
                    return executeWorkflowResponse.Data;

                default:
					throw new InvalidOperationException("Unknown message type");
			}
		}
	}
}
