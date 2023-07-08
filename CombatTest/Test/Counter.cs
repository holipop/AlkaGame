using Godot;
using System;

public partial class Counter : Label
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	public void OnButtonPressed()
	{
		int num = System.Convert.ToInt32(Text) + 1;
		Text = num + "";
	}
}
