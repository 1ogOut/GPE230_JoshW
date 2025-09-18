// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class GPE230JoshW : ModuleRules
{
	public GPE230JoshW(ReadOnlyTargetRules Target) : base(Target)
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
			"GPE230JoshW",
			"GPE230JoshW/Variant_Platforming",
			"GPE230JoshW/Variant_Platforming/Animation",
			"GPE230JoshW/Variant_Combat",
			"GPE230JoshW/Variant_Combat/AI",
			"GPE230JoshW/Variant_Combat/Animation",
			"GPE230JoshW/Variant_Combat/Gameplay",
			"GPE230JoshW/Variant_Combat/Interfaces",
			"GPE230JoshW/Variant_Combat/UI",
			"GPE230JoshW/Variant_SideScrolling",
			"GPE230JoshW/Variant_SideScrolling/AI",
			"GPE230JoshW/Variant_SideScrolling/Gameplay",
			"GPE230JoshW/Variant_SideScrolling/Interfaces",
			"GPE230JoshW/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
