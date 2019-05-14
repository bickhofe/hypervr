using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sticks : MonoBehaviour
{
    [Range(0f,1f)]
    public float grip = 0;

    public float startAngle;
    public float angle;

    public Transform HandController;
    public Transform UpperStick;
    public Transform LowerStick;
    // Start is called before the first frame update
    void Start()
    {
        transform.parent = HandController;
        transform.localPosition = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        grip = Input.GetAxis("TriggerRight")*1.25f;
        if (grip > 1) grip = 1;
        UpperStick.localEulerAngles = new Vector3(startAngle+grip*angle,0,0);
    }
}
