using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Collectibles : MonoBehaviour
{
    public Tilemap destructableTilemap;
    public PlayerController Player;
    [SerializeField] private bool red;
    [SerializeField] private bool yellow;
    [SerializeField] private bool blue;
    private int nothing;
    private int ground;

    private string myColour;

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

    private void Update() {
        findColour();
    }

    private void Start() {
        destructableTilemap = GetComponent<Tilemap>();

    }
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Player" && Player.currentColour != myColour){
            Vector3 hitPosition = Vector3.zero;
            foreach (ContactPoint2D hit in other.contacts)
            {
                hitPosition.x = hit.point.x + 0.05f * hit.normal.x;
                hitPosition.y = hit.point.y + 0.05f * hit.normal.y;
                destructableTilemap.SetTile(destructableTilemap.WorldToCell(hitPosition), null);
                
            }
        }

        else{
            Debug.Log("you two are the same colour");
        }
    }

}
