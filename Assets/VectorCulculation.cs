using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class VectorCulculation : MonoBehaviour
{
    public Transform basetarget;
    public Transform target1;
    ///public Transform target2;
    public Text warning;
    public float badangle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetDir1 = target1.position - basetarget.position; 
        ///Vector3 targetDir2 = target2.position - basetarget.position;
        float angle1 = Vector3.Angle(targetDir1,basetarget.up); 
        ///float angle2 = Vector3.Angle(targetDir2, basetarget.up);
            warning.enabled = angle1  > badangle;
    }
}
