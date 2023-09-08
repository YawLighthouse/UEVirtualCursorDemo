// Copyright 2020 by Nicholas Helish. All Rights Reserved.

#include "UEVirtualCursorDemoGameMode.h"
#include "UEVirtualCursorDemoCharacter.h"
#include "UObject/ConstructorHelpers.h"

AUEVirtualCursorDemoGameMode::AUEVirtualCursorDemoGameMode()
{
	// set default pawn class to our Blueprinted character
	static ConstructorHelpers::FClassFinder<APawn> PlayerPawnBPClass(TEXT("/Game/ThirdPersonCPP/Blueprints/ThirdPersonCharacter"));
	if (PlayerPawnBPClass.Class != NULL)
	{
		DefaultPawnClass = PlayerPawnBPClass.Class;
	}
}
