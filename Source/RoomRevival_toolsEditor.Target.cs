// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class RoomRevival_toolsEditorTarget : TargetRules
{
	public RoomRevival_toolsEditorTarget(TargetInfo Target) : base(Target)
	{
        DefaultBuildSettings = BuildSettingsVersion.Latest; // V5
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;

        Type = TargetType.Editor;
        ExtraModuleNames.AddRange(new string[] { "RoomRevival_tools" });
		//bUseUnityBuild = false;
		//bUsePCHFiles = false;
    }

	//
	// TargetRules interface.
	//

/*	public override void SetupBinaries(
		TargetInfo Target,
		ref List<UEBuildBinaryConfiguration> OutBuildBinaryConfigurations,
		ref List<string> OutExtraModuleNames
		)
	{
		OutExtraModuleNames.AddRange( new string[] { "RoomRevival_tools" } );
	}*/
}
