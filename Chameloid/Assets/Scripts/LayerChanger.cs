using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class LayerChanger : MonoBehaviour
{
    public PlayerController Player;
    [SerializeField] private bool red;
    [SerializeField] private bool yellow;
    [SerializeField] private bool blue;
    private int nothing;
    private int ground;

    private string myColour;
    // Start is called before the first frame update
    void Start()
    {
        int nothing = LayerMask.NameToLayer("Default");
        int ground = LayerMask.NameToLayer("Ground");
    }

    private void findColour(){
        if (red == true){
            myColour = "red";
        }
        else if (yellow == true){
            myColour = "yellow";
        }
        else if (blue == true){
            myColour = "blue";
        }
    }

    // Update is called once per frame
    void Update()
    {
        findColour();
        if(Player.currentColour == myColour){
            this.gameObject.layer = 6;
        }
        else{
            this.gameObject.layer = 0;
        }
    }
}
