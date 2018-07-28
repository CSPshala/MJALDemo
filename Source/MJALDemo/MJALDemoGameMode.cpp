// Copyright 1998-2018 Epic Games, Inc. All Rights Reserved.

#include "MJALDemoGameMode.h"
#include "MJALDemoCharacter.h"
#include "UObject/ConstructorHelpers.h"

AMJALDemoGameMode::AMJALDemoGameMode()
{
	// set default pawn class to our Blueprinted character
	static ConstructorHelpers::FClassFinder<APawn> PlayerPawnBPClass(TEXT("/Game/ThirdPersonCPP/Blueprints/MisfitCharacter"));
	if (PlayerPawnBPClass.Class != NULL)
	{
		DefaultPawnClass = PlayerPawnBPClass.Class;
	}
}
