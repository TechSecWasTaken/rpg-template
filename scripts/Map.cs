using Godot;
using System;
using System.Linq;

public partial class Map : Node2D
{
	public Vector2? room_center = null;
	public Player player;

    public override void _Ready()
    {
		GameManager.instance.current_map = this;
		
		GameManager.instance.player = GetNode<Player>("player");
		
		#nullable enable
		Marker2D? top_left = GetNode<Marker2D>("TOP_LEFT_CORNER");
		Marker2D? bottom_right = GetNode<Marker2D>("BOTTOM_RIGHT_CORNER");
		room_center = top_left.Position + ((bottom_right.Position - top_left.Position)/2);
    }
}
