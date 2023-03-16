using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetPassCard : MonoBehaviour
{
    public GameObject doorSwitch;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            gameObject.SetActive(false);
            doorSwitch.SendMessage("ActivateSwitch");

        }
    }
}
