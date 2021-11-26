using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private Rigidbody RB;
    public float moveSpeed;

    public PlayerController thePlayer;



    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody>();
        thePlayer = FindObjectOfType<PlayerController>(thePlayer);
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(thePlayer.transform.position);
    }


    void FixedUpdate()
    {
        RB.velocity = (transform.forward * moveSpeed);

    }
}
