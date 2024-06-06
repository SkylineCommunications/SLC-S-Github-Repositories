// Ignore Spelling: Github App

namespace Skyline.DataMiner.ConnectorAPI.Github.Repositories.InterAppMessages.Repositories
{
	using System.ComponentModel;

	using Skyline.DataMiner.ConnectorAPI.Github.Repositories.Attributes;

	/// <summary>
	/// Represents the method used for updating.
	/// </summary>
	public enum UpdateMethod
	{
		/// <summary>
		/// Indicates that the update will be performed with raw data.
		/// </summary>
		Raw,

		/// <summary>
		/// Indicates that the update will be performed using a file.
		/// </summary>
		File,
	}

	/// <summary>
	/// Represents the type of collaborator used when adding a new one.
	/// </summary>
	public enum CollaboratorType
	{
		/// <summary>
		/// Indicates that the collaborator is an individual user.
		/// </summary>
		User,

		/// <summary>
		/// Indicates that the collaborator is a team.
		/// </summary>
		Team,
	}

	/// <summary>
	/// Represents the permission types that can be granted to a collaborator on a GitHub repository.
	/// </summary>
	public enum PermissionType
	{
		/// <summary>
		/// Grants read-only access to the repository.
		/// </summary>
		Read,

		/// <summary>
		/// Grants the ability to triage issues and pull requests.
		/// </summary>
		Triage,

		/// <summary>
		/// Grants write access to the repository, allowing the collaborator to push to the repository.
		/// </summary>
		Write,

		/// <summary>
		/// Grants maintain access to the repository, allowing the collaborator to push, merge, and manage releases.
		/// </summary>
		Maintain,

		/// <summary>
		/// Grants full administrative access to the repository, allowing the collaborator to manage repository settings and permissions.
		/// </summary>
		Admin
	}

	/// <summary>
	/// Represents the different types of DataMiner repositories.
	/// </summary>
	public enum RepositoryType
	{
		/// <summary>
		/// Indicates that the repository contains a DataMiner Connector.
		/// </summary>
		[ShortDescription("C")]
		[Description("Connector")]
		Connector,

		/// <summary>
		/// Indicates that the repository contains a Visio.
		/// </summary>
		[ShortDescription("V")]
		[Description("Visio")]
		Visio,

		/// <summary>
		/// Indicates that the repository contains a .NET solution.
		/// </summary>
		[ShortDescription("S")]
		[Description("Solution")]
		Solution,

		/// <summary>
		/// Indicates that the repository contains a DataMiner Function.
		/// </summary>
		[ShortDescription("F")]
		[Description("Function")]
		Function,

		/// <summary>
		/// Indicates that the repository contains a DataMiner Automation Script.
		/// </summary>
		[ShortDescription("AS")]
		[Description("Automation Script")]
		Automation_Script,

		/// <summary>
		/// Indicates that the repository contains a DataMiner Dashboard.
		/// </summary>
		[ShortDescription("D")]
		[Description("Dashboard")]
		Dashboard,

		/// <summary>
		/// Indicates that the repository contains a DataMiner Profile Load Script.
		/// </summary>
		[ShortDescription("PLS")]
		[Description("Profile-Load Script")]
		Profile_Load_Script,

		/// <summary>
		/// Indicates that the repository contains a DataMiner Process Automation Script.
		/// </summary>
		[ShortDescription("PA")]
		[Description("Process Automation")]
		Process_Automation_Script,

		/// <summary>
		/// Indicates that the repository contains a DataMiner Life Service Orchestration.
		/// </summary>
		[ShortDescription("LSO")]
		[Description("Life cycle Service Orchestration")]
		Life_Service_Orchestration,

		/// <summary>
		/// Indicates that the repository contains a DataMiner GQI Data Source.
		/// </summary>
		[ShortDescription("GQIDS")]
		[Description("GQI Data Source")]
		GQI_Data_Source,

		/// <summary>
		/// Indicates that the repository contains a DataMiner GQI Operator.
		/// </summary>
		[ShortDescription("GQIO")]
		[Description("GQI Operator")]
		GQI_Operator,

		/// <summary>
		/// Indicates that the repository contains a DataMiner Test Solution.
		/// </summary>
		[ShortDescription("T")]
		[Description("Tests")]
		Tests,

		/// <summary>
		/// Indicates that the repository contains a DataMiner User-Defined API.
		/// </summary>
		[ShortDescription("UDAPI")]
		[Description("User-Defined API")]
		User_Defined_API,

		/// <summary>
		/// Indicates that the repository contains a Documentation files.
		/// </summary>
		[ShortDescription("DOC")]
		[Description("Documentation")]
		Doc,

		/// <summary>
		/// Indicates that the repository contains a DataMiner Integration Studio Macro.
		/// </summary>
		[ShortDescription("DISMACRO")]
		[Description("DIS Macro")]
		DIS_Macro,

		/// <summary>
		/// Indicates that the repository contains a DataMiner ChatOps solution.
		/// </summary>
		[ShortDescription("CHATOPS")]
		[Description("ChatOps")]
		ChatOps,

		/// <summary>
		/// Indicates that the repository contains a DataMiner Nuget Package.
		/// </summary>
		[ShortDescription("S")]
		[Description("Nuget")]
		Nuget,

		/// <summary>
		/// Indicates that the repository contains a DataMiner Scripted Connector.
		/// </summary>
		[ShortDescription("SC")]
		[Description("Scripted Connector")]
		Scripted_Connector,
	}

	/// <summary>
	/// Represents the diffrent types of RepositoryTopic a DataMiner repository can have.
	/// </summary>
	public enum RepositoryTopic
	{
		/// <summary>
		/// The default 'dataminer' topic.
		/// </summary>
		[Description("dataminer")]
		DataMiner,

		/// <summary>
		/// The topic a Connector Repository should have.
		/// </summary>
		[Description("dataminer-connector")]
		DataMiner_Connector,

		/// <summary>
		/// The topic a Visio Repository should have.
		/// </summary>
		[Description("dataminer-visio")]
		DataMiner_Visio,

		/// <summary>
		/// The topic a Solution Repository should have.
		/// </summary>
		[Description("dataminer-solution")]
		DataMiner_Solution,

		/// <summary>
		/// The topic a Function Repository should have.
		/// </summary>
		[Description("dataminer-function")]
		DataMiner_Function,

		/// <summary>
		/// The topic a Automation Script Repository should have.
		/// </summary>
		[Description("dataminer-automation-script")]
		DataMiner_Automation_Script,

		/// <summary>
		/// The topic a Dashboard Repository should have.
		/// </summary>
		[Description("dataminer-dashboard")]
		DataMiner_Dashboard,

		/// <summary>
		/// The topic a Profile Load Script Repository should have.
		/// </summary>
		[Description("dataminer-profile-load-script")]
		DataMiner_Profile_Load_Script,

		/// <summary>
		/// The topic a Process Automation Script Repository should have.
		/// </summary>
		[Description("dataminer-process-automation-script")]
		DataMiner_Process_Automation_Script,

		/// <summary>
		/// The topic a Life Service Orchestration Repository should have.
		/// </summary>
		[Description("dataminer-life-service-orchestration")]
		DataMiner_Life_Service_Orchestration,

		/// <summary>
		/// The topic a GQI Data Source Repository should have.
		/// </summary>
		[Description("dataminer-gqi-data-source")]
		DataMiner_GQI_Data_Source,

		/// <summary>
		/// The topic a GQI Operator Repository should have.
		/// </summary>
		[Description("dataminer-gqi-operator")]
		DataMiner_GQI_Operator,

		/// <summary>
		/// The topic a Regression Test Repository should have.
		/// </summary>
		[Description("dataminer-regression-test")]
		DataMiner_Regression_Test,

		/// <summary>
		/// The topic a UI Test Repository should have.
		/// </summary>
		[Description("dataminer-UI-test")]
		DataMiner_UI_Test,

		/// <summary>
		/// The topic a DataMienr Bot Repository should have.
		/// </summary>
		[Description("dataminer-bot")]
		DataMiner_Bot,

		/// <summary>
		/// The topic a User-Defined API Repository should have.
		/// </summary>
		[Description("dataminer-user-defined-api")]
		DataMiner_User_Defined_API,

		/// <summary>
		/// The topic a Documentation Repository should have.
		/// </summary>
		[Description("dataminer-doc")]
		DataMiner_Doc,

		/// <summary>
		/// The topic a DataMiner Integration Studio Macro Repository should have.
		/// </summary>
		[Description("dataminer-dis-macro")]
		DataMiner_DIS_Macro,

		/// <summary>
		/// The topic a ChatOps Repository should have.
		/// </summary>
		[Description("dataminer-chatops")]
		DataMiner_ChatOps,

		/// <summary>
		/// The topic a Nuget Repository should have.
		/// </summary>
		[Description("dataminer-nuget")]
		DataMiner_Nuget,
	}
}
