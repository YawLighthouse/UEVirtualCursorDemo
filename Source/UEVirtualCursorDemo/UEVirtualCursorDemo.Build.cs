// Copyright 2020 by Nicholas Helish. All Rights Reserved.

using UnrealBuildTool;

public class UEVirtualCursorDemo : ModuleRules
{
	public UEVirtualCursorDemo(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "HeadMountedDisplay" });
	}
}
