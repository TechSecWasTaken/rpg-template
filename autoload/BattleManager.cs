using Godot;
using Godot.Collections;

public partial class BattleManager : Node
{
    public static BattleManager instance {get; private set;}

    public override void _Ready() { instance = this; }

    public Dictionary party_members = new Dictionary(); 
    /* 
        {
            "Player" : {
                "Skills": {
                    "Fireball": {
                        "Cost": 10,
                        "Method": () => {
                            // What the skill does here.
                        }
                    }
                },
                HP: 100,
                Mana: 50,
            },
        } 
    */

    public Dictionary current_enemies = new Dictionary();
    public Dictionary options = new Dictionary();
    public Dictionary items = new Dictionary();
}
