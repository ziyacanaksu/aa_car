using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Car : MonoBehaviour
{
    //[SerializeField]  float pace;
    [SerializeField] GameObject Count;
    [SerializeField] GameObject pace;
    public bool isCollided;
    public Vector3 pointOfRotation = Vector3.zero; //arabanın çarpınca dönüceği eksen

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //GetComponent<Rigidbody>().velocity = new Vector3(0,0, pace);
        if(isCollided){
            //Rotate scriptAReference = park.GetComponent<Rotate>();
            //float speed = scriptAReference.RotationSpeed;
            //Direction = scriptAReference.transform.TransformDirection(Vector3.up); // Get Object A's local Y axis in world space
            transform.RotateAround( pointOfRotation, Vector3.up, 20*Time.deltaTime);// can't use scene reference with prefabs so i will assume it as a constant parking place


        }
    }
    private void OnTriggerEnter(Collider other){
        if (other.CompareTag("Target")){
            
            //pace = 0;
            //GetComponent<Rigidbody>().isKinematic = true;    Burda bir sorunumuz var ...
            isCollided = true;
  

        }
        if(other.CompareTag("Finish")){
            //pace=0;
            SceneManager.LoadScene("MainMenu");
        }
       

    }

    
}
