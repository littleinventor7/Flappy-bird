using UnityEngine;

public class pipespScript : MonoBehaviour
{
   public GameObject pipe;
   public float sprate = 3;
   private float timer= 0;
   public float hos=10;
    void Start()
    {
         sppipe();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer <sprate){
            timer += Time.deltaTime;
        }
        else{
            sppipe();
            timer =0;
        }
    }
    void sppipe(){
        float lowpoint = transform.position.y - hos;
        float highpoint = transform.position.y + hos;

        Instantiate(pipe,new Vector3(transform.position.x,Random.Range(lowpoint,highpoint),0), transform.rotation );

    }
}
