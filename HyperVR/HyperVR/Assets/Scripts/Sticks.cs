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
    public Transform pickup;
    public Transform curSushi;
    bool hasItem = false;

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
        if (hasItem) grip = .25f;
        UpperStick.localEulerAngles = new Vector3(startAngle+grip*angle,0,0);

        if (hasItem && Input.GetAxis("TriggerRight") < .5f) {
            curSushi.GetComponent<Sushi>().Release();
            curSushi.transform.parent = null;
            curSushi = null;
            hasItem = false;
        }
    }

    void OnTriggerStay(Collider col){
        if (col.tag =="GrabObject"){
            if (!hasItem && grip >.5f){
                hasItem = true;
                curSushi = col.transform;
                curSushi.parent = pickup;
                curSushi.localPosition = Vector3.zero;
                curSushi.localEulerAngles = new Vector3(0,curSushi.localEulerAngles.y,0);
                curSushi.GetComponent<Sushi>().Grab();
            }
        }
    }


}
