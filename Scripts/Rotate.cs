using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    // Start is called before the first frame update

    public float RotationSpeed;
    public Vector3 RotationDirection = new Vector3();
  

    // Update is called once per frame
    void Update()
    {
      transform.Rotate(RotationSpeed*RotationDirection*Time.deltaTime);
    }
}
