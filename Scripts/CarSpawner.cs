using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    [SerializeField] public GameObject[] DifferentCar;
    private GameObject CurrentCar = null;
    private GameObject [] CarList = null;
    public float pace = 0;
    public float rotationSpeed = 30.0f;
    public Vector3 SpawnPoint ;
    private bool isRotating = false;
    private bool isPace = false;
    private int currentCarIndex = 0;  // Keep track of the number of cars spawned
    private int maxCars = 10;

    // Start is called before the first frame update
    void Start()
    {
        CarList = new GameObject[maxCars];
        CurrentCar = Instantiate(DifferentCar[Random.Range(0,2)]);
        
        
    }

    // Update is called once per frame
    void Update()
    { 
        if(CurrentCar != null && 
                                 CurrentCar.GetComponent<Car>() != null && CurrentCar.GetComponent<Car>().isCollided){
            GameObject CarSpawn = DifferentCar[Random.Range(0,2)];
            CurrentCar = Instantiate(CarSpawn);
            isPace = false;

        }
        if(isPace && CurrentCar != null && !CurrentCar.GetComponent<Car>().isCollided ){
            CurrentCar.GetComponent<Rigidbody>().velocity = new Vector3(0,0,pace);

        }
        if (isRotating && CurrentCar != null)
        {
            CurrentCar.transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
            CurrentCar.GetComponent<Rigidbody>().velocity = new Vector3(0,0,pace);
            Debug.Log(pace);
        }


        
    }


    public void ToggleCarRotation()  // Public method to be called by the Event Trigger
    {
        isRotating = !isRotating;    // Toggle rotation state
    }
    public void TogglePace(){
        isPace = true;
    }
}
