using UnityEngine;
using UnityEngine.PlayerLoop;

public class pipeScript : MonoBehaviour
{
   public float movespeed = 5;
   public float deadz = -40;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < deadz){
            Destroy(gameObject);
        }
        transform.position += Vector3.left * movespeed ;
       // transform.position *= Time.deltaTime;
    }
}
