using Godot;
using System;

public partial class PlayerSpritesHandler : AnimatedSprite2D
{
	[Export]
	private Player player;
	private Vector2 previous_input = Vector2.Zero;
	private string curAnimation = "idle_down";

	public override void _Process(double delta)
	{
		if (player.moving) {
			if (player.input_dir == Vector2.Left) curAnimation = "left";
			if (player.input_dir == Vector2.Right) curAnimation = "right";
			if (player.input_dir == Vector2.Up) curAnimation = "up";
			if (player.input_dir == Vector2.Down) curAnimation = "down";
			previous_input = player.input_dir;
		}
		else {
			if (previous_input == Vector2.Left) curAnimation = "idle_left";
			if (previous_input == Vector2.Right) curAnimation = "idle_right";
			if (previous_input == Vector2.Up) curAnimation = "idle_up";
			if (previous_input == Vector2.Down) curAnimation = "idle_down";
		}
		Play(curAnimation);
		
		//GD.Print(curAnimation);
	}
}
