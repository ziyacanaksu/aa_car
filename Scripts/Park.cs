using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Park : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float RotateSpeed;
    [SerializeField] Vector3 RotationDirection = new Vector3();
  

    // Update is called once per frame
    void Update()
    {
      transform.Rotate(RotateSpeed*RotationDirection*Time.deltaTime);
    }
}
