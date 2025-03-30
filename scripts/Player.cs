using Godot;
using Godot.Collections;

public partial class Player : Area2D
{
	[Export]
	public float move_dist = 8.0f;
	[Export]
	public double speed = 0.2;

	public Vector2 input_dir = Vector2.Zero;
	public bool moving = false;
	private bool isWall = false;
	public override void _Process(double delta)
	{	
		RayCast2D ray = GetNode<RayCast2D>("RayCast2D");
		var collision = ray.GetCollider();

		if (Input.IsActionPressed("move_up")) input_dir = Vector2.Up;
		else if (Input.IsActionPressed("move_down")) input_dir = Vector2.Down;
		else if (Input.IsActionPressed("move_left")) input_dir = Vector2.Left;
		else if (Input.IsActionPressed("move_right")) input_dir = Vector2.Right;

		if (input_dir != Vector2.Zero) {
			ray.Rotation=Vector2.Zero.AngleToPoint(input_dir) - Mathf.DegToRad(90);
		}

		if (!moving) { 
			move(); 
		}
		
		GD.Print(input_dir);
	}

	void move() {
		if (isWall) return;
		if (input_dir != Vector2.Zero)
			if (!moving) {
				moving = true;
				Tween tween = CreateTween();
				tween.TweenProperty(this, "position", Position+input_dir*move_dist, speed);
				Callable stop_moving = Callable.From(() => cancel_move());
				tween.TweenCallback(stop_moving);
			}
	}

	private void cancel_move() { 
		moving=false;
		input_dir = Vector2.Zero;
	}
}