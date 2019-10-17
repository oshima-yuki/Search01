using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateEcho : MonoBehaviour
{
    // Start is called before the first frame update
    void Update()
    {
		transform.localPosition=Vector3.Lerp(transform.localPosition,new Vector3(3,0,0),Time.deltaTime * 1);
		transform.localScale = Vector3.Lerp(transform.localScale,new Vector3(3,3,3),Time.deltaTime * 3);
    }
		
}
