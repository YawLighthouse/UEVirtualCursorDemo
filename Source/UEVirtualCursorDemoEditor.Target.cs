// Copyright 2020 by Nicholas Helish. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class UEVirtualCursorDemoEditorTarget : TargetRules
{
	public UEVirtualCursorDemoEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		ExtraModuleNames.Add("UEVirtualCursorDemo");
	}
}
