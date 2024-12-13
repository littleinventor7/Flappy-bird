using UnityEngine;

public class BSCRIPT : MonoBehaviour
{
    public Rigidbody2D myrigibody;
    public float flapstr;
    public LogicMScript logic;
    public bool birdisalive = true;
        void Start()
    {
       logic = GameObject.FindGameObjectWithTag("logic").GetComponent<LogicMScript>();
    }

   
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)== true && birdisalive == true){
        myrigibody.linearVelocity = Vector2.up * flapstr;}
        if(transform.position.y >= 12.7 || transform.position.y <= -12.7){
            logic.gameover();
       birdisalive = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D Collision){
       logic.gameover();
       birdisalive = false;
    }
}
