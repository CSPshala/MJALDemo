// Copyright 1998-2018 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.IO;

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
        // 1) Nothing to do here, the installed marketplace plugin is included in the build below
        // 2) Open MJALDemoCharacter.cpp and find :USERTODO: to see a static library

        PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "HeadMountedDisplay", "MJAssetLibrary"});
        PublicIncludePaths.AddRange(new string[] { });
        PublicIncludePaths.Add(Path.GetFullPath(Path.Combine(EngineDirectory, "Plugins/Marketplace/MJAssetLibrary/Source/MJAssetLibrary/Public")));
    }
}
