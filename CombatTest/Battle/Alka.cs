using Godot;
using System;

public partial class Alka : Node2D
{
	[Signal] public delegate void SubmitMoveEventHandler();
	private Godot.Button submit;
	public override void _Ready()
	{
		base._Ready();

 		submit = GetNode<Godot.Button>("Submit");
		submit.Pressed += SubmitPressed;
	}
	private void SubmitPressed()
	{
		submit.Disabled = true;
		EmitSignal("SubmitMove");

		GD.Print($"Submitted for {this.Name}");
	}
}
