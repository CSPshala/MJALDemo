// Copyright 1998-2017 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class MJALDemo : ModuleRules
{
	public MJALDemo(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

        //////////////////////
        // :MJREADME:
        // Add MJAssetLibrary to public dependency modules, add /Classes to include paths\
        // This is not needed if just using the blueprintable version of the AssetLibrary, C++ cool kids only
        //
        // :USERTODO:
        // 1) Uncomment comments in code and any commented lines below
        // 2) Open MJALDemoCharacter.cpp and find :USERTODO:

        PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "HeadMountedDisplay"/*, "MJAssetLibrary"*/});
        //PublicIncludePaths.AddRange(new string[] { "MJAssetLibrary/Classes" });
    }
}
