using Godot;
using System;

public partial class BattleEntity : Node2D
{
    private int id;
	private Stat health;
    private Stat mana;
    private Stat speed;
    private Stat attack;
    private Stat defense;
    private string type;
    private Move[] moves = new Move[4];

    public BattleEntity(int id, Stat health, Stat mana, Stat speed, Stat attack, Stat defense, string type, Move[] moves)
    {
        this.id = id;
        this.health = health;
        this.mana = mana;
        this.speed = speed;
        this.attack = attack;
        this.defense = defense;
        this.type = type;
        this.moves = moves;
    }

    public int getHealth()
    {
        return this.health.getValue();
    }
    public int getMana()
    {
        return this.mana.getValue();
    }
}