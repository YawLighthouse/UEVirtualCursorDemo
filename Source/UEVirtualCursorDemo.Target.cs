// Copyright 2020 by Nicholas Helish. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class UEVirtualCursorDemoTarget : TargetRules
{
	public UEVirtualCursorDemoTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		ExtraModuleNames.Add("UEVirtualCursorDemo");
	}
}
