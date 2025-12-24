// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class TeamSpace : ModuleRules
{
	public TeamSpace(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"TeamSpace",
			"TeamSpace/Variant_Platforming",
			"TeamSpace/Variant_Platforming/Animation",
			"TeamSpace/Variant_Combat",
			"TeamSpace/Variant_Combat/AI",
			"TeamSpace/Variant_Combat/Animation",
			"TeamSpace/Variant_Combat/Gameplay",
			"TeamSpace/Variant_Combat/Interfaces",
			"TeamSpace/Variant_Combat/UI",
			"TeamSpace/Variant_SideScrolling",
			"TeamSpace/Variant_SideScrolling/AI",
			"TeamSpace/Variant_SideScrolling/Gameplay",
			"TeamSpace/Variant_SideScrolling/Interfaces",
			"TeamSpace/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
