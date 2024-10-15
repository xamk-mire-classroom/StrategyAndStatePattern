using StrategyAndStatePattern;

class Program
{
    static void Main(string[] args)
    {
        // Create character with initial state
        Character character = new Character(new IdleState());

        // Switch to Action State and set action strategy
        character.SetActionStrategy(new MeleeAction()); // Set strategy first
        character.ChangeState(new ActionState()); // Then change state
        character.PerformAction(); // This should work fine now

        // Switch to Defending State
        character.ChangeState(new DefendingState());
        character.PerformAction(); // Cannot perform action in defending state

        // Switch back to Action State with a different strategy
        character.SetActionStrategy(new HealAction()); // Set a new strategy
        character.ChangeState(new ActionState());
        character.PerformAction(); // This should work as expected now
    }
}

