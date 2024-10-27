using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    public PlayerController playerController;

    public MeshRenderer meshRenderer;
    public CapsuleCollider capsuleCollider;
    void Start()
    {
        
    }
    void Update() => transform.localEulerAngles = new Vector3(transform.localEulerAngles.x,
                                                 transform.localEulerAngles.y + 20 * Time.deltaTime,
                                                 transform.localEulerAngles.z);

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            playerController.zebranepunkty++;
            Debug.Log(playerController.zebranepunkty);

            Destroy(this.gameObject);
        }
        
    }
 



}