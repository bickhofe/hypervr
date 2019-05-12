using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sticks : MonoBehaviour
{
    [Range(0f,1f)]
    public float grip = 0;

    public float startAngle;
    public float angle;

    public Transform UpperStick;
    public Transform LowerStick;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UpperStick.localEulerAngles = new Vector3(startAngle+grip*angle,0,0);
    }
}
