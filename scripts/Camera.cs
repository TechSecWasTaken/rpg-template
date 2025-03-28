using Godot;
using System;

public partial class Camera : Camera2D
{
	public override void _Process(double delta)
	{
		var player = GameManager.instance.player;
		var player_sprites = player.GetNode<AnimatedSprite2D>("AnimatedSprite2D");

		Position = player.Position + player_sprites.Position;
		if (GameManager.instance.current_map.room_center != null) {
			Position = Position.Clamp(GetNode<Marker2D>("TOP_LEFT_CORNER").Position, GetNode<Marker2D>("BOTTOM_RIGHT_CORNER").Position);
		}
	}
}
