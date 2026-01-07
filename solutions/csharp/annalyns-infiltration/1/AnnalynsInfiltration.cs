static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake) => knightIsAwake ? false : true;

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake) => knightIsAwake || prisonerIsAwake || archerIsAwake ? true : false;

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake) 
        => prisonerIsAwake && !archerIsAwake ? true : false;

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
        => (petDogIsPresent && !archerIsAwake) || (!petDogIsPresent && prisonerIsAwake && !knightIsAwake && !archerIsAwake);
}
