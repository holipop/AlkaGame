using Godot;
using System;

public partial class CombatSpace : Node2D
{
	private Alka pember;
	private Alka aquott;
	private Godot.Button playTurn;
	private Godot.Label turnCounter;

	public override void _Ready()
	{
		base._Ready();

		pember = GetNode<Alka>("Pember");
		aquott = GetNode<Alka>("Aquott");
		ConnectAlka(pember);
		ConnectAlka(aquott);

		playTurn = GetNode<Godot.Button>("PlayTurn");
		turnCounter = GetNode<Godot.Label>("TurnCounter");
		playTurn.Disabled = true;
		playTurn.Pressed += PlayTurnPressed;
	}
	private void ConnectAlka(Alka buny) => buny.Connect("SubmitMove", new Callable(this, "OnSubmitMove"));
	private void OnSubmitMove()
	{
		GD.Print("Submitted move!");
		CheckSubmits(pember, aquott);
	}
	private void CheckSubmits(Alka buny, Alka soft)
	{
		bool bunySubmitted = buny.GetNode<Godot.Button>("Submit").Disabled == true;
		bool softSubmitted = soft.GetNode<Godot.Button>("Submit").Disabled == true;

		if (bunySubmitted && softSubmitted)
		{
			playTurn.Disabled = false;
		}
	}
	private void PlayTurnPressed()
	{
		int counter = System.Convert.ToInt32(turnCounter.Text) + 1;
		turnCounter.Text = counter + "";

		playTurn.Disabled = true;

		pember.GetNode<Godot.Button>("Submit").Disabled = false;
		aquott.GetNode<Godot.Button>("Submit").Disabled = false;

		GD.Print("PlayTurn pressed!");
	}
}
