using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    private const double V= 2.17;
    public GameObject Samus;
    private Vector3 offset = new Vector3(3, (float)V, -7);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = Samus.transform.position + offset;
    }
}
