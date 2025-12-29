// Copyright Epic Games, Inc. All Rights Reserved.

#include "SpaceProjectGameMode.h"
#include "SpaceProjectCharacter.h"
#include "UObject/ConstructorHelpers.h"

ASpaceProjectGameMode::ASpaceProjectGameMode()
{
	// set default pawn class to our Blueprinted character
	static ConstructorHelpers::FClassFinder<APawn> PlayerPawnBPClass(TEXT("/Game/ThirdPerson/Blueprints/BP_ThirdPersonCharacter"));
	if (PlayerPawnBPClass.Class != NULL)
	{
		DefaultPawnClass = PlayerPawnBPClass.Class;
	}
}
