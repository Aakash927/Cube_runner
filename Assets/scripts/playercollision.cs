using UnityEngine;

public class playercollision : MonoBehaviour
{
    public plymovement movement;
    // Start is called before the first frame update
    void OnCollisionEnter(Collision info)
    {
        if(info.collider.name == "Cylinder" )
        {
            movement.enabled = false;
        }
         
    }
}
