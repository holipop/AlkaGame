using Godot;
using System;

public partial class Counter : Label
{

	private Button button;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		ConnectTestSignal();
	}

	public void OnButtonPressed()
	{
		int num = System.Convert.ToInt32(Text) + 1;
		Text = num + "";
	}
	
	public void ConnectTestSignal()
	{
		button = GetNode<Button>("../Button");
		button.Connect("TestSignal", new Callable(this, "OnTestSignal"));
		button.EmitSignal("TestSignal");
	}
	public void OnTestSignal()
	{
		GD.Print("Recieved Test Signal!");
	}
}
