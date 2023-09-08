// Copyright Epic Games, Inc. All Rights Reserved.

#include "UEVirtualCursorDemoGameMode.h"
#include "UEVirtualCursorDemoCharacter.h"
#include "UObject/ConstructorHelpers.h"

AUEVirtualCursorDemoGameMode::AUEVirtualCursorDemoGameMode()
{
	// set default pawn class to our Blueprinted character
	static ConstructorHelpers::FClassFinder<APawn> PlayerPawnBPClass(TEXT("/Game/ThirdPerson/Blueprints/BP_ThirdPersonCharacter"));
	if (PlayerPawnBPClass.Class != NULL)
	{
		DefaultPawnClass = PlayerPawnBPClass.Class;
	}
}
