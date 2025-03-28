using Godot;
using System;

[GlobalClass]
public partial class GameManager : Node
{
	public static GameManager instance {get; private set;}
    public override void _Ready() { instance = this; }

	public Map current_map { get; set; }
    public Player player { get; set; }
}
