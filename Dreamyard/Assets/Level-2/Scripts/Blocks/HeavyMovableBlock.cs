using UnityEngine;

public class HeavyMovableBlock : MonoBehaviour
{   
    public shape_changer shape_Changer;
    public Special_moves special_Moves;

    public Rigidbody2D BlockBody;

    // Start is called before the first frame update
    void Start()
    {
        BlockBody.constraints = RigidbodyConstraints2D.FreezeAll;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collider){
        if (collider.gameObject.CompareTag("Player") && shape_Changer.isSquare && special_Moves.SpecialCharged){
            BlockBody.constraints =RigidbodyConstraints2D.None;
            BlockBody.constraints = RigidbodyConstraints2D.FreezeRotation;
        }
    }

    void OnCollisionExit2D(Collision2D collider){
        if (collider.gameObject.CompareTag("Player")){
        BlockBody.constraints = RigidbodyConstraints2D.FreezeAll;
        }
    }
    
}
