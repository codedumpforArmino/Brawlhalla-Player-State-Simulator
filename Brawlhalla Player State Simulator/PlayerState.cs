using System;
using System.ComponentModel;


public class PlayerState
{
	int currentStateValue;
    DiscreteState currentState;

    public enum DiscreteState {
        Grounded,
        FloatWithoutDodge,
        FloatWithoutRecovery,
        Exhausted
    }

    int[,] FSMtable = {
        { 0, 1, 0, 0 },
        { 0, 2, 4, 7 },
        { 0, 3, 5, 8 },
        { 0, 3, 6, 9 },
        { 0, 5, 4, 10 },
        { 0, 6, 5, 11 },
        { 0, 6, 6, 12 },
        { 0, 8, 10, 8 },
        { 0, 9, 11, 9 },
        { 0, 9, 12, 9 },
        { 0, 11, 10, 10 },
        { 0, 12, 11, 11 },
        { 0, 12, 12, 12 }
    };


    public PlayerState()
	{
		currentStateValue = 0;
        currentState = DiscreteState.Grounded;
	}

	public int getNextState(int input)
	{
        currentStateValue = FSMtable[currentStateValue, input];

        switch (currentStateValue) {
            case 4:
            case 5:
            case 6:
                currentState = DiscreteState.FloatWithoutDodge;
                break;
            case 7:
            case 8:
            case 9:
                currentState = DiscreteState.FloatWithoutRecovery;
                break;
            case 10:
            case 11:
            case 12:
                currentState = DiscreteState.Exhausted;
                break;
            default:
                currentState = DiscreteState.Grounded;
                break;
        }

        return currentStateValue;
	}

    public String GetDiscreteStateDescription()
    {
        return currentState.ToString();
    }
}
