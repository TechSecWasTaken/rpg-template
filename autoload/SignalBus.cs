using Godot;
using Godot.Collections;
using System;

[GlobalClass]
public partial class SignalBus : Node
{
	public static SignalBus instance {get; private set;}
    public override void _Ready() { instance = this; }

    /* DIALOGUE SIGNALS */
	[Signal] public delegate void DialogueOpenedEventHandler();
    [Signal] public delegate void DialogueClosedEventHandler();

    /* TOP DOWN PLAYER SIGNALS */
    [Signal] public delegate void PlayerMovedEventHandler();

    /* BATTLE SIGNALS */
    [Signal] public delegate void OnBattleStartEventHandler();
    [Signal] public delegate void OnBattleEndEventHandler();
    [Signal] public delegate void TurnChangedEventHandler(int turn);
    [Signal] public delegate void OnLevelUpEventHandler(Dictionary party_member);
    [Signal] public delegate void OnNewSkillEventHandler(string skill_name);
}
